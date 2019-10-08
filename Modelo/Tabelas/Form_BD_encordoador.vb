Public Class Form_BD_encordoador

    Private Sub Tb_encordoadorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_encordoadorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_encordoadorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bola_dentroDataSet)

    End Sub

    Private Sub Form_BD_encordoador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Bola_dentroDataSet.tb_encordoador'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_encordoadorTableAdapter.Fill(Me.Bola_dentroDataSet.tb_encordoador)

    End Sub
End Class