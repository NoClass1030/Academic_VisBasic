<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmA16
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
        Me.lblRank = New System.Windows.Forms.Label()
        Me.txtRank = New System.Windows.Forms.TextBox()
        Me.txtDescript = New System.Windows.Forms.TextBox()
        Me.lblDescript = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Location = New System.Drawing.Point(13, 13)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(39, 16)
        Me.lblRank.TabIndex = 0
        Me.lblRank.Text = "Rank"
        '
        'txtRank
        '
        Me.txtRank.Location = New System.Drawing.Point(105, 10)
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(161, 22)
        Me.txtRank.TabIndex = 1
        '
        'txtDescript
        '
        Me.txtDescript.Location = New System.Drawing.Point(105, 38)
        Me.txtDescript.Name = "txtDescript"
        Me.txtDescript.Size = New System.Drawing.Size(161, 22)
        Me.txtDescript.TabIndex = 3
        '
        'lblDescript
        '
        Me.lblDescript.AutoSize = True
        Me.lblDescript.Location = New System.Drawing.Point(13, 41)
        Me.lblDescript.Name = "lblDescript"
        Me.lblDescript.Size = New System.Drawing.Size(75, 16)
        Me.lblDescript.TabIndex = 2
        Me.lblDescript.Text = "Description"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(105, 66)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(161, 22)
        Me.txtStatus.TabIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(13, 69)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(44, 16)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status"
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(29, 94)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(110, 23)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(145, 94)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(145, 123)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 23)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "New Entry"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(29, 123)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(110, 23)
        Me.btnOpen.TabIndex = 8
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(145, 152)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(30, 152)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update Entry"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmA16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 181)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtDescript)
        Me.Controls.Add(Me.lblDescript)
        Me.Controls.Add(Me.txtRank)
        Me.Controls.Add(Me.lblRank)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmA16"
        Me.Text = "frmA16"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRank As Label
    Friend WithEvents txtRank As TextBox
    Friend WithEvents txtDescript As TextBox
    Friend WithEvents lblDescript As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
End Class
