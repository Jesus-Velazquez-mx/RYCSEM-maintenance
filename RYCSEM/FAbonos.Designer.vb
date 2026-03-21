<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FAbonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAbonos))
        Me.numPago = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numAbono = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lCambio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFolioVta = New System.Windows.Forms.TextBox()
        Me.lAbonos = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lSaldo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtFolioAbn = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MyDataGrid1 = New MyControls.MyDataGrid()
        Me.DvVenta = New System.Data.DataView()
        Me.DS_FAbonos = New RYCSEM.DS_FAbonos()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SdaVenta = New System.Data.SqlClient.SqlDataAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.SqlInsertarAbono = New System.Data.SqlClient.SqlCommand()
        Me.SqlActualizaVta = New System.Data.SqlClient.SqlCommand()
        Me.cmdFormasPago = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SdaAbono = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.numPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'numPago
        '
        Me.numPago.DecimalPlaces = 2
        Me.numPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPago.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.numPago.Location = New System.Drawing.Point(143, 65)
        Me.numPago.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.numPago.Name = "numPago"
        Me.numPago.Size = New System.Drawing.Size(154, 35)
        Me.numPago.TabIndex = 23
        Me.numPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 31)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Pago:"
        '
        'numAbono
        '
        Me.numAbono.DecimalPlaces = 2
        Me.numAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAbono.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.numAbono.Location = New System.Drawing.Point(143, 21)
        Me.numAbono.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.numAbono.Name = "numAbono"
        Me.numAbono.Size = New System.Drawing.Size(154, 35)
        Me.numAbono.TabIndex = 19
        Me.numAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 31)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Abono:"
        '
        'lCambio
        '
        Me.lCambio.AutoSize = True
        Me.lCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCambio.ForeColor = System.Drawing.Color.ForestGreen
        Me.lCambio.Location = New System.Drawing.Point(524, 41)
        Me.lCambio.Name = "lCambio"
        Me.lCambio.Size = New System.Drawing.Size(127, 39)
        Me.lCambio.TabIndex = 17
        Me.lCambio.Text = "$00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(358, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 39)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Cambio:"
        '
        'lTotal
        '
        Me.lTotal.AutoSize = True
        Me.lTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lTotal.Location = New System.Drawing.Point(67, 164)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(127, 39)
        Me.lTotal.TabIndex = 15
        Me.lTotal.Text = "$00.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(81, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 39)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 29)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "FOLIO"
        '
        'txtFolioVta
        '
        Me.txtFolioVta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolioVta.Location = New System.Drawing.Point(12, 54)
        Me.txtFolioVta.Name = "txtFolioVta"
        Me.txtFolioVta.Size = New System.Drawing.Size(110, 38)
        Me.txtFolioVta.TabIndex = 26
        '
        'lAbonos
        '
        Me.lAbonos.AutoSize = True
        Me.lAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAbonos.ForeColor = System.Drawing.Color.ForestGreen
        Me.lAbonos.Location = New System.Drawing.Point(275, 164)
        Me.lAbonos.Name = "lAbonos"
        Me.lAbonos.Size = New System.Drawing.Size(127, 39)
        Me.lAbonos.TabIndex = 32
        Me.lAbonos.Text = "$00.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(269, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 39)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Abonos"
        '
        'lSaldo
        '
        Me.lSaldo.AutoSize = True
        Me.lSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSaldo.ForeColor = System.Drawing.Color.Red
        Me.lSaldo.Location = New System.Drawing.Point(482, 164)
        Me.lSaldo.Name = "lSaldo"
        Me.lSaldo.Size = New System.Drawing.Size(127, 39)
        Me.lSaldo.TabIndex = 34
        Me.lSaldo.Text = "$00.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(490, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 39)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Saldo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.txtFolioAbn)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lSaldo)
        Me.GroupBox1.Controls.Add(Me.txtFolioVta)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lAbonos)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lTotal)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 219)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(131, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 29)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "RAZÓN SOCIAL"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(128, 54)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(414, 38)
        Me.txtRazonSocial.TabIndex = 36
        '
        'txtFolioAbn
        '
        Me.txtFolioAbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFolioAbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolioAbn.Location = New System.Drawing.Point(609, 12)
        Me.txtFolioAbn.Name = "txtFolioAbn"
        Me.txtFolioAbn.ReadOnly = True
        Me.txtFolioAbn.Size = New System.Drawing.Size(89, 33)
        Me.txtFolioAbn.TabIndex = 35
        Me.txtFolioAbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MyDataGrid1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 333)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'MyDataGrid1
        '
        Me.MyDataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Bold)
        Me.MyDataGrid1.DataMember = ""
        Me.MyDataGrid1.DataSource = Me.DvVenta
        Me.MyDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MyDataGrid1.Location = New System.Drawing.Point(3, 16)
        Me.MyDataGrid1.Name = "MyDataGrid1"
        Me.MyDataGrid1.Portapapeles = True
        Me.MyDataGrid1.ReadOnly = True
        Me.MyDataGrid1.Size = New System.Drawing.Size(697, 314)
        Me.MyDataGrid1.TabIndex = 0
        Me.MyDataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DvVenta
        '
        Me.DvVenta.AllowNew = False
        Me.DvVenta.Table = Me.DS_FAbonos.Venta
        '
        'DS_FAbonos
        '
        Me.DS_FAbonos.DataSetName = "DS_FAbonos"
        Me.DS_FAbonos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.MyDataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Venta"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Articulo"
        Me.DataGridTextBoxColumn1.MappingName = "cod_art"
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.MappingName = "descripcion"
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "N0"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Cantidad."
        Me.DataGridTextBoxColumn5.MappingName = "cantidad"
        Me.DataGridTextBoxColumn5.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "#,##0.00"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Importe."
        Me.DataGridTextBoxColumn3.MappingName = "importe"
        Me.DataGridTextBoxColumn3.Width = 80
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "#,##0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Total."
        Me.DataGridTextBoxColumn4.MappingName = "total_art"
        Me.DataGridTextBoxColumn4.Width = 80
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lCambio)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.numAbono)
        Me.GroupBox3.Controls.Add(Me.numPago)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 489)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(703, 119)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "dbo.Venta"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.[Char], 10), New System.Data.SqlClient.SqlParameter("@Transaccion", System.Data.SqlDbType.[Char], 10)})
        '
        'SdaVenta
        '
        Me.SdaVenta.SelectCommand = Me.SqlSelectCommand1
        Me.SdaVenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Venta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("razon_social", "razon_social"), New System.Data.Common.DataColumnMapping("total_vta", "total_vta"), New System.Data.Common.DataColumnMapping("saldo", "saldo"), New System.Data.Common.DataColumnMapping("abonos", "abonos"), New System.Data.Common.DataColumnMapping("cod_art", "cod_art"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("importe", "importe"), New System.Data.Common.DataColumnMapping("total_art", "total_art")})})
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnImprimir)
        Me.GroupBox4.Controls.Add(Me.btnDeshacer)
        Me.GroupBox4.Controls.Add(Me.btnGuardar)
        Me.GroupBox4.Controls.Add(Me.btnNuevo)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(703, 56)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(158, 10)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(44, 40)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnDeshacer
        '
        Me.btnDeshacer.Image = CType(resources.GetObject("btnDeshacer.Image"), System.Drawing.Image)
        Me.btnDeshacer.Location = New System.Drawing.Point(108, 10)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(44, 40)
        Me.btnDeshacer.TabIndex = 3
        Me.btnDeshacer.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(58, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(44, 40)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(9, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(44, 40)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'SqlInsertarAbono
        '
        Me.SqlInsertarAbono.CommandText = resources.GetString("SqlInsertarAbono.CommandText")
        Me.SqlInsertarAbono.Connection = Me.sqlConn
        Me.SqlInsertarAbono.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 4, "fecha"), New System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Money, 8, "importe"), New System.Data.SqlClient.SqlParameter("@total", System.Data.SqlDbType.Money, 8, "total"), New System.Data.SqlClient.SqlParameter("@folio_doc", System.Data.SqlDbType.[Char], 10, "folio_doc"), New System.Data.SqlClient.SqlParameter("@transaccion_doc", System.Data.SqlDbType.[Char], 10, "transaccion_doc"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 10, "cod_cte"), New System.Data.SqlClient.SqlParameter("@fecha_abono", System.Data.SqlDbType.SmallDateTime, 4, "fecha_abono"), New System.Data.SqlClient.SqlParameter("@efectivo", System.Data.SqlDbType.Money, 8, "efectivo"), New System.Data.SqlClient.SqlParameter("@tarjeta", System.Data.SqlDbType.Money, 8, "tarjeta")})
        '
        'SqlActualizaVta
        '
        Me.SqlActualizaVta.CommandText = "UPDATE       notas_venta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                abonos = abonos + @Abono, saldo = sa" &
    "ldo - @Abono" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (folio = @Folio) AND (transaccion = @Transaccion)"
        Me.SqlActualizaVta.Connection = Me.sqlConn
        Me.SqlActualizaVta.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Abono", System.Data.SqlDbType.Money, 8, "abonos"), New System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Transaccion", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "transaccion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'cmdFormasPago
        '
        Me.cmdFormasPago.CommandText = "INSERT INTO documentos_formas_pago" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         (folio, transaccion," &
    " forma_pago, monto)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES        (@folio,@transaccion,@forma_pago,@monto)"
        Me.cmdFormasPago.Connection = Me.sqlConn
        Me.cmdFormasPago.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion"), New System.Data.SqlClient.SqlParameter("@forma_pago", System.Data.SqlDbType.[Char], 10, "forma_pago"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(4, Byte), "monto", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@Transaccion", System.Data.SqlDbType.[Char], 10, "transaccion")})
        '
        'SdaAbono
        '
        Me.SdaAbono.SelectCommand = Me.SqlSelectCommand2
        Me.SdaAbono.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "abonos_clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("importe", "importe"), New System.Data.Common.DataColumnMapping("poc_interes_moratorio", "poc_interes_moratorio"), New System.Data.Common.DataColumnMapping("interes_moratorio", "interes_moratorio"), New System.Data.Common.DataColumnMapping("total", "total"), New System.Data.Common.DataColumnMapping("folio_doc", "folio_doc"), New System.Data.Common.DataColumnMapping("transaccion_doc", "transaccion_doc"), New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("fecha_abono", "fecha_abono"), New System.Data.Common.DataColumnMapping("efectivo", "efectivo"), New System.Data.Common.DataColumnMapping("tarjeta", "tarjeta")})})
        '
        'FAbonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 608)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "FAbonos"
        Me.Text = "Abonos clientes"
        CType(Me.numPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAbono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents numPago As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents numAbono As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents lCambio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFolioVta As TextBox
    Friend WithEvents lAbonos As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lSaldo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MyDataGrid1 As MyControls.MyDataGrid
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtFolioAbn As TextBox
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SdaVenta As SqlClient.SqlDataAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnDeshacer As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents DS_FAbonos As DS_FAbonos
    Friend WithEvents SqlInsertarAbono As SqlClient.SqlCommand
    Friend WithEvents SqlActualizaVta As SqlClient.SqlCommand
    Friend WithEvents DvVenta As DataView
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents cmdFormasPago As SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SdaAbono As SqlClient.SqlDataAdapter
End Class
