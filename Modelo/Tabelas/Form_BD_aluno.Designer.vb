<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BD_aluno
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
        Dim AlunoIDLabel As System.Windows.Forms.Label
        Dim Nome_alunoLabel As System.Windows.Forms.Label
        Dim Data_nascimentoLabel As System.Windows.Forms.Label
        Dim Mae_alunoLabel As System.Windows.Forms.Label
        Dim Pai_alunoLabel As System.Windows.Forms.Label
        Dim Rg_alunoLabel As System.Windows.Forms.Label
        Dim Data_ingressoLabel As System.Windows.Forms.Label
        Dim Exame_medico_alunoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BD_aluno))
        Me.Bola_dentroDataSet = New WindowsApplication1.bola_dentroDataSet()
        Me.Tb_alunoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_alunoTableAdapter = New WindowsApplication1.bola_dentroDataSetTableAdapters.tb_alunoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager()
        Me.Tb_alunoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tb_alunoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AlunoIDTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_alunoTextBox = New System.Windows.Forms.TextBox()
        Me.Data_nascimentoTextBox = New System.Windows.Forms.TextBox()
        Me.Mae_alunoTextBox = New System.Windows.Forms.TextBox()
        Me.Pai_alunoTextBox = New System.Windows.Forms.TextBox()
        Me.Rg_alunoTextBox = New System.Windows.Forms.TextBox()
        Me.Data_ingressoTextBox = New System.Windows.Forms.TextBox()
        Me.Exame_medico_alunoTextBox = New System.Windows.Forms.TextBox()
        AlunoIDLabel = New System.Windows.Forms.Label()
        Nome_alunoLabel = New System.Windows.Forms.Label()
        Data_nascimentoLabel = New System.Windows.Forms.Label()
        Mae_alunoLabel = New System.Windows.Forms.Label()
        Pai_alunoLabel = New System.Windows.Forms.Label()
        Rg_alunoLabel = New System.Windows.Forms.Label()
        Data_ingressoLabel = New System.Windows.Forms.Label()
        Exame_medico_alunoLabel = New System.Windows.Forms.Label()
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_alunoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_alunoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_alunoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlunoIDLabel
        '
        AlunoIDLabel.AutoSize = True
        AlunoIDLabel.Location = New System.Drawing.Point(61, 39)
        AlunoIDLabel.Name = "AlunoIDLabel"
        AlunoIDLabel.Size = New System.Drawing.Size(50, 13)
        AlunoIDLabel.TabIndex = 1
        AlunoIDLabel.Text = "aluno ID:"
        '
        'Nome_alunoLabel
        '
        Nome_alunoLabel.AutoSize = True
        Nome_alunoLabel.Location = New System.Drawing.Point(61, 65)
        Nome_alunoLabel.Name = "Nome_alunoLabel"
        Nome_alunoLabel.Size = New System.Drawing.Size(65, 13)
        Nome_alunoLabel.TabIndex = 3
        Nome_alunoLabel.Text = "nome aluno:"
        '
        'Data_nascimentoLabel
        '
        Data_nascimentoLabel.AutoSize = True
        Data_nascimentoLabel.Location = New System.Drawing.Point(61, 91)
        Data_nascimentoLabel.Name = "Data_nascimentoLabel"
        Data_nascimentoLabel.Size = New System.Drawing.Size(88, 13)
        Data_nascimentoLabel.TabIndex = 5
        Data_nascimentoLabel.Text = "data nascimento:"
        '
        'Mae_alunoLabel
        '
        Mae_alunoLabel.AutoSize = True
        Mae_alunoLabel.Location = New System.Drawing.Point(61, 117)
        Mae_alunoLabel.Name = "Mae_alunoLabel"
        Mae_alunoLabel.Size = New System.Drawing.Size(59, 13)
        Mae_alunoLabel.TabIndex = 7
        Mae_alunoLabel.Text = "mae aluno:"
        '
        'Pai_alunoLabel
        '
        Pai_alunoLabel.AutoSize = True
        Pai_alunoLabel.Location = New System.Drawing.Point(61, 143)
        Pai_alunoLabel.Name = "Pai_alunoLabel"
        Pai_alunoLabel.Size = New System.Drawing.Size(53, 13)
        Pai_alunoLabel.TabIndex = 9
        Pai_alunoLabel.Text = "pai aluno:"
        '
        'Rg_alunoLabel
        '
        Rg_alunoLabel.AutoSize = True
        Rg_alunoLabel.Location = New System.Drawing.Point(61, 169)
        Rg_alunoLabel.Name = "Rg_alunoLabel"
        Rg_alunoLabel.Size = New System.Drawing.Size(48, 13)
        Rg_alunoLabel.TabIndex = 11
        Rg_alunoLabel.Text = "rg aluno:"
        '
        'Data_ingressoLabel
        '
        Data_ingressoLabel.AutoSize = True
        Data_ingressoLabel.Location = New System.Drawing.Point(61, 195)
        Data_ingressoLabel.Name = "Data_ingressoLabel"
        Data_ingressoLabel.Size = New System.Drawing.Size(73, 13)
        Data_ingressoLabel.TabIndex = 13
        Data_ingressoLabel.Text = "data ingresso:"
        '
        'Exame_medico_alunoLabel
        '
        Exame_medico_alunoLabel.AutoSize = True
        Exame_medico_alunoLabel.Location = New System.Drawing.Point(61, 221)
        Exame_medico_alunoLabel.Name = "Exame_medico_alunoLabel"
        Exame_medico_alunoLabel.Size = New System.Drawing.Size(107, 13)
        Exame_medico_alunoLabel.TabIndex = 15
        Exame_medico_alunoLabel.Text = "exame medico aluno:"
        '
        'Bola_dentroDataSet
        '
        Me.Bola_dentroDataSet.DataSetName = "bola_dentroDataSet"
        Me.Bola_dentroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_alunoBindingSource
        '
        Me.Tb_alunoBindingSource.DataMember = "tb_aluno"
        Me.Tb_alunoBindingSource.DataSource = Me.Bola_dentroDataSet
        '
        'Tb_alunoTableAdapter
        '
        Me.Tb_alunoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_ajudante_quadraTableAdapter = Nothing
        Me.TableAdapterManager.tb_alunoTableAdapter = Me.Tb_alunoTableAdapter
        Me.TableAdapterManager.tb_arbitrosTableAdapter = Nothing
        Me.TableAdapterManager.tb_boleiroTableAdapter = Nothing
        Me.TableAdapterManager.tb_encordoadorTableAdapter = Nothing
        Me.TableAdapterManager.tb_jogadorTableAdapter = Nothing
        Me.TableAdapterManager.tb_jogoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_alunoBindingNavigator
        '
        Me.Tb_alunoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_alunoBindingNavigator.BindingSource = Me.Tb_alunoBindingSource
        Me.Tb_alunoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_alunoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_alunoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_alunoBindingNavigatorSaveItem})
        Me.Tb_alunoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_alunoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_alunoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_alunoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_alunoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_alunoBindingNavigator.Name = "Tb_alunoBindingNavigator"
        Me.Tb_alunoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_alunoBindingNavigator.Size = New System.Drawing.Size(354, 25)
        Me.Tb_alunoBindingNavigator.TabIndex = 0
        Me.Tb_alunoBindingNavigator.Text = "BindingNavigator1"
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
        'Tb_alunoBindingNavigatorSaveItem
        '
        Me.Tb_alunoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_alunoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_alunoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_alunoBindingNavigatorSaveItem.Name = "Tb_alunoBindingNavigatorSaveItem"
        Me.Tb_alunoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_alunoBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'AlunoIDTextBox
        '
        Me.AlunoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_alunoBindingSource, "alunoID", True))
        Me.AlunoIDTextBox.Location = New System.Drawing.Point(174, 36)
        Me.AlunoIDTextBox.Name = "AlunoIDTextBox"
        Me.AlunoIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlunoIDTextBox.TabIndex = 2
        '
        'Nome_alunoTextBox
        '
        Me.Nome_alunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_alunoBindingSource, "nome_aluno", True))
        Me.Nome_alunoTextBox.Location = New System.Drawing.Point(174, 62)
        Me.Nome_alunoTextBox.Name = "Nome_alunoTextBox"
        Me.Nome_alunoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nome_alunoTextBox.TabIndex = 4
        '
        'Data_nascimentoTextBox
        '
        Me.Data_nascimentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_alunoBindingSource, "data_nascimento", True))
        Me.Data_nascimentoTextBox.Location = New System.Drawing.Point(174, 88)
        Me.Data_nascimentoTextBox.Name = "Data_nascimentoTextBox"
        Me.Data_nascimentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Data_nascimentoTextBox.TabIndex = 6
        '
        'Mae_alunoTextBox
        '
        Me.Mae_alunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_alunoBindingSource, "mae_aluno", True))
        Me.Mae_alunoTextBox.Location = New System.Drawing.Point(174, 114)
        Me.Mae_alunoTextBox.Name = "Mae_alunoTextBox"
        Me.Mae_alunoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Mae_alunoTextBox.TabIndex = 8
        '
        'Pai_alunoTextBox
        '
        Me.Pai_alunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_alunoBindingSource, "pai_aluno", True))
        Me.Pai_alunoTextBox.Location = New System.Drawing.Point(174, 140)
        Me.Pai_alunoTextBox.Name = "Pai_alunoTextBox"
        Me.Pai_alunoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pai_alunoTextBox.TabIndex = 10
        '
        'Rg_alunoTextBox
        '
        Me.Rg_alunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_alunoBindingSource, "rg_aluno", True))
        Me.Rg_alunoTextBox.Location = New System.Drawing.Point(174, 166)
        Me.Rg_alunoTextBox.Name = "Rg_alunoTextBox"
        Me.Rg_alunoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Rg_alunoTextBox.TabIndex = 12
        '
        'Data_ingressoTextBox
        '
        Me.Data_ingressoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_alunoBindingSource, "data_ingresso", True))
        Me.Data_ingressoTextBox.Location = New System.Drawing.Point(174, 192)
        Me.Data_ingressoTextBox.Name = "Data_ingressoTextBox"
        Me.Data_ingressoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Data_ingressoTextBox.TabIndex = 14
        '
        'Exame_medico_alunoTextBox
        '
        Me.Exame_medico_alunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_alunoBindingSource, "exame_medico_aluno", True))
        Me.Exame_medico_alunoTextBox.Location = New System.Drawing.Point(174, 218)
        Me.Exame_medico_alunoTextBox.Name = "Exame_medico_alunoTextBox"
        Me.Exame_medico_alunoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Exame_medico_alunoTextBox.TabIndex = 16
        '
        'Form_BD_aluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 262)
        Me.Controls.Add(AlunoIDLabel)
        Me.Controls.Add(Me.AlunoIDTextBox)
        Me.Controls.Add(Nome_alunoLabel)
        Me.Controls.Add(Me.Nome_alunoTextBox)
        Me.Controls.Add(Data_nascimentoLabel)
        Me.Controls.Add(Me.Data_nascimentoTextBox)
        Me.Controls.Add(Mae_alunoLabel)
        Me.Controls.Add(Me.Mae_alunoTextBox)
        Me.Controls.Add(Pai_alunoLabel)
        Me.Controls.Add(Me.Pai_alunoTextBox)
        Me.Controls.Add(Rg_alunoLabel)
        Me.Controls.Add(Me.Rg_alunoTextBox)
        Me.Controls.Add(Data_ingressoLabel)
        Me.Controls.Add(Me.Data_ingressoTextBox)
        Me.Controls.Add(Exame_medico_alunoLabel)
        Me.Controls.Add(Me.Exame_medico_alunoTextBox)
        Me.Controls.Add(Me.Tb_alunoBindingNavigator)
        Me.Name = "Form_BD_aluno"
        Me.Opacity = 0.0R
        Me.Text = "Form_BD_aluno"
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_alunoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_alunoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_alunoBindingNavigator.ResumeLayout(False)
        Me.Tb_alunoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bola_dentroDataSet As WindowsApplication1.bola_dentroDataSet
    Friend WithEvents Tb_alunoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_alunoTableAdapter As WindowsApplication1.bola_dentroDataSetTableAdapters.tb_alunoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_alunoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_alunoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AlunoIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nome_alunoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_nascimentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mae_alunoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pai_alunoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rg_alunoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_ingressoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Exame_medico_alunoTextBox As System.Windows.Forms.TextBox
End Class
