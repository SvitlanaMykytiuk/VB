<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		txtInput = New TextBox()
		txtAnalyze = New Button()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		Label6 = New Label()
		lblCharacters = New Label()
		lblWords = New Label()
		lblSentences = New Label()
		lblAverageLength = New Label()
		lblLongestWord = New Label()
		SuspendLayout()
		' 
		' txtInput
		' 
		txtInput.Location = New Point(102, 55)
		txtInput.Name = "txtInput"
		txtInput.Size = New Size(1227, 31)
		txtInput.TabIndex = 0
		' 
		' txtAnalyze
		' 
		txtAnalyze.Location = New Point(609, 122)
		txtAnalyze.Name = "txtAnalyze"
		txtAnalyze.Size = New Size(112, 34)
		txtAnalyze.TabIndex = 1
		txtAnalyze.Text = "Analyze"
		txtAnalyze.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(609, 9)
		Label1.Name = "Label1"
		Label1.Size = New Size(127, 25)
		Label1.TabIndex = 2
		Label1.Text = "Enter your text"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(509, 243)
		Label2.Name = "Label2"
		Label2.Size = New Size(157, 25)
		Label2.TabIndex = 3
		Label2.Text = "Number of words:"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(484, 401)
		Label3.Name = "Label3"
		Label3.Size = New Size(182, 25)
		Label3.TabIndex = 4
		Label3.Text = "Average word length:"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(479, 191)
		Label4.Name = "Label4"
		Label4.Size = New Size(187, 25)
		Label4.TabIndex = 5
		Label4.Text = "Number of characters:"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(516, 346)
		Label5.Name = "Label5"
		Label5.Size = New Size(154, 25)
		Label5.TabIndex = 6
		Label5.Text = "The longest word:"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(485, 295)
		Label6.Name = "Label6"
		Label6.Size = New Size(185, 25)
		Label6.TabIndex = 7
		Label6.Text = "Number of sentences:"
		' 
		' lblCharacters
		' 
		lblCharacters.AutoSize = True
		lblCharacters.Location = New Point(694, 191)
		lblCharacters.Name = "lblCharacters"
		lblCharacters.Size = New Size(0, 25)
		lblCharacters.TabIndex = 8
		' 
		' lblWords
		' 
		lblWords.AutoSize = True
		lblWords.Location = New Point(694, 243)
		lblWords.Name = "lblWords"
		lblWords.Size = New Size(0, 25)
		lblWords.TabIndex = 10
		' 
		' lblSentences
		' 
		lblSentences.AutoSize = True
		lblSentences.Location = New Point(694, 295)
		lblSentences.Name = "lblSentences"
		lblSentences.Size = New Size(0, 25)
		lblSentences.TabIndex = 11
		' 
		' lblAverageLength
		' 
		lblAverageLength.AutoSize = True
		lblAverageLength.Location = New Point(694, 401)
		lblAverageLength.Name = "lblAverageLength"
		lblAverageLength.Size = New Size(0, 25)
		lblAverageLength.TabIndex = 12
		' 
		' lblLongestWord
		' 
		lblLongestWord.AutoSize = True
		lblLongestWord.Location = New Point(694, 346)
		lblLongestWord.Name = "lblLongestWord"
		lblLongestWord.Size = New Size(0, 25)
		lblLongestWord.TabIndex = 13
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(1366, 480)
		Controls.Add(lblLongestWord)
		Controls.Add(lblAverageLength)
		Controls.Add(lblSentences)
		Controls.Add(lblWords)
		Controls.Add(lblCharacters)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(txtAnalyze)
		Controls.Add(txtInput)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents txtInput As TextBox
	Friend WithEvents txtAnalyze As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents lblCharacters As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents lblWords As Label
	Friend WithEvents lblSentences As Label
	Friend WithEvents lblAverageLength As Label
	Friend WithEvents lblLongestWord As Label

End Class
