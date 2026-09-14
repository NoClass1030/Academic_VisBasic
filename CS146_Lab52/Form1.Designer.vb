<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab52
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTaxRate = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.ttpTaxRate = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.ttpPrice = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblTaxRate
        '
        Me.lblTaxRate.AutoSize = True
        Me.lblTaxRate.Location = New System.Drawing.Point(51, 15)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(65, 16)
        Me.lblTaxRate.TabIndex = 0
        Me.lblTaxRate.Text = "Tax Rate:"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(124, 12)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 22)
        Me.txtTax.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(124, 40)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 3
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(33, 43)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(83, 16)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price of Item:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 68)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(192, 29)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Total Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'ttpTaxRate
        '
        Me.ttpTaxRate.AutoPopDelay = 5000
        Me.ttpTaxRate.InitialDelay = 500
        Me.ttpTaxRate.ReshowDelay = 100
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(124, 109)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalCost.TabIndex = 6
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(33, 112)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(71, 16)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'frmLab52
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 145)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblTaxRate)
        Me.Name = "frmLab52"
        Me.Text = "Lab 52"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTaxRate As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents ttpTaxRate As ToolTip
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents ttpPrice As ToolTip
End Class
