<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BukuTamu
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
        Me.nama_text = New System.Windows.Forms.TextBox()
        Me.email_text = New System.Windows.Forms.TextBox()
        Me.url_text = New System.Windows.Forms.TextBox()
        Me.komen_tamu_text = New System.Windows.Forms.TextBox()
        Me.datetime = New System.Windows.Forms.DateTimePicker()
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(799, 266)
        Me.DGV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Tamu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Tamu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email Tamu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "URL Tamu:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(441, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Komentar Tamu:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(441, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tanggal:"
        '
        'id_text
        '
        Me.id_text.Location = New System.Drawing.Point(86, 290)
        Me.id_text.Name = "id_text"
        Me.id_text.Size = New System.Drawing.Size(297, 20)
        Me.id_text.TabIndex = 7
        '
        'nama_text
        '
        Me.nama_text.Location = New System.Drawing.Point(86, 316)
        Me.nama_text.Name = "nama_text"
        Me.nama_text.Size = New System.Drawing.Size(297, 20)
        Me.nama_text.TabIndex = 8
        '
        'email_text
        '
        Me.email_text.Location = New System.Drawing.Point(86, 342)
        Me.email_text.Name = "email_text"
        Me.email_text.Size = New System.Drawing.Size(297, 20)
        Me.email_text.TabIndex = 9
        '
        'url_text
        '
        Me.url_text.Location = New System.Drawing.Point(86, 368)
        Me.url_text.Name = "url_text"
        Me.url_text.Size = New System.Drawing.Size(297, 20)
        Me.url_text.TabIndex = 10
        '
        'komen_tamu_text
        '
        Me.komen_tamu_text.Location = New System.Drawing.Point(532, 290)
        Me.komen_tamu_text.Name = "komen_tamu_text"
        Me.komen_tamu_text.Size = New System.Drawing.Size(200, 20)
        Me.komen_tamu_text.TabIndex = 11
        '
        'datetime
        '
        Me.datetime.CustomFormat = "yyyy-MM-dd"
        Me.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetime.Location = New System.Drawing.Point(532, 319)
        Me.datetime.Name = "datetime"
        Me.datetime.Size = New System.Drawing.Size(200, 20)
        Me.datetime.TabIndex = 12
        '
        'ok_btn
        '
        Me.ok_btn.Location = New System.Drawing.Point(5, 416)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(93, 23)
        Me.ok_btn.TabIndex = 13
        Me.ok_btn.Text = "Save/Update"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(104, 416)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 14
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(185, 416)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.refresh_btn.TabIndex = 15
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'BukuTamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 448)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.datetime)
        Me.Controls.Add(Me.komen_tamu_text)
        Me.Controls.Add(Me.url_text)
        Me.Controls.Add(Me.email_text)
        Me.Controls.Add(Me.nama_text)
        Me.Controls.Add(Me.id_text)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "BukuTamu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buku Tamu"
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
    Friend WithEvents nama_text As TextBox
    Friend WithEvents email_text As TextBox
    Friend WithEvents url_text As TextBox
    Friend WithEvents komen_tamu_text As TextBox
    Friend WithEvents datetime As DateTimePicker
    Friend WithEvents ok_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents refresh_btn As Button
End Class
