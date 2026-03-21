Public Class FI001

    Dim rArt As DS_FI001.articulosRow
    Dim transaccion = "01"
    Dim bt() As Byte
    Dim Band As String = ""
    Dim Articulo As String = ""

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Maximized
        Me.Habilita(False)
        Me.sdaStatus.Fill(Me.DS_FI001.status)
        Me.DS_FI001.modelos.AddmodelosRow("", "")
        Me.SdaModelos.Fill(Me.DS_FI001.modelos)
        Me.DS_FI001.tipos.AddtiposRow("", "")
        Me.SdaTipos.Fill(Me.DS_FI001.tipos)
        Me.refrescar()
        Me.txtCodArt.Focus()
    End Sub

    Private Sub MToolBar1_ButtonClick(indice As Integer)
        Select Case indice
            Case 6 'nuevo
                Me.nuevo()
            Case 7 'modificar
                Me.Habilita(True)
                Me.dgArticulos.Enabled = False
            Case 9 'guardar
                If Me.validar() Then Me.guardar()
            Case 10 'deshacer
                Me.deshacer()
            Case 12 'imprimir
                Help.imprimeReporte("R_FI001", Me.DS_FI001, Me.Name)
            Case 15 'refrescar
                Me.refrescar()
        End Select
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Band = "N"
        Me.nuevo()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.Band = "M"
        If Me.dvArticulos.Count <= 0 Then Exit Sub
        Me.Articulo = "M"
        Me.Habilita(True)
        Me.dgArticulos.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Band = "G"
        If Me.validar() Then Me.guardar()
    End Sub

    Private Sub btnDeshacer_Click(sender As Object, e As EventArgs) Handles btnDeshacer.Click
        Me.Band = "D"
        Me.deshacer()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Band = "I"
        Help.imprimeReporte("R_FI001", Me.DS_FI001, Me.Name)
    End Sub

    Private Sub ver()
        Try
            Dim pos As Integer = Me.BindingContext(Me.dvArticulos).Position
            If Me.dvArticulos(pos)!nombre_imagGen.ToString.Trim = "" Then
                MsgBox("Aún no ha asignado un archivo al defecto", MsgBoxStyle.Information)
                Return
            End If
            Dim nombre As String = Me.dvArticulos(pos)!nombre_imagen.ToString.Trim
            Dim archivo() As Byte = Me.dvArticulos(pos)!imagen
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
    Private Sub deshacer()
        Me.Habilita(False)
        Me.dgArticulos.Enabled = True
        Me.refrescar()
    End Sub
    Private Sub refrescar()
        Me.DS_FI001.articulos.Clear()
        Me.NumCantArt.Value = 0
        If Me.sdaArticulos.Fill(Me.DS_FI001.articulos) > 0 Then
            Me.BindingContext(Me.dvArticulos).Position = 0
            Me.txtCodArt.Text = Me.dvArticulos(0)!cod_art.ToString.Trim
            Me.muestraImagen()
        End If
    End Sub
    Private Sub guardar()
        Try
            Me.txtObservaciones.Focus()
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.sdaArticulos.DeleteCommand.Transaction = Help.MyTrans
            Me.sdaArticulos.InsertCommand.Transaction = Help.MyTrans
            Me.sdaArticulos.UpdateCommand.Transaction = Help.MyTrans

            If Me.Articulo = "N" Then
                Me.rArt.cod_art = Help.generaFolio(Me.sqlConn, Me.transaccion)  'Me.obtieneFolio()
                Me.AyDInventario(Me.sqlConn, "02", "G")
            End If

            Me.BindingContext(Me.dvArticulos).EndCurrentEdit()
            Me.sdaArticulos.Update(Me.DS_FI001.articulos)
            Help.MyTrans.Commit()
            MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
            Me.Habilita(False)
            Me.dgArticulos.Enabled = True
            Me.refrescar()
            'Me.MToolBar1.Habilita_Guardar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
        End Try
    End Sub
    Private Function validar() As Boolean
        If Me.txtDescripcion.Text.Trim = "" Then
            MsgBox("Ingrese una descripción del artículo", MsgBoxStyle.Information)
            Return False
        End If
        If Me.numCosto.Value = 0 Then
            MsgBox("El costo del articulo no puede ser cero", MsgBoxStyle.Information)
            Return False
        End If
        If Me.numPrecio.Value = 0 Then
            MsgBox("El precio del articulo no puede ser cero", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub nuevo()
        Me.Habilita(True)
        Me.Articulo = "N"
        rArt = Me.DS_FI001.articulos.NewRow
        rArt.cod_art = Help.generaFolio(Me.sqlConn, Me.transaccion) 'Me.obtieneFolio()
        rArt.descripcion = ""
        rArt.costo = 0
        rArt.precio = 0
        rArt.observaciones = ""
        rArt.usuario = Help.usuario.Trim
        rArt.imagen = Nothing

        rArt.status = "V"
        Me.DS_FI001.articulos.AddarticulosRow(rArt)
        Me.NumCantArt.Value = 1
        ' Me.MToolBar1.Habilita_Nuevo()
        Me.dgArticulos.Enabled = False
        Me.txtDescripcion.Focus()
        Me.BindingContext(Me.dvArticulos).Position = Help.dataViewPos(Me.dvArticulos, rArt.cod_art.ToString.Trim)
        Me.txtCodArt.Text = rArt.cod_art.ToString.Trim
    End Sub

    Private Sub Habilita(ByRef valor As Boolean)
        Help.SetAll(Me, "Enabled", valor, "Textbox")
        Help.SetAll(Me, "Enabled", valor, "ComboBox")
        Help.SetAll(Me, "Enabled", valor, "NumericUpDown")
        Me.btnBuscar.Enabled = valor
        Me.txtImagen.Enabled = False
        Me.txtCodArt.Enabled = Not Me.txtCodArt.Enabled
        Me.NumInventario.Enabled = False
    End Sub

    Private Function obtieneFolio() As Integer
        Return Help.obtieneDato("SELECT TOP 1 cod_art +1 FROM articulos ORDER BY cod_art DESC")
    End Function

    Private Sub txtCodArt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodArt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.posicion(Me.txtCodArt.Text.Trim)
        End If
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("articulos")
            F.ShowDialog()
            Me.txtCodArt.Text = F.codigo.Trim
        End If
    End Sub
    Private Sub posicion(Optional ByVal cod_art As String = "")
        Dim pos As Integer
        If cod_art.Trim <> "" Then
            pos = Help.dataViewPos(Me.dvArticulos, cod_art)
        Else
            pos = Me.BindingContext(Me.dvArticulos).Position
        End If

        If pos < 0 Then
            'MsgBox("Artículo no registrado", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.muestraImagen()
        Me.txtCodArt.Text = Me.dvArticulos(pos)!cod_art.ToString.Trim
        Me.BindingContext(Me.dvArticulos).Position = pos
        Me.calculaPrecio()
    End Sub
    Private Sub muestraImagen()
        Dim pos As Integer = Me.BindingContext(Me.dvArticulos).Position
        Help.Imagen(Me.dvArticulos(pos)!imagen, Me.imgArticulo, True)
    End Sub
    Private Sub dgArticulos_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgArticulos.CurrentCellChanged
        Me.posicion()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim ofd As New OpenFileDialog
        ofd.ShowDialog()
        Dim nomArchivo As String = ofd.FileName
        If Not My.Computer.FileSystem.FileExists(nomArchivo) Then Return
        Dim info As New IO.FileInfo(nomArchivo)
        Dim nombre As String = info.Name
        bt = My.Computer.FileSystem.ReadAllBytes(nomArchivo)
        Dim pos As Integer = Me.BindingContext(Me.dvArticulos).Position
        Me.dvArticulos(pos)!imagen = bt
        Me.dvArticulos(pos)!nombre_imagen = nombre.Trim
        Me.txtImagen.Text = nombre.Trim
        Me.muestraImagen()
    End Sub

    Private Sub imgArticulo_Click(sender As Object, e As EventArgs) Handles imgArticulo.Click
        Me.ver()
    End Sub


    Private Sub numCosto_ValueChanged(sender As Object, e As EventArgs) Handles numCosto.ValueChanged
        Me.calculaPrecio()
    End Sub
    Private Sub calculaPrecio()
        'Me.numPrecio.Value = Me.numCosto.Value * (1 + (Me.numPorcGan.Value / 100))
    End Sub

    Private Sub numPorcGan_ValueChanged(sender As Object, e As EventArgs)
        Me.calculaPrecio()
    End Sub

    Private Sub BtnModifInv_Click(sender As Object, e As EventArgs) Handles BtnModifInv.Click
        Me.GbModifInventario.Visible = Not Me.GbModifInventario.Visible
        Me.NumCantArt.Enabled = Me.GbModifInventario.Visible
        If Me.Band.Trim = "N" Then Me.habilitaBotones(False) Else Me.habilitaBotones(True)
    End Sub

    Private Sub BtnAumentar_Click(sender As Object, e As EventArgs) Handles BtnAumentar.Click
        If Me.NumCantArt.Value = 0 Then
            MsgBox("No ha ingresado cantidad de inventario.", MsgBoxStyle.Information)
            Me.NumCantArt.Focus()
            Exit Sub
        End If
        Me.AyDInventario(Me.sqlConn, "02")
    End Sub

    Private Sub BtnDismunuir_Click(sender As Object, e As EventArgs) Handles BtnDismunuir.Click
        If Me.NumCantArt.Value = 0 Then
            MsgBox("No ha ingresado cantidad de inventario.", MsgBoxStyle.Information)
            Me.NumCantArt.Focus()
            Exit Sub
        End If
        Me.AyDInventario(Me.sqlConn, "03")
    End Sub

    Private Sub AyDInventario(ByVal conexion As SqlClient.SqlConnection, Trans As String, Optional Tipo As String = "M")
        Try
            Dim msg As String = ""
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            If Tipo.Trim = "M" Then Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.CmdAyDInventario.Transaction = Help.MyTrans
            Me.CmdAyDInventario.Parameters("@Trans").Value = Trans
            Me.CmdAyDInventario.Parameters("@CodArt").Value = Me.txtCodArt.Text.Trim
            Me.CmdAyDInventario.Parameters("@Cant").Value = Me.NumCantArt.Value
            Me.CmdAyDInventario.Parameters("@msg").Value = ""
            Me.CmdAyDInventario.ExecuteNonQuery()
            msg = Me.CmdAyDInventario.Parameters("@msg").Value
            If Tipo.Trim = "M" Then
                Help.MyTrans.Commit()
                If msg = "" Then MsgBox("Se modificó el inventario del producto exitosamente.", MsgBoxStyle.Information)
                Me.NumInventario.Value = Help.obtieneDato("SELECT dbo.ObtenerValor('" & Me.txtCodArt.Text.Trim & "', '01')")
                Me.refrescar()
            End If
            Me.NumCantArt.Value = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            If Tipo.Trim = "M" Then If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim F As New FI003("")
        F.Show()
    End Sub

    Private Sub habilitaBotones(valor As Boolean)
        Me.BtnAumentar.Enabled = valor
        Me.BtnDismunuir.Enabled = valor
    End Sub


End Class
