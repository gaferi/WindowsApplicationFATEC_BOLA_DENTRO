Imports MySql.Data.MySqlClient
Imports System.Text

Public Class classe_consulta_jogador
    Dim stringconexao As String

    Public Function AbreBanco() As MySqlConnection
        stringconexao = "server=localhost;User Id=root;password=b2w25pgGC@;database=boladentro;Persist Security Info=True"
        Dim conn As New MySqlConnection
        With conn
            .ConnectionString = stringconexao
            .Open()
        End With
        Return conn
    End Function

    Public Sub FechaBanco(ByVal conn As MySqlConnection)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

    End Sub

    Public Function RetornaDataSet(ByVal strQuery As String) As DataSet
        Dim conn As New MySqlConnection
        Try
            conn = AbreBanco()
            Dim cmdComando As New MySqlCommand
            With cmdComando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = conn
            End With
            Dim daAdaptador As New MySqlDataAdapter
            Dim dsDataSet As New DataSet
            daAdaptador.SelectCommand = cmdComando
            daAdaptador.Fill(dsDataSet)
            Return dsDataSet
        Catch ex As Exception
            Throw New Exception("Erro na Camada3 " & ex.Message)
        Finally
            FechaBanco(conn)
        End Try
    End Function

    Public Function detalhe_a() As DataSet
        Dim var As New StringBuilder
        var.Append(" select nome_aluno, tb_jogador.pontuacao from tb_aluno ")
        var.Append(" inner join tb_jogador ")
        var.Append(" on tb_aluno.alunoID = tb_jogador.alunoID ")
        var.Append(" where categoria = 'A'")
        var.Append(" order by pontuacao desc;")

        Return RetornaDataSet(var.ToString)
    End Function
    Public Function detalhe_b() As DataSet
        Dim var As New StringBuilder
        var.Append(" select nome_aluno, tb_jogador.pontuacao from tb_aluno ")
        var.Append(" inner join tb_jogador ")
        var.Append(" on tb_aluno.alunoID = tb_jogador.alunoID ")
        var.Append(" where categoria = 'B'")
        var.Append(" order by pontuacao desc;")

        Return RetornaDataSet(var.ToString)
    End Function

    Public Function detalhe_c() As DataSet
        Dim var As New StringBuilder

        var.Append(" select nome_aluno, tb_jogador.pontuacao from tb_aluno ")
        var.Append(" inner join tb_jogador ")
        var.Append(" on tb_aluno.alunoID = tb_jogador.alunoID ")
        var.Append(" where categoria = 'C'")
        var.Append(" order by pontuacao desc;")
        Return RetornaDataSet(var.ToString)
    End Function
    Public Function detalhe_d() As DataSet
        Dim var As New StringBuilder

        var.Append(" select nome_aluno, tb_jogador.pontuacao from tb_aluno ")
        var.Append(" inner join tb_jogador ")
        var.Append(" on tb_aluno.alunoID = tb_jogador.alunoID ")
        var.Append(" where categoria = 'D'")
        var.Append(" order by pontuacao desc;")
        Return RetornaDataSet(var.ToString)
    End Function

End Class
