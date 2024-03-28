<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim Código_CliLabel As System.Windows.Forms.Label
        Dim Nome_CliLabel As System.Windows.Forms.Label
        Dim Sobrenome_CliLabel As System.Windows.Forms.Label
        Dim DataNasc_CliLabel As System.Windows.Forms.Label
        Dim RG_CliLabel As System.Windows.Forms.Label
        Dim CPF_CliLabel As System.Windows.Forms.Label
        Dim Nacionalidade_CliLabel As System.Windows.Forms.Label
        Dim Cidade_CliLabel As System.Windows.Forms.Label
        Dim Estado_CliLabel As System.Windows.Forms.Label
        Dim CEP_CliLabel As System.Windows.Forms.Label
        Dim Rua_CliLabel As System.Windows.Forms.Label
        Dim Nº_CliLabel As System.Windows.Forms.Label
        Dim Bairro_CliLabel As System.Windows.Forms.Label
        Dim Complemento_CliLabel As System.Windows.Forms.Label
        Dim Telefone_CliLabel As System.Windows.Forms.Label
        Dim Celular_CliLabel As System.Windows.Forms.Label
        Dim Email_CliLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.SorveteriaDataSet = New Sorveteria.SorveteriaDataSet
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Sorveteria.SorveteriaDataSetTableAdapters.ClientesTableAdapter
        Me.TableAdapterManager = New Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Código_CliTextBox = New System.Windows.Forms.TextBox
        Me.Nome_CliTextBox = New System.Windows.Forms.TextBox
        Me.Sobrenome_CliTextBox = New System.Windows.Forms.TextBox
        Me.DataNasc_CliDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.RG_CliMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CPF_CliMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Nacionalidade_CliTextBox = New System.Windows.Forms.TextBox
        Me.Cidade_CliTextBox = New System.Windows.Forms.TextBox
        Me.Estado_CliComboBox = New System.Windows.Forms.ComboBox
        Me.CEP_CliMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Rua_CliTextBox = New System.Windows.Forms.TextBox
        Me.Nº_CliTextBox = New System.Windows.Forms.TextBox
        Me.Bairro_CliTextBox = New System.Windows.Forms.TextBox
        Me.Complemento_CliTextBox = New System.Windows.Forms.TextBox
        Me.Telefone_CliMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Celular_CliMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Email_CliTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Código_CliLabel = New System.Windows.Forms.Label
        Nome_CliLabel = New System.Windows.Forms.Label
        Sobrenome_CliLabel = New System.Windows.Forms.Label
        DataNasc_CliLabel = New System.Windows.Forms.Label
        RG_CliLabel = New System.Windows.Forms.Label
        CPF_CliLabel = New System.Windows.Forms.Label
        Nacionalidade_CliLabel = New System.Windows.Forms.Label
        Cidade_CliLabel = New System.Windows.Forms.Label
        Estado_CliLabel = New System.Windows.Forms.Label
        CEP_CliLabel = New System.Windows.Forms.Label
        Rua_CliLabel = New System.Windows.Forms.Label
        Nº_CliLabel = New System.Windows.Forms.Label
        Bairro_CliLabel = New System.Windows.Forms.Label
        Complemento_CliLabel = New System.Windows.Forms.Label
        Telefone_CliLabel = New System.Windows.Forms.Label
        Celular_CliLabel = New System.Windows.Forms.Label
        Email_CliLabel = New System.Windows.Forms.Label
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Código_CliLabel
        '
        Código_CliLabel.AutoSize = True
        Código_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Código_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Código_CliLabel.Location = New System.Drawing.Point(31, 41)
        Código_CliLabel.Name = "Código_CliLabel"
        Código_CliLabel.Size = New System.Drawing.Size(85, 33)
        Código_CliLabel.TabIndex = 1
        Código_CliLabel.Text = "Código:"
        '
        'Nome_CliLabel
        '
        Nome_CliLabel.AutoSize = True
        Nome_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Nome_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Nome_CliLabel.Location = New System.Drawing.Point(31, 67)
        Nome_CliLabel.Name = "Nome_CliLabel"
        Nome_CliLabel.Size = New System.Drawing.Size(76, 33)
        Nome_CliLabel.TabIndex = 3
        Nome_CliLabel.Text = "Nome:"
        '
        'Sobrenome_CliLabel
        '
        Sobrenome_CliLabel.AutoSize = True
        Sobrenome_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Sobrenome_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Sobrenome_CliLabel.Location = New System.Drawing.Point(31, 93)
        Sobrenome_CliLabel.Name = "Sobrenome_CliLabel"
        Sobrenome_CliLabel.Size = New System.Drawing.Size(128, 33)
        Sobrenome_CliLabel.TabIndex = 5
        Sobrenome_CliLabel.Text = "Sobrenome:"
        '
        'DataNasc_CliLabel
        '
        DataNasc_CliLabel.AutoSize = True
        DataNasc_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataNasc_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataNasc_CliLabel.Location = New System.Drawing.Point(31, 120)
        DataNasc_CliLabel.Name = "DataNasc_CliLabel"
        DataNasc_CliLabel.Size = New System.Drawing.Size(186, 33)
        DataNasc_CliLabel.TabIndex = 7
        DataNasc_CliLabel.Text = "Data Nascimento:"
        '
        'RG_CliLabel
        '
        RG_CliLabel.AutoSize = True
        RG_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        RG_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        RG_CliLabel.Location = New System.Drawing.Point(31, 145)
        RG_CliLabel.Name = "RG_CliLabel"
        RG_CliLabel.Size = New System.Drawing.Size(158, 33)
        RG_CliLabel.TabIndex = 9
        RG_CliLabel.Text = "Registro Geral:"
        '
        'CPF_CliLabel
        '
        CPF_CliLabel.AutoSize = True
        CPF_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CPF_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CPF_CliLabel.Location = New System.Drawing.Point(31, 171)
        CPF_CliLabel.Name = "CPF_CliLabel"
        CPF_CliLabel.Size = New System.Drawing.Size(58, 33)
        CPF_CliLabel.TabIndex = 11
        CPF_CliLabel.Text = "CPF:"
        '
        'Nacionalidade_CliLabel
        '
        Nacionalidade_CliLabel.AutoSize = True
        Nacionalidade_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Nacionalidade_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Nacionalidade_CliLabel.Location = New System.Drawing.Point(31, 197)
        Nacionalidade_CliLabel.Name = "Nacionalidade_CliLabel"
        Nacionalidade_CliLabel.Size = New System.Drawing.Size(154, 33)
        Nacionalidade_CliLabel.TabIndex = 13
        Nacionalidade_CliLabel.Text = "Nacionalidade:"
        '
        'Cidade_CliLabel
        '
        Cidade_CliLabel.AutoSize = True
        Cidade_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Cidade_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Cidade_CliLabel.Location = New System.Drawing.Point(31, 223)
        Cidade_CliLabel.Name = "Cidade_CliLabel"
        Cidade_CliLabel.Size = New System.Drawing.Size(86, 33)
        Cidade_CliLabel.TabIndex = 15
        Cidade_CliLabel.Text = "Cidade:"
        '
        'Estado_CliLabel
        '
        Estado_CliLabel.AutoSize = True
        Estado_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Estado_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Estado_CliLabel.Location = New System.Drawing.Point(31, 249)
        Estado_CliLabel.Name = "Estado_CliLabel"
        Estado_CliLabel.Size = New System.Drawing.Size(86, 33)
        Estado_CliLabel.TabIndex = 17
        Estado_CliLabel.Text = "Estado:"
        '
        'CEP_CliLabel
        '
        CEP_CliLabel.AutoSize = True
        CEP_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CEP_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CEP_CliLabel.Location = New System.Drawing.Point(31, 276)
        CEP_CliLabel.Name = "CEP_CliLabel"
        CEP_CliLabel.Size = New System.Drawing.Size(60, 33)
        CEP_CliLabel.TabIndex = 19
        CEP_CliLabel.Text = "CEP:"
        '
        'Rua_CliLabel
        '
        Rua_CliLabel.AutoSize = True
        Rua_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Rua_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Rua_CliLabel.Location = New System.Drawing.Point(31, 302)
        Rua_CliLabel.Name = "Rua_CliLabel"
        Rua_CliLabel.Size = New System.Drawing.Size(58, 33)
        Rua_CliLabel.TabIndex = 21
        Rua_CliLabel.Text = "Rua:"
        '
        'Nº_CliLabel
        '
        Nº_CliLabel.AutoSize = True
        Nº_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Nº_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Nº_CliLabel.Location = New System.Drawing.Point(31, 328)
        Nº_CliLabel.Name = "Nº_CliLabel"
        Nº_CliLabel.Size = New System.Drawing.Size(98, 33)
        Nº_CliLabel.TabIndex = 23
        Nº_CliLabel.Text = "Número:"
        '
        'Bairro_CliLabel
        '
        Bairro_CliLabel.AutoSize = True
        Bairro_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Bairro_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Bairro_CliLabel.Location = New System.Drawing.Point(31, 354)
        Bairro_CliLabel.Name = "Bairro_CliLabel"
        Bairro_CliLabel.Size = New System.Drawing.Size(82, 33)
        Bairro_CliLabel.TabIndex = 25
        Bairro_CliLabel.Text = "Bairro:"
        '
        'Complemento_CliLabel
        '
        Complemento_CliLabel.AutoSize = True
        Complemento_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Complemento_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Complemento_CliLabel.Location = New System.Drawing.Point(31, 380)
        Complemento_CliLabel.Name = "Complemento_CliLabel"
        Complemento_CliLabel.Size = New System.Drawing.Size(153, 33)
        Complemento_CliLabel.TabIndex = 27
        Complemento_CliLabel.Text = "Complemento:"
        '
        'Telefone_CliLabel
        '
        Telefone_CliLabel.AutoSize = True
        Telefone_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Telefone_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Telefone_CliLabel.Location = New System.Drawing.Point(31, 406)
        Telefone_CliLabel.Name = "Telefone_CliLabel"
        Telefone_CliLabel.Size = New System.Drawing.Size(145, 33)
        Telefone_CliLabel.TabIndex = 29
        Telefone_CliLabel.Text = "Telefone Fixo:"
        '
        'Celular_CliLabel
        '
        Celular_CliLabel.AutoSize = True
        Celular_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Celular_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Celular_CliLabel.Location = New System.Drawing.Point(31, 432)
        Celular_CliLabel.Name = "Celular_CliLabel"
        Celular_CliLabel.Size = New System.Drawing.Size(87, 33)
        Celular_CliLabel.TabIndex = 31
        Celular_CliLabel.Text = "Celular:"
        '
        'Email_CliLabel
        '
        Email_CliLabel.AutoSize = True
        Email_CliLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Email_CliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Email_CliLabel.Location = New System.Drawing.Point(31, 458)
        Email_CliLabel.Name = "Email_CliLabel"
        Email_CliLabel.Size = New System.Drawing.Size(74, 33)
        Email_CliLabel.TabIndex = 33
        Email_CliLabel.Text = "Email:"
        '
        'SorveteriaDataSet
        '
        Me.SorveteriaDataSet.DataSetName = "SorveteriaDataSet"
        Me.SorveteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.SorveteriaDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.FornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.FuncionáriosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Nota_FiscalTableAdapter = Nothing
        Me.TableAdapterManager.ProdutoTableAdapter = Nothing
        Me.TableAdapterManager.TransportadoraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(450, 25)
        Me.ClientesBindingNavigator.TabIndex = 0
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
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
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Código_CliTextBox
        '
        Me.Código_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Código_Cli", True))
        Me.Código_CliTextBox.Location = New System.Drawing.Point(219, 41)
        Me.Código_CliTextBox.Name = "Código_CliTextBox"
        Me.Código_CliTextBox.ReadOnly = True
        Me.Código_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Código_CliTextBox.TabIndex = 2
        Me.Código_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nome_CliTextBox
        '
        Me.Nome_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nome_Cli", True))
        Me.Nome_CliTextBox.Location = New System.Drawing.Point(219, 67)
        Me.Nome_CliTextBox.Name = "Nome_CliTextBox"
        Me.Nome_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nome_CliTextBox.TabIndex = 4
        Me.Nome_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sobrenome_CliTextBox
        '
        Me.Sobrenome_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Sobrenome_Cli", True))
        Me.Sobrenome_CliTextBox.Location = New System.Drawing.Point(219, 93)
        Me.Sobrenome_CliTextBox.Name = "Sobrenome_CliTextBox"
        Me.Sobrenome_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Sobrenome_CliTextBox.TabIndex = 6
        Me.Sobrenome_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataNasc_CliDateTimePicker
        '
        Me.DataNasc_CliDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "DataNasc_Cli", True))
        Me.DataNasc_CliDateTimePicker.Location = New System.Drawing.Point(219, 119)
        Me.DataNasc_CliDateTimePicker.Name = "DataNasc_CliDateTimePicker"
        Me.DataNasc_CliDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataNasc_CliDateTimePicker.TabIndex = 8
        '
        'RG_CliMaskedTextBox
        '
        Me.RG_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "RG_Cli", True))
        Me.RG_CliMaskedTextBox.Location = New System.Drawing.Point(219, 145)
        Me.RG_CliMaskedTextBox.Mask = "00,000,0000-0"
        Me.RG_CliMaskedTextBox.Name = "RG_CliMaskedTextBox"
        Me.RG_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RG_CliMaskedTextBox.TabIndex = 10
        Me.RG_CliMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CPF_CliMaskedTextBox
        '
        Me.CPF_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CPF_Cli", True))
        Me.CPF_CliMaskedTextBox.Location = New System.Drawing.Point(219, 171)
        Me.CPF_CliMaskedTextBox.Mask = "000,000,000-00"
        Me.CPF_CliMaskedTextBox.Name = "CPF_CliMaskedTextBox"
        Me.CPF_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CPF_CliMaskedTextBox.TabIndex = 12
        Me.CPF_CliMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nacionalidade_CliTextBox
        '
        Me.Nacionalidade_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nacionalidade_Cli", True))
        Me.Nacionalidade_CliTextBox.Location = New System.Drawing.Point(219, 197)
        Me.Nacionalidade_CliTextBox.Name = "Nacionalidade_CliTextBox"
        Me.Nacionalidade_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nacionalidade_CliTextBox.TabIndex = 14
        Me.Nacionalidade_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cidade_CliTextBox
        '
        Me.Cidade_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Cidade_Cli", True))
        Me.Cidade_CliTextBox.Location = New System.Drawing.Point(219, 223)
        Me.Cidade_CliTextBox.Name = "Cidade_CliTextBox"
        Me.Cidade_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cidade_CliTextBox.TabIndex = 16
        Me.Cidade_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Estado_CliComboBox
        '
        Me.Estado_CliComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Estado_Cli", True))
        Me.Estado_CliComboBox.FormattingEnabled = True
        Me.Estado_CliComboBox.Items.AddRange(New Object() {"", "AC", "AL", "AP", "AM", "BH", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Estado_CliComboBox.Location = New System.Drawing.Point(219, 249)
        Me.Estado_CliComboBox.Name = "Estado_CliComboBox"
        Me.Estado_CliComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Estado_CliComboBox.TabIndex = 18
        '
        'CEP_CliMaskedTextBox
        '
        Me.CEP_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CEP_Cli", True))
        Me.CEP_CliMaskedTextBox.Location = New System.Drawing.Point(219, 276)
        Me.CEP_CliMaskedTextBox.Mask = "00,000-000                 "
        Me.CEP_CliMaskedTextBox.Name = "CEP_CliMaskedTextBox"
        Me.CEP_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CEP_CliMaskedTextBox.TabIndex = 20
        Me.CEP_CliMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Rua_CliTextBox
        '
        Me.Rua_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Rua_Cli", True))
        Me.Rua_CliTextBox.Location = New System.Drawing.Point(219, 302)
        Me.Rua_CliTextBox.Name = "Rua_CliTextBox"
        Me.Rua_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rua_CliTextBox.TabIndex = 22
        Me.Rua_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nº_CliTextBox
        '
        Me.Nº_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nº_Cli", True))
        Me.Nº_CliTextBox.Location = New System.Drawing.Point(219, 328)
        Me.Nº_CliTextBox.Name = "Nº_CliTextBox"
        Me.Nº_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nº_CliTextBox.TabIndex = 24
        Me.Nº_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bairro_CliTextBox
        '
        Me.Bairro_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Bairro_Cli", True))
        Me.Bairro_CliTextBox.Location = New System.Drawing.Point(219, 354)
        Me.Bairro_CliTextBox.Name = "Bairro_CliTextBox"
        Me.Bairro_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Bairro_CliTextBox.TabIndex = 26
        Me.Bairro_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Complemento_CliTextBox
        '
        Me.Complemento_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Complemento_Cli", True))
        Me.Complemento_CliTextBox.Location = New System.Drawing.Point(219, 380)
        Me.Complemento_CliTextBox.Name = "Complemento_CliTextBox"
        Me.Complemento_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Complemento_CliTextBox.TabIndex = 28
        Me.Complemento_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Telefone_CliMaskedTextBox
        '
        Me.Telefone_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telefone_Cli", True))
        Me.Telefone_CliMaskedTextBox.Location = New System.Drawing.Point(219, 406)
        Me.Telefone_CliMaskedTextBox.Mask = "(99) 0000-0000"
        Me.Telefone_CliMaskedTextBox.Name = "Telefone_CliMaskedTextBox"
        Me.Telefone_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Telefone_CliMaskedTextBox.TabIndex = 30
        Me.Telefone_CliMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Celular_CliMaskedTextBox
        '
        Me.Celular_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Celular_Cli", True))
        Me.Celular_CliMaskedTextBox.Location = New System.Drawing.Point(219, 432)
        Me.Celular_CliMaskedTextBox.Mask = "(99) 00000-0000"
        Me.Celular_CliMaskedTextBox.Name = "Celular_CliMaskedTextBox"
        Me.Celular_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Celular_CliMaskedTextBox.TabIndex = 32
        Me.Celular_CliMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Email_CliTextBox
        '
        Me.Email_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Email_Cli", True))
        Me.Email_CliTextBox.Location = New System.Drawing.Point(219, 458)
        Me.Email_CliTextBox.Name = "Email_CliTextBox"
        Me.Email_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Email_CliTextBox.TabIndex = 34
        Me.Email_CliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(344, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "&Fechar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(450, 537)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Código_CliLabel)
        Me.Controls.Add(Me.Código_CliTextBox)
        Me.Controls.Add(Nome_CliLabel)
        Me.Controls.Add(Me.Nome_CliTextBox)
        Me.Controls.Add(Sobrenome_CliLabel)
        Me.Controls.Add(Me.Sobrenome_CliTextBox)
        Me.Controls.Add(DataNasc_CliLabel)
        Me.Controls.Add(Me.DataNasc_CliDateTimePicker)
        Me.Controls.Add(RG_CliLabel)
        Me.Controls.Add(Me.RG_CliMaskedTextBox)
        Me.Controls.Add(CPF_CliLabel)
        Me.Controls.Add(Me.CPF_CliMaskedTextBox)
        Me.Controls.Add(Nacionalidade_CliLabel)
        Me.Controls.Add(Me.Nacionalidade_CliTextBox)
        Me.Controls.Add(Cidade_CliLabel)
        Me.Controls.Add(Me.Cidade_CliTextBox)
        Me.Controls.Add(Estado_CliLabel)
        Me.Controls.Add(Me.Estado_CliComboBox)
        Me.Controls.Add(CEP_CliLabel)
        Me.Controls.Add(Me.CEP_CliMaskedTextBox)
        Me.Controls.Add(Rua_CliLabel)
        Me.Controls.Add(Me.Rua_CliTextBox)
        Me.Controls.Add(Nº_CliLabel)
        Me.Controls.Add(Me.Nº_CliTextBox)
        Me.Controls.Add(Bairro_CliLabel)
        Me.Controls.Add(Me.Bairro_CliTextBox)
        Me.Controls.Add(Complemento_CliLabel)
        Me.Controls.Add(Me.Complemento_CliTextBox)
        Me.Controls.Add(Telefone_CliLabel)
        Me.Controls.Add(Me.Telefone_CliMaskedTextBox)
        Me.Controls.Add(Celular_CliLabel)
        Me.Controls.Add(Me.Celular_CliMaskedTextBox)
        Me.Controls.Add(Email_CliLabel)
        Me.Controls.Add(Me.Email_CliTextBox)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SorveteriaDataSet As Sorveteria.SorveteriaDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Sorveteria.SorveteriaDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Código_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nome_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sobrenome_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataNasc_CliDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RG_CliMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPF_CliMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Nacionalidade_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cidade_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Estado_CliComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CEP_CliMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Rua_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nº_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bairro_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Complemento_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telefone_CliMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Celular_CliMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Email_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
