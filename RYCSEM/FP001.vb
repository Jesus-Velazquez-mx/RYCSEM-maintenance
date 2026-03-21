Public Class FP001
    Dim rPrv As DS_FP001_.proveedoresRow
    'Dim MyTrans As SqlClient.SqlTransaction
    Dim Trans As String = "11"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Maximized
        Me.Habilita(False)
        Me.sdaStatus.Fill(Me.DS_FP001_.status)
        Me.refrescar()
    End Sub
    Private Sub MToolBar1_ButtonClick(indice As Integer) Handles MToolBar1.ButtonClick
        Select Case indice
            Case 6 'nuevo
                Me.nuevo()
            Case 7 'modificar
                Me.Habilita(True)
                Me.dgProveedores.Enabled = False
            Case 9 'guardar
                If Me.validar() Then Me.guardar()
            Case 10 'deshacer
                Me.deshacer()
            Case 12 'imprimir
                Help.imprimeReporte("R_FP001", Me.DS_FP001_, Me.Name)
        End Select
    End Sub

    Private Sub Habilita(ByRef valor As Boolean)
        Help.SetAll(Me, "Enabled", valor, "Textbox")
        Help.SetAll(Me, "Enabled", valor, "ComboBox")
        Me.txtCodPrv.Enabled = Not Me.txtCodPrv.Enabled
    End Sub
    Private Sub refrescar()
        Me.DS_FP001_.proveedores.Clear()
        If Me.sdaProveedores.Fill(Me.DS_FP001_.proveedores) > 0 Then
            Me.BindingContext(Me.dvProveedores).Position = 0
            Me.txtCodPrv.Text = Me.dvProveedores(0)!cod_prv.ToString.Trim
        End If
    End Sub
    Private Function validar() As Boolean
        'If Me.txtRazonSocial.Text.Trim = "" Then
        '    MsgBox("Ingrese una razón social", MsgBoxStyle.Information)
        '    Return False
        'End If

        'If Me.txtCalleNum.Text.Trim = "" Then
        '    MsgBox("Ingrese numero de casa/oficina", MsgBoxStyle.Information)
        '    Return False
        'End If
        If Me.txtNombre.Text.Trim = "" And Me.txtRazonSocial.Text.Trim = "" Then
            MsgBox("Ingrese un nombre o razón social", MsgBoxStyle.Information)
            Return False
        End If
        If Me.txtRFC.Text.Trim = "" Then
            MsgBox("Ingrese un rfc de la empresa", MsgBoxStyle.Information)
            Return False
        End If
        'If Me.txtCalle.Text.Trim = "" Then
        '    MsgBox("Ingrese una dirección", MsgBoxStyle.Information)
        '    Return False
        'End If
        If Me.txtTelefono.Text.Trim = "" And Me.txtCel.Text.Trim = "" Then
            MsgBox("Ingrese un telefono fijo o celular", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function
    'Private Function obtieneFolio() As Integer
    '    Dim f As Integer = Help.obtieneDato("SELECT TOP 1 cod_prv +1 FROM proveedores ORDER BY cod_prv DESC")
    '    Return IIf(f = 0, 1, f)
    'End Function
    Private Function obtieneFolio() As String
        Dim Folio As String = ""
        Folio = Help.generaFolio(Me.sqlConn, Me.Trans.Trim)
        If IsNothing(Folio) Then
            MsgBox("Error al generar folio.", MsgBoxStyle.Information)
            Me.txtCodPrv.Focus()
            Return ""
        End If
        ' Dim f As Integer = Help.obtieneDato("SELECT TOP 1 cod_cte +1 FROM clientes ORDER BY cod_cte DESC")
        '  IIf(f = 0, 1, f)
        Return Folio.Trim
    End Function
    Private Sub deshacer()
        Me.Habilita(False)
        Me.dgProveedores.Enabled = True
        Me.refrescar()
        Me.MToolBar1.Habilita_Guardar()
    End Sub
    Private Sub guardar()
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.sdaProveedores.DeleteCommand.Transaction = Help.MyTrans
            Me.sdaProveedores.InsertCommand.Transaction = Help.MyTrans
            Me.sdaProveedores.UpdateCommand.Transaction = Help.MyTrans
            If Me.MToolBar1.Band = "N" Then
                Me.rPrv.cod_prv = Me.obtieneFolio()
                Me.rPrv.usuario = Help.usuario.Trim
            End If
            Me.BindingContext(Me.dvProveedores).EndCurrentEdit()
            Me.sdaProveedores.Update(Me.DS_FP001_.proveedores)


            Help.MyTrans.Commit()
            MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
            Me.Habilita(False)
            Me.dgProveedores.Enabled = True
            Me.refrescar()
            Me.MToolBar1.Habilita_Guardar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Help.MyTrans.Rollback()
        Finally
            If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
        End Try
    End Sub
    Private Sub nuevo()
        Me.Habilita(True)
        rPrv = Me.DS_FP001_.proveedores.NewRow
        rPrv.cod_prv = Me.obtieneFolio()
        rPrv.razon_social = ""
        rPrv.nombre = ""
        rPrv.rfc = ""
        rPrv.telefono = ""
        rPrv.calle = ""
        rPrv.status = "V"
        rPrv.banco = ""
        rPrv.cuenta = ""
        rPrv.vendedor = ""
        rPrv.telefonoVendedor = ""
        rPrv.usuario = Help.usuario.Trim
        Me.DS_FP001_.proveedores.AddproveedoresRow(rPrv)
        Me.MToolBar1.Habilita_Nuevo()
        Me.dgProveedores.Enabled = False
        Me.txtRazonSocial.Focus()
        Me.BindingContext(Me.dvProveedores).Position = Help.dataViewPos(Me.dvProveedores, rPrv.cod_prv.ToString.Trim)
        Me.txtCodPrv.Text = rPrv.cod_prv.ToString.Trim
    End Sub

    Private Sub txtCodPrv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodPrv.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.posicion(Me.txtCodPrv.Text.Trim)
        End If
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("proveedores")
            F.ShowDialog()
            Me.txtCodPrv.Text = F.codigo.Trim
        End If
    End Sub
    Private Sub posicion(Optional ByVal cod_prv As String = "")
        Dim pos As Integer
        If Me.DS_FP001_.proveedores.Count <= 0 Then Exit Sub
        If cod_prv.Trim <> "" Then
            pos = Help.dataViewPos(Me.dvProveedores, cod_prv)
        Else
            pos = Me.BindingContext(Me.dvProveedores).Position
        End If

        If pos < 0 Then
            MsgBox("Proveedor no registrado", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.txtCodPrv.Text = Me.dvProveedores(pos)!cod_prv.ToString.Trim
        Me.BindingContext(Me.dvProveedores).Position = pos
    End Sub

    Private Sub dgProveedores_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgProveedores.CurrentCellChanged
        Me.posicion()
    End Sub
End Class
