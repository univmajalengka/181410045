<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataProfil
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
        Me.id_text = New System.Windows.Forms.TextBox()
        Me.nama_text = New System.Windows.Forms.TextBox()
        Me.ket_text = New System.Windows.Forms.TextBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.username_text = New System.Windows.Forms.ComboBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(411, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(377, 426)
        Me.DGV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Profil:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Keterangan:"
        '
        'id_text
        '
        Me.id_text.Location = New System.Drawing.Point(83, 12)
        Me.id_text.Name = "id_text"
        Me.id_text.Size = New System.Drawing.Size(322, 20)
        Me.id_text.TabIndex = 5
        '
        'nama_text
        '
        Me.nama_text.Location = New System.Drawing.Point(83, 38)
        Me.nama_text.Name = "nama_text"
        Me.nama_text.Size = New System.Drawing.Size(322, 20)
        Me.nama_text.TabIndex = 6
        '
        'ket_text
        '
        Me.ket_text.Location = New System.Drawing.Point(83, 90)
        Me.ket_text.Name = "ket_text"
        Me.ket_text.Size = New System.Drawing.Size(322, 20)
        Me.ket_text.TabIndex = 8
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(65, 153)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(97, 23)
        Me.save_btn.TabIndex = 9
        Me.save_btn.Text = "Save/Update"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(168, 153)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.refresh_btn.TabIndex = 10
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(249, 153)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 11
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(330, 153)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 12
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'username_text
        '
        Me.username_text.FormattingEnabled = True
        Me.username_text.Location = New System.Drawing.Point(83, 63)
        Me.username_text.Name = "username_text"
        Me.username_text.Size = New System.Drawing.Size(322, 21)
        Me.username_text.TabIndex = 13
        '
        'DataProfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.username_text)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.ket_text)
        Me.Controls.Add(Me.nama_text)
        Me.Controls.Add(Me.id_text)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "DataProfil"
        Me.Text = "DataProfil"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents id_text As TextBox
    Friend WithEvents nama_text As TextBox
    Friend WithEvents ket_text As TextBox
    Friend WithEvents save_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents username_text As ComboBox
End Class
