Public Class FConf
    Dim RowP As DS_FConf.tipos_plazosRow
    Dim RowI As DS_FConf.interesesRow
    Private Sub FConf_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.SqlCnn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Maximized
        Me.SdaStatus.Fill(Me.DS_FConf)
        Me.SdaTipoInteres.Fill(Me.DS_FConf)
        Me.Refrescar()
    End Sub

    Private Sub MT_Operacional1_ButtonClick(indice As Integer) Handles MT_Operacional1.ButtonClick
        Me.MT_Operacional1.Focus()
        Select Case indice
            Case 0 'Guardar
            Case 1 'Deshacer
                Me.Refrescar()
            Case 3 'Modificar
            Case 5 'Imprimir
            Case 10 'Refrescar
                Me.Refrescar()
        End Select
    End Sub
    Private Sub habilitaPlazo()

    End Sub

    Private Sub habilitaInteres()

    End Sub

    Private Sub Refrescar()
        Me.limpiar()
        Me.SdaTiposPlazos.Fill(Me.DS_FConf)
        Me.SdaIntereses.Fill(Me.DS_FConf)
        Dim p As Integer = Me.BindingContext(Me.DvPlazos).Position
        If p > -1 Then Me.TxtPlazo.Text = Me.DvPlazos(p)!tipo_plazo.ToString.Trim
        p = Me.BindingContext(Me.DvIntereses).Position
        If p > -1 Then Me.TxtInteres.Text = Me.DvIntereses(p)!folio.ToString.Trim
    End Sub

    Private Sub limpiar()
        Me.DS_FConf.intereses.Clear()
        Me.DS_FConf.tipos_plazos.Clear()
    End Sub

    Private Sub MyDataGrid1_CurrentCellChanged(sender As Object, e As EventArgs) Handles MyDataGrid1.CurrentCellChanged
        Dim p As Integer = Me.BindingContext(Me.DvPlazos).Position
        If p > -1 Then Me.TxtPlazo.Text = Me.DvPlazos(p)!tipo_plazo.ToString.Trim

    End Sub

    Private Sub MyDataGrid2_CurrentCellChanged(sender As Object, e As EventArgs) Handles MyDataGrid2.CurrentCellChanged
        Dim p As Integer = Me.BindingContext(Me.DvIntereses).Position
        If p > -1 Then Me.TxtInteres.Text = Me.DvIntereses(p)!folio.ToString.Trim
    End Sub

    Private Sub nuevoPlazo()

    End Sub

    Private Sub nuevoInteres()

    End Sub

    Private Sub Guardar()

    End Sub


End Class