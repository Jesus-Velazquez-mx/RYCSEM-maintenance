Public Class FLogin
    Private Sub FLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.SqlCC.ConnectionString = Help.stringConexion
        Me.WindowState = FormWindowState.Normal
        Me.cerrarSesion()
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
            Me.DS_FLogin.usuarios.Clear()
            If Me.sdaUsuario.Fill(Me.DS_FLogin.usuarios) = 0 Then
                MsgBox("Ingrese un usuario válido", MsgBoxStyle.Information)
                Me.txtContrasena.ReadOnly = False
                'Me.btnCambiarContra.Enabled = False
                Exit Sub
            End If
            Me.txtUsuario.ReadOnly = True
            Me.txtContrasena.Focus()
        End If
        If e.KeyCode = Keys.F2 Then
            Dim F As New FBuscador("usuarios")
            F.ShowDialog()
            Me.txtUsuario.Text = F.codigo.Trim
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
        Me.DS_FLogin.Login.Clear()
        Me.sdaLogin.SelectCommand.Parameters("@usuario").Value = Me.txtUsuario.Text.Trim
        Me.sdaLogin.SelectCommand.Parameters("@clave").Value = Me.txtContrasena.Text.Trim
        Me.sdaLogin.Fill(Me.DS_FLogin)
        If Me.DS_FLogin.Login.Count() = 0 Then
            MsgBox("Usuario y/o contraseña no válida", MsgBoxStyle.Information)
            Me.cerrarSesion()
            Exit Sub
        End If
        Help.usuario = Me.DS_FLogin.Login(0).usuario.Trim
        Me.btnAceptar.Enabled = False
        Me.btnCerrarSesion.Enabled = True
        Me.txtContrasena.ReadOnly = True
        Me.btnCerrarSesion.Visible = True
        Me.LinkRC.Visible = False
        Me.CargarOpcion()
    End Sub
    Private Sub cerrarSesion()
        Me.txtUsuario.Focus()
        Me.txtUsuario.ReadOnly = False
        Me.txtContrasena.ReadOnly = False
        Me.limpiar()
        Me.btnAceptar.Enabled = True
        Me.LinkRC.Visible = True
        Me.btnCerrarSesion.Enabled = False
        Me.btnCerrarSesion.Visible = False
        Me.btnAceptar.Visible = True
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
            If Me.SqlCC.State <> ConnectionState.Open Then Me.SqlCC.Open()
            Help.MyTrans = Me.SqlCC.BeginTransaction
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
            'Me.btnCambiarContra.Enabled = False
            Me.gbCambiarContrasena.Visible = False
            Me.txtNvaContra.Text = ""
            Me.txtNvaContraConf.Text = ""
            Me.cerrarSesion()
        Catch ex As Exception
            Help.MyTrans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If Me.SqlCC.State <> ConnectionState.Closed Then Me.SqlCC.Close()
        End Try
    End Sub
    Private Sub limpiar()
        Me.DS_FLogin.usuarios.Clear()
        Me.txtContrasena.Text = ""
        Me.txtUsuario.Text = ""
    End Sub

    Private Sub LinkRC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRC.LinkClicked
        If Me.txtUsuario.Text.Trim = "" Then
            MsgBox("Debe ingresar un usuario valido.", MsgBoxStyle.Exclamation)
            Me.txtUsuario.Focus()
            Exit Sub
        End If
        Me.gbCambiarContrasena.Visible = True
        Me.TxtClaveAdmin.Enabled = True
        Me.txtNvaContra.Enabled = False
        Me.txtNvaContraConf.Enabled = False
    End Sub

    Private Function validaClaveAdmin(Clave As String) As Boolean
        If Help.obtieneDato("select count(*) from usuarios where contrasena = dbo.encriptado('" & Me.TxtClaveAdmin.Text.Trim & "')") > 0 Then
            Return True
        End If
        MsgBox("La clave ingresada no corresponde a ningun administrador.", MsgBoxStyle.Information)
        Return False
    End Function

    Private Sub TxtClaveAdmin_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtClaveAdmin.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TxtClaveAdmin.Text.Trim = "" Then
                MsgBox("Debe ingresar una clave valida.", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf Me.validaClaveAdmin(Me.TxtClaveAdmin.Text.Trim) Then
                Me.TxtClaveAdmin.Enabled = False
                Me.txtNvaContra.Enabled = True
                Me.txtNvaContraConf.Enabled = True
                Me.txtNvaContra.Focus()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.txtNvaContra.Text = ""
        Me.txtNvaContraConf.Text = ""
        Me.TxtClaveAdmin.Text = ""
        Me.gbCambiarContrasena.Visible = False
        Me.cerrarSesion()
    End Sub

    Private Sub CargarOpcion()
        Dim F As New FInicio(Me.txtUsuario.Text.Trim)
        F.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.txtUsuario.ReadOnly = False
        Me.txtUsuario.Focus()
        Me.txtNombre.Text = ""
    End Sub
End Class