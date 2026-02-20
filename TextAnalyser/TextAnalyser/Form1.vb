Public Class Form1
	Private Sub txtAnalyze_Click(sender As Object, e As EventArgs) Handles txtAnalyze.Click

		Dim text As String = txtInput.Text.Trim()

		If text = "" Then
			MessageBox.Show("Enter some text first")
			txtInput.Focus()
		End If

		'Кількість символів (без пробілів на початку/кінці)
		Dim characterCount As Integer = text.Length

		'Розбиваємо на слова
		Dim separators() As Char = {" "c, ControlChars.Cr, ControlChars.Lf, "."c, "!"c, "?"c, ";"c, ":"c}
		Dim words() As String = text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
		Dim wordCount As Integer = words.Length

		' Кількість речень
		Dim sentenceCount As Integer = text.Count(Function(c) c = "."c OrElse c = "!"c OrElse c = "?"c)

		'Пошук найдовшого слова
		Dim longestWord As String = ""
		For Each w In words
			If w.Length > longestWord.Length Then
				longestWord = w
			End If
		Next

		'Середня довжина слова
		Dim averageLength As Double = 0
		If wordCount > 0 Then
			averageLength = words.Average(Function(w) w.Length)
		End If

		'Вивід результатів
		lblCharacters.Text = characterCount
		lblWords.Text = wordCount
		lblSentences.Text = sentenceCount
		lblLongestWord.Text = longestWord
		lblAverageLength.Text = averageLength.ToString("F2")
	End Sub
End Class
