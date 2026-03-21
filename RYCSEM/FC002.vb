Public Class FC002
    Dim trans As String = "06"
    Dim row As DS_FC002.abonosRow
    Private Sub FC002_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Maximized
        Me.DS_FC002.formas_pago.Addformas_pagoRow("", "", "", "")
        Me.sdaFormaPago.Fill(Me.DS_FC002.formas_pago)
        Me.cbFormaPago.SelectedIndex = 0
        Me.Habilita(False)
    End Sub
    Private Sub MToolBar1_ButtonClick(indice As Integer) Handles MToolBar1.ButtonClick
        Select Case indice
            Case 6 'nuevo
                If Not validarLiquidado() Then Exit Sub
                Me.nuevo()
            Case 7 'modificar
                If Not validarLiquidado() Then Exit Sub
                If Me.DS_FC002.abonos.Count = 0 Then Exit Sub
                Me.Habilita(True)
                Me.dgAbonos.Enabled = False
                Me.MToolBar1.Band = "M"
            Case 9 'guardar
                If Me.validar() Then Me.guardar()
            Case 10 'deshacer
                Me.deshacer()
            Case 12 'Imprimir
                'Help.imprimeReporte("R_FC002", Me.DS_FC002, Me.Name)
        End Select
    End Sub
    Private Sub guardar()
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.sdaTraerAbonos.InsertCommand.Transaction = Help.MyTrans
            Me.sdaTraerAbonos.UpdateCommand.Transaction = Help.MyTrans
            ' Me.sdaTraerAbonos.DeleteCommand.Transaction = Help.MyTrans
            Me.sqlActFecha.Transaction = Help.MyTrans
            Me.sqlActSaldo.Transaction = Help.MyTrans
            Me.sqlLiquidar.Transaction = Help.MyTrans
            If Me.MToolBar1.Band = "N" Then
                Me.row.folio = Help.generaFolio(Me.sqlConn, Me.trans)
                Me.row.transaccion = Me.trans
                Me.row.forma_pago = Me.cbFormaPago.SelectedValue.ToString.Trim
                Me.row.importe = Me.numSugerido.Value
                Me.row.total = Me.numImporte.Value
                Me.row.folio_doc = Me.txtFolio.Text.Trim
                Me.row.transaccion_doc = "05"
                Me.row.poc_interes_moratorio = Me.numPorcMor.Value
                Me.row.interes_moratorio = Me.numIntereses.Value
                Me.row.cod_cte = Convert.ToInt64(Me.txtCodCte.Text.Trim)
                If Me.chkLiquidar.Checked Then
                    'Actualiza Liquidar
                    Me.sqlLiquidar.Parameters("@folio").Value = Me.txtFolio.Text.Trim
                    Me.sqlLiquidar.Parameters("@transaccion").Value = "05"
                    Me.sqlLiquidar.ExecuteNonQuery()
                End If
            End If


            Me.BindingContext(Me.dvAbonos).EndCurrentEdit()
            Me.sdaTraerAbonos.Update(Me.DS_FC002.abonos)
            If Me.DS_FC002.abonoPendiente.Count > 0 Then
                Me.sqlActFecha.Parameters("@id").Value = Me.DS_FC002.abonoPendiente(0).idPlanPagoDetalle
                Me.sqlActFecha.ExecuteNonQuery()
            End If
            Me.sqlActSaldo.Parameters("@folio").Value = Me.txtFolio.Text.Trim
            Me.sqlActSaldo.Parameters("@transaccion").Value = "05"
            Me.sqlActSaldo.Parameters("@abono").Value = Me.numImporte.Value
            Me.sqlActSaldo.ExecuteNonQuery()
            'Me.sqlGuardaAbono.Parameters("transaccion").Value = Me.trans.Trim
            'Me.sqlGuardaAbono.Parameters("@fecha").Value = ""
            'Me.sqlGuardaAbono.Parameters("@forma_pago").Value = ""
            'Me.sqlGuardaAbono.Parameters("@importe").Value = ""
            'Me.sqlGuardaAbono.Parameters("@poc_interes_moratorio").Value = ""
            'Me.sqlGuardaAbono.Parameters("@interes_moratorio").Value = ""
            'Me.sqlGuardaAbono.Parameters("@folio_doc").Value = ""
            'Me.sqlGuardaAbono.Parameters("@transaccion_doc").Value = ""
            'Me.sqlGuardaAbono.Parameters("@cod_cte").Value = ""
            Help.MyTrans.Commit()
            MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
            Me.Habilita(False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally

            Me.numImporte.Minimum = 0
            Me.numImporte.Maximum = 99999999999
            Me.numImporte.Value = 0
            If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
            Me.refrescar()
        End Try
    End Sub
    Private Function validar() As Boolean
        If Not validarLiquidado() Then Return False
        If Me.cbFormaPago.SelectedValue.ToString.Trim = "" Then
            MsgBox("Seleccione una forma de pago", MsgBoxStyle.Information)
            Return False
        End If
        If Me.numImporte.Value = 0 Then
            MsgBox("Ingrese un importe mayor a cero", MsgBoxStyle.Information)
            Return False
        End If
        If Me.numImporte.Value > Me.DS_FC002.abonoPendiente(0).saldo Then
            MsgBox("El abono no puede ser mayor que el saldo de la cuenta. " & vbCrLf & "El saldo pendiente es $" & Me.DS_FC002.abonoPendiente(0).saldo)
            Return False
        End If
        Return True
    End Function
    Private Sub deshacer()
        Me.Habilita(False)
        Me.dgAbonos.Enabled = True

        Me.numImporte.Minimum = 0
        Me.numImporte.Maximum = 99999999999
        Me.numImporte.Value = 0
        Me.MToolBar1.Habilita_Guardar()
        Me.DS_FC002.abonoPendiente.Clear()
        Me.DS_FC002.abonos.Clear()
        Me.DS_FC002.cliente.Clear()
    End Sub
    Private Sub Habilita(ByRef valor As Boolean)
        'Help.SetAll(Me, "Enabled", valor, "Textbox")
        'Help.SetAll(Me, "Enabled", valor, "ComboBox")
        'Help.SetAll(Me, "Enabled", valor, "NumericUpDown")
        Me.txtFolio.Enabled = valor
        Me.numImporte.Enabled = valor
        Me.cbFormaPago.Enabled = valor
        Me.chkLiquidar.Enabled = valor
        Me.txtFolio.Enabled = Not Me.txtFolio.Enabled
    End Sub
    Private Sub nuevo()
        If Me.DS_FC002.abonoPendiente.Count = 0 Then
            Me.MToolBar1.Habilita_Guardar()
            Exit Sub
        End If
        Me.Habilita(True)
        row = Me.DS_FC002.abonos.NewRow
        row.folio = Help.generaFolio(Me.sqlConn, Me.trans.Trim)
        row.forma_pago = ""
        row.importe = 0
        row.interes_moratorio = 0
        row.poc_interes_moratorio = 0
        row.total = 0
        'row.usuario = Help.usuario.Trim
        Me.DS_FC002.abonos.AddabonosRow(row)
        Me.MToolBar1.Habilita_Nuevo()
        Me.numImporte.Focus()
        Me.dgAbonos.Enabled = False
        Me.BindingContext(Me.dvAbonos).Position = Help.dataViewPos(Me.dvAbonos, row.folio.ToString.Trim)
        Me.MToolBar1.Band = "N"
        'Me.txtFolio.Text = row.folio.ToString.Trim
    End Sub
    Private Sub txtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolio.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Me.txtFolio.Text.Trim = "" Then
                MsgBox("Ingrese un folio válido", MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.refrescar()
        End If
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("plan_pagos")
            F.ShowDialog()
            Me.txtFolio.Text = F.codigo.Trim
        End If

    End Sub
    Private Sub refrescar()
        Me.DS_FC002.abonoPendiente.Clear()
        Me.DS_FC002.abonos.Clear()
        Me.DS_FC002.cliente.Clear()
        Me.sdaTraerAbonos.SelectCommand.Parameters("@folio").Value = Me.txtFolio.Text.Trim
        Me.sdaTraerAbonos.SelectCommand.Parameters("@transaccion").Value = "05" 'trans de Nota de Venta
        Me.sdaTraerAbonos.Fill(Me.DS_FC002)
        Me.validarLiquidado()
        If Me.DS_FC002.abonoPendiente.Count > 0 Then
            Me.numImporte.Value = Me.DS_FC002.abonoPendiente(0).total
            Me.numImporte.Minimum = Me.DS_FC002.abonoPendiente(0).total
            Me.numImporte.Maximum = 99999999999
        End If
    End Sub
    Private Function validarLiquidado() As Boolean
        If Me.DS_FC002.cliente.Count > 0 Then
            If Me.DS_FC002.cliente(0).liquidar Then
                MsgBox("Esta cuenta ya está liquidada", MsgBoxStyle.Information)
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub chkLiquidar_CheckedChanged(sender As Object, e As EventArgs) Handles chkLiquidar.CheckedChanged
        If Me.chkLiquidar.Checked Then
            Me.numImporte.Minimum = 0
            Me.numImporte.Maximum = Me.DS_FC002.abonoPendiente(0).saldo
        End If
    End Sub
End Class