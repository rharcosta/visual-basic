Public Class Form1
    Dim Valor, Entrada As Double
    Dim Juros As Single
    Dim Meses As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If (Resp = vbYes) Then
            End
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Valor = 0
        Entrada = 0
        Juros = 0
        Meses = 0

    End Sub

    Private Sub Txtvalor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtvalor.LostFocus
        On Error GoTo valor_Errado
        Valor = Txtvalor.Text
        Prestação()
valor_Errado:
        If Err.Number = 13 Then
            MsgBox("Dado inválido no valor do financiamento", MsgBoxStyle.Exclamation, "Aviso")
            Txtvalor.Text = InputBox("Informe o valor correto do financiamento", "Valor do financiamento:")
            Resume
        End If

    End Sub

    Private Sub Txtentrada_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtentrada.LostFocus
        On Error GoTo Entrada_Errado
        Entrada = Txtentrada.Text
        Prestação()
Entrada_Errado:
        If Err.Number = 13 Then
            MsgBox("Dado inválido no valor da entrada", MsgBoxStyle.Exclamation, "Aviso")
            Txtentrada.Text = InputBox("Informe o valor correto da Entrada", "Entrada:")
            Resume
        End If

    End Sub

    Private Sub Txtjuros_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtjuros.LostFocus
        On Error GoTo Juros_Errado
        Juros = Txtjuros.Text
        Juros = Juros / 100
        Prestação()
Juros_Errado:
        If Err.Number = 13 Then
            MsgBox("Dado inválido no valor do juros", MsgBoxStyle.Exclamation, "Aviso")
            Txtjuros.Text = InputBox("Informe o valor correto do juros", "Juros:")
            Resume
        End If
    End Sub

    Private Sub Txtmeses_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtmeses.LostFocus
        On Error GoTo meses_Errado
        Meses = Txtmeses.Text
        Prestação()
Meses_Errado:
        If Err.Number = 13 Then
            MsgBox("Dado inválido no valor do número de meses", MsgBoxStyle.Exclamation, "Aviso")
            Txtmeses.Text = InputBox("Informe o valor correto do número de meses", "Nº de meses:")
            Resume
        End If
    End Sub

    
    Private Sub Form1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{Tab}")
            e.Handled = True
        End If
    End Sub

    Public Sub Prestação()
        Dim ValFinanciado As Double
        Dim PrestMensal As Double
        If (Valor <> 0) And (Juros <> 0) And (Meses <> 0) Then
            If Entrada >= Valor Then
                MsgBox("O valor da entrada deve ser menor que o do financiamento", MsgBoxStyle.Exclamation, "Aviso")
                TextBox4.Clear()
                TextBox6.Clear()
                Txtentrada.Focus()
                Exit Sub
            End If
            ValFinanciado = Valor - Entrada
            PrestMensal = ValFinanciado * Juros * (1 + Juros) ^ Meses / ((1 + Juros) ^ Meses - 1)
            TextBox4.Text = Format(ValFinanciado, "R$ ###,##0.00")
            TextBox6.Text = Format(PrestMensal, "R$ ###,##0.00")

        Else
            TextBox4.Clear()
            TextBox6.Clear()
        End If


    End Sub



End Class
