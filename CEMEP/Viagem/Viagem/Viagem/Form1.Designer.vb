<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblpaisescolhido = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblnumpais = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Cidades = New System.Windows.Forms.GroupBox
        Me.lblcidadeescolhida = New System.Windows.Forms.Label
        Me.lblnumcidades = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Cidades.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblpaisescolhido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblnumpais)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Países"
        '
        'lblpaisescolhido
        '
        Me.lblpaisescolhido.AutoSize = True
        Me.lblpaisescolhido.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblpaisescolhido.Location = New System.Drawing.Point(441, 144)
        Me.lblpaisescolhido.Name = "lblpaisescolhido"
        Me.lblpaisescolhido.Size = New System.Drawing.Size(0, 26)
        Me.lblpaisescolhido.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "País escolhido"
        '
        'lblnumpais
        '
        Me.lblnumpais.AutoSize = True
        Me.lblnumpais.Location = New System.Drawing.Point(444, 62)
        Me.lblnumpais.Name = "lblnumpais"
        Me.lblnumpais.Size = New System.Drawing.Size(0, 26)
        Me.lblnumpais.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nº de Países"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 26
        Me.ListBox1.Items.AddRange(New Object() {"Portugal", "Itália", "França", "Argentina", "Chile", "Japão", "Uruguai"})
        Me.ListBox1.Location = New System.Drawing.Point(306, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 134)
        Me.ListBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(179, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Remover"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(179, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 33)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "País"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Lisboa", "Roma", "Paris", "Buenos Aires", "Santiago", "Tokyo", "Montevideo"})
        Me.ComboBox1.Location = New System.Drawing.Point(306, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox1.TabIndex = 8
        '
        'Cidades
        '
        Me.Cidades.Controls.Add(Me.lblcidadeescolhida)
        Me.Cidades.Controls.Add(Me.lblnumcidades)
        Me.Cidades.Controls.Add(Me.Label6)
        Me.Cidades.Controls.Add(Me.Label5)
        Me.Cidades.Controls.Add(Me.Button4)
        Me.Cidades.Controls.Add(Me.Button3)
        Me.Cidades.Controls.Add(Me.TextBox2)
        Me.Cidades.Controls.Add(Me.Label3)
        Me.Cidades.Controls.Add(Me.ComboBox1)
        Me.Cidades.Font = New System.Drawing.Font("Palatino Linotype", 14.25!)
        Me.Cidades.Location = New System.Drawing.Point(30, 264)
        Me.Cidades.Name = "Cidades"
        Me.Cidades.Size = New System.Drawing.Size(568, 198)
        Me.Cidades.TabIndex = 1
        Me.Cidades.TabStop = False
        Me.Cidades.Text = "Cidades"
        '
        'lblcidadeescolhida
        '
        Me.lblcidadeescolhida.AutoSize = True
        Me.lblcidadeescolhida.Location = New System.Drawing.Point(444, 159)
        Me.lblcidadeescolhida.Name = "lblcidadeescolhida"
        Me.lblcidadeescolhida.Size = New System.Drawing.Size(0, 26)
        Me.lblcidadeescolhida.TabIndex = 16
        '
        'lblnumcidades
        '
        Me.lblnumcidades.AutoSize = True
        Me.lblnumcidades.Location = New System.Drawing.Point(444, 67)
        Me.lblnumcidades.Name = "lblnumcidades"
        Me.lblnumcidades.Size = New System.Drawing.Size(0, 26)
        Me.lblnumcidades.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cidade escolhida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(436, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nº de cidades"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(179, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 31)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Remover"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(179, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 31)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Adicionar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(24, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(135, 33)
        Me.TextBox2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cidade"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(621, 474)
        Me.Controls.Add(Me.Cidades)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lugares que quero conhecer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Cidades.ResumeLayout(False)
        Me.Cidades.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblpaisescolhido As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblnumpais As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Cidades As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblcidadeescolhida As System.Windows.Forms.Label
    Friend WithEvents lblnumcidades As System.Windows.Forms.Label

End Class
