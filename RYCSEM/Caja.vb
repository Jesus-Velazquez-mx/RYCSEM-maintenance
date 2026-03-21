Public Class Caja
    Dim UsuarioSesion As String
    Public Sub New(ByVal Usuario As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        UsuarioSesion = Usuario

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Guardar()
        Dim F As New FVPOS(UsuarioSesion)
        F.Show()
        Me.Close()
    End Sub

    Private Sub Caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Normal
        Me.sdaUsuario.Fill(Me.DS_FCaja)
        If Me.UsuarioSesion.Trim <> "" Then
            Me.cmbUsuario.SelectedValue = UsuarioSesion
        End If
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Guardar()
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.SqlNuevoTurno.Transaction = Help.MyTrans
            With Me.SqlNuevoTurno
                .Parameters("@usuario").Value = Me.cmbUsuario.SelectedValue
                .Parameters("@fecha_inicial").Value = Now
                .Parameters("@fecha_final").Value = Now
                .Parameters("@monto").Value = Me.numFondo.Value
                .Parameters("@activo").Value = 1
                .ExecuteNonQuery()
            End With
            Help.MyTrans.Commit()
            MsgBox("Turno nuevo registrado correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
        End Try
    End Sub
End Class