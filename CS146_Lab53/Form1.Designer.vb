<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab53
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
        Me.mstripOrganize = New System.Windows.Forms.MenuStrip()
        Me.mnuOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkVIoletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForestGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.mstripOrganize.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstripOrganize
        '
        Me.mstripOrganize.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mstripOrganize.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOrder, Me.mnuColor})
        Me.mstripOrganize.Location = New System.Drawing.Point(0, 0)
        Me.mstripOrganize.Name = "mstripOrganize"
        Me.mstripOrganize.Size = New System.Drawing.Size(266, 28)
        Me.mstripOrganize.TabIndex = 0
        Me.mstripOrganize.Text = "MenuStripOrganize"
        '
        'mnuOrder
        '
        Me.mnuOrder.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AscendingToolStripMenuItem, Me.DescendingToolStripMenuItem})
        Me.mnuOrder.Name = "mnuOrder"
        Me.mnuOrder.Size = New System.Drawing.Size(61, 24)
        Me.mnuOrder.Text = "Order"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'mnuColor
        '
        Me.mnuColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkVIoletToolStripMenuItem, Me.ForestGreenToolStripMenuItem})
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(59, 24)
        Me.mnuColor.Text = "Color"
        '
        'DarkVIoletToolStripMenuItem
        '
        Me.DarkVIoletToolStripMenuItem.Name = "DarkVIoletToolStripMenuItem"
        Me.DarkVIoletToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.DarkVIoletToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.DarkVIoletToolStripMenuItem.Text = "Dark VIolet"
        '
        'ForestGreenToolStripMenuItem
        '
        Me.ForestGreenToolStripMenuItem.Name = "ForestGreenToolStripMenuItem"
        Me.ForestGreenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.ForestGreenToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.ForestGreenToolStripMenuItem.Text = "Forest Green"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Items.AddRange(New Object() {"Steven", "Samuel", "Andrew", "Olliver", "Matthew", "Nathan", "Allissa", "Erin", "Karen", "Sherry"})
        Me.lstDisplay.Location = New System.Drawing.Point(13, 28)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(239, 148)
        Me.lstDisplay.TabIndex = 1
        '
        'frmLab53
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 187)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.mstripOrganize)
        Me.MainMenuStrip = Me.mstripOrganize
        Me.Name = "frmLab53"
        Me.Text = "Lab 53"
        Me.mstripOrganize.ResumeLayout(False)
        Me.mstripOrganize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstripOrganize As MenuStrip
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents mnuOrder As ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents DarkVIoletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForestGreenToolStripMenuItem As ToolStripMenuItem
End Class
