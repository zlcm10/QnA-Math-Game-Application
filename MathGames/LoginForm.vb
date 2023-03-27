Imports System.Data.OleDb
Public Class LoginForm
    Public LoginUsername As String

    Private Sub lblForgotPW_Click(sender As Object, e As EventArgs) Handles lblForgotPW.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to change your password? If student account click yes, if teacher account click no.", "Change Password", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            changePass = "student"
            Me.Hide()
            ChangePassword.Show()
        ElseIf dialog = Windows.Forms.DialogResult.No Then
            changePass = "teacher"
            Me.Hide()
            ChangePassword.Show()
        End If
    End Sub

    Private Sub lblShowPassword_Click(sender As Object, e As EventArgs) Handles lblShowPassword.Click
        If txtPassword.UseSystemPasswordChar = True Then

            txtPassword.UseSystemPasswordChar = False

            lblShowPassword.Text = "Hide Password"
        Else

            txtPassword.UseSystemPasswordChar = True

            lblShowPassword.Text = "Show Password"
        End If
    End Sub

    Private Sub StudentLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'for show and hide the pw
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCreateAccount.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you want to create student account? If yes click Yes, if want to create teacher account, click No.", "Create Account?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)

        If dialog = Windows.Forms.DialogResult.Yes Then
            userType = "student"
            Me.Hide()
            RegisterForm.Show()
            txtUsername.Text = ""
            txtPassword.Text = ""
        ElseIf dialog = Windows.Forms.DialogResult.No Then
            userType = "teacher"
            Me.Hide()
            RegisterForm.Show()
            txtUsername.Text = ""
            txtPassword.Text = ""

        End If

    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Dim uname As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim sql As String
        Dim str As String
        Dim con As New OleDb.OleDbConnection

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb"
        con = New OleDbConnection(str)

        If rdbStudent.Checked Then
            sql = "SELECT stu_Username, stu_Password FROM student where stu_Username = '" & uname & "'and stu_Password = '" & password & "';"

            Dim cmd As OleDbCommand
            Dim r As OleDbDataReader

            con.Open()
            cmd = New OleDbCommand(sql, con)
            r = cmd.ExecuteReader()

            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MessageBox.Show("Plz Fill All the info", "Fill All", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf r.HasRows Then
                MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                LoginUsername = uname
                StudentOption.Show()
                txtUsername.Text = ""
                txtPassword.Text = ""

            Else
                MessageBox.Show("Invalid username or password! Please Try Again!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If

        ElseIf rdbTeacher.Checked Then
            sql = "SELECT tea_Username, tea_Password FROM teacher where tea_Username = '" & uname & "'and tea_Password = '" & password & "';"

            Dim cmd As OleDbCommand
            Dim r As OleDbDataReader

            con.Open()
            cmd = New OleDbCommand(sql, con)
            r = cmd.ExecuteReader()

            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MessageBox.Show("Plz Fill All the info", "Fill All", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf r.HasRows Then
                MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                LoginUsername = uname
                TeacherOption.Show()
                txtUsername.Text = ""
                txtPassword.Text = ""

            Else
                MessageBox.Show("Invalid username or password! Please Try Again!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
        ElseIf txtUsername.Text = "admin" And txtPassword.Text = "admin1234" Then
            MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            AdminOption.Show()
            txtUsername.Text = ""
            txtPassword.Text = ""
        Else
            MessageBox.Show("Please choose either student or teacher!", "User Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
End Class
