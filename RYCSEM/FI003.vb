Public Class FI003
    Dim Articulo As String

    Public Sub New(Art As String)

        ' This call is required by the designer.
        InitializeComponent()

        Articulo = Art

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FI003_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.Sqlcnn1.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Maximized
        If Articulo.ToString.Trim <> "" Then
            Me.TxtArt.Text = Articulo.ToString.Trim
            If ValidaArticulo(Me.TxtArt.Text.Trim) Then Me.Refrescar(Me.TxtArt.Text.Trim)
        Else
            Me.Refrescar()
        End If
    End Sub

    Private Sub MT_reportes1_ButtonClick(indice As Integer) Handles MT_reportes1.ButtonClick
        Select Case indice
            Case 0 'Filtro
            Case 1 'Refrescar
            Case 6 'Imprimir
        End Select
    End Sub

    Private Sub Refrescar(Optional ByVal Art As String = "")
        Dim Filtro As String = ""
        '   If Me.TxtFiltro.Text.Trim <> "" Then Filtro = Me.TxtFiltro.Tag
        Me.DS_FI003.articulos.Clear()
        Me.SdaInventarioArticulos.SelectCommand.Parameters("@Art").Value = Art.ToString.Trim
        Me.SdaInventarioArticulos.SelectCommand.Parameters("@FI").Value = Format(Me.DtpDe.Value, "dd/MM/yyyy 00:00")
        Me.SdaInventarioArticulos.SelectCommand.Parameters("@FF").Value = Format(Me.DtpA.Value, "dd/MM/yyyy 23:59")
        Me.SdaInventarioArticulos.SelectCommand.Parameters("@Filtro").Value = ""
        Me.SdaInventarioArticulos.SelectCommand.Parameters("@Actual").Value = Me.ChkFActual.Checked
        If Me.SdaInventarioArticulos.Fill(Me.DS_FI003.articulos) = 0 Then
            MsgBox("No hay registros para los filtros ingresados")
        End If
        Me.muestraImagen()
    End Sub

    Private Function ValidaArticulo(Art As String) As Boolean
        Dim descArt As String = ""
        If Art.Trim = "" Then
            MsgBox("Debe proporcionar código de articulo", MsgBoxStyle.Information)
            Me.TxtArt.Focus()
            Return False
        End If
        descArt = Help.obtieneDato("select descripcion from articulos where cod_art = '" & Art.Trim & "'")
        If Not IsNothing(descArt) Then
            Me.TxtDescArt.Text = descArt
            Return True
        Else
            MsgBox("Código de articulo no válido.", MsgBoxStyle.Information)
            Me.TxtArt.SelectAll()
            Me.TxtArt.Focus()
            Return False
        End If
    End Function

    Private Sub DtpDe_ValueChanged(sender As Object, e As EventArgs) Handles DtpDe.ValueChanged
        Me.DS_FI003.articulos.Clear()
    End Sub

    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs)
        Me.DS_FI003.articulos.Clear()
    End Sub

    Private Sub ChkFActual_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFActual.CheckedChanged
        Me.DS_FI003.articulos.Clear()
    End Sub

    Private Sub TxtArt_TextChanged(sender As Object, e As EventArgs) Handles TxtArt.TextChanged
        Me.DS_FI003.articulos.Clear()
        Me.TxtDescArt.Text = ""
    End Sub

    Private Sub TxtArt_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidaArticulo(Me.TxtArt.Text.Trim) Then Me.Refrescar(Me.TxtArt.Text.Trim)
        ElseIf e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("articulos")
            F.ShowDialog()
            Me.TxtArt.Text = F.codigo
        End If
    End Sub

    Private Sub muestraImagen()
        Dim pos As Integer = Me.BindingContext(Me.DvArticulos).Position
        If pos < 0 Then Exit Sub
        Help.Imagen(Me.DvArticulos(pos)!imagen, Me.imgArticulo, True)
    End Sub

    Private Sub MyDataGrid1_CurrentCellChanged(sender As Object, e As EventArgs) Handles MyDataGrid1.CurrentCellChanged
        Me.muestraImagen()
    End Sub

    Private Sub imgArticulo_Click(sender As Object, e As EventArgs) Handles imgArticulo.Click
        Me.AbrirImagen()
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

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        If Me.TxtArt.Text.Trim <> "" Then Me.Refrescar(Me.TxtArt.Text.Trim) Else Me.Refrescar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Help.imprimeReporte("R_FI001", Me.DS_FI003, Me.Name)
    End Sub
End Class