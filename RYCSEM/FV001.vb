Public Class FV001
    Dim Row As DS_FV001.notas_ventaRow
    Dim RowD As DS_FV001.notas_venta_detalleRow
    Dim rPPD As DS_FV001.plan_pagos_detalleRow
    Dim rPP As DS_FV001.plan_pagosRow
    Dim Trans As String = "05"
    Dim bandRef As Boolean = False
    Dim WithEvents tDetalle As DS_FV001.notas_venta_detalleDataTable
    Private Sub FV001_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.SqlCnn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Maximized
        Me.HabilitaControles(False)
        Me.inicializa()
        tDetalle = Me.DS_FV001.notas_venta_detalle
    End Sub
    Private Sub inicializa()
        Me.SdaCondicionesPago.Fill(Me.DS_FV001.condiciones_pago)
        Me.SdaFormasPago.Fill(Me.DS_FV001.formas_pago)
        Me.SdaTiposPlazo.Fill(Me.DS_FV001.tipos_plazos)
        Me.DS_FV001.plazos.AddplazosRow(0, "")
        Me.DS_FV001.plazos.AddplazosRow(3, "3 Meses")
        Me.DS_FV001.plazos.AddplazosRow(6, "6 Meses")
        Me.DS_FV001.plazos.AddplazosRow(12, "12 Meses")
        Me.DS_FV001.plazos.AddplazosRow(18, "18 Meses")
        Me.DS_FV001.plazos.AddplazosRow(24, "24 Meses")
        Me.cbPlazos.SelectedIndex = 0
    End Sub
    Private Sub MToolBar1_ButtonClick(indice As Integer) Handles MToolBar1.ButtonClick
        Me.MyDataGrid1.Focus()
        Select Case indice
            Case 6 'Nuevo
                Me.Nuevo()
            Case 7 'Modificar
                Me.Modificar()
            Case 9 'Guardar
                Me.Guardar()
            Case 10 'Deshacer
                Me.deshacer()
            Case 12 'Imprimir
            Case 13 'Exportar
        End Select
    End Sub
    Private Sub deshacer()
        'Me.DS_FV001.notas_venta_detalle.RejectChanges()
        Me.DS_FV001.notas_venta.Clear()
        Me.DS_FV001.notas_venta_detalle.Clear()
        Me.cbCondPago.SelectedIndex = 0
        Me.cbFormaPago.SelectedIndex = 0
        Me.cbPlazos.SelectedIndex = 0
        Me.TxtArt.Text = ""
        Me.TxtCliente.Text = ""
        Me.TxtFolio.Text = ""
        Me.TxtDomEntrega.Text = ""
        Me.TxtRazonSocial.Text = ""
        Me.chkDomicCte.Checked = False
        Me.chkVentaPublico.Checked = False
        Me.DS_FV001.plan_pagos_detalle.Clear()
        Me.numDescuento.Value = 0
        Me.numDescGral.Value = 0
        Me.numImporte.Value = 0
        Me.numIVAGral.Value = 0
        Me.numSubtotal.Value = 0
        Me.numTotalGral.Value = 0
        Me.numDescGralPorc.Value = 0
        Me.numEngGral.Value = 0
        Me.HabilitaControles(False)
        Me.MToolBar1.Habilita_Guardar()
    End Sub
    Private Sub HabilitaControles(valor As Boolean)
        Help.SetAll(Me.GroupBox1, "Enabled", valor, "Textbox")
        Help.SetAll(Me.GroupBox1, "Enabled", valor, "ComboBox")
        Help.SetAll(Me.GroupBox1, "Enabled", valor, "MyNumeric")
        Me.DtpFecha.Enabled = valor
        Me.BtnEliminar.Enabled = valor
        Me.TxtFolio.Enabled = Not valor
    End Sub

    Private Sub Nuevo()
        Dim Folio As String = ""
        Folio = Help.generaFolio(Me.SqlCnn, Me.Trans.Trim)
        If IsNothing(Folio) Then
            MsgBox("Error al generar folio.", MsgBoxStyle.Information)
            Me.TxtFolio.Focus()
            Exit Sub
        End If
        Me.TxtFolio.Text = Folio
        Me.HabilitaControles(True)
        Row = Me.DS_FV001.notas_venta.NewRow
        Row.folio = Folio
        Row.transaccion = Me.Trans
        Row.cod_cte = ""
        Row.domicilio_entrega = ""
        Row.cond_pago = ""
        Row.plazo = 0
        Row.porc_descuento = 0
        Row.importe_descuento = 0
        Row.importe = 0
        Row.iva = 0
        Row.ieps = 0
        Row.total = 0
        Row.saldo = 0
        Row.abonos = 0
        Me.DS_FV001.notas_venta.Addnotas_ventaRow(Row)
        Me.MToolBar1.Habilita_Nuevo()
        Me.TxtCliente.Focus()
        Me.cbCondPago.SelectedValue = "01"
        Me.cbPlazos.Enabled = 0

    End Sub

    Private Sub Modificar()

    End Sub

    Private Sub Guardar()
        Try
            If IsNothing(Me.cbFormaPago.SelectedValue) Then Me.cbFormaPago.SelectedIndex = 0
            If Me.SqlCnn.State <> ConnectionState.Open Then Me.SqlCnn.Open()
            Help.MyTrans = Me.SqlCnn.BeginTransaction
            Me.SdaNotasVentaDetalle.DeleteCommand.Transaction = Help.MyTrans
            Me.SdaNotasVentaDetalle.InsertCommand.Transaction = Help.MyTrans
            Me.SdaNotasVentaDetalle.UpdateCommand.Transaction = Help.MyTrans

            Me.SdaNotasVenta.DeleteCommand.Transaction = Help.MyTrans
            Me.SdaNotasVenta.InsertCommand.Transaction = Help.MyTrans
            Me.SdaNotasVenta.UpdateCommand.Transaction = Help.MyTrans

            Me.SdaPlanPagos.DeleteCommand.Transaction = Help.MyTrans
            Me.SdaPlanPagos.InsertCommand.Transaction = Help.MyTrans
            Me.SdaPlanPagos.UpdateCommand.Transaction = Help.MyTrans
            Me.SdaPlanPagosDetalle.DeleteCommand.Transaction = Help.MyTrans
            Me.SdaPlanPagosDetalle.InsertCommand.Transaction = Help.MyTrans
            Me.SdaPlanPagosDetalle.UpdateCommand.Transaction = Help.MyTrans
            If Me.MToolBar1.Band = "N" Then
                Dim Folio As String = ""
                Folio = Help.generaFolio(Me.SqlCnn, Me.Trans.Trim)

                If IsNothing(Folio) Then
                    MsgBox("Error al generar folio.", MsgBoxStyle.Information)
                    Me.TxtFolio.Focus()
                    Exit Sub
                End If
                Me.Row.folio = Folio.Trim
                Me.Row.transaccion = Me.Trans
                Me.Row.fecha = Me.DtpFecha.Value
                Me.Row.cod_cte = Me.TxtCliente.Text.Trim
                Me.Row.razon_social = Me.TxtRazonSocial.Text.Trim
                Me.Row.domicilio_entrega = Me.TxtDomEntrega.Text.Trim
                Me.Row.cond_pago = Me.cbCondPago.SelectedValue.ToString.Trim
                Me.Row.plazo = Me.cbPlazos.SelectedValue.ToString.Trim
                Me.Row.porc_descuento = Me.numDescuento.Value
                Me.Row.importe_descuento = (Me.numImporte.Value - Me.numDescGral.Value) * (Me.numDescuento.Value / 100)
                Me.Row.importe = Me.numImporte.Value
                Me.Row.iva = Me.numIVAGral.Value
                Me.Row.ieps = 0
                Me.Row.total = Me.numTotalGral.Value
                Me.Row.saldo = Me.numResto.Value
                Me.Row.abonos = Me.numEngGral.Value
                Me.Row.forma_pago = Me.cbFormaPago.SelectedValue.ToString.Trim
                Me.Row.venta_publico = Me.chkVentaPublico.Checked

                'Me.RowD.folio = Folio.Trim
                For Each rd As DS_FV001.notas_venta_detalleRow In Me.DS_FV001.notas_venta_detalle.Rows
                    rd.folio = Folio.Trim
                Next
                If Me.DS_FV001.plan_pagos.Count > 0 Then
                    Me.rPP.folio = Folio.Trim
                    For Each rpd As DS_FV001.plan_pagos_detalleRow In Me.DS_FV001.plan_pagos_detalle.Rows
                        rpd.folio = Folio.Trim
                    Next
                End If

            End If

            Me.BindingContext(Me.dvNotaVenta).EndCurrentEdit()
            Me.BindingContext(Me.dvNotaVentaDetalle).EndCurrentEdit()
            Me.BindingContext(Me.DvArticulos).EndCurrentEdit()
            'plan de pagos
            Me.SdaPlanPagosDetalle.Update(Me.DS_FV001.plan_pagos_detalle)
            Me.SdaPlanPagos.Update(Me.DS_FV001.plan_pagos)
            'detalle
            Me.SdaNotasVentaDetalle.Update(Me.DS_FV001.notas_venta_detalle)
            Me.SdaNotasVenta.Update(Me.DS_FV001.notas_venta)
            Help.MyTrans.Commit()
            MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            Me.deshacer()
            Me.MToolBar1.Habilita_Guardar()
            If Me.SqlCnn.State <> ConnectionState.Closed Then Me.SqlCnn.Close()
        End Try

    End Sub


    Private Sub imgArticulo_Click(sender As Object, e As EventArgs) Handles imgArticulo.Click
        Me.AbrirImagen()
    End Sub

    Private Sub TxtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TraerCliente()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("clientes")
            F.ShowDialog()
            Me.TxtCliente.Text = F.codigo
        End If
    End Sub

    Private Sub TraerCliente()
        If Me.TxtCliente.Text.Trim = "" Then
            MsgBox("Debe ingresar cliente.", MsgBoxStyle.Information)
            Me.TxtCliente.Focus()
            Exit Sub
        End If
        If Not IsNumeric(Me.TxtCliente.Text) Then
            MsgBox("Ingrese un cliente válido", MsgBoxStyle.Information)
            Me.TxtCliente.Focus()
            Exit Sub
        End If
        Me.DS_FV001.cliente.Clear()
        Me.sdaCliente.SelectCommand.Parameters("@cod_cte").Value = Me.TxtCliente.Text.Trim
        If Me.sdaCliente.Fill(Me.DS_FV001.cliente) = 0 Then
            MsgBox("Ingrese un cliente válido", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.TxtRazonSocial.Text = Me.DS_FV001.cliente(0).razon_social.Trim
        Me.TxtDomEntrega.Text = Me.DS_FV001.cliente(0).direccion.Trim
        Me.chkDomicCte.Checked = True
    End Sub

    Private Sub TxtArt_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TraerArticulo()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("articulos")
            F.ShowDialog()
            Me.TxtArt.Text = F.codigo
            Me.TraerArticulo()
        End If
    End Sub

    Private Sub TraerArticulo()
        Me.bandRef = True
        If Me.TxtArt.Text.Trim = "" Then
            MsgBox("Debe ingresar Artículo.", MsgBoxStyle.Information)
            Me.TxtArt.Focus()
            Me.bandRef = False
            Me.DS_FV001.cliente.Clear()
            Exit Sub
        End If
        Me.DS_FV001.articulos.Clear()
        Me.sdaArticulos.SelectCommand.Parameters("@cod_art").Value = Me.TxtArt.Text.Trim
        If Me.sdaArticulos.Fill(Me.DS_FV001.articulos) = 0 Then
            MsgBox("Ingrese un articulo válido", MsgBoxStyle.Information)
            Me.bandRef = False
            Me.DS_FV001.cliente.Clear()
            Exit Sub
        End If
        Me.AgregaArticulo()
        Me.TxtArt.Text = ""
        Me.bandRef = False
    End Sub
    Private Function ProductoAgregado(ByVal producto As String) As Boolean
        For Each r As DS_FV001.notas_venta_detalleRow In Me.DS_FV001.notas_venta_detalle.Rows
            If r.cod_art.Trim = producto.Trim Then
                Me.bandRef = False
                If MsgBox("Este articulo ya está agregado. Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Return True
                End If
                r.cantidad += 1
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub AgregaArticulo()
        If Me.ProductoAgregado(Me.DS_FV001.articulos(0).cod_art.Trim) Then Exit Sub
        RowD = Me.DS_FV001.notas_venta_detalle.NewRow
        With Me.DS_FV001.articulos(0)
            RowD.folio = Row.folio
            RowD.transaccion = Row.transaccion
            RowD.cantidad = 1
            RowD.cod_art = .cod_art
            RowD.unidad = "PZA"
            RowD.precio = .precio
            RowD.importe = .precio * RowD.cantidad
            RowD.iva = RowD.importe * 0.16
            RowD.total = RowD.importe + RowD.iva
            RowD.ieps = 0
            RowD.porc_descuento = 0
            RowD.importe_descuento = 0
            RowD.descripcion = .descripcion
            'Dim img As Byte() = .imagen
            'If Not IsDBNull(.imagen) Then
            RowD.imagen = .imagen
            'End If
            RowD.nombre_imagen = .nombre_imagen
        End With
        Me.DS_FV001.notas_venta_detalle.Addnotas_venta_detalleRow(RowD)
        Me.BindingContext(Me.DvArticulos).Position = Help.dataViewPos(Me.DvArticulos, Row.folio.ToString.Trim)
        Me.muestraImagen()
        Me.Calcula()
    End Sub

    Private Sub AbrirImagen()
        Try
            If Me.DvArticulos.Count = 0 Then Exit Sub
            Dim pos As Integer = Me.BindingContext(Me.DvArticulos).Position
            If Me.DvArticulos(pos)!nombre_imagen.ToString.Trim = "" Then
                MsgBox("Aún no ha asignado un archivo al defecto", MsgBoxStyle.Information)
                Return
            End If
            Dim nombre As String = Me.DvArticulos(pos)!nombre_imagen.ToString.Trim
            Dim archivo() As Byte = Me.DvArticulos(pos)!imagen
            Dim path As String = My.Computer.FileSystem.GetTempFileName
            My.Computer.FileSystem.WriteAllBytes(path, archivo, False)
            Dim info As New IO.FileInfo(path)
            If IO.File.Exists(info.DirectoryName & "\" & nombre) Then
                My.Computer.FileSystem.DeleteFile(info.DirectoryName & "\" & nombre)
            End If
            My.Computer.FileSystem.RenameFile(path, nombre)
            Process.Start(info.DirectoryName & "\" & nombre)
        Catch
            MsgBox("Error al cargar la imagen", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub muestraImagen()
        Dim pos As Integer = Me.BindingContext(Me.DvArticulos).Position
        If pos < 0 Then Exit Sub
        Help.Imagen(Me.DvArticulos(pos)!imagen, Me.imgArticulo, True)
    End Sub

    Private Sub MyDataGrid1_CurrentCellChanged(sender As Object, e As EventArgs) Handles MyDataGrid1.CurrentCellChanged
        Me.muestraImagen()
        'Me.Calcula()
    End Sub

    'Private Sub MyNumPlazo_ValueChanged(sender As Object, e As EventArgs) Handles MyNumPlazo.ValueChanged
    '    'If Me.CmbTipoPlazo.SelectedValue.ToString.Trim <> "" And Me.MyNumPlazo.Value > 0 Then
    '    '    Me.generaPagos()
    '    'End If
    'End Sub

    'Private Sub CmbTipoPlazo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoPlazo.SelectedIndexChanged
    '    'If Me.MyNumPlazo.Value > 0 And Me.CmbTipoPlazo.SelectedValue.ToString.Trim <> "" Then
    '    '    Me.generaPagos()
    '    'End If
    'End Sub

    Private Sub generaPagos()
        If Me.cbCondPago.SelectedValue.ToString.Trim <> "02" Then Exit Sub
        If Me.cbPlazos.SelectedValue = 0 Then
            If Me.DS_FV001.notas_venta_detalle.Count = 0 Then
                MsgBox("Ingrese un articulo", MsgBoxStyle.Information)
                Me.cbCondPago.SelectedIndex = 0
                Me.cbPlazos.Enabled = false
                Exit Sub
            End If
            Me.cbPlazos.Focus()
            Exit Sub
        End If
        Dim p As Integer = Me.cbPlazos.SelectedValue
        Dim importe As Decimal = Me.numTotalGral.Value / Me.cbPlazos.SelectedValue
        Dim Folio As String = Help.generaFolio(Me.SqlCnn, "07")
        Me.DS_FV001.plan_pagos_detalle.Clear()

        For i As Integer = 1 To p
            rPPD = DS_FV001.plan_pagos_detalle.NewRow
            rPPD.folio = Folio
            rPPD.transaccion = Me.Trans
            rPPD.fecha = Me.DtpFecha.Value
            rPPD.importe = Me.numTotalGral.Value
            rPPD.iva = rPPD.importe * 0.16
            rPPD.total = rPPD.importe + rPPD.iva
            'r.fecha_aplicado = null
            Me.DS_FV001.plan_pagos_detalle.Addplan_pagos_detalleRow(rPPD)
            'Me.DS_FV001.plan_pagos_detalle.Addplan_pagos_detalleRow(Folio, "", Me.DtpFecha.Value.AddMonths(i), importe, 0, importe, Now)
        Next

        rPP = Me.DS_FV001.plan_pagos.NewRow
        rPP.folio = Folio.Trim
        rPP.transaccion = Me.Trans
        rPP.fecha = Me.DtpFecha.Value
        rPP.cod_cte = Me.TxtCliente.Text.Trim
        rPP.plazo = Me.cbPlazos.SelectedValue.ToString.Trim
        rPP.tipo_interes = "2"
        rPP.liquidar = False
        Me.DS_FV001.plan_pagos.Addplan_pagosRow(rPP)

    End Sub

    Private Sub Calcula()
        Dim imp As Decimal = 0, desc As Decimal = 0, iva As Decimal = 0, tot As Decimal = 0
        For i As Integer = 0 To Me.DS_FV001.notas_venta_detalle.Count - 1
            With Me.DS_FV001.notas_venta_detalle(i)
                imp += .importe
                iva += .iva
                desc += .importe_descuento
                tot += .total
            End With
        Next
        Me.numImporte.Value = imp

        Me.numDescGral.Value = desc
        Me.numDescGralPorc.Value = Me.numDescuento.Value
        Dim imp_desc_gral As Decimal = (imp - desc) * (Me.numDescGralPorc.Value / 100)
        imp_desc_gral = imp_desc_gral + desc
        Me.numSubtotal.Value = imp - imp_desc_gral
        Me.numIVAGral.Value = (imp - imp_desc_gral) * 0.16 'iva
        Me.numTotalGral.Value = imp - imp_desc_gral + Me.numIVAGral.Value
        Me.numResto.Value = Me.numTotalGral.Value - Me.numEngGral.Value
    End Sub

    Private Sub chkDomicCte_CheckedChanged(sender As Object, e As EventArgs) Handles chkDomicCte.CheckedChanged
        If Me.chkDomicCte.Checked Then
            If Me.DS_FV001.cliente.Count = 0 Then
                MsgBox("Ingrese un cliente válido", MsgBoxStyle.Information)
                Me.chkDomicCte.Checked = False
                Exit Sub
            End If
            Me.TxtDomEntrega.Enabled = False
            Me.TxtDomEntrega.Text = Me.DS_FV001.cliente(0).direccion
        Else
            Me.TxtDomEntrega.Enabled = True
            Me.TxtDomEntrega.Text = ""
        End If
    End Sub

    Private Sub cbCondPago_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCondPago.SelectionChangeCommitted
        If Me.cbCondPago.SelectedValue.ToString.Trim = "02" Then
            Me.generaPagos() 'Me.creaPlanPagos()
            Me.numEngGral.Enabled = True
            Me.numEngGral.ReadOnly = False
        Else
            Me.DS_FV001.plan_pagos_detalle.Clear()
            Me.cbPlazos.SelectedValue = 0
            Me.numEngGral.Enabled = False
            Me.numEngGral.ReadOnly = True
            Me.numEngGral.Value = 0
        End If

        If Me.cbCondPago.SelectedValue.ToString.Trim = "01" Then
            Me.chkVentaPublico.Enabled = True
            Me.cbPlazos.SelectedIndex = 0
            Me.cbPlazos.Enabled = False
        Else
            Me.chkVentaPublico.Enabled = False
            Me.chkVentaPublico.Checked = False
            Me.habilita(True)
            Me.cbPlazos.Enabled = True
        End If
    End Sub
    'Private Sub creaPlanPagos()
    '    If Me.cbPlazos.SelectedValue = 0 Then
    '        MsgBox("Seleccione un plazo", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If
    '    Dim cantPagos As Decimal = Me.MyNumTotal.Value / Me.cbPlazos.SelectedValue
    'End Sub
    Private Sub chkVentaPublico_CheckedChanged(sender As Object, e As EventArgs) Handles chkVentaPublico.CheckedChanged
        If Not Me.chkVentaPublico.Checked Then
            Me.habilita(True)
        Else
            Me.habilita(False)
            Me.DS_FV001.cliente.Clear()
            Me.TxtCliente.Text = ""
            Me.TxtRazonSocial.Text = ""
            Me.TxtDomEntrega.Text = ""
            Me.chkDomicCte.Checked = False
        End If
    End Sub
    Private Sub habilita(ByVal valor As Boolean)
        Me.TxtCliente.Enabled = valor
        Me.TxtRazonSocial.Enabled = Not valor
        Me.TxtRazonSocial.ReadOnly = valor
    End Sub

    Private Sub cbPlazos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlazos.SelectedIndexChanged
        Me.DS_FV001.plan_pagos.Clear()
        Me.DS_FV001.plan_pagos_detalle.Clear()
        Me.generaPagos()
    End Sub
    Private Sub tDetalle_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tDetalle.ColumnChanging
        If Me.bandRef Then Exit Sub
        If e.Column Is tDetalle.cantidadColumn Then
            e.Row.Item("importe") = e.ProposedValue * e.Row.Item("precio")
            e.Row.Item("iva") = (e.Row.Item("importe") - e.Row.Item("importe_descuento")) * 0.16
            e.Row.Item("total") = e.Row.Item("importe") - e.Row.Item("importe_descuento") + e.Row.Item("iva")
        End If
        If e.Column Is tDetalle.precioColumn Then
            e.Row.Item("importe") = e.ProposedValue * e.Row.Item("cantidad")
            e.Row.Item("iva") = (e.Row.Item("importe") - e.Row.Item("importe_descuento")) * 0.16
            e.Row.Item("total") = e.Row.Item("importe") - e.Row.Item("importe_descuento") + e.Row.Item("iva")
        End If
        If e.Column Is tDetalle.importe_descuentoColumn Then
            e.Row.Item("iva") = (e.Row.Item("importe") - e.ProposedValue) * 0.16
            e.Row.Item("total") = e.Row.Item("importe") - e.ProposedValue + e.Row.Item("iva")
        End If
        'If e.Column Is tDetalle.importe_descuentoColumn Then
        '    Me.Calcula()
        'End If
    End Sub
    Private Sub tDetalle_Columnged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tDetalle.ColumnChanged
        If e.Column Is tDetalle.importe_descuentoColumn Then
            Me.Calcula()
        End If
    End Sub
    Private Sub numDescuento_ValueChanged(sender As Object, e As EventArgs) Handles numDescuento.ValueChanged
        Me.Calcula()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim pos As Integer = 0
        pos = Me.BindingContext(Me.DvArticulos).Position
        If pos < 0 Then Exit Sub
        Dim art As String = Me.DvArticulos(pos)!cod_art.ToString.Trim
        For i As Integer = Me.DvArticulos.Count - 1 To 0 Step -1
            With Me.DvArticulos(i)
                If !cod_art.Trim = art.Trim Then
                    .Delete()
                    Exit For
                End If
            End With
        Next
        Me.DS_FV001.notas_venta_detalle.AcceptChanges()
        Me.Calcula()




        'Dim row As DS_FV001.notas_venta_detalleRow
        'row = Me.DS_FV001.notas_venta_detalle.FindBycod_art(art.Trim)
        'If Not row Is Nothing Then row.Delete()
        'Me.BindingContext(Me.DvArticulos).EndCurrentEdit()
    End Sub

    Private Sub numEngGral_ValueChanged(sender As Object, e As EventArgs) Handles numEngGral.ValueChanged
        Me.numResto.Value = Me.numTotalGral.Value - Me.numEngGral.Value
    End Sub


End Class