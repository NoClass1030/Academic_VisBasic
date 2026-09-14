<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab29
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
        Me.grpRecipes = New System.Windows.Forms.GroupBox()
        Me.btnRecip3 = New System.Windows.Forms.Button()
        Me.btnRecip2 = New System.Windows.Forms.Button()
        Me.btnRecip1 = New System.Windows.Forms.Button()
        Me.grpIngredients = New System.Windows.Forms.GroupBox()
        Me.lstIngredients = New System.Windows.Forms.ListBox()
        Me.grpRecipes.SuspendLayout()
        Me.grpIngredients.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRecipes
        '
        Me.grpRecipes.Controls.Add(Me.btnRecip3)
        Me.grpRecipes.Controls.Add(Me.btnRecip2)
        Me.grpRecipes.Controls.Add(Me.btnRecip1)
        Me.grpRecipes.Location = New System.Drawing.Point(13, 13)
        Me.grpRecipes.Name = "grpRecipes"
        Me.grpRecipes.Size = New System.Drawing.Size(209, 173)
        Me.grpRecipes.TabIndex = 0
        Me.grpRecipes.TabStop = False
        Me.grpRecipes.Text = "Recipes"
        '
        'btnRecip3
        '
        Me.btnRecip3.Location = New System.Drawing.Point(7, 120)
        Me.btnRecip3.Name = "btnRecip3"
        Me.btnRecip3.Size = New System.Drawing.Size(189, 38)
        Me.btnRecip3.TabIndex = 2
        Me.btnRecip3.Text = "PBJ French Toast"
        Me.btnRecip3.UseVisualStyleBackColor = True
        '
        'btnRecip2
        '
        Me.btnRecip2.Location = New System.Drawing.Point(7, 76)
        Me.btnRecip2.Name = "btnRecip2"
        Me.btnRecip2.Size = New System.Drawing.Size(189, 38)
        Me.btnRecip2.TabIndex = 1
        Me.btnRecip2.Text = "Pizza on a Stick"
        Me.btnRecip2.UseVisualStyleBackColor = True
        '
        'btnRecip1
        '
        Me.btnRecip1.Location = New System.Drawing.Point(7, 32)
        Me.btnRecip1.Name = "btnRecip1"
        Me.btnRecip1.Size = New System.Drawing.Size(189, 38)
        Me.btnRecip1.TabIndex = 0
        Me.btnRecip1.Text = "Cheeseburger Cups"
        Me.btnRecip1.UseVisualStyleBackColor = True
        '
        'grpIngredients
        '
        Me.grpIngredients.Controls.Add(Me.lstIngredients)
        Me.grpIngredients.Location = New System.Drawing.Point(238, 13)
        Me.grpIngredients.Name = "grpIngredients"
        Me.grpIngredients.Size = New System.Drawing.Size(468, 261)
        Me.grpIngredients.TabIndex = 1
        Me.grpIngredients.TabStop = False
        Me.grpIngredients.Text = "Ingredients"
        '
        'lstIngredients
        '
        Me.lstIngredients.FormattingEnabled = True
        Me.lstIngredients.ItemHeight = 24
        Me.lstIngredients.Location = New System.Drawing.Point(7, 32)
        Me.lstIngredients.Name = "lstIngredients"
        Me.lstIngredients.Size = New System.Drawing.Size(455, 220)
        Me.lstIngredients.TabIndex = 0
        '
        'frmLab29
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 295)
        Me.Controls.Add(Me.grpIngredients)
        Me.Controls.Add(Me.grpRecipes)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLab29"
        Me.Text = "Lab 31"
        Me.grpRecipes.ResumeLayout(False)
        Me.grpIngredients.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpRecipes As GroupBox
    Friend WithEvents btnRecip3 As Button
    Friend WithEvents btnRecip2 As Button
    Friend WithEvents btnRecip1 As Button
    Friend WithEvents grpIngredients As GroupBox
    Friend WithEvents lstIngredients As ListBox
End Class
