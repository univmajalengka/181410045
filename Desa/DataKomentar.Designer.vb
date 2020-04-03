<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataKomentar
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
        Me.id_komen_text = New System.Windows.Forms.TextBox()
        Me.nama_text = New System.Windows.Forms.TextBox()
        Me.email_text = New System.Windows.Forms.TextBox()
        Me.url_text = New System.Windows.Forms.TextBox()
        Me.isi_text = New System.Windows.Forms.RichTextBox()
        Me.id_news_combo = New System.Windows.Forms.ComboBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        Me.bruh = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.jml_output = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(450, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(338, 426)
        Me.DGV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Komentar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Komentar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "URL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Isi Komentar:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ID Berita:"
        '
        'id_komen_text
        '
        Me.id_komen_text.Location = New System.Drawing.Point(104, 12)
        Me.id_komen_text.Name = "id_komen_text"
        Me.id_komen_text.Size = New System.Drawing.Size(324, 20)
        Me.id_komen_text.TabIndex = 8
        '
        'nama_text
        '
        Me.nama_text.Location = New System.Drawing.Point(104, 38)
        Me.nama_text.Name = "nama_text"
        Me.nama_text.Size = New System.Drawing.Size(324, 20)
        Me.nama_text.TabIndex = 9
        '
        'email_text
        '
        Me.email_text.Location = New System.Drawing.Point(104, 64)
        Me.email_text.Name = "email_text"
        Me.email_text.Size = New System.Drawing.Size(324, 20)
        Me.email_text.TabIndex = 10
        '
        'url_text
        '
        Me.url_text.Location = New System.Drawing.Point(104, 90)
        Me.url_text.Name = "url_text"
        Me.url_text.Size = New System.Drawing.Size(324, 20)
        Me.url_text.TabIndex = 11
        '
        'isi_text
        '
        Me.isi_text.Location = New System.Drawing.Point(104, 116)
        Me.isi_text.Name = "isi_text"
        Me.isi_text.Size = New System.Drawing.Size(324, 210)
        Me.isi_text.TabIndex = 13
        Me.isi_text.Text = ""
        '
        'id_news_combo
        '
        Me.id_news_combo.FormattingEnabled = True
        Me.id_news_combo.Location = New System.Drawing.Point(104, 358)
        Me.id_news_combo.Name = "id_news_combo"
        Me.id_news_combo.Size = New System.Drawing.Size(63, 21)
        Me.id_news_combo.TabIndex = 14
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(12, 415)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(110, 23)
        Me.save_btn.TabIndex = 15
        Me.save_btn.Text = "Save/Update"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(128, 415)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.refresh_btn.TabIndex = 16
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(209, 415)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 17
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.Location = New System.Drawing.Point(290, 415)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(75, 23)
        Me.quit_btn.TabIndex = 18
        Me.quit_btn.Text = "Quit"
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'bruh
        '
        Me.bruh.CustomFormat = "yyyy-MM-dd"
        Me.bruh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bruh.Location = New System.Drawing.Point(104, 332)
        Me.bruh.Name = "bruh"
        Me.bruh.Size = New System.Drawing.Size(324, 20)
        Me.bruh.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Tanggal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(326, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Jumlah Komentar:"
        '
        'jml_output
        '
        Me.jml_output.Enabled = False
        Me.jml_output.Location = New System.Drawing.Point(349, 377)
        Me.jml_output.Name = "jml_output"
        Me.jml_output.Size = New System.Drawing.Size(37, 20)
        Me.jml_output.TabIndex = 22
        Me.jml_output.Text = "0"
        Me.jml_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataKomentar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.jml_output)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bruh)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.id_news_combo)
        Me.Controls.Add(Me.isi_text)
        Me.Controls.Add(Me.url_text)
        Me.Controls.Add(Me.email_text)
        Me.Controls.Add(Me.nama_text)
        Me.Controls.Add(Me.id_komen_text)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "DataKomentar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Komentar"
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
    Friend WithEvents id_komen_text As TextBox
    Friend WithEvents nama_text As TextBox
    Friend WithEvents email_text As TextBox
    Friend WithEvents url_text As TextBox
    Friend WithEvents isi_text As RichTextBox
    Friend WithEvents id_news_combo As ComboBox
    Friend WithEvents save_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents quit_btn As Button
    Friend WithEvents bruh As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents jml_output As TextBox
End Class
