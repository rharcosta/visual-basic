<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecedores
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
        Dim Código_FornLabel As System.Windows.Forms.Label
        Dim NomeEmp_FornLabel As System.Windows.Forms.Label
        Dim Responsavel_FornLabel As System.Windows.Forms.Label
        Dim CNPJ_FornLabel As System.Windows.Forms.Label
        Dim Departamento_FornLabel As System.Windows.Forms.Label
        Dim Cidade_FornLabel As System.Windows.Forms.Label
        Dim Estado_FornLabel As System.Windows.Forms.Label
        Dim Cep_FornLabel As System.Windows.Forms.Label
        Dim Rua_FornLabel As System.Windows.Forms.Label
        Dim N_FornLabel As System.Windows.Forms.Label
        Dim Bairro_FornLabel As System.Windows.Forms.Label
        Dim Complemento_FornLabel As System.Windows.Forms.Label
        Dim Tel_FornLabel As System.Windows.Forms.Label
        Dim Cel_FornLabel As System.Windows.Forms.Label
        Dim Email_FornLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fornecedores))
        Me.SorveteriaDataSet = New Sorveteria.SorveteriaDataSet
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecedoresTableAdapter = New Sorveteria.SorveteriaDataSetTableAdapters.FornecedoresTableAdapter
        Me.TableAdapterManager = New Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
        Me.FornecedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.FornecedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Código_FornTextBox = New System.Windows.Forms.TextBox
        Me.NomeEmp_FornTextBox = New System.Windows.Forms.TextBox
        Me.Responsavel_FornTextBox = New System.Windows.Forms.TextBox
        Me.CNPJ_FornMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Departamento_FornTextBox = New System.Windows.Forms.TextBox
        Me.Cidade_FornTextBox = New System.Windows.Forms.TextBox
        Me.Estado_FornComboBox = New System.Windows.Forms.ComboBox
        Me.Cep_FornMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Rua_FornTextBox = New System.Windows.Forms.TextBox
        Me.N_FornTextBox = New System.Windows.Forms.TextBox
        Me.Bairro_FornTextBox = New System.Windows.Forms.TextBox
        Me.Complemento_FornTextBox = New System.Windows.Forms.TextBox
        Me.Tel_FornMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Cel_FornMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Email_FornTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Código_FornLabel = New System.Windows.Forms.Label
        NomeEmp_FornLabel = New System.Windows.Forms.Label
        Responsavel_FornLabel = New System.Windows.Forms.Label
        CNPJ_FornLabel = New System.Windows.Forms.Label
        Departamento_FornLabel = New System.Windows.Forms.Label
        Cidade_FornLabel = New System.Windows.Forms.Label
        Estado_FornLabel = New System.Windows.Forms.Label
        Cep_FornLabel = New System.Windows.Forms.Label
        Rua_FornLabel = New System.Windows.Forms.Label
        N_FornLabel = New System.Windows.Forms.Label
        Bairro_FornLabel = New System.Windows.Forms.Label
        Complemento_FornLabel = New System.Windows.Forms.Label
        Tel_FornLabel = New System.Windows.Forms.Label
        Cel_FornLabel = New System.Windows.Forms.Label
        Email_FornLabel = New System.Windows.Forms.Label
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FornecedoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Código_FornLabel
        '
        Código_FornLabel.AutoSize = True
        Código_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Código_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Código_FornLabel.Location = New System.Drawing.Point(25, 46)
        Código_FornLabel.Name = "Código_FornLabel"
        Código_FornLabel.Size = New System.Drawing.Size(85, 33)
        Código_FornLabel.TabIndex = 1
        Código_FornLabel.Text = "Código:"
        '
        'NomeEmp_FornLabel
        '
        NomeEmp_FornLabel.AutoSize = True
        NomeEmp_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        NomeEmp_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NomeEmp_FornLabel.Location = New System.Drawing.Point(25, 72)
        NomeEmp_FornLabel.Name = "NomeEmp_FornLabel"
        NomeEmp_FornLabel.Size = New System.Drawing.Size(76, 33)
        NomeEmp_FornLabel.TabIndex = 3
        NomeEmp_FornLabel.Text = "Nome:"
        '
        'Responsavel_FornLabel
        '
        Responsavel_FornLabel.AutoSize = True
        Responsavel_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Responsavel_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Responsavel_FornLabel.Location = New System.Drawing.Point(25, 98)
        Responsavel_FornLabel.Name = "Responsavel_FornLabel"
        Responsavel_FornLabel.Size = New System.Drawing.Size(133, 33)
        Responsavel_FornLabel.TabIndex = 5
        Responsavel_FornLabel.Text = "Responsável:"
        '
        'CNPJ_FornLabel
        '
        CNPJ_FornLabel.AutoSize = True
        CNPJ_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CNPJ_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CNPJ_FornLabel.Location = New System.Drawing.Point(25, 124)
        CNPJ_FornLabel.Name = "CNPJ_FornLabel"
        CNPJ_FornLabel.Size = New System.Drawing.Size(67, 33)
        CNPJ_FornLabel.TabIndex = 7
        CNPJ_FornLabel.Text = "CNPJ"
        '
        'Departamento_FornLabel
        '
        Departamento_FornLabel.AutoSize = True
        Departamento_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Departamento_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Departamento_FornLabel.Location = New System.Drawing.Point(25, 150)
        Departamento_FornLabel.Name = "Departamento_FornLabel"
        Departamento_FornLabel.Size = New System.Drawing.Size(161, 33)
        Departamento_FornLabel.TabIndex = 9
        Departamento_FornLabel.Text = "Departamento:"
        '
        'Cidade_FornLabel
        '
        Cidade_FornLabel.AutoSize = True
        Cidade_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Cidade_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Cidade_FornLabel.Location = New System.Drawing.Point(25, 176)
        Cidade_FornLabel.Name = "Cidade_FornLabel"
        Cidade_FornLabel.Size = New System.Drawing.Size(86, 33)
        Cidade_FornLabel.TabIndex = 11
        Cidade_FornLabel.Text = "Cidade:"
        '
        'Estado_FornLabel
        '
        Estado_FornLabel.AutoSize = True
        Estado_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Estado_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Estado_FornLabel.Location = New System.Drawing.Point(25, 202)
        Estado_FornLabel.Name = "Estado_FornLabel"
        Estado_FornLabel.Size = New System.Drawing.Size(86, 33)
        Estado_FornLabel.TabIndex = 13
        Estado_FornLabel.Text = "Estado:"
        '
        'Cep_FornLabel
        '
        Cep_FornLabel.AutoSize = True
        Cep_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Cep_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Cep_FornLabel.Location = New System.Drawing.Point(25, 229)
        Cep_FornLabel.Name = "Cep_FornLabel"
        Cep_FornLabel.Size = New System.Drawing.Size(60, 33)
        Cep_FornLabel.TabIndex = 15
        Cep_FornLabel.Text = "CEP:"
        '
        'Rua_FornLabel
        '
        Rua_FornLabel.AutoSize = True
        Rua_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Rua_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Rua_FornLabel.Location = New System.Drawing.Point(25, 255)
        Rua_FornLabel.Name = "Rua_FornLabel"
        Rua_FornLabel.Size = New System.Drawing.Size(58, 33)
        Rua_FornLabel.TabIndex = 17
        Rua_FornLabel.Text = "Rua:"
        '
        'N_FornLabel
        '
        N_FornLabel.AutoSize = True
        N_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        N_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        N_FornLabel.Location = New System.Drawing.Point(25, 281)
        N_FornLabel.Name = "N_FornLabel"
        N_FornLabel.Size = New System.Drawing.Size(98, 33)
        N_FornLabel.TabIndex = 19
        N_FornLabel.Text = "Número:"
        '
        'Bairro_FornLabel
        '
        Bairro_FornLabel.AutoSize = True
        Bairro_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Bairro_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Bairro_FornLabel.Location = New System.Drawing.Point(25, 307)
        Bairro_FornLabel.Name = "Bairro_FornLabel"
        Bairro_FornLabel.Size = New System.Drawing.Size(82, 33)
        Bairro_FornLabel.TabIndex = 21
        Bairro_FornLabel.Text = "Bairro:"
        '
        'Complemento_FornLabel
        '
        Complemento_FornLabel.AutoSize = True
        Complemento_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Complemento_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Complemento_FornLabel.Location = New System.Drawing.Point(25, 333)
        Complemento_FornLabel.Name = "Complemento_FornLabel"
        Complemento_FornLabel.Size = New System.Drawing.Size(153, 33)
        Complemento_FornLabel.TabIndex = 23
        Complemento_FornLabel.Text = "Complemento:"
        '
        'Tel_FornLabel
        '
        Tel_FornLabel.AutoSize = True
        Tel_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Tel_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Tel_FornLabel.Location = New System.Drawing.Point(25, 359)
        Tel_FornLabel.Name = "Tel_FornLabel"
        Tel_FornLabel.Size = New System.Drawing.Size(160, 33)
        Tel_FornLabel.TabIndex = 25
        Tel_FornLabel.Text = "Telelefone Fixo:"
        '
        'Cel_FornLabel
        '
        Cel_FornLabel.AutoSize = True
        Cel_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Cel_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Cel_FornLabel.Location = New System.Drawing.Point(25, 385)
        Cel_FornLabel.Name = "Cel_FornLabel"
        Cel_FornLabel.Size = New System.Drawing.Size(87, 33)
        Cel_FornLabel.TabIndex = 27
        Cel_FornLabel.Text = "Celular:"
        '
        'Email_FornLabel
        '
        Email_FornLabel.AutoSize = True
        Email_FornLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Email_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Email_FornLabel.Location = New System.Drawing.Point(25, 411)
        Email_FornLabel.Name = "Email_FornLabel"
        Email_FornLabel.Size = New System.Drawing.Size(74, 33)
        Email_FornLabel.TabIndex = 29
        Email_FornLabel.Text = "Email:"
        '
        'SorveteriaDataSet
        '
        Me.SorveteriaDataSet.DataSetName = "SorveteriaDataSet"
        Me.SorveteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FornecedoresBindingSource
        '
        Me.FornecedoresBindingSource.DataMember = "Fornecedores"
        Me.FornecedoresBindingSource.DataSource = Me.SorveteriaDataSet
        '
        'FornecedoresTableAdapter
        '
        Me.FornecedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Me.FornecedoresTableAdapter
        Me.TableAdapterManager.FuncionáriosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Nota_FiscalTableAdapter = Nothing
        Me.TableAdapterManager.ProdutoTableAdapter = Nothing
        Me.TableAdapterManager.TransportadoraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'FornecedoresBindingNavigator
        '
        Me.FornecedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FornecedoresBindingNavigator.BindingSource = Me.FornecedoresBindingSource
        Me.FornecedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FornecedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FornecedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FornecedoresBindingNavigatorSaveItem})
        Me.FornecedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FornecedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FornecedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FornecedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FornecedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FornecedoresBindingNavigator.Name = "FornecedoresBindingNavigator"
        Me.FornecedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FornecedoresBindingNavigator.Size = New System.Drawing.Size(438, 25)
        Me.FornecedoresBindingNavigator.TabIndex = 0
        Me.FornecedoresBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'FornecedoresBindingNavigatorSaveItem
        '
        Me.FornecedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FornecedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("FornecedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FornecedoresBindingNavigatorSaveItem.Name = "FornecedoresBindingNavigatorSaveItem"
        Me.FornecedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FornecedoresBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Código_FornTextBox
        '
        Me.Código_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Código_Forn", True))
        Me.Código_FornTextBox.Location = New System.Drawing.Point(209, 56)
        Me.Código_FornTextBox.Name = "Código_FornTextBox"
        Me.Código_FornTextBox.ReadOnly = True
        Me.Código_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Código_FornTextBox.TabIndex = 2
        Me.Código_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NomeEmp_FornTextBox
        '
        Me.NomeEmp_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "NomeEmp_Forn", True))
        Me.NomeEmp_FornTextBox.Location = New System.Drawing.Point(209, 82)
        Me.NomeEmp_FornTextBox.Name = "NomeEmp_FornTextBox"
        Me.NomeEmp_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomeEmp_FornTextBox.TabIndex = 4
        Me.NomeEmp_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Responsavel_FornTextBox
        '
        Me.Responsavel_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Responsavel_Forn", True))
        Me.Responsavel_FornTextBox.Location = New System.Drawing.Point(209, 108)
        Me.Responsavel_FornTextBox.Name = "Responsavel_FornTextBox"
        Me.Responsavel_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Responsavel_FornTextBox.TabIndex = 6
        Me.Responsavel_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CNPJ_FornMaskedTextBox
        '
        Me.CNPJ_FornMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "CNPJ_Forn", True))
        Me.CNPJ_FornMaskedTextBox.Location = New System.Drawing.Point(209, 134)
        Me.CNPJ_FornMaskedTextBox.Mask = "00,000,000/0000-00   "
        Me.CNPJ_FornMaskedTextBox.Name = "CNPJ_FornMaskedTextBox"
        Me.CNPJ_FornMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CNPJ_FornMaskedTextBox.TabIndex = 8
        Me.CNPJ_FornMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Departamento_FornTextBox
        '
        Me.Departamento_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Departamento_Forn", True))
        Me.Departamento_FornTextBox.Location = New System.Drawing.Point(209, 160)
        Me.Departamento_FornTextBox.Name = "Departamento_FornTextBox"
        Me.Departamento_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Departamento_FornTextBox.TabIndex = 10
        Me.Departamento_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cidade_FornTextBox
        '
        Me.Cidade_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Cidade_Forn", True))
        Me.Cidade_FornTextBox.Location = New System.Drawing.Point(209, 186)
        Me.Cidade_FornTextBox.Name = "Cidade_FornTextBox"
        Me.Cidade_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cidade_FornTextBox.TabIndex = 12
        Me.Cidade_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Estado_FornComboBox
        '
        Me.Estado_FornComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Estado_Forn", True))
        Me.Estado_FornComboBox.FormattingEnabled = True
        Me.Estado_FornComboBox.Items.AddRange(New Object() {"", "AC", "AL", "AP", "AM", "BH", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Estado_FornComboBox.Location = New System.Drawing.Point(209, 212)
        Me.Estado_FornComboBox.Name = "Estado_FornComboBox"
        Me.Estado_FornComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Estado_FornComboBox.TabIndex = 14
        '
        'Cep_FornMaskedTextBox
        '
        Me.Cep_FornMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Cep_Forn", True))
        Me.Cep_FornMaskedTextBox.Location = New System.Drawing.Point(209, 239)
        Me.Cep_FornMaskedTextBox.Mask = "00,000-000 "
        Me.Cep_FornMaskedTextBox.Name = "Cep_FornMaskedTextBox"
        Me.Cep_FornMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cep_FornMaskedTextBox.TabIndex = 16
        Me.Cep_FornMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Rua_FornTextBox
        '
        Me.Rua_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Rua_Forn", True))
        Me.Rua_FornTextBox.Location = New System.Drawing.Point(209, 265)
        Me.Rua_FornTextBox.Name = "Rua_FornTextBox"
        Me.Rua_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rua_FornTextBox.TabIndex = 18
        Me.Rua_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'N_FornTextBox
        '
        Me.N_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "N_Forn", True))
        Me.N_FornTextBox.Location = New System.Drawing.Point(209, 291)
        Me.N_FornTextBox.Name = "N_FornTextBox"
        Me.N_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.N_FornTextBox.TabIndex = 20
        Me.N_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bairro_FornTextBox
        '
        Me.Bairro_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Bairro_Forn", True))
        Me.Bairro_FornTextBox.Location = New System.Drawing.Point(209, 317)
        Me.Bairro_FornTextBox.Name = "Bairro_FornTextBox"
        Me.Bairro_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Bairro_FornTextBox.TabIndex = 22
        Me.Bairro_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Complemento_FornTextBox
        '
        Me.Complemento_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Complemento_Forn", True))
        Me.Complemento_FornTextBox.Location = New System.Drawing.Point(209, 343)
        Me.Complemento_FornTextBox.Name = "Complemento_FornTextBox"
        Me.Complemento_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Complemento_FornTextBox.TabIndex = 24
        Me.Complemento_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tel_FornMaskedTextBox
        '
        Me.Tel_FornMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Tel_Forn", True))
        Me.Tel_FornMaskedTextBox.Location = New System.Drawing.Point(209, 369)
        Me.Tel_FornMaskedTextBox.Mask = "(99) 0000-0000"
        Me.Tel_FornMaskedTextBox.Name = "Tel_FornMaskedTextBox"
        Me.Tel_FornMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tel_FornMaskedTextBox.TabIndex = 26
        Me.Tel_FornMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cel_FornMaskedTextBox
        '
        Me.Cel_FornMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Cel_Forn", True))
        Me.Cel_FornMaskedTextBox.Location = New System.Drawing.Point(209, 395)
        Me.Cel_FornMaskedTextBox.Mask = "(99) 00000-0000"
        Me.Cel_FornMaskedTextBox.Name = "Cel_FornMaskedTextBox"
        Me.Cel_FornMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cel_FornMaskedTextBox.TabIndex = 28
        Me.Cel_FornMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Email_FornTextBox
        '
        Me.Email_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedoresBindingSource, "Email_Forn", True))
        Me.Email_FornTextBox.Location = New System.Drawing.Point(209, 421)
        Me.Email_FornTextBox.Name = "Email_FornTextBox"
        Me.Email_FornTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Email_FornTextBox.TabIndex = 30
        Me.Email_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Location = New System.Drawing.Point(334, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "&Fechar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(438, 521)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Código_FornLabel)
        Me.Controls.Add(Me.Código_FornTextBox)
        Me.Controls.Add(NomeEmp_FornLabel)
        Me.Controls.Add(Me.NomeEmp_FornTextBox)
        Me.Controls.Add(Responsavel_FornLabel)
        Me.Controls.Add(Me.Responsavel_FornTextBox)
        Me.Controls.Add(CNPJ_FornLabel)
        Me.Controls.Add(Me.CNPJ_FornMaskedTextBox)
        Me.Controls.Add(Departamento_FornLabel)
        Me.Controls.Add(Me.Departamento_FornTextBox)
        Me.Controls.Add(Cidade_FornLabel)
        Me.Controls.Add(Me.Cidade_FornTextBox)
        Me.Controls.Add(Estado_FornLabel)
        Me.Controls.Add(Me.Estado_FornComboBox)
        Me.Controls.Add(Cep_FornLabel)
        Me.Controls.Add(Me.Cep_FornMaskedTextBox)
        Me.Controls.Add(Rua_FornLabel)
        Me.Controls.Add(Me.Rua_FornTextBox)
        Me.Controls.Add(N_FornLabel)
        Me.Controls.Add(Me.N_FornTextBox)
        Me.Controls.Add(Bairro_FornLabel)
        Me.Controls.Add(Me.Bairro_FornTextBox)
        Me.Controls.Add(Complemento_FornLabel)
        Me.Controls.Add(Me.Complemento_FornTextBox)
        Me.Controls.Add(Tel_FornLabel)
        Me.Controls.Add(Me.Tel_FornMaskedTextBox)
        Me.Controls.Add(Cel_FornLabel)
        Me.Controls.Add(Me.Cel_FornMaskedTextBox)
        Me.Controls.Add(Email_FornLabel)
        Me.Controls.Add(Me.Email_FornTextBox)
        Me.Controls.Add(Me.FornecedoresBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedores"
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FornecedoresBindingNavigator.ResumeLayout(False)
        Me.FornecedoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SorveteriaDataSet As Sorveteria.SorveteriaDataSet
    Friend WithEvents FornecedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FornecedoresTableAdapter As Sorveteria.SorveteriaDataSetTableAdapters.FornecedoresTableAdapter
    Friend WithEvents TableAdapterManager As Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FornecedoresBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FornecedoresBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Código_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeEmp_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Responsavel_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CNPJ_FornMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Departamento_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cidade_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Estado_FornComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cep_FornMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Rua_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents N_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bairro_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Complemento_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_FornMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Cel_FornMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Email_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
