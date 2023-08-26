Public Class movie1___Date1__
    Sub switchPanel(ByVal panel As Form)
        fixedpanel1today.Controls.Clear()
        panel.TopLevel = False
        fixedpanel1today.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub tomorrowpathandate1_Click(sender As Object, e As EventArgs) Handles tomorrowpathandate1.Click
        switchPanel(movie1___Date_2__)
        HighlightToday.Visible = False
        HighlightTomorrow.Visible = True
        HighlightDAT.Visible = False
    End Sub

    Private Sub Dayaftertomorrowpathandate1_Click(sender As Object, e As EventArgs) Handles Dayaftertomorrowpathandate1.Click
        switchPanel(movie1___date_3_)
        HighlightToday.Visible = False
        HighlightTomorrow.Visible = False
        HighlightDAT.Visible = True
    End Sub

    Private Sub movie1date1screen1timing1_Click(sender As Object, e As EventArgs)
        Screen1.Show()
        Me.Hide()
    End Sub


    Private Sub todaypathandate1_Click(sender As Object, e As EventArgs) Handles todaypathandate1.Click
        switchPanel(movie1_date1_)
        HighlightToday.Visible = True
        HighlightTomorrow.Visible = False
        HighlightDAT.Visible = False
    End Sub


    Private Sub cross_Click(sender As Object, e As EventArgs) Handles cross.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub lessthan1movie1_Click(sender As Object, e As EventArgs) Handles lessthan1movie1.Click
        MainMenu.Show()
        MainMenu.switchPanel(NowShowingForm)
        MainMenu.HighlightMain.Visible = True
        MainMenu.HighlightGenre.Visible = False
        MainMenu.HighlightBeverages.Visible = False
        MainMenu.HighlightScreen.Visible = False
        Me.Hide()
    End Sub

End Class