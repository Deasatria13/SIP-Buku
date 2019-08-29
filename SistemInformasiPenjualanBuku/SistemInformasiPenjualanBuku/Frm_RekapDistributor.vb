Imports System.Data.OleDb
Public Class Frm_RekapDistributor
    Sub tampilkan_data()
        Koneksi()
        da = New OleDbDataAdapter("Select * from Tbl_Distributor", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        dt = ds.Tables(0)
        dgDis.DataSource = dt
        conn.Close()
    End Sub
    Sub namalist()
        Koneksi()
        cmd = New OleDbCommand("select * FROM tbl_Distributor", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbNama.Items.Add(rd.Item(1))
            cbNama.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbNama.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop
    End Sub
    Private Sub Frm_RekapDistributor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampilkan_data()
        namalist()
    End Sub

    Private Sub cbNama_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNama.SelectedIndexChanged
        Call Koneksi()
        cmd = New OleDbCommand("select * from Tbl_Distributor where nama_distributor like '%" & cbNama.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call Koneksi()
            da = New OleDbDataAdapter("select * from Tbl_Distributor where nama_distributor like '%" & cbNama.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            dgDis.DataSource = ds.Tables(0)
            cbNama.Text = ""
        Else
            MsgBox("Nama Distributor tidak ditemukan !!")
            cbNama.ResetText()
            tampilkan_data()
        End If
    End Sub

    Private Sub bClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClear.Click
        cbNama.ResetText()
        tampilkan_data()
    End Sub

    Private Sub bKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKeluar.Click
        Close()
    End Sub

    Private Sub dgDis_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDis.CellDoubleClick
        On Error Resume Next
        Dim i As Integer
        i = Me.dgDis.CurrentRow.Index
        With dgDis.Rows.Item(i)
            Frm_Distributor.iddistxt.Text = .Cells(0).Value
            Frm_Distributor.namatxt.Text = .Cells(1).Value
            Frm_Distributor.alamattxt.Text = .Cells(2).Value
            Frm_Distributor.telptxt.Text = .Cells(3).Value
        End With
        Frm_Distributor.Show()
        Close()
    End Sub

    Private Sub bLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLaporan.Click
        Me.Cursor = Cursors.WaitCursor
        LaporanDistributor.WindowState = FormWindowState.Maximized
        LaporanDistributor.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class