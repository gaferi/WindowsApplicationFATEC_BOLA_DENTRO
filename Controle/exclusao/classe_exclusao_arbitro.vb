Public Class classe_exclusao_arbitro
    Public Sub excluir_arbitro()
        Try
            Form_BD_arbitros.Tb_arbitrosTableAdapter.deletar_arbitro(Form_alteracao_aluno.id_retornado.Text)
        Catch ex As Exception

        End Try
    End Sub

End Class
