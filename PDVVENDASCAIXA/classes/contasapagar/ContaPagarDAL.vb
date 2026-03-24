Imports System.Data.SqlClient
Imports System.Configuration

Public Class ContaPagarDAL
    Public ds As New DataSet
    Private adpt As SqlDataAdapter
    'Private PDVConnectionString As String = ConfigurationManager.ConnectionStrings("PDVConnectionString").ConnectionString
    Dim connectionString As String = My.Settings.PDVConnectionString.ToString

    Public Function TotalPendente() As Decimal
        Using con As New SqlConnection(connectionString)
            Dim sql As String = "SELECT SUM(Valor) FROM tbContas_a_Pagar WHERE Pago = 0"
            Using cmd As New SqlCommand(sql, con)
                con.Open()
                Dim result = cmd.ExecuteScalar()
                If IsDBNull(result) Then
                    Return 0
                End If
                Return Convert.ToDecimal(result)
            End Using
        End Using
    End Function

    Public Function TotalPendenteRec() As Decimal
        Using con As New SqlConnection(connectionString)
            Dim sql As String = "SELECT SUM(Valor) FROM tbContasReceber WHERE Pago = 0"
            Using cmd As New SqlCommand(sql, con)
                con.Open()
                Dim result = cmd.ExecuteScalar()
                If IsDBNull(result) Then
                    Return 0
                End If
                Return Convert.ToDecimal(result)
            End Using
        End Using
    End Function

    Public Function ListarPendente() As DataTable
        Dim dt As New DataTable
        Using con As New SqlConnection(connectionString)
            Dim sql As String = "SELECT * FROM tbContas_a_Pagar WHERE Pago = 0"
            Using da As New SqlDataAdapter(sql, con)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function ListarPendenteRec() As DataTable
        Dim dt As New DataTable
        Using con As New SqlConnection(connectionString)
            Dim sql As String = "SELECT * FROM tbContasReceber WHERE Pago = 0"
            Using da As New SqlDataAdapter(sql, con)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Sub VerificarAlertas()

        Using conn = clsConexao.ObterConexao()
            conn.Open()

            Dim cmd As New SqlCommand("
            SELECT COUNT(*) FROM Parcelas
            WHERE Status = 'Aberta'
            AND DataVencimento <= DATEADD(DAY, 3, GETDATE())", conn)

            Dim qtd As Integer = CInt(cmd.ExecuteScalar())

            If qtd > 0 Then
                MessageBox.Show("Atenção! Existem " & qtd & " parcelas próximas do vencimento.")
            End If
        End Using
    End Sub

    Public Function listar(ByVal sql As String)
        'Faz a conexão com o banco de dados SQL
        Try
            con = New SqlConnection(connectionString)

        Catch ex As Exception
            MsgBox("Erro ao tentar se conectar ao banco de dados" & ex.Message, MsgBoxStyle.Information, "ERRO DE CONEXÃO COM O BANCO")
            End
        End Try

        Try
            con.Open()
            'Faz a Consulta de acordo com a String fornecida
            adpt = New SqlDataAdapter(sql, con)
            ds.Clear()

            adpt.Fill(ds)
        Catch ex As Exception
            MsgBox("Erro no método Listar" & ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try

        Return ds

    End Function


End Class
