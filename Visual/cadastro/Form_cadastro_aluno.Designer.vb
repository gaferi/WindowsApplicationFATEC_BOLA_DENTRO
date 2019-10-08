<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cadastro_aluno
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_cadastro_aluno))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nome_aluno = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mae_aluno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nome_pai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.data_exame_medico = New System.Windows.Forms.TextBox()
        Me.data_ingresso = New System.Windows.Forms.TextBox()
        Me.rg = New System.Windows.Forms.TextBox()
        Me.data_nascimento = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkbox_encordoador = New System.Windows.Forms.CheckBox()
        Me.checkbox_arbitro = New System.Windows.Forms.CheckBox()
        Me.checkbox_ajudante_quadra = New System.Windows.Forms.CheckBox()
        Me.checkbox_boleiro = New System.Windows.Forms.CheckBox()
        Me.retorno_id = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.sem_ranking = New System.Windows.Forms.RadioButton()
        Me.categoria_d = New System.Windows.Forms.RadioButton()
        Me.categoria_c = New System.Windows.Forms.RadioButton()
        Me.categoria_b = New System.Windows.Forms.RadioButton()
        Me.categoria_a = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.categoria_jogador = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do aluno:"
        '
        'nome_aluno
        '
        Me.nome_aluno.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome_aluno.Location = New System.Drawing.Point(197, 50)
        Me.nome_aluno.Name = "nome_aluno"
        Me.nome_aluno.Size = New System.Drawing.Size(295, 25)
        Me.nome_aluno.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(249, 611)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cadastrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data de nascimento: "
        '
        'mae_aluno
        '
        Me.mae_aluno.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mae_aluno.Location = New System.Drawing.Point(197, 100)
        Me.mae_aluno.Name = "mae_aluno"
        Me.mae_aluno.Size = New System.Drawing.Size(295, 25)
        Me.mae_aluno.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nome da mãe: "
        '
        'nome_pai
        '
        Me.nome_pai.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome_pai.Location = New System.Drawing.Point(197, 150)
        Me.nome_pai.Name = "nome_pai"
        Me.nome_pai.Size = New System.Drawing.Size(295, 25)
        Me.nome_pai.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nome do pai: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(336, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "RG: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Data de ingresso:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Data do exame médico:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.data_exame_medico)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.data_ingresso)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rg)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nome_pai)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.mae_aluno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.data_nascimento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nome_aluno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 345)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações do aluno"
        '
        'data_exame_medico
        '
        Me.data_exame_medico.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_exame_medico.Location = New System.Drawing.Point(197, 289)
        Me.data_exame_medico.Name = "data_exame_medico"
        Me.data_exame_medico.Size = New System.Drawing.Size(129, 25)
        Me.data_exame_medico.TabIndex = 7
        '
        'data_ingresso
        '
        Me.data_ingresso.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_ingresso.Location = New System.Drawing.Point(197, 241)
        Me.data_ingresso.Name = "data_ingresso"
        Me.data_ingresso.Size = New System.Drawing.Size(129, 25)
        Me.data_ingresso.TabIndex = 6
        '
        'rg
        '
        Me.rg.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rg.Location = New System.Drawing.Point(384, 197)
        Me.rg.Name = "rg"
        Me.rg.Size = New System.Drawing.Size(108, 25)
        Me.rg.TabIndex = 5
        '
        'data_nascimento
        '
        Me.data_nascimento.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_nascimento.Location = New System.Drawing.Point(197, 197)
        Me.data_nascimento.Name = "data_nascimento"
        Me.data_nascimento.Size = New System.Drawing.Size(129, 25)
        Me.data_nascimento.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox2.Controls.Add(Me.checkbox_encordoador)
        Me.GroupBox2.Controls.Add(Me.checkbox_arbitro)
        Me.GroupBox2.Controls.Add(Me.checkbox_ajudante_quadra)
        Me.GroupBox2.Controls.Add(Me.checkbox_boleiro)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(305, 378)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 174)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Atividade do Aluno"
        '
        'checkbox_encordoador
        '
        Me.checkbox_encordoador.AutoSize = True
        Me.checkbox_encordoador.Location = New System.Drawing.Point(6, 135)
        Me.checkbox_encordoador.Name = "checkbox_encordoador"
        Me.checkbox_encordoador.Size = New System.Drawing.Size(121, 23)
        Me.checkbox_encordoador.TabIndex = 7
        Me.checkbox_encordoador.Text = "Encordoador"
        Me.checkbox_encordoador.UseVisualStyleBackColor = True
        '
        'checkbox_arbitro
        '
        Me.checkbox_arbitro.AutoSize = True
        Me.checkbox_arbitro.Location = New System.Drawing.Point(6, 104)
        Me.checkbox_arbitro.Name = "checkbox_arbitro"
        Me.checkbox_arbitro.Size = New System.Drawing.Size(79, 23)
        Me.checkbox_arbitro.TabIndex = 6
        Me.checkbox_arbitro.Text = "Arbitro"
        Me.checkbox_arbitro.UseVisualStyleBackColor = True
        '
        'checkbox_ajudante_quadra
        '
        Me.checkbox_ajudante_quadra.AutoSize = True
        Me.checkbox_ajudante_quadra.Location = New System.Drawing.Point(6, 70)
        Me.checkbox_ajudante_quadra.Name = "checkbox_ajudante_quadra"
        Me.checkbox_ajudante_quadra.Size = New System.Drawing.Size(180, 23)
        Me.checkbox_ajudante_quadra.TabIndex = 5
        Me.checkbox_ajudante_quadra.Text = "Ajudante de Quadra"
        Me.checkbox_ajudante_quadra.UseVisualStyleBackColor = True
        '
        'checkbox_boleiro
        '
        Me.checkbox_boleiro.AutoSize = True
        Me.checkbox_boleiro.Location = New System.Drawing.Point(6, 35)
        Me.checkbox_boleiro.Name = "checkbox_boleiro"
        Me.checkbox_boleiro.Size = New System.Drawing.Size(81, 23)
        Me.checkbox_boleiro.TabIndex = 4
        Me.checkbox_boleiro.Text = "Boleiro"
        Me.checkbox_boleiro.UseVisualStyleBackColor = True
        '
        'retorno_id
        '
        Me.retorno_id.AutoSize = True
        Me.retorno_id.Location = New System.Drawing.Point(180, 624)
        Me.retorno_id.Name = "retorno_id"
        Me.retorno_id.Size = New System.Drawing.Size(39, 13)
        Me.retorno_id.TabIndex = 16
        Me.retorno_id.Text = "Label8"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox3.Controls.Add(Me.sem_ranking)
        Me.GroupBox3.Controls.Add(Me.categoria_d)
        Me.GroupBox3.Controls.Add(Me.categoria_c)
        Me.GroupBox3.Controls.Add(Me.categoria_b)
        Me.GroupBox3.Controls.Add(Me.categoria_a)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 378)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 174)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informações Ranking"
        '
        'sem_ranking
        '
        Me.sem_ranking.AutoSize = True
        Me.sem_ranking.Location = New System.Drawing.Point(16, 137)
        Me.sem_ranking.Name = "sem_ranking"
        Me.sem_ranking.Size = New System.Drawing.Size(231, 23)
        Me.sem_ranking.TabIndex = 17
        Me.sem_ranking.TabStop = True
        Me.sem_ranking.Text = "Não Participará do Ranking"
        Me.sem_ranking.UseVisualStyleBackColor = True
        '
        'categoria_d
        '
        Me.categoria_d.AutoSize = True
        Me.categoria_d.Location = New System.Drawing.Point(137, 99)
        Me.categoria_d.Name = "categoria_d"
        Me.categoria_d.Size = New System.Drawing.Size(39, 23)
        Me.categoria_d.TabIndex = 15
        Me.categoria_d.TabStop = True
        Me.categoria_d.Text = "D"
        Me.categoria_d.UseVisualStyleBackColor = True
        '
        'categoria_c
        '
        Me.categoria_c.AutoSize = True
        Me.categoria_c.Location = New System.Drawing.Point(139, 61)
        Me.categoria_c.Name = "categoria_c"
        Me.categoria_c.Size = New System.Drawing.Size(38, 23)
        Me.categoria_c.TabIndex = 14
        Me.categoria_c.TabStop = True
        Me.categoria_c.Text = "C"
        Me.categoria_c.UseVisualStyleBackColor = True
        '
        'categoria_b
        '
        Me.categoria_b.AutoSize = True
        Me.categoria_b.Location = New System.Drawing.Point(70, 99)
        Me.categoria_b.Name = "categoria_b"
        Me.categoria_b.Size = New System.Drawing.Size(38, 23)
        Me.categoria_b.TabIndex = 13
        Me.categoria_b.TabStop = True
        Me.categoria_b.Text = "B"
        Me.categoria_b.UseVisualStyleBackColor = True
        '
        'categoria_a
        '
        Me.categoria_a.AutoSize = True
        Me.categoria_a.Location = New System.Drawing.Point(70, 61)
        Me.categoria_a.Name = "categoria_a"
        Me.categoria_a.Size = New System.Drawing.Size(37, 23)
        Me.categoria_a.TabIndex = 12
        Me.categoria_a.TabStop = True
        Me.categoria_a.Text = "A"
        Me.categoria_a.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(79, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Categoria"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(395, 593)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 72)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Voltar Para Menu Principal"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'categoria_jogador
        '
        Me.categoria_jogador.AutoSize = True
        Me.categoria_jogador.ForeColor = System.Drawing.Color.Transparent
        Me.categoria_jogador.Location = New System.Drawing.Point(49, 611)
        Me.categoria_jogador.Name = "categoria_jogador"
        Me.categoria_jogador.Size = New System.Drawing.Size(39, 13)
        Me.categoria_jogador.TabIndex = 21
        Me.categoria_jogador.Text = "Label9"
        '
        'Form_cadastro_aluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(566, 693)
        Me.Controls.Add(Me.categoria_jogador)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.retorno_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_cadastro_aluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de aluno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nome_aluno As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mae_aluno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nome_pai As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents checkbox_encordoador As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_arbitro As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_ajudante_quadra As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_boleiro As System.Windows.Forms.CheckBox
    Friend WithEvents retorno_id As System.Windows.Forms.Label
    Friend WithEvents data_ingresso As System.Windows.Forms.TextBox
    Friend WithEvents rg As System.Windows.Forms.TextBox
    Friend WithEvents data_exame_medico As System.Windows.Forms.TextBox
    Friend WithEvents data_nascimento As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents categoria_d As System.Windows.Forms.RadioButton
    Friend WithEvents categoria_c As System.Windows.Forms.RadioButton
    Friend WithEvents categoria_b As System.Windows.Forms.RadioButton
    Friend WithEvents categoria_a As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents sem_ranking As System.Windows.Forms.RadioButton
    Friend WithEvents categoria_jogador As System.Windows.Forms.Label
End Class
