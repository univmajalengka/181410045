<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Berita_isi
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
        Me.Judul_text = New System.Windows.Forms.Label()
        Me.isi_text = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Judul_text
        '
        Me.Judul_text.AutoSize = True
        Me.Judul_text.Location = New System.Drawing.Point(361, 9)
        Me.Judul_text.Name = "Judul_text"
        Me.Judul_text.Size = New System.Drawing.Size(39, 13)
        Me.Judul_text.TabIndex = 0
        Me.Judul_text.Text = "Label1"
        '
        'isi_text
        '
        Me.isi_text.AutoSize = True
        Me.isi_text.Location = New System.Drawing.Point(92, 79)
        Me.isi_text.Name = "isi_text"
        Me.isi_text.Size = New System.Drawing.Size(39, 13)
        Me.isi_text.TabIndex = 1
        Me.isi_text.Text = "Label2"
        '
        'Berita_isi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.isi_text)
        Me.Controls.Add(Me.Judul_text)
        Me.Name = "Berita_isi"
        Me.Text = "Berita_isi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Judul_text As Label
    Friend WithEvents isi_text As Label
End Class
