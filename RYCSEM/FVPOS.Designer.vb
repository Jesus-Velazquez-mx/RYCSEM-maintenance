<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FVPOS
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVPOS))
        Me.spGen = New System.Windows.Forms.SplitContainer()
        Me.spSec = New System.Windows.Forms.SplitContainer()
        Me.gbArticulos = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.CodartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreimagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LiquidarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReimprimirTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dvArticulos = New System.Data.DataView()
        Me.DS_FVPOS = New RYCSEM.DS_FVPOS()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.GbInicio = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtNotas = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelarVta = New System.Windows.Forms.Button()
        Me.cmbCP = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GbInfo = New System.Windows.Forms.GroupBox()
        Me.btnConsultaInventario = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numArticulos = New System.Windows.Forms.NumericUpDown()
        Me.TxtCant = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodCte = New System.Windows.Forms.TextBox()
        Me.GbResumen = New System.Windows.Forms.GroupBox()
        Me.BtnAbonos = New System.Windows.Forms.Button()
        Me.btnMovsCaja = New System.Windows.Forms.Button()
        Me.btnCorteCaja = New System.Windows.Forms.Button()
        Me.btnLiquidar = New System.Windows.Forms.Button()
        Me.numImporte = New System.Windows.Forms.NumericUpDown()
        Me.numDescuento = New System.Windows.Forms.NumericUpDown()
        Me.numDescPorc = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numTotal = New System.Windows.Forms.NumericUpDown()
        Me.btnAD = New System.Windows.Forms.Button()
        Me.numIva = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.sdaCliente = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaArticulo = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlGuardaNotaDetalle = New System.Data.SqlClient.SqlCommand()
        Me.sqlGuardaNotaVenta = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.sdaTraerVenta = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.sdaTraerVentaDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SdaCondicionesPago = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SqlGuardarHistorico = New System.Data.SqlClient.SqlCommand()
        Me.CmdAyDInventario = New System.Data.SqlClient.SqlCommand()
        Me.cmdFormasPago = New System.Data.SqlClient.SqlCommand()
        Me.SqlCancelarVenta = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.sdaDocFormasPago = New System.Data.SqlClient.SqlDataAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.spGen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spGen.Panel1.SuspendLayout()
        Me.spGen.Panel2.SuspendLayout()
        Me.spGen.SuspendLayout()
        CType(Me.spSec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spSec.Panel1.SuspendLayout()
        Me.spSec.SuspendLayout()
        Me.gbArticulos.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FVPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbInicio.SuspendLayout()
        Me.GbInfo.SuspendLayout()
        CType(Me.numArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbResumen.SuspendLayout()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDescPorc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spGen
        '
        Me.spGen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spGen.Location = New System.Drawing.Point(0, 0)
        Me.spGen.Name = "spGen"
        Me.spGen.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spGen.Panel1
        '
        Me.spGen.Panel1.Controls.Add(Me.spSec)
        '
        'spGen.Panel2
        '
        Me.spGen.Panel2.Controls.Add(Me.GbResumen)
        Me.spGen.Panel2.Controls.Add(Me.GroupBox1)
        Me.spGen.Size = New System.Drawing.Size(1035, 712)
        Me.spGen.SplitterDistance = 526
        Me.spGen.TabIndex = 0
        '
        'spSec
        '
        Me.spSec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spSec.Location = New System.Drawing.Point(0, 0)
        Me.spSec.Name = "spSec"
        Me.spSec.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spSec.Panel1
        '
        Me.spSec.Panel1.Controls.Add(Me.gbArticulos)
        Me.spSec.Panel1.Controls.Add(Me.GbInicio)
        Me.spSec.Panel2Collapsed = True
        Me.spSec.Size = New System.Drawing.Size(1035, 526)
        Me.spSec.SplitterDistance = 495
        Me.spSec.TabIndex = 0
        '
        'gbArticulos
        '
        Me.gbArticulos.Controls.Add(Me.SplitContainer1)
        Me.gbArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbArticulos.Location = New System.Drawing.Point(0, 316)
        Me.gbArticulos.Name = "gbArticulos"
        Me.gbArticulos.Size = New System.Drawing.Size(1035, 210)
        Me.gbArticulos.TabIndex = 475
        Me.gbArticulos.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgArticulos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pbImagen)
        Me.SplitContainer1.Size = New System.Drawing.Size(1029, 191)
        Me.SplitContainer1.SplitterDistance = 660
        Me.SplitContainer1.TabIndex = 44
        '
        'dgArticulos
        '
        Me.dgArticulos.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodartDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.cantidad, Me.ImagenDataGridViewImageColumn, Me.costo, Me.NombreimagenDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dgArticulos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgArticulos.DataSource = Me.dvArticulos
        Me.dgArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgArticulos.Location = New System.Drawing.Point(0, 25)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.Size = New System.Drawing.Size(660, 166)
        Me.dgArticulos.TabIndex = 0
        '
        'CodartDataGridViewTextBoxColumn
        '
        Me.CodartDataGridViewTextBoxColumn.DataPropertyName = "cod_art"
        Me.CodartDataGridViewTextBoxColumn.HeaderText = "Artículo"
        Me.CodartDataGridViewTextBoxColumn.Name = "CodartDataGridViewTextBoxColumn"
        Me.CodartDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodartDataGridViewTextBoxColumn.Width = 70
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 180
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "#,###,##0.00"
        DataGridViewCellStyle8.NullValue = "0"
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio."
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 70
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N0"
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle9
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'ImagenDataGridViewImageColumn
        '
        Me.ImagenDataGridViewImageColumn.DataPropertyName = "imagen"
        Me.ImagenDataGridViewImageColumn.HeaderText = "imagen"
        Me.ImagenDataGridViewImageColumn.Name = "ImagenDataGridViewImageColumn"
        Me.ImagenDataGridViewImageColumn.Visible = False
        '
        'costo
        '
        Me.costo.DataPropertyName = "iva"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "#,###,##0.00"
        DataGridViewCellStyle10.NullValue = "0"
        Me.costo.DefaultCellStyle = DataGridViewCellStyle10
        Me.costo.HeaderText = "Iva"
        Me.costo.Name = "costo"
        '
        'NombreimagenDataGridViewTextBoxColumn
        '
        Me.NombreimagenDataGridViewTextBoxColumn.DataPropertyName = "nombre_imagen"
        Me.NombreimagenDataGridViewTextBoxColumn.HeaderText = "nombre_imagen"
        Me.NombreimagenDataGridViewTextBoxColumn.Name = "NombreimagenDataGridViewTextBoxColumn"
        Me.NombreimagenDataGridViewTextBoxColumn.Visible = False
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "importe"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "#,###,##0.00"
        DataGridViewCellStyle11.NullValue = "0"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe."
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 70
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "#,###,##0.00"
        DataGridViewCellStyle12.NullValue = "0"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total."
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 70
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidarToolStripMenuItem, Me.ReimprimirTicketToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(187, 70)
        '
        'LiquidarToolStripMenuItem
        '
        Me.LiquidarToolStripMenuItem.Name = "LiquidarToolStripMenuItem"
        Me.LiquidarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.LiquidarToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.LiquidarToolStripMenuItem.Text = "Liquidar"
        '
        'ReimprimirTicketToolStripMenuItem
        '
        Me.ReimprimirTicketToolStripMenuItem.Name = "ReimprimirTicketToolStripMenuItem"
        Me.ReimprimirTicketToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ReimprimirTicketToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ReimprimirTicketToolStripMenuItem.Text = "Reimprimir Ticket"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'dvArticulos
        '
        Me.dvArticulos.AllowNew = False
        Me.dvArticulos.Table = Me.DS_FVPOS.detalle
        '
        'DS_FVPOS
        '
        Me.DS_FVPOS.DataSetName = "DS_FVPOS"
        Me.DS_FVPOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(660, 25)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Artículos"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.White
        Me.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImagen.Location = New System.Drawing.Point(0, 0)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(365, 191)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbImagen.TabIndex = 0
        Me.pbImagen.TabStop = False
        '
        'GbInicio
        '
        Me.GbInicio.Controls.Add(Me.Label14)
        Me.GbInicio.Controls.Add(Me.TxtNotas)
        Me.GbInicio.Controls.Add(Me.btnImprimir)
        Me.GbInicio.Controls.Add(Me.btnDeshacer)
        Me.GbInicio.Controls.Add(Me.btnNuevo)
        Me.GbInicio.Controls.Add(Me.btnCancelarVta)
        Me.GbInicio.Controls.Add(Me.cmbCP)
        Me.GbInicio.Controls.Add(Me.Label12)
        Me.GbInicio.Controls.Add(Me.PictureBox2)
        Me.GbInicio.Controls.Add(Me.GbInfo)
        Me.GbInicio.Controls.Add(Me.dtpFecha)
        Me.GbInicio.Controls.Add(Me.Label10)
        Me.GbInicio.Controls.Add(Me.Label9)
        Me.GbInicio.Controls.Add(Me.txtFolio)
        Me.GbInicio.Controls.Add(Me.txtNombre)
        Me.GbInicio.Controls.Add(Me.Label7)
        Me.GbInicio.Controls.Add(Me.txtCodCte)
        Me.GbInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbInicio.Location = New System.Drawing.Point(0, 0)
        Me.GbInicio.Name = "GbInicio"
        Me.GbInicio.Size = New System.Drawing.Size(1035, 316)
        Me.GbInicio.TabIndex = 0
        Me.GbInicio.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(67, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 25)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "NOTAS"
        '
        'TxtNotas
        '
        Me.TxtNotas.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TxtNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNotas.Location = New System.Drawing.Point(161, 132)
        Me.TxtNotas.Multiline = True
        Me.TxtNotas.Name = "TxtNotas"
        Me.TxtNotas.Size = New System.Drawing.Size(440, 75)
        Me.TxtNotas.TabIndex = 23
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(367, 13)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(44, 40)
        Me.btnImprimir.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Reimprimir ticket")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnDeshacer
        '
        Me.btnDeshacer.Image = CType(resources.GetObject("btnDeshacer.Image"), System.Drawing.Image)
        Me.btnDeshacer.Location = New System.Drawing.Point(322, 13)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(44, 40)
        Me.btnDeshacer.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btnDeshacer, "Deshacer venta actual")
        Me.btnDeshacer.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(277, 13)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(44, 40)
        Me.btnNuevo.TabIndex = 20
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nueva venta")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancelarVta
        '
        Me.btnCancelarVta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarVta.Image = CType(resources.GetObject("btnCancelarVta.Image"), System.Drawing.Image)
        Me.btnCancelarVta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelarVta.Location = New System.Drawing.Point(417, 13)
        Me.btnCancelarVta.Name = "btnCancelarVta"
        Me.btnCancelarVta.Size = New System.Drawing.Size(44, 40)
        Me.btnCancelarVta.TabIndex = 17
        Me.btnCancelarVta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCancelarVta, "Cancelar venta")
        Me.btnCancelarVta.UseVisualStyleBackColor = True
        '
        'cmbCP
        '
        Me.cmbCP.DataSource = Me.DS_FVPOS
        Me.cmbCP.DisplayMember = "condiciones_pago.nombre"
        Me.cmbCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCP.FormattingEnabled = True
        Me.cmbCP.Location = New System.Drawing.Point(161, 55)
        Me.cmbCP.Name = "cmbCP"
        Me.cmbCP.Size = New System.Drawing.Size(170, 33)
        Me.cmbCP.TabIndex = 20
        Me.cmbCP.ValueMember = "condiciones_pago.condicion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 25)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "COND. PAGO"
        '
        'GbInfo
        '
        Me.GbInfo.Controls.Add(Me.btnConsultaInventario)
        Me.GbInfo.Controls.Add(Me.Label11)
        Me.GbInfo.Controls.Add(Me.Label6)
        Me.GbInfo.Controls.Add(Me.txtArticulo)
        Me.GbInfo.Controls.Add(Me.btnEliminar)
        Me.GbInfo.Controls.Add(Me.Label1)
        Me.GbInfo.Controls.Add(Me.numArticulos)
        Me.GbInfo.Controls.Add(Me.TxtCant)
        Me.GbInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbInfo.Location = New System.Drawing.Point(3, 213)
        Me.GbInfo.Name = "GbInfo"
        Me.GbInfo.Size = New System.Drawing.Size(1029, 100)
        Me.GbInfo.TabIndex = 17
        Me.GbInfo.TabStop = False
        '
        'btnConsultaInventario
        '
        Me.btnConsultaInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultaInventario.Image = CType(resources.GetObject("btnConsultaInventario.Image"), System.Drawing.Image)
        Me.btnConsultaInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultaInventario.Location = New System.Drawing.Point(387, 49)
        Me.btnConsultaInventario.Name = "btnConsultaInventario"
        Me.btnConsultaInventario.Size = New System.Drawing.Size(128, 38)
        Me.btnConsultaInventario.TabIndex = 486
        Me.btnConsultaInventario.Text = "F8 Consulta de Inventario"
        Me.btnConsultaInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultaInventario.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 29)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "CANT."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ARTICULO"
        '
        'txtArticulo
        '
        Me.txtArticulo.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.Location = New System.Drawing.Point(118, 49)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(213, 38)
        Me.txtArticulo.TabIndex = 1
        '
        'btnEliminar
        '
        Me.btnEliminar.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnEliminar.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(337, 49)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(44, 38)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(760, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# ARTICULOS:"
        '
        'numArticulos
        '
        Me.numArticulos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.numArticulos.Enabled = False
        Me.numArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numArticulos.Location = New System.Drawing.Point(927, 52)
        Me.numArticulos.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.numArticulos.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.numArticulos.Name = "numArticulos"
        Me.numArticulos.ReadOnly = True
        Me.numArticulos.Size = New System.Drawing.Size(72, 32)
        Me.numArticulos.TabIndex = 0
        Me.numArticulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numArticulos.ThousandsSeparator = True
        '
        'TxtCant
        '
        Me.TxtCant.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TxtCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCant.Location = New System.Drawing.Point(45, 49)
        Me.TxtCant.Name = "TxtCant"
        Me.TxtCant.Size = New System.Drawing.Size(67, 38)
        Me.TxtCant.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(431, 56)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(170, 32)
        Me.dtpFecha.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(340, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "FECHA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(78, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "FOLIO"
        '
        'txtFolio
        '
        Me.txtFolio.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(161, 18)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(110, 30)
        Me.txtFolio.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DS_FVPOS, "clientes.nombre", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(251, 95)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(350, 30)
        Me.txtNombre.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "CLIENTE"
        '
        'txtCodCte
        '
        Me.txtCodCte.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtCodCte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCte.Location = New System.Drawing.Point(161, 95)
        Me.txtCodCte.Name = "txtCodCte"
        Me.txtCodCte.Size = New System.Drawing.Size(84, 30)
        Me.txtCodCte.TabIndex = 7
        '
        'GbResumen
        '
        Me.GbResumen.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GbResumen.Controls.Add(Me.BtnAbonos)
        Me.GbResumen.Controls.Add(Me.btnMovsCaja)
        Me.GbResumen.Controls.Add(Me.btnCorteCaja)
        Me.GbResumen.Controls.Add(Me.btnLiquidar)
        Me.GbResumen.Controls.Add(Me.numImporte)
        Me.GbResumen.Controls.Add(Me.numDescuento)
        Me.GbResumen.Controls.Add(Me.numDescPorc)
        Me.GbResumen.Controls.Add(Me.Label2)
        Me.GbResumen.Controls.Add(Me.numTotal)
        Me.GbResumen.Controls.Add(Me.btnAD)
        Me.GbResumen.Controls.Add(Me.numIva)
        Me.GbResumen.Controls.Add(Me.Label8)
        Me.GbResumen.Controls.Add(Me.Label3)
        Me.GbResumen.Controls.Add(Me.Label4)
        Me.GbResumen.Controls.Add(Me.Label5)
        Me.GbResumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbResumen.Location = New System.Drawing.Point(0, -11)
        Me.GbResumen.Name = "GbResumen"
        Me.GbResumen.Size = New System.Drawing.Size(1035, 154)
        Me.GbResumen.TabIndex = 0
        Me.GbResumen.TabStop = False
        '
        'BtnAbonos
        '
        Me.BtnAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbonos.Image = CType(resources.GetObject("BtnAbonos.Image"), System.Drawing.Image)
        Me.BtnAbonos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAbonos.Location = New System.Drawing.Point(208, 60)
        Me.BtnAbonos.Name = "BtnAbonos"
        Me.BtnAbonos.Size = New System.Drawing.Size(84, 70)
        Me.BtnAbonos.TabIndex = 20
        Me.BtnAbonos.Text = "F5 ABONOS CLIENTE"
        Me.BtnAbonos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAbonos.UseVisualStyleBackColor = True
        '
        'btnMovsCaja
        '
        Me.btnMovsCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovsCaja.Image = CType(resources.GetObject("btnMovsCaja.Image"), System.Drawing.Image)
        Me.btnMovsCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMovsCaja.Location = New System.Drawing.Point(13, 60)
        Me.btnMovsCaja.Name = "btnMovsCaja"
        Me.btnMovsCaja.Size = New System.Drawing.Size(84, 70)
        Me.btnMovsCaja.TabIndex = 19
        Me.btnMovsCaja.Text = "F6 MOVS CAJA"
        Me.btnMovsCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMovsCaja.UseVisualStyleBackColor = True
        '
        'btnCorteCaja
        '
        Me.btnCorteCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorteCaja.Image = CType(resources.GetObject("btnCorteCaja.Image"), System.Drawing.Image)
        Me.btnCorteCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCorteCaja.Location = New System.Drawing.Point(110, 60)
        Me.btnCorteCaja.Name = "btnCorteCaja"
        Me.btnCorteCaja.Size = New System.Drawing.Size(84, 70)
        Me.btnCorteCaja.TabIndex = 18
        Me.btnCorteCaja.Text = "F7 CORTE CAJA"
        Me.btnCorteCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCorteCaja.UseVisualStyleBackColor = True
        '
        'btnLiquidar
        '
        Me.btnLiquidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiquidar.Image = CType(resources.GetObject("btnLiquidar.Image"), System.Drawing.Image)
        Me.btnLiquidar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLiquidar.Location = New System.Drawing.Point(900, 28)
        Me.btnLiquidar.Name = "btnLiquidar"
        Me.btnLiquidar.Size = New System.Drawing.Size(124, 89)
        Me.btnLiquidar.TabIndex = 16
        Me.btnLiquidar.Text = "F4 PAGAR/GUARDAR"
        Me.btnLiquidar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLiquidar.UseVisualStyleBackColor = True
        '
        'numImporte
        '
        Me.numImporte.ContextMenuStrip = Me.ContextMenuStrip1
        Me.numImporte.DecimalPlaces = 2
        Me.numImporte.Enabled = False
        Me.numImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numImporte.Location = New System.Drawing.Point(732, 16)
        Me.numImporte.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.numImporte.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.numImporte.Name = "numImporte"
        Me.numImporte.ReadOnly = True
        Me.numImporte.Size = New System.Drawing.Size(158, 32)
        Me.numImporte.TabIndex = 1
        Me.numImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numImporte.ThousandsSeparator = True
        '
        'numDescuento
        '
        Me.numDescuento.ContextMenuStrip = Me.ContextMenuStrip1
        Me.numDescuento.DecimalPlaces = 2
        Me.numDescuento.Enabled = False
        Me.numDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDescuento.Location = New System.Drawing.Point(732, 16)
        Me.numDescuento.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.numDescuento.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.numDescuento.Name = "numDescuento"
        Me.numDescuento.ReadOnly = True
        Me.numDescuento.Size = New System.Drawing.Size(158, 32)
        Me.numDescuento.TabIndex = 2
        Me.numDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDescuento.ThousandsSeparator = True
        Me.numDescuento.Visible = False
        '
        'numDescPorc
        '
        Me.numDescPorc.ContextMenuStrip = Me.ContextMenuStrip1
        Me.numDescPorc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDescPorc.Location = New System.Drawing.Point(402, 97)
        Me.numDescPorc.Name = "numDescPorc"
        Me.numDescPorc.Size = New System.Drawing.Size(84, 30)
        Me.numDescPorc.TabIndex = 13
        Me.numDescPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(592, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SUB-TOT: $"
        '
        'numTotal
        '
        Me.numTotal.ContextMenuStrip = Me.ContextMenuStrip1
        Me.numTotal.DecimalPlaces = 2
        Me.numTotal.Enabled = False
        Me.numTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.numTotal.Location = New System.Drawing.Point(732, 92)
        Me.numTotal.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.numTotal.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.numTotal.Name = "numTotal"
        Me.numTotal.ReadOnly = True
        Me.numTotal.Size = New System.Drawing.Size(158, 38)
        Me.numTotal.TabIndex = 4
        Me.numTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotal.ThousandsSeparator = True
        '
        'btnAD
        '
        Me.btnAD.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAD.Location = New System.Drawing.Point(492, 97)
        Me.btnAD.Name = "btnAD"
        Me.btnAD.Size = New System.Drawing.Size(89, 30)
        Me.btnAD.TabIndex = 14
        Me.btnAD.Text = "AD"
        Me.btnAD.UseVisualStyleBackColor = True
        '
        'numIva
        '
        Me.numIva.ContextMenuStrip = Me.ContextMenuStrip1
        Me.numIva.DecimalPlaces = 2
        Me.numIva.Enabled = False
        Me.numIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numIva.Location = New System.Drawing.Point(732, 54)
        Me.numIva.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.numIva.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.numIva.Name = "numIva"
        Me.numIva.ReadOnly = True
        Me.numIva.Size = New System.Drawing.Size(158, 32)
        Me.numIva.TabIndex = 3
        Me.numIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numIva.ThousandsSeparator = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(299, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "% DESC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(629, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DESC: $"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(653, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IVA: $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(586, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TOTAL: $"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 39)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(943, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 25)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Label13"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        cod_cte, dbo.nombreCompleto(cod_cte, 'C') AS nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          " &
    "  clientes WITH (NOLOCK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (cod_cte = @cod_cte) AND (status = 'V')"
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 10, "cod_cte")})
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=SA" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'sdaCliente
        '
        Me.sdaCliente.SelectCommand = Me.SqlSelectCommand1
        Me.sdaCliente.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        cod_art, descripcion, precio, imagen, nombre_imagen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          " &
    "  articulos WITH (NOLOCK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (cod_art = @cod_art) AND (status = 'V')"
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 10, "cod_art")})
        '
        'sdaArticulo
        '
        Me.sdaArticulo.SelectCommand = Me.SqlSelectCommand2
        Me.sdaArticulo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "articulos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_art", "cod_art"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("precio", "precio")})})
        '
        'sqlGuardaNotaDetalle
        '
        Me.sqlGuardaNotaDetalle.CommandText = resources.GetString("sqlGuardaNotaDetalle.CommandText")
        Me.sqlGuardaNotaDetalle.Connection = Me.sqlConn
        Me.sqlGuardaNotaDetalle.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 10, "cod_art"), New System.Data.SqlClient.SqlParameter("@unidad", System.Data.SqlDbType.[Char], 5, "unidad"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 8, "importe"), New System.Data.SqlClient.SqlParameter("@iva", System.Data.SqlDbType.Money, 8, "iva"), New System.Data.SqlClient.SqlParameter("@ieps", System.Data.SqlDbType.Money, 8, "ieps"), New System.Data.SqlClient.SqlParameter("@porc_descuento", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_descuento", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@importe_descuento", System.Data.SqlDbType.Money, 8, "importe_descuento"), New System.Data.SqlClient.SqlParameter("@total", System.Data.SqlDbType.Money, 8, "total")})
        '
        'sqlGuardaNotaVenta
        '
        Me.sqlGuardaNotaVenta.CommandText = resources.GetString("sqlGuardaNotaVenta.CommandText")
        Me.sqlGuardaNotaVenta.Connection = Me.sqlConn
        Me.sqlGuardaNotaVenta.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 4, "fecha"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 10, "cod_cte"), New System.Data.SqlClient.SqlParameter("@domicilio_entrega", System.Data.SqlDbType.VarChar, 500, "domicilio_entrega"), New System.Data.SqlClient.SqlParameter("@cond_pago", System.Data.SqlDbType.[Char], 5, "cond_pago"), New System.Data.SqlClient.SqlParameter("@plazo", System.Data.SqlDbType.Int, 4, "plazo"), New System.Data.SqlClient.SqlParameter("@porc_descuento", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_descuento", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@importe_descuento", System.Data.SqlDbType.Money, 8, "importe_descuento"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 8, "importe"), New System.Data.SqlClient.SqlParameter("@iva", System.Data.SqlDbType.Money, 8, "iva"), New System.Data.SqlClient.SqlParameter("@ieps", System.Data.SqlDbType.Money, 8, "ieps"), New System.Data.SqlClient.SqlParameter("@saldo", System.Data.SqlDbType.Money, 8, "saldo"), New System.Data.SqlClient.SqlParameter("@abonos", System.Data.SqlDbType.Money, 8, "abonos"), New System.Data.SqlClient.SqlParameter("@forma_pago", System.Data.SqlDbType.[Char], 5, "forma_pago"), New System.Data.SqlClient.SqlParameter("@venta_publico", System.Data.SqlDbType.Bit, 1, "venta_publico"), New System.Data.SqlClient.SqlParameter("@razon_social", System.Data.SqlDbType.VarChar, 250, "razon_social"), New System.Data.SqlClient.SqlParameter("@total", System.Data.SqlDbType.Money, 8, "total"), New System.Data.SqlClient.SqlParameter("@domicilio_cliente", System.Data.SqlDbType.Bit, 1, "domicilio_cliente"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3, "status"), New System.Data.SqlClient.SqlParameter("@entregado", System.Data.SqlDbType.Bit, 1, "entregado"), New System.Data.SqlClient.SqlParameter("@enganche", System.Data.SqlDbType.Money, 8, "enganche"), New System.Data.SqlClient.SqlParameter("@porc_enganche", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_enganche", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@notas", System.Data.SqlDbType.VarChar, 500, "notas")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.sqlConn
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion")})
        '
        'sdaTraerVenta
        '
        Me.sdaTraerVenta.SelectCommand = Me.SqlSelectCommand3
        Me.sdaTraerVenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "notas_venta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("domicilio_entrega", "domicilio_entrega"), New System.Data.Common.DataColumnMapping("cond_pago", "cond_pago"), New System.Data.Common.DataColumnMapping("plazo", "plazo"), New System.Data.Common.DataColumnMapping("porc_descuento", "porc_descuento"), New System.Data.Common.DataColumnMapping("importe_descuento", "importe_descuento"), New System.Data.Common.DataColumnMapping("importe", "importe"), New System.Data.Common.DataColumnMapping("iva", "iva"), New System.Data.Common.DataColumnMapping("ieps", "ieps"), New System.Data.Common.DataColumnMapping("saldo", "saldo"), New System.Data.Common.DataColumnMapping("abonos", "abonos"), New System.Data.Common.DataColumnMapping("forma_pago", "forma_pago"), New System.Data.Common.DataColumnMapping("venta_publico", "venta_publico"), New System.Data.Common.DataColumnMapping("razon_social", "razon_social"), New System.Data.Common.DataColumnMapping("total", "total"), New System.Data.Common.DataColumnMapping("domicilio_cliente", "domicilio_cliente"), New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("entregado", "entregado"), New System.Data.Common.DataColumnMapping("enganche", "enganche"), New System.Data.Common.DataColumnMapping("porc_enganche", "porc_enganche"), New System.Data.Common.DataColumnMapping("notas", "notas")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.sqlConn
        Me.SqlSelectCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion")})
        '
        'sdaTraerVentaDetalle
        '
        Me.sdaTraerVentaDetalle.SelectCommand = Me.SqlSelectCommand4
        Me.sdaTraerVentaDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "notas_venta_detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("cod_art", "cod_art"), New System.Data.Common.DataColumnMapping("unidad", "unidad"), New System.Data.Common.DataColumnMapping("importe", "importe"), New System.Data.Common.DataColumnMapping("iva", "iva"), New System.Data.Common.DataColumnMapping("ieps", "ieps"), New System.Data.Common.DataColumnMapping("porc_descuento", "porc_descuento"), New System.Data.Common.DataColumnMapping("importe_descuento", "importe_descuento"), New System.Data.Common.DataColumnMapping("total", "total")})})
        '
        'SdaCondicionesPago
        '
        Me.SdaCondicionesPago.SelectCommand = Me.SqlSelectCommand6
        Me.SdaCondicionesPago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "condiciones_pago", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("condicion", "condicion"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("status", "status")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT        condicion, UPPER(nombre) AS nombre, status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            condici" &
    "ones_pago WITH (NOLOCK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (status = 'V')"
        Me.SqlSelectCommand6.CommandTimeout = 999
        Me.SqlSelectCommand6.Connection = Me.sqlConn
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SqlGuardarHistorico
        '
        Me.SqlGuardarHistorico.CommandText = "INSERT INTO historico_ventas_turno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         (turnoid, fecha, fol" &
    "io, total)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES        (@turnoid,@fecha,@folio,@total)"
        Me.SqlGuardarHistorico.Connection = Me.sqlConn
        Me.SqlGuardarHistorico.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@turnoid", System.Data.SqlDbType.Int, 4, "turnoid"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 4, "fecha"), New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@total", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(4, Byte), "total", System.Data.DataRowVersion.Current, Nothing)})
        '
        'CmdAyDInventario
        '
        Me.CmdAyDInventario.CommandText = "AyDInventario"
        Me.CmdAyDInventario.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdAyDInventario.Connection = Me.sqlConn
        Me.CmdAyDInventario.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Trans", System.Data.SqlDbType.[Char], 5), New System.Data.SqlClient.SqlParameter("@CodArt", System.Data.SqlDbType.[Char], 10), New System.Data.SqlClient.SqlParameter("@Cant", System.Data.SqlDbType.Int, 4), New System.Data.SqlClient.SqlParameter("@msg", System.Data.SqlDbType.NVarChar, 2147483647, System.Data.ParameterDirection.InputOutput, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing)})
        '
        'cmdFormasPago
        '
        Me.cmdFormasPago.CommandText = "INSERT INTO documentos_formas_pago" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         (folio, transaccion," &
    " forma_pago, monto)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES        (@folio,@transaccion,@forma_pago,@monto)"
        Me.cmdFormasPago.Connection = Me.sqlConn
        Me.cmdFormasPago.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion"), New System.Data.SqlClient.SqlParameter("@forma_pago", System.Data.SqlDbType.[Char], 10, "forma_pago"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(4, Byte), "monto", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlCancelarVenta
        '
        Me.SqlCancelarVenta.CommandText = "UPDATE       notas_venta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                status = 'C'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (folio = " &
    "@Folio)"
        Me.SqlCancelarVenta.Connection = Me.sqlConn
        Me.SqlCancelarVenta.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
        Me.SqlSelectCommand5.Connection = Me.sqlConn
        Me.SqlSelectCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@Transaccion", System.Data.SqlDbType.[Char], 10, "transaccion")})
        '
        'sdaDocFormasPago
        '
        Me.sdaDocFormasPago.SelectCommand = Me.SqlSelectCommand5
        Me.sdaDocFormasPago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "documentos_formas_pago", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("forma_pago", "forma_pago"), New System.Data.Common.DataColumnMapping("monto", "monto")})})
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Location = New System.Drawing.Point(786, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(246, 197)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'FVPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 712)
        Me.Controls.Add(Me.spGen)
        Me.Name = "FVPOS"
        Me.Text = "POS"
        Me.spGen.Panel1.ResumeLayout(False)
        Me.spGen.Panel2.ResumeLayout(False)
        CType(Me.spGen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spGen.ResumeLayout(False)
        Me.spSec.Panel1.ResumeLayout(False)
        CType(Me.spSec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spSec.ResumeLayout(False)
        Me.gbArticulos.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FVPOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbInicio.ResumeLayout(False)
        Me.GbInicio.PerformLayout()
        Me.GbInfo.ResumeLayout(False)
        Me.GbInfo.PerformLayout()
        CType(Me.numArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbResumen.ResumeLayout(False)
        Me.GbResumen.PerformLayout()
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDescPorc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spGen As SplitContainer
    Friend WithEvents gbArticulos As GroupBox
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GbResumen As GroupBox
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents sdaCliente As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaArticulo As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FVPOS As DS_FVPOS
    Friend WithEvents dvArticulos As DataView
    Friend WithEvents numDescuento As NumericUpDown
    Friend WithEvents numTotal As NumericUpDown
    Friend WithEvents numIva As NumericUpDown
    Friend WithEvents numImporte As NumericUpDown
    Friend WithEvents numArticulos As NumericUpDown
    Friend WithEvents sqlGuardaNotaDetalle As SqlClient.SqlCommand
    Friend WithEvents sqlGuardaNotaVenta As SqlClient.SqlCommand
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LiquidarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents sdaTraerVenta As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents sdaTraerVentaDetalle As SqlClient.SqlDataAdapter
    Friend WithEvents ReimprimirTicketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents numDescPorc As NumericUpDown
    Friend WithEvents btnAD As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GbInicio As GroupBox
    Friend WithEvents GbInfo As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtArticulo As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodCte As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pbImagen As PictureBox
    Private WithEvents spSec As SplitContainer
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCant As TextBox
    Friend WithEvents btnCancelarVta As Button
    Friend WithEvents btnLiquidar As Button
    Friend WithEvents btnMovsCaja As Button
    Friend WithEvents btnCorteCaja As Button
    Friend WithEvents btnConsultaInventario As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cmbCP As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents SdaCondicionesPago As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As SqlClient.SqlCommand
    Friend WithEvents btnDeshacer As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label13 As Label
    Friend WithEvents SqlGuardarHistorico As SqlClient.SqlCommand
    Friend WithEvents btnImprimir As Button
    Friend WithEvents CmdAyDInventario As SqlClient.SqlCommand
    Friend WithEvents cmdFormasPago As SqlClient.SqlCommand
    Friend WithEvents SqlCancelarVenta As SqlClient.SqlCommand
    Friend WithEvents BtnAbonos As Button
    Friend WithEvents CodartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents ImagenDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
    Friend WithEvents NombreimagenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtNotas As TextBox
    Friend WithEvents SqlSelectCommand5 As SqlClient.SqlCommand
    Friend WithEvents sdaDocFormasPago As SqlClient.SqlDataAdapter
    Friend WithEvents PictureBox2 As PictureBox
End Class
