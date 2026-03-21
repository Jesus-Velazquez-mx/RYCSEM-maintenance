<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FV002
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FV002))
        Me.MT_reportes1 = New WindowsControlLibrary1.MT_reportes()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFF = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFI = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtCodCte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.DS_FV002 = New RYCSEM.DS_FV002()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MyDataGrid1 = New MyControls.MyDataGrid()
        Me.dvCabecero = New System.Data.DataView()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.MyDataGrid2 = New MyControls.MyDataGrid()
        Me.dvDetalle = New System.Data.DataView()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.MyDataGrid3 = New MyControls.MyDataGrid()
        Me.dvResumenArticulos = New System.Data.DataView()
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.sdaStatus = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaDatos = New System.Data.SqlClient.SqlDataAdapter()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DS_FV002, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvCabecero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.MyDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvResumenArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MT_reportes1
        '
        Me.MT_reportes1.BExportarVisible = False
        Me.MT_reportes1.BFilterVisible = False
        Me.MT_reportes1.BGraficarVisible = False
        Me.MT_reportes1.BimagenVisible = False
        Me.MT_reportes1.BImprimirVisible = False
        Me.MT_reportes1.BIvaVisible = False
        Me.MT_reportes1.BMilesVisible = False
        Me.MT_reportes1.BPlanoCVisible = False
        Me.MT_reportes1.BRefreshVisible = False
        Me.MT_reportes1.BSep1Visible = False
        Me.MT_reportes1.BSep2Visible = False
        Me.MT_reportes1.BSep3Visible = False
        Me.MT_reportes1.BSep4Visible = False
        Me.MT_reportes1.Bsep5visible = False
        Me.MT_reportes1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MT_reportes1.Location = New System.Drawing.Point(0, 0)
        Me.MT_reportes1.Name = "MT_reportes1"
        Me.MT_reportes1.Size = New System.Drawing.Size(1008, 54)
        Me.MT_reportes1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFF)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFI)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.txtCodCte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbStatus)
        Me.GroupBox1.Controls.Add(Me.txtFolio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 91)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'dtpFF
        '
        Me.dtpFF.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFF.Location = New System.Drawing.Point(241, 14)
        Me.dtpFF.Name = "dtpFF"
        Me.dtpFF.Size = New System.Drawing.Size(139, 26)
        Me.dtpFF.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "A"
        '
        'dtpFI
        '
        Me.dtpFI.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFI.Location = New System.Drawing.Point(58, 14)
        Me.dtpFI.Name = "dtpFI"
        Me.dtpFI.Size = New System.Drawing.Size(140, 26)
        Me.dtpFI.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "De"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(389, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Status"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(333, 55)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(363, 26)
        Me.txtRazonSocial.TabIndex = 5
        '
        'txtCodCte
        '
        Me.txtCodCte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCte.Location = New System.Drawing.Point(241, 55)
        Me.txtCodCte.Name = "txtCodCte"
        Me.txtCodCte.Size = New System.Drawing.Size(86, 26)
        Me.txtCodCte.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente"
        '
        'cbStatus
        '
        Me.cbStatus.DataSource = Me.DS_FV002
        Me.cbStatus.DisplayMember = "status.descripcion"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(455, 13)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(186, 28)
        Me.cbStatus.TabIndex = 2
        Me.cbStatus.ValueMember = "status.status"
        '
        'DS_FV002
        '
        Me.DS_FV002.DataSetName = "DS_FV002"
        Me.DS_FV002.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtFolio
        '
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(58, 55)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(108, 26)
        Me.txtFolio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 145)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MyDataGrid1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1008, 576)
        Me.SplitContainer1.SplitterDistance = 259
        Me.SplitContainer1.TabIndex = 4
        '
        'MyDataGrid1
        '
        Me.MyDataGrid1.CaptionText = "Nota de venta"
        Me.MyDataGrid1.DataMember = ""
        Me.MyDataGrid1.DataSource = Me.dvCabecero
        Me.MyDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MyDataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGrid1.Name = "MyDataGrid1"
        Me.MyDataGrid1.Portapapeles = True
        Me.MyDataGrid1.ReadOnly = True
        Me.MyDataGrid1.Size = New System.Drawing.Size(1008, 259)
        Me.MyDataGrid1.TabIndex = 3
        Me.MyDataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'dvCabecero
        '
        Me.dvCabecero.AllowNew = False
        Me.dvCabecero.Table = Me.DS_FV002.cabecero
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.MyDataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "cabecero"
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
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridTextBoxColumn3.MappingName = "cod_cte"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Razón social"
        Me.DataGridTextBoxColumn4.MappingName = "razonSocial"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 190
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Cond. Pago"
        Me.DataGridTextBoxColumn6.MappingName = "condPago"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 120
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "% Desc. Gen."
        Me.DataGridTextBoxColumn8.MappingName = "porc_descuento"
        Me.DataGridTextBoxColumn8.NullText = "0"
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Importe Desc."
        Me.DataGridTextBoxColumn9.MappingName = "importe_descuento"
        Me.DataGridTextBoxColumn9.NullText = "0"
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn10.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Importe."
        Me.DataGridTextBoxColumn10.MappingName = "importe"
        Me.DataGridTextBoxColumn10.NullText = "0"
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "IVA."
        Me.DataGridTextBoxColumn11.MappingName = "iva"
        Me.DataGridTextBoxColumn11.NullText = "0"
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn12.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "IEPS."
        Me.DataGridTextBoxColumn12.MappingName = "ieps"
        Me.DataGridTextBoxColumn12.NullText = "0"
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn13.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Total."
        Me.DataGridTextBoxColumn13.MappingName = "total"
        Me.DataGridTextBoxColumn13.NullText = "0"
        Me.DataGridTextBoxColumn13.ReadOnly = True
        Me.DataGridTextBoxColumn13.Width = 90
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Status"
        Me.DataGridTextBoxColumn14.MappingName = "status"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.ReadOnly = True
        Me.DataGridTextBoxColumn14.Width = 50
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.MyDataGrid2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.MyDataGrid3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1008, 313)
        Me.SplitContainer2.SplitterDistance = 555
        Me.SplitContainer2.TabIndex = 1
        '
        'MyDataGrid2
        '
        Me.MyDataGrid2.CaptionText = "Artículos"
        Me.MyDataGrid2.DataMember = ""
        Me.MyDataGrid2.DataSource = Me.dvDetalle
        Me.MyDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGrid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyDataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MyDataGrid2.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGrid2.Name = "MyDataGrid2"
        Me.MyDataGrid2.Portapapeles = True
        Me.MyDataGrid2.ReadOnly = True
        Me.MyDataGrid2.Size = New System.Drawing.Size(555, 313)
        Me.MyDataGrid2.TabIndex = 1
        Me.MyDataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'dvDetalle
        '
        Me.dvDetalle.AllowNew = False
        Me.dvDetalle.Table = Me.DS_FV002.detalle
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.MyDataGrid2
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "detalle"
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Artículo"
        Me.DataGridTextBoxColumn7.MappingName = "cod_art"
        Me.DataGridTextBoxColumn7.Width = 65
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn15.MappingName = "descripcion"
        Me.DataGridTextBoxColumn15.Width = 200
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn16.Format = "N0"
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Cant."
        Me.DataGridTextBoxColumn16.MappingName = "cantidad"
        Me.DataGridTextBoxColumn16.Width = 80
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn17.Format = "#,###.00"
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Importe."
        Me.DataGridTextBoxColumn17.MappingName = "importe"
        Me.DataGridTextBoxColumn17.Width = 80
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn18.Format = "#,###.00"
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "IVA."
        Me.DataGridTextBoxColumn18.MappingName = "iva"
        Me.DataGridTextBoxColumn18.Width = 80
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn19.Format = "#,###.00"
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Total."
        Me.DataGridTextBoxColumn19.MappingName = "total"
        Me.DataGridTextBoxColumn19.Width = 80
        '
        'MyDataGrid3
        '
        Me.MyDataGrid3.CaptionText = "Total por artículo"
        Me.MyDataGrid3.DataMember = ""
        Me.MyDataGrid3.DataSource = Me.dvResumenArticulos
        Me.MyDataGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGrid3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyDataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MyDataGrid3.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGrid3.Name = "MyDataGrid3"
        Me.MyDataGrid3.Portapapeles = True
        Me.MyDataGrid3.ReadOnly = True
        Me.MyDataGrid3.Size = New System.Drawing.Size(449, 313)
        Me.MyDataGrid3.TabIndex = 0
        Me.MyDataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'dvResumenArticulos
        '
        Me.dvResumenArticulos.AllowNew = False
        Me.dvResumenArticulos.Table = Me.DS_FV002.resumen_articulos
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.MyDataGrid3
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "resumen_articulos"
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Artículo"
        Me.DataGridTextBoxColumn20.MappingName = "cod_art"
        Me.DataGridTextBoxColumn20.Width = 65
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn21.MappingName = "descripcion"
        Me.DataGridTextBoxColumn21.Width = 180
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn22.Format = "N0"
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Cant."
        Me.DataGridTextBoxColumn22.MappingName = "cantidad"
        Me.DataGridTextBoxColumn22.Width = 80
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn23.Format = "#,###.00"
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Total."
        Me.DataGridTextBoxColumn23.MappingName = "total"
        Me.DataGridTextBoxColumn23.Width = 80
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        status, abreviatura, descripcion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            status WITH (NOLO" &
    "CK)"
        Me.SqlSelectCommand1.CommandTimeout = 99999
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'sdaStatus
        '
        Me.sdaStatus.SelectCommand = Me.SqlSelectCommand1
        Me.sdaStatus.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "status", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("abreviatura", "abreviatura"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "dbo.FV002_Datos"
        Me.SqlSelectCommand2.CommandTimeout = 999999
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@FI", System.Data.SqlDbType.SmallDateTime, 4), New System.Data.SqlClient.SqlParameter("@FF", System.Data.SqlDbType.SmallDateTime, 4), New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 10), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3)})
        '
        'sdaDatos
        '
        Me.sdaDatos.SelectCommand = Me.SqlSelectCommand2
        Me.sdaDatos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cabecero", New System.Data.Common.DataColumnMapping(-1) {}), New System.Data.Common.DataTableMapping("Table1", "detalle", New System.Data.Common.DataColumnMapping(-1) {}), New System.Data.Common.DataTableMapping("Table2", "resumen_articulos", New System.Data.Common.DataColumnMapping(-1) {})})
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(62, 6)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(44, 40)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.Location = New System.Drawing.Point(12, 6)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(44, 40)
        Me.btnRefrescar.TabIndex = 5
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn24.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Tarjeta."
        Me.DataGridTextBoxColumn24.MappingName = "tarjeta"
        Me.DataGridTextBoxColumn24.Width = 90
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn25.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "Efectivo."
        Me.DataGridTextBoxColumn25.MappingName = "efectivo"
        Me.DataGridTextBoxColumn25.Width = 90
        '
        'FV002
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MT_reportes1)
        Me.Name = "FV002"
        Me.Text = "Reporte de ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DS_FV002, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvCabecero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.MyDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvResumenArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MT_reportes1 As WindowsControlLibrary1.MT_reportes
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFF As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFI As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents txtCodCte As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MyDataGrid1 As MyControls.MyDataGrid
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents sdaStatus As SqlClient.SqlDataAdapter
    Friend WithEvents dvCabecero As DataView
    Friend WithEvents dvDetalle As DataView
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaDatos As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FV002 As DS_FV002
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As DataGridTextBoxColumn
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents MyDataGrid2 As MyControls.MyDataGrid
    Friend WithEvents MyDataGrid3 As MyControls.MyDataGrid
    Friend WithEvents DataGridTableStyle2 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn7 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As DataGridTextBoxColumn
    Friend WithEvents dvResumenArticulos As DataView
    Friend WithEvents DataGridTableStyle3 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn20 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As DataGridTextBoxColumn
End Class
