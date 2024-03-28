<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.Nome = New System.Windows.Forms.Label
        Me.Aluno = New System.Windows.Forms.Label
        Me.Série = New System.Windows.Forms.Label
        Me.Turma = New System.Windows.Forms.Label
        Me.Concatenar = New System.Windows.Forms.Button
        Me.Limpar = New System.Windows.Forms.Button
        Me.Sair = New System.Windows.Forms.Button
        Me.Cores = New System.Windows.Forms.Button
        Me.Ano = New System.Windows.Forms.Label
        Me.FormEsco = New System.Windows.Forms.Label
        Me.Txtnome = New System.Windows.Forms.TextBox
        Me.Txtturma = New System.Windows.Forms.TextBox
        Me.Txtano = New System.Windows.Forms.TextBox
        Me.Txtaluno = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Resultado = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.BackColor = System.Drawing.Color.White
        Me.Nome.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome.Location = New System.Drawing.Point(12, 63)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(201, 24)
        Me.Nome.TabIndex = 0
        Me.Nome.Text = "Nome do Colégio: "
        '
        'Aluno
        '
        Me.Aluno.AutoSize = True
        Me.Aluno.BackColor = System.Drawing.Color.White
        Me.Aluno.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aluno.Location = New System.Drawing.Point(12, 111)
        Me.Aluno.Name = "Aluno"
        Me.Aluno.Size = New System.Drawing.Size(186, 24)
        Me.Aluno.TabIndex = 1
        Me.Aluno.Text = "Nome do Aluno: "
        '
        'Série
        '
        Me.Série.AutoSize = True
        Me.Série.BackColor = System.Drawing.Color.White
        Me.Série.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Série.Location = New System.Drawing.Point(12, 158)
        Me.Série.Name = "Série"
        Me.Série.Size = New System.Drawing.Size(73, 24)
        Me.Série.TabIndex = 2
        Me.Série.Text = "Série: "
        '
        'Turma
        '
        Me.Turma.AutoSize = True
        Me.Turma.BackColor = System.Drawing.Color.White
        Me.Turma.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Turma.Location = New System.Drawing.Point(12, 212)
        Me.Turma.Name = "Turma"
        Me.Turma.Size = New System.Drawing.Size(83, 24)
        Me.Turma.TabIndex = 3
        Me.Turma.Text = "Turma"
        '
        'Concatenar
        '
        Me.Concatenar.BackColor = System.Drawing.Color.White
        Me.Concatenar.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Concatenar.Location = New System.Drawing.Point(493, 179)
        Me.Concatenar.Name = "Concatenar"
        Me.Concatenar.Size = New System.Drawing.Size(144, 31)
        Me.Concatenar.TabIndex = 6
        Me.Concatenar.Text = "Concatenar"
        Me.Concatenar.UseVisualStyleBackColor = False
        '
        'Limpar
        '
        Me.Limpar.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpar.Location = New System.Drawing.Point(12, 318)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(101, 32)
        Me.Limpar.TabIndex = 7
        Me.Limpar.Text = "Limpar"
        Me.Limpar.UseVisualStyleBackColor = True
        '
        'Sair
        '
        Me.Sair.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sair.Location = New System.Drawing.Point(556, 319)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(101, 31)
        Me.Sair.TabIndex = 9
        Me.Sair.Text = "Sair"
        Me.Sair.UseVisualStyleBackColor = True
        '
        'Cores
        '
        Me.Cores.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cores.Location = New System.Drawing.Point(547, 9)
        Me.Cores.Name = "Cores"
        Me.Cores.Size = New System.Drawing.Size(101, 31)
        Me.Cores.TabIndex = 8
        Me.Cores.Text = "Cores"
        Me.Cores.UseVisualStyleBackColor = True
        '
        'Ano
        '
        Me.Ano.AutoSize = True
        Me.Ano.BackColor = System.Drawing.Color.White
        Me.Ano.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ano.Location = New System.Drawing.Point(12, 261)
        Me.Ano.Name = "Ano"
        Me.Ano.Size = New System.Drawing.Size(52, 24)
        Me.Ano.TabIndex = 8
        Me.Ano.Text = "Ano"
        '
        'FormEsco
        '
        Me.FormEsco.AutoSize = True
        Me.FormEsco.BackColor = System.Drawing.Color.White
        Me.FormEsco.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormEsco.Location = New System.Drawing.Point(190, 9)
        Me.FormEsco.Name = "FormEsco"
        Me.FormEsco.Size = New System.Drawing.Size(294, 31)
        Me.FormEsco.TabIndex = 9
        Me.FormEsco.Text = "Formulário Escolar"
        '
        'Txtnome
        '
        Me.Txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtnome.Location = New System.Drawing.Point(264, 63)
        Me.Txtnome.Name = "Txtnome"
        Me.Txtnome.Size = New System.Drawing.Size(143, 20)
        Me.Txtnome.TabIndex = 1
        '
        'Txtturma
        '
        Me.Txtturma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtturma.Location = New System.Drawing.Point(264, 212)
        Me.Txtturma.Name = "Txtturma"
        Me.Txtturma.Size = New System.Drawing.Size(143, 20)
        Me.Txtturma.TabIndex = 4
        '
        'Txtano
        '
        Me.Txtano.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtano.Location = New System.Drawing.Point(264, 261)
        Me.Txtano.Name = "Txtano"
        Me.Txtano.Size = New System.Drawing.Size(143, 20)
        Me.Txtano.TabIndex = 5
        '
        'Txtaluno
        '
        Me.Txtaluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtaluno.Location = New System.Drawing.Point(264, 111)
        Me.Txtaluno.Name = "Txtaluno"
        Me.Txtaluno.Size = New System.Drawing.Size(143, 20)
        Me.Txtaluno.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1º (Primeiro)", "2º (Segundo)", "3º (Terceiro)"})
        Me.ComboBox1.Location = New System.Drawing.Point(264, 158)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.BackColor = System.Drawing.Color.Transparent
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Resultado.Location = New System.Drawing.Point(213, 318)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(0, 25)
        Me.Resultado.TabIndex = 17
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(660, 362)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Txtaluno)
        Me.Controls.Add(Me.Txtano)
        Me.Controls.Add(Me.Txtturma)
        Me.Controls.Add(Me.Txtnome)
        Me.Controls.Add(Me.FormEsco)
        Me.Controls.Add(Me.Ano)
        Me.Controls.Add(Me.Cores)
        Me.Controls.Add(Me.Sair)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.Concatenar)
        Me.Controls.Add(Me.Turma)
        Me.Controls.Add(Me.Série)
        Me.Controls.Add(Me.Aluno)
        Me.Controls.Add(Me.Nome)
        Me.Name = "Form"
        Me.Text = "Formulário Escola"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nome As System.Windows.Forms.Label
    Friend WithEvents Aluno As System.Windows.Forms.Label
    Friend WithEvents Série As System.Windows.Forms.Label
    Friend WithEvents Turma As System.Windows.Forms.Label
    Friend WithEvents Concatenar As System.Windows.Forms.Button
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents Sair As System.Windows.Forms.Button
    Friend WithEvents Cores As System.Windows.Forms.Button
    Friend WithEvents Ano As System.Windows.Forms.Label
    Friend WithEvents FormEsco As System.Windows.Forms.Label
    Friend WithEvents Txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Txtturma As System.Windows.Forms.TextBox
    Friend WithEvents Txtano As System.Windows.Forms.TextBox
    Friend WithEvents Txtaluno As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Resultado As System.Windows.Forms.Label

End Class
