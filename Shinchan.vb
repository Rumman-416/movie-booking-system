Public Class Shinchan
    Private Sub Shinchan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Me.Size = shinchan_panel.Size
    End Sub
    Private Sub sc_Add_btn_Click(sender As Object, e As EventArgs) Handles sc_Add_btn.Click
        sc_username_lbl.Text = user + " :"
        sc_user_review_output.Text = sc_user_review_txt.Text
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles sc_next_btn.Click
        sc_next_btn.Enabled = False
        shinchan_format_pnl.Visible = True
    End Sub

    Public Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles sc_vid_sc.Enter
        sc_vid_sc.URL = "D:\college projects\Movie booking\movie images\Shinchan\Shinchan_Trailer.mp4"
        sc_vid_sc.Ctlcontrols.play()
    End Sub

    Private Sub ply_btn_Click(sender As Object, e As EventArgs) Handles sc_ply_btn.Click
        Call AxWindowsMediaPlayer1_Enter(Nothing, Nothing)
        sc_vid_sc.Ctlcontrols.pause()
        If sc_ply_btn.Visible = True Then
            sc_vid_sc.Ctlcontrols.pause()
            sc_ply_btn.Visible = False
        ElseIf sc_ply_btn.Visible = False Then
            sc_vid_sc.Ctlcontrols.play()
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

    Private Sub sc_format_nxt_btn_Click(sender As Object, e As EventArgs) Handles sc_format_nxt_btn.Click
        movie1___Date1__.Pname.Text = "Shinchan: Mexico Cactus"
        TandC.Show()
        Me.Hide()
    End Sub

    Private Sub sc_btn_2d_CheckedChanged(sender As Object, e As EventArgs) Handles sc_btn_2d.CheckedChanged
        mode = "2D"
    End Sub

    Private Sub sc_btn_3d_CheckedChanged(sender As Object, e As EventArgs) Handles sc_btn_3d.CheckedChanged
        mode = "3D"
    End Sub
End Class