<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmA15
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
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.JusticeDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JusticeDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDisplay
        '
        Me.dgvDisplay.AutoGenerateColumns = False
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.DataSource = Me.JusticeDataBindingSource
        Me.dgvDisplay.Location = New System.Drawing.Point(20, 20)
        Me.dgvDisplay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.RowHeadersVisible = False
        Me.dgvDisplay.RowHeadersWidth = 51
        Me.dgvDisplay.RowTemplate.Height = 24
        Me.dgvDisplay.Size = New System.Drawing.Size(741, 619)
        Me.dgvDisplay.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(20, 648)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(112, 36)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(142, 648)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 36)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'JusticeDataBindingSource
        '
        Me.JusticeDataBindingSource.DataSource = GetType(CS146_A15.JusticeData)
        '
        'frmA15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 703)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmA15"
        Me.Text = "A15 - Justice Appointments"
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JusticeDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDisplay As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents JusticeDataBindingSource As BindingSource
End Class
