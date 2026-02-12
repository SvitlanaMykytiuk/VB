Public Class Form1

	Dim rnd As New Random()


	Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim count As Integer = 1
        If Not Integer.TryParse(txtCount.Text, count) Then
            MessageBox.Show("Enter a valid number")
            txtCount.Text = "1"
            count = 1
        End If

        lstHistory.Items.Clear() ' Очищаємо попередню історію

        For i As Integer = 1 To count
            Dim r As Integer = rnd.Next(0, 256)
            Dim g As Integer = rnd.Next(0, 256)
            Dim b As Integer = rnd.Next(0, 256)

            Dim color As Color = Color.FromArgb(r, g, b)

            ' Відображаємо колір у Label
            lblColor.BackColor = color
            lblColor.Text = $"RGB: {r}, {g}, {b}"

            ' Додаємо до історії
            lstHistory.Items.Add($"#{r:X2}{g:X2}{b:X2} - RGB({r},{g},{b})")
        Next

    End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		lblColor.BackColor = SystemColors.Control
		lblColor.Text = "Your color:"
		lstHistory.Items.Clear()
		txtCount.Text = "1"
	End Sub


End Class
