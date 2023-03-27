<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblForgotPW = New System.Windows.Forms.Label()
        Me.lblShowPassword = New System.Windows.Forms.Label()
        Me.lblCreateAccount = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.rdbStudent = New System.Windows.Forms.RadioButton()
        Me.rdbTeacher = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(196, 60)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(278, 51)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Math Games"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(104, 188)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(170, 32)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username: "
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(104, 252)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(164, 32)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password: "
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(302, 188)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(240, 38)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(302, 252)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(240, 38)
        Me.txtPassword.TabIndex = 4
        '
        'lblForgotPW
        '
        Me.lblForgotPW.AutoSize = True
        Me.lblForgotPW.Location = New System.Drawing.Point(421, 293)
        Me.lblForgotPW.Name = "lblForgotPW"
        Me.lblForgotPW.Size = New System.Drawing.Size(121, 17)
        Me.lblForgotPW.TabIndex = 5
        Me.lblForgotPW.Text = "Forgot password?"
        '
        'lblShowPassword
        '
        Me.lblShowPassword.AutoSize = True
        Me.lblShowPassword.Location = New System.Drawing.Point(299, 293)
        Me.lblShowPassword.Name = "lblShowPassword"
        Me.lblShowPassword.Size = New System.Drawing.Size(106, 17)
        Me.lblShowPassword.TabIndex = 8
        Me.lblShowPassword.Text = "Show password"
        '
        'lblCreateAccount
        '
        Me.lblCreateAccount.AutoSize = True
        Me.lblCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAccount.Location = New System.Drawing.Point(150, 413)
        Me.lblCreateAccount.Name = "lblCreateAccount"
        Me.lblCreateAccount.Size = New System.Drawing.Size(190, 29)
        Me.lblCreateAccount.TabIndex = 9
        Me.lblCreateAccount.Text = "Create Account"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(464, 413)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(78, 29)
        Me.lblLogin.TabIndex = 10
        Me.lblLogin.Text = "Login"
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.Location = New System.Drawing.Point(130, 329)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(128, 32)
        Me.lblUserType.TabIndex = 11
        Me.lblUserType.Text = "Are you:"
        '
        'rdbStudent
        '
        Me.rdbStudent.AutoSize = True
        Me.rdbStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbStudent.Location = New System.Drawing.Point(302, 329)
        Me.rdbStudent.Name = "rdbStudent"
        Me.rdbStudent.Size = New System.Drawing.Size(108, 29)
        Me.rdbStudent.TabIndex = 12
        Me.rdbStudent.TabStop = True
        Me.rdbStudent.Text = "Student"
        Me.rdbStudent.UseVisualStyleBackColor = True
        '
        'rdbTeacher
        '
        Me.rdbTeacher.AutoSize = True
        Me.rdbTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTeacher.Location = New System.Drawing.Point(429, 328)
        Me.rdbTeacher.Name = "rdbTeacher"
        Me.rdbTeacher.Size = New System.Drawing.Size(113, 29)
        Me.rdbTeacher.TabIndex = 13
        Me.rdbTeacher.TabStop = True
        Me.rdbTeacher.Text = "Teacher"
        Me.rdbTeacher.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(676, 485)
        Me.Controls.Add(Me.rdbTeacher)
        Me.Controls.Add(Me.rdbStudent)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblCreateAccount)
        Me.Controls.Add(Me.lblShowPassword)
        Me.Controls.Add(Me.lblForgotPW)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Games"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblForgotPW As Label
    Friend WithEvents lblShowPassword As Label
    Friend WithEvents lblCreateAccount As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblUserType As Label
    Friend WithEvents rdbStudent As RadioButton
    Friend WithEvents rdbTeacher As RadioButton
End Class
