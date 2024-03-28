Public Class FrmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ((TextBox1.Text = "nome") And (TextBox2.Text = "123")) Then
            Me.Hide()
            FrmPrin.Show()
        Else
            MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If

    End Sub

    Private Sub FrmLogin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub
End Class