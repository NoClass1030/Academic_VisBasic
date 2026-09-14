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
        Me.btnCreateChart = New System.Windows.Forms.Button()
        Me.grpMultChart = New System.Windows.Forms.GroupBox()
        Me.lstMultChart = New System.Windows.Forms.ListBox()
        Me.grpMultChart.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateChart
        '
        Me.btnCreateChart.Location = New System.Drawing.Point(13, 13)
        Me.btnCreateChart.Name = "btnCreateChart"
        Me.btnCreateChart.Size = New System.Drawing.Size(421, 35)
        Me.btnCreateChart.TabIndex = 0
        Me.btnCreateChart.Text = "Create Chart"
        Me.btnCreateChart.UseVisualStyleBackColor = True
        '
        'grpMultChart
        '
        Me.grpMultChart.Controls.Add(Me.lstMultChart)
        Me.grpMultChart.Location = New System.Drawing.Point(13, 54)
        Me.grpMultChart.Name = "grpMultChart"
        Me.grpMultChart.Size = New System.Drawing.Size(421, 287)
        Me.grpMultChart.TabIndex = 1
        Me.grpMultChart.TabStop = False
        Me.grpMultChart.Text = "Multiplication Chart"
        '
        'lstMultChart
        '
        Me.lstMultChart.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMultChart.FormattingEnabled = True
        Me.lstMultChart.ItemHeight = 20
        Me.lstMultChart.Location = New System.Drawing.Point(7, 22)
        Me.lstMultChart.Name = "lstMultChart"
        Me.lstMultChart.Size = New System.Drawing.Size(408, 244)
        Me.lstMultChart.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 353)
        Me.Controls.Add(Me.grpMultChart)
        Me.Controls.Add(Me.btnCreateChart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpMultChart.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateChart As Button
    Friend WithEvents grpMultChart As GroupBox
    Friend WithEvents lstMultChart As ListBox
End Class
