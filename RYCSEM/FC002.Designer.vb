<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FC002
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FC002))
        Me.MToolBar1 = New WindowsControlLibrary1.MToolBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkLiquidar = New System.Windows.Forms.CheckBox()
        Me.DS_FC002 = New RYCSEM.DS_FC002()
        Me.numPorcMor = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numApagar = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numIntereses = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numSugerido = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numDebe = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.numImporte = New System.Windows.Forms.NumericUpDown()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodCte = New System.Windows.Forms.TextBox()
        Me.Cli = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgAbonos = New MyControls.MyDataGrid()
        Me.dvAbonos = New System.Data.DataView()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.sdaFormaPago = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaTraerAbonos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlActFecha = New System.Data.SqlClient.SqlCommand()
        Me.sqlActSaldo = New System.Data.SqlClient.SqlCommand()
        Me.sqlLiquidar = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DS_FC002, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPorcMor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numApagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIntereses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSugerido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDebe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MToolBar1
        '
        Me.MToolBar1.BAnteriorVisible = False
        Me.MToolBar1.BBuscarVisible = False
        Me.MToolBar1.BdeshacerVisible = True
        Me.MToolBar1.Beliminarvisible = False
        Me.MToolBar1.BExportarVisible = True
        Me.MToolBar1.BFiltroVisible = False
        Me.MToolBar1.BGuardarVisible = True
        Me.MToolBar1.Bimagenvisible = False
        Me.MToolBar1.BImprimirVisible = True
        Me.MToolBar1.BmodificarVisible = True
        Me.MToolBar1.BNotasVisible = False
        Me.MToolBar1.BNuevoVisible = True
        Me.MToolBar1.BPrimeroVisible = False
        Me.MToolBar1.BRefreshVisible = False
        Me.MToolBar1.BSep1Visible = False
        Me.MToolBar1.BSep2Visible = True
        Me.MToolBar1.BSep3Visible = True
        Me.MToolBar1.BSep4Visible = True
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
        Me.MToolBar1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkLiquidar)
        Me.GroupBox1.Controls.Add(Me.numPorcMor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.numApagar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.numIntereses)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.numSugerido)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.numDebe)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbFormaPago)
        Me.GroupBox1.Controls.Add(Me.numImporte)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodCte)
        Me.GroupBox1.Controls.Add(Me.Cli)
        Me.GroupBox1.Controls.Add(Me.txtFolio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 108)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'chkLiquidar
        '
        Me.chkLiquidar.AutoSize = True
        Me.chkLiquidar.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DS_FC002, "cliente.liquidar", True))
        Me.chkLiquidar.Location = New System.Drawing.Point(432, 68)
        Me.chkLiquidar.Name = "chkLiquidar"
        Me.chkLiquidar.Size = New System.Drawing.Size(63, 17)
        Me.chkLiquidar.TabIndex = 22
        Me.chkLiquidar.Text = "Liquidar"
        Me.chkLiquidar.UseVisualStyleBackColor = True
        '
        'DS_FC002
        '
        Me.DS_FC002.DataSetName = "DS_FC002"
        Me.DS_FC002.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'numPorcMor
        '
        Me.numPorcMor.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DS_FC002, "abonoPendiente.porc_interes", True))
        Me.numPorcMor.DecimalPlaces = 2
        Me.numPorcMor.Enabled = False
        Me.numPorcMor.Location = New System.Drawing.Point(407, 41)
        Me.numPorcMor.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numPorcMor.Name = "numPorcMor"
        Me.numPorcMor.ReadOnly = True
        Me.numPorcMor.Size = New System.Drawing.Size(76, 20)
        Me.numPorcMor.TabIndex = 21
        Me.numPorcMor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPorcMor.ThousandsSeparator = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "% moratorio"
        '
        'numApagar
        '
        Me.numApagar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DS_FC002, "abonoPendiente.total", True))
        Me.numApagar.DecimalPlaces = 2
        Me.numApagar.Enabled = False
        Me.numApagar.Location = New System.Drawing.Point(716, 41)
        Me.numApagar.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numApagar.Name = "numApagar"
        Me.numApagar.ReadOnly = True
        Me.numApagar.Size = New System.Drawing.Size(76, 20)
        Me.numApagar.TabIndex = 19
        Me.numApagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numApagar.ThousandsSeparator = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(665, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "A pagar"
        '
        'numIntereses
        '
        Me.numIntereses.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DS_FC002, "abonoPendiente.importe_moratorio", True))
        Me.numIntereses.DecimalPlaces = 2
        Me.numIntereses.Enabled = False
        Me.numIntereses.Location = New System.Drawing.Point(582, 41)
        Me.numIntereses.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numIntereses.Name = "numIntereses"
        Me.numIntereses.ReadOnly = True
        Me.numIntereses.Size = New System.Drawing.Size(76, 20)
        Me.numIntereses.TabIndex = 17
        Me.numIntereses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numIntereses.ThousandsSeparator = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(490, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Interes moratorio"
        '
        'numSugerido
        '
        Me.numSugerido.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DS_FC002, "abonoPendiente.abono_sugerido", True))
        Me.numSugerido.DecimalPlaces = 2
        Me.numSugerido.Enabled = False
        Me.numSugerido.Location = New System.Drawing.Point(256, 41)
        Me.numSugerido.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numSugerido.Name = "numSugerido"
        Me.numSugerido.ReadOnly = True
        Me.numSugerido.Size = New System.Drawing.Size(76, 20)
        Me.numSugerido.TabIndex = 15
        Me.numSugerido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSugerido.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Abono sugerido"
        '
        'numDebe
        '
        Me.numDebe.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DS_FC002, "abonoPendiente.saldo", True))
        Me.numDebe.DecimalPlaces = 2
        Me.numDebe.Enabled = False
        Me.numDebe.Location = New System.Drawing.Point(85, 41)
        Me.numDebe.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numDebe.Name = "numDebe"
        Me.numDebe.ReadOnly = True
        Me.numDebe.Size = New System.Drawing.Size(76, 20)
        Me.numDebe.TabIndex = 13
        Me.numDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDebe.ThousandsSeparator = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Usted debe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Forma pago"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.DataSource = Me.DS_FC002
        Me.cbFormaPago.DisplayMember = "formas_pago.nombre"
        Me.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPago.FormattingEnabled = True
        Me.cbFormaPago.Location = New System.Drawing.Point(256, 66)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(170, 21)
        Me.cbFormaPago.TabIndex = 10
        Me.cbFormaPago.ValueMember = "formas_pago.forma_pago"
        '
        'numImporte
        '
        Me.numImporte.DecimalPlaces = 2
        Me.numImporte.Location = New System.Drawing.Point(85, 66)
        Me.numImporte.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numImporte.Name = "numImporte"
        Me.numImporte.Size = New System.Drawing.Size(76, 20)
        Me.numImporte.TabIndex = 7
        Me.numImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numImporte.ThousandsSeparator = True
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DS_FC002, "cliente.nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(338, 15)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(483, 20)
        Me.txtNombre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Abonar"
        '
        'txtCodCte
        '
        Me.txtCodCte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DS_FC002, "cliente.cod_cte", True))
        Me.txtCodCte.Location = New System.Drawing.Point(256, 15)
        Me.txtCodCte.Name = "txtCodCte"
        Me.txtCodCte.ReadOnly = True
        Me.txtCodCte.Size = New System.Drawing.Size(76, 20)
        Me.txtCodCte.TabIndex = 3
        '
        'Cli
        '
        Me.Cli.AutoSize = True
        Me.Cli.Location = New System.Drawing.Point(210, 18)
        Me.Cli.Name = "Cli"
        Me.Cli.Size = New System.Drawing.Size(39, 13)
        Me.Cli.TabIndex = 2
        Me.Cli.Text = "Cliente"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(85, 15)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(76, 20)
        Me.txtFolio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio"
        '
        'dgAbonos
        '
        Me.dgAbonos.CaptionText = "Abonos"
        Me.dgAbonos.DataMember = ""
        Me.dgAbonos.DataSource = Me.dvAbonos
        Me.dgAbonos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAbonos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgAbonos.Location = New System.Drawing.Point(0, 136)
        Me.dgAbonos.Name = "dgAbonos"
        Me.dgAbonos.Portapapeles = True
        Me.dgAbonos.Size = New System.Drawing.Size(1008, 585)
        Me.dgAbonos.TabIndex = 2
        Me.dgAbonos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'dvAbonos
        '
        Me.dvAbonos.AllowNew = False
        Me.dvAbonos.Table = Me.DS_FC002.abonos
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgAbonos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "abonos"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Folio"
        Me.DataGridTextBoxColumn1.MappingName = "folio"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "dd/MM/yyyy HH:mm"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn2.MappingName = "fecha"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 110
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Forma pago"
        Me.DataGridTextBoxColumn3.MappingName = "forma_pago"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Abono."
        Me.DataGridTextBoxColumn4.MappingName = "importe"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 80
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "% Moratorio."
        Me.DataGridTextBoxColumn5.MappingName = "poc_interes_moratorio"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 80
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Interes moratorio."
        Me.DataGridTextBoxColumn6.MappingName = "interes_moratorio"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 80
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Pagó."
        Me.DataGridTextBoxColumn7.MappingName = "total"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 80
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        forma_pago, nombre, abreviatura, status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            formas_pag" &
    "o WITH (NOLOCK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (status = 'V')"
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'sdaFormaPago
        '
        Me.sdaFormaPago.SelectCommand = Me.SqlSelectCommand1
        Me.sdaFormaPago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "formas_pago", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("forma_pago", "forma_pago"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("abreviatura", "abreviatura"), New System.Data.Common.DataColumnMapping("status", "status")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "dbo.FC002_Datos"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10)})
        '
        'sdaTraerAbonos
        '
        Me.sdaTraerAbonos.InsertCommand = Me.SqlCommand1
        Me.sdaTraerAbonos.SelectCommand = Me.SqlSelectCommand2
        Me.sdaTraerAbonos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "abonos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("forma_pago", "forma_pago"), New System.Data.Common.DataColumnMapping("importe", "importe"), New System.Data.Common.DataColumnMapping("poc_interes_moratorio", "poc_interes_moratorio"), New System.Data.Common.DataColumnMapping("interes_moratorio", "interes_moratorio"), New System.Data.Common.DataColumnMapping("total", "total"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("folio_doc", "folio_doc"), New System.Data.Common.DataColumnMapping("transaccion_doc", "transaccion_doc"), New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion")}), New System.Data.Common.DataTableMapping("Table1", "abonoPendiente", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("saldo", "saldo"), New System.Data.Common.DataColumnMapping("abono_sugerido", "abono_sugerido"), New System.Data.Common.DataColumnMapping("porc_interes", "porc_interes"), New System.Data.Common.DataColumnMapping("importe_moratorio", "importe_moratorio"), New System.Data.Common.DataColumnMapping("total", "total")}), New System.Data.Common.DataTableMapping("Table2", "cliente", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.sdaTraerAbonos.UpdateCommand = Me.SqlCommand2
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.CommandTimeout = 9999
        Me.SqlCommand1.Connection = Me.sqlConn
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion"), New System.Data.SqlClient.SqlParameter("@forma_pago", System.Data.SqlDbType.[Char], 5, "forma_pago"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 8, "importe"), New System.Data.SqlClient.SqlParameter("@poc_interes_moratorio", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "poc_interes_moratorio", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@interes_moratorio", System.Data.SqlDbType.Money, 8, "interes_moratorio"), New System.Data.SqlClient.SqlParameter("@folio_doc", System.Data.SqlDbType.[Char], 10, "folio_doc"), New System.Data.SqlClient.SqlParameter("@transaccion_doc", System.Data.SqlDbType.[Char], 10, "transaccion_doc"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.Int, 4, "cod_cte"), New System.Data.SqlClient.SqlParameter("@total", System.Data.SqlDbType.Money, 8, "total")})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandTimeout = 999999
        Me.SqlCommand2.Connection = Me.sqlConn
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@forma_pago", System.Data.SqlDbType.[Char], 5, "forma_pago"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 8, "importe"), New System.Data.SqlClient.SqlParameter("@poc_interes_moratorio", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "poc_interes_moratorio", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@interes_moratorio", System.Data.SqlDbType.Money, 8, "interes_moratorio"), New System.Data.SqlClient.SqlParameter("@folio_doc", System.Data.SqlDbType.[Char], 10, "folio_doc"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.Int, 4, "cod_cte"), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlActFecha
        '
        Me.sqlActFecha.CommandText = "UPDATE       plan_pagos_detalle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                fecha_aplicado = GETDATE()" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W" &
    "HERE        (id = @id)"
        Me.sqlActFecha.CommandTimeout = 9999999
        Me.sqlActFecha.Connection = Me.sqlConn
        Me.sqlActFecha.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlActSaldo
        '
        Me.sqlActSaldo.CommandText = "UPDATE       notas_venta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                saldo = saldo - @abono, abonos = abo" &
    "nos + @abono" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (folio = @folio) AND (transaccion = @transaccion)"
        Me.sqlActSaldo.CommandTimeout = 999999
        Me.sqlActSaldo.Connection = Me.sqlConn
        Me.sqlActSaldo.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@abono", System.Data.SqlDbType.Money, 8, "saldo"), New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "transaccion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlLiquidar
        '
        Me.sqlLiquidar.CommandText = "UPDATE       plan_pagos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                liquidar = 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (folio = @" &
    "folio) AND (transaccion = @transaccion)"
        Me.sqlLiquidar.CommandTimeout = 9999999
        Me.sqlLiquidar.Connection = Me.sqlConn
        Me.sqlLiquidar.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "transaccion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'FC002
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.Controls.Add(Me.dgAbonos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MToolBar1)
        Me.Name = "FC002"
        Me.Text = "Abonos clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DS_FC002, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPorcMor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numApagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIntereses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSugerido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDebe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MToolBar1 As WindowsControlLibrary1.MToolBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodCte As TextBox
    Friend WithEvents Cli As Label
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents numImporte As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents cbFormaPago As ComboBox
    Friend WithEvents dgAbonos As MyControls.MyDataGrid
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents sdaFormaPago As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FC002 As DS_FC002
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaTraerAbonos As SqlClient.SqlDataAdapter
    Friend WithEvents numApagar As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents numIntereses As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents numSugerido As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents numDebe As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents numPorcMor As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents dvAbonos As DataView
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As DataGridTextBoxColumn
    Friend WithEvents sqlActFecha As SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As SqlClient.SqlCommand
    Friend WithEvents sqlActSaldo As SqlClient.SqlCommand
    Friend WithEvents chkLiquidar As CheckBox
    Friend WithEvents sqlLiquidar As SqlClient.SqlCommand
End Class
