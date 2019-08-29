<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Penjualan
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
        Dim Id_penjualanLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Penjualan))
        Me.idPenjualan = New System.Windows.Forms.TextBox()
        Me.idKasir = New System.Windows.Forms.TextBox()
        Me.totaltxt = New System.Windows.Forms.TextBox()
        Me.bayartxt = New System.Windows.Forms.TextBox()
        Me.kembaliantxt = New System.Windows.Forms.TextBox()
        Me.dgJual = New System.Windows.Forms.DataGridView()
        Me.bBatal = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.bBaru = New System.Windows.Forms.Button()
        Me.tgl = New System.Windows.Forms.DateTimePicker()
        Me.dgBuku = New System.Windows.Forms.DataGridView()
        Me.IdbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSIPBukuDataSet = New SistemInformasiPenjualanBuku.dbSIPBukuDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bClear = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbCari = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.jumlahtxt = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgbukukosong = New System.Windows.Forms.DataGridView()
        Me.IdbukuDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBukuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_BukuTableAdapter = New SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_BukuTableAdapter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bLaporan = New System.Windows.Forms.Button()
        Id_penjualanLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.dgJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgbukukosong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBukuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_penjualanLabel
        '
        Id_penjualanLabel.AutoSize = True
        Id_penjualanLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_penjualanLabel.Location = New System.Drawing.Point(24, 77)
        Id_penjualanLabel.Name = "Id_penjualanLabel"
        Id_penjualanLabel.Size = New System.Drawing.Size(98, 21)
        Id_penjualanLabel.TabIndex = 1
        Id_penjualanLabel.Text = "ID Penjualan"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(24, 103)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(65, 21)
        Label1.TabIndex = 3
        Label1.Text = "ID Kasir"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(12, 15)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(78, 15)
        Label2.TabIndex = 3
        Label2.Text = "Jumlah Item :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(7, 36)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(33, 15)
        Label3.TabIndex = 3
        Label3.Text = "Total"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.White
        Label6.Location = New System.Drawing.Point(7, 63)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(36, 15)
        Label6.TabIndex = 3
        Label6.Text = "Bayar"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.White
        Label7.Location = New System.Drawing.Point(7, 89)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(63, 15)
        Label7.TabIndex = 3
        Label7.Text = "Kembalian"
        '
        'idPenjualan
        '
        Me.idPenjualan.Enabled = False
        Me.idPenjualan.Location = New System.Drawing.Point(128, 79)
        Me.idPenjualan.Name = "idPenjualan"
        Me.idPenjualan.Size = New System.Drawing.Size(136, 20)
        Me.idPenjualan.TabIndex = 2
        '
        'idKasir
        '
        Me.idKasir.Enabled = False
        Me.idKasir.Location = New System.Drawing.Point(128, 105)
        Me.idKasir.Name = "idKasir"
        Me.idKasir.Size = New System.Drawing.Size(136, 20)
        Me.idKasir.TabIndex = 4
        '
        'totaltxt
        '
        Me.totaltxt.Enabled = False
        Me.totaltxt.Location = New System.Drawing.Point(80, 34)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(105, 20)
        Me.totaltxt.TabIndex = 4
        '
        'bayartxt
        '
        Me.bayartxt.Enabled = False
        Me.bayartxt.Location = New System.Drawing.Point(80, 60)
        Me.bayartxt.Name = "bayartxt"
        Me.bayartxt.Size = New System.Drawing.Size(105, 20)
        Me.bayartxt.TabIndex = 5
        '
        'kembaliantxt
        '
        Me.kembaliantxt.Enabled = False
        Me.kembaliantxt.Location = New System.Drawing.Point(80, 86)
        Me.kembaliantxt.Name = "kembaliantxt"
        Me.kembaliantxt.Size = New System.Drawing.Size(105, 20)
        Me.kembaliantxt.TabIndex = 4
        '
        'dgJual
        '
        Me.dgJual.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgJual.Enabled = False
        Me.dgJual.Location = New System.Drawing.Point(218, 162)
        Me.dgJual.Name = "dgJual"
        Me.dgJual.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgJual.Size = New System.Drawing.Size(867, 432)
        Me.dgJual.TabIndex = 5
        '
        'bBatal
        '
        Me.bBatal.Enabled = False
        Me.bBatal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bBatal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBatal.Location = New System.Drawing.Point(170, 10)
        Me.bBatal.Name = "bBatal"
        Me.bBatal.Size = New System.Drawing.Size(75, 23)
        Me.bBatal.TabIndex = 40
        Me.bBatal.Text = "&Batal"
        Me.bBatal.UseVisualStyleBackColor = True
        '
        'bSimpan
        '
        Me.bSimpan.Enabled = False
        Me.bSimpan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bSimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSimpan.Location = New System.Drawing.Point(89, 10)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(75, 23)
        Me.bSimpan.TabIndex = 6
        Me.bSimpan.Text = "&Simpan"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'bBaru
        '
        Me.bBaru.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bBaru.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBaru.Location = New System.Drawing.Point(8, 10)
        Me.bBaru.Name = "bBaru"
        Me.bBaru.Size = New System.Drawing.Size(75, 23)
        Me.bBaru.TabIndex = 1
        Me.bBaru.Text = "&Baru"
        Me.bBaru.UseVisualStyleBackColor = True
        '
        'tgl
        '
        Me.tgl.Location = New System.Drawing.Point(1150, 65)
        Me.tgl.Name = "tgl"
        Me.tgl.Size = New System.Drawing.Size(200, 20)
        Me.tgl.TabIndex = 41
        '
        'dgBuku
        '
        Me.dgBuku.AutoGenerateColumns = False
        Me.dgBuku.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBuku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdbukuDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.stok})
        Me.dgBuku.DataSource = Me.TblBukuBindingSource
        Me.dgBuku.Enabled = False
        Me.dgBuku.Location = New System.Drawing.Point(1093, 201)
        Me.dgBuku.Name = "dgBuku"
        Me.dgBuku.Size = New System.Drawing.Size(257, 218)
        Me.dgBuku.TabIndex = 42
        '
        'IdbukuDataGridViewTextBoxColumn
        '
        Me.IdbukuDataGridViewTextBoxColumn.DataPropertyName = "id_buku"
        Me.IdbukuDataGridViewTextBoxColumn.HeaderText = "ID Buku"
        Me.IdbukuDataGridViewTextBoxColumn.Name = "IdbukuDataGridViewTextBoxColumn"
        '
        'JudulDataGridViewTextBoxColumn
        '
        Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "judul"
        Me.JudulDataGridViewTextBoxColumn.HeaderText = "Judul"
        Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
        '
        'stok
        '
        Me.stok.DataPropertyName = "stok"
        Me.stok.HeaderText = "Stok"
        Me.stok.Name = "stok"
        Me.stok.Width = 50
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bClear)
        Me.Panel1.Controls.Add(Me.bBatal)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.bSimpan)
        Me.Panel1.Controls.Add(Me.cbCari)
        Me.Panel1.Controls.Add(Me.bBaru)
        Me.Panel1.Location = New System.Drawing.Point(22, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1328, 45)
        Me.Panel1.TabIndex = 44
        '
        'bClear
        '
        Me.bClear.Image = CType(resources.GetObject("bClear.Image"), System.Drawing.Image)
        Me.bClear.Location = New System.Drawing.Point(1294, 10)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(22, 23)
        Me.bClear.TabIndex = 51
        Me.bClear.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1050, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Cari Buku"
        '
        'cbCari
        '
        Me.cbCari.FormattingEnabled = True
        Me.cbCari.Location = New System.Drawing.Point(1112, 12)
        Me.cbCari.Name = "cbCari"
        Me.cbCari.Size = New System.Drawing.Size(176, 21)
        Me.cbCari.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Controls.Add(Label6)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.kembaliantxt)
        Me.Panel2.Controls.Add(Me.bayartxt)
        Me.Panel2.Controls.Add(Me.totaltxt)
        Me.Panel2.Location = New System.Drawing.Point(22, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 201)
        Me.Panel2.TabIndex = 45
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(4, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 25)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Pembayaran"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.bKeluar)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(-1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1368, 58)
        Me.Panel3.TabIndex = 47
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(1264, 14)
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
        Me.Label8.Size = New System.Drawing.Size(282, 50)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Penjualan Buku"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.jumlahtxt)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Label2)
        Me.Panel4.Location = New System.Drawing.Point(-1, 653)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1368, 52)
        Me.Panel4.TabIndex = 48
        '
        'jumlahtxt
        '
        Me.jumlahtxt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlahtxt.ForeColor = System.Drawing.Color.White
        Me.jumlahtxt.Location = New System.Drawing.Point(88, 16)
        Me.jumlahtxt.Name = "jumlahtxt"
        Me.jumlahtxt.Size = New System.Drawing.Size(51, 23)
        Me.jumlahtxt.TabIndex = 5
        Me.jumlahtxt.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1070, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 45)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Total :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1167, -1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 45)
        Me.Label9.TabIndex = 5
        '
        'dgbukukosong
        '
        Me.dgbukukosong.AutoGenerateColumns = False
        Me.dgbukukosong.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgbukukosong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbukukosong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdbukuDataGridViewTextBoxColumn1, Me.JudulDataGridViewTextBoxColumn1, Me.StokDataGridViewTextBoxColumn})
        Me.dgbukukosong.DataSource = Me.TblBukuBindingSource1
        Me.dgbukukosong.Location = New System.Drawing.Point(1093, 444)
        Me.dgbukukosong.Name = "dgbukukosong"
        Me.dgbukukosong.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgbukukosong.Size = New System.Drawing.Size(257, 189)
        Me.dgbukukosong.TabIndex = 49
        '
        'IdbukuDataGridViewTextBoxColumn1
        '
        Me.IdbukuDataGridViewTextBoxColumn1.DataPropertyName = "id_buku"
        Me.IdbukuDataGridViewTextBoxColumn1.HeaderText = "ID Buku"
        Me.IdbukuDataGridViewTextBoxColumn1.Name = "IdbukuDataGridViewTextBoxColumn1"
        Me.IdbukuDataGridViewTextBoxColumn1.Width = 90
        '
        'JudulDataGridViewTextBoxColumn1
        '
        Me.JudulDataGridViewTextBoxColumn1.DataPropertyName = "judul"
        Me.JudulDataGridViewTextBoxColumn1.HeaderText = "Judul"
        Me.JudulDataGridViewTextBoxColumn1.Name = "JudulDataGridViewTextBoxColumn1"
        Me.JudulDataGridViewTextBoxColumn1.Width = 90
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "stok"
        Me.StokDataGridViewTextBoxColumn.HeaderText = "Stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        '
        'TblBukuBindingSource1
        '
        Me.TblBukuBindingSource1.DataMember = "Tbl_Buku"
        Me.TblBukuBindingSource1.DataSource = Me.DbSIPBukuDataSet
        '
        'Tbl_BukuTableAdapter
        '
        Me.Tbl_BukuTableAdapter.ClearBeforeFill = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1090, 428)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "*Stok Kosong"
        '
        'bLaporan
        '
        Me.bLaporan.Location = New System.Drawing.Point(1150, 95)
        Me.bLaporan.Name = "bLaporan"
        Me.bLaporan.Size = New System.Drawing.Size(200, 38)
        Me.bLaporan.TabIndex = 51
        Me.bLaporan.Text = "Rekap data Transaksi"
        Me.bLaporan.UseVisualStyleBackColor = True
        '
        'Frm_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1268, 702)
        Me.Controls.Add(Me.bLaporan)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgbukukosong)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgBuku)
        Me.Controls.Add(Me.tgl)
        Me.Controls.Add(Me.dgJual)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.idKasir)
        Me.Controls.Add(Id_penjualanLabel)
        Me.Controls.Add(Me.idPenjualan)
        Me.Name = "Frm_Penjualan"
        Me.Text = "Transaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgbukukosong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBukuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idPenjualan As System.Windows.Forms.TextBox
    Friend WithEvents idKasir As System.Windows.Forms.TextBox
    Friend WithEvents totaltxt As System.Windows.Forms.TextBox
    Friend WithEvents bayartxt As System.Windows.Forms.TextBox
    Friend WithEvents kembaliantxt As System.Windows.Forms.TextBox
    Friend WithEvents dgJual As System.Windows.Forms.DataGridView
    Friend WithEvents bBatal As System.Windows.Forms.Button
    Friend WithEvents bSimpan As System.Windows.Forms.Button
    Friend WithEvents bBaru As System.Windows.Forms.Button
    Friend WithEvents tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgBuku As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DbSIPBukuDataSet As SistemInformasiPenjualanBuku.dbSIPBukuDataSet
    Friend WithEvents TblBukuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BukuTableAdapter As SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_BukuTableAdapter
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents jumlahtxt As System.Windows.Forms.Label
    Friend WithEvents cbCari As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents dgbukukosong As System.Windows.Forms.DataGridView
    Friend WithEvents TblBukuBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IdbukuDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents bLaporan As System.Windows.Forms.Button
    Friend WithEvents IdbukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stok As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
