Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim savedUser As String = "admin"
        Dim savedPass As String = "Admin123"

        Dim inputUser As String = txtUserName.Text
        Dim inputPass As String = txtPassword.Text

        If inputUser = savedUser Then

            If inputPass = savedPass Then
                lblResult.Text = "Login succesfull"
                lblResult.ForeColor = Color.Green
            Else
                lblResult.Text = "Wrong password"
                lblResult.ForeColor = Color.Red
            End If

        Else
            lblResult.Text = "User not found"
            lblResult.ForeColor = Color.Red

        End If


    End Sub
End Class
