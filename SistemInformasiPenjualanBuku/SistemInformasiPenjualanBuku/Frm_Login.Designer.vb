<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.bLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbUser
        '
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Location = New System.Drawing.Point(46, 127)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(107, 21)
        Me.cbUser.TabIndex = 4
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(46, 170)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtxt.Size = New System.Drawing.Size(107, 20)
        Me.passtxt.TabIndex = 5
        '
        'bLogin
        '
        Me.bLogin.BackColor = System.Drawing.Color.LightSlateGray
        Me.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bLogin.Location = New System.Drawing.Point(57, 202)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(83, 26)
        Me.bLogin.TabIndex = 7
        Me.bLogin.Text = "Login"
        Me.bLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(562, 296)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bLogin)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.cbUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbUser As System.Windows.Forms.ComboBox
    Friend WithEvents passtxt As System.Windows.Forms.TextBox
    Friend WithEvents bLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
