<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Kasir
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
        Me.components = New System.ComponentModel.Container()
        Dim Id_kasirLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Kasir))
        Me.idkasirtxt = New System.Windows.Forms.TextBox()
        Me.namatxt = New System.Windows.Forms.TextBox()
        Me.alamattxt = New System.Windows.Forms.TextBox()
        Me.telptxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.cbAkses = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.dgKasir = New System.Windows.Forms.DataGridView()
        Me.IdkasirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AksesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblKasirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSIPBukuDataSet = New SistemInformasiPenjualanBuku.dbSIPBukuDataSet()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.bBaru = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bClear = New System.Windows.Forms.Button()
        Me.Tahun = New System.Windows.Forms.Label()
        Me.cbNama = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tbl_KasirTableAdapter = New SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_KasirTableAdapter()
        Me.bRekap = New System.Windows.Forms.Button()
        Id_kasirLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.dgKasir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblKasirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_kasirLabel
        '
        Id_kasirLabel.AutoSize = True
        Id_kasirLabel.Location = New System.Drawing.Point(18, 126)
        Id_kasirLabel.Name = "Id_kasirLabel"
        Id_kasirLabel.Size = New System.Drawing.Size(44, 13)
        Id_kasirLabel.TabIndex = 1
        Id_kasirLabel.Text = "ID Kasir"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(18, 152)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(35, 13)
        Label1.TabIndex = 3
        Label1.Text = "Nama"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(18, 178)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(39, 13)
        Label2.TabIndex = 3
        Label2.Text = "Alamat"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(18, 204)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(28, 13)
        Label3.TabIndex = 3
        Label3.Text = "Telp"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(18, 230)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(37, 13)
        Label4.TabIndex = 3
        Label4.Text = "Status"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(18, 256)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 13)
        Label5.TabIndex = 3
        Label5.Text = "Username"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(20, 282)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(53, 13)
        Label6.TabIndex = 3
        Label6.Text = "Password"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(20, 308)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(36, 13)
        Label7.TabIndex = 3
        Label7.Text = "Akses"
        '
        'idkasirtxt
        '
        Me.idkasirtxt.Enabled = False
        Me.idkasirtxt.Location = New System.Drawing.Point(79, 123)
        Me.idkasirtxt.Name = "idkasirtxt"
        Me.idkasirtxt.Size = New System.Drawing.Size(254, 20)
        Me.idkasirtxt.TabIndex = 2
        '
        'namatxt
        '
        Me.namatxt.Enabled = False
        Me.namatxt.Location = New System.Drawing.Point(79, 149)
        Me.namatxt.Name = "namatxt"
        Me.namatxt.Size = New System.Drawing.Size(254, 20)
        Me.namatxt.TabIndex = 2
        '
        'alamattxt
        '
        Me.alamattxt.Enabled = False
        Me.alamattxt.Location = New System.Drawing.Point(79, 175)
        Me.alamattxt.Name = "alamattxt"
        Me.alamattxt.Size = New System.Drawing.Size(254, 20)
        Me.alamattxt.TabIndex = 3
        '
        'telptxt
        '
        Me.telptxt.Enabled = False
        Me.telptxt.Location = New System.Drawing.Point(79, 201)
        Me.telptxt.Name = "telptxt"
        Me.telptxt.Size = New System.Drawing.Size(254, 20)
        Me.telptxt.TabIndex = 4
        '
        'usernametxt
        '
        Me.usernametxt.Enabled = False
        Me.usernametxt.Location = New System.Drawing.Point(79, 253)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(254, 20)
        Me.usernametxt.TabIndex = 6
        '
        'passtxt
        '
        Me.passtxt.Enabled = False
        Me.passtxt.Location = New System.Drawing.Point(79, 279)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(254, 20)
        Me.passtxt.TabIndex = 7
        '
        'cbAkses
        '
        Me.cbAkses.Enabled = False
        Me.cbAkses.FormattingEnabled = True
        Me.cbAkses.Location = New System.Drawing.Point(79, 305)
        Me.cbAkses.Name = "cbAkses"
        Me.cbAkses.Size = New System.Drawing.Size(254, 21)
        Me.cbAkses.TabIndex = 8
        '
        'cbStatus
        '
        Me.cbStatus.Enabled = False
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(79, 226)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(254, 21)
        Me.cbStatus.TabIndex = 5
        '
        'dgKasir
        '
        Me.dgKasir.AutoGenerateColumns = False
        Me.dgKasir.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKasir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdkasirDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TelpDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.AksesDataGridViewTextBoxColumn})
        Me.dgKasir.DataSource = Me.TblKasirBindingSource
        Me.dgKasir.Location = New System.Drawing.Point(339, 123)
        Me.dgKasir.Name = "dgKasir"
        Me.dgKasir.Size = New System.Drawing.Size(539, 231)
        Me.dgKasir.TabIndex = 6
        '
        'IdkasirDataGridViewTextBoxColumn
        '
        Me.IdkasirDataGridViewTextBoxColumn.DataPropertyName = "id_kasir"
        Me.IdkasirDataGridViewTextBoxColumn.HeaderText = "ID Kasir"
        Me.IdkasirDataGridViewTextBoxColumn.Name = "IdkasirDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'TelpDataGridViewTextBoxColumn
        '
        Me.TelpDataGridViewTextBoxColumn.DataPropertyName = "telp"
        Me.TelpDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TelpDataGridViewTextBoxColumn.Name = "TelpDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'AksesDataGridViewTextBoxColumn
        '
        Me.AksesDataGridViewTextBoxColumn.DataPropertyName = "akses"
        Me.AksesDataGridViewTextBoxColumn.HeaderText = "Akses"
        Me.AksesDataGridViewTextBoxColumn.Name = "AksesDataGridViewTextBoxColumn"
        '
        'TblKasirBindingSource
        '
        Me.TblKasirBindingSource.DataMember = "Tbl_Kasir"
        Me.TblKasirBindingSource.DataSource = Me.DbSIPBukuDataSet
        '
        'DbSIPBukuDataSet
        '
        Me.DbSIPBukuDataSet.DataSetName = "dbSIPBukuDataSet"
        Me.DbSIPBukuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bEdit
        '
        Me.bEdit.Location = New System.Drawing.Point(170, 10)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(75, 32)
        Me.bEdit.TabIndex = 40
        Me.bEdit.Text = "&Edit"
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(251, 10)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(75, 32)
        Me.bHapus.TabIndex = 39
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bSimpan
        '
        Me.bSimpan.Enabled = False
        Me.bSimpan.Location = New System.Drawing.Point(89, 10)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(75, 32)
        Me.bSimpan.TabIndex = 9
        Me.bSimpan.Text = "&Simpan"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'bBaru
        '
        Me.bBaru.Location = New System.Drawing.Point(8, 10)
        Me.bBaru.Name = "bBaru"
        Me.bBaru.Size = New System.Drawing.Size(75, 32)
        Me.bBaru.TabIndex = 1
        Me.bBaru.Text = "&Baru"
        Me.bBaru.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bRekap)
        Me.Panel1.Controls.Add(Me.bClear)
        Me.Panel1.Controls.Add(Me.Tahun)
        Me.Panel1.Controls.Add(Me.cbNama)
        Me.Panel1.Controls.Add(Me.bEdit)
        Me.Panel1.Controls.Add(Me.bHapus)
        Me.Panel1.Controls.Add(Me.bSimpan)
        Me.Panel1.Controls.Add(Me.bBaru)
        Me.Panel1.Location = New System.Drawing.Point(12, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(866, 54)
        Me.Panel1.TabIndex = 41
        '
        'bClear
        '
        Me.bClear.Image = CType(resources.GetObject("bClear.Image"), System.Drawing.Image)
        Me.bClear.Location = New System.Drawing.Point(595, 15)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(22, 23)
        Me.bClear.TabIndex = 49
        Me.bClear.UseVisualStyleBackColor = True
        '
        'Tahun
        '
        Me.Tahun.AutoSize = True
        Me.Tahun.Location = New System.Drawing.Point(352, 20)
        Me.Tahun.Name = "Tahun"
        Me.Tahun.Size = New System.Drawing.Size(61, 13)
        Me.Tahun.TabIndex = 48
        Me.Tahun.Text = "Nama Kasir"
        '
        'cbNama
        '
        Me.cbNama.FormattingEnabled = True
        Me.cbNama.Location = New System.Drawing.Point(419, 17)
        Me.cbNama.Name = "cbNama"
        Me.cbNama.Size = New System.Drawing.Size(170, 21)
        Me.cbNama.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bKeluar)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(-4, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(894, 58)
        Me.Panel2.TabIndex = 42
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(788, 12)
        Me.bKeluar.Name = "bKeluar"
        Me.bKeluar.Size = New System.Drawing.Size(78, 28)
        Me.bKeluar.TabIndex = 30
        Me.bKeluar.Text = "&Keluar"
        Me.bKeluar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(349, 50)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Input Data Pegawai"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(-19, 375)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(909, 52)
        Me.Panel3.TabIndex = 43
        '
        'Tbl_KasirTableAdapter
        '
        Me.Tbl_KasirTableAdapter.ClearBeforeFill = True
        '
        'bRekap
        '
        Me.bRekap.Location = New System.Drawing.Point(654, 12)
        Me.bRekap.Name = "bRekap"
        Me.bRekap.Size = New System.Drawing.Size(181, 28)
        Me.bRekap.TabIndex = 50
        Me.bRekap.Text = "Rekap Pegawai"
        Me.bRekap.UseVisualStyleBackColor = True
        '
        'Frm_Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(882, 424)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgKasir)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.cbAkses)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.telptxt)
        Me.Controls.Add(Me.alamattxt)
        Me.Controls.Add(Me.namatxt)
        Me.Controls.Add(Id_kasirLabel)
        Me.Controls.Add(Me.idkasirtxt)
        Me.Name = "Frm_Kasir"
        CType(Me.dgKasir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblKasirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idkasirtxt As System.Windows.Forms.TextBox
    Friend WithEvents namatxt As System.Windows.Forms.TextBox
    Friend WithEvents alamattxt As System.Windows.Forms.TextBox
    Friend WithEvents telptxt As System.Windows.Forms.TextBox
    Friend WithEvents usernametxt As System.Windows.Forms.TextBox
    Friend WithEvents passtxt As System.Windows.Forms.TextBox
    Friend WithEvents cbAkses As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dgKasir As System.Windows.Forms.DataGridView
    Friend WithEvents bEdit As System.Windows.Forms.Button
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bSimpan As System.Windows.Forms.Button
    Friend WithEvents bBaru As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DbSIPBukuDataSet As SistemInformasiPenjualanBuku.dbSIPBukuDataSet
    Friend WithEvents TblKasirBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_KasirTableAdapter As SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_KasirTableAdapter
    Friend WithEvents IdkasirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AksesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tahun As System.Windows.Forms.Label
    Friend WithEvents cbNama As System.Windows.Forms.ComboBox
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents bRekap As System.Windows.Forms.Button
End Class
