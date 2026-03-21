<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FI002
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FI002))
        Me.MToolBar1 = New WindowsControlLibrary1.MToolBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.DvArticulos = New System.Data.DataView()
        Me.DS_FI002 = New RYCSEM.DS_FI002()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MyNumCant = New MyControls.MyNumeric()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbOpe = New System.Windows.Forms.ComboBox()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MyDataGrid1 = New MyControls.MyDataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SqlCnn1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SdaMOpeInventario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SdaStatus = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SdaOperaciones = New System.Data.SqlClient.SqlDataAdapter()
        Me.CmdOpeInventario = New System.Data.SqlClient.SqlCommand()
        Me.CmdActOpeInventario = New System.Data.SqlClient.SqlCommand()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FI002, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyNumCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MToolBar1.BSep1Visible = False
        Me.MToolBar1.BSep2Visible = True
        Me.MToolBar1.BSep3Visible = True
        Me.MToolBar1.BSep4Visible = False
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
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CmbStatus)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.MyNumCant)
        Me.GroupBox1.Controls.Add(Me.TxtArticulo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTPFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CmbOpe)
        Me.GroupBox1.Controls.Add(Me.TxtFolio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 71)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(451, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Status"
        '
        'CmbStatus
        '
        Me.CmbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DvArticulos, "status", True))
        Me.CmbStatus.DataSource = Me.DS_FI002
        Me.CmbStatus.DisplayMember = "status.descripcion"
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(494, 14)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(123, 21)
        Me.CmbStatus.TabIndex = 12
        Me.CmbStatus.ValueMember = "status.status"
        '
        'DvArticulos
        '
        Me.DvArticulos.AllowNew = False
        Me.DvArticulos.Table = Me.DS_FI002.moperaciones_inventario
        '
        'DS_FI002
        '
        Me.DS_FI002.DataSetName = "DS_FI002"
        Me.DS_FI002.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.RYCSEM.My.Resources.Resources.DELETE
        Me.BtnEliminar.Location = New System.Drawing.Point(274, 43)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(27, 23)
        Me.BtnEliminar.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar articulo")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.RYCSEM.My.Resources.Resources._NEW
        Me.BtnNuevo.Location = New System.Drawing.Point(246, 43)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(27, 23)
        Me.BtnNuevo.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Insertar articulo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cantidad"
        '
        'MyNumCant
        '
        Me.MyNumCant.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DvArticulos, "cantidad", True))
        Me.MyNumCant.DecimalPlaces = 2
        Me.MyNumCant.Location = New System.Drawing.Point(194, 44)
        Me.MyNumCant.Name = "MyNumCant"
        Me.MyNumCant.Size = New System.Drawing.Size(47, 20)
        Me.MyNumCant.TabIndex = 8
        '
        'TxtArticulo
        '
        Me.TxtArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DvArticulos, "cod_art", True))
        Me.TxtArticulo.Location = New System.Drawing.Point(64, 44)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.Size = New System.Drawing.Size(62, 20)
        Me.TxtArticulo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Artículo"
        '
        'DTPFecha
        '
        Me.DTPFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DvArticulos, "fecha", True))
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(347, 14)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(98, 20)
        Me.DTPFecha.TabIndex = 5
        Me.DTPFecha.Value = New Date(2018, 2, 22, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Operación"
        '
        'CmbOpe
        '
        Me.CmbOpe.DataSource = Me.DS_FI002
        Me.CmbOpe.DisplayMember = "transacciones.nombre"
        Me.CmbOpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOpe.FormattingEnabled = True
        Me.CmbOpe.Location = New System.Drawing.Point(194, 14)
        Me.CmbOpe.Name = "CmbOpe"
        Me.CmbOpe.Size = New System.Drawing.Size(104, 21)
        Me.CmbOpe.TabIndex = 2
        Me.CmbOpe.ValueMember = "transacciones.transaccion"
        '
        'TxtFolio
        '
        Me.TxtFolio.Location = New System.Drawing.Point(64, 14)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(62, 20)
        Me.TxtFolio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MyDataGrid1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 462)
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
        Me.MyDataGrid1.Size = New System.Drawing.Size(1002, 443)
        Me.MyDataGrid1.TabIndex = 0
        Me.MyDataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.MyDataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "moperaciones_inventario"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Artículo"
        Me.DataGridTextBoxColumn1.MappingName = "cod_art"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.MappingName = "descripcion"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "#,##0.00"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Cant."
        Me.DataGridTextBoxColumn3.MappingName = "cantidad"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'SqlCnn1
        '
        Me.SqlCnn1.ConnectionString = "Data Source=LUNA;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa;Pas" &
    "sword=rycsem2017"
        Me.SqlCnn1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlCnn1
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion")})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [moperaciones_inventario] ([folio], [transaccion], [cod_art], [cantid" &
    "ad]) VALUES (@folio, @transaccion, @cod_art, @cantidad)"
        Me.SqlInsertCommand1.Connection = Me.SqlCnn1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 0, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 0, "transaccion"), New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 0, "cod_art"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(4, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE [moperaciones_inventario] SET [folio] = @folio, [transaccion] = @transacci" &
    "on, [cod_art] = @cod_art, [cantidad] = @cantidad WHERE (([id] = @Original_id))"
        Me.SqlUpdateCommand1.Connection = Me.SqlCnn1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 0, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 0, "transaccion"), New System.Data.SqlClient.SqlParameter("@cod_art", System.Data.SqlDbType.[Char], 0, "cod_art"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(4, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [moperaciones_inventario] WHERE (([id] = @Original_id))"
        Me.SqlDeleteCommand1.Connection = Me.SqlCnn1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SdaMOpeInventario
        '
        Me.SdaMOpeInventario.DeleteCommand = Me.SqlDeleteCommand1
        Me.SdaMOpeInventario.InsertCommand = Me.SqlInsertCommand1
        Me.SdaMOpeInventario.SelectCommand = Me.SqlSelectCommand1
        Me.SdaMOpeInventario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "moperaciones_inventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("folio", "folio"), New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("cod_art", "cod_art"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad")})})
        Me.SdaMOpeInventario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        status, abreviatura, descripcion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE    " &
    "    (status IN ('V', 'C'))"
        Me.SqlSelectCommand2.Connection = Me.SqlCnn1
        '
        'SdaStatus
        '
        Me.SdaStatus.SelectCommand = Me.SqlSelectCommand2
        Me.SdaStatus.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "status", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("abreviatura", "abreviatura"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "select * from transacciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "where transaccion in ('02','03')"
        Me.SqlSelectCommand3.Connection = Me.SqlCnn1
        '
        'SdaOperaciones
        '
        Me.SdaOperaciones.SelectCommand = Me.SqlSelectCommand3
        Me.SdaOperaciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "transacciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("transaccion", "transaccion"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("tabla", "tabla"), New System.Data.Common.DataColumnMapping("campo_id", "campo_id"), New System.Data.Common.DataColumnMapping("serie", "serie")})})
        '
        'CmdOpeInventario
        '
        Me.CmdOpeInventario.CommandText = "INSERT INTO operaciones_inventario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         (folio, transaccion," &
    " fecha, usuario, status)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES        (@folio,@transaccion,@fecha,@usuario,@st" &
    "atus)"
        Me.CmdOpeInventario.Connection = Me.SqlCnn1
        Me.CmdOpeInventario.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, "folio"), New System.Data.SqlClient.SqlParameter("@transaccion", System.Data.SqlDbType.[Char], 10, "transaccion"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.SmallDateTime, 4, "fecha"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 1, "status")})
        '
        'CmdActOpeInventario
        '
        Me.CmdActOpeInventario.CommandText = "UPDATE       operaciones_inventario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                usuario = @usuario, statu" &
    "s = @status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (folio = @folio) AND (transaccion = @trans)"
        Me.CmdActOpeInventario.Connection = Me.SqlCnn1
        Me.CmdActOpeInventario.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 1, "status"), New System.Data.SqlClient.SqlParameter("@folio", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "folio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@trans", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "transaccion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'FI002
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MToolBar1)
        Me.Name = "FI002"
        Me.Text = "Operaciones inventario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FI002, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyNumCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MToolBar1 As WindowsControlLibrary1.MToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbOpe As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MyNumCant As MyControls.MyNumeric
    Friend WithEvents TxtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents MyDataGrid1 As MyControls.MyDataGrid
    Friend WithEvents SqlCnn1 As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SdaMOpeInventario As SqlClient.SqlDataAdapter
    Friend WithEvents DvArticulos As DataView
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SdaStatus As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FI002 As DS_FI002
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents SdaOperaciones As SqlClient.SqlDataAdapter
    Friend WithEvents CmdOpeInventario As SqlClient.SqlCommand
    Friend WithEvents CmdActOpeInventario As SqlClient.SqlCommand
    Friend WithEvents ToolTip1 As ToolTip
End Class
