<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notas_Fiscais
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
        Dim Código_NotaLabel As System.Windows.Forms.Label
        Dim Código_ProdLabel As System.Windows.Forms.Label
        Dim CódCli_NotaLabel As System.Windows.Forms.Label
        Dim RgFun_NotaLabel As System.Windows.Forms.Label
        Dim DatEm_NotaLabel As System.Windows.Forms.Label
        Dim ProdDes_NotaLabel As System.Windows.Forms.Label
        Dim QntProd_NotaLabel As System.Windows.Forms.Label
        Dim FormaPag_NotaLabel As System.Windows.Forms.Label
        Dim Valor_NotaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notas_Fiscais))
        Me.SorveteriaDataSet = New Sorveteria.SorveteriaDataSet
        Me.Nota_FiscalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nota_FiscalTableAdapter = New Sorveteria.SorveteriaDataSetTableAdapters.Nota_FiscalTableAdapter
        Me.TableAdapterManager = New Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
        Me.Nota_FiscalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Nota_FiscalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Código_NotaTextBox = New System.Windows.Forms.TextBox
        Me.Código_ProdTextBox = New System.Windows.Forms.TextBox
        Me.CódCli_NotaTextBox = New System.Windows.Forms.TextBox
        Me.RgFun_NotaMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.DatEm_NotaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ProdDes_NotaTextBox = New System.Windows.Forms.TextBox
        Me.QntProd_NotaTextBox = New System.Windows.Forms.TextBox
        Me.FormaPag_NotaComboBox = New System.Windows.Forms.ComboBox
        Me.Valor_NotaTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Código_NotaLabel = New System.Windows.Forms.Label
        Código_ProdLabel = New System.Windows.Forms.Label
        CódCli_NotaLabel = New System.Windows.Forms.Label
        RgFun_NotaLabel = New System.Windows.Forms.Label
        DatEm_NotaLabel = New System.Windows.Forms.Label
        ProdDes_NotaLabel = New System.Windows.Forms.Label
        QntProd_NotaLabel = New System.Windows.Forms.Label
        FormaPag_NotaLabel = New System.Windows.Forms.Label
        Valor_NotaLabel = New System.Windows.Forms.Label
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nota_FiscalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nota_FiscalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Nota_FiscalBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Código_NotaLabel
        '
        Código_NotaLabel.AutoSize = True
        Código_NotaLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Código_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Código_NotaLabel.Location = New System.Drawing.Point(26, 41)
        Código_NotaLabel.Name = "Código_NotaLabel"
        Código_NotaLabel.Size = New System.Drawing.Size(85, 33)
        Código_NotaLabel.TabIndex = 1
        Código_NotaLabel.Text = "Código:"
        '
        'Código_ProdLabel
        '
        Código_ProdLabel.AutoSize = True
        Código_ProdLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Código_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Código_ProdLabel.Location = New System.Drawing.Point(26, 67)
        Código_ProdLabel.Name = "Código_ProdLabel"
        Código_ProdLabel.Size = New System.Drawing.Size(100, 33)
        Código_ProdLabel.TabIndex = 3
        Código_ProdLabel.Text = "Produto:"
        '
        'CódCli_NotaLabel
        '
        CódCli_NotaLabel.AutoSize = True
        CódCli_NotaLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CódCli_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CódCli_NotaLabel.Location = New System.Drawing.Point(26, 93)
        CódCli_NotaLabel.Name = "CódCli_NotaLabel"
        CódCli_NotaLabel.Size = New System.Drawing.Size(86, 33)
        CódCli_NotaLabel.TabIndex = 5
        CódCli_NotaLabel.Text = "Cliente:"
        '
        'RgFun_NotaLabel
        '
        RgFun_NotaLabel.AutoSize = True
        RgFun_NotaLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        RgFun_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        RgFun_NotaLabel.Location = New System.Drawing.Point(26, 119)
        RgFun_NotaLabel.Name = "RgFun_NotaLabel"
        RgFun_NotaLabel.Size = New System.Drawing.Size(170, 33)
        RgFun_NotaLabel.TabIndex = 7
        RgFun_NotaLabel.Text = "RG Funcionário:"
        '
        'DatEm_NotaLabel
        '
        DatEm_NotaLabel.AutoSize = True
        DatEm_NotaLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DatEm_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DatEm_NotaLabel.Location = New System.Drawing.Point(26, 146)
        DatEm_NotaLabel.Name = "DatEm_NotaLabel"
        DatEm_NotaLabel.Size = New System.Drawing.Size(150, 33)
        DatEm_NotaLabel.TabIndex = 9
        DatEm_NotaLabel.Text = "Data Emissão:"
        '
        'ProdDes_NotaLabel
        '
        ProdDes_NotaLabel.AutoSize = True
        ProdDes_NotaLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        ProdDes_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ProdDes_NotaLabel.Location = New System.Drawing.Point(26, 171)
        ProdDes_NotaLabel.Name = "ProdDes_NotaLabel"
        ProdDes_NotaLabel.Size = New System.Drawing.Size(111, 33)
        ProdDes_NotaLabel.TabIndex = 11
        ProdDes_NotaLabel.Text = "Descrição:"
        '
        'QntProd_NotaLabel
        '
        QntProd_NotaLabel.AutoSize = True
        QntProd_NotaLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        QntProd_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        QntProd_NotaLabel.Location = New System.Drawing.Point(26, 197)
        QntProd_NotaLabel.Name = "QntProd_NotaLabel"
        QntProd_NotaLabel.Size = New System.Drawing.Size(145, 33)
        QntProd_NotaLabel.TabIndex = 13
        QntProd_NotaLabel.Text = "Qtd Produto:"
        '
        'FormaPag_NotaLabel
        '
        FormaPag_NotaLabel.AutoSize = True
        FormaPag_NotaLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        FormaPag_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        FormaPag_NotaLabel.Location = New System.Drawing.Point(26, 223)
        FormaPag_NotaLabel.Name = "FormaPag_NotaLabel"
        FormaPag_NotaLabel.Size = New System.Drawing.Size(199, 33)
        FormaPag_NotaLabel.TabIndex = 15
        FormaPag_NotaLabel.Text = "Forma Pagamento:"
        '
        'Valor_NotaLabel
        '
        Valor_NotaLabel.AutoSize = True
        Valor_NotaLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Valor_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Valor_NotaLabel.Location = New System.Drawing.Point(26, 250)
        Valor_NotaLabel.Name = "Valor_NotaLabel"
        Valor_NotaLabel.Size = New System.Drawing.Size(72, 33)
        Valor_NotaLabel.TabIndex = 17
        Valor_NotaLabel.Text = "Valor:"
        '
        'SorveteriaDataSet
        '
        Me.SorveteriaDataSet.DataSetName = "SorveteriaDataSet"
        Me.SorveteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nota_FiscalBindingSource
        '
        Me.Nota_FiscalBindingSource.DataMember = "Nota_Fiscal"
        Me.Nota_FiscalBindingSource.DataSource = Me.SorveteriaDataSet
        '
        'Nota_FiscalTableAdapter
        '
        Me.Nota_FiscalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.FuncionáriosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Nota_FiscalTableAdapter = Me.Nota_FiscalTableAdapter
        Me.TableAdapterManager.ProdutoTableAdapter = Nothing
        Me.TableAdapterManager.TransportadoraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'Nota_FiscalBindingNavigator
        '
        Me.Nota_FiscalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Nota_FiscalBindingNavigator.BindingSource = Me.Nota_FiscalBindingSource
        Me.Nota_FiscalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Nota_FiscalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Nota_FiscalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Nota_FiscalBindingNavigatorSaveItem})
        Me.Nota_FiscalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Nota_FiscalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Nota_FiscalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Nota_FiscalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Nota_FiscalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Nota_FiscalBindingNavigator.Name = "Nota_FiscalBindingNavigator"
        Me.Nota_FiscalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Nota_FiscalBindingNavigator.Size = New System.Drawing.Size(450, 25)
        Me.Nota_FiscalBindingNavigator.TabIndex = 0
        Me.Nota_FiscalBindingNavigator.Text = "BindingNavigator1"
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
        'Nota_FiscalBindingNavigatorSaveItem
        '
        Me.Nota_FiscalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nota_FiscalBindingNavigatorSaveItem.Image = CType(resources.GetObject("Nota_FiscalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Nota_FiscalBindingNavigatorSaveItem.Name = "Nota_FiscalBindingNavigatorSaveItem"
        Me.Nota_FiscalBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Nota_FiscalBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Código_NotaTextBox
        '
        Me.Código_NotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nota_FiscalBindingSource, "Código_Nota", True))
        Me.Código_NotaTextBox.Location = New System.Drawing.Point(238, 54)
        Me.Código_NotaTextBox.Name = "Código_NotaTextBox"
        Me.Código_NotaTextBox.ReadOnly = True
        Me.Código_NotaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Código_NotaTextBox.TabIndex = 2
        Me.Código_NotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Código_ProdTextBox
        '
        Me.Código_ProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nota_FiscalBindingSource, "Código_Prod", True))
        Me.Código_ProdTextBox.Location = New System.Drawing.Point(238, 80)
        Me.Código_ProdTextBox.Name = "Código_ProdTextBox"
        Me.Código_ProdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Código_ProdTextBox.TabIndex = 4
        Me.Código_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CódCli_NotaTextBox
        '
        Me.CódCli_NotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nota_FiscalBindingSource, "CódCli_Nota", True))
        Me.CódCli_NotaTextBox.Location = New System.Drawing.Point(238, 106)
        Me.CódCli_NotaTextBox.Name = "CódCli_NotaTextBox"
        Me.CódCli_NotaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CódCli_NotaTextBox.TabIndex = 6
        Me.CódCli_NotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RgFun_NotaMaskedTextBox
        '
        Me.RgFun_NotaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nota_FiscalBindingSource, "RgFun_Nota", True))
        Me.RgFun_NotaMaskedTextBox.Location = New System.Drawing.Point(238, 132)
        Me.RgFun_NotaMaskedTextBox.Name = "RgFun_NotaMaskedTextBox"
        Me.RgFun_NotaMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RgFun_NotaMaskedTextBox.TabIndex = 8
        Me.RgFun_NotaMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DatEm_NotaDateTimePicker
        '
        Me.DatEm_NotaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Nota_FiscalBindingSource, "DatEm_Nota", True))
        Me.DatEm_NotaDateTimePicker.Location = New System.Drawing.Point(238, 158)
        Me.DatEm_NotaDateTimePicker.Name = "DatEm_NotaDateTimePicker"
        Me.DatEm_NotaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatEm_NotaDateTimePicker.TabIndex = 10
        '
        'ProdDes_NotaTextBox
        '
        Me.ProdDes_NotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nota_FiscalBindingSource, "ProdDes_Nota", True))
        Me.ProdDes_NotaTextBox.Location = New System.Drawing.Point(238, 184)
        Me.ProdDes_NotaTextBox.Name = "ProdDes_NotaTextBox"
        Me.ProdDes_NotaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProdDes_NotaTextBox.TabIndex = 12
        Me.ProdDes_NotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QntProd_NotaTextBox
        '
        Me.QntProd_NotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nota_FiscalBindingSource, "QntProd_Nota", True))
        Me.QntProd_NotaTextBox.Location = New System.Drawing.Point(238, 210)
        Me.QntProd_NotaTextBox.Name = "QntProd_NotaTextBox"
        Me.QntProd_NotaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QntProd_NotaTextBox.TabIndex = 14
        Me.QntProd_NotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormaPag_NotaComboBox
        '
        Me.FormaPag_NotaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nota_FiscalBindingSource, "FormaPag_Nota", True))
        Me.FormaPag_NotaComboBox.FormattingEnabled = True
        Me.FormaPag_NotaComboBox.Items.AddRange(New Object() {"À vista", "Crédito", "Debito ", "Outro"})
        Me.FormaPag_NotaComboBox.Location = New System.Drawing.Point(238, 236)
        Me.FormaPag_NotaComboBox.Name = "FormaPag_NotaComboBox"
        Me.FormaPag_NotaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.FormaPag_NotaComboBox.TabIndex = 16
        '
        'Valor_NotaTextBox
        '
        Me.Valor_NotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nota_FiscalBindingSource, "Valor_Nota", True))
        Me.Valor_NotaTextBox.Location = New System.Drawing.Point(238, 263)
        Me.Valor_NotaTextBox.Name = "Valor_NotaTextBox"
        Me.Valor_NotaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Valor_NotaTextBox.TabIndex = 18
        Me.Valor_NotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Location = New System.Drawing.Point(342, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "&Fechar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Notas_Fiscais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(450, 358)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Código_NotaLabel)
        Me.Controls.Add(Me.Código_NotaTextBox)
        Me.Controls.Add(Código_ProdLabel)
        Me.Controls.Add(Me.Código_ProdTextBox)
        Me.Controls.Add(CódCli_NotaLabel)
        Me.Controls.Add(Me.CódCli_NotaTextBox)
        Me.Controls.Add(RgFun_NotaLabel)
        Me.Controls.Add(Me.RgFun_NotaMaskedTextBox)
        Me.Controls.Add(DatEm_NotaLabel)
        Me.Controls.Add(Me.DatEm_NotaDateTimePicker)
        Me.Controls.Add(ProdDes_NotaLabel)
        Me.Controls.Add(Me.ProdDes_NotaTextBox)
        Me.Controls.Add(QntProd_NotaLabel)
        Me.Controls.Add(Me.QntProd_NotaTextBox)
        Me.Controls.Add(FormaPag_NotaLabel)
        Me.Controls.Add(Me.FormaPag_NotaComboBox)
        Me.Controls.Add(Valor_NotaLabel)
        Me.Controls.Add(Me.Valor_NotaTextBox)
        Me.Controls.Add(Me.Nota_FiscalBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Notas_Fiscais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas Fiscais"
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nota_FiscalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nota_FiscalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Nota_FiscalBindingNavigator.ResumeLayout(False)
        Me.Nota_FiscalBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SorveteriaDataSet As Sorveteria.SorveteriaDataSet
    Friend WithEvents Nota_FiscalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nota_FiscalTableAdapter As Sorveteria.SorveteriaDataSetTableAdapters.Nota_FiscalTableAdapter
    Friend WithEvents TableAdapterManager As Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Nota_FiscalBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Nota_FiscalBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Código_NotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Código_ProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CódCli_NotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RgFun_NotaMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DatEm_NotaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProdDes_NotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QntProd_NotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FormaPag_NotaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Valor_NotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
