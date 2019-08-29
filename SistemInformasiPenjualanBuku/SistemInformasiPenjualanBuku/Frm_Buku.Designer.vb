<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Buku
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
        Dim Id_bukuLabel As System.Windows.Forms.Label
        Dim Judul As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.idbukutxt = New System.Windows.Forms.TextBox()
        Me.judultxt = New System.Windows.Forms.TextBox()
        Me.noisbntxt = New System.Windows.Forms.TextBox()
        Me.penulistxt = New System.Windows.Forms.TextBox()
        Me.penerbittxt = New System.Windows.Forms.TextBox()
        Me.stoktxt = New System.Windows.Forms.TextBox()
        Me.hargaPtxt = New System.Windows.Forms.TextBox()
        Me.hargaDtxt = New System.Windows.Forms.TextBox()
        Me.hargaJtxt = New System.Windows.Forms.TextBox()
        Me.ppntxt = New System.Windows.Forms.TextBox()
        Me.diskontxt = New System.Windows.Forms.TextBox()
        Me.cbTahun = New System.Windows.Forms.ComboBox()
        Me.bBaru = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.dgBuku = New System.Windows.Forms.DataGridView()
        Me.IdbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoisbnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenulisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenerbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargapokokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargadiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargajualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PpnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSIPBukuDataSet = New SistemInformasiPenjualanBuku.dbSIPBukuDataSet()
        Me.Tbl_BukuTableAdapter = New SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_BukuTableAdapter()
        Me.diskonLb = New System.Windows.Forms.TextBox()
        Me.jual = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bRekap = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Id_bukuLabel = New System.Windows.Forms.Label()
        Judul = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.dgBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_bukuLabel
        '
        Id_bukuLabel.AutoSize = True
        Id_bukuLabel.Location = New System.Drawing.Point(12, 130)
        Id_bukuLabel.Name = "Id_bukuLabel"
        Id_bukuLabel.Size = New System.Drawing.Size(46, 13)
        Id_bukuLabel.TabIndex = 1
        Id_bukuLabel.Text = "ID Buku"
        '
        'Judul
        '
        Judul.AutoSize = True
        Judul.Location = New System.Drawing.Point(12, 156)
        Judul.Name = "Judul"
        Judul.Size = New System.Drawing.Size(32, 13)
        Judul.TabIndex = 3
        Judul.Text = "Judul"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 182)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(49, 13)
        Label2.TabIndex = 5
        Label2.Text = "No ISBN"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 208)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(41, 13)
        Label3.TabIndex = 7
        Label3.Text = "Penulis"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(12, 236)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(46, 13)
        Label4.TabIndex = 9
        Label4.Text = "Penerbit"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(12, 261)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 11
        Label5.Text = "Tahun"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(12, 286)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(29, 13)
        Label6.TabIndex = 13
        Label6.Text = "Stok"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(12, 311)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(70, 13)
        Label7.TabIndex = 15
        Label7.Text = "Harga Pokok"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(256, 311)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(90, 13)
        Label8.TabIndex = 17
        Label8.Text = "Setelah di Diskon"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(12, 338)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(58, 13)
        Label9.TabIndex = 19
        Label9.Text = "Harga Jual"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(11, 390)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(29, 13)
        Label10.TabIndex = 21
        Label10.Text = "PPN"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(11, 364)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(40, 13)
        Label11.TabIndex = 23
        Label11.Text = "Diskon"
        '
        'idbukutxt
        '
        Me.idbukutxt.Enabled = False
        Me.idbukutxt.Location = New System.Drawing.Point(84, 127)
        Me.idbukutxt.Name = "idbukutxt"
        Me.idbukutxt.Size = New System.Drawing.Size(615, 20)
        Me.idbukutxt.TabIndex = 2
        '
        'judultxt
        '
        Me.judultxt.Enabled = False
        Me.judultxt.Location = New System.Drawing.Point(84, 153)
        Me.judultxt.Name = "judultxt"
        Me.judultxt.Size = New System.Drawing.Size(615, 20)
        Me.judultxt.TabIndex = 2
        '
        'noisbntxt
        '
        Me.noisbntxt.Enabled = False
        Me.noisbntxt.Location = New System.Drawing.Point(84, 179)
        Me.noisbntxt.Name = "noisbntxt"
        Me.noisbntxt.Size = New System.Drawing.Size(615, 20)
        Me.noisbntxt.TabIndex = 3
        '
        'penulistxt
        '
        Me.penulistxt.Enabled = False
        Me.penulistxt.Location = New System.Drawing.Point(84, 205)
        Me.penulistxt.Name = "penulistxt"
        Me.penulistxt.Size = New System.Drawing.Size(615, 20)
        Me.penulistxt.TabIndex = 4
        '
        'penerbittxt
        '
        Me.penerbittxt.Enabled = False
        Me.penerbittxt.Location = New System.Drawing.Point(84, 233)
        Me.penerbittxt.Name = "penerbittxt"
        Me.penerbittxt.Size = New System.Drawing.Size(615, 20)
        Me.penerbittxt.TabIndex = 5
        '
        'stoktxt
        '
        Me.stoktxt.Enabled = False
        Me.stoktxt.Location = New System.Drawing.Point(84, 283)
        Me.stoktxt.Name = "stoktxt"
        Me.stoktxt.Size = New System.Drawing.Size(615, 20)
        Me.stoktxt.TabIndex = 7
        '
        'hargaPtxt
        '
        Me.hargaPtxt.Enabled = False
        Me.hargaPtxt.Location = New System.Drawing.Point(84, 308)
        Me.hargaPtxt.Name = "hargaPtxt"
        Me.hargaPtxt.Size = New System.Drawing.Size(167, 20)
        Me.hargaPtxt.TabIndex = 8
        '
        'hargaDtxt
        '
        Me.hargaDtxt.Enabled = False
        Me.hargaDtxt.Location = New System.Drawing.Point(352, 308)
        Me.hargaDtxt.Name = "hargaDtxt"
        Me.hargaDtxt.Size = New System.Drawing.Size(347, 20)
        Me.hargaDtxt.TabIndex = 18
        '
        'hargaJtxt
        '
        Me.hargaJtxt.Enabled = False
        Me.hargaJtxt.Location = New System.Drawing.Point(84, 335)
        Me.hargaJtxt.Name = "hargaJtxt"
        Me.hargaJtxt.Size = New System.Drawing.Size(616, 20)
        Me.hargaJtxt.TabIndex = 20
        '
        'ppntxt
        '
        Me.ppntxt.Enabled = False
        Me.ppntxt.Location = New System.Drawing.Point(83, 387)
        Me.ppntxt.Name = "ppntxt"
        Me.ppntxt.Size = New System.Drawing.Size(616, 20)
        Me.ppntxt.TabIndex = 10
        '
        'diskontxt
        '
        Me.diskontxt.Enabled = False
        Me.diskontxt.Location = New System.Drawing.Point(83, 361)
        Me.diskontxt.Name = "diskontxt"
        Me.diskontxt.Size = New System.Drawing.Size(616, 20)
        Me.diskontxt.TabIndex = 9
        '
        'cbTahun
        '
        Me.cbTahun.Enabled = False
        Me.cbTahun.FormattingEnabled = True
        Me.cbTahun.Location = New System.Drawing.Point(84, 258)
        Me.cbTahun.Name = "cbTahun"
        Me.cbTahun.Size = New System.Drawing.Size(615, 21)
        Me.cbTahun.TabIndex = 6
        '
        'bBaru
        '
        Me.bBaru.Location = New System.Drawing.Point(10, 7)
        Me.bBaru.Name = "bBaru"
        Me.bBaru.Size = New System.Drawing.Size(78, 28)
        Me.bBaru.TabIndex = 1
        Me.bBaru.Text = "&Baru"
        Me.bBaru.UseVisualStyleBackColor = True
        '
        'bSimpan
        '
        Me.bSimpan.Enabled = False
        Me.bSimpan.Location = New System.Drawing.Point(91, 7)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(78, 28)
        Me.bSimpan.TabIndex = 11
        Me.bSimpan.Text = "&Simpan"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(254, 7)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(78, 28)
        Me.bHapus.TabIndex = 28
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bEdit
        '
        Me.bEdit.Location = New System.Drawing.Point(172, 7)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(78, 28)
        Me.bEdit.TabIndex = 29
        Me.bEdit.Text = "&Edit"
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'dgBuku
        '
        Me.dgBuku.AutoGenerateColumns = False
        Me.dgBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBuku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdbukuDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.NoisbnDataGridViewTextBoxColumn, Me.PenulisDataGridViewTextBoxColumn, Me.PenerbitDataGridViewTextBoxColumn, Me.TahunDataGridViewTextBoxColumn, Me.StokDataGridViewTextBoxColumn, Me.HargapokokDataGridViewTextBoxColumn, Me.HargadiskonDataGridViewTextBoxColumn, Me.HargajualDataGridViewTextBoxColumn, Me.PpnDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn})
        Me.dgBuku.DataSource = Me.TblBukuBindingSource
        Me.dgBuku.Location = New System.Drawing.Point(733, 127)
        Me.dgBuku.Name = "dgBuku"
        Me.dgBuku.Size = New System.Drawing.Size(10, 323)
        Me.dgBuku.TabIndex = 30
        Me.dgBuku.Visible = False
        '
        'IdbukuDataGridViewTextBoxColumn
        '
        Me.IdbukuDataGridViewTextBoxColumn.DataPropertyName = "id_buku"
        Me.IdbukuDataGridViewTextBoxColumn.HeaderText = "id_buku"
        Me.IdbukuDataGridViewTextBoxColumn.Name = "IdbukuDataGridViewTextBoxColumn"
        '
        'JudulDataGridViewTextBoxColumn
        '
        Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "judul"
        Me.JudulDataGridViewTextBoxColumn.HeaderText = "judul"
        Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
        '
        'NoisbnDataGridViewTextBoxColumn
        '
        Me.NoisbnDataGridViewTextBoxColumn.DataPropertyName = "noisbn"
        Me.NoisbnDataGridViewTextBoxColumn.HeaderText = "noisbn"
        Me.NoisbnDataGridViewTextBoxColumn.Name = "NoisbnDataGridViewTextBoxColumn"
        '
        'PenulisDataGridViewTextBoxColumn
        '
        Me.PenulisDataGridViewTextBoxColumn.DataPropertyName = "penulis"
        Me.PenulisDataGridViewTextBoxColumn.HeaderText = "penulis"
        Me.PenulisDataGridViewTextBoxColumn.Name = "PenulisDataGridViewTextBoxColumn"
        '
        'PenerbitDataGridViewTextBoxColumn
        '
        Me.PenerbitDataGridViewTextBoxColumn.DataPropertyName = "penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.HeaderText = "penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.Name = "PenerbitDataGridViewTextBoxColumn"
        '
        'TahunDataGridViewTextBoxColumn
        '
        Me.TahunDataGridViewTextBoxColumn.DataPropertyName = "tahun"
        Me.TahunDataGridViewTextBoxColumn.HeaderText = "tahun"
        Me.TahunDataGridViewTextBoxColumn.Name = "TahunDataGridViewTextBoxColumn"
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "stok"
        Me.StokDataGridViewTextBoxColumn.HeaderText = "stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        '
        'HargapokokDataGridViewTextBoxColumn
        '
        Me.HargapokokDataGridViewTextBoxColumn.DataPropertyName = "harga_pokok"
        Me.HargapokokDataGridViewTextBoxColumn.HeaderText = "harga_pokok"
        Me.HargapokokDataGridViewTextBoxColumn.Name = "HargapokokDataGridViewTextBoxColumn"
        '
        'HargadiskonDataGridViewTextBoxColumn
        '
        Me.HargadiskonDataGridViewTextBoxColumn.DataPropertyName = "harga_diskon"
        Me.HargadiskonDataGridViewTextBoxColumn.HeaderText = "harga_diskon"
        Me.HargadiskonDataGridViewTextBoxColumn.Name = "HargadiskonDataGridViewTextBoxColumn"
        '
        'HargajualDataGridViewTextBoxColumn
        '
        Me.HargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual"
        Me.HargajualDataGridViewTextBoxColumn.HeaderText = "harga_jual"
        Me.HargajualDataGridViewTextBoxColumn.Name = "HargajualDataGridViewTextBoxColumn"
        '
        'PpnDataGridViewTextBoxColumn
        '
        Me.PpnDataGridViewTextBoxColumn.DataPropertyName = "ppn"
        Me.PpnDataGridViewTextBoxColumn.HeaderText = "ppn"
        Me.PpnDataGridViewTextBoxColumn.Name = "PpnDataGridViewTextBoxColumn"
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        '
        'TblBukuBindingSource
        '
        Me.TblBukuBindingSource.DataMember = "Tbl_Buku"
        Me.TblBukuBindingSource.DataSource = Me.DbSIPBukuDataSet
        '
        'DbSIPBukuDataSet
        '
        Me.DbSIPBukuDataSet.DataSetName = "dbSIPBukuDataSet"
        Me.DbSIPBukuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_BukuTableAdapter
        '
        Me.Tbl_BukuTableAdapter.ClearBeforeFill = True
        '
        'diskonLb
        '
        Me.diskonLb.Enabled = False
        Me.diskonLb.Location = New System.Drawing.Point(18, 412)
        Me.diskonLb.Name = "diskonLb"
        Me.diskonLb.Size = New System.Drawing.Size(10, 20)
        Me.diskonLb.TabIndex = 31
        Me.diskonLb.Visible = False
        '
        'jual
        '
        Me.jual.Enabled = False
        Me.jual.Location = New System.Drawing.Point(34, 412)
        Me.jual.Name = "jual"
        Me.jual.Size = New System.Drawing.Size(10, 20)
        Me.jual.TabIndex = 32
        Me.jual.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bKeluar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 58)
        Me.Panel1.TabIndex = 33
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(665, 11)
        Me.bKeluar.Name = "bKeluar"
        Me.bKeluar.Size = New System.Drawing.Size(78, 28)
        Me.bKeluar.TabIndex = 30
        Me.bKeluar.Text = "&Keluar"
        Me.bKeluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Data Buku"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bRekap)
        Me.Panel2.Controls.Add(Me.bEdit)
        Me.Panel2.Controls.Add(Me.bHapus)
        Me.Panel2.Controls.Add(Me.bSimpan)
        Me.Panel2.Controls.Add(Me.bBaru)
        Me.Panel2.Location = New System.Drawing.Point(9, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(734, 43)
        Me.Panel2.TabIndex = 34
        '
        'bRekap
        '
        Me.bRekap.Location = New System.Drawing.Point(569, 7)
        Me.bRekap.Name = "bRekap"
        Me.bRekap.Size = New System.Drawing.Size(142, 28)
        Me.bRekap.TabIndex = 30
        Me.bRekap.Text = "Rekap Buku"
        Me.bRekap.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(-1, 429)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(771, 52)
        Me.Panel3.TabIndex = 34
        '
        'Frm_Buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(769, 478)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.jual)
        Me.Controls.Add(Me.diskonLb)
        Me.Controls.Add(Me.dgBuku)
        Me.Controls.Add(Me.cbTahun)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.diskontxt)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.ppntxt)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.hargaJtxt)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.hargaDtxt)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.hargaPtxt)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.stoktxt)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.penerbittxt)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.penulistxt)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.noisbntxt)
        Me.Controls.Add(Judul)
        Me.Controls.Add(Me.judultxt)
        Me.Controls.Add(Id_bukuLabel)
        Me.Controls.Add(Me.idbukutxt)
        Me.Name = "Frm_Buku"
        Me.Text = "Buku"
        CType(Me.dgBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idbukutxt As System.Windows.Forms.TextBox
    Friend WithEvents judultxt As System.Windows.Forms.TextBox
    Friend WithEvents noisbntxt As System.Windows.Forms.TextBox
    Friend WithEvents penulistxt As System.Windows.Forms.TextBox
    Friend WithEvents penerbittxt As System.Windows.Forms.TextBox
    Friend WithEvents stoktxt As System.Windows.Forms.TextBox
    Friend WithEvents hargaPtxt As System.Windows.Forms.TextBox
    Friend WithEvents hargaDtxt As System.Windows.Forms.TextBox
    Friend WithEvents hargaJtxt As System.Windows.Forms.TextBox
    Friend WithEvents ppntxt As System.Windows.Forms.TextBox
    Friend WithEvents diskontxt As System.Windows.Forms.TextBox
    Friend WithEvents cbTahun As System.Windows.Forms.ComboBox
    Friend WithEvents bBaru As System.Windows.Forms.Button
    Friend WithEvents bSimpan As System.Windows.Forms.Button
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bEdit As System.Windows.Forms.Button
    Friend WithEvents dgBuku As System.Windows.Forms.DataGridView
    Friend WithEvents DbSIPBukuDataSet As SistemInformasiPenjualanBuku.dbSIPBukuDataSet
    Friend WithEvents TblBukuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BukuTableAdapter As SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_BukuTableAdapter
    Friend WithEvents IdbukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoisbnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PenulisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PenerbitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargapokokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargadiskonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargajualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PpnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diskonLb As System.Windows.Forms.TextBox
    Friend WithEvents jual As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents bRekap As System.Windows.Forms.Button

End Class
