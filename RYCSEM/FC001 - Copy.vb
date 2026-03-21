Public Class FC001
    Dim rCliente As DS_FC001.clientesRow
    Dim Band As String = ""
    Dim Trans As String = "01" 'clientes 
    'Dim MyTrans As SqlClient.SqlTransaction
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.Habilita(False)
        Me.sdaStatus.Fill(Me.DS_FC001.status)
        Me.refrescar()
        Me.Habilita_Guardar()
    End Sub
    Private Sub Habilita(ByRef valor As Boolean)
        Help.SetAll(Me, "Enabled", valor, "Textbox")
        Help.SetAll(Me, "Enabled", valor, "ComboBox")
        Me.txtCodCte.Enabled = Not Me.txtCodCte.Enabled
    End Sub

    Private Function validar() As Boolean
        'If Me.txtRazonSocial.Text.Trim = "" Then
        '    MsgBox("Ingrese una razón social", MsgBoxStyle.Information)
        '    Return False
        'End If
        'If Me.txtRFC.Text.Trim = "" Then
        '    MsgBox("Ingrese un rfc de la empresa", MsgBoxStyle.Information)
        '    Return False
        'End If
        'If Me.txtNum.Text.Trim = "" Then
        '    MsgBox("Ingrese numero de casa/oficina", MsgBoxStyle.Information)
        '    Return False
        'End If
        If Me.txtNombre.Text.Trim = "" Then
            MsgBox("Ingrese un nombre", MsgBoxStyle.Information)
            Return False
        End If
        If txtApPat.Text.Trim = "" Then
            MsgBox("Ingrese apellido paterno", MsgBoxStyle.Information)
            Return False
        End If
        'If txtApMat.Text.Trim = "" Then
        '    MsgBox("Ingrese apellido materno", MsgBoxStyle.Information)
        '    Return False
        'End If
        If Me.txtTel1.Text.Trim = "" And Me.txtCel.Text.Trim = "" Then
            MsgBox("Ingrese un telefono fijo o celular", MsgBoxStyle.Information)
            Return False
        End If
        'If Me.txtCalle.Text.Trim = "" Then
        '    MsgBox("Ingrese calle de dirección", MsgBoxStyle.Information)
        '    Return False
        'End If
        'If Me.txtColonia.Text.Trim = "" Then
        '    MsgBox("Ingrese la colonia de la dirección", MsgBoxStyle.Information)
        '    Return False
        'End If

        Return True
    End Function
    Private Sub deshacer()
        Me.Habilita(False)
        Me.dgClientes.Enabled = True
        Me.refrescar()
        'Me.MToolBar1.Habilita_Guardar()
        Me.Habilita_Guardar()
    End Sub
    Private Sub guardar()
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.sdaClientes.DeleteCommand.Transaction = Help.MyTrans
            Me.sdaClientes.InsertCommand.Transaction = Help.MyTrans
            Me.sdaClientes.UpdateCommand.Transaction = Help.MyTrans
            'If Me.MToolBar1.Band = "N" Then Me.rCliente.cod_cte = Me.obtieneFolio()
            If Me.Band = "N" Then Me.rCliente.cod_cte = Me.obtieneFolio()
            Me.BindingContext(Me.dvClientes).EndCurrentEdit()
            Me.sdaClientes.Update(Me.DS_FC001.clientes)
            Help.MyTrans.Commit()
            MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
            Me.Habilita(False)
            Me.dgClientes.Enabled = True
            Me.refrescar()
            'Me.MToolBar1.Habilita_Guardar()
            Me.Habilita_Guardar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()

        End Try
    End Sub

    Private Function obtieneFolio() As String
        Dim Folio As String = ""
        Folio = Help.generaFolio(Me.sqlConn, Me.Trans.Trim)
        If IsNothing(Folio) Then
            MsgBox("Error al generar folio.", MsgBoxStyle.Information)
            Me.txtCodCte.Focus()
            Return ""
        End If
        ' Dim f As Integer = Help.obtieneDato("SELECT TOP 1 cod_cte +1 FROM clientes ORDER BY cod_cte DESC")
        '  IIf(f = 0, 1, f)
        Return Folio.Trim
    End Function
    Private Sub refrescar()
        Me.DS_FC001.clientes.Clear()
        If Me.sdaClientes.Fill(Me.DS_FC001.clientes) > 0 Then
            Me.BindingContext(Me.dvClientes).Position = 0
            Me.txtCodCte.Text = Me.dvClientes(0)!cod_cte.ToString.Trim
        End If
    End Sub
    Private Sub nuevo()
        Me.Habilita(True)
        rCliente = Me.DS_FC001.clientes.NewRow
        rCliente.cod_cte = Me.obtieneFolio()
        rCliente.razon_social = ""
        rCliente.nombre = ""
        rCliente.rfc = ""
        rCliente.ap_paterno = ""
        rCliente.ap_materno = ""
        rCliente.telefono = ""
        rCliente.extension = ""
        rCliente.telefono2 = ""
        rCliente.calle = ""
        rCliente.calle_num = ""
        rCliente.calle_entre1 = ""
        rCliente.calle_entre2 = ""
        rCliente.colonia = ""
        rCliente.cod_postal = ""
        rCliente.status = "V"
        rCliente.usuario = Help.usuario.Trim
        Me.DS_FC001.clientes.AddclientesRow(rCliente)
        'Me.MToolBar1.Habilita_Nuevo()
        Me.Habilita_Nuevo()
        Me.txtRazonSocial.Focus()
        Me.dgClientes.Enabled = False
        Me.BindingContext(Me.dvClientes).Position = Help.dataViewPos(Me.dvClientes, rCliente.cod_cte.ToString.Trim)
        Me.txtCodCte.Text = rCliente.cod_cte.ToString.Trim
    End Sub

    Private Sub txtCodCte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCte.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.posicion(Me.txtCodCte.Text.Trim)
        End If
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("clientes")
            F.ShowDialog()
            Me.txtCodCte.Text = F.codigo.Trim
        End If
    End Sub
    Private Sub posicion(Optional ByVal cod_cte As String = "")
        Dim pos As Integer
        If cod_cte.Trim <> "" Then
            pos = Help.dataViewPos(Me.dvClientes, cod_cte)
        Else
            pos = Me.BindingContext(Me.dvClientes).Position
        End If

        If pos < 0 Then
            MsgBox("Cliente no registrado", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.txtCodCte.Text = Me.dvClientes(pos)!cod_cte.ToString.Trim
        Me.BindingContext(Me.dvClientes).Position = pos
    End Sub
    Private Sub dgClientes_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgClientes.CurrentCellChanged
        Me.posicion()
    End Sub

    Private Sub btnReferencias_Click(sender As Object, e As EventArgs) Handles btnReferencias.Click
        Dim cte As String = Me.txtCodCte.Text.Trim
        If cte.Trim = "" Then Exit Sub
        Dim FRef As New FC001_1(cte.Trim)
        FRef.ShowDialog()
    End Sub
    Private Sub MToolBar1_ButtonClick(indice As Integer)
        Select Case indice
            Case 6 'nuevo
                Me.nuevo()
            Case 7 'modificar
                Me.Habilita(True)
                Me.dgClientes.Enabled = False
            Case 9 'guardar
                If Me.validar() Then Me.guardar()
            Case 10 'deshacer
                Me.deshacer()
            Case 12 'Imprimir
                Help.imprimeReporte("R_FC001", Me.DS_FC001, Me.Name)
        End Select
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Band = "N"
        Me.nuevo()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Me.dvClientes.Count <= 0 Then Exit Sub
        Me.Band = "M"
        Me.Habilita_Nuevo()
        Me.Habilita(True)
        Me.dgClientes.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Band = "G"
        If Me.validar() Then Me.guardar()
    End Sub

    Private Sub btnDeshacer_Click(sender As Object, e As EventArgs) Handles btnDeshacer.Click
        Me.Band = "D"
        Me.deshacer()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Band = "I"
        Help.imprimeReporte("R_FC001", Me.DS_FC001, Me.Name)
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
End Class
