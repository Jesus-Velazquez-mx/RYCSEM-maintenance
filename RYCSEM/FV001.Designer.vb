<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FV001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FV001))
        Me.MToolBar1 = New WindowsControlLibrary1.MToolBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbPlazos = New System.Windows.Forms.ComboBox()
        Me.dvNotaVenta = New System.Data.DataView()
        Me.DS_FV001 = New RYCSEM.DS_FV001()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkVentaPublico = New System.Windows.Forms.CheckBox()
        Me.chkDomicCte = New System.Windows.Forms.CheckBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.imgArticulo = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgPlanPagos = New MyControls.MyDataGrid()
        Me.DvPlanPagosDet = New System.Data.DataView()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtArt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.numDescuento = New MyControls.MyNumeric()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.CmbTipoPlazo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MyNumPlazo = New MyControls.MyNumeric()
        Me.cbCondPago = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDomEntrega = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MyDataGrid1 = New MyControls.MyDataGrid()
        Me.DvArticulos = New System.Data.DataView()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.numResto = New MyControls.MyNumeric()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.numSubtotal = New MyControls.MyNumeric()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.numDescGralPorc = New MyControls.MyNumeric()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numTotalGral = New MyControls.MyNumeric()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numEngGral = New MyControls.MyNumeric()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numIVAGral = New MyControls.MyNumeric()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numDescGral = New MyControls.MyNumeric()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numImporte = New MyControls.MyNumeric()
        Me.SqlCnn = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SdaNotasVenta = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SdaNotasVentaDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SdaPlanPagos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SdaPlanPagosDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SdaTiposPlazo = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SdaCondicionesPago = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SdaFormasPago = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.sdaCliente = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.sdaArticulos = New System.Data.SqlClient.SqlDataAdapter()
        Me.dvNotaVentaDetalle = New System.Data.DataView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dvNotaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FV001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgPlanPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvPlanPagosDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyNumPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numResto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDescGralPorc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalGral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEngGral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIVAGral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDescGral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvNotaVentaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MToolBar1.BRefreshVisible = True
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
        Me.GroupBox1.Controls.Add(Me.cbPlazos)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.chkVentaPublico)
        Me.GroupBox1.Controls.Add(Me.chkDomicCte)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.imgArticulo)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxtArt)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.numDescuento)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbFormaPago)
        Me.GroupBox1.Controls.Add(Me.CmbTipoPlazo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.MyNumPlazo)
        Me.GroupBox1.Controls.Add(Me.cbCondPago)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtDomEntrega)
        Me.GroupBox1.Controls.Add(Me.TxtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCliente)
        Me.GroupBox1.Controls.Add(Me.DtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtFolio)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 306)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cbPlazos
        '
        Me.cbPlazos.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvNotaVenta, "plazo", True))
        Me.cbPlazos.DataSource = Me.DS_FV001
        Me.cbPlazos.DisplayMember = "plazos.descripcion"
        Me.cbPlazos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlazos.FormattingEnabled = True
        Me.cbPlazos.Location = New System.Drawing.Point(244, 126)
        Me.cbPlazos.Name = "cbPlazos"
        Me.cbPlazos.Size = New System.Drawing.Size(121, 21)
        Me.cbPlazos.TabIndex = 475
        Me.cbPlazos.ValueMember = "plazos.plazo"
        '
        'dvNotaVenta
        '
        Me.dvNotaVenta.Table = Me.DS_FV001.notas_venta
        '
        'DS_FV001
        '
        Me.DS_FV001.DataSetName = "DS_FV001"
        Me.DS_FV001.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(207, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 474
        Me.Label16.Text = "Plazo"
        '
        'chkVentaPublico
        '
        Me.chkVentaPublico.AutoSize = True
        Me.chkVentaPublico.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.dvNotaVenta, "venta_publico", True))
        Me.chkVentaPublico.Location = New System.Drawing.Point(408, 41)
        Me.chkVentaPublico.Name = "chkVentaPublico"
        Me.chkVentaPublico.Size = New System.Drawing.Size(102, 17)
        Me.chkVentaPublico.TabIndex = 473
        Me.chkVentaPublico.Text = "Venta al público"
        Me.chkVentaPublico.UseVisualStyleBackColor = True
        '
        'chkDomicCte
        '
        Me.chkDomicCte.AutoSize = True
        Me.chkDomicCte.Location = New System.Drawing.Point(408, 64)
        Me.chkDomicCte.Name = "chkDomicCte"
        Me.chkDomicCte.Size = New System.Drawing.Size(117, 17)
        Me.chkDomicCte.TabIndex = 472
        Me.chkDomicCte.Text = "Domicilio de cliente"
        Me.chkDomicCte.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.RYCSEM.My.Resources.Resources.DELETE
        Me.BtnEliminar.Location = New System.Drawing.Point(145, 280)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(25, 23)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'imgArticulo
        '
        Me.imgArticulo.Dock = System.Windows.Forms.DockStyle.Right
        Me.imgArticulo.Location = New System.Drawing.Point(763, 16)
        Me.imgArticulo.Name = "imgArticulo"
        Me.imgArticulo.Size = New System.Drawing.Size(242, 287)
        Me.imgArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgArticulo.TabIndex = 471
        Me.imgArticulo.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgPlanPagos)
        Me.GroupBox4.Location = New System.Drawing.Point(405, 110)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 193)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'dgPlanPagos
        '
        Me.dgPlanPagos.CaptionText = "Plan de pagos"
        Me.dgPlanPagos.DataMember = ""
        Me.dgPlanPagos.DataSource = Me.DvPlanPagosDet
        Me.dgPlanPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPlanPagos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgPlanPagos.Location = New System.Drawing.Point(3, 16)
        Me.dgPlanPagos.Name = "dgPlanPagos"
        Me.dgPlanPagos.Portapapeles = True
        Me.dgPlanPagos.ReadOnly = True
        Me.dgPlanPagos.Size = New System.Drawing.Size(242, 174)
        Me.dgPlanPagos.TabIndex = 0
        Me.dgPlanPagos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DvPlanPagosDet
        '
        Me.DvPlanPagosDet.AllowNew = False
        Me.DvPlanPagosDet.Table = Me.DS_FV001.plan_pagos_detalle
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgPlanPagos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "plan_pagos_detalle"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = "dd/MM/yyyy"
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn1.MappingName = "fecha"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn2.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Importe."
        Me.DataGridTextBoxColumn2.MappingName = "total"
        Me.DataGridTextBoxColumn2.Width = 70
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(134, 183)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "%"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Artículo"
        '
        'TxtArt
        '
        Me.TxtArt.Location = New System.Drawing.Point(76, 281)
        Me.TxtArt.Name = "TxtArt"
        Me.TxtArt.Size = New System.Drawing.Size(64, 20)
        Me.TxtArt.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Desc."
        '
        'numDescuento
        '
        Me.numDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dvNotaVenta, "porc_descuento", True))
        Me.numDescuento.DecimalPlaces = 2
        Me.numDescuento.Location = New System.Drawing.Point(76, 180)
        Me.numDescuento.Name = "numDescuento"
        Me.numDescuento.Size = New System.Drawing.Size(55, 20)
        Me.numDescuento.TabIndex = 16
        Me.numDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Forma pago"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Cond. Pago"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvNotaVenta, "forma_pago", True))
        Me.cbFormaPago.DataSource = Me.DS_FV001
        Me.cbFormaPago.DisplayMember = "formas_pago.nombre"
        Me.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPago.FormattingEnabled = True
        Me.cbFormaPago.Location = New System.Drawing.Point(76, 153)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(121, 21)
        Me.cbFormaPago.TabIndex = 13
        Me.cbFormaPago.ValueMember = "formas_pago.forma_pago"
        '
        'CmbTipoPlazo
        '
        Me.CmbTipoPlazo.DataSource = Me.DS_FV001
        Me.CmbTipoPlazo.DisplayMember = "tipos_plazos.nombre"
        Me.CmbTipoPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoPlazo.FormattingEnabled = True
        Me.CmbTipoPlazo.Location = New System.Drawing.Point(306, 154)
        Me.CmbTipoPlazo.Name = "CmbTipoPlazo"
        Me.CmbTipoPlazo.Size = New System.Drawing.Size(93, 21)
        Me.CmbTipoPlazo.TabIndex = 12
        Me.CmbTipoPlazo.ValueMember = "tipos_plazos.tipo_plazo"
        Me.CmbTipoPlazo.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(207, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Plazo"
        Me.Label10.Visible = False
        '
        'MyNumPlazo
        '
        Me.MyNumPlazo.DecimalPlaces = 2
        Me.MyNumPlazo.Location = New System.Drawing.Point(245, 154)
        Me.MyNumPlazo.Name = "MyNumPlazo"
        Me.MyNumPlazo.Size = New System.Drawing.Size(55, 20)
        Me.MyNumPlazo.TabIndex = 10
        Me.MyNumPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MyNumPlazo.Visible = False
        '
        'cbCondPago
        '
        Me.cbCondPago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvNotaVenta, "cond_pago", True))
        Me.cbCondPago.DataSource = Me.DS_FV001
        Me.cbCondPago.DisplayMember = "condiciones_pago.nombre"
        Me.cbCondPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCondPago.FormattingEnabled = True
        Me.cbCondPago.Location = New System.Drawing.Point(76, 126)
        Me.cbCondPago.Name = "cbCondPago"
        Me.cbCondPago.Size = New System.Drawing.Size(121, 21)
        Me.cbCondPago.TabIndex = 9
        Me.cbCondPago.ValueMember = "condiciones_pago.condicion"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 53)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Domicilio de entrega"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDomEntrega
        '
        Me.TxtDomEntrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvNotaVenta, "domicilio_entrega", True))
        Me.TxtDomEntrega.Location = New System.Drawing.Point(76, 64)
        Me.TxtDomEntrega.Multiline = True
        Me.TxtDomEntrega.Name = "TxtDomEntrega"
        Me.TxtDomEntrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDomEntrega.Size = New System.Drawing.Size(322, 56)
        Me.TxtDomEntrega.TabIndex = 7
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvNotaVenta, "razon_social", True))
        Me.TxtRazonSocial.Location = New System.Drawing.Point(146, 39)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.ReadOnly = True
        Me.TxtRazonSocial.Size = New System.Drawing.Size(253, 20)
        Me.TxtRazonSocial.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvNotaVenta, "cod_cte", True))
        Me.TxtCliente.Location = New System.Drawing.Point(76, 39)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(64, 20)
        Me.TxtCliente.TabIndex = 4
        '
        'DtpFecha
        '
        Me.DtpFecha.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFecha.Location = New System.Drawing.Point(189, 12)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(126, 20)
        Me.DtpFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folio"
        '
        'TxtFolio
        '
        Me.TxtFolio.Location = New System.Drawing.Point(76, 12)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(64, 20)
        Me.TxtFolio.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MyDataGrid1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 387)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'MyDataGrid1
        '
        Me.MyDataGrid1.CaptionText = "Artículos"
        Me.MyDataGrid1.DataMember = ""
        Me.MyDataGrid1.DataSource = Me.DvArticulos
        Me.MyDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MyDataGrid1.Location = New System.Drawing.Point(3, 16)
        Me.MyDataGrid1.Name = "MyDataGrid1"
        Me.MyDataGrid1.Portapapeles = True
        Me.MyDataGrid1.Size = New System.Drawing.Size(1002, 368)
        Me.MyDataGrid1.TabIndex = 0
        Me.MyDataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DvArticulos
        '
        Me.DvArticulos.AllowNew = False
        Me.DvArticulos.Table = Me.DS_FV001.notas_venta_detalle
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.MyDataGrid1
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "notas_venta_detalle"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Articulo"
        Me.DataGridTextBoxColumn3.MappingName = "cod_art"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn11.MappingName = "descripcion"
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "##0"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Cant."
        Me.DataGridTextBoxColumn4.MappingName = "cantidad"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Unidad"
        Me.DataGridTextBoxColumn5.MappingName = "unidad"
        Me.DataGridTextBoxColumn5.NullText = "PZA"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn12.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Precio."
        Me.DataGridTextBoxColumn12.MappingName = "precio"
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Importe."
        Me.DataGridTextBoxColumn6.MappingName = "importe"
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Descuento."
        Me.DataGridTextBoxColumn7.MappingName = "importe_descuento"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "IVA."
        Me.DataGridTextBoxColumn8.MappingName = "iva"
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Total."
        Me.DataGridTextBoxColumn9.MappingName = "total"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.numResto)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.numSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.numDescGralPorc)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.numTotalGral)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.numEngGral)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.numIVAGral)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.numDescGral)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.numImporte)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 648)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1008, 73)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(638, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "A pagar"
        '
        'numResto
        '
        Me.numResto.DecimalPlaces = 2
        Me.numResto.Enabled = False
        Me.numResto.Location = New System.Drawing.Point(684, 41)
        Me.numResto.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numResto.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.numResto.Name = "numResto"
        Me.numResto.ReadOnly = True
        Me.numResto.Size = New System.Drawing.Size(87, 20)
        Me.numResto.TabIndex = 19
        Me.numResto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numResto.ThousandsSeparator = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Subtotal"
        '
        'numSubtotal
        '
        Me.numSubtotal.DecimalPlaces = 2
        Me.numSubtotal.Enabled = False
        Me.numSubtotal.Location = New System.Drawing.Point(68, 41)
        Me.numSubtotal.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numSubtotal.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.numSubtotal.Name = "numSubtotal"
        Me.numSubtotal.ReadOnly = True
        Me.numSubtotal.Size = New System.Drawing.Size(87, 20)
        Me.numSubtotal.TabIndex = 17
        Me.numSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSubtotal.ThousandsSeparator = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(313, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Desc. %"
        '
        'numDescGralPorc
        '
        Me.numDescGralPorc.DecimalPlaces = 2
        Me.numDescGralPorc.Enabled = False
        Me.numDescGralPorc.Location = New System.Drawing.Point(372, 13)
        Me.numDescGralPorc.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numDescGralPorc.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.numDescGralPorc.Name = "numDescGralPorc"
        Me.numDescGralPorc.ReadOnly = True
        Me.numDescGralPorc.Size = New System.Drawing.Size(87, 20)
        Me.numDescGralPorc.TabIndex = 15
        Me.numDescGralPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDescGralPorc.ThousandsSeparator = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(323, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Total"
        '
        'numTotalGral
        '
        Me.numTotalGral.DecimalPlaces = 2
        Me.numTotalGral.Enabled = False
        Me.numTotalGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotalGral.Location = New System.Drawing.Point(372, 41)
        Me.numTotalGral.Maximum = New Decimal(New Integer() {-1981284353, -1966660860, 0, 0})
        Me.numTotalGral.Minimum = New Decimal(New Integer() {-1304428545, 434162106, 542, -2147483648})
        Me.numTotalGral.Name = "numTotalGral"
        Me.numTotalGral.ReadOnly = True
        Me.numTotalGral.Size = New System.Drawing.Size(87, 20)
        Me.numTotalGral.TabIndex = 13
        Me.numTotalGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotalGral.ThousandsSeparator = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(472, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Enganche"
        '
        'numEngGral
        '
        Me.numEngGral.DecimalPlaces = 2
        Me.numEngGral.Enabled = False
        Me.numEngGral.Location = New System.Drawing.Point(541, 41)
        Me.numEngGral.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numEngGral.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.numEngGral.Name = "numEngGral"
        Me.numEngGral.ReadOnly = True
        Me.numEngGral.Size = New System.Drawing.Size(87, 20)
        Me.numEngGral.TabIndex = 11
        Me.numEngGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numEngGral.ThousandsSeparator = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(176, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "IVA"
        '
        'numIVAGral
        '
        Me.numIVAGral.DecimalPlaces = 2
        Me.numIVAGral.Enabled = False
        Me.numIVAGral.Location = New System.Drawing.Point(213, 41)
        Me.numIVAGral.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numIVAGral.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.numIVAGral.Name = "numIVAGral"
        Me.numIVAGral.ReadOnly = True
        Me.numIVAGral.Size = New System.Drawing.Size(87, 20)
        Me.numIVAGral.TabIndex = 9
        Me.numIVAGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numIVAGral.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Desc"
        '
        'numDescGral
        '
        Me.numDescGral.DecimalPlaces = 2
        Me.numDescGral.Enabled = False
        Me.numDescGral.Location = New System.Drawing.Point(213, 13)
        Me.numDescGral.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numDescGral.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.numDescGral.Name = "numDescGral"
        Me.numDescGral.ReadOnly = True
        Me.numDescGral.Size = New System.Drawing.Size(87, 20)
        Me.numDescGral.TabIndex = 7
        Me.numDescGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDescGral.ThousandsSeparator = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Importe"
        '
        'numImporte
        '
        Me.numImporte.DecimalPlaces = 2
        Me.numImporte.Enabled = False
        Me.numImporte.Location = New System.Drawing.Point(68, 13)
        Me.numImporte.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numImporte.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.numImporte.Name = "numImporte"
        Me.numImporte.ReadOnly = True
        Me.numImporte.Size = New System.Drawing.Size(87, 20)
        Me.numImporte.TabIndex = 0
        Me.numImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numImporte.ThousandsSeparator = True
        '
        'SqlCnn
        '
        Me.SqlCnn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa" &
    ";Password=luna"
        Me.SqlCnn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.CommandTimeout = 99999
        Me.SqlSelectCommand1.Connection = Me.SqlCnn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio")})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.CommandTimeout = 9999
        Me.SqlInsertCommand1.Connection = Me.SqlCnn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 4, "fecha"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 10, "cod_cte"), New System.Data.SqlClient.SqlParameter("@domicilio_entrega", System.Data.SqlDbType.VarChar, 500, "domicilio_entrega"), New System.Data.SqlClient.SqlParameter("@cond_pago", System.Data.SqlDbType.[Char], 5, "cond_pago"), New System.Data.SqlClient.SqlParameter("@plazo", System.Data.SqlDbType.Int, 4, "plazo"), New System.Data.SqlClient.SqlParameter("@porc_descuento", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_descuento", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@importe_descuento", System.Data.SqlDbType.Money, 8, "importe_descuento"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 8, "importe"), New System.Data.SqlClient.SqlParameter("@iva", System.Data.SqlDbType.Money, 8, "iva"), New System.Data.SqlClient.SqlParameter("@ieps", System.Data.SqlDbType.Money, 8, "ieps"), New System.Data.SqlClient.SqlParameter("@saldo", System.Data.SqlDbType.Money, 8, "saldo"), New System.Data.SqlClient.SqlParameter("@abonos", System.Data.SqlDbType.Money, 8, "abonos"), New System.Data.SqlClient.SqlParameter("@forma_pago", System.Data.SqlDbType.[Char], 5, "forma_pago"), New System.Data.SqlClient.SqlParameter("@venta_publico", System.Data.SqlDbType.Bit, 1, "venta_publico"), New System.Data.SqlClient.SqlParameter("@razon_social", System.Data.SqlDbType.VarChar, 250, "razon_social")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.CommandTimeout = 9999999
        Me.SqlUpdateCommand1.Connection = Me.SqlCnn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 4, "fecha"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 10, "cod_cte"), New System.Data.SqlClient.SqlParameter("@domicilio_entrega", System.Data.SqlDbType.VarChar, 500, "domicilio_entrega"), New System.Data.SqlClient.SqlParameter("@cond_pago", System.Data.SqlDbType.[Char], 5, "cond_pago"), New System.Data.SqlClient.SqlParameter("@plazo", System.Data.SqlDbType.Int, 4, "plazo"), New System.Data.SqlClient.SqlParameter("@porc_descuento", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_descuento", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@importe_descuento", System.Data.SqlDbType.Money, 8, "importe_descuento"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 8, "importe"), New System.Data.SqlClient.SqlParameter("@iva", System.Data.SqlDbType.Money, 8, "iva"), New System.Data.SqlClient.SqlParameter("@ieps", System.Data.SqlDbType.Money, 8, "ieps"), New System.Data.SqlClient.SqlParameter("@saldo", System.Data.SqlDbType.Money, 8, "saldo"), New System.Data.SqlClient.SqlParameter("@abonos", System.Data.SqlDbType.Money, 8, "abonos"), New System.Data.SqlClient.SqlParameter("@forma_pago", System.Data.SqlDbType.[Char], 5, "forma_pago"), New System.Data.SqlClient.SqlParameter("@venta_publico", System.Data.SqlDbType.Bit, 1, "venta_publico"), New System.Data.SqlClient.SqlParameter("@razon_social", System.Data.SqlDbType.VarChar, 250, "razon_social"), New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [notas_venta] WHERE (([folio] = @Original_folio))"
        Me.SqlDeleteCommand1.Connection = Me.SqlCnn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SdaNotasVenta
        '
        Me.SdaNotasVenta.DeleteCommand = Me.SqlDeleteCommand1
        Me.SdaNotasVenta.InsertCommand = Me.SqlInsertCommand1
        Me.SdaNotasVenta.SelectCommand = Me.SqlSelectCommand1
        Me.SdaNotasVenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "notas_venta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("domicilio_entrega", "domicilio_entrega"), New System.Data.Common.DataColumnMapping("cond_pago", "cond_pago"), New System.Data.Common.DataColumnMapping("plazo", "plazo"), New System.Data.Common.DataColumnMapping("porc_descuento", "porc_descuento"), New System.Data.Common.DataColumnMapping("importe_descuento", "importe_descuento"), New System.Data.Common.DataColumnMapping("importe", "importe"), New System.Data.Common.DataColumnMapping("iva", "iva"), New System.Data.Common.DataColumnMapping("ieps", "ieps"), New System.Data.Common.DataColumnMapping("total", "total"), New System.Data.Common.DataColumnMapping("saldo", "saldo"), New System.Data.Common.DataColumnMapping("abonos", "abonos")})})
        Me.SdaNotasVenta.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlCnn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlCnn
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 10, "cod_art"), New System.Data.SqlClient.SqlParameter("@unidad", System.Data.SqlDbType.[Char], 5, "unidad"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 8, "importe"), New System.Data.SqlClient.SqlParameter("@iva", System.Data.SqlDbType.Money, 8, "iva"), New System.Data.SqlClient.SqlParameter("@ieps", System.Data.SqlDbType.Money, 8, "ieps"), New System.Data.SqlClient.SqlParameter("@porc_descuento", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_descuento", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@importe_descuento", System.Data.SqlDbType.Money, 8, "importe_descuento"), New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [notas_venta_detalle] WHERE (([folio] = @Original_folio))"
        Me.SqlDeleteCommand2.Connection = Me.SqlCnn
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SdaNotasVentaDetalle
        '
        Me.SdaNotasVentaDetalle.DeleteCommand = Me.SqlDeleteCommand2
        Me.SdaNotasVentaDetalle.InsertCommand = Me.SqlInsertCommand2
        Me.SdaNotasVentaDetalle.SelectCommand = Me.SqlSelectCommand2
        Me.SdaNotasVentaDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "notas_venta_detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("cod_art", "cod_art"), New System.Data.Common.DataColumnMapping("unidad", "unidad"), New System.Data.Common.DataColumnMapping("importe", "importe"), New System.Data.Common.DataColumnMapping("iva", "iva"), New System.Data.Common.DataColumnMapping("ieps", "ieps"), New System.Data.Common.DataColumnMapping("porc_descuento", "porc_descuento"), New System.Data.Common.DataColumnMapping("importe_descuento", "importe_descuento"), New System.Data.Common.DataColumnMapping("total", "total"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("imagen", "imagen"), New System.Data.Common.DataColumnMapping("nombre_imagen", "nombre_imagen")})})
        Me.SdaNotasVentaDetalle.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlCnn
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 0, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 0, "transaccion"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 0, "cod_art"), New System.Data.SqlClient.SqlParameter("@unidad", System.Data.SqlDbType.[Char], 0, "unidad"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 0, "importe"), New System.Data.SqlClient.SqlParameter("@iva", System.Data.SqlDbType.Money, 0, "iva"), New System.Data.SqlClient.SqlParameter("@ieps", System.Data.SqlDbType.Money, 0, "ieps"), New System.Data.SqlClient.SqlParameter("@porc_descuento", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_descuento", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@importe_descuento", System.Data.SqlDbType.Money, 0, "importe_descuento")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT        folio, transaccion, fecha, cod_cte, plazo, tipo_interes, liquidar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "FROM            plan_pagos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (folio = @folio)"
        Me.SqlSelectCommand3.CommandTimeout = 999999
        Me.SqlSelectCommand3.Connection = Me.SqlCnn
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio")})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO plan_pagos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         (folio, transaccion, fecha, cod_" &
    "cte, plazo, tipo_interes, liquidar)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES        (@folio,@transaccion,@fecha,@" &
    "cod_cte,@plazo,@tipo_interes,@liquidar)"
        Me.SqlInsertCommand3.Connection = Me.SqlCnn
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 4, "fecha"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.Int, 4, "cod_cte"), New System.Data.SqlClient.SqlParameter("@plazo", System.Data.SqlDbType.Int, 4, "plazo"), New System.Data.SqlClient.SqlParameter("@tipo_interes", System.Data.SqlDbType.Int, 4, "tipo_interes"), New System.Data.SqlClient.SqlParameter("@liquidar", System.Data.SqlDbType.Bit, 1, "liquidar")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE       plan_pagos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                fecha = @fecha, cod_cte = @cod_cte, p" &
    "lazo = @plazo, tipo_interes = @tipo_interes, liquidar = @liquidar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        " &
    "(folio = @Original_folio)"
        Me.SqlUpdateCommand3.Connection = Me.SqlCnn
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 4, "fecha"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.Int, 4, "cod_cte"), New System.Data.SqlClient.SqlParameter("@plazo", System.Data.SqlDbType.Int, 4, "plazo"), New System.Data.SqlClient.SqlParameter("@tipo_interes", System.Data.SqlDbType.Int, 4, "tipo_interes"), New System.Data.SqlClient.SqlParameter("@liquidar", System.Data.SqlDbType.Bit, 1, "liquidar"), New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM [plan_pagos] WHERE (([folio] = @Original_folio))"
        Me.SqlDeleteCommand3.Connection = Me.SqlCnn
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SdaPlanPagos
        '
        Me.SdaPlanPagos.DeleteCommand = Me.SqlDeleteCommand3
        Me.SdaPlanPagos.InsertCommand = Me.SqlInsertCommand3
        Me.SdaPlanPagos.SelectCommand = Me.SqlSelectCommand3
        Me.SdaPlanPagos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "plan_pagos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("plazo", "plazo"), New System.Data.Common.DataColumnMapping("tipo_interes", "tipo_interes")})})
        Me.SdaPlanPagos.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "select * from plan_pagos_detalle"
        Me.SqlSelectCommand4.Connection = Me.SqlCnn
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO [plan_pagos_detalle] ([folio], [transaccion], [fecha], [importe], [iv" &
    "a], [fecha_aplicado]) VALUES (@folio, @transaccion, @fecha, @importe, @iva, @fec" &
    "ha_aplicado)"
        Me.SqlInsertCommand4.Connection = Me.SqlCnn
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 0, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 0, "transaccion"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 0, "fecha"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 0, "importe"), New System.Data.SqlClient.SqlParameter("@iva", System.Data.SqlDbType.Money, 0, "iva"), New System.Data.SqlClient.SqlParameter("@fecha_aplicado", System.Data.SqlDbType.SmallDateTime, 0, "fecha_aplicado")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE       plan_pagos_detalle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                fecha = @fecha, importe = @im" &
    "porte, iva = @iva, fecha_aplicado = @fecha_aplicado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (folio = @Orig" &
    "inal_folio)"
        Me.SqlUpdateCommand4.Connection = Me.SqlCnn
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 4, "fecha"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 8, "importe"), New System.Data.SqlClient.SqlParameter("@iva", System.Data.SqlDbType.Money, 8, "iva"), New System.Data.SqlClient.SqlParameter("@fecha_aplicado", System.Data.SqlDbType.SmallDateTime, 4, "fecha_aplicado"), New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM [plan_pagos_detalle] WHERE (([folio] = @Original_folio))"
        Me.SqlDeleteCommand4.Connection = Me.SqlCnn
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_folio", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SdaPlanPagosDetalle
        '
        Me.SdaPlanPagosDetalle.DeleteCommand = Me.SqlDeleteCommand4
        Me.SdaPlanPagosDetalle.InsertCommand = Me.SqlInsertCommand4
        Me.SdaPlanPagosDetalle.SelectCommand = Me.SqlSelectCommand4
        Me.SdaPlanPagosDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "plan_pagos_detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("importe", "importe"), New System.Data.Common.DataColumnMapping("iva", "iva"), New System.Data.Common.DataColumnMapping("total", "total"), New System.Data.Common.DataColumnMapping("fecha_aplicado", "fecha_aplicado")})})
        Me.SdaPlanPagosDetalle.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT        tipo_plazo, nombre, status, porc_interes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tipos_pla" &
    "zos"
        Me.SqlSelectCommand5.Connection = Me.SqlCnn
        '
        'SdaTiposPlazo
        '
        Me.SdaTiposPlazo.SelectCommand = Me.SqlSelectCommand5
        Me.SdaTiposPlazo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tipos_plazos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("tipo_plazo", "tipo_plazo"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("status", "status")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT        condicion, nombre, status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            condiciones_pago WITH (N" &
    "OLOCK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (status = 'V')"
        Me.SqlSelectCommand6.CommandTimeout = 999
        Me.SqlSelectCommand6.Connection = Me.SqlCnn
        '
        'SdaCondicionesPago
        '
        Me.SdaCondicionesPago.SelectCommand = Me.SqlSelectCommand6
        Me.SdaCondicionesPago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "condiciones_pago", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("condicion", "condicion"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("status", "status")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "select * from formas_pago where status = 'V'"
        Me.SqlSelectCommand7.Connection = Me.SqlCnn
        '
        'SdaFormasPago
        '
        Me.SdaFormasPago.SelectCommand = Me.SqlSelectCommand7
        Me.SdaFormasPago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "formas_pago", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("forma_pago", "forma_pago"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("abreviatura", "abreviatura"), New System.Data.Common.DataColumnMapping("status", "status")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = resources.GetString("SqlSelectCommand9.CommandText")
        Me.SqlSelectCommand9.Connection = Me.SqlCnn
        Me.SqlSelectCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.Int, 4, "cod_cte")})
        '
        'sdaCliente
        '
        Me.sdaCliente.SelectCommand = Me.SqlSelectCommand9
        Me.sdaCliente.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("razon_social", "razon_social"), New System.Data.Common.DataColumnMapping("direccion", "direccion")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT        cod_art, descripcion, precio, nombre_imagen, porc_ganancia, imagen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            articulos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (cod_art = @cod_art)"
        Me.SqlSelectCommand10.Connection = Me.SqlCnn
        Me.SqlSelectCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 10, "cod_art")})
        '
        'sdaArticulos
        '
        Me.sdaArticulos.SelectCommand = Me.SqlSelectCommand10
        Me.sdaArticulos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "articulos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_art", "cod_art"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("nombre_imagen", "nombre_imagen"), New System.Data.Common.DataColumnMapping("porc_ganancia", "porc_ganancia"), New System.Data.Common.DataColumnMapping("imagen", "imagen")})})
        '
        'dvNotaVentaDetalle
        '
        Me.dvNotaVentaDetalle.Table = Me.DS_FV001.plan_pagos_detalle
        '
        'FV001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MToolBar1)
        Me.Name = "FV001"
        Me.Text = "Nota de venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dvNotaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FV001, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgPlanPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvPlanPagosDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyNumPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numResto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDescGralPorc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalGral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEngGral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIVAGral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDescGral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvNotaVentaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MToolBar1 As WindowsControlLibrary1.MToolBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDomEntrega As TextBox
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFolio As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MyDataGrid1 As MyControls.MyDataGrid
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents numTotalGral As MyControls.MyNumeric
    Friend WithEvents Label8 As Label
    Friend WithEvents numEngGral As MyControls.MyNumeric
    Friend WithEvents Label7 As Label
    Friend WithEvents numIVAGral As MyControls.MyNumeric
    Friend WithEvents Label6 As Label
    Friend WithEvents numDescGral As MyControls.MyNumeric
    Friend WithEvents Label5 As Label
    Friend WithEvents numImporte As MyControls.MyNumeric
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgPlanPagos As MyControls.MyDataGrid
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtArt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents numDescuento As MyControls.MyNumeric
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbFormaPago As ComboBox
    Friend WithEvents CmbTipoPlazo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents MyNumPlazo As MyControls.MyNumeric
    Friend WithEvents cbCondPago As ComboBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents imgArticulo As PictureBox
    Friend WithEvents SqlCnn As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SdaNotasVenta As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents SdaNotasVentaDetalle As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As SqlClient.SqlCommand
    Friend WithEvents SdaPlanPagos As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As SqlClient.SqlCommand
    Friend WithEvents SdaPlanPagosDetalle As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As SqlClient.SqlCommand
    Friend WithEvents SdaTiposPlazo As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As SqlClient.SqlCommand
    Friend WithEvents SdaCondicionesPago As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As SqlClient.SqlCommand
    Friend WithEvents SdaFormasPago As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FV001 As DS_FV001
    Friend WithEvents DvPlanPagosDet As DataView
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DvArticulos As DataView
    Friend WithEvents DataGridTableStyle2 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As DataGridTextBoxColumn
    Friend WithEvents chkDomicCte As CheckBox
    Friend WithEvents SqlSelectCommand9 As SqlClient.SqlCommand
    Friend WithEvents sdaCliente As SqlClient.SqlDataAdapter
    Friend WithEvents chkVentaPublico As CheckBox
    Friend WithEvents cbPlazos As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents SqlSelectCommand10 As SqlClient.SqlCommand
    Friend WithEvents sdaArticulos As SqlClient.SqlDataAdapter
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents Label17 As Label
    Friend WithEvents numDescGralPorc As MyControls.MyNumeric
    Friend WithEvents Label18 As Label
    Friend WithEvents numSubtotal As MyControls.MyNumeric
    Friend WithEvents Label19 As Label
    Friend WithEvents numResto As MyControls.MyNumeric
    Friend WithEvents dvNotaVenta As DataView
    Friend WithEvents dvNotaVentaDetalle As DataView
End Class
