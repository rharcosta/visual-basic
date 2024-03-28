Public Class Principal

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click, ToolStripButton3.Click
        Clientes.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click, ToolStripButton4.Click
        Fornecedores.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click, ToolStripButton6.Click
        Funcionarios.Show()
    End Sub

    Private Sub NotaFiscalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaFiscalToolStripMenuItem.Click, ToolStripButton8.Click
        Notas_Fiscais.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosToolStripMenuItem.Click, ToolStripButton9.Click
        Produtos.Show()
    End Sub

    Private Sub TransportadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportadoraToolStripMenuItem.Click, ToolStripButton2.Click
        Transportadoras.Show()
    End Sub

    Private Sub VendasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasToolStripMenuItem.Click, ToolStripButton10.Click
        Vendas.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = DateTime.Now.ToLongDateString
        ToolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        ConsultaClientes.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click, ToolStripButton1.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question)
        If (Resp = vbYes) Then
            End
        End If
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Sobre.Show()
    End Sub
End Class