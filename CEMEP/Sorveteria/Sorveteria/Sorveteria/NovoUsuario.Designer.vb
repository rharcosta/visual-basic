<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovoUsuario))
        Dim Código_LogLabel As System.Windows.Forms.Label
        Dim Nome_LogLabel As System.Windows.Forms.Label
        Dim Usuario_LogLabel As System.Windows.Forms.Label
        Dim Senha_LogLabel As System.Windows.Forms.Label
        Me.SorveteriaDataSet = New Sorveteria.SorveteriaDataSet
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New Sorveteria.SorveteriaDataSetTableAdapters.LoginTableAdapter
        Me.TableAdapterManager = New Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
        Me.LoginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LoginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Código_LogTextBox = New System.Windows.Forms.TextBox
        Me.Nome_LogTextBox = New System.Windows.Forms.TextBox
        Me.Usuario_LogTextBox = New System.Windows.Forms.TextBox
        Me.Senha_LogTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Código_LogLabel = New System.Windows.Forms.Label
        Nome_LogLabel = New System.Windows.Forms.Label
        Usuario_LogLabel = New System.Windows.Forms.Label
        Senha_LogLabel = New System.Windows.Forms.Label
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SorveteriaDataSet
        '
        Me.SorveteriaDataSet.DataSetName = "SorveteriaDataSet"
        Me.SorveteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.SorveteriaDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.FornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.FuncionáriosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.Nota_FiscalTableAdapter = Nothing
        Me.TableAdapterManager.ProdutoTableAdapter = Nothing
        Me.TableAdapterManager.TransportadoraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        '
        'LoginBindingNavigator
        '
        Me.LoginBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LoginBindingNavigator.BindingSource = Me.LoginBindingSource
        Me.LoginBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LoginBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LoginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LoginBindingNavigatorSaveItem})
        Me.LoginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LoginBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LoginBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LoginBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LoginBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LoginBindingNavigator.Name = "LoginBindingNavigator"
        Me.LoginBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LoginBindingNavigator.Size = New System.Drawing.Size(281, 25)
        Me.LoginBindingNavigator.TabIndex = 0
        Me.LoginBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
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
        'LoginBindingNavigatorSaveItem
        '
        Me.LoginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LoginBindingNavigatorSaveItem.Image = CType(resources.GetObject("LoginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LoginBindingNavigatorSaveItem.Name = "LoginBindingNavigatorSaveItem"
        Me.LoginBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LoginBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Código_LogLabel
        '
        Código_LogLabel.AutoSize = True
        Código_LogLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Código_LogLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Código_LogLabel.Location = New System.Drawing.Point(30, 46)
        Código_LogLabel.Name = "Código_LogLabel"
        Código_LogLabel.Size = New System.Drawing.Size(85, 33)
        Código_LogLabel.TabIndex = 1
        Código_LogLabel.Text = "Código:"
        '
        'Código_LogTextBox
        '
        Me.Código_LogTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Código_Log", True))
        Me.Código_LogTextBox.Location = New System.Drawing.Point(128, 56)
        Me.Código_LogTextBox.Name = "Código_LogTextBox"
        Me.Código_LogTextBox.Size = New System.Drawing.Size(122, 20)
        Me.Código_LogTextBox.TabIndex = 2
        Me.Código_LogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nome_LogLabel
        '
        Nome_LogLabel.AutoSize = True
        Nome_LogLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Nome_LogLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Nome_LogLabel.Location = New System.Drawing.Point(30, 72)
        Nome_LogLabel.Name = "Nome_LogLabel"
        Nome_LogLabel.Size = New System.Drawing.Size(76, 33)
        Nome_LogLabel.TabIndex = 3
        Nome_LogLabel.Text = "Nome:"
        '
        'Nome_LogTextBox
        '
        Me.Nome_LogTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Nome_Log", True))
        Me.Nome_LogTextBox.Location = New System.Drawing.Point(128, 82)
        Me.Nome_LogTextBox.Name = "Nome_LogTextBox"
        Me.Nome_LogTextBox.Size = New System.Drawing.Size(122, 20)
        Me.Nome_LogTextBox.TabIndex = 4
        Me.Nome_LogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Usuario_LogLabel
        '
        Usuario_LogLabel.AutoSize = True
        Usuario_LogLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Usuario_LogLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Usuario_LogLabel.Location = New System.Drawing.Point(30, 98)
        Usuario_LogLabel.Name = "Usuario_LogLabel"
        Usuario_LogLabel.Size = New System.Drawing.Size(93, 33)
        Usuario_LogLabel.TabIndex = 5
        Usuario_LogLabel.Text = "Usuario:"
        '
        'Usuario_LogTextBox
        '
        Me.Usuario_LogTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Usuario_Log", True))
        Me.Usuario_LogTextBox.Location = New System.Drawing.Point(128, 108)
        Me.Usuario_LogTextBox.Name = "Usuario_LogTextBox"
        Me.Usuario_LogTextBox.Size = New System.Drawing.Size(122, 20)
        Me.Usuario_LogTextBox.TabIndex = 6
        Me.Usuario_LogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Senha_LogLabel
        '
        Senha_LogLabel.AutoSize = True
        Senha_LogLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Senha_LogLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Senha_LogLabel.Location = New System.Drawing.Point(30, 124)
        Senha_LogLabel.Name = "Senha_LogLabel"
        Senha_LogLabel.Size = New System.Drawing.Size(79, 33)
        Senha_LogLabel.TabIndex = 7
        Senha_LogLabel.Text = "Senha:"
        '
        'Senha_LogTextBox
        '
        Me.Senha_LogTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Senha_Log", True))
        Me.Senha_LogTextBox.Location = New System.Drawing.Point(128, 134)
        Me.Senha_LogTextBox.Name = "Senha_LogTextBox"
        Me.Senha_LogTextBox.Size = New System.Drawing.Size(122, 20)
        Me.Senha_LogTextBox.TabIndex = 8
        Me.Senha_LogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(175, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "&Fechar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NovoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(281, 212)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Código_LogLabel)
        Me.Controls.Add(Me.Código_LogTextBox)
        Me.Controls.Add(Nome_LogLabel)
        Me.Controls.Add(Me.Nome_LogTextBox)
        Me.Controls.Add(Usuario_LogLabel)
        Me.Controls.Add(Me.Usuario_LogTextBox)
        Me.Controls.Add(Senha_LogLabel)
        Me.Controls.Add(Me.Senha_LogTextBox)
        Me.Controls.Add(Me.LoginBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NovoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novo Usuario"
        CType(Me.SorveteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginBindingNavigator.ResumeLayout(False)
        Me.LoginBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SorveteriaDataSet As Sorveteria.SorveteriaDataSet
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Sorveteria.SorveteriaDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents TableAdapterManager As Sorveteria.SorveteriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LoginBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Código_LogTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nome_LogTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Usuario_LogTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Senha_LogTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
