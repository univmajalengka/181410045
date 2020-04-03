Imports System.Data.Odbc
Public Class DataUser

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from data_user", connected)
        ds = New DataSet
        adapter.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        level_combo.Text = "-"
    End Sub

    Sub refreshed()
        username_text.Clear()
        name_text.Clear()
        passwd_text.Clear()
        level_combo.Text = "-"
        username_text.Focus()
    End Sub
    Sub grab()
        On Error Resume Next
        passwd_text.Text = reader("password")
        level_combo.Text = reader("level")
        name_text.Text = reader("nama_lengkap")
    End Sub

    Sub tarik()
        koneksi()
        cmd = New OdbcCommand("select * from data_user where username='" & username_text.Text & "'", connected)
        reader = cmd.ExecuteReader
        reader.Read()
    End Sub

    Private Sub DataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Dispose()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If MessageBox.Show("Apakah anda ingin menghapus record ini?", "Warning!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OdbcCommand("delete from data_user where username='" & username_text.Text & "'", connected)
            cmd.ExecuteNonQuery()
        End If
        refreshed()
        tampil()
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        refreshed()
        tampil()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If username_text.Text = "" Or passwd_text.Text = "" Or level_combo.Text = "" Or name_text.Text = "" Then
            MsgBox("Masukan data dengan benar!")
            Exit Sub
        End If
        Try
            tarik()
            If Not reader.HasRows Then
                Dim saved As String = "insert into data_user values('" & username_text.Text & "', '" & passwd_text.Text & "', '" & level_combo.Text & "', '" & name_text.Text & "')"
                cmd = New OdbcCommand(saved, connected)
                cmd.ExecuteNonQuery()
            Else
                Dim updt As String = "updatte data_user set password='" & passwd_text.Text & "', level='" & level_combo.Text & "', nama_lengkap='" & name_text.Text & "' where username='" & username_text.Text & "'"
                cmd = New OdbcCommand(updt, connected)
                cmd.ExecuteNonQuery()
            End If
            refreshed()
            tampil()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        username_text.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        tarik()
        If reader.HasRows Then
            grab()
        End If
    End Sub
End Class