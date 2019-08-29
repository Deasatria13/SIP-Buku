Public Class MenuUtama


    Private Sub bBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuku.Click
        Frm_Buku.Show()
        Hide()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKasir.Click
        Frm_Kasir.Show()
        Hide()
    End Sub

    Private Sub bDistributor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDistributor.Click
        Frm_Distributor.Show()
        Hide()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRekapBuku.Click
        Frm_RekapBuku.Show()
    End Sub

    Private Sub Pasok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPasok.Click
        Frm_Pasok.Show()
        Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMaster.Click
        Frm_MasterData.Show()
        Hide()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPenjualan.Click
        Frm_Penjualan.Show()
        Hide()
    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setingtoko2.Click
        Frm_Toko.Show()
        Hide()
    End Sub

    Private Sub bLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLogin.Click
        Frm_Login.Show()
        tampilUser.Text = ""
        Frm_Login.cbUser.Text = ""
        Frm_Login.passtxt.Clear()
        Me.Enabled = False
    End Sub

    Private Sub bLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLogout.Click
        If MsgBox("Anda Yakin Akan Keluar ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
            End
        Else
        End If

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingtoko.Click
        Frm_Toko.Show()
        Hide()
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bRekapDistributor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRekapDistributor.Click
        Frm_RekapDistributor.Show()
    End Sub

End Class