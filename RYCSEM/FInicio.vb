Public Class FInicio
    Dim UsuarioSesion As String

    Public Sub New(usuario As String)

        ' This call is required by the designer.
        InitializeComponent()
        UsuarioSesion = usuario
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim F As New FC001
        F.Show()
    End Sub
    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Dim F As New FV002
        F.Show()
    End Sub
    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim F As New FI001
        F.Show()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim CajaActiva As Integer = 0
        CajaActiva = Help.obtieneDato("SELECT count(*) from turnos where activo = 1 and usuario = '" & UsuarioSesion & "'")
        If CajaActiva > 0 Then
            Dim F As New FVPOS(UsuarioSesion)
            F.Show()
        Else
            Dim F As New Caja(UsuarioSesion)
            F.Show()
        End If
    End Sub

End Class