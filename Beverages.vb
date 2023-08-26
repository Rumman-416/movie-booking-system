Module beveragesGlobal
    Public totalRs As Integer = 0
    Public h1 As Integer = 0
    Public h2 As Integer = 0
    Public h3 As Integer = 0
    Public h4 As Integer = 0
    Public h5 As Integer = 0
    Public h6 As Integer = 0
End Module
Public Class Beverages


    Private Sub Beverages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
    End Sub
    Private Sub text1_Click(sender As Object, e As EventArgs) Handles text1.Click
        Console.WriteLine(h1)

    End Sub

    Private Sub plus1_Click(sender As Object, e As EventArgs) Handles plus1.Click
        h1 = h1 + 1
        text1.Text = h1
        totalRs = totalRs + 310
        Total.Text = "Total = " & totalRs
    End Sub


    Private Sub minus1_Click(sender As Object, e As EventArgs) Handles minus1.Click
        If h1 >= 1 Then
            h1 = h1 - 1
            text1.Text = h1
            totalRs = totalRs - 310
            Total.Text = "Total = " & totalRs
        Else
            h1 = 0
        End If

    End Sub


    Private Sub plus2_Click(sender As Object, e As EventArgs) Handles plus2.Click
        h2 = h2 + 1
        text2.Text = h2
        totalRs = totalRs + 260
        Total.Text = "Total = " & totalRs
    End Sub


    Private Sub minus2_Click(sender As Object, e As EventArgs) Handles minus2.Click
        If h2 >= 1 Then
            h2 = h2 - 1
            text2.Text = h2
            totalRs = totalRs - 260
            Total.Text = "Total = " & totalRs
        Else
            h2 = 0
        End If

    End Sub

    Private Sub text2_Click(sender As Object, e As EventArgs) Handles text2.Click
        Console.WriteLine(h2)
    End Sub



    Private Sub plus3_Click(sender As Object, e As EventArgs) Handles plus3.Click
        h3 = h3 + 1
        text3.Text = h3
        totalRs = totalRs + 300
        Total.Text = "Total = " & totalRs
    End Sub


    Private Sub minus3_Click(sender As Object, e As EventArgs) Handles minus3.Click
        If h3 >= 1 Then
            h3 = h3 - 1
            text3.Text = h3
            totalRs = totalRs - 300
            Total.Text = "Total = " & totalRs
        Else
            h3 = 0
        End If

    End Sub

    Private Sub text3_Click(sender As Object, e As EventArgs) Handles text3.Click
        Console.WriteLine(h3)
    End Sub




    Private Sub plus4_Click(sender As Object, e As EventArgs) Handles plus4.Click
        h4 = h4 + 1
        text4.Text = h4
        totalRs = totalRs + 350
        Total.Text = "Total = " & totalRs
    End Sub


    Private Sub minus4_Click(sender As Object, e As EventArgs) Handles minus4.Click
        If h4 >= 1 Then
            h4 = h4 - 1
            text4.Text = h1
            totalRs = totalRs - 350
            Total.Text = "Total = " & totalRs
        Else
            h4 = 0
        End If

    End Sub

    Private Sub text4_Click(sender As Object, e As EventArgs) Handles text4.Click
        Console.WriteLine(h4)
    End Sub



    Private Sub plus5_Click(sender As Object, e As EventArgs) Handles plus5.Click
        h5 = h5 + 1
        text5.Text = h5
        totalRs = totalRs + 400
        Total.Text = "Total = " & totalRs
    End Sub


    Private Sub minus5_Click(sender As Object, e As EventArgs) Handles minus5.Click
        If h5 >= 1 Then
            h5 = h5 - 1
            text5.Text = h5
            totalRs = totalRs - 400
            Total.Text = "Total = " & totalRs
        Else
            h5 = 0
        End If

    End Sub

    Private Sub text5_Click(sender As Object, e As EventArgs) Handles text5.Click
        Console.WriteLine(h5)
    End Sub



    Private Sub plus6_Click(sender As Object, e As EventArgs) Handles plus6.Click
        h6 = h6 + 1
        text6.Text = h6
        totalRs = totalRs + 500
        Total.Text = "Total = " & totalRs
    End Sub


    Private Sub minus6_Click(sender As Object, e As EventArgs) Handles minus6.Click
        If h6 >= 1 Then
            h6 = h6 - 1
            text6.Text = h6
            totalRs = totalRs - 500
            Total.Text = "Total = " & totalRs
        Else
            h6 = 0
        End If

    End Sub

    Private Sub text6_Click(sender As Object, e As EventArgs) Handles text6.Click
        Console.WriteLine(h6)
    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click
        Console.Write(totalRs)
    End Sub

    Private Sub proceed_Click(sender As Object, e As EventArgs) Handles proceed.Click
        Beverages2.text1.Text = h1
        Beverages2.text2.Text = h2
        Beverages2.text3.Text = h3
        Beverages2.text4.Text = h4
        Beverages2.text5.Text = h5
        Beverages2.text6.Text = h6
        Beverages2.Total.Text = totalRs
    End Sub

    Private Sub skip_Click(sender As Object, e As EventArgs)
        totalRs = 0
        h1 = 0
        h2 = 0
        h3 = 0
        h4 = 0
        h5 = 0
        h6 = 0
        PaymentForm.Show()
        Me.Hide()
    End Sub

    Private Sub lessthan1movie1_Click(sender As Object, e As EventArgs) Handles lessthan1movie1.Click
        movie1___Date1__.Show()
        Me.Hide()
    End Sub
End Class