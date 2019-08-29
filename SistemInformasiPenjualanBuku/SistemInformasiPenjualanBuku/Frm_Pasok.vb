Imports System.Data.OleDb
Public Class Frm_Pasok
    Sub nama_dg()
        Me.dgPasok.Columns(0).HeaderText = "ID Pasok"
        Me.dgPasok.Columns(1).HeaderText = "ID Distrubutor"
        Me.dgPasok.Columns(2).HeaderText = "Id Buku"
        Me.dgPasok.Columns(3).HeaderText = "Harga Pokok"
        Me.dgPasok.Columns(4).HeaderText = "Jumlah"
        Me.dgPasok.Columns(5).HeaderText = "Total"
        Me.dgPasok.Columns(6).HeaderText = "Tanggal"
    End Sub
    Sub nyala()
        Me.cbBuku.Enabled = True
        Me.cbDis.Enabled = True
        Me.iddistxt.Enabled = True
        Me.idbuku.Enabled = True
        Me.hargatxt.Enabled = True
        Me.jumlahtxt.Enabled = True
        Me.totaltxt.Enabled = True
    End Sub
    Sub mati()
        Me.cbBuku.Enabled = False
        Me.cbDis.Enabled = False
        Me.iddistxt.Enabled = False
        Me.idbuku.Enabled = False
        Me.hargatxt.Enabled = False
        Me.jumlahtxt.Enabled = False
        Me.totaltxt.Enabled = False
    End Sub
    Sub bersih()
        Me.cbBuku.Text = ""
        Me.cbDis.Text = ""
        Me.iddistxt.Clear()
        Me.idbuku.Clear()
        Me.hargatxt.Clear()
        Me.jumlahtxt.Clear()
        Me.totaltxt.Clear()
    End Sub
    Private Sub id_otomatis()
        Koneksi()
        cmd = New OleDbCommand("Select * from Tbl_Pasok where id_pasok in(select max (id_pasok)from Tbl_pasok)", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = 0 Then
            idpasoktxt.Text = "PSK" & Date.Now.Year & "000001"
        End If
        If Not rd.HasRows Then
            idpasoktxt.Text = "PSK" & Date.Now.Year & "000001"
            rd.Close()
        Else
            idpasoktxt.Text = Val(Microsoft.VisualBasic.Right(rd.Item("id_pasok").ToString, 6)) + 1
            If Len(idpasoktxt.Text) = 1 Then
                idpasoktxt.Text = "PSK" & Date.Now.Year & "00000" & idpasoktxt.Text & ""
            ElseIf Len(idpasoktxt.Text) = 2 Then
                idpasoktxt.Text = "PSK" & Date.Now.Year & "0000" & idpasoktxt.Text & ""
            ElseIf Len(idpasoktxt.Text) = 3 Then
                idpasoktxt.Text = "PSK" & Date.Now.Year & "000" & idpasoktxt.Text & ""
            ElseIf Len(idpasoktxt.Text) = 4 Then
                idpasoktxt.Text = "PSK" & Date.Now.Year & "00" & idpasoktxt.Text & ""
            ElseIf Len(idpasoktxt.Text) = 5 Then
                idpasoktxt.Text = "PSK" & Date.Now.Year & "0" & idpasoktxt.Text & ""
            End If
            rd.Close()
        End If
    End Sub
    Sub distributor()
        Koneksi()
        cmd = New OleDbCommand("Select * from Tbl_distributor", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbDis.Items.Add(rd.Item(1))
            cbDis.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbDis.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop
    End Sub
    Sub tampilBuku()
        Koneksi()
        cmd = New OleDbCommand("Select * from Tbl_Buku", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbBuku.Items.Add(rd.Item(1))
            cbBuku.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbBuku.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop
    End Sub
    Sub tampilkan_data()
        Koneksi()
        da = New OleDbDataAdapter("Select * from Tbl_Pasok", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        dt = ds.Tables(0)
        dgPasok.DataSource = dt
        conn.Close()
    End Sub
    Private Sub Frm_Pasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tgl.Text = Today
        Koneksi()
        id_otomatis()
        tampilkan_data()
        distributor()
        tampilBuku()
        bBaru.Focus()
        nama_dg()
    End Sub

    Private Sub cbDis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDis.SelectedIndexChanged
        cmd = New OleDbCommand("Select * from Tbl_Distributor where nama_distributor='" & cbDis.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            iddistxt.Text = rd.Item("id_distributor")
        End If
    End Sub

    Private Sub cbBuku_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBuku.SelectedIndexChanged
        cmd = New OleDbCommand("Select * from Tbl_Buku where Judul='" & cbBuku.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            idbuku.Text = rd.Item("id_buku")
            hargatxt.Text = rd.Item("harga_pokok")
        End If
    End Sub

    Private Sub jumlahtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jumlahtxt.TextChanged
        On Error Resume Next
        If Me.jumlahtxt.Text = vbNullString Then
            Me.jumlahtxt.Text = ""
        Else
            If CInt(Me.jumlahtxt.Text) > CInt(Me.jumlahtxt.Text) Then
                Me.jumlahtxt.Text = ""
            End If
        End If
        If Me.jumlahtxt.Text <> vbNullString Then
            Me.totaltxt.Text = Val(Me.hargatxt.Text * Me.jumlahtxt.Text)
        End If
        If Me.jumlahtxt.Text = "" Then
            Me.totaltxt.Text = ""
        End If
    End Sub

    Private Sub bBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBaru.Click
        nyala()
        bersih()
        Me.bEdit.Text = "&Batal"
        id_otomatis()
        iddistxt.Focus()
        bSimpan.Enabled = True
    End Sub


    Private Sub bEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEdit.Click
        If Me.bEdit.Text = "&Batal" Then
            Me.bEdit.Text = "&Edit"
            Me.bSimpan.Text = "&Simpan"
            Me.mati()
            bersih()
            Koneksi()
            bSimpan.Enabled = False
        ElseIf Me.bEdit.Text = "&Edit" Then
            Me.bEdit.Text = "&Batal"
            Koneksi()
            Me.nyala()
            Me.bSimpan.Text = "&Perbaharui"
            bSimpan.Enabled = True
        End If
    End Sub

    Private Sub bSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSimpan.Click
        Koneksi()
        If Me.iddistxt.Text = "" Then
            MsgBox("Data Masih Ada yang kosong !", MsgBoxStyle.Critical, "Peringatan")
        Else
            cmd = New OleDbCommand("Select * from Tbl_Pasok where id_pasok='" & Me.idpasoktxt.Text & "'", conn)
            rd = cmd.ExecuteReader()
            If Not rd.HasRows Then
                Koneksi()
                Me.bEdit.Text = "&Edit"
                Me.bBaru.Focus()
                Dim Simpan As String = "Insert into Tbl_pasok values('" & Me.idpasoktxt.Text & "','" & Me.iddistxt.Text & "','" & Me.idbuku.Text & "','" & Me.hargatxt.Text & "','" & Me.jumlahtxt.Text & "','" & Me.totaltxt.Text & "','" & Me.tgl.Text & "')"
                cmd = New OleDbCommand(Simpan, conn)
                cmd.ExecuteNonQuery()

                cmd = New OleDbCommand("select * from Tbl_Buku where id_buku='" & idbuku.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Dim kurangistok As String = "Update Tbl_Buku set stok='" & rd.Item(6) + jumlahtxt.Text & "' where id_buku='" & idbuku.Text & "'"
                    cmd = New OleDbCommand(kurangistok, conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    id_otomatis()
                    tampilkan_data()
                    idbuku.Clear()
                    iddistxt.Clear()
                End If
                conn.Close()
                tampilkan_data()
                idbuku.Clear()
                iddistxt.Clear()
                bBaru.Focus()
                id_otomatis()
                bSimpan.Enabled = False
            ElseIf Me.bSimpan.Text = "&Perbaharui" Then
                Me.bSimpan.Text = "&Simpan"
                Me.bEdit.Text = "&Edit"
                Me.bBaru.Focus()
                Koneksi()
                Dim ubah As String = "Update Tbl_Pasok set [id_distributor]='" & iddistxt.Text & "',id_buku='" & idbuku.Text & "',harga_pokok='" & hargatxt.Text & "',jumlah='" & jumlahtxt.Text & "',Total='" & totaltxt.Text & "',tanggal='" & tgl.Text & "' where [id_pasok]='" & idpasoktxt.Text & "'"
                cmd = New OleDbCommand(ubah, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                tampilkan_data()
                bBaru.Focus()
                id_otomatis()
                bSimpan.Enabled = False
            End If
            bersih()
            mati()
        End If
    End Sub

    Private Sub bHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHapus.Click
        If MsgBox("Data ini Akan di Hapus?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Koneksi()
            Dim hapus As String = "Delete from Tbl_Pasok where id_Pasok='" & Me.idpasoktxt.Text & "'"
            cmd = New OleDbCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            tampilkan_data()
            bersih()
        Else
            bersih()
        End If
    End Sub

    Private Sub dgPasok_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPasok.CellClick
        On Error Resume Next
        Dim i As Integer
        i = Me.dgPasok.CurrentRow.Index
        With dgPasok.Rows.Item(i)
            Me.idpasoktxt.Text = .Cells(0).Value
            Me.iddistxt.Text = .Cells(1).Value
            Me.idbuku.Text = .Cells(2).Value
            Me.hargatxt.Text = .Cells(3).Value
            Me.jumlahtxt.Text = .Cells(4).Value
            Me.totaltxt.Text = .Cells(5).Value
            Me.tgl.Text = .Cells(6).Value
        End With
    End Sub

    Private Sub bKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKeluar.Click
        If Me.bSimpan.Enabled = True Then
            MsgBox("Data belum di simpan !", MsgBoxStyle.OkOnly, "Konfirmasi")
            Me.bSimpan.Focus()
        Else
            MenuUtama.Show()
            Close()
        End If
    End Sub

    Private Sub bLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLaporan.Click
        Me.Cursor = Cursors.WaitCursor
        LaporanPasok.WindowState = FormWindowState.Maximized
        LaporanPasok.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class