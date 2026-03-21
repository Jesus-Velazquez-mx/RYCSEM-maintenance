<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCorteCaja
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCorteCaja))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.DS_FCorteCaja = New RYCSEM.DS_FCorteCaja()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numDeposito = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numEgresos = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numIngresos = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumFondo = New System.Windows.Forms.NumericUpDown()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numTarjeta = New System.Windows.Forms.NumericUpDown()
        Me.NumEfectivo = New System.Windows.Forms.NumericUpDown()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.sdaUsuario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlTerminarTurno = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaTraerCorteCaja = New System.Data.SqlClient.SqlDataAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DS_FCorteCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(170, 32)
        Me.DateTimePicker1.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "DE"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(394, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(110, 29)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Por turno"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmbUser
        '
        Me.cmbUser.DataSource = Me.DS_FCorteCaja
        Me.cmbUser.DisplayMember = "usuarios.nombre"
        Me.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUser.Enabled = False
        Me.cmbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(119, 68)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(269, 33)
        Me.cmbUser.TabIndex = 20
        Me.cmbUser.ValueMember = "usuarios.usuario"
        '
        'DS_FCorteCaja
        '
        Me.DS_FCorteCaja.DataSetName = "DS_FCorteCaja"
        Me.DS_FCorteCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "USUARIO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cmbUser)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 438)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(295, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "A"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(328, 19)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(170, 32)
        Me.DateTimePicker2.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.numDeposito)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.numEgresos)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.numIngresos)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.NumFondo)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.lTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.numTarjeta)
        Me.GroupBox2.Controls.Add(Me.NumEfectivo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 330)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(220, 193)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 41
        Me.PictureBox6.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(50, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 25)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "VTA. EN LÍNEA"
        '
        'numDeposito
        '
        Me.numDeposito.DecimalPlaces = 2
        Me.numDeposito.Enabled = False
        Me.numDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDeposito.Location = New System.Drawing.Point(259, 194)
        Me.numDeposito.Maximum = New Decimal(New Integer() {-1304428544, 434162106, 542, 0})
        Me.numDeposito.Minimum = New Decimal(New Integer() {-1981284352, -1966660860, 0, -2147483648})
        Me.numDeposito.Name = "numDeposito"
        Me.numDeposito.Size = New System.Drawing.Size(186, 30)
        Me.numDeposito.TabIndex = 39
        Me.numDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDeposito.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.numDeposito, "DEPÓSITOS Y COBRO EN LÍNEA")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(221, 85)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 38
        Me.PictureBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(98, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 25)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "EGRESOS"
        '
        'numEgresos
        '
        Me.numEgresos.DecimalPlaces = 2
        Me.numEgresos.Enabled = False
        Me.numEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEgresos.Location = New System.Drawing.Point(259, 86)
        Me.numEgresos.Maximum = New Decimal(New Integer() {-1304428544, 434162106, 542, 0})
        Me.numEgresos.Minimum = New Decimal(New Integer() {-1981284352, -1966660860, 0, -2147483648})
        Me.numEgresos.Name = "numEgresos"
        Me.numEgresos.Size = New System.Drawing.Size(186, 30)
        Me.numEgresos.TabIndex = 36
        Me.numEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numEgresos.ThousandsSeparator = True
        Me.numEgresos.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(221, 49)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(91, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 25)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "INGRESOS"
        '
        'numIngresos
        '
        Me.numIngresos.DecimalPlaces = 2
        Me.numIngresos.Enabled = False
        Me.numIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numIngresos.Location = New System.Drawing.Point(259, 50)
        Me.numIngresos.Maximum = New Decimal(New Integer() {-1304428544, 434162106, 542, 0})
        Me.numIngresos.Minimum = New Decimal(New Integer() {-1981284352, -1966660860, 0, -2147483648})
        Me.numIngresos.Name = "numIngresos"
        Me.numIngresos.Size = New System.Drawing.Size(186, 30)
        Me.numIngresos.TabIndex = 33
        Me.numIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numIngresos.ThousandsSeparator = True
        Me.numIngresos.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(221, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(126, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 25)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "FONDO"
        '
        'NumFondo
        '
        Me.NumFondo.DecimalPlaces = 2
        Me.NumFondo.Enabled = False
        Me.NumFondo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumFondo.Location = New System.Drawing.Point(259, 14)
        Me.NumFondo.Maximum = New Decimal(New Integer() {-1304428544, 434162106, 542, 0})
        Me.NumFondo.Minimum = New Decimal(New Integer() {-1981284352, -1966660860, 0, -2147483648})
        Me.NumFondo.Name = "NumFondo"
        Me.NumFondo.Size = New System.Drawing.Size(186, 30)
        Me.NumFondo.TabIndex = 30
        Me.NumFondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumFondo.ThousandsSeparator = True
        Me.NumFondo.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(515, 39)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(159, 117)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "F9 IMPRIMIR CORTE"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lTotal
        '
        Me.lTotal.AutoSize = True
        Me.lTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lTotal.Location = New System.Drawing.Point(348, 246)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(252, 69)
        Me.lTotal.TabIndex = 28
        Me.lTotal.Text = "$360.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(109, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 69)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "TOTAL:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(220, 157)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(221, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "VTA. TARJETA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "VTA. EFECTIVO"
        '
        'numTarjeta
        '
        Me.numTarjeta.DecimalPlaces = 2
        Me.numTarjeta.Enabled = False
        Me.numTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTarjeta.Location = New System.Drawing.Point(259, 158)
        Me.numTarjeta.Maximum = New Decimal(New Integer() {-1304428544, 434162106, 542, 0})
        Me.numTarjeta.Minimum = New Decimal(New Integer() {-1981284352, -1966660860, 0, -2147483648})
        Me.numTarjeta.Name = "numTarjeta"
        Me.numTarjeta.Size = New System.Drawing.Size(186, 30)
        Me.numTarjeta.TabIndex = 1
        Me.numTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTarjeta.ThousandsSeparator = True
        '
        'NumEfectivo
        '
        Me.NumEfectivo.DecimalPlaces = 2
        Me.NumEfectivo.Enabled = False
        Me.NumEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumEfectivo.Location = New System.Drawing.Point(259, 122)
        Me.NumEfectivo.Maximum = New Decimal(New Integer() {-1304428544, 434162106, 542, 0})
        Me.NumEfectivo.Minimum = New Decimal(New Integer() {-1981284352, -1966660860, 0, -2147483648})
        Me.NumEfectivo.Name = "NumEfectivo"
        Me.NumEfectivo.Size = New System.Drawing.Size(186, 30)
        Me.NumEfectivo.TabIndex = 0
        Me.NumEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumEfectivo.ThousandsSeparator = True
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'sdaUsuario
        '
        Me.sdaUsuario.SelectCommand = Me.SqlSelectCommand1
        Me.sdaUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        usuario, nombre + ' ' + ap_paterno + ' ' + ap_Materno AS nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FR" &
    "OM            usuarios WITH (NOLOCK)"
        Me.SqlSelectCommand1.CommandTimeout = 999999
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'SqlTerminarTurno
        '
        Me.SqlTerminarTurno.CommandText = "UPDATE       turnos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                activo = 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (turnoid = @turn" &
    "oid)"
        Me.SqlTerminarTurno.Connection = Me.sqlConn
        Me.SqlTerminarTurno.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@turnoid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "turnoid", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "dbo.CorteCaja"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@turnoID", System.Data.SqlDbType.Int, 4)})
        '
        'sdaTraerCorteCaja
        '
        Me.sdaTraerCorteCaja.SelectCommand = Me.SqlSelectCommand2
        Me.sdaTraerCorteCaja.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Agrupado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("FONDO", "FONDO"), New System.Data.Common.DataColumnMapping("INGRESOS", "INGRESOS"), New System.Data.Common.DataColumnMapping("EGRESOS", "EGRESOS"), New System.Data.Common.DataColumnMapping("VENTA_EFECTIVO", "VENTA_EFECTIVO"), New System.Data.Common.DataColumnMapping("VENTA_TARJETA", "VENTA_TARJETA")}), New System.Data.Common.DataTableMapping("Table1", "detalleVentas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"), New System.Data.Common.DataColumnMapping("CANTIDAD", "CANTIDAD"), New System.Data.Common.DataColumnMapping("COD_ART", "COD_ART"), New System.Data.Common.DataColumnMapping("DESCRIPCION", "DESCRIPCION"), New System.Data.Common.DataColumnMapping("IMPORTE", "IMPORTE"), New System.Data.Common.DataColumnMapping("IVA", "IVA"), New System.Data.Common.DataColumnMapping("TOTAL", "TOTAL"), New System.Data.Common.DataColumnMapping("FORMA_PAGO", "FORMA_PAGO"), New System.Data.Common.DataColumnMapping("NOMBREFORMAPAGO", "NOMBREFORMAPAGO")})})
        '
        'FCorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FCorteCaja"
        Me.Text = "Corte Caja"
        CType(Me.DS_FCorteCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumFondo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numTarjeta As NumericUpDown
    Friend WithEvents NumEfectivo As NumericUpDown
    Friend WithEvents lTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents sdaUsuario As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents DS_FCorteCaja As DS_FCorteCaja
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NumFondo As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents numEgresos As NumericUpDown
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents numIngresos As NumericUpDown
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SqlTerminarTurno As SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaTraerCorteCaja As SqlClient.SqlDataAdapter
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents numDeposito As NumericUpDown
    Friend WithEvents ToolTip1 As ToolTip
End Class
