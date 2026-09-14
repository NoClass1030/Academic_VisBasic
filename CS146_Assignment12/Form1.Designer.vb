<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmA12
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
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.grpAddressBook = New System.Windows.Forms.GroupBox()
        Me.lstAddressBook = New System.Windows.Forms.ListBox()
        Me.grpInfo.SuspendLayout()
        Me.grpAddressBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.txtSearch)
        Me.grpInfo.Controls.Add(Me.btnAdd)
        Me.grpInfo.Controls.Add(Me.btnSearch)
        Me.grpInfo.Controls.Add(Me.lblPhone)
        Me.grpInfo.Controls.Add(Me.txtPhone)
        Me.grpInfo.Controls.Add(Me.lblEmail)
        Me.grpInfo.Controls.Add(Me.txtEmail)
        Me.grpInfo.Controls.Add(Me.lblFirstName)
        Me.grpInfo.Controls.Add(Me.txtFirstName)
        Me.grpInfo.Controls.Add(Me.lblLastName)
        Me.grpInfo.Controls.Add(Me.txtLastName)
        Me.grpInfo.Location = New System.Drawing.Point(13, 13)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(1175, 110)
        Me.grpInfo.TabIndex = 0
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Search Terms"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(712, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(352, 30)
        Me.txtSearch.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1070, 59)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 30)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1070, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(99, 30)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(820, 62)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(69, 25)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(895, 59)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(169, 30)
        Me.txtPhone.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(524, 62)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(68, 25)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "E-Mail"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(598, 59)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(216, 30)
        Me.txtEmail.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(265, 62)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(106, 25)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(377, 59)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(141, 30)
        Me.txtFirstName.TabIndex = 2
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(6, 62)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(106, 25)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(118, 59)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(141, 30)
        Me.txtLastName.TabIndex = 0
        '
        'grpAddressBook
        '
        Me.grpAddressBook.Controls.Add(Me.lstAddressBook)
        Me.grpAddressBook.Location = New System.Drawing.Point(13, 130)
        Me.grpAddressBook.Name = "grpAddressBook"
        Me.grpAddressBook.Size = New System.Drawing.Size(1175, 418)
        Me.grpAddressBook.TabIndex = 1
        Me.grpAddressBook.TabStop = False
        Me.grpAddressBook.Text = "Address Book Info"
        '
        'lstAddressBook
        '
        Me.lstAddressBook.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAddressBook.FormattingEnabled = True
        Me.lstAddressBook.ItemHeight = 22
        Me.lstAddressBook.Location = New System.Drawing.Point(7, 30)
        Me.lstAddressBook.Name = "lstAddressBook"
        Me.lstAddressBook.Size = New System.Drawing.Size(1162, 378)
        Me.lstAddressBook.TabIndex = 0
        '
        'frmA12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 553)
        Me.Controls.Add(Me.grpAddressBook)
        Me.Controls.Add(Me.grpInfo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmA12"
        Me.Text = "A12 - Address Book"
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.grpAddressBook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents grpAddressBook As GroupBox
    Friend WithEvents lstAddressBook As ListBox
    Friend WithEvents txtSearch As TextBox
End Class
