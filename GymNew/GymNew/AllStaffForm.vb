Public Class AllStaffForm
    Private Sub AllStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllStaffDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.AllStaffDataSet.Staff)
        Me.Location = New Point(450, 100)
    End Sub

    'closes window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    'Save button handling
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim updateMsg As Integer

        Dim updateComplete As Integer

        updateMsg = MessageBox.Show("Are you sure you want to update this Staff?", "Staff update", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If updateMsg = DialogResult.Yes Then

            updateComplete = MessageBox.Show("Staff successfully updated.", "Updated Staff", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.StaffTableAdapter.Update(Me.AllStaffDataSet.Staff)
        End If
    End Sub

    'Delete Button handling
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DeletionMsg As Integer

        Dim DeletionComplete As Integer

        DeletionMsg = MessageBox.Show("Are you sure you want to delete this Staff?", "Staff Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If DeletionMsg = DialogResult.Yes Then

            DeletionComplete = MessageBox.Show("Staff successfully deleted.", "Deleted Staff", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Validate()
            StaffBindingSource.RemoveCurrent()

            StaffBindingSource.EndEdit()
            StaffTableAdapter.Update(Me.AllStaffDataSet.Staff)
        End If
    End Sub
End Class