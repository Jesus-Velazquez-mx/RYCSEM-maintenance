Public Class FAbonos
    Dim transaccion = "06"
    Dim Band As String = ""
    Dim Saldo As Decimal = 0
    Dim Cte As String = 0

    Private Sub FAbonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Habilita_Guardar()
    End Sub

    Private Sub Habilita_Nuevo()
        Me.btnNuevo.Enabled = False ' Not valor
        Me.btnGuardar.Enabled = True ' valor
        Me.btnDeshacer.Enabled = True 'valor
    End Sub

    Private Sub Habilita_Guardar()
        Me.btnNuevo.Enabled = True ' Not valor
        Me.btnGuardar.Enabled = False ' True ' valor
        Me.btnDeshacer.Enabled = False ' True 'valor
    End Sub

    Private Sub txtFolioVta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolioVta.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtFolioVta.Text.Trim <> "" Then
            Me.TraerVenta(Me.txtFolioVta.Text.Trim)
        ElseIf e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("notas_venta")
            F.ShowDialog()
            Me.txtFolioVta.Text = F.codigo
        End If
    End Sub

    Private Sub TraerVenta(Folio As String)
        Me.DS_FAbonos.Venta.Clear()
        Me.SdaVenta.SelectCommand.Parameters("@Folio").Value = Folio.Trim
        Me.SdaVenta.SelectCommand.Parameters("@Transaccion").Value = "05"
        If Me.SdaVenta.Fill(Me.DS_FAbonos) = 0 Then
            MsgBox("Venta no valida", MsgBoxStyle.Information)
            Me.txtFolioVta.Focus()
            Exit Sub
        End If
        With Me.DS_FAbonos.Venta(0)
            Me.lTotal.Text = "$" + Format(.total_vta, "##,##0.00")
            Me.lAbonos.Text = "$" + Format(.abonos, "##,##0.00")
            Me.lSaldo.Text = "$" + Format(.saldo, "##,##0.00")
            Saldo = .saldo
            Me.txtRazonSocial.Text = .razon_social
            Cte = .cod_cte
        End With
    End Sub

    Private Sub Nuevo()
        If Me.DS_FAbonos.Venta(0).saldo = 0 Then
            MsgBox("La nota de venta ingresada ya esta liquidada.", MsgBoxStyle.Information)
            Me.txtFolioVta.Focus()
            Exit Sub
        End If
        If Me.DS_FAbonos.Venta(0).status.ToString.Trim = "C" Then
            MsgBox("La nota de venta esta cancelada, no se puede abonar.", MsgBoxStyle.Information)
            Me.txtFolioVta.Focus()
            Exit Sub
        End If

        Me.Band = "N"
        Me.txtFolioAbn.Text = Me.obtieneFolio()
        Me.Habilita_Nuevo()
    End Sub

    Private Function obtieneFolio() As String
        Dim Folio As String = ""
        Folio = Help.generaFolio(Me.sqlConn, Me.transaccion.Trim)
        If IsNothing(Folio) Then
            MsgBox("Error al generar folio.", MsgBoxStyle.Information)
            Return ""
        End If
        Return Folio.Trim
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If Me.txtFolioVta.Text.Trim = "" Then
            MsgBox("No ha ingresado el folio de la nota de venta.", MsgBoxStyle.Information)
            Me.txtFolioVta.Focus()
            Exit Sub
        End If
        Me.Nuevo()
    End Sub

    Private Sub Guardar()
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.SqlInsertarAbono.Transaction = Help.MyTrans
            Me.SqlActualizaVta.Transaction = Help.MyTrans
            Me.cmdFormasPago.Transaction = Help.MyTrans
            If Me.Band = "N" Then Me.txtFolioAbn.Text = Me.obtieneFolio()
            With Me.SqlInsertarAbono
                .Parameters("@folio").Value = Me.txtFolioAbn.Text.Trim
                .Parameters("@transaccion").Value = Me.transaccion.Trim
                .Parameters("@fecha").Value = Now
                .Parameters("@importe").Value = Me.numAbono.Value
                .Parameters("@total").Value = Me.numAbono.Value
                .Parameters("@folio_doc").Value = Me.txtFolioVta.Text.Trim
                .Parameters("@transaccion_doc").Value = "05"
                .Parameters("@cod_cte").Value = Cte
                .Parameters("@fecha_abono").Value = Now
                .Parameters("@efectivo").Value = Me.numAbono.Value
                .Parameters("@tarjeta").Value = 0
                .ExecuteNonQuery()
            End With
            With Me.SqlActualizaVta
                .Parameters("@Folio").Value = Me.txtFolioVta.Text.Trim
                .Parameters("@Transaccion").Value = "05"
                .Parameters("@Abono").Value = Me.numAbono.Value
                .ExecuteNonQuery()
            End With
            With Me.cmdFormasPago
                .Parameters("@folio").Value = Me.txtFolioVta.Text.Trim
                .Parameters("@transaccion").Value = "05"
                .Parameters("@forma_pago").Value = "01"
                .Parameters("@monto").Value = Me.numAbono.Value
                .ExecuteNonQuery()
            End With
            Help.MyTrans.Commit()
            MsgBox("Abono registrado exitosamente", MsgBoxStyle.Information)
            Me.Habilita_Guardar()
            Me.TraerAbono()
            Me.ImprimirAbono()
            Me.TraerVenta(Me.txtFolioVta.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Band = "G"
        If Me.numPago.Value = 0 Then
            MsgBox("No ha ingresado pago.", MsgBoxStyle.Information)
            Me.numPago.Focus()
            Exit Sub
        End If
        If Me.validaAbono Then Me.Guardar()
    End Sub

    Private Sub Cambio(Pago As Decimal)
        If Pago = Me.numAbono.Value Then Exit Sub
        Dim cambioTot As Decimal = Pago - Me.numAbono.Value
        Me.lCambio.Text = "$" + cambioTot.ToString.Trim
    End Sub

    Private Function validaAbono() As Boolean
        If Me.numAbono.Value = 0 And Me.Band.ToString.Trim = "N" Then
            MsgBox("No ha ingresado abono.", MsgBoxStyle.Information)
            Me.numAbono.Focus()
            Return False
        End If
        If Me.numAbono.Value > Saldo Then
            MsgBox("El abono ingresado es mayor que el saldo de la nota de venta.", MsgBoxStyle.Information)
            Me.numAbono.Focus()
            Return False
        End If
        If Me.numPago.Value > 0 And (Me.numPago.Value < numAbono.Value) Then
            MsgBox("El pago ingresado es menor que el abono.", MsgBoxStyle.Information)
            Me.numPago.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub numAbono_ValueChanged(sender As Object, e As EventArgs) Handles numAbono.ValueChanged
        Me.lCambio.Text = "$00.00"
        Me.validaAbono()
    End Sub

    Private Sub numPago_ValueChanged(sender As Object, e As EventArgs) Handles numPago.ValueChanged
        Me.lCambio.Text = "$00.00"
        If validaAbono() Then Me.Cambio(Me.numPago.Value)
    End Sub

    Private Sub txtFolioVta_TextChanged(sender As Object, e As EventArgs) Handles txtFolioVta.TextChanged
        If Me.txtFolioVta.Text.Trim = "" Then
            Me.limpiar()
        End If
    End Sub

    Private Sub btnDeshacer_Click(sender As Object, e As EventArgs) Handles btnDeshacer.Click
        Me.limpiar()
        Me.Habilita_Guardar()
    End Sub

    Private Sub limpiar()
        Me.lCambio.Text = "$00.00"
        Me.lTotal.Text = "$00.00"
        Me.lAbonos.Text = "$00.00"
        Me.lSaldo.Text = "$00.00"
        Me.DS_FAbonos.Venta.Clear()
        Me.txtFolioVta.Text = ""
        Me.txtFolioAbn.Text = ""
        Me.numAbono.Value = 0
        Me.numPago.Value = 0
        Me.txtRazonSocial.Text = ""
    End Sub

    Private Sub TraerAbono()
        Me.DS_FAbonos.abonos_clientes.Clear()
        Me.SdaAbono.SelectCommand.Parameters("@Folio").Value = Me.txtFolioAbn.Text.Trim
        Me.SdaAbono.SelectCommand.Parameters("@Transaccion").Value = Me.transaccion
        Me.SdaAbono.Fill(Me.DS_FAbonos.abonos_clientes)
    End Sub

    Private Sub ImprimirAbono()
        Help.imprimeReporte("R_FAbono", Me.DS_FAbonos, Me.Name)
    End Sub
End Class