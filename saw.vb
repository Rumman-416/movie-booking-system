Public Class saw

    Private Sub saw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Me.Size = saw_panel.Size
    End Sub
    Private Sub sw_Add_btn_Click(sender As Object, e As EventArgs) Handles sw_Add_btn.Click
        sw_username_lbl.Text = user + " :"
        sw_user_review_output.Text = sw_user_review_txt.Text
    End Sub
    Private Sub sw_next_btn_Click(sender As Object, e As EventArgs) Handles sw_next_btn.Click
        sw_next_btn.Enabled = False
        sw_format_pnl.Visible = True
    End Sub
    Public Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles sw_vid_sc.Enter
        sw_vid_sc.URL = "D:\college projects\Movie booking\movie images\Saw\Saw_Trailer.mp4"
        sw_vid_sc.Ctlcontrols.play()
    End Sub

    Private Sub sw_ply_btn_Click(sender As Object, e As EventArgs) Handles sw_ply_btn.Click
        Call AxWindowsMediaPlayer1_Enter(Nothing, Nothing)
        sw_vid_sc.Ctlcontrols.pause()
        If sw_ply_btn.Visible = True Then
            sw_vid_sc.Ctlcontrols.pause()
            sw_ply_btn.Visible = False
        ElseIf sw_ply_btn.Visible = False Then
            sw_vid_sc.Ctlcontrols.play()
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

    Private Sub sw_format_nxt_btn_Click(sender As Object, e As EventArgs) Handles sw_format_nxt_btn.Click
        movie1___Date1__.Pname.Text = "Saw"
        TandC.Show()
        MainMenu.switchPanel(NowShowingForm)
        MainMenu.HighlightMain.Visible = True
        MainMenu.HighlightGenre.Visible = False
        MainMenu.HighlightBeverages.Visible = False
        MainMenu.HighlightScreen.Visible = False
        Me.Hide()
    End Sub

    Private Sub sw_btn_2d_CheckedChanged(sender As Object, e As EventArgs) Handles sw_btn_2d.CheckedChanged
        mode = "2D"
    End Sub

    Private Sub sw_btn_3d_CheckedChanged(sender As Object, e As EventArgs) Handles sw_btn_3d.CheckedChanged
        mode = "3D"
    End Sub
End Class