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
		txtTask = New TextBox()
		cmbPriority = New ComboBox()
		btnAdd = New Button()
		btnDelete = New Button()
		lstTasks = New ListBox()
		btnFilter = New Button()
		SuspendLayout()
		' 
		' txtTask
		' 
		txtTask.Location = New Point(233, 42)
		txtTask.Name = "txtTask"
		txtTask.Size = New Size(150, 31)
		txtTask.TabIndex = 0
		' 
		' cmbPriority
		' 
		cmbPriority.FormattingEnabled = True
		cmbPriority.Location = New Point(220, 97)
		cmbPriority.Name = "cmbPriority"
		cmbPriority.Size = New Size(182, 33)
		cmbPriority.TabIndex = 1
		' 
		' btnAdd
		' 
		btnAdd.Location = New Point(252, 170)
		btnAdd.Name = "btnAdd"
		btnAdd.Size = New Size(112, 34)
		btnAdd.TabIndex = 2
		btnAdd.Text = "Add task"
		btnAdd.UseVisualStyleBackColor = True
		' 
		' btnDelete
		' 
		btnDelete.Location = New Point(252, 232)
		btnDelete.Name = "btnDelete"
		btnDelete.Size = New Size(112, 34)
		btnDelete.TabIndex = 3
		btnDelete.Text = "Delete Task"
		btnDelete.UseVisualStyleBackColor = True
		' 
		' lstTasks
		' 
		lstTasks.FormattingEnabled = True
		lstTasks.Location = New Point(566, 54)
		lstTasks.Name = "lstTasks"
		lstTasks.Size = New Size(180, 129)
		lstTasks.TabIndex = 4
		' 
		' btnFilter
		' 
		btnFilter.Location = New Point(482, 262)
		btnFilter.Name = "btnFilter"
		btnFilter.Size = New Size(224, 34)
		btnFilter.TabIndex = 5
		btnFilter.Text = "Filter High Priority"
		btnFilter.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(btnFilter)
		Controls.Add(lstTasks)
		Controls.Add(btnDelete)
		Controls.Add(btnAdd)
		Controls.Add(cmbPriority)
		Controls.Add(txtTask)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents txtTask As TextBox
	Friend WithEvents cmbPriority As ComboBox
	Friend WithEvents btnAdd As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents lstTasks As ListBox
	Friend WithEvents btnFilter As Button

End Class
