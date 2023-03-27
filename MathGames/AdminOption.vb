Public Class AdminOption
    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Close()
        AdminStudentRecord.Show()

    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Me.Close()
        AdminTeacherRecord.Show()

    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
        End If
    End Sub

    Private Sub AdminOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class