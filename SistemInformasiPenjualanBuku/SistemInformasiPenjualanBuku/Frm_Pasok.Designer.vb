<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pasok
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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.idbuku = New System.Windows.Forms.TextBox()
        Me.iddistxt = New System.Windows.Forms.TextBox()
        Me.totaltxt = New System.Windows.Forms.TextBox()
        Me.jumlahtxt = New System.Windows.Forms.TextBox()
        Me.hargatxt = New System.Windows.Forms.TextBox()
        Me.tgl = New System.Windows.Forms.DateTimePicker()
        Me.idpasoktxt = New System.Windows.Forms.TextBox()
        Me.dgPasok = New System.Windows.Forms.DataGridView()
        Me.cbDis = New System.Windows.Forms.ComboBox()
        Me.cbBuku = New System.Windows.Forms.ComboBox()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.bBaru = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bLaporan = New System.Windows.Forms.Button()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.dgPasok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(25, 269)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(31, 13)
        Label5.TabIndex = 26
        Label5.Text = "Total"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(25, 245)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(40, 13)
        Label4.TabIndex = 24
        Label4.Text = "Jumlah"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(25, 220)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(70, 13)
        Label3.TabIndex = 22
        Label3.Text = "Harga Pokok"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(25, 194)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(46, 13)
        Label2.TabIndex = 20
        Label2.Text = "ID Buku"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(25, 169)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 13)
        Label1.TabIndex = 18
        Label1.Text = "ID Distributor"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(25, 144)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(51, 13)
        Label6.TabIndex = 15
        Label6.Text = "ID Pasok"
        '
        'idbuku
        '
        Me.idbuku.Enabled = False
        Me.idbuku.Location = New System.Drawing.Point(203, 191)
        Me.idbuku.Name = "idbuku"
        Me.idbuku.Size = New System.Drawing.Size(100, 20)
        Me.idbuku.TabIndex = 29
        '
        'iddistxt
        '
        Me.iddistxt.Enabled = False
        Me.iddistxt.Location = New System.Drawing.Point(203, 166)
        Me.iddistxt.Name = "iddistxt"
        Me.iddistxt.Size = New System.Drawing.Size(100, 20)
        Me.iddistxt.TabIndex = 28
        '
        'totaltxt
        '
        Me.totaltxt.Enabled = False
        Me.totaltxt.Location = New System.Drawing.Point(97, 266)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(206, 20)
        Me.totaltxt.TabIndex = 6
        '
        'jumlahtxt
        '
        Me.jumlahtxt.Enabled = False
        Me.jumlahtxt.Location = New System.Drawing.Point(97, 242)
        Me.jumlahtxt.Name = "jumlahtxt"
        Me.jumlahtxt.Size = New System.Drawing.Size(206, 20)
        Me.jumlahtxt.TabIndex = 5
        '
        'hargatxt
        '
        Me.hargatxt.Enabled = False
        Me.hargatxt.Location = New System.Drawing.Point(97, 217)
        Me.hargatxt.Name = "hargatxt"
        Me.hargatxt.Size = New System.Drawing.Size(206, 20)
        Me.hargatxt.TabIndex = 4
        '
        'tgl
        '
        Me.tgl.Location = New System.Drawing.Point(629, 15)
        Me.tgl.Name = "tgl"
        Me.tgl.Size = New System.Drawing.Size(200, 20)
        Me.tgl.TabIndex = 17
        '
        'idpasoktxt
        '
        Me.idpasoktxt.Enabled = False
        Me.idpasoktxt.Location = New System.Drawing.Point(97, 141)
        Me.idpasoktxt.Name = "idpasoktxt"
        Me.idpasoktxt.Size = New System.Drawing.Size(206, 20)
        Me.idpasoktxt.TabIndex = 1
        '
        'dgPasok
        '
        Me.dgPasok.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgPasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPasok.Location = New System.Drawing.Point(331, 141)
        Me.dgPasok.Name = "dgPasok"
        Me.dgPasok.Size = New System.Drawing.Size(514, 264)
        Me.dgPasok.TabIndex = 30
        '
        'cbDis
        '
        Me.cbDis.Enabled = False
        Me.cbDis.FormattingEnabled = True
        Me.cbDis.Location = New System.Drawing.Point(97, 166)
        Me.cbDis.Name = "cbDis"
        Me.cbDis.Size = New System.Drawing.Size(100, 21)
        Me.cbDis.TabIndex = 2
        '
        'cbBuku
        '
        Me.cbBuku.Enabled = False
        Me.cbBuku.FormattingEnabled = True
        Me.cbBuku.Location = New System.Drawing.Point(97, 191)
        Me.cbBuku.Name = "cbBuku"
        Me.cbBuku.Size = New System.Drawing.Size(100, 21)
        Me.cbBuku.TabIndex = 3
        '
        'bEdit
        '
        Me.bEdit.Location = New System.Drawing.Point(177, 12)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(75, 23)
        Me.bEdit.TabIndex = 36
        Me.bEdit.Text = "&Edit"
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(259, 12)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(75, 23)
        Me.bHapus.TabIndex = 35
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bSimpan
        '
        Me.bSimpan.Enabled = False
        Me.bSimpan.Location = New System.Drawing.Point(96, 12)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(75, 23)
        Me.bSimpan.TabIndex = 34
        Me.bSimpan.Text = "&Simpan"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'bBaru
        '
        Me.bBaru.Location = New System.Drawing.Point(15, 12)
        Me.bBaru.Name = "bBaru"
        Me.bBaru.Size = New System.Drawing.Size(75, 23)
        Me.bBaru.TabIndex = 0
        Me.bBaru.Text = "&Baru"
        Me.bBaru.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bLaporan)
        Me.Panel1.Controls.Add(Me.bEdit)
        Me.Panel1.Controls.Add(Me.bHapus)
        Me.Panel1.Controls.Add(Me.bSimpan)
        Me.Panel1.Controls.Add(Me.bBaru)
        Me.Panel1.Controls.Add(Me.tgl)
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 49)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bKeluar)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(-4, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(867, 58)
        Me.Panel2.TabIndex = 46
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(771, 11)
        Me.bKeluar.Name = "bKeluar"
        Me.bKeluar.Size = New System.Drawing.Size(78, 28)
        Me.bKeluar.TabIndex = 30
        Me.bKeluar.Text = "&Keluar"
        Me.bKeluar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(408, 50)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Input Pemasokan Buku"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(-4, 411)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(867, 52)
        Me.Panel3.TabIndex = 48
        '
        'bLaporan
        '
        Me.bLaporan.Location = New System.Drawing.Point(466, 12)
        Me.bLaporan.Name = "bLaporan"
        Me.bLaporan.Size = New System.Drawing.Size(145, 23)
        Me.bLaporan.TabIndex = 37
        Me.bLaporan.Text = "Laporan Pasok"
        Me.bLaporan.UseVisualStyleBackColor = True
        '
        'Frm_Pasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(857, 456)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbBuku)
        Me.Controls.Add(Me.cbDis)
        Me.Controls.Add(Me.dgPasok)
        Me.Controls.Add(Me.idbuku)
        Me.Controls.Add(Me.iddistxt)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.totaltxt)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.jumlahtxt)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.hargatxt)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.idpasoktxt)
        Me.Name = "Frm_Pasok"
        Me.Text = "Pemasokan Buku"
        CType(Me.dgPasok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idbuku As System.Windows.Forms.TextBox
    Friend WithEvents iddistxt As System.Windows.Forms.TextBox
    Friend WithEvents totaltxt As System.Windows.Forms.TextBox
    Friend WithEvents jumlahtxt As System.Windows.Forms.TextBox
    Friend WithEvents hargatxt As System.Windows.Forms.TextBox
    Friend WithEvents tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents idpasoktxt As System.Windows.Forms.TextBox
    Friend WithEvents dgPasok As System.Windows.Forms.DataGridView
    Friend WithEvents cbDis As System.Windows.Forms.ComboBox
    Friend WithEvents cbBuku As System.Windows.Forms.ComboBox
    Friend WithEvents bEdit As System.Windows.Forms.Button
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bSimpan As System.Windows.Forms.Button
    Friend WithEvents bBaru As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents bLaporan As System.Windows.Forms.Button
End Class
