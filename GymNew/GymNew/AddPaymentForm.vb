Public Class AddPaymentForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllMembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.AllMembersDataSet.Members)
        'TODO: This line of code loads data into the 'AddPaymentDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentBindingSource.AddNew()
        Payment_DateDateTimePicker.Value = Today()

        Me.Location = New Point(450, 100)
    End Sub

    'closes window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()




    End Sub

    'update table adapter
    Private Sub PaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AddPaymentDataSet)

    End Sub

    'save button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim errorCheck As Boolean = True
        Dim strName, strDate As String
        Dim intPhone As Integer


        'Payment Error handling
        If String.IsNullOrEmpty(AmountTextBox.Text) Or String.IsNullOrEmpty(Member_IDTextBox.Text) Then
            MessageBox.Show("Please Fill in the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            errorCheck = False
        End If

        'if no errors, insert data
        If errorCheck = True Then
            Try
                Me.PaymentBindingSource.EndEdit()
                Me.PaymentTableAdapter.Update(AddPaymentDataSet.Payment)
                MessageBox.Show("Payment recorded", "Record Payment")
                Clear()
            Catch ex As Exception
                MessageBox.Show(Me, "Error: " & ex.Message, "Save",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try



        End If
    End Sub

    'x call clear procedure
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()

    End Sub

    'Clear fields procedure
    Sub Clear()
        Member_IDTextBox.Clear()
        AmountTextBox.Clear()
    End Sub


End Class