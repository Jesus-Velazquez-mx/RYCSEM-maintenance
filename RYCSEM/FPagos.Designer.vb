<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPagos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.lCambio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numPagoEF = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DS_FPagos = New RYCSEM.DS_FPagos()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SdaFormasPago = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.numPagoTC = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numPagoTD = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numDeposito = New System.Windows.Forms.NumericUpDown()
        Me.numCobroLk = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.numPagoEF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPagoTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPagoTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCobroLk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(115, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total a pagar:"
        '
        'lTotal
        '
        Me.lTotal.AutoSize = True
        Me.lTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lTotal.Location = New System.Drawing.Point(169, 69)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(170, 46)
        Me.lTotal.TabIndex = 1
        Me.lTotal.Text = "$360.00"
        '
        'lCambio
        '
        Me.lCambio.AutoSize = True
        Me.lCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCambio.ForeColor = System.Drawing.Color.ForestGreen
        Me.lCambio.Location = New System.Drawing.Point(259, 427)
        Me.lCambio.Name = "lCambio"
        Me.lCambio.Size = New System.Drawing.Size(147, 46)
        Me.lCambio.TabIndex = 3
        Me.lCambio.Text = "$00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(93, 427)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 46)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cambio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(93, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 36)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Efectivo:"
        '
        'numPagoEF
        '
        Me.numPagoEF.DecimalPlaces = 2
        Me.numPagoEF.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPagoEF.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.numPagoEF.Location = New System.Drawing.Point(237, 178)
        Me.numPagoEF.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.numPagoEF.Name = "numPagoEF"
        Me.numPagoEF.Size = New System.Drawing.Size(203, 39)
        Me.numPagoEF.TabIndex = 5
        Me.numPagoEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(25, 585)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(458, 46)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Gracias por su compra!"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(137, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 39)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Formas Pago:"
        '
        'DS_FPagos
        '
        Me.DS_FPagos.DataSetName = "DS_FPagos"
        Me.DS_FPagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(186, 495)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(136, 74)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "PAGAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa" &
    ";Password=luna"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'SdaFormasPago
        '
        Me.SdaFormasPago.SelectCommand = Me.SqlSelectCommand7
        Me.SdaFormasPago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "formas_pago", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("forma_pago", "forma_pago"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("abreviatura", "abreviatura"), New System.Data.Common.DataColumnMapping("status", "status")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "select * from formas_pago where status = 'V'"
        Me.SqlSelectCommand7.Connection = Me.sqlConn
        '
        'numPagoTC
        '
        Me.numPagoTC.DecimalPlaces = 2
        Me.numPagoTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPagoTC.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.numPagoTC.Location = New System.Drawing.Point(237, 226)
        Me.numPagoTC.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.numPagoTC.Name = "numPagoTC"
        Me.numPagoTC.Size = New System.Drawing.Size(203, 39)
        Me.numPagoTC.TabIndex = 11
        Me.numPagoTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 36)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tarjeta Créd:"
        Me.ToolTip1.SetToolTip(Me.Label2, "Tarjeta de crédito")
        '
        'numPagoTD
        '
        Me.numPagoTD.DecimalPlaces = 2
        Me.numPagoTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPagoTD.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.numPagoTD.Location = New System.Drawing.Point(237, 274)
        Me.numPagoTD.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.numPagoTD.Name = "numPagoTD"
        Me.numPagoTD.Size = New System.Drawing.Size(203, 39)
        Me.numPagoTD.TabIndex = 13
        Me.numPagoTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(43, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 36)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tarjeta Déb:"
        Me.ToolTip1.SetToolTip(Me.Label3, "Tarjeta de débito")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(90, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 36)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Depósito"
        '
        'numDeposito
        '
        Me.numDeposito.DecimalPlaces = 2
        Me.numDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDeposito.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.numDeposito.Location = New System.Drawing.Point(237, 322)
        Me.numDeposito.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.numDeposito.Name = "numDeposito"
        Me.numDeposito.Size = New System.Drawing.Size(203, 39)
        Me.numDeposito.TabIndex = 15
        Me.numDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numCobroLk
        '
        Me.numCobroLk.DecimalPlaces = 2
        Me.numCobroLk.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCobroLk.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.numCobroLk.Location = New System.Drawing.Point(237, 370)
        Me.numCobroLk.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.numCobroLk.Name = "numCobroLk"
        Me.numCobroLk.Size = New System.Drawing.Size(203, 39)
        Me.numCobroLk.TabIndex = 17
        Me.numCobroLk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 371)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 36)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cobro con link"
        '
        'FPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 641)
        Me.Controls.Add(Me.numCobroLk)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.numDeposito)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numPagoTD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numPagoTC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numPagoEF)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lCambio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FPagos"
        Me.Text = "Pago"
        CType(Me.numPagoEF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPagoTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPagoTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCobroLk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lTotal As Label
    Friend WithEvents lCambio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents numPagoEF As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents sqlConn As SqlClient.SqlConnection
    Friend WithEvents SdaFormasPago As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As SqlClient.SqlCommand
    Friend WithEvents DS_FPagos As DS_FPagos
    Friend WithEvents numPagoTC As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents numPagoTD As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents numDeposito As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents numCobroLk As NumericUpDown
    Friend WithEvents Label9 As Label
End Class
