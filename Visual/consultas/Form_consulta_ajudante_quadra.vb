Imports MySql.Data.MySqlClient

Public Class Form_consulta_ajudante_quadra

    Private Sub Form_consulta_ajudante_quadra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clss As New classe_consulta_ajudante_quadra
        DataGridView1.DataSource() = clss.detalhe().Tables(0)
        DataGridView1.Columns(0).HeaderText = CStr("codigo ajudante de quadra")
        DataGridView1.Columns(1).HeaderText = CStr("Nome Aluno")
        DataGridView1.Columns(2).HeaderText = CStr("RG aluno")
        DataGridView1.AutoResizeColumns()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class