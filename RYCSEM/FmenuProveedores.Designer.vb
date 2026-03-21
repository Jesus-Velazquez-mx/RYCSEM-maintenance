<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmenuProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmenuProveedores))
        Me.dbMenuCtes = New System.Windows.Forms.GroupBox()
        Me.FP001 = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.dbMenuCtes.SuspendLayout()
        Me.SuspendLayout()
        '
        'dbMenuCtes
        '
        Me.dbMenuCtes.Controls.Add(Me.FP001)
        Me.dbMenuCtes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dbMenuCtes.Location = New System.Drawing.Point(0, 0)
        Me.dbMenuCtes.Name = "dbMenuCtes"
        Me.dbMenuCtes.Size = New System.Drawing.Size(1008, 74)
        Me.dbMenuCtes.TabIndex = 0
        Me.dbMenuCtes.TabStop = False
        '
        'FP001
        '
        Me.FP001.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FP001.Location = New System.Drawing.Point(12, 19)
        Me.FP001.Name = "FP001"
        Me.FP001.Size = New System.Drawing.Size(170, 39)
        Me.FP001.TabIndex = 2
        Me.FP001.Text = "PROVEEDORES"
        Me.FP001.UseVisualStyleBackColor = True
        '
        'panel
        '
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 74)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(1008, 647)
        Me.panel.TabIndex = 1
        '
        'FmenuProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.dbMenuCtes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmenuProveedores"
        Me.Text = "Menú proveedores"
        Me.dbMenuCtes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dbMenuCtes As GroupBox
    Friend WithEvents panel As Panel
    Friend WithEvents FP001 As Button
End Class
