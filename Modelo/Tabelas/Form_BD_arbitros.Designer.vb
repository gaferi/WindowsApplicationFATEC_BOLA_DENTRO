<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BD_arbitros
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
        Dim Cod_arbitrosLabel As System.Windows.Forms.Label
        Dim AlunoIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BD_arbitros))
        Me.Bola_dentroDataSet = New WindowsApplication1.bola_dentroDataSet()
        Me.Tb_arbitrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_arbitrosTableAdapter = New WindowsApplication1.bola_dentroDataSetTableAdapters.tb_arbitrosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager()
        Me.Tb_arbitrosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tb_arbitrosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cod_arbitrosTextBox = New System.Windows.Forms.TextBox()
        Me.AlunoIDTextBox = New System.Windows.Forms.TextBox()
        Cod_arbitrosLabel = New System.Windows.Forms.Label()
        AlunoIDLabel = New System.Windows.Forms.Label()
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_arbitrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_arbitrosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_arbitrosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cod_arbitrosLabel
        '
        Cod_arbitrosLabel.AutoSize = True
        Cod_arbitrosLabel.Location = New System.Drawing.Point(83, 115)
        Cod_arbitrosLabel.Name = "Cod_arbitrosLabel"
        Cod_arbitrosLabel.Size = New System.Drawing.Size(65, 13)
        Cod_arbitrosLabel.TabIndex = 1
        Cod_arbitrosLabel.Text = "cod arbitros:"
        '
        'AlunoIDLabel
        '
        AlunoIDLabel.AutoSize = True
        AlunoIDLabel.Location = New System.Drawing.Point(83, 141)
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
        'Tb_arbitrosBindingSource
        '
        Me.Tb_arbitrosBindingSource.DataMember = "tb_arbitros"
        Me.Tb_arbitrosBindingSource.DataSource = Me.Bola_dentroDataSet
        '
        'Tb_arbitrosTableAdapter
        '
        Me.Tb_arbitrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_ajudante_quadraTableAdapter = Nothing
        Me.TableAdapterManager.tb_alunoTableAdapter = Nothing
        Me.TableAdapterManager.tb_arbitrosTableAdapter = Me.Tb_arbitrosTableAdapter
        Me.TableAdapterManager.tb_boleiroTableAdapter = Nothing
        Me.TableAdapterManager.tb_encordoadorTableAdapter = Nothing
        Me.TableAdapterManager.tb_jogadorTableAdapter = Nothing
        Me.TableAdapterManager.tb_jogoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_arbitrosBindingNavigator
        '
        Me.Tb_arbitrosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_arbitrosBindingNavigator.BindingSource = Me.Tb_arbitrosBindingSource
        Me.Tb_arbitrosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_arbitrosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_arbitrosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_arbitrosBindingNavigatorSaveItem})
        Me.Tb_arbitrosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_arbitrosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_arbitrosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_arbitrosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_arbitrosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_arbitrosBindingNavigator.Name = "Tb_arbitrosBindingNavigator"
        Me.Tb_arbitrosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_arbitrosBindingNavigator.Size = New System.Drawing.Size(307, 25)
        Me.Tb_arbitrosBindingNavigator.TabIndex = 0
        Me.Tb_arbitrosBindingNavigator.Text = "BindingNavigator1"
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
        'Tb_arbitrosBindingNavigatorSaveItem
        '
        Me.Tb_arbitrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_arbitrosBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_arbitrosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_arbitrosBindingNavigatorSaveItem.Name = "Tb_arbitrosBindingNavigatorSaveItem"
        Me.Tb_arbitrosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_arbitrosBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'Cod_arbitrosTextBox
        '
        Me.Cod_arbitrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_arbitrosBindingSource, "cod_arbitros", True))
        Me.Cod_arbitrosTextBox.Location = New System.Drawing.Point(154, 112)
        Me.Cod_arbitrosTextBox.Name = "Cod_arbitrosTextBox"
        Me.Cod_arbitrosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_arbitrosTextBox.TabIndex = 2
        '
        'AlunoIDTextBox
        '
        Me.AlunoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_arbitrosBindingSource, "alunoID", True))
        Me.AlunoIDTextBox.Location = New System.Drawing.Point(154, 138)
        Me.AlunoIDTextBox.Name = "AlunoIDTextBox"
        Me.AlunoIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlunoIDTextBox.TabIndex = 4
        '
        'Form_BD_arbitros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 262)
        Me.Controls.Add(Cod_arbitrosLabel)
        Me.Controls.Add(Me.Cod_arbitrosTextBox)
        Me.Controls.Add(AlunoIDLabel)
        Me.Controls.Add(Me.AlunoIDTextBox)
        Me.Controls.Add(Me.Tb_arbitrosBindingNavigator)
        Me.Name = "Form_BD_arbitros"
        Me.Opacity = 0.0R
        Me.Text = "Form_BD_arbitros"
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_arbitrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_arbitrosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_arbitrosBindingNavigator.ResumeLayout(False)
        Me.Tb_arbitrosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bola_dentroDataSet As WindowsApplication1.bola_dentroDataSet
    Friend WithEvents Tb_arbitrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_arbitrosTableAdapter As WindowsApplication1.bola_dentroDataSetTableAdapters.tb_arbitrosTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_arbitrosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_arbitrosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cod_arbitrosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlunoIDTextBox As System.Windows.Forms.TextBox
End Class
