<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Distributor
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim idDis As System.Windows.Forms.Label
        Me.telptxt = New System.Windows.Forms.TextBox()
        Me.alamattxt = New System.Windows.Forms.TextBox()
        Me.namatxt = New System.Windows.Forms.TextBox()
        Me.iddistxt = New System.Windows.Forms.TextBox()
        Me.dgDis = New System.Windows.Forms.DataGridView()
        Me.IddistributorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamadistributorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblDistributorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSIPBukuDataSet = New SistemInformasiPenjualanBuku.dbSIPBukuDataSet()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.bBaru = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tbl_DistributorTableAdapter = New SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_DistributorTableAdapter()
        Me.bRekap = New System.Windows.Forms.Button()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        idDis = New System.Windows.Forms.Label()
        CType(Me.dgDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDistributorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(20, 204)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(28, 13)
        Label3.TabIndex = 7
        Label3.Text = "Telp"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(20, 178)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(39, 13)
        Label2.TabIndex = 8
        Label2.Text = "Alamat"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(20, 152)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(85, 13)
        Label1.TabIndex = 9
        Label1.Text = "Nama Distributor"
        '
        'idDis
        '
        idDis.AutoSize = True
        idDis.Location = New System.Drawing.Point(20, 126)
        idDis.Name = "idDis"
        idDis.Size = New System.Drawing.Size(68, 13)
        idDis.TabIndex = 5
        idDis.Text = "ID Distributor"
        '
        'telptxt
        '
        Me.telptxt.Enabled = False
        Me.telptxt.Location = New System.Drawing.Point(112, 201)
        Me.telptxt.Name = "telptxt"
        Me.telptxt.Size = New System.Drawing.Size(228, 20)
        Me.telptxt.TabIndex = 3
        '
        'alamattxt
        '
        Me.alamattxt.Enabled = False
        Me.alamattxt.Location = New System.Drawing.Point(112, 175)
        Me.alamattxt.Name = "alamattxt"
        Me.alamattxt.Size = New System.Drawing.Size(228, 20)
        Me.alamattxt.TabIndex = 2
        '
        'namatxt
        '
        Me.namatxt.Enabled = False
        Me.namatxt.Location = New System.Drawing.Point(112, 149)
        Me.namatxt.Name = "namatxt"
        Me.namatxt.Size = New System.Drawing.Size(228, 20)
        Me.namatxt.TabIndex = 1
        '
        'iddistxt
        '
        Me.iddistxt.Enabled = False
        Me.iddistxt.Location = New System.Drawing.Point(112, 123)
        Me.iddistxt.Name = "iddistxt"
        Me.iddistxt.Size = New System.Drawing.Size(228, 20)
        Me.iddistxt.TabIndex = 112
        '
        'dgDis
        '
        Me.dgDis.AutoGenerateColumns = False
        Me.dgDis.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IddistributorDataGridViewTextBoxColumn, Me.NamadistributorDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TeleponDataGridViewTextBoxColumn})
        Me.dgDis.DataSource = Me.TblDistributorBindingSource
        Me.dgDis.Location = New System.Drawing.Point(367, 123)
        Me.dgDis.Name = "dgDis"
        Me.dgDis.Size = New System.Drawing.Size(419, 241)
        Me.dgDis.TabIndex = 13
        '
        'IddistributorDataGridViewTextBoxColumn
        '
        Me.IddistributorDataGridViewTextBoxColumn.DataPropertyName = "id_distributor"
        Me.IddistributorDataGridViewTextBoxColumn.HeaderText = "ID Distributor"
        Me.IddistributorDataGridViewTextBoxColumn.Name = "IddistributorDataGridViewTextBoxColumn"
        '
        'NamadistributorDataGridViewTextBoxColumn
        '
        Me.NamadistributorDataGridViewTextBoxColumn.DataPropertyName = "nama_distributor"
        Me.NamadistributorDataGridViewTextBoxColumn.HeaderText = "Nama Distributor"
        Me.NamadistributorDataGridViewTextBoxColumn.Name = "NamadistributorDataGridViewTextBoxColumn"
        Me.NamadistributorDataGridViewTextBoxColumn.Width = 160
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'TeleponDataGridViewTextBoxColumn
        '
        Me.TeleponDataGridViewTextBoxColumn.DataPropertyName = "telepon"
        Me.TeleponDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.Name = "TeleponDataGridViewTextBoxColumn"
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
        'bEdit
        '
        Me.bEdit.Location = New System.Drawing.Point(175, 10)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(75, 27)
        Me.bEdit.TabIndex = 44
        Me.bEdit.Text = "&Edit"
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(264, 10)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(75, 27)
        Me.bHapus.TabIndex = 43
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bSimpan
        '
        Me.bSimpan.Enabled = False
        Me.bSimpan.Location = New System.Drawing.Point(94, 10)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(75, 27)
        Me.bSimpan.TabIndex = 42
        Me.bSimpan.Text = "&Simpan"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'bBaru
        '
        Me.bBaru.Location = New System.Drawing.Point(13, 10)
        Me.bBaru.Name = "bBaru"
        Me.bBaru.Size = New System.Drawing.Size(75, 27)
        Me.bBaru.TabIndex = 1
        Me.bBaru.Text = "&Baru"
        Me.bBaru.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bKeluar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 58)
        Me.Panel1.TabIndex = 45
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(709, 12)
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
        Me.Label4.Size = New System.Drawing.Size(305, 50)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Input Distributor"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bRekap)
        Me.Panel2.Controls.Add(Me.bEdit)
        Me.Panel2.Controls.Add(Me.bHapus)
        Me.Panel2.Controls.Add(Me.bSimpan)
        Me.Panel2.Controls.Add(Me.bBaru)
        Me.Panel2.Location = New System.Drawing.Point(10, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 51)
        Me.Panel2.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(-1, 383)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(804, 52)
        Me.Panel3.TabIndex = 47
        '
        'Tbl_DistributorTableAdapter
        '
        Me.Tbl_DistributorTableAdapter.ClearBeforeFill = True
        '
        'bRekap
        '
        Me.bRekap.Location = New System.Drawing.Point(615, 10)
        Me.bRekap.Name = "bRekap"
        Me.bRekap.Size = New System.Drawing.Size(142, 28)
        Me.bRekap.TabIndex = 45
        Me.bRekap.Text = "Rekap Distributor"
        Me.bRekap.UseVisualStyleBackColor = True
        '
        'Frm_Distributor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(799, 427)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgDis)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.telptxt)
        Me.Controls.Add(Me.alamattxt)
        Me.Controls.Add(Me.namatxt)
        Me.Controls.Add(idDis)
        Me.Controls.Add(Me.iddistxt)
        Me.Name = "Frm_Distributor"
        Me.Text = "Distributor"
        CType(Me.dgDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDistributorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSIPBukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents telptxt As System.Windows.Forms.TextBox
    Friend WithEvents alamattxt As System.Windows.Forms.TextBox
    Friend WithEvents namatxt As System.Windows.Forms.TextBox
    Friend WithEvents iddistxt As System.Windows.Forms.TextBox
    Friend WithEvents dgDis As System.Windows.Forms.DataGridView
    Friend WithEvents bEdit As System.Windows.Forms.Button
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bSimpan As System.Windows.Forms.Button
    Friend WithEvents bBaru As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DbSIPBukuDataSet As SistemInformasiPenjualanBuku.dbSIPBukuDataSet
    Friend WithEvents TblDistributorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_DistributorTableAdapter As SistemInformasiPenjualanBuku.dbSIPBukuDataSetTableAdapters.Tbl_DistributorTableAdapter
    Friend WithEvents IddistributorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamadistributorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bRekap As System.Windows.Forms.Button
End Class
