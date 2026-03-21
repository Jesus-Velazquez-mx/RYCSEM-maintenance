<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FConf))
        Me.MT_Operacional1 = New WindowsControlLibrary1.MT_Operacional()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Plazos = New System.Windows.Forms.TabPage()
        Me.MyDataGrid1 = New MyControls.MyDataGrid()
        Me.DvPlazos = New System.Data.DataView()
        Me.DS_FConf = New RYCSEM.DS_FConf()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPlazo = New System.Windows.Forms.TextBox()
        Me.NumPInteresP = New MyControls.MyNumeric()
        Me.TxtNomPlazo = New System.Windows.Forms.TextBox()
        Me.CbStatusPlazo = New System.Windows.Forms.ComboBox()
        Me.DvStatusPlazos = New System.Data.DataView()
        Me.BtnNvoPlazo = New System.Windows.Forms.Button()
        Me.Intereses = New System.Windows.Forms.TabPage()
        Me.MyDataGrid2 = New MyControls.MyDataGrid()
        Me.DvIntereses = New System.Data.DataView()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumPrioridad = New MyControls.MyNumeric()
        Me.NumR2 = New MyControls.MyNumeric()
        Me.CbTipoInteres = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumR1 = New MyControls.MyNumeric()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumPInteresM = New MyControls.MyNumeric()
        Me.BtnNvoInteres = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtInteres = New System.Windows.Forms.TextBox()
        Me.TxtNombreInteres = New System.Windows.Forms.TextBox()
        Me.CbStatusInteres = New System.Windows.Forms.ComboBox()
        Me.DvStatusInteres = New System.Data.DataView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SqlCnn = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SdaTiposPlazos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SdaIntereses = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SdaStatus = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SdaTipoInteres = New System.Data.SqlClient.SqlDataAdapter()
        Me.TabControl1.SuspendLayout()
        Me.Plazos.SuspendLayout()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvPlazos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FConf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumPInteresP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvStatusPlazos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Intereses.SuspendLayout()
        CType(Me.MyDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvIntereses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumR2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPInteresM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvStatusInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MT_Operacional1
        '
        Me.MT_Operacional1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.MT_Operacional1.BBorrarVisible = True
        Me.MT_Operacional1.BDeshacerVisible = True
        Me.MT_Operacional1.BDetalleVisible = False
        Me.MT_Operacional1.BExportarVisible = False
        Me.MT_Operacional1.BFiltrarVisible = False
        Me.MT_Operacional1.BGuardarVisible = True
        Me.MT_Operacional1.BimagenVisible = False
        Me.MT_Operacional1.BImprimirVisible = True
        Me.MT_Operacional1.BMoneyVisible = False
        Me.MT_Operacional1.BNotasVisible = False
        Me.MT_Operacional1.BRefreshVisible = True
        Me.MT_Operacional1.BSep1Visible = True
        Me.MT_Operacional1.BSep2Visible = False
        Me.MT_Operacional1.BSep3Visible = False
        Me.MT_Operacional1.BSep4Visible = True
        Me.MT_Operacional1.BSep5Visible = False
        Me.MT_Operacional1.BSep6Visible = False
        Me.MT_Operacional1.BSep7Visible = False
        Me.MT_Operacional1.Bsep8visible = False
        Me.MT_Operacional1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MT_Operacional1.Location = New System.Drawing.Point(0, 0)
        Me.MT_Operacional1.Name = "MT_Operacional1"
        Me.MT_Operacional1.Size = New System.Drawing.Size(1008, 28)
        Me.MT_Operacional1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Plazos)
        Me.TabControl1.Controls.Add(Me.Intereses)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 693)
        Me.TabControl1.TabIndex = 1
        '
        'Plazos
        '
        Me.Plazos.Controls.Add(Me.MyDataGrid1)
        Me.Plazos.Controls.Add(Me.GroupBox1)
        Me.Plazos.Location = New System.Drawing.Point(4, 22)
        Me.Plazos.Name = "Plazos"
        Me.Plazos.Padding = New System.Windows.Forms.Padding(3)
        Me.Plazos.Size = New System.Drawing.Size(1000, 667)
        Me.Plazos.TabIndex = 0
        Me.Plazos.Text = "Plazos"
        Me.Plazos.UseVisualStyleBackColor = True
        '
        'MyDataGrid1
        '
        Me.MyDataGrid1.DataMember = ""
        Me.MyDataGrid1.DataSource = Me.DvPlazos
        Me.MyDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MyDataGrid1.Location = New System.Drawing.Point(3, 77)
        Me.MyDataGrid1.Name = "MyDataGrid1"
        Me.MyDataGrid1.Portapapeles = True
        Me.MyDataGrid1.ReadOnly = True
        Me.MyDataGrid1.Size = New System.Drawing.Size(994, 587)
        Me.MyDataGrid1.TabIndex = 8
        Me.MyDataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DvPlazos
        '
        Me.DvPlazos.AllowNew = False
        Me.DvPlazos.Table = Me.DS_FConf.tipos_plazos
        '
        'DS_FConf
        '
        Me.DS_FConf.DataSetName = "DS_FConf"
        Me.DS_FConf.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.MyDataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "tipos_plazos"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Plazo"
        Me.DataGridTextBoxColumn1.MappingName = "tipo_plazo"
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn2.MappingName = "nombre"
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "#,##0.00"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "% Interés."
        Me.DataGridTextBoxColumn3.MappingName = "porc_interes"
        Me.DataGridTextBoxColumn3.Width = 60
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Status"
        Me.DataGridTextBoxColumn4.MappingName = "status"
        Me.DataGridTextBoxColumn4.Width = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtPlazo)
        Me.GroupBox1.Controls.Add(Me.NumPInteresP)
        Me.GroupBox1.Controls.Add(Me.TxtNomPlazo)
        Me.GroupBox1.Controls.Add(Me.CbStatusPlazo)
        Me.GroupBox1.Controls.Add(Me.BtnNvoPlazo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(994, 74)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plazo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "% Interés"
        '
        'TxtPlazo
        '
        Me.TxtPlazo.Location = New System.Drawing.Point(58, 18)
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(59, 20)
        Me.TxtPlazo.TabIndex = 0
        '
        'NumPInteresP
        '
        Me.NumPInteresP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DvPlazos, "porc_interes", True))
        Me.NumPInteresP.DecimalPlaces = 2
        Me.NumPInteresP.Location = New System.Drawing.Point(58, 44)
        Me.NumPInteresP.Name = "NumPInteresP"
        Me.NumPInteresP.Size = New System.Drawing.Size(59, 20)
        Me.NumPInteresP.TabIndex = 5
        Me.NumPInteresP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNomPlazo
        '
        Me.TxtNomPlazo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DvPlazos, "nombre", True))
        Me.TxtNomPlazo.Location = New System.Drawing.Point(123, 18)
        Me.TxtNomPlazo.Name = "TxtNomPlazo"
        Me.TxtNomPlazo.ReadOnly = True
        Me.TxtNomPlazo.Size = New System.Drawing.Size(168, 20)
        Me.TxtNomPlazo.TabIndex = 2
        '
        'CbStatusPlazo
        '
        Me.CbStatusPlazo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DvPlazos, "status", True))
        Me.CbStatusPlazo.DataSource = Me.DvStatusPlazos
        Me.CbStatusPlazo.DisplayMember = "descripcion"
        Me.CbStatusPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbStatusPlazo.FormattingEnabled = True
        Me.CbStatusPlazo.Location = New System.Drawing.Point(340, 18)
        Me.CbStatusPlazo.Name = "CbStatusPlazo"
        Me.CbStatusPlazo.Size = New System.Drawing.Size(100, 21)
        Me.CbStatusPlazo.TabIndex = 4
        Me.CbStatusPlazo.ValueMember = "status"
        '
        'DvStatusPlazos
        '
        Me.DvStatusPlazos.Table = Me.DS_FConf.status
        '
        'BtnNvoPlazo
        '
        Me.BtnNvoPlazo.Image = Global.RYCSEM.My.Resources.Resources._NEW
        Me.BtnNvoPlazo.Location = New System.Drawing.Point(123, 43)
        Me.BtnNvoPlazo.Name = "BtnNvoPlazo"
        Me.BtnNvoPlazo.Size = New System.Drawing.Size(23, 23)
        Me.BtnNvoPlazo.TabIndex = 3
        Me.BtnNvoPlazo.UseVisualStyleBackColor = True
        '
        'Intereses
        '
        Me.Intereses.Controls.Add(Me.MyDataGrid2)
        Me.Intereses.Controls.Add(Me.GroupBox2)
        Me.Intereses.Location = New System.Drawing.Point(4, 22)
        Me.Intereses.Name = "Intereses"
        Me.Intereses.Padding = New System.Windows.Forms.Padding(3)
        Me.Intereses.Size = New System.Drawing.Size(1000, 667)
        Me.Intereses.TabIndex = 1
        Me.Intereses.Text = "Intereses"
        Me.Intereses.UseVisualStyleBackColor = True
        '
        'MyDataGrid2
        '
        Me.MyDataGrid2.DataMember = ""
        Me.MyDataGrid2.DataSource = Me.DvIntereses
        Me.MyDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MyDataGrid2.Location = New System.Drawing.Point(3, 103)
        Me.MyDataGrid2.Name = "MyDataGrid2"
        Me.MyDataGrid2.Portapapeles = True
        Me.MyDataGrid2.ReadOnly = True
        Me.MyDataGrid2.Size = New System.Drawing.Size(994, 561)
        Me.MyDataGrid2.TabIndex = 1
        Me.MyDataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DvIntereses
        '
        Me.DvIntereses.AllowNew = False
        Me.DvIntereses.Table = Me.DS_FConf.intereses
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.MyDataGrid2
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "intereses"
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Interés"
        Me.DataGridTextBoxColumn5.MappingName = "folio"
        Me.DataGridTextBoxColumn5.Width = 60
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn6.MappingName = "nombre"
        Me.DataGridTextBoxColumn6.Width = 150
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = "#,###"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "De."
        Me.DataGridTextBoxColumn7.MappingName = "rango1"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = "#,###"
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "A."
        Me.DataGridTextBoxColumn8.MappingName = "rango2"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn9.MappingName = "nombre_tipo"
        Me.DataGridTextBoxColumn9.Width = 90
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn10.Format = "#,##0.00"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "% Interés."
        Me.DataGridTextBoxColumn10.MappingName = "porc_interes"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Prioridad."
        Me.DataGridTextBoxColumn11.MappingName = "prioridad"
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Status"
        Me.DataGridTextBoxColumn12.MappingName = "status"
        Me.DataGridTextBoxColumn12.Width = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.NumPrioridad)
        Me.GroupBox2.Controls.Add(Me.NumR2)
        Me.GroupBox2.Controls.Add(Me.CbTipoInteres)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.NumR1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.NumPInteresM)
        Me.GroupBox2.Controls.Add(Me.BtnNvoInteres)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtInteres)
        Me.GroupBox2.Controls.Add(Me.TxtNombreInteres)
        Me.GroupBox2.Controls.Add(Me.CbStatusInteres)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(994, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(132, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Prioridad"
        '
        'NumPrioridad
        '
        Me.NumPrioridad.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DvIntereses, "prioridad", True))
        Me.NumPrioridad.Location = New System.Drawing.Point(181, 66)
        Me.NumPrioridad.Name = "NumPrioridad"
        Me.NumPrioridad.Size = New System.Drawing.Size(39, 20)
        Me.NumPrioridad.TabIndex = 21
        Me.NumPrioridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumR2
        '
        Me.NumR2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DvIntereses, "rango2", True))
        Me.NumR2.DecimalPlaces = 2
        Me.NumR2.Location = New System.Drawing.Point(153, 38)
        Me.NumR2.Name = "NumR2"
        Me.NumR2.Size = New System.Drawing.Size(67, 20)
        Me.NumR2.TabIndex = 20
        Me.NumR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbTipoInteres
        '
        Me.CbTipoInteres.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DvIntereses, "tipo_interes", True))
        Me.CbTipoInteres.DataSource = Me.DS_FConf
        Me.CbTipoInteres.DisplayMember = "tipos_intereses.nombre"
        Me.CbTipoInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipoInteres.FormattingEnabled = True
        Me.CbTipoInteres.Location = New System.Drawing.Point(226, 38)
        Me.CbTipoInteres.Name = "CbTipoInteres"
        Me.CbTipoInteres.Size = New System.Drawing.Size(66, 21)
        Me.CbTipoInteres.TabIndex = 19
        Me.CbTipoInteres.ValueMember = "tipos_intereses.tipo_interes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(135, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "De"
        '
        'NumR1
        '
        Me.NumR1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DvIntereses, "rango1", True))
        Me.NumR1.DecimalPlaces = 2
        Me.NumR1.Location = New System.Drawing.Point(59, 38)
        Me.NumR1.Name = "NumR1"
        Me.NumR1.Size = New System.Drawing.Size(67, 20)
        Me.NumR1.TabIndex = 15
        Me.NumR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "% Interés"
        '
        'NumPInteresM
        '
        Me.NumPInteresM.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DvIntereses, "porc_interes", True))
        Me.NumPInteresM.DecimalPlaces = 2
        Me.NumPInteresM.Location = New System.Drawing.Point(59, 66)
        Me.NumPInteresM.Name = "NumPInteresM"
        Me.NumPInteresM.Size = New System.Drawing.Size(67, 20)
        Me.NumPInteresM.TabIndex = 13
        Me.NumPInteresM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnNvoInteres
        '
        Me.BtnNvoInteres.Image = Global.RYCSEM.My.Resources.Resources._NEW
        Me.BtnNvoInteres.Location = New System.Drawing.Point(226, 65)
        Me.BtnNvoInteres.Name = "BtnNvoInteres"
        Me.BtnNvoInteres.Size = New System.Drawing.Size(23, 23)
        Me.BtnNvoInteres.TabIndex = 12
        Me.BtnNvoInteres.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Status"
        '
        'TxtInteres
        '
        Me.TxtInteres.Location = New System.Drawing.Point(59, 12)
        Me.TxtInteres.Name = "TxtInteres"
        Me.TxtInteres.Size = New System.Drawing.Size(59, 20)
        Me.TxtInteres.TabIndex = 8
        '
        'TxtNombreInteres
        '
        Me.TxtNombreInteres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DvIntereses, "nombre", True))
        Me.TxtNombreInteres.Location = New System.Drawing.Point(124, 12)
        Me.TxtNombreInteres.Name = "TxtNombreInteres"
        Me.TxtNombreInteres.ReadOnly = True
        Me.TxtNombreInteres.Size = New System.Drawing.Size(168, 20)
        Me.TxtNombreInteres.TabIndex = 9
        '
        'CbStatusInteres
        '
        Me.CbStatusInteres.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DvIntereses, "status", True))
        Me.CbStatusInteres.DataSource = Me.DvStatusInteres
        Me.CbStatusInteres.DisplayMember = "descripcion"
        Me.CbStatusInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbStatusInteres.FormattingEnabled = True
        Me.CbStatusInteres.Location = New System.Drawing.Point(341, 12)
        Me.CbStatusInteres.Name = "CbStatusInteres"
        Me.CbStatusInteres.Size = New System.Drawing.Size(100, 21)
        Me.CbStatusInteres.TabIndex = 10
        Me.CbStatusInteres.ValueMember = "status"
        '
        'DvStatusInteres
        '
        Me.DvStatusInteres.Table = Me.DS_FConf.status
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Interés"
        '
        'SqlCnn
        '
        Me.SqlCnn.ConnectionString = "Data Source=LUNA;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa;Pas" &
    "sword=rycsem2017"
        Me.SqlCnn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        tipo_plazo, nombre, status, porc_interes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tipos_pla" &
    "zos"
        Me.SqlSelectCommand1.Connection = Me.SqlCnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [tipos_plazos] ([nombre], [status], [porc_interes]) VALUES (@nombre, " &
    "@status, @porc_interes)"
        Me.SqlInsertCommand1.Connection = Me.SqlCnn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status"), New System.Data.SqlClient.SqlParameter("@porc_interes", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_interes", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE [tipos_plazos] SET [nombre] = @nombre, [status] = @status, [porc_interes] " &
    "= @porc_interes WHERE (([tipo_plazo] = @Original_tipo_plazo))"
        Me.SqlUpdateCommand1.Connection = Me.SqlCnn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status"), New System.Data.SqlClient.SqlParameter("@porc_interes", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_interes", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipo_plazo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipo_plazo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [tipos_plazos] WHERE (([tipo_plazo] = @Original_tipo_plazo))"
        Me.SqlDeleteCommand1.Connection = Me.SqlCnn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_tipo_plazo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipo_plazo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SdaTiposPlazos
        '
        Me.SdaTiposPlazos.DeleteCommand = Me.SqlDeleteCommand1
        Me.SdaTiposPlazos.InsertCommand = Me.SqlInsertCommand1
        Me.SdaTiposPlazos.SelectCommand = Me.SqlSelectCommand1
        Me.SdaTiposPlazos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tipos_plazos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("tipo_plazo", "tipo_plazo"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("porc_interes", "porc_interes")})})
        Me.SdaTiposPlazos.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlCnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlCnn
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 0, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 0, "transaccion"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@rango1", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "rango1", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@rango2", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "rango2", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@tipo_interes", System.Data.SqlDbType.Int, 0, "tipo_interes"), New System.Data.SqlClient.SqlParameter("@porc_interes", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_interes", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@prioridad", System.Data.SqlDbType.Int, 0, "prioridad"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlCnn
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 0, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 0, "transaccion"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@rango1", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "rango1", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@rango2", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "rango2", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@tipo_interes", System.Data.SqlDbType.Int, 0, "tipo_interes"), New System.Data.SqlClient.SqlParameter("@porc_interes", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_interes", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@prioridad", System.Data.SqlDbType.Int, 0, "prioridad"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status"), New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [intereses] WHERE (([folio] = @Original_folio))"
        Me.SqlDeleteCommand2.Connection = Me.SqlCnn
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SdaIntereses
        '
        Me.SdaIntereses.DeleteCommand = Me.SqlDeleteCommand2
        Me.SdaIntereses.InsertCommand = Me.SqlInsertCommand2
        Me.SdaIntereses.SelectCommand = Me.SqlSelectCommand2
        Me.SdaIntereses.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "intereses", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("rango1", "rango1"), New System.Data.Common.DataColumnMapping("rango2", "rango2"), New System.Data.Common.DataColumnMapping("tipo_interes", "tipo_interes"), New System.Data.Common.DataColumnMapping("porc_interes", "porc_interes"), New System.Data.Common.DataColumnMapping("prioridad", "prioridad"), New System.Data.Common.DataColumnMapping("status", "status")})})
        Me.SdaIntereses.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT        status, abreviatura, descripcion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE    " &
    "    (status IN ('V', 'C'))"
        Me.SqlSelectCommand3.Connection = Me.SqlCnn
        '
        'SdaStatus
        '
        Me.SdaStatus.SelectCommand = Me.SqlSelectCommand3
        Me.SdaStatus.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "status", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("abreviatura", "abreviatura"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT        tipo_interes, nombre, status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tipos_intereses" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHER" &
    "E        (status = 'V')"
        Me.SqlSelectCommand4.Connection = Me.SqlCnn
        '
        'SdaTipoInteres
        '
        Me.SdaTipoInteres.SelectCommand = Me.SqlSelectCommand4
        Me.SdaTipoInteres.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tipos_intereses", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("tipo_interes", "tipo_interes"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("status", "status")})})
        '
        'FConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MT_Operacional1)
        Me.Name = "FConf"
        Me.Text = "Configuración general"
        Me.TabControl1.ResumeLayout(False)
        Me.Plazos.ResumeLayout(False)
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvPlazos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FConf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumPInteresP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvStatusPlazos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Intereses.ResumeLayout(False)
        CType(Me.MyDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvIntereses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumR2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPInteresM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvStatusInteres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MT_Operacional1 As WindowsControlLibrary1.MT_Operacional
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Plazos As TabPage
    Friend WithEvents Intereses As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents NumPInteresP As MyControls.MyNumeric
    Friend WithEvents CbStatusPlazo As ComboBox
    Friend WithEvents BtnNvoPlazo As Button
    Friend WithEvents TxtNomPlazo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPlazo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MyDataGrid1 As MyControls.MyDataGrid
    Friend WithEvents MyDataGrid2 As MyControls.MyDataGrid
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtInteres As TextBox
    Friend WithEvents TxtNombreInteres As TextBox
    Friend WithEvents CbStatusInteres As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NumR1 As MyControls.MyNumeric
    Friend WithEvents Label6 As Label
    Friend WithEvents NumPInteresM As MyControls.MyNumeric
    Friend WithEvents BtnNvoInteres As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumPrioridad As MyControls.MyNumeric
    Friend WithEvents NumR2 As MyControls.MyNumeric
    Friend WithEvents CbTipoInteres As ComboBox
    Friend WithEvents SqlCnn As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SdaTiposPlazos As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents SdaIntereses As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents SdaStatus As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents SdaTipoInteres As SqlClient.SqlDataAdapter
    Friend WithEvents DvPlazos As DataView
    Friend WithEvents DvIntereses As DataView
    Friend WithEvents DvStatusPlazos As DataView
    Friend WithEvents DvStatusInteres As DataView
    Friend WithEvents DS_FConf As DS_FConf
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As DataGridTextBoxColumn
End Class
