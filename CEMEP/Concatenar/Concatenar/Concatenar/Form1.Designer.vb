<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frnconcatenar
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
        Me.Lblnome = New System.Windows.Forms.Label
        Me.Lblsobrenome = New System.Windows.Forms.Label
        Me.Txtnome = New System.Windows.Forms.TextBox
        Me.Txtsobrenome = New System.Windows.Forms.TextBox
        Me.Btncomcatenar = New System.Windows.Forms.Button
        Me.Lblconcatenar = New System.Windows.Forms.Label
        Me.Limpar = New System.Windows.Forms.Button
        Me.Sair = New System.Windows.Forms.Button
        Me.Cores = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Lblnome
        '
        Me.Lblnome.AutoSize = True
        Me.Lblnome.BackColor = System.Drawing.Color.Black
        Me.Lblnome.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnome.ForeColor = System.Drawing.Color.White
        Me.Lblnome.Location = New System.Drawing.Point(12, 23)
        Me.Lblnome.Name = "Lblnome"
        Me.Lblnome.Size = New System.Drawing.Size(193, 23)
        Me.Lblnome.TabIndex = 0
        Me.Lblnome.Text = "Informe seu nome:"
        '
        'Lblsobrenome
        '
        Me.Lblsobrenome.AutoSize = True
        Me.Lblsobrenome.BackColor = System.Drawing.Color.Black
        Me.Lblsobrenome.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsobrenome.ForeColor = System.Drawing.Color.White
        Me.Lblsobrenome.Location = New System.Drawing.Point(220, 23)
        Me.Lblsobrenome.Name = "Lblsobrenome"
        Me.Lblsobrenome.Size = New System.Drawing.Size(223, 23)
        Me.Lblsobrenome.TabIndex = 1
        Me.Lblsobrenome.Text = "Informe o sobrenome:"
        '
        'Txtnome
        '
        Me.Txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtnome.Location = New System.Drawing.Point(12, 49)
        Me.Txtnome.Name = "Txtnome"
        Me.Txtnome.Size = New System.Drawing.Size(193, 20)
        Me.Txtnome.TabIndex = 2
        '
        'Txtsobrenome
        '
        Me.Txtsobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtsobrenome.Location = New System.Drawing.Point(219, 49)
        Me.Txtsobrenome.Name = "Txtsobrenome"
        Me.Txtsobrenome.Size = New System.Drawing.Size(224, 20)
        Me.Txtsobrenome.TabIndex = 3
        '
        'Btncomcatenar
        '
        Me.Btncomcatenar.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncomcatenar.Location = New System.Drawing.Point(40, 96)
        Me.Btncomcatenar.Name = "Btncomcatenar"
        Me.Btncomcatenar.Size = New System.Drawing.Size(139, 32)
        Me.Btncomcatenar.TabIndex = 4
        Me.Btncomcatenar.Text = "Concatenar"
        Me.Btncomcatenar.UseVisualStyleBackColor = True
        '
        'Lblconcatenar
        '
        Me.Lblconcatenar.AutoSize = True
        Me.Lblconcatenar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lblconcatenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblconcatenar.Location = New System.Drawing.Point(164, 159)
        Me.Lblconcatenar.Name = "Lblconcatenar"
        Me.Lblconcatenar.Size = New System.Drawing.Size(0, 24)
        Me.Lblconcatenar.TabIndex = 5
        '
        'Limpar
        '
        Me.Limpar.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpar.Location = New System.Drawing.Point(286, 98)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(91, 30)
        Me.Limpar.TabIndex = 6
        Me.Limpar.Text = "Limpar"
        Me.Limpar.UseVisualStyleBackColor = True
        '
        'Sair
        '
        Me.Sair.BackColor = System.Drawing.Color.LightGreen
        Me.Sair.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sair.Location = New System.Drawing.Point(287, 211)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(90, 35)
        Me.Sair.TabIndex = 7
        Me.Sair.Text = "Sair"
        Me.Sair.UseVisualStyleBackColor = False
        '
        'Cores
        '
        Me.Cores.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cores.Location = New System.Drawing.Point(55, 216)
        Me.Cores.Name = "Cores"
        Me.Cores.Size = New System.Drawing.Size(111, 30)
        Me.Cores.TabIndex = 8
        Me.Cores.Text = "Cores"
        Me.Cores.UseVisualStyleBackColor = True
        '
        'Frnconcatenar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(456, 258)
        Me.Controls.Add(Me.Cores)
        Me.Controls.Add(Me.Sair)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.Lblconcatenar)
        Me.Controls.Add(Me.Btncomcatenar)
        Me.Controls.Add(Me.Txtsobrenome)
        Me.Controls.Add(Me.Txtnome)
        Me.Controls.Add(Me.Lblsobrenome)
        Me.Controls.Add(Me.Lblnome)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frnconcatenar"
        Me.Text = "Programa Concatenar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblnome As System.Windows.Forms.Label
    Friend WithEvents Lblsobrenome As System.Windows.Forms.Label
    Friend WithEvents Txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Txtsobrenome As System.Windows.Forms.TextBox
    Friend WithEvents Btncomcatenar As System.Windows.Forms.Button
    Public WithEvents Lblconcatenar As System.Windows.Forms.Label
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents Sair As System.Windows.Forms.Button
    Friend WithEvents Cores As System.Windows.Forms.Button

End Class
