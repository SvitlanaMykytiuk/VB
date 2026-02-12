Public Class Form1

    Dim seconds As Integer = 0
    Dim minutes As Integer = 0
    Dim hours As Integer = 0

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        seconds += 1

        If seconds = 60 Then
            seconds = 0
            minutes += 1
        End If

        If minutes = 60 Then
            minutes = 0
            hours += 1
        End If

        LabelTime.Text = hours.ToString("00") & ":" & minutes.ToString("00") & ":" & seconds.ToString("00")


    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Timer.Start()
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        Timer.Stop()
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        Timer.Stop()
        seconds = 0
        minutes = 0
        hours = 0
        LabelTime.Text = "00:00:00"
    End Sub


End Class
