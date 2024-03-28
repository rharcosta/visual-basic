<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funcionarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funcionarios))
        Dim RG_FuncLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Me.SorveteriaDataSet = New Sorveteria.SorveteriaDataSet
        Me.FuncionáriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionáriosTableAdapter = New Sorveteria.SorveteriaDataSetTableAdapters.FuncionáriosTableAdapter
        Me.TableAdapterManager = New Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
        Me.Button1 = New System.Windows.Forms.Button
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.FuncionáriosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FuncionáriosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Nome_FuncTextBox = New System.Windows.Forms.TextBox
        Me.Sobrenome_FuncTextBox = New System.Windows.Forms.TextBox
        Me.Sexo_FuncComboBox = New System.Windows.Forms.ComboBox
        Me.Idade_FuncTextBox = New System.Windows.Forms.TextBox
        Me.Filhos_FuncTextBox = New System.Windows.Forms.TextBox
        Me.Departamento_FuncTextBox = New System.Windows.Forms.TextBox
        Me.RG_FuncMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CPF_FuncMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CEP_FuncMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Cidade_FuncTextBox = New System.Windows.Forms.TextBox
        Me.Est_FuncComboBox = New System.Windows.Forms.ComboBox
        Me.Rua_FuncTextBox = New System.Windows.Forms.TextBox
        Me.N__FuncTextBox = New System.Windows.Forms.TextBox
        Me.Bairro_FuncTextBox = New System.Windows.Forms.TextBox
        Me.Complemento_FuncTextBox = New System.Windows.Forms.TextBox
        Me.Telefone_FuncMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Celular_FuncMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Email_FuncTextBox = New System.Windows.Forms.TextBox
        Me.DataAdm_FuncDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.RendaFam_FuncTextBox = New System.Windows.Forms.TextBox
        Me.Salário_FuncTextBox = New System.Windows.Forms.TextBox
        Me.TaxaCom_FuncTextBox1 = New System.Windows.Forms.TextBox
        RG_FuncLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label11 = New System.Windows.Forms.Label
        Label12 = New System.Windows.Forms.Label
        Label13 = New System.Windows.Forms.Label
        Label14 = New System.Windows.Forms.Label
        Label15 = New System.Windows.Forms.Label
        Label16 = New System.Windows.Forms.Label
        Label17 = New System.Windows.Forms.Label
        Label18 = New System.Windows.Forms.Label
        Label19 = New System.Windows.Forms.Label
        Label20 = New System.Windows.Forms.Label
        Label21 = New System.Windows.Forms.Label
        Label22 = New System.Windows.Forms.Label
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionáriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionáriosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FuncionáriosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SorveteriaDataSet
        '
        Me.SorveteriaDataSet.DataSetName = "SorveteriaDataSet"
        Me.SorveteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FuncionáriosBindingSource
        '
        Me.FuncionáriosBindingSource.DataMember = "Funcionários"
        Me.FuncionáriosBindingSource.DataSource = Me.SorveteriaDataSet
        '
        'FuncionáriosTableAdapter
        '
        Me.FuncionáriosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.FuncionáriosTableAdapter = Me.FuncionáriosTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Nota_FiscalTableAdapter = Nothing
        Me.TableAdapterManager.ProdutoTableAdapter = Nothing
        Me.TableAdapterManager.TransportadoraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Location = New System.Drawing.Point(335, 645)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "&Fechar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'FuncionáriosBindingNavigatorSaveItem
        '
        Me.FuncionáriosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FuncionáriosBindingNavigatorSaveItem.Image = CType(resources.GetObject("FuncionáriosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FuncionáriosBindingNavigatorSaveItem.Name = "FuncionáriosBindingNavigatorSaveItem"
        Me.FuncionáriosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FuncionáriosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FuncionáriosBindingNavigator
        '
        Me.FuncionáriosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FuncionáriosBindingNavigator.BindingSource = Me.FuncionáriosBindingSource
        Me.FuncionáriosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FuncionáriosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FuncionáriosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FuncionáriosBindingNavigatorSaveItem})
        Me.FuncionáriosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FuncionáriosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FuncionáriosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FuncionáriosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FuncionáriosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FuncionáriosBindingNavigator.Name = "FuncionáriosBindingNavigator"
        Me.FuncionáriosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FuncionáriosBindingNavigator.Size = New System.Drawing.Size(450, 25)
        Me.FuncionáriosBindingNavigator.TabIndex = 0
        Me.FuncionáriosBindingNavigator.Text = "BindingNavigator1"
        '
        'Nome_FuncTextBox
        '
        Me.Nome_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Nome_Func", True))
        Me.Nome_FuncTextBox.Location = New System.Drawing.Point(210, 61)
        Me.Nome_FuncTextBox.Name = "Nome_FuncTextBox"
        Me.Nome_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nome_FuncTextBox.TabIndex = 46
        Me.Nome_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sobrenome_FuncTextBox
        '
        Me.Sobrenome_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Sobrenome_Func", True))
        Me.Sobrenome_FuncTextBox.Location = New System.Drawing.Point(210, 87)
        Me.Sobrenome_FuncTextBox.Name = "Sobrenome_FuncTextBox"
        Me.Sobrenome_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Sobrenome_FuncTextBox.TabIndex = 48
        Me.Sobrenome_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sexo_FuncComboBox
        '
        Me.Sexo_FuncComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Sexo_Func", True))
        Me.Sexo_FuncComboBox.FormattingEnabled = True
        Me.Sexo_FuncComboBox.Items.AddRange(New Object() {"Feminino ", "Masculino", "Outros"})
        Me.Sexo_FuncComboBox.Location = New System.Drawing.Point(210, 113)
        Me.Sexo_FuncComboBox.Name = "Sexo_FuncComboBox"
        Me.Sexo_FuncComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Sexo_FuncComboBox.TabIndex = 50
        '
        'Idade_FuncTextBox
        '
        Me.Idade_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Idade_Func", True))
        Me.Idade_FuncTextBox.Location = New System.Drawing.Point(210, 140)
        Me.Idade_FuncTextBox.Name = "Idade_FuncTextBox"
        Me.Idade_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Idade_FuncTextBox.TabIndex = 52
        Me.Idade_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Filhos_FuncTextBox
        '
        Me.Filhos_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Filhos_Func", True))
        Me.Filhos_FuncTextBox.Location = New System.Drawing.Point(210, 166)
        Me.Filhos_FuncTextBox.Name = "Filhos_FuncTextBox"
        Me.Filhos_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Filhos_FuncTextBox.TabIndex = 54
        Me.Filhos_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Departamento_FuncTextBox
        '
        Me.Departamento_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Departamento_Func", True))
        Me.Departamento_FuncTextBox.Location = New System.Drawing.Point(210, 192)
        Me.Departamento_FuncTextBox.Name = "Departamento_FuncTextBox"
        Me.Departamento_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Departamento_FuncTextBox.TabIndex = 56
        Me.Departamento_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RG_FuncLabel
        '
        RG_FuncLabel.AutoSize = True
        RG_FuncLabel.Location = New System.Drawing.Point(136, 222)
        RG_FuncLabel.Name = "RG_FuncLabel"
        RG_FuncLabel.Size = New System.Drawing.Size(53, 13)
        RG_FuncLabel.TabIndex = 57
        RG_FuncLabel.Text = "RG Func:"
        '
        'RG_FuncMaskedTextBox
        '
        Me.RG_FuncMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "RG_Func", True))
        Me.RG_FuncMaskedTextBox.Location = New System.Drawing.Point(210, 218)
        Me.RG_FuncMaskedTextBox.Mask = "00,000,0000-0"
        Me.RG_FuncMaskedTextBox.Name = "RG_FuncMaskedTextBox"
        Me.RG_FuncMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RG_FuncMaskedTextBox.TabIndex = 58
        Me.RG_FuncMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CPF_FuncMaskedTextBox
        '
        Me.CPF_FuncMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "CPF_Func", True))
        Me.CPF_FuncMaskedTextBox.Location = New System.Drawing.Point(210, 244)
        Me.CPF_FuncMaskedTextBox.Mask = "000,000,000-00  "
        Me.CPF_FuncMaskedTextBox.Name = "CPF_FuncMaskedTextBox"
        Me.CPF_FuncMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CPF_FuncMaskedTextBox.TabIndex = 60
        Me.CPF_FuncMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CEP_FuncMaskedTextBox
        '
        Me.CEP_FuncMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "CEP_Func", True))
        Me.CEP_FuncMaskedTextBox.Location = New System.Drawing.Point(210, 270)
        Me.CEP_FuncMaskedTextBox.Mask = "00,000-000 "
        Me.CEP_FuncMaskedTextBox.Name = "CEP_FuncMaskedTextBox"
        Me.CEP_FuncMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CEP_FuncMaskedTextBox.TabIndex = 62
        Me.CEP_FuncMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cidade_FuncTextBox
        '
        Me.Cidade_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Cidade_Func", True))
        Me.Cidade_FuncTextBox.Location = New System.Drawing.Point(210, 296)
        Me.Cidade_FuncTextBox.Name = "Cidade_FuncTextBox"
        Me.Cidade_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cidade_FuncTextBox.TabIndex = 64
        Me.Cidade_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Est_FuncComboBox
        '
        Me.Est_FuncComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Est_Func", True))
        Me.Est_FuncComboBox.FormattingEnabled = True
        Me.Est_FuncComboBox.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BH", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Est_FuncComboBox.Location = New System.Drawing.Point(210, 322)
        Me.Est_FuncComboBox.Name = "Est_FuncComboBox"
        Me.Est_FuncComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Est_FuncComboBox.TabIndex = 66
        '
        'Rua_FuncTextBox
        '
        Me.Rua_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Rua_Func", True))
        Me.Rua_FuncTextBox.Location = New System.Drawing.Point(210, 349)
        Me.Rua_FuncTextBox.Name = "Rua_FuncTextBox"
        Me.Rua_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rua_FuncTextBox.TabIndex = 68
        Me.Rua_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'N__FuncTextBox
        '
        Me.N__FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "N°_Func", True))
        Me.N__FuncTextBox.Location = New System.Drawing.Point(210, 375)
        Me.N__FuncTextBox.Name = "N__FuncTextBox"
        Me.N__FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.N__FuncTextBox.TabIndex = 70
        Me.N__FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bairro_FuncTextBox
        '
        Me.Bairro_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Bairro_Func", True))
        Me.Bairro_FuncTextBox.Location = New System.Drawing.Point(210, 401)
        Me.Bairro_FuncTextBox.Name = "Bairro_FuncTextBox"
        Me.Bairro_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Bairro_FuncTextBox.TabIndex = 72
        Me.Bairro_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Complemento_FuncTextBox
        '
        Me.Complemento_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Complemento_Func", True))
        Me.Complemento_FuncTextBox.Location = New System.Drawing.Point(210, 427)
        Me.Complemento_FuncTextBox.Name = "Complemento_FuncTextBox"
        Me.Complemento_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Complemento_FuncTextBox.TabIndex = 74
        Me.Complemento_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Telefone_FuncMaskedTextBox
        '
        Me.Telefone_FuncMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Telefone_Func", True))
        Me.Telefone_FuncMaskedTextBox.Location = New System.Drawing.Point(210, 453)
        Me.Telefone_FuncMaskedTextBox.Mask = "(99) 0000-0000"
        Me.Telefone_FuncMaskedTextBox.Name = "Telefone_FuncMaskedTextBox"
        Me.Telefone_FuncMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Telefone_FuncMaskedTextBox.TabIndex = 76
        Me.Telefone_FuncMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Celular_FuncMaskedTextBox
        '
        Me.Celular_FuncMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Celular_Func", True))
        Me.Celular_FuncMaskedTextBox.Location = New System.Drawing.Point(210, 479)
        Me.Celular_FuncMaskedTextBox.Mask = "(99) 00000-0000"
        Me.Celular_FuncMaskedTextBox.Name = "Celular_FuncMaskedTextBox"
        Me.Celular_FuncMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Celular_FuncMaskedTextBox.TabIndex = 78
        Me.Celular_FuncMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Email_FuncTextBox
        '
        Me.Email_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Email_Func", True))
        Me.Email_FuncTextBox.Location = New System.Drawing.Point(210, 505)
        Me.Email_FuncTextBox.Name = "Email_FuncTextBox"
        Me.Email_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Email_FuncTextBox.TabIndex = 80
        Me.Email_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataAdm_FuncDateTimePicker
        '
        Me.DataAdm_FuncDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FuncionáriosBindingSource, "DataAdm_Func", True))
        Me.DataAdm_FuncDateTimePicker.Location = New System.Drawing.Point(210, 531)
        Me.DataAdm_FuncDateTimePicker.Name = "DataAdm_FuncDateTimePicker"
        Me.DataAdm_FuncDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataAdm_FuncDateTimePicker.TabIndex = 82
        '
        'RendaFam_FuncTextBox
        '
        Me.RendaFam_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "RendaFam_Func", True))
        Me.RendaFam_FuncTextBox.Location = New System.Drawing.Point(210, 557)
        Me.RendaFam_FuncTextBox.Name = "RendaFam_FuncTextBox"
        Me.RendaFam_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RendaFam_FuncTextBox.TabIndex = 84
        Me.RendaFam_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Salário_FuncTextBox
        '
        Me.Salário_FuncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "Salário_Func", True))
        Me.Salário_FuncTextBox.Location = New System.Drawing.Point(210, 583)
        Me.Salário_FuncTextBox.Name = "Salário_FuncTextBox"
        Me.Salário_FuncTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Salário_FuncTextBox.TabIndex = 86
        Me.Salário_FuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaxaCom_FuncTextBox1
        '
        Me.TaxaCom_FuncTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionáriosBindingSource, "TaxaCom_Func", True))
        Me.TaxaCom_FuncTextBox1.Location = New System.Drawing.Point(210, 609)
        Me.TaxaCom_FuncTextBox1.Name = "TaxaCom_FuncTextBox1"
        Me.TaxaCom_FuncTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TaxaCom_FuncTextBox1.TabIndex = 88
        Me.TaxaCom_FuncTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label1.Location = New System.Drawing.Point(24, 51)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 33)
        Label1.TabIndex = 89
        Label1.Text = "Nome:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label2.Location = New System.Drawing.Point(24, 78)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(128, 33)
        Label2.TabIndex = 90
        Label2.Text = "Sobrenome:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label3.Location = New System.Drawing.Point(24, 104)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(64, 33)
        Label3.TabIndex = 91
        Label3.Text = "Sexo:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label4.Location = New System.Drawing.Point(24, 131)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(74, 33)
        Label4.TabIndex = 92
        Label4.Text = "Idade:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label5.Location = New System.Drawing.Point(24, 157)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(73, 33)
        Label5.TabIndex = 93
        Label5.Text = "Filhos:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label6.Location = New System.Drawing.Point(24, 183)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(161, 33)
        Label6.TabIndex = 94
        Label6.Text = "Departamento:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label7.Location = New System.Drawing.Point(24, 209)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(158, 33)
        Label7.TabIndex = 95
        Label7.Text = "Registro Geral:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label8.Location = New System.Drawing.Point(24, 235)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(58, 33)
        Label8.TabIndex = 96
        Label8.Text = "CPF:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label9.Location = New System.Drawing.Point(24, 261)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(60, 33)
        Label9.TabIndex = 97
        Label9.Text = "CEP:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label10.Location = New System.Drawing.Point(24, 287)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(86, 33)
        Label10.TabIndex = 98
        Label10.Text = "Cidade:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label11.Location = New System.Drawing.Point(24, 313)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(86, 33)
        Label11.TabIndex = 99
        Label11.Text = "Estado:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label12.Location = New System.Drawing.Point(24, 339)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(58, 33)
        Label12.TabIndex = 100
        Label12.Text = "Rua:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label13.Location = New System.Drawing.Point(24, 365)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(98, 33)
        Label13.TabIndex = 101
        Label13.Text = "Número:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label14.Location = New System.Drawing.Point(24, 391)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(82, 33)
        Label14.TabIndex = 102
        Label14.Text = "Bairro:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label15.Location = New System.Drawing.Point(24, 417)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(153, 33)
        Label15.TabIndex = 103
        Label15.Text = "Complemento:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label16.Location = New System.Drawing.Point(24, 443)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(100, 33)
        Label16.TabIndex = 104
        Label16.Text = "Telefone:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label17.Location = New System.Drawing.Point(24, 469)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(87, 33)
        Label17.TabIndex = 105
        Label17.Text = "Celular:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label18.Location = New System.Drawing.Point(24, 495)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(74, 33)
        Label18.TabIndex = 106
        Label18.Text = "Email:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label19.Location = New System.Drawing.Point(24, 522)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(165, 33)
        Label19.TabIndex = 107
        Label19.Text = "Data Admissão:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label20.Location = New System.Drawing.Point(24, 547)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(167, 33)
        Label20.TabIndex = 108
        Label20.Text = "Renda Familiar:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label21.Location = New System.Drawing.Point(24, 573)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(86, 33)
        Label21.TabIndex = 109
        Label21.Text = "Salário:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label22.Location = New System.Drawing.Point(24, 599)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(160, 33)
        Label22.TabIndex = 110
        Label22.Text = "Taxa Comissão:"
        '
        'Funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(450, 680)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Label16)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Label18)
        Me.Controls.Add(Label19)
        Me.Controls.Add(Label20)
        Me.Controls.Add(Label21)
        Me.Controls.Add(Label22)
        Me.Controls.Add(Me.Nome_FuncTextBox)
        Me.Controls.Add(Me.Sobrenome_FuncTextBox)
        Me.Controls.Add(Me.Sexo_FuncComboBox)
        Me.Controls.Add(Me.Idade_FuncTextBox)
        Me.Controls.Add(Me.Filhos_FuncTextBox)
        Me.Controls.Add(Me.Departamento_FuncTextBox)
        Me.Controls.Add(RG_FuncLabel)
        Me.Controls.Add(Me.RG_FuncMaskedTextBox)
        Me.Controls.Add(Me.CPF_FuncMaskedTextBox)
        Me.Controls.Add(Me.CEP_FuncMaskedTextBox)
        Me.Controls.Add(Me.Cidade_FuncTextBox)
        Me.Controls.Add(Me.Est_FuncComboBox)
        Me.Controls.Add(Me.Rua_FuncTextBox)
        Me.Controls.Add(Me.N__FuncTextBox)
        Me.Controls.Add(Me.Bairro_FuncTextBox)
        Me.Controls.Add(Me.Complemento_FuncTextBox)
        Me.Controls.Add(Me.Telefone_FuncMaskedTextBox)
        Me.Controls.Add(Me.Celular_FuncMaskedTextBox)
        Me.Controls.Add(Me.Email_FuncTextBox)
        Me.Controls.Add(Me.DataAdm_FuncDateTimePicker)
        Me.Controls.Add(Me.RendaFam_FuncTextBox)
        Me.Controls.Add(Me.Salário_FuncTextBox)
        Me.Controls.Add(Me.TaxaCom_FuncTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FuncionáriosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionarios"
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionáriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionáriosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FuncionáriosBindingNavigator.ResumeLayout(False)
        Me.FuncionáriosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SorveteriaDataSet As Sorveteria.SorveteriaDataSet
    Friend WithEvents FuncionáriosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionáriosTableAdapter As Sorveteria.SorveteriaDataSetTableAdapters.FuncionáriosTableAdapter
    Friend WithEvents TableAdapterManager As Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FuncionáriosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FuncionáriosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents Nome_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sobrenome_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sexo_FuncComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Idade_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Filhos_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Departamento_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RG_FuncMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPF_FuncMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CEP_FuncMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Cidade_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Est_FuncComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rua_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents N__FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bairro_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Complemento_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telefone_FuncMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Celular_FuncMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Email_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataAdm_FuncDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RendaFam_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Salário_FuncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaxaCom_FuncTextBox1 As System.Windows.Forms.TextBox
End Class
