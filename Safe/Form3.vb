Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            System.Diagnostics.Process.Start("https://wa.me/541134225141")
        Catch ex As Exception

        End Try
    End Sub
End Class