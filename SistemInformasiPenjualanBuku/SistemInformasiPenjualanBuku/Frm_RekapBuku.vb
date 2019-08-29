Imports System.Data.OleDb
Public Class Frm_RekapBuku
    Sub tampilkan_data()
        Koneksi()
        da = New OleDbDataAdapter("Select * from Tbl_Buku", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        dt = ds.Tables(0)
        dgBuku.DataSource = dt
        conn.Close()
    End Sub
    Sub tahunlist()
        cmd = New OleDbCommand("Select * from Tbl_Tahun", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbTahun.Items.Add(rd.Item(0))
            cbTahun.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbTahun.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop
    End Sub
    Sub judullist()
        Koneksi()
        cmd = New OleDbCommand("select * FROM tbl_buku", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbJudul.Items.Add(rd.Item(1))
            cbJudul.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbJudul.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop

    End Sub
    Private Sub Frm_RekapBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampilkan_data()
        judullist()
        tahunlist()
    End Sub

    Private Sub cbTahun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTahun.SelectedIndexChanged
        Koneksi()
        cmd = New OleDbCommand("select * from Tbl_Buku where tahun like '%" & cbTahun.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Koneksi()
            da = New OleDbDataAdapter("select * from Tbl_Buku where tahun like '%" & cbTahun.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            dgBuku.DataSource = ds.Tables(0)
            cbJudul.Text = ""
        Else
            MsgBox("Tidak Ada Data Buku !!")
            cbTahun.ResetText()
            tampilkan_data()
        End If
    End Sub
    Private Sub dgBuku_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBuku.CellDoubleClick
        On Error Resume Next
        Dim i As Integer
        i = Me.dgBuku.CurrentRow.Index
        With dgBuku.Rows.Item(i)
            Frm_Buku.idbukutxt.Text = .Cells(0).Value
            Frm_Buku.judultxt.Text = .Cells(1).Value
            Frm_Buku.noisbntxt.Text = .Cells(2).Value
            Frm_Buku.penulistxt.Text = .Cells(3).Value
            Frm_Buku.penerbittxt.Text = .Cells(4).Value
            Frm_Buku.cbTahun.Text = .Cells(5).Value
            Frm_Buku.stoktxt.Text = .Cells(6).Value
            Frm_Buku.hargaPtxt.Text = .Cells(7).Value
            Frm_Buku.hargaDtxt.Text = .Cells(8).Value
            Frm_Buku.hargaJtxt.Text = .Cells(9).Value
            Frm_Buku.ppntxt.Text = .Cells(10).Value
            Frm_Buku.diskontxt.Text = .Cells(11).Value
        End With
        Frm_Buku.Show()
        Close()
    End Sub

    Private Sub bLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLaporan.Click
        Frm_Filter.Show()
    End Sub

    Private Sub bClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClear.Click
        cbTahun.ResetText()
        cbJudul.ResetText()
        tampilkan_data()
    End Sub

    Private Sub cbJudul_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbJudul.SelectedIndexChanged
        Call Koneksi()
        cmd = New OleDbCommand("select * from Tbl_Buku where judul like '%" & cbJudul.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call Koneksi()
            da = New OleDbDataAdapter("select * from Tbl_Buku where judul like '%" & cbJudul.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            dgBuku.DataSource = ds.Tables(0)
            cbTahun.Text = ""
        Else
            MsgBox("judul buku tidak ditemukan !!")
            cbJudul.ResetText()
            tampilkan_data()
        End If
    End Sub

    Private Sub bKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKeluar.Click
        Close()
    End Sub
End Class