Public Class Form_BD_jogador

    Private Sub Tb_jogadorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_jogadorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_jogadorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bola_dentroDataSet)

    End Sub

    Private Sub Form_BD_jogador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Bola_dentroDataSet.tb_jogador'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_jogadorTableAdapter.Fill(Me.Bola_dentroDataSet.tb_jogador)

    End Sub
End Class