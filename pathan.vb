Public Class pathan
    Private Sub pathan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Me.Size = pathan_panel.Size
    End Sub
    Private Sub pt_Add_btn_Click(sender As Object, e As EventArgs) Handles pt_Add_btn.Click
        pt_username_lbl.Text = user + " :"
        pt_user_review_output.Text = pt_user_review_txt.Text
    End Sub

    Private Sub pt_next_btn_Click(sender As Object, e As EventArgs) Handles pt_next_btn.Click
        pt_next_btn.Enabled = False
        pathan_format_pnl.Visible = True
    End Sub
    Public Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles pt_vid_sc.Enter
        pt_vid_sc.URL = "D:\college projects\Movie booking\movie images\Pathan\Pathan_Trailer.mp4"
        pt_vid_sc.Ctlcontrols.play()
    End Sub

    Private Sub pt_ply_btn_Click(sender As Object, e As EventArgs) Handles pt_ply_btn.Click
        Call AxWindowsMediaPlayer1_Enter(Nothing, Nothing)
        pt_vid_sc.Ctlcontrols.pause()
        If pt_ply_btn.Visible = True Then
            pt_vid_sc.Ctlcontrols.pause()
            pt_ply_btn.Visible = False
        ElseIf pt_ply_btn.Visible = False Then
            pt_vid_sc.Ctlcontrols.play()
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

    Private Sub pt_format_nxt_btn_Click(sender As Object, e As EventArgs) Handles pt_format_nxt_btn.Click
        movie1___Date1__.Pname.Text = "Pathan"
        TandC.Show()
        Me.Hide()
    End Sub

    Private Sub pt_btn_2d_CheckedChanged(sender As Object, e As EventArgs) Handles pt_btn_2d.CheckedChanged
        mode = "2D"
    End Sub

    Private Sub pt_btn_3d_CheckedChanged(sender As Object, e As EventArgs) Handles pt_btn_3d.CheckedChanged
        mode = "3D"
    End Sub
End Class