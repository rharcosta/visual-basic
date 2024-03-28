<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaClientes))
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.SorveteriaDataSet = New Sorveteria.SorveteriaDataSet
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Sorveteria.SorveteriaDataSetTableAdapters.ClientesTableAdapter
        Me.TableAdapterManager = New Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Panel1 = New System.Windows.Forms.Panel
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
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.ClientesBindingSource
        Me.ComboBox1.DisplayMember = "Nome_Cli"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(266, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Código_Cli"
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
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(479, 25)
        Me.ClientesBindingNavigator.TabIndex = 1
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ClientesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Código_CliTextBox
        '
        Me.Código_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Código_Cli", True))
        Me.Código_CliTextBox.Location = New System.Drawing.Point(215, 29)
        Me.Código_CliTextBox.Name = "Código_CliTextBox"
        Me.Código_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Código_CliTextBox.TabIndex = 3
        '
        'Nome_CliTextBox
        '
        Me.Nome_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nome_Cli", True))
        Me.Nome_CliTextBox.Location = New System.Drawing.Point(215, 55)
        Me.Nome_CliTextBox.Name = "Nome_CliTextBox"
        Me.Nome_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nome_CliTextBox.TabIndex = 5
        '
        'Sobrenome_CliTextBox
        '
        Me.Sobrenome_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Sobrenome_Cli", True))
        Me.Sobrenome_CliTextBox.Location = New System.Drawing.Point(215, 81)
        Me.Sobrenome_CliTextBox.Name = "Sobrenome_CliTextBox"
        Me.Sobrenome_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Sobrenome_CliTextBox.TabIndex = 7
        '
        'DataNasc_CliDateTimePicker
        '
        Me.DataNasc_CliDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "DataNasc_Cli", True))
        Me.DataNasc_CliDateTimePicker.Location = New System.Drawing.Point(215, 107)
        Me.DataNasc_CliDateTimePicker.Name = "DataNasc_CliDateTimePicker"
        Me.DataNasc_CliDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataNasc_CliDateTimePicker.TabIndex = 9
        '
        'RG_CliMaskedTextBox
        '
        Me.RG_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "RG_Cli", True))
        Me.RG_CliMaskedTextBox.Location = New System.Drawing.Point(215, 133)
        Me.RG_CliMaskedTextBox.Name = "RG_CliMaskedTextBox"
        Me.RG_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RG_CliMaskedTextBox.TabIndex = 11
        '
        'CPF_CliMaskedTextBox
        '
        Me.CPF_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CPF_Cli", True))
        Me.CPF_CliMaskedTextBox.Location = New System.Drawing.Point(215, 159)
        Me.CPF_CliMaskedTextBox.Name = "CPF_CliMaskedTextBox"
        Me.CPF_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CPF_CliMaskedTextBox.TabIndex = 13
        '
        'Nacionalidade_CliTextBox
        '
        Me.Nacionalidade_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nacionalidade_Cli", True))
        Me.Nacionalidade_CliTextBox.Location = New System.Drawing.Point(215, 185)
        Me.Nacionalidade_CliTextBox.Name = "Nacionalidade_CliTextBox"
        Me.Nacionalidade_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nacionalidade_CliTextBox.TabIndex = 15
        '
        'Cidade_CliTextBox
        '
        Me.Cidade_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Cidade_Cli", True))
        Me.Cidade_CliTextBox.Location = New System.Drawing.Point(215, 211)
        Me.Cidade_CliTextBox.Name = "Cidade_CliTextBox"
        Me.Cidade_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cidade_CliTextBox.TabIndex = 17
        '
        'Estado_CliComboBox
        '
        Me.Estado_CliComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Estado_Cli", True))
        Me.Estado_CliComboBox.FormattingEnabled = True
        Me.Estado_CliComboBox.Location = New System.Drawing.Point(215, 237)
        Me.Estado_CliComboBox.Name = "Estado_CliComboBox"
        Me.Estado_CliComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Estado_CliComboBox.TabIndex = 19
        '
        'CEP_CliMaskedTextBox
        '
        Me.CEP_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CEP_Cli", True))
        Me.CEP_CliMaskedTextBox.Location = New System.Drawing.Point(215, 264)
        Me.CEP_CliMaskedTextBox.Name = "CEP_CliMaskedTextBox"
        Me.CEP_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CEP_CliMaskedTextBox.TabIndex = 21
        '
        'Rua_CliTextBox
        '
        Me.Rua_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Rua_Cli", True))
        Me.Rua_CliTextBox.Location = New System.Drawing.Point(215, 290)
        Me.Rua_CliTextBox.Name = "Rua_CliTextBox"
        Me.Rua_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rua_CliTextBox.TabIndex = 23
        '
        'Nº_CliTextBox
        '
        Me.Nº_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nº_Cli", True))
        Me.Nº_CliTextBox.Location = New System.Drawing.Point(215, 316)
        Me.Nº_CliTextBox.Name = "Nº_CliTextBox"
        Me.Nº_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nº_CliTextBox.TabIndex = 25
        '
        'Bairro_CliTextBox
        '
        Me.Bairro_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Bairro_Cli", True))
        Me.Bairro_CliTextBox.Location = New System.Drawing.Point(215, 342)
        Me.Bairro_CliTextBox.Name = "Bairro_CliTextBox"
        Me.Bairro_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Bairro_CliTextBox.TabIndex = 27
        '
        'Complemento_CliTextBox
        '
        Me.Complemento_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Complemento_Cli", True))
        Me.Complemento_CliTextBox.Location = New System.Drawing.Point(215, 368)
        Me.Complemento_CliTextBox.Name = "Complemento_CliTextBox"
        Me.Complemento_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Complemento_CliTextBox.TabIndex = 29
        '
        'Telefone_CliMaskedTextBox
        '
        Me.Telefone_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telefone_Cli", True))
        Me.Telefone_CliMaskedTextBox.Location = New System.Drawing.Point(215, 394)
        Me.Telefone_CliMaskedTextBox.Name = "Telefone_CliMaskedTextBox"
        Me.Telefone_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Telefone_CliMaskedTextBox.TabIndex = 31
        '
        'Celular_CliMaskedTextBox
        '
        Me.Celular_CliMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Celular_Cli", True))
        Me.Celular_CliMaskedTextBox.Location = New System.Drawing.Point(215, 420)
        Me.Celular_CliMaskedTextBox.Name = "Celular_CliMaskedTextBox"
        Me.Celular_CliMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Celular_CliMaskedTextBox.TabIndex = 33
        '
        'Email_CliTextBox
        '
        Me.Email_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Email_Cli", True))
        Me.Email_CliTextBox.Location = New System.Drawing.Point(215, 446)
        Me.Email_CliTextBox.Name = "Email_CliTextBox"
        Me.Email_CliTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Email_CliTextBox.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.Email_CliTextBox)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.Celular_CliMaskedTextBox)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.Telefone_CliMaskedTextBox)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.Complemento_CliTextBox)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.Bairro_CliTextBox)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Me.Nº_CliTextBox)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(Me.Rua_CliTextBox)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.CEP_CliMaskedTextBox)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Me.Estado_CliComboBox)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Me.Cidade_CliTextBox)
        Me.Panel1.Controls.Add(Label11)
        Me.Panel1.Controls.Add(Me.Nacionalidade_CliTextBox)
        Me.Panel1.Controls.Add(Label12)
        Me.Panel1.Controls.Add(Me.CPF_CliMaskedTextBox)
        Me.Panel1.Controls.Add(Label13)
        Me.Panel1.Controls.Add(Me.RG_CliMaskedTextBox)
        Me.Panel1.Controls.Add(Label14)
        Me.Panel1.Controls.Add(Me.DataNasc_CliDateTimePicker)
        Me.Panel1.Controls.Add(Label15)
        Me.Panel1.Controls.Add(Me.Sobrenome_CliTextBox)
        Me.Panel1.Controls.Add(Label16)
        Me.Panel1.Controls.Add(Me.Nome_CliTextBox)
        Me.Panel1.Controls.Add(Label17)
        Me.Panel1.Controls.Add(Me.Código_CliTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 495)
        Me.Panel1.TabIndex = 36
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label1.Location = New System.Drawing.Point(20, 19)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(85, 33)
        Label1.TabIndex = 37
        Label1.Text = "Código:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label2.Location = New System.Drawing.Point(20, 45)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(76, 33)
        Label2.TabIndex = 38
        Label2.Text = "Nome:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label3.Location = New System.Drawing.Point(20, 71)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(128, 33)
        Label3.TabIndex = 39
        Label3.Text = "Sobrenome:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label4.Location = New System.Drawing.Point(20, 98)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(186, 33)
        Label4.TabIndex = 40
        Label4.Text = "Data Nascimento:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label5.Location = New System.Drawing.Point(20, 123)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(158, 33)
        Label5.TabIndex = 41
        Label5.Text = "Registro Geral:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label6.Location = New System.Drawing.Point(20, 149)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(58, 33)
        Label6.TabIndex = 42
        Label6.Text = "CPF:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label7.Location = New System.Drawing.Point(20, 175)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(154, 33)
        Label7.TabIndex = 43
        Label7.Text = "Nacionalidade:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label8.Location = New System.Drawing.Point(20, 201)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(86, 33)
        Label8.TabIndex = 44
        Label8.Text = "Cidade:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label9.Location = New System.Drawing.Point(20, 227)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(86, 33)
        Label9.TabIndex = 45
        Label9.Text = "Estado:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label10.Location = New System.Drawing.Point(20, 254)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(60, 33)
        Label10.TabIndex = 46
        Label10.Text = "CEP:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label11.Location = New System.Drawing.Point(20, 280)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(58, 33)
        Label11.TabIndex = 47
        Label11.Text = "Rua:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label12.Location = New System.Drawing.Point(20, 306)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(98, 33)
        Label12.TabIndex = 48
        Label12.Text = "Número:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label13.Location = New System.Drawing.Point(20, 332)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(82, 33)
        Label13.TabIndex = 49
        Label13.Text = "Bairro:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label14.Location = New System.Drawing.Point(20, 358)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(153, 33)
        Label14.TabIndex = 50
        Label14.Text = "Complemento:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label15.Location = New System.Drawing.Point(20, 384)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(145, 33)
        Label15.TabIndex = 51
        Label15.Text = "Telefone Fixo:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label16.Location = New System.Drawing.Point(20, 410)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(87, 33)
        Label16.TabIndex = 52
        Label16.Text = "Celular:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label17.Location = New System.Drawing.Point(20, 436)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(74, 33)
        Label17.TabIndex = 53
        Label17.Text = "Email:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label18.Location = New System.Drawing.Point(82, 42)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(178, 33)
        Label18.TabIndex = 38
        Label18.Text = "Busca por nome:"
        '
        'ConsultaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(479, 612)
        Me.Controls.Add(Label18)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConsultaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaClientes"
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
