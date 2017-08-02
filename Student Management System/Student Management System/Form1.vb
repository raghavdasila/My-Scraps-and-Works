Public Class Form1
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If PwdBox.Text = "kartik" Then
            MMenu.Show()
            Me.Hide()
        Else
            Label2.Text = "Wrong Password!!"
        End If
    End Sub
End Class
