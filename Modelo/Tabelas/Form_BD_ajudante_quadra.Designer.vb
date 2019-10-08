<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BD_ajudante_quadra
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
        Dim Cod_ajudante_quadraLabel As System.Windows.Forms.Label
        Dim AlunoIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BD_ajudante_quadra))
        Me.Bola_dentroDataSet = New WindowsApplication1.bola_dentroDataSet()
        Me.Tb_ajudante_quadraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_ajudante_quadraTableAdapter = New WindowsApplication1.bola_dentroDataSetTableAdapters.tb_ajudante_quadraTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager()
        Me.Tb_ajudante_quadraBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tb_ajudante_quadraBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cod_ajudante_quadraTextBox = New System.Windows.Forms.TextBox()
        Me.AlunoIDTextBox = New System.Windows.Forms.TextBox()
        Cod_ajudante_quadraLabel = New System.Windows.Forms.Label()
        AlunoIDLabel = New System.Windows.Forms.Label()
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_ajudante_quadraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_ajudante_quadraBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_ajudante_quadraBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cod_ajudante_quadraLabel
        '
        Cod_ajudante_quadraLabel.AutoSize = True
        Cod_ajudante_quadraLabel.Location = New System.Drawing.Point(61, 113)
        Cod_ajudante_quadraLabel.Name = "Cod_ajudante_quadraLabel"
        Cod_ajudante_quadraLabel.Size = New System.Drawing.Size(108, 13)
        Cod_ajudante_quadraLabel.TabIndex = 1
        Cod_ajudante_quadraLabel.Text = "cod ajudante quadra:"
        '
        'AlunoIDLabel
        '
        AlunoIDLabel.AutoSize = True
        AlunoIDLabel.Location = New System.Drawing.Point(61, 139)
        AlunoIDLabel.Name = "AlunoIDLabel"
        AlunoIDLabel.Size = New System.Drawing.Size(50, 13)
        AlunoIDLabel.TabIndex = 3
        AlunoIDLabel.Text = "aluno ID:"
        '
        'Bola_dentroDataSet
        '
        Me.Bola_dentroDataSet.DataSetName = "bola_dentroDataSet"
        Me.Bola_dentroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_ajudante_quadraBindingSource
        '
        Me.Tb_ajudante_quadraBindingSource.DataMember = "tb_ajudante_quadra"
        Me.Tb_ajudante_quadraBindingSource.DataSource = Me.Bola_dentroDataSet
        '
        'Tb_ajudante_quadraTableAdapter
        '
        Me.Tb_ajudante_quadraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_ajudante_quadraTableAdapter = Me.Tb_ajudante_quadraTableAdapter
        Me.TableAdapterManager.tb_alunoTableAdapter = Nothing
        Me.TableAdapterManager.tb_arbitrosTableAdapter = Nothing
        Me.TableAdapterManager.tb_boleiroTableAdapter = Nothing
        Me.TableAdapterManager.tb_encordoadorTableAdapter = Nothing
        Me.TableAdapterManager.tb_jogadorTableAdapter = Nothing
        Me.TableAdapterManager.tb_jogoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_ajudante_quadraBindingNavigator
        '
        Me.Tb_ajudante_quadraBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_ajudante_quadraBindingNavigator.BindingSource = Me.Tb_ajudante_quadraBindingSource
        Me.Tb_ajudante_quadraBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_ajudante_quadraBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_ajudante_quadraBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_ajudante_quadraBindingNavigatorSaveItem})
        Me.Tb_ajudante_quadraBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_ajudante_quadraBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_ajudante_quadraBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_ajudante_quadraBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_ajudante_quadraBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_ajudante_quadraBindingNavigator.Name = "Tb_ajudante_quadraBindingNavigator"
        Me.Tb_ajudante_quadraBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_ajudante_quadraBindingNavigator.Size = New System.Drawing.Size(333, 25)
        Me.Tb_ajudante_quadraBindingNavigator.TabIndex = 0
        Me.Tb_ajudante_quadraBindingNavigator.Text = "BindingNavigator1"
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
        'Tb_ajudante_quadraBindingNavigatorSaveItem
        '
        Me.Tb_ajudante_quadraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_ajudante_quadraBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_ajudante_quadraBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_ajudante_quadraBindingNavigatorSaveItem.Name = "Tb_ajudante_quadraBindingNavigatorSaveItem"
        Me.Tb_ajudante_quadraBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_ajudante_quadraBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'Cod_ajudante_quadraTextBox
        '
        Me.Cod_ajudante_quadraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_ajudante_quadraBindingSource, "cod_ajudante_quadra", True))
        Me.Cod_ajudante_quadraTextBox.Location = New System.Drawing.Point(175, 110)
        Me.Cod_ajudante_quadraTextBox.Name = "Cod_ajudante_quadraTextBox"
        Me.Cod_ajudante_quadraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_ajudante_quadraTextBox.TabIndex = 2
        '
        'AlunoIDTextBox
        '
        Me.AlunoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_ajudante_quadraBindingSource, "alunoID", True))
        Me.AlunoIDTextBox.Location = New System.Drawing.Point(175, 136)
        Me.AlunoIDTextBox.Name = "AlunoIDTextBox"
        Me.AlunoIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlunoIDTextBox.TabIndex = 4
        '
        'Form_BD_ajudante_quadra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 262)
        Me.Controls.Add(Cod_ajudante_quadraLabel)
        Me.Controls.Add(Me.Cod_ajudante_quadraTextBox)
        Me.Controls.Add(AlunoIDLabel)
        Me.Controls.Add(Me.AlunoIDTextBox)
        Me.Controls.Add(Me.Tb_ajudante_quadraBindingNavigator)
        Me.Name = "Form_BD_ajudante_quadra"
        Me.Opacity = 0.0R
        Me.Text = "Form_BD_ajudante_quadra"
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_ajudante_quadraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_ajudante_quadraBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_ajudante_quadraBindingNavigator.ResumeLayout(False)
        Me.Tb_ajudante_quadraBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bola_dentroDataSet As WindowsApplication1.bola_dentroDataSet
    Friend WithEvents Tb_ajudante_quadraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_ajudante_quadraTableAdapter As WindowsApplication1.bola_dentroDataSetTableAdapters.tb_ajudante_quadraTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_ajudante_quadraBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_ajudante_quadraBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cod_ajudante_quadraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlunoIDTextBox As System.Windows.Forms.TextBox
End Class
