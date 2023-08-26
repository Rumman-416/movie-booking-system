Public Class suzume


    Private Sub suzume_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Me.Size = suz_panel.Size
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles s_Add_btn.Click
        s_username_lbl.Text = user + " :"
        s_user_review_output.Text = s_user_review_txt.Text
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles s_next_btn.Click
        s_next_btn.Enabled = False
        suz_format_pnl.Visible = True
    End Sub
    Public Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles s_vid_sc.Enter
        s_vid_sc.URL = "D:\college projects\Movie booking\movie images\Suzume\Suzume_trailer.mp4"
        s_vid_sc.Ctlcontrols.play()
    End Sub

    Private Sub s_ply_btn_Click(sender As Object, e As EventArgs) Handles s_ply_btn.Click
        Call AxWindowsMediaPlayer1_Enter(Nothing, Nothing)
        s_vid_sc.Ctlcontrols.pause()
        If s_ply_btn.Visible = True Then
            s_vid_sc.Ctlcontrols.pause()
            s_ply_btn.Visible = False
        ElseIf s_ply_btn.Visible = False Then
            s_vid_sc.Ctlcontrols.play()
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

    Private Sub s_format_nxt_btn_Click(sender As Object, e As EventArgs) Handles s_format_nxt_btn.Click
        movie1___Date1__.Pname.Text = "Suzume"
        TandC.Show()
        Me.Hide()
    End Sub

    Private Sub s_btn_2d_CheckedChanged(sender As Object, e As EventArgs) Handles s_btn_2d.CheckedChanged
        mode = "2D"
    End Sub

    Private Sub s_btn_3d_CheckedChanged(sender As Object, e As EventArgs) Handles s_btn_3d.CheckedChanged
        mode = "3D"
    End Sub
End Class