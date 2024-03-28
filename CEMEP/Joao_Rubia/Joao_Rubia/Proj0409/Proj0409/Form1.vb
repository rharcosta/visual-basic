Public Class FrmCarro
    Dim Modelo, Preco As Integer
    Dim Pintura, Vv, Te, Ac, Dh, Fa, Bc As Integer

    Public Sub Calcular()

        Modelo = 0
        Preco = 0
        Pintura = 0
        Vv = 0
        Te = 0
        Ac = 0
        Dh = 0
        Fa = 0
        Bc = 0


        If (ComboBox1.Text = "Compacto") Then
            Modelo = 22000
            CheckBox1.Enabled = True
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
        End If

        If (ComboBox1.Text = "Sedan") Then
            Modelo = 28000
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
        End If

        If (ComboBox1.Text = "Perua") Then
            Modelo = 34000
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
        End If

        If (ComboBox1.Text = "Conversível") Then
            Modelo = 60000
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
        End If

        If (ComboBox1.Text = "Esportivo") Then
            Modelo = 80000
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
        End If

        If RadioButton1.Checked = True Then
            Pintura = 0
        End If

        If RadioButton2.Checked = True Then
            Pintura = 180
        End If

        If RadioButton3.Checked = True Then
            Pintura = 320
        End If

        If (CheckBox1.Checked = True) Then
            Vv = 300

        End If

        If (CheckBox2.Checked = True) Then
            Te = 700

        End If

        If (CheckBox3.Checked = True) Then
            Ac = 1200

        End If

        If (CheckBox4.Checked = True) Then
            Dh = 1000

        End If

        If (CheckBox5.Checked = True) Then
            Fa = 2000

        End If

        If (CheckBox6.Checked = True) Then
            Bc = 1600

        End If

        Preco = Modelo + Pintura + Vv + Te + Ac + Dh + Fa + Bc
        TextBox2.Text = Format(Preco, "R$ ###,##0.00")
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Resp As Integer
        Resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Em aguarde")
        If (Resp = vbYes) Then
            Close()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton1.Focus()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        TextBox1.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        Calcular()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        If (ComboBox2.Text = "BRANCO") Then
            TextBox1.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
        End If

        If (ComboBox2.Text = "AZUL") Then

            TextBox1.Visible = False
            TextBox3.Visible = True
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
        End If

        If (ComboBox2.Text = "VERMELHO") Then
            TextBox1.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = True
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
        End If

        If (ComboBox2.Text = "VERDE") Then
            TextBox1.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = True
            TextBox6.Visible = False
            TextBox7.Visible = False
        End If

        If (ComboBox2.Text = "CINZA") Then
            TextBox1.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = True
            TextBox7.Visible = False
        End If

        If (ComboBox2.Text = "PRETO") Then
            TextBox1.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Calcular()

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Calcular()

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Calcular()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Calcular()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Calcular()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Calcular()
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Calcular()
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        Calcular()
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        Calcular()
    End Sub


End Class








