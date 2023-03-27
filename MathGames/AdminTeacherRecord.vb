Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Public Class AdminTeacherRecord
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Function GetTeacher() As DataTable

        Dim dtTeacher As New DataTable

        connstring = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using myconnection As New OleDbConnection(connstring)
            Using cmd As New OleDbCommand("SELECT * FROM teacher", myconnection)

                myconnection.Open()

                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                dtTeacher.Load(reader)

            End Using
        End Using

        Return dtTeacher

    End Function

    Sub LoadDGV()
        DGV.DataSource = GetTeacher()
    End Sub

    Private Sub AdminTeacherRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MathUserDataSet1.teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter.Fill(Me.MathUserDataSet1.teacher)
        'TODO: This line of code loads data into the 'MathUserDataSet1.teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter.Fill(Me.MathUserDataSet1.teacher)
        LoadDGV()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "INSERT INTO teacher(tea_ID,tea_Username,tea_Password) values ('" & txtID.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

        cmd.Parameters.Add(New OleDbParameter("stu_ID", CType(txtID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("stu_Username", CType(txtUsername.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("stu_Password", CType(txtPassword.Text, String)))

        MessageBox.Show("Account Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtID.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
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
        command = "DELETE FROM [teacher] WHERE [tea_ID] = " & txtID.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

        MessageBox.Show("Account Deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtID.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
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
        command = "update teacher set [tea_Username] = '" & txtUsername.Text & "', [tea_Password] = '" & txtPassword.Text & "' WHERE [tea_ID] = " & txtID.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

        MessageBox.Show("Account Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtID.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            LoadDGV()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you want to go back to option form?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            AdminOption.Show()
        End If
    End Sub

    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb")

        Dim command As New OleDbCommand("SELECT * FROM teacher where tea_ID = @id", con)

        command.Parameters.Add("@id", OleDbType.Integer).Value = txtID.Text

        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        txtUsername.Text = ""
        txtPassword.Text = ""

        If table.Rows.Count() > 0 Then
            txtUsername.Text = table.Rows(0)(1).ToString()
            txtPassword.Text = table.Rows(0)(2).ToString()
        Else
            MessageBox.Show("No Data Found", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtID.Text = ""
        End If
    End Sub
End Class