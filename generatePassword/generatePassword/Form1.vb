Public Class Form1

	Dim rnd As New Random()

	Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
		Dim length As Integer
		If Not Integer.TryParse(txtLength.Text, length) OrElse length <= 0 Then
			MessageBox.Show("Enter a valid number of length", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			txtLength.Clear()
			txtLength.Focus()
			Return

		End If

		Dim chars As String = ""
		If chkUpper.Checked Then chars &= "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
		If chkLower.Checked Then chars &= "abcdefghijklmnopqrstuvwxyz"
		If chkDigits.Checked Then chars &= "0123456789"
		If chkSymbols.Checked Then chars &= "!@#$%^&*()_+-=[]{}|;:,.<>?/"

		If chars = "" Then
			MessageBox.Show("Select at least one character type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If

		Dim password As String = ""
		For i As Integer = 1 To length
			password &= chars(rnd.Next(0, chars.Length))
		Next


		lblPassword.Text = password
		EvaluateStrength(password)

	End Sub

	Private Sub EvaluateStrength(pwd As String)
		Dim strenght As String = "Weak"
		Dim score As Integer = 0

		If pwd.Length >= 8 Then score += 1
		If pwd.Length >= 12 Then score += 1
		If System.Text.RegularExpressions.Regex.IsMatch(pwd, "[A-Z]") Then score += 1
		If System.Text.RegularExpressions.Regex.IsMatch(pwd, "[a-z]") Then score += 1
		If System.Text.RegularExpressions.Regex.IsMatch(pwd, "[0-9]") Then score += 1
		If System.Text.RegularExpressions.Regex.IsMatch(pwd, "[!@#$%^&*()_+\-=\[\]{}|;:,.<>?/]") Then score += 1

		Select Case score
			Case <= 2
				strenght = "Weak"
				lblStrength.ForeColor = Color.Red
			Case <= 4
				strenght = "Medium"
				lblStrength.ForeColor = Color.Orange
			Case Else
				strenght = "Strong"
				lblStrength.ForeColor = Color.Green
		End Select

	End Sub

	Private Sub txtCopy_Click(sender As Object, e As EventArgs) Handles txtCopy.Click
		If lblPassword.Text <> "" Then
			Clipboard.SetText(lblPassword.Text)
			MessageBox.Show("Password copied to clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		lblPassword.Text = ""
		txtLength.Clear()
		lblStrength.Text = ""
		chkUpper.Checked = True
		chkLower.Checked = True
		chkDigits.Checked = True
		chkSymbols.Checked = True
		txtLength.Focus()

	End Sub


End Class
