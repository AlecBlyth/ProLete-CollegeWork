<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtUsernameLogin = New System.Windows.Forms.TextBox()
        Me.txtPasswordLogin = New System.Windows.Forms.TextBox()
        Me.lbluserNameinfo = New System.Windows.Forms.Label()
        Me.lblPasswordInfo = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblEnterDetails = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(470, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(212, 295)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(212, 324)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtUsernameLogin
        '
        Me.txtUsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsernameLogin.Location = New System.Drawing.Point(176, 217)
        Me.txtUsernameLogin.Name = "txtUsernameLogin"
        Me.txtUsernameLogin.Size = New System.Drawing.Size(148, 20)
        Me.txtUsernameLogin.TabIndex = 4
        '
        'txtPasswordLogin
        '
        Me.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordLogin.Location = New System.Drawing.Point(176, 243)
        Me.txtPasswordLogin.Name = "txtPasswordLogin"
        Me.txtPasswordLogin.Size = New System.Drawing.Size(148, 20)
        Me.txtPasswordLogin.TabIndex = 5
        '
        'lbluserNameinfo
        '
        Me.lbluserNameinfo.AutoSize = True
        Me.lbluserNameinfo.Location = New System.Drawing.Point(117, 220)
        Me.lbluserNameinfo.Name = "lbluserNameinfo"
        Me.lbluserNameinfo.Size = New System.Drawing.Size(55, 13)
        Me.lbluserNameinfo.TabIndex = 6
        Me.lbluserNameinfo.Text = "Username"
        '
        'lblPasswordInfo
        '
        Me.lblPasswordInfo.AutoSize = True
        Me.lblPasswordInfo.Location = New System.Drawing.Point(117, 246)
        Me.lblPasswordInfo.Name = "lblPasswordInfo"
        Me.lblPasswordInfo.Size = New System.Drawing.Size(53, 13)
        Me.lblPasswordInfo.TabIndex = 7
        Me.lblPasswordInfo.Text = "Password"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(224, 171)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(52, 13)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Welcome"
        '
        'lblEnterDetails
        '
        Me.lblEnterDetails.AutoSize = True
        Me.lblEnterDetails.Location = New System.Drawing.Point(202, 201)
        Me.lblEnterDetails.Name = "lblEnterDetails"
        Me.lblEnterDetails.Size = New System.Drawing.Size(96, 13)
        Me.lblEnterDetails.TabIndex = 9
        Me.lblEnterDetails.Text = "Enter Login Details"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(484, 391)
        Me.Controls.Add(Me.lblEnterDetails)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblPasswordInfo)
        Me.Controls.Add(Me.lbluserNameinfo)
        Me.Controls.Add(Me.txtPasswordLogin)
        Me.Controls.Add(Me.txtUsernameLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.Text = "ABM ProLete: Business Edition 2009 - Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtUsernameLogin As TextBox
    Friend WithEvents txtPasswordLogin As TextBox
    Friend WithEvents lbluserNameinfo As Label
    Friend WithEvents lblPasswordInfo As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblEnterDetails As Label
End Class
