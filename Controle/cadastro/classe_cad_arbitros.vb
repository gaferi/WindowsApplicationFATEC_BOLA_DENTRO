Public Class classe_cad_arbitros
    Public Sub cad_arbitros()
        Try
            Form_BD_arbitros.Tb_arbitrosTableAdapter.InsertQuery(Form_cadastro_aluno.retorno_id.Text)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub retorna_ativade()
        Try
            Form_BD_arbitros.Tb_arbitrosTableAdapter.retorna_atividade(Form_BD_arbitros.Bola_dentroDataSet.tb_arbitros, Form_alteracao_aluno.id_retornado.Text)


            If (Form_BD_arbitros.Cod_arbitrosTextBox.Text <> "") Then
                Form_alteracao_aluno.checkbox_arbitro.Checked = True
                Form_alteracao_aluno.checkbox_arbitro_novo.Checked = True
            Else
                Form_alteracao_aluno.checkbox_arbitro.Checked = False
                Form_alteracao_aluno.checkbox_arbitro_novo.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub alteracao_arbitros()
        Try
            Form_BD_arbitros.Tb_arbitrosTableAdapter.InsertQuery(Form_alteracao_aluno.id_retornado.Text)


        Catch ex As Exception

        End Try
    End Sub
End Class
