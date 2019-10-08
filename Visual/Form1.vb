Public Class Form1

    Private Sub AlunoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlunoToolStripMenuItem.Click
        Form_cadastro_aluno.ShowDialog()


    End Sub

    Private Sub AlunosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlunosToolStripMenuItem.Click
        Form_consulta_alunos.ShowDialog()

    End Sub

    Private Sub AjudantesDeQuadraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudantesDeQuadraToolStripMenuItem.Click
        Form_consulta_ajudante_quadra.ShowDialog()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clssA As New classe_consulta_jogador()
        dgvA.DataSource() = clssA.detalhe_a().Tables(0)
        dgvA.Columns(0).HeaderText = CStr("Nome do Jogador")
        dgvA.Columns(1).HeaderText = CStr("Pontuação")
        dgvA.AutoResizeColumns()
        Dim clssB As New classe_consulta_jogador()
        dgvB.DataSource() = clssB.detalhe_b().Tables(0)
        dgvB.Columns(0).HeaderText = CStr("Nome do Jogador")
        dgvB.Columns(1).HeaderText = CStr("Pontuação")
        dgvB.AutoResizeColumns()
        Dim clsSC As New classe_consulta_jogador()
        dgvC.DataSource() = clssC.detalhe_c().Tables(0)
        dgvC.Columns(0).HeaderText = CStr("Nome do Jogador")
        dgvC.Columns(1).HeaderText = CStr("Pontuação")
        dgvC.AutoResizeColumns()
        Dim clssD As New classe_consulta_jogador()
        dgvD.DataSource() = clssD.detalhe_d().Tables(0)
        dgvD.Columns(0).HeaderText = CStr("Nome do Jogador")
        dgvD.Columns(1).HeaderText = CStr("Pontuação")
        dgvD.AutoResizeColumns()

    End Sub

    Private Sub AlunosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlunosToolStripMenuItem1.Click
        Form_alteracao_aluno.ShowDialog()
        Form_BD_aluno.Show()



        Form_BD_ajudante_quadra.Show()
        Form_BD_arbitros.Show()
        Form_BD_boleiro.Show()
        Form_BD_encordoador.Show()

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ArbitrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArbitrosToolStripMenuItem.Click
        Form_consulta_arbitros.ShowDialog()

    End Sub

    Private Sub BoleiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoleiroToolStripMenuItem.Click
        Form_consulta_boleiro.ShowDialog()

    End Sub

    Private Sub EncordoadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncordoadorToolStripMenuItem.Click
        Form_consulta_encordoador.ShowDialog()

    End Sub

    Private Sub DesligamentoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AlunoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    

    End Sub

    Private Sub JogadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JogadoresToolStripMenuItem.Click
        Form_consulta_jogadores.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim clssA As New classe_consulta_jogador()
        dgvA.DataSource() = clssA.detalhe_a().Tables(0)
     
        Dim clssB As New classe_consulta_jogador()
        dgvB.DataSource() = clssB.detalhe_b().Tables(0)
    
        Dim clsSC As New classe_consulta_jogador()
        dgvC.DataSource() = clsSC.detalhe_c().Tables(0)

        Dim clssD As New classe_consulta_jogador()
        dgvD.DataSource() = clssD.detalhe_d().Tables(0)

        txtteste.Text = Now.ToString

    End Sub

    Private Sub txtteste_TextChanged(sender As Object, e As EventArgs) Handles txtteste.TextChanged

    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Shell("calc")
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        Shell("notepad")
    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem.Click
        Form_cadastro_jogo.Show()
        Form_BD_aluno.Show()
        Form_BD_jogador.Show()

    End Sub
End Class
