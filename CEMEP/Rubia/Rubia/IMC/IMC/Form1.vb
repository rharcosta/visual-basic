Public Class Imc
    Dim Peso As Integer
    Dim Altura As Double
    Dim Resultado As Double
    Dim Nome As String

    Private Sub Imc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Peso = 0
        Altura = 0

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Nome = TextBox1.Text
        Peso = TextBox2.Text
        Altura = TextBox3.Text
        Resultado = Peso / (Altura * Altura)
        TextBox4.Text = Format(Resultado, "###,##0.00")



        If (Resultado < 20) Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            TextBox5.Visible = True
            TextBox6.Visible = False
            TextBox7.Visible = False
            TextBox8.Visible = False

        End If

        If ((Resultado > 20) And (Resultado < 25)) Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = True
            TextBox7.Visible = False
            TextBox8.Visible = False
        End If

        If ((Resultado > 25) And (Resultado < 27)) Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = True
            TextBox8.Visible = False
        End If

        If (Resultado > 27) Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = True
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
            TextBox8.Visible = True
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim resp As Integer
        resp = MsgBox("Deseja sair?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Sair")
        If (resp = vbYes) Then
            End
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox1.Focus()
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
    End Sub

    Private Sub Imc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{Tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        On Error GoTo Peso_Errado
        Peso = TextBox2.Text
        TextBox2.Text = Peso
Peso_Errado:
        If Err.Number = 13 Then
            MsgBox("Peso inválido", MsgBoxStyle.Exclamation, "Aviso")
            TextBox2.Text = InputBox("Informe o valor correto do peso", "Peso:")
            Resume
        End If

    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        On Error GoTo Altura_Errado
        Altura = TextBox3.Text
        TextBox3.Text = Altura
Altura_Errado:
        If Err.Number = 13 Then
            MsgBox("Altura inválido", MsgBoxStyle.Exclamation, "Aviso")
            TextBox3.Text = InputBox("Informe o valor correto da altura", "Altura:")
            Resume
        End If

    End Sub
    
  
End Class
