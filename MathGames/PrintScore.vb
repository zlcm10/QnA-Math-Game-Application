Imports System.Data.OleDb
Public Class PrintScore
    Public PrintUsername As String = StudentOption.StudentUsername

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim sql As String
        Dim str As String
        Dim con As New OleDb.OleDbConnection
        Dim cmd As OleDbCommand
        Dim r As OleDbDataReader
        Dim addmath, subMath, divMath, mulmath As Integer

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\MathUser.accdb"
        con = New OleDbConnection(str)
        sql = "SELECT * FROM student where stu_Username = '" & PrintUsername & "';"

        con.Open()
        cmd = New OleDbCommand(sql, con)
        r = cmd.ExecuteReader()

        If r.Read Then
            addmath = r("stu_AddMath")
            subMath = r("stu_SubMath")
            mulmath = r("stu_MulMath")
            divMath = r("stu_DivMath")

        End If

        Dim ReportFont As Font = New Drawing.Font("Arial", 14)
        e.Graphics.DrawString("Dear " & PrintUsername, ReportFont, Brushes.Blue, 100, 100)
        e.Graphics.DrawString("Total Score", ReportFont, Brushes.Blue, 100, 150)
        e.Graphics.DrawString("Addition Math Score:          " & addmath, ReportFont, Brushes.Black, 100, 300)
        e.Graphics.DrawString("Subtraction Math Score:     " & subMath, ReportFont, Brushes.Black, 100, 400)
        e.Graphics.DrawString("Multiplication Math Score:   " & mulmath, ReportFont, Brushes.Black, 100, 500)
        e.Graphics.DrawString("Division Math Score:          " & divMath, ReportFont, Brushes.Black, 100, 600)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewControl1.Document = PrintDocument1
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you want to go back to option form?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            StudentOption.Show()
        End If

    End Sub
End Class