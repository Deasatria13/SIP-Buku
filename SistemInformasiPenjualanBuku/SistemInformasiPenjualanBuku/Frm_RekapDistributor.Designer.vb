<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RekapDistributor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RekapDistributor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgDis = New System.Windows.Forms.DataGridView()
        Me.IddistributorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamadistributorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblDistributorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSIPBukuDataSet = New SistemInformasiPenjualanBuku.dbSIPBukuDataSet()
        Me.Tbl_DistributorTableAdapter = New SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_DistributorTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bLaporan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbNama = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDistributorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bKeluar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1375, 58)
        Me.Panel1.TabIndex = 47
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(1246, 16)
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
        Me.Label4.Location = New System.Drawing.Point(12, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 50)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Rekap Distributor"
        '
        'dgDis
        '
        Me.dgDis.AutoGenerateColumns = False
        Me.dgDis.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IddistributorDataGridViewTextBoxColumn, Me.NamadistributorDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TeleponDataGridViewTextBoxColumn})
        Me.dgDis.DataSource = Me.TblDistributorBindingSource
        Me.dgDis.Location = New System.Drawing.Point(9, 125)
        Me.dgDis.Name = "dgDis"
        Me.dgDis.Size = New System.Drawing.Size(1329, 568)
        Me.dgDis.TabIndex = 48
        '
        'IddistributorDataGridViewTextBoxColumn
        '
        Me.IddistributorDataGridViewTextBoxColumn.DataPropertyName = "id_distributor"
        Me.IddistributorDataGridViewTextBoxColumn.HeaderText = "ID Distributor"
        Me.IddistributorDataGridViewTextBoxColumn.Name = "IddistributorDataGridViewTextBoxColumn"
        Me.IddistributorDataGridViewTextBoxColumn.Width = 200
        '
        'NamadistributorDataGridViewTextBoxColumn
        '
        Me.NamadistributorDataGridViewTextBoxColumn.DataPropertyName = "nama_distributor"
        Me.NamadistributorDataGridViewTextBoxColumn.HeaderText = "Nama Distributor"
        Me.NamadistributorDataGridViewTextBoxColumn.Name = "NamadistributorDataGridViewTextBoxColumn"
        Me.NamadistributorDataGridViewTextBoxColumn.Width = 530
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.Width = 410
        '
        'TeleponDataGridViewTextBoxColumn
        '
        Me.TeleponDataGridViewTextBoxColumn.DataPropertyName = "telepon"
        Me.TeleponDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.Name = "TeleponDataGridViewTextBoxColumn"
        Me.TeleponDataGridViewTextBoxColumn.Width = 150
        '
        'TblDistributorBindingSource
        '
        Me.TblDistributorBindingSource.DataMember = "Tbl_Distributor"
        Me.TblDistributorBindingSource.DataSource = Me.DbSIPBukuDataSet
        '
        'DbSIPBukuDataSet
        '
        Me.DbSIPBukuDataSet.DataSetName = "dbSIPBukuDataSet"
        Me.DbSIPBukuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_DistributorTableAdapter
        '
        Me.Tbl_DistributorTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bClear)
        Me.Panel2.Controls.Add(Me.bLaporan)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cbNama)
        Me.Panel2.Location = New System.Drawing.Point(11, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1327, 41)
        Me.Panel2.TabIndex = 49
        '
        'bClear
        '
        Me.bClear.Image = CType(resources.GetObject("bClear.Image"), System.Drawing.Image)
        Me.bClear.Location = New System.Drawing.Point(274, 9)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(22, 23)
        Me.bClear.TabIndex = 6
        Me.bClear.UseVisualStyleBackColor = True
        '
        'bLaporan
        '
        Me.bLaporan.Location = New System.Drawing.Point(1161, 8)
        Me.bLaporan.Name = "bLaporan"
        Me.bLaporan.Size = New System.Drawing.Size(145, 23)
        Me.bLaporan.TabIndex = 5
        Me.bLaporan.Text = "Laporan Distributor/Cetak"
        Me.bLaporan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Distributor"
        '
        'cbNama
        '
        Me.cbNama.FormattingEnabled = True
        Me.cbNama.Location = New System.Drawing.Point(98, 11)
        Me.cbNama.Name = "cbNama"
        Me.cbNama.Size = New System.Drawing.Size(170, 21)
        Me.cbNama.TabIndex = 3
        '
        'Frm_RekapDistributor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgDis)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_RekapDistributor"
        Me.Text = "Frm_RekapDistributor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDistributorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgDis As System.Windows.Forms.DataGridView
    Friend WithEvents DbSIPBukuDataSet As SistemInformasiPenjualanBuku.dbSIPBukuDataSet
    Friend WithEvents TblDistributorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_DistributorTableAdapter As SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_DistributorTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents bLaporan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbNama As System.Windows.Forms.ComboBox
    Friend WithEvents IddistributorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamadistributorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
