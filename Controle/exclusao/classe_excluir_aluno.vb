Public Class classe_excluir_aluno
    Public Sub exclui_aluno()
        Try
            Form_BD_aluno.Tb_alunoTableAdapter.deletar_aluno_id(Form_alteracao_aluno.id_retornado.Text)
            MsgBox("aluno excluido com sucesso!!", MsgBoxStyle.Exclamation, "Sucesso")
        Catch ex As Exception
            MsgBox("Houve um erro na exclusão deste aluno", MsgBoxStyle.Critical, "Erro")
        End Try


    End Sub
End Class
