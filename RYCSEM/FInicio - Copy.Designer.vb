<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FInicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.DS_FInicio = New RYCSEM.DS_FInicio()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.sdaUsuario = New System.Data.SqlClient.SqlDataAdapter()
        Me.btnCambiarContra = New System.Windows.Forms.Button()
        Me.gbCambiarContrasena = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtNvaContraConf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNvaContra = New System.Windows.Forms.TextBox()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaLogin = New System.Data.SqlClient.SqlDataAdapter()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.sqlUpdateContra = New System.Data.SqlClient.SqlCommand()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DS_FInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCambiarContrasena.SuspendLayout()
        Me.gbLogin.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Contraseña"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(99, 104)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.Location = New System.Drawing.Point(180, 104)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(93, 23)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(99, 52)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(49, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(99, 78)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(174, 20)
        Me.txtContrasena.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DS_FInicio, "usuarios.nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(154, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(214, 20)
        Me.txtNombre.TabIndex = 2
        '
        'DS_FInicio
        '
        Me.DS_FInicio.DataSetName = "DS_FInicio"
        Me.DS_FInicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(12, 561)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(937, 15)
        Me.Panel1.TabIndex = 19
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        usuario, nombre + ' ' + ap_paterno + ' ' + ap_Materno AS nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FR" &
    "OM            usuarios WITH (NOLOCK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (usuario = @user)"
        Me.SqlSelectCommand1.CommandTimeout = 999999
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@user", System.Data.SqlDbType.[Char], 10, "usuario")})
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'sdaUsuario
        '
        Me.sdaUsuario.SelectCommand = Me.SqlSelectCommand1
        Me.sdaUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'btnCambiarContra
        '
        Me.btnCambiarContra.Location = New System.Drawing.Point(279, 104)
        Me.btnCambiarContra.Name = "btnCambiarContra"
        Me.btnCambiarContra.Size = New System.Drawing.Size(28, 23)
        Me.btnCambiarContra.TabIndex = 6
        Me.btnCambiarContra.Text = "***"
        Me.btnCambiarContra.UseVisualStyleBackColor = True
        '
        'gbCambiarContrasena
        '
        Me.gbCambiarContrasena.Controls.Add(Me.btnCancelar)
        Me.gbCambiarContrasena.Controls.Add(Me.btnConfirmar)
        Me.gbCambiarContrasena.Controls.Add(Me.txtNvaContraConf)
        Me.gbCambiarContrasena.Controls.Add(Me.Label5)
        Me.gbCambiarContrasena.Controls.Add(Me.Label4)
        Me.gbCambiarContrasena.Controls.Add(Me.txtNvaContra)
        Me.gbCambiarContrasena.Location = New System.Drawing.Point(49, 45)
        Me.gbCambiarContrasena.Name = "gbCambiarContrasena"
        Me.gbCambiarContrasena.Size = New System.Drawing.Size(326, 112)
        Me.gbCambiarContrasena.TabIndex = 21
        Me.gbCambiarContrasena.TabStop = False
        Me.gbCambiarContrasena.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(229, 69)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(130, 69)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 9
        Me.btnConfirmar.Text = "Guardar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtNvaContraConf
        '
        Me.txtNvaContraConf.Location = New System.Drawing.Point(130, 43)
        Me.txtNvaContraConf.Name = "txtNvaContraConf"
        Me.txtNvaContraConf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNvaContraConf.Size = New System.Drawing.Size(174, 20)
        Me.txtNvaContraConf.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Confirmar contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nueva contraseña"
        '
        'txtNvaContra
        '
        Me.txtNvaContra.Location = New System.Drawing.Point(130, 13)
        Me.txtNvaContra.Name = "txtNvaContra"
        Me.txtNvaContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNvaContra.Size = New System.Drawing.Size(174, 20)
        Me.txtNvaContra.TabIndex = 7
        '
        'gbLogin
        '
        Me.gbLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLogin.Controls.Add(Me.gbCambiarContrasena)
        Me.gbLogin.Controls.Add(Me.txtUsuario)
        Me.gbLogin.Controls.Add(Me.Label1)
        Me.gbLogin.Controls.Add(Me.btnCambiarContra)
        Me.gbLogin.Controls.Add(Me.Label2)
        Me.gbLogin.Controls.Add(Me.txtNombre)
        Me.gbLogin.Controls.Add(Me.Label3)
        Me.gbLogin.Controls.Add(Me.txtContrasena)
        Me.gbLogin.Controls.Add(Me.btnAceptar)
        Me.gbLogin.Controls.Add(Me.btnCerrarSesion)
        Me.gbLogin.Location = New System.Drawing.Point(491, 478)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(381, 163)
        Me.gbLogin.TabIndex = 23
        Me.gbLogin.TabStop = False
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "dbo.Login"
        Me.SqlSelectCommand2.CommandTimeout = 99999
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 5), New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.VarChar, 10)})
        '
        'sdaLogin
        '
        Me.sdaLogin.SelectCommand = Me.SqlSelectCommand2
        Me.sdaLogin.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Login", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnClientes)
        Me.gbOpciones.Controls.Add(Me.btnProveedores)
        Me.gbOpciones.Controls.Add(Me.btnVentas)
        Me.gbOpciones.Controls.Add(Me.btnInventario)
        Me.gbOpciones.Location = New System.Drawing.Point(12, 12)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(184, 505)
        Me.gbOpciones.TabIndex = 24
        Me.gbOpciones.TabStop = False
        '
        'btnClientes
        '
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.Location = New System.Drawing.Point(31, 36)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(110, 90)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.Image = Global.RYCSEM.My.Resources.Resources.proveedores
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProveedores.Location = New System.Drawing.Point(31, 146)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(110, 90)
        Me.btnProveedores.TabIndex = 2
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Image = Global.RYCSEM.My.Resources.Resources.ventas
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVentas.Location = New System.Drawing.Point(31, 256)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(110, 90)
        Me.btnVentas.TabIndex = 3
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.Image = Global.RYCSEM.My.Resources.Resources.inventario
        Me.btnInventario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInventario.Location = New System.Drawing.Point(31, 366)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(110, 90)
        Me.btnInventario.TabIndex = 9
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'sqlUpdateContra
        '
        Me.sqlUpdateContra.CommandText = "UPDATE       usuarios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                contrasena = @contrasena" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        " &
    "(usuario = @usuario)"
        Me.sqlUpdateContra.CommandTimeout = 9999
        Me.sqlUpdateContra.Connection = Me.sqlConn
        Me.sqlUpdateContra.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@contrasena", System.Data.SqlDbType.VarChar, 20, "contrasena"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(734, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(179, 197)
        Me.Panel2.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.RYCSEM.My.Resources.Resources.Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 653)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FInicio"
        Me.Text = "DISCOMSIN"
        CType(Me.DS_FInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCambiarContrasena.ResumeLayout(False)
        Me.gbCambiarContrasena.PerformLayout()
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents sdaUsuario As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FInicio As DS_FInicio
    Friend WithEvents btnCambiarContra As Button
    Friend WithEvents gbCambiarContrasena As GroupBox
    Friend WithEvents txtNvaContra As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtNvaContraConf As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaLogin As SqlClient.SqlDataAdapter
    Friend WithEvents gbOpciones As GroupBox
    Friend WithEvents sqlUpdateContra As SqlClient.SqlCommand
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Panel2 As Panel
End Class
