<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataUser
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
        Me.name_text = New System.Windows.Forms.TextBox()
        Me.username_text = New System.Windows.Forms.TextBox()
        Me.passwd_text = New System.Windows.Forms.TextBox()
        Me.level_combo = New System.Windows.Forms.ComboBox()
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
        Me.DGV.Location = New System.Drawing.Point(381, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(407, 220)
        Me.DGV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Level:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama Lengkap:"
        '
        'name_text
        '
        Me.name_text.Location = New System.Drawing.Point(105, 23)
        Me.name_text.Name = "name_text"
        Me.name_text.Size = New System.Drawing.Size(270, 20)
        Me.name_text.TabIndex = 5
        '
        'username_text
        '
        Me.username_text.Location = New System.Drawing.Point(105, 49)
        Me.username_text.Name = "username_text"
        Me.username_text.Size = New System.Drawing.Size(270, 20)
        Me.username_text.TabIndex = 6
        '
        'passwd_text
        '
        Me.passwd_text.Location = New System.Drawing.Point(105, 75)
        Me.passwd_text.Name = "passwd_text"
        Me.passwd_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(111)
        Me.passwd_text.Size = New System.Drawing.Size(270, 20)
        Me.passwd_text.TabIndex = 7
        '
        'level_combo
        '
        Me.level_combo.FormattingEnabled = True
        Me.level_combo.Items.AddRange(New Object() {"Admin", "User"})
        Me.level_combo.Location = New System.Drawing.Point(105, 101)
        Me.level_combo.Name = "level_combo"
        Me.level_combo.Size = New System.Drawing.Size(270, 21)
        Me.level_combo.TabIndex = 8
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(35, 163)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(97, 23)
        Me.save_btn.TabIndex = 9
        Me.save_btn.Text = "Save/Update"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(138, 163)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.refresh_btn.TabIndex = 10
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(219, 163)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 11
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(300, 163)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 12
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'DataUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 244)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.level_combo)
        Me.Controls.Add(Me.passwd_text)
        Me.Controls.Add(Me.username_text)
        Me.Controls.Add(Me.name_text)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "DataUser"
        Me.Text = "DataUser"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents name_text As TextBox
    Friend WithEvents username_text As TextBox
    Friend WithEvents passwd_text As TextBox
    Friend WithEvents level_combo As ComboBox
    Friend WithEvents save_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents exit_btn As Button
End Class
