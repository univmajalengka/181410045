Imports System.Data.Odbc

Public Class BukuTamu

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from buku_tamu", connected)
        ds = New DataSet
        adapter.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Sub delete()
        koneksi()
        cmd = New OdbcCommand("delete from buku_tamu where id_tamu='" & id_text.Text & "'", connected)
        cmd.ExecuteNonQuery()
    End Sub

    Sub automatic_guest()
        koneksi()
        cmd = New OdbcCommand("select * from buku_tamu order by id_tamu desc", connected)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            id_text.Text = "BKT" + "0001"
        Else
            id_text.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("id_tamu").ToString, 6, 4)) + 1
            If Len(id_text.Text) = 1 Then
                id_text.Text = "BKT000" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 2 Then
                id_text.Text = "BKT00" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 3 Then
                id_text.Text = "BKT0" & id_text.Text & ""
            End If
        End If
        id_text.Enabled = False
    End Sub

    Sub cari()
        koneksi()
        cmd = New OdbcCommand("select * from buku_tamu where id_tamu='" & id_text.Text & "'", connected)
        reader = cmd.ExecuteReader
        reader.Read()
    End Sub

    Sub refreshed()
        nama_text.Clear()
        email_text.Clear()
        url_text.Clear()
        komen_tamu_text.Clear()
        datetime.Text = Format(Today)
        automatic_guest()
    End Sub

    Sub dont_update_it()
        On Error Resume Next
        nama_text.Text = reader("nama_tamu")
        email_text.Text = reader("email_tamu")
        url_text.Text = reader("url_tamu")
        komen_tamu_text.Text = reader("komentar_tamu")
        datetime.Text = reader("tgl_tamu")
    End Sub

    Private Sub BukuTamu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        automatic_guest()
        tampil()
    End Sub

    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click
        If id_text.Text = "" Or nama_text.Text = "" Or email_text.Text = "" Or komen_tamu_text.Text = "" Then
            MsgBox("Harap masukan dengan benar")
            nama_text.Focus()
            Exit Sub
        End If
        Try
            cari()
            If Not reader.HasRows Then
                Dim simpan As String = "insert into buku_tamu values('" & id_text.Text & "', '" & nama_text.Text & "', '" & email_text.Text & "', '" & url_text.Text & "', '" & komen_tamu_text.Text & "', '" & datetime.Text & "')"
                cmd = New OdbcCommand(simpan, connected)
                cmd.ExecuteNonQuery()
            Else
                Dim updt As String = "update buku_tamu set nama_tamu='" & nama_text.Text & "', email_tamu='" & email_text.Text & "', url_tamu='" & url_text.Text & "', komentar_tamu='" & komen_tamu_text.Text & "', tgl_tamu='" & datetime.Text & "' where id_tamu='" & id_text.Text & "'"
                cmd = New OdbcCommand(updt, connected)
                cmd.ExecuteNonQuery()
            End If
            tampil()
            refreshed()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        koneksi()
        If MessageBox.Show("Apakah anda yakin ingin menghapus record ini?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim delet As String = "delete from buku_tamu where id_tamu='" & id_text.Text & "'"
            cmd = New OdbcCommand(delet, connected)
            cmd.ExecuteNonQuery()
            tampil()
            refreshed()
        Else
            refreshed()
        End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        refreshed()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        id_text.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            dont_update_it()
        End If
    End Sub
End Class