<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FP001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FP001))
        Me.txtCodPrv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.dvProveedores = New System.Data.DataView()
        Me.DS_FP001 = New RYCSEM.DS_FP001()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApPaterno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApMaterno = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCalleNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbDireccion = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.txtEntre2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEntre1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MToolBar1 = New WindowsControlLibrary1.MToolBar()
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.dgProveedores = New MyControls.MyDataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sdaProveedores = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaStatus = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.dvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FP001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDireccion.SuspendLayout()
        Me.gbDatosGenerales.SuspendLayout()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodPrv
        '
        Me.txtCodPrv.Location = New System.Drawing.Point(78, 22)
        Me.txtCodPrv.Name = "txtCodPrv"
        Me.txtCodPrv.Size = New System.Drawing.Size(100, 20)
        Me.txtCodPrv.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proveedor"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "razon_social", True))
        Me.txtRazonSocial.Location = New System.Drawing.Point(260, 22)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(401, 20)
        Me.txtRazonSocial.TabIndex = 2
        '
        'dvProveedores
        '
        Me.dvProveedores.AllowNew = False
        Me.dvProveedores.Table = Me.DS_FP001.proveedores
        '
        'DS_FP001
        '
        Me.DS_FP001.DataSetName = "DS_FP001"
        Me.DS_FP001.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Razón Social"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(78, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(444, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtRFC
        '
        Me.txtRFC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "rfc", True))
        Me.txtRFC.Location = New System.Drawing.Point(561, 49)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(100, 20)
        Me.txtRFC.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(527, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RFC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apellido P."
        '
        'txtApPaterno
        '
        Me.txtApPaterno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "ap_paterno", True))
        Me.txtApPaterno.Location = New System.Drawing.Point(78, 75)
        Me.txtApPaterno.Name = "txtApPaterno"
        Me.txtApPaterno.Size = New System.Drawing.Size(240, 20)
        Me.txtApPaterno.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Apellido M."
        '
        'txtApMaterno
        '
        Me.txtApMaterno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "ap_materno", True))
        Me.txtApMaterno.Location = New System.Drawing.Point(393, 75)
        Me.txtApMaterno.Name = "txtApMaterno"
        Me.txtApMaterno.Size = New System.Drawing.Size(268, 20)
        Me.txtApMaterno.TabIndex = 6
        '
        'txtCalle
        '
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "calle", True))
        Me.txtCalle.Location = New System.Drawing.Point(68, 19)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(408, 20)
        Me.txtCalle.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Calle"
        '
        'txtCalleNum
        '
        Me.txtCalleNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "calle_num", True))
        Me.txtCalleNum.Location = New System.Drawing.Point(516, 19)
        Me.txtCalleNum.Name = "txtCalleNum"
        Me.txtCalleNum.Size = New System.Drawing.Size(100, 20)
        Me.txtCalleNum.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(479, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Num."
        '
        'txtColonia
        '
        Me.txtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "colonia", True))
        Me.txtColonia.Location = New System.Drawing.Point(68, 75)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(346, 20)
        Me.txtColonia.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Colonia"
        '
        'gbDireccion
        '
        Me.gbDireccion.Controls.Add(Me.TextBox2)
        Me.gbDireccion.Controls.Add(Me.Label19)
        Me.gbDireccion.Controls.Add(Me.TextBox1)
        Me.gbDireccion.Controls.Add(Me.Label18)
        Me.gbDireccion.Controls.Add(Me.Label12)
        Me.gbDireccion.Controls.Add(Me.txtCodPostal)
        Me.gbDireccion.Controls.Add(Me.txtEntre2)
        Me.gbDireccion.Controls.Add(Me.Label11)
        Me.gbDireccion.Controls.Add(Me.txtEntre1)
        Me.gbDireccion.Controls.Add(Me.Label10)
        Me.gbDireccion.Controls.Add(Me.txtCalle)
        Me.gbDireccion.Controls.Add(Me.txtColonia)
        Me.gbDireccion.Controls.Add(Me.Label7)
        Me.gbDireccion.Controls.Add(Me.Label9)
        Me.gbDireccion.Controls.Add(Me.Label8)
        Me.gbDireccion.Controls.Add(Me.txtCalleNum)
        Me.gbDireccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbDireccion.Location = New System.Drawing.Point(0, 186)
        Me.gbDireccion.Name = "gbDireccion"
        Me.gbDireccion.Size = New System.Drawing.Size(1008, 154)
        Me.gbDireccion.TabIndex = 18
        Me.gbDireccion.TabStop = False
        Me.gbDireccion.Text = "Dirección"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(491, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 20)
        Me.TextBox2.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(427, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Teléfono"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(346, 20)
        Me.TextBox1.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Vendedor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(424, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Cod. Postal"
        '
        'txtCodPostal
        '
        Me.txtCodPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "cod_postal", True))
        Me.txtCodPostal.Location = New System.Drawing.Point(491, 75)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(125, 20)
        Me.txtCodPostal.TabIndex = 17
        '
        'txtEntre2
        '
        Me.txtEntre2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "calle_entre2", True))
        Me.txtEntre2.Location = New System.Drawing.Point(352, 45)
        Me.txtEntre2.Name = "txtEntre2"
        Me.txtEntre2.Size = New System.Drawing.Size(264, 20)
        Me.txtEntre2.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(332, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Y"
        '
        'txtEntre1
        '
        Me.txtEntre1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "calle_entre1", True))
        Me.txtEntre1.Location = New System.Drawing.Point(68, 45)
        Me.txtEntre1.Name = "txtEntre1"
        Me.txtEntre1.Size = New System.Drawing.Size(255, 20)
        Me.txtEntre1.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Entre"
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "telefono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(79, 101)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(153, 20)
        Me.txtTelefono.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Telefono"
        '
        'txtCel
        '
        Me.txtCel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "celular", True))
        Me.txtCel.Location = New System.Drawing.Point(79, 127)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(153, 20)
        Me.txtCel.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Celular"
        '
        'txtExt
        '
        Me.txtExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "extension", True))
        Me.txtExt.Location = New System.Drawing.Point(261, 101)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(57, 20)
        Me.txtExt.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(238, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Ext"
        '
        'txtTelefono2
        '
        Me.txtTelefono2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "telefono2", True))
        Me.txtTelefono2.Location = New System.Drawing.Point(392, 101)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(153, 20)
        Me.txtTelefono2.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(328, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Telefono 2"
        '
        'MToolBar1
        '
        Me.MToolBar1.BAnteriorVisible = False
        Me.MToolBar1.BBuscarVisible = False
        Me.MToolBar1.BdeshacerVisible = True
        Me.MToolBar1.Beliminarvisible = False
        Me.MToolBar1.BExportarVisible = False
        Me.MToolBar1.BFiltroVisible = False
        Me.MToolBar1.BGuardarVisible = True
        Me.MToolBar1.Bimagenvisible = False
        Me.MToolBar1.BImprimirVisible = True
        Me.MToolBar1.BmodificarVisible = True
        Me.MToolBar1.BNotasVisible = False
        Me.MToolBar1.BNuevoVisible = True
        Me.MToolBar1.BPrimeroVisible = False
        Me.MToolBar1.BRefreshVisible = False
        Me.MToolBar1.BSep1Visible = True
        Me.MToolBar1.BSep2Visible = True
        Me.MToolBar1.BSep3Visible = True
        Me.MToolBar1.BSep4Visible = False
        Me.MToolBar1.BSep5Visible = False
        Me.MToolBar1.BSep6Visible = False
        Me.MToolBar1.Bsep7Visible = False
        Me.MToolBar1.Bsep8Visible = False
        Me.MToolBar1.BSiguienteVisible = False
        Me.MToolBar1.BUltimoVisible = False
        Me.MToolBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MToolBar1.Name = "MToolBar1"
        Me.MToolBar1.Size = New System.Drawing.Size(1008, 28)
        Me.MToolBar1.TabIndex = 35
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.Controls.Add(Me.Label17)
        Me.gbDatosGenerales.Controls.Add(Me.cbStatus)
        Me.gbDatosGenerales.Controls.Add(Me.Label2)
        Me.gbDatosGenerales.Controls.Add(Me.txtCodPrv)
        Me.gbDatosGenerales.Controls.Add(Me.Label1)
        Me.gbDatosGenerales.Controls.Add(Me.txtTelefono2)
        Me.gbDatosGenerales.Controls.Add(Me.txtRazonSocial)
        Me.gbDatosGenerales.Controls.Add(Me.Label16)
        Me.gbDatosGenerales.Controls.Add(Me.txtNombre)
        Me.gbDatosGenerales.Controls.Add(Me.Label15)
        Me.gbDatosGenerales.Controls.Add(Me.Label3)
        Me.gbDatosGenerales.Controls.Add(Me.txtExt)
        Me.gbDatosGenerales.Controls.Add(Me.txtRFC)
        Me.gbDatosGenerales.Controls.Add(Me.txtCel)
        Me.gbDatosGenerales.Controls.Add(Me.Label4)
        Me.gbDatosGenerales.Controls.Add(Me.Label14)
        Me.gbDatosGenerales.Controls.Add(Me.txtApPaterno)
        Me.gbDatosGenerales.Controls.Add(Me.txtTelefono)
        Me.gbDatosGenerales.Controls.Add(Me.Label5)
        Me.gbDatosGenerales.Controls.Add(Me.Label13)
        Me.gbDatosGenerales.Controls.Add(Me.txtApMaterno)
        Me.gbDatosGenerales.Controls.Add(Me.Label6)
        Me.gbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbDatosGenerales.Location = New System.Drawing.Point(0, 28)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(1008, 158)
        Me.gbDatosGenerales.TabIndex = 38
        Me.gbDatosGenerales.TabStop = False
        Me.gbDatosGenerales.Text = "Datos generales"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(352, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvProveedores, "status", True))
        Me.cbStatus.DataSource = Me.DS_FP001
        Me.cbStatus.DisplayMember = "status.descripcion"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(392, 127)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(153, 21)
        Me.cbStatus.TabIndex = 11
        Me.cbStatus.ValueMember = "status.status"
        '
        'dgProveedores
        '
        Me.dgProveedores.CaptionText = "Proveedores"
        Me.dgProveedores.DataMember = ""
        Me.dgProveedores.DataSource = Me.dvProveedores
        Me.dgProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProveedores.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProveedores.Location = New System.Drawing.Point(0, 340)
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.Portapapeles = True
        Me.dgProveedores.Size = New System.Drawing.Size(1008, 381)
        Me.dgProveedores.TabIndex = 39
        Me.dgProveedores.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgProveedores
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "proveedores"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Proveedor"
        Me.DataGridTextBoxColumn1.MappingName = "cod_prv"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Razón social"
        Me.DataGridTextBoxColumn2.MappingName = "razon_social"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn3.MappingName = "nombreCompleto"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 250
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "R.F.C."
        Me.DataGridTextBoxColumn4.MappingName = "rfc"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 110
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Teléfono"
        Me.DataGridTextBoxColumn5.MappingName = "telefono"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Ext."
        Me.DataGridTextBoxColumn7.MappingName = "extension"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Teléfono 2"
        Me.DataGridTextBoxColumn8.MappingName = "telefono2"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Celular"
        Me.DataGridTextBoxColumn6.MappingName = "celular"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 120
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Dirección"
        Me.DataGridTextBoxColumn9.MappingName = "direccionCompleta"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 350
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Status"
        Me.DataGridTextBoxColumn10.MappingName = "status"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.CommandTimeout = 999999
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.CommandTimeout = 9999999
        Me.SqlInsertCommand1.Connection = Me.sqlConn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@razon_social", System.Data.SqlDbType.VarChar, 250, "razon_social"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 150, "nombre"), New System.Data.SqlClient.SqlParameter("@rfc", System.Data.SqlDbType.VarChar, 20, "rfc"), New System.Data.SqlClient.SqlParameter("@ap_paterno", System.Data.SqlDbType.VarChar, 80, "ap_paterno"), New System.Data.SqlClient.SqlParameter("@ap_materno", System.Data.SqlDbType.VarChar, 80, "ap_materno"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 15, "telefono"), New System.Data.SqlClient.SqlParameter("@extension", System.Data.SqlDbType.[Char], 8, "extension"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.[Char], 15, "telefono2"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.[Char], 20, "celular"), New System.Data.SqlClient.SqlParameter("@calle", System.Data.SqlDbType.VarChar, 100, "calle"), New System.Data.SqlClient.SqlParameter("@calle_num", System.Data.SqlDbType.[Char], 10, "calle_num"), New System.Data.SqlClient.SqlParameter("@calle_entre1", System.Data.SqlDbType.VarChar, 100, "calle_entre1"), New System.Data.SqlClient.SqlParameter("@calle_entre2", System.Data.SqlDbType.VarChar, 100, "calle_entre2"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.VarChar, 150, "colonia"), New System.Data.SqlClient.SqlParameter("@cod_postal", System.Data.SqlDbType.[Char], 15, "cod_postal"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3, "status"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.CommandTimeout = 9999999
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@razon_social", System.Data.SqlDbType.VarChar, 250, "razon_social"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 150, "nombre"), New System.Data.SqlClient.SqlParameter("@rfc", System.Data.SqlDbType.VarChar, 20, "rfc"), New System.Data.SqlClient.SqlParameter("@ap_paterno", System.Data.SqlDbType.VarChar, 80, "ap_paterno"), New System.Data.SqlClient.SqlParameter("@ap_materno", System.Data.SqlDbType.VarChar, 80, "ap_materno"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 15, "telefono"), New System.Data.SqlClient.SqlParameter("@extension", System.Data.SqlDbType.[Char], 8, "extension"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.[Char], 15, "telefono2"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.[Char], 20, "celular"), New System.Data.SqlClient.SqlParameter("@calle", System.Data.SqlDbType.VarChar, 100, "calle"), New System.Data.SqlClient.SqlParameter("@calle_num", System.Data.SqlDbType.[Char], 10, "calle_num"), New System.Data.SqlClient.SqlParameter("@calle_entre1", System.Data.SqlDbType.VarChar, 100, "calle_entre1"), New System.Data.SqlClient.SqlParameter("@calle_entre2", System.Data.SqlDbType.VarChar, 100, "calle_entre2"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.VarChar, 150, "colonia"), New System.Data.SqlClient.SqlParameter("@cod_postal", System.Data.SqlDbType.[Char], 15, "cod_postal"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3, "status"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@Original_cod_prv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_prv", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [proveedores] WHERE (([cod_prv] = @Original_cod_prv))"
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cod_prv", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_prv", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sdaProveedores
        '
        Me.sdaProveedores.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaProveedores.InsertCommand = Me.SqlInsertCommand1
        Me.sdaProveedores.SelectCommand = Me.SqlSelectCommand1
        Me.sdaProveedores.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_prv", "cod_prv"), New System.Data.Common.DataColumnMapping("razon_social", "razon_social"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("rfc", "rfc"), New System.Data.Common.DataColumnMapping("ap_paterno", "ap_paterno"), New System.Data.Common.DataColumnMapping("ap_materno", "ap_materno"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("extension", "extension"), New System.Data.Common.DataColumnMapping("telefono2", "telefono2"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("calle", "calle"), New System.Data.Common.DataColumnMapping("calle_num", "calle_num"), New System.Data.Common.DataColumnMapping("calle_entre1", "calle_entre1"), New System.Data.Common.DataColumnMapping("calle_entre2", "calle_entre2"), New System.Data.Common.DataColumnMapping("colonia", "colonia"), New System.Data.Common.DataColumnMapping("cod_postal", "cod_postal"), New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("direccionCompleta", "direccionCompleta"), New System.Data.Common.DataColumnMapping("nombreCompleto", "nombreCompleto")})})
        Me.sdaProveedores.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        status, abreviatura, descripcion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            status WITH (NOLO" &
    "CK)"
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        '
        'sdaStatus
        '
        Me.sdaStatus.SelectCommand = Me.SqlSelectCommand2
        Me.sdaStatus.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "status", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("abreviatura", "abreviatura"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        '
        'FP001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgProveedores)
        Me.Controls.Add(Me.gbDireccion)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.Controls.Add(Me.MToolBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FP001"
        Me.Text = "Catálogo de proveedores"
        CType(Me.dvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FP001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDireccion.ResumeLayout(False)
        Me.gbDireccion.PerformLayout()
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.gbDatosGenerales.PerformLayout()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCodPrv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApPaterno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApMaterno As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCalleNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gbDireccion As GroupBox
    Friend WithEvents txtEntre2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEntre1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCel As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTelefono2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents MToolBar1 As WindowsControlLibrary1.MToolBar
    Friend WithEvents gbDatosGenerales As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents dgProveedores As MyControls.MyDataGrid
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents sdaProveedores As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FP001 As DS_FP001
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaStatus As SqlClient.SqlDataAdapter
    Friend WithEvents dvProveedores As DataView
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As DataGridTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label18 As Label
End Class
