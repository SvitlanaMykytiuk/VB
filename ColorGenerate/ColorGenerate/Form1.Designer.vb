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
		btnReset = New Button()
		lblColor = New Label()
		txtCount = New TextBox()
		lstHistory = New ListBox()
		SuspendLayout()
		' 
		' btnGenerate
		' 
		btnGenerate.Location = New Point(317, 23)
		btnGenerate.Name = "btnGenerate"
		btnGenerate.Size = New Size(112, 34)
		btnGenerate.TabIndex = 0
		btnGenerate.Text = "Generate"
		btnGenerate.UseVisualStyleBackColor = True
		' 
		' btnReset
		' 
		btnReset.Location = New Point(655, 384)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(112, 34)
		btnReset.TabIndex = 1
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = True
		' 
		' lblColor
		' 
		lblColor.BorderStyle = BorderStyle.FixedSingle
		lblColor.Location = New Point(317, 96)
		lblColor.Name = "lblColor"
		lblColor.Size = New Size(184, 38)
		lblColor.TabIndex = 2
		lblColor.Text = "Your color"
		' 
		' txtCount
		' 
		txtCount.Location = New Point(317, 157)
		txtCount.Name = "txtCount"
		txtCount.Size = New Size(150, 31)
		txtCount.TabIndex = 3
		txtCount.Text = "1"
		' 
		' lstHistory
		' 
		lstHistory.FormattingEnabled = True
		lstHistory.Location = New Point(175, 261)
		lstHistory.Name = "lstHistory"
		lstHistory.Size = New Size(474, 129)
		lstHistory.TabIndex = 4
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(lstHistory)
		Controls.Add(txtCount)
		Controls.Add(lblColor)
		Controls.Add(btnReset)
		Controls.Add(btnGenerate)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents btnGenerate As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents lblColor As Label
	Friend WithEvents txtCount As TextBox
	Friend WithEvents lstHistory As ListBox

End Class
