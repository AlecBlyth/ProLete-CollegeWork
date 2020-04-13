<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registry))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCreateTitle = New System.Windows.Forms.Label()
        Me.lblUsernameTaken = New System.Windows.Forms.Label()
        Me.lblCreateInfo1 = New System.Windows.Forms.Label()
        Me.lblCreateInfo2 = New System.Windows.Forms.Label()
        Me.txtUsernameAccount = New System.Windows.Forms.TextBox()
        Me.txtPasswordAccount = New System.Windows.Forms.TextBox()
        Me.btnBackLogin = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(470, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblCreateTitle
        '
        Me.lblCreateTitle.AutoSize = True
        Me.lblCreateTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateTitle.Location = New System.Drawing.Point(130, 165)
        Me.lblCreateTitle.Name = "lblCreateTitle"
        Me.lblCreateTitle.Size = New System.Drawing.Size(239, 31)
        Me.lblCreateTitle.TabIndex = 3
        Me.lblCreateTitle.Text = "Create an Account"
        '
        'lblUsernameTaken
        '
        Me.lblUsernameTaken.AutoSize = True
        Me.lblUsernameTaken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameTaken.ForeColor = System.Drawing.Color.Red
        Me.lblUsernameTaken.Location = New System.Drawing.Point(330, 228)
        Me.lblUsernameTaken.Name = "lblUsernameTaken"
        Me.lblUsernameTaken.Size = New System.Drawing.Size(103, 13)
        Me.lblUsernameTaken.TabIndex = 4
        Me.lblUsernameTaken.Text = "Username Taken"
        Me.lblUsernameTaken.Visible = False
        '
        'lblCreateInfo1
        '
        Me.lblCreateInfo1.AutoSize = True
        Me.lblCreateInfo1.Location = New System.Drawing.Point(82, 228)
        Me.lblCreateInfo1.Name = "lblCreateInfo1"
        Me.lblCreateInfo1.Size = New System.Drawing.Size(89, 13)
        Me.lblCreateInfo1.TabIndex = 5
        Me.lblCreateInfo1.Text = "Create Username"
        '
        'lblCreateInfo2
        '
        Me.lblCreateInfo2.AutoSize = True
        Me.lblCreateInfo2.Location = New System.Drawing.Point(82, 251)
        Me.lblCreateInfo2.Name = "lblCreateInfo2"
        Me.lblCreateInfo2.Size = New System.Drawing.Size(87, 13)
        Me.lblCreateInfo2.TabIndex = 6
        Me.lblCreateInfo2.Text = "Create Password"
        '
        'txtUsernameAccount
        '
        Me.txtUsernameAccount.Location = New System.Drawing.Point(176, 225)
        Me.txtUsernameAccount.Name = "txtUsernameAccount"
        Me.txtUsernameAccount.Size = New System.Drawing.Size(148, 20)
        Me.txtUsernameAccount.TabIndex = 7
        '
        'txtPasswordAccount
        '
        Me.txtPasswordAccount.Location = New System.Drawing.Point(175, 248)
        Me.txtPasswordAccount.Name = "txtPasswordAccount"
        Me.txtPasswordAccount.Size = New System.Drawing.Size(149, 20)
        Me.txtPasswordAccount.TabIndex = 8
        '
        'btnBackLogin
        '
        Me.btnBackLogin.Location = New System.Drawing.Point(9, 356)
        Me.btnBackLogin.Name = "btnBackLogin"
        Me.btnBackLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnBackLogin.TabIndex = 9
        Me.btnBackLogin.Text = "Back"
        Me.btnBackLogin.UseVisualStyleBackColor = True
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(200, 274)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(96, 23)
        Me.btnCreateAccount.TabIndex = 10
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'Registry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(484, 391)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.btnBackLogin)
        Me.Controls.Add(Me.txtPasswordAccount)
        Me.Controls.Add(Me.txtUsernameAccount)
        Me.Controls.Add(Me.lblCreateInfo2)
        Me.Controls.Add(Me.lblCreateInfo1)
        Me.Controls.Add(Me.lblUsernameTaken)
        Me.Controls.Add(Me.lblCreateTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Registry"
        Me.Text = "ABM ProLete: Business Edition 2009 - Registry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCreateTitle As Label
    Friend WithEvents lblUsernameTaken As Label
    Friend WithEvents lblCreateInfo1 As Label
    Friend WithEvents lblCreateInfo2 As Label
    Friend WithEvents txtUsernameAccount As TextBox
    Friend WithEvents txtPasswordAccount As TextBox
    Friend WithEvents btnBackLogin As Button
    Friend WithEvents btnCreateAccount As Button
End Class
