<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FC001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FC001))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCodCte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.dvClientes = New System.Data.DataView()
        Me.DS_FC001 = New RYCSEM.DS_FC001()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApPat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApMat = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgDireccion = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.txtCalleEntre2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCalleEntre1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gpDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.btnReferencias = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.sdaClientes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sdaStatus = New System.Data.SqlClient.SqlDataAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.CodcteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonsocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RfcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApmaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CallenumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calleentre1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calleentre2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodpostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionCompletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.dvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FC001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dgDireccion.SuspendLayout()
        Me.gpDatosGenerales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodCte
        '
        Me.txtCodCte.Location = New System.Drawing.Point(96, 23)
        Me.txtCodCte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodCte.Name = "txtCodCte"
        Me.txtCodCte.Size = New System.Drawing.Size(132, 22)
        Me.txtCodCte.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "razon_social", True))
        Me.txtRazonSocial.Location = New System.Drawing.Point(339, 23)
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(533, 22)
        Me.txtRazonSocial.TabIndex = 2
        '
        'dvClientes
        '
        Me.dvClientes.AllowNew = False
        Me.dvClientes.Table = Me.DS_FC001.clientes
        '
        'DS_FC001
        '
        Me.DS_FC001.DataSetName = "DS_FC001"
        Me.DS_FC001.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Razón Social"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(96, 55)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(591, 22)
        Me.txtNombre.TabIndex = 3
        '
        'txtRFC
        '
        Me.txtRFC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "rfc", True))
        Me.txtRFC.Location = New System.Drawing.Point(740, 55)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRFC.MaxLength = 15
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(132, 22)
        Me.txtRFC.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(695, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RFC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apellido P."
        '
        'txtApPat
        '
        Me.txtApPat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "ap_paterno", True))
        Me.txtApPat.Location = New System.Drawing.Point(96, 87)
        Me.txtApPat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApPat.Name = "txtApPat"
        Me.txtApPat.Size = New System.Drawing.Size(319, 22)
        Me.txtApPat.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(432, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Apellido M."
        '
        'txtApMat
        '
        Me.txtApMat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "ap_materno", True))
        Me.txtApMat.Location = New System.Drawing.Point(516, 87)
        Me.txtApMat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApMat.Name = "txtApMat"
        Me.txtApMat.Size = New System.Drawing.Size(356, 22)
        Me.txtApMat.TabIndex = 6
        '
        'txtCalle
        '
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "calle", True))
        Me.txtCalle.Location = New System.Drawing.Point(81, 23)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(543, 22)
        Me.txtCalle.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Calle"
        '
        'txtNum
        '
        Me.txtNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "calle_num", True))
        Me.txtNum.Location = New System.Drawing.Point(679, 23)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(132, 22)
        Me.txtNum.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(629, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Num."
        '
        'txtColonia
        '
        Me.txtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "colonia", True))
        Me.txtColonia.Location = New System.Drawing.Point(81, 92)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(460, 22)
        Me.txtColonia.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 97)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Colonia"
        '
        'dgDireccion
        '
        Me.dgDireccion.Controls.Add(Me.Label12)
        Me.dgDireccion.Controls.Add(Me.txtCodPostal)
        Me.dgDireccion.Controls.Add(Me.txtCalleEntre2)
        Me.dgDireccion.Controls.Add(Me.Label11)
        Me.dgDireccion.Controls.Add(Me.txtCalleEntre1)
        Me.dgDireccion.Controls.Add(Me.Label10)
        Me.dgDireccion.Controls.Add(Me.txtCalle)
        Me.dgDireccion.Controls.Add(Me.txtColonia)
        Me.dgDireccion.Controls.Add(Me.Label7)
        Me.dgDireccion.Controls.Add(Me.Label9)
        Me.dgDireccion.Controls.Add(Me.Label8)
        Me.dgDireccion.Controls.Add(Me.txtNum)
        Me.dgDireccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgDireccion.Location = New System.Drawing.Point(0, 252)
        Me.dgDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgDireccion.Name = "dgDireccion"
        Me.dgDireccion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgDireccion.Size = New System.Drawing.Size(1344, 140)
        Me.dgDireccion.TabIndex = 18
        Me.dgDireccion.TabStop = False
        Me.dgDireccion.Text = "Dirección"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(556, 97)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Cod. Postal"
        '
        'txtCodPostal
        '
        Me.txtCodPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "cod_postal", True))
        Me.txtCodPostal.Location = New System.Drawing.Point(645, 92)
        Me.txtCodPostal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(165, 22)
        Me.txtCodPostal.TabIndex = 17
        '
        'txtCalleEntre2
        '
        Me.txtCalleEntre2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "calle_entre2", True))
        Me.txtCalleEntre2.Location = New System.Drawing.Point(460, 55)
        Me.txtCalleEntre2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCalleEntre2.Name = "txtCalleEntre2"
        Me.txtCalleEntre2.Size = New System.Drawing.Size(351, 22)
        Me.txtCalleEntre2.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(433, 60)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Y"
        '
        'txtCalleEntre1
        '
        Me.txtCalleEntre1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "calle_entre1", True))
        Me.txtCalleEntre1.Location = New System.Drawing.Point(81, 55)
        Me.txtCalleEntre1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCalleEntre1.Name = "txtCalleEntre1"
        Me.txtCalleEntre1.Size = New System.Drawing.Size(339, 22)
        Me.txtCalleEntre1.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 60)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Entre"
        '
        'txtTel1
        '
        Me.txtTel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "telefono", True))
        Me.txtTel1.Location = New System.Drawing.Point(97, 119)
        Me.txtTel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(203, 22)
        Me.txtTel1.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 124)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Telefono"
        '
        'txtCel
        '
        Me.txtCel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "celular", True))
        Me.txtCel.Location = New System.Drawing.Point(97, 150)
        Me.txtCel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(203, 22)
        Me.txtCel.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(37, 155)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 16)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Celular"
        '
        'txtExt
        '
        Me.txtExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "extension", True))
        Me.txtExt.Location = New System.Drawing.Point(340, 119)
        Me.txtExt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(75, 22)
        Me.txtExt.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(309, 124)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 16)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Ext"
        '
        'txtTel2
        '
        Me.txtTel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dvClientes, "telefono2", True))
        Me.txtTel2.Location = New System.Drawing.Point(515, 119)
        Me.txtTel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(203, 22)
        Me.txtTel2.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(429, 124)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 16)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Telefono 2"
        '
        'gpDatosGenerales
        '
        Me.gpDatosGenerales.Controls.Add(Me.btnReferencias)
        Me.gpDatosGenerales.Controls.Add(Me.Label17)
        Me.gpDatosGenerales.Controls.Add(Me.cbStatus)
        Me.gpDatosGenerales.Controls.Add(Me.txtCodCte)
        Me.gpDatosGenerales.Controls.Add(Me.Label1)
        Me.gpDatosGenerales.Controls.Add(Me.txtRazonSocial)
        Me.gpDatosGenerales.Controls.Add(Me.txtTel2)
        Me.gpDatosGenerales.Controls.Add(Me.Label2)
        Me.gpDatosGenerales.Controls.Add(Me.Label16)
        Me.gpDatosGenerales.Controls.Add(Me.txtNombre)
        Me.gpDatosGenerales.Controls.Add(Me.Label15)
        Me.gpDatosGenerales.Controls.Add(Me.Label3)
        Me.gpDatosGenerales.Controls.Add(Me.txtExt)
        Me.gpDatosGenerales.Controls.Add(Me.txtRFC)
        Me.gpDatosGenerales.Controls.Add(Me.txtCel)
        Me.gpDatosGenerales.Controls.Add(Me.Label4)
        Me.gpDatosGenerales.Controls.Add(Me.Label14)
        Me.gpDatosGenerales.Controls.Add(Me.txtApPat)
        Me.gpDatosGenerales.Controls.Add(Me.txtTel1)
        Me.gpDatosGenerales.Controls.Add(Me.Label5)
        Me.gpDatosGenerales.Controls.Add(Me.Label13)
        Me.gpDatosGenerales.Controls.Add(Me.txtApMat)
        Me.gpDatosGenerales.Controls.Add(Me.Label6)
        Me.gpDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpDatosGenerales.Location = New System.Drawing.Point(0, 69)
        Me.gpDatosGenerales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpDatosGenerales.Name = "gpDatosGenerales"
        Me.gpDatosGenerales.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpDatosGenerales.Size = New System.Drawing.Size(1344, 183)
        Me.gpDatosGenerales.TabIndex = 37
        Me.gpDatosGenerales.TabStop = False
        Me.gpDatosGenerales.Text = "Datos generales"
        '
        'btnReferencias
        '
        Me.btnReferencias.Location = New System.Drawing.Point(740, 149)
        Me.btnReferencias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReferencias.Name = "btnReferencias"
        Me.btnReferencias.Size = New System.Drawing.Size(133, 28)
        Me.btnReferencias.TabIndex = 34
        Me.btnReferencias.Text = "Referencias"
        Me.btnReferencias.UseVisualStyleBackColor = True
        Me.btnReferencias.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(456, 155)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 16)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dvClientes, "status", True))
        Me.cbStatus.DataSource = Me.DS_FC001
        Me.cbStatus.DisplayMember = "status.descripcion"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(516, 150)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(160, 24)
        Me.cbStatus.TabIndex = 11
        Me.cbStatus.ValueMember = "status.status"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.CommandTimeout = 99999
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=ASUS10137\PERSONALSERVER;Initial Catalog=RYCSEM;Persist Security Info" &
    "=True;User ID=sa;Password=Jesu2016;TrustServerCertificate=True"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'sdaClientes
        '
        Me.sdaClientes.DeleteCommand = Me.SqlDeleteCommand
        Me.sdaClientes.InsertCommand = Me.SqlInsertCommand
        Me.sdaClientes.SelectCommand = Me.SqlSelectCommand1
        Me.sdaClientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_cte", "cod_cte"), New System.Data.Common.DataColumnMapping("razon_social", "razon_social"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("rfc", "rfc"), New System.Data.Common.DataColumnMapping("ap_paterno", "ap_paterno"), New System.Data.Common.DataColumnMapping("ap_materno", "ap_materno"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("extension", "extension"), New System.Data.Common.DataColumnMapping("telefono2", "telefono2"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("calle", "calle"), New System.Data.Common.DataColumnMapping("calle_num", "calle_num"), New System.Data.Common.DataColumnMapping("calle_entre1", "calle_entre1"), New System.Data.Common.DataColumnMapping("calle_entre2", "calle_entre2"), New System.Data.Common.DataColumnMapping("colonia", "colonia"), New System.Data.Common.DataColumnMapping("cod_postal", "cod_postal"), New System.Data.Common.DataColumnMapping("status", "status"), New System.Data.Common.DataColumnMapping("direccionCompleta", "direccionCompleta"), New System.Data.Common.DataColumnMapping("nombreCompleto", "nombreCompleto"), New System.Data.Common.DataColumnMapping("usuario", "usuario")})})
        Me.sdaClientes.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
        Me.SqlDeleteCommand.Connection = Me.sqlConn
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cod_cte", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_cte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_razon_social", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "razon_social", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_razon_social", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "razon_social", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_rfc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "rfc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_rfc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "rfc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ap_paterno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ap_paterno", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ap_paterno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ap_paterno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ap_materno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ap_materno", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ap_materno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ap_materno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_extension", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "extension", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_extension", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono2", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_calle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "calle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_calle", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_calle_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "calle_num", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_calle_num", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calle_num", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_calle_entre1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "calle_entre1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_calle_entre1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calle_entre1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_calle_entre2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "calle_entre2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_calle_entre2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calle_entre2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_colonia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cod_postal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cod_postal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cod_postal", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_postal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_status", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "status", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.CommandTimeout = 999999
        Me.SqlInsertCommand.Connection = Me.sqlConn
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 0, "cod_cte"), New System.Data.SqlClient.SqlParameter("@razon_social", System.Data.SqlDbType.VarChar, 0, "razon_social"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@rfc", System.Data.SqlDbType.VarChar, 0, "rfc"), New System.Data.SqlClient.SqlParameter("@ap_paterno", System.Data.SqlDbType.VarChar, 0, "ap_paterno"), New System.Data.SqlClient.SqlParameter("@ap_materno", System.Data.SqlDbType.VarChar, 0, "ap_materno"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 0, "telefono"), New System.Data.SqlClient.SqlParameter("@extension", System.Data.SqlDbType.[Char], 0, "extension"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.[Char], 0, "telefono2"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.[Char], 0, "celular"), New System.Data.SqlClient.SqlParameter("@calle", System.Data.SqlDbType.VarChar, 0, "calle"), New System.Data.SqlClient.SqlParameter("@calle_num", System.Data.SqlDbType.[Char], 0, "calle_num"), New System.Data.SqlClient.SqlParameter("@calle_entre1", System.Data.SqlDbType.VarChar, 0, "calle_entre1"), New System.Data.SqlClient.SqlParameter("@calle_entre2", System.Data.SqlDbType.VarChar, 0, "calle_entre2"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.VarChar, 0, "colonia"), New System.Data.SqlClient.SqlParameter("@cod_postal", System.Data.SqlDbType.[Char], 0, "cod_postal"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status")})
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.CommandTimeout = 99999
        Me.SqlUpdateCommand.Connection = Me.sqlConn
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cod_cte", System.Data.SqlDbType.[Char], 0, "cod_cte"), New System.Data.SqlClient.SqlParameter("@razon_social", System.Data.SqlDbType.VarChar, 0, "razon_social"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@rfc", System.Data.SqlDbType.VarChar, 0, "rfc"), New System.Data.SqlClient.SqlParameter("@ap_paterno", System.Data.SqlDbType.VarChar, 0, "ap_paterno"), New System.Data.SqlClient.SqlParameter("@ap_materno", System.Data.SqlDbType.VarChar, 0, "ap_materno"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.[Char], 0, "telefono"), New System.Data.SqlClient.SqlParameter("@extension", System.Data.SqlDbType.[Char], 0, "extension"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.[Char], 0, "telefono2"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.[Char], 0, "celular"), New System.Data.SqlClient.SqlParameter("@calle", System.Data.SqlDbType.VarChar, 0, "calle"), New System.Data.SqlClient.SqlParameter("@calle_num", System.Data.SqlDbType.[Char], 0, "calle_num"), New System.Data.SqlClient.SqlParameter("@calle_entre1", System.Data.SqlDbType.VarChar, 0, "calle_entre1"), New System.Data.SqlClient.SqlParameter("@calle_entre2", System.Data.SqlDbType.VarChar, 0, "calle_entre2"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.VarChar, 0, "colonia"), New System.Data.SqlClient.SqlParameter("@cod_postal", System.Data.SqlDbType.[Char], 0, "cod_postal"), New System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.[Char], 0, "status"), New System.Data.SqlClient.SqlParameter("@Original_cod_cte", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_cte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_razon_social", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "razon_social", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_razon_social", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "razon_social", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_rfc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "rfc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_rfc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "rfc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ap_paterno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ap_paterno", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ap_paterno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ap_paterno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ap_materno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ap_materno", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ap_materno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ap_materno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_extension", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "extension", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_extension", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono2", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_calle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "calle", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_calle", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_calle_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "calle_num", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_calle_num", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calle_num", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_calle_entre1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "calle_entre1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_calle_entre1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calle_entre1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_calle_entre2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "calle_entre2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_calle_entre2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calle_entre2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_colonia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cod_postal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cod_postal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cod_postal", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_postal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "status", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_status", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "status", System.Data.DataRowVersion.Original, Nothing)})
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnDeshacer)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1344, 69)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(279, 12)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(59, 49)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnDeshacer
        '
        Me.btnDeshacer.Image = CType(resources.GetObject("btnDeshacer.Image"), System.Drawing.Image)
        Me.btnDeshacer.Location = New System.Drawing.Point(212, 12)
        Me.btnDeshacer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(59, 49)
        Me.btnDeshacer.TabIndex = 3
        Me.btnDeshacer.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(145, 12)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(59, 49)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(79, 12)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(59, 49)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(12, 12)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(59, 49)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dgClientes
        '
        Me.dgClientes.AutoGenerateColumns = False
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodcteDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.RazonsocialDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.RfcDataGridViewTextBoxColumn, Me.AppaternoDataGridViewTextBoxColumn, Me.ApmaternoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.ExtensionDataGridViewTextBoxColumn, Me.Telefono2DataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.CallenumDataGridViewTextBoxColumn, Me.Calleentre1DataGridViewTextBoxColumn, Me.Calleentre2DataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.CodpostalDataGridViewTextBoxColumn, Me.DireccionCompletaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.dgClientes.DataSource = Me.dvClientes
        Me.dgClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgClientes.Location = New System.Drawing.Point(4, 50)
        Me.dgClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.Size = New System.Drawing.Size(1336, 441)
        Me.dgClientes.TabIndex = 40
        '
        'CodcteDataGridViewTextBoxColumn
        '
        Me.CodcteDataGridViewTextBoxColumn.DataPropertyName = "cod_cte"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodcteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CodcteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.CodcteDataGridViewTextBoxColumn.Name = "CodcteDataGridViewTextBoxColumn"
        Me.CodcteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodcteDataGridViewTextBoxColumn.Width = 70
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "nombreCompleto"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreCompletoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre / Razón social"
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        Me.NombreCompletoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreCompletoDataGridViewTextBoxColumn.Width = 200
        '
        'RazonsocialDataGridViewTextBoxColumn
        '
        Me.RazonsocialDataGridViewTextBoxColumn.DataPropertyName = "razon_social"
        Me.RazonsocialDataGridViewTextBoxColumn.HeaderText = "Razón social"
        Me.RazonsocialDataGridViewTextBoxColumn.Name = "RazonsocialDataGridViewTextBoxColumn"
        Me.RazonsocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.RazonsocialDataGridViewTextBoxColumn.Visible = False
        Me.RazonsocialDataGridViewTextBoxColumn.Width = 190
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Visible = False
        Me.NombreDataGridViewTextBoxColumn.Width = 190
        '
        'RfcDataGridViewTextBoxColumn
        '
        Me.RfcDataGridViewTextBoxColumn.DataPropertyName = "rfc"
        Me.RfcDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RfcDataGridViewTextBoxColumn.Name = "RfcDataGridViewTextBoxColumn"
        Me.RfcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AppaternoDataGridViewTextBoxColumn
        '
        Me.AppaternoDataGridViewTextBoxColumn.DataPropertyName = "ap_paterno"
        Me.AppaternoDataGridViewTextBoxColumn.HeaderText = "ap_paterno"
        Me.AppaternoDataGridViewTextBoxColumn.Name = "AppaternoDataGridViewTextBoxColumn"
        Me.AppaternoDataGridViewTextBoxColumn.Visible = False
        '
        'ApmaternoDataGridViewTextBoxColumn
        '
        Me.ApmaternoDataGridViewTextBoxColumn.DataPropertyName = "ap_materno"
        Me.ApmaternoDataGridViewTextBoxColumn.HeaderText = "ap_materno"
        Me.ApmaternoDataGridViewTextBoxColumn.Name = "ApmaternoDataGridViewTextBoxColumn"
        Me.ApmaternoDataGridViewTextBoxColumn.Visible = False
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExtensionDataGridViewTextBoxColumn
        '
        Me.ExtensionDataGridViewTextBoxColumn.DataPropertyName = "extension"
        Me.ExtensionDataGridViewTextBoxColumn.HeaderText = "Ext."
        Me.ExtensionDataGridViewTextBoxColumn.Name = "ExtensionDataGridViewTextBoxColumn"
        Me.ExtensionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExtensionDataGridViewTextBoxColumn.Width = 50
        '
        'Telefono2DataGridViewTextBoxColumn
        '
        Me.Telefono2DataGridViewTextBoxColumn.DataPropertyName = "telefono2"
        Me.Telefono2DataGridViewTextBoxColumn.HeaderText = "telefono2"
        Me.Telefono2DataGridViewTextBoxColumn.Name = "Telefono2DataGridViewTextBoxColumn"
        Me.Telefono2DataGridViewTextBoxColumn.Visible = False
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.Visible = False
        '
        'CallenumDataGridViewTextBoxColumn
        '
        Me.CallenumDataGridViewTextBoxColumn.DataPropertyName = "calle_num"
        Me.CallenumDataGridViewTextBoxColumn.HeaderText = "calle_num"
        Me.CallenumDataGridViewTextBoxColumn.Name = "CallenumDataGridViewTextBoxColumn"
        Me.CallenumDataGridViewTextBoxColumn.Visible = False
        '
        'Calleentre1DataGridViewTextBoxColumn
        '
        Me.Calleentre1DataGridViewTextBoxColumn.DataPropertyName = "calle_entre1"
        Me.Calleentre1DataGridViewTextBoxColumn.HeaderText = "calle_entre1"
        Me.Calleentre1DataGridViewTextBoxColumn.Name = "Calleentre1DataGridViewTextBoxColumn"
        Me.Calleentre1DataGridViewTextBoxColumn.Visible = False
        '
        'Calleentre2DataGridViewTextBoxColumn
        '
        Me.Calleentre2DataGridViewTextBoxColumn.DataPropertyName = "calle_entre2"
        Me.Calleentre2DataGridViewTextBoxColumn.HeaderText = "calle_entre2"
        Me.Calleentre2DataGridViewTextBoxColumn.Name = "Calleentre2DataGridViewTextBoxColumn"
        Me.Calleentre2DataGridViewTextBoxColumn.Visible = False
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.Visible = False
        '
        'CodpostalDataGridViewTextBoxColumn
        '
        Me.CodpostalDataGridViewTextBoxColumn.DataPropertyName = "cod_postal"
        Me.CodpostalDataGridViewTextBoxColumn.HeaderText = "cod_postal"
        Me.CodpostalDataGridViewTextBoxColumn.Name = "CodpostalDataGridViewTextBoxColumn"
        Me.CodpostalDataGridViewTextBoxColumn.Visible = False
        '
        'DireccionCompletaDataGridViewTextBoxColumn
        '
        Me.DireccionCompletaDataGridViewTextBoxColumn.DataPropertyName = "direccionCompleta"
        Me.DireccionCompletaDataGridViewTextBoxColumn.HeaderText = "Dirección completa"
        Me.DireccionCompletaDataGridViewTextBoxColumn.Name = "DireccionCompletaDataGridViewTextBoxColumn"
        Me.DireccionCompletaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionCompletaDataGridViewTextBoxColumn.Width = 250
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 50
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'gbClientes
        '
        Me.gbClientes.Controls.Add(Me.dgClientes)
        Me.gbClientes.Controls.Add(Me.Label18)
        Me.gbClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbClientes.Location = New System.Drawing.Point(0, 392)
        Me.gbClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbClientes.Name = "gbClientes"
        Me.gbClientes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbClientes.Size = New System.Drawing.Size(1344, 495)
        Me.gbClientes.TabIndex = 41
        Me.gbClientes.TabStop = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(4, 19)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(1336, 31)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Clientes"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FC001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 887)
        Me.Controls.Add(Me.gbClientes)
        Me.Controls.Add(Me.dgDireccion)
        Me.Controls.Add(Me.gpDatosGenerales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FC001"
        Me.Text = "Catálogo de clientes"
        CType(Me.dvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FC001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dgDireccion.ResumeLayout(False)
        Me.dgDireccion.PerformLayout()
        Me.gpDatosGenerales.ResumeLayout(False)
        Me.gpDatosGenerales.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbClientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCodCte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApPat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApMat As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgDireccion As GroupBox
    Friend WithEvents txtCalleEntre2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCalleEntre1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents txtTel1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCel As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTel2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents gpDatosGenerales As GroupBox
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents sdaClientes As SqlClient.SqlDataAdapter
    Friend WithEvents DS_FC001 As DS_FC001
    Friend WithEvents SqlDeleteCommand As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlClient.SqlCommand
    Friend WithEvents dvClientes As DataView
    Friend WithEvents Label17 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents sdaStatus As SqlClient.SqlDataAdapter
    Friend WithEvents btnReferencias As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnDeshacer As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgClientes As DataGridView
    Friend WithEvents gbClientes As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CodcteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonsocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RfcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApmaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Telefono2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CallenumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Calleentre1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Calleentre2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodpostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionCompletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
