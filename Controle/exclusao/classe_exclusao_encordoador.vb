Public Class classe_exclusao_encordoador
    Public Sub exclui_encordoador()
        Try
            Form_BD_encordoador.Tb_encordoadorTableAdapter.excluir_encordoador(Form_alteracao_aluno.id_retornado.Text)

        Catch ex As Exception

        End Try
    End Sub
End Class
