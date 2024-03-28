Public Class Transportadoras

    Private Sub TransportadoraBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportadoraBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransportadoraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SorveteriaDataSet)

    End Sub

    Private Sub Transportadoras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SorveteriaDataSet.Transportadora' table. You can move, or remove it, as needed.
        Me.TransportadoraTableAdapter.Fill(Me.SorveteriaDataSet.Transportadora)

    End Sub

    Private Sub Nome_TranspTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nome_TranspTextBox.LostFocus
        Nome_TranspTextBox.Text = StrConv(Nome_TranspTextBox.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub Departamento_TranspTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Departamento_TranspTextBox.LostFocus
        Departamento_TranspTextBox.Text = StrConv(Departamento_TranspTextBox.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub Cidade_TranspTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cidade_TranspTextBox.LostFocus
        Cidade_TranspTextBox.Text = StrConv(Cidade_TranspTextBox.Text, VbStrConv.ProperCase)
    End Sub


    Private Sub Rua_TranspTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rua_TranspTextBox.LostFocus
        Rua_TranspTextBox.Text = StrConv(Rua_TranspTextBox.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub Bairro_TranspTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bairro_TranspTextBox.LostFocus
        Bairro_TranspTextBox.Text = StrConv(Bairro_TranspTextBox.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub Complemento_TranspTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Complemento_TranspTextBox.LostFocus
        Complemento_TranspTextBox.Text = StrConv(Complemento_TranspTextBox.Text, VbStrConv.ProperCase)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Transportadoras_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{Tab}")
            e.Handled = True
        End If
    End Sub
End Class