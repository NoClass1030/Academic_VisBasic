<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab37
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
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.lstDisplay)
        Me.grpDisplay.Location = New System.Drawing.Point(13, 13)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(775, 425)
        Me.grpDisplay.TabIndex = 0
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Billboard Hot 100 Hit Artists"
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(7, 22)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstDisplay.Size = New System.Drawing.Size(762, 388)
        Me.lstDisplay.TabIndex = 0
        '
        'frmLab37
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpDisplay)
        Me.Name = "frmLab37"
        Me.Text = "Lab 37 - Billboard Hot 100"
        Me.grpDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents lstDisplay As ListBox
End Class
