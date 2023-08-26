
Public Class Screen2

    Dim isImage17 As Boolean = True
    Dim isImage9 As Boolean = True
    Dim isImage77 As Boolean = True
    Dim isImage8 As Boolean = True
    Dim isImage7 As Boolean = True
    Dim isImage6 As Boolean = True
    Dim isImage5 As Boolean = True
    Dim isImage4 As Boolean = True
    Dim isImage3 As Boolean = True
    Dim isImage2 As Boolean = True
    Dim isImage18 As Boolean = True
    Dim isImage76 As Boolean = True
    Dim isImage22 As Boolean = True
    Dim isImage25 As Boolean = True
    Dim isImage26 As Boolean = True
    Dim isImage81 As Boolean = True
    Dim isImage94 As Boolean = True
    Dim isImage97 As Boolean = True
    Dim isImage100 As Boolean = True
    Dim isImage106 As Boolean = True
    Dim isImage35 As Boolean = True
    Dim isImage80 As Boolean = True
    Dim isImage90 As Boolean = True
    Dim isImage91 As Boolean = True
    Dim isImage92 As Boolean = True
    Dim isImage99 As Boolean = True
    Dim isImage105 As Boolean = True
    Dim isImage48 As Boolean = True
    Dim isImage51 As Boolean = True
    Dim isImage52 As Boolean = True
    Dim isImage87 As Boolean = True
    Dim isImage88 As Boolean = True
    Dim isImage89 As Boolean = True
    Dim isImage64 As Boolean = True
    Dim isImage65 As Boolean = True
    Dim isImage78 As Boolean = True
    Dim isImage82 As Boolean = True
    Dim isImage83 As Boolean = True
    Dim isImage14 As Boolean = True
    Dim isImage15 As Boolean = True
    Dim isImage30 As Boolean = True
    Dim isImage29 As Boolean = True
    Dim isImage28 As Boolean = True
    Dim isImage27 As Boolean = True
    Dim isImage16 As Boolean = True
    Dim isImage31 As Boolean = True
    Dim isImage50 As Boolean = True
    Dim isImage46 As Boolean = True
    Dim isImage32 As Boolean = True
    Dim isImage44 As Boolean = True
    Dim isImage37 As Boolean = True
    Dim isImage36 As Boolean = True
    Dim isImage45 As Boolean = True
    Dim isImage49 As Boolean = True


    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage17 = Not isImage17
        Dim seat1 As String = "A1 "
        If isImage17 Then
            PictureBox17.Image = image1
            selectedSeat = selectedSeat.Replace("A1 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox17.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub


    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage9 = Not isImage9
        Dim seat1 As String = "A2 "
        If isImage9 Then
            PictureBox9.Image = image1
            selectedSeat = selectedSeat.Replace("A2 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox9.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox77_Click(sender As Object, e As EventArgs) Handles PictureBox77.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage77 = Not isImage77
        Dim seat1 As String = "A3 "
        If isImage77 Then
            PictureBox77.Image = image1
            selectedSeat = selectedSeat.Replace("A3 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox77.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage17 = Not isImage17
        Dim seat1 As String = "A4 "
        If isImage17 Then
            PictureBox1.Image = image1
            selectedSeat = selectedSeat.Replace("A4 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox1.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage8 = Not isImage8
        Dim seat1 As String = "A5 "
        If isImage8 Then
            PictureBox8.Image = image1
            selectedSeat = selectedSeat.Replace("A5 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox8.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage7 = Not isImage7
        Dim seat1 As String = "A6 "
        If isImage7 Then
            PictureBox7.Image = image1
            selectedSeat = selectedSeat.Replace("A6 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox7.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage6 = Not isImage6
        Dim seat1 As String = "A7 "
        If isImage6 Then
            PictureBox6.Image = image1
            selectedSeat = selectedSeat.Replace("A7 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox6.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

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
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox5.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage4 = Not isImage4
        Dim seat1 As String = "A9 "
        If isImage4 Then
            PictureBox4.Image = image1
            selectedSeat = selectedSeat.Replace("A9 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox4.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage3 = Not isImage3
        Dim seat1 As String = "A10 "
        If isImage3 Then
            PictureBox3.Image = image1
            selectedSeat = selectedSeat.Replace("A10 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox3.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage2 = Not isImage2
        Dim seat1 As String = "A11 "
        If isImage2 Then
            PictureBox2.Image = image1
            selectedSeat = selectedSeat.Replace("A11 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox2.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage18 = Not isImage18
        Dim seat1 As String = "B9 "
        If isImage18 Then
            PictureBox18.Image = image1
            selectedSeat = selectedSeat.Replace("B9 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox18.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox76_Click(sender As Object, e As EventArgs) Handles PictureBox76.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage76 = Not isImage76
        Dim seat1 As String = "B12 "
        If isImage76 Then
            PictureBox76.Image = image1
            selectedSeat = selectedSeat.Replace("B12 ", "")
            totalSeatPrice = totalSeatPrice - 350
        Else
            PictureBox76.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 350

        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage22 = Not isImage22
        Dim seat1 As String = "C3 "
        If isImage22 Then
            PictureBox22.Image = image1
            selectedSeat = selectedSeat.Replace("C3 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox22.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage25 = Not isImage25
        Dim seat1 As String = "C4 "
        If isImage25 Then
            PictureBox25.Image = image1
            selectedSeat = selectedSeat.Replace("C4 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox25.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage26 = Not isImage26
        Dim seat1 As String = "C5 "
        If isImage26 Then
            PictureBox26.Image = image1
            selectedSeat = selectedSeat.Replace("C5 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox26.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox81_Click(sender As Object, e As EventArgs) Handles PictureBox81.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage81 = Not isImage81
        Dim seat1 As String = "C9 "
        If isImage81 Then
            PictureBox81.Image = image1
            selectedSeat = selectedSeat.Replace("C9 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox81.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox94_Click(sender As Object, e As EventArgs) Handles PictureBox94.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage94 = Not isImage94
        Dim seat1 As String = "C10 "
        If isImage94 Then
            PictureBox94.Image = image1
            selectedSeat = selectedSeat.Replace("C10 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox94.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox97_Click(sender As Object, e As EventArgs) Handles PictureBox97.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage97 = Not isImage97
        Dim seat1 As String = "C13 "
        If isImage97 Then
            PictureBox97.Image = image1
            selectedSeat = selectedSeat.Replace("C13 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox97.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox100_Click(sender As Object, e As EventArgs) Handles PictureBox100.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage100 = Not isImage100
        Dim seat1 As String = "D1 "
        If isImage100 Then
            PictureBox100.Image = image1
            selectedSeat = selectedSeat.Replace("D1 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox100.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox106_Click(sender As Object, e As EventArgs) Handles PictureBox106.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage106 = Not isImage106
        Dim seat1 As String = "D2 "
        If isImage106 Then
            PictureBox106.Image = image1
            selectedSeat = selectedSeat.Replace("D2 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox106.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage35 = Not isImage35
        Dim seat1 As String = "D3 "
        If isImage35 Then
            PictureBox35.Image = image1
            selectedSeat = selectedSeat.Replace("D3 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox35.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox80_Click(sender As Object, e As EventArgs) Handles PictureBox80.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage80 = Not isImage80
        Dim seat1 As String = "D9 "
        If isImage80 Then
            PictureBox80.Image = image1
            selectedSeat = selectedSeat.Replace("D9 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox80.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox90_Click(sender As Object, e As EventArgs) Handles PictureBox90.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage90 = Not isImage90
        Dim seat1 As String = "D10 "
        If isImage90 Then
            PictureBox90.Image = image1
            selectedSeat = selectedSeat.Replace("D10 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox90.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox91_Click(sender As Object, e As EventArgs) Handles PictureBox91.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage91 = Not isImage91
        Dim seat1 As String = "D11 "
        If isImage91 Then
            PictureBox91.Image = image1
            selectedSeat = selectedSeat.Replace("D11 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox91.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox92_Click(sender As Object, e As EventArgs) Handles PictureBox92.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage92 = Not isImage92
        Dim seat1 As String = "D12 "
        If isImage92 Then
            PictureBox92.Image = image1
            selectedSeat = selectedSeat.Replace("D12 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox92.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox99_Click(sender As Object, e As EventArgs) Handles PictureBox99.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage99 = Not isImage99
        Dim seat1 As String = "E1 "
        If isImage99 Then
            PictureBox99.Image = image1
            selectedSeat = selectedSeat.Replace("E1 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox99.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox105_Click(sender As Object, e As EventArgs) Handles PictureBox105.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage105 = Not isImage105
        Dim seat1 As String = "E2 "
        If isImage105 Then
            PictureBox105.Image = image1
            selectedSeat = selectedSeat.Replace("E2 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox105.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage48 = Not isImage48
        Dim seat1 As String = "E3 "
        If isImage48 Then
            PictureBox48.Image = image1
            selectedSeat = selectedSeat.Replace("E3 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox48.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage51 = Not isImage51
        Dim seat1 As String = "E4 "
        If isImage51 Then
            PictureBox51.Image = image1
            selectedSeat = selectedSeat.Replace("E4 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox51.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage52 = Not isImage52
        Dim seat1 As String = "E5 "
        If isImage52 Then
            PictureBox52.Image = image1
            selectedSeat = selectedSeat.Replace("E5 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox52.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox87_Click(sender As Object, e As EventArgs) Handles PictureBox87.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage87 = Not isImage87
        Dim seat1 As String = "E11 "
        If isImage87 Then
            PictureBox87.Image = image1
            selectedSeat = selectedSeat.Replace("E11 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox87.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox88_Click(sender As Object, e As EventArgs) Handles PictureBox88.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage88 = Not isImage88
        Dim seat1 As String = "E12 "
        If isImage88 Then
            PictureBox88.Image = image1
            selectedSeat = selectedSeat.Replace("E12 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox88.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox89_Click(sender As Object, e As EventArgs) Handles PictureBox89.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage89 = Not isImage89
        Dim seat1 As String = "E13 "
        If isImage89 Then
            PictureBox89.Image = image1
            selectedSeat = selectedSeat.Replace("E13 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox89.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox64_Click(sender As Object, e As EventArgs) Handles PictureBox64.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage64 = Not isImage64
        Dim seat1 As String = "F4 "
        If isImage64 Then
            PictureBox64.Image = image1
            selectedSeat = selectedSeat.Replace("F4 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox64.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox65_Click(sender As Object, e As EventArgs) Handles PictureBox65.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage65 = Not isImage65
        Dim seat1 As String = "F5 "
        If isImage65 Then
            PictureBox65.Image = image1
            selectedSeat = selectedSeat.Replace("F5 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox65.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox78_Click(sender As Object, e As EventArgs) Handles PictureBox78.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage78 = Not isImage78
        Dim seat1 As String = "F9 "
        If isImage78 Then
            PictureBox78.Image = image1
            selectedSeat = selectedSeat.Replace("F9 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox78.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox82_Click(sender As Object, e As EventArgs) Handles PictureBox82.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage82 = Not isImage82
        Dim seat1 As String = "F10 "
        If isImage82 Then
            PictureBox82.Image = image1
            selectedSeat = selectedSeat.Replace("F10 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox82.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox83_Click(sender As Object, e As EventArgs) Handles PictureBox83.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage83 = Not isImage83
        Dim seat1 As String = "F11 "
        If isImage83 Then
            PictureBox83.Image = image1
            selectedSeat = selectedSeat.Replace("F11 ", "")
            totalSeatPrice = totalSeatPrice - 250
        Else
            PictureBox83.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 250

        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage14 = Not isImage14
        Dim seat1 As String = "G3 "
        If isImage14 Then
            PictureBox14.Image = image1
            selectedSeat = selectedSeat.Replace("G3 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox14.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage15 = Not isImage15
        Dim seat1 As String = "G4 "
        If isImage15 Then
            PictureBox15.Image = image1
            selectedSeat = selectedSeat.Replace("G4 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox15.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage30 = Not isImage30
        Dim seat1 As String = "G5 "
        If isImage30 Then
            PictureBox30.Image = image1
            selectedSeat = selectedSeat.Replace("G5 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox30.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage29 = Not isImage29
        Dim seat1 As String = "G6 "
        If isImage29 Then
            PictureBox29.Image = image1
            selectedSeat = selectedSeat.Replace("G6 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox29.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage28 = Not isImage28
        Dim seat1 As String = "G7 "
        If isImage28 Then
            PictureBox28.Image = image1
            selectedSeat = selectedSeat.Replace("G7 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox28.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage27 = Not isImage27
        Dim seat1 As String = "G8 "
        If isImage27 Then
            PictureBox27.Image = image1
            selectedSeat = selectedSeat.Replace("G8 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox27.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage16 = Not isImage16
        Dim seat1 As String = "G11 "
        If isImage16 Then
            PictureBox16.Image = image1
            selectedSeat = selectedSeat.Replace("G11 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox16.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage31 = Not isImage31
        Dim seat1 As String = "G12 "
        If isImage31 Then
            PictureBox31.Image = image1
            selectedSeat = selectedSeat.Replace("G12 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox31.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs) Handles PictureBox50.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage50 = Not isImage50
        Dim seat1 As String = "G13 "
        If isImage50 Then
            PictureBox50.Image = image1
            selectedSeat = selectedSeat.Replace("G13 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox50.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage46 = Not isImage46
        Dim seat1 As String = "H1 "
        If isImage46 Then
            PictureBox46.Image = image1
            selectedSeat = selectedSeat.Replace("H1 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox46.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage32 = Not isImage32
        Dim seat1 As String = "H2 "
        If isImage32 Then
            PictureBox32.Image = image1
            selectedSeat = selectedSeat.Replace("H2 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox32.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage44 = Not isImage44
        Dim seat1 As String = "H5 "
        If isImage44 Then
            PictureBox44.Image = image1
            selectedSeat = selectedSeat.Replace("H5 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox44.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage37 = Not isImage37
        Dim seat1 As String = "H10 "
        If isImage37 Then
            PictureBox37.Image = image1
            selectedSeat = selectedSeat.Replace("H10 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox37.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage36 = Not isImage36
        Dim seat1 As String = "H11 "
        If isImage36 Then
            PictureBox36.Image = image1
            selectedSeat = selectedSeat.Replace("H11 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox36.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage45 = Not isImage45
        Dim seat1 As String = "H12 "
        If isImage45 Then
            PictureBox45.Image = image1
            selectedSeat = selectedSeat.Replace("H12 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox45.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        Dim image1 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Grey Seat.png")
        Dim image2 As Image = Image.FromFile("D:\college projects\Movie booking\Images\Green.png")
        isImage49 = Not isImage49
        Dim seat1 As String = "H13 "
        If isImage49 Then
            PictureBox49.Image = image1
            selectedSeat = selectedSeat.Replace("H13 ", "")
            totalSeatPrice = totalSeatPrice - 150
        Else
            PictureBox49.Image = image2
            selectedSeat = selectedSeat + seat1
            totalSeatPrice = totalSeatPrice + 150

        End If
    End Sub

    Private Sub cross_Click(sender As Object, e As EventArgs) Handles cross.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.WindowState = WindowState.Minimized
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If totalSeatPrice > 0 Then
            Beverages2.Show()
            'Beverages.skip.Visible = True
            'Beverages.proceed.Visible = True
            Me.Hide()

        Else
            MessageBox.Show("Please select a seat")
        End If
    End Sub


End Class