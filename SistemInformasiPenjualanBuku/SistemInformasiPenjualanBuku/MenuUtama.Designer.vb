<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.bLogin = New System.Windows.Forms.Button()
        Me.bLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tampilUser = New System.Windows.Forms.Label()
        Me.bBuku = New System.Windows.Forms.Label()
        Me.bDistributor = New System.Windows.Forms.Label()
        Me.bKasir = New System.Windows.Forms.Label()
        Me.bRekapBuku = New System.Windows.Forms.Label()
        Me.bPasok = New System.Windows.Forms.Label()
        Me.bMaster = New System.Windows.Forms.Label()
        Me.bPenjualan = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tampilStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.settingtoko = New System.Windows.Forms.Label()
        Me.setingtoko2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bRekapDistributor = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bLogin
        '
        Me.bLogin.Location = New System.Drawing.Point(39, 634)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(95, 41)
        Me.bLogin.TabIndex = 1
        Me.bLogin.Text = "Login"
        Me.bLogin.UseVisualStyleBackColor = True
        '
        'bLogout
        '
        Me.bLogout.Location = New System.Drawing.Point(165, 634)
        Me.bLogout.Name = "bLogout"
        Me.bLogout.Size = New System.Drawing.Size(95, 41)
        Me.bLogout.TabIndex = 2
        Me.bLogout.Text = "Keluar"
        Me.bLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1138, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username :"
        '
        'tampilUser
        '
        Me.tampilUser.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.tampilUser.ForeColor = System.Drawing.Color.White
        Me.tampilUser.Location = New System.Drawing.Point(1220, 9)
        Me.tampilUser.Name = "tampilUser"
        Me.tampilUser.Size = New System.Drawing.Size(131, 22)
        Me.tampilUser.TabIndex = 4
        '
        'bBuku
        '
        Me.bBuku.BackColor = System.Drawing.Color.White
        Me.bBuku.Enabled = False
        Me.bBuku.Image = CType(resources.GetObject("bBuku.Image"), System.Drawing.Image)
        Me.bBuku.Location = New System.Drawing.Point(35, 88)
        Me.bBuku.Name = "bBuku"
        Me.bBuku.Size = New System.Drawing.Size(158, 170)
        Me.bBuku.TabIndex = 8
        Me.bBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bDistributor
        '
        Me.bDistributor.Enabled = False
        Me.bDistributor.Image = CType(resources.GetObject("bDistributor.Image"), System.Drawing.Image)
        Me.bDistributor.Location = New System.Drawing.Point(207, 88)
        Me.bDistributor.Name = "bDistributor"
        Me.bDistributor.Size = New System.Drawing.Size(176, 170)
        Me.bDistributor.TabIndex = 9
        Me.bDistributor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bKasir
        '
        Me.bKasir.Enabled = False
        Me.bKasir.Image = CType(resources.GetObject("bKasir.Image"), System.Drawing.Image)
        Me.bKasir.Location = New System.Drawing.Point(404, 88)
        Me.bKasir.Name = "bKasir"
        Me.bKasir.Size = New System.Drawing.Size(166, 170)
        Me.bKasir.TabIndex = 10
        '
        'bRekapBuku
        '
        Me.bRekapBuku.Enabled = False
        Me.bRekapBuku.Image = CType(resources.GetObject("bRekapBuku.Image"), System.Drawing.Image)
        Me.bRekapBuku.Location = New System.Drawing.Point(597, 89)
        Me.bRekapBuku.Name = "bRekapBuku"
        Me.bRekapBuku.Size = New System.Drawing.Size(166, 170)
        Me.bRekapBuku.TabIndex = 11
        '
        'bPasok
        '
        Me.bPasok.Enabled = False
        Me.bPasok.Image = CType(resources.GetObject("bPasok.Image"), System.Drawing.Image)
        Me.bPasok.Location = New System.Drawing.Point(28, 312)
        Me.bPasok.Name = "bPasok"
        Me.bPasok.Size = New System.Drawing.Size(166, 170)
        Me.bPasok.TabIndex = 12
        '
        'bMaster
        '
        Me.bMaster.Enabled = False
        Me.bMaster.Image = CType(resources.GetObject("bMaster.Image"), System.Drawing.Image)
        Me.bMaster.Location = New System.Drawing.Point(214, 308)
        Me.bMaster.Name = "bMaster"
        Me.bMaster.Size = New System.Drawing.Size(166, 170)
        Me.bMaster.TabIndex = 13
        '
        'bPenjualan
        '
        Me.bPenjualan.Enabled = False
        Me.bPenjualan.Image = CType(resources.GetObject("bPenjualan.Image"), System.Drawing.Image)
        Me.bPenjualan.Location = New System.Drawing.Point(404, 313)
        Me.bPenjualan.Name = "bPenjualan"
        Me.bPenjualan.Size = New System.Drawing.Size(166, 170)
        Me.bPenjualan.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Input Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(235, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Input Distributor"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.tampilStatus)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.settingtoko)
        Me.Panel1.Controls.Add(Me.tampilUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.setingtoko2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1364, 58)
        Me.Panel1.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1138, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 20)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Status        :"
        '
        'tampilStatus
        '
        Me.tampilStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.tampilStatus.ForeColor = System.Drawing.Color.White
        Me.tampilStatus.Location = New System.Drawing.Point(1220, 32)
        Me.tampilStatus.Name = "tampilStatus"
        Me.tampilStatus.Size = New System.Drawing.Size(131, 22)
        Me.tampilStatus.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(88, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 44)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "SIP BUKU"
        '
        'Label2
        '
        Me.Label2.Enabled = False
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(1099, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 28)
        Me.Label2.TabIndex = 20
        '
        'settingtoko
        '
        Me.settingtoko.AutoSize = True
        Me.settingtoko.Enabled = False
        Me.settingtoko.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingtoko.ForeColor = System.Drawing.Color.White
        Me.settingtoko.Location = New System.Drawing.Point(3, 40)
        Me.settingtoko.Name = "settingtoko"
        Me.settingtoko.Size = New System.Drawing.Size(75, 13)
        Me.settingtoko.TabIndex = 19
        Me.settingtoko.Text = "Setting Profil"
        '
        'setingtoko2
        '
        Me.setingtoko2.Enabled = False
        Me.setingtoko2.Image = CType(resources.GetObject("setingtoko2.Image"), System.Drawing.Image)
        Me.setingtoko2.Location = New System.Drawing.Point(19, 3)
        Me.setingtoko2.Name = "setingtoko2"
        Me.setingtoko2.Size = New System.Drawing.Size(41, 36)
        Me.setingtoko2.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(435, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Input Pegawai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(635, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Rekap Buku"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 480)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Pemasokan Barang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(251, 478)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Master Data"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(435, 479)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Penjualan Buku"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(798, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(566, 689)
        Me.Panel2.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(64, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(448, 86)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Warung Buku"
        '
        'bRekapDistributor
        '
        Me.bRekapDistributor.Enabled = False
        Me.bRekapDistributor.Image = CType(resources.GetObject("bRekapDistributor.Image"), System.Drawing.Image)
        Me.bRekapDistributor.Location = New System.Drawing.Point(598, 313)
        Me.bRekapDistributor.Name = "bRekapDistributor"
        Me.bRekapDistributor.Size = New System.Drawing.Size(166, 170)
        Me.bRekapDistributor.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(618, 479)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Rekap Distributor"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1360, 739)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.bLogout)
        Me.Controls.Add(Me.bRekapDistributor)
        Me.Controls.Add(Me.bLogin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bPenjualan)
        Me.Controls.Add(Me.bMaster)
        Me.Controls.Add(Me.bPasok)
        Me.Controls.Add(Me.bRekapBuku)
        Me.Controls.Add(Me.bKasir)
        Me.Controls.Add(Me.bDistributor)
        Me.Controls.Add(Me.bBuku)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bLogin As System.Windows.Forms.Button
    Friend WithEvents bLogout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tampilUser As System.Windows.Forms.Label
    Friend WithEvents bBuku As System.Windows.Forms.Label
    Friend WithEvents bDistributor As System.Windows.Forms.Label
    Friend WithEvents bKasir As System.Windows.Forms.Label
    Friend WithEvents bRekapBuku As System.Windows.Forms.Label
    Friend WithEvents bPasok As System.Windows.Forms.Label
    Friend WithEvents bMaster As System.Windows.Forms.Label
    Friend WithEvents bPenjualan As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents setingtoko2 As System.Windows.Forms.Label
    Friend WithEvents settingtoko As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents bRekapDistributor As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tampilStatus As System.Windows.Forms.Label
End Class
