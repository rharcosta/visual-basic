Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = DateTime.Now.ToLongDateString
        ToolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString

    End Sub

    Private Sub ImportCarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportCarToolStripMenuItem.Click, ToolStripButton1.Click
        FrmCarro.Show()

    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click, ToolStripButton2.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Sair")
        If (Resp = vbYes) Then
            End
        End If
    End Sub

    Private Sub SobreOSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreOSistemaToolStripMenuItem.Click
        Shell("Calc")
    End Sub

    Private Sub NToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NToolStripMenuItem.Click, ToolStripButton4.Click
        System.Diagnostics.Process.Start("Notepad")
    End Sub

    Private Sub WordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem.Click, ToolStripButton5.Click
        System.Diagnostics.Process.Start("WinWord")
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.Click, ToolStripButton6.Click
        System.Diagnostics.Process.Start("Excel")
    End Sub

    Private Sub ExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExplorerToolStripMenuItem.Click, ToolStripButton7.Click
        System.Diagnostics.Process.Start("Explorer.exe")
    End Sub

    Private Sub ChromeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeToolStripMenuItem.Click, ToolStripButton8.Click
        System.Diagnostics.Process.Start("Chrome.exe")
    End Sub

    Private Sub SobreOSistemaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreOSistemaToolStripMenuItem1.Click, ToolStripButton9.Click
        AboutBox1.Show()
    End Sub
End Class