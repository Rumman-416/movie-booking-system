Public Class The_Nun

    Private Sub The_Nun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Me.Size = nun_panel.Size
    End Sub

    Public Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs)
        vid_sc.URL = "D:\college projects\Movie booking\movie images\The nun\THE_NUN_-_Official_Teaser_Trailer_[HD](1080p).mp4"
        vid_sc.Ctlcontrols.play()
    End Sub

    Private Sub ply_btn_Click(sender As Object, e As EventArgs)
        Call AxWindowsMediaPlayer1_Enter(Nothing, Nothing)
        vid_sc.Ctlcontrols.pause()
        If ply_btn.Visible = True Then
            vid_sc.Ctlcontrols.pause()
            ply_btn.Visible = False
        ElseIf ply_btn.Visible = False Then
            vid_sc.Ctlcontrols.play()
        End If
    End Sub

    Sub switchPanel(ByVal panel As Form)
        nun_panel.Controls.Clear()
        panel.TopLevel = False
        nun_panel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub format_nxt_btn_Click(sender As Object, e As EventArgs)
        'nun_format_pnl.Enabled = False
        'nun_format_pnl.Visible = False
        'switchPanel(movie1___Date1__)
        movie1___Date1__.Show()
    End Sub


    Private Sub BackButton_Click_1(sender As Object, e As EventArgs) Handles BackButton.Click
        MainMenu.Show()
        MainMenu.switchPanel(NowShowingForm)
        MainMenu.HighlightMain.Visible = True
        MainMenu.HighlightGenre.Visible = False
        MainMenu.HighlightBeverages.Visible = False
        MainMenu.HighlightScreen.Visible = False
        Me.Hide()
    End Sub

    Private Sub next_btn_Click_1(sender As Object, e As EventArgs) Handles next_btn.Click
        next_btn.Enabled = False
        nun_format_pnl.Visible = True
    End Sub

    Private Sub Add_btn_Click_1(sender As Object, e As EventArgs) Handles Add_btn.Click
        username_lbl.Text = user + " :"
        user_review_output.Text = user_review_txt.Text
    End Sub

    Private Sub cross_Click(sender As Object, e As EventArgs) Handles cross.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub format_nxt_btn_Click_1(sender As Object, e As EventArgs) Handles format_nxt_btn.Click
        movie1___Date1__.Pname.Text = "The Nun"
        TandC.Show()
        Me.Hide()
    End Sub

    Private Sub btn_2d_CheckedChanged(sender As Object, e As EventArgs) Handles btn_2d.CheckedChanged
        mode = "2D"
    End Sub

    Private Sub btn_3d_CheckedChanged(sender As Object, e As EventArgs) Handles btn_3d.CheckedChanged
        mode = "3D"
    End Sub


End Class
