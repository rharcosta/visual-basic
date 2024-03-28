Public Class Form

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click
        End
    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Txtnome.Clear()
        Txtaluno.Clear()
        Txtturma.Clear()
        Txtano.Clear()
        ComboBox1.Text = ""

    End Sub

    Private Sub Concatenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Concatenar.Click
        Resultado.Text = Txtnome.Text & " " & Txtaluno.Text
        'CHR: Código para pular linha
    End Sub

    
    Private Sub Cores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cores.Click

        FormEsco.BackColor = Color.Aquamarine

    End Sub
    
End Class
