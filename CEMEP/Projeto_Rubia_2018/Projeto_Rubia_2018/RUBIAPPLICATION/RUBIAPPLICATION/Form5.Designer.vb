<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcadlivros
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
        Dim IdLivroLabel As System.Windows.Forms.Label
        Dim IdEditoraLabel As System.Windows.Forms.Label
        Dim TítuloLabel As System.Windows.Forms.Label
        Dim EdiçãoLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim LocalizaçãoLabel As System.Windows.Forms.Label
        Dim AssuntoLabel As System.Windows.Forms.Label
        Dim ClassificaçãoLabel As System.Windows.Forms.Label
        Dim ColeçãoLabel As System.Windows.Forms.Label
        Dim TomboLabel As System.Windows.Forms.Label
        Dim ResenhaLabel As System.Windows.Forms.Label
        Dim AutoresLabel As System.Windows.Forms.Label
        Dim ComentáriosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcadlivros))
        Me.Button1 = New System.Windows.Forms.Button
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.IdLivroTextBox = New System.Windows.Forms.TextBox
        Me.LivroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSystem1DataSet = New RUBIAPPLICATION.BDSystem1DataSet
        Me.TítuloTextBox = New System.Windows.Forms.TextBox
        Me.EdiçãoTextBox = New System.Windows.Forms.TextBox
        Me.AnoTextBox = New System.Windows.Forms.TextBox
        Me.ISBNTextBox = New System.Windows.Forms.TextBox
        Me.LocalizaçãoTextBox = New System.Windows.Forms.TextBox
        Me.AssuntoTextBox = New System.Windows.Forms.TextBox
        Me.ClassificaçãoTextBox = New System.Windows.Forms.TextBox
        Me.ColeçãoTextBox = New System.Windows.Forms.TextBox
        Me.TomboCheckBox = New System.Windows.Forms.CheckBox
        Me.ResenhaTextBox = New System.Windows.Forms.TextBox
        Me.AutoresTextBox = New System.Windows.Forms.TextBox
        Me.ComentáriosTextBox = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.LivroTableAdapter = New RUBIAPPLICATION.BDSystem1DataSetTableAdapters.LivroTableAdapter
        Me.TableAdapterManager = New RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager
        Me.LivroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LivroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.EditoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EditoraTableAdapter = New RUBIAPPLICATION.BDSystem1DataSetTableAdapters.EditoraTableAdapter
        IdLivroLabel = New System.Windows.Forms.Label
        IdEditoraLabel = New System.Windows.Forms.Label
        TítuloLabel = New System.Windows.Forms.Label
        EdiçãoLabel = New System.Windows.Forms.Label
        AnoLabel = New System.Windows.Forms.Label
        ISBNLabel = New System.Windows.Forms.Label
        LocalizaçãoLabel = New System.Windows.Forms.Label
        AssuntoLabel = New System.Windows.Forms.Label
        ClassificaçãoLabel = New System.Windows.Forms.Label
        ColeçãoLabel = New System.Windows.Forms.Label
        TomboLabel = New System.Windows.Forms.Label
        ResenhaLabel = New System.Windows.Forms.Label
        AutoresLabel = New System.Windows.Forms.Label
        ComentáriosLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.LivroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LivroBindingNavigator.SuspendLayout()
        CType(Me.EditoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLivroLabel
        '
        IdLivroLabel.AutoSize = True
        IdLivroLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLivroLabel.Location = New System.Drawing.Point(17, 18)
        IdLivroLabel.Name = "IdLivroLabel"
        IdLivroLabel.Size = New System.Drawing.Size(72, 18)
        IdLivroLabel.TabIndex = 0
        IdLivroLabel.Text = "Id Livro:"
        '
        'IdEditoraLabel
        '
        IdEditoraLabel.AutoSize = True
        IdEditoraLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdEditoraLabel.Location = New System.Drawing.Point(17, 44)
        IdEditoraLabel.Name = "IdEditoraLabel"
        IdEditoraLabel.Size = New System.Drawing.Size(88, 18)
        IdEditoraLabel.TabIndex = 2
        IdEditoraLabel.Text = "Id Editora:"
        '
        'TítuloLabel
        '
        TítuloLabel.AutoSize = True
        TítuloLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TítuloLabel.Location = New System.Drawing.Point(17, 70)
        TítuloLabel.Name = "TítuloLabel"
        TítuloLabel.Size = New System.Drawing.Size(56, 18)
        TítuloLabel.TabIndex = 4
        TítuloLabel.Text = "Título:"
        '
        'EdiçãoLabel
        '
        EdiçãoLabel.AutoSize = True
        EdiçãoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EdiçãoLabel.Location = New System.Drawing.Point(17, 96)
        EdiçãoLabel.Name = "EdiçãoLabel"
        EdiçãoLabel.Size = New System.Drawing.Size(66, 18)
        EdiçãoLabel.TabIndex = 6
        EdiçãoLabel.Text = "Edição:"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnoLabel.Location = New System.Drawing.Point(17, 122)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(43, 18)
        AnoLabel.TabIndex = 8
        AnoLabel.Text = "Ano:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ISBNLabel.Location = New System.Drawing.Point(17, 148)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(50, 18)
        ISBNLabel.TabIndex = 10
        ISBNLabel.Text = "ISBN:"
        '
        'LocalizaçãoLabel
        '
        LocalizaçãoLabel.AutoSize = True
        LocalizaçãoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalizaçãoLabel.Location = New System.Drawing.Point(17, 174)
        LocalizaçãoLabel.Name = "LocalizaçãoLabel"
        LocalizaçãoLabel.Size = New System.Drawing.Size(106, 18)
        LocalizaçãoLabel.TabIndex = 12
        LocalizaçãoLabel.Text = "Localização:"
        '
        'AssuntoLabel
        '
        AssuntoLabel.AutoSize = True
        AssuntoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AssuntoLabel.Location = New System.Drawing.Point(17, 200)
        AssuntoLabel.Name = "AssuntoLabel"
        AssuntoLabel.Size = New System.Drawing.Size(73, 18)
        AssuntoLabel.TabIndex = 14
        AssuntoLabel.Text = "Assunto:"
        '
        'ClassificaçãoLabel
        '
        ClassificaçãoLabel.AutoSize = True
        ClassificaçãoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClassificaçãoLabel.Location = New System.Drawing.Point(17, 226)
        ClassificaçãoLabel.Name = "ClassificaçãoLabel"
        ClassificaçãoLabel.Size = New System.Drawing.Size(115, 18)
        ClassificaçãoLabel.TabIndex = 16
        ClassificaçãoLabel.Text = "Classificação:"
        '
        'ColeçãoLabel
        '
        ColeçãoLabel.AutoSize = True
        ColeçãoLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColeçãoLabel.Location = New System.Drawing.Point(17, 252)
        ColeçãoLabel.Name = "ColeçãoLabel"
        ColeçãoLabel.Size = New System.Drawing.Size(76, 18)
        ColeçãoLabel.TabIndex = 18
        ColeçãoLabel.Text = "Coleção:"
        '
        'TomboLabel
        '
        TomboLabel.AutoSize = True
        TomboLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TomboLabel.Location = New System.Drawing.Point(17, 280)
        TomboLabel.Name = "TomboLabel"
        TomboLabel.Size = New System.Drawing.Size(65, 18)
        TomboLabel.TabIndex = 20
        TomboLabel.Text = "Tombo:"
        '
        'ResenhaLabel
        '
        ResenhaLabel.AutoSize = True
        ResenhaLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ResenhaLabel.Location = New System.Drawing.Point(17, 308)
        ResenhaLabel.Name = "ResenhaLabel"
        ResenhaLabel.Size = New System.Drawing.Size(77, 18)
        ResenhaLabel.TabIndex = 22
        ResenhaLabel.Text = "Resenha:"
        '
        'AutoresLabel
        '
        AutoresLabel.AutoSize = True
        AutoresLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AutoresLabel.Location = New System.Drawing.Point(17, 334)
        AutoresLabel.Name = "AutoresLabel"
        AutoresLabel.Size = New System.Drawing.Size(70, 18)
        AutoresLabel.TabIndex = 24
        AutoresLabel.Text = "Autores:"
        '
        'ComentáriosLabel
        '
        ComentáriosLabel.AutoSize = True
        ComentáriosLabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComentáriosLabel.Location = New System.Drawing.Point(17, 360)
        ComentáriosLabel.Name = "ComentáriosLabel"
        ComentáriosLabel.Size = New System.Drawing.Size(107, 18)
        ComentáriosLabel.TabIndex = 26
        ComentáriosLabel.Text = "Comentários:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(245, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button1, "Cancelar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(363, 523)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -19
        Me.LineShape1.X2 = 367
        Me.LineShape1.Y1 = 473
        Me.LineShape1.Y2 = 471
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(323, 414)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(IdLivroLabel)
        Me.TabPage1.Controls.Add(Me.IdLivroTextBox)
        Me.TabPage1.Controls.Add(IdEditoraLabel)
        Me.TabPage1.Controls.Add(TítuloLabel)
        Me.TabPage1.Controls.Add(Me.TítuloTextBox)
        Me.TabPage1.Controls.Add(EdiçãoLabel)
        Me.TabPage1.Controls.Add(Me.EdiçãoTextBox)
        Me.TabPage1.Controls.Add(AnoLabel)
        Me.TabPage1.Controls.Add(Me.AnoTextBox)
        Me.TabPage1.Controls.Add(ISBNLabel)
        Me.TabPage1.Controls.Add(Me.ISBNTextBox)
        Me.TabPage1.Controls.Add(LocalizaçãoLabel)
        Me.TabPage1.Controls.Add(Me.LocalizaçãoTextBox)
        Me.TabPage1.Controls.Add(AssuntoLabel)
        Me.TabPage1.Controls.Add(Me.AssuntoTextBox)
        Me.TabPage1.Controls.Add(ClassificaçãoLabel)
        Me.TabPage1.Controls.Add(Me.ClassificaçãoTextBox)
        Me.TabPage1.Controls.Add(ColeçãoLabel)
        Me.TabPage1.Controls.Add(Me.ColeçãoTextBox)
        Me.TabPage1.Controls.Add(TomboLabel)
        Me.TabPage1.Controls.Add(Me.TomboCheckBox)
        Me.TabPage1.Controls.Add(ResenhaLabel)
        Me.TabPage1.Controls.Add(Me.ResenhaTextBox)
        Me.TabPage1.Controls.Add(AutoresLabel)
        Me.TabPage1.Controls.Add(Me.AutoresTextBox)
        Me.TabPage1.Controls.Add(ComentáriosLabel)
        Me.TabPage1.Controls.Add(Me.ComentáriosTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(315, 388)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Gerais"
        '
        'IdLivroTextBox
        '
        Me.IdLivroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "IdLivro", True))
        Me.IdLivroTextBox.Location = New System.Drawing.Point(146, 16)
        Me.IdLivroTextBox.Name = "IdLivroTextBox"
        Me.IdLivroTextBox.ReadOnly = True
        Me.IdLivroTextBox.Size = New System.Drawing.Size(144, 20)
        Me.IdLivroTextBox.TabIndex = 1
        Me.IdLivroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LivroBindingSource
        '
        Me.LivroBindingSource.DataMember = "Livro"
        Me.LivroBindingSource.DataSource = Me.BDSystem1DataSet
        '
        'BDSystem1DataSet
        '
        Me.BDSystem1DataSet.DataSetName = "BDSystem1DataSet"
        Me.BDSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TítuloTextBox
        '
        Me.TítuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Título", True))
        Me.TítuloTextBox.Location = New System.Drawing.Point(146, 68)
        Me.TítuloTextBox.Name = "TítuloTextBox"
        Me.TítuloTextBox.Size = New System.Drawing.Size(144, 20)
        Me.TítuloTextBox.TabIndex = 5
        Me.TítuloTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EdiçãoTextBox
        '
        Me.EdiçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Edição", True))
        Me.EdiçãoTextBox.Location = New System.Drawing.Point(146, 94)
        Me.EdiçãoTextBox.Name = "EdiçãoTextBox"
        Me.EdiçãoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.EdiçãoTextBox.TabIndex = 7
        Me.EdiçãoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AnoTextBox
        '
        Me.AnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Ano", True))
        Me.AnoTextBox.Location = New System.Drawing.Point(146, 120)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.AnoTextBox.TabIndex = 9
        Me.AnoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(146, 146)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(144, 20)
        Me.ISBNTextBox.TabIndex = 11
        Me.ISBNTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LocalizaçãoTextBox
        '
        Me.LocalizaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Localização", True))
        Me.LocalizaçãoTextBox.Location = New System.Drawing.Point(146, 172)
        Me.LocalizaçãoTextBox.Name = "LocalizaçãoTextBox"
        Me.LocalizaçãoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.LocalizaçãoTextBox.TabIndex = 13
        Me.LocalizaçãoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AssuntoTextBox
        '
        Me.AssuntoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Assunto", True))
        Me.AssuntoTextBox.Location = New System.Drawing.Point(146, 198)
        Me.AssuntoTextBox.Name = "AssuntoTextBox"
        Me.AssuntoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.AssuntoTextBox.TabIndex = 15
        Me.AssuntoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClassificaçãoTextBox
        '
        Me.ClassificaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Classificação", True))
        Me.ClassificaçãoTextBox.Location = New System.Drawing.Point(146, 224)
        Me.ClassificaçãoTextBox.Name = "ClassificaçãoTextBox"
        Me.ClassificaçãoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.ClassificaçãoTextBox.TabIndex = 17
        Me.ClassificaçãoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColeçãoTextBox
        '
        Me.ColeçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Coleção", True))
        Me.ColeçãoTextBox.Location = New System.Drawing.Point(146, 250)
        Me.ColeçãoTextBox.Name = "ColeçãoTextBox"
        Me.ColeçãoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.ColeçãoTextBox.TabIndex = 19
        Me.ColeçãoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TomboCheckBox
        '
        Me.TomboCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LivroBindingSource, "Tombo", True))
        Me.TomboCheckBox.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TomboCheckBox.Location = New System.Drawing.Point(146, 276)
        Me.TomboCheckBox.Name = "TomboCheckBox"
        Me.TomboCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.TomboCheckBox.TabIndex = 21
        Me.TomboCheckBox.Text = "Sim"
        Me.TomboCheckBox.UseVisualStyleBackColor = True
        '
        'ResenhaTextBox
        '
        Me.ResenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Resenha", True))
        Me.ResenhaTextBox.Location = New System.Drawing.Point(146, 306)
        Me.ResenhaTextBox.Name = "ResenhaTextBox"
        Me.ResenhaTextBox.Size = New System.Drawing.Size(144, 20)
        Me.ResenhaTextBox.TabIndex = 23
        Me.ResenhaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AutoresTextBox
        '
        Me.AutoresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Autores", True))
        Me.AutoresTextBox.Location = New System.Drawing.Point(146, 332)
        Me.AutoresTextBox.Name = "AutoresTextBox"
        Me.AutoresTextBox.Size = New System.Drawing.Size(144, 20)
        Me.AutoresTextBox.TabIndex = 25
        Me.AutoresTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComentáriosTextBox
        '
        Me.ComentáriosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivroBindingSource, "Comentários", True))
        Me.ComentáriosTextBox.Location = New System.Drawing.Point(146, 358)
        Me.ComentáriosTextBox.Name = "ComentáriosTextBox"
        Me.ComentáriosTextBox.Size = New System.Drawing.Size(144, 20)
        Me.ComentáriosTextBox.TabIndex = 27
        Me.ComentáriosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(317, 388)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Comentários"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LivroTableAdapter
        '
        Me.LivroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EditoraTableAdapter = Nothing
        Me.TableAdapterManager.FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.Item_LocaçãoTableAdapter = Nothing
        Me.TableAdapterManager.LivroTableAdapter = Me.LivroTableAdapter
        Me.TableAdapterManager.LocaçãoTableAdapter = Nothing
        Me.TableAdapterManager.LocatárioTableAdapter = Nothing
        Me.TableAdapterManager.PerfilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LivroBindingNavigator
        '
        Me.LivroBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LivroBindingNavigator.BindingSource = Me.LivroBindingSource
        Me.LivroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LivroBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LivroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LivroBindingNavigatorSaveItem})
        Me.LivroBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LivroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LivroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LivroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LivroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LivroBindingNavigator.Name = "LivroBindingNavigator"
        Me.LivroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LivroBindingNavigator.Size = New System.Drawing.Size(363, 25)
        Me.LivroBindingNavigator.TabIndex = 4
        Me.LivroBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'LivroBindingNavigatorSaveItem
        '
        Me.LivroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LivroBindingNavigatorSaveItem.Image = CType(resources.GetObject("LivroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LivroBindingNavigatorSaveItem.Name = "LivroBindingNavigatorSaveItem"
        Me.LivroBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LivroBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LivroBindingSource, "IdEditora", True))
        Me.ComboBox1.DataSource = Me.EditoraBindingSource
        Me.ComboBox1.DisplayMember = "Nome"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(146, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 28
        Me.ComboBox1.ValueMember = "IdEditora"
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
        'Frmcadlivros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(363, 523)
        Me.Controls.Add(Me.LivroBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmcadlivros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Livros"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.LivroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LivroBindingNavigator.ResumeLayout(False)
        Me.LivroBindingNavigator.PerformLayout()
        CType(Me.EditoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BDSystem1DataSet As RUBIAPPLICATION.BDSystem1DataSet
    Friend WithEvents LivroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LivroTableAdapter As RUBIAPPLICATION.BDSystem1DataSetTableAdapters.LivroTableAdapter
    Friend WithEvents TableAdapterManager As RUBIAPPLICATION.BDSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LivroBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LivroBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdLivroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TítuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EdiçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalizaçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AssuntoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassificaçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColeçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TomboCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ResenhaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutoresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentáriosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents EditoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EditoraTableAdapter As RUBIAPPLICATION.BDSystem1DataSetTableAdapters.EditoraTableAdapter
End Class
