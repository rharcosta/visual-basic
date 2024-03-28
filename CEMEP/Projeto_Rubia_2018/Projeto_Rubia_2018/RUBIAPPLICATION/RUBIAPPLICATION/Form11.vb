Public Class Frmcadlocatarios


    Private Sub LocatárioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocatárioBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.LocatárioBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BDSystem1DataSet)

            MessageBox.Show("Registro salvo com sucesso", "informa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch
            MessageBox.Show("Falha ao salvar o registro", "informa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
       
    End Sub

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSystem1DataSet.Locatário' table. You can move, or remove it, as needed.
        Me.LocatárioTableAdapter.Fill(Me.BDSystem1DataSet.Locatário)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MessageBox.Show("Deseja excluir esse registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ''Se sim salvar, pegue a programação do salvar
            Me.Validate()
            Me.LocatárioBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BDSystem1DataSet)
            MessageBox.Show("Para concluir a exclusão, clique no BOTÃO SALVAR!")
        Else
            'Pegue a programacao do frmcadeditora_load que preenche o data set 
            Me.LocatárioTableAdapter.Fill(Me.BDSystem1DataSet.Locatário)

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Frmcadlocatarios_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{Tab}")
            e.Handled = True
        End If
    End Sub
End Class