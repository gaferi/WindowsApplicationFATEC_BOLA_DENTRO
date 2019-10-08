Public Class Form_consulta_alunos

    Private Sub Tb_alunoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_alunoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bola_dentroDataSet)

    End Sub

    Private Sub Form_consulta_alunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Bola_dentroDataSet.tb_aluno'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_alunoTableAdapter.Fill(Me.Bola_dentroDataSet.tb_aluno)

    End Sub

    Private Sub Tb_alunoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Tb_alunoBindingSource.CurrentChanged

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Todos_AlunosToolStripButton_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class