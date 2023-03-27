
Public Class UserGuide
    Dim images(5) As Bitmap
    Dim pos As Integer = 0

    Private Sub lblNext_Click(sender As Object, e As EventArgs) Handles lblNext.Click
        pos = pos + 1

        If pos < images.Length - 1 Then
            PictureBox1.Image = images(pos)
        Else
            pos = images.Length - 1
        End If
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        images(0) = MathGames.My.Resources.loginForm
        images(1) = MathGames.My.Resources.registerForm
        images(2) = MathGames.My.Resources.studentOption
        images(3) = MathGames.My.Resources.questionForm
        images(4) = MathGames.My.Resources.scoreForm

        PictureBox1.Image = images(0)
    End Sub

    Private Sub lblPrevious_Click(sender As Object, e As EventArgs) Handles lblPrevious.Click
        pos = pos - 1

        If pos >= 0 Then
            PictureBox1.Image = images(pos)
        Else
            pos = 0
        End If
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
        StudentOption.Show()
    End Sub
End Class