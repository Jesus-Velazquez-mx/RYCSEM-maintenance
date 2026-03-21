<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmenuInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmenuInventario))
        Me.dbMenuCtes = New System.Windows.Forms.GroupBox()
        Me.FI003 = New System.Windows.Forms.Button()
        Me.FI002 = New System.Windows.Forms.Button()
        Me.FI001 = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.dbMenuCtes.SuspendLayout()
        Me.SuspendLayout()
        '
        'dbMenuCtes
        '
        Me.dbMenuCtes.Controls.Add(Me.FI003)
        Me.dbMenuCtes.Controls.Add(Me.FI002)
        Me.dbMenuCtes.Controls.Add(Me.FI001)
        Me.dbMenuCtes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dbMenuCtes.Location = New System.Drawing.Point(0, 0)
        Me.dbMenuCtes.Name = "dbMenuCtes"
        Me.dbMenuCtes.Size = New System.Drawing.Size(1008, 74)
        Me.dbMenuCtes.TabIndex = 0
        Me.dbMenuCtes.TabStop = False
        '
        'FI003
        '
        Me.FI003.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FI003.Location = New System.Drawing.Point(637, 19)
        Me.FI003.Name = "FI003"
        Me.FI003.Size = New System.Drawing.Size(281, 39)
        Me.FI003.TabIndex = 3
        Me.FI003.Text = "CONSULTA DE INVENTARIO"
        Me.FI003.UseVisualStyleBackColor = True
        '
        'FI002
        '
        Me.FI002.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FI002.Location = New System.Drawing.Point(327, 19)
        Me.FI002.Name = "FI002"
        Me.FI002.Size = New System.Drawing.Size(281, 39)
        Me.FI002.TabIndex = 2
        Me.FI002.Text = "OPERACIONES DE INVENTARIO"
        Me.FI002.UseVisualStyleBackColor = True
        '
        'FI001
        '
        Me.FI001.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FI001.Location = New System.Drawing.Point(22, 19)
        Me.FI001.Name = "FI001"
        Me.FI001.Size = New System.Drawing.Size(281, 39)
        Me.FI001.TabIndex = 1
        Me.FI001.Text = "ARTICULOS"
        Me.FI001.UseVisualStyleBackColor = True
        '
        'panel
        '
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 74)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(1008, 647)
        Me.panel.TabIndex = 1
        '
        'FmenuInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.dbMenuCtes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmenuInventario"
        Me.Text = "Menú inventario"
        Me.dbMenuCtes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dbMenuCtes As GroupBox
    Friend WithEvents panel As Panel
    Friend WithEvents FI002 As Button
    Friend WithEvents FI001 As Button
    Friend WithEvents FI003 As Button
End Class
