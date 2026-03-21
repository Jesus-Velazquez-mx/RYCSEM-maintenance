<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FInicio))
        Me.DS_FInicio = New RYCSEM.DS_FInicio()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.sdaUsuario = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaLogin = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlUpdateContra = New System.Data.SqlClient.SqlCommand()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DS_FInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DS_FInicio
        '
        Me.DS_FInicio.DataSetName = "DS_FInicio"
        Me.DS_FInicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        usuario, nombre + ' ' + ap_paterno + ' ' + ap_Materno AS nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FR" &
    "OM            usuarios WITH (NOLOCK)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (usuario = @user)"
        Me.SqlSelectCommand1.CommandTimeout = 999999
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@user", System.Data.SqlDbType.[Char], 10, "usuario")})
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
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "dbo.Login"
        Me.SqlSelectCommand2.CommandTimeout = 99999
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 5), New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.VarChar, 10)})
        '
        'sdaLogin
        '
        Me.sdaLogin.SelectCommand = Me.SqlSelectCommand2
        Me.sdaLogin.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Login", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'sqlUpdateContra
        '
        Me.sqlUpdateContra.CommandText = "UPDATE       usuarios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                contrasena = @contrasena" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        " &
    "(usuario = @usuario)"
        Me.sqlUpdateContra.CommandTimeout = 9999
        Me.sqlUpdateContra.Connection = Me.sqlConn
        Me.sqlUpdateContra.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@contrasena", System.Data.SqlDbType.VarChar, 20, "contrasena"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.[Char], 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnClientes)
        Me.gbOpciones.Controls.Add(Me.btnProveedores)
        Me.gbOpciones.Controls.Add(Me.btnVentas)
        Me.gbOpciones.Controls.Add(Me.btnInventario)
        Me.gbOpciones.Location = New System.Drawing.Point(12, 19)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(319, 261)
        Me.gbOpciones.TabIndex = 24
        Me.gbOpciones.TabStop = False
        '
        'btnClientes
        '
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.Location = New System.Drawing.Point(19, 36)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(135, 90)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProveedores.Location = New System.Drawing.Point(166, 144)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(135, 90)
        Me.btnProveedores.TabIndex = 3
        Me.btnProveedores.Text = "Reporte ventas"
        Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Image = Global.RYCSEM.My.Resources.Resources.ventas
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVentas.Location = New System.Drawing.Point(19, 144)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(135, 90)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "POS"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.Image = Global.RYCSEM.My.Resources.Resources.inventario
        Me.btnInventario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInventario.Location = New System.Drawing.Point(166, 36)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(135, 90)
        Me.btnInventario.TabIndex = 1
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbOpciones)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 293)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'FInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 293)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RYCSEM"
        CType(Me.DS_FInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents sdaUsuario As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FInicio As DS_FInicio
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaLogin As SqlClient.SqlDataAdapter
    Friend WithEvents sqlUpdateContra As SqlClient.SqlCommand
    Friend WithEvents gbOpciones As GroupBox
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
