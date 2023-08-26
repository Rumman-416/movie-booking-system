Public Class NowShowingForm
    Dim slideShow() As String = {"D:\college projects\Movie booking\Images\movie1.jpg", "D:\college projects\Movie booking\Images\movie2.jpg", "D:\college projects\Movie booking\Images\movie3.jpg", "D:\college projects\Movie booking\Images\movie4.jpg"}
    Dim ss As Integer = 0

    Private Sub NowShowingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile("D:\college projects\Movie booking\Images\movie1.jpg")
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ss = ss + 1
        If (ss >= slideShow.Length) Then
            ss = 0
            PictureBox1.Image = Image.FromFile(slideShow(ss))
        Else
            PictureBox1.Image = Image.FromFile(slideShow(ss))
        End If
    End Sub

    Sub switchPanel(ByVal panel As Form)
        NextNSPanel.Controls.Clear()
        panel.TopLevel = False
        NextNSPanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Nmovie1_Click_1(sender As Object, e As EventArgs)
        switchPanel(The_Nun)
    End Sub

    Private Sub Nmovie2_Click(sender As Object, e As EventArgs)
        switchPanel(suzume)
    End Sub

    Private Sub Nmovie1_Click(sender As Object, e As EventArgs) Handles Nmovie1.Click
        The_Nun.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Nmovie2_Click_1(sender As Object, e As EventArgs) Handles Nmovie2.Click
        suzume.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Nmovie3_Click(sender As Object, e As EventArgs) Handles Nmovie3.Click
        pathan.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Nmovie4_Click(sender As Object, e As EventArgs) Handles Nmovie4.Click
        Lallu.Show()
        MainMenu.Hide()
    End Sub
End Class