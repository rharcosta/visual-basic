Public Class Form2

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click, ToolStripButton1.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Em aguarde")
        If (Resp = vbYes) Then
            End
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = DateTime.Now.ToLongDateString
        ToolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub HoróscopoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HoróscopoToolStripMenuItem.Click, ToolStripButton2.Click
        Form3.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click, ToolStripButton4.Click
        System.Diagnostics.Process.Start("Calc")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click, ToolStripButton5.Click
        System.Diagnostics.Process.Start("Notepad")
    End Sub

    Private Sub WordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem.Click, ToolStripButton6.Click
        System.Diagnostics.Process.Start("WinWord")
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.Click, ToolStripButton7.Click
        System.Diagnostics.Process.Start("Excel")
    End Sub

    Private Sub ExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExplorerToolStripMenuItem.Click, ToolStripButton8.Click
        System.Diagnostics.Process.Start("Explorer.exe")
    End Sub

    Private Sub ChromeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeToolStripMenuItem.Click, ToolStripButton9.Click
        System.Diagnostics.Process.Start("Chrome.exe")
    End Sub

    Private Sub CalendárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendárioToolStripMenuItem.Click, ToolStripButton3.Click
        Form4.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click, ToolStripButton10.Click
        Form5.Show()
    End Sub
End Class