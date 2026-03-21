Public Class FCorteCaja
    Dim UsuarioSesion As String
    Dim turnoID As Integer = 0
    Public finalizoTurno As Boolean = False

    Public Sub New(ByVal Usuario As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        UsuarioSesion = Usuario

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FPagos_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Normal
        Me.sdaUsuario.Fill(Me.DS_FCorteCaja.usuarios)
        Me.cmbUser.SelectedValue = UsuarioSesion
        turnoID = Help.obtieneDato("select top 1 turnoid from turnos where usuario = '" & UsuarioSesion & "' and activo = 1 order by fecha_inicial desc")
        Me.CorteCaja()
    End Sub

    Private Sub CorteCaja()
        Dim tot As Decimal, fondo As Decimal, ingresos As Decimal, egresos As Decimal, ve As Decimal, vt As Decimal, dpo As Decimal
        fondo = Help.obtieneDato("select dbo.ObtenerValor('" & turnoID & "', 'F')")
        ingresos = Help.obtieneDato("select dbo.ObtenerValor('" & turnoID & "', 'I')")
        egresos = Help.obtieneDato("select dbo.ObtenerValor('" & turnoID & "', 'E')")
        ve = Help.obtieneDato("select dbo.ObtenerValor('" & turnoID & "', 'VE')")
        vt = Help.obtieneDato("select dbo.ObtenerValor('" & turnoID & "', 'VT')")
        dpo = Help.obtieneDato("select dbo.ObtenerValor('" & turnoID & "', 'DP')")
        'Help.obtieneDato("Select sum(total) from notas_venta With(nolock) where fecha between '" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy 00:00") & "' and '" & Format(Me.DateTimePicker2.Value, "dd/MM/yyyy 23:59") & "'")
        Me.NumFondo.Value = fondo
        Me.numIngresos.Value = ingresos
        Me.numEgresos.Value = egresos
        Me.numTarjeta.Value = vt
        Me.NumEfectivo.Value = ve
        Me.numDeposito.Value = dpo
        tot = (fondo + ingresos + ve + vt + dpo) - egresos
        lTotal.Text = "$" + Format(tot, "##,##0.00")
    End Sub

    Private Sub FCorteCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F9 Then
            generarCorte()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        generarCorte()
    End Sub

    Private Sub generarCorte()
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.SqlTerminarTurno.Transaction = Help.MyTrans
            With Me.SqlTerminarTurno
                .Parameters("@turnoid").Value = turnoID
                .ExecuteNonQuery()
            End With
            Help.MyTrans.Commit()

            Me.DS_FCorteCaja.Agrupado.Clear()
            Me.DS_FCorteCaja.detalleVentas.Clear()
            Me.sdaTraerCorteCaja.SelectCommand.Parameters("@turnoID").Value = turnoID
            Me.sdaTraerCorteCaja.Fill(Me.DS_FCorteCaja)
            Help.imprimeReporte("R_FCORTECAJA_", Me.DS_FCorteCaja, Me.Name)
            finalizoTurno = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
        End Try
        Me.Close()
    End Sub
End Class