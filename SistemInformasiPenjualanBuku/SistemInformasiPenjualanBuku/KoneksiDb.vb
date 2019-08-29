Imports System.Data.OleDb
Module KoneksiDb
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public dt As DataTable
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public Str As String
    Public Sub Koneksi()
        Str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbSIPBuku.mdb"
        conn = New OleDbConnection(Str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
