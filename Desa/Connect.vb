Imports System.Data.Odbc

Module Connect

    Public connected As OdbcConnection
    Public reader As OdbcDataReader
    Public adapter As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand


    Sub koneksi()
        connected = New OdbcConnection("Dsn=desa;uid=root")
        connected.Open()
    End Sub

End Module
