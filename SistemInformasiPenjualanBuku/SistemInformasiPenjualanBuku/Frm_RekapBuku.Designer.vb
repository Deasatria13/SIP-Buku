<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RekapBuku
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RekapBuku))
        Me.dgBuku = New System.Windows.Forms.DataGridView()
        Me.IdbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoisbnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenulisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenerbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargadiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargajualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PpnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSIPBukuDataSet = New SistemInformasiPenjualanBuku.dbSIPBukuDataSet()
        Me.cbTahun = New System.Windows.Forms.ComboBox()
        Me.Tahun = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbJudul = New System.Windows.Forms.ComboBox()
        Me.Tbl_BukuTableAdapter = New SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_BukuTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bLaporan = New System.Windows.Forms.Button()
        CType(Me.dgBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgBuku
        '
        Me.dgBuku.AutoGenerateColumns = False
        Me.dgBuku.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBuku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdbukuDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.NoisbnDataGridViewTextBoxColumn, Me.PenulisDataGridViewTextBoxColumn, Me.PenerbitDataGridViewTextBoxColumn, Me.TahunDataGridViewTextBoxColumn, Me.StokDataGridViewTextBoxColumn, Me.HargadiskonDataGridViewTextBoxColumn, Me.harga_diskon, Me.HargajualDataGridViewTextBoxColumn, Me.PpnDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn})
        Me.dgBuku.DataSource = Me.TblBukuBindingSource
        Me.dgBuku.Location = New System.Drawing.Point(12, 109)
        Me.dgBuku.Name = "dgBuku"
        Me.dgBuku.Size = New System.Drawing.Size(1326, 586)
        Me.dgBuku.TabIndex = 0
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
        Me.JudulDataGridViewTextBoxColumn.Width = 203
        '
        'NoisbnDataGridViewTextBoxColumn
        '
        Me.NoisbnDataGridViewTextBoxColumn.DataPropertyName = "noisbn"
        Me.NoisbnDataGridViewTextBoxColumn.HeaderText = "No ISBN"
        Me.NoisbnDataGridViewTextBoxColumn.Name = "NoisbnDataGridViewTextBoxColumn"
        Me.NoisbnDataGridViewTextBoxColumn.Width = 110
        '
        'PenulisDataGridViewTextBoxColumn
        '
        Me.PenulisDataGridViewTextBoxColumn.DataPropertyName = "penulis"
        Me.PenulisDataGridViewTextBoxColumn.HeaderText = "Penulis"
        Me.PenulisDataGridViewTextBoxColumn.Name = "PenulisDataGridViewTextBoxColumn"
        Me.PenulisDataGridViewTextBoxColumn.Width = 180
        '
        'PenerbitDataGridViewTextBoxColumn
        '
        Me.PenerbitDataGridViewTextBoxColumn.DataPropertyName = "penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.HeaderText = "Penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.Name = "PenerbitDataGridViewTextBoxColumn"
        Me.PenerbitDataGridViewTextBoxColumn.Width = 180
        '
        'TahunDataGridViewTextBoxColumn
        '
        Me.TahunDataGridViewTextBoxColumn.DataPropertyName = "tahun"
        Me.TahunDataGridViewTextBoxColumn.HeaderText = "Tahun"
        Me.TahunDataGridViewTextBoxColumn.Name = "TahunDataGridViewTextBoxColumn"
        Me.TahunDataGridViewTextBoxColumn.Width = 50
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "stok"
        Me.StokDataGridViewTextBoxColumn.HeaderText = "Stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        Me.StokDataGridViewTextBoxColumn.Width = 50
        '
        'HargadiskonDataGridViewTextBoxColumn
        '
        Me.HargadiskonDataGridViewTextBoxColumn.DataPropertyName = "harga_diskon"
        Me.HargadiskonDataGridViewTextBoxColumn.HeaderText = "Harga Buku"
        Me.HargadiskonDataGridViewTextBoxColumn.Name = "HargadiskonDataGridViewTextBoxColumn"
        '
        'harga_diskon
        '
        Me.harga_diskon.DataPropertyName = "harga_diskon"
        Me.harga_diskon.HeaderText = "Harga Diskon"
        Me.harga_diskon.Name = "harga_diskon"
        '
        'HargajualDataGridViewTextBoxColumn
        '
        Me.HargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual"
        Me.HargajualDataGridViewTextBoxColumn.HeaderText = "Harga Jual"
        Me.HargajualDataGridViewTextBoxColumn.Name = "HargajualDataGridViewTextBoxColumn"
        '
        'PpnDataGridViewTextBoxColumn
        '
        Me.PpnDataGridViewTextBoxColumn.DataPropertyName = "ppn"
        Me.PpnDataGridViewTextBoxColumn.HeaderText = "PPN"
        Me.PpnDataGridViewTextBoxColumn.Name = "PpnDataGridViewTextBoxColumn"
        Me.PpnDataGridViewTextBoxColumn.Width = 60
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "Diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        Me.DiskonDataGridViewTextBoxColumn.Width = 50
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
        'cbTahun
        '
        Me.cbTahun.FormattingEnabled = True
        Me.cbTahun.Location = New System.Drawing.Point(53, 11)
        Me.cbTahun.Name = "cbTahun"
        Me.cbTahun.Size = New System.Drawing.Size(170, 21)
        Me.cbTahun.TabIndex = 1
        '
        'Tahun
        '
        Me.Tahun.AutoSize = True
        Me.Tahun.Location = New System.Drawing.Point(9, 14)
        Me.Tahun.Name = "Tahun"
        Me.Tahun.Size = New System.Drawing.Size(38, 13)
        Me.Tahun.TabIndex = 2
        Me.Tahun.Text = "Tahun"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Judul"
        '
        'cbJudul
        '
        Me.cbJudul.FormattingEnabled = True
        Me.cbJudul.Location = New System.Drawing.Point(276, 11)
        Me.cbJudul.Name = "cbJudul"
        Me.cbJudul.Size = New System.Drawing.Size(170, 21)
        Me.cbJudul.TabIndex = 3
        '
        'Tbl_BukuTableAdapter
        '
        Me.Tbl_BukuTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bKeluar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1376, 58)
        Me.Panel1.TabIndex = 46
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(1254, 14)
        Me.bKeluar.Name = "bKeluar"
        Me.bKeluar.Size = New System.Drawing.Size(78, 28)
        Me.bKeluar.TabIndex = 30
        Me.bKeluar.Text = "&Keluar"
        Me.bKeluar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 50)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Rekap Buku"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bClear)
        Me.Panel2.Controls.Add(Me.bLaporan)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cbJudul)
        Me.Panel2.Controls.Add(Me.Tahun)
        Me.Panel2.Controls.Add(Me.cbTahun)
        Me.Panel2.Location = New System.Drawing.Point(14, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1324, 41)
        Me.Panel2.TabIndex = 47
        '
        'bClear
        '
        Me.bClear.Image = CType(resources.GetObject("bClear.Image"), System.Drawing.Image)
        Me.bClear.Location = New System.Drawing.Point(452, 9)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(22, 23)
        Me.bClear.TabIndex = 6
        Me.bClear.UseVisualStyleBackColor = True
        '
        'bLaporan
        '
        Me.bLaporan.Location = New System.Drawing.Point(1164, 9)
        Me.bLaporan.Name = "bLaporan"
        Me.bLaporan.Size = New System.Drawing.Size(145, 23)
        Me.bLaporan.TabIndex = 5
        Me.bLaporan.Text = "Laporan Buku/Cetak"
        Me.bLaporan.UseVisualStyleBackColor = True
        '
        'Frm_RekapBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgBuku)
        Me.Name = "Frm_RekapBuku"
        Me.Text = "Rekap Buku"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgBuku As System.Windows.Forms.DataGridView
    Friend WithEvents cbTahun As System.Windows.Forms.ComboBox
    Friend WithEvents Tahun As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbJudul As System.Windows.Forms.ComboBox
    Friend WithEvents DbSIPBukuDataSet As SistemInformasiPenjualanBuku.dbSIPBukuDataSet
    Friend WithEvents TblBukuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_BukuTableAdapter As SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_BukuTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bLaporan As System.Windows.Forms.Button
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents IdbukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoisbnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PenulisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PenerbitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargadiskonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_diskon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargajualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PpnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
