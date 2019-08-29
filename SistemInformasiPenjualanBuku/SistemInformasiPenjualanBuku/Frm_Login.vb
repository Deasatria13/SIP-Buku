Imports System.Data.OleDb
Public Class Frm_Login
    Sub bersih()
        cbUser.Text = ""
        passtxt.Clear()
    End Sub
    Sub tampilkan_user()
        cmd = New OleDbCommand("Select * from Tbl_Kasir", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbUser.Items.Add(rd.Item(5))
            cbUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbUser.AutoCompleteSource = AutoCompleteSource.ListItems
        Loop
    End Sub
    Private Sub Frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        bersih()
        tampilkan_user()
    End Sub

    Private Sub bLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLogin.Click
        Call Koneksi()
        cmd = New OleDbCommand("select * from Tbl_Kasir where username='" & cbUser.Text & "' and password='" & passtxt.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Login Gagal")
            cbUser.Focus()
            bersih()
        Else
            Me.Visible = False
            If rd.Item("akses") = "Administator" Then
                MenuUtama.Show()
                MenuUtama.bbuku.Enabled = True
                MenuUtama.bKasir.Enabled = True
                MenuUtama.bPasok.Enabled = True
                MenuUtama.bRekapBuku.Enabled = True
                MenuUtama.bRekapDistributor.Enabled = True
                MenuUtama.bPenjualan.Enabled = True
                MenuUtama.bDistributor.Enabled = True
                MenuUtama.settingtoko.Enabled = True
                MenuUtama.setingtoko2.Enabled = True
                MenuUtama.bMaster.Enabled = True
                MenuUtama.Enabled = True
            ElseIf rd.Item("akses") = "Kasir" Then
                MenuUtama.Show()
                MenuUtama.bBuku.Enabled = False
                MenuUtama.bKasir.Enabled = False
                MenuUtama.bPasok.Enabled = False
                MenuUtama.bRekapBuku.Enabled = False
                MenuUtama.bRekapDistributor.Enabled = False
                MenuUtama.bPenjualan.Enabled = True
                MenuUtama.bDistributor.Enabled = False
                MenuUtama.settingtoko.Enabled = False
                MenuUtama.setingtoko2.Enabled = False
                MenuUtama.bMaster.Enabled = False
                MenuUtama.Enabled = True
            End If
        End If
    End Sub

    Private Sub cbUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUser.SelectedIndexChanged
        cmd = New OleDbCommand("Select * from Tbl_Kasir where username='" & cbUser.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            MenuUtama.tampilUser.Text = rd.Item("nama")
            MenuUtama.tampilStatus.Text = rd.Item("akses")
        End If
    End Sub
End Class