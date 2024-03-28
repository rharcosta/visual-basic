Public Class FrmPrin

    Private Sub TabelaPeriódicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabelaPeriódicaToolStripMenuItem.Click, ToolStripButton2.Click, TabelaPeriódicaToolStripMenuItem1.Click
        Form5.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click, ToolStripButton1.Click, SairToolStripMenuItem1.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Em aguarde")
        If (Resp = vbYes) Then
            End
        End If
    End Sub
    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel3.Text = DateTime.Now.ToLongDateString
        ToolStripStatusLabel1.Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub CalendárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendárioToolStripMenuItem.Click, ToolStripButton4.Click, CalendárioToolStripMenuItem1.Click
        Form7.Show()
    End Sub

    Private Sub CálculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CálculadoraToolStripMenuItem.Click, ToolStripButton5.Click, CalculadoraToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Calc")
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click, ToolStripButton6.Click, NotepadToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("Notepad")
    End Sub

    Private Sub WordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem.Click, ToolStripButton7.Click, WordToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("WinWord")
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.Click, ToolStripButton8.Click, ExcelToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("Excel")
    End Sub

    Private Sub ExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExplorerToolStripMenuItem.Click, ToolStripButton9.Click, ExploToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Explorer.exe")
    End Sub

    Private Sub ChromeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeToolStripMenuItem.Click, ToolStripButton10.Click, ChromeToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("Chrome.exe")
    End Sub

    Private Sub YoutubeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YoutubeToolStripMenuItem.Click, ToolStripButton11.Click, YoutubeToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("www.Youtube.com")
    End Sub

    Private Sub TabelaDeÂnionsECâtionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabelaDeÂnionsECâtionsToolStripMenuItem.Click, ToolStripButton3.Click, TabelaDeÂnionsECátionsToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub QuímicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuímicaToolStripMenuItem.Click, ToolStripButton12.Click, AQuímicaToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub PropostaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropostaToolStripMenuItem.Click, ToolStripButton13.Click, OProjetoToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub DesenvolvedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesenvolvedorToolStripMenuItem.Click, ToolStripButton14.Click, ODesenvolvedorToolStripMenuItem.Click
        Form9.Show()
    End Sub

    Private Sub ContatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContatoToolStripMenuItem.Click, ToolStripButton15.Click, ContatoToolStripMenuItem1.Click
        Form10.Show()
    End Sub
End Class