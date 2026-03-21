Public Class FPagos
    Dim Total As String
    Public Pagado As Boolean = False
    Public FP As String = "01"
    Public FolNota As String = ""

    Public Sub New(Tot As Decimal, Folio As String)
        ' This call is required by the designer.
        InitializeComponent()
        Me.Total = Format(Tot, "##,##0.00")
        Me.FolNota = Folio
        Me.numPagoEF.Value = 0
        Me.numPagoTC.Value = 0
        Me.numPagoTD.Value = 0
        Me.numDeposito.Value = 0
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub FPagos_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Normal
        Me.lTotal.Text = "$" + Total
    End Sub

    Private Sub Cambio(Pago As Decimal)
        Dim TotPagar As Decimal = CDec(Me.Total)
        If Pago <= TotPagar Then Exit Sub
        Dim cambioTot As Decimal = Pago - TotPagar
        Me.lCambio.Text = "$" + cambioTot.ToString.Trim
    End Sub

    Private Sub numPago_ValueChanged(sender As Object, e As EventArgs) Handles numPagoEF.ValueChanged
        Me.lCambio.Text = "$00.00"
        Me.pagar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.DS_FPagos.docs_formas_pago.Count = 0 Then Me.Close()
        Me.Pagado = False
        If Me.DS_FPagos.docs_formas_pago.Count > 0 Then
            Dim pago As Decimal = Me.DS_FPagos.docs_formas_pago.Compute("sum(monto)", "")
            Dim TotPagar As Decimal = CDec(Me.Total)
            If pago < TotPagar Then
                MsgBox("El monto ingresado es menor al monto a pagar.", MsgBoxStyle.Information)
                Me.numPagoEF.Focus()
                Exit Sub
            End If
            Me.Pagado = True
        End If
        If Not Me.Pagado Then
            MsgBox("No se realizo el pago.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub FPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F8 Then
            If Not Me.Pagado Then
                MsgBox("No se realizo el pago.", MsgBoxStyle.Information)
            End If
            Me.Close()
        End If
    End Sub

    'Formas Pago
    '01 Efectivo
    '02 Tarjeta de crédito
    '03 Tarjeta de débito

    Private Sub pagar()
        Me.DS_FPagos.docs_formas_pago.Clear()
        Dim Pago As Decimal = 0
        If Me.numPagoEF.Value > 0 Then
            Me.DS_FPagos.docs_formas_pago.Adddocs_formas_pagoRow(Me.FolNota, "01", Me.numPagoEF.Value)
        End If
        If Me.numPagoTC.Value > 0 Then
            Me.DS_FPagos.docs_formas_pago.Adddocs_formas_pagoRow(Me.FolNota, "02", Me.numPagoTC.Value)
        End If
        If Me.numPagoTD.Value > 0 Then
            Me.DS_FPagos.docs_formas_pago.Adddocs_formas_pagoRow(Me.FolNota, "03", Me.numPagoTD.Value)
        End If
        If Me.numDeposito.Value > 0 Then
            Me.DS_FPagos.docs_formas_pago.Adddocs_formas_pagoRow(Me.FolNota, "04", Me.numDeposito.Value)
        End If
        If Me.numCobroLk.Value > 0 Then
            Me.DS_FPagos.docs_formas_pago.Adddocs_formas_pagoRow(Me.FolNota, "05", Me.numCobroLk.Value)
        End If
        If Me.DS_FPagos.docs_formas_pago.Count = 0 Then Exit Sub
        Pago = Me.DS_FPagos.docs_formas_pago.Compute("sum(monto)", "")
        Cambio(Pago)
    End Sub

    Private Function validaPago() As Boolean
        Me.Pagado = False
        If Me.DS_FPagos.docs_formas_pago.Count = 0 Then Return False
        Dim pago As Decimal = Me.DS_FPagos.docs_formas_pago.Compute("sum(monto)", "")
        Dim TotPagar As Decimal = CDec(Me.Total)
        If pago < TotPagar Then
            MsgBox("El monto ingresado es menor al monto a pagar.", MsgBoxStyle.Information)
            Me.numPagoEF.Focus()
            Return False
        End If
        Me.Pagado = True
        Return True
    End Function

    Private Sub numPagoTC_ValueChanged(sender As Object, e As EventArgs) Handles numPagoTC.ValueChanged
        Me.lCambio.Text = "$00.00"
        Me.pagar()
    End Sub

    Private Sub numPagoTD_ValueChanged(sender As Object, e As EventArgs) Handles numPagoTD.ValueChanged
        Me.lCambio.Text = "$00.00"
        Me.pagar()
    End Sub

    Private Sub numDeposito_ValueChanged(sender As Object, e As EventArgs) Handles numDeposito.ValueChanged
        Me.lCambio.Text = "$00.00"
        Me.pagar()
    End Sub

    Private Sub numCobroLk_ValueChanged(sender As Object, e As EventArgs) Handles numCobroLk.ValueChanged
        Me.lCambio.Text = "$00.00"
        Me.pagar()
    End Sub
End Class