Module login
    Public user As String = "user416"
    Public mode As String
End Module
Public Class LogInForm


    Private Sub Buttonlogin_Click_1(sender As Object, e As EventArgs) Handles Buttonlogin.Click
        If Textusername.Text = user And textpassword.Text = "12345" Then
            Dim password As String = textpassword.Text
            MainMenu.Show()
            MainMenu.switchPanel(NowShowingForm)
            MainMenu.HighlightMain.Visible = True
            MainMenu.HighlightGenre.Visible = False
            MainMenu.HighlightBeverages.Visible = False
            MainMenu.HighlightScreen.Visible = False

            Me.Hide()
        Else
            MessageBox.Show("Wrong Credentials")

        End If

    End Sub

    Private Sub textpassword_TextChanged(sender As Object, e As EventArgs) Handles textpassword.TextChanged

        textpassword.PasswordChar = "*"
    End Sub

End Class
