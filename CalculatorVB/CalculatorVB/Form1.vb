Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Emit

Public Class Form1

    Dim firstNumber As Double
    Dim secondNumber As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            firstNumber = Double.Parse(InputBox("Enter first number"))
            secondNumber = Double.Parse(InputBox("Enter second number"))

        Catch
            MessageBox.Show("Error! Please enter correct numbers.")
            Me.Close()
        End Try
    End Sub

    If operation = "+" Then
                result = firstNumber + secondNumber
            ElseIf operation = "-" Then
                result = firstNumber - secondNumber
            ElseIf operation = "*" Then
                result = firstNumber * secondNumber
            ElseIf operation = "/" Then
                If secondNumber = 0 Then
                    MessageBox.Show("Error: division by zero")
                    Exit Sub
                End If
                result = firstNumber / secondNumber
            Else
                MessageBox.Show("Unknown operation")
                Exit Sub
            End If

            MessageBox.Show("Result: " & result)


    End Sub

End Class
