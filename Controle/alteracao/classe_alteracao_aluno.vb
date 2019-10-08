Public Class classe_alteracao_aluno
    Public Sub altera_dados_aluno()
        Try
            Form_BD_aluno.Tb_alunoTableAdapter.alteracao_dados_aluno(Form_alteracao_aluno.nome_aluno.Text,
                                                                     Form_alteracao_aluno.data_nascimento.Text,
                                                                     Form_alteracao_aluno.mae_aluno.Text,
                                                                     Form_alteracao_aluno.nome_pai.Text,
                                                                     Form_alteracao_aluno.rg.Text,
                                                                     Form_alteracao_aluno.data_ingresso.Text,
                                                                     Form_alteracao_aluno.data_exame_medico.Text,
                                                                     Form_alteracao_aluno.id_retornado.Text)

            MsgBox("aluno alterado com sucesso", MsgBoxStyle.Exclamation, "Sucesso")
        Catch ex As Exception
            MsgBox("Erro ao fazer alterações nos dados do aluno!!", MsgBoxStyle.Critical, "Erro")

        End Try
    End Sub
End Class
