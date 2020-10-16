
Public Class AddMemberForm

    Private Sub AddMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MembersBindingSource.AddNew()
        Date_JoinedDateTimePicker.Value = Today()


        Me.Location = New Point(450, 100)
    End Sub

    'cancel edit and closes window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.MembersBindingSource.CancelEdit()
        Me.Hide()
    End Sub

    'update table adapter
    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AllMembersDataSet)

    End Sub

    'Numeric updown calculation
    Private Sub upDownMonths_ValueChanged(sender As Object, e As EventArgs) Handles upDownMonths.ValueChanged
        Const intFEES As Integer = 100
        Const intFEESHALF As Integer = 90
        Const intFEESANNUAL As Integer = 85

        Dim intTotal As Integer
        Dim errorCheck As Boolean = True
        ' intTotal = intFEES * upDownMonths.Value

        If upDownMonths.Value > 5 And upDownMonths.Value < 12 Then
            intTotal = intFEESHALF * upDownMonths.Value
        ElseIf upDownMonths.Value > 11 And upDownMonths.Value < 13 Then
            intTotal = intFEESANNUAL * upDownMonths.Value
        Else
            intTotal = intFEES * upDownMonths.Value
        End If
        Member_txtAmountOwed.Text = intTotal
        lblDateExpired.Text = Date_JoinedDateTimePicker.Value.AddMonths(upDownMonths.Value)

    End Sub

    'Determine expiry date
    Private Sub Date_JoinedDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_JoinedDateTimePicker.ValueChanged

        lblDateExpired.Text = Date_JoinedDateTimePicker.Value.AddMonths(upDownMonths.Value)

    End Sub

    'save button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim errorCheck As Boolean = True
        Dim strName, strDate As String
        Dim intPhone As Integer
        Dim dblAmount As Double


        'Member error handling
        If String.IsNullOrEmpty(Member_NameTextBox.Text) Or String.IsNullOrEmpty(lblDateExpired.Text) Or
            String.IsNullOrEmpty(PhoneTextBox.Text) Then
            MessageBox.Show("Please Fill in the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            errorCheck = False
        End If

        'if no errors, insert data
        If errorCheck = True Then
            MembersTableAdapter.Insert(Member_NameTextBox.Text, upDownMonths.Value, PhoneTextBox.Text, Date_JoinedDateTimePicker.Value, lblDateExpired.Text, Member_txtAmountOwed.Text)
            MessageBox.Show("Member added!", "Confirmed")
            Clear()
        End If


    End Sub

    'Call clear procedure
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()

    End Sub

    'Procedure to clear all fields
    Sub Clear()
        Member_NameTextBox.Clear()
        PhoneTextBox.Clear()
        upDownMonths.Value = 1
        lblDateExpired.Text = String.Empty
        Member_txtAmountOwed.Text = String.Empty

    End Sub

    'button unused
    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Try
            Me.MembersBindingSource.EndEdit()
            Me.MembersTableAdapter.Update(AllMembersDataSet.Members)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        MessageBox.Show("Member has been added", "Add Member")
    End Sub


End Class