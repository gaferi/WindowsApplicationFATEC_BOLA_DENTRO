Public Class classe_exclusao_boleiro
    Public Sub excluir_boleiro()
        Try
            Form_BD_boleiro.Tb_boleiroTableAdapter.deletar_boleiro(Form_alteracao_aluno.id_retornado.Text)

        Catch ex As Exception

        End Try
    End Sub
End Class
