Public Class Form1


    Private Sub txtNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            ResultNumberInfo()
            e.SuppressKeyPress = True ' щоб не чути “дзвінок” при Enter
        End If
    End Sub
    Private Sub ResultNumberInfo()
        Dim Number As Integer
        If Not Integer.TryParse(txtNumber.Text, Number) Then
            MessageBox.Show("Enter korrect number!")
            Return
        End If

        Dim Result As String = ""

        If Number Mod 2 = 0 Then
            Result &= "Even" & vbCrLf
        Else
            Result &= "Odd" & vbCrLf
        End If

        If Number < 0 Then
            Result &= "Negatige" & vbCrLf
        ElseIf Number > 0 Then
            Result &= "Positive" & vbCrLf
        Else
            Result &= "Zero" & vbCrLf
        End If

        If Number > 100 Then
            Result &= "Greater than 100" & vbCrLf
        Else
            Result &= "Lower than 100" & vbCrLf
        End If


        lblResult.Text = Result
        txtNumber.Text = ""

    End Sub

End Class


