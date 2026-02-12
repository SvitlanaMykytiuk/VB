Imports System.Diagnostics
Imports System.IO

Public Class Form1

    'NOTEPAD
    Private Sub Notepad_Click(sender As Object, e As EventArgs) Handles Notepad.Click
        Notepad.Text = "Notepad. Clicked"
        Notepad.BackColor = Color.LightGray

        Try

            For Each p As Process In
                    Process.GetProcessesByName("notepad")
                p.Kill()
            Next
            Process.Start("notepad")
            'MessageBox.Show("Usel-level service restarted successfully.", "Success")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try
    End Sub

    Private Sub Notepad_MouseLeave(sender As Object, e As EventArgs) Handles Notepad.MouseLeave
        Notepad.Text = "notepad"
        Notepad.BackColor = Color.White
    End Sub


    'Calc
    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles Calc.Click
        Calc.Text = "Calc. Clicked"
        Calc.BackColor = Color.LightGray

        Try

            For Each p In
        Process.GetProcessesByName("calc")
                p.Kill()
            Next
            Process.Start("calc")
            'MessageBox.Show("Usel-level service restarted successfully.", "Success")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try
    End Sub

    Private Sub Calc_MouseLeave(sender As Object, e As EventArgs) Handles Calc.MouseLeave
        Calc.Text = "Calc"
        Calc.BackColor = Color.White
    End Sub


    'GOOGLE
    Private Sub Edge_Click(sender As Object, e As EventArgs) Handles Edge.Click
        Edge.Text = "Google. Clicked"
        Edge.BackColor = Color.LightGray

        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = "http://google.com"
            psi.UseShellExecute = True

            Process.Start(psi)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try
    End Sub
    Private Sub Edge_MouseLeave(sender As Object, e As EventArgs) Handles Edge.MouseLeave
        Edge.Text = "Google"
        Edge.BackColor = Color.White
    End Sub


    'ChatGPT
    Private Sub chatGPT_Click(sender As Object, e As EventArgs) Handles chatGPT.Click
        Edge.Text = "ChatGPT. Clicked"
        Edge.BackColor = Color.LightGray

        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = "http://chatgpt.com"
            psi.UseShellExecute = True

            Process.Start(psi)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try
    End Sub

    Private Sub chatGPT_MouseLeave(sender As Object, e As EventArgs) Handles chatGPT.MouseLeave
        chatGPT.Text = "chatGPT"
        chatGPT.BackColor = Color.White
    End Sub

    'FRAGE
    Private Sub Ask_Click_1(sender As Object, e As EventArgs) Handles Ask.Click
        Dim result As DialogResult

        result = MessageBox.Show("Weiter?",
                                 "Frage",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Erledigt")
        Else
            MessageBox.Show("Abgebrochen")
        End If




    End Sub

    Private Sub ShowText_Click(sender As Object, e As EventArgs) Handles ShowText.Click
        If TextInput.Text = "" Then
            MessageBox.Show("Bitte geben Sie einen Text ein")

        Else
            MessageBox.Show("Sie haben eingegeben: " & TextInput.Text)

        End If
    End Sub


End Class
