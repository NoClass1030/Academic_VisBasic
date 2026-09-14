<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkVioletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForestGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOrder, Me.mnuColor, Me.mnuAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(410, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'mnuColor
        '
        Me.mnuColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkVioletToolStripMenuItem, Me.ForestGreenToolStripMenuItem})
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(59, 24)
        Me.mnuColor.Text = "Color"
        '
        'DarkVioletToolStripMenuItem
        '
        Me.DarkVioletToolStripMenuItem.Name = "DarkVioletToolStripMenuItem"
        Me.DarkVioletToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DarkVioletToolStripMenuItem.Text = "Dark Violet"
        '
        'ForestGreenToolStripMenuItem
        '
        Me.ForestGreenToolStripMenuItem.Name = "ForestGreenToolStripMenuItem"
        Me.ForestGreenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ForestGreenToolStripMenuItem.Text = "Forest Green"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Apples", "Bananas", "Cherries", "Watermelon", "Dragonfruit", "Starfruit", "Durian Fruit", "Qumquat", "Papaya", "Pear", "Plantains"})
        Me.ListBox1.Location = New System.Drawing.Point(13, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(380, 212)
        Me.ListBox1.TabIndex = 1
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(64, 24)
        Me.mnuAbout.Text = "About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 265)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Lab 54 - Multi-Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuOrder As ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents DarkVioletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForestGreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
