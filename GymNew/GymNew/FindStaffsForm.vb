Public Class FindStaffsForm

    'closes the window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()

    End Sub

    Private Sub FindStaffsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FindStaffsDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.FindStaffsDataSet.Staff)
        Me.Location = New Point(450, 100)
    End Sub

    'Perform search using Staff name
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim dv As DataView

        dv = New DataView(FindStaffsDataSet.Tables(0), "Staff_Name= '" & Me.txtLastName.Text & "' ", "Staff_Name", DataViewRowState.CurrentRows)
        Me.dgvMembers.DataSource = dv
    End Sub






End Class