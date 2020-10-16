Public Class ReceiptForm

    'View print preview button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnPrint.Hide() 'hides button for printing purposes
        comboID.Hide() 'hides combobox for printing purposes

        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
    End Sub

    'closes the window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()

    End Sub

    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllMembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.AllMembersDataSet.Members)
        lblTime.Text = Date.Today

    End Sub


End Class