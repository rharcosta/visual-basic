Public Class Frnconcatenar

    Private Sub Btncomcatenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncomcatenar.Click
        Lblconcatenar.Text = Txtnome.Text & " " & Txtsobrenome.Text

    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Txtnome.Clear()
        Txtsobrenome.Clear()
        Lblconcatenar.Text = ""
        Txtnome.Focus()
    End Sub

    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click
        End
    End Sub

    Private Sub Cores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cores.Click
        Lblnome.BackColor = Color.BlueViolet
        Lblsobrenome.BackColor = Color.BlueViolet
        Lblnome.ForeColor = Color.Tomato
        Lblsobrenome.ForeColor = Color.Tomato
        Sair.BackColor = Color.White
        Limpar.BackColor = Color.White
        Btncomcatenar.BackColor = Color.White
        Cores.BackColor = Color.White






    End Sub
End Class

