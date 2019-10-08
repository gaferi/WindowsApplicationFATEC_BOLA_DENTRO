Public Class Form_BD_boleiro

    Private Sub Tb_boleiroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_boleiroBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_boleiroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bola_dentroDataSet)

    End Sub

    Private Sub Form_BD_boleiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Bola_dentroDataSet.tb_boleiro'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_boleiroTableAdapter.Fill(Me.Bola_dentroDataSet.tb_boleiro)

    End Sub
End Class