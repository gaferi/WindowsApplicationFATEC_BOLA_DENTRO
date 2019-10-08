Public Class classe_cad_aluno
    Public Sub cadastro_aluno()
        Try
            Form_BD_aluno.Tb_alunoTableAdapter.InserirAlunoBD(Form_cadastro_aluno.nome_aluno.Text,
                                                                 Form_cadastro_aluno.data_nascimento.Text,
                                                                 Form_cadastro_aluno.mae_aluno.Text,
                                                                 Form_cadastro_aluno.nome_pai.Text,
                                                                 Form_cadastro_aluno.rg.Text,
                                                                 Form_cadastro_aluno.data_ingresso.Text,
                                                                 Form_cadastro_aluno.data_exame_medico.Text)
            MsgBox("aluno cadastrado com sucesso", MsgBoxStyle.Exclamation, "Sucesso")
        Catch ex As Exception
            MsgBox("aluno não foi cadastrado com sucesso!!", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Public Sub retorn_id_aluno()
        Try
            Form_BD_aluno.Tb_alunoTableAdapter.retorn_id_aluno(Form_BD_aluno.Bola_dentroDataSet.tb_aluno, Form_cadastro_aluno.rg.Text, Form_cadastro_aluno.nome_aluno.Text)
            Form_cadastro_aluno.retorno_id.Text = Form_BD_aluno.AlunoIDTextBox.Text


        Catch ex As Exception
            MsgBox("Houve um erro no cadastro das atividades do aluno", MsgBoxStyle.Critical, "Erro")

        End Try


    End Sub

    Public Sub pesquisar_aluno_por_rg()
        Try
            Form_BD_aluno.Tb_alunoTableAdapter.pesquisa_aluno_rg(Form_BD_aluno.Bola_dentroDataSet.tb_aluno, Form_alteracao_aluno.rg_dig.Text)
            '(Form_alteracao_aluno.rg_dig.Text)


            If (Form_BD_aluno.AlunoIDTextBox.Text <> "") Then
                MsgBox("Aluno encontrado!", MsgBoxStyle.Information, "Sucesso")
            Else
                MsgBox("Aluno não encontrado", MsgBoxStyle.Critical, "Erro")
            End If
            Form_alteracao_aluno.nome_aluno.Text = Form_BD_aluno.Nome_alunoTextBox.Text
            Form_alteracao_aluno.mae_aluno.Text = Form_BD_aluno.Mae_alunoTextBox.Text
            Form_alteracao_aluno.nome_pai.Text = Form_BD_aluno.Pai_alunoTextBox.Text
            Form_alteracao_aluno.data_nascimento.Text = Form_BD_aluno.Data_nascimentoTextBox.Text
            Form_alteracao_aluno.rg.Text = Form_BD_aluno.Rg_alunoTextBox.Text
            Form_alteracao_aluno.data_ingresso.Text = Form_BD_aluno.Data_ingressoTextBox.Text
            Form_alteracao_aluno.data_exame_medico.Text = Form_BD_aluno.Exame_medico_alunoTextBox.Text
            Form_alteracao_aluno.id_retornado.Text = Form_BD_aluno.AlunoIDTextBox.Text

        Catch ex As Exception
            MsgBox("Houve um erro na pesquisa feito sob este aluno", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
   

End Class
