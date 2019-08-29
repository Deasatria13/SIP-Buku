<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MasterData
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
        Me.Level = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgAkses = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgStatus = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgTahun = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Level.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgAkses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgTahun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Level
        '
        Me.Level.Controls.Add(Me.TabPage1)
        Me.Level.Controls.Add(Me.TabPage2)
        Me.Level.Controls.Add(Me.TabPage3)
        Me.Level.Location = New System.Drawing.Point(2, 118)
        Me.Level.Name = "Level"
        Me.Level.SelectedIndex = 0
        Me.Level.Size = New System.Drawing.Size(454, 259)
        Me.Level.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgAkses)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(446, 233)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Level"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgAkses
        '
        Me.dgAkses.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgAkses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAkses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAkses.Location = New System.Drawing.Point(3, 3)
        Me.dgAkses.Name = "dgAkses"
        Me.dgAkses.Size = New System.Drawing.Size(440, 227)
        Me.dgAkses.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgStatus)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(446, 233)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Status"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgStatus
        '
        Me.dgStatus.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgStatus.Location = New System.Drawing.Point(3, 3)
        Me.dgStatus.Name = "dgStatus"
        Me.dgStatus.Size = New System.Drawing.Size(440, 227)
        Me.dgStatus.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgTahun)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(446, 233)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tahun"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgTahun
        '
        Me.dgTahun.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgTahun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTahun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTahun.Location = New System.Drawing.Point(3, 3)
        Me.dgTahun.Name = "dgTahun"
        Me.dgTahun.Size = New System.Drawing.Size(440, 227)
        Me.dgTahun.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bKeluar)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(-5, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(470, 58)
        Me.Panel2.TabIndex = 43
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(369, 12)
        Me.bKeluar.Name = "bKeluar"
        Me.bKeluar.Size = New System.Drawing.Size(81, 34)
        Me.bKeluar.TabIndex = 30
        Me.bKeluar.Text = "&Keluar"
        Me.bKeluar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(226, 50)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Master Data"
        '
        'Frm_MasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 389)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Level)
        Me.Name = "Frm_MasterData"
        Me.Text = "Master Data"
        Me.Level.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgAkses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgTahun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Level As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgAkses As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgStatus As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgTahun As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
