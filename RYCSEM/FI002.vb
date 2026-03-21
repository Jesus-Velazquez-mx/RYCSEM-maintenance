Public Class FI002

    Private Sub FI002_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.SqlCnn1.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Maximized
        Me.SdaOperaciones.Fill(Me.DS_FI002.transacciones)
        Me.DS_FI002.transacciones.AddtransaccionesRow("", "", "", "", "")
        Me.SdaStatus.Fill(Me.DS_FI002.status)
        Me.CmbOpe.SelectedValue = "02"
        Me.CmbStatus.SelectedValue = "V"
        Me.Habilita(False)
    End Sub

    Private Sub MToolBar1_ButtonClick(indice As Integer) Handles MToolBar1.ButtonClick
        Select Case indice
            Case 6 'Nuevo
                If Me.CmbOpe.SelectedValue = "" Then
                    MsgBox("Seleccione operación a realizar", MsgBoxStyle.Information)
                    Me.CmbOpe.Focus()
                    Exit Sub
                End If
                Me.Nuevo()
            Case 7 'Modificar
                Me.Modificar()
            Case 9 'Guardar
                Me.Guardar()
            Case 10 'Deshacer
                If Me.MToolBar1.Band = "N" Then
                    Me.Limpiar()
                    Me.CmbOpe.SelectedValue = "02"
                    Me.TxtFolio.Text = ""
                End If
                If Me.TxtFolio.Text.Trim <> "" Then Me.Refrescar()
                Me.MToolBar1.Habilita_Guardar()
                Me.Habilita(False)
            Case 12 'Imprimir
            Case 15 'Refrescar
                Me.Refrescar()
        End Select
    End Sub

    Private Sub Limpiar()
        Me.DTPFecha.Value = Now
        Me.DS_FI002.moperaciones_inventario.Clear()
    End Sub

    Private Sub Habilita(valor As Boolean)
        Help.SetAll(Me, "Enabled", valor, "Textbox")
        Help.SetAll(Me, "Enabled", valor, "ComboBox")
        Me.MyNumCant.Enabled = valor
        Me.DTPFecha.Enabled = valor
        Me.TxtFolio.Enabled = Not valor
        Me.CmbOpe.Enabled = Not valor
        Me.BtnNuevo.Enabled = valor
        Me.BtnEliminar.Enabled = valor
    End Sub

    Private Sub Nuevo()
        Me.Limpiar()
        Dim Folio As String = ""
        Folio = Help.generaFolio(SqlCnn1, Me.CmbOpe.SelectedValue.ToString.Trim)
        If IsNothing(Folio) Then
            MsgBox("Error al generar folio", MsgBoxStyle.Information)
            Me.TxtArticulo.Focus()
            Exit Sub
        End If
        Me.TxtFolio.Text = Folio
        'Me.TxtFolio.ReadOnly = True
        Me.MyNumCant.Value = 1
        Me.CmbStatus.SelectedValue = "V"
        Me.Habilita(True)
        Me.MToolBar1.Habilita_Nuevo()
    End Sub

    Private Sub NuevoArt(Art As String, descArt As String)
        Dim row As DS_FI002.moperaciones_inventarioRow
        row = DS_FI002.moperaciones_inventario.NewRow
        row.folio = Me.TxtFolio.Text.Trim
        row.transaccion = Me.CmbOpe.SelectedValue.ToString.Trim
        row.cod_art = Art
        row.cantidad = Me.MyNumCant.Value
        row.descripcion = descArt
        row.fecha = Me.DTPFecha.Value
        row.status = Me.CmbStatus.SelectedValue
        Me.DS_FI002.moperaciones_inventario.Addmoperaciones_inventarioRow(row)

        Me.BindingContext(Me.DvArticulos).Position = Help.dataViewPos(Me.DvArticulos, row.cod_art.ToString.Trim)
    End Sub

    Private Sub Modificar()
        If Me.DS_FI002.moperaciones_inventario.Count = 0 Then
            MsgBox("No existen registros que modificar.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.DS_FI002.moperaciones_inventario(0).status = "C" Then
            MsgBox("El folio ingresado se encuentra cancelado, no se puede moficar.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.Habilita(True)
        Me.MToolBar1.Habilita_Nuevo()
        Me.MToolBar1.Band = "M"
    End Sub

    Private Sub Guardar()
        Dim Folio As String = ""
        Try
            If Me.MToolBar1.Band = "N" Then Folio = Help.generaFolio(Me.SqlCnn1, Me.CmbOpe.SelectedValue.ToString.Trim)
            If Me.MToolBar1.Band = "M" Then Folio = Me.TxtFolio.Text.Trim
            If Folio.Trim <> Me.TxtFolio.Text.Trim Then
                For Each rArt As DS_FI002.moperaciones_inventarioRow In Me.DS_FI002.moperaciones_inventario.Rows
                    rArt.folio = Folio
                Next
            End If
            If Me.SqlCnn1.State <> ConnectionState.Open Then Me.SqlCnn1.Open()
            Help.MyTrans = Me.SqlCnn1.BeginTransaction
            Me.CmdActOpeInventario.Transaction = Help.MyTrans
            Me.CmdOpeInventario.Transaction = Help.MyTrans
            Me.SdaMOpeInventario.DeleteCommand.Transaction = Help.MyTrans
            Me.SdaMOpeInventario.InsertCommand.Transaction = Help.MyTrans
            Me.SdaMOpeInventario.UpdateCommand.Transaction = Help.MyTrans
            If Me.MToolBar1.Band = "N" Then
                With Me.CmdOpeInventario
                    .Parameters("@folio").Value = Folio
                    .Parameters("@transaccion").Value = Me.CmbOpe.SelectedValue.ToString.Trim
                    .Parameters("@fecha").Value = Me.DTPFecha.Value
                    .Parameters("@usuario").Value = Help.usuario.Trim
                    .Parameters("@status").Value = Me.CmbStatus.SelectedValue.ToString.Trim
                    .ExecuteNonQuery()
                End With
            Else
                With Me.CmdActOpeInventario
                    .Parameters("@folio").Value = Folio
                    .Parameters("@trans").Value = Me.CmbOpe.SelectedValue.ToString.Trim
                    .Parameters("@usuario").Value = Help.usuario.Trim
                    .Parameters("@status").Value = Me.CmbStatus.SelectedValue.ToString.Trim
                    .ExecuteNonQuery()
                End With
            End If
            Me.BindingContext(Me.DvArticulos).EndCurrentEdit()
            Me.SdaMOpeInventario.Update(Me.DS_FI002.moperaciones_inventario)
            Help.MyTrans.Commit()
            MsgBox(Me.CmbOpe.Text.Trim & " registrado correctamente.", MsgBoxStyle.Information)
            Me.Refrescar()
            Me.MToolBar1.Habilita_Guardar()
            Me.TxtFolio.ReadOnly = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            If Me.SqlCnn1.State <> ConnectionState.Closed Then Me.SqlCnn1.Close()
        End Try

    End Sub

    Private Sub Refrescar()
        If Me.TxtFolio.Text.Trim = "" Then
            MsgBox("Ingrese folio que desea consultar.", MsgBoxStyle.Information)
            Me.TxtFolio.Text.Trim()
            Exit Sub
        End If
        If Me.CmbOpe.SelectedValue = "" Then
            MsgBox("Seleccione operación que desea consultar.", MsgBoxStyle.Information)
            Me.CmbOpe.Focus()
            Exit Sub
        End If
        Me.DS_FI002.moperaciones_inventario.Clear()
        Me.SdaMOpeInventario.SelectCommand.Parameters("@folio").Value = Me.TxtFolio.Text.Trim
        Me.SdaMOpeInventario.SelectCommand.Parameters("@transaccion").Value = Me.CmbOpe.SelectedValue.ToString.Trim
        If Me.SdaMOpeInventario.Fill(Me.DS_FI002) = 0 Then
            MsgBox("No existen registros para el folio insertado.", MsgBoxStyle.Information)
            Me.TxtFolio.Focus()
            Exit Sub
        End If
        Me.Habilita(False)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If Me.TxtArticulo.Text.Trim = "" Then
            MsgBox("Debe ingresar producto", MsgBoxStyle.Information)
            Me.TxtArticulo.Focus()
            Exit Sub
        End If
        Dim descArt As String = ""
        If Me.ValidaArticulo(Me.TxtArticulo.Text.Trim, descArt) Then Me.NuevoArt(Me.TxtArticulo.Text.Trim, descArt)
    End Sub

    Private Function ValidaArticulo(Art As String, ByRef descArt As String) As Boolean
        If Art.Trim = "" Then
            MsgBox("Debe proporcionar código de articulo", MsgBoxStyle.Information)
            Me.TxtArticulo.Focus()
            Return False
        End If
        descArt = Help.obtieneDato("select descripcion from articulos where cod_art = '" & Art.Trim & "'")
        If Not IsNothing(descArt) Then
            Return True
        Else
            MsgBox("Código de articulo no válido.", MsgBoxStyle.Information)
            Me.TxtFolio.SelectAll()
            Me.TxtFolio.Focus()
            Return False
        End If
    End Function

    Private Sub TxtArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim descArt As String = ""
            If ValidaArticulo(Me.TxtArticulo.Text.Trim, descArt) Then Me.NuevoArt(Me.TxtArticulo.Text.Trim, descArt)
        ElseIf e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("articulos")
            F.ShowDialog()
            Me.TxtArticulo.Text = F.codigo
        End If
    End Sub

    Private Sub TxtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFolio.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.ValidadFolio() Then Me.Refrescar()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("operaciones_inventario", Me.CmbOpe.SelectedValue.ToString.Trim)
            F.ShowDialog()
            Me.TxtFolio.Text = F.codigo
        End If
    End Sub

    Private Function ValidadFolio() As Boolean
        If TxtFolio.Text.Trim = "" Then
            MsgBox("Debe proporcionar folio a consultar", MsgBoxStyle.Information)
            Me.TxtFolio.Focus()
            Return False
        End If
        If Me.CmbOpe.SelectedValue.ToString.Trim = "" Then
            MsgBox("Debe seleccionar operación a consultar.")
            Me.CmbOpe.Focus()
            Return False
        End If
        Dim folio As String = Help.obtieneDato("select folio from operaciones_inventario where folio = '" & Me.TxtFolio.Text.Trim & "' and transaccion = '" & Me.CmbOpe.SelectedValue.ToString.Trim & "'")
        If Not IsNothing(folio) Then
            Return True
        Else
            MsgBox("Folio de " & Me.CmbOpe.Text.Trim & " no válido.", MsgBoxStyle.Information)
            Me.TxtFolio.SelectAll()
            Me.TxtFolio.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CmbOpe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOpe.SelectedIndexChanged
        If Me.MToolBar1.Band <> "N" Then
            Me.Limpiar()
            Me.TxtFolio.Clear()
        End If
    End Sub

    Private Sub TxtFolio_TextChanged(sender As Object, e As EventArgs) Handles TxtFolio.TextChanged
        If Me.MToolBar1.Band <> "N" And Me.TxtFolio.Text.Trim <> "" Then Me.Limpiar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim p As Integer = Me.BindingContext(Me.DvArticulos).Position
        If p < 0 Then Exit Sub
        Me.DvArticulos.AllowDelete = True
        Me.DvArticulos(p).Delete()
        Me.DvArticulos.AllowDelete = False
    End Sub
End Class