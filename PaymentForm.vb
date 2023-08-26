Public Class PaymentForm
    Dim flag As Integer = 0
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Label10.Text = totalSeatPrice
        Label11.Text = totalRs
        Label12.Text = totalRs + totalSeatPrice
    End Sub

    Private Sub cross_Click(sender As Object, e As EventArgs) Handles cross.Click
        Me.Close()
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If IsNumeric(CVVTextBox.Text) And CVVTextBox.TextLength = 4 And IsNumeric(TextBox1.Text) And TextBox1.TextLength = 16 Then
            Me.Hide()
            TicketForm.Show()
        ElseIf CVVTextBox.Text = String.Empty Or TextBox1.Text = String.Empty Then
            MessageBox.Show("Fill the form ")
        ElseIf Not IsLettersOnly(TextBox4.Text) Then
            MessageBox.Show("Please enter only letters.")
        Else
            MessageBox.Show("Invalid information")
        End If


    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value.Date < DateTime.Today.Date Then
            MessageBox.Show("You cannot select a past date.")
            DateTimePicker1.Value = DateTime.Today
        End If
    End Sub

    Private Function IsLettersOnly(ByVal str As String) As Boolean
        For Each c As Char In str
            If Not Char.IsLetter(c) Then
                Return False
            End If
        Next
        Return True
    End Function


End Class