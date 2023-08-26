Public Class Lallu

    Private Sub Lallu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Me.Size = lallu_panel.Size
    End Sub
    Private Sub ll_Add_btn_Click(sender As Object, e As EventArgs) Handles ll_Add_btn.Click
        ll_username_lbl.Text = user + " :"
        ll_user_review_output.Text = ll_user_review_txt.Text
    End Sub

    Private Sub ll_next_btn_Click(sender As Object, e As EventArgs) Handles ll_next_btn.Click
        ll_next_btn.Enabled = False
        lallu_format_pnl.Visible = True
    End Sub

    Public Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles ll_vid_sc.Enter
        ll_vid_sc.URL = "D:\college projects\Movie booking\movie images\Lalu\Lallu_trailer.mp4"
        ll_vid_sc.Ctlcontrols.play()
    End Sub

    Private Sub ply_btn_Click(sender As Object, e As EventArgs) Handles ll_ply_btn.Click
        Call AxWindowsMediaPlayer1_Enter(Nothing, Nothing)
        ll_vid_sc.Ctlcontrols.pause()
        If ll_ply_btn.Visible = True Then
            ll_vid_sc.Ctlcontrols.pause()
            ll_ply_btn.Visible = False
        ElseIf ll_ply_btn.Visible = False Then
            ll_vid_sc.Ctlcontrols.play()
        End If
    End Sub

    Sub switchPanel(ByVal panel As Form)
        lallu_panel.Controls.Clear()
        panel.TopLevel = False
        lallu_panel.Controls.Add(panel)
        panel.Show()
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

    Private Sub ll_format_nxt_btn_Click(sender As Object, e As EventArgs) Handles ll_format_nxt_btn.Click
        movie1___Date1__.Pname.Text = "Lallu Kei Laila"
        TandC.Show()
        Me.Hide()
    End Sub

    Private Sub ll_btn_2d_CheckedChanged(sender As Object, e As EventArgs) Handles ll_btn_2d.CheckedChanged
        mode = "2D"
    End Sub

    Private Sub ll_btn_3d_CheckedChanged(sender As Object, e As EventArgs) Handles ll_btn_3d.CheckedChanged
        mode = "3D"
    End Sub
End Class