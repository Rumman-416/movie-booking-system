Public Class poster_boys
    Private Sub poster_boys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Me.Size = poster_panel.Size
    End Sub
    Private Sub pb_Add_btn_Click(sender As Object, e As EventArgs) Handles pb_Add_btn.Click
        pb_username_lbl.Text = user + " :"
        pb_user_review_output.Text = pb_user_review_txt.Text
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles pb_next_btn.Click
        pb_next_btn.Enabled = False
        poster_format_pnl.Visible = True
    End Sub

    Public Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles pb_vid_sc.Enter
        pb_vid_sc.URL = "D:\college projects\Movie booking\movie images\Poster boys\Poster_Boys_Trailer.mp4"
        pb_vid_sc.Ctlcontrols.play()
    End Sub

    Private Sub ply_btn_Click(sender As Object, e As EventArgs) Handles pb_ply_btn.Click
        Call AxWindowsMediaPlayer1_Enter(Nothing, Nothing)
        pb_vid_sc.Ctlcontrols.pause()
        If pb_ply_btn.Visible = True Then
            pb_vid_sc.Ctlcontrols.pause()
            pb_ply_btn.Visible = False
        ElseIf pb_ply_btn.Visible = False Then
            pb_vid_sc.Ctlcontrols.play()
        End If
    End Sub

    Private Sub cross_Click(sender As Object, e As EventArgs) Handles cross.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainMenu.Show()
        MainMenu.switchPanel(NowShowingForm)
        MainMenu.HighlightMain.Visible = True
        MainMenu.HighlightGenre.Visible = False
        MainMenu.HighlightBeverages.Visible = False
        MainMenu.HighlightScreen.Visible = False
        Me.Hide()
    End Sub

    Private Sub pb_format_nxt_btn_Click(sender As Object, e As EventArgs) Handles pb_format_nxt_btn.Click
        movie1___Date1__.Pname.Text = "Pster Boys"
        TandC.Show()
        Me.Hide()
    End Sub

    Private Sub pb_btn_2d_CheckedChanged(sender As Object, e As EventArgs) Handles pb_btn_2d.CheckedChanged
        mode = "2D"
    End Sub

    Private Sub pb_btn_3d_CheckedChanged(sender As Object, e As EventArgs) Handles pb_btn_3d.CheckedChanged
        mode = "2D"
    End Sub
End Class