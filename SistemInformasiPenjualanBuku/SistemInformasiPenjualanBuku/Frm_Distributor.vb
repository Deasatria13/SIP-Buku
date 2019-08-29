Imports System.Data.OleDb
Public Class Frm_Distributor
    Sub nyala()
        Me.namatxt.Enabled = True
        Me.alamattxt.Enabled = True
        Me.telptxt.Enabled = True
    End Sub
    Sub mati()
        Me.namatxt.Enabled = False
        Me.alamattxt.Enabled = False
        Me.telptxt.Enabled = False
    End Sub
    Sub bersih()
        Me.namatxt.Clear()
        Me.alamattxt.Clear()
        Me.telptxt.Clear()
    End Sub
    Private Sub id_otomatis()
        Koneksi()
        cmd = New OleDbCommand("Select * from Tbl_Distributor where id_distributor in(select max (id_distributor)from Tbl_Distributor)", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = 0 Then
            iddistxt.Text = "DIS" & Date.Now.Year & "000001"
        End If
        If Not rd.HasRows Then
            iddistxt.Text = "DIS" & Date.Now.Year & "000001"
            rd.Close()
        Else
            iddistxt.Text = Val(Microsoft.VisualBasic.Right(rd.Item("id_distributor").ToString, 6)) + 1
            If Len(iddistxt.Text) = 1 Then
                iddistxt.Text = "DIS" & Date.Now.Year & "00000" & iddistxt.Text & ""
            ElseIf Len(iddistxt.Text) = 2 Then
                iddistxt.Text = "DIS" & Date.Now.Year & "0000" & iddistxt.Text & ""
            ElseIf Len(iddistxt.Text) = 3 Then
                iddistxt.Text = "DIS" & Date.Now.Year & "000" & iddistxt.Text & ""
            ElseIf Len(iddistxt.Text) = 4 Then
                iddistxt.Text = "DIS" & Date.Now.Year & "00" & iddistxt.Text & ""
            ElseIf Len(iddistxt.Text) = 5 Then
                iddistxt.Text = "DIS" & Date.Now.Year & "0" & iddistxt.Text & ""
            End If
            rd.Close()
        End If
    End Sub
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
    Private Sub Frm_Distributor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampilkan_data()
        bBaru.Focus()
    End Sub

    Private Sub bBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBaru.Click
        nyala()
        bersih()
        Me.bEdit.Text = "&Batal"
        id_otomatis()
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

    Private Sub bHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHapus.Click
        If MsgBox("Data ini Akan di Hapus?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Koneksi()
            Dim hapus As String = "Delete from Tbl_Distributor where id_distributor='" & Me.iddistxt.Text & "'"
            cmd = New OleDbCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            tampilkan_data()
            bersih()
        Else
            bersih()
        End If
    End Sub

    Private Sub bSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSimpan.Click
        Koneksi()
        If Me.namatxt.Text = "" Then
            MsgBox("Data Masih Ada yang kosong !", MsgBoxStyle.Critical, "Peringatan")
        Else
            cmd = New OleDbCommand("Select * from Tbl_Distributor where id_distributor='" & Me.iddistxt.Text & "'", conn)
            rd = cmd.ExecuteReader()
            If Not rd.HasRows Then
                Koneksi()
                Me.bEdit.Text = "&Edit"
                Me.bBaru.Focus()
                Dim Simpan As String = "Insert into Tbl_Distributor values('" & Me.iddistxt.Text & "','" & Me.namatxt.Text & "','" & Me.alamattxt.Text & "','" & Me.telptxt.Text & "')"
                cmd = New OleDbCommand(Simpan, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                tampilkan_data()
                bBaru.Focus()
                id_otomatis()
            ElseIf Me.bSimpan.Text = "&Perbaharui" Then
                Me.bSimpan.Text = "&Simpan"
                Me.bEdit.Text = "&Edit"
                Me.bBaru.Focus()
                Koneksi()
                Dim ubah As String = "Update Tbl_Distributor set [nama_distributor]='" & namatxt.Text & "',alamat='" & alamattxt.Text & "',telepon='" & telptxt.Text & "'where [id_distributor]='" & iddistxt.Text & "'"
                cmd = New OleDbCommand(ubah, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                tampilkan_data()
                bBaru.Focus()
                id_otomatis()
            End If
            bersih()
            mati()
            bSimpan.Enabled = False
        End If
    End Sub

    Private Sub dgDis_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDis.CellClick
        On Error Resume Next
        Dim i As Integer
        i = Me.dgDis.CurrentRow.Index
        With dgDis.Rows.Item(i)
            Me.iddistxt.Text = .Cells(0).Value
            Me.namatxt.Text = .Cells(1).Value
            Me.alamattxt.Text = .Cells(2).Value
            Me.telptxt.Text = .Cells(3).Value
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

    Private Sub bRekap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRekap.Click
        Me.Cursor = Cursors.WaitCursor
        LaporanDistributor.WindowState = FormWindowState.Maximized
        LaporanDistributor.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class