Public Class FrmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If ((TextBox1.Text = "nome") And (TextBox2.Text = "123")) Then
        '    Me.Hide()
        '    FrmPrin.Show()
        'Else
        '    MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    TextBox1.Clear()
        '    TextBox2.Clear()
        '    TextBox1.Focus()
        'End If

        Dim Result As Integer
        Result = FuncionárioTableAdapter.FillByFuncionarioLogin(BDSystem1DataSet.Funcionário, TextBox1.Text, TextBox2.Text)
        If (Result = 1) Then
            FrmPrin.Show()
        Else
            MsgBox("Usuário ou senha inválidos")
        End If

    End Sub

    Private Sub FrmLogin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSystem1DataSet.Funcionário' table. You can move, or remove it, as needed.
        Me.FuncionárioTableAdapter.Fill(Me.BDSystem1DataSet.Funcionário)

    End Sub

    Private Sub FuncionárioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FuncionárioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDSystem1DataSet)

    End Sub
End Class