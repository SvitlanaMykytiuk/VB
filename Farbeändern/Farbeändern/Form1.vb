Public Class Form1

    Private Sub txtColor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtColor.KeyDown
        If e.KeyCode = Keys.Enter Then
            ApplyColor()
            e.SuppressKeyPress = True
        End If

    End Sub
    Private Sub ApplyColor()
        Try
            Me.BackColor = Color.FromName(txtColor.Text)
            'txtColor.BackColor = Color.FromName(txtColor.Text)
            txtColor.BorderStyle = BorderStyle.FixedSingle
            lblMessage.Text = ""
            txtColor.Text = ""

        Catch ex As Exception
            lblMessage.Text = "Unknown color!"
            txtColor.Clear()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.BackColor = SystemColors.Control
    End Sub
End Class
