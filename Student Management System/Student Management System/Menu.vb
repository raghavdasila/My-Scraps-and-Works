Public Class MMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudDetails.Show()
        '  Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Marks.Show()
        'Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        attendance.Show()
        'Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DB.Show()
    End Sub

    Private Sub meclose(sender As Object, e As EventArgs) Handles Me.Closing
        Form1.Close()
        StudDetails.Close()
        Marks.Close()
        DB.Close()
        attendance.Close()

    End Sub
End Class