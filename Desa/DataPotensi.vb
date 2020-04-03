Imports System.Data.Odbc

Public Class DataPotensi

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from data_potensi", connected)
        ds = New DataSet
        adapter.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        author_text.Text = Frontend.Label1.Text
        author_text.Enabled = False
    End Sub

    Sub automatic_id()
        koneksi()
        cmd = New OdbcCommand("select * from data_potensi order by id_potensi desc", connected)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            id_text.Text = "POT" + "0001"
        Else
            id_text.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("id_potensi").ToString, 6, 4)) + 1
            If Len(id_text.Text) = 1 Then
                id_text.Text = "POT000" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 2 Then
                id_text.Text = "POT00" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 3 Then
                id_text.Text = "POT0" & id_text.Text & ""
            End If
        End If
        id_text.Enabled = False
    End Sub

    Sub refreshed()
        automatic_id()
        title_text.Clear()
        isi_text.Clear()
        TimePicker.Text = Format(Today)
    End Sub

    Sub grab()
        On Error Resume Next
        title_text.Text = reader("nama_potensi")
        author_text.Text = reader("username")
        isi_text.Text = reader("potensi_isi")
        TimePicker.Text = reader("tgl_publish_po")
    End Sub

    Sub cari()
        koneksi()
        cmd = New OdbcCommand("select * from data_potensi where id_potensi='" & id_text.Text & "'", connected)
        reader = cmd.ExecuteReader
        reader.Read()
    End Sub


    Private Sub DataPotensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        automatic_id()
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Dispose()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If MessageBox.Show("Apakah anda yakin ingin menghapus record ini?", "Warning!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OdbcCommand("delete from data_potensi where id_potensi='" & id_text.Text & "'", connected)
            cmd.ExecuteNonQuery()
            refreshed()
            tampil()
        Else
            refreshed()
            tampil()
        End If

    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        tampil()
        refreshed()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If title_text.Text = "" Or isi_text.Text = "" Or author_text.Text = "" Then
            MsgBox("Masukan data dengan benar!")
            Exit Sub
        End If
        Try
            cari()
            If Not reader.HasRows Then
                Dim saved As String = "insert into data_potensi values('" & id_text.Text & "', '" & title_text.Text & "', '" & isi_text.Text & "', '" & TimePicker.Text & "', '" & author_text.Text & "')"
                cmd = New OdbcCommand(saved, connected)
                cmd.ExecuteNonQuery()
            Else
                Dim updt As String = "update data_potensi set nama_potensi='" & title_text.Text & "', potensi_isi='" & isi_text.Text & "', tgl_publish_po='" & TimePicker.Text & "', username='" & author_text.Text & "' where id_potensi='" & id_text.Text & "'"
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
        id_text.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            grab()
        End If
    End Sub
End Class