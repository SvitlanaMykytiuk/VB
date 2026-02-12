Public Class Form1
    Dim remainingSeconds As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If remainingSeconds > 0 Then
            remainingSeconds -= 1
            LabelTime.Text = remainingSeconds.ToString()
        Else
            Timer1.Stop()
            MessageBox.Show("Time is up!")
        End If
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If Integer.TryParse(TextBoxSeconds.Text, remainingSeconds) Then
            If remainingSeconds > 0 Then
                LabelTime.Text = remainingSeconds.ToString()
                Timer1.Start()
            Else
                MessageBox.Show("Enter a number greater than 0")
            End If
        Else
            MessageBox.Show("Enter a valid number")
        End If
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        Timer1.Stop()
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        Timer1.Stop()
        remainingSeconds = 0
        LabelTime.Text = "00"
        TextBoxSeconds.Text = ""
    End Sub
End Class
