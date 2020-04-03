Imports System.Data.Odbc
Public Class DataPengumuman

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from data_pengumuman", connected)
        ds = New DataSet
        adapter.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        jml_text.Text = "0"
        jml_text.Enabled = False
        sender_text.Text = Frontend.Label1.Text
        sender_text.Enabled = False
    End Sub

    Sub automatic_id()
        koneksi()
        cmd = New OdbcCommand("select * from data_pengumuman order by id_pengumuman desc", connected)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            id_text.Text = "PEG" + "0001"
        Else
            id_text.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("id_pengumuman").ToString, 6, 4)) + 1
            If Len(id_text.Text) = 1 Then
                id_text.Text = "PEG000" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 2 Then
                id_text.Text = "PEG00" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 3 Then
                id_text.Text = "PEG0" & id_text.Text & ""
            End If
        End If
        id_text.Enabled = False
    End Sub

    Sub cari()
        koneksi()
        cmd = New OdbcCommand("select * from data_pengumuman where id_pengumuman='" & id_text.Text & "'", connected)
        reader = cmd.ExecuteReader
        reader.Read()
    End Sub

    Sub refreshed()
        title_text.Clear()
        isi_text.Clear()
        timepicker.Text = Format(Today)
        automatic_id()
    End Sub

    Sub grab()
        On Error Resume Next
        title_text.Text = reader("judul_pengumuman")
        sender_text.Text = reader("pengirim_pengumuman")
        isi_text.Text = reader("isi_pengumuman")
        jml_text.Text = reader("jml_baca")
        timepicker.Text = reader("tgl_publish_p")
    End Sub

    Private Sub DataPengumuman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        automatic_id()
    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        Dispose()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If MessageBox.Show("Apakah anda yakin ingin menghapus record ini?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OdbcCommand("delete from data_pengumuman where id_pengumuman='" & id_text.Text & "'", connected)
            cmd.ExecuteNonQuery()
            tampil()
            refreshed()
        Else
            tampil()
            refreshed()
        End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        refreshed()
        tampil()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If title_text.Text = "" Or isi_text.Text = "" Then
            MsgBox("Masukan data dengan benar!")
            Exit Sub
        End If
        Try
            cari()
            If Not reader.HasRows Then
                Dim saved As String = "insert into data_pengumuman values('" & id_text.Text & "', '" & title_text.Text & "', '" & isi_text.Text & "', '" & sender_text.Text & "', '" & jml_text.Text & "', '" & timepicker.Text & "')"
                cmd = New OdbcCommand(saved, connected)
                cmd.ExecuteNonQuery()
            Else
                Dim updt As String = "update data_pengumuman set judul_pengumuman='" & title_text.Text & "', isi_pengumuman='" & isi_text.Text & "', pengirim_pengumuman='" & sender_text.Text & "', jml_baca='" & jml_text.Text & "', tgl_publish_p='" & timepicker.Text & "' where id_pengumuman='" & id_text.Text & "'"
                cmd = New OdbcCommand(updt, connected)
                cmd.ExecuteNonQuery()
            End If
            tampil()
            refreshed()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        id_text.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            grab()
        End If
    End Sub
End Class