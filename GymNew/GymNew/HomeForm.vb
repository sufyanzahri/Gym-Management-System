Public Class HomeForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit() 'me.close

    End Sub

    'minimizes home form
    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'displays current date and time
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Now, "dd-MM-yyyy hh:mm:ss tt")
    End Sub

    'uh
    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        'Loginform.show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnViewMember.Click
        ' Create an instance of AllMembersForm
        Dim frmAllMembers As New AllMembersForm
        ' Display the form.
        frmAllMembers.ShowDialog()
    End Sub

    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        ' Create an instance of AddMemberForm
        Dim frmAddMember As New AddMemberForm
        ' Display the form.
        frmAddMember.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        ' Create an instance of AllPaymentsForm
        Dim frmPaymentsAll As New AllPaymentsForm
        ' Display the form.
        frmPaymentsAll.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Create an instance of AddStaffForm
        Dim frmAddStaff As New AddStaffForm
        ' Display the form.
        frmAddStaff.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Create an instance of AllStaffForm
        Dim frmAllStaff As New AllStaffForm
        ' Display the form.
        frmAllStaff.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Create an instance of AddPaymentForm
        Dim frmAddPayment As New AddPaymentForm
        ' Display the form.
        frmAddPayment.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create an instance of FindMemberForm
        Dim frmFindMember As New FindMemberForm
        ' Display the form.
        frmFindMember.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ' Create an instance of FindStaffsForm
        Dim frmFindStaff As New FindStaffsForm
        ' Display the form.
        frmFindStaff.ShowDialog()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frmSignin As New SignIn
        frmSignin.Show()
        Me.Close()
    End Sub






    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Create an instance of ReceiptForm
        Dim frmReceipt As New ReceiptForm
        'Display the form
        frmReceipt.ShowDialog()

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs)


    End Sub

End Class
