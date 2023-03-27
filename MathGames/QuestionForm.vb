Imports System.Data.OleDb
Public Class QuestionForm
    Public QuestionUsername As String = StudentOption.StudentUsername
    Dim timesNum As Integer = 1

    Private Sub PracticeMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nextQuestion()
        lblUsername.Text = QuestionUsername
    End Sub

    Sub compareAnswer()
        Dim sql As String
        Dim str As String
        Dim con As New OleDb.OleDbConnection
        Dim cmd As OleDbCommand
        Dim r As OleDbDataReader
        Dim question As String = txtQuestion.Text

        Dim ans As Integer

        If gamemode = 1 Then
            str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathQuestion.accdb"
            con = New OleDbConnection(str)
            sql = "SELECT math_Answer FROM Addition where math_Question = '" & question & "';"

            con.Open()
            cmd = New OleDbCommand(sql, con)
            r = cmd.ExecuteReader()

            If r.Read Then
                ans = r("math_Answer")
                If txtAnswer.Text = "" Then
                    MessageBox.Show("Please enter answer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    If txtAnswer.Text = ans Then
                        timesNum += 1
                        score += 10
                        txtAnswer.Clear()
                        txtAnswer.Focus()
                        nextQuestion()

                    Else
                        timesNum += 1
                        txtAnswer.Clear()
                        txtAnswer.Focus()
                        nextQuestion()

                    End If
                End If

                txtScore.Text = score
            End If

        ElseIf gamemode = 2 Then
            str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathQuestion.accdb"
            con = New OleDbConnection(str)
            sql = "SELECT math_Answer FROM Subtraction where math_Question = '" & question & "';"

            con.Open()
            cmd = New OleDbCommand(sql, con)
            r = cmd.ExecuteReader()

            If r.Read Then
                ans = r("math_Answer")
                If txtAnswer.Text = "" Then
                    MessageBox.Show("Please enter answer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    If txtAnswer.Text = ans Then
                        timesNum += 1
                        score += 10
                        txtAnswer.Clear()
                        txtAnswer.Focus()
                        nextQuestion()

                    Else
                        timesNum += 1
                        txtAnswer.Clear()
                        txtAnswer.Focus()
                        nextQuestion()

                    End If
                End If

                txtScore.Text = score
            End If

        ElseIf gamemode = 3 Then
            str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathQuestion.accdb"
            con = New OleDbConnection(str)
            sql = "SELECT math_Answer FROM Multiplication where math_Question = '" & question & "';"

            con.Open()
            cmd = New OleDbCommand(sql, con)
            r = cmd.ExecuteReader()

            If r.Read Then
                ans = r("math_Answer")
                If txtAnswer.Text = "" Then
                    MessageBox.Show("Please enter answer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    If txtAnswer.Text = ans Then
                        timesNum += 1
                        score += 10
                        txtAnswer.Clear()
                        txtAnswer.Focus()
                        nextQuestion()

                    Else
                        timesNum += 1
                        txtAnswer.Clear()
                        txtAnswer.Focus()
                        nextQuestion()

                    End If
                End If

                txtScore.Text = score
            End If

        ElseIf gamemode = 4 Then
            str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathQuestion.accdb"
            con = New OleDbConnection(str)
            sql = "SELECT math_Answer FROM Division where math_Question = '" & question & "';"

            con.Open()
            cmd = New OleDbCommand(sql, con)
            r = cmd.ExecuteReader()

            If r.Read Then
                ans = r("math_Answer")
                If txtAnswer.Text = "" Then
                    MessageBox.Show("Please enter answer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    If txtAnswer.Text = ans Then
                        timesNum += 1
                        score += 10
                        txtAnswer.Clear()
                        txtAnswer.Focus()
                        nextQuestion()

                    Else
                        timesNum += 1
                        txtAnswer.Clear()
                        txtAnswer.Focus()
                        nextQuestion()

                    End If
                End If

                txtScore.Text = score
            End If

        Else
            MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        con.Close()

    End Sub

    Sub nextQuestion()
        Dim sql As String
        Dim str As String
        Dim con As New OleDb.OleDbConnection
        Dim cmd As OleDbCommand
        Dim r As OleDbDataReader
        Dim questionNum As Integer

        If gamemode = 1 Then

            If timesNum <= 10 Then
                questionNum = rndnumber()

                str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathQuestion.accdb"
                con = New OleDbConnection(str)
                sql = "SELECT math_Question FROM Addition where math_ID = " & questionNum & ";"

                con.Open()
                cmd = New OleDbCommand(sql, con)
                r = cmd.ExecuteReader()

                If r.Read Then
                    txtQuestion.Text = r("math_Question")

                End If
            Else
                Me.Close()
                gamemode = 1
                PlayerScore.Show()
            End If

        ElseIf gamemode = 2 Then

            If timesNum <= 10 Then
                questionNum = rndnumber()

                str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathQuestion.accdb"
                con = New OleDbConnection(str)
                sql = "SELECT math_Question FROM Subtraction where math_ID = " & questionNum & ";"

                con.Open()
                cmd = New OleDbCommand(sql, con)
                r = cmd.ExecuteReader()

                If r.Read Then
                    txtQuestion.Text = r("math_Question")

                End If
            Else
                Me.Close()
                gamemode = 2
                PlayerScore.Show()

            End If

        ElseIf gamemode = 3 Then

            If timesNum <= 10 Then
                questionNum = rndnumber()

                str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathQuestion.accdb"
                con = New OleDbConnection(str)
                sql = "SELECT math_Question FROM Multiplication where math_ID = " & questionNum & ";"

                con.Open()
                cmd = New OleDbCommand(sql, con)
                r = cmd.ExecuteReader()

                If r.Read Then
                    txtQuestion.Text = r("math_Question")

                End If
            Else
                Me.Close()
                gamemode = 3
                PlayerScore.Show()

            End If

        ElseIf gamemode = 4 Then

            If timesNum <= 10 Then
                questionNum = rndnumber()

                str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathQuestion.accdb"
                con = New OleDbConnection(str)
                sql = "SELECT math_Question FROM Division where math_ID = " & questionNum & ";"

                con.Open()
                cmd = New OleDbCommand(sql, con)
                r = cmd.ExecuteReader()

                If r.Read Then
                    txtQuestion.Text = r("math_Question")

                End If
            Else
                Me.Close()
                gamemode = 4
                PlayerScore.Show()

            End If

        Else
            MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        compareAnswer()
    End Sub


    Function rndnumber()
        Dim num As Integer

        num = Math.Ceiling(Rnd() * 10)

        Return num

    End Function
End Class