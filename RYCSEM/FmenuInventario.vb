Public Class FmenuInventario
    Dim FInventario As New FI001
    Dim FopInv As New FI002
    Dim FconsInv As New FI003("")

    Private Sub FmenuClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        FInventario.TopLevel = False
        FopInv.TopLevel = False
        FconsInv.TopLevel = False
        Me.panel.Controls.Add(FInventario)
        Me.panel.Controls.Add(FopInv)
        Me.panel.Controls.Add(FconsInv)
    End Sub
    'Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles FI001.Click
    '    'If Not Fclientes.Visible Then
    '    '    Fclientes.Show()
    '    'Else
    '    '    Fclientes.Hide()
    '    'End If
    '    Me.oculta(FI001.Name)
    '    'Dim str As String = Me.Name
    'End Sub

    Private Sub oculta(ByVal f As String)
        For i As Integer = 0 To Me.panel.Controls.Count - 1
            Me.panel.Controls.Item(i).Hide()
        Next
        Me.panel.Controls.Item(f.Trim).Show()
    End Sub

    Private Sub FI001_Click(sender As Object, e As EventArgs) Handles FI001.Click
        Me.oculta(FI001.Name)
    End Sub
    Private Sub FI002_Click(sender As Object, e As EventArgs) Handles FI002.Click
        Me.oculta(FI002.Name)
    End Sub
    Private Sub FI003_Click(sender As Object, e As EventArgs) Handles FI003.Click
        Me.oculta(FI003.Name)
    End Sub
End Class