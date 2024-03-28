<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcadlocatarios
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
        Dim IdLocatárioLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DataNascLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim FoneLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim RGLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Dim SerieLabel As System.Windows.Forms.Label
        Dim EscolaLabel As System.Windows.Forms.Label
        Dim ProfissãoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcadlocatarios))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.IdLocatárioTextBox = New System.Windows.Forms.TextBox
        Me.LocatárioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSystem1DataSet = New RUBIAPPLICATION.BDSystem1DataSet
        Me.NomeTextBox = New System.Windows.Forms.TextBox
        Me.DataNascDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox
        Me.CidadeTextBox = New System.Windows.Forms.TextBox
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.BairroTextBox = New System.Windows.Forms.TextBox
        Me.FoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.RGMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.UFComboBox = New System.Windows.Forms.ComboBox
        Me.SerieTextBox = New System.Windows.Forms.TextBox
        Me.EscolaTextBox = New System.Windows.Forms.TextBox
        Me.ProfissãoTextBox = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.LocatárioTableAdapter = New RUBIAPPLICATION.BDSystem1DataSetTableAdapters.LocatárioTableAdapter
        Me.TableAdapterManager = New RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager
        Me.LocatárioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LocatárioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        IdLocatárioLabel = New System.Windows.Forms.Label
        NomeLabel = New System.Windows.Forms.Label
        DataNascLabel = New System.Windows.Forms.Label
        EndereçoLabel = New System.Windows.Forms.Label
        CidadeLabel = New System.Windows.Forms.Label
        CEPLabel = New System.Windows.Forms.Label
        BairroLabel = New System.Windows.Forms.Label
        FoneLabel = New System.Windows.Forms.Label
        CPFLabel = New System.Windows.Forms.Label
        RGLabel = New System.Windows.Forms.Label
        UFLabel = New System.Windows.Forms.Label
        SerieLabel = New System.Windows.Forms.Label
        EscolaLabel = New System.Windows.Forms.Label
        ProfissãoLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.LocatárioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocatárioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LocatárioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLocatárioLabel
        '
        IdLocatárioLabel.AutoSize = True
        IdLocatárioLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        IdLocatárioLabel.Location = New System.Drawing.Point(30, 27)
        IdLocatárioLabel.Name = "IdLocatárioLabel"
        IdLocatárioLabel.Size = New System.Drawing.Size(113, 18)
        IdLocatárioLabel.TabIndex = 0
        IdLocatárioLabel.Text = "Identificação:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        NomeLabel.Location = New System.Drawing.Point(30, 53)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(58, 18)
        NomeLabel.TabIndex = 2
        NomeLabel.Text = "Nome:"
        '
        'DataNascLabel
        '
        DataNascLabel.AutoSize = True
        DataNascLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        DataNascLabel.Location = New System.Drawing.Point(30, 80)
        DataNascLabel.Name = "DataNascLabel"
        DataNascLabel.Size = New System.Drawing.Size(143, 18)
        DataNascLabel.TabIndex = 4
        DataNascLabel.Text = "Data Nascimento:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        EndereçoLabel.Location = New System.Drawing.Point(30, 105)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(84, 18)
        EndereçoLabel.TabIndex = 6
        EndereçoLabel.Text = "Endereço:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        CidadeLabel.Location = New System.Drawing.Point(30, 131)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(69, 18)
        CidadeLabel.TabIndex = 8
        CidadeLabel.Text = "Cidade:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        CEPLabel.Location = New System.Drawing.Point(30, 157)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(42, 18)
        CEPLabel.TabIndex = 10
        CEPLabel.Text = "CEP:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        BairroLabel.Location = New System.Drawing.Point(30, 183)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(57, 18)
        BairroLabel.TabIndex = 12
        BairroLabel.Text = "Bairro:"
        '
        'FoneLabel
        '
        FoneLabel.AutoSize = True
        FoneLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        FoneLabel.Location = New System.Drawing.Point(30, 209)
        FoneLabel.Name = "FoneLabel"
        FoneLabel.Size = New System.Drawing.Size(78, 18)
        FoneLabel.TabIndex = 14
        FoneLabel.Text = "Telefone:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        CPFLabel.Location = New System.Drawing.Point(30, 235)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(42, 18)
        CPFLabel.TabIndex = 16
        CPFLabel.Text = "CPF:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        RGLabel.Location = New System.Drawing.Point(30, 261)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(121, 18)
        RGLabel.TabIndex = 18
        RGLabel.Text = "Registro Geral:"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        UFLabel.Location = New System.Drawing.Point(30, 287)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(65, 18)
        UFLabel.TabIndex = 20
        UFLabel.Text = "Estado:"
        '
        'SerieLabel
        '
        SerieLabel.AutoSize = True
        SerieLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        SerieLabel.Location = New System.Drawing.Point(30, 314)
        SerieLabel.Name = "SerieLabel"
        SerieLabel.Size = New System.Drawing.Size(50, 18)
        SerieLabel.TabIndex = 22
        SerieLabel.Text = "Série:"
        '
        'EscolaLabel
        '
        EscolaLabel.AutoSize = True
        EscolaLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        EscolaLabel.Location = New System.Drawing.Point(30, 340)
        EscolaLabel.Name = "EscolaLabel"
        EscolaLabel.Size = New System.Drawing.Size(63, 18)
        EscolaLabel.TabIndex = 24
        EscolaLabel.Text = "Escola:"
        '
        'ProfissãoLabel
        '
        ProfissãoLabel.AutoSize = True
        ProfissãoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        ProfissãoLabel.Location = New System.Drawing.Point(30, 366)
        ProfissãoLabel.Name = "ProfissãoLabel"
        ProfissãoLabel.Size = New System.Drawing.Size(82, 18)
        ProfissãoLabel.TabIndex = 26
        ProfissãoLabel.Text = "Profissão:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(39, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(408, 449)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(IdLocatárioLabel)
        Me.TabPage1.Controls.Add(Me.IdLocatárioTextBox)
        Me.TabPage1.Controls.Add(NomeLabel)
        Me.TabPage1.Controls.Add(Me.NomeTextBox)
        Me.TabPage1.Controls.Add(DataNascLabel)
        Me.TabPage1.Controls.Add(Me.DataNascDateTimePicker)
        Me.TabPage1.Controls.Add(EndereçoLabel)
        Me.TabPage1.Controls.Add(Me.EndereçoTextBox)
        Me.TabPage1.Controls.Add(CidadeLabel)
        Me.TabPage1.Controls.Add(Me.CidadeTextBox)
        Me.TabPage1.Controls.Add(CEPLabel)
        Me.TabPage1.Controls.Add(Me.CEPMaskedTextBox)
        Me.TabPage1.Controls.Add(BairroLabel)
        Me.TabPage1.Controls.Add(Me.BairroTextBox)
        Me.TabPage1.Controls.Add(FoneLabel)
        Me.TabPage1.Controls.Add(Me.FoneMaskedTextBox)
        Me.TabPage1.Controls.Add(CPFLabel)
        Me.TabPage1.Controls.Add(Me.CPFMaskedTextBox)
        Me.TabPage1.Controls.Add(RGLabel)
        Me.TabPage1.Controls.Add(Me.RGMaskedTextBox)
        Me.TabPage1.Controls.Add(UFLabel)
        Me.TabPage1.Controls.Add(Me.UFComboBox)
        Me.TabPage1.Controls.Add(SerieLabel)
        Me.TabPage1.Controls.Add(Me.SerieTextBox)
        Me.TabPage1.Controls.Add(EscolaLabel)
        Me.TabPage1.Controls.Add(Me.EscolaTextBox)
        Me.TabPage1.Controls.Add(ProfissãoLabel)
        Me.TabPage1.Controls.Add(Me.ProfissãoTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(400, 423)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Gerais"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'IdLocatárioTextBox
        '
        Me.IdLocatárioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "IdLocatário", True))
        Me.IdLocatárioTextBox.Location = New System.Drawing.Point(175, 25)
        Me.IdLocatárioTextBox.Name = "IdLocatárioTextBox"
        Me.IdLocatárioTextBox.ReadOnly = True
        Me.IdLocatárioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdLocatárioTextBox.TabIndex = 1
        Me.IdLocatárioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LocatárioBindingSource
        '
        Me.LocatárioBindingSource.DataMember = "Locatário"
        Me.LocatárioBindingSource.DataSource = Me.BDSystem1DataSet
        '
        'BDSystem1DataSet
        '
        Me.BDSystem1DataSet.DataSetName = "BDSystem1DataSet"
        Me.BDSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(175, 51)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomeTextBox.TabIndex = 3
        Me.NomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataNascDateTimePicker
        '
        Me.DataNascDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LocatárioBindingSource, "DataNasc", True))
        Me.DataNascDateTimePicker.Location = New System.Drawing.Point(175, 77)
        Me.DataNascDateTimePicker.Name = "DataNascDateTimePicker"
        Me.DataNascDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataNascDateTimePicker.TabIndex = 5
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(175, 103)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EndereçoTextBox.TabIndex = 7
        Me.EndereçoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(175, 129)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CidadeTextBox.TabIndex = 9
        Me.CidadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(175, 155)
        Me.CEPMaskedTextBox.Mask = "00,000-000"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CEPMaskedTextBox.TabIndex = 11
        Me.CEPMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(175, 181)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BairroTextBox.TabIndex = 13
        Me.BairroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FoneMaskedTextBox
        '
        Me.FoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "Fone", True))
        Me.FoneMaskedTextBox.Location = New System.Drawing.Point(175, 207)
        Me.FoneMaskedTextBox.Mask = "(00)0000-0000"
        Me.FoneMaskedTextBox.Name = "FoneMaskedTextBox"
        Me.FoneMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FoneMaskedTextBox.TabIndex = 15
        Me.FoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(175, 233)
        Me.CPFMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CPFMaskedTextBox.TabIndex = 17
        Me.CPFMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RGMaskedTextBox
        '
        Me.RGMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "RG", True))
        Me.RGMaskedTextBox.Location = New System.Drawing.Point(175, 259)
        Me.RGMaskedTextBox.Mask = "00,000,0000-0"
        Me.RGMaskedTextBox.Name = "RGMaskedTextBox"
        Me.RGMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RGMaskedTextBox.TabIndex = 19
        Me.RGMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UFComboBox
        '
        Me.UFComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "UF", True))
        Me.UFComboBox.FormattingEnabled = True
        Me.UFComboBox.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BH", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.UFComboBox.Location = New System.Drawing.Point(175, 285)
        Me.UFComboBox.Name = "UFComboBox"
        Me.UFComboBox.Size = New System.Drawing.Size(200, 21)
        Me.UFComboBox.TabIndex = 21
        '
        'SerieTextBox
        '
        Me.SerieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "Serie", True))
        Me.SerieTextBox.Location = New System.Drawing.Point(175, 312)
        Me.SerieTextBox.Name = "SerieTextBox"
        Me.SerieTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SerieTextBox.TabIndex = 23
        Me.SerieTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EscolaTextBox
        '
        Me.EscolaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "Escola", True))
        Me.EscolaTextBox.Location = New System.Drawing.Point(175, 338)
        Me.EscolaTextBox.Name = "EscolaTextBox"
        Me.EscolaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EscolaTextBox.TabIndex = 25
        Me.EscolaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProfissãoTextBox
        '
        Me.ProfissãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatárioBindingSource, "Profissão", True))
        Me.ProfissãoTextBox.Location = New System.Drawing.Point(175, 364)
        Me.ProfissãoTextBox.Name = "ProfissãoTextBox"
        Me.ProfissãoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProfissãoTextBox.TabIndex = 27
        Me.ProfissãoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(400, 423)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Comentários"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LocatárioTableAdapter
        '
        Me.LocatárioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EditoraTableAdapter = Nothing
        Me.TableAdapterManager.FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.Item_LocaçãoTableAdapter = Nothing
        Me.TableAdapterManager.LivroTableAdapter = Nothing
        Me.TableAdapterManager.LocaçãoTableAdapter = Nothing
        Me.TableAdapterManager.LocatárioTableAdapter = Me.LocatárioTableAdapter
        Me.TableAdapterManager.PerfilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LocatárioBindingNavigator
        '
        Me.LocatárioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LocatárioBindingNavigator.BindingSource = Me.LocatárioBindingSource
        Me.LocatárioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LocatárioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LocatárioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LocatárioBindingNavigatorSaveItem})
        Me.LocatárioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LocatárioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LocatárioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LocatárioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LocatárioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LocatárioBindingNavigator.Name = "LocatárioBindingNavigator"
        Me.LocatárioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LocatárioBindingNavigator.Size = New System.Drawing.Size(492, 25)
        Me.LocatárioBindingNavigator.TabIndex = 1
        Me.LocatárioBindingNavigator.Text = "BindingNavigator1"
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
        'LocatárioBindingNavigatorSaveItem
        '
        Me.LocatárioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LocatárioBindingNavigatorSaveItem.Image = CType(resources.GetObject("LocatárioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LocatárioBindingNavigatorSaveItem.Name = "LocatárioBindingNavigatorSaveItem"
        Me.LocatárioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LocatárioBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(353, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button1, "Cancelar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -2
        Me.LineShape1.X2 = 499
        Me.LineShape1.Y1 = 528
        Me.LineShape1.Y2 = 527
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(492, 585)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'Frmcadlocatarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(492, 585)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LocatárioBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmcadlocatarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Locatários"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.LocatárioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocatárioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LocatárioBindingNavigator.ResumeLayout(False)
        Me.LocatárioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BDSystem1DataSet As RUBIAPPLICATION.BDSystem1DataSet
    Friend WithEvents LocatárioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocatárioTableAdapter As RUBIAPPLICATION.BDSystem1DataSetTableAdapters.LocatárioTableAdapter
    Friend WithEvents TableAdapterManager As RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocatárioBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LocatárioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdLocatárioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataNascDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndereçoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPFMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RGMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents UFComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SerieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EscolaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfissãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
