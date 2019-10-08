Imports MySql.Data.MySqlClient
Imports System.Text

Public Class classe_consulta_encordoador
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

    Public Function detalhe() As DataSet
        Dim var As New StringBuilder

        var.Append(" SELECT a.alunoID, nome_aluno, rg_aluno FROM boladentro.tb_encordoador ")
        var.Append(" INNER JOIN tb_aluno as a ")
        var.Append(" ON tb_encordoador.alunoID = a.alunoID; ")

        Return RetornaDataSet(var.ToString)
    End Function
End Class
