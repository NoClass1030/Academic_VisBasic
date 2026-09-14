<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab34
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
        Me.grpArtistSearch = New System.Windows.Forms.GroupBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.grpArtistSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpArtistSearch
        '
        Me.grpArtistSearch.Controls.Add(Me.lstDisplay)
        Me.grpArtistSearch.Location = New System.Drawing.Point(13, 13)
        Me.grpArtistSearch.Name = "grpArtistSearch"
        Me.grpArtistSearch.Size = New System.Drawing.Size(415, 325)
        Me.grpArtistSearch.TabIndex = 0
        Me.grpArtistSearch.TabStop = False
        Me.grpArtistSearch.Text = "Spotify Top 200"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(7, 19)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(402, 292)
        Me.lstDisplay.TabIndex = 1
        '
        'frmLab34
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 342)
        Me.Controls.Add(Me.grpArtistSearch)
        Me.Name = "frmLab34"
        Me.Text = "Lab 34 - LINQ Distinct Operators"
        Me.grpArtistSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpArtistSearch As GroupBox
    Friend WithEvents lstDisplay As ListBox
End Class
