Public Class FmenuProveedores
    Dim Fproveedores As New FP001


    Private Sub FmenuClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Fproveedores.TopLevel = False
        Me.panel.Controls.Add(Fproveedores)
    End Sub
    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles FP001.Click
        Me.oculta(FP001.Name)
    End Sub
    Private Sub oculta(ByVal f As String)
        For i As Integer = 0 To Me.panel.Controls.Count - 1
            Me.panel.Controls.Item(i).Hide()
        Next
        Me.panel.Controls.Item(f.Trim).Show()
    End Sub
End Class