Public Class About


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Me.Hide()
        'SignIn.ShowDialog()
        'Me.Close()
        Dim formSignIn = New SignIn()
        SignIn.Show()
        Me.Close()
    End Sub
End Class