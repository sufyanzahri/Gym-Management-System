Public Class FindMemberForm

    'Closes window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()


    End Sub

    Private Sub FindMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FindMembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.FindMembersDataSet.Members)
        Me.Location = New Point(450, 100)
    End Sub

    'Perform search using Member Name
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Perform a wildcard search for last name.
        ' Me.MembersTableAdapter.Fill(Me.FindMembersDataSet.Members, txtLastName.Text)
        Dim dv As DataView

        dv = New DataView(FindMembersDataSet.Tables(0), "Member_Name= '" & Me.txtLastName.Text & "' ", "Member_Name", DataViewRowState.CurrentRows)
        Me.dgvMembers.DataSource = dv
    End Sub


    'unused function
    Function lul()
        Dim temp As Integer = 0
        For i As Integer = 0 To dgvMembers.RowCount - 1
            For j As Integer = 0 To dgvMembers.ColumnCount - 1
                If dgvMembers.Rows(i).Cells(j).Value.ToString = txtLastName.Text Then
                    MsgBox("Item found")
                    temp = 1
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("Item not found")
        End If

        Dim query As String
        query = "SELECT ID, Member_Name, Phone, Date_Joined " _
        & "FROM Members WHERE Member_Name = '" & txtLastName.Text & "'"
    End Function

End Class