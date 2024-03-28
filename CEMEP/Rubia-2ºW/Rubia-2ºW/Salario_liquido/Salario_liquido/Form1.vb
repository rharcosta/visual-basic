Public Class Form1
    Dim HT As Double 'Hora Trabalhada
    Dim VH As Double 'Valor Hora Trabalhada
    Dim PD As Double 'Percentual de Desconto 
    Dim SB As Double 'Salário bruto
    Dim TD As Double 'Total de Desconto 
    Dim SL As Double 'Salário Líquido

    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click

        End

    End Sub

  
    Private Sub Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcular.Click
        HT = Tb1.Text 'Entrada de dados
        VH = Tb2.Text
        PD = Tb3.Text

        SB = HT * VH 'Processamentos
        TD = (PD / 100) * SB
        SL = SB - TD

        Tb4.Text = Format(SB, "R$###,##0.00") 'Saída de dados
        Tb5.Text = Format(TD, "R$###,##0.00")
        Tb6.Text = Format(SL, "R$###,##0.00")


    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Tb1.Clear()
        Tb2.Clear()
        Tb3.Clear()
        Tb4.Clear()
        Tb5.Clear()
        Tb6.Clear()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
