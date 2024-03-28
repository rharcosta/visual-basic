Public Class FrmGemeos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub FrmGemeos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = "Nome: " & Form3.TextBox1.Text
        Label6.Text = "Dia de  Nascimento: " & Form3.NumericUpDown1.Value
        Label7.Text = "Mes: " & Form3.Label6.Text
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://joaobidu.com.br/horoscopo/signos/previsao-gemeos/")
    End Sub
End Class