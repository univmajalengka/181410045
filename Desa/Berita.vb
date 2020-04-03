Imports System.Data.Odbc
Public Class Berita_2d

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select id_news, judul_berita from data_berita", connected)
        ds = New DataSet
        adapter.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Sub de()
        On Error Resume Next
        title_label.Text = reader("judul_berita")
    End Sub

    Sub cari()
        koneksi()
        cmd = New OdbcCommand("select * from data_berita where id_news='" & id_label.Text & "'", connected)
        reader = cmd.ExecuteReader
        reader.Read()
    End Sub

    Private Sub Berita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        id_label.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            de()
        End If

    End Sub

    Private Sub read_text_Click(sender As Object, e As EventArgs) Handles read_btn.Click
        koneksi()
        tampil()
        cari()
        Berita_isi.Show()
        If reader.HasRows Then
            Berita_isi.Judul_text.Text = reader.Item("judul_berita")
            Berita_isi.isi_text.Text = reader.Item("berita_isi")
        End If
    End Sub

    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click

    End Sub
End Class