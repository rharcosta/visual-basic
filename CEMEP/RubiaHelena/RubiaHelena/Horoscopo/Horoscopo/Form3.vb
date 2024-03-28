Public Class Form3
    Dim Dia, Mes, Mes2 As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dia = NumericUpDown1.Value
        Mes = NumericUpDown2.Value


        If TextBox1.Text = "" Then
            TextBox1.Text = InputBox("Digite seu nome")
        End If

        If ((Dia > 28) And (Mes = 2)) Then
            NumericUpDown1.Value = InputBox("Inválido! Digite o dia novamente [Entre 1 e 28]")


        ElseIf ((Mes = 4) And (Dia > 30)) Then
            NumericUpDown1.Value = InputBox("Inválido! Digite o dia novamente")


        ElseIf ((Mes = 6) And (Dia > 30)) Then
            NumericUpDown1.Value = InputBox("Inválido! Digite o dia novamente")


        ElseIf ((Mes = 9) And (Dia > 30)) Then
            NumericUpDown1.Value = InputBox("Inválido! Digite o dia novamente")


        ElseIf ((Mes = 11) And (Dia > 30)) Then
            NumericUpDown1.Value = InputBox("Inválido! Digite o dia novamente")
        End If


        Mes2 = Convert.ToInt32(NumericUpDown2.Value.ToString)

        If (Mes2 = 1) Then
            Label6.Text = "Janeiro"


        ElseIf (Mes2 = 2) Then
            Label6.Text = "Fevereiro"


        ElseIf (Mes2 = 3) Then
            Label6.Text = "Março"


        ElseIf (Mes2 = 4) Then
            Label6.Text = "Abril"


        ElseIf (Mes2 = 5) Then
            Label6.Text = "Maio"

        ElseIf (Mes2 = 6) Then
            Label6.Text = "Junho"


        ElseIf (Mes2 = 7) Then
            Label6.Text = "Julho"


        ElseIf (Mes2 = 8) Then
            Label6.Text = "Agosto"


        ElseIf (Mes2 = 9) Then
            Label6.Text = "Setembro"


        ElseIf (Mes2 = 10) Then
            Label6.Text = "Outubro"


        ElseIf (Mes2 = 11) Then
            Label6.Text = "Novembro"

        ElseIf (Mes2 = 12) Then
            Label6.Text = "Dezembro"

        End If

        If (Dia >= 21 And Mes = 12) Or (Dia < 21 And Mes = 1) Then
            FrmCapri.Show()
            Close()
        End If


        If (Dia >= 21 And Mes = 1) Or (Dia < 21 And Mes = 2) Then
            FrmAquario.Show()
            Close()
        End If


        If (Dia >= 21 And Mes = 2) Or (Dia < 21 And Mes = 3) Then
            FrmPeixes.Show()
            Close()
        End If


        If (Dia >= 21 And Mes = 3) Or (Dia < 21 And Mes = 4) Then
            FrmAries.Show()
            Close()
        End If


        If (Dia >= 21 And Mes = 4) Or (Dia < 21 And Mes = 5) Then
            FrmTouro.Show()
            Close()
        End If


        If (Dia >= 21 And Mes = 5) Or (Dia < 21 And Mes = 6) Then
            FrmGemeos.Show()
            Close()
        End If


        If (Dia >= 21 And Mes = 6) Or (Dia < 21 And Mes = 7) Then
            FrmCancer.Show()
            Close()
        End If


        If (Dia >= 21 And Mes = 7) Or (Dia < 21 And Mes = 8) Then
            FrmLeao.Show()
            Close()
        End If


        If (Dia >= 21 And Mes = 8) Or (Dia < 21 And Mes = 9) Then
            FrmVirgem.Show()
            Close()
        End If



        If (Dia >= 21 And Mes = 9) Or (Dia < 21 And Mes = 10) Then
            FrmLibra.Show()
            Close()
        End If



        If (Dia >= 21 And Mes = 10) Or (Dia < 21 And Mes = 11) Then
            FrmEscorp.Show()
            Close()
        End If



        If (Dia >= 21 And Mes = 11) Or (Dia < 21 And Mes = 12) Then
            FrmSag.Show()
            Close()
        End If

    End Sub

End Class