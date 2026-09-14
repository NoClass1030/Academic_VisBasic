<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmA14
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpEngSentence = New System.Windows.Forms.GroupBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtOrigSentence = New System.Windows.Forms.TextBox()
        Me.grpTextese = New System.Windows.Forms.GroupBox()
        Me.txtTextese = New System.Windows.Forms.TextBox()
        Me.grpConvList = New System.Windows.Forms.GroupBox()
        Me.dgvConvList = New System.Windows.Forms.DataGridView()
        Me.grpEngSentence.SuspendLayout()
        Me.grpTextese.SuspendLayout()
        Me.grpConvList.SuspendLayout()
        CType(Me.dgvConvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEngSentence
        '
        Me.grpEngSentence.Controls.Add(Me.btnConvert)
        Me.grpEngSentence.Controls.Add(Me.txtOrigSentence)
        Me.grpEngSentence.Location = New System.Drawing.Point(13, 13)
        Me.grpEngSentence.Name = "grpEngSentence"
        Me.grpEngSentence.Size = New System.Drawing.Size(427, 58)
        Me.grpEngSentence.TabIndex = 0
        Me.grpEngSentence.TabStop = False
        Me.grpEngSentence.Text = "English Sentence"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(346, 22)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtOrigSentence
        '
        Me.txtOrigSentence.Location = New System.Drawing.Point(7, 22)
        Me.txtOrigSentence.Name = "txtOrigSentence"
        Me.txtOrigSentence.Size = New System.Drawing.Size(333, 22)
        Me.txtOrigSentence.TabIndex = 0
        '
        'grpTextese
        '
        Me.grpTextese.Controls.Add(Me.txtTextese)
        Me.grpTextese.Location = New System.Drawing.Point(13, 249)
        Me.grpTextese.Name = "grpTextese"
        Me.grpTextese.Size = New System.Drawing.Size(427, 58)
        Me.grpTextese.TabIndex = 2
        Me.grpTextese.TabStop = False
        Me.grpTextese.Text = "Textese Sentence"
        '
        'txtTextese
        '
        Me.txtTextese.Location = New System.Drawing.Point(7, 22)
        Me.txtTextese.Name = "txtTextese"
        Me.txtTextese.ReadOnly = True
        Me.txtTextese.Size = New System.Drawing.Size(414, 22)
        Me.txtTextese.TabIndex = 0
        '
        'grpConvList
        '
        Me.grpConvList.Controls.Add(Me.dgvConvList)
        Me.grpConvList.Location = New System.Drawing.Point(447, 13)
        Me.grpConvList.Name = "grpConvList"
        Me.grpConvList.Size = New System.Drawing.Size(286, 354)
        Me.grpConvList.TabIndex = 3
        Me.grpConvList.TabStop = False
        Me.grpConvList.Text = "Conversion List"
        '
        'dgvConvList
        '
        Me.dgvConvList.AllowUserToDeleteRows = False
        Me.dgvConvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvConvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConvList.Location = New System.Drawing.Point(6, 21)
        Me.dgvConvList.Name = "dgvConvList"
        Me.dgvConvList.ReadOnly = True
        Me.dgvConvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvConvList.RowHeadersVisible = False
        Me.dgvConvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgvConvList.RowTemplate.Height = 24
        Me.dgvConvList.Size = New System.Drawing.Size(274, 326)
        Me.dgvConvList.TabIndex = 0
        '
        'frmA14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 379)
        Me.Controls.Add(Me.grpConvList)
        Me.Controls.Add(Me.grpTextese)
        Me.Controls.Add(Me.grpEngSentence)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmA14"
        Me.Text = "A14 - Textese Conversion"
        Me.grpEngSentence.ResumeLayout(False)
        Me.grpEngSentence.PerformLayout()
        Me.grpTextese.ResumeLayout(False)
        Me.grpTextese.PerformLayout()
        Me.grpConvList.ResumeLayout(False)
        CType(Me.dgvConvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpEngSentence As GroupBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtOrigSentence As TextBox
    Friend WithEvents grpTextese As GroupBox
    Friend WithEvents txtTextese As TextBox
    Friend WithEvents grpConvList As GroupBox
    Friend WithEvents dgvConvList As DataGridView
End Class
