Public Class classe_cad_ajudante_quadra
    Public Sub cad_ajudante_quadra()
        Try
            Form_BD_ajudante_quadra.Tb_ajudante_quadraTableAdapter.InsertQuery(Form_cadastro_aluno.retorno_id.Text)

        Catch ex As Exception

        End Try
    End Sub
    Public Sub retorna_ativade()
        Try
            Form_BD_ajudante_quadra.Tb_ajudante_quadraTableAdapter.retorna_ativade(Form_BD_ajudante_quadra.Bola_dentroDataSet.tb_ajudante_quadra, Form_alteracao_aluno.id_retornado.Text)


            If (Form_BD_ajudante_quadra.Cod_ajudante_quadraTextBox.Text <> "") Then
                Form_alteracao_aluno.checkbox_ajudante_quadra.Checked = True
                Form_alteracao_aluno.checkbox_ajudante_quadra_novo.Checked = True
            Else
                Form_alteracao_aluno.checkbox_ajudante_quadra.Checked = False
                Form_alteracao_aluno.checkbox_ajudante_quadra_novo.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub alterar_ajudante_quadra()
        Try
            Form_BD_ajudante_quadra.Tb_ajudante_quadraTableAdapter.InsertQuery(Form_alteracao_aluno.id_retornado.Text)
        Catch ex As Exception

        End Try
    End Sub

End Class
