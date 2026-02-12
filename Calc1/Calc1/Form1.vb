Imports System.Reflection.Emit

Public Class Form1
    Dim firstNumber As Double = 0
    Dim secondNumber As Double = 0
    Dim operation As String = ""
    Dim newInput As Boolean = True

    Private Sub ButtonNumber_Click(sender As Object, e As EventArgs) _
    Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click,
            Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click

        Dim btn As Button = CType(sender, Button)

        If TextBox1.Text = "0" OrElse newInput Then
            TextBox1.Text = btn.Text
            newInput = False
        Else
            TextBox1.Text &= btn.Text
        End If

        If operation = "" Then
            Label2.Text = TextBox1.Text
        Else
            Label2.Text = firstNumber & " " & operation & " " & TextBox1.Text
        End If

    End Sub

    Private Sub ButtonOp_Click(sender As Object, e As EventArgs) _
    Handles ButtonAdd.Click, ButtonSub.Click, ButtonMul.Click, ButtonDiv.Click

        firstNumber = Double.Parse(TextBox1.Text)
        Dim btn As Button = CType(sender, Button)
        operation = btn.Text
        newInput = True

        Label2.Text = firstNumber & " " & operation
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        secondNumber = Double.Parse(TextBox1.Text)
        Dim result As Double = 0

        Select Case operation
            Case "+"
                result = firstNumber + secondNumber
            Case "-"
                result = firstNumber - secondNumber
            Case "*"
                result = firstNumber * secondNumber
            Case "/"
                If secondNumber = 0 Then
                    TextBox1.Text = "Error: division by zero"
                    newInput = True
                    Exit Sub
                End If
                result = firstNumber / secondNumber
        End Select

        Label2.Text = firstNumber & " " & operation & " " & secondNumber & " = " & result
        TextBox1.Text = result
        firstNumber = result
        newInput = True

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox1.Text = "0"
        firstNumber = 0
        secondNumber = 0
        operation = ""
        newInput = True
    End Sub


End Class
