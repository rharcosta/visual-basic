Public Class FrmPrin

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = DateTime.Now.ToLongDateString
        ToolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem1.Click, ToolStripButton1.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Em aguarde")
        If (Resp = vbYes) Then
            End
        End If
    End Sub

    Private Sub JogadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JogadoresToolStripMenuItem.Click, ToolStripButton2.Click
        Form4.Show()
    End Sub

    Private Sub OClubeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OClubeToolStripMenuItem.Click, ToolStripButton4.Click
        Form6.Show()
    End Sub

    Private Sub PatrocinadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatrocinadoresToolStripMenuItem.Click, ToolStripButton5.Click
        Form7.Show()
    End Sub

    Private Sub TítulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TítulosToolStripMenuItem.Click, ToolStripButton7.Click
        Form8.Show()
    End Sub

    Private Sub FotosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FotosToolStripMenuItem.Click, ToolStripButton6.Click
        Form9.Show()
    End Sub

    
End Class