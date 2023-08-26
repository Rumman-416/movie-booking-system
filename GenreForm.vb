Public Class GenreForm
    Private Sub GenreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
    End Sub
    Private Sub Hmovie1_Click_1(sender As Object, e As EventArgs) Handles Hmovie1.Click
        The_Nun.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        saw.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Radhe.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        poster_boys.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Shinchan.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        suzume.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Titanic.Show()
        MainMenu.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Lallu.Show()
        MainMenu.Hide()
    End Sub

    Private Sub MoviePoster_Click_1(sender As Object, e As EventArgs) Handles MoviePoster.Click
        pathan.Show()
        MainMenu.Hide()
    End Sub
End Class