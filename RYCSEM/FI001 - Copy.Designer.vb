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
        Me.MToolBar1 = New WindowsControlLibrary1.MToolBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numPorcGan = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbLinea = New System.Windows.Forms.ComboBox()
        Me.imgArticulo = New System.Windows.Forms.PictureBox()
        Me.dgArticulos = New MyControls.MyDataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
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
        Me.sdaLineas = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.dvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FI001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numPorcGan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(457, 68)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(23, 26)
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
        Me.txtImagen.Size = New System.Drawing.Size(356, 20)
        Me.txtImagen.TabIndex = 468
        '
        'dvArticulos
        '
        Me.dvArticulos.AllowNew = False
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
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(385, 61)
        Me.txtObservaciones.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 466
        Me.Label4.Text = "Observaciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 464
        Me.Label3.Text = "Precio"
        '
        'numPrecio
        '
        Me.numPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dvArticulos, "precio", True))
        Me.numPrecio.DecimalPlaces = 2
        Me.numPrecio.Enabled = False
        Me.numPrecio.Location = New System.Drawing.Point(236, 45)
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
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
        Me.txtCodArt.Size = New System.Drawing.Size(74, 20)
        Me.txtCodArt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 459
        Me.Label1.Text = "Artículo"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvArticulos, "descripcion", True))
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(171, 19)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(309, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(332, 49)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(37, 13)
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
        Me.cbStatus.Location = New System.Drawing.Point(374, 45)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(107, 21)
        Me.cbStatus.TabIndex = 5
        Me.cbStatus.ValueMember = "status.status"
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
        Me.MToolBar1.BRefreshVisible = True
        Me.MToolBar1.BSep1Visible = True
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
        Me.MToolBar1.TabIndex = 470
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.numPorcGan)
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
        Me.GroupBox1.Size = New System.Drawing.Size(492, 190)
        Me.GroupBox1.TabIndex = 471
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(222, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 472
        Me.Label7.Text = "% Ganancia"
        '
        'numPorcGan
        '
        Me.numPorcGan.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dvArticulos, "porc_ganancia", True))
        Me.numPorcGan.Location = New System.Drawing.Point(292, 96)
        Me.numPorcGan.Name = "numPorcGan"
        Me.numPorcGan.Size = New System.Drawing.Size(58, 20)
        Me.numPorcGan.TabIndex = 471
        Me.numPorcGan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 470
        Me.Label6.Text = "Linea"
        '
        'cbLinea
        '
        Me.cbLinea.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvArticulos, "linea_articulo", True))
        Me.cbLinea.DataSource = Me.DS_FI001
        Me.cbLinea.DisplayMember = "lineas_articulos.nombre"
        Me.cbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLinea.FormattingEnabled = True
        Me.cbLinea.Location = New System.Drawing.Point(95, 96)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Size = New System.Drawing.Size(121, 21)
        Me.cbLinea.TabIndex = 469
        Me.cbLinea.ValueMember = "lineas_articulos.linea_articulo"
        '
        'imgArticulo
        '
        Me.imgArticulo.Dock = System.Windows.Forms.DockStyle.Left
        Me.imgArticulo.Image = CType(resources.GetObject("imgArticulo.Image"), System.Drawing.Image)
        Me.imgArticulo.Location = New System.Drawing.Point(0, 0)
        Me.imgArticulo.Name = "imgArticulo"
        Me.imgArticulo.Size = New System.Drawing.Size(180, 190)
        Me.imgArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgArticulo.TabIndex = 470
        Me.imgArticulo.TabStop = False
        '
        'dgArticulos
        '
        Me.dgArticulos.CaptionText = "Artículos"
        Me.dgArticulos.DataMember = ""
        Me.dgArticulos.DataSource = Me.dvArticulos
        Me.dgArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgArticulos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgArticulos.Location = New System.Drawing.Point(0, 218)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.Portapapeles = True
        Me.dgArticulos.Size = New System.Drawing.Size(1008, 503)
        Me.dgArticulos.TabIndex = 472
        Me.dgArticulos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgArticulos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "articulos"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Artículo"
        Me.DataGridTextBoxColumn1.MappingName = "cod_art"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripcióon"
        Me.DataGridTextBoxColumn2.MappingName = "descripcion"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Costo."
        Me.DataGridTextBoxColumn3.MappingName = "costo"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 90
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "#,###,##0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Precio."
        Me.DataGridTextBoxColumn4.MappingName = "precio"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 90
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Observaciones"
        Me.DataGridTextBoxColumn5.MappingName = "observaciones"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 350
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Nombre Imagen"
        Me.DataGridTextBoxColumn8.MappingName = "nombre_imagen"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 150
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Status"
        Me.DataGridTextBoxColumn7.MappingName = "status"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 10, "cod_art"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 200, "descripcion"), New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Money, 8, "costo"), New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Money, 8, "precio"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 500, "observaciones"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3, "status"), New System.Data.SqlClient.SqlParameter("@imagen", System.Data.SqlDbType.VarBinary, 2147483647, "imagen"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@nombre_imagen", System.Data.SqlDbType.VarChar, 200, "nombre_imagen"), New System.Data.SqlClient.SqlParameter("@linea_articulo", System.Data.SqlDbType.[Char], 10, "linea_articulo"), New System.Data.SqlClient.SqlParameter("@porc_ganancia", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_ganancia", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.CommandTimeout = 99999999
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 10, "cod_art"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 200, "descripcion"), New System.Data.SqlClient.SqlParameter("@costo", System.Data.SqlDbType.Money, 8, "costo"), New System.Data.SqlClient.SqlParameter("@precio", System.Data.SqlDbType.Money, 8, "precio"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 500, "observaciones"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3, "status"), New System.Data.SqlClient.SqlParameter("@imagen", System.Data.SqlDbType.VarBinary, 2147483647, "imagen"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@nombre_imagen", System.Data.SqlDbType.VarChar, 200, "nombre_imagen"), New System.Data.SqlClient.SqlParameter("@linea_articulo", System.Data.SqlDbType.[Char], 10, "linea_articulo"), New System.Data.SqlClient.SqlParameter("@porc_ganancia", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(8, Byte), "porc_ganancia", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cod_art", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_art", System.Data.DataRowVersion.Original, Nothing)})
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
        Me.sdaArticulos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "articulos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_art", "cod_art"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("costo", "costo"), New System.Data.Common.DataColumnMapping("precio", "precio"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones"), New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("imagen", "imagen"), New System.Data.Common.DataColumnMapping("usuario", "usuario")})})
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
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.imgArticulo)
        Me.SplitContainer1.Size = New System.Drawing.Size(1008, 190)
        Me.SplitContainer1.SplitterDistance = 492
        Me.SplitContainer1.TabIndex = 473
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT        linea_articulo, nombre, porc_ganancia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            lineas_artic" &
    "ulos WITH (NOLOCK)"
        Me.SqlSelectCommand4.Connection = Me.sqlConn
        '
        'sdaLineas
        '
        Me.sdaLineas.SelectCommand = Me.SqlSelectCommand4
        Me.sdaLineas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "lineas_articulos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("linea_articulo", "linea_articulo"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("porc_ganancia", "porc_ganancia")})})
        '
        'FI001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MToolBar1)
        Me.Name = "FI001"
        Me.Text = "Catálogo de artículos"
        CType(Me.dvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FI001, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numPorcGan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents MToolBar1 As WindowsControlLibrary1.MToolBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents imgArticulo As PictureBox
    Friend WithEvents dgArticulos As MyControls.MyDataGrid
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
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As DataGridTextBoxColumn
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents sdaFolio As SqlClient.SqlDataAdapter
    Friend WithEvents DataGridTextBoxColumn8 As DataGridTextBoxColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label7 As Label
    Friend WithEvents numPorcGan As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents cbLinea As ComboBox
    Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
    Friend WithEvents sdaLineas As SqlClient.SqlDataAdapter
End Class
