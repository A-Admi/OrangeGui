<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreationDePaletteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BDQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TracabilitéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatistiqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.BDQToolStripMenuItem, Me.TracabilitéToolStripMenuItem, Me.StatistiqueToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreationDePaletteToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'CreationDePaletteToolStripMenuItem
        '
        Me.CreationDePaletteToolStripMenuItem.Name = "CreationDePaletteToolStripMenuItem"
        Me.CreationDePaletteToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CreationDePaletteToolStripMenuItem.Text = "&Creation de Palette"
        '
        'BDQToolStripMenuItem
        '
        Me.BDQToolStripMenuItem.Name = "BDQToolStripMenuItem"
        Me.BDQToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.BDQToolStripMenuItem.Text = "BDQ"
        '
        'TracabilitéToolStripMenuItem
        '
        Me.TracabilitéToolStripMenuItem.Name = "TracabilitéToolStripMenuItem"
        Me.TracabilitéToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.TracabilitéToolStripMenuItem.Text = "Tracabilité"
        '
        'StatistiqueToolStripMenuItem
        '
        Me.StatistiqueToolStripMenuItem.Name = "StatistiqueToolStripMenuItem"
        Me.StatistiqueToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.StatistiqueToolStripMenuItem.Text = "Statistique"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'Export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 481)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Export"
        Me.Text = "Export"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreationDePaletteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BDQToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TracabilitéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatistiqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
