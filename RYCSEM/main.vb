Module main
    Public Sub Main()
        System.Windows.Forms.Application.EnableVisualStyles()
        Dim F As New FLogin ' FInicio ' FI001() ' FP001() ' FC001() ' FInicio()
        Help.usuario = "1"
        F.MdiParent = Nothing
        F.ShowDialog()
    End Sub
End Module