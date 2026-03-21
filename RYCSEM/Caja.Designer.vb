<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caja))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.DS_FCaja = New RYCSEM.DS_FCaja()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numFondo = New MyControls.MyNumeric()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.sdaUsuario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlNuevoTurno = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DS_FCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbUsuario)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.numFondo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 306)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caja"
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DataSource = Me.DS_FCaja
        Me.cmbUsuario.DisplayMember = "usuarios.nombre"
        Me.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(159, 115)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(349, 45)
        Me.cmbUsuario.TabIndex = 6
        Me.cmbUsuario.ValueMember = "usuarios.usuario"
        '
        'DS_FCaja
        '
        Me.DS_FCaja.DataSetName = "DS_FCaja"
        Me.DS_FCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(391, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 55)
        Me.Button2.TabIndex = 5
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fondo $"
        '
        'numFondo
        '
        Me.numFondo.DecimalPlaces = 2
        Me.numFondo.Location = New System.Drawing.Point(159, 176)
        Me.numFondo.Maximum = New Decimal(New Integer() {-559939585, 902409669, 54, 0})
        Me.numFondo.Minimum = New Decimal(New Integer() {-559939585, 902409669, 54, -2147483648})
        Me.numFondo.Name = "numFondo"
        Me.numFondo.Size = New System.Drawing.Size(198, 45)
        Me.numFondo.TabIndex = 3
        Me.numFondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numFondo.ThousandsSeparator = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Caja 1", ""})
        Me.ComboBox1.Location = New System.Drawing.Point(159, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 46)
        Me.ComboBox1.TabIndex = 0
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
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=SA" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlNuevoTurno
        '
        Me.SqlNuevoTurno.CommandText = "INSERT INTO turnos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         (usuario, fecha_inicial, fecha_final" &
    ", monto, activo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES        (@usuario,@fecha_inicial,@fecha_final,@monto,@ac" &
    "tivo)"
        Me.SqlNuevoTurno.Connection = Me.sqlConn
        Me.SqlNuevoTurno.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, "usuario"), New System.Data.SqlClient.SqlParameter("@fecha_inicial", System.Data.SqlDbType.DateTime, 8, "fecha_inicial"), New System.Data.SqlClient.SqlParameter("@fecha_final", System.Data.SqlDbType.DateTime, 8, "fecha_final"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@activo", System.Data.SqlDbType.Bit, 1, "activo")})
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 306)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DS_FCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numFondo As MyControls.MyNumeric
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbUsuario As ComboBox
    Friend WithEvents sdaUsuario As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents DS_FCaja As DS_FCaja
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents SqlNuevoTurno As SqlClient.SqlCommand
End Class
