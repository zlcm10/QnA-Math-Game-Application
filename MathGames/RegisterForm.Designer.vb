<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblConfirmPassoward = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.lblCreate = New System.Windows.Forms.Label()
        Me.lblChkUsername = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblChecking = New System.Windows.Forms.Label()
        Me.lblShowPassword = New System.Windows.Forms.Label()
        Me.lblShowConPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.Location = New System.Drawing.Point(276, 58)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(245, 46)
        Me.lblRegistration.TabIndex = 0
        Me.lblRegistration.Text = "Registration"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(187, 159)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(162, 32)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(193, 238)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(156, 32)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'lblConfirmPassoward
        '
        Me.lblConfirmPassoward.AutoSize = True
        Me.lblConfirmPassoward.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassoward.Location = New System.Drawing.Point(79, 317)
        Me.lblConfirmPassoward.Name = "lblConfirmPassoward"
        Me.lblConfirmPassoward.Size = New System.Drawing.Size(270, 32)
        Me.lblConfirmPassoward.TabIndex = 3
        Me.lblConfirmPassoward.Text = "Confirm Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(400, 156)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(223, 38)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(400, 238)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(223, 38)
        Me.txtPassword.TabIndex = 5
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(400, 317)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(223, 38)
        Me.txtConfirmPassword.TabIndex = 6
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(450, 201)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 17)
        Me.lblOutput.TabIndex = 12
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(279, 410)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(70, 29)
        Me.lblBack.TabIndex = 13
        Me.lblBack.Text = "Back"
        '
        'lblCreate
        '
        Me.lblCreate.AutoSize = True
        Me.lblCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreate.Location = New System.Drawing.Point(532, 410)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(91, 29)
        Me.lblCreate.TabIndex = 14
        Me.lblCreate.Text = "Create"
        '
        'lblChkUsername
        '
        Me.lblChkUsername.AutoSize = True
        Me.lblChkUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChkUsername.Location = New System.Drawing.Point(641, 165)
        Me.lblChkUsername.Name = "lblChkUsername"
        Me.lblChkUsername.Size = New System.Drawing.Size(74, 25)
        Me.lblChkUsername.TabIndex = 15
        Me.lblChkUsername.Text = "Check"
        '
        'Timer1
        '
        '
        'lblChecking
        '
        Me.lblChecking.AutoSize = True
        Me.lblChecking.Location = New System.Drawing.Point(643, 201)
        Me.lblChecking.Name = "lblChecking"
        Me.lblChecking.Size = New System.Drawing.Size(78, 17)
        Me.lblChecking.TabIndex = 16
        Me.lblChecking.Text = "Checking..."
        '
        'lblShowPassword
        '
        Me.lblShowPassword.AutoSize = True
        Me.lblShowPassword.Location = New System.Drawing.Point(397, 279)
        Me.lblShowPassword.Name = "lblShowPassword"
        Me.lblShowPassword.Size = New System.Drawing.Size(106, 17)
        Me.lblShowPassword.TabIndex = 17
        Me.lblShowPassword.Text = "Show password"
        '
        'lblShowConPassword
        '
        Me.lblShowConPassword.AutoSize = True
        Me.lblShowConPassword.Location = New System.Drawing.Point(397, 358)
        Me.lblShowConPassword.Name = "lblShowConPassword"
        Me.lblShowConPassword.Size = New System.Drawing.Size(106, 17)
        Me.lblShowConPassword.TabIndex = 18
        Me.lblShowConPassword.Text = "Show password"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(763, 478)
        Me.Controls.Add(Me.lblShowConPassword)
        Me.Controls.Add(Me.lblShowPassword)
        Me.Controls.Add(Me.lblChecking)
        Me.Controls.Add(Me.lblChkUsername)
        Me.Controls.Add(Me.lblCreate)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblConfirmPassoward)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblRegistration)
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegistration As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassoward As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblBack As Label
    Friend WithEvents lblCreate As Label
    Friend WithEvents lblChkUsername As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblChecking As Label
    Friend WithEvents lblShowPassword As Label
    Friend WithEvents lblShowConPassword As Label
End Class
