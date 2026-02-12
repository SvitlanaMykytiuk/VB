Public Class Form1
    Private Sub CalcNeustart_Click(sender As Object, e As EventArgs) Handles CalcNeustart.Click
        Try
            Dim processName As String = "calc"
            For Each p As Process In
                    Process.GetProcessesByName(processName)
                p.Kill()
            Next
            Process.Start(processName)

            MessageBox.Show("Usel-level service restarted successfully.", "Success")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try
    End Sub
End Class
