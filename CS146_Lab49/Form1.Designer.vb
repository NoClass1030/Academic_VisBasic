<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab49
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
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTitle
        '
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Items.AddRange(New Object() {"Mr.", "Ms.", "Mrs.", "Dr.", "The Honorable", "Her Highness", "His Highness", "Add New"})
        Me.cboTitle.Location = New System.Drawing.Point(16, 40)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(208, 24)
        Me.cboTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(13, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(211, 16)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Select Existing or Create New Title"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(230, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(233, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(169, 22)
        Me.txtName.TabIndex = 3
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.lstDisplay)
        Me.grpDisplay.Location = New System.Drawing.Point(12, 147)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(390, 196)
        Me.grpDisplay.TabIndex = 4
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Results"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(4, 22)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(380, 164)
        Me.lstDisplay.TabIndex = 0
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(283, 69)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(118, 40)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display Full Name"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frmLab49
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 355)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cboTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLab49"
        Me.Text = "Lab 49 - ComboBox Controls"
        Me.grpDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboTitle As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lstDisplay As ListBox
End Class
