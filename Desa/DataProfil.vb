Imports System.Data.Odbc

Public Class DataProfil

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from data_profil", connected)
        ds = New DataSet
        adapter.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        nama_text.Focus()
        username_text.Text = "-"
    End Sub

    Sub refreshed()
        automatic()
        nama_text.Clear()
        username_text.Text = "-"
        ket_text.Clear()
        nama_text.Focus()
    End Sub

    Sub cari()
        koneksi()
        cmd = New OdbcCommand("select * from data_profil where id_profil='" & id_text.Text & "'", connected)
        reader = cmd.ExecuteReader
        reader.Read()
    End Sub

    Sub tarik_username()
        koneksi()
        cmd = New OdbcCommand("select distinct username from data_user", connected)
        reader = cmd.ExecuteReader
        username_text.Items.Clear()
        Do While reader.Read
            username_text.Items.Add(reader("username"))
        Loop
    End Sub

    Sub grab()
        On Error Resume Next
        nama_text.Text = reader("nama_profil")
        username_text.Text = reader("username")
        ket_text.Text = reader("isi_profil")
    End Sub

    Sub automatic()
        koneksi()
        cmd = New OdbcCommand("select * from data_profil order by id_profil desc", connected)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            id_text.Text = "PRO" + "0001"
        Else
            id_text.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("id_profil").ToString, 6, 4)) + 1
            If Len(id_text.Text) = 1 Then
                id_text.Text = "PRO000" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 2 Then
                id_text.Text = "PRO00" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 3 Then
                id_text.Text = "PRO0" & id_text.Text & ""
            End If
        End If
        id_text.Enabled = False
    End Sub

    Private Sub DataProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        automatic()
        tarik_username()
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Dispose()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If MessageBox.Show("Apakah anda ingin menghapus record ini?", "Warning!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OdbcCommand("delete from data_profil where id_profil='" & id_text.Text & "'", connected)
            cmd.ExecuteNonQuery()
        End If
        refreshed()
        tampil()
    End Sub

    Private Sub DGV_CellMouceClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        id_text.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            grab()
        End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        refreshed()
        tampil()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If nama_text.Text = "" Or username_text.Text = "" Or ket_text.Text = "" Then
            MsgBox("Masukan data dengan benar!")
            nama_text.Focus()
            Exit Sub
        End If
        Try
            cari()
            If Not reader.HasRows Then
                Dim save As String = "insert into data_profil values('" & id_text.Text & "', '" & nama_text.Text & "', '" & ket_text.Text & "', '" & username_text.Text & "')"
                cmd = New OdbcCommand(save, connected)
                cmd.ExecuteNonQuery()
            Else
                Dim updt As String = "update data_profil set nama_profil='" & nama_text.Text & "', isi_profil='" & ket_text.Text & "', username='" & username_text.Text & "' where id_profil='" & id_text.Text & "'"
                cmd = New OdbcCommand(updt, connected)
                cmd.ExecuteNonQuery()
            End If
            tampil()
            refreshed()
        Catch ex As Exception

        End Try
    End Sub
End Class