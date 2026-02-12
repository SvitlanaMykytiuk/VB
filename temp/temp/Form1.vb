Public Class Form1


    Private Sub txtCelsius_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCelsius.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConvertTemperature()
            e.SuppressKeyPress = True ' щоб не чути “дзвінок” при Enter
        End If
    End Sub

    Private Sub ConvertTemperature()
        Dim c As Double
        If Not Double.TryParse(txtCelsius.Text, c) Then
            MessageBox.Show("Enter korrect number!")
            Return
        End If

        Dim f As Double = c * 9 / 5 + 32
        lblResult.Text = c & "°C = " & f & "°F"
        txtCelsius.Text = ""
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCelsius.Text = "Enter Celsius"
        lblResult.Text = ""
    End Sub

End Class
