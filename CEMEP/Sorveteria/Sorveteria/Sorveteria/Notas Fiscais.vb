Public Class Notas_Fiscais

    Private Sub Nota_FiscalBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nota_FiscalBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Nota_FiscalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SorveteriaDataSet)

    End Sub

    Private Sub Notas_Fiscais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SorveteriaDataSet.Nota_Fiscal' table. You can move, or remove it, as needed.
        Me.Nota_FiscalTableAdapter.Fill(Me.SorveteriaDataSet.Nota_Fiscal)

    End Sub

    Private Sub ProdDes_NotaTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProdDes_NotaTextBox.LostFocus
        ProdDes_NotaTextBox.Text = StrConv(ProdDes_NotaTextBox.Text, VbStrConv.ProperCase)
    End Sub


    Private Sub Notas_Fiscais_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{Tab}")
            e.Handled = True
        End If
    End Sub
End Class