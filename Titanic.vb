Public Class Titanic
    Private Sub Titanic_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Click
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Me.Size = Titanic_panel.Size
    End Sub

    Private Sub TT_Add_btn_Click(sender As Object, e As EventArgs) Handles TT_Add_btn.Click
        TT_username_lbl.Text = user + " :"
        TT_user_review_output.Text = TT_user_review_txt.Text
    End Sub

    Private Sub TT_next_btn_Click(sender As Object, e As EventArgs) Handles TT_next_btn.Click
        TT_next_btn.Enabled = False
        titanic_format_pnl.Visible = True
    End Sub
    Public Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles TT_vid_sc.Enter
        TT_vid_sc.URL = "D:\college projects\Movie booking\movie images\Titanic\Titanic_Trailer.mp4"
        TT_vid_sc.Ctlcontrols.play()
    End Sub

    Private Sub TT_ply_btn_Click(sender As Object, e As EventArgs) Handles TT_ply_btn.Click
        Call AxWindowsMediaPlayer1_Enter(Nothing, Nothing)
        TT_vid_sc.Ctlcontrols.pause()
        If TT_ply_btn.Visible = True Then
            TT_vid_sc.Ctlcontrols.pause()
            TT_ply_btn.Visible = False
        ElseIf TT_ply_btn.Visible = False Then
            TT_vid_sc.Ctlcontrols.play()
        End If
    End Sub
    Sub switchPanel(ByVal panel As Form)
        Titanic_panel.Controls.Clear()
        panel.TopLevel = False
        Titanic_panel.Controls.Add(panel)
        panel.Show()
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

    Private Sub cross_Click(sender As Object, e As EventArgs) Handles cross.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub TT_format_nxt_btn_Click(sender As Object, e As EventArgs) Handles TT_format_nxt_btn.Click
        movie1___Date1__.Pname.Text = "Titanic"
        TandC.Show()
        Me.Hide()
    End Sub

    Private Sub TT_btn_2d_CheckedChanged(sender As Object, e As EventArgs) Handles TT_btn_2d.CheckedChanged
        mode = "2D"
    End Sub

    Private Sub TT_btn_3d_CheckedChanged(sender As Object, e As EventArgs) Handles TT_btn_3d.CheckedChanged
        mode = "3D"
    End Sub
End Class