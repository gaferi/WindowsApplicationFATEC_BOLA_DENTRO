Public Class Form_cadastro_aluno

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        retorno_id.Text = ""

        If (nome_aluno.Text <> "") And (rg.Text <> "") Then
            Dim cad_aluno = New classe_cad_aluno
            cad_aluno.cadastro_aluno()
            Form_BD_aluno.Show()
        Else
            MsgBox("Campo nome do aluno e rg do aluno, não podem estar em branco")

        End If

     
        Dim consulta_id = New classe_cad_aluno()
        consulta_id.retorn_id_aluno()

        If (checkbox_ajudante_quadra.Checked = True) Then
            Dim cadastro_ajudante_quadra = New classe_cad_ajudante_quadra()
            cadastro_ajudante_quadra.cad_ajudante_quadra()

        End If

        If (checkbox_boleiro.Checked = True) Then

            Dim cadastro_boleiro = New classe_cad_boleiro()
            cadastro_boleiro.cad_boleiro()

        End If

        If (checkbox_encordoador.Checked = True) Then
            Dim cadastro_encordoador = New classe_cad_encordoador()
            cadastro_encordoador.cad_encordoador()


        End If

        If (checkbox_arbitro.Checked = True) Then
            Dim cadastro_arbitro = New classe_cad_arbitros()
            cadastro_arbitro.cad_arbitros()

        End If

        If (categoria_a.Checked = True) Or (categoria_b.Checked = True) Or (categoria_c.Checked = True) Or (categoria_d.Checked = True) Then
            Dim cadastro_jogador = New classe_cad_jogador()
            cadastro_jogador.cadastrar_jogador()
        End If


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles categoria_a.CheckedChanged
        If (categoria_a.Checked = True) Then
            categoria_jogador.Text = "A"
        End If

        

        

        
    End Sub

    Private Sub categoria_b_CheckedChanged(sender As Object, e As EventArgs) Handles categoria_b.CheckedChanged
        If (categoria_b.Checked = True) Then
            categoria_jogador.Text = "B"
        End If
    End Sub

    Private Sub categoria_c_CheckedChanged(sender As Object, e As EventArgs) Handles categoria_c.CheckedChanged
        If (categoria_c.Checked = True) Then
            categoria_jogador.Text = "C"
        End If
    End Sub

    Private Sub categoria_d_CheckedChanged(sender As Object, e As EventArgs) Handles categoria_d.CheckedChanged
        If (categoria_d.Checked = True) Then
            categoria_jogador.Text = "D"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles sem_ranking.CheckedChanged
        If (sem_ranking.Checked = True) Then
            categoria_jogador.Text = ""
        End If
    End Sub
End Class