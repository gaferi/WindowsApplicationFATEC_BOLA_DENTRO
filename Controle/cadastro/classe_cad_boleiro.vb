Public Class classe_cad_boleiro
    Public Sub cad_boleiro()
        Try
            Form_BD_boleiro.Tb_boleiroTableAdapter.InsertQuery(Form_cadastro_aluno.retorno_id.Text)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub retorna_ativade()
        Try
            Form_BD_boleiro.Tb_boleiroTableAdapter.retorna_atividade(Form_BD_boleiro.Bola_dentroDataSet.tb_boleiro, Form_alteracao_aluno.id_retornado.Text)


            If (Form_BD_boleiro.Cod_boleiroTextBox.Text <> "") Then
                Form_alteracao_aluno.checkbox_boleiro.Checked = True
                Form_alteracao_aluno.checkbox_boleiro_novo.Checked = True

            Else
                Form_alteracao_aluno.checkbox_boleiro.Checked = False
                Form_alteracao_aluno.checkbox_boleiro_novo.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub altera_boleiro()
        Try
            Form_BD_boleiro.Tb_boleiroTableAdapter.InsertQuery(Form_alteracao_aluno.id_retornado.Text)

        Catch ex As Exception

        End Try
    End Sub
End Class
