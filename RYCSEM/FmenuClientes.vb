Public Class FmenuClientes
    Dim Fclientes As New FC001
    Dim Fabonos As New FC002
    Private Sub FmenuClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Fclientes.TopLevel = False
        Fabonos.TopLevel = False
        Me.panel.Controls.Add(Fclientes)
        Me.panel.Controls.Add(Fabonos)
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles FC001.Click
        Me.oculta(FC001.Name)
    End Sub
    Private Sub oculta(ByVal f As String)
        For i As Integer = 0 To Me.panel.Controls.Count - 1
            Me.panel.Controls.Item(i).Hide()
        Next
        Me.panel.Controls.Item(f.Trim).Show()
    End Sub

    Private Sub FC002_Click(sender As Object, e As EventArgs) Handles FC002.Click
        Me.oculta(FC002.Name)
    End Sub
End Class