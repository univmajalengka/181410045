<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPotensi
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.isi_text = New System.Windows.Forms.RichTextBox()
        Me.id_text = New System.Windows.Forms.TextBox()
        Me.title_text = New System.Windows.Forms.TextBox()
        Me.author_text = New System.Windows.Forms.TextBox()
        Me.TimePicker = New System.Windows.Forms.DateTimePicker()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(776, 207)
        Me.DGV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Potensi:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lembaga:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Isi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(628, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(628, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Author:"
        '
        'isi_text
        '
        Me.isi_text.Location = New System.Drawing.Point(77, 252)
        Me.isi_text.Name = "isi_text"
        Me.isi_text.Size = New System.Drawing.Size(545, 156)
        Me.isi_text.TabIndex = 6
        Me.isi_text.Text = ""
        '
        'id_text
        '
        Me.id_text.Location = New System.Drawing.Point(77, 225)
        Me.id_text.Name = "id_text"
        Me.id_text.Size = New System.Drawing.Size(91, 20)
        Me.id_text.TabIndex = 7
        '
        'title_text
        '
        Me.title_text.Location = New System.Drawing.Point(234, 225)
        Me.title_text.Name = "title_text"
        Me.title_text.Size = New System.Drawing.Size(388, 20)
        Me.title_text.TabIndex = 8
        '
        'author_text
        '
        Me.author_text.Location = New System.Drawing.Point(675, 225)
        Me.author_text.Name = "author_text"
        Me.author_text.Size = New System.Drawing.Size(113, 20)
        Me.author_text.TabIndex = 9
        '
        'TimePicker
        '
        Me.TimePicker.CustomFormat = "yyyy-MM-dd"
        Me.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimePicker.Location = New System.Drawing.Point(694, 255)
        Me.TimePicker.Name = "TimePicker"
        Me.TimePicker.Size = New System.Drawing.Size(94, 20)
        Me.TimePicker.TabIndex = 10
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(433, 414)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(112, 23)
        Me.save_btn.TabIndex = 11
        Me.save_btn.Text = "Save/Update"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(551, 414)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.refresh_btn.TabIndex = 12
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(632, 415)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 13
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(713, 415)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 14
        Me.exit_btn.Text = "Quit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'DataPotensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.TimePicker)
        Me.Controls.Add(Me.author_text)
        Me.Controls.Add(Me.title_text)
        Me.Controls.Add(Me.id_text)
        Me.Controls.Add(Me.isi_text)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "DataPotensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataPotensi"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents isi_text As RichTextBox
    Friend WithEvents id_text As TextBox
    Friend WithEvents title_text As TextBox
    Friend WithEvents author_text As TextBox
    Friend WithEvents TimePicker As DateTimePicker
    Friend WithEvents save_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents exit_btn As Button
End Class
