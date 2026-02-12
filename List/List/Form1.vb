Public Class Form1

    Dim attempts As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        attempts = 0
        LabelAttempts.Text = "Menge: " & attempts
    End Sub

    Private Sub txtTask_keyDown(sender As Object, e As KeyEventArgs) Handles txtTask.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtTask.Text <> "" Then
                lstTasks.Items.Add(txtTask.Text)
                txtTask.Clear()

                lstTasks.SelectedIndex = lstTasks.Items.Count - 1

                attempts += 1
                LabelAttempts.Text = "Menge: " & attempts

            Else MessageBox.Show("Enter task")
            End If
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstTasks.SelectedIndex <> -1 Then
            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex)
            attempts = Math.Max(0, attempts - 1)
            LabelAttempts.Text = "Menge: " & attempts
        Else
            MessageBox.Show("Choose task for deleting")

        End If
    End Sub
End Class
