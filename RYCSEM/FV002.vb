Public Class FV002
    Private Sub FV002_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.DS_FV002.status.AddstatusRow("", "", "Todos")
        Me.sdaStatus.Fill(Me.DS_FV002.status)
    End Sub
    Private Sub refrescar()
        Me.limpiar()
        If Me.dtpFI.Value.Date > Me.dtpFF.Value.Date Then
            MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim codcte As Integer = 0
        If IsNumeric(Me.txtCodCte.Text.Trim) Then codcte = Convert.ToInt32(Me.txtCodCte.Text.Trim)
        Me.sdaDatos.SelectCommand.Parameters("@FI").Value = Format(Me.dtpFI.Value, "dd/MM/yyyy 00:00")
        Me.sdaDatos.SelectCommand.Parameters("@FF").Value = Format(Me.dtpFF.Value, "dd/MM/yyyy 23:59")
        Me.sdaDatos.SelectCommand.Parameters("@folio").Value = Me.txtFolio.Text.Trim
        Me.sdaDatos.SelectCommand.Parameters("@cod_cte").Value = codcte
        Me.sdaDatos.SelectCommand.Parameters("@status").Value = Me.cbStatus.SelectedValue.ToString.Trim
        Me.sdaDatos.Fill(Me.DS_FV002)
        Me.filtrar()
    End Sub
    Private Sub filtrar()
        Dim pos As Integer
        pos = Me.BindingContext(Me.dvCabecero).Position
        Me.dvDetalle.RowFilter = ""
        If pos < 0 Then Exit Sub
        Me.dvDetalle.RowFilter = "folio = '" & Me.dvCabecero(pos)!folio.ToString.trim & "'"
    End Sub
    Private Sub txtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolio.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("notas_venta")
            F.ShowDialog()
            Me.txtFolio.Text = F.codigo.Trim
            Me.txtFolio_KeyDown(Me.txtFolio, New KeyEventArgs(Keys.Enter))
        End If
        If e.KeyCode = Keys.Enter Then
            Dim rs As String = Help.obtieneDato("SELECT folio FROM notas_venta WHERE folio = '" & Me.txtFolio.Text.Trim & "'")
            If rs Is Nothing Then
                MsgBox("Ingrese un folio válido", MsgBoxStyle.Information)
                Me.txtFolio.Text = ""
                Me.txtFolio.Focus()
            End If
            Me.limpiar()
        End If
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            Me.limpiar()
        End If
    End Sub
    Private Sub txtCodCte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCte.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("clientes")
            F.ShowDialog()
            Me.txtCodCte.Text = F.codigo.Trim
            Me.txtCodCte_KeyDown(Me.txtCodCte, New KeyEventArgs(Keys.Enter))
        End If
        If e.KeyCode = Keys.Enter Then
            Me.limpiarCte()
            Dim codcte As Integer
            If Not IsNumeric(Me.txtCodCte.Text.Trim) Then
                MsgBox("Ingrese un cliente válido", MsgBoxStyle.Information)
                Me.limpiarCte()
                Exit Sub
            Else
                codcte = Convert.ToInt32(Me.txtCodCte.Text.Trim)
            End If
            Dim rs As String = Help.obtieneDato("SELECT dbo.nombreCompleto(" & codcte & ", 'C')")
            If rs Is Nothing Then
                MsgBox("Ingrese un cliente válido", MsgBoxStyle.Information)
                Me.limpiarCte()
                Exit Sub
            End If
            Me.txtRazonSocial.Text = rs.Trim
        End If
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            Me.limpiarCte()
        End If
    End Sub
    Private Sub limpiarCte()
        Me.txtRazonSocial.Text = ""
        Me.txtCodCte.Focus()
        Me.limpiar()
    End Sub

    Private Sub cbStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbStatus.SelectionChangeCommitted
        Me.limpiar()
    End Sub
    Private Sub limpiar()
        Me.DS_FV002.cabecero.Clear()
        Me.DS_FV002.detalle.Clear()
        Me.DS_FV002.resumen_articulos.Clear()
    End Sub

    Private Sub dtpFI_ValueChanged(sender As Object, e As EventArgs) Handles dtpFI.ValueChanged
        Me.limpiar()
    End Sub

    Private Sub dtpFF_ValueChanged(sender As Object, e As EventArgs) Handles dtpFF.ValueChanged
        Me.limpiar()
    End Sub

    Private Sub MyDataGrid1_CurrentCellChanged(sender As Object, e As EventArgs) Handles MyDataGrid1.CurrentCellChanged
        Me.filtrar()
    End Sub

    Private Sub MT_reportes1_ButtonClick(indice As Integer) Handles MT_reportes1.ButtonClick
        Select Case indice
            Case 1 'REFRESCAR
                Me.refrescar()
            Case 6 'IMPRIMIR
                Dim Parametros As Object(,) = {{"DE", Me.dtpFI.Value}, {"A", Me.dtpFF.Value}, {"STATUS", Me.cbStatus.SelectedText}, {"FOLIO", Me.txtFolio.Text.Trim}, {"CLIENTE", Me.txtRazonSocial.Text.Trim}}
                Help.imprimeReporte("R_FV002", Me.DS_FV002, Me.Name, ,, Parametros)
        End Select
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Me.refrescar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim Parametros As Object(,) = {{"DE", Me.dtpFI.Value}, {"A", Me.dtpFF.Value}, {"STATUS", Me.cbStatus.SelectedText}, {"FOLIO", Me.txtFolio.Text.Trim}, {"CLIENTE", Me.txtRazonSocial.Text.Trim}}
        Help.imprimeReporte("R_FV002", Me.DS_FV002, Me.Name, ,, Parametros)
    End Sub
End Class