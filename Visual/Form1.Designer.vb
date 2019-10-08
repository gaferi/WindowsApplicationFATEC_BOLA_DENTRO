<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlunoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlunosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudantesDeQuadraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArbitrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoleiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncordoadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlteraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlunosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocoDeNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvD = New System.Windows.Forms.DataGridView()
        Me.dgvC = New System.Windows.Forms.DataGridView()
        Me.dgvB = New System.Windows.Forms.DataGridView()
        Me.dgvA = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtteste = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.MenuStrip1.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.AlteraçõesToolStripMenuItem, Me.FerramentasToolStripMenuItem, Me.SairToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1386, 50)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlunoToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(88, 46)
        Me.CadastrosToolStripMenuItem.Text = "Cadastro"
        '
        'AlunoToolStripMenuItem
        '
        Me.AlunoToolStripMenuItem.Name = "AlunoToolStripMenuItem"
        Me.AlunoToolStripMenuItem.Size = New System.Drawing.Size(188, 24)
        Me.AlunoToolStripMenuItem.Text = "Aluno/Jogador"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlunosToolStripMenuItem, Me.AjudantesDeQuadraToolStripMenuItem, Me.ArbitrosToolStripMenuItem, Me.BoleiroToolStripMenuItem, Me.EncordoadorToolStripMenuItem, Me.JogadoresToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(96, 46)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'AlunosToolStripMenuItem
        '
        Me.AlunosToolStripMenuItem.Name = "AlunosToolStripMenuItem"
        Me.AlunosToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.AlunosToolStripMenuItem.Text = "Alunos"
        '
        'AjudantesDeQuadraToolStripMenuItem
        '
        Me.AjudantesDeQuadraToolStripMenuItem.Name = "AjudantesDeQuadraToolStripMenuItem"
        Me.AjudantesDeQuadraToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.AjudantesDeQuadraToolStripMenuItem.Text = "Ajudantes de Quadra"
        '
        'ArbitrosToolStripMenuItem
        '
        Me.ArbitrosToolStripMenuItem.Name = "ArbitrosToolStripMenuItem"
        Me.ArbitrosToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.ArbitrosToolStripMenuItem.Text = "Arbitros"
        '
        'BoleiroToolStripMenuItem
        '
        Me.BoleiroToolStripMenuItem.Name = "BoleiroToolStripMenuItem"
        Me.BoleiroToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.BoleiroToolStripMenuItem.Text = "Boleiro"
        '
        'EncordoadorToolStripMenuItem
        '
        Me.EncordoadorToolStripMenuItem.Name = "EncordoadorToolStripMenuItem"
        Me.EncordoadorToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.EncordoadorToolStripMenuItem.Text = "Encordoador"
        '
        'JogadoresToolStripMenuItem
        '
        Me.JogadoresToolStripMenuItem.Name = "JogadoresToolStripMenuItem"
        Me.JogadoresToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.JogadoresToolStripMenuItem.Text = "Jogadores"
        '
        'AlteraçõesToolStripMenuItem
        '
        Me.AlteraçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlunosToolStripMenuItem1})
        Me.AlteraçõesToolStripMenuItem.Name = "AlteraçõesToolStripMenuItem"
        Me.AlteraçõesToolStripMenuItem.Size = New System.Drawing.Size(100, 46)
        Me.AlteraçõesToolStripMenuItem.Text = "Alterações"
        '
        'AlunosToolStripMenuItem1
        '
        Me.AlunosToolStripMenuItem1.Name = "AlunosToolStripMenuItem1"
        Me.AlunosToolStripMenuItem1.Size = New System.Drawing.Size(188, 24)
        Me.AlunosToolStripMenuItem1.Text = "Aluno/Jogador"
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.BlocoDeNotasToolStripMenuItem})
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(119, 46)
        Me.FerramentasToolStripMenuItem.Text = "Ferramentas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'BlocoDeNotasToolStripMenuItem
        '
        Me.BlocoDeNotasToolStripMenuItem.Name = "BlocoDeNotasToolStripMenuItem"
        Me.BlocoDeNotasToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.BlocoDeNotasToolStripMenuItem.Text = "Bloco de notas"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(52, 46)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(142, 46)
        Me.AjudaToolStripMenuItem.Text = "Cadastrar Jogos"
        '
        'dgvD
        '
        Me.dgvD.AllowUserToAddRows = False
        Me.dgvD.AllowUserToDeleteRows = False
        Me.dgvD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvD.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.dgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvD.Location = New System.Drawing.Point(1552, 124)
        Me.dgvD.Name = "dgvD"
        Me.dgvD.ReadOnly = True
        Me.dgvD.Size = New System.Drawing.Size(338, 894)
        Me.dgvD.TabIndex = 24
        '
        'dgvC
        '
        Me.dgvC.AllowUserToAddRows = False
        Me.dgvC.AllowUserToDeleteRows = False
        Me.dgvC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvC.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvC.Location = New System.Drawing.Point(1154, 124)
        Me.dgvC.Name = "dgvC"
        Me.dgvC.ReadOnly = True
        Me.dgvC.Size = New System.Drawing.Size(338, 894)
        Me.dgvC.TabIndex = 25
        '
        'dgvB
        '
        Me.dgvB.AllowUserToAddRows = False
        Me.dgvB.AllowUserToDeleteRows = False
        Me.dgvB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvB.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvB.Location = New System.Drawing.Point(772, 124)
        Me.dgvB.Name = "dgvB"
        Me.dgvB.ReadOnly = True
        Me.dgvB.Size = New System.Drawing.Size(338, 894)
        Me.dgvB.TabIndex = 26
        '
        'dgvA
        '
        Me.dgvA.AllowUserToAddRows = False
        Me.dgvA.AllowUserToDeleteRows = False
        Me.dgvA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvA.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvA.Location = New System.Drawing.Point(390, 124)
        Me.dgvA.Name = "dgvA"
        Me.dgvA.ReadOnly = True
        Me.dgvA.Size = New System.Drawing.Size(338, 894)
        Me.dgvA.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(500, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 27)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Classe A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(871, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 27)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Classe B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1264, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 27)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Classe C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1665, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 27)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Classe D"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'txtteste
        '
        Me.txtteste.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtteste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtteste.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtteste.Enabled = False
        Me.txtteste.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtteste.ForeColor = System.Drawing.Color.White
        Me.txtteste.Location = New System.Drawing.Point(37, 240)
        Me.txtteste.Name = "txtteste"
        Me.txtteste.ReadOnly = True
        Me.txtteste.Size = New System.Drawing.Size(291, 38)
        Me.txtteste.TabIndex = 34
        Me.txtteste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1072, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 36)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Ranking"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtteste)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvA)
        Me.Controls.Add(Me.dgvB)
        Me.Controls.Add(Me.dgvC)
        Me.Controls.Add(Me.dgvD)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Projeto Bola Dentro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlunoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlunosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudantesDeQuadraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlteraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlunosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArbitrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoleiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncordoadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvD As System.Windows.Forms.DataGridView
    Friend WithEvents dgvC As System.Windows.Forms.DataGridView
    Friend WithEvents dgvB As System.Windows.Forms.DataGridView
    Friend WithEvents dgvA As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtteste As System.Windows.Forms.TextBox
    Friend WithEvents FerramentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlocoDeNotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
End Class
