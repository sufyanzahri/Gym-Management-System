Public Class AllPaymentsForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()

    End Sub

    Private Sub AllPaymentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllPaymentsDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.AllPaymentsDataSet.Payment)

        Me.Location = New Point(450, 100)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Column looping calculation
        Dim decTotal As Decimal = 0
        Dim row As AllPaymentsDataSet.PaymentRow
        For Each row In Me.AllPaymentsDataSet.Payment.Rows
            decTotal += row.Amount
        Next
        MessageBox.Show("Total Recorded sales are: " &
        decTotal.ToString("c"), "Total")
    End Sub

    'save button handling
    Private Sub btnSave_Click(sender As Object, e As EventArgs) 

    End Sub

    'delete button handling
    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class