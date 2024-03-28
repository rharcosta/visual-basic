Public Class FrmPrin


    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click, SairToolStripMenuItem1.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Em aguarde")
        If (Resp = vbYes) Then
            End
        End If
    End Sub
   

    Private Sub QuímicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuímicaToolStripMenuItem.Click, AQuímicaToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub PropostaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropostaToolStripMenuItem.Click, OProjetoToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub DesenvolvedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesenvolvedorToolStripMenuItem.Click, ODesenvolvedorToolStripMenuItem.Click
        Form9.Show()
    End Sub
    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel3.Text = DateTime.Now.ToLongDateString
        ToolStripStatusLabel1.Text = DateTime.Now.ToShortTimeString
    End Sub

   
    Private Sub ContatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContatoToolStripMenuItem.Click, ContatoToolStripMenuItem2.Click
        Form10.Show()
    End Sub

    Private Sub LivrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivrosToolStripMenuItem.Click, LivrosToolStripMenuItem1.Click
        Frmcadlivros.Show()
    End Sub

    Private Sub EditorasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditorasToolStripMenuItem.Click, EditoriaToolStripMenuItem.Click
        Frmcadeditoras.Show()
    End Sub

    Private Sub FuncionarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionarioToolStripMenuItem.Click, FuncionáriosToolStripMenuItem.Click, ToolStripButton3.Click
        Frmcadfuncionarios.Show()
    End Sub

    Private Sub LocatarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocatarioToolStripMenuItem.Click, LocatariosToolStripMenuItem1.Click, ToolStripButton12.Click
        Frmcadlocatarios.Show()
    End Sub

    
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Frmcadlivros.Show()
    End Sub

    Private Sub WordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem.Click
        FrmConsultaEd.Show()
    End Sub
End Class