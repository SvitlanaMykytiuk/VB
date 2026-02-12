Public Class Form1
    Dim blink As Boolean = False

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        lblBlink.ForeColor = Color.Black
        If Timer1.Enabled Then
            Timer1.Stop()
            lblBlink.ForeColor = Color.Black
            lblBlink.BackColor = SystemColors.Control
            lblBlink.Visible = True
        Else
            Timer1.Start()
            lblBlink.ForeColor = Color.Red
            lblBlink.BackColor = Color.Yellow
        End If

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        blink = Not blink
        lblBlink.Visible = blink
    End Sub

End Class
