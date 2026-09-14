<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab26
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
        Me.btnCreateChart = New System.Windows.Forms.Button()
        Me.grpMultChart = New System.Windows.Forms.GroupBox()
        Me.lstDisplayChart = New System.Windows.Forms.ListBox()
        Me.grpMultChart.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateChart
        '
        Me.btnCreateChart.Location = New System.Drawing.Point(13, 13)
        Me.btnCreateChart.Name = "btnCreateChart"
        Me.btnCreateChart.Size = New System.Drawing.Size(775, 50)
        Me.btnCreateChart.TabIndex = 0
        Me.btnCreateChart.Text = "Create Chart"
        Me.btnCreateChart.UseVisualStyleBackColor = True
        '
        'grpMultChart
        '
        Me.grpMultChart.Controls.Add(Me.lstDisplayChart)
        Me.grpMultChart.Location = New System.Drawing.Point(13, 70)
        Me.grpMultChart.Name = "grpMultChart"
        Me.grpMultChart.Size = New System.Drawing.Size(775, 368)
        Me.grpMultChart.TabIndex = 1
        Me.grpMultChart.TabStop = False
        Me.grpMultChart.Text = "Multiplication Chart"
        '
        'lstDisplayChart
        '
        Me.lstDisplayChart.FormattingEnabled = True
        Me.lstDisplayChart.ItemHeight = 16
        Me.lstDisplayChart.Location = New System.Drawing.Point(7, 22)
        Me.lstDisplayChart.Name = "lstDisplayChart"
        Me.lstDisplayChart.Size = New System.Drawing.Size(749, 340)
        Me.lstDisplayChart.TabIndex = 0
        '
        'frmLab26
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpMultChart)
        Me.Controls.Add(Me.btnCreateChart)
        Me.Name = "frmLab26"
        Me.Text = "Array Multiplication Chart"
        Me.grpMultChart.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateChart As Button
    Friend WithEvents grpMultChart As GroupBox
    Friend WithEvents lstDisplayChart As ListBox
End Class
