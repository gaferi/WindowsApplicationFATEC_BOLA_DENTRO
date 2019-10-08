Public Class Form_BD_aluno

    Private Sub Tb_alunoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_alunoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_alunoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bola_dentroDataSet)

    End Sub

    Private Sub Form_BD_aluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Bola_dentroDataSet.tb_aluno'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_alunoTableAdapter.Fill(Me.Bola_dentroDataSet.tb_aluno)

    End Sub
End Class