Public Class Form1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Font = New System.Drawing.Font("mistral", "14")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox1.Font = New System.Drawing.Font("tahoma", "14")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox1.Font = New System.Drawing.Font("niagara solid", "14")
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox1.Font = New System.Drawing.Font("papyrus", "14")
        End If
    End Sub
    Private Sub AzulToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AzulToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub RosaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RosaToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Pink
    End Sub

    Private Sub VerdeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerdeToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub VermelhoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VermelhoToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        TextBox1.Font = New Font(TextBox1.Font.Size, "8")
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        TextBox1.Font = New Font(TextBox1.Font.Size, "20")
    End Sub

    'SUB ROTINA CHAMADA TESTE

    Public Sub Teste()

        If CheckBox1.Checked = True Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold)
        End If
        If CheckBox2.Checked = True Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic)
        End If
        If CheckBox3.Checked = True Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Underline)
        End If
        If CheckBox4.Checked = True Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Strikeout)
        End If




        If ((CheckBox1.Checked = True) And (CheckBox2.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Italic)
        End If
        If ((CheckBox1.Checked = True) And (CheckBox3.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Underline)
        End If
        If ((CheckBox1.Checked = True) And (CheckBox4.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Strikeout)
        End If
        If ((CheckBox2.Checked = True) And (CheckBox3.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic Or FontStyle.Underline)
        End If
        If ((CheckBox2.Checked = True) And (CheckBox4.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic Or FontStyle.Strikeout)
        End If
        If ((CheckBox3.Checked = True) And (CheckBox4.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Underline Or FontStyle.Strikeout)
        End If



        If ((CheckBox1.Checked = True) And (CheckBox2.Checked = True) And (CheckBox3.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        End If
        If ((CheckBox1.Checked = True) And (CheckBox2.Checked = True) And (CheckBox4.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Strikeout)
        End If
        If ((CheckBox1.Checked = True) And (CheckBox3.Checked = True) And (CheckBox4.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Underline Or FontStyle.Strikeout)
        End If
        If ((CheckBox2.Checked = True) And (CheckBox3.Checked = True) And (CheckBox4.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic Or FontStyle.Underline Or FontStyle.Strikeout)
        End If



        If ((CheckBox1.Checked = True) And (CheckBox2.Checked = True) And (CheckBox3.Checked = True) And (CheckBox4.Checked = True)) Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline Or FontStyle.Strikeout)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Teste()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Teste()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Teste()
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Teste()
    End Sub


End Class
