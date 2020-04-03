Public Class Frontend
    Private Sub BukuTamuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuTamuToolStripMenuItem.Click
        BukuTamu.Show()
    End Sub

    Private Sub Frontend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ThisSourceCodeCanBeSeenAtHereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThisSourceCodeCanBeSeenAtHereToolStripMenuItem.Click
        Process.Start("https://github.com/univmajalengka/181410045")
    End Sub

    Private Sub BeritaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeritaToolStripMenuItem.Click
        Berita_momen.Show()
    End Sub

    Private Sub DataKomentarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKomentarToolStripMenuItem.Click
        DataKomentar.Show()
    End Sub

    Private Sub DataProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataProfilToolStripMenuItem.Click
        DataProfil.Show()
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        DataUser.Show()
    End Sub

    Private Sub PotensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PotensiToolStripMenuItem.Click
        DataPotensi.Show()
    End Sub

    Private Sub PengmumanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengmumanToolStripMenuItem.Click
        DataPengumuman.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub
End Class
