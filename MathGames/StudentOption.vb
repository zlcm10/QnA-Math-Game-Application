Imports System.Data.OleDb
Public Class StudentOption
    Public StudentUsername As String = LoginForm.LoginUsername


    Private Sub btnAdditionMath_Click(sender As Object, e As EventArgs) Handles btnAdditionMath.Click
        gamemode = 1
        Me.Close()
        score = 0
        QuestionForm.Show()


    End Sub

    Private Sub StudentOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = StudentUsername

        generateScore()
    End Sub

    Sub generateScore()
        Dim sql As String
        Dim str As String
        Dim con As New OleDb.OleDbConnection
        Dim cmd As OleDbCommand
        Dim r As OleDbDataReader

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb"
        con = New OleDbConnection(str)
        sql = "SELECT stu_AddMath, stu_SubMath, stu_MulMath, stu_DivMath FROM student where stu_Username = '" & StudentUsername & "';"

        con.Open()
        cmd = New OleDbCommand(sql, con)
        r = cmd.ExecuteReader()

        If r.Read Then
            txtAdditionScore.Text = r("stu_AddMath")
            txtSubtractionScore.Text = r("stu_SubMath")
            txtMultiplicationScore.Text = r("stu_MulMath")
            txtDivisionScore.Text = r("stu_DivMath")
        End If
        con.Close()
    End Sub

    Private Sub btnSubtractionMath_Click(sender As Object, e As EventArgs) Handles btnSubtractionMath.Click
        gamemode = 2
        Me.Close()
        score = 0
        QuestionForm.Show()
    End Sub

    Private Sub btnMultiplicationMath_Click(sender As Object, e As EventArgs) Handles btnMultiplicationMath.Click
        gamemode = 3
        Me.Close()
        score = 0
        QuestionForm.Show()
    End Sub

    Private Sub btnDivisionMath_Click(sender As Object, e As EventArgs) Handles btnDivisionMath.Click
        gamemode = 4
        Me.Close()
        score = 0
        QuestionForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
        End If
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Me.Close()
        PrintScore.Show()

    End Sub

    Private Sub lblUserGuide_Click(sender As Object, e As EventArgs) Handles lblUserGuide.Click
        Me.Close()
        UserGuide.Show()

    End Sub
End Class