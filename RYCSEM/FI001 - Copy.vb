Public Class FI001

    Dim rArt As DS_FI001.articulosRow
    Dim transaccion = "03"
    Dim bt() As Byte
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Maximized
        Me.Habilita(False)
        Me.sdaStatus.Fill(Me.DS_FI001.status)
        Me.DS_FI001.lineas_articulos.Addlineas_articulosRow("", "", 0.0)
        Me.sdaLineas.Fill(Me.DS_FI001.lineas_articulos)
        Me.refrescar()
        Me.txtCodArt.Focus()
    End Sub
    Private Sub MToolBar1_ButtonClick(indice As Integer) Handles MToolBar1.ButtonClick
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

    Private Sub ver()
        Try
            Dim pos As Integer = Me.BindingContext(Me.dvArticulos).Position
            If Me.dvArticulos(pos)!nombre_imagen.ToString.Trim = "" Then
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
        Me.MToolBar1.Habilita_Guardar()
    End Sub
    Private Sub refrescar()
        Me.DS_FI001.articulos.Clear()
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

            If Me.MToolBar1.Band = "N" Then
                Me.rArt.cod_art = Help.generaFolio(Me.sqlConn, Me.transaccion)  'Me.obtieneFolio()
            End If
            Me.BindingContext(Me.dvArticulos).EndCurrentEdit()
            Me.sdaArticulos.Update(Me.DS_FI001.articulos)
            Help.MyTrans.Commit()
            MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
            Me.Habilita(False)
            Me.dgArticulos.Enabled = True
            Me.refrescar()
            Me.MToolBar1.Habilita_Guardar()
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
        Me.MToolBar1.Habilita_Nuevo()
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
            MsgBox("Artículo no registrado", MsgBoxStyle.Information)
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

    Private Sub cbLinea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbLinea.SelectionChangeCommitted
        If Me.cbLinea.SelectedIndex = 0 Then
            Me.numPorcGan.Value = 0
        Else
            Me.numPorcGan.Value = Me.DS_FI001.lineas_articulos(Me.cbLinea.SelectedIndex).porc_ganancia
        End If
    End Sub

    Private Sub numCosto_ValueChanged(sender As Object, e As EventArgs) Handles numCosto.ValueChanged
        Me.calculaPrecio()
    End Sub
    Private Sub calculaPrecio()
        Me.numPrecio.Value = Me.numCosto.Value * (1 + (Me.numPorcGan.Value / 100))
    End Sub

    Private Sub numPorcGan_ValueChanged(sender As Object, e As EventArgs) Handles numPorcGan.ValueChanged
        Me.calculaPrecio()
    End Sub
End Class
