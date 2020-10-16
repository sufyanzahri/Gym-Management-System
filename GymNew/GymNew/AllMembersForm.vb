Public Class AllMembersForm
    Private Sub AllMembersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllMembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.AllMembersDataSet.Members)

        Me.Location = New Point(450, 100)

    End Sub

    'cancels edit and close window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    'Save button handling
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim updateMsg As Integer

        Dim updateComplete As Integer

        updateMsg = MessageBox.Show("Are you sure you want to update this Member?", "Member update", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If updateMsg = DialogResult.Yes Then

            updateComplete = MessageBox.Show("Member successfully updated.", "Updated Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.MembersTableAdapter.Update(Me.AllMembersDataSet.Members)

        End If
    End Sub

    'Delete button handling
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DeletionMsg As Integer

        Dim DeletionComplete As Integer

        DeletionMsg = MessageBox.Show("Are you sure you want to delete this Member?", "Member Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If DeletionMsg = DialogResult.Yes Then

            DeletionComplete = MessageBox.Show("Member successfully deleted.", "Deleted Member", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Validate()
            MembersBindingSource.RemoveCurrent()

            MembersBindingSource.EndEdit()
            MembersTableAdapter.Update(Me.AllMembersDataSet.Members)
        End If

    End Sub


End Class