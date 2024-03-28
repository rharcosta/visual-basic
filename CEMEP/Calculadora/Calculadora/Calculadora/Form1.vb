Public Class Form1
    Dim A As Integer 'Declaração das variáveis 
    Dim B As Integer
    Dim R As Integer
   
    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
       
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True


        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False

        TextBox1.Clear()
        TextBox2.Clear()
        Result.Clear()

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Dim resp As Integer
        resp = MsgBox("Deseja sair?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Sair")
        If (resp = vbYes) Then
            End
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        A = TextBox1.Text
        B = TextBox2.Text
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        If (RadioButton1.Checked = True) Then
            R = A + B
            Result.Text = R
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False

        End If
        
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        A = TextBox1.Text
        B = TextBox2.Text
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        If (RadioButton2.Checked = True) Then
            R = A - B
            Result.Text = R
            RadioButton1.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False

        End If
       
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        A = TextBox1.Text
        B = TextBox2.Text
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = True
        PictureBox4.Visible = False
        If (RadioButton3.Checked = True) Then
            R = A * B
            Result.Text = R
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton4.Enabled = False

        End If
        
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        A = TextBox1.Text
        B = TextBox2.Text
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        If (RadioButton4.Checked = True) Then
            R = A / B
            Result.Text = R
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
        End If
        
    End Sub

  
End Class
