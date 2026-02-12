Imports System.Net.Security

Public Class Form1


    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            ResultPassInfo()
            e.SuppressKeyPress = True
        End If

    End Sub


    Private Sub ResultPassInfo()
        Dim Password As String = txtPass.Text


        If Password = "" Then
            lblResult.Text = "Password cannot be empty"
            Label1.ForeColor = Color.Red
            lblResult.ForeColor = Color.Red

        Else
            Dim hasDigit As Boolean = False
            Dim hasUpper As Boolean = False

            For Each ch As Char In Password
                If Char.IsDigit(ch) Then
                    hasDigit = True
                End If

                If Char.IsUpper(ch) Then
                    hasUpper = True
                End If

            Next

            If Password.Length < 8 Then
                lblResult.Text = "Password is weak"
                Label1.ForeColor = Color.Red
                txtPass.Clear()
                txtPass.Focus()

            ElseIf Password.Length >= 8 And hasDigit And hasUpper Then
                lblResult.Text = "Password is strong"
                lblResult.ForeColor = Color.Green
                Label1.Text = ""

            Else
                lblResult.Text = "Password is Medium"
                Label1.Text = ""
                lblResult.ForeColor = Color.Orange


            End If

        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPass.Clear()
        txtPass.Focus()
        lblResult.Text = ""
        Label1.Text = "Enter Password"
        Label1.ForeColor = Color.Black
        lblResult.ForeColor = Color.Black
    End Sub
End Class

