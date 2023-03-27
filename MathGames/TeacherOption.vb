Imports System.Data.OleDb
Public Class TeacherOption
    Public TeacherUsername As String = LoginForm.LoginUsername

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb")

        If txtSearch.Text = "" Then
            MessageBox.Show("Please input something message!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If rdbID.Checked Then
            Dim command As New OleDbCommand("SELECT * FROM student where stu_ID = @id", con)

            command.Parameters.Add("@id", OleDbType.Integer).Value = txtSearch.Text

            Dim adapter As New OleDbDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            txtAddScore.Text = ""
            txtSubScore.Text = ""
            txtMulScore.Text = ""
            txtDivScore.Text = ""

            If table.Rows.Count() > 0 Then
                txtAddScore.Text = table.Rows(0)(3).ToString()
                txtSubScore.Text = table.Rows(0)(4).ToString()
                txtMulScore.Text = table.Rows(0)(5).ToString()
                txtDivScore.Text = table.Rows(0)(6).ToString()
            Else
                MessageBox.Show("No Data Found", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Text = ""
            End If

        ElseIf rdbUsername.Checked Then
            Dim command As New OleDbCommand("SELECT * FROM student where stu_Username = @username", con)

            command.Parameters.Add("@username", OleDbType.Char).Value = txtSearch.Text

            Dim adapter As New OleDbDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            txtAddScore.Text = ""
            txtSubScore.Text = ""
            txtMulScore.Text = ""
            txtDivScore.Text = ""

            If table.Rows.Count() > 0 Then
                txtAddScore.Text = table.Rows(0)(3).ToString()
                txtSubScore.Text = table.Rows(0)(4).ToString()
                txtMulScore.Text = table.Rows(0)(5).ToString()
                txtDivScore.Text = table.Rows(0)(6).ToString()
            Else
                MessageBox.Show("No Data Found", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Text = ""
            End If

        Else
            MessageBox.Show("Please choose either ID or Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you want to exit? ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()

        End If

    End Sub

    Private Sub TeacherOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblShowUsername.Text = TeacherUsername
    End Sub
End Class