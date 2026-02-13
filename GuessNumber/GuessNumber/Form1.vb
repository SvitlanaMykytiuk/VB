Public Class Form1
    Dim secretNumber As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rnd As New Random()
        secretNumber = rnd.Next(1, 100)
    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles ButtonGuess.Click
        Dim guess As Integer

        If Integer.TryParse(TextBox1.Text, guess) Then
            If guess < secretNumber Then
                LabelResult.Text = "Too low!"
            ElseIf guess > secretNumber Then
                LabelResult.Text = "Too high!"
            Else
                LabelResult.Text = "Correct! You guessed it!"
            End If
        Else
            LabelResult.Text = "Enter a valid number!"
        End If
    End Sub

End Class
