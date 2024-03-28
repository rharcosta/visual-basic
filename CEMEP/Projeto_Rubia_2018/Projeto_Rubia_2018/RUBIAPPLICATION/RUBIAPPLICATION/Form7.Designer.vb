<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcadfuncionarios
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
        Dim IdFuncionárioLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim LoginLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim IdPerfilLabel As System.Windows.Forms.Label
        Dim SituaçãoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcadfuncionarios))
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.IdFuncionárioTextBox = New System.Windows.Forms.TextBox
        Me.FuncionárioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSystem1DataSet = New RUBIAPPLICATION.BDSystem1DataSet
        Me.NomeTextBox = New System.Windows.Forms.TextBox
        Me.LoginTextBox = New System.Windows.Forms.TextBox
        Me.SenhaTextBox = New System.Windows.Forms.TextBox
        Me.IdPerfilTextBox = New System.Windows.Forms.TextBox
        Me.SituaçãoCheckBox = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.FuncionárioTableAdapter = New RUBIAPPLICATION.BDSystem1DataSetTableAdapters.FuncionárioTableAdapter
        Me.TableAdapterManager = New RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager
        Me.FuncionárioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FuncionárioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        IdFuncionárioLabel = New System.Windows.Forms.Label
        NomeLabel = New System.Windows.Forms.Label
        LoginLabel = New System.Windows.Forms.Label
        SenhaLabel = New System.Windows.Forms.Label
        IdPerfilLabel = New System.Windows.Forms.Label
        SituaçãoLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionárioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FuncionárioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdFuncionárioLabel
        '
        IdFuncionárioLabel.AutoSize = True
        IdFuncionárioLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        IdFuncionárioLabel.Location = New System.Drawing.Point(16, 35)
        IdFuncionárioLabel.Name = "IdFuncionárioLabel"
        IdFuncionárioLabel.Size = New System.Drawing.Size(113, 18)
        IdFuncionárioLabel.TabIndex = 0
        IdFuncionárioLabel.Text = "Identificação:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        NomeLabel.Location = New System.Drawing.Point(16, 61)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(58, 18)
        NomeLabel.TabIndex = 2
        NomeLabel.Text = "Nome:"
        '
        'LoginLabel
        '
        LoginLabel.AutoSize = True
        LoginLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        LoginLabel.Location = New System.Drawing.Point(16, 87)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New System.Drawing.Size(56, 18)
        LoginLabel.TabIndex = 4
        LoginLabel.Text = "Login:"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        SenhaLabel.Location = New System.Drawing.Point(16, 113)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(58, 18)
        SenhaLabel.TabIndex = 6
        SenhaLabel.Text = "Senha:"
        '
        'IdPerfilLabel
        '
        IdPerfilLabel.AutoSize = True
        IdPerfilLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        IdPerfilLabel.Location = New System.Drawing.Point(16, 139)
        IdPerfilLabel.Name = "IdPerfilLabel"
        IdPerfilLabel.Size = New System.Drawing.Size(182, 18)
        IdPerfilLabel.TabIndex = 8
        IdPerfilLabel.Text = "Identificação do Perfil:"
        '
        'SituaçãoLabel
        '
        SituaçãoLabel.AutoSize = True
        SituaçãoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        SituaçãoLabel.Location = New System.Drawing.Point(16, 167)
        SituaçãoLabel.Name = "SituaçãoLabel"
        SituaçãoLabel.Size = New System.Drawing.Size(78, 18)
        SituaçãoLabel.TabIndex = 10
        SituaçãoLabel.Text = "Situação:"
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 457
        Me.LineShape1.Y1 = 323
        Me.LineShape1.Y2 = 324
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(445, 376)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RosyBrown
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(313, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button1, "Cancelar")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(396, 252)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage1.Controls.Add(IdFuncionárioLabel)
        Me.TabPage1.Controls.Add(Me.IdFuncionárioTextBox)
        Me.TabPage1.Controls.Add(NomeLabel)
        Me.TabPage1.Controls.Add(Me.NomeTextBox)
        Me.TabPage1.Controls.Add(LoginLabel)
        Me.TabPage1.Controls.Add(Me.LoginTextBox)
        Me.TabPage1.Controls.Add(SenhaLabel)
        Me.TabPage1.Controls.Add(Me.SenhaTextBox)
        Me.TabPage1.Controls.Add(IdPerfilLabel)
        Me.TabPage1.Controls.Add(Me.IdPerfilTextBox)
        Me.TabPage1.Controls.Add(SituaçãoLabel)
        Me.TabPage1.Controls.Add(Me.SituaçãoCheckBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(388, 226)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Gerais"
        '
        'IdFuncionárioTextBox
        '
        Me.IdFuncionárioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "IdFuncionário", True))
        Me.IdFuncionárioTextBox.Location = New System.Drawing.Point(224, 36)
        Me.IdFuncionárioTextBox.Name = "IdFuncionárioTextBox"
        Me.IdFuncionárioTextBox.ReadOnly = True
        Me.IdFuncionárioTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IdFuncionárioTextBox.TabIndex = 1
        Me.IdFuncionárioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FuncionárioBindingSource
        '
        Me.FuncionárioBindingSource.DataMember = "Funcionário"
        Me.FuncionárioBindingSource.DataSource = Me.BDSystem1DataSet
        '
        'BDSystem1DataSet
        '
        Me.BDSystem1DataSet.DataSetName = "BDSystem1DataSet"
        Me.BDSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(224, 62)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.NomeTextBox.TabIndex = 2
        Me.NomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginTextBox
        '
        Me.LoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Login", True))
        Me.LoginTextBox.Location = New System.Drawing.Point(224, 88)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(104, 20)
        Me.LoginTextBox.TabIndex = 3
        Me.LoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Senha", True))
        Me.SenhaTextBox.Location = New System.Drawing.Point(224, 114)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SenhaTextBox.TabIndex = 4
        Me.SenhaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IdPerfilTextBox
        '
        Me.IdPerfilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "IdPerfil", True))
        Me.IdPerfilTextBox.Location = New System.Drawing.Point(224, 140)
        Me.IdPerfilTextBox.Name = "IdPerfilTextBox"
        Me.IdPerfilTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IdPerfilTextBox.TabIndex = 5
        Me.IdPerfilTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SituaçãoCheckBox
        '
        Me.SituaçãoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FuncionárioBindingSource, "Situação", True))
        Me.SituaçãoCheckBox.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.SituaçãoCheckBox.Location = New System.Drawing.Point(224, 166)
        Me.SituaçãoCheckBox.Name = "SituaçãoCheckBox"
        Me.SituaçãoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SituaçãoCheckBox.TabIndex = 6
        Me.SituaçãoCheckBox.Text = "Ativo"
        Me.SituaçãoCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(388, 226)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Comentários"
        '
        'FuncionárioTableAdapter
        '
        Me.FuncionárioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EditoraTableAdapter = Nothing
        Me.TableAdapterManager.FuncionárioTableAdapter = Me.FuncionárioTableAdapter
        Me.TableAdapterManager.Item_LocaçãoTableAdapter = Nothing
        Me.TableAdapterManager.LivroTableAdapter = Nothing
        Me.TableAdapterManager.LocaçãoTableAdapter = Nothing
        Me.TableAdapterManager.LocatárioTableAdapter = Nothing
        Me.TableAdapterManager.PerfilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FuncionárioBindingNavigator
        '
        Me.FuncionárioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FuncionárioBindingNavigator.BindingSource = Me.FuncionárioBindingSource
        Me.FuncionárioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FuncionárioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FuncionárioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FuncionárioBindingNavigatorSaveItem})
        Me.FuncionárioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FuncionárioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FuncionárioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FuncionárioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FuncionárioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FuncionárioBindingNavigator.Name = "FuncionárioBindingNavigator"
        Me.FuncionárioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FuncionárioBindingNavigator.Size = New System.Drawing.Size(445, 25)
        Me.FuncionárioBindingNavigator.TabIndex = 11
        Me.FuncionárioBindingNavigator.Text = "BindingNavigator1"
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
        'FuncionárioBindingNavigatorSaveItem
        '
        Me.FuncionárioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FuncionárioBindingNavigatorSaveItem.Image = CType(resources.GetObject("FuncionárioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FuncionárioBindingNavigatorSaveItem.Name = "FuncionárioBindingNavigatorSaveItem"
        Me.FuncionárioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FuncionárioBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Frmcadfuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(445, 376)
        Me.Controls.Add(Me.FuncionárioBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmcadfuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionárioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FuncionárioBindingNavigator.ResumeLayout(False)
        Me.FuncionárioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BDSystem1DataSet As RUBIAPPLICATION.BDSystem1DataSet
    Friend WithEvents FuncionárioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionárioTableAdapter As RUBIAPPLICATION.BDSystem1DataSetTableAdapters.FuncionárioTableAdapter
    Friend WithEvents TableAdapterManager As RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents FuncionárioBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FuncionárioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdFuncionárioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SenhaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdPerfilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SituaçãoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
