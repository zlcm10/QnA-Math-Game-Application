Imports System.Data.OleDb
Public Class PlayerScore
    Public ScoreUsername As String = QuestionForm.QuestionUsername

    Private Sub score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gamemode = 1 Then
            lblOutput.Text = "Dear " + ScoreUsername + ", You get the " + score.ToString + " score."

        ElseIf gamemode = 2 Then
            lblOutput.Text = "Dear " + ScoreUsername + ", You get " + score.ToString + " score."

        ElseIf gamemode = 3 Then
            lblOutput.Text = "Dear " + ScoreUsername + ", You get " + score.ToString + " score."

        ElseIf gamemode = 4 Then
            lblOutput.Text = "Dear " + ScoreUsername + ", You get " + score.ToString + " score."

        Else
            MessageBox.Show("Don't have this game mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As Integer = score

        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you want to save your score?", "Save Score?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If gamemode = 1 Then
            If dialog = Windows.Forms.DialogResult.Yes Then
                Dim cmd As New OleDbCommand
                Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\MathUser.accdb")
                Dim sql As String

                sql = "UPDATE student SET stu_AddMath = stu_AddMath + '" & score & "' where stu_Username = '" & ScoreUsername & "'"
                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Saved score is complete", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                StudentOption.generateScore()
                StudentOption.Show()

            Else
                Me.Close()
                StudentOption.Show()
            End If

        ElseIf gamemode = 2 Then
            If dialog = Windows.Forms.DialogResult.Yes Then
                Dim cmd As New OleDbCommand
                Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\MathUser.accdb")
                Dim sql As String

                sql = "UPDATE student SET stu_SubMath =  stu_SubMath + '" & score & "' where stu_Username = '" & ScoreUsername & "'"
                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Saved score is complete", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                StudentOption.generateScore()
                StudentOption.Show()
            Else
                Me.Close()
                StudentOption.Show()
            End If

        ElseIf gamemode = 3 Then
            If dialog = Windows.Forms.DialogResult.Yes Then
                Dim cmd As New OleDbCommand
                Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\MathUser.accdb")
                Dim sql As String

                sql = "UPDATE student SET stu_MulMath = stu_MulMath + '" & score & "' where stu_Username = '" & ScoreUsername & "'"
                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Saved score is complete", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                StudentOption.generateScore()
                StudentOption.Show()
            Else
                Me.Close()
                StudentOption.Show()
            End If

        ElseIf gamemode = 4 Then
            If dialog = Windows.Forms.DialogResult.Yes Then
                Dim cmd As New OleDbCommand
                Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\MathUser.accdb")
                Dim sql As String

                sql = "UPDATE student SET stu_DivMath = stu_DivMath + '" & score & "' where stu_Username = '" & ScoreUsername & "'"
                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Saved score is complete", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                StudentOption.generateScore()
                StudentOption.Show()
            Else
                Me.Close()
                StudentOption.Show()
            End If

        Else
            MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class