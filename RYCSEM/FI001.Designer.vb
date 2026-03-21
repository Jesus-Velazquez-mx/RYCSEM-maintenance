<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FI001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FI001))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.dvArticulos = New System.Data.DataView()
        Me.DS_FI001 = New RYCSEM.DS_FI001()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numCosto = New System.Windows.Forms.NumericUpDown()
        Me.txtCodArt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GbModifInventario = New System.Windows.Forms.GroupBox()
        Me.BtnDismunuir = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnAumentar = New System.Windows.Forms.Button()
        Me.NumCantArt = New System.Windows.Forms.NumericUpDown()
        Me.BtnModifInv = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumInventario = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbLinea = New System.Windows.Forms.ComboBox()
        Me.imgArticulo = New System.Windows.Forms.PictureBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sdaArticulos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaStatus = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.sdaFolio = New System.Data.SqlClient.SqlDataAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SdaModelos = New System.Data.SqlClient.SqlDataAdapter()
        Me.gbArticulos = New System.Windows.Forms.GroupBox()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.CmdAyDInventario = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SdaTipos = New System.Data.SqlClient.SqlDataAdapter()
        Me.CodartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreimagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcgananciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FI001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GbModifInventario.SuspendLayout()
        CType(Me.NumCantArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbArticulos.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(476, 68)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(41, 26)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtImagen
        '
        Me.txtImagen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvArticulos, "nombre_imagen", True))
        Me.txtImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagen.Location = New System.Drawing.Point(95, 71)
        Me.txtImagen.MaxLength = 999999999
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(375, 20)
        Me.txtImagen.TabIndex = 468
        '
        'dvArticulos
        '
        Me.dvArticulos.AllowNew = False
        Me.dvArticulos.Sort = "nombre_modelo"
        Me.dvArticulos.Table = Me.DS_FI001.articulos
        '
        'DS_FI001
        '
        Me.DS_FI001.DataSetName = "DS_FI001"
        Me.DS_FI001.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 467
        Me.Label5.Text = "Imagen"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvArticulos, "observaciones", True))
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(95, 123)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(278, 134)
        Me.txtObservaciones.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 466
        Me.Label4.Text = "Características"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 464
        Me.Label3.Text = "Precio"
        '
        'numPrecio
        '
        Me.numPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dvArticulos, "precio", True))
        Me.numPrecio.DecimalPlaces = 2
        Me.numPrecio.Enabled = False
        Me.numPrecio.Location = New System.Drawing.Point(240, 45)
        Me.numPrecio.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numPrecio.Name = "numPrecio"
        Me.numPrecio.Size = New System.Drawing.Size(88, 20)
        Me.numPrecio.TabIndex = 4
        Me.numPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPrecio.ThousandsSeparator = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 462
        Me.Label2.Text = "Costo"
        '
        'numCosto
        '
        Me.numCosto.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dvArticulos, "costo", True))
        Me.numCosto.DecimalPlaces = 2
        Me.numCosto.Location = New System.Drawing.Point(95, 45)
        Me.numCosto.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numCosto.Name = "numCosto"
        Me.numCosto.Size = New System.Drawing.Size(88, 20)
        Me.numCosto.TabIndex = 3
        Me.numCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCosto.ThousandsSeparator = True
        '
        'txtCodArt
        '
        Me.txtCodArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodArt.Location = New System.Drawing.Point(95, 19)
        Me.txtCodArt.Name = "txtCodArt"
        Me.txtCodArt.Size = New System.Drawing.Size(82, 20)
        Me.txtCodArt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 459
        Me.Label1.Text = "Artículo"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvArticulos, "descripcion", True))
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(183, 19)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(334, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(338, 48)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(41, 15)
        Me.Label58.TabIndex = 460
        Me.Label58.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvArticulos, "status", True))
        Me.cbStatus.DataSource = Me.DS_FI001
        Me.cbStatus.DisplayMember = "status.descripcion"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.ItemHeight = 13
        Me.cbStatus.Location = New System.Drawing.Point(385, 45)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(132, 21)
        Me.cbStatus.TabIndex = 5
        Me.cbStatus.ValueMember = "status.status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GbModifInventario)
        Me.GroupBox1.Controls.Add(Me.BtnModifInv)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.NumInventario)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbLinea)
        Me.GroupBox1.Controls.Add(Me.txtCodArt)
        Me.GroupBox1.Controls.Add(Me.cbStatus)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Controls.Add(Me.txtImagen)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.numCosto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.numPrecio)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 268)
        Me.GroupBox1.TabIndex = 471
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvArticulos, "tipo", True))
        Me.ComboBox1.DataSource = Me.DS_FI001
        Me.ComboBox1.DisplayMember = "tipos.nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(258, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(113, 21)
        Me.ComboBox1.TabIndex = 485
        Me.ComboBox1.ValueMember = "tipos.tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(223, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 486
        Me.Label7.Text = "Tipo"
        '
        'GbModifInventario
        '
        Me.GbModifInventario.Controls.Add(Me.BtnDismunuir)
        Me.GbModifInventario.Controls.Add(Me.Label11)
        Me.GbModifInventario.Controls.Add(Me.BtnAumentar)
        Me.GbModifInventario.Controls.Add(Me.NumCantArt)
        Me.GbModifInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbModifInventario.Location = New System.Drawing.Point(379, 171)
        Me.GbModifInventario.Name = "GbModifInventario"
        Me.GbModifInventario.Size = New System.Drawing.Size(135, 86)
        Me.GbModifInventario.TabIndex = 481
        Me.GbModifInventario.TabStop = False
        Me.GbModifInventario.Text = "Modificar inventario"
        Me.GbModifInventario.Visible = False
        '
        'BtnDismunuir
        '
        Me.BtnDismunuir.AutoSize = True
        Me.BtnDismunuir.Image = CType(resources.GetObject("BtnDismunuir.Image"), System.Drawing.Image)
        Me.BtnDismunuir.Location = New System.Drawing.Point(69, 44)
        Me.BtnDismunuir.Name = "BtnDismunuir"
        Me.BtnDismunuir.Size = New System.Drawing.Size(39, 32)
        Me.BtnDismunuir.TabIndex = 483
        Me.BtnDismunuir.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 481
        Me.Label11.Text = "Cantidad"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtnAumentar
        '
        Me.BtnAumentar.AutoSize = True
        Me.BtnAumentar.Image = CType(resources.GetObject("BtnAumentar.Image"), System.Drawing.Image)
        Me.BtnAumentar.Location = New System.Drawing.Point(27, 44)
        Me.BtnAumentar.Name = "BtnAumentar"
        Me.BtnAumentar.Size = New System.Drawing.Size(39, 32)
        Me.BtnAumentar.TabIndex = 482
        Me.BtnAumentar.UseVisualStyleBackColor = True
        '
        'NumCantArt
        '
        Me.NumCantArt.DecimalPlaces = 2
        Me.NumCantArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCantArt.Location = New System.Drawing.Point(63, 18)
        Me.NumCantArt.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.NumCantArt.Name = "NumCantArt"
        Me.NumCantArt.Size = New System.Drawing.Size(58, 20)
        Me.NumCantArt.TabIndex = 480
        Me.NumCantArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnModifInv
        '
        Me.BtnModifInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifInv.Image = CType(resources.GetObject("BtnModifInv.Image"), System.Drawing.Image)
        Me.BtnModifInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModifInv.Location = New System.Drawing.Point(395, 123)
        Me.BtnModifInv.Name = "BtnModifInv"
        Me.BtnModifInv.Size = New System.Drawing.Size(102, 43)
        Me.BtnModifInv.TabIndex = 484
        Me.BtnModifInv.Text = "Modificar Inventario"
        Me.BtnModifInv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModifInv.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(379, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 483
        Me.Label10.Text = "Exist. Actual"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NumInventario
        '
        Me.NumInventario.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dvArticulos, "existencia", True))
        Me.NumInventario.DecimalPlaces = 2
        Me.NumInventario.Location = New System.Drawing.Point(455, 96)
        Me.NumInventario.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.NumInventario.Name = "NumInventario"
        Me.NumInventario.Size = New System.Drawing.Size(62, 20)
        Me.NumInventario.TabIndex = 482
        Me.NumInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 470
        Me.Label6.Text = "Modelo"
        Me.Label6.Visible = False
        '
        'cbLinea
        '
        Me.cbLinea.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvArticulos, "modelo", True))
        Me.cbLinea.DataSource = Me.DS_FI001
        Me.cbLinea.DisplayMember = "modelos.nombre"
        Me.cbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLinea.FormattingEnabled = True
        Me.cbLinea.Location = New System.Drawing.Point(95, 96)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Size = New System.Drawing.Size(121, 21)
        Me.cbLinea.TabIndex = 469
        Me.cbLinea.ValueMember = "modelos.modelo"
        '
        'imgArticulo
        '
        Me.imgArticulo.BackColor = System.Drawing.Color.White
        Me.imgArticulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgArticulo.Image = CType(resources.GetObject("imgArticulo.Image"), System.Drawing.Image)
        Me.imgArticulo.Location = New System.Drawing.Point(0, 0)
        Me.imgArticulo.Name = "imgArticulo"
        Me.imgArticulo.Size = New System.Drawing.Size(481, 268)
        Me.imgArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgArticulo.TabIndex = 470
        Me.imgArticulo.TabStop = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.CommandTimeout = 99999999
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
        Me.SqlInsertCommand1.CommandTimeout = 999999999
        Me.SqlInsertCommand1.Connection = Me.sqlConn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 10, "cod_art"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 200, "descripcion"), New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Money, 8, "costo"), New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Money, 8, "precio"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 500, "observaciones"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3, "status"), New System.Data.SqlClient.SqlParameter("@imagen", System.Data.SqlDbType.VarBinary, 2147483647, "imagen"), New System.Data.SqlClient.SqlParameter("@nombre_imagen", System.Data.SqlDbType.VarChar, 200, "nombre_imagen"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@porc_ganancia", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_ganancia", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@modelo", System.Data.SqlDbType.[Char], 10, "modelo"), New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.[Char], 10, "tipo")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.CommandTimeout = 99999999
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 10, "cod_art"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 200, "descripcion"), New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Money, 8, "costo"), New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Money, 8, "precio"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 500, "observaciones"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3, "status"), New System.Data.SqlClient.SqlParameter("@imagen", System.Data.SqlDbType.VarBinary, 2147483647, "imagen"), New System.Data.SqlClient.SqlParameter("@nombre_imagen", System.Data.SqlDbType.VarChar, 200, "nombre_imagen"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@porc_ganancia", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_ganancia", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@modelo", System.Data.SqlDbType.[Char], 10, "modelo"), New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.[Char], 10, "tipo"), New System.Data.SqlClient.SqlParameter("@Original_cod_art", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_art", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [articulos] WHERE (([cod_art] = @Original_cod_art))"
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cod_art", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_art", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sdaArticulos
        '
        Me.sdaArticulos.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaArticulos.InsertCommand = Me.SqlInsertCommand1
        Me.sdaArticulos.SelectCommand = Me.SqlSelectCommand1
        Me.sdaArticulos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "articulos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_art", "cod_art"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("costo", "costo"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("imagen", "imagen"), New System.Data.Common.DataColumnMapping("nombre_imagen", "nombre_imagen"), New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("porc_ganancia", "porc_ganancia"), New System.Data.Common.DataColumnMapping("cod_prv", "cod_prv"), New System.Data.Common.DataColumnMapping("razon_social", "razon_social"), New System.Data.Common.DataColumnMapping("modelo", "modelo"), New System.Data.Common.DataColumnMapping("tipo", "tipo")})})
        Me.sdaArticulos.UpdateCommand = Me.SqlUpdateCommand1
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
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "dbo.generaFolio"
        Me.SqlSelectCommand3.CommandTimeout = 99999
        Me.SqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand3.Connection = Me.sqlConn
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@trans", System.Data.SqlDbType.[Char], 5), New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.InputOutput, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@msg", System.Data.SqlDbType.NVarChar, 2147483647, System.Data.ParameterDirection.InputOutput, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing)})
        '
        'sdaFolio
        '
        Me.sdaFolio.SelectCommand = Me.SqlSelectCommand3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 56)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.imgArticulo)
        Me.SplitContainer1.Size = New System.Drawing.Size(1008, 268)
        Me.SplitContainer1.SplitterDistance = 523
        Me.SplitContainer1.TabIndex = 473
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT        modelo, nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            modelos WITH (NOLOCK)"
        Me.SqlSelectCommand4.Connection = Me.sqlConn
        '
        'SdaModelos
        '
        Me.SdaModelos.SelectCommand = Me.SqlSelectCommand4
        Me.SdaModelos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "modelos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("modelo", "modelo"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'gbArticulos
        '
        Me.gbArticulos.Controls.Add(Me.dgArticulos)
        Me.gbArticulos.Controls.Add(Me.Label18)
        Me.gbArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbArticulos.Location = New System.Drawing.Point(0, 324)
        Me.gbArticulos.Name = "gbArticulos"
        Me.gbArticulos.Size = New System.Drawing.Size(1008, 397)
        Me.gbArticulos.TabIndex = 474
        Me.gbArticulos.TabStop = False
        '
        'dgArticulos
        '
        Me.dgArticulos.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodartDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.Column1, Me.CostoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.nombre_modelo, Me.nombre_tipo, Me.ObservacionesDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.ImagenDataGridViewImageColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.NombreimagenDataGridViewTextBoxColumn, Me.PorcgananciaDataGridViewTextBoxColumn})
        Me.dgArticulos.DataSource = Me.dvArticulos
        Me.dgArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgArticulos.Location = New System.Drawing.Point(3, 41)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgArticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgArticulos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgArticulos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgArticulos.Size = New System.Drawing.Size(1002, 353)
        Me.dgArticulos.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(3, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(1002, 25)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Artículos"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Controls.Add(Me.btnDeshacer)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 56)
        Me.GroupBox2.TabIndex = 475
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(258, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 43)
        Me.Button1.TabIndex = 485
        Me.Button1.Text = "Consulta de Inventario"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(208, 10)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(44, 40)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnDeshacer
        '
        Me.btnDeshacer.Image = CType(resources.GetObject("btnDeshacer.Image"), System.Drawing.Image)
        Me.btnDeshacer.Location = New System.Drawing.Point(158, 10)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(44, 40)
        Me.btnDeshacer.TabIndex = 3
        Me.btnDeshacer.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(108, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(44, 40)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(58, 10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(44, 40)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(8, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(44, 40)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'CmdAyDInventario
        '
        Me.CmdAyDInventario.CommandText = "AyDInventario"
        Me.CmdAyDInventario.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdAyDInventario.Connection = Me.sqlConn
        Me.CmdAyDInventario.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Trans", System.Data.SqlDbType.[Char], 5), New System.Data.SqlClient.SqlParameter("@CodArt", System.Data.SqlDbType.[Char], 10), New System.Data.SqlClient.SqlParameter("@Cant", System.Data.SqlDbType.Int, 4), New System.Data.SqlClient.SqlParameter("@msg", System.Data.SqlDbType.NVarChar, 2147483647, System.Data.ParameterDirection.InputOutput, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT        tipo, nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            tipos WITH (nolock)"
        Me.SqlSelectCommand5.Connection = Me.sqlConn
        '
        'SdaTipos
        '
        Me.SdaTipos.SelectCommand = Me.SqlSelectCommand5
        Me.SdaTipos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tipos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("tipo", "tipo"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'CodartDataGridViewTextBoxColumn
        '
        Me.CodartDataGridViewTextBoxColumn.DataPropertyName = "cod_art"
        Me.CodartDataGridViewTextBoxColumn.HeaderText = "Artículo"
        Me.CodartDataGridViewTextBoxColumn.Name = "CodartDataGridViewTextBoxColumn"
        Me.CodartDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodartDataGridViewTextBoxColumn.Width = 95
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 300
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "existencia"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "#,###,##0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Exist. Actual"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 115
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "#,###,##0.00"
        DataGridViewCellStyle3.NullValue = "0"
        Me.CostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo."
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoDataGridViewTextBoxColumn.Width = 95
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "#,###,##0.00"
        DataGridViewCellStyle4.NullValue = "0"
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio."
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 95
        '
        'nombre_modelo
        '
        Me.nombre_modelo.DataPropertyName = "nombre_modelo"
        Me.nombre_modelo.HeaderText = "Modelo"
        Me.nombre_modelo.Name = "nombre_modelo"
        Me.nombre_modelo.ReadOnly = True
        Me.nombre_modelo.Width = 200
        '
        'nombre_tipo
        '
        Me.nombre_tipo.DataPropertyName = "nombre_tipo"
        Me.nombre_tipo.HeaderText = "Tipo"
        Me.nombre_tipo.Name = "nombre_tipo"
        Me.nombre_tipo.ReadOnly = True
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Características"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 450
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 60
        '
        'ImagenDataGridViewImageColumn
        '
        Me.ImagenDataGridViewImageColumn.DataPropertyName = "imagen"
        Me.ImagenDataGridViewImageColumn.HeaderText = "imagen"
        Me.ImagenDataGridViewImageColumn.Name = "ImagenDataGridViewImageColumn"
        Me.ImagenDataGridViewImageColumn.ReadOnly = True
        Me.ImagenDataGridViewImageColumn.Visible = False
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'NombreimagenDataGridViewTextBoxColumn
        '
        Me.NombreimagenDataGridViewTextBoxColumn.DataPropertyName = "nombre_imagen"
        Me.NombreimagenDataGridViewTextBoxColumn.HeaderText = "nombre_imagen"
        Me.NombreimagenDataGridViewTextBoxColumn.Name = "NombreimagenDataGridViewTextBoxColumn"
        Me.NombreimagenDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreimagenDataGridViewTextBoxColumn.Visible = False
        '
        'PorcgananciaDataGridViewTextBoxColumn
        '
        Me.PorcgananciaDataGridViewTextBoxColumn.DataPropertyName = "porc_ganancia"
        Me.PorcgananciaDataGridViewTextBoxColumn.HeaderText = "porc_ganancia"
        Me.PorcgananciaDataGridViewTextBoxColumn.Name = "PorcgananciaDataGridViewTextBoxColumn"
        Me.PorcgananciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcgananciaDataGridViewTextBoxColumn.Visible = False
        '
        'FI001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.Controls.Add(Me.gbArticulos)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FI001"
        Me.Text = "Catálogo de artículos"
        CType(Me.dvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FI001, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbModifInventario.ResumeLayout(False)
        Me.GbModifInventario.PerformLayout()
        CType(Me.NumCantArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbArticulos.ResumeLayout(False)
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtImagen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numPrecio As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents numCosto As NumericUpDown
    Friend WithEvents txtCodArt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents imgArticulo As PictureBox
    Friend WithEvents dvArticulos As DataView
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents sdaArticulos As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaStatus As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FI001 As DS_FI001
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents sdaFolio As SqlClient.SqlDataAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label6 As Label
    Friend WithEvents cbLinea As ComboBox
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents SdaModelos As SqlClient.SqlDataAdapter
    Friend WithEvents gbArticulos As GroupBox
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnDeshacer As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents GbModifInventario As GroupBox
    Friend WithEvents BtnDismunuir As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnAumentar As Button
    Friend WithEvents NumCantArt As NumericUpDown
    Friend WithEvents BtnModifInv As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents NumInventario As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents CmdAyDInventario As SqlClient.SqlCommand
    Friend WithEvents LineaarticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SqlSelectCommand5 As SqlClient.SqlCommand
    Friend WithEvents SdaTipos As SqlClient.SqlDataAdapter
    Friend WithEvents CodartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombre_modelo As DataGridViewTextBoxColumn
    Friend WithEvents nombre_tipo As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImagenDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreimagenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcgananciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
