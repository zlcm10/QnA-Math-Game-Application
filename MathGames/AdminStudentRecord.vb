Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Public Class AdminStudentRecord
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Function GetStudent() As DataTable

        Dim dtStudent As New DataTable

        connstring = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using myconnection As New OleDbConnection(connstring)
            Using cmd As New OleDbCommand("SELECT * FROM student", myconnection)

                myconnection.Open()

                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                dtStudent.Load(reader)
                dtStudent.Load(reader)

            End Using
        End Using

        Return dtStudent

    End Function

    Sub LoadDGV()
        DGV.DataSource = GetStudent()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "INSERT INTO student(stu_ID,stu_Username,stu_Password,stu_AddMath,stu_SubMath,stu_MulMath,stu_DivMath) values ('" & txtID.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "','" & txtAddScore.Text & "','" & txtSubScore.Text & "','" & txtMulScore.Text & "','" & txtDivScore.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

        cmd.Parameters.Add(New OleDbParameter("stu_ID", CType(txtID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("stu_Username", CType(txtUsername.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("stu_Password", CType(txtPassword.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("stu_AddMath", CType(txtAddScore.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("stu_SubMath", CType(txtSubScore.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("stu_MulMath", CType(txtMulScore.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("stu_DivMath", CType(txtDivScore.Text, String)))

        MessageBox.Show("Account Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtID.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtAddScore.Clear()
            txtSubScore.Clear()
            txtMulScore.Clear()
            txtDivScore.Clear()
            LoadDGV()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "DELETE FROM [student] WHERE [stu_ID] = " & txtID.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

        MessageBox.Show("Account Deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtID.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtAddScore.Clear()
            txtSubScore.Clear()
            txtMulScore.Clear()
            txtDivScore.Clear()
            LoadDGV()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "update student set [stu_Username] = '" & txtUsername.Text & "', [stu_Password] = '" & txtPassword.Text & "', [stu_AddMath] = '" & txtAddScore.Text & "', [stu_SubMath] = '" & txtSubScore.Text & "', [stu_MulMath] = '" & txtMulScore.Text & "', [stu_DivMath] = '" & txtDivScore.Text & "' WHERE [stu_ID] = " & txtID.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

        MessageBox.Show("Account Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtID.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtAddScore.Clear()
            txtSubScore.Clear()
            txtMulScore.Clear()
            txtDivScore.Clear()
            LoadDGV()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtAddScore.Clear()
        txtSubScore.Clear()
        txtMulScore.Clear()
        txtDivScore.Clear()
    End Sub

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MathUserDataSet.student' table.
        Me.StudentTableAdapter.Fill(Me.MathUserDataSet.student)
        LoadDGV()
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you want to go back to option form?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            AdminOption.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb")

        Dim command As New OleDbCommand("SELECT * FROM student where stu_ID = @id", con)

        command.Parameters.Add("@id", OleDbType.Integer).Value = txtID.Text

        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        txtUsername.Text = ""
        txtPassword.Text = ""
        txtAddScore.Text = ""
        txtSubScore.Text = ""
        txtMulScore.Text = ""
        txtDivScore.Text = ""

        If table.Rows.Count() > 0 Then
            txtUsername.Text = table.Rows(0)(1).ToString()
            txtPassword.Text = table.Rows(0)(2).ToString()
            txtAddScore.Text = table.Rows(0)(3).ToString()
            txtSubScore.Text = table.Rows(0)(4).ToString()
            txtMulScore.Text = table.Rows(0)(5).ToString()
            txtDivScore.Text = table.Rows(0)(6).ToString()
        Else
            MessageBox.Show("No Data Found", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtID.Text = ""
        End If

    End Sub
End Class