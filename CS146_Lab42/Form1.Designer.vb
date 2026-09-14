<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab42
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
        Me.grpDistance = New System.Windows.Forms.GroupBox()
        Me.lblCity1 = New System.Windows.Forms.Label()
        Me.cboCity1 = New System.Windows.Forms.ComboBox()
        Me.cboCity2 = New System.Windows.Forms.ComboBox()
        Me.lblCity2 = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpDistance.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDistance
        '
        Me.grpDistance.Controls.Add(Me.btnCalculate)
        Me.grpDistance.Controls.Add(Me.txtDistance)
        Me.grpDistance.Controls.Add(Me.lblDistance)
        Me.grpDistance.Controls.Add(Me.cboCity2)
        Me.grpDistance.Controls.Add(Me.lblCity2)
        Me.grpDistance.Controls.Add(Me.cboCity1)
        Me.grpDistance.Controls.Add(Me.lblCity1)
        Me.grpDistance.Location = New System.Drawing.Point(13, 13)
        Me.grpDistance.Name = "grpDistance"
        Me.grpDistance.Size = New System.Drawing.Size(268, 142)
        Me.grpDistance.TabIndex = 0
        Me.grpDistance.TabStop = False
        Me.grpDistance.Text = "Distance Between Cities"
        '
        'lblCity1
        '
        Me.lblCity1.AutoSize = True
        Me.lblCity1.Location = New System.Drawing.Point(7, 22)
        Me.lblCity1.Name = "lblCity1"
        Me.lblCity1.Size = New System.Drawing.Size(46, 16)
        Me.lblCity1.TabIndex = 0
        Me.lblCity1.Text = "City #1"
        '
        'cboCity1
        '
        Me.cboCity1.FormattingEnabled = True
        Me.cboCity1.Location = New System.Drawing.Point(10, 42)
        Me.cboCity1.Name = "cboCity1"
        Me.cboCity1.Size = New System.Drawing.Size(121, 24)
        Me.cboCity1.TabIndex = 1
        '
        'cboCity2
        '
        Me.cboCity2.FormattingEnabled = True
        Me.cboCity2.Location = New System.Drawing.Point(137, 42)
        Me.cboCity2.Name = "cboCity2"
        Me.cboCity2.Size = New System.Drawing.Size(121, 24)
        Me.cboCity2.TabIndex = 3
        '
        'lblCity2
        '
        Me.lblCity2.AutoSize = True
        Me.lblCity2.Location = New System.Drawing.Point(134, 22)
        Me.lblCity2.Name = "lblCity2"
        Me.lblCity2.Size = New System.Drawing.Size(46, 16)
        Me.lblCity2.TabIndex = 2
        Me.lblCity2.Text = "City #2"
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Location = New System.Drawing.Point(10, 73)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(60, 16)
        Me.lblDistance.TabIndex = 4
        Me.lblDistance.Text = "Distance"
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(13, 93)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.ReadOnly = True
        Me.txtDistance.Size = New System.Drawing.Size(118, 22)
        Me.txtDistance.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(137, 93)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(121, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmLab42
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 169)
        Me.Controls.Add(Me.grpDistance)
        Me.Name = "frmLab42"
        Me.Text = "Lab 42 - 2D Arrays"
        Me.grpDistance.ResumeLayout(False)
        Me.grpDistance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDistance As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtDistance As TextBox
    Friend WithEvents lblDistance As Label
    Friend WithEvents cboCity2 As ComboBox
    Friend WithEvents lblCity2 As Label
    Friend WithEvents cboCity1 As ComboBox
    Friend WithEvents lblCity1 As Label
End Class
