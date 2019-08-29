Imports System.Data.OleDb
Public Class Frm_Toko
    Sub tampildata()
        cmd = New OleDbCommand("Select * from Tbl_IdentitasToko", conn)
        rd = cmd.ExecuteReader
        With rd.Read
            Me.namatxt.Text = rd.Item(0)
            Me.alamattxt.Text = rd.Item(1)
            Me.pemiliktxt.Text = rd.Item(2)
            Me.notxt.Text = rd.Item(3)
            Me.kodepostxt.Text = rd.Item(4)
            Me.emailtxt.Text = rd.Item(5)
        End With
    End Sub
    Sub nyala()
        Me.alamattxt.Enabled = True
        Me.pemiliktxt.Enabled = True
        Me.notxt.Enabled = True
        Me.kodepostxt.Enabled = True
        Me.emailtxt.Enabled = True
    End Sub
    Sub mati()
        Me.alamattxt.Enabled = False
        Me.pemiliktxt.Enabled = False
        Me.notxt.Enabled = False
        Me.kodepostxt.Enabled = False
        Me.emailtxt.Enabled = False
    End Sub
    Private Sub Frm_Toko_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampildata()
    End Sub

    Private Sub bSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSimpan.Click
        Koneksi()
        Dim ubah As String = "Update Tbl_IdentitasToko set [alamat]='" & alamattxt.Text & "',[pemilik]='" & pemiliktxt.Text & "',[telp]='" & notxt.Text & "',[kodepos]='" & kodepostxt.Text & "',[email]='" & emailtxt.Text & "'where [namaToko]='" & namatxt.Text & "'"
        cmd = New OleDbCommand(ubah, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        mati()
        MenuUtama.Show()
        Hide()
    End Sub

    Private Sub bEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEdit.Click
        nyala()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class