<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Berita_2d
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_label = New System.Windows.Forms.Label()
        Me.title_label = New System.Windows.Forms.Label()
        Me.read_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(776, 344)
        Me.DGV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Berita:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Judul Berita:"
        '
        'id_label
        '
        Me.id_label.AutoSize = True
        Me.id_label.Location = New System.Drawing.Point(83, 411)
        Me.id_label.Name = "id_label"
        Me.id_label.Size = New System.Drawing.Size(39, 13)
        Me.id_label.TabIndex = 3
        Me.id_label.Text = "Label3"
        '
        'title_label
        '
        Me.title_label.AutoSize = True
        Me.title_label.Location = New System.Drawing.Point(83, 385)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(39, 13)
        Me.title_label.TabIndex = 4
        Me.title_label.Text = "Label4"
        '
        'read_btn
        '
        Me.read_btn.Location = New System.Drawing.Point(405, 373)
        Me.read_btn.Name = "read_btn"
        Me.read_btn.Size = New System.Drawing.Size(124, 65)
        Me.read_btn.TabIndex = 5
        Me.read_btn.Text = "Read!"
        Me.read_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Location = New System.Drawing.Point(535, 373)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(124, 65)
        Me.edit_btn.TabIndex = 6
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.Location = New System.Drawing.Point(665, 373)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(124, 65)
        Me.quit_btn.TabIndex = 7
        Me.quit_btn.Text = "Exit"
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'Berita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.edit_btn)
        Me.Controls.Add(Me.read_btn)
        Me.Controls.Add(Me.title_label)
        Me.Controls.Add(Me.id_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "Berita"
        Me.Text = "Berita"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id_label As Label
    Friend WithEvents title_label As Label
    Friend WithEvents read_btn As Button
    Friend WithEvents edit_btn As Button
    Friend WithEvents quit_btn As Button
End Class
