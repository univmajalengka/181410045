Imports System.Data.Odbc
Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Sub delete()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        Label1.Text = ""
        UsernameTextBox.Focus()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        koneksi()
        UsernameTextBox.Focus()
        cmd = New OdbcCommand("select * from data_user where username='" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "'", connected)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            Me.Visible = False
            Frontend.Show()
            If reader.HasRows Then
                Frontend.Label1.Text = reader("username")
                Frontend.Label2.Text = reader("nama_lengkap")
                Frontend.Label3.Text = reader(UCase("level"))
                If Frontend.Label3.Text <> "Admin" Then
                    Frontend.DataUserToolStripMenuItem.Visible = False
                    Frontend.DataProfilToolStripMenuItem.Visible = False
                    Frontend.DataKomentarToolStripMenuItem.Visible = False
                Else
                    Frontend.DataUserToolStripMenuItem.Visible = True
                    Frontend.DataProfilToolStripMenuItem.Visible = True
                End If
            End If
            delete()
        Else
            Label1.Text = "Username atau password salah!"
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
        'Frontend.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
    End Sub
End Class
