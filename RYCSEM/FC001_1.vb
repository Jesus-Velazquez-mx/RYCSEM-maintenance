Public Class FC001_1
    Dim row As DS_FC001_1.refencia_clientesRow
    Sub New(Optional ByVal cod_cte As String = "")

        ' This call is required by the designer.
        InitializeComponent()
        Me.cliente = cod_cte
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Dim cliente As String = ""
    Private Sub FC001_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.Habilita(False)
        Me.sdaStatus.Fill(Me.DS_FC001_1.status)
        Me.refrescar()
    End Sub
    Private Sub MToolBar1_ButtonClick(indice As Integer) Handles MToolBar1.ButtonClick
        Select Case indice
            Case 6 'nuevo
                Me.nuevo()
            Case 7 'modificar
                If Me.DS_FC001_1.refencia_clientes.Count = 0 Then
                    Me.MToolBar1.Habilita_Guardar()
                    Exit Sub
                End If
                Me.Habilita(True)
                Me.dgReferencias.Enabled = False
            Case 9 'guardar
                If Me.validar() Then
                    Me.txtCod_Ref.Focus()
                    Me.guardar()
                End If
            Case 10 'deshacer
                Me.deshacer()
        End Select
    End Sub
    Private Function obtieneFolio() As Integer
        Dim f As Integer = Help.obtieneDato("SELECT TOP 1 cod_cte +1 FROM refencia_clientes ORDER BY cod_cte DESC")
        Return IIf(f = 0, 1, f)
    End Function
    Private Function validar() As Boolean
        If Me.txtNombre.Text.Trim = "" Then
            MsgBox("Ingrese un nombre", MsgBoxStyle.Information)
            Return False
        End If
        'If .Text.Trim = "" Then
        '    MsgBox("Ingrese apellido paterno", MsgBoxStyle.Information)
        '    Return False
        'End If
        If Me.txtTelefono.Text.Trim = "" Then
            MsgBox("Ingrese teléfono", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function
    Private Sub guardar()
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction

            Me.sdaReferencias.InsertCommand.Transaction = Help.MyTrans
            Me.sdaReferencias.UpdateCommand.Transaction = Help.MyTrans
            Me.sdaReferencias.DeleteCommand.Transaction = Help.MyTrans
            If Me.MToolBar1.Band = "N" Then Me.row.cod_ref = Me.obtieneFolio()
            Me.BindingContext(Me.dvReferencias).EndCurrentEdit()
            Me.sdaReferencias.Update(Me.DS_FC001_1.refencia_clientes)
            Help.MyTrans.Commit()
            MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
            Me.Habilita(False)
            Me.dgReferencias.Enabled = True
            Me.refrescar()
            Me.MToolBar1.Habilita_Guardar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
            Me.txtCodCte.Text = ""
        End Try
    End Sub
    Private Sub deshacer()
        Me.Habilita(False)
        Me.dgReferencias.Enabled = True
        Me.refrescar()
        Me.MToolBar1.Habilita_Guardar()
    End Sub
    Private Sub refrescar()
        Me.DS_FC001_1.refencia_clientes.Clear()
        Me.sdaReferencias.SelectCommand.Parameters("@cod_cte").Value = Me.cliente
        Me.sdaReferencias.Fill(Me.DS_FC001_1)
        'If Me.sdaReferencias.Fill(Me.DS_FC001_1) = 0 Then
        '    MsgBox("Éste cliente no tiene referencias registradas", MsgBoxStyle.Information)
        'End If
    End Sub
    Private Sub nuevo()
        Me.row = Me.DS_FC001_1.refencia_clientes.NewRow
        Me.Habilita(True)
        row = Me.DS_FC001_1.refencia_clientes.NewRow
        row.cod_ref = Me.obtieneFolio()
        row.cod_cte = Me.cliente
        row.nombre = ""
        row.telefono = ""
        row.cliente = False
        row.cod_cteRef = 0
        row.status = "V"
        row.usuario = Help.usuario.Trim
        Me.DS_FC001_1.refencia_clientes.Addrefencia_clientesRow(row)
        Me.MToolBar1.Habilita_Nuevo()
        Me.txtNombre.Focus()
        Me.dgReferencias.Enabled = False
        Me.BindingContext(Me.dvReferencias).Position = Help.dataViewPos(Me.dvReferencias, row.cod_ref.ToString.Trim)
        Me.txtCod_Ref.Text = row.cod_ref.ToString.Trim
    End Sub
    Private Sub Habilita(ByRef valor As Boolean)
        Help.SetAll(Me, "Enabled", valor, "Textbox")
        Help.SetAll(Me, "Enabled", valor, "ComboBox")
        Me.chkCliente.Enabled = valor
        Me.txtCod_Ref.Enabled = Not Me.txtCod_Ref.Enabled
    End Sub

    Private Sub txtCod_Ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCod_Ref.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.posicion(Me.txtCod_Ref.Text.Trim)
        End If
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("referencia_clientes")
            F.ShowDialog()
            Me.txtCod_Ref.Text = F.codigo.Trim
        End If
    End Sub
    Private Sub posicion(Optional ByVal cod_cte As String = "")
        Dim pos As Integer
        If cod_cte.Trim <> "" Then
            pos = Help.dataViewPos(Me.dvReferencias, cod_cte)
        Else
            pos = Me.BindingContext(Me.dvReferencias).Position
        End If

        If pos < 0 Then
            MsgBox("Referencia no registrada", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.txtCod_Ref.Text = Me.dvReferencias(pos)!cod_ref.ToString.Trim
        Me.BindingContext(Me.dvReferencias).Position = pos
    End Sub

    Private Sub dgReferencias_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgReferencias.CurrentCellChanged
        Me.posicion()
    End Sub

    Private Sub txtCodCte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCte.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("clientes")
            F.ShowDialog()
            Dim cod_cteRef As Integer = F.codigo.Trim
            Me.txtCodCte.Text = cod_cteRef
            Me.txtNombre.Text = Help.obtieneDato("SELECT dbo.nombreCompleto(" & cod_cteRef & ",'C')")
        End If
        If e.KeyCode = Keys.Enter Then
            Me.txtNombre.Text = Help.obtieneDato("SELECT dbo.nombreCompleto(" & Me.txtCodCte.Text.Trim & ",'C')")
        End If
    End Sub
End Class