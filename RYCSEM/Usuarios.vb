Public Class Usuarios
    Dim BandChk As Boolean = False
    Dim BandChk2 As Boolean = False
    Dim BandNuevo As Boolean = False
    Dim Band As Boolean = False

    Public MyTrans As SqlClient.SqlTransaction

    Private Sub Usuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.habilita_botones(True)
        Me.Habilita_controles(False)
        Me.BtnCambiarContra.Visible = False
        Me.informacion_default()
        Me.Refrescar()
    End Sub

    Private Sub habilita_botones(ByVal valor As Boolean)
        Me.BtnNuevo.Enabled = valor
        Me.BtnModificar.Enabled = valor
        Me.BtnGuardar.Enabled = Not valor
        Me.BtnDeshacer.Enabled = Not valor
        Me.BtnCancelar.Enabled = valor
    End Sub

    Private Sub Habilita_controles(ByVal valor As Boolean)
        Help.SetAll(Me.GroupBox2, "Enabled", valor, "TextBox")
        Me.PB1.Enabled = valor
        Me.PbAdmin.Enabled = valor
        If Not Me.BandNuevo Then
            Me.TxtContraseña.Enabled = False
            Me.TxtConfContraseña.Enabled = False
            Me.PB1.Enabled = False
        End If
    End Sub

    Private Sub PB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB1.Click
        If Me.Band Then Exit Sub
        If Me.BandChk Then
            'Me.PB1.BackgroundImage = RYCSEM.My.Resources.Resources.check_2
            Me.TxtContraseña.Text = "Contraseña"
            Me.TxtContraseña.ForeColor = Color.LightGray
            Me.TxtConfContraseña.Text = "Confirmar contraseña"
            Me.TxtConfContraseña.ForeColor = Color.LightGray
            Me.TxtContraseña.PasswordChar = ""
            Me.TxtConfContraseña.PasswordChar = ""
            Me.BandChk = False
        Else
            ' Me.PB1.BackgroundImage = RYCSEM.My.Resources.Resources.check_1
            Me.TxtContraseña.Text = "0123456789"
            Me.TxtConfContraseña.Text = "0123456789"
            Me.TxtContraseña.PasswordChar = "*"
            Me.TxtConfContraseña.PasswordChar = "*"
            Me.BandChk = True
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If Not Me.ValidaGuardar Then Exit Sub
        Dim contraseña As String = Me.TxtContraseña.Text.Trim
        ' If Not Me.BandChk Then contraseña = Help.Encriptado(Me.TxtContraseña.Text.Trim)
        Dim usuario As String = Me.TxtUsuario.Text.Trim
        If Me.BandNuevo Then usuario = Help.obtieneDato("select isnull(MAX(cast(usuario as int)), 0) + 1 from usuarios")
        Dim admin As Boolean = False
        If Me.BandChk2 Then admin = True
        Try
            If Me.SqlConnection1.State = ConnectionState.Closed Then Me.SqlConnection1.Open()
            MyTrans = Me.SqlConnection1.BeginTransaction
            Me.SdaUsuarios.DeleteCommand.Transaction = MyTrans
            Me.SdaUsuarios.InsertCommand.Transaction = MyTrans

            If Not Me.BandNuevo Then
                With Me.SdaUsuarios.DeleteCommand
                    .Parameters("@usuario").Value = usuario
                    .ExecuteNonQuery()
                End With
            End If

            With Me.SdaUsuarios.InsertCommand
                .Parameters("@usuario").Value = usuario
                .Parameters("@nombre").Value = Me.TxtUsuarioNombre.Text.Trim
                .Parameters("@contraseña").Value = contraseña
                .Parameters("@status").Value = "V"
                .Parameters("@administrador").Value = admin
                .ExecuteNonQuery()
            End With
            MyTrans.Commit()
            MsgBox("Usuario guardado correctamente", MsgBoxStyle.Information)
            Me.BtnCambiarContra.Visible = False
            Me.DgUsuarios.Enabled = True
            Me.Refrescar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        Me.habilita_botones(True)
        Me.Habilita_controles(False)
        Me.BandNuevo = False
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim usuario As String = Help.obtieneDato("select isnull(MAX(cast(usuario as int)), 0) + 1 from usuarios")
        Me.TxtUsuario.Text = usuario
        Me.DS_Usuarios.usuarios.AddusuariosRow(usuario, "", "", "V", False)
        Me.habilita_botones(False)
        Me.BandNuevo = True
        Me.Habilita_controles(True)
        Me.informacion_default()
        Me.BindingContext(Me.DvUsuarios).Position = Me.DvUsuarios.Count - 1
        Me.DgUsuarios.Enabled = False
        Me.TxtUsuarioNombre.Focus()
        Me.habilita_botones(False)
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Dim p As Integer = Me.BindingContext(Me.DvUsuarios).Position
        If p < 0 Then Exit Sub
        If Me.DvUsuarios(p)!status = "C" Then
            MsgBox("El usuario se encuentra cancelado no se puede modificar", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.habilita_botones(False)
        Me.BandNuevo = False
        Me.Habilita_controles(True)
        Me.BtnCambiarContra.Visible = True
        Me.DgUsuarios.Enabled = False
    End Sub

    Public Sub informacion_default()
        Me.Band = True
        Me.TxtUsuarioNombre.Text = "Nombre usuario"
        Me.TxtUsuarioNombre.ForeColor = Color.LightGray
        Me.TxtContraseña.Text = "Contraseña"
        Me.TxtContraseña.ForeColor = Color.LightGray
        Me.TxtConfContraseña.Text = "Confirmar contraseña"
        Me.TxtConfContraseña.ForeColor = Color.LightGray
        Me.TxtContraseña.PasswordChar = ""
        Me.TxtConfContraseña.PasswordChar = ""
        '  Me.PB1.BackgroundImage = RYCSEM.My.Resources.Resources.check_2
        ' Me.PbAdmin.BackgroundImage = RYCSEM.My.Resources.Resources.check_2
        Me.Band = False
    End Sub

    Private Sub PbAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbAdmin.Click
        If Me.Band Then Exit Sub
        If Me.BandChk2 Then
            'Me.PbAdmin.BackgroundImage = RYCSEM.My.Resources.Resources.check_2
            Me.BandChk2 = False
        Else
            'Me.PbAdmin.BackgroundImage = RYCSEM.My.Resources.Resources.check_1
            Me.BandChk2 = True
        End If
    End Sub

    Private Sub TxtUsuarioNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUsuarioNombre.TextChanged
        If Not Me.Band Then
            Me.TxtUsuarioNombre.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtContraseña.TextChanged
        If Not Me.Band Then
            Me.TxtContraseña.ForeColor = Color.Black
            Me.TxtContraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub TxtConfContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtConfContraseña.TextChanged
        If Not Me.Band Then
            Me.TxtConfContraseña.ForeColor = Color.Black
            Me.TxtConfContraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub Refrescar()
        Me.DS_Usuarios.usuarios.Clear()
        Me.SdaUsuarios.Fill(Me.DS_Usuarios.usuarios)
        Me.Ligar()
    End Sub

    Private Sub TxtContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtContraseña.Click
        Me.TxtContraseña.SelectAll()
    End Sub

    Private Sub TxtConfContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtConfContraseña.Click
        Me.TxtConfContraseña.SelectAll()
    End Sub

    Private Sub MyDataGrid1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DgUsuarios.CurrentCellChanged
        Me.Ligar()
    End Sub

    Private Sub BtnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeshacer.Click
        Me.habilita_botones(True)
        Me.BtnCambiarContra.Visible = False
        Me.DgUsuarios.Enabled = True
        Me.Refrescar()
    End Sub

    Private Sub Ligar()
        Dim p As Integer = Me.BindingContext(Me.DvUsuarios).Position
        If p < 0 Then Exit Sub
        Me.TxtUsuarioNombre.Text = Me.DvUsuarios(p)!nombre
        Me.TxtContraseña.Text = Me.DvUsuarios(p)!contraseña
        Me.TxtUsuario.Text = Me.DvUsuarios(p)!usuario
        Me.TxtConfContraseña.Text = Me.DvUsuarios(p)!contraseña
        'If Me.DvUsuarios(p)!administrador Then Me.PbAdmin.BackgroundImage = RYCSEM.My.Resources.Resources.check_1 Else _
        'Me.PbAdmin.BackgroundImage = RYCSEM.My.Resources.Resources.check_2
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Dim p As Integer = Me.BindingContext(Me.DvUsuarios).Position
        If p < 0 Then Exit Sub
        If Me.DvUsuarios(p)!status = "C" Then
            MsgBox("El usuario ya se encuentra cancelado", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            If Me.SqlConnection1.State = ConnectionState.Closed Then Me.SqlConnection1.Open()
            MyTrans = Me.SqlConnection1.BeginTransaction
            Me.SdaUsuarios.UpdateCommand.Transaction = MyTrans

            Me.SdaUsuarios.UpdateCommand.Parameters("@usuario").Value = Me.DvUsuarios(p)!usuario
            Me.SdaUsuarios.UpdateCommand.ExecuteNonQuery()
            MyTrans.Commit()
            MsgBox("Usuario cancelado correctamente", MsgBoxStyle.Information)
            Me.Refrescar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Function ValidaGuardar() As Boolean
        If Me.TxtUsuarioNombre.ForeColor = Color.LightGray Then
            MsgBox("Debe ingresar nombre.", MsgBoxStyle.Information)
            Me.TxtUsuarioNombre.Focus()
            Me.TxtUsuarioNombre.SelectAll()
            Return False
        ElseIf Me.TxtContraseña.ForeColor = Color.LightGray Then
            MsgBox("Debe ingresar contraseña.", MsgBoxStyle.Information)
            Me.TxtContraseña.Focus()
            Me.TxtContraseña.SelectAll()
            Return False
        ElseIf Me.TxtConfContraseña.ForeColor = Color.LightGray Then
            MsgBox("Debe confirmar contraseña.", MsgBoxStyle.Information)
            Me.TxtConfContraseña.Focus()
            Me.TxtConfContraseña.SelectAll()
            Return False
        ElseIf Me.TxtContraseña.Text.Length > 10 Then
            MsgBox("Sobrepasa el limite máximo de carácteres para la contraseña.", MsgBoxStyle.Information)
            Me.TxtContraseña.Focus()
            Me.TxtContraseña.SelectAll()
            Return False
        ElseIf Me.TxtContraseña.Text.Trim <> Me.TxtConfContraseña.Text.Trim Then
            MsgBox("Las contraseñas ingresadas no son iguales.", MsgBoxStyle.Information)
            Me.TxtConfContraseña.Focus()
            Me.TxtConfContraseña.SelectAll()
            Return False
        End If
        Return True
    End Function
End Class