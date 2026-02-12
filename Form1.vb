Public Class Form1

    Dim firstNumber As Double
    Dim secondNumber As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            firstNumber = Double.Parse(InputBox("Enter first number"))
            secondNumber = Double.Parse(InputBox("Enter second number"))
        Catch
            MessageBox.Show("Error! Please enter correct numbers.")
            Me.Close() ' Закрываем программу, если ошибка
        End Try
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim result As Double
        result = firstNumber + secondNumber
        Label1.Text = "Result: " & result
    End Sub

    Private Sub ButtonSub_Click(sender As Object, e As EventArgs) Handles ButtonSub.Click
        Dim result As Double
        result = firstNumber - secondNumber
        Label1.Text = "Result: " & result
    End Sub
    Private Sub ButtonMul_Click(sender As Object, e As EventArgs) Handles ButtonMul.Click
        Dim result As Double
        result = firstNumber * secondNumber
        Label1.Text = "Result: " & result
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        Dim result As Double
        If secondNumber = 0 Then
            Label1.Text = "Error: division by zero"
            Exit Sub
        End If
        result = firstNumber / secondNumber
        Label1.Text = "Result: " & result
    End Sub
End Class
