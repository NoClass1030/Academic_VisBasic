<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoinCompCalc
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
        Me.lblChangeAmount = New System.Windows.Forms.Label()
        Me.txtChangeAmount = New System.Windows.Forms.TextBox()
        Me.btnCoinComp = New System.Windows.Forms.Button()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.txtNickels = New System.Windows.Forms.TextBox()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblChangeAmount
        '
        Me.lblChangeAmount.AutoSize = True
        Me.lblChangeAmount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeAmount.Location = New System.Drawing.Point(13, 17)
        Me.lblChangeAmount.Name = "lblChangeAmount"
        Me.lblChangeAmount.Size = New System.Drawing.Size(356, 24)
        Me.lblChangeAmount.TabIndex = 0
        Me.lblChangeAmount.Text = "Total Amount of Change (Under 99 cents)"
        '
        'txtChangeAmount
        '
        Me.txtChangeAmount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeAmount.Location = New System.Drawing.Point(376, 14)
        Me.txtChangeAmount.Name = "txtChangeAmount"
        Me.txtChangeAmount.Size = New System.Drawing.Size(100, 32)
        Me.txtChangeAmount.TabIndex = 1
        '
        'btnCoinComp
        '
        Me.btnCoinComp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoinComp.Location = New System.Drawing.Point(17, 52)
        Me.btnCoinComp.Name = "btnCoinComp"
        Me.btnCoinComp.Size = New System.Drawing.Size(459, 36)
        Me.btnCoinComp.TabIndex = 2
        Me.btnCoinComp.Text = "Calculate Coin Composition"
        Me.btnCoinComp.UseVisualStyleBackColor = True
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(17, 95)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(83, 24)
        Me.lblQuarters.TabIndex = 3
        Me.lblQuarters.Text = "Quarters"
        '
        'txtQuarters
        '
        Me.txtQuarters.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuarters.Location = New System.Drawing.Point(106, 92)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.Size = New System.Drawing.Size(139, 32)
        Me.txtQuarters.TabIndex = 4
        '
        'txtDimes
        '
        Me.txtDimes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimes.Location = New System.Drawing.Point(106, 134)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.Size = New System.Drawing.Size(139, 32)
        Me.txtDimes.TabIndex = 6
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimes.Location = New System.Drawing.Point(17, 137)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(61, 24)
        Me.lblDimes.TabIndex = 5
        Me.lblDimes.Text = "Dimes"
        '
        'txtNickels
        '
        Me.txtNickels.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNickels.Location = New System.Drawing.Point(340, 92)
        Me.txtNickels.Name = "txtNickels"
        Me.txtNickels.Size = New System.Drawing.Size(136, 32)
        Me.txtNickels.TabIndex = 8
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickels.Location = New System.Drawing.Point(251, 95)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(67, 24)
        Me.lblNickels.TabIndex = 7
        Me.lblNickels.Text = "Nickels"
        '
        'txtPennies
        '
        Me.txtPennies.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPennies.Location = New System.Drawing.Point(340, 134)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(136, 32)
        Me.txtPennies.TabIndex = 10
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennies.Location = New System.Drawing.Point(251, 137)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(75, 24)
        Me.lblPennies.TabIndex = 9
        Me.lblPennies.Text = "Pennies"
        '
        'frmCoinCompCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 181)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.txtNickels)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.txtDimes)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.txtQuarters)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.btnCoinComp)
        Me.Controls.Add(Me.txtChangeAmount)
        Me.Controls.Add(Me.lblChangeAmount)
        Me.Name = "frmCoinCompCalc"
        Me.Text = "Coin Composition Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChangeAmount As Label
    Friend WithEvents txtChangeAmount As TextBox
    Friend WithEvents btnCoinComp As Button
    Friend WithEvents lblQuarters As Label
    Friend WithEvents txtQuarters As TextBox
    Friend WithEvents txtDimes As TextBox
    Friend WithEvents lblDimes As Label
    Friend WithEvents txtNickels As TextBox
    Friend WithEvents lblNickels As Label
    Friend WithEvents txtPennies As TextBox
    Friend WithEvents lblPennies As Label
End Class
