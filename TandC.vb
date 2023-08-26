Public Class TandC
    Private Sub cross_Click(sender As Object, e As EventArgs) Handles cross.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        movie1___Date1__.Show()
        movie1___Date1__.switchPanel(movie1_date1_)
        movie1___Date1__.HighlightToday.Visible = True
        movie1___Date1__.HighlightTomorrow.Visible = False
        movie1___Date1__.HighlightDAT.Visible = False
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class
