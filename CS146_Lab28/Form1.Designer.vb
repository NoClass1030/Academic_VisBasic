<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab28
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
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpOrigList = New System.Windows.Forms.GroupBox()
        Me.lstOrigList = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.grpSortList = New System.Windows.Forms.GroupBox()
        Me.lstSortList = New System.Windows.Forms.ListBox()
        Me.grpOrigList.SuspendLayout()
        Me.grpSortList.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(13, 13)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(117, 25)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search Item"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(18, 42)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(184, 30)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(209, 42)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 30)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(18, 79)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(396, 25)
        Me.lblAdd.TabIndex = 3
        Me.lblAdd.Text = "Add Items (add commas between two items)"
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(13, 108)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(536, 30)
        Me.txtAdd.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(556, 108)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 30)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpOrigList
        '
        Me.grpOrigList.Controls.Add(Me.lstOrigList)
        Me.grpOrigList.Location = New System.Drawing.Point(13, 145)
        Me.grpOrigList.Name = "grpOrigList"
        Me.grpOrigList.Size = New System.Drawing.Size(246, 316)
        Me.grpOrigList.TabIndex = 6
        Me.grpOrigList.TabStop = False
        Me.grpOrigList.Text = "Original List"
        '
        'lstOrigList
        '
        Me.lstOrigList.FormattingEnabled = True
        Me.lstOrigList.ItemHeight = 25
        Me.lstOrigList.Location = New System.Drawing.Point(7, 30)
        Me.lstOrigList.Name = "lstOrigList"
        Me.lstOrigList.Size = New System.Drawing.Size(233, 279)
        Me.lstOrigList.TabIndex = 0
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(266, 423)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(88, 37)
        Me.btnSort.TabIndex = 7
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'grpSortList
        '
        Me.grpSortList.Controls.Add(Me.lstSortList)
        Me.grpSortList.Location = New System.Drawing.Point(401, 145)
        Me.grpSortList.Name = "grpSortList"
        Me.grpSortList.Size = New System.Drawing.Size(246, 316)
        Me.grpSortList.TabIndex = 7
        Me.grpSortList.TabStop = False
        Me.grpSortList.Text = "Sorted List"
        '
        'lstSortList
        '
        Me.lstSortList.FormattingEnabled = True
        Me.lstSortList.ItemHeight = 25
        Me.lstSortList.Location = New System.Drawing.Point(7, 30)
        Me.lstSortList.Name = "lstSortList"
        Me.lstSortList.Size = New System.Drawing.Size(233, 279)
        Me.lstSortList.TabIndex = 0
        '
        'frmLab28
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 471)
        Me.Controls.Add(Me.grpSortList)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.grpOrigList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLab28"
        Me.Text = "Lab 28"
        Me.grpOrigList.ResumeLayout(False)
        Me.grpSortList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblAdd As Label
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents grpOrigList As GroupBox
    Friend WithEvents lstOrigList As ListBox
    Friend WithEvents btnSort As Button
    Friend WithEvents grpSortList As GroupBox
    Friend WithEvents lstSortList As ListBox
End Class
