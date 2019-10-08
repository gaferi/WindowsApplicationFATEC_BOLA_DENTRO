<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_alteracao_aluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_alteracao_aluno))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rg_dig = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.id_retornado = New System.Windows.Forms.Label()
        Me.data_exame_medico = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.data_ingresso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nome_pai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mae_aluno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.data_nascimento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nome_aluno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkbox_encordoador_novo = New System.Windows.Forms.CheckBox()
        Me.checkbox_arbitro_novo = New System.Windows.Forms.CheckBox()
        Me.checkbox_ajudante_quadra_novo = New System.Windows.Forms.CheckBox()
        Me.checkbox_boleiro_novo = New System.Windows.Forms.CheckBox()
        Me.checkbox_encordoador = New System.Windows.Forms.CheckBox()
        Me.checkbox_arbitro = New System.Windows.Forms.CheckBox()
        Me.checkbox_ajudante_quadra = New System.Windows.Forms.CheckBox()
        Me.checkbox_boleiro = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rg_dig)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Aluno"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(33, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Pesquisar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rg_dig
        '
        Me.rg_dig.Location = New System.Drawing.Point(33, 65)
        Me.rg_dig.Mask = "000000000"
        Me.rg_dig.Name = "rg_dig"
        Me.rg_dig.Size = New System.Drawing.Size(100, 25)
        Me.rg_dig.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite o RG do Aluno"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.id_retornado)
        Me.GroupBox2.Controls.Add(Me.data_exame_medico)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.data_ingresso)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.rg)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.nome_pai)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.mae_aluno)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.data_nascimento)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.nome_aluno)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(513, 394)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações do aluno"
        '
        'id_retornado
        '
        Me.id_retornado.AutoSize = True
        Me.id_retornado.Location = New System.Drawing.Point(394, 261)
        Me.id_retornado.Name = "id_retornado"
        Me.id_retornado.Size = New System.Drawing.Size(78, 24)
        Me.id_retornado.TabIndex = 14
        Me.id_retornado.Text = "Label9"
        Me.id_retornado.Visible = False
        '
        'data_exame_medico
        '
        Me.data_exame_medico.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_exame_medico.Location = New System.Drawing.Point(182, 350)
        Me.data_exame_medico.Name = "data_exame_medico"
        Me.data_exame_medico.Size = New System.Drawing.Size(100, 25)
        Me.data_exame_medico.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(59, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Exame médico:"
        '
        'data_ingresso
        '
        Me.data_ingresso.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_ingresso.Location = New System.Drawing.Point(182, 300)
        Me.data_ingresso.Name = "data_ingresso"
        Me.data_ingresso.Size = New System.Drawing.Size(100, 25)
        Me.data_ingresso.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Data de ingresso:"
        '
        'rg
        '
        Me.rg.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rg.Location = New System.Drawing.Point(182, 250)
        Me.rg.Name = "rg"
        Me.rg.Size = New System.Drawing.Size(100, 25)
        Me.rg.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "RG:"
        '
        'nome_pai
        '
        Me.nome_pai.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome_pai.Location = New System.Drawing.Point(182, 150)
        Me.nome_pai.Name = "nome_pai"
        Me.nome_pai.Size = New System.Drawing.Size(310, 25)
        Me.nome_pai.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nome do pai:"
        '
        'mae_aluno
        '
        Me.mae_aluno.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mae_aluno.Location = New System.Drawing.Point(182, 100)
        Me.mae_aluno.Name = "mae_aluno"
        Me.mae_aluno.Size = New System.Drawing.Size(310, 25)
        Me.mae_aluno.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nome da mãe:"
        '
        'data_nascimento
        '
        Me.data_nascimento.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_nascimento.Location = New System.Drawing.Point(182, 200)
        Me.data_nascimento.Name = "data_nascimento"
        Me.data_nascimento.Size = New System.Drawing.Size(100, 25)
        Me.data_nascimento.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data de nascimento:"
        '
        'nome_aluno
        '
        Me.nome_aluno.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome_aluno.Location = New System.Drawing.Point(182, 50)
        Me.nome_aluno.Name = "nome_aluno"
        Me.nome_aluno.Size = New System.Drawing.Size(310, 25)
        Me.nome_aluno.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nome do aluno:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkbox_encordoador_novo)
        Me.GroupBox3.Controls.Add(Me.checkbox_arbitro_novo)
        Me.GroupBox3.Controls.Add(Me.checkbox_ajudante_quadra_novo)
        Me.GroupBox3.Controls.Add(Me.checkbox_boleiro_novo)
        Me.GroupBox3.Controls.Add(Me.checkbox_encordoador)
        Me.GroupBox3.Controls.Add(Me.checkbox_arbitro)
        Me.GroupBox3.Controls.Add(Me.checkbox_ajudante_quadra)
        Me.GroupBox3.Controls.Add(Me.checkbox_boleiro)
        Me.GroupBox3.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(542, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 281)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Atividades Aluno"
        '
        'checkbox_encordoador_novo
        '
        Me.checkbox_encordoador_novo.AutoSize = True
        Me.checkbox_encordoador_novo.Location = New System.Drawing.Point(19, 223)
        Me.checkbox_encordoador_novo.Name = "checkbox_encordoador_novo"
        Me.checkbox_encordoador_novo.Size = New System.Drawing.Size(160, 28)
        Me.checkbox_encordoador_novo.TabIndex = 11
        Me.checkbox_encordoador_novo.Text = "Encordoador"
        Me.checkbox_encordoador_novo.UseVisualStyleBackColor = True
        '
        'checkbox_arbitro_novo
        '
        Me.checkbox_arbitro_novo.AutoSize = True
        Me.checkbox_arbitro_novo.Location = New System.Drawing.Point(19, 168)
        Me.checkbox_arbitro_novo.Name = "checkbox_arbitro_novo"
        Me.checkbox_arbitro_novo.Size = New System.Drawing.Size(100, 28)
        Me.checkbox_arbitro_novo.TabIndex = 10
        Me.checkbox_arbitro_novo.Text = "Arbitro"
        Me.checkbox_arbitro_novo.UseVisualStyleBackColor = True
        '
        'checkbox_ajudante_quadra_novo
        '
        Me.checkbox_ajudante_quadra_novo.AutoSize = True
        Me.checkbox_ajudante_quadra_novo.Location = New System.Drawing.Point(19, 109)
        Me.checkbox_ajudante_quadra_novo.Name = "checkbox_ajudante_quadra_novo"
        Me.checkbox_ajudante_quadra_novo.Size = New System.Drawing.Size(236, 28)
        Me.checkbox_ajudante_quadra_novo.TabIndex = 9
        Me.checkbox_ajudante_quadra_novo.Text = "Ajudante de Quadra"
        Me.checkbox_ajudante_quadra_novo.UseVisualStyleBackColor = True
        '
        'checkbox_boleiro_novo
        '
        Me.checkbox_boleiro_novo.AutoSize = True
        Me.checkbox_boleiro_novo.Location = New System.Drawing.Point(19, 52)
        Me.checkbox_boleiro_novo.Name = "checkbox_boleiro_novo"
        Me.checkbox_boleiro_novo.Size = New System.Drawing.Size(101, 28)
        Me.checkbox_boleiro_novo.TabIndex = 8
        Me.checkbox_boleiro_novo.Text = "Boleiro"
        Me.checkbox_boleiro_novo.UseVisualStyleBackColor = True
        '
        'checkbox_encordoador
        '
        Me.checkbox_encordoador.AutoSize = True
        Me.checkbox_encordoador.Enabled = False
        Me.checkbox_encordoador.Location = New System.Drawing.Point(425, 148)
        Me.checkbox_encordoador.Name = "checkbox_encordoador"
        Me.checkbox_encordoador.Size = New System.Drawing.Size(235, 28)
        Me.checkbox_encordoador.TabIndex = 7
        Me.checkbox_encordoador.Text = "Encordoador(antigo)"
        Me.checkbox_encordoador.UseVisualStyleBackColor = True
        Me.checkbox_encordoador.Visible = False
        '
        'checkbox_arbitro
        '
        Me.checkbox_arbitro.AutoSize = True
        Me.checkbox_arbitro.Enabled = False
        Me.checkbox_arbitro.Location = New System.Drawing.Point(425, 109)
        Me.checkbox_arbitro.Name = "checkbox_arbitro"
        Me.checkbox_arbitro.Size = New System.Drawing.Size(175, 28)
        Me.checkbox_arbitro.TabIndex = 6
        Me.checkbox_arbitro.Text = "Arbitro(antigo)"
        Me.checkbox_arbitro.UseVisualStyleBackColor = True
        Me.checkbox_arbitro.Visible = False
        '
        'checkbox_ajudante_quadra
        '
        Me.checkbox_ajudante_quadra.AutoSize = True
        Me.checkbox_ajudante_quadra.Enabled = False
        Me.checkbox_ajudante_quadra.Location = New System.Drawing.Point(425, 72)
        Me.checkbox_ajudante_quadra.Name = "checkbox_ajudante_quadra"
        Me.checkbox_ajudante_quadra.Size = New System.Drawing.Size(311, 28)
        Me.checkbox_ajudante_quadra.TabIndex = 5
        Me.checkbox_ajudante_quadra.Text = "Ajudante de Quadra(antigo)"
        Me.checkbox_ajudante_quadra.UseVisualStyleBackColor = True
        Me.checkbox_ajudante_quadra.Visible = False
        '
        'checkbox_boleiro
        '
        Me.checkbox_boleiro.AutoSize = True
        Me.checkbox_boleiro.Enabled = False
        Me.checkbox_boleiro.Location = New System.Drawing.Point(425, 37)
        Me.checkbox_boleiro.Name = "checkbox_boleiro"
        Me.checkbox_boleiro.Size = New System.Drawing.Size(176, 28)
        Me.checkbox_boleiro.TabIndex = 4
        Me.checkbox_boleiro.Text = "Boleiro(antigo)"
        Me.checkbox_boleiro.UseVisualStyleBackColor = True
        Me.checkbox_boleiro.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(542, 494)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 72)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Alterar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(784, 494)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 72)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Voltar Para Menu Principal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(667, 494)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 72)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Excluir Aluno"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form_alteracao_aluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(928, 578)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_alteracao_aluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alteração de cadastro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents data_exame_medico As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents data_ingresso As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rg As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nome_pai As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mae_aluno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents data_nascimento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nome_aluno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents checkbox_encordoador As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_arbitro As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_ajudante_quadra As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_boleiro As System.Windows.Forms.CheckBox
    Friend WithEvents id_retornado As System.Windows.Forms.Label
    Friend WithEvents rg_dig As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents checkbox_encordoador_novo As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_arbitro_novo As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_ajudante_quadra_novo As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_boleiro_novo As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
