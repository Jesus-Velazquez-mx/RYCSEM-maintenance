<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBuscador
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
        Me.MT_reportes1 = New WindowsControlLibrary1.MT_reportes()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MyDataGrid1 = New MyControls.MyDataGrid()
        Me.DvDatos = New System.Data.DataView()
        Me.DS_Buscador = New RYCSEM.DS_Buscador()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.ColCodigo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ColNombre = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ColFecha = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ColMonto = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ColCantidad = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SqlCnn = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SdaDatos = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.MT_reportes1.BRefreshVisible = True
        Me.MT_reportes1.BSep1Visible = False
        Me.MT_reportes1.BSep2Visible = False
        Me.MT_reportes1.BSep3Visible = False
        Me.MT_reportes1.BSep4Visible = False
        Me.MT_reportes1.Bsep5visible = False
        Me.MT_reportes1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MT_reportes1.Location = New System.Drawing.Point(0, 0)
        Me.MT_reportes1.Name = "MT_reportes1"
        Me.MT_reportes1.Size = New System.Drawing.Size(546, 20)
        Me.MT_reportes1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MyDataGrid1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 348)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'MyDataGrid1
        '
        Me.MyDataGrid1.DataMember = ""
        Me.MyDataGrid1.DataSource = Me.DvDatos
        Me.MyDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MyDataGrid1.Location = New System.Drawing.Point(3, 16)
        Me.MyDataGrid1.Name = "MyDataGrid1"
        Me.MyDataGrid1.Portapapeles = True
        Me.MyDataGrid1.ReadOnly = True
        Me.MyDataGrid1.Size = New System.Drawing.Size(540, 329)
        Me.MyDataGrid1.TabIndex = 0
        Me.MyDataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DvDatos
        '
        Me.DvDatos.AllowNew = False
        Me.DvDatos.Table = Me.DS_Buscador.datos
        '
        'DS_Buscador
        '
        Me.DS_Buscador.DataSetName = "DS_Buscador"
        Me.DS_Buscador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.MyDataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ColCodigo, Me.ColNombre, Me.ColFecha, Me.ColMonto, Me.ColCantidad, Me.ColStatus})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "datos"
        '
        'ColCodigo
        '
        Me.ColCodigo.Format = ""
        Me.ColCodigo.FormatInfo = Nothing
        Me.ColCodigo.HeaderText = "Código"
        Me.ColCodigo.MappingName = "codigo"
        Me.ColCodigo.Width = 75
        '
        'ColNombre
        '
        Me.ColNombre.Format = ""
        Me.ColNombre.FormatInfo = Nothing
        Me.ColNombre.HeaderText = "Nombre"
        Me.ColNombre.MappingName = "nombre"
        Me.ColNombre.Width = 200
        '
        'ColFecha
        '
        Me.ColFecha.Format = "dd/MM/yyyy"
        Me.ColFecha.FormatInfo = Nothing
        Me.ColFecha.HeaderText = "Fecha"
        Me.ColFecha.MappingName = "fecha"
        Me.ColFecha.Width = 75
        '
        'ColMonto
        '
        Me.ColMonto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColMonto.Format = "#,##0.00"
        Me.ColMonto.FormatInfo = Nothing
        Me.ColMonto.HeaderText = "Monto. "
        Me.ColMonto.MappingName = "monto"
        Me.ColMonto.Width = 75
        '
        'ColCantidad
        '
        Me.ColCantidad.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColCantidad.Format = "N2"
        Me.ColCantidad.FormatInfo = Nothing
        Me.ColCantidad.HeaderText = "Cantidad."
        Me.ColCantidad.MappingName = "cantidad"
        Me.ColCantidad.Width = 75
        '
        'ColStatus
        '
        Me.ColStatus.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColStatus.Format = ""
        Me.ColStatus.FormatInfo = Nothing
        Me.ColStatus.HeaderText = "Status"
        Me.ColStatus.MappingName = "status"
        Me.ColStatus.Width = 75
        '
        'SqlCnn
        '
        Me.SqlCnn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=SA" &
    ";Password=luna"
        Me.SqlCnn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "dbo.Buscador"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlCnn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Tabla", System.Data.SqlDbType.VarChar, 30), New System.Data.SqlClient.SqlParameter("@Filtro", System.Data.SqlDbType.VarChar, 2147483647)})
        '
        'SdaDatos
        '
        Me.SdaDatos.SelectCommand = Me.SqlSelectCommand1
        Me.SdaDatos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "datos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("codigo", "codigo"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("visible_f", "visible_f"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("visible_m", "visible_m"), New System.Data.Common.DataColumnMapping("status", "status")}), New System.Data.Common.DataTableMapping("Table1", "columnas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("columna", "columna"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'txtFiltro
        '
        Me.txtFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFiltro.Location = New System.Drawing.Point(3, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(540, 20)
        Me.txtFiltro.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFiltro)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 44)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'FBuscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 412)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MT_reportes1)
        Me.Name = "FBuscador"
        Me.Text = "Buscador"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MT_reportes1 As WindowsControlLibrary1.MT_reportes
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MyDataGrid1 As MyControls.MyDataGrid
    Friend WithEvents DvDatos As DataView
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents ColCodigo As DataGridTextBoxColumn
    Friend WithEvents ColNombre As DataGridTextBoxColumn
    Friend WithEvents ColFecha As DataGridTextBoxColumn
    Friend WithEvents ColMonto As DataGridTextBoxColumn
    Friend WithEvents ColStatus As DataGridTextBoxColumn
    Friend WithEvents SqlCnn As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SdaDatos As SqlClient.SqlDataAdapter
    Friend WithEvents DS_Buscador As DS_Buscador
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ColCantidad As DataGridTextBoxColumn
End Class
