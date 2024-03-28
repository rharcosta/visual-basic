Public Class Form1
    Dim Salario As Double
    Dim DP As Integer
    Dim INSS, BCIR, IR, VR As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Salario = 0
        DP = 0
        INSS = 0
        BCIR = 0
        IR = 0
        VR = 0

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If (Resp = vbYes) Then
            End
        End If
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{Tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        On Error GoTo DependentesErrado
        DP = TextBox2.Text
        Prestação()
DependentesErrado:
        If Err.Number = 13 Then
            MsgBox("Dado inválido no número de dependentes", MsgBoxStyle.Exclamation, "Aviso")
            TextBox2.Text = InputBox("Informe o número correto de dependentes", "Dependentes:")
            Resume
        End If
        
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        On Error GoTo SalErrado
        Salario = TextBox3.Text
        TextBox3.Text = Format(Salario, "R$###,##00.00")
        Prestação()
SalErrado:
        If Err.Number = 13 Then

            MsgBox("Dado inválido no valor do salário base", MsgBoxStyle.Exclamation, "Aviso")
            TextBox3.Text = InputBox("Informe o valor correto do salário base", "Salário Base:")
            Resume
        End If
    End Sub

    Public Sub Prestação()


        If (Salario <= 1317.07) Then
            INSS = Salario * 0.08
        End If
        If (Salario >= 1317.08) And (Salario <= 2195.12) Then
            INSS = Salario * 0.09
        End If
        If (Salario >= 2195.13) And (Salario <= 4390.24) Then
            INSS = Salario * 0.11
        End If
        If (Salario >= 4390.24) Then
            INSS = 482.93
        End If
        TextBox4.Text = Format(INSS, "R$###,##0.00")

        BCIR = Salario - INSS - (DP * 179.71)

        TextBox5.Text = Format(BCIR, "R$###,##0.00")

        If (BCIR <= 1787.77) Then
            IR = 0
        End If
        If (BCIR >= 1787.78) And (BCIR <= 2679.29) Then
            IR = ((BCIR * 7.5) / 100) - 134.08
        End If
        If (BCIR >= 2679.3) And (BCIR <= 3572.43) Then
            IR = (BCIR * 0.15) - 335.03
        End If
        If (BCIR >= 3572.44) And (BCIR <= 4463.81) Then
            IR = ((BCIR * 22.5) / 100) - 602.96
        End If
        If (BCIR >= 4463.81) Then
            IR = ((BCIR * 27.5) / 100) - 826.15
        End If
        TextBox6.Text = Format(IR, "R$###,##0.00")
        VR = Salario - INSS - IR
        TextBox7.Text = Format(VR, "R$###,##0.00")
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox1.Focus()
    End Sub
End Class





