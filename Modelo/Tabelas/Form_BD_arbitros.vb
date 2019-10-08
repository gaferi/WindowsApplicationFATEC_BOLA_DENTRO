Public Class Form_BD_arbitros

    Private Sub Tb_arbitrosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_arbitrosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_arbitrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bola_dentroDataSet)

    End Sub

    Private Sub Form_BD_arbitros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Bola_dentroDataSet.tb_arbitros'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_arbitrosTableAdapter.Fill(Me.Bola_dentroDataSet.tb_arbitros)

    End Sub
End Class