Public Class TicketForm
    Private Sub TicketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeatLabel.Text = selectedSeat
        Label6.Text = mode
        TotalLabel.Text = totalSeatPrice
        BevLabel.Text = totalRs
        TotLabel.Text = totalSeatPrice + totalRs
    End Sub

    Private Sub cross_Click(sender As Object, e As EventArgs) Handles cross.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        MainMenu.Show()
        MainMenu.switchPanel(NowShowingForm)
        MainMenu.HighlightMain.Visible = True
        MainMenu.HighlightGenre.Visible = False
        MainMenu.HighlightBeverages.Visible = False
        MainMenu.HighlightScreen.Visible = False
        Me.Hide()
    End Sub
End Class