<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FI003
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FI003))
        Me.MT_reportes1 = New WindowsControlLibrary1.MT_reportes()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDescArt = New System.Windows.Forms.TextBox()
        Me.TxtArt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkFActual = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpA = New System.Windows.Forms.DateTimePicker()
        Me.DtpDe = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.imgArticulo = New System.Windows.Forms.PictureBox()
        Me.MyDataGrid1 = New MyControls.MyDataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Sqlcnn1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SdaInventarioArticulos = New System.Data.SqlClient.SqlDataAdapter()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DvArticulos = New System.Data.DataView()
        Me.DS_FI003 = New RYCSEM.DS_FI003()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FI003, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MT_reportes1.Size = New System.Drawing.Size(1008, 50)
        Me.MT_reportes1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDescArt)
        Me.GroupBox1.Controls.Add(Me.TxtArt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ChkFActual)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DtpA)
        Me.GroupBox1.Controls.Add(Me.DtpDe)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 84)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'TxtDescArt
        '
        Me.TxtDescArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescArt.Location = New System.Drawing.Point(173, 49)
        Me.TxtDescArt.Name = "TxtDescArt"
        Me.TxtDescArt.ReadOnly = True
        Me.TxtDescArt.Size = New System.Drawing.Size(219, 26)
        Me.TxtDescArt.TabIndex = 7
        '
        'TxtArt
        '
        Me.TxtArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArt.Location = New System.Drawing.Point(85, 49)
        Me.TxtArt.Name = "TxtArt"
        Me.TxtArt.Size = New System.Drawing.Size(82, 26)
        Me.TxtArt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Artículo"
        '
        'ChkFActual
        '
        Me.ChkFActual.AutoSize = True
        Me.ChkFActual.Checked = True
        Me.ChkFActual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFActual.Location = New System.Drawing.Point(396, 17)
        Me.ChkFActual.Name = "ChkFActual"
        Me.ChkFActual.Size = New System.Drawing.Size(79, 24)
        Me.ChkFActual.TabIndex = 4
        Me.ChkFActual.Text = "Actual"
        Me.ToolTip1.SetToolTip(Me.ChkFActual, "Mostrar inventario al día de hoy.")
        Me.ChkFActual.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "De"
        '
        'DtpA
        '
        Me.DtpA.CustomFormat = "dd/MMM/yyyy"
        Me.DtpA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpA.Location = New System.Drawing.Point(255, 16)
        Me.DtpA.Name = "DtpA"
        Me.DtpA.Size = New System.Drawing.Size(137, 26)
        Me.DtpA.TabIndex = 1
        '
        'DtpDe
        '
        Me.DtpDe.CustomFormat = "dd/MMM/yyyy"
        Me.DtpDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpDe.Location = New System.Drawing.Point(85, 16)
        Me.DtpDe.Name = "DtpDe"
        Me.DtpDe.Size = New System.Drawing.Size(137, 26)
        Me.DtpDe.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.imgArticulo)
        Me.GroupBox2.Controls.Add(Me.MyDataGrid1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 587)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'imgArticulo
        '
        Me.imgArticulo.BackColor = System.Drawing.Color.White
        Me.imgArticulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgArticulo.Location = New System.Drawing.Point(809, 16)
        Me.imgArticulo.Name = "imgArticulo"
        Me.imgArticulo.Size = New System.Drawing.Size(196, 568)
        Me.imgArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgArticulo.TabIndex = 471
        Me.imgArticulo.TabStop = False
        '
        'MyDataGrid1
        '
        Me.MyDataGrid1.CaptionText = "Artículos"
        Me.MyDataGrid1.DataMember = ""
        Me.MyDataGrid1.DataSource = Me.DvArticulos
        Me.MyDataGrid1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MyDataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MyDataGrid1.Location = New System.Drawing.Point(3, 16)
        Me.MyDataGrid1.Name = "MyDataGrid1"
        Me.MyDataGrid1.Portapapeles = True
        Me.MyDataGrid1.Size = New System.Drawing.Size(806, 568)
        Me.MyDataGrid1.TabIndex = 0
        Me.MyDataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.MyDataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
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
        Me.DataGridTextBoxColumn3.Format = "#,##0"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Existencia."
        Me.DataGridTextBoxColumn3.MappingName = "existencia"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "#,##0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Precio."
        Me.DataGridTextBoxColumn4.MappingName = "precio"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'Sqlcnn1
        '
        Me.Sqlcnn1.ConnectionString = "Data Source=LUNA;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa;Pas" &
    "sword=rycsem2017"
        Me.Sqlcnn1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "dbo.FI003_Datos"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.Sqlcnn1
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Art", System.Data.SqlDbType.[Char], 10), New System.Data.SqlClient.SqlParameter("@FI", System.Data.SqlDbType.SmallDateTime, 4), New System.Data.SqlClient.SqlParameter("@FF", System.Data.SqlDbType.SmallDateTime, 4), New System.Data.SqlClient.SqlParameter("@Filtro", System.Data.SqlDbType.VarChar, 200), New System.Data.SqlClient.SqlParameter("@Actual", System.Data.SqlDbType.Bit, 1)})
        '
        'SdaInventarioArticulos
        '
        Me.SdaInventarioArticulos.SelectCommand = Me.SqlSelectCommand1
        Me.SdaInventarioArticulos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "articulos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_art", "cod_art"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("existencia", "existencia"), New System.Data.Common.DataColumnMapping("precio", "precio")})})
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(63, 7)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(44, 40)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.Location = New System.Drawing.Point(13, 7)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(44, 40)
        Me.btnRefrescar.TabIndex = 7
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Observaciones"
        Me.DataGridTextBoxColumn5.MappingName = "observaciones"
        Me.DataGridTextBoxColumn5.Width = 350
        '
        'DvArticulos
        '
        Me.DvArticulos.AllowEdit = False
        Me.DvArticulos.AllowNew = False
        Me.DvArticulos.Table = Me.DS_FI003.articulos
        '
        'DS_FI003
        '
        Me.DS_FI003.DataSetName = "DS_FI003"
        Me.DS_FI003.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FI003
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MT_reportes1)
        Me.Name = "FI003"
        Me.Text = "Consulta de inventario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FI003, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MT_reportes1 As WindowsControlLibrary1.MT_reportes
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MyDataGrid1 As MyControls.MyDataGrid
    Friend WithEvents TxtDescArt As TextBox
    Friend WithEvents TxtArt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ChkFActual As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpA As DateTimePicker
    Friend WithEvents DtpDe As DateTimePicker
    Friend WithEvents Sqlcnn1 As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SdaInventarioArticulos As SqlClient.SqlDataAdapter
    Friend WithEvents DvArticulos As DataView
    Friend WithEvents DS_FI003 As DS_FI003
    Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As DataGridTextBoxColumn
    Friend WithEvents imgArticulo As PictureBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents DataGridTextBoxColumn5 As DataGridTextBoxColumn
End Class
