Imports System.Data.OleDb
Public Class Frm_Penjualan
    Sub tampilkan_buku()
        Koneksi()
        da = New OleDbDataAdapter("Select * from Tbl_Buku where stok>0", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        dt = ds.Tables(0)
        dgBuku.DataSource = dt
        conn.Close()
    End Sub
    Sub tampilkan_bukukosong()
        Koneksi()
        da = New OleDbDataAdapter("Select * from Tbl_Buku where stok=0", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        dt = ds.Tables(0)
        dgbukukosong.DataSource = dt
        conn.Close()
    End Sub
    Sub tampilidkasir()
        Koneksi()
        cmd = New OleDbCommand("select * from Tbl_Kasir where username='" & Frm_Login.cbUser.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            idKasir.Text = rd.Item(0)
        End If
    End Sub
    Sub nyala()
        bSimpan.Enabled = True
        bBatal.Enabled = True
        dgJual.Enabled = True
        bayartxt.Enabled = True
        kembaliantxt.Enabled = True
        dgJual.Enabled = True
        dgBuku.Enabled = True
        bSimpan.Enabled = True
    End Sub
    Sub mati()
        bSimpan.Enabled = False
        bBatal.Enabled = False
        dgJual.Enabled = False
        bayartxt.Enabled = False
        kembaliantxt.Enabled = False
        bSimpan.Enabled = False
    End Sub
    Private Sub Id_otomatis()
        Koneksi()
        cmd = New OleDbCommand("Select * from tbl_Penjualan where id_penjualan in (select max (id_penjualan)from Tbl_Penjualan)", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = 0 Then
            idPenjualan.Text = "TB" & Format(Today, "ddMMyyyy") & "000001"
        End If
        If Not rd.HasRows Then
            idPenjualan.Text = "TB" & Format(Today, "ddMMyyyy") & "000001"
            rd.Close()
        Else
            idPenjualan.Text = Val(Microsoft.VisualBasic.Right(rd.Item("id_penjualan").ToString, 6)) + 1
            If Len(idPenjualan.Text) = 1 Then
                idPenjualan.Text = "TB" & Format(Today, "ddMMyyyy") & "00000" & idPenjualan.Text & ""
            ElseIf Len(idPenjualan.Text) = 2 Then
                idPenjualan.Text = "TB" & Format(Today, "ddMMyyyy") & "0000" & idPenjualan.Text & ""
            ElseIf Len(idPenjualan.Text) = 3 Then
                idPenjualan.Text = "TB" & Format(Today, "ddMMyyyy") & "000" & idPenjualan.Text & ""
            ElseIf Len(idPenjualan.Text) = 4 Then
                idPenjualan.Text = "TB" & Format(Today, "ddMMyyyy") & "00" & idPenjualan.Text & ""
            ElseIf Len(idPenjualan.Text) = 5 Then
                idPenjualan.Text = "TB" & Format(Today, "ddMMyyyy") & "0" & idPenjualan.Text & ""
            End If
            rd.Close()
        End If
    End Sub
    Sub kosong()
        jumlahtxt.Text = ""
        bayartxt.Clear()
        totaltxt.Clear()
        kembaliantxt.Clear()
    End Sub
    Sub KolomBaru()
        dgJual.Columns.Add("id_buku", "ID Buku")
        dgJual.Columns.Add("judul", "Judul Buku")
        dgJual.Columns.Add("hargajual", "Harga")
        dgJual.Columns.Add("jumlah", "Jumlah")
        dgJual.Columns.Add("diskon", "Diskon")
        dgJual.Columns.Add("subtotal", "Sub Total")
        dgJual.Columns.Add("jumlahdiskon", "Hemat")
        Call LebarKolom()
    End Sub
    Sub LebarKolom()
        dgJual.Columns(0).Width = 150
        dgJual.Columns(1).Width = 180
        dgJual.Columns(2).Width = 100
        dgJual.Columns(3).Width = 100
        dgJual.Columns(4).Width = 106
        dgJual.Columns(5).Width = 106
        dgJual.Columns(6).Width = 106
    End Sub
    Sub lebardgbuku()
        dgBuku.Columns(0).Width = 85
        dgBuku.Columns(1).Width = 100
        dgBuku.Columns(2).Width = 60
    End Sub
    Sub TampilBuku()
        Koneksi()
        cmd = New OleDbCommand("Select id_buku From tbl_buku", conn)
        rd = cmd.ExecuteReader
    End Sub
    Sub HapusBaris()
        On Error Resume Next
        Dim Baris As Integer = dgJual.CurrentCell.RowIndex
        dgJual.Rows(Baris).Cells(0).Value = ""
        Chr(30)
    End Sub
    Sub TotalItem()
        Dim HitungItem As Integer = 0
        For I As Integer = 0 To dgJual.Rows.Count - 1
            HitungItem = HitungItem + Val(dgJual.Rows(I).Cells(3).Value)
            jumlahtxt.Text = HitungItem
        Next
    End Sub

    Sub TotalHarga()
        Dim HitungHarga As Integer = 0
        For I As Integer = 0 To dgJual.Rows.Count - 1
            HitungHarga = HitungHarga + Val(dgJual.Rows(I).Cells(5).Value)
            totaltxt.Text = HitungHarga
        Next
    End Sub

    Private Sub Frm_Penjualan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tgl.Text = Today
        Id_otomatis()
    End Sub

    Private Sub Frm_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        KolomBaru()
        kosong()
        TampilBuku()
        tampilkan_buku()
        bBaru.Focus()
        tampilidkasir()
        judullist()
        lebardgbuku()
        tampilkan_bukukosong()
    End Sub

    Private Sub dgJual_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgJual.CellContentClick

    End Sub

    Private Sub dgJual_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgJual.CellEndEdit
        On Error Resume Next
        Koneksi()
        Dim i As Integer
        i = Me.dgJual.CurrentRow.Index
        If e.ColumnIndex = 3 Then
            cmd = New OleDbCommand("select * from Tbl_Buku where id_buku='" & dgJual.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If dgJual.Rows(e.RowIndex).Cells(3).Value > rd.Item(6) Then
                    MsgBox("Stok Buku hanya ada " & rd.Item(6) & "")
                    dgJual.Rows(e.RowIndex).Cells(3).Value = 1
                    dgJual.Rows(e.RowIndex).Cells(5).Value = dgJual.Rows(e.RowIndex).Cells(2).Value * dgJual.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                Else
                    dgJual.Rows(e.RowIndex).Cells(5).Value = dgJual.Rows(e.RowIndex).Cells(2).Value * dgJual.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                End If
            End If

        End If
        If e.ColumnIndex = 4 Then
            cmd = New OleDbCommand("select * from Tbl_Buku where id_buku='" & dgJual.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If dgJual.Rows(e.RowIndex).Cells(4).Value > rd.Item(11) Then
                    MsgBox("Diskon Terlalu Tinggi !!,Maximal diskon untuk Buku ini " & rd.Item(11) & "")
                    dgJual.Rows(e.RowIndex).Cells(4).Value = 0
                    dgJual.Rows(e.RowIndex).Cells(6).Value = ((dgJual.Rows(e.RowIndex).Cells(5).Value * dgJual.Rows(e.RowIndex).Cells(4).Value)) / 100
                ElseIf dgJual.Rows(e.RowIndex).Cells(4).Value = 0 Then
                    dgJual.Rows(e.RowIndex).Cells(5).Value = dgJual.Rows(e.RowIndex).Cells(2).Value * dgJual.Rows(e.RowIndex).Cells(3).Value
                    dgJual.Rows(e.RowIndex).Cells(6).Value = 0
                Else
                    dgJual.Rows(e.RowIndex).Cells(6).Value = ((dgJual.Rows(e.RowIndex).Cells(5).Value * dgJual.Rows(e.RowIndex).Cells(4).Value)) / 100
                    dgJual.Rows(e.RowIndex).Cells(5).Value = dgJual.Rows(e.RowIndex).Cells(5).Value - dgJual.Rows(e.RowIndex).Cells(6).Value
                End If
                Call TotalHarga()
            End If
            dgJual.CurrentCell = dgJual.Rows(i).Cells(0)
        End If

    End Sub

    Private Sub dgJual_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgJual.CellValueChanged
        On Error Resume Next
        Koneksi()
        Dim i As Integer
        i = Me.dgJual.CurrentRow.Index
        If e.ColumnIndex = 0 Then
            cmd = New OleDbCommand("select * from Tbl_Buku where id_buku='" & dgJual.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                dgJual.Rows(e.RowIndex).Cells(1).Value = rd.Item(1)
                dgJual.Rows(e.RowIndex).Cells(2).Value = rd.Item(9) + rd.Item(10)
                dgJual.Rows(e.RowIndex).Cells(3).Value = 1
                dgJual.Rows(e.RowIndex).Cells(4).Value = 0
                dgJual.Rows(e.RowIndex).Cells(6).Value = 0
                dgJual.Rows(e.RowIndex).Cells(5).Value = dgJual.Rows(e.RowIndex).Cells(2).Value * dgJual.Rows(e.RowIndex).Cells(4).Value
                Call TotalItem()
                Call TotalHarga()
            Else
                MsgBox("Kode buku tidak terdaftar")
            End If
            dgJual.CurrentCell = dgJual.Rows(i).Cells(3)
        End If
    End Sub

    Private Sub dgJual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgJual.KeyDown
        If e.KeyCode = Keys.Up Then
            dgJual.CurrentCell = dgJual.Rows(0).Cells(4)
        End If
    End Sub

    Private Sub dgJual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgJual.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            dgJual.Rows.RemoveAt(dgJual.CurrentCell.RowIndex)
            Call TotalItem()
            Call TotalHarga()
            bayartxt.Clear()
            kembaliantxt.Text = ""
        End If

    End Sub

    Private Sub bayartxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bayartxt.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(bayartxt.Text) < Val(totaltxt.Text) Then
                MsgBox("Pembayaran kurang")
                kembaliantxt.Text = ""
                bayartxt.Focus()
                Exit Sub
            ElseIf Val(bayartxt.Text) = Val(totaltxt.Text) Then
                kembaliantxt.Text = 0
            Else
                kembaliantxt.Text = Val(bayartxt.Text) - Val(totaltxt.Text)
            End If
        End If
    End Sub
    Private Sub dgJual_EditingControlShowing(ByVal sender As Object, ByVal ByVale As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
        If ByVale.Control.GetType.ToString() = "System.Windows.Forms.DataGridViewTextBoxEditingControl" Then
            Dim c As DataGridViewTextBoxEditingControl = CType(ByVale.Control, DataGridViewTextBoxEditingControl)
            RemoveHandler c.KeyPress, AddressOf GridViewTextBox_KeyPress
            AddHandler c.KeyPress, AddressOf GridViewTextBox_KeyPress
        End If
    End Sub
    Private Sub GridViewTextBox_KeyPress(ByVal sender As Object, ByVal ex As KeyPressEventArgs)
        If dgJual.CurrentCell.ColumnIndex = 4 Then
            If ((Asc(ex.KeyChar) < 48 Or Asc(ex.KeyChar) > 57) And Asc(ex.KeyChar) <> 8) Then
                ex.Handled = True
            End If
        End If
    End Sub

    Private Sub bBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBatal.Click
        kosong()
        dgJual.Columns.Clear()
        KolomBaru()
        dgJual.Focus()
        mati()
    End Sub

    Private Sub bSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSimpan.Click
        On Error Resume Next
        If bayartxt.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau pembayaran masih kosong")
            bayartxt.Focus()
        ElseIf kembaliantxt.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau pembayaran masih kosong")
            bayartxt.Focus()
        Else

            Dim SimpanTransaksi As String = "Insert into Tbl_Penjualan (id_penjualan,id_kasir,tanggal,total,bayar,kembalian,jumlahItem) values " & _
            "('" & idPenjualan.Text & "','" & idKasir.Text & "','" & tgl.Text & "','" & totaltxt.Text & "','" & bayartxt.Text & "','" & kembaliantxt.Text & "','" & jumlahtxt.Text & "')"
            cmd = New OleDbCommand(SimpanTransaksi, conn)
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To dgJual.Rows.Count

                Dim SimpanDetailTransaksi As String = "Insert into Tbl_DetailTransaksi (id_penjualan,id_buku,judul,harga_jual,diskon,jumlah,sub_total,jumlahdiskon) values " & _
                "('" & idPenjualan.Text & "','" & dgJual.Rows(baris).Cells(0).Value & "','" & dgJual.Rows(baris).Cells(1).Value & "','" & dgJual.Rows(baris).Cells(2).Value & "','" & dgJual.Rows(baris).Cells(4).Value & "','" & dgJual.Rows(baris).Cells(3).Value & "','" & dgJual.Rows(baris).Cells(5).Value & "','" & dgJual.Rows(baris).Cells(6).Value & "')"
                cmd = New OleDbCommand(SimpanDetailTransaksi, conn)
                cmd.ExecuteNonQuery()

                cmd = New OleDbCommand("select * from Tbl_Buku where id_buku='" & dgJual.Rows(baris).Cells(0).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Dim KurangiStok As String = "update Tbl_Buku set stok= '" & rd.Item(6) - dgJual.Rows(baris).Cells(3).Value & "' where id_buku='" & dgJual.Rows(baris).Cells(0).Value & "'"
                    cmd = New OleDbCommand(KurangiStok, conn)
                    cmd.ExecuteNonQuery()
                End If
            Next baris
            If MsgBox("Anda Akan melihat Struk ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                LaporanPenjualan.WindowState = FormWindowState.Maximized
                LaporanPenjualan.Show()
                Me.Cursor = Cursors.Default
            End If
            dgJual.Columns.Clear()
            Call KolomBaru()
            Call kosong()
            Id_otomatis()
            mati()
        End If
    End Sub

    Private Sub bBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBaru.Click
        nyala()
        kosong()
        Id_otomatis()
        dgJual.Focus()
    End Sub

    Private Sub bKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKeluar.Click
        MenuUtama.Show()
        Close()
    End Sub

    Private Sub totaltxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totaltxt.TextChanged
        Me.Label9.Text = "Rp." & totaltxt.Text & ""
    End Sub
    Sub judullist()
        Koneksi()
        cmd = New OleDbCommand("select * FROM tbl_buku where stok>0", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbCari.Items.Add(rd.Item(1))
            cbCari.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbCari.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop

    End Sub
    Private Sub cbCari_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCari.SelectedValueChanged
        Koneksi()
        cmd = New OleDbCommand("select * from Tbl_Buku where judul like '%" & cbCari.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Koneksi()
            da = New OleDbDataAdapter("select * from Tbl_Buku where judul like '%" & cbCari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            dgBuku.DataSource = ds.Tables(0)
        Else
            MsgBox("Tidak Ada Data Buku !!")
            cbCari.ResetText()
            tampilkan_buku()
        End If
    End Sub

    Private Sub bClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClear.Click
        cbCari.ResetText()
        tampilkan_buku()
    End Sub
    Private Sub dgBuku_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgJual.CellClick
        On Error Resume Next
        Dim i As Integer
        i = Me.dgBuku.CurrentRow.Index
        With dgBuku.Rows.Item(i)
            dgJual.Rows(e.RowIndex).Cells(0).Value = .Cells(0).Value
        End With
        dgJual.Focus()
    End Sub

    Private Sub bLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLaporan.Click
        Me.Cursor = Cursors.WaitCursor
        LaporanRekapPenjualan.WindowState = FormWindowState.Maximized
        LaporanRekapPenjualan.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class