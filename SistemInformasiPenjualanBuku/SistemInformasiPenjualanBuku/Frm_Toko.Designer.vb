<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Toko
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
        Dim NamaTokoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Toko))
        Me.namatxt = New System.Windows.Forms.TextBox()
        Me.alamattxt = New System.Windows.Forms.TextBox()
        Me.pemiliktxt = New System.Windows.Forms.TextBox()
        Me.notxt = New System.Windows.Forms.TextBox()
        Me.kodepostxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        NamaTokoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NamaTokoLabel
        '
        NamaTokoLabel.BackColor = System.Drawing.Color.DimGray
        NamaTokoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        NamaTokoLabel.ForeColor = System.Drawing.Color.White
        NamaTokoLabel.Location = New System.Drawing.Point(39, 150)
        NamaTokoLabel.Name = "NamaTokoLabel"
        NamaTokoLabel.Size = New System.Drawing.Size(74, 20)
        NamaTokoLabel.TabIndex = 1
        NamaTokoLabel.Text = "Nama Toko"
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.DimGray
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(39, 176)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 20)
        Label1.TabIndex = 1
        Label1.Text = "Alamat"
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.DimGray
        Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(39, 202)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(74, 20)
        Label2.TabIndex = 1
        Label2.Text = "Pemilik"
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.DimGray
        Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(39, 228)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(74, 20)
        Label3.TabIndex = 1
        Label3.Text = "No Telp"
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.DimGray
        Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label4.ForeColor = System.Drawing.Color.White
        Label4.Location = New System.Drawing.Point(39, 254)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(74, 20)
        Label4.TabIndex = 1
        Label4.Text = "kode Pos"
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.DimGray
        Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(39, 280)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(74, 20)
        Label5.TabIndex = 1
        Label5.Text = "Email"
        '
        'namatxt
        '
        Me.namatxt.Enabled = False
        Me.namatxt.Location = New System.Drawing.Point(113, 150)
        Me.namatxt.Name = "namatxt"
        Me.namatxt.Size = New System.Drawing.Size(234, 20)
        Me.namatxt.TabIndex = 2
        '
        'alamattxt
        '
        Me.alamattxt.Enabled = False
        Me.alamattxt.Location = New System.Drawing.Point(113, 176)
        Me.alamattxt.Name = "alamattxt"
        Me.alamattxt.Size = New System.Drawing.Size(234, 20)
        Me.alamattxt.TabIndex = 2
        '
        'pemiliktxt
        '
        Me.pemiliktxt.Enabled = False
        Me.pemiliktxt.Location = New System.Drawing.Point(113, 202)
        Me.pemiliktxt.Name = "pemiliktxt"
        Me.pemiliktxt.Size = New System.Drawing.Size(234, 20)
        Me.pemiliktxt.TabIndex = 2
        '
        'notxt
        '
        Me.notxt.Enabled = False
        Me.notxt.Location = New System.Drawing.Point(112, 228)
        Me.notxt.Name = "notxt"
        Me.notxt.Size = New System.Drawing.Size(234, 20)
        Me.notxt.TabIndex = 2
        '
        'kodepostxt
        '
        Me.kodepostxt.Enabled = False
        Me.kodepostxt.Location = New System.Drawing.Point(112, 254)
        Me.kodepostxt.Name = "kodepostxt"
        Me.kodepostxt.Size = New System.Drawing.Size(234, 20)
        Me.kodepostxt.TabIndex = 2
        '
        'emailtxt
        '
        Me.emailtxt.Enabled = False
        Me.emailtxt.Location = New System.Drawing.Point(112, 280)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(234, 20)
        Me.emailtxt.TabIndex = 2
        '
        'bEdit
        '
        Me.bEdit.Location = New System.Drawing.Point(127, 102)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(77, 27)
        Me.bEdit.TabIndex = 31
        Me.bEdit.Text = "&Edit"
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'bSimpan
        '
        Me.bSimpan.Location = New System.Drawing.Point(38, 102)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(83, 27)
        Me.bSimpan.TabIndex = 30
        Me.bSimpan.Text = "&Simpan"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(402, 432)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 60)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "ProfilToko"
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Frm_Toko
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 428)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.bSimpan)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(NamaTokoLabel)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.kodepostxt)
        Me.Controls.Add(Me.notxt)
        Me.Controls.Add(Me.pemiliktxt)
        Me.Controls.Add(Me.alamattxt)
        Me.Controls.Add(Me.namatxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_Toko"
        Me.Text = "Identitas Toko"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents namatxt As System.Windows.Forms.TextBox
    Friend WithEvents alamattxt As System.Windows.Forms.TextBox
    Friend WithEvents pemiliktxt As System.Windows.Forms.TextBox
    Friend WithEvents notxt As System.Windows.Forms.TextBox
    Friend WithEvents kodepostxt As System.Windows.Forms.TextBox
    Friend WithEvents emailtxt As System.Windows.Forms.TextBox
    Friend WithEvents bEdit As System.Windows.Forms.Button
    Friend WithEvents bSimpan As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
