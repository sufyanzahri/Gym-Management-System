Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            LblDisplay.Text = "Initializing  System "
        ElseIf ProgressBar1.Value <= 30 Then
            LblDisplay.Text = "Loading all components"
        ElseIf ProgressBar1.Value <= 50 Then
            LblDisplay.Text = "Integrating Database"
        ElseIf ProgressBar1.Value <= 70 Then
            LblDisplay.Text = "Please Wait "
        ElseIf ProgressBar1.Value <= 100 Then
            LblDisplay.Text = " Welcome! "

            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                About.ShowDialog()
                Me.Close()
            End If

        End If
    End Sub
End Class