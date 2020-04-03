Imports System.Data.Odbc
Public Class Berita_momen

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from data_berita", connected)
        ds = New DataSet
        adapter.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        jml_baca_text.Enabled = False
        jml_baca_text.Text = "0"
        sender_text.Text = Frontend.Label1.Text
        sender_text.Enabled = False
    End Sub

    Sub refreshed()
        title_text.Clear()
        'sender_text.Clear()
        isi_rich_text.Clear()
        jml_baca_text.Clear()
        timepicker.Text = Format(Today)
        title_text.Focus()
        automatic()
    End Sub

    Sub grab()
        On Error Resume Next
        id_text.Text = reader("id_news")
        title_text.Text = reader("judul_berita")
        sender_text.Text = reader("pengirim_berita")
        isi_rich_text.Text = reader("berita_isi")
        jml_baca_text.Text = reader("jml_baca")
        timepicker.Text = reader("tgl_publish")
    End Sub

    Sub cari()
        koneksi()
        cmd = New OdbcCommand("select * from data_berita where id_news='" & id_text.Text & "'", connected)
        reader = cmd.ExecuteReader
        reader.Read()
    End Sub

    Sub automatic()
        koneksi()
        cmd = New OdbcCommand("select * from data_berita order by id_news desc", connected)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            id_text.Text = "NW" + "0001"
        Else
            id_text.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("id_news").ToString, 6, 4)) + 1
            If Len(id_text.Text) = 1 Then
                id_text.Text = "NW000" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 2 Then
                id_text.Text = "NW00" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 3 Then
                id_text.Text = "NW0" & id_text.Text & ""
            End If
        End If
        id_text.Enabled = False
    End Sub

    Private Sub Berita_momen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        automatic()
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Dispose()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        koneksi()
        If MessageBox.Show("Apakah anda yakin ingin menghapus Record ini?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim del As String = "delete from data_berita where id_news='" & id_text.Text & "'"
            cmd = New OdbcCommand(del, connected)
            cmd.ExecuteNonQuery()
            refresh()
            tampil()
        Else
            refreshed()
        End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        refreshed()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If title_text.Text = "" Or isi_rich_text.Text = "" Then
            MsgBox("Harap masukan Data dengan benar!")
            Exit Sub
        End If
        Try
            cari()
            If Not reader.HasRows Then
                Dim saved As String = "insert into data_berita values('" & id_text.Text & "', '" & title_text.Text & "', '" & isi_rich_text.Text & "', '" & sender_text.Text & "', '" & jml_baca_text.Text & "', '" & timepicker.Text & "')"
                cmd = New OdbcCommand(saved, connected)
                cmd.ExecuteNonQuery()
            Else
                Dim updt As String = "update data_berita set judul_berita='" & title_text.Text & "', berita_isi='" & isi_rich_text.Text & "', pengirim_berita='" & sender_text.Text & "', jml_baca='" & jml_baca_text.Text & "', tgl_publish='" & timepicker.Text & "' where id_news='" & id_text.Text & "'"
                cmd = New OdbcCommand(updt, connected)
                cmd.ExecuteNonQuery()
            End If
            refreshed()
            tampil()
            'automatic()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_CellMouceClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        id_text.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            grab()
        End If
    End Sub
End Class