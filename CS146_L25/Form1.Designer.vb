<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab25
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
        Me.lblNiceJob = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNiceJob
        '
        Me.lblNiceJob.AutoSize = True
        Me.lblNiceJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNiceJob.Location = New System.Drawing.Point(130, 113)
        Me.lblNiceJob.Name = "lblNiceJob"
        Me.lblNiceJob.Size = New System.Drawing.Size(159, 36)
        Me.lblNiceJob.TabIndex = 0
        Me.lblNiceJob.Text = "NICE JOB!"
        '
        'frmLab25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 258)
        Me.Controls.Add(Me.lblNiceJob)
        Me.Name = "frmLab25"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNiceJob As Label
End Class
