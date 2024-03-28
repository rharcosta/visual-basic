Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Assim que o form for carregado apresentar a quantidade de países e cidades
        lblnumpais.Text = ListBox1.Items.Count 'colocando na label a quantidade de países
        lblnumcidades.Text = ComboBox1.Items.Count 'colocando na label a quantidade de cidades
    End Sub

    'NA TEXTBOX1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Button1.Enabled = True ' quando clicar na text habilita o botão adicionar
    End Sub


    'NA LISTBOX

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Button2.Enabled = True ' esse botão foi previamente desabilitado Enabled = False
        lblpaisescolhido.Text = ListBox1.Text   'o que é selecionado na listbox1 aparece na label paises
    End Sub

    'BUTTON1 – ADICIONAR PAÍS

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then  ' se a text estiver vazia, exibir uma mensagem
            MsgBox("Você precisa digitar o nome do país adicionado!!", MsgBoxStyle.Exclamation, "Aviso")
            TextBox1.Focus() 'voltar o foco para uma nova digitação
            Exit Sub
        End If
        With ListBox1 ' com a listbox1 em enfase
            .Items.Add(TextBox1.Text) ' pegar a informação na text e adicionar na list
            Button1.Enabled = False ' desabilitar o botão adicionar após seu uso
            lblnumpais.Text = .Items.Count ' atualizar a quantidade de itens
        End With
        lblpaisescolhido.Text = TextBox1.Text   ' exibir o conteúdo da text na label
        TextBox1.Clear() 'limpar
        TextBox1.Focus() 'voltar o foco
    End Sub


    'BUTTON2 – REMOVER PAIS
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With ListBox1
            .Items.Remove(TextBox1.Text) ' Removendo itens selecionados na text
            .Items.Remove(ListBox1.Text)  ' Removendo itens selecionados na label
            Button2.Enabled = False  'desabilitando o botão após o uso 
            lblnumpais.Text = .Items.Count  ' atualizando o número de itens na label país
            lblpaisescolhido.Text = ""
        End With
    End Sub

    'Cidades

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Button3.Enabled = True ' quando clicar na text habilita o botão adicionar
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button4.Enabled = True ' esse botão foi previamente desabilitado Enabled = False
        lblcidadeescolhida.Text = ComboBox1.Text   'o que é selecionado no combo aparece na label cidade
    End Sub

    'BUTTON3 – ADICIONAR CIDADE

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If TextBox2.Text = "" Then  ' se a text estiver vazia, exibir uma mensagem
            MsgBox("Você precisa digitar o nome da cidade adicionada!!", MsgBoxStyle.Exclamation, "Aviso")
            TextBox2.Focus() 'voltar o foco para uma nova digitação
            Exit Sub
        End If
        With ComboBox1
            .Items.Add(TextBox2.Text) ' pegar a informação na text e adicionar no combo
            Button3.Enabled = False ' desabilitar o botão adicionar após seu uso
            lblnumcidades.Text = .Items.Count ' atualizar a quantidade de itens
        End With
        lblcidadeescolhida.Text = TextBox2.Text   ' exibir o conteúdo da text no combo
        TextBox2.Clear() 'limpar
        TextBox2.Focus() 'voltar o foco
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'BUTTON4 – REMOVER CIDADE


        With ComboBox1
            .Items.Remove(TextBox2.Text) ' Removendo itens selecionados na text
            .Items.Remove(ComboBox1.Text)  ' Removendo itens selecionados na label
            Button4.Enabled = False  'desabilitando o botão após o uso 
            lblnumcidades.Text = .Items.Count  ' atualizando o número de itens na label cidade
            lblcidadeescolhida.Text = ""
        End With
    End Sub
End Class

