Public Class classe_exclusao_ajudante_quadra
    Public Sub excluir_ajudante_quadra()
        Try
            Form_BD_ajudante_quadra.Tb_ajudante_quadraTableAdapter.deletar_ajudante_quadra(Form_alteracao_aluno.id_retornado.Text)

        Catch ex As Exception

        End Try
    End Sub

End Class
