Public Class Radhe

    Private Sub Radhe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Me.Size = radhe_panel.Size
    End Sub
    Private Sub rd_Add_btn_Click(sender As Object, e As EventArgs) Handles rd_Add_btn.Click
        rd_username_lbl.Text = user + " :"
        rd_user_review_output.Text = rd_user_review_txt.Text
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles rd_next_btn.Click
        rd_next_btn.Enabled = False
        radhe_format_pnl.Visible = True
    End Sub

    Public Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles rd_vid_sc.Enter
        rd_vid_sc.URL = "D:\college projects\Movie booking\movie images\Radhe\Radhe_Trailer.mp4"
        rd_vid_sc.Ctlcontrols.play()
    End Sub

    Private Sub ply_btn_Click(sender As Object, e As EventArgs) Handles rd_ply_btn.Click
        Call AxWindowsMediaPlayer1_Enter(Nothing, Nothing)
        rd_vid_sc.Ctlcontrols.pause()
        If rd_ply_btn.Visible = True Then
            rd_vid_sc.Ctlcontrols.pause()
            rd_ply_btn.Visible = False
        ElseIf rd_ply_btn.Visible = False Then
            rd_vid_sc.Ctlcontrols.play()
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
        Me.Hide()
    End Sub

    Private Sub rd_format_nxt_btn_Click(sender As Object, e As EventArgs) Handles rd_format_nxt_btn.Click
        movie1___Date1__.Pname.Text = "Radhe"
        TandC.Show()
        MainMenu.switchPanel(NowShowingForm)
        MainMenu.HighlightMain.Visible = True
        MainMenu.HighlightGenre.Visible = False
        MainMenu.HighlightBeverages.Visible = False
        MainMenu.HighlightScreen.Visible = False
        Me.Hide()
    End Sub

    Private Sub rd_btn_2d_CheckedChanged(sender As Object, e As EventArgs) Handles rd_btn_2d.CheckedChanged
        mode = "2D"
    End Sub

    Private Sub rd_btn_3d_CheckedChanged(sender As Object, e As EventArgs) Handles rd_btn_3d.CheckedChanged
        mode = "2D"
    End Sub
End Class