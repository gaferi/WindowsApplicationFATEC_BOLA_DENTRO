Public Class Form_BD_ajudante_quadra

    Private Sub Tb_ajudante_quadraBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_ajudante_quadraBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_ajudante_quadraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bola_dentroDataSet)

    End Sub

    Private Sub Form_BD_ajudante_quadra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Bola_dentroDataSet.tb_ajudante_quadra'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_ajudante_quadraTableAdapter.Fill(Me.Bola_dentroDataSet.tb_ajudante_quadra)

    End Sub
End Class