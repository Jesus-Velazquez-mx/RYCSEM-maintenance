Public Class FMovCaja

    Dim transaccion = "10"
    Dim Band As String = ""
    Dim UsuarioSesion As String
    Dim turnoid As Integer = 0


    Public Sub New(usuario As String)

        ' This call is required by the designer.
        InitializeComponent()
        UsuarioSesion = usuario
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FMovCaja_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.DS_FMovCaja.conceptos.AddconceptosRow("E", "Egreso")
        Me.DS_FMovCaja.conceptos.AddconceptosRow("I", "Ingreso")
        Me.DS_FMovCaja.conceptos.AddconceptosRow("", "")
        turnoid = Help.obtieneDato("select top 1 turnoid from turnos where usuario = '" & UsuarioSesion & "' and activo = 1 order by fecha_inicial desc")
        Me.cmbConcepto.SelectedValue = ""
        Me.Habilita(False)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Band = "N"
        Me.Nuevo()
    End Sub

    Private Sub Guardar()
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.CmdMovCaja.Transaction = Help.MyTrans
            If Me.Band = "N" Then Me.txtFolio.Text = Me.obtieneFolio()
            With Me.CmdMovCaja
                .Parameters("@folio").Value = Me.txtFolio.Text.Trim
                .Parameters("@transaccion").Value = Me.transaccion.Trim
                .Parameters("@tipo").Value = Me.cmbConcepto.SelectedValue
                .Parameters("@monto").Value = Me.numMonto.Value
                .Parameters("@fecha").Value = Now
                .Parameters("@turnoid").Value = turnoid
                .Parameters("@usuario").Value = UsuarioSesion
                .Parameters("@notas").Value = Me.txtNotas.Text.Trim
                .ExecuteNonQuery()
            End With
            Help.MyTrans.Commit()
            MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
            Me.Habilita(False)
            Me.Habilita_Guardar()
            Me.TraerMovimiento()
            Me.Imprimir()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
        End Try
    End Sub

    Private Sub Nuevo()
        Me.limpiar()
        Habilita(True)
        Me.txtFolio.Text = Me.obtieneFolio()
        Me.Habilita_Nuevo()
    End Sub

    Private Sub Habilita_Nuevo()
        Me.btnNuevo.Enabled = False ' Not valor
        Me.btnModificar.Enabled = False ' valor
        Me.btnGuardar.Enabled = True ' valor
        Me.btnDeshacer.Enabled = True 'valor
    End Sub

    Private Sub Habilita_Guardar()
        Me.btnNuevo.Enabled = True ' Not valor
        Me.btnModificar.Enabled = True ' False ' valor
        Me.btnGuardar.Enabled = False ' True ' valor
        Me.btnDeshacer.Enabled = False ' True 'valor
    End Sub

    Private Sub Habilita(valor As Boolean)
        Help.SetAll(Me, "Enabled", valor, "Textbox")
        Me.cmbConcepto.Enabled = valor
        Me.btnAceptar.Enabled = valor
        Me.txtFolio.Enabled = Not valor
        Me.btnAceptar.Enabled = Not valor
        Me.numMonto.Enabled = valor
    End Sub

    Private Function obtieneFolio() As String
        Dim Folio As String = ""
        Folio = Help.generaFolio(Me.sqlConn, Me.transaccion.Trim)
        If IsNothing(Folio) Then
            MsgBox("Error al generar folio.", MsgBoxStyle.Information)
            Me.txtFolio.Focus()
            Return ""
        End If
        Return Folio.Trim
    End Function

    Private Sub limpiar()
        Me.DS_FMovCaja.movimientos_caja.Clear()
        Me.txtFolio.Text = ""
        Me.cmbConcepto.SelectedValue = ""
        Me.numMonto.Value = 0
        Me.txtNotas.Text = ""
    End Sub

    Private Sub txtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolio.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtFolio.Text.Trim <> "" Then
            Me.TraerMovimiento()
        End If
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("movimientos_caja")
            F.ShowDialog()
            Me.txtFolio.Text = F.codigo.Trim
        End If
    End Sub

    Private Sub TraerMovimiento()
        Me.DS_FMovCaja.movimientos_caja.Clear()
        Me.SdaMovCaja.SelectCommand.Parameters("@Folio").Value = Me.txtFolio.Text.Trim
        If Me.SdaMovCaja.Fill(Me.DS_FMovCaja.movimientos_caja) > 0 Then
            Me.cmbConcepto.SelectedValue = Me.DS_FMovCaja.movimientos_caja(0).tipo.Trim
            Me.txtNotas.Text = Me.DS_FMovCaja.movimientos_caja(0).notas.Trim
            Me.numMonto.Value = Me.DS_FMovCaja.movimientos_caja(0).monto
        End If
    End Sub

    Private Sub btnDeshacer_Click(sender As Object, e As EventArgs) Handles btnDeshacer.Click
        Me.Band = "D"
        Me.limpiar()
        Me.Habilita(False)
        Me.Habilita_Guardar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Me.txtFolio.Text.Trim = "" Then
            MsgBox("Debe ingresar folio de movimiento a modificar.")
            Me.txtFolio.Focus()
            Exit Sub
        End If
        Me.Band = "M"
        Me.Habilita(True)
        Me.Habilita_Nuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Band = "G"
        Me.Guardar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Band = "I"
        Me.Imprimir()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub Imprimir()
        Help.imprimeReporte("R_FMovCaja", Me.DS_FMovCaja, Me.Name)
    End Sub

    Private Sub txtFolio_TextChanged(sender As Object, e As EventArgs) Handles txtFolio.TextChanged
        If Me.txtFolio.Text.Trim = "" Then
            Me.cmbConcepto.SelectedValue = ""
            Me.numMonto.Value = 0
            Me.txtNotas.Text = ""
        End If
    End Sub

End Class
