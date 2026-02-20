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
		Label1 = New Label()
		Label2 = New Label()
		txtWeight = New TextBox()
		txtHeight = New TextBox()
		btnCalculate = New Button()
		lblResult = New Label()
		lblCategory = New Label()
		btnReset = New Button()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(148, 68)
		Label1.Name = "Label1"
		Label1.Size = New Size(195, 25)
		Label1.TabIndex = 0
		Label1.Text = "Enter your weight in kg"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(159, 218)
		Label2.Name = "Label2"
		Label2.Size = New Size(196, 25)
		Label2.TabIndex = 1
		Label2.Text = "Enter your height in cm"
		' 
		' txtWeight
		' 
		txtWeight.Location = New Point(157, 143)
		txtWeight.Name = "txtWeight"
		txtWeight.Size = New Size(150, 31)
		txtWeight.TabIndex = 2
		' 
		' txtHeight
		' 
		txtHeight.Location = New Point(166, 290)
		txtHeight.Name = "txtHeight"
		txtHeight.Size = New Size(150, 31)
		txtHeight.TabIndex = 3
		' 
		' btnCalculate
		' 
		btnCalculate.Location = New Point(556, 59)
		btnCalculate.Name = "btnCalculate"
		btnCalculate.Size = New Size(112, 34)
		btnCalculate.TabIndex = 4
		btnCalculate.Text = "Calculate"
		btnCalculate.UseVisualStyleBackColor = True
		' 
		' lblResult
		' 
		lblResult.AutoSize = True
		lblResult.Location = New Point(526, 145)
		lblResult.Name = "lblResult"
		lblResult.Size = New Size(0, 25)
		lblResult.TabIndex = 5
		' 
		' lblCategory
		' 
		lblCategory.AutoSize = True
		lblCategory.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblCategory.Location = New Point(556, 193)
		lblCategory.Name = "lblCategory"
		lblCategory.Size = New Size(0, 32)
		lblCategory.TabIndex = 6
		' 
		' btnReset
		' 
		btnReset.Location = New Point(641, 379)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(112, 34)
		btnReset.TabIndex = 7
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(btnReset)
		Controls.Add(lblCategory)
		Controls.Add(lblResult)
		Controls.Add(btnCalculate)
		Controls.Add(txtHeight)
		Controls.Add(txtWeight)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtWeight As TextBox
	Friend WithEvents txtHeight As TextBox
	Friend WithEvents btnCalculate As Button
	Friend WithEvents lblResult As Label
	Friend WithEvents lblCategory As Label
	Friend WithEvents btnReset As Button

End Class
