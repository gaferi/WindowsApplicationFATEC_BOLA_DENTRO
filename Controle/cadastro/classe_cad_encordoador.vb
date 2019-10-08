Public Class classe_cad_encordoador
    Public Sub cad_encordoador()
        Try
            Form_BD_encordoador.Tb_encordoadorTableAdapter.InsertQuery(Form_cadastro_aluno.retorno_id.Text)

        Catch ex As Exception

        End Try
    End Sub


    Public Sub retorna_ativade()
        Try
            Form_BD_encordoador.Tb_encordoadorTableAdapter.retorna_atividade(Form_BD_encordoador.Bola_dentroDataSet.tb_encordoador, Form_alteracao_aluno.id_retornado.Text)


            If (Form_BD_encordoador.Cod_encordoadorTextBox.Text <> "") Then
                Form_alteracao_aluno.checkbox_encordoador.Checked = True
                Form_alteracao_aluno.checkbox_encordoador_novo.Checked = True
            Else
                Form_alteracao_aluno.checkbox_encordoador.Checked = False
                Form_alteracao_aluno.checkbox_encordoador_novo.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub


    Public Sub alterar_encordoador()
        Try
            Form_BD_encordoador.Tb_encordoadorTableAdapter.InsertQuery(Form_alteracao_aluno.id_retornado.Text)

        Catch ex As Exception

        End Try
    End Sub
End Class
