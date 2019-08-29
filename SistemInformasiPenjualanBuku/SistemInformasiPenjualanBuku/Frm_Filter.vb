Imports System.Data.OleDb
Public Class Frm_Filter
    Sub tahunlist()
        Koneksi()
        cmd = New OleDbCommand("Select * from Tbl_Tahun", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbTahun.Items.Add(rd.Item(0))
            cbTahun.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbTahun.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop
    End Sub
    Private Sub Frm_Filter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tahunlist()
    End Sub

    Private Sub bCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCetak.Click
        If Me.CheckBox1.Checked Then
            Me.Cursor = Cursors.WaitCursor
            LaporanBuku.WindowState = FormWindowState.Maximized
            LaporanBuku.Show()
            Me.Cursor = Cursors.Default
        Else
            Me.Cursor = Cursors.WaitCursor
            LaporanBuku.CrystalReportViewer1.SelectionFormula = "{Tbl_Buku.tahun} = '" & cbTahun.Text & "'"
            LaporanBuku.CrystalReportViewer1.RefreshReport()
            LaporanBuku.WindowState = FormWindowState.Maximized
            LaporanBuku.Show()
            Me.Cursor = Cursors.Default
        End If
        Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Me.cbTahun.Text = ""
        End If
    End Sub
End Class