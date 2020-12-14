Imports MySql.Data.MySqlClient
Module KoneksiDB
    Public conn As MySqlConnection
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public cmd As MySqlCommand
    Public ds As DataSet

    Public simpan, ubah, hapus As String

    Public Sub bukadb()
        Dim sqlconn As String
        sqlconn = "server=localhost;Uid=root;Password=;Database=prauas"
        conn = New MySqlConnection(sqlconn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module