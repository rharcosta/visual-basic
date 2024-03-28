Public Class Form1
    Dim Nome As String
    Dim Horas, Tempo, Salario, Ad, Sal, Gratificacao As Decimal
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Sair")
        If (Resp = vbYes) Then
            End
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False

    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        On Error GoTo Hora_Errado
        Horas = TextBox2.Text
        TextBox2.Text = Horas
Hora_Errado:
        If Err.Number = 13 Then
            MsgBox("Hora inválida", MsgBoxStyle.Exclamation, "Aviso")
            TextBox2.Text = InputBox("Informe o valor correto da Hora/Mês", "Hora/Mês:")
            Resume
        End If
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        On Error GoTo Tempo_Errado
        Tempo = TextBox3.Text
        TextBox3.Text = Tempo
Tempo_Errado:
        If Err.Number = 13 Then
            MsgBox("Tempo de casa inválido", MsgBoxStyle.Exclamation, "Aviso")
            TextBox3.Text = InputBox("Informe o valor correto do tempo", "Tempo de casa:")
            Resume
        End If


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = Horas
        TextBox3.Text = Tempo
        TextBox4.Text = Salario
        Sal = 0
        Ad = 0
        Gratificacao = 0
        If TextBox1.Text = "" Then
            MsgBox("Digite seu nome", MsgBoxStyle.Information)
            TextBox1.Focus()
        End If
        If (Horas < 120) Or (Horas > 200) Then
            MsgBox("Hora inválida! Digite um valor entre 120-200", MsgBoxStyle.Exclamation, "Aviso")
            TextBox3.Text = ""
            TextBox2.Focus()
        End If
        If (Tempo < 0) Or (Tempo > 35) Then
            MsgBox("Tempo inválido!", MsgBoxStyle.Exclamation, "Aviso")
            TextBox3.Text = ""
            TextBox3.Focus()
        End If

        Gratificacao = Tempo * 30

        If (RadioButton1.Checked = True) Then
            Sal = Sal + 16
        End If
        If (RadioButton2.Checked = True) Then
            Sal = Sal + 24
        End If
        If (RadioButton3.Checked = True) Then
            Sal = Sal + 35
        End If

        If (CheckBox1.Checked = True) Then
            Ad = Ad + 150
        End If
        If (CheckBox2.Checked = True) Then
            Ad = Ad + 120
        End If
        If (CheckBox3.Checked = True) Then
            Ad = Ad + 120
        End If



        Salario = (Horas * Sal) + Gratificacao + Ad
        TextBox4.Text = Format(Salario, "R$ ###,##0.00")

    End Sub

    Private Sub Form1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{Tab}")
            e.Handled = True
        End If
    End Sub



End Class
