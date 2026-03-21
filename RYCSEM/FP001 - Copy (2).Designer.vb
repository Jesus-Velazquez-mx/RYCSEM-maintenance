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
        Me.DS_FP001_ = New RYCSEM.DS_FP001_()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sdaProveedores = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaStatus = New System.Data.SqlClient.SqlDataAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTelVendedor = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.dvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FP001_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosGenerales.SuspendLayout()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proveedor"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "razon_social", True))
        Me.txtRazonSocial.Location = New System.Drawing.Point(78, 48)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(401, 20)
        Me.txtRazonSocial.TabIndex = 3
        '
        'dvProveedores
        '
        Me.dvProveedores.AllowNew = False
        Me.dvProveedores.Table = Me.DS_FP001_.proveedores
        '
        'DS_FP001_
        '
        Me.DS_FP001_.DataSetName = "DS_FP001_"
        Me.DS_FP001_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Razón Social"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(232, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(429, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtRFC
        '
        Me.txtRFC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "rfc", True))
        Me.txtRFC.Location = New System.Drawing.Point(516, 48)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(145, 20)
        Me.txtRFC.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RFC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre"
        '
        'txtCalle
        '
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "calle", True))
        Me.txtCalle.Location = New System.Drawing.Point(78, 74)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(583, 20)
        Me.txtCalle.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Dirección"
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "telefono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(78, 100)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(153, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Teléfono"
        '
        'txtCel
        '
        Me.txtCel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "celular", True))
        Me.txtCel.Location = New System.Drawing.Point(284, 100)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(153, 20)
        Me.txtCel.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(239, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Celular"
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
        Me.gbDatosGenerales.Controls.Add(Me.txtRazonSocial)
        Me.gbDatosGenerales.Controls.Add(Me.txtNombre)
        Me.gbDatosGenerales.Controls.Add(Me.txtCalle)
        Me.gbDatosGenerales.Controls.Add(Me.Label3)
        Me.gbDatosGenerales.Controls.Add(Me.Label7)
        Me.gbDatosGenerales.Controls.Add(Me.txtRFC)
        Me.gbDatosGenerales.Controls.Add(Me.txtCel)
        Me.gbDatosGenerales.Controls.Add(Me.Label4)
        Me.gbDatosGenerales.Controls.Add(Me.Label14)
        Me.gbDatosGenerales.Controls.Add(Me.txtTelefono)
        Me.gbDatosGenerales.Controls.Add(Me.Label13)
        Me.gbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbDatosGenerales.Location = New System.Drawing.Point(0, 28)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(1008, 134)
        Me.gbDatosGenerales.TabIndex = 38
        Me.gbDatosGenerales.TabStop = False
        Me.gbDatosGenerales.Text = "Datos generales"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(468, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvProveedores, "status", True))
        Me.cbStatus.DataSource = Me.DS_FP001_
        Me.cbStatus.DisplayMember = "status.descripcion"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(508, 98)
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
        Me.dgProveedores.Location = New System.Drawing.Point(0, 242)
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.Portapapeles = True
        Me.dgProveedores.Size = New System.Drawing.Size(1008, 479)
        Me.dgProveedores.TabIndex = 39
        Me.dgProveedores.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgProveedores
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn10})
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
        Me.DataGridTextBoxColumn9.MappingName = "calle"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 350
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Banco"
        Me.DataGridTextBoxColumn11.MappingName = "banco"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 90
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Cuenta"
        Me.DataGridTextBoxColumn12.MappingName = "cuenta"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Vendedor"
        Me.DataGridTextBoxColumn13.MappingName = "vendedor"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 200
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Teléfono"
        Me.DataGridTextBoxColumn14.MappingName = "telefonoVendedor"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_prv", System.Data.SqlDbType.[Char], 0, "cod_prv"), New System.Data.SqlClient.SqlParameter("@rfc", System.Data.SqlDbType.VarChar, 0, "rfc"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 0, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.[Char], 0, "celular"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status"), New System.Data.SqlClient.SqlParameter("@calle", System.Data.SqlDbType.VarChar, 0, "calle"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.[Char], 0, "Expr1"), New System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.[Char], 0, "Expr2"), New System.Data.SqlClient.SqlParameter("@Expr3", System.Data.SqlDbType.[Char], 0, "Expr3"), New System.Data.SqlClient.SqlParameter("@Expr4", System.Data.SqlDbType.VarChar, 0, "Expr4"), New System.Data.SqlClient.SqlParameter("@Expr5", System.Data.SqlDbType.[Char], 0, "Expr5")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.CommandTimeout = 9999999
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_prv", System.Data.SqlDbType.[Char], 0, "cod_prv"), New System.Data.SqlClient.SqlParameter("@rfc", System.Data.SqlDbType.VarChar, 0, "rfc"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 0, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.[Char], 0, "celular"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status"), New System.Data.SqlClient.SqlParameter("@calle", System.Data.SqlDbType.VarChar, 0, "calle"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.[Char], 0, "Expr1"), New System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.[Char], 0, "Expr2"), New System.Data.SqlClient.SqlParameter("@Expr3", System.Data.SqlDbType.[Char], 0, "Expr3"), New System.Data.SqlClient.SqlParameter("@Expr4", System.Data.SqlDbType.VarChar, 0, "Expr4"), New System.Data.SqlClient.SqlParameter("@Expr5", System.Data.SqlDbType.[Char], 0, "Expr5"), New System.Data.SqlClient.SqlParameter("@Original_cod_prv", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_prv", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [proveedores] WHERE (([cod_prv] = @Original_cod_prv))"
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cod_prv", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_prv", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sdaProveedores
        '
        Me.sdaProveedores.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaProveedores.InsertCommand = Me.SqlInsertCommand1
        Me.sdaProveedores.SelectCommand = Me.SqlSelectCommand1
        Me.sdaProveedores.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_prv", "cod_prv"), New System.Data.Common.DataColumnMapping("razon_social", "razon_social"), New System.Data.Common.DataColumnMapping("rfc", "rfc"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("calle", "calle"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("banco", "banco"), New System.Data.Common.DataColumnMapping("cuenta", "cuenta"), New System.Data.Common.DataColumnMapping("vendedor", "vendedor"), New System.Data.Common.DataColumnMapping("telefonoVendedor", "telefonoVendedor"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2"), New System.Data.Common.DataColumnMapping("Expr3", "Expr3"), New System.Data.Common.DataColumnMapping("Expr4", "Expr4"), New System.Data.Common.DataColumnMapping("Expr5", "Expr5")})})
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTelVendedor)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtVendedor)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtNumCuenta)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 80)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos adicionales"
        '
        'txtTelVendedor
        '
        Me.txtTelVendedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "telefonoVendedor", True))
        Me.txtTelVendedor.Location = New System.Drawing.Point(505, 45)
        Me.txtTelVendedor.Name = "txtTelVendedor"
        Me.txtTelVendedor.Size = New System.Drawing.Size(156, 20)
        Me.txtTelVendedor.TabIndex = 11
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(446, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Teléfono"
        '
        'txtVendedor
        '
        Me.txtVendedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "vendedor", True))
        Me.txtVendedor.Location = New System.Drawing.Point(78, 45)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(362, 20)
        Me.txtVendedor.TabIndex = 10
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(19, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Vendedor"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "cuenta", True))
        Me.txtNumCuenta.Location = New System.Drawing.Point(287, 19)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(153, 20)
        Me.txtNumCuenta.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(240, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Cuenta"
        '
        'txtBanco
        '
        Me.txtBanco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvProveedores, "banco", True))
        Me.txtBanco.Location = New System.Drawing.Point(78, 19)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(153, 20)
        Me.txtBanco.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(34, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Banco"
        '
        'FP001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgProveedores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.Controls.Add(Me.MToolBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FP001"
        Me.Text = "Catálogo de proveedores"
        CType(Me.dvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FP001_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.gbDatosGenerales.PerformLayout()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCel As TextBox
    Friend WithEvents Label14 As Label
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
    Friend WithEvents DS_FP001_ As DS_FP001_
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaStatus As SqlClient.SqlDataAdapter
    Friend WithEvents dvProveedores As DataView
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtNumCuenta As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtTelVendedor As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtVendedor As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents DataGridTextBoxColumn11 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As DataGridTextBoxColumn
End Class
