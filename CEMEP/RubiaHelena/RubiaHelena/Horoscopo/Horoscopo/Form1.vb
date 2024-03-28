Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value < ProgressBar1.Maximum) Then
            ProgressBar1.Increment(2)
            Label1.Text = "Carregando " & ProgressBar1.Value & "%"
        Else
            Timer1.Stop()
            Me.Hide()
            LoginForm1.Show()

        End If
    End Sub
End Class
