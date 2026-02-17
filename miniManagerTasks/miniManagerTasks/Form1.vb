Public Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Додаємо значення пріоритету у ComboBox
		cmbPriority.Items.Add("Low")
		cmbPriority.Items.Add("Medium")
		cmbPriority.Items.Add("High")
		cmbPriority.SelectedIndex = 0 ' за замовчуванням Low
	End Sub

	Private Sub txtTask_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTask.KeyDown
		If e.KeyCode = Keys.Enter Then
			AddTask()
			e.SuppressKeyPress = True
		End If
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		AddTask()
	End Sub

	Private Sub AddTask()
		If txtTask.Text <> "" Then
			Dim taskText As String = txtTask.Text & " (" & cmbPriority.SelectedItem.ToString() & ")"
			lstTasks.Items.Add(taskText)
			txtTask.Clear()
			txtTask.Focus()

			' Автоматично виділяємо останнє додане завдання
			lstTasks.SelectedIndex = lstTasks.Items.Count - 1
		Else
			MessageBox.Show("Please enter a task!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		If lstTasks.SelectedIndex <> -1 Then
			lstTasks.Items.RemoveAt(lstTasks.SelectedIndex)
		Else
			MessageBox.Show("Please select a task to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
		Dim highTasks As New List(Of String)

		For Each item As String In lstTasks.Items
			If item.Contains("(High)") Then
				highTasks.Add(item)
			End If
		Next

		If highTasks.Count > 0 Then
			lstTasks.Items.Clear()
			lstTasks.Items.AddRange(highTasks.ToArray())
		Else
			MessageBox.Show("No high priority tasks found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub
End Class
