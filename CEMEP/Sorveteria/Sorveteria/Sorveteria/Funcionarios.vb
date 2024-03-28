Public Class Funcionarios

    Private Sub FuncionáriosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FuncionáriosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SorveteriaDataSet)

    End Sub

    Private Sub Funcionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SorveteriaDataSet.Funcionários' table. You can move, or remove it, as needed.
        Me.FuncionáriosTableAdapter.Fill(Me.SorveteriaDataSet.Funcionários)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Funcionarios_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{Tab}")
            e.Handled = True
        End If
    End Sub
End Class