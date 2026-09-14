<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQandAXML
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SkillLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.BeginnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SkillLevelToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(542, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SkillLevelToolStripMenuItem
        '
        Me.SkillLevelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeginnerToolStripMenuItem, Me.IntermediateToolStripMenuItem, Me.AdvancedToolStripMenuItem})
        Me.SkillLevelToolStripMenuItem.Name = "SkillLevelToolStripMenuItem"
        Me.SkillLevelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SkillLevelToolStripMenuItem.Size = New System.Drawing.Size(88, 26)
        Me.SkillLevelToolStripMenuItem.Text = "Skill Level"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(13, 32)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(60, 16)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "Question"
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(16, 52)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.Size = New System.Drawing.Size(504, 22)
        Me.txtQuestion.TabIndex = 2
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(16, 97)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(504, 22)
        Me.txtAnswer.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(13, 77)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(51, 16)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Text = "Answer"
        '
        'BeginnerToolStripMenuItem
        '
        Me.BeginnerToolStripMenuItem.Name = "BeginnerToolStripMenuItem"
        Me.BeginnerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BeginnerToolStripMenuItem.Text = "Beginner"
        '
        'IntermediateToolStripMenuItem
        '
        Me.IntermediateToolStripMenuItem.Name = "IntermediateToolStripMenuItem"
        Me.IntermediateToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.IntermediateToolStripMenuItem.Text = "Intermediate"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AdvancedToolStripMenuItem.Text = "Advanced"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(16, 126)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(42, 16)
        Me.lblTimer.TabIndex = 5
        Me.lblTimer.Text = "Timer"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(84, 126)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(436, 51)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit Answer"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(13, 211)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.RowHeadersWidth = 51
        Me.dgvResults.RowTemplate.Height = 24
        Me.dgvResults.Size = New System.Drawing.Size(507, 204)
        Me.dgvResults.TabIndex = 7
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(13, 189)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(52, 16)
        Me.lblResults.TabIndex = 8
        Me.lblResults.Text = "Results"
        '
        'frmQandAXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 437)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmQandAXML"
        Me.Text = "frmQandAXML"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SkillLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents BeginnerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntermediateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents lblResults As Label
End Class
