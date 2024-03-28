Public Class FrmConsultaEd

    Private Sub EditoraBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditoraBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EditoraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDSystem1DataSet)

    End Sub

    Private Sub FrmConsultaEd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSystem1DataSet.Editora' table. You can move, or remove it, as needed.
        Me.EditoraTableAdapter.Fill(Me.BDSystem1DataSet.Editora)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.EditoraTableAdapter.FillByEditoraNome(Me.BDSystem1DataSet.Editora, TextBox1.Text)

    End Sub
End Class