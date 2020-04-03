Imports System.Data.Odbc
Public Class DataKomentar

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from data_komentar", connected)
        ds = New DataSet
        adapter.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        id_komen_text.Enabled = False
        otomatis_id_komen()
        otomatis_id_berirta()
    End Sub

    Sub otomatis_id_komen()
        koneksi()
        cmd = New OdbcCommand("select * from data_komentar order by id_komentar desc", connected)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            id_komen_text.Text = "KMT" + "0001"
        Else
            id_komen_text.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("id_komentar").ToString, 6, 4)) + 1
            If Len(id_komen_text.Text) = 1 Then
                id_komen_text.Text = "KMT000" & id_komen_text.Text & ""
            ElseIf Len(id_komen_text.Text) = 2 Then
                id_komen_text.Text = "KMT00" & id_komen_text.Text & ""
            ElseIf Len(id_komen_text.Text) = 3 Then
                id_komen_text.Text = "KMT0" & id_komen_text.Text & ""
            End If
        End If
    End Sub

    Sub otomatis_id_berirta()
        koneksi()
        cmd = New OdbcCommand("select distinct id_news from data_berita", connected)
        reader = cmd.ExecuteReader
        id_news_combo.Items.Clear()
        Do While reader.Read
            id_news_combo.Items.Add(reader("id_news"))
        Loop
    End Sub

    Sub cari()
        koneksi()
        cmd = New OdbcCommand("select * from data_komentar where id_komentar='" & id_komen_text.Text & "'", connected)
        reader = cmd.ExecuteReader
        reader.Read()
    End Sub

    Sub grab()
        On Error Resume Next
        nama_text.Text = reader("nama_komentar")
        email_text.Text = reader("email_komentar")
        url_text.Text = reader("url_komentar")
        isi_text.Text = reader("komentar_isi")
        id_news_combo.Text = reader("id_news")
    End Sub

    Sub refreshed()
        nama_text.Clear()
        email_text.Clear()
        url_text.Clear()
        isi_text.Clear()
        otomatis_id_komen()
        id_news_combo.Text = "-Pilih-"
    End Sub

    Private Sub DataKomentar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        refreshed()
        tampil()
    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        Dispose()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If MessageBox.Show("Apakah anda ingin menghapus record ini?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OdbcCommand("delete from data_komentar where id_komentar=" & id_komen_text.Text & "", connected)
            cmd.ExecuteNonQuery()
            refreshed()
            tampil()
        Else
            refreshed()
            tampil()
        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If nama_text.Text = "" Or email_text.Text = "" Or isi_text.Text = "" Then
            MsgBox("Harap masukan data dengan benar!")
            Exit Sub
        End If
        Try
            cari()
            If Not reader.HasRows Then
                Dim simpan As String = "insert into data_komentar values('" & id_komen_text.Text & "', '" & nama_text.Text & "', '" & email_text.Text & "', '" & url_text.Text & "', '" & isi_text.Text & "', '" & bruh.Text & "', '" & jml_output.Text & "', '" & id_news_combo.Text & "')"
                cmd = New OdbcCommand(simpan, connected)
                cmd.ExecuteNonQuery()
            Else
                Dim updt As String = "update data_komentar set nama_komentar='" & nama_text.Text & "', email_komentar='" & email_text.Text & "', url_komentar='" & url_text.Text & "', komentar_isi='" & isi_text.Text & "', tgl_publish_k='" & bruh.Text & "', jml_komentar='" & jml_output.Text & "', id_news='" & id_news_combo.Text & "' where id_komentar='" & id_komen_text.Text & "'"
                cmd = New OdbcCommand(updt, connected)
                cmd.ExecuteNonQuery()
            End If
            tampil()
            refreshed()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        id_komen_text.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            grab()
        End If
    End Sub
End Class