Imports System.Data.OleDb
'Imports Microsoft.VisualBasic
Public Class RegisterForm

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you want to go back to login form?", "Go Back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtConfirmPassword.Text = ""
        End If
    End Sub

    Private Sub lblCreate_Click(sender As Object, e As EventArgs) Handles lblCreate.Click
        Dim useracc As String
        Dim sql As String
        Dim cmd As New OleDbCommand
        Dim userpassword As String

        useracc = txtUsername.Text
        userpassword = txtPassword.Text

        Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\MathUser.accdb")

        If userType = "student" Then

            sql = "INSERT INTO student(stu_Username,stu_Password) values ('" & useracc & "','" & userpassword & "')"

            con.Open()
            cmd = New OleDbCommand(sql, con)

            cmd.ExecuteNonQuery()


            If txtUsername.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
                MessageBox.Show("Plz Fill All the info", "Fill All", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Your Password must match with the Confirm Password!", "Match Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf lblOutput.Text = "Username already taken" Then
                MessageBox.Show("Your username has been created", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf txtPassword.Text = txtConfirmPassword.Text Then
                MessageBox.Show("Student Account Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information)

                con.Close()
                Me.Close()
                LoginForm.Show()
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtConfirmPassword.Text = ""
            End If


        ElseIf userType = "teacher" Then

            sql = "INSERT INTO teacher(tea_Username,tea_Password) values ('" & useracc & "','" & userpassword & "')"

            con.Open()
            cmd = New OleDbCommand(sql, con)

            cmd.ExecuteNonQuery()


            If txtUsername.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
                MessageBox.Show("Plz Fill All the info", "Fill All", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Your Password must match with the Confirm Password!", "Match Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf lblOutput.Text = "Username already taken" Then
                MessageBox.Show("Your username has been created", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf txtPassword.Text = txtConfirmPassword.Text Then
                MessageBox.Show("Teacher Account Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information)

                con.Close()
                Me.Close()
                LoginForm.Show()
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtConfirmPassword.Text = ""
            End If
        End If

    End Sub

    Private Sub lblChkUsername_Click(sender As Object, e As EventArgs) Handles lblChkUsername.Click
        Timer1.Enabled = True
        Timer1.Interval = 1000
        lblChecking.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 2000 Then


            Dim cmd As New OleDbCommand
            Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\MathUser.accdb")
            Dim sql As String

            If userType = "student" Then

                sql = "Select stu_Username from student where username = stu_Username"

                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.Parameters.AddWithValue("stu_Username", txtUsername.Text)

                Dim dr As OleDbDataReader
                dr = cmd.ExecuteReader()

                While dr.Read
                    lblOutput.BackColor = Color.Red
                    lblOutput.ForeColor = Color.White
                    lblChecking.Visible = False
                    lblOutput.Text = "Username already taken"
                    con.Close()
                    Exit Sub

                End While
                lblOutput.Text = "Available"
                lblOutput.BackColor = Color.Green
                lblOutput.ForeColor = Color.White
                lblChecking.Visible = False
                con.Close()

            ElseIf userType = "teacher" Then

                sql = "Select tea_Username from teacher where username = tea_Username"

                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.Parameters.AddWithValue("tea_Username", txtUsername.Text)

                Dim dr As OleDbDataReader
                dr = cmd.ExecuteReader()

                While dr.Read
                    lblOutput.BackColor = Color.Red
                    lblOutput.ForeColor = Color.White
                    lblChecking.Visible = False
                    lblOutput.Text = "Username already taken"
                    con.Close()
                    Exit Sub

                End While
                lblOutput.Text = "Available"
                lblOutput.BackColor = Color.Green
                lblOutput.ForeColor = Color.White
                lblChecking.Visible = False
                con.Close()

            End If
        End If
        Timer1.Interval += 1000
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        lblOutput.Text = ""

    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblChecking.Visible = False

        'for show and hide the pw
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
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

    Private Sub lblShowConPassword_Click(sender As Object, e As EventArgs) Handles lblShowConPassword.Click
        If txtConfirmPassword.UseSystemPasswordChar = True Then

            txtConfirmPassword.UseSystemPasswordChar = False

            lblShowConPassword.Text = "Hide Password"
        Else

            txtConfirmPassword.UseSystemPasswordChar = True

            lblShowConPassword.Text = "Show Password"
        End If
    End Sub
End Class