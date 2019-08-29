Imports System.Data.OleDb
Public Class Frm_MasterData
    Sub tampilkan_level()
        Koneksi()
        da = New OleDbDataAdapter("Select * from Tbl_Level", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        dt = ds.Tables(0)
        dgAkses.DataSource = dt
        conn.Close()
    End Sub
    Sub tampilkan_Status()
        Koneksi()
        da = New OleDbDataAdapter("Select * from Tbl_Status", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        dt = ds.Tables(0)
        dgStatus.DataSource = dt
        conn.Close()
    End Sub
    Sub tampilkan_Tahun()
        Koneksi()
        da = New OleDbDataAdapter("Select * from Tbl_Tahun", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        dt = ds.Tables(0)
        dgTahun.DataSource = dt
        conn.Close()
    End Sub
    Private Sub Frm_MasterData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampilkan_level()
        tampilkan_Status()
        tampilkan_Tahun()
    End Sub


    Private Sub dgAkses_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAkses.CellEndEdit
        Koneksi()
        cmd = New OleDbCommand("select count (*) from Tbl_Level", conn)
        Dim rs As Integer
        rs = cmd.ExecuteScalar
        For i As Integer = rs To (dgAkses.Rows.Count - 2)
            Koneksi()
            Dim simpan As String = "Insert into Tbl_Level values('" & dgAkses.Rows(i).Cells(0).Value & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Next
    End Sub


    Private Sub dgStatus_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStatus.CellEndEdit
        Koneksi()
        cmd = New OleDbCommand("select count (*) from Tbl_Status", conn)
        Dim rs As Integer
        rs = cmd.ExecuteScalar
        For i As Integer = rs To (dgStatus.Rows.Count - 2)
            Koneksi()
            Dim simpan As String = "Insert into Tbl_Status values('" & dgStatus.Rows(i).Cells(0).Value & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Next
    End Sub


    Private Sub dgTahun_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTahun.CellEndEdit
        Koneksi()
        cmd = New OleDbCommand("select count (*) from Tbl_Tahun", conn)
        Dim rs As Integer
        rs = cmd.ExecuteScalar
        For i As Integer = rs To (dgTahun.Rows.Count - 2)
            Koneksi()
            Dim simpan As String = "Insert into Tbl_Tahun values('" & dgTahun.Rows(i).Cells(0).Value & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Next
    End Sub

    Private Sub bKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKeluar.Click
        MenuUtama.Show()
        Close()
    End Sub

    Private Sub dgAkses_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAkses.CellContentClick

    End Sub

    Private Sub dgAkses_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgAkses.KeyPress
        If e.KeyChar = Chr(127) Then
            Dim index As Integer
            index = dgAkses.CurrentCell.RowIndex
            dgAkses.Rows.RemoveAt(index)
        End If
    End Sub
End Class