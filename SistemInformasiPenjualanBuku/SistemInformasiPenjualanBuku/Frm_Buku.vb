Imports System.Data.OleDb
Public Class Frm_Buku
    Private Sub id_otomatis()
        Koneksi()
        cmd = New OleDbCommand("Select * from Tbl_Buku where id_buku in(select max (id_buku)from Tbl_Buku)", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = 0 Then
            idbukutxt.Text = "BK" & Date.Now.Year & "000001"
        End If
        If Not rd.HasRows Then
            idbukutxt.Text = "BK" & Date.Now.Year & "000001"
            rd.Close()
        Else
            idbukutxt.Text = Val(Microsoft.VisualBasic.Right(rd.Item("id_buku").ToString, 6)) + 1
            If Len(idbukutxt.Text) = 1 Then
                idbukutxt.Text = "BK" & Date.Now.Year & "00000" & idbukutxt.Text & ""
            ElseIf Len(idbukutxt.Text) = 2 Then
                idbukutxt.Text = "BK" & Date.Now.Year & "0000" & idbukutxt.Text & ""
            ElseIf Len(idbukutxt.Text) = 3 Then
                idbukutxt.Text = "BK" & Date.Now.Year & "000" & idbukutxt.Text & ""
            ElseIf Len(idbukutxt.Text) = 4 Then
                idbukutxt.Text = "BK" & Date.Now.Year & "00" & idbukutxt.Text & ""
            ElseIf Len(idbukutxt.Text) = 5 Then
                idbukutxt.Text = "BK" & Date.Now.Year & "0" & idbukutxt.Text & ""
            End If
            rd.Close()
        End If
    End Sub
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
    Sub mati()
        Me.judultxt.Enabled = False
        Me.noisbntxt.Enabled = False
        Me.penulistxt.Enabled = False
        Me.penerbittxt.Enabled = False
        Me.cbTahun.Enabled = False
        Me.stoktxt.Enabled = False
        Me.hargaPtxt.Enabled = False
        Me.hargaDtxt.Enabled = False
        Me.hargaJtxt.Enabled = False
        Me.ppntxt.Enabled = False
        Me.diskontxt.Enabled = False
    End Sub
    Sub nyala()
        Me.judultxt.Enabled = True
        Me.noisbntxt.Enabled = True
        Me.penulistxt.Enabled = True
        Me.penerbittxt.Enabled = True
        Me.cbTahun.Enabled = True
        Me.hargaPtxt.Enabled = True
        Me.hargaDtxt.Enabled = True
        Me.hargaJtxt.Enabled = True
        Me.ppntxt.Enabled = True
        Me.diskontxt.Enabled = True
    End Sub
    Sub bersih()
        Me.judultxt.Clear()
        Me.noisbntxt.Clear()
        Me.penulistxt.Clear()
        Me.penerbittxt.Clear()
        Me.cbTahun.Text = ""
        Me.stoktxt.Clear()
        Me.hargaPtxt.Clear()
        Me.hargaDtxt.Clear()
        Me.hargaJtxt.Clear()
        Me.ppntxt.Clear()
        Me.diskontxt.Text = ""
        Me.hargaDtxt.Text = ""
    End Sub
    Private Sub Frm_Buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tahunlist()
        tampilkan_data()
        bBaru.Focus()
    End Sub

    Private Sub bBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBaru.Click
        nyala()
        bersih()
        id_otomatis()
        Me.bEdit.Text = "&Batal"
        judultxt.Focus()
        Me.stoktxt.Text = 0
        Me.bSimpan.Enabled = True
    End Sub

    Private Sub bSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSimpan.Click
        Koneksi()
        If Me.judultxt.Text = "" Then
            MsgBox("Data Masih Ada yang kosong !", MsgBoxStyle.Critical, "Peringatan")
        Else
            cmd = New OleDbCommand("Select * from Tbl_Buku where id_buku='" & Me.idbukutxt.Text & "'", conn)
            rd = cmd.ExecuteReader()
            If Not rd.HasRows Then
                Koneksi()
                Me.bEdit.Text = "&Edit"
                Me.bBaru.Focus()
                Dim Simpan As String = "Insert into Tbl_Buku values('" & Me.idbukutxt.Text & "','" & Me.judultxt.Text & "','" & Me.noisbntxt.Text & "','" & Me.penulistxt.Text & "','" & Me.penerbittxt.Text & "','" & Me.cbTahun.Text & "','" & Me.stoktxt.Text & "','" & Val(Me.hargaPtxt.Text) & "','" & Val(Me.hargaDtxt.Text) & "','" & Val(Me.hargaJtxt.Text) & "','" & Val(Me.ppntxt.Text) & "','" & Val(Me.diskontxt.Text) & "')"
                cmd = New OleDbCommand(Simpan, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                tampilkan_data()
                bBaru.Focus()
                id_otomatis()
                bSimpan.Enabled = False
            ElseIf Me.bSimpan.Text = "&Perbaharui" Then
                Me.bSimpan.Text = "&Simpan"
                Me.bEdit.Text = "&Edit"
                Me.bBaru.Focus()
                Koneksi()
                Dim ubah As String = "Update Tbl_Buku set [judul]='" & judultxt.Text & "',noisbn='" & noisbntxt.Text & "',penulis='" & penulistxt.Text & "',penerbit='" & penerbittxt.Text & "',tahun='" & cbTahun.Text & "',stok='" & stoktxt.Text & "',harga_pokok='" & hargaPtxt.Text & "',harga_diskon='" & hargaDtxt.Text & "',harga_jual='" & hargaJtxt.Text & "',ppn='" & ppntxt.Text & "',diskon='" & diskontxt.Text & "' where [id_buku]='" & idbukutxt.Text & "'"
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

    Private Sub hargaPtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hargaPtxt.TextChanged
        On Error Resume Next
        If Me.hargaPtxt.Text = vbNullString Then
            Me.hargaPtxt.Text = ""
        Else
            If CInt(Me.hargaPtxt.Text) > CInt(Me.hargaPtxt.Text) Then
                Me.hargaPtxt.Text = ""
            End If
        End If
        If Me.hargaPtxt.Text <> vbNullString Then
            Me.hargaJtxt.Text = Val(Me.hargaPtxt.Text * 1.2)
        End If
        If hargaPtxt.Text = "" Then
            hargaJtxt.Text = ""
        End If
    End Sub

    Private Sub hargaJtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hargaJtxt.TextChanged
        On Error Resume Next
        If Me.hargaJtxt.Text = vbNullString Then
            Me.hargaJtxt.Text = ""
        Else
            If CInt(Me.hargaJtxt.Text) > CInt(Me.hargaJtxt.Text) Then
                Me.hargaJtxt.Text = ""
            End If
        End If
        If Me.hargaJtxt.Text <> vbNullString Then
            Me.ppntxt.Text = Val(Me.hargaJtxt.Text) * 0.1
        End If
    End Sub

    Private Sub diskontxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diskontxt.TextChanged
        On Error Resume Next
        If Me.diskontxt.Text <> vbNullString Then
            Me.diskonLb.Text = Val(Me.diskontxt.Text * Me.hargaPtxt.Text) / 100
        ElseIf diskontxt.Text = "" Then
            Me.diskonLb.Text = ""
        End If
        If Me.diskontxt.Text <> vbNullString Then
            Me.hargaDtxt.Text = Val(Me.hargaPtxt.Text) - Val(Me.diskonLb.Text)
        End If
        If Me.diskontxt.Text = "" Then
            Me.diskontxt.Text = 0
        End If
    End Sub

    Private Sub bEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEdit.Click
        If Me.bEdit.Text = "&Batal" Then
            Me.bEdit.Text = "&Edit"
            Me.bSimpan.Text = "&Simpan"
            Me.mati()
            bSimpan.Enabled = False
            bersih()
            Koneksi()
        ElseIf Me.bEdit.Text = "&Edit" Then
            Me.bEdit.Text = "&Batal"
            Koneksi()
            Me.nyala()
            Me.bSimpan.Text = "&Perbaharui"
            Me.bSimpan.Enabled = True
        End If
    End Sub

    Private Sub bHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHapus.Click
        If MsgBox("Data ini Akan di Hapus?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Koneksi()
            Dim hapus As String = "Delete from Tbl_Buku where id_buku='" & Me.idbukutxt.Text & "'"
            cmd = New OleDbCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            tampilkan_data()
            bersih()
        Else
            bersih()
        End If
    End Sub

    Private Sub dgBuku_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBuku.CellClick
        On Error Resume Next
        Dim i As Integer
        i = Me.dgBuku.CurrentRow.Index
        With dgBuku.Rows.Item(i)
            Me.idbukutxt.Text = .Cells(0).Value
            Me.judultxt.Text = .Cells(1).Value
            Me.noisbntxt.Text = .Cells(2).Value
            Me.penulistxt.Text = .Cells(3).Value
            Me.penerbittxt.Text = .Cells(4).Value
            Me.cbTahun.Text = .Cells(5).Value
            Me.stoktxt.Text = .Cells(6).Value
            Me.hargaPtxt.Text = .Cells(7).Value
            Me.hargaDtxt.Text = .Cells(8).Value
            Me.hargaJtxt.Text = .Cells(9).Value
            Me.ppntxt.Text = .Cells(10).Value
            Me.diskontxt.Text = .Cells(11).Value
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
        Frm_RekapBuku.Show()
    End Sub
End Class
