<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab35
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
        Me.lstSearchResults = New System.Windows.Forms.ListBox()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.lstSearchResults)
        Me.grpDisplay.Location = New System.Drawing.Point(13, 13)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(1149, 509)
        Me.grpDisplay.TabIndex = 0
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Search Results"
        '
        'lstSearchResults
        '
        Me.lstSearchResults.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSearchResults.FormattingEnabled = True
        Me.lstSearchResults.ItemHeight = 16
        Me.lstSearchResults.Location = New System.Drawing.Point(7, 22)
        Me.lstSearchResults.Name = "lstSearchResults"
        Me.lstSearchResults.Size = New System.Drawing.Size(1136, 468)
        Me.lstSearchResults.TabIndex = 0
        '
        'frmLab35
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 534)
        Me.Controls.Add(Me.grpDisplay)
        Me.Name = "frmLab35"
        Me.Text = "Lab 35 - Let & Order By Operators"
        Me.grpDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents lstSearchResults As ListBox
End Class
