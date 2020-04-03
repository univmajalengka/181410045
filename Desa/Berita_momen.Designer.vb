<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Berita_momen
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.id_text = New System.Windows.Forms.TextBox()
        Me.title_text = New System.Windows.Forms.TextBox()
        Me.sender_text = New System.Windows.Forms.TextBox()
        Me.jml_baca_text = New System.Windows.Forms.TextBox()
        Me.isi_rich_text = New System.Windows.Forms.RichTextBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.timepicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(776, 250)
        Me.DGV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Berita:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Judul Berita:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Isi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(570, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pengirim:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(570, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jumlah Baca:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(570, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tanggal:"
        '
        'id_text
        '
        Me.id_text.Location = New System.Drawing.Point(66, 278)
        Me.id_text.Name = "id_text"
        Me.id_text.Size = New System.Drawing.Size(111, 20)
        Me.id_text.TabIndex = 7
        '
        'title_text
        '
        Me.title_text.Location = New System.Drawing.Point(254, 278)
        Me.title_text.Name = "title_text"
        Me.title_text.Size = New System.Drawing.Size(310, 20)
        Me.title_text.TabIndex = 8
        '
        'sender_text
        '
        Me.sender_text.Location = New System.Drawing.Point(647, 278)
        Me.sender_text.Name = "sender_text"
        Me.sender_text.Size = New System.Drawing.Size(141, 20)
        Me.sender_text.TabIndex = 9
        '
        'jml_baca_text
        '
        Me.jml_baca_text.Location = New System.Drawing.Point(647, 304)
        Me.jml_baca_text.Name = "jml_baca_text"
        Me.jml_baca_text.Size = New System.Drawing.Size(35, 20)
        Me.jml_baca_text.TabIndex = 10
        '
        'isi_rich_text
        '
        Me.isi_rich_text.Location = New System.Drawing.Point(66, 304)
        Me.isi_rich_text.Name = "isi_rich_text"
        Me.isi_rich_text.Size = New System.Drawing.Size(498, 138)
        Me.isi_rich_text.TabIndex = 11
        Me.isi_rich_text.Text = ""
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(66, 448)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(115, 23)
        Me.save_btn.TabIndex = 12
        Me.save_btn.Text = "Save/Update"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(187, 448)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.refresh_btn.TabIndex = 13
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(268, 448)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 14
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(349, 448)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 15
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'timepicker
        '
        Me.timepicker.CustomFormat = "yyyy-MM-dd"
        Me.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timepicker.Location = New System.Drawing.Point(647, 330)
        Me.timepicker.Name = "timepicker"
        Me.timepicker.Size = New System.Drawing.Size(94, 20)
        Me.timepicker.TabIndex = 16
        '
        'Berita_momen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.timepicker)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.isi_rich_text)
        Me.Controls.Add(Me.jml_baca_text)
        Me.Controls.Add(Me.sender_text)
        Me.Controls.Add(Me.title_text)
        Me.Controls.Add(Me.id_text)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "Berita_momen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Berita_momen"
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
    Friend WithEvents Label6 As Label
    Friend WithEvents id_text As TextBox
    Friend WithEvents title_text As TextBox
    Friend WithEvents sender_text As TextBox
    Friend WithEvents jml_baca_text As TextBox
    Friend WithEvents isi_rich_text As RichTextBox
    Friend WithEvents save_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents timepicker As DateTimePicker
End Class
