Public Class Form_consulta_boleiro

    Private Sub Form_consulta_boleiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clss As New classe_consulta_boleiro
        DataGridView1.DataSource() = clss.detalhe().Tables(0)
        DataGridView1.Columns(0).HeaderText = CStr("codigo boleiro")
        DataGridView1.Columns(1).HeaderText = CStr("Nome Aluno")
        DataGridView1.Columns(2).HeaderText = CStr("RG aluno")
        DataGridView1.AutoResizeColumns()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class