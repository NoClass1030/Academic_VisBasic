<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab27
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
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.grpResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.lstResults)
        Me.grpResults.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResults.Location = New System.Drawing.Point(13, 13)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(216, 227)
        Me.grpResults.TabIndex = 0
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results:"
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 22
        Me.lstResults.Location = New System.Drawing.Point(7, 22)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(203, 202)
        Me.lstResults.TabIndex = 0
        '
        'frmLab27
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 267)
        Me.Controls.Add(Me.grpResults)
        Me.Name = "frmLab27"
        Me.Text = "Lab 27"
        Me.grpResults.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpResults As GroupBox
    Friend WithEvents lstResults As ListBox
End Class
