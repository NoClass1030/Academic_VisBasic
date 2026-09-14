<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLuckyNum = New System.Windows.Forms.TextBox()
        Me.lblLuckyNumber = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(13, 13)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(100, 24)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(17, 41)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(239, 41)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(200, 22)
        Me.txtLastName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(235, 13)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(97, 24)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'txtLuckyNum
        '
        Me.txtLuckyNum.Location = New System.Drawing.Point(463, 41)
        Me.txtLuckyNum.Name = "txtLuckyNum"
        Me.txtLuckyNum.Size = New System.Drawing.Size(100, 22)
        Me.txtLuckyNum.TabIndex = 5
        '
        'lblLuckyNumber
        '
        Me.lblLuckyNumber.AutoSize = True
        Me.lblLuckyNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuckyNumber.Location = New System.Drawing.Point(459, 13)
        Me.lblLuckyNumber.Name = "lblLuckyNumber"
        Me.lblLuckyNumber.Size = New System.Drawing.Size(128, 24)
        Me.lblLuckyNumber.TabIndex = 4
        Me.lblLuckyNumber.Text = "Lucky Number"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(17, 70)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(546, 37)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add to List"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 24
        Me.lstResults.Location = New System.Drawing.Point(17, 114)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(546, 76)
        Me.lstResults.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 221)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtLuckyNum)
        Me.Controls.Add(Me.lblLuckyNumber)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLuckyNum As TextBox
    Friend WithEvents lblLuckyNumber As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstResults As ListBox
End Class
