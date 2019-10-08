Public Class classe_cad_jogador
    Public Sub cadastrar_jogador()
        Try

        
            Form_BD_jogador.Tb_jogadorTableAdapter.cadastrar_jogador(Form_cadastro_aluno.retorno_id.Text,
                                                                        Form_cadastro_aluno.categoria_jogador.Text,
                                                                        Form_cadastro_aluno.data_ingresso.Text)
            MsgBox("Jogador cadastrado com sucesso", MsgBoxStyle.Exclamation, "Sucesso")
        Catch ex As Exception
            MsgBox("jogador não foi cadastrado com sucesso!!", MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub




End Class
