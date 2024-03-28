<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transportadoras
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
        Dim Código_TranspLabel As System.Windows.Forms.Label
        Dim CNPJ_TranspLabel As System.Windows.Forms.Label
        Dim Nome_TranspLabel As System.Windows.Forms.Label
        Dim Departamento_TranspLabel As System.Windows.Forms.Label
        Dim Cidade_TranspLabel As System.Windows.Forms.Label
        Dim Estado_TranspLabel As System.Windows.Forms.Label
        Dim CEP_TranspLabel As System.Windows.Forms.Label
        Dim Rua_TranspLabel As System.Windows.Forms.Label
        Dim N_TranspLabel As System.Windows.Forms.Label
        Dim Bairro_TranspLabel As System.Windows.Forms.Label
        Dim Complemento_TranspLabel As System.Windows.Forms.Label
        Dim Telefone_TranspLabel As System.Windows.Forms.Label
        Dim Celular_TranspLabel As System.Windows.Forms.Label
        Dim ValorKM_TranspLabel As System.Windows.Forms.Label
        Dim Frete_TranspLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transportadoras))
        Me.SorveteriaDataSet = New Sorveteria.SorveteriaDataSet
        Me.TransportadoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportadoraTableAdapter = New Sorveteria.SorveteriaDataSetTableAdapters.TransportadoraTableAdapter
        Me.TableAdapterManager = New Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
        Me.TransportadoraBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TransportadoraBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Código_TranspTextBox = New System.Windows.Forms.TextBox
        Me.CNPJ_TranspMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Nome_TranspTextBox = New System.Windows.Forms.TextBox
        Me.Departamento_TranspTextBox = New System.Windows.Forms.TextBox
        Me.Cidade_TranspTextBox = New System.Windows.Forms.TextBox
        Me.Estado_TranspComboBox = New System.Windows.Forms.ComboBox
        Me.CEP_TranspMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Rua_TranspTextBox = New System.Windows.Forms.TextBox
        Me.N_TranspTextBox = New System.Windows.Forms.TextBox
        Me.Bairro_TranspTextBox = New System.Windows.Forms.TextBox
        Me.Complemento_TranspTextBox = New System.Windows.Forms.TextBox
        Me.Telefone_TranspMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Celular_TranspMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.ValorKM_TranspTextBox = New System.Windows.Forms.TextBox
        Me.Frete_TranspTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Código_TranspLabel = New System.Windows.Forms.Label
        CNPJ_TranspLabel = New System.Windows.Forms.Label
        Nome_TranspLabel = New System.Windows.Forms.Label
        Departamento_TranspLabel = New System.Windows.Forms.Label
        Cidade_TranspLabel = New System.Windows.Forms.Label
        Estado_TranspLabel = New System.Windows.Forms.Label
        CEP_TranspLabel = New System.Windows.Forms.Label
        Rua_TranspLabel = New System.Windows.Forms.Label
        N_TranspLabel = New System.Windows.Forms.Label
        Bairro_TranspLabel = New System.Windows.Forms.Label
        Complemento_TranspLabel = New System.Windows.Forms.Label
        Telefone_TranspLabel = New System.Windows.Forms.Label
        Celular_TranspLabel = New System.Windows.Forms.Label
        ValorKM_TranspLabel = New System.Windows.Forms.Label
        Frete_TranspLabel = New System.Windows.Forms.Label
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportadoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportadoraBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransportadoraBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Código_TranspLabel
        '
        Código_TranspLabel.AutoSize = True
        Código_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Código_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Código_TranspLabel.Location = New System.Drawing.Point(28, 41)
        Código_TranspLabel.Name = "Código_TranspLabel"
        Código_TranspLabel.Size = New System.Drawing.Size(85, 33)
        Código_TranspLabel.TabIndex = 1
        Código_TranspLabel.Text = "Código:"
        '
        'CNPJ_TranspLabel
        '
        CNPJ_TranspLabel.AutoSize = True
        CNPJ_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CNPJ_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CNPJ_TranspLabel.Location = New System.Drawing.Point(26, 67)
        CNPJ_TranspLabel.Name = "CNPJ_TranspLabel"
        CNPJ_TranspLabel.Size = New System.Drawing.Size(73, 33)
        CNPJ_TranspLabel.TabIndex = 3
        CNPJ_TranspLabel.Text = "CNPJ:"
        '
        'Nome_TranspLabel
        '
        Nome_TranspLabel.AutoSize = True
        Nome_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Nome_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Nome_TranspLabel.Location = New System.Drawing.Point(26, 93)
        Nome_TranspLabel.Name = "Nome_TranspLabel"
        Nome_TranspLabel.Size = New System.Drawing.Size(76, 33)
        Nome_TranspLabel.TabIndex = 5
        Nome_TranspLabel.Text = "Nome:"
        '
        'Departamento_TranspLabel
        '
        Departamento_TranspLabel.AutoSize = True
        Departamento_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Departamento_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Departamento_TranspLabel.Location = New System.Drawing.Point(26, 119)
        Departamento_TranspLabel.Name = "Departamento_TranspLabel"
        Departamento_TranspLabel.Size = New System.Drawing.Size(161, 33)
        Departamento_TranspLabel.TabIndex = 7
        Departamento_TranspLabel.Text = "Departamento:"
        '
        'Cidade_TranspLabel
        '
        Cidade_TranspLabel.AutoSize = True
        Cidade_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Cidade_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Cidade_TranspLabel.Location = New System.Drawing.Point(26, 145)
        Cidade_TranspLabel.Name = "Cidade_TranspLabel"
        Cidade_TranspLabel.Size = New System.Drawing.Size(86, 33)
        Cidade_TranspLabel.TabIndex = 9
        Cidade_TranspLabel.Text = "Cidade:"
        '
        'Estado_TranspLabel
        '
        Estado_TranspLabel.AutoSize = True
        Estado_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Estado_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Estado_TranspLabel.Location = New System.Drawing.Point(26, 171)
        Estado_TranspLabel.Name = "Estado_TranspLabel"
        Estado_TranspLabel.Size = New System.Drawing.Size(86, 33)
        Estado_TranspLabel.TabIndex = 11
        Estado_TranspLabel.Text = "Estado:"
        '
        'CEP_TranspLabel
        '
        CEP_TranspLabel.AutoSize = True
        CEP_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CEP_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CEP_TranspLabel.Location = New System.Drawing.Point(26, 198)
        CEP_TranspLabel.Name = "CEP_TranspLabel"
        CEP_TranspLabel.Size = New System.Drawing.Size(60, 33)
        CEP_TranspLabel.TabIndex = 13
        CEP_TranspLabel.Text = "CEP:"
        '
        'Rua_TranspLabel
        '
        Rua_TranspLabel.AutoSize = True
        Rua_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Rua_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Rua_TranspLabel.Location = New System.Drawing.Point(26, 224)
        Rua_TranspLabel.Name = "Rua_TranspLabel"
        Rua_TranspLabel.Size = New System.Drawing.Size(58, 33)
        Rua_TranspLabel.TabIndex = 15
        Rua_TranspLabel.Text = "Rua:"
        '
        'N_TranspLabel
        '
        N_TranspLabel.AutoSize = True
        N_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        N_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        N_TranspLabel.Location = New System.Drawing.Point(26, 250)
        N_TranspLabel.Name = "N_TranspLabel"
        N_TranspLabel.Size = New System.Drawing.Size(98, 33)
        N_TranspLabel.TabIndex = 17
        N_TranspLabel.Text = "Número:"
        '
        'Bairro_TranspLabel
        '
        Bairro_TranspLabel.AutoSize = True
        Bairro_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Bairro_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Bairro_TranspLabel.Location = New System.Drawing.Point(26, 276)
        Bairro_TranspLabel.Name = "Bairro_TranspLabel"
        Bairro_TranspLabel.Size = New System.Drawing.Size(82, 33)
        Bairro_TranspLabel.TabIndex = 19
        Bairro_TranspLabel.Text = "Bairro:"
        '
        'Complemento_TranspLabel
        '
        Complemento_TranspLabel.AutoSize = True
        Complemento_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Complemento_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Complemento_TranspLabel.Location = New System.Drawing.Point(26, 302)
        Complemento_TranspLabel.Name = "Complemento_TranspLabel"
        Complemento_TranspLabel.Size = New System.Drawing.Size(153, 33)
        Complemento_TranspLabel.TabIndex = 21
        Complemento_TranspLabel.Text = "Complemento:"
        '
        'Telefone_TranspLabel
        '
        Telefone_TranspLabel.AutoSize = True
        Telefone_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Telefone_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Telefone_TranspLabel.Location = New System.Drawing.Point(26, 328)
        Telefone_TranspLabel.Name = "Telefone_TranspLabel"
        Telefone_TranspLabel.Size = New System.Drawing.Size(100, 33)
        Telefone_TranspLabel.TabIndex = 23
        Telefone_TranspLabel.Text = "Telefone:"
        '
        'Celular_TranspLabel
        '
        Celular_TranspLabel.AutoSize = True
        Celular_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Celular_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Celular_TranspLabel.Location = New System.Drawing.Point(26, 354)
        Celular_TranspLabel.Name = "Celular_TranspLabel"
        Celular_TranspLabel.Size = New System.Drawing.Size(87, 33)
        Celular_TranspLabel.TabIndex = 25
        Celular_TranspLabel.Text = "Celular:"
        '
        'ValorKM_TranspLabel
        '
        ValorKM_TranspLabel.AutoSize = True
        ValorKM_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        ValorKM_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ValorKM_TranspLabel.Location = New System.Drawing.Point(26, 380)
        ValorKM_TranspLabel.Name = "ValorKM_TranspLabel"
        ValorKM_TranspLabel.Size = New System.Drawing.Size(112, 33)
        ValorKM_TranspLabel.TabIndex = 27
        ValorKM_TranspLabel.Text = "Valor KM:"
        '
        'Frete_TranspLabel
        '
        Frete_TranspLabel.AutoSize = True
        Frete_TranspLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Frete_TranspLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Frete_TranspLabel.Location = New System.Drawing.Point(26, 406)
        Frete_TranspLabel.Name = "Frete_TranspLabel"
        Frete_TranspLabel.Size = New System.Drawing.Size(71, 33)
        Frete_TranspLabel.TabIndex = 29
        Frete_TranspLabel.Text = "Frete:"
        '
        'SorveteriaDataSet
        '
        Me.SorveteriaDataSet.DataSetName = "SorveteriaDataSet"
        Me.SorveteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransportadoraBindingSource
        '
        Me.TransportadoraBindingSource.DataMember = "Transportadora"
        Me.TransportadoraBindingSource.DataSource = Me.SorveteriaDataSet
        '
        'TransportadoraTableAdapter
        '
        Me.TransportadoraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.FuncionáriosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Nota_FiscalTableAdapter = Nothing
        Me.TableAdapterManager.ProdutoTableAdapter = Nothing
        Me.TableAdapterManager.TransportadoraTableAdapter = Me.TransportadoraTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'TransportadoraBindingNavigator
        '
        Me.TransportadoraBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TransportadoraBindingNavigator.BindingSource = Me.TransportadoraBindingSource
        Me.TransportadoraBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TransportadoraBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TransportadoraBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TransportadoraBindingNavigatorSaveItem})
        Me.TransportadoraBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TransportadoraBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TransportadoraBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TransportadoraBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TransportadoraBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TransportadoraBindingNavigator.Name = "TransportadoraBindingNavigator"
        Me.TransportadoraBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TransportadoraBindingNavigator.Size = New System.Drawing.Size(431, 25)
        Me.TransportadoraBindingNavigator.TabIndex = 0
        Me.TransportadoraBindingNavigator.Text = "BindingNavigator1"
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
        'TransportadoraBindingNavigatorSaveItem
        '
        Me.TransportadoraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TransportadoraBindingNavigatorSaveItem.Image = CType(resources.GetObject("TransportadoraBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TransportadoraBindingNavigatorSaveItem.Name = "TransportadoraBindingNavigatorSaveItem"
        Me.TransportadoraBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TransportadoraBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Código_TranspTextBox
        '
        Me.Código_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Código_Transp", True))
        Me.Código_TranspTextBox.Location = New System.Drawing.Point(195, 54)
        Me.Código_TranspTextBox.Name = "Código_TranspTextBox"
        Me.Código_TranspTextBox.ReadOnly = True
        Me.Código_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Código_TranspTextBox.TabIndex = 2
        Me.Código_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CNPJ_TranspMaskedTextBox
        '
        Me.CNPJ_TranspMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "CNPJ_Transp", True))
        Me.CNPJ_TranspMaskedTextBox.Location = New System.Drawing.Point(195, 80)
        Me.CNPJ_TranspMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJ_TranspMaskedTextBox.Name = "CNPJ_TranspMaskedTextBox"
        Me.CNPJ_TranspMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CNPJ_TranspMaskedTextBox.TabIndex = 4
        Me.CNPJ_TranspMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nome_TranspTextBox
        '
        Me.Nome_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Nome_Transp", True))
        Me.Nome_TranspTextBox.Location = New System.Drawing.Point(195, 106)
        Me.Nome_TranspTextBox.Name = "Nome_TranspTextBox"
        Me.Nome_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nome_TranspTextBox.TabIndex = 6
        Me.Nome_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Departamento_TranspTextBox
        '
        Me.Departamento_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Departamento_Transp", True))
        Me.Departamento_TranspTextBox.Location = New System.Drawing.Point(195, 132)
        Me.Departamento_TranspTextBox.Name = "Departamento_TranspTextBox"
        Me.Departamento_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Departamento_TranspTextBox.TabIndex = 8
        Me.Departamento_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cidade_TranspTextBox
        '
        Me.Cidade_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Cidade_Transp", True))
        Me.Cidade_TranspTextBox.Location = New System.Drawing.Point(195, 158)
        Me.Cidade_TranspTextBox.Name = "Cidade_TranspTextBox"
        Me.Cidade_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cidade_TranspTextBox.TabIndex = 10
        Me.Cidade_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Estado_TranspComboBox
        '
        Me.Estado_TranspComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Estado_Transp", True))
        Me.Estado_TranspComboBox.FormattingEnabled = True
        Me.Estado_TranspComboBox.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BH", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Estado_TranspComboBox.Location = New System.Drawing.Point(195, 184)
        Me.Estado_TranspComboBox.Name = "Estado_TranspComboBox"
        Me.Estado_TranspComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Estado_TranspComboBox.TabIndex = 12
        '
        'CEP_TranspMaskedTextBox
        '
        Me.CEP_TranspMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "CEP_Transp", True))
        Me.CEP_TranspMaskedTextBox.Location = New System.Drawing.Point(195, 211)
        Me.CEP_TranspMaskedTextBox.Mask = "00,000-000"
        Me.CEP_TranspMaskedTextBox.Name = "CEP_TranspMaskedTextBox"
        Me.CEP_TranspMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CEP_TranspMaskedTextBox.TabIndex = 14
        Me.CEP_TranspMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Rua_TranspTextBox
        '
        Me.Rua_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Rua_Transp", True))
        Me.Rua_TranspTextBox.Location = New System.Drawing.Point(195, 237)
        Me.Rua_TranspTextBox.Name = "Rua_TranspTextBox"
        Me.Rua_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rua_TranspTextBox.TabIndex = 16
        Me.Rua_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'N_TranspTextBox
        '
        Me.N_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "N_Transp", True))
        Me.N_TranspTextBox.Location = New System.Drawing.Point(195, 263)
        Me.N_TranspTextBox.Name = "N_TranspTextBox"
        Me.N_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.N_TranspTextBox.TabIndex = 18
        Me.N_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bairro_TranspTextBox
        '
        Me.Bairro_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Bairro_Transp", True))
        Me.Bairro_TranspTextBox.Location = New System.Drawing.Point(195, 289)
        Me.Bairro_TranspTextBox.Name = "Bairro_TranspTextBox"
        Me.Bairro_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Bairro_TranspTextBox.TabIndex = 20
        Me.Bairro_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Complemento_TranspTextBox
        '
        Me.Complemento_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Complemento_Transp", True))
        Me.Complemento_TranspTextBox.Location = New System.Drawing.Point(195, 315)
        Me.Complemento_TranspTextBox.Name = "Complemento_TranspTextBox"
        Me.Complemento_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Complemento_TranspTextBox.TabIndex = 22
        Me.Complemento_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Telefone_TranspMaskedTextBox
        '
        Me.Telefone_TranspMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Telefone_Transp", True))
        Me.Telefone_TranspMaskedTextBox.Location = New System.Drawing.Point(195, 341)
        Me.Telefone_TranspMaskedTextBox.Mask = "(99) 0000-0000"
        Me.Telefone_TranspMaskedTextBox.Name = "Telefone_TranspMaskedTextBox"
        Me.Telefone_TranspMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Telefone_TranspMaskedTextBox.TabIndex = 24
        Me.Telefone_TranspMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Celular_TranspMaskedTextBox
        '
        Me.Celular_TranspMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Celular_Transp", True))
        Me.Celular_TranspMaskedTextBox.Location = New System.Drawing.Point(195, 367)
        Me.Celular_TranspMaskedTextBox.Mask = "(99) 00000-0000"
        Me.Celular_TranspMaskedTextBox.Name = "Celular_TranspMaskedTextBox"
        Me.Celular_TranspMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Celular_TranspMaskedTextBox.TabIndex = 26
        Me.Celular_TranspMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValorKM_TranspTextBox
        '
        Me.ValorKM_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "ValorKM_Transp", True))
        Me.ValorKM_TranspTextBox.Location = New System.Drawing.Point(195, 393)
        Me.ValorKM_TranspTextBox.Name = "ValorKM_TranspTextBox"
        Me.ValorKM_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ValorKM_TranspTextBox.TabIndex = 28
        Me.ValorKM_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frete_TranspTextBox
        '
        Me.Frete_TranspTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportadoraBindingSource, "Frete_Transp", True))
        Me.Frete_TranspTextBox.Location = New System.Drawing.Point(195, 419)
        Me.Frete_TranspTextBox.Name = "Frete_TranspTextBox"
        Me.Frete_TranspTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Frete_TranspTextBox.TabIndex = 30
        Me.Frete_TranspTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Location = New System.Drawing.Point(320, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "&Fechar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Transportadoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(431, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Código_TranspLabel)
        Me.Controls.Add(Me.Código_TranspTextBox)
        Me.Controls.Add(CNPJ_TranspLabel)
        Me.Controls.Add(Me.CNPJ_TranspMaskedTextBox)
        Me.Controls.Add(Nome_TranspLabel)
        Me.Controls.Add(Me.Nome_TranspTextBox)
        Me.Controls.Add(Departamento_TranspLabel)
        Me.Controls.Add(Me.Departamento_TranspTextBox)
        Me.Controls.Add(Cidade_TranspLabel)
        Me.Controls.Add(Me.Cidade_TranspTextBox)
        Me.Controls.Add(Estado_TranspLabel)
        Me.Controls.Add(Me.Estado_TranspComboBox)
        Me.Controls.Add(CEP_TranspLabel)
        Me.Controls.Add(Me.CEP_TranspMaskedTextBox)
        Me.Controls.Add(Rua_TranspLabel)
        Me.Controls.Add(Me.Rua_TranspTextBox)
        Me.Controls.Add(N_TranspLabel)
        Me.Controls.Add(Me.N_TranspTextBox)
        Me.Controls.Add(Bairro_TranspLabel)
        Me.Controls.Add(Me.Bairro_TranspTextBox)
        Me.Controls.Add(Complemento_TranspLabel)
        Me.Controls.Add(Me.Complemento_TranspTextBox)
        Me.Controls.Add(Telefone_TranspLabel)
        Me.Controls.Add(Me.Telefone_TranspMaskedTextBox)
        Me.Controls.Add(Celular_TranspLabel)
        Me.Controls.Add(Me.Celular_TranspMaskedTextBox)
        Me.Controls.Add(ValorKM_TranspLabel)
        Me.Controls.Add(Me.ValorKM_TranspTextBox)
        Me.Controls.Add(Frete_TranspLabel)
        Me.Controls.Add(Me.Frete_TranspTextBox)
        Me.Controls.Add(Me.TransportadoraBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transportadoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transportadoras"
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportadoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportadoraBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransportadoraBindingNavigator.ResumeLayout(False)
        Me.TransportadoraBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SorveteriaDataSet As Sorveteria.SorveteriaDataSet
    Friend WithEvents TransportadoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransportadoraTableAdapter As Sorveteria.SorveteriaDataSetTableAdapters.TransportadoraTableAdapter
    Friend WithEvents TableAdapterManager As Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TransportadoraBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TransportadoraBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Código_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CNPJ_TranspMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Nome_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Departamento_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cidade_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Estado_TranspComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CEP_TranspMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Rua_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents N_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bairro_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Complemento_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telefone_TranspMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Celular_TranspMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ValorKM_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Frete_TranspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
