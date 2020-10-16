Public Class AddStaffForm

    Private Sub AddStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllStaffDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffBindingSource.AddNew()
        Date_JoinedDateTimePicker.Value = Today()
        Me.Location = New Point(450, 100)


    End Sub

    'Update table adapter
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AllStaffDataSet)

    End Sub

    'Cancel edit and closes window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.StaffBindingSource.CancelEdit()
        Me.Hide()
    End Sub

    'save button 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim errorCheck As Boolean = True
        Dim strName, strDate As String
        Dim intPhone As Integer


        'Staff Error handling
        If String.IsNullOrEmpty(Staff_NameTextBox.Text) Or String.IsNullOrEmpty(Staff_PositionTextBox.Text) _
            Or String.IsNullOrEmpty(PhoneTextBox.Text) Or String.IsNullOrEmpty(AddressTextBox.Text) Then
            MessageBox.Show("Please Fill in the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            errorCheck = False
        End If

        'if no errors, insert data
        If errorCheck = True Then
            StaffTableAdapter.Insert(Staff_NameTextBox.Text, Staff_PositionTextBox.Text, PhoneTextBox.Text, AddressTextBox.Text, Date_JoinedDateTimePicker.Value)
            MessageBox.Show("Staff added!", "Confirmed")
            Clear()

        End If


    End Sub

    'Call the clear procedure
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub


    'Procedure to clear all fields
    Sub Clear()
        Staff_NameTextBox.Clear()
        Staff_PositionTextBox.Clear()
        PhoneTextBox.Clear()
        AddressTextBox.Clear()

    End Sub

    'x pakai-------------
    Private Sub btnAddMember_Click(sender As Object, e As EventArgs)
        Try
            Me.StaffBindingSource.EndEdit()
            Me.StaffTableAdapter.Update(AllStaffDataSet.Staff)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        MessageBox.Show("Staff has been added", "Add Staff")
    End Sub
End Class