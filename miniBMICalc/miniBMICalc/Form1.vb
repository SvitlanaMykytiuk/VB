Public Class Form1
	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


		Dim Weight As Double
		Dim Height As Double

		If Not Double.TryParse(txtWeight.Text, Weight) OrElse Weight < 2 OrElse Weight > 500 Then
			MessageBox.Show("Enter a valid weight between 2 and 500 kg.")
			txtWeight.Clear()
			txtWeight.Focus()
			Return
		End If

		If Not Double.TryParse(txtHeight.Text, Height) OrElse Height < 30 OrElse Height > 300 Then
			MessageBox.Show("Enter a valid height between 30 and 300 cm.")
			txtWeight.Clear()
			txtWeight.Focus()
			Return
		End If



		Dim BMI As Double = Weight / Math.Pow(Height / 100, 2)

		lblResult.Text = "Your BMI is: " & BMI.ToString("F2")

		If BMI < 18.5 Then
			lblCategory.Text = "Underweight"
			lblCategory.ForeColor = Color.Red
		ElseIf BMI < 25 Then
			lblCategory.Text = "Normal"
			lblCategory.ForeColor = Color.Green
		ElseIf BMI < 30 Then
			lblCategory.Text = "Overweight"
			lblCategory.ForeColor = Color.Orange
		Else
			lblCategory.Text = "Obese"
			lblCategory.ForeColor = Color.Violet
		End If

	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		txtWeight.Clear()
		txtHeight.Clear()
		lblResult.Text = ""
		lblCategory.Text = ""
		txtWeight.Focus()

	End Sub
End Class
