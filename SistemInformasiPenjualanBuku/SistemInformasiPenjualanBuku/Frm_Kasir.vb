Imports System.Data.OleDb
Public Class Frm_Kasir
    Sub namakasir()
        cmd = New OleDbCommand("select * FROM Tbl_Kasir", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbNama.Items.Add(rd.Item(1))
            cbNama.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbNama.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop
    End Sub
    Sub nyala()
        Me.namatxt.Enabled = True
        Me.alamattxt.Enabled = True
        Me.telptxt.Enabled = True
        Me.cbStatus.Enabled = True
        Me.usernametxt.Enabled = True
        Me.passtxt.Enabled = True
        Me.cbAkses.Enabled = True
    End Sub
    Sub mati()
        Me.namatxt.Enabled = False
        Me.alamattxt.Enabled = False
        Me.telptxt.Enabled = False
        Me.cbStatus.Enabled = False
        Me.usernametxt.Enabled = False
        Me.passtxt.Enabled = False
        Me.cbAkses.Enabled = False
    End Sub
    Sub bersih()
        Me.namatxt.Clear()
        Me.alamattxt.Clear()
        Me.telptxt.Clear()
        Me.cbStatus.Text = ""
        Me.usernametxt.Clear()
        Me.passtxt.Clear()
        Me.cbAkses.Text = ""
    End Sub
    Private Sub id_otomatis()
        Koneksi()
        cmd = New OleDbCommand("Select * from Tbl_Kasir where id_kasir in(select max (id_kasir)from Tbl_Kasir)", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = 0 Then
            idkasirtxt.Text = "KSR" & Date.Now.Year & "000001"
        End If
        If Not rd.HasRows Then
            idkasirtxt.Text = "KSR" & Date.Now.Year & "000001"
            rd.Close()
        Else
            idkasirtxt.Text = Val(Microsoft.VisualBasic.Right(rd.Item("id_kasir").ToString, 6)) + 1
            If Len(idkasirtxt.Text) = 1 Then
                idkasirtxt.Text = "KSR" & Date.Now.Year & "00000" & idkasirtxt.Text & ""
            ElseIf Len(idkasirtxt.Text) = 2 Then
                idkasirtxt.Text = "KSR" & Date.Now.Year & "0000" & idkasirtxt.Text & ""
            ElseIf Len(idkasirtxt.Text) = 3 Then
                idkasirtxt.Text = "KSR" & Date.Now.Year & "000" & idkasirtxt.Text & ""
            ElseIf Len(idkasirtxt.Text) = 4 Then
                idkasirtxt.Text = "KSR" & Date.Now.Year & "00" & idkasirtxt.Text & ""
            ElseIf Len(idkasirtxt.Text) = 5 Then
                idkasirtxt.Text = "KSR" & Date.Now.Year & "0" & idkasirtxt.Text & ""
            End If
            rd.Close()
        End If
    End Sub
    Sub tampilStatus()
        Koneksi()
        cmd = New OleDbCommand("Select * from Tbl_Status", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbStatus.Items.Add(rd.Item(0))
            cbStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbStatus.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop
    End Sub
    Sub tampilAkses()
        Koneksi()
        cmd = New OleDbCommand("Select * from Tbl_Level", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbAkses.Items.Add(rd.Item(0))
            cbAkses.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbAkses.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop
    End Sub
    Sub tampilkan_data()
        Koneksi()
        da = New OleDbDataAdapter("Select * from Tbl_Kasir", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        dt = ds.Tables(0)
        dgKasir.DataSource = dt
        conn.Close()
    End Sub
    Private Sub Frm_Kasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        id_otomatis()
        tampilkan_data()
        tampilAkses()
        tampilStatus()
        namakasir()
        bBaru.Focus()
    End Sub

    Private Sub bBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBaru.Click
        nyala()
        bersih()
        Me.bEdit.Text = "&Batal"
        id_otomatis()
        namatxt.Focus()
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
        If Me.idkasirtxt.Text = "" Then
            MsgBox("Data Masih Ada yang kosong !", MsgBoxStyle.Critical, "Peringatan")
        Else
            cmd = New OleDbCommand("Select * from Tbl_Kasir where id_kasir='" & Me.idkasirtxt.Text & "'", conn)
            rd = cmd.ExecuteReader()
            If Not rd.HasRows Then
                Koneksi()
                Me.bEdit.Text = "&Edit"
                Me.bBaru.Focus()
                Dim Simpan As String = "Insert into Tbl_Kasir values('" & Me.idkasirtxt.Text & "','" & Me.namatxt.Text & "','" & Me.alamattxt.Text & "','" & Me.telptxt.Text & "','" & Me.cbStatus.Text & "','" & Me.usernametxt.Text & "','" & Me.passtxt.Text & "','" & Me.cbAkses.Text & "')"
                cmd = New OleDbCommand(Simpan, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                tampilkan_data()
                bBaru.Focus()
                bSimpan.Focus()
                id_otomatis()
                cbNama.Refresh()
                bSimpan.Enabled = False
            ElseIf Me.bSimpan.Text = "&Perbaharui" Then
                Koneksi()
                Me.bSimpan.Text = "&Simpan"
                Me.bEdit.Text = "&Edit"
                Dim ubah As String = "Update Tbl_Kasir set [nama]='" & namatxt.Text & "',[alamat]='" & alamattxt.Text & "',[telp]='" & telptxt.Text & "',[status]='" & cbStatus.Text & "',[username]='" & usernametxt.Text & "',[password]='" & passtxt.Text & "',[akses]='" & cbAkses.Text & "' where [id_kasir]='" & idkasirtxt.Text & "'"
                cmd = New OleDbCommand(ubah, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                tampilkan_data()
                bBaru.Focus()
                bSimpan.Enabled = False
            End If
            bersih()
            mati()
        End If
    End Sub

    Private Sub bHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHapus.Click
        If MsgBox("Data ini Akan di Hapus?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Koneksi()
            Dim hapus As String = "Delete from Tbl_Kasir where id_kasir='" & Me.idkasirtxt.Text & "'"
            cmd = New OleDbCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            tampilkan_data()
            bersih()
        Else
            bersih()
        End If
    End Sub

    Private Sub dgKasir_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgKasir.CellClick
        On Error Resume Next
        Dim i As Integer
        i = Me.dgKasir.CurrentRow.Index
        With dgKasir.Rows.Item(i)
            Me.idkasirtxt.Text = .Cells(0).Value
            Me.namatxt.Text = .Cells(1).Value
            Me.alamattxt.Text = .Cells(2).Value
            Me.telptxt.Text = .Cells(3).Value
            Me.cbStatus.Text = .Cells(4).Value
            Me.usernametxt.Text = .Cells(5).Value
            Me.passtxt.Text = .Cells(6).Value
            Me.cbAkses.Text = .Cells(7).Value
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

    Private Sub cbNama_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNama.SelectedValueChanged
        Koneksi()
        cmd = New OleDbCommand("select * from Tbl_Kasir where nama like '%" & cbNama.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Koneksi()
            da = New OleDbDataAdapter("select * from Tbl_Kasir where nama like '%" & cbNama.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            dgKasir.DataSource = ds.Tables(0)
        Else
            MsgBox("Tidak Ada Data Nama Kasir !!")
            cbNama.ResetText()
            tampilkan_data()
        End If
    End Sub

    Private Sub bClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClear.Click
        cbNama.ResetText()
        tampilkan_data()
    End Sub

    Private Sub bRekap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRekap.Click
        Me.Cursor = Cursors.WaitCursor
        LaporanKasir.WindowState = FormWindowState.Maximized
        LaporanKasir.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class