Public Class Form_alteracao_aluno

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesquisa_aluno = New classe_cad_aluno
        pesquisa_aluno.pesquisar_aluno_por_rg()

        Dim retorna_ajudante_quadra = New classe_cad_ajudante_quadra()
        retorna_ajudante_quadra.retorna_ativade()

        Dim retorna_arbitros = New classe_cad_arbitros()
        retorna_arbitros.retorna_ativade()

        Dim retorna_boleiro = New classe_cad_boleiro()
        retorna_boleiro.retorna_ativade()

        Dim retorna_encordoador = New classe_cad_encordoador()
        retorna_encordoador.retorna_ativade()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim alteracao_aluno = New classe_alteracao_aluno()
        alteracao_aluno.altera_dados_aluno()

        If (checkbox_ajudante_quadra_novo.Checked <> checkbox_ajudante_quadra.Checked) Then
            If (checkbox_ajudante_quadra_novo.Checked = True) Then
                Dim cadastro_ajudante_quadra = New classe_cad_ajudante_quadra()
                cadastro_ajudante_quadra.alterar_ajudante_quadra()

            Else
                Dim exclusao_ajudante_quadra = New classe_exclusao_ajudante_quadra()
                exclusao_ajudante_quadra.excluir_ajudante_quadra()

            End If
        End If



        If (checkbox_boleiro_novo.Checked <> checkbox_boleiro.Checked) Then
            If (checkbox_boleiro_novo.Checked = True) Then
                Dim cadastro_boleiro = New classe_cad_boleiro()
                cadastro_boleiro.altera_boleiro()

            Else
                Dim exclusao_boleiro = New classe_exclusao_boleiro()
                exclusao_boleiro.excluir_boleiro()
            End If
        End If

        If (checkbox_arbitro_novo.Checked <> checkbox_arbitro.Checked) Then
            If (checkbox_arbitro_novo.Checked = True) Then
                Dim cadastro_arbitro = New classe_cad_arbitros()
                cadastro_arbitro.alteracao_arbitros()

            Else
                Dim exclusao_arbitros = New classe_exclusao_arbitro()
                exclusao_arbitros.excluir_arbitro()
            End If
        End If

        If (checkbox_encordoador_novo.Checked <> checkbox_encordoador.Checked) Then
            If (checkbox_encordoador_novo.Checked = True) Then
                Dim cadastro_encordoador = New classe_cad_encordoador()
                cadastro_encordoador.alterar_encordoador()

            Else
                Dim exclusao_encordoador = New classe_exclusao_encordoador()
                exclusao_encordoador.exclui_encordoador()

            End If
        End If

        limpa_campos()









    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Select Case MsgBox("A funcionalidade de exclusão está restrita a um cadastro incorreto. Deseja mesmo excluir este aluno?", MsgBoxStyle.YesNoCancel, "caption")

            Case MsgBoxResult.Yes

                If (checkbox_ajudante_quadra.Checked = True) Then
                    Dim exclusao_ajudante_quadra = New classe_exclusao_ajudante_quadra()
                    exclusao_ajudante_quadra.excluir_ajudante_quadra()
                End If

                If (checkbox_boleiro.Checked = True) Then
                    Dim exclusao_boleiro = New classe_exclusao_boleiro()
                    exclusao_boleiro.excluir_boleiro()
                End If

                If (checkbox_arbitro.Checked = True) Then
                    Dim exclusao_arbitros = New classe_exclusao_arbitro()
                    exclusao_arbitros.excluir_arbitro()
                End If

                If (checkbox_encordoador.Checked = True) Then
                    Dim exclusao_encordoador = New classe_exclusao_encordoador()
                    exclusao_encordoador.exclui_encordoador()
                End If

                Dim exclui_aluno = New classe_excluir_aluno()
                exclui_aluno.exclui_aluno()
                limpa_campos()



            Case MsgBoxResult.Cancel
                MessageBox.Show("Operação cancelada")
            Case MsgBoxResult.No
                MessageBox.Show("Operação cancelada")

        End Select




    End Sub

    Public Function limpa_campos()

        rg_dig.Text = ""
        nome_aluno.Text = ""
        mae_aluno.Text = ""
        nome_pai.Text = ""
        data_nascimento.Text = ""
        rg.Text = ""
        data_ingresso.Text = ""
        data_exame_medico.Text = ""
        id_retornado.Text = ""
        checkbox_ajudante_quadra.Checked = False
        checkbox_ajudante_quadra_novo.Checked = (False)
        checkbox_arbitro.Checked = False
        checkbox_arbitro_novo.Checked = False
        checkbox_boleiro.Checked = False
        checkbox_boleiro_novo.Checked = False
        checkbox_encordoador.Checked = False
        checkbox_encordoador_novo.Checked = False
        Return 0

    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        MsgBox("blabla", MsgBoxStyle.YesNoCancel, "caption")
    End Sub

    Private Sub Form_alteracao_aluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.limpa_campos()
    End Sub
End Class