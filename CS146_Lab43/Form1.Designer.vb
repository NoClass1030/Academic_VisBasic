<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab43
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
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(12, 12)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(900, 388)
        Me.lstDisplay.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(808, 408)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(698, 408)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(104, 23)
        Me.btnLoadFile.TabIndex = 2
        Me.btnLoadFile.Text = "Load File"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'frmLab43
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 450)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstDisplay)
        Me.Name = "frmLab43"
        Me.Text = "Lab 43 - OpenFileDialog Control"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoadFile As Button
End Class
