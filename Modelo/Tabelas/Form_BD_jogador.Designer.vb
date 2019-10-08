<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BD_jogador
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
        Dim JogadorIDLabel As System.Windows.Forms.Label
        Dim AlunoIDLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim Data_entradaLabel As System.Windows.Forms.Label
        Dim Data_saidaLabel As System.Windows.Forms.Label
        Dim PontuacaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BD_jogador))
        Me.Bola_dentroDataSet = New WindowsApplication1.bola_dentroDataSet()
        Me.Tb_jogadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_jogadorTableAdapter = New WindowsApplication1.bola_dentroDataSetTableAdapters.tb_jogadorTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager()
        Me.Tb_jogadorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tb_jogadorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.JogadorIDTextBox = New System.Windows.Forms.TextBox()
        Me.AlunoIDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Data_entradaTextBox = New System.Windows.Forms.TextBox()
        Me.Data_saidaTextBox = New System.Windows.Forms.TextBox()
        Me.PontuacaoTextBox = New System.Windows.Forms.TextBox()
        JogadorIDLabel = New System.Windows.Forms.Label()
        AlunoIDLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Data_entradaLabel = New System.Windows.Forms.Label()
        Data_saidaLabel = New System.Windows.Forms.Label()
        PontuacaoLabel = New System.Windows.Forms.Label()
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_jogadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_jogadorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_jogadorBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'JogadorIDLabel
        '
        JogadorIDLabel.AutoSize = True
        JogadorIDLabel.Location = New System.Drawing.Point(55, 111)
        JogadorIDLabel.Name = "JogadorIDLabel"
        JogadorIDLabel.Size = New System.Drawing.Size(59, 13)
        JogadorIDLabel.TabIndex = 1
        JogadorIDLabel.Text = "jogador ID:"
        '
        'AlunoIDLabel
        '
        AlunoIDLabel.AutoSize = True
        AlunoIDLabel.Location = New System.Drawing.Point(55, 137)
        AlunoIDLabel.Name = "AlunoIDLabel"
        AlunoIDLabel.Size = New System.Drawing.Size(50, 13)
        AlunoIDLabel.TabIndex = 3
        AlunoIDLabel.Text = "aluno ID:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(55, 163)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(54, 13)
        CategoriaLabel.TabIndex = 5
        CategoriaLabel.Text = "categoria:"
        '
        'Data_entradaLabel
        '
        Data_entradaLabel.AutoSize = True
        Data_entradaLabel.Location = New System.Drawing.Point(55, 189)
        Data_entradaLabel.Name = "Data_entradaLabel"
        Data_entradaLabel.Size = New System.Drawing.Size(70, 13)
        Data_entradaLabel.TabIndex = 7
        Data_entradaLabel.Text = "data entrada:"
        '
        'Data_saidaLabel
        '
        Data_saidaLabel.AutoSize = True
        Data_saidaLabel.Location = New System.Drawing.Point(55, 215)
        Data_saidaLabel.Name = "Data_saidaLabel"
        Data_saidaLabel.Size = New System.Drawing.Size(59, 13)
        Data_saidaLabel.TabIndex = 9
        Data_saidaLabel.Text = "data saida:"
        '
        'PontuacaoLabel
        '
        PontuacaoLabel.AutoSize = True
        PontuacaoLabel.Location = New System.Drawing.Point(55, 241)
        PontuacaoLabel.Name = "PontuacaoLabel"
        PontuacaoLabel.Size = New System.Drawing.Size(61, 13)
        PontuacaoLabel.TabIndex = 11
        PontuacaoLabel.Text = "pontuacao:"
        '
        'Bola_dentroDataSet
        '
        Me.Bola_dentroDataSet.DataSetName = "bola_dentroDataSet"
        Me.Bola_dentroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_jogadorBindingSource
        '
        Me.Tb_jogadorBindingSource.DataMember = "tb_jogador"
        Me.Tb_jogadorBindingSource.DataSource = Me.Bola_dentroDataSet
        '
        'Tb_jogadorTableAdapter
        '
        Me.Tb_jogadorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_ajudante_quadraTableAdapter = Nothing
        Me.TableAdapterManager.tb_alunoTableAdapter = Nothing
        Me.TableAdapterManager.tb_arbitrosTableAdapter = Nothing
        Me.TableAdapterManager.tb_boleiroTableAdapter = Nothing
        Me.TableAdapterManager.tb_encordoadorTableAdapter = Nothing
        Me.TableAdapterManager.tb_jogadorTableAdapter = Me.Tb_jogadorTableAdapter
        Me.TableAdapterManager.tb_jogoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_jogadorBindingNavigator
        '
        Me.Tb_jogadorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_jogadorBindingNavigator.BindingSource = Me.Tb_jogadorBindingSource
        Me.Tb_jogadorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_jogadorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_jogadorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_jogadorBindingNavigatorSaveItem})
        Me.Tb_jogadorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_jogadorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_jogadorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_jogadorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_jogadorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_jogadorBindingNavigator.Name = "Tb_jogadorBindingNavigator"
        Me.Tb_jogadorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_jogadorBindingNavigator.Size = New System.Drawing.Size(325, 25)
        Me.Tb_jogadorBindingNavigator.TabIndex = 0
        Me.Tb_jogadorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
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
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tb_jogadorBindingNavigatorSaveItem
        '
        Me.Tb_jogadorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_jogadorBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_jogadorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_jogadorBindingNavigatorSaveItem.Name = "Tb_jogadorBindingNavigatorSaveItem"
        Me.Tb_jogadorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_jogadorBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'JogadorIDTextBox
        '
        Me.JogadorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_jogadorBindingSource, "jogadorID", True))
        Me.JogadorIDTextBox.Location = New System.Drawing.Point(131, 108)
        Me.JogadorIDTextBox.Name = "JogadorIDTextBox"
        Me.JogadorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JogadorIDTextBox.TabIndex = 2
        '
        'AlunoIDTextBox
        '
        Me.AlunoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_jogadorBindingSource, "alunoID", True))
        Me.AlunoIDTextBox.Location = New System.Drawing.Point(131, 134)
        Me.AlunoIDTextBox.Name = "AlunoIDTextBox"
        Me.AlunoIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlunoIDTextBox.TabIndex = 4
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_jogadorBindingSource, "categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(131, 160)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoriaTextBox.TabIndex = 6
        '
        'Data_entradaTextBox
        '
        Me.Data_entradaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_jogadorBindingSource, "data_entrada", True))
        Me.Data_entradaTextBox.Location = New System.Drawing.Point(131, 186)
        Me.Data_entradaTextBox.Name = "Data_entradaTextBox"
        Me.Data_entradaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Data_entradaTextBox.TabIndex = 8
        '
        'Data_saidaTextBox
        '
        Me.Data_saidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_jogadorBindingSource, "data_saida", True))
        Me.Data_saidaTextBox.Location = New System.Drawing.Point(131, 212)
        Me.Data_saidaTextBox.Name = "Data_saidaTextBox"
        Me.Data_saidaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Data_saidaTextBox.TabIndex = 10
        '
        'PontuacaoTextBox
        '
        Me.PontuacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_jogadorBindingSource, "pontuacao", True))
        Me.PontuacaoTextBox.Location = New System.Drawing.Point(131, 238)
        Me.PontuacaoTextBox.Name = "PontuacaoTextBox"
        Me.PontuacaoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PontuacaoTextBox.TabIndex = 12
        '
        'Form_BD_jogador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 406)
        Me.Controls.Add(JogadorIDLabel)
        Me.Controls.Add(Me.JogadorIDTextBox)
        Me.Controls.Add(AlunoIDLabel)
        Me.Controls.Add(Me.AlunoIDTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(Data_entradaLabel)
        Me.Controls.Add(Me.Data_entradaTextBox)
        Me.Controls.Add(Data_saidaLabel)
        Me.Controls.Add(Me.Data_saidaTextBox)
        Me.Controls.Add(PontuacaoLabel)
        Me.Controls.Add(Me.PontuacaoTextBox)
        Me.Controls.Add(Me.Tb_jogadorBindingNavigator)
        Me.Name = "Form_BD_jogador"
        Me.Opacity = 0.0R
        Me.Text = "Form_BD_jogador"
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_jogadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_jogadorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_jogadorBindingNavigator.ResumeLayout(False)
        Me.Tb_jogadorBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bola_dentroDataSet As WindowsApplication1.bola_dentroDataSet
    Friend WithEvents Tb_jogadorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_jogadorTableAdapter As WindowsApplication1.bola_dentroDataSetTableAdapters.tb_jogadorTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_jogadorBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_jogadorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents JogadorIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlunoIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_entradaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_saidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PontuacaoTextBox As System.Windows.Forms.TextBox
End Class
