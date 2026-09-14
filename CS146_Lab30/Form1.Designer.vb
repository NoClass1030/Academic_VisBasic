<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab30
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
        Me.grpItemCost = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtItemCost = New System.Windows.Forms.TextBox()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.lstSummary = New System.Windows.Forms.ListBox()
        Me.grpItemCost.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpItemCost
        '
        Me.grpItemCost.Controls.Add(Me.btnAdd)
        Me.grpItemCost.Controls.Add(Me.txtItemCost)
        Me.grpItemCost.Location = New System.Drawing.Point(13, 13)
        Me.grpItemCost.Name = "grpItemCost"
        Me.grpItemCost.Size = New System.Drawing.Size(168, 119)
        Me.grpItemCost.TabIndex = 0
        Me.grpItemCost.TabStop = False
        Me.grpItemCost.Text = "Item Cost"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(75, 67)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 31)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtItemCost
        '
        Me.txtItemCost.Location = New System.Drawing.Point(7, 30)
        Me.txtItemCost.Name = "txtItemCost"
        Me.txtItemCost.Size = New System.Drawing.Size(144, 30)
        Me.txtItemCost.TabIndex = 0
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.lstSummary)
        Me.grpSummary.Location = New System.Drawing.Point(188, 13)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(251, 169)
        Me.grpSummary.TabIndex = 1
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Shopping Cart Summary"
        '
        'lstSummary
        '
        Me.lstSummary.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSummary.FormattingEnabled = True
        Me.lstSummary.ItemHeight = 22
        Me.lstSummary.Location = New System.Drawing.Point(7, 30)
        Me.lstSummary.Name = "lstSummary"
        Me.lstSummary.Size = New System.Drawing.Size(238, 114)
        Me.lstSummary.TabIndex = 0
        '
        'frmLab30
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(453, 195)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.grpItemCost)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLab30"
        Me.Text = "5"
        Me.grpItemCost.ResumeLayout(False)
        Me.grpItemCost.PerformLayout()
        Me.grpSummary.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpItemCost As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtItemCost As TextBox
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents lstSummary As ListBox
End Class
