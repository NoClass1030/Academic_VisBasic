<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab50
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
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(13, 13)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(194, 46)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(13, 66)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(64, 16)
        Me.lblSeconds.TabIndex = 1
        Me.lblSeconds.Text = "Seconds:"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(13, 95)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(194, 47)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'tmrTime
        '
        '
        'txtTimer
        '
        Me.txtTimer.Location = New System.Drawing.Point(84, 66)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(123, 22)
        Me.txtTimer.TabIndex = 3
        '
        'frmLab50
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 157)
        Me.Controls.Add(Me.txtTimer)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.btnStart)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLab50"
        Me.Text = "Lab 50 - Timers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents lblSeconds As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents tmrTime As Timer
    Friend WithEvents txtTimer As TextBox
End Class
