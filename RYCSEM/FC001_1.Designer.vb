<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FC001_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FC001_1))
        Me.MToolBar1 = New WindowsControlLibrary1.MToolBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodCte = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.dvReferencias = New System.Data.DataView()
        Me.DS_FC001_1 = New RYCSEM.DS_FC001_1()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCod_Ref = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgReferencias = New MyControls.MyDataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sdaReferencias = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaStatus = New System.Data.SqlClient.SqlDataAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dvReferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FC001_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReferencias, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MToolBar1.BImprimirVisible = False
        Me.MToolBar1.BmodificarVisible = True
        Me.MToolBar1.BNotasVisible = False
        Me.MToolBar1.BNuevoVisible = True
        Me.MToolBar1.BPrimeroVisible = False
        Me.MToolBar1.BRefreshVisible = True
        Me.MToolBar1.BSep1Visible = True
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
        Me.MToolBar1.Size = New System.Drawing.Size(584, 28)
        Me.MToolBar1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodCte)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbStatus)
        Me.GroupBox1.Controls.Add(Me.chkCliente)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCod_Ref)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 94)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtCodCte
        '
        Me.txtCodCte.Location = New System.Drawing.Point(215, 12)
        Me.txtCodCte.Name = "txtCodCte"
        Me.txtCodCte.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCte.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvReferencias, "status", True))
        Me.cbStatus.DataSource = Me.DS_FC001_1
        Me.cbStatus.DisplayMember = "status.descripcion"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(369, 59)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 7
        Me.cbStatus.ValueMember = "status.status"
        '
        'dvReferencias
        '
        Me.dvReferencias.AllowNew = False
        Me.dvReferencias.Table = Me.DS_FC001_1.refencia_clientes
        '
        'DS_FC001_1
        '
        Me.DS_FC001_1.DataSetName = "DS_FC001_1"
        Me.DS_FC001_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.dvReferencias, "cliente", True))
        Me.chkCliente.Location = New System.Drawing.Point(257, 61)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(58, 17)
        Me.chkCliente.TabIndex = 6
        Me.chkCliente.Text = "Cliente"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvReferencias, "telefono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(79, 59)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(162, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefono"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvReferencias, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(79, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(411, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtCod_Ref
        '
        Me.txtCod_Ref.Location = New System.Drawing.Point(79, 12)
        Me.txtCod_Ref.Name = "txtCod_Ref"
        Me.txtCod_Ref.Size = New System.Drawing.Size(80, 20)
        Me.txtCod_Ref.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Referencia"
        '
        'dgReferencias
        '
        Me.dgReferencias.CaptionText = "Referencia de cliente"
        Me.dgReferencias.DataMember = ""
        Me.dgReferencias.DataSource = Me.dvReferencias
        Me.dgReferencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReferencias.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgReferencias.Location = New System.Drawing.Point(0, 122)
        Me.dgReferencias.Name = "dgReferencias"
        Me.dgReferencias.Portapapeles = True
        Me.dgReferencias.Size = New System.Drawing.Size(584, 239)
        Me.dgReferencias.TabIndex = 3
        Me.dgReferencias.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgReferencias
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn5, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "refencia_clientes"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Referencia"
        Me.DataGridTextBoxColumn1.MappingName = "cod_ref"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn3.MappingName = "nombre"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Teléfono"
        Me.DataGridTextBoxColumn5.MappingName = "telefono"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridBoolColumn1.HeaderText = "Cliente"
        Me.DataGridBoolColumn1.MappingName = "cliente"
        Me.DataGridBoolColumn1.NullText = "false"
        Me.DataGridBoolColumn1.NullValue = "false"
        Me.DataGridBoolColumn1.Width = 60
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Status"
        Me.DataGridTextBoxColumn6.MappingName = "status"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        cod_ref, cod_cte, nombre, telefono, cliente, status, usuario, cod_c" &
    "teRef" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            refencia_clientes WITH (NOLOCK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (cod_cte = " &
    "@cod_cte)"
        Me.SqlSelectCommand1.CommandTimeout = 99999999
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.Int, 4, "cod_cte")})
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_ref", System.Data.SqlDbType.Int, 4, "cod_ref"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.Int, 4, "cod_cte"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 350, "nombre"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 15, "telefono"), New System.Data.SqlClient.SqlParameter("@cliente", System.Data.SqlDbType.Bit, 1, "cliente"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3, "status"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@cod_cteRef", System.Data.SqlDbType.Int, 4, "cod_cteRef")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.CommandTimeout = 999999999
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_ref", System.Data.SqlDbType.Int, 4, "cod_ref"), New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.Int, 4, "cod_cte"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 350, "nombre"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 15, "telefono"), New System.Data.SqlClient.SqlParameter("@cliente", System.Data.SqlDbType.Bit, 1, "cliente"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 3, "status"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@cod_cteRef", System.Data.SqlDbType.Int, 4, "cod_cteRef"), New System.Data.SqlClient.SqlParameter("@Original_cod_ref", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_ref", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [refencia_clientes] WHERE (([cod_ref] = @Original_cod_ref))"
        Me.SqlDeleteCommand1.CommandTimeout = 9999
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cod_ref", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_ref", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sdaReferencias
        '
        Me.sdaReferencias.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaReferencias.InsertCommand = Me.SqlInsertCommand1
        Me.sdaReferencias.SelectCommand = Me.SqlSelectCommand1
        Me.sdaReferencias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "refencia_clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_ref", "cod_ref"), New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("ap_paterno", "ap_paterno"), New System.Data.Common.DataColumnMapping("ap_materno", "ap_materno"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("cliente", "cliente")})})
        Me.sdaReferencias.UpdateCommand = Me.SqlUpdateCommand1
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
        'FC001_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.dgReferencias)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MToolBar1)
        Me.Name = "FC001_1"
        Me.Text = "Referencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dvReferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FC001_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MToolBar1 As WindowsControlLibrary1.MToolBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCod_Ref As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgReferencias As MyControls.MyDataGrid
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents sdaReferencias As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FC001_1 As DS_FC001_1
    Friend WithEvents dvReferencias As DataView
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaStatus As SqlClient.SqlDataAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn6 As DataGridTextBoxColumn
    Friend WithEvents txtCodCte As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
