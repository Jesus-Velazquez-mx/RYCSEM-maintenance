Public Class FInicio


    Private Sub FInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Help.inicializa() Then Me.Close()
        Me.sqlConn.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Maximized
        Me.cerrarSesion()
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim F As New FmenuClientes
        F.Show()
    End Sub
    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Dim F As New FmenuProveedores
        F.Show()
    End Sub
    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim F As New FmenuInventario
        F.Show()
    End Sub
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim F As New FmenuVentas
        F.Show()
    End Sub

    Private Sub btnCambiarContra_Click(sender As Object, e As EventArgs) Handles btnCambiarContra.Click
        Me.gbCambiarContrasena.Visible = True
        Me.habilita(False)
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        If Not validaCambioContra() Then Exit Sub
        Me.cambiarContrasena()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtUsuario.Text.Trim = "" Then
                MsgBox("Ingrese un usuario válido", MsgBoxStyle.Information)
                Me.txtContrasena.ReadOnly = False
                Exit Sub
            End If
            Me.sdaUsuario.SelectCommand.Parameters("@user").Value = Me.txtUsuario.Text.Trim
            Me.DS_FInicio.usuarios.Clear()
            If Me.sdaUsuario.Fill(Me.DS_FInicio.usuarios) = 0 Then
                MsgBox("Ingrese un usuario válido", MsgBoxStyle.Information)
                Me.txtContrasena.ReadOnly = False
                Me.btnCambiarContra.Enabled = False
                Exit Sub
            End If
            Me.txtUsuario.ReadOnly = True
            Me.txtContrasena.Focus()
        End If
    End Sub
    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.iniciaSesion()
        End If
    End Sub
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.cerrarSesion()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.txtNvaContra.Text = ""
        Me.txtNvaContraConf.Text = ""
        Me.gbCambiarContrasena.Visible = False
        Me.cerrarSesion()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.iniciaSesion()
    End Sub
    Private Sub iniciaSesion()
        If Me.txtUsuario.Text.Trim = "" Then
            MsgBox("Ingrese un usuario", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.txtContrasena.Text.Trim = "" Then
            MsgBox("Ingrese una contraseña", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.sdaLogin.SelectCommand.Parameters("@usuario").Value = Me.txtUsuario.Text.Trim
        Me.sdaLogin.SelectCommand.Parameters("@clave").Value = Me.txtContrasena.Text.Trim
        Me.DS_FInicio.login.Clear()
        If Me.sdaLogin.Fill(Me.DS_FInicio.login) = 0 Then
            MsgBox("Usuario y/o contraseña no válida", MsgBoxStyle.Information)
            Me.cerrarSesion()
            Exit Sub
        End If
        Help.usuario = Me.DS_FInicio.login(0).usuario.Trim
        Me.btnAceptar.Enabled = False
        Me.btnCambiarContra.Enabled = True
        Me.btnCerrarSesion.Enabled = True
        Me.txtContrasena.ReadOnly = True
        Me.habilita(True)
    End Sub
    Private Sub cerrarSesion()
        Me.txtUsuario.Focus()
        Me.txtUsuario.ReadOnly = False
        Me.txtContrasena.ReadOnly = False
        Me.limpiar()
        Me.habilita(False)
        Me.btnAceptar.Enabled = True
        Me.btnCambiarContra.Enabled = False
        Me.btnCerrarSesion.Enabled = False
    End Sub
    Private Function validaCambioContra() As Boolean
        If Me.txtNvaContraConf.Text.Trim.Length >= 20 Or Me.txtNvaContraConf.Text.Trim.Length >= 20 Then
            MsgBox("La longitud de la contraseña debe ser máximo 20 caracteres", MsgBoxStyle.Information)
            Return False
        End If
        If Me.txtNvaContra.Text.Trim = "" Then
            MsgBox("Ingrese la nueva contraseña", MsgBoxStyle.Information)
            Return False
        End If
        If Me.txtNvaContraConf.Text.Trim = "" Then
            MsgBox("Confirme la nueva contraseña", MsgBoxStyle.Information)
            Return False
        End If
        If Me.txtNvaContra.Text.Trim <> Me.txtNvaContraConf.Text.Trim Then
            MsgBox("La contraseña ingresada no coincide", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function
    Private Sub cambiarContrasena()
        Try
            If Me.sqlConn.State <> ConnectionState.Open Then Me.sqlConn.Open()
            Help.MyTrans = Me.sqlConn.BeginTransaction
            Me.sqlUpdateContra.Transaction = Help.MyTrans
            Dim cveS As String = Help.obtieneDato("SELECT dbo.Encriptado('" & Me.txtNvaContra.Text.Trim & "')")
            If cveS Is Nothing Then
                MsgBox("Error al guardar la clave. Intente de nuevo", MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.sqlUpdateContra.Parameters("@usuario").Value = Me.txtUsuario.Text.Trim
            Me.sqlUpdateContra.Parameters("@contrasena").Value = cveS
            Me.sqlUpdateContra.ExecuteNonQuery()
            Help.MyTrans.Commit()
            MsgBox("Datos registrados exitosamente", MsgBoxStyle.Information)
            Me.btnCambiarContra.Enabled = False
            Me.gbCambiarContrasena.Visible = False
            Me.txtNvaContra.Text = ""
            Me.txtNvaContraConf.Text = ""
            Me.cerrarSesion()
        Catch ex As Exception
            Help.MyTrans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If Me.sqlConn.State <> ConnectionState.Closed Then Me.sqlConn.Close()
        End Try
    End Sub
    Private Sub limpiar()
        Me.DS_FInicio.usuarios.Clear()
        Me.txtContrasena.Text = ""
        Me.txtUsuario.Text = ""
    End Sub

    Private Sub habilita(ByVal valor As Boolean)
        Me.gbOpciones.Enabled = valor
    End Sub

End Class