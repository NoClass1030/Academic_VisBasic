<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab51
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
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtSelection = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(50, 12)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(283, 67)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "Randomly Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtSelection
        '
        Me.txtSelection.Location = New System.Drawing.Point(144, 85)
        Me.txtSelection.Name = "txtSelection"
        Me.txtSelection.ReadOnly = True
        Me.txtSelection.Size = New System.Drawing.Size(100, 22)
        Me.txtSelection.TabIndex = 1
        '
        'frmLab51
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 126)
        Me.Controls.Add(Me.txtSelection)
        Me.Controls.Add(Me.btnSelect)
        Me.Name = "frmLab51"
        Me.Text = "Lab 51 - Random Numbers "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelect As Button
    Friend WithEvents txtSelection As TextBox
End Class
