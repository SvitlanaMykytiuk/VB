Imports System.IO
Public Class Form1
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "CSV files (*.csv)|*.csv"

        If openFile.ShowDialog() = DialogResult.OK Then
            dgvSales.Rows.Clear()
            dgvSales.Columns.Clear()

            Dim lines() As String = File.ReadAllLines(openFile.FileName)

            ' Columns
            Dim headers() As String = lines(0).Split(","c)
            For Each header In headers
                dgvSales.Columns.Add(header, header)
            Next

            ' Rows
            For i As Integer = 1 To lines.Length - 1
                Dim values() As String = lines(i).Split(","c)
                dgvSales.Rows.Add(values)
            Next
        End If
    End Sub

    Private Sub btnAnalyse_Click(sender As Object, e As EventArgs) Handles btnAnalyse.Click

    End Sub


End Class
