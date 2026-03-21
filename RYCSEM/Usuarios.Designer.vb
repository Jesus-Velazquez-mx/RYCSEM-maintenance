<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PbAdmin = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnCambiarContra = New System.Windows.Forms.Button
        Me.PB1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtConfContraseña = New System.Windows.Forms.TextBox
        Me.TxtContraseña = New System.Windows.Forms.TextBox
        Me.TxtUsuarioNombre = New System.Windows.Forms.TextBox
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DgUsuarios = New MyControls.MyDataGrid
        Me.DvUsuarios = New System.Data.DataView
        Me.DS_Usuarios = New RYCSEM.DS_Usuarios
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.MyDataGridView1 = New MyControls.MyDataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnDeshacer = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.BtnModificar = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SdaUsuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 618)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 97)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DgUsuarios)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MyDataGridView1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(823, 518)
        Me.SplitContainer1.SplitterDistance = 196
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PbAdmin)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.BtnCambiarContra)
        Me.GroupBox2.Controls.Add(Me.PB1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtConfContraseña)
        Me.GroupBox2.Controls.Add(Me.TxtContraseña)
        Me.GroupBox2.Controls.Add(Me.TxtUsuarioNombre)
        Me.GroupBox2.Controls.Add(Me.TxtUsuario)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(823, 196)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'PictureBox4
        '
        'Me.PictureBox4.BackgroundImage = Global.RYCSEM.My.Resources.Resources.contraseña
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(53, 140)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(44, 45)
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        ' Me.PictureBox3.BackgroundImage = Global.RYCSEM.My.Resources.Resources.contraseña
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(53, 87)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(44, 45)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        'Me.PictureBox2.BackgroundImage = Global.RYCSEM.My.Resources.Resources.usuario
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(53, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 45)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PbAdmin
        '
        '   Me.PbAdmin.BackgroundImage = Global.RYCSEM.My.Resources.Resources.check_2
        Me.PbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbAdmin.Location = New System.Drawing.Point(626, 39)
        Me.PbAdmin.Name = "PbAdmin"
        Me.PbAdmin.Size = New System.Drawing.Size(32, 34)
        Me.PbAdmin.TabIndex = 12
        Me.PbAdmin.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(663, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 35)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Admin"
        '
        'BtnCambiarContra
        '
        Me.BtnCambiarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCambiarContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarContra.Location = New System.Drawing.Point(598, 145)
        Me.BtnCambiarContra.Name = "BtnCambiarContra"
        Me.BtnCambiarContra.Size = New System.Drawing.Size(216, 45)
        Me.BtnCambiarContra.TabIndex = 3
        Me.BtnCambiarContra.Text = "Cambiar contraseña"
        Me.ToolTip1.SetToolTip(Me.BtnCambiarContra, "Cambiar contraseña")
        Me.BtnCambiarContra.UseVisualStyleBackColor = True
        '
        'PB1
        '
        ' Me.PB1.BackgroundImage = Global.RYCSEM.My.Resources.Resources.check_2
        Me.PB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB1.Location = New System.Drawing.Point(435, 92)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(32, 34)
        Me.PB1.TabIndex = 9
        Me.PB1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(472, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 35)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Default"
        '
        'TxtConfContraseña
        '
        Me.TxtConfContraseña.ForeColor = System.Drawing.Color.LightGray
        Me.TxtConfContraseña.Location = New System.Drawing.Point(103, 140)
        Me.TxtConfContraseña.Name = "TxtConfContraseña"
        Me.TxtConfContraseña.Size = New System.Drawing.Size(326, 45)
        Me.TxtConfContraseña.TabIndex = 2
        Me.TxtConfContraseña.Text = "Confirmar contraseña"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.ForeColor = System.Drawing.Color.LightGray
        Me.TxtContraseña.Location = New System.Drawing.Point(103, 87)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(326, 45)
        Me.TxtContraseña.TabIndex = 1
        Me.TxtContraseña.Text = "Contraseña"
        '
        'TxtUsuarioNombre
        '
        Me.TxtUsuarioNombre.ForeColor = System.Drawing.Color.LightGray
        Me.TxtUsuarioNombre.Location = New System.Drawing.Point(205, 34)
        Me.TxtUsuarioNombre.Name = "TxtUsuarioNombre"
        Me.TxtUsuarioNombre.Size = New System.Drawing.Size(415, 45)
        Me.TxtUsuarioNombre.TabIndex = 0
        Me.TxtUsuarioNombre.Text = "Nombre usuario"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(103, 34)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.ReadOnly = True
        Me.TxtUsuario.Size = New System.Drawing.Size(96, 45)
        Me.TxtUsuario.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(478, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "(0123456789)"
        '
        'DgUsuarios
        '
        Me.DgUsuarios.CaptionVisible = False
        Me.DgUsuarios.DataMember = ""
        Me.DgUsuarios.DataSource = Me.DvUsuarios
        Me.DgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgUsuarios.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.DgUsuarios.Name = "DgUsuarios"
        Me.DgUsuarios.Portapapeles = True
        Me.DgUsuarios.ReadOnly = True
        Me.DgUsuarios.Size = New System.Drawing.Size(823, 318)
        Me.DgUsuarios.TabIndex = 0
        Me.DgUsuarios.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DvUsuarios
        '
        Me.DvUsuarios.AllowDelete = False
        Me.DvUsuarios.AllowEdit = False
        Me.DvUsuarios.AllowNew = False
        Me.DvUsuarios.Table = Me.DS_Usuarios.usuarios
        '
        'DS_Usuarios
        '
        Me.DS_Usuarios.DataSetName = "DS_Usuarios"
        Me.DS_Usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DgUsuarios
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridBoolColumn1})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "usuarios"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Usuario"
        Me.DataGridTextBoxColumn1.MappingName = "usuario"
        Me.DataGridTextBoxColumn1.Width = 130
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn2.MappingName = "nombre"
        Me.DataGridTextBoxColumn2.Width = 400
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Status"
        Me.DataGridTextBoxColumn3.MappingName = "status"
        Me.DataGridTextBoxColumn3.Width = 130
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.HeaderText = "Admin"
        Me.DataGridBoolColumn1.MappingName = "administrador"
        Me.DataGridBoolColumn1.Width = 120
        '
        'MyDataGridView1
        '
        Me.MyDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView1.Name = "MyDataGridView1"
        Me.MyDataGridView1.Portapapeles = True
        Me.MyDataGridView1.Size = New System.Drawing.Size(823, 318)
        Me.MyDataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnCancelar)
        Me.GroupBox3.Controls.Add(Me.BtnDeshacer)
        Me.GroupBox3.Controls.Add(Me.BtnGuardar)
        Me.GroupBox3.Controls.Add(Me.BtnNuevo)
        Me.GroupBox3.Controls.Add(Me.BtnModificar)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(823, 56)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCancelar.Location = New System.Drawing.Point(760, 7)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(54, 49)
        Me.BtnCancelar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, "Cancelar")
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnDeshacer
        '
        ' Me.BtnDeshacer.BackgroundImage = Global.RYCSEM.My.Resources.Resources.undo
        Me.BtnDeshacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDeshacer.Location = New System.Drawing.Point(690, 7)
        Me.BtnDeshacer.Name = "BtnDeshacer"
        Me.BtnDeshacer.Size = New System.Drawing.Size(54, 49)
        Me.BtnDeshacer.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnDeshacer, "Deshacer")
        Me.BtnDeshacer.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardar.Location = New System.Drawing.Point(620, 7)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(54, 49)
        Me.BtnGuardar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Guardar")
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = CType(resources.GetObject("BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNuevo.Location = New System.Drawing.Point(480, 7)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(54, 49)
        Me.BtnNuevo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnModificar.Location = New System.Drawing.Point(550, 7)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(54, 49)
        Me.BtnModificar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnModificar, "Modificar")
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=CatySO\SQLEXPRESS;Initial Catalog=Royal;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        usuario, nombre, contraseña, status, administrador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM           " &
            " usuarios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [usuarios] ([usuario], [nombre], [contraseña], [status], [administrad" &
            "or]) VALUES (@usuario, @nombre, @contraseña, @status, @administrador)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 0, "usuario"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.[Char], 0, "nombre"), New System.Data.SqlClient.SqlParameter("@contraseña", System.Data.SqlDbType.[Char], 0, "contraseña"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status"), New System.Data.SqlClient.SqlParameter("@administrador", System.Data.SqlDbType.Bit, 0, "administrador")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE       usuarios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                status = 'C'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (usuario = @" &
            "usuario)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM usuarios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (usuario = @usuario)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SdaUsuarios
        '
        Me.SdaUsuarios.DeleteCommand = Me.SqlDeleteCommand1
        Me.SdaUsuarios.InsertCommand = Me.SqlInsertCommand1
        Me.SdaUsuarios.SelectCommand = Me.SqlSelectCommand1
        Me.SdaUsuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("contraseña", "contraseña"), New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("administrador", "administrador")})})
        Me.SdaUsuarios.UpdateCommand = Me.SqlUpdateCommand1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(435, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Máx. 10 caracteres"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 618)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MyDataGridView1 As MyControls.MyDataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnDeshacer As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents TxtConfContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuarioNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents PB1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SdaUsuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DS_Usuarios As RYCSEM.DS_Usuarios
    Friend WithEvents DgUsuarios As MyControls.MyDataGrid
    Friend WithEvents DvUsuarios As System.Data.DataView
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BtnCambiarContra As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PbAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
