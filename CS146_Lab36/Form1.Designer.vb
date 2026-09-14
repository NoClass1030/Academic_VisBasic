<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab36
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
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchTerm = New System.Windows.Forms.Label()
        Me.radName = New System.Windows.Forms.RadioButton()
        Me.radYear = New System.Windows.Forms.RadioButton()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.grpSearch.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.lblSearchTerm)
        Me.grpSearch.Controls.Add(Me.radName)
        Me.grpSearch.Controls.Add(Me.radYear)
        Me.grpSearch.Controls.Add(Me.lblLocation)
        Me.grpSearch.Location = New System.Drawing.Point(13, 13)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(200, 153)
        Me.grpSearch.TabIndex = 0
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Controls"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(119, 117)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 88)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(188, 22)
        Me.txtSearch.TabIndex = 4
        '
        'lblSearchTerm
        '
        Me.lblSearchTerm.AutoSize = True
        Me.lblSearchTerm.Location = New System.Drawing.Point(7, 69)
        Me.lblSearchTerm.Name = "lblSearchTerm"
        Me.lblSearchTerm.Size = New System.Drawing.Size(53, 16)
        Me.lblSearchTerm.TabIndex = 3
        Me.lblSearchTerm.Text = "Search:"
        '
        'radName
        '
        Me.radName.AutoSize = True
        Me.radName.Location = New System.Drawing.Point(73, 42)
        Me.radName.Name = "radName"
        Me.radName.Size = New System.Drawing.Size(65, 20)
        Me.radName.TabIndex = 2
        Me.radName.TabStop = True
        Me.radName.Text = "Name"
        Me.radName.UseVisualStyleBackColor = True
        '
        'radYear
        '
        Me.radYear.AutoSize = True
        Me.radYear.Location = New System.Drawing.Point(10, 42)
        Me.radYear.Name = "radYear"
        Me.radYear.Size = New System.Drawing.Size(57, 20)
        Me.radYear.TabIndex = 1
        Me.radYear.TabStop = True
        Me.radYear.Text = "Year"
        Me.radYear.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(7, 22)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(98, 16)
        Me.lblLocation.TabIndex = 0
        Me.lblLocation.Text = "Year or Name?"
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.lstDisplay)
        Me.grpResults.Location = New System.Drawing.Point(219, 13)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(997, 425)
        Me.grpResults.TabIndex = 1
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Search Results"
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(7, 22)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(984, 388)
        Me.lstDisplay.TabIndex = 0
        '
        'frmLab36
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 450)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpSearch)
        Me.Name = "frmLab36"
        Me.Text = "Lab 36 - Functions in LINQ Query"
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.grpResults.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents radName As RadioButton
    Friend WithEvents radYear As RadioButton
    Friend WithEvents lblLocation As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearchTerm As Label
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents lstDisplay As ListBox
End Class
