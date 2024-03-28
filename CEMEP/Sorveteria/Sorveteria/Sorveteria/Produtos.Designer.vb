<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produtos
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
        Dim Código_ProdLabel As System.Windows.Forms.Label
        Dim CódigoCli_ProdLabel As System.Windows.Forms.Label
        Dim CódForn_ProdLabel As System.Windows.Forms.Label
        Dim DataDeValidade_ProdLabel As System.Windows.Forms.Label
        Dim Tipo_ProdLabel As System.Windows.Forms.Label
        Dim Quantidade_ProdLabel As System.Windows.Forms.Label
        Dim Sabor_ProdLabel As System.Windows.Forms.Label
        Dim Valor_ProdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produtos))
        Me.SorveteriaDataSet = New Sorveteria.SorveteriaDataSet
        Me.ProdutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutoTableAdapter = New Sorveteria.SorveteriaDataSetTableAdapters.ProdutoTableAdapter
        Me.TableAdapterManager = New Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
        Me.ProdutoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProdutoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Código_ProdTextBox = New System.Windows.Forms.TextBox
        Me.CódigoCli_ProdTextBox = New System.Windows.Forms.TextBox
        Me.CódForn_ProdTextBox = New System.Windows.Forms.TextBox
        Me.DataDeValidade_ProdDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Tipo_ProdComboBox = New System.Windows.Forms.ComboBox
        Me.Quantidade_ProdTextBox = New System.Windows.Forms.TextBox
        Me.Sabor_ProdComboBox = New System.Windows.Forms.ComboBox
        Me.Valor_ProdTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Código_ProdLabel = New System.Windows.Forms.Label
        CódigoCli_ProdLabel = New System.Windows.Forms.Label
        CódForn_ProdLabel = New System.Windows.Forms.Label
        DataDeValidade_ProdLabel = New System.Windows.Forms.Label
        Tipo_ProdLabel = New System.Windows.Forms.Label
        Quantidade_ProdLabel = New System.Windows.Forms.Label
        Sabor_ProdLabel = New System.Windows.Forms.Label
        Valor_ProdLabel = New System.Windows.Forms.Label
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdutoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Código_ProdLabel
        '
        Código_ProdLabel.AutoSize = True
        Código_ProdLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Código_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Código_ProdLabel.Location = New System.Drawing.Point(31, 52)
        Código_ProdLabel.Name = "Código_ProdLabel"
        Código_ProdLabel.Size = New System.Drawing.Size(85, 33)
        Código_ProdLabel.TabIndex = 1
        Código_ProdLabel.Text = "Código:"
        '
        'CódigoCli_ProdLabel
        '
        CódigoCli_ProdLabel.AutoSize = True
        CódigoCli_ProdLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CódigoCli_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CódigoCli_ProdLabel.Location = New System.Drawing.Point(31, 78)
        CódigoCli_ProdLabel.Name = "CódigoCli_ProdLabel"
        CódigoCli_ProdLabel.Size = New System.Drawing.Size(86, 33)
        CódigoCli_ProdLabel.TabIndex = 3
        CódigoCli_ProdLabel.Text = "Cliente:"
        '
        'CódForn_ProdLabel
        '
        CódForn_ProdLabel.AutoSize = True
        CódForn_ProdLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CódForn_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CódForn_ProdLabel.Location = New System.Drawing.Point(31, 104)
        CódForn_ProdLabel.Name = "CódForn_ProdLabel"
        CódForn_ProdLabel.Size = New System.Drawing.Size(130, 33)
        CódForn_ProdLabel.TabIndex = 5
        CódForn_ProdLabel.Text = "Fornecedor:"
        '
        'DataDeValidade_ProdLabel
        '
        DataDeValidade_ProdLabel.AutoSize = True
        DataDeValidade_ProdLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataDeValidade_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataDeValidade_ProdLabel.Location = New System.Drawing.Point(31, 131)
        DataDeValidade_ProdLabel.Name = "DataDeValidade_ProdLabel"
        DataDeValidade_ProdLabel.Size = New System.Drawing.Size(190, 33)
        DataDeValidade_ProdLabel.TabIndex = 7
        DataDeValidade_ProdLabel.Text = "Data De Validade:"
        '
        'Tipo_ProdLabel
        '
        Tipo_ProdLabel.AutoSize = True
        Tipo_ProdLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Tipo_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Tipo_ProdLabel.Location = New System.Drawing.Point(31, 156)
        Tipo_ProdLabel.Name = "Tipo_ProdLabel"
        Tipo_ProdLabel.Size = New System.Drawing.Size(62, 33)
        Tipo_ProdLabel.TabIndex = 9
        Tipo_ProdLabel.Text = "Tipo:"
        '
        'Quantidade_ProdLabel
        '
        Quantidade_ProdLabel.AutoSize = True
        Quantidade_ProdLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Quantidade_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Quantidade_ProdLabel.Location = New System.Drawing.Point(31, 183)
        Quantidade_ProdLabel.Name = "Quantidade_ProdLabel"
        Quantidade_ProdLabel.Size = New System.Drawing.Size(133, 33)
        Quantidade_ProdLabel.TabIndex = 11
        Quantidade_ProdLabel.Text = "Quantidade:"
        '
        'Sabor_ProdLabel
        '
        Sabor_ProdLabel.AutoSize = True
        Sabor_ProdLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Sabor_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Sabor_ProdLabel.Location = New System.Drawing.Point(31, 209)
        Sabor_ProdLabel.Name = "Sabor_ProdLabel"
        Sabor_ProdLabel.Size = New System.Drawing.Size(94, 33)
        Sabor_ProdLabel.TabIndex = 13
        Sabor_ProdLabel.Text = "Sabores:"
        '
        'Valor_ProdLabel
        '
        Valor_ProdLabel.AutoSize = True
        Valor_ProdLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Valor_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Valor_ProdLabel.Location = New System.Drawing.Point(31, 236)
        Valor_ProdLabel.Name = "Valor_ProdLabel"
        Valor_ProdLabel.Size = New System.Drawing.Size(72, 33)
        Valor_ProdLabel.TabIndex = 15
        Valor_ProdLabel.Text = "Valor:"
        '
        'SorveteriaDataSet
        '
        Me.SorveteriaDataSet.DataSetName = "SorveteriaDataSet"
        Me.SorveteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdutoBindingSource
        '
        Me.ProdutoBindingSource.DataMember = "Produto"
        Me.ProdutoBindingSource.DataSource = Me.SorveteriaDataSet
        '
        'ProdutoTableAdapter
        '
        Me.ProdutoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.FuncionáriosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Nota_FiscalTableAdapter = Nothing
        Me.TableAdapterManager.ProdutoTableAdapter = Me.ProdutoTableAdapter
        Me.TableAdapterManager.TransportadoraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'ProdutoBindingNavigator
        '
        Me.ProdutoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProdutoBindingNavigator.BindingSource = Me.ProdutoBindingSource
        Me.ProdutoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProdutoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProdutoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProdutoBindingNavigatorSaveItem})
        Me.ProdutoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProdutoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProdutoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProdutoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProdutoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProdutoBindingNavigator.Name = "ProdutoBindingNavigator"
        Me.ProdutoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProdutoBindingNavigator.Size = New System.Drawing.Size(450, 25)
        Me.ProdutoBindingNavigator.TabIndex = 0
        Me.ProdutoBindingNavigator.Text = "BindingNavigator1"
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
        'ProdutoBindingNavigatorSaveItem
        '
        Me.ProdutoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProdutoBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProdutoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProdutoBindingNavigatorSaveItem.Name = "ProdutoBindingNavigatorSaveItem"
        Me.ProdutoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProdutoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Código_ProdTextBox
        '
        Me.Código_ProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutoBindingSource, "Código_Prod", True))
        Me.Código_ProdTextBox.Location = New System.Drawing.Point(222, 62)
        Me.Código_ProdTextBox.Name = "Código_ProdTextBox"
        Me.Código_ProdTextBox.ReadOnly = True
        Me.Código_ProdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Código_ProdTextBox.TabIndex = 2
        Me.Código_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CódigoCli_ProdTextBox
        '
        Me.CódigoCli_ProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutoBindingSource, "CódigoCli_Prod", True))
        Me.CódigoCli_ProdTextBox.Location = New System.Drawing.Point(222, 88)
        Me.CódigoCli_ProdTextBox.Name = "CódigoCli_ProdTextBox"
        Me.CódigoCli_ProdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CódigoCli_ProdTextBox.TabIndex = 4
        Me.CódigoCli_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CódForn_ProdTextBox
        '
        Me.CódForn_ProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutoBindingSource, "CódForn_Prod", True))
        Me.CódForn_ProdTextBox.Location = New System.Drawing.Point(222, 114)
        Me.CódForn_ProdTextBox.Name = "CódForn_ProdTextBox"
        Me.CódForn_ProdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CódForn_ProdTextBox.TabIndex = 6
        Me.CódForn_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataDeValidade_ProdDateTimePicker
        '
        Me.DataDeValidade_ProdDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProdutoBindingSource, "DataDeValidade_Prod", True))
        Me.DataDeValidade_ProdDateTimePicker.Location = New System.Drawing.Point(222, 140)
        Me.DataDeValidade_ProdDateTimePicker.Name = "DataDeValidade_ProdDateTimePicker"
        Me.DataDeValidade_ProdDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDeValidade_ProdDateTimePicker.TabIndex = 8
        '
        'Tipo_ProdComboBox
        '
        Me.Tipo_ProdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutoBindingSource, "Tipo_Prod", True))
        Me.Tipo_ProdComboBox.FormattingEnabled = True
        Me.Tipo_ProdComboBox.Items.AddRange(New Object() {"Banana Split", "Cestinha Tradicional", "Massa 1 bola", "Massa 2 bolas", "Massa 3 bolas", "Picolé", "Sunday"})
        Me.Tipo_ProdComboBox.Location = New System.Drawing.Point(222, 166)
        Me.Tipo_ProdComboBox.Name = "Tipo_ProdComboBox"
        Me.Tipo_ProdComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Tipo_ProdComboBox.TabIndex = 10
        '
        'Quantidade_ProdTextBox
        '
        Me.Quantidade_ProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutoBindingSource, "Quantidade_Prod", True))
        Me.Quantidade_ProdTextBox.Location = New System.Drawing.Point(222, 193)
        Me.Quantidade_ProdTextBox.Name = "Quantidade_ProdTextBox"
        Me.Quantidade_ProdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Quantidade_ProdTextBox.TabIndex = 12
        Me.Quantidade_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sabor_ProdComboBox
        '
        Me.Sabor_ProdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutoBindingSource, "Sabor_Prod", True))
        Me.Sabor_ProdComboBox.FormattingEnabled = True
        Me.Sabor_ProdComboBox.Items.AddRange(New Object() {"Baunilha", "Chocolate", "Creme", "Flocos", "Leite Ninho", "Menta", "Morango", "Pistache"})
        Me.Sabor_ProdComboBox.Location = New System.Drawing.Point(222, 219)
        Me.Sabor_ProdComboBox.Name = "Sabor_ProdComboBox"
        Me.Sabor_ProdComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Sabor_ProdComboBox.TabIndex = 14
        '
        'Valor_ProdTextBox
        '
        Me.Valor_ProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutoBindingSource, "Valor_Prod", True))
        Me.Valor_ProdTextBox.Location = New System.Drawing.Point(222, 246)
        Me.Valor_ProdTextBox.Name = "Valor_ProdTextBox"
        Me.Valor_ProdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Valor_ProdTextBox.TabIndex = 16
        Me.Valor_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Location = New System.Drawing.Point(347, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "&Fechar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(450, 336)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Código_ProdLabel)
        Me.Controls.Add(Me.Código_ProdTextBox)
        Me.Controls.Add(CódigoCli_ProdLabel)
        Me.Controls.Add(Me.CódigoCli_ProdTextBox)
        Me.Controls.Add(CódForn_ProdLabel)
        Me.Controls.Add(Me.CódForn_ProdTextBox)
        Me.Controls.Add(DataDeValidade_ProdLabel)
        Me.Controls.Add(Me.DataDeValidade_ProdDateTimePicker)
        Me.Controls.Add(Tipo_ProdLabel)
        Me.Controls.Add(Me.Tipo_ProdComboBox)
        Me.Controls.Add(Quantidade_ProdLabel)
        Me.Controls.Add(Me.Quantidade_ProdTextBox)
        Me.Controls.Add(Sabor_ProdLabel)
        Me.Controls.Add(Me.Sabor_ProdComboBox)
        Me.Controls.Add(Valor_ProdLabel)
        Me.Controls.Add(Me.Valor_ProdTextBox)
        Me.Controls.Add(Me.ProdutoBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Produtos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdutoBindingNavigator.ResumeLayout(False)
        Me.ProdutoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SorveteriaDataSet As Sorveteria.SorveteriaDataSet
    Friend WithEvents ProdutoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdutoTableAdapter As Sorveteria.SorveteriaDataSetTableAdapters.ProdutoTableAdapter
    Friend WithEvents TableAdapterManager As Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProdutoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProdutoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Código_ProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CódigoCli_ProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CódForn_ProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDeValidade_ProdDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tipo_ProdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Quantidade_ProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sabor_ProdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Valor_ProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
