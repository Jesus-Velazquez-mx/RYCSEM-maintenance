<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FC001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FC001))
        Me.txtCodCte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.dvClientes = New System.Data.DataView()
        Me.DS_FC001 = New RYCSEM.DS_FC001()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApPat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApMat = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgDireccion = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.txtCalleEntre2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCalleEntre1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gpDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.btnReferencias = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.dgClientes = New MyControls.MyDataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.sdaClientes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaStatus = New System.Data.SqlClient.SqlDataAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.dvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FC001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dgDireccion.SuspendLayout()
        Me.gpDatosGenerales.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodCte
        '
        Me.txtCodCte.Location = New System.Drawing.Point(72, 19)
        Me.txtCodCte.Name = "txtCodCte"
        Me.txtCodCte.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCte.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "razon_social", True))
        Me.txtRazonSocial.Location = New System.Drawing.Point(254, 19)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(401, 20)
        Me.txtRazonSocial.TabIndex = 2
        '
        'dvClientes
        '
        Me.dvClientes.AllowNew = False
        Me.dvClientes.Table = Me.DS_FC001.clientes
        '
        'DS_FC001
        '
        Me.DS_FC001.DataSetName = "DS_FC001"
        Me.DS_FC001.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Razón Social"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(72, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(444, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtRFC
        '
        Me.txtRFC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "rfc", True))
        Me.txtRFC.Location = New System.Drawing.Point(555, 45)
        Me.txtRFC.MaxLength = 15
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(100, 20)
        Me.txtRFC.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(521, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RFC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apellido P."
        '
        'txtApPat
        '
        Me.txtApPat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "ap_paterno", True))
        Me.txtApPat.Location = New System.Drawing.Point(72, 71)
        Me.txtApPat.Name = "txtApPat"
        Me.txtApPat.Size = New System.Drawing.Size(240, 20)
        Me.txtApPat.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(324, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Apellido M."
        '
        'txtApMat
        '
        Me.txtApMat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "ap_materno", True))
        Me.txtApMat.Location = New System.Drawing.Point(387, 71)
        Me.txtApMat.Name = "txtApMat"
        Me.txtApMat.Size = New System.Drawing.Size(268, 20)
        Me.txtApMat.TabIndex = 6
        '
        'txtCalle
        '
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "calle", True))
        Me.txtCalle.Location = New System.Drawing.Point(61, 19)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(408, 20)
        Me.txtCalle.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Calle"
        '
        'txtNum
        '
        Me.txtNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "calle_num", True))
        Me.txtNum.Location = New System.Drawing.Point(509, 19)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(472, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Num."
        '
        'txtColonia
        '
        Me.txtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "colonia", True))
        Me.txtColonia.Location = New System.Drawing.Point(61, 75)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(346, 20)
        Me.txtColonia.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Colonia"
        '
        'dgDireccion
        '
        Me.dgDireccion.Controls.Add(Me.Label12)
        Me.dgDireccion.Controls.Add(Me.txtCodPostal)
        Me.dgDireccion.Controls.Add(Me.txtCalleEntre2)
        Me.dgDireccion.Controls.Add(Me.Label11)
        Me.dgDireccion.Controls.Add(Me.txtCalleEntre1)
        Me.dgDireccion.Controls.Add(Me.Label10)
        Me.dgDireccion.Controls.Add(Me.txtCalle)
        Me.dgDireccion.Controls.Add(Me.txtColonia)
        Me.dgDireccion.Controls.Add(Me.Label7)
        Me.dgDireccion.Controls.Add(Me.Label9)
        Me.dgDireccion.Controls.Add(Me.Label8)
        Me.dgDireccion.Controls.Add(Me.txtNum)
        Me.dgDireccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgDireccion.Location = New System.Drawing.Point(0, 205)
        Me.dgDireccion.Name = "dgDireccion"
        Me.dgDireccion.Size = New System.Drawing.Size(1008, 114)
        Me.dgDireccion.TabIndex = 18
        Me.dgDireccion.TabStop = False
        Me.dgDireccion.Text = "Dirección"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(417, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Cod. Postal"
        '
        'txtCodPostal
        '
        Me.txtCodPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "cod_postal", True))
        Me.txtCodPostal.Location = New System.Drawing.Point(484, 75)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(125, 20)
        Me.txtCodPostal.TabIndex = 17
        '
        'txtCalleEntre2
        '
        Me.txtCalleEntre2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "calle_entre2", True))
        Me.txtCalleEntre2.Location = New System.Drawing.Point(345, 45)
        Me.txtCalleEntre2.Name = "txtCalleEntre2"
        Me.txtCalleEntre2.Size = New System.Drawing.Size(264, 20)
        Me.txtCalleEntre2.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(325, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Y"
        '
        'txtCalleEntre1
        '
        Me.txtCalleEntre1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "calle_entre1", True))
        Me.txtCalleEntre1.Location = New System.Drawing.Point(61, 45)
        Me.txtCalleEntre1.Name = "txtCalleEntre1"
        Me.txtCalleEntre1.Size = New System.Drawing.Size(255, 20)
        Me.txtCalleEntre1.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Entre"
        '
        'txtTel1
        '
        Me.txtTel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "telefono", True))
        Me.txtTel1.Location = New System.Drawing.Point(73, 97)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(153, 20)
        Me.txtTel1.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Telefono"
        '
        'txtCel
        '
        Me.txtCel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "celular", True))
        Me.txtCel.Location = New System.Drawing.Point(73, 122)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(153, 20)
        Me.txtCel.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Celular"
        '
        'txtExt
        '
        Me.txtExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "extension", True))
        Me.txtExt.Location = New System.Drawing.Point(255, 97)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(57, 20)
        Me.txtExt.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(232, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Ext"
        '
        'txtTel2
        '
        Me.txtTel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "telefono2", True))
        Me.txtTel2.Location = New System.Drawing.Point(386, 97)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(153, 20)
        Me.txtTel2.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(322, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Telefono 2"
        '
        'gpDatosGenerales
        '
        Me.gpDatosGenerales.Controls.Add(Me.btnReferencias)
        Me.gpDatosGenerales.Controls.Add(Me.Label17)
        Me.gpDatosGenerales.Controls.Add(Me.cbStatus)
        Me.gpDatosGenerales.Controls.Add(Me.txtCodCte)
        Me.gpDatosGenerales.Controls.Add(Me.Label1)
        Me.gpDatosGenerales.Controls.Add(Me.txtRazonSocial)
        Me.gpDatosGenerales.Controls.Add(Me.txtTel2)
        Me.gpDatosGenerales.Controls.Add(Me.Label2)
        Me.gpDatosGenerales.Controls.Add(Me.Label16)
        Me.gpDatosGenerales.Controls.Add(Me.txtNombre)
        Me.gpDatosGenerales.Controls.Add(Me.Label15)
        Me.gpDatosGenerales.Controls.Add(Me.Label3)
        Me.gpDatosGenerales.Controls.Add(Me.txtExt)
        Me.gpDatosGenerales.Controls.Add(Me.txtRFC)
        Me.gpDatosGenerales.Controls.Add(Me.txtCel)
        Me.gpDatosGenerales.Controls.Add(Me.Label4)
        Me.gpDatosGenerales.Controls.Add(Me.Label14)
        Me.gpDatosGenerales.Controls.Add(Me.txtApPat)
        Me.gpDatosGenerales.Controls.Add(Me.txtTel1)
        Me.gpDatosGenerales.Controls.Add(Me.Label5)
        Me.gpDatosGenerales.Controls.Add(Me.Label13)
        Me.gpDatosGenerales.Controls.Add(Me.txtApMat)
        Me.gpDatosGenerales.Controls.Add(Me.Label6)
        Me.gpDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpDatosGenerales.Location = New System.Drawing.Point(0, 56)
        Me.gpDatosGenerales.Name = "gpDatosGenerales"
        Me.gpDatosGenerales.Size = New System.Drawing.Size(1008, 149)
        Me.gpDatosGenerales.TabIndex = 37
        Me.gpDatosGenerales.TabStop = False
        Me.gpDatosGenerales.Text = "Datos generales"
        '
        'btnReferencias
        '
        Me.btnReferencias.Location = New System.Drawing.Point(555, 121)
        Me.btnReferencias.Name = "btnReferencias"
        Me.btnReferencias.Size = New System.Drawing.Size(100, 23)
        Me.btnReferencias.TabIndex = 34
        Me.btnReferencias.Text = "Referencias"
        Me.btnReferencias.UseVisualStyleBackColor = True
        Me.btnReferencias.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(342, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvClientes, "status", True))
        Me.cbStatus.DataSource = Me.DS_FC001
        Me.cbStatus.DisplayMember = "status.descripcion"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(387, 122)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 11
        Me.cbStatus.ValueMember = "status.status"
        '
        'dgClientes
        '
        Me.dgClientes.CaptionText = "Clientes"
        Me.dgClientes.DataMember = ""
        Me.dgClientes.DataSource = Me.dvClientes
        Me.dgClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgClientes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgClientes.Location = New System.Drawing.Point(0, 319)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.Portapapeles = True
        Me.dgClientes.Size = New System.Drawing.Size(1008, 402)
        Me.dgClientes.TabIndex = 38
        Me.dgClientes.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgClientes
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "clientes"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cliente"
        Me.DataGridTextBoxColumn1.MappingName = "cod_cte"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Razón social"
        Me.DataGridTextBoxColumn2.MappingName = "razon_social"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn3.MappingName = "nombreCompleto"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 250
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "R.F.C."
        Me.DataGridTextBoxColumn4.MappingName = "rfc"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 110
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Teléfono"
        Me.DataGridTextBoxColumn5.MappingName = "telefono"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 110
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Ext."
        Me.DataGridTextBoxColumn6.MappingName = "extension"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Teléfono 2"
        Me.DataGridTextBoxColumn7.MappingName = "telefono2"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Celular"
        Me.DataGridTextBoxColumn8.MappingName = "celular"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Dirección"
        Me.DataGridTextBoxColumn9.MappingName = "direccionCompleta"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
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
        Me.SqlSelectCommand1.CommandTimeout = 99999
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=SA" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'sdaClientes
        '
        Me.sdaClientes.DeleteCommand = Me.SqlDeleteCommand
        Me.sdaClientes.InsertCommand = Me.SqlInsertCommand
        Me.sdaClientes.SelectCommand = Me.SqlSelectCommand1
        Me.sdaClientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("razon_social", "razon_social"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("rfc", "rfc"), New System.Data.Common.DataColumnMapping("ap_paterno", "ap_paterno"), New System.Data.Common.DataColumnMapping("ap_materno", "ap_materno"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("extension", "extension"), New System.Data.Common.DataColumnMapping("telefono2", "telefono2"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("calle", "calle"), New System.Data.Common.DataColumnMapping("calle_num", "calle_num"), New System.Data.Common.DataColumnMapping("calle_entre1", "calle_entre1"), New System.Data.Common.DataColumnMapping("calle_entre2", "calle_entre2"), New System.Data.Common.DataColumnMapping("colonia", "colonia"), New System.Data.Common.DataColumnMapping("cod_postal", "cod_postal"), New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("direccionCompleta", "direccionCompleta"), New System.Data.Common.DataColumnMapping("nombreCompleto", "nombreCompleto"), New System.Data.Common.DataColumnMapping("usuario", "usuario")})})
        Me.sdaClientes.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = "DELETE FROM [clientes] WHERE (([cod_cte] = @Original_cod_cte))"
        Me.SqlDeleteCommand.Connection = Me.sqlConn
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cod_cte", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_cte", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.CommandTimeout = 999999
        Me.SqlInsertCommand.Connection = Me.sqlConn
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 0, "cod_cte"), New System.Data.SqlClient.SqlParameter("@razon_social", System.Data.SqlDbType.VarChar, 0, "razon_social"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@rfc", System.Data.SqlDbType.VarChar, 0, "rfc"), New System.Data.SqlClient.SqlParameter("@ap_paterno", System.Data.SqlDbType.VarChar, 0, "ap_paterno"), New System.Data.SqlClient.SqlParameter("@ap_materno", System.Data.SqlDbType.VarChar, 0, "ap_materno"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 0, "telefono"), New System.Data.SqlClient.SqlParameter("@extension", System.Data.SqlDbType.[Char], 0, "extension"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.[Char], 0, "telefono2"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.[Char], 0, "celular"), New System.Data.SqlClient.SqlParameter("@calle", System.Data.SqlDbType.VarChar, 0, "calle"), New System.Data.SqlClient.SqlParameter("@calle_num", System.Data.SqlDbType.[Char], 0, "calle_num"), New System.Data.SqlClient.SqlParameter("@calle_entre1", System.Data.SqlDbType.VarChar, 0, "calle_entre1"), New System.Data.SqlClient.SqlParameter("@calle_entre2", System.Data.SqlDbType.VarChar, 0, "calle_entre2"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.VarChar, 0, "colonia"), New System.Data.SqlClient.SqlParameter("@cod_postal", System.Data.SqlDbType.[Char], 0, "cod_postal"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status")})
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.CommandTimeout = 99999
        Me.SqlUpdateCommand.Connection = Me.sqlConn
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 0, "cod_cte"), New System.Data.SqlClient.SqlParameter("@razon_social", System.Data.SqlDbType.VarChar, 0, "razon_social"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@rfc", System.Data.SqlDbType.VarChar, 0, "rfc"), New System.Data.SqlClient.SqlParameter("@ap_paterno", System.Data.SqlDbType.VarChar, 0, "ap_paterno"), New System.Data.SqlClient.SqlParameter("@ap_materno", System.Data.SqlDbType.VarChar, 0, "ap_materno"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 0, "telefono"), New System.Data.SqlClient.SqlParameter("@extension", System.Data.SqlDbType.[Char], 0, "extension"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.[Char], 0, "telefono2"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.[Char], 0, "celular"), New System.Data.SqlClient.SqlParameter("@calle", System.Data.SqlDbType.VarChar, 0, "calle"), New System.Data.SqlClient.SqlParameter("@calle_num", System.Data.SqlDbType.[Char], 0, "calle_num"), New System.Data.SqlClient.SqlParameter("@calle_entre1", System.Data.SqlDbType.VarChar, 0, "calle_entre1"), New System.Data.SqlClient.SqlParameter("@calle_entre2", System.Data.SqlDbType.VarChar, 0, "calle_entre2"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.VarChar, 0, "colonia"), New System.Data.SqlClient.SqlParameter("@cod_postal", System.Data.SqlDbType.[Char], 0, "cod_postal"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status"), New System.Data.SqlClient.SqlParameter("@Original_cod_cte", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_cte", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        status, abreviatura, descripcion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            status WITH (nolo" &
    "ck)"
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        '
        'sdaStatus
        '
        Me.sdaStatus.SelectCommand = Me.SqlSelectCommand2
        Me.sdaStatus.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "status", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("abreviatura", "abreviatura"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnDeshacer)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 56)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(224, 10)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(44, 40)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnDeshacer
        '
        Me.btnDeshacer.Image = CType(resources.GetObject("btnDeshacer.Image"), System.Drawing.Image)
        Me.btnDeshacer.Location = New System.Drawing.Point(174, 10)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(44, 40)
        Me.btnDeshacer.TabIndex = 3
        Me.btnDeshacer.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(124, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(44, 40)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(74, 10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(44, 40)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(24, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(44, 40)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'FC001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgClientes)
        Me.Controls.Add(Me.dgDireccion)
        Me.Controls.Add(Me.gpDatosGenerales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FC001"
        Me.Text = "Catálogo de clientes"
        CType(Me.dvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FC001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dgDireccion.ResumeLayout(False)
        Me.dgDireccion.PerformLayout()
        Me.gpDatosGenerales.ResumeLayout(False)
        Me.gpDatosGenerales.PerformLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCodCte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApPat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApMat As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgDireccion As GroupBox
    Friend WithEvents txtCalleEntre2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCalleEntre1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents txtTel1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCel As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTel2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents gpDatosGenerales As GroupBox
    Friend WithEvents dgClientes As MyControls.MyDataGrid
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents sdaClientes As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FC001 As DS_FC001
    Friend WithEvents SqlDeleteCommand As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlClient.SqlCommand
    Friend WithEvents dvClientes As DataView
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As DataGridTextBoxColumn
    Friend WithEvents Label17 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaStatus As SqlClient.SqlDataAdapter
    Friend WithEvents DataGridTextBoxColumn10 As DataGridTextBoxColumn
    Friend WithEvents btnReferencias As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnDeshacer As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
End Class
