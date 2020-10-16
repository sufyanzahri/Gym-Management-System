Public Class SignIn
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'hides password
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub

    'toggle hidden password
    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    'check for login errors
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            MessageBox.Show("Welcome, admin", "Welcome")
            Dim HomePage = New HomeForm()
            HomeForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect username or password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class