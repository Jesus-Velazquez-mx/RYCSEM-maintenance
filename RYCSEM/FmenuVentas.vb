Public Class FmenuVentas
    Dim Fventas As New FV001
    Dim Fconf As New FConf
    Private Sub FmenuClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Fventas.TopLevel = False
        Fconf.TopLevel = False
        Me.panel.Controls.Add(Fventas)
        Me.panel.Controls.Add(Fconf)
    End Sub
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles FV001.Click
        Me.oculta(FV001.Name)
    End Sub
    Private Sub FConf_Click(sender As Object, e As EventArgs)
        Me.oculta(FConf.Name)
    End Sub
    Private Sub oculta(ByVal f As String)
        For i As Integer = 0 To Me.panel.Controls.Count - 1
            Me.panel.Controls.Item(i).Hide()
        Next
        Me.panel.Controls.Item(f.Trim).Show()
    End Sub



End Class