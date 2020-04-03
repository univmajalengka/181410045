<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPengumuman
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
        Me.jml_text = New System.Windows.Forms.TextBox()
        Me.isi_text = New System.Windows.Forms.RichTextBox()
        Me.timepicker = New System.Windows.Forms.DateTimePicker()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(776, 209)
        Me.DGV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Pengumuman:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Judul:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Isi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(632, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pengirim:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(632, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jumlah Baca:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(632, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tanggal:"
        '
        'id_text
        '
        Me.id_text.Location = New System.Drawing.Point(121, 242)
        Me.id_text.Name = "id_text"
        Me.id_text.Size = New System.Drawing.Size(75, 20)
        Me.id_text.TabIndex = 7
        '
        'title_text
        '
        Me.title_text.Location = New System.Drawing.Point(252, 241)
        Me.title_text.Name = "title_text"
        Me.title_text.Size = New System.Drawing.Size(374, 20)
        Me.title_text.TabIndex = 8
        '
        'sender_text
        '
        Me.sender_text.Location = New System.Drawing.Point(688, 242)
        Me.sender_text.Name = "sender_text"
        Me.sender_text.Size = New System.Drawing.Size(100, 20)
        Me.sender_text.TabIndex = 10
        '
        'jml_text
        '
        Me.jml_text.Location = New System.Drawing.Point(709, 268)
        Me.jml_text.Name = "jml_text"
        Me.jml_text.Size = New System.Drawing.Size(79, 20)
        Me.jml_text.TabIndex = 11
        '
        'isi_text
        '
        Me.isi_text.Location = New System.Drawing.Point(121, 271)
        Me.isi_text.Name = "isi_text"
        Me.isi_text.Size = New System.Drawing.Size(505, 131)
        Me.isi_text.TabIndex = 12
        Me.isi_text.Text = ""
        '
        'timepicker
        '
        Me.timepicker.CustomFormat = "yyyy-MM-dd"
        Me.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timepicker.Location = New System.Drawing.Point(709, 294)
        Me.timepicker.Name = "timepicker"
        Me.timepicker.Size = New System.Drawing.Size(79, 20)
        Me.timepicker.TabIndex = 13
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(440, 415)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(105, 23)
        Me.save_btn.TabIndex = 14
        Me.save_btn.Text = "Save/Update"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(551, 415)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.refresh_btn.TabIndex = 15
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(632, 415)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 16
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.Location = New System.Drawing.Point(713, 415)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(75, 23)
        Me.quit_btn.TabIndex = 17
        Me.quit_btn.Text = "Quit"
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'DataPengumuman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.timepicker)
        Me.Controls.Add(Me.isi_text)
        Me.Controls.Add(Me.jml_text)
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
        Me.Name = "DataPengumuman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pengumuman"
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
    Friend WithEvents jml_text As TextBox
    Friend WithEvents isi_text As RichTextBox
    Friend WithEvents timepicker As DateTimePicker
    Friend WithEvents save_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents quit_btn As Button
End Class
