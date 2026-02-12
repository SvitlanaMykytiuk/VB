Imports System.Reflection.Emit

Public Class Form1
    Dim attempts As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        attempts = 0
        Label1.Text = attempts
    End Sub


    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        attempts += 1
        Label1.Text = attempts
    End Sub
End Class
