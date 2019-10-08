<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BD_boleiro
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
        Dim Cod_boleiroLabel As System.Windows.Forms.Label
        Dim AlunoIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BD_boleiro))
        Me.Bola_dentroDataSet = New WindowsApplication1.bola_dentroDataSet()
        Me.Tb_boleiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_boleiroTableAdapter = New WindowsApplication1.bola_dentroDataSetTableAdapters.tb_boleiroTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager()
        Me.Tb_boleiroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tb_boleiroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cod_boleiroTextBox = New System.Windows.Forms.TextBox()
        Me.AlunoIDTextBox = New System.Windows.Forms.TextBox()
        Cod_boleiroLabel = New System.Windows.Forms.Label()
        AlunoIDLabel = New System.Windows.Forms.Label()
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_boleiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_boleiroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_boleiroBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cod_boleiroLabel
        '
        Cod_boleiroLabel.AutoSize = True
        Cod_boleiroLabel.Location = New System.Drawing.Point(70, 107)
        Cod_boleiroLabel.Name = "Cod_boleiroLabel"
        Cod_boleiroLabel.Size = New System.Drawing.Size(62, 13)
        Cod_boleiroLabel.TabIndex = 1
        Cod_boleiroLabel.Text = "cod boleiro:"
        '
        'AlunoIDLabel
        '
        AlunoIDLabel.AutoSize = True
        AlunoIDLabel.Location = New System.Drawing.Point(70, 133)
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
        'Tb_boleiroBindingSource
        '
        Me.Tb_boleiroBindingSource.DataMember = "tb_boleiro"
        Me.Tb_boleiroBindingSource.DataSource = Me.Bola_dentroDataSet
        '
        'Tb_boleiroTableAdapter
        '
        Me.Tb_boleiroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_ajudante_quadraTableAdapter = Nothing
        Me.TableAdapterManager.tb_alunoTableAdapter = Nothing
        Me.TableAdapterManager.tb_arbitrosTableAdapter = Nothing
        Me.TableAdapterManager.tb_boleiroTableAdapter = Me.Tb_boleiroTableAdapter
        Me.TableAdapterManager.tb_encordoadorTableAdapter = Nothing
        Me.TableAdapterManager.tb_jogadorTableAdapter = Nothing
        Me.TableAdapterManager.tb_jogoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_boleiroBindingNavigator
        '
        Me.Tb_boleiroBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_boleiroBindingNavigator.BindingSource = Me.Tb_boleiroBindingSource
        Me.Tb_boleiroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_boleiroBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_boleiroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_boleiroBindingNavigatorSaveItem})
        Me.Tb_boleiroBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_boleiroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_boleiroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_boleiroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_boleiroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_boleiroBindingNavigator.Name = "Tb_boleiroBindingNavigator"
        Me.Tb_boleiroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_boleiroBindingNavigator.Size = New System.Drawing.Size(300, 25)
        Me.Tb_boleiroBindingNavigator.TabIndex = 0
        Me.Tb_boleiroBindingNavigator.Text = "BindingNavigator1"
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
        'Tb_boleiroBindingNavigatorSaveItem
        '
        Me.Tb_boleiroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_boleiroBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_boleiroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_boleiroBindingNavigatorSaveItem.Name = "Tb_boleiroBindingNavigatorSaveItem"
        Me.Tb_boleiroBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_boleiroBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'Cod_boleiroTextBox
        '
        Me.Cod_boleiroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_boleiroBindingSource, "cod_boleiro", True))
        Me.Cod_boleiroTextBox.Location = New System.Drawing.Point(138, 104)
        Me.Cod_boleiroTextBox.Name = "Cod_boleiroTextBox"
        Me.Cod_boleiroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_boleiroTextBox.TabIndex = 2
        '
        'AlunoIDTextBox
        '
        Me.AlunoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_boleiroBindingSource, "alunoID", True))
        Me.AlunoIDTextBox.Location = New System.Drawing.Point(138, 130)
        Me.AlunoIDTextBox.Name = "AlunoIDTextBox"
        Me.AlunoIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlunoIDTextBox.TabIndex = 4
        '
        'Form_BD_boleiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 262)
        Me.Controls.Add(Cod_boleiroLabel)
        Me.Controls.Add(Me.Cod_boleiroTextBox)
        Me.Controls.Add(AlunoIDLabel)
        Me.Controls.Add(Me.AlunoIDTextBox)
        Me.Controls.Add(Me.Tb_boleiroBindingNavigator)
        Me.Name = "Form_BD_boleiro"
        Me.Opacity = 0.0R
        Me.Text = "Form_BD_boleiro"
        CType(Me.Bola_dentroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_boleiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_boleiroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_boleiroBindingNavigator.ResumeLayout(False)
        Me.Tb_boleiroBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bola_dentroDataSet As WindowsApplication1.bola_dentroDataSet
    Friend WithEvents Tb_boleiroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_boleiroTableAdapter As WindowsApplication1.bola_dentroDataSetTableAdapters.tb_boleiroTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bola_dentroDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_boleiroBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_boleiroBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cod_boleiroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlunoIDTextBox As System.Windows.Forms.TextBox
End Class
