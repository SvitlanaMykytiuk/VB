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
		btnGenerate = New Button()
		txtCopy = New Button()
		Label1 = New Label()
		lblPassword = New Label()
		txtLength = New TextBox()
		chkUpper = New CheckBox()
		chkLower = New CheckBox()
		chkDigits = New CheckBox()
		chkSymbols = New CheckBox()
		lblStrength = New Label()
		btnReset = New Button()
		SuspendLayout()
		' 
		' btnGenerate
		' 
		btnGenerate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		btnGenerate.Location = New Point(319, 186)
		btnGenerate.Name = "btnGenerate"
		btnGenerate.Size = New Size(143, 55)
		btnGenerate.TabIndex = 0
		btnGenerate.Text = "Generate"
		btnGenerate.UseVisualStyleBackColor = True
		' 
		' txtCopy
		' 
		txtCopy.Location = New Point(549, 275)
		txtCopy.Name = "txtCopy"
		txtCopy.Size = New Size(112, 34)
		txtCopy.TabIndex = 1
		txtCopy.Text = "Copy"
		txtCopy.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(273, 34)
		Label1.Name = "Label1"
		Label1.Size = New Size(255, 25)
		Label1.TabIndex = 2
		Label1.Text = "Enter the number of characters"
		' 
		' lblPassword
		' 
		lblPassword.AutoSize = True
		lblPassword.Location = New Point(363, 284)
		lblPassword.Name = "lblPassword"
		lblPassword.Size = New Size(0, 25)
		lblPassword.TabIndex = 3
		lblPassword.TextAlign = ContentAlignment.MiddleCenter
		' 
		' txtLength
		' 
		txtLength.Location = New Point(320, 71)
		txtLength.Name = "txtLength"
		txtLength.Size = New Size(150, 31)
		txtLength.TabIndex = 4
		' 
		' chkUpper
		' 
		chkUpper.AutoSize = True
		chkUpper.Location = New Point(208, 124)
		chkUpper.Name = "chkUpper"
		chkUpper.Size = New Size(87, 29)
		chkUpper.TabIndex = 5
		chkUpper.Text = "Upper"
		chkUpper.UseVisualStyleBackColor = True
		' 
		' chkLower
		' 
		chkLower.AutoSize = True
		chkLower.Location = New Point(311, 124)
		chkLower.Name = "chkLower"
		chkLower.Size = New Size(85, 29)
		chkLower.TabIndex = 6
		chkLower.Text = "Lower"
		chkLower.UseVisualStyleBackColor = True
		' 
		' chkDigits
		' 
		chkDigits.AutoSize = True
		chkDigits.Location = New Point(417, 124)
		chkDigits.Name = "chkDigits"
		chkDigits.Size = New Size(84, 29)
		chkDigits.TabIndex = 7
		chkDigits.Text = "Digits"
		chkDigits.UseVisualStyleBackColor = True
		' 
		' chkSymbols
		' 
		chkSymbols.AutoSize = True
		chkSymbols.Location = New Point(507, 124)
		chkSymbols.Name = "chkSymbols"
		chkSymbols.Size = New Size(106, 29)
		chkSymbols.TabIndex = 8
		chkSymbols.Text = "Symbols"
		chkSymbols.UseVisualStyleBackColor = True
		' 
		' lblStrength
		' 
		lblStrength.AutoSize = True
		lblStrength.Location = New Point(363, 327)
		lblStrength.Name = "lblStrength"
		lblStrength.Size = New Size(0, 25)
		lblStrength.TabIndex = 9
		' 
		' btnReset
		' 
		btnReset.Location = New Point(336, 385)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(112, 34)
		btnReset.TabIndex = 10
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(btnReset)
		Controls.Add(lblStrength)
		Controls.Add(chkSymbols)
		Controls.Add(chkDigits)
		Controls.Add(chkLower)
		Controls.Add(chkUpper)
		Controls.Add(txtLength)
		Controls.Add(lblPassword)
		Controls.Add(Label1)
		Controls.Add(txtCopy)
		Controls.Add(btnGenerate)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents btnGenerate As Button
	Friend WithEvents txtCopy As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents lblPassword As Label
	Friend WithEvents txtLength As TextBox
	Friend WithEvents chkUpper As CheckBox
	Friend WithEvents chkLower As CheckBox
	Friend WithEvents chkDigits As CheckBox
	Friend WithEvents chkSymbols As CheckBox
	Friend WithEvents lblStrength As Label
	Friend WithEvents btnReset As Button

End Class
