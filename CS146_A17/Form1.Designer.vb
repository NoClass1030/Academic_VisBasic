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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(13, 13)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(134, 39)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play Game"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(13, 59)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(134, 37)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = "Administration"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(13, 103)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 37)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close Program"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(172, 160)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnPlay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnClose As Button
End Class
