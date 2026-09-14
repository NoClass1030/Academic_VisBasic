<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab32
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.lblMatches = New System.Windows.Forms.Label()
        Me.lblMatchCount = New System.Windows.Forms.Label()
        Me.lstSearchResults = New System.Windows.Forms.ListBox()
        Me.grpResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(18, 41)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(323, 30)
        Me.txtSearch.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 25)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(347, 41)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 30)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.lblMatches)
        Me.grpResults.Controls.Add(Me.lblMatchCount)
        Me.grpResults.Controls.Add(Me.lstSearchResults)
        Me.grpResults.Location = New System.Drawing.Point(13, 78)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(683, 445)
        Me.grpResults.TabIndex = 3
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Search Results"
        '
        'lblMatches
        '
        Me.lblMatches.AutoSize = True
        Me.lblMatches.Location = New System.Drawing.Point(507, 412)
        Me.lblMatches.Name = "lblMatches"
        Me.lblMatches.Size = New System.Drawing.Size(93, 25)
        Me.lblMatches.TabIndex = 2
        Me.lblMatches.Text = "Matches:"
        '
        'lblMatchCount
        '
        Me.lblMatchCount.AutoSize = True
        Me.lblMatchCount.Location = New System.Drawing.Point(606, 412)
        Me.lblMatchCount.Name = "lblMatchCount"
        Me.lblMatchCount.Size = New System.Drawing.Size(0, 25)
        Me.lblMatchCount.TabIndex = 1
        '
        'lstSearchResults
        '
        Me.lstSearchResults.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSearchResults.FormattingEnabled = True
        Me.lstSearchResults.ItemHeight = 22
        Me.lstSearchResults.Location = New System.Drawing.Point(7, 30)
        Me.lstSearchResults.Name = "lstSearchResults"
        Me.lstSearchResults.Size = New System.Drawing.Size(670, 378)
        Me.lstSearchResults.TabIndex = 0
        '
        'frmLab32
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 529)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtSearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLab32"
        Me.Text = "Lab 32 - Search Array"
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents lstSearchResults As ListBox
    Friend WithEvents lblMatches As Label
    Friend WithEvents lblMatchCount As Label
End Class
