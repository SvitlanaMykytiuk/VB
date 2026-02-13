Public Class Form1

    Private Sub FForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCategory.Items.Add("Food")
        cmbCategory.Items.Add("Transport")
        cmbCategory.Items.Add("Rent")
        cmbCategory.Items.Add("Internet")
        cmbCategory.Items.Add("Mobile")
        cmbCategory.Items.Add("Kleidung")
        cmbCategory.Items.Add("Entertainment")
        cmbCategory.Items.Add("Other")

        cmbCategory.SelectedIndex = 0

        dgvExpenses.ColumnCount = 3
        dgvExpenses.Columns(0).Name = "Date"
        dgvExpenses.Columns(1).Name = "Category"
        dgvExpenses.Columns(2).Name = "Amount"

        dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtAmount.Text = "" Or Not IsNumeric(txtAmount.Text) Then
            MessageBox.Show("Enter valid amount")
            Exit Sub
        End If

        Dim amount As Decimal = Convert.ToDecimal(txtAmount.Text)

        dgvExpenses.Rows.Add(
        dtpDate.Value.ToShortDateString(),
        cmbCategory.Text,
        amount
        )

        CalculateTotal()
        txtAmount.Clear()

    End Sub

    Private Sub CalculateTotal()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvExpenses.Rows
            If row.Cells(2).Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells(2).Value)
            End If
        Next

        lblTotal.Text = "Total: " & total.ToString("0.00")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvExpenses.SelectedRows.Count > 0 Then
            dgvExpenses.Rows.RemoveAt(dgvExpenses.SelectedRows(0).Index)
            CalculateTotal()
        Else
            MessageBox.Show("Select a row to delete")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvExpenses.Rows.Count = 0 Then
            MessageBox.Show("No data to save")
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Text files (*.txt)|*.txt"
        sfd.Title = "Save expenses"

        If sfd.ShowDialog() = DialogResult.OK Then

            Using writer As New System.IO.StreamWriter(sfd.FileName, False, System.Text.Encoding.UTF8)

                writer.WriteLine("Date    Category    Amount")

                For Each row As DataGridViewRow In dgvExpenses.Rows
                    If Not row.IsNewRow Then
                        writer.WriteLine(
                        row.Cells(0).Value.ToString() & "    " &
                        row.Cells(1).Value.ToString() & "    " &
                        row.Cells(2).Value.ToString()
                    )
                    End If
                Next

            End Using

            MessageBox.Show("File saved successfully!")

        End If
    End Sub
End Class
