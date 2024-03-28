<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcadeditoras
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
        Dim IdEditoraLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Dim FoneLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcadeditoras))
        Me.BDSystem1DataSet = New RUBIAPPLICATION.BDSystem1DataSet
        Me.EditoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EditoraTableAdapter = New RUBIAPPLICATION.BDSystem1DataSetTableAdapters.EditoraTableAdapter
        Me.TableAdapterManager = New RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager
        Me.EditoraBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EditoraBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IdEditoraTextBox = New System.Windows.Forms.TextBox
        Me.NomeTextBox = New System.Windows.Forms.TextBox
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox
        Me.BairroTextBox = New System.Windows.Forms.TextBox
        Me.CidadeTextBox = New System.Windows.Forms.TextBox
        Me.UFComboBox = New System.Windows.Forms.ComboBox
        Me.FoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        IdEditoraLabel = New System.Windows.Forms.Label
        NomeLabel = New System.Windows.Forms.Label
        EndereçoLabel = New System.Windows.Forms.Label
        BairroLabel = New System.Windows.Forms.Label
        CidadeLabel = New System.Windows.Forms.Label
        UFLabel = New System.Windows.Forms.Label
        FoneLabel = New System.Windows.Forms.Label
        CEPLabel = New System.Windows.Forms.Label
        CNPJLabel = New System.Windows.Forms.Label
        CType(Me.BDSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditoraBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditoraBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdEditoraLabel
        '
        IdEditoraLabel.AutoSize = True
        IdEditoraLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        IdEditoraLabel.Location = New System.Drawing.Point(24, 22)
        IdEditoraLabel.Name = "IdEditoraLabel"
        IdEditoraLabel.Size = New System.Drawing.Size(70, 18)
        IdEditoraLabel.TabIndex = 1
        IdEditoraLabel.Text = "Código:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        NomeLabel.Location = New System.Drawing.Point(24, 46)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(58, 18)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        EndereçoLabel.Location = New System.Drawing.Point(24, 72)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(84, 18)
        EndereçoLabel.TabIndex = 5
        EndereçoLabel.Text = "Endereço:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        BairroLabel.Location = New System.Drawing.Point(24, 98)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(57, 18)
        BairroLabel.TabIndex = 7
        BairroLabel.Text = "Bairro:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        CidadeLabel.Location = New System.Drawing.Point(24, 123)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(69, 18)
        CidadeLabel.TabIndex = 9
        CidadeLabel.Text = "Cidade:"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        UFLabel.Location = New System.Drawing.Point(24, 150)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(65, 18)
        UFLabel.TabIndex = 11
        UFLabel.Text = "Estado:"
        '
        'FoneLabel
        '
        FoneLabel.AutoSize = True
        FoneLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        FoneLabel.Location = New System.Drawing.Point(24, 176)
        FoneLabel.Name = "FoneLabel"
        FoneLabel.Size = New System.Drawing.Size(78, 18)
        FoneLabel.TabIndex = 13
        FoneLabel.Text = "Telefone:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        CEPLabel.Location = New System.Drawing.Point(24, 202)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(42, 18)
        CEPLabel.TabIndex = 15
        CEPLabel.Text = "CEP:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        CNPJLabel.Location = New System.Drawing.Point(24, 228)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(51, 18)
        CNPJLabel.TabIndex = 17
        CNPJLabel.Text = "CNPJ:"
        '
        'BDSystem1DataSet
        '
        Me.BDSystem1DataSet.DataSetName = "BDSystem1DataSet"
        Me.BDSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EditoraBindingSource
        '
        Me.EditoraBindingSource.DataMember = "Editora"
        Me.EditoraBindingSource.DataSource = Me.BDSystem1DataSet
        '
        'EditoraTableAdapter
        '
        Me.EditoraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EditoraTableAdapter = Me.EditoraTableAdapter
        Me.TableAdapterManager.FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.Item_LocaçãoTableAdapter = Nothing
        Me.TableAdapterManager.LivroTableAdapter = Nothing
        Me.TableAdapterManager.LocaçãoTableAdapter = Nothing
        Me.TableAdapterManager.LocatárioTableAdapter = Nothing
        Me.TableAdapterManager.PerfilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EditoraBindingNavigator
        '
        Me.EditoraBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EditoraBindingNavigator.BindingSource = Me.EditoraBindingSource
        Me.EditoraBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EditoraBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EditoraBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EditoraBindingNavigatorSaveItem})
        Me.EditoraBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EditoraBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EditoraBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EditoraBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EditoraBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EditoraBindingNavigator.Name = "EditoraBindingNavigator"
        Me.EditoraBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EditoraBindingNavigator.Size = New System.Drawing.Size(359, 25)
        Me.EditoraBindingNavigator.TabIndex = 0
        Me.EditoraBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        'EditoraBindingNavigatorSaveItem
        '
        Me.EditoraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditoraBindingNavigatorSaveItem.Image = CType(resources.GetObject("EditoraBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EditoraBindingNavigatorSaveItem.Name = "EditoraBindingNavigatorSaveItem"
        Me.EditoraBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EditoraBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdEditoraTextBox
        '
        Me.IdEditoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditoraBindingSource, "IdEditora", True))
        Me.IdEditoraTextBox.Location = New System.Drawing.Point(144, 20)
        Me.IdEditoraTextBox.Name = "IdEditoraTextBox"
        Me.IdEditoraTextBox.ReadOnly = True
        Me.IdEditoraTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IdEditoraTextBox.TabIndex = 1
        Me.IdEditoraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditoraBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(144, 46)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NomeTextBox.TabIndex = 2
        Me.NomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditoraBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(144, 72)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EndereçoTextBox.TabIndex = 3
        Me.EndereçoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditoraBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(144, 98)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BairroTextBox.TabIndex = 4
        Me.BairroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditoraBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(144, 124)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CidadeTextBox.TabIndex = 5
        Me.CidadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UFComboBox
        '
        Me.UFComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditoraBindingSource, "UF", True))
        Me.UFComboBox.FormattingEnabled = True
        Me.UFComboBox.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BH", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.UFComboBox.Location = New System.Drawing.Point(144, 150)
        Me.UFComboBox.Name = "UFComboBox"
        Me.UFComboBox.Size = New System.Drawing.Size(121, 21)
        Me.UFComboBox.TabIndex = 6
        '
        'FoneMaskedTextBox
        '
        Me.FoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditoraBindingSource, "Fone", True))
        Me.FoneMaskedTextBox.Location = New System.Drawing.Point(144, 177)
        Me.FoneMaskedTextBox.Mask = "(00)0000-0000"
        Me.FoneMaskedTextBox.Name = "FoneMaskedTextBox"
        Me.FoneMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.FoneMaskedTextBox.TabIndex = 7
        Me.FoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditoraBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(144, 203)
        Me.CEPMaskedTextBox.Mask = "00,000-000              "
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CEPMaskedTextBox.TabIndex = 8
        Me.CEPMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditoraBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(144, 229)
        Me.CNPJMaskedTextBox.Mask = "00,000,000/0000-00                    "
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CNPJMaskedTextBox.TabIndex = 9
        Me.CNPJMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(28, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(297, 297)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage1.Controls.Add(Me.CNPJMaskedTextBox)
        Me.TabPage1.Controls.Add(IdEditoraLabel)
        Me.TabPage1.Controls.Add(CNPJLabel)
        Me.TabPage1.Controls.Add(Me.IdEditoraTextBox)
        Me.TabPage1.Controls.Add(Me.CEPMaskedTextBox)
        Me.TabPage1.Controls.Add(NomeLabel)
        Me.TabPage1.Controls.Add(CEPLabel)
        Me.TabPage1.Controls.Add(Me.NomeTextBox)
        Me.TabPage1.Controls.Add(Me.FoneMaskedTextBox)
        Me.TabPage1.Controls.Add(EndereçoLabel)
        Me.TabPage1.Controls.Add(FoneLabel)
        Me.TabPage1.Controls.Add(Me.EndereçoTextBox)
        Me.TabPage1.Controls.Add(Me.UFComboBox)
        Me.TabPage1.Controls.Add(BairroLabel)
        Me.TabPage1.Controls.Add(UFLabel)
        Me.TabPage1.Controls.Add(Me.BairroTextBox)
        Me.TabPage1.Controls.Add(Me.CidadeTextBox)
        Me.TabPage1.Controls.Add(CidadeLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(289, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Gerais"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(289, 271)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Comentários"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -8
        Me.LineShape1.X2 = 357
        Me.LineShape1.Y1 = 392
        Me.LineShape1.Y2 = 392
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(359, 436)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(232, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "&Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button1, "Cancelar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frmcadeditoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(359, 436)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.EditoraBindingNavigator)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmcadeditoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Editoras"
        CType(Me.BDSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditoraBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditoraBindingNavigator.ResumeLayout(False)
        Me.EditoraBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BDSystem1DataSet As RUBIAPPLICATION.BDSystem1DataSet
    Friend WithEvents EditoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EditoraTableAdapter As RUBIAPPLICATION.BDSystem1DataSetTableAdapters.EditoraTableAdapter
    Friend WithEvents TableAdapterManager As RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EditoraBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EditoraBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdEditoraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndereçoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UFComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CEPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CNPJMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
