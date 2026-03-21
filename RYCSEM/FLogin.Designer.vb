<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FLogin))
        Me.gbCambiarContrasena = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtClaveAdmin = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtNvaContraConf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNvaContra = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.DS_FLogin = New RYCSEM.DS_FLogin()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SqlCC = New System.Data.SqlClient.SqlConnection()
        Me.sdaUsuario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sdaLogin = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateContra = New System.Data.SqlClient.SqlCommand()
        Me.LinkRC = New System.Windows.Forms.LinkLabel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbCambiarContrasena.SuspendLayout()
        CType(Me.DS_FLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCambiarContrasena
        '
        Me.gbCambiarContrasena.Controls.Add(Me.BtnCancel)
        Me.gbCambiarContrasena.Controls.Add(Me.Label1)
        Me.gbCambiarContrasena.Controls.Add(Me.TxtClaveAdmin)
        Me.gbCambiarContrasena.Controls.Add(Me.btnConfirmar)
        Me.gbCambiarContrasena.Controls.Add(Me.txtNvaContraConf)
        Me.gbCambiarContrasena.Controls.Add(Me.Label5)
        Me.gbCambiarContrasena.Controls.Add(Me.Label4)
        Me.gbCambiarContrasena.Controls.Add(Me.txtNvaContra)
        Me.gbCambiarContrasena.Location = New System.Drawing.Point(-1, 120)
        Me.gbCambiarContrasena.Name = "gbCambiarContrasena"
        Me.gbCambiarContrasena.Size = New System.Drawing.Size(326, 149)
        Me.gbCambiarContrasena.TabIndex = 21
        Me.gbCambiarContrasena.TabStop = False
        Me.gbCambiarContrasena.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(229, 110)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 27
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = " Clave"
        '
        'TxtClaveAdmin
        '
        Me.TxtClaveAdmin.Location = New System.Drawing.Point(130, 17)
        Me.TxtClaveAdmin.Name = "TxtClaveAdmin"
        Me.TxtClaveAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClaveAdmin.Size = New System.Drawing.Size(174, 20)
        Me.TxtClaveAdmin.TabIndex = 25
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(130, 110)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 9
        Me.btnConfirmar.Text = "Guardar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtNvaContraConf
        '
        Me.txtNvaContraConf.Location = New System.Drawing.Point(130, 77)
        Me.txtNvaContraConf.Name = "txtNvaContraConf"
        Me.txtNvaContraConf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNvaContraConf.Size = New System.Drawing.Size(174, 20)
        Me.txtNvaContraConf.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Confirmar contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nueva contraseña"
        '
        'txtNvaContra
        '
        Me.txtNvaContra.Location = New System.Drawing.Point(130, 47)
        Me.txtNvaContra.Name = "txtNvaContra"
        Me.txtNvaContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNvaContra.Size = New System.Drawing.Size(174, 20)
        Me.txtNvaContra.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(26, 137)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(49, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Usuario"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DS_FLogin, "usuarios.nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(81, 137)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(214, 20)
        Me.txtNombre.TabIndex = 2
        '
        'DS_FLogin
        '
        Me.DS_FLogin.DataSetName = "DS_FLogin"
        Me.DS_FLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Contraseña"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(26, 187)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(269, 20)
        Me.txtContrasena.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(172, 223)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(123, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'SqlCC
        '
        Me.SqlCC.ConnectionString = "Data Source=CATYSO;Initial Catalog=RYCSEM2;Integrated Security=True"
        Me.SqlCC.FireInfoMessageEventOnUserErrors = False
        '
        'sdaUsuario
        '
        Me.sdaUsuario.SelectCommand = Me.SqlSelectCommand1
        Me.sdaUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        usuario, nombre + ' ' + ap_paterno + ' ' + ap_Materno AS nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FR" &
    "OM            usuarios WITH (NOLOCK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (usuario = @user)"
        Me.SqlSelectCommand1.CommandTimeout = 999999
        Me.SqlSelectCommand1.Connection = Me.SqlCC
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@user", System.Data.SqlDbType.[Char], 10, "usuario")})
        '
        'sdaLogin
        '
        Me.sdaLogin.SelectCommand = Me.SqlSelectCommand2
        Me.sdaLogin.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Login", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "dbo.Login"
        Me.SqlSelectCommand2.CommandTimeout = 99999
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.SqlCC
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 5), New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.VarChar, 10)})
        '
        'sqlUpdateContra
        '
        Me.sqlUpdateContra.CommandText = "UPDATE       usuarios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                contrasena = @contrasena" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        " &
    "(usuario = @usuario)"
        Me.sqlUpdateContra.CommandTimeout = 9999
        Me.sqlUpdateContra.Connection = Me.SqlCC
        Me.sqlUpdateContra.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@contrasena", System.Data.SqlDbType.VarChar, 20, "contrasena"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'LinkRC
        '
        Me.LinkRC.AutoSize = True
        Me.LinkRC.Location = New System.Drawing.Point(91, 255)
        Me.LinkRC.Name = "LinkRC"
        Me.LinkRC.Size = New System.Drawing.Size(143, 13)
        Me.LinkRC.TabIndex = 26
        Me.LinkRC.TabStop = True
        Me.LinkRC.Text = "¿Se te olvido tu contraseña?"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.Location = New System.Drawing.Point(172, 223)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(123, 23)
        Me.btnCerrarSesion.TabIndex = 27
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(326, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(26, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 288)
        Me.Controls.Add(Me.gbCambiarContrasena)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.LinkRC)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.gbCambiarContrasena.ResumeLayout(False)
        Me.gbCambiarContrasena.PerformLayout()
        CType(Me.DS_FLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCambiarContrasena As GroupBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtNvaContraConf As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNvaContra As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents SqlCC As SqlClient.SqlConnection
    Friend WithEvents sdaUsuario As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sdaLogin As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sqlUpdateContra As SqlClient.SqlCommand
    Friend WithEvents DS_FLogin As DS_FLogin
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkRC As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtClaveAdmin As TextBox
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Button1 As Button
End Class
