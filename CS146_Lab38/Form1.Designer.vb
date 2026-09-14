<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab39
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
        Me.grpDataEntry = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtFirstCar = New System.Windows.Forms.TextBox()
        Me.lblFirstCar = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.grpDataEntry.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDataEntry
        '
        Me.grpDataEntry.Controls.Add(Me.btnAdd)
        Me.grpDataEntry.Controls.Add(Me.txtFirstCar)
        Me.grpDataEntry.Controls.Add(Me.lblFirstCar)
        Me.grpDataEntry.Controls.Add(Me.txtHeight)
        Me.grpDataEntry.Controls.Add(Me.lblHeight)
        Me.grpDataEntry.Controls.Add(Me.txtDOB)
        Me.grpDataEntry.Controls.Add(Me.lblDOB)
        Me.grpDataEntry.Controls.Add(Me.txtFullName)
        Me.grpDataEntry.Controls.Add(Me.lblName)
        Me.grpDataEntry.Location = New System.Drawing.Point(13, 13)
        Me.grpDataEntry.Name = "grpDataEntry"
        Me.grpDataEntry.Size = New System.Drawing.Size(200, 240)
        Me.grpDataEntry.TabIndex = 0
        Me.grpDataEntry.TabStop = False
        Me.grpDataEntry.Text = "Data Entry"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(119, 206)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtFirstCar
        '
        Me.txtFirstCar.Location = New System.Drawing.Point(7, 177)
        Me.txtFirstCar.Name = "txtFirstCar"
        Me.txtFirstCar.Size = New System.Drawing.Size(187, 22)
        Me.txtFirstCar.TabIndex = 7
        '
        'lblFirstCar
        '
        Me.lblFirstCar.AutoSize = True
        Me.lblFirstCar.Location = New System.Drawing.Point(7, 157)
        Me.lblFirstCar.Name = "lblFirstCar"
        Me.lblFirstCar.Size = New System.Drawing.Size(143, 16)
        Me.lblFirstCar.TabIndex = 6
        Me.lblFirstCar.Text = "First Car (Make/Model)"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(7, 132)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(187, 22)
        Me.txtHeight.TabIndex = 5
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(7, 112)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(96, 16)
        Me.lblHeight.TabIndex = 4
        Me.lblHeight.Text = "Height (inches)"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(7, 87)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(187, 22)
        Me.txtDOB.TabIndex = 3
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(7, 67)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(79, 16)
        Me.lblDOB.TabIndex = 2
        Me.lblDOB.Text = "Date of Birth"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(7, 42)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(187, 22)
        Me.txtFullName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 22)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Full Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstHistory)
        Me.GroupBox2.Location = New System.Drawing.Point(220, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(918, 425)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lstHistory
        '
        Me.lstHistory.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.ItemHeight = 16
        Me.lstHistory.Location = New System.Drawing.Point(6, 21)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(906, 388)
        Me.lstHistory.TabIndex = 0
        '
        'frmLab39
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpDataEntry)
        Me.Name = "frmLab39"
        Me.Text = "Lab 39 - Family History"
        Me.grpDataEntry.ResumeLayout(False)
        Me.grpDataEntry.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDataEntry As GroupBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtFirstCar As TextBox
    Friend WithEvents lblFirstCar As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents lblDOB As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstHistory As ListBox
End Class
