Public Class Form_consulta_jogadores

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clss As New classe_consulta_jogador()
        DataGridView1.DataSource() = clss.detalhe_a().Tables(0)

        DataGridView1.Columns(0).HeaderText = CStr("Nome do Jogador")
        DataGridView1.Columns(1).HeaderText = CStr("Pontuação")
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim clss As New classe_consulta_jogador()
        DataGridView1.DataSource() = clss.detalhe_b().Tables(0)

        DataGridView1.Columns(0).HeaderText = CStr("Nome do Jogador")
        DataGridView1.Columns(1).HeaderText = CStr("Pontuação")
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim clss As New classe_consulta_jogador()
        DataGridView1.DataSource() = clss.detalhe_c().Tables(0)

        DataGridView1.Columns(0).HeaderText = CStr("Nome do Jogador")
        DataGridView1.Columns(1).HeaderText = CStr("Pontuação")
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clss As New classe_consulta_jogador()
        DataGridView1.DataSource() = clss.detalhe_d().Tables(0)

        DataGridView1.Columns(0).HeaderText = CStr("Nome do Jogador")
        DataGridView1.Columns(1).HeaderText = CStr("Pontuação")
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub
End Class