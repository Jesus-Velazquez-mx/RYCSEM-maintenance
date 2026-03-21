<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmenuClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmenuClientes))
        Me.dbMenuCtes = New System.Windows.Forms.GroupBox()
        Me.FC001 = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.FC002 = New System.Windows.Forms.Button()
        Me.dbMenuCtes.SuspendLayout()
        Me.SuspendLayout()
        '
        'dbMenuCtes
        '
        Me.dbMenuCtes.Controls.Add(Me.FC002)
        Me.dbMenuCtes.Controls.Add(Me.FC001)
        Me.dbMenuCtes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dbMenuCtes.Location = New System.Drawing.Point(0, 0)
        Me.dbMenuCtes.Name = "dbMenuCtes"
        Me.dbMenuCtes.Size = New System.Drawing.Size(1008, 74)
        Me.dbMenuCtes.TabIndex = 0
        Me.dbMenuCtes.TabStop = False
        '
        'FC001
        '
        Me.FC001.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FC001.Location = New System.Drawing.Point(22, 19)
        Me.FC001.Name = "FC001"
        Me.FC001.Size = New System.Drawing.Size(170, 39)
        Me.FC001.TabIndex = 1
        Me.FC001.Text = "CLIENTES"
        Me.FC001.UseVisualStyleBackColor = True
        '
        'panel
        '
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 74)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(1008, 647)
        Me.panel.TabIndex = 1
        '
        'FC002
        '
        Me.FC002.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FC002.Location = New System.Drawing.Point(210, 19)
        Me.FC002.Name = "FC002"
        Me.FC002.Size = New System.Drawing.Size(170, 39)
        Me.FC002.TabIndex = 2
        Me.FC002.Text = "ABONOS CLIENTES"
        Me.FC002.UseVisualStyleBackColor = True
        '
        'FmenuClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 721)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.dbMenuCtes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmenuClientes"
        Me.Text = "Menú clientes"
        Me.dbMenuCtes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dbMenuCtes As GroupBox
    Friend WithEvents panel As Panel
    Friend WithEvents FC001 As Button
    Friend WithEvents FC002 As Button
End Class
