Imports System.Data.OleDb
Public Class ChangePassword
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure don't want to change your password?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
            txtUsername.Text = ""
            txtNewPassword.Text = ""
            txtConfirmPassword.Text = ""
        End If

    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim userName As String
        Dim newPassword As String
        Dim cmd As New OleDbCommand

        userName = txtUsername.Text
        newPassword = txtNewPassword.Text

        Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\MathUser.accdb")
        Dim sql As String

        If changePass = "student" Then
            If txtUsername.Text = "" Or txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
                MessageBox.Show("Plz Fill All the info", "Fill All", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf txtNewPassword.Text = txtConfirmPassword.Text Then
                MessageBox.Show("New Password Updated", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                sql = "UPDATE student SET stu_Password = '" & newPassword & "' WHERE stu_Username = '" & userName & "'"
                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()

                Me.Hide()
                LoginForm.Show()
                txtUsername.Text = ""
                txtNewPassword.Text = ""
                txtConfirmPassword.Text = ""
            End If

        ElseIf changePass = "teacher" Then
            If txtUsername.Text = "" Or txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
                MessageBox.Show("Plz Fill All the info", "Fill All", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf txtNewPassword.Text = txtConfirmPassword.Text Then
            MessageBox.Show("New Password Updated", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                sql = "UPDATE teacher SET tea_Password = '" & newPassword & "' WHERE tea_Username = '" & userName & "'"
                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()

                Me.Hide()
                LoginForm.Show()
                txtUsername.Text = ""
                txtNewPassword.Text = ""
                txtConfirmPassword.Text = ""
            End If
        End If

        con.Close()
    End Sub

    Private Sub StudentChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewPassword.UseSystemPasswordChar = True

        txtConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub lblShowPassword_Click(sender As Object, e As EventArgs) Handles lblShowPassword.Click
        If txtNewPassword.UseSystemPasswordChar = True Then

            txtNewPassword.UseSystemPasswordChar = False

            lblShowPassword.Text = "Hide Password"
        Else

            txtNewPassword.UseSystemPasswordChar = True

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