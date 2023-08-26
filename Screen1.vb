Module GlobalVarialbles
    Public selectedSeat As String = " "
    Public totalSeatPrice As Integer = 0

End Module
Public Class Screen1
    Dim isImage1 As Boolean = True
    Dim isImage2 As Boolean = True
    Dim isImage3 As Boolean = True
    Dim isImage4 As Boolean = True
    Dim isImage17 As Boolean = True
    Dim isImage5 As Boolean = True
    Dim isImage6 As Boolean = True
    Dim isImage7 As Boolean = True
    Dim isImage8 As Boolean = True
    Dim isImage108 As Boolean = True
    Dim isImage21 As Boolean = True
    Dim isImage18 As Boolean = True
    Dim isImage16 As Boolean = True
    Dim isImage13 As Boolean = True
    Dim isImage12 As Boolean = True
    Dim isImage107 As Boolean = True
    Dim isImage22 As Boolean = True
    Dim isImage25 As Boolean = True
    Dim isImage26 As Boolean = True
    Dim isImage34 As Boolean = True
    Dim isImage33 As Boolean = True
    Dim isImage32 As Boolean = True
    Dim isImage31 As Boolean = True
    Dim isImage27 As Boolean = True
    Dim isImage24 As Boolean = True
    Dim isImage23 As Boolean = True
    Dim isImage106 As Boolean = True
    Dim isImage35 As Boolean = True
    Dim isImage47 As Boolean = True
    Dim isImage46 As Boolean = True
    Dim isImage45 As Boolean = True
    Dim isImage44 As Boolean = True
    Dim isImage43 As Boolean = True
    Dim isImage42 As Boolean = True
    Dim isImage41 As Boolean = True
    Dim isImage40 As Boolean = True
    Dim isImage37 As Boolean = True
    Dim isImage36 As Boolean = True
    Dim isImage51 As Boolean = True
    Dim isImage52 As Boolean = True
    Dim isImage60 As Boolean = True
    Dim isImage57 As Boolean = True
    Dim isImage56 As Boolean = True
    Dim isImage55 As Boolean = True
    Dim isImage54 As Boolean = True
    Dim isImage53 As Boolean = True
    Dim isImage49 As Boolean = True
    Dim isImage104 As Boolean = True
    Dim isImage61 As Boolean = True
    Dim isImage64 As Boolean = True
    Dim isImage70 As Boolean = True
    Dim isImage69 As Boolean = True
    Dim isImage68 As Boolean = True
    Dim isImage67 As Boolean = True
    Dim isImage66 As Boolean = True
    Dim isImage63 As Boolean = True
    Dim isImage62 As Boolean = True
    Dim isImage99 As Boolean = True
    Dim isImage98 As Boolean = True
    Dim isImage85 As Boolean = True
    Dim isImage84 As Boolean = True
    Dim isImage83 As Boolean = True
    Dim isImage82 As Boolean = True
    Dim isImage81 As Boolean = True
    Dim isImage74 As Boolean = True
    Dim isImage76 As Boolean = True
    Dim isImage75 As Boolean = True
    Dim isImage95 As Boolean = True
    Dim isImage94 As Boolean = True
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage1 = Not isImage1
        Dim seat1 As String = "A4 "
        If isImage1 Then
            PictureBox1.Image = image1
            selectedSeat = selectedSeat.Replace("A4 ", "")
            totalSeatPrice = totalSeatPrice - 450
        Else
            PictureBox1.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 450

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage2 = Not isImage2
        Dim seat1 As String = "A5 "

        If isImage2 Then
            PictureBox2.Image = image1
            selectedSeat = selectedSeat.Replace("A5 ", "")
            totalSeatPrice = totalSeatPrice - 450
        Else
            PictureBox2.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 450
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage3 = Not isImage3
        Dim seat1 As String = "A6 "
        If isImage3 Then
            PictureBox3.Image = image1
            selectedSeat = selectedSeat.Replace("A6 ", "")
            totalSeatPrice = totalSeatPrice - 450
        Else
            PictureBox3.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 450
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage4 = Not isImage4
        Dim seat1 As String = "A7 "
        If isImage4 Then
            PictureBox4.Image = image1
            selectedSeat = selectedSeat.Replace("A7 ", "")
            totalSeatPrice = totalSeatPrice - 450
        Else
            PictureBox4.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 450
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage17 = Not isImage17
        Dim seat1 As String = "B4 "
        If isImage17 Then
            PictureBox17.Image = image1
            selectedSeat = selectedSeat.Replace("B4 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox17.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If totalSeatPrice > 0 Then
            'Beverages.proceed.Visible = True
            'Beverages.skip.Visible = True
            Beverages2.Show()
            Me.Hide()

        Else
            MessageBox.Show("Please select a seat")
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage5 = Not isImage5
        Dim seat1 As String = "A8 "
        If isImage5 Then
            PictureBox5.Image = image1
            selectedSeat = selectedSeat.Replace("A8 ", "")
            totalSeatPrice = totalSeatPrice - 450
        Else
            PictureBox5.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 450

        End If
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage6 = Not isImage6
        Dim seat1 As String = "A9 "
        If isImage6 Then
            PictureBox6.Image = image1
            selectedSeat = selectedSeat.Replace("A9 ", "")
            totalSeatPrice = totalSeatPrice - 450
        Else
            PictureBox6.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 450

        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage7 = Not isImage7
        Dim seat1 As String = "A10 "
        If isImage7 Then
            PictureBox7.Image = image1
            selectedSeat = selectedSeat.Replace("A10 ", "")
            totalSeatPrice = totalSeatPrice - 450
        Else
            PictureBox7.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 450

        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage8 = Not isImage8
        Dim seat1 As String = "A11 "
        If isImage8 Then
            PictureBox8.Image = image1
            selectedSeat = selectedSeat.Replace("A11 ", "")
            totalSeatPrice = totalSeatPrice - 450
        Else
            PictureBox8.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 450

        End If
    End Sub

    Private Sub PictureBox108_Click(sender As Object, e As EventArgs) Handles PictureBox108.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage108 = Not isImage108
        Dim seat1 As String = "B1 "
        If isImage108 Then
            PictureBox8.Image = image1
            selectedSeat = selectedSeat.Replace("B1 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox108.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage21 = Not isImage21
        Dim seat1 As String = "B2 "
        If isImage21 Then
            PictureBox21.Image = image1
            selectedSeat = selectedSeat.Replace("B2 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox21.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage18 = Not isImage18
        Dim seat1 As String = "B3 "
        If isImage18 Then
            PictureBox18.Image = image1
            selectedSeat = selectedSeat.Replace("B2 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox18.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage16 = Not isImage16
        Dim seat1 As String = "B5 "
        If isImage16 Then
            PictureBox16.Image = image1
            selectedSeat = selectedSeat.Replace("B5 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox16.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage13 = Not isImage13
        Dim seat1 As String = "B8 "
        If isImage13 Then
            PictureBox13.Image = image1
            selectedSeat = selectedSeat.Replace("B8 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox13.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage12 = Not isImage12
        Dim seat1 As String = "B9 "
        If isImage12 Then
            PictureBox12.Image = image1
            selectedSeat = selectedSeat.Replace("B9 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox12.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox107_Click(sender As Object, e As EventArgs) Handles PictureBox107.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage107 = Not isImage107
        Dim seat1 As String = "C1 "
        If isImage107 Then
            PictureBox107.Image = image1
            selectedSeat = selectedSeat.Replace("C1 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox107.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage22 = Not isImage22
        Dim seat1 As String = "C2 "
        If isImage22 Then
            PictureBox22.Image = image1
            selectedSeat = selectedSeat.Replace("C2 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox22.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage25 = Not isImage25
        Dim seat1 As String = "C3 "
        If isImage25 Then
            PictureBox25.Image = image1
            selectedSeat = selectedSeat.Replace("C3 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox25.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage26 = Not isImage26
        Dim seat1 As String = "C4 "
        If isImage26 Then
            PictureBox26.Image = image1
            selectedSeat = selectedSeat.Replace("C4 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox26.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage34 = Not isImage34
        Dim seat1 As String = "C5 "
        If isImage34 Then
            PictureBox34.Image = image1
            selectedSeat = selectedSeat.Replace("C5 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox34.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage33 = Not isImage33
        Dim seat1 As String = "C6 "
        If isImage33 Then
            PictureBox33.Image = image1
            selectedSeat = selectedSeat.Replace("C6 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox33.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage32 = Not isImage32
        Dim seat1 As String = "C7 "
        If isImage32 Then
            PictureBox32.Image = image1
            selectedSeat = selectedSeat.Replace("C7 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox32.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage31 = Not isImage31
        Dim seat1 As String = "C8 "
        If isImage31 Then
            PictureBox31.Image = image1
            selectedSeat = selectedSeat.Replace("C8 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox31.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If

    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage27 = Not isImage27
        Dim seat1 As String = "C12 "
        If isImage27 Then
            PictureBox27.Image = image1
            selectedSeat = selectedSeat.Replace("C12 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox27.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage24 = Not isImage24
        Dim seat1 As String = "C13 "
        If isImage24 Then
            PictureBox24.Image = image1
            selectedSeat = selectedSeat.Replace("C13 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox24.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage23 = Not isImage23
        Dim seat1 As String = "C14 "
        If isImage23 Then
            PictureBox23.Image = image1
            selectedSeat = selectedSeat.Replace("C14 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox23.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox106_Click(sender As Object, e As EventArgs) Handles PictureBox106.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage106 = Not isImage106
        Dim seat1 As String = "D1 "
        If isImage106 Then
            PictureBox106.Image = image1
            selectedSeat = selectedSeat.Replace("D1 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox106.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage35 = Not isImage35
        Dim seat1 As String = "D2 "
        If isImage35 Then
            PictureBox35.Image = image1
            selectedSeat = selectedSeat.Replace("D2 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox35.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage47 = Not isImage47
        Dim seat1 As String = "D5 "
        If isImage47 Then
            PictureBox47.Image = image1
            selectedSeat = selectedSeat.Replace("D5 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox47.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage46 = Not isImage46
        Dim seat1 As String = "D6 "
        If isImage46 Then
            PictureBox46.Image = image1
            selectedSeat = selectedSeat.Replace("D6 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox46.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage45 = Not isImage45
        Dim seat1 As String = "D7 "
        If isImage45 Then
            PictureBox45.Image = image1
            selectedSeat = selectedSeat.Replace("D7 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox45.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage44 = Not isImage44
        Dim seat1 As String = "D8 "
        If isImage44 Then
            PictureBox44.Image = image1
            selectedSeat = selectedSeat.Replace("D8 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox44.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage43 = Not isImage43
        Dim seat1 As String = "D9 "
        If isImage43 Then
            PictureBox43.Image = image1
            selectedSeat = selectedSeat.Replace("D9 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox43.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage42 = Not isImage42
        Dim seat1 As String = "D10 "
        If isImage42 Then
            PictureBox42.Image = image1
            selectedSeat = selectedSeat.Replace("D10 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox42.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage41 = Not isImage41
        Dim seat1 As String = "D11 "
        If isImage41 Then
            PictureBox41.Image = image1
            selectedSeat = selectedSeat.Replace("D11 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox41.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage40 = Not isImage40
        Dim seat1 As String = "D12 "
        If isImage40 Then
            PictureBox40.Image = image1
            selectedSeat = selectedSeat.Replace("D12 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox40.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage37 = Not isImage37
        Dim seat1 As String = "D13 "
        If isImage37 Then
            PictureBox37.Image = image1
            selectedSeat = selectedSeat.Replace("D13 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox37.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage36 = Not isImage36
        Dim seat1 As String = "D13 "
        If isImage36 Then
            PictureBox36.Image = image1
            selectedSeat = selectedSeat.Replace("D13 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox36.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage51 = Not isImage51
        Dim seat1 As String = "E3 "
        If isImage51 Then
            PictureBox51.Image = image1
            selectedSeat = selectedSeat.Replace("E3 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox51.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage52 = Not isImage52
        Dim seat1 As String = "E4 "
        If isImage52 Then
            PictureBox52.Image = image1
            selectedSeat = selectedSeat.Replace("E4 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox52.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox60_Click(sender As Object, e As EventArgs) Handles PictureBox60.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage60 = Not isImage60
        Dim seat1 As String = "E4 "
        If isImage60 Then
            PictureBox60.Image = image1
            selectedSeat = selectedSeat.Replace("E4 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox60.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox57_Click(sender As Object, e As EventArgs) Handles PictureBox57.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage57 = Not isImage57
        Dim seat1 As String = "E8 "
        If isImage57 Then
            PictureBox57.Image = image1
            selectedSeat = selectedSeat.Replace("E8 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox57.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage56 = Not isImage56
        Dim seat1 As String = "E9 "
        If isImage56 Then
            PictureBox56.Image = image1
            selectedSeat = selectedSeat.Replace("E9 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox56.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage55 = Not isImage55
        Dim seat1 As String = "E10 "
        If isImage55 Then
            PictureBox55.Image = image1
            selectedSeat = selectedSeat.Replace("E10 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox55.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage54 = Not isImage54
        Dim seat1 As String = "E11 "
        If isImage54 Then
            PictureBox54.Image = image1
            selectedSeat = selectedSeat.Replace("E11 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox54.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage53 = Not isImage53
        Dim seat1 As String = "E12 "
        If isImage53 Then
            PictureBox53.Image = image1
            selectedSeat = selectedSeat.Replace("E12 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox53.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage49 = Not isImage49
        Dim seat1 As String = "E14 "
        If isImage49 Then
            PictureBox49.Image = image1
            selectedSeat = selectedSeat.Replace("E14 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox49.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox104_Click(sender As Object, e As EventArgs) Handles PictureBox104.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage104 = Not isImage104
        Dim seat1 As String = "F1 "
        If isImage104 Then
            PictureBox104.Image = image1
            selectedSeat = selectedSeat.Replace("F1 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox104.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox61_Click(sender As Object, e As EventArgs) Handles PictureBox61.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage61 = Not isImage61
        Dim seat1 As String = "F2 "
        If isImage61 Then
            PictureBox61.Image = image1
            selectedSeat = selectedSeat.Replace("F2 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox61.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox64_Click(sender As Object, e As EventArgs) Handles PictureBox64.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage64 = Not isImage64
        Dim seat1 As String = "F3 "
        If isImage64 Then
            PictureBox64.Image = image1
            selectedSeat = selectedSeat.Replace("F3 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox64.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox70_Click(sender As Object, e As EventArgs) Handles PictureBox70.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage70 = Not isImage70
        Dim seat1 As String = "F8 "
        If isImage70 Then
            PictureBox70.Image = image1
            selectedSeat = selectedSeat.Replace("F8 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox70.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox69_Click(sender As Object, e As EventArgs) Handles PictureBox69.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage69 = Not isImage69
        Dim seat1 As String = "F9 "
        If isImage69 Then
            PictureBox69.Image = image1
            selectedSeat = selectedSeat.Replace("F9 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox69.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox68_Click(sender As Object, e As EventArgs) Handles PictureBox68.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage68 = Not isImage68
        Dim seat1 As String = "F10 "
        If isImage68 Then
            PictureBox68.Image = image1
            selectedSeat = selectedSeat.Replace("F10 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox68.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox67_Click(sender As Object, e As EventArgs) Handles PictureBox67.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage67 = Not isImage67
        Dim seat1 As String = "F11 "
        If isImage67 Then
            PictureBox67.Image = image1
            selectedSeat = selectedSeat.Replace("F11 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox67.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox66_Click(sender As Object, e As EventArgs) Handles PictureBox66.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage66 = Not isImage66
        Dim seat1 As String = "F12 "
        If isImage66 Then
            PictureBox66.Image = image1
            selectedSeat = selectedSeat.Replace("F12 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox66.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox63_Click(sender As Object, e As EventArgs) Handles PictureBox63.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage63 = Not isImage63
        Dim seat1 As String = "F13 "
        If isImage63 Then
            PictureBox63.Image = image1
            selectedSeat = selectedSeat.Replace("F13 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox63.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox62_Click(sender As Object, e As EventArgs) Handles PictureBox62.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage62 = Not isImage62
        Dim seat1 As String = "F14 "
        If isImage62 Then
            PictureBox62.Image = image1
            selectedSeat = selectedSeat.Replace("F14 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox62.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox99_Click(sender As Object, e As EventArgs) Handles PictureBox99.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage99 = Not isImage99
        Dim seat1 As String = "G1 "
        If isImage99 Then
            PictureBox99.Image = image1
            selectedSeat = selectedSeat.Replace("G1 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox99.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox98_Click(sender As Object, e As EventArgs) Handles PictureBox98.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage98 = Not isImage98
        Dim seat1 As String = "G3 "
        If isImage98 Then
            PictureBox98.Image = image1
            selectedSeat = selectedSeat.Replace("G3 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox98.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If

    End Sub

    Private Sub PictureBox85_Click(sender As Object, e As EventArgs) Handles PictureBox85.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage85 = Not isImage85
        Dim seat1 As String = "G4 "
        If isImage85 Then
            PictureBox85.Image = image1
            selectedSeat = selectedSeat.Replace("G4 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox85.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox84_Click(sender As Object, e As EventArgs) Handles PictureBox84.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage84 = Not isImage84
        Dim seat1 As String = "G5 "
        If isImage84 Then
            PictureBox84.Image = image1
            selectedSeat = selectedSeat.Replace("G5 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox84.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox83_Click(sender As Object, e As EventArgs) Handles PictureBox83.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage83 = Not isImage83
        Dim seat1 As String = "G6 "
        If isImage83 Then
            PictureBox83.Image = image1
            selectedSeat = selectedSeat.Replace("G6 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox83.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox82_Click(sender As Object, e As EventArgs) Handles PictureBox82.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage82 = Not isImage82
        Dim seat1 As String = "G7 "
        If isImage82 Then
            PictureBox82.Image = image1
            selectedSeat = selectedSeat.Replace("G7 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox82.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox81_Click(sender As Object, e As EventArgs) Handles PictureBox81.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage81 = Not isImage81
        Dim seat1 As String = "G8 "
        If isImage81 Then
            PictureBox81.Image = image1
            selectedSeat = selectedSeat.Replace("G8 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox81.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox77_Click(sender As Object, e As EventArgs) Handles PictureBox77.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage74 = Not isImage74
        Dim seat1 As String = "H7 "
        If isImage74 Then
            PictureBox74.Image = image1
            selectedSeat = selectedSeat.Replace("H7 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox74.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox76_Click(sender As Object, e As EventArgs) Handles PictureBox76.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage76 = Not isImage76
        Dim seat1 As String = "H8 "
        If isImage76 Then
            PictureBox76.Image = image1
            selectedSeat = selectedSeat.Replace("H8 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox76.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox75_Click(sender As Object, e As EventArgs) Handles PictureBox75.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage75 = Not isImage75
        Dim seat1 As String = "H9 "
        If isImage75 Then
            PictureBox75.Image = image1
            selectedSeat = selectedSeat.Replace("H9 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox75.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox74_Click(sender As Object, e As EventArgs) Handles PictureBox74.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage74 = Not isImage74
        Dim seat1 As String = "H10 "
        If isImage74 Then
            PictureBox74.Image = image1
            selectedSeat = selectedSeat.Replace("H10 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox74.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox95_Click(sender As Object, e As EventArgs) Handles PictureBox95.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage95 = Not isImage95
        Dim seat1 As String = "H12 "
        If isImage95 Then
            PictureBox95.Image = image1
            selectedSeat = selectedSeat.Replace("H12 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox95.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox94_Click(sender As Object, e As EventArgs) Handles PictureBox94.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage94 = Not isImage94
        Dim seat1 As String = "H13 "
        If isImage94 Then
            PictureBox94.Image = image1
            selectedSeat = selectedSeat.Replace("H13 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox94.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub cross_Click(sender As Object, e As EventArgs) Handles cross.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.WindowState = WindowState.Minimized
    End Sub

End Class
