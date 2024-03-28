<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendas
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
        Dim Código_VendLabel As System.Windows.Forms.Label
        Dim Produto_VendLabel As System.Windows.Forms.Label
        Dim Cliente_VendLabel As System.Windows.Forms.Label
        Dim Quantidade_VendLabel As System.Windows.Forms.Label
        Dim Funcionario_VendLabel As System.Windows.Forms.Label
        Dim Data_VendLabel As System.Windows.Forms.Label
        Dim Nota_Fiscal_VendLabel As System.Windows.Forms.Label
        Dim Valor_VendLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendas))
        Me.SorveteriaDataSet = New Sorveteria.SorveteriaDataSet
        Me.VendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasTableAdapter = New Sorveteria.SorveteriaDataSetTableAdapters.VendasTableAdapter
        Me.TableAdapterManager = New Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
        Me.VendasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VendasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Código_VendTextBox = New System.Windows.Forms.TextBox
        Me.Produto_VendTextBox = New System.Windows.Forms.TextBox
        Me.Cliente_VendTextBox = New System.Windows.Forms.TextBox
        Me.Quantidade_VendTextBox = New System.Windows.Forms.TextBox
        Me.Funcionario_VendTextBox = New System.Windows.Forms.TextBox
        Me.Data_VendDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Nota_Fiscal_VendTextBox = New System.Windows.Forms.TextBox
        Me.Valor_VendTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Código_VendLabel = New System.Windows.Forms.Label
        Produto_VendLabel = New System.Windows.Forms.Label
        Cliente_VendLabel = New System.Windows.Forms.Label
        Quantidade_VendLabel = New System.Windows.Forms.Label
        Funcionario_VendLabel = New System.Windows.Forms.Label
        Data_VendLabel = New System.Windows.Forms.Label
        Nota_Fiscal_VendLabel = New System.Windows.Forms.Label
        Valor_VendLabel = New System.Windows.Forms.Label
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VendasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Código_VendLabel
        '
        Código_VendLabel.AutoSize = True
        Código_VendLabel.BackColor = System.Drawing.Color.Indigo
        Código_VendLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Código_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Código_VendLabel.Location = New System.Drawing.Point(36, 52)
        Código_VendLabel.Name = "Código_VendLabel"
        Código_VendLabel.Size = New System.Drawing.Size(85, 33)
        Código_VendLabel.TabIndex = 1
        Código_VendLabel.Text = "Código:"
        '
        'Produto_VendLabel
        '
        Produto_VendLabel.AutoSize = True
        Produto_VendLabel.BackColor = System.Drawing.Color.Indigo
        Produto_VendLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Produto_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Produto_VendLabel.Location = New System.Drawing.Point(36, 78)
        Produto_VendLabel.Name = "Produto_VendLabel"
        Produto_VendLabel.Size = New System.Drawing.Size(100, 33)
        Produto_VendLabel.TabIndex = 3
        Produto_VendLabel.Text = "Produto:"
        '
        'Cliente_VendLabel
        '
        Cliente_VendLabel.AutoSize = True
        Cliente_VendLabel.BackColor = System.Drawing.Color.Indigo
        Cliente_VendLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Cliente_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Cliente_VendLabel.Location = New System.Drawing.Point(36, 104)
        Cliente_VendLabel.Name = "Cliente_VendLabel"
        Cliente_VendLabel.Size = New System.Drawing.Size(86, 33)
        Cliente_VendLabel.TabIndex = 5
        Cliente_VendLabel.Text = "Cliente:"
        '
        'Quantidade_VendLabel
        '
        Quantidade_VendLabel.AutoSize = True
        Quantidade_VendLabel.BackColor = System.Drawing.Color.Indigo
        Quantidade_VendLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Quantidade_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Quantidade_VendLabel.Location = New System.Drawing.Point(36, 130)
        Quantidade_VendLabel.Name = "Quantidade_VendLabel"
        Quantidade_VendLabel.Size = New System.Drawing.Size(133, 33)
        Quantidade_VendLabel.TabIndex = 7
        Quantidade_VendLabel.Text = "Quantidade:"
        '
        'Funcionario_VendLabel
        '
        Funcionario_VendLabel.AutoSize = True
        Funcionario_VendLabel.BackColor = System.Drawing.Color.Indigo
        Funcionario_VendLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Funcionario_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Funcionario_VendLabel.Location = New System.Drawing.Point(36, 156)
        Funcionario_VendLabel.Name = "Funcionario_VendLabel"
        Funcionario_VendLabel.Size = New System.Drawing.Size(133, 33)
        Funcionario_VendLabel.TabIndex = 9
        Funcionario_VendLabel.Text = "Funcionário:"
        '
        'Data_VendLabel
        '
        Data_VendLabel.AutoSize = True
        Data_VendLabel.BackColor = System.Drawing.Color.Indigo
        Data_VendLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Data_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Data_VendLabel.Location = New System.Drawing.Point(36, 183)
        Data_VendLabel.Name = "Data_VendLabel"
        Data_VendLabel.Size = New System.Drawing.Size(67, 33)
        Data_VendLabel.TabIndex = 11
        Data_VendLabel.Text = "Data:"
        '
        'Nota_Fiscal_VendLabel
        '
        Nota_Fiscal_VendLabel.AutoSize = True
        Nota_Fiscal_VendLabel.BackColor = System.Drawing.Color.Indigo
        Nota_Fiscal_VendLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Nota_Fiscal_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Nota_Fiscal_VendLabel.Location = New System.Drawing.Point(36, 208)
        Nota_Fiscal_VendLabel.Name = "Nota_Fiscal_VendLabel"
        Nota_Fiscal_VendLabel.Size = New System.Drawing.Size(125, 33)
        Nota_Fiscal_VendLabel.TabIndex = 13
        Nota_Fiscal_VendLabel.Text = "Nota Fiscal:"
        '
        'Valor_VendLabel
        '
        Valor_VendLabel.AutoSize = True
        Valor_VendLabel.BackColor = System.Drawing.Color.Indigo
        Valor_VendLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Valor_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Valor_VendLabel.Location = New System.Drawing.Point(36, 234)
        Valor_VendLabel.Name = "Valor_VendLabel"
        Valor_VendLabel.Size = New System.Drawing.Size(72, 33)
        Valor_VendLabel.TabIndex = 15
        Valor_VendLabel.Text = "Valor:"
        '
        'SorveteriaDataSet
        '
        Me.SorveteriaDataSet.DataSetName = "SorveteriaDataSet"
        Me.SorveteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendasBindingSource
        '
        Me.VendasBindingSource.DataMember = "Vendas"
        Me.VendasBindingSource.DataSource = Me.SorveteriaDataSet
        '
        'VendasTableAdapter
        '
        Me.VendasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TransportadoraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Me.VendasTableAdapter
        '
        'VendasBindingNavigator
        '
        Me.VendasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VendasBindingNavigator.BindingSource = Me.VendasBindingSource
        Me.VendasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VendasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VendasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VendasBindingNavigatorSaveItem})
        Me.VendasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VendasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VendasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VendasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VendasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VendasBindingNavigator.Name = "VendasBindingNavigator"
        Me.VendasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VendasBindingNavigator.Size = New System.Drawing.Size(423, 25)
        Me.VendasBindingNavigator.TabIndex = 0
        Me.VendasBindingNavigator.Text = "BindingNavigator1"
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
        'VendasBindingNavigatorSaveItem
        '
        Me.VendasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VendasBindingNavigatorSaveItem.Image = CType(resources.GetObject("VendasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VendasBindingNavigatorSaveItem.Name = "VendasBindingNavigatorSaveItem"
        Me.VendasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VendasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Código_VendTextBox
        '
        Me.Código_VendTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Código_Vend", True))
        Me.Código_VendTextBox.Location = New System.Drawing.Point(193, 62)
        Me.Código_VendTextBox.Name = "Código_VendTextBox"
        Me.Código_VendTextBox.ReadOnly = True
        Me.Código_VendTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Código_VendTextBox.TabIndex = 2
        Me.Código_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Produto_VendTextBox
        '
        Me.Produto_VendTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Produto_Vend", True))
        Me.Produto_VendTextBox.Location = New System.Drawing.Point(193, 88)
        Me.Produto_VendTextBox.Name = "Produto_VendTextBox"
        Me.Produto_VendTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Produto_VendTextBox.TabIndex = 4
        Me.Produto_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cliente_VendTextBox
        '
        Me.Cliente_VendTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Cliente_Vend", True))
        Me.Cliente_VendTextBox.Location = New System.Drawing.Point(193, 114)
        Me.Cliente_VendTextBox.Name = "Cliente_VendTextBox"
        Me.Cliente_VendTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cliente_VendTextBox.TabIndex = 6
        Me.Cliente_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Quantidade_VendTextBox
        '
        Me.Quantidade_VendTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Quantidade_Vend", True))
        Me.Quantidade_VendTextBox.Location = New System.Drawing.Point(193, 140)
        Me.Quantidade_VendTextBox.Name = "Quantidade_VendTextBox"
        Me.Quantidade_VendTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Quantidade_VendTextBox.TabIndex = 8
        Me.Quantidade_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Funcionario_VendTextBox
        '
        Me.Funcionario_VendTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Funcionario_Vend", True))
        Me.Funcionario_VendTextBox.Location = New System.Drawing.Point(193, 166)
        Me.Funcionario_VendTextBox.Name = "Funcionario_VendTextBox"
        Me.Funcionario_VendTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Funcionario_VendTextBox.TabIndex = 10
        Me.Funcionario_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data_VendDateTimePicker
        '
        Me.Data_VendDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendasBindingSource, "Data_Vend", True))
        Me.Data_VendDateTimePicker.Location = New System.Drawing.Point(193, 192)
        Me.Data_VendDateTimePicker.Name = "Data_VendDateTimePicker"
        Me.Data_VendDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Data_VendDateTimePicker.TabIndex = 12
        '
        'Nota_Fiscal_VendTextBox
        '
        Me.Nota_Fiscal_VendTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Nota_Fiscal_Vend", True))
        Me.Nota_Fiscal_VendTextBox.Location = New System.Drawing.Point(193, 218)
        Me.Nota_Fiscal_VendTextBox.Name = "Nota_Fiscal_VendTextBox"
        Me.Nota_Fiscal_VendTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nota_Fiscal_VendTextBox.TabIndex = 14
        Me.Nota_Fiscal_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Valor_VendTextBox
        '
        Me.Valor_VendTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Valor_Vend", True))
        Me.Valor_VendTextBox.Location = New System.Drawing.Point(193, 244)
        Me.Valor_VendTextBox.Name = "Valor_VendTextBox"
        Me.Valor_VendTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Valor_VendTextBox.TabIndex = 16
        Me.Valor_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Location = New System.Drawing.Point(318, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "&Fechar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(423, 342)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Código_VendLabel)
        Me.Controls.Add(Me.Código_VendTextBox)
        Me.Controls.Add(Produto_VendLabel)
        Me.Controls.Add(Me.Produto_VendTextBox)
        Me.Controls.Add(Cliente_VendLabel)
        Me.Controls.Add(Me.Cliente_VendTextBox)
        Me.Controls.Add(Quantidade_VendLabel)
        Me.Controls.Add(Me.Quantidade_VendTextBox)
        Me.Controls.Add(Funcionario_VendLabel)
        Me.Controls.Add(Me.Funcionario_VendTextBox)
        Me.Controls.Add(Data_VendLabel)
        Me.Controls.Add(Me.Data_VendDateTimePicker)
        Me.Controls.Add(Nota_Fiscal_VendLabel)
        Me.Controls.Add(Me.Nota_Fiscal_VendTextBox)
        Me.Controls.Add(Valor_VendLabel)
        Me.Controls.Add(Me.Valor_VendTextBox)
        Me.Controls.Add(Me.VendasBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VendasBindingNavigator.ResumeLayout(False)
        Me.VendasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SorveteriaDataSet As Sorveteria.SorveteriaDataSet
    Friend WithEvents VendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendasTableAdapter As Sorveteria.SorveteriaDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents TableAdapterManager As Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents VendasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Código_VendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Produto_VendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cliente_VendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Quantidade_VendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Funcionario_VendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_VendDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Nota_Fiscal_VendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Valor_VendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
