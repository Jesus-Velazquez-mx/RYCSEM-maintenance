Public Class FVPOS
    Dim Trans As String = "05"
    Dim WithEvents tDetalle As DS_FVPOS.detalleDataTable
    Dim pIva As Decimal = 0

    Dim UsuarioSesion As String
    Dim nombreUsuario As String


    Public Sub New(usuario As String)

        ' This call is required by the designer.
        InitializeComponent()
        UsuarioSesion = usuario
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FVPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.DS_FVPOS.condiciones_pago.Addcondiciones_pagoRow("", "", "")
        Me.SdaCondicionesPago.Fill(Me.DS_FVPOS.condiciones_pago)
        Me.cmbCP.SelectedValue = ""
        tDetalle = Me.DS_FVPOS.detalle
        Me.pIva = Help.obtieneDato("SELECT dbo.ObtenerValor('', 'iva')")
        nombreUsuario = Help.obtieneDato("SELECT nombre + ' ' + ap_materno from usuarios where usuario = '" & UsuarioSesion & "'")
        Me.habilita(False)
    End Sub

    Private Sub nuevaVenta()

        Me.cmbCP.SelectedValue = "01"
        Me.txtCodCte.Text = "PG" 'publico general
        Me.txtCodCte_KeyDown(Me.txtCodCte, New KeyEventArgs(Keys.Enter))
        tDetalle = Me.DS_FVPOS.detalle
        Me.txtFolio.Text = Help.generaFolio(Me.sqlConn, Me.Trans.Trim)
        Me.TxtCant.Text = 1
        Me.txtArticulo.Focus()
    End Sub

    Private Sub habilita(valor As Boolean)
        Help.SetAll(Me, "Enabled", valor, "Textbox")
        Help.SetAll(Me, "Enabled", valor, "ComboBox")
        Help.SetAll(Me, "Enabled", valor, "Button")
        Help.SetAll(Me, "Enabled", valor, "DateTimePicker")
        Me.btnCancelarVta.Enabled = Not valor
        Me.btnMovsCaja.Enabled = True
        Me.btnCorteCaja.Enabled = True
        Me.BtnAbonos.Enabled = True
        Me.btnNuevo.Enabled = Not valor
        Me.numDescPorc.Enabled = valor
        Me.btnImprimir.Enabled = True
        Me.btnConsultaInventario.Enabled = True
        Me.txtFolio.Enabled = Not valor
    End Sub

    Private Sub traerCliente()
        Me.DS_FVPOS.clientes.Clear()
        Me.sdaCliente.SelectCommand.Parameters("@cod_cte").Value = Me.txtCodCte.Text.Trim
        If Me.sdaCliente.Fill(Me.DS_FVPOS.clientes) = 0 Then
            MsgBox("Ingrese un cliente válido", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub traerArticulo()
        Me.DS_FVPOS.articulos.Clear()
        Me.sdaArticulo.SelectCommand.Parameters("@cod_art").Value = Me.txtArticulo.Text.Trim
        If Me.sdaArticulo.Fill(Me.DS_FVPOS.articulos) = 0 Then
            MsgBox("Ingrese un articulo válido", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Help.obtieneDato("SELECT dbo.ObtenerValor('" & Me.txtArticulo.Text.Trim & "', '01')") = 0 Then
            MsgBox("No hay existencia del producto ingresado.", MsgBoxStyle.Information)
            Me.txtArticulo.Focus()
            Exit Sub
        End If
        Me.AgregaArticulo()
        Me.countArts()
    End Sub
    Private Sub AgregaArticulo()
        If Me.ProductoAgregado(Me.DS_FVPOS.articulos(0).cod_art.Trim) Then Exit Sub
        Dim RowD As DS_FVPOS.detalleRow
        RowD = Me.DS_FVPOS.detalle.NewRow
        With Me.DS_FVPOS.articulos(0)
            RowD.cod_art = .cod_art
            RowD.descripcion = .descripcion
            RowD.precio = .precio
            RowD.unidad = "PZA"
            RowD.cantidad = Me.TxtCant.Text.Trim
            RowD.importe = RowD.precio * RowD.cantidad
            RowD.iva = RowD.importe * pIva
            RowD.total = RowD.importe + RowD.iva
            'RowD.ieps = 0
            'RowD.porc_descuento = 0
            'RowD.importe_descuento = 0
            'Dim img As Byte() = .imagen
            'If Not IsDBNull(.imagen) Then
            If Not .IsimagenNull Then
                RowD.imagen = .imagen
            End If

            'End If
            RowD.nombre_imagen = .nombre_imagen
        End With
        Me.DS_FVPOS.detalle.AdddetalleRow(RowD)
        Me.BindingContext(Me.dvArticulos).Position = Help.dataViewPos(Me.dvArticulos, RowD.cod_art.Trim)
        Me.muestraImagen()
        Me.Calcula()
        Me.dgArticulos.CurrentCell = Me.dgArticulos(3, Me.DS_FVPOS.detalle.Count - 1)
    End Sub

    Private Sub muestraImagen()
        Dim pos As Integer = Me.BindingContext(Me.dvArticulos).Position
        If pos < 0 Then
            Help.Imagen(Nothing, Me.pbImagen, True)
        Else
            Help.Imagen(Me.dvArticulos(pos)!imagen, Me.pbImagen, True)
        End If
    End Sub

    Private Function ProductoAgregado(ByVal producto As String) As Boolean
        For Each r As DS_FVPOS.detalleRow In Me.DS_FVPOS.detalle.Rows
            If r.cod_art.Trim = producto.Trim Then
                'Me.bandRef = False
                If MsgBox("Este articulo ya está agregado. Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Return True
                End If
                r.cantidad += 1
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub tDetalle_Columnging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tDetalle.ColumnChanging
        If e.Column Is tDetalle.cantidadColumn Then
            If Me.bandCalculando Then Exit Sub
            If e.ProposedValue Is Nothing Then e.ProposedValue = 1 'Me.Calcula()
            If Not IsNumeric(e.ProposedValue) Then e.ProposedValue = 1
        End If
    End Sub
    Private Sub tDetalle_Columnged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tDetalle.ColumnChanged
        'If e.Column Is tDetalle.cantidadColumn Then
        '    ' Me.Calcula()
        'End If
        If Me.bandCalculando Then Exit Sub
        Calcula()
        Me.countArts()
    End Sub
    Dim bandCalculando As Boolean = False
    Private Sub Calcula()
        Dim imp As Decimal = 0, desc As Decimal = 0, iva As Decimal = 0, tot As Decimal = 0
        For i As Integer = 0 To Me.DS_FVPOS.detalle.Count - 1
            With Me.DS_FVPOS.detalle(i)
                Me.bandCalculando = True
                .importe = .precio * .cantidad
                imp += .importe
                .iva = .importe * pIva
                .total = .importe + .iva
                iva += .iva
                'desc += .importe_descuento
                tot += .total
            End With
        Next
        Me.numImporte.Value = imp
        Me.numDescuento.Value = Me.numImporte.Value * (Me.numDescPorc.Value / 100)
        Me.numIva.Value = iva
        Me.numTotal.Value = (Me.numImporte.Value - Me.numDescuento.Value) + Me.numIva.Value
        Me.bandCalculando = False

    End Sub

    Private Sub dgArticulos_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgArticulos.DataError
        If e.ColumnIndex = 4 Then
            'If Not IsNumeric(dgArticulos(e.ColumnIndex, e.RowIndex).Value) Then
            dgArticulos(e.ColumnIndex, e.RowIndex).Value = 1
            'End If
            'Dim entero As Integer = dgArticulos(e.ColumnIndex, e.RowIndex).Value
            'Dim dgv As DataGridView = New DataGridView()
            'DataGridView dgv = sender as DataGridView;

        End If
    End Sub

    Private Sub dgArticulos_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgArticulos.CurrentCellChanged
        Me.muestraImagen()
    End Sub
    Dim folioGen As String = ""
    Private Function guardar() As Boolean
        If Me.cmbCP.SelectedValue.ToString.Trim = "02" And Me.txtCodCte.Text.Trim = "PG" Then
            MsgBox("Debe proporcionar cliente para hacer ventas a crédito.", MsgBoxStyle.Information)
            Me.txtCodCte.Focus()
            Return False
        End If
        Dim F As New FPagos(Me.numTotal.Value, Me.txtFolio.Text.Trim)
        If Me.cmbCP.SelectedValue.ToString.Trim = "01" Then
            F.ShowDialog()
            If Not F.Pagado Then Return False
        End If

        Dim Abonos As Decimal = 0
        Dim Saldo As Decimal = 0
        Dim turnoid As Integer = 0
        turnoid = Help.obtieneDato("select top 1 turnoid from turnos where usuario = '" & UsuarioSesion & "' and activo = 1 order by fecha_inicial desc")
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.sqlGuardaNotaDetalle.Transaction = Help.MyTrans
            Me.sqlGuardaNotaVenta.Transaction = Help.MyTrans
            Me.SqlGuardarHistorico.Transaction = Help.MyTrans
            Me.cmdFormasPago.Transaction = Help.MyTrans
            Dim Folio As String = ""
            Folio = Help.generaFolio(Me.sqlConn, Me.Trans.Trim)
            If IsNothing(Folio) Then
                MsgBox("Error al generar folio.", MsgBoxStyle.Information)
                Me.txtFolio.Focus()
                Return False
            End If
            Dim msg As String
            For Each row As DS_FVPOS.detalleRow In Me.DS_FVPOS.detalle.Rows
                ' Me.AyDInventario(Me.sqlConn, "03", row.cantidad, row.cod_art)
                Me.CmdAyDInventario.Transaction = Help.MyTrans
                Me.CmdAyDInventario.Parameters("@Trans").Value = "03"
                Me.CmdAyDInventario.Parameters("@CodArt").Value = row.cod_art
                Me.CmdAyDInventario.Parameters("@Cant").Value = row.cantidad
                Me.CmdAyDInventario.Parameters("@msg").Value = ""
                Me.CmdAyDInventario.ExecuteNonQuery()
                msg = Me.CmdAyDInventario.Parameters("@msg").Value
                With Me.sqlGuardaNotaDetalle
                    .Parameters("@folio").Value = Folio.Trim
                    .Parameters("@transaccion").Value = Me.Trans.Trim
                    .Parameters("@cantidad").Value = row.cantidad
                    .Parameters("@cod_art").Value = row.cod_art.Trim
                    .Parameters("@unidad").Value = row.unidad.Trim
                    .Parameters("@importe").Value = row.importe
                    .Parameters("@iva").Value = row.iva
                    .Parameters("@ieps").Value = 0
                    .Parameters("@porc_descuento").Value = 0
                    .Parameters("@importe_descuento").Value = 0
                    .Parameters("@total").Value = row.total
                    .ExecuteNonQuery()
                End With
            Next
            If Me.cmbCP.SelectedValue.ToString.Trim = "01" Then
                Abonos = Me.numTotal.Value
                Saldo = 0
            Else
                Abonos = 0
                Saldo = Me.numTotal.Value
            End If
            With Me.sqlGuardaNotaVenta
                .Parameters("@folio").Value = Folio.Trim
                .Parameters("@transaccion").Value = Me.Trans.Trim
                .Parameters("@fecha").Value = Now
                .Parameters("@cod_cte").Value = Me.txtCodCte.Text.Trim
                .Parameters("@domicilio_entrega").Value = ""
                .Parameters("@cond_pago").Value = Me.cmbCP.SelectedValue
                .Parameters("@plazo").Value = 0
                .Parameters("@porc_descuento").Value = Me.numDescPorc.Value
                .Parameters("@importe_descuento").Value = Me.numDescuento.Value
                .Parameters("@importe").Value = Me.numImporte.Value
                .Parameters("@iva").Value = Me.numIva.Value
                .Parameters("@ieps").Value = 0
                .Parameters("@saldo").Value = Saldo
                .Parameters("@abonos").Value = Abonos
                .Parameters("@forma_pago").Value = "01"
                .Parameters("@venta_publico").Value = True
                .Parameters("@razon_social").Value = Me.txtNombre.Text.Trim
                .Parameters("@total").Value = Me.numTotal.Value
                .Parameters("@domicilio_cliente").Value = False
                .Parameters("@status").Value = "V"
                .Parameters("@entregado").Value = True
                .Parameters("@enganche").Value = 0
                .Parameters("@porc_enganche").Value = 0
                .Parameters("@notas").Value = Me.TxtNotas.Text.Trim
                .ExecuteNonQuery()
            End With
            For i As Integer = 0 To F.DS_FPagos.docs_formas_pago.Count - 1
                With F.DS_FPagos.docs_formas_pago(i)
                    Me.cmdFormasPago.Parameters("@folio").Value = Folio.Trim
                    Me.cmdFormasPago.Parameters("@transaccion").Value = Me.Trans.Trim
                    Me.cmdFormasPago.Parameters("@forma_pago").Value = .forma_pago
                    Me.cmdFormasPago.Parameters("@monto").Value = .monto
                    Me.cmdFormasPago.ExecuteNonQuery()
                End With
            Next
            With Me.SqlGuardarHistorico
                .Parameters("@turnoid").Value = turnoid
                .Parameters("@fecha").Value = Now
                .Parameters("@folio").Value = Folio.Trim
                .Parameters("@total").Value = Me.numTotal.Value
                .ExecuteNonQuery()
            End With
            folioGen = Folio.Trim
            Help.MyTrans.Commit()
            'MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
            Return False
        Finally
            'Me.deshacer()
            'Me.MToolBar1.Habilita_Guardar()
            If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
            Me.TraerVenta()
            Me.imprimirTicket(Me.folioGen)
        End Try
        Return True
    End Function

    Private Sub FVPOS_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Me.guardar() Then
                Me.limpiar()
            End If
        End If
        If e.KeyCode = Keys.F7 Then
            Dim F As New FCorteCaja(UsuarioSesion)
            F.ShowDialog()
        End If
    End Sub

    Private Sub limpiar()
        Me.DS_FVPOS.detalle.Clear()
        Me.DS_FVPOS.notas_venta.Clear()
        Me.DS_FVPOS.notas_venta_detalle.Clear()
        Me.dtpFecha.Value = Now
        Me.numDescPorc.Value = 0
        Me.numImporte.Value = 0
        Me.numDescuento.Value = 0
        Me.numIva.Value = 0
        Me.numTotal.Value = 0
        Me.numArticulos.Value = 0
        Me.txtCodCte.Text = ""
        Me.TxtCant.Text = 0
        Me.txtFolio.Text = ""
        Me.txtNombre.Text = ""
        Me.cmbCP.SelectedValue = ""
        Me.TxtCant.Text = ""
        Me.txtArticulo.Text = ""
        Me.TxtNotas.Text = ""
        Me.countArts()
        Me.habilita(False)
    End Sub

    Private Sub countArts()
        If Me.DS_FVPOS.detalle.Count = 0 Then
            Me.numArticulos.Value = 0
        Else
            Me.numArticulos.Value = Me.DS_FVPOS.detalle.Compute("sum(cantidad)", "")

        End If
    End Sub

    Private Sub FVPOS_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.txtArticulo.Focus()
    End Sub

    Private Function valida() As Boolean
        If Me.DS_FVPOS.detalle.Count = 0 Then
            MsgBox("No hay artículos ingresados", MsgBoxStyle.Information)
            Return False
        End If

        Return True
    End Function

    Private Sub LiquidarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidarToolStripMenuItem.Click
        If valida() Then
            If Me.guardar() Then
                Me.limpiar()
            End If
        End If

    End Sub

    Private Sub ReimprimirTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReimprimirTicketToolStripMenuItem.Click
        If Me.DS_FVPOS.notas_venta_detalle.Count = 0 Then Exit Sub
        Help.imprimeReporte("R_FVPOS", Me.DS_FVPOS, Me.Name)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub txtArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.traerArticulo()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("articulos")
            F.ShowDialog()
            Me.txtArticulo.Text = F.codigo
            Me.traerArticulo()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLiquidar.Click
        If Me.guardar() Then
            Me.limpiar()
        End If
    End Sub

    Private Sub btnAD_Click(sender As Object, e As EventArgs) Handles btnAD.Click
        Me.Calcula()
    End Sub

    Private Sub txtCodCte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCte.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.traerCliente()
        ElseIf e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            Me.DS_FVPOS.clientes.Clear()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("clientes")
            F.ShowDialog()
            Me.txtCodCte.Text = F.codigo.Trim
            Me.traerCliente()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCorteCaja.Click
        Dim F As New FCorteCaja(UsuarioSesion)
        F.ShowDialog()
        If F.finalizoTurno Then Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnConsultaInventario.Click
        Dim F As New FI003(Me.txtArticulo.Text.Trim)
        F.Show()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.limpiar()
        Me.habilita(True)
        Me.nuevaVenta()
    End Sub

    Private Sub btnDeshacer_Click(sender As Object, e As EventArgs) Handles btnDeshacer.Click
        Me.limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim pos As Integer = 0
        pos = Me.BindingContext(Me.dvArticulos).Position
        If pos < 0 Then Exit Sub
        Dim art As String = Me.dvArticulos(pos)!cod_art.ToString.Trim
        For i As Integer = Me.dvArticulos.Count - 1 To 0 Step -1
            With Me.dvArticulos(i)
                If !cod_art.Trim = art.Trim Then
                    .Delete()
                    Exit For
                End If
            End With
        Next
        Me.DS_FVPOS.detalle.AcceptChanges()
        Me.countArts()
        Me.Calcula()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = "Caja 1: " & nombreUsuario & "    " & Now.ToString("dd/MM/yyyy") & " " & Now.ToString("hh:mm:ss")
    End Sub

    Private Sub imprimirTicket(Folio As String)
        Help.imprimeReporte("R_Ticket_MovilMX", Me.DS_FVPOS, Me.Name)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Help.imprimeReporte("R_Ticket_MovilMX", Me.DS_FVPOS, Me.Name)
    End Sub

    Private Sub AyDInventario(ByVal conexion As SqlClient.SqlConnection, Trans As String, cantidad As Decimal, art As String, Optional Tipo As String = "M")
        Try
            Dim msg As String = ""
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            If Tipo.Trim = "M" Then Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.CmdAyDInventario.Transaction = Help.MyTrans
            Me.CmdAyDInventario.Parameters("@Trans").Value = Trans
            Me.CmdAyDInventario.Parameters("@CodArt").Value = art.Trim
            Me.CmdAyDInventario.Parameters("@Cant").Value = cantidad
            Me.CmdAyDInventario.Parameters("@msg").Value = ""
            Me.CmdAyDInventario.ExecuteNonQuery()
            msg = Me.CmdAyDInventario.Parameters("@msg").Value
            Help.MyTrans.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            If Tipo.Trim = "M" Then If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
        End Try
    End Sub

    Private Sub btnMovsCaja_Click(sender As Object, e As EventArgs) Handles btnMovsCaja.Click
        Dim F As New FMovCaja(UsuarioSesion)
        F.ShowDialog()
    End Sub

    Private Sub txtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolio.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtFolio.Text.Trim <> "" Then
            Me.ConsultarVenta()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("notas_venta")
            F.ShowDialog()
            Me.txtFolio.Text = F.codigo
        End If
    End Sub

    Private Function TraerVenta() As Boolean
        Me.DS_FVPOS.notas_venta.Clear()
        Me.DS_FVPOS.notas_venta_detalle.Clear()
        Me.DS_FVPOS.documentos_formas_pago.Clear()
        Me.sdaTraerVenta.SelectCommand.Parameters("@folio").Value = Me.txtFolio.Text.Trim
        Me.sdaTraerVenta.SelectCommand.Parameters("@transaccion").Value = Me.Trans
        If Me.sdaTraerVenta.Fill(Me.DS_FVPOS) = 0 Then
            MsgBox("Folio ingresado no valido.", MsgBoxStyle.Information)
            Me.txtFolio.Focus()
            Return False
        End If
        Me.sdaTraerVentaDetalle.SelectCommand.Parameters("@folio").Value = Me.txtFolio.Text.Trim
        Me.sdaTraerVentaDetalle.SelectCommand.Parameters("@transaccion").Value = Me.Trans
        Me.sdaTraerVentaDetalle.Fill(Me.DS_FVPOS.notas_venta_detalle)
        Me.sdaDocFormasPago.SelectCommand.Parameters("@Folio").Value = Me.txtFolio.Text.Trim
        Me.sdaDocFormasPago.SelectCommand.Parameters("@Transaccion").Value = Me.Trans
        Me.sdaDocFormasPago.Fill(Me.DS_FVPOS.documentos_formas_pago)
        Return True
    End Function

    Private Sub ConsultarVenta()
        Me.DS_FVPOS.detalle.Clear()
        If Not Me.TraerVenta() Then Exit Sub
        For Each row As DS_FVPOS.notas_venta_detalleRow In Me.DS_FVPOS.notas_venta_detalle.Rows
            Me.DS_FVPOS.detalle.AdddetalleRow(row.cod_art, row.descripcion, row.importe, "", row.cantidad, Nothing, "", row.importe, row.total, row.iva)
        Next
        Me.dtpFecha.Value = Me.DS_FVPOS.notas_venta(0).fecha
        Me.txtCodCte.Text = Me.DS_FVPOS.notas_venta(0).cod_cte
        Me.txtNombre.Text = Me.DS_FVPOS.notas_venta(0).razon_social
        Me.cmbCP.SelectedValue = Me.DS_FVPOS.notas_venta(0).cond_pago
        Me.TxtNotas.Text = Me.DS_FVPOS.notas_venta(0).notas
        Me.numTotal.Value = Me.DS_FVPOS.notas_venta(0).total
    End Sub

    Private Sub txtFolio_TextChanged(sender As Object, e As EventArgs) Handles txtFolio.TextChanged
        If Me.txtFolio.Text.Trim = "" Then Me.limpiar()
    End Sub

    Private Sub btnCancelarVta_Click(sender As Object, e As EventArgs) Handles btnCancelarVta.Click
        If Me.txtFolio.Text.Trim <> "" Then
            Try
                Dim msg As String = ""
                If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
                Help.MyTrans = Me.sqlConn.BeginTransaction
                Me.SqlCancelarVenta.Transaction = Help.MyTrans
                Me.SqlCancelarVenta.Parameters("@Folio").Value = Me.txtFolio.Text.Trim
                Me.SqlCancelarVenta.ExecuteNonQuery()
                Help.MyTrans.Commit()
                MsgBox("Nota de venta cancelada exitosamente", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
                Help.MyTrans.Rollback()
            Finally
                If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
            End Try
        Else
            MsgBox("Debe ingresar el folio de la nota a cancelar.", MsgBoxStyle.Information)
            Me.txtFolio.Focus()
        End If
    End Sub

    Private Sub BtnAbonos_Click(sender As Object, e As EventArgs) Handles BtnAbonos.Click
        Dim F As New FAbonos()
        F.ShowDialog()
    End Sub

    Private Sub cmbCP_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCP.SelectionChangeCommitted
        If Me.cmbCP.SelectedValue.ToString.Trim = "02" And Me.txtCodCte.Text.Trim = "PG" Then
            MsgBox("Debe proporcionar cliente para hacer ventas a crédito.", MsgBoxStyle.Information)
            Me.txtCodCte.Focus()
        End If
    End Sub

    Private Sub sdaCliente_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs) Handles sdaCliente.RowUpdated

    End Sub
End Class