

Imports System.Data.SqlClient

Public Class Parcelas

    Dim sql As String
    Dim ds As New DataSet
    Dim conex As New ConexaoTeste
    Dim param As SqlParameter


    Private id_parcela_ As Integer
    Public Property id_parcela() As Integer
        Get
            Return id_parcela_
        End Get
        Set(ByVal value As Integer)
            id_parcela_ = value
        End Set
    End Property

    Private parcela_ As Integer
    Public Property parcela() As Integer
        Get
            Return parcela_
        End Get
        Set(ByVal value As Integer)
            parcela_ = value
        End Set
    End Property


    Private data_parcela_ As String
    Public Property data_parcela() As String
        Get
            Return data_parcela_
        End Get
        Set(ByVal value As String)
            data_parcela_ = value
        End Set
    End Property

    Private valor_parcela_ As String
    Public Property valor_parcela() As String
        Get
            Return valor_parcela_
        End Get
        Set(ByVal value As String)
            valor_parcela_ = value
        End Set
    End Property

    Private numDocto_ As String
    Public Property numDocto() As String
        Get
            Return numDocto_
        End Get
        Set(ByVal value As String)
            numDocto_ = value
        End Set
    End Property


    Private descricao_ As String
    Public Property descricao() As String
        Get
            Return descricao_
        End Get
        Set(ByVal value As String)
            descricao_ = value
        End Set
    End Property


    Private valorTotal_ As String
    Public Property valorTotal() As String
        Get
            Return valorTotal_
        End Get
        Set(ByVal value As String)
            valorTotal_ = value
        End Set
    End Property


    Private situacao_ As String
    Public Property situacao() As String
        Get
            Return situacao_
        End Get
        Set(ByVal value As String)
            situacao_ = value
        End Set
    End Property

    Private saldoRestante_ As String
    Public Property saldoRestante() As String
        Get
            Return saldoRestante_
        End Get
        Set(ByVal value As String)
            saldoRestante_ = value
        End Set
    End Property

    Public Sub CadastrarParcela()

        sql = "Insert Into tbParcelasPagar(parcela,data_parcela,valor_parcela,numDocto,descricao,valorTotal,situacao,saldoRestante)values(" & parcela & ",'" & data_parcela & "','" & valor_parcela & "','" & numDocto & "','" & descricao & "','" & valorTotal & "','" & situacao & "','" & saldoRestante & "' )"
        conex.Operar(sql)

        'Try
        '    abrir()
        '    Dim SqlQuery As String = "pa_Parcelas_Salvar"
        '    Dim cmd As New SqlClient.SqlCommand(SqlQuery, con)
        '    cmd.CommandType = CommandType.StoredProcedure

        '    param = Paramete.parcela
        '    param.Value = parcela
        '    cmd.Parameters.Add(param)

        '    param = Paramete.data_parcela
        '    param.Value = data_parcela
        '    cmd.Parameters.Add(param)

        '    param = Paramete.valor_parcela
        '    param.Value = valor_parcela
        '    cmd.Parameters.Add(param)

        '    param = Paramete.numDocto
        '    param.Value = numDocto
        '    cmd.Parameters.Add(param)

        '    param = Paramete.descricao
        '    param.Value = descricao
        '    cmd.Parameters.Add(param)

        '    param = Paramete.valorTotal
        '    param.Value = valorTotal
        '    cmd.Parameters.Add(param)

        '    param = Paramete.situacao
        '    param.Value = situacao
        '    cmd.Parameters.Add(param)
        '    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
        '    cmd.ExecuteNonQuery()

        '    Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
        '    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

        '        id_parcela Int PRIMARY KEY IDENTITY(1, 1) Not NULL,
        'parcela Int,
        'data_parcela Date,
        'valor_parcela varchar(20),
        'numDocto varchar(50),
        'descricao varchar(200) NULL,
        'valorTotal varchar(30),
        'situacao varchar(20) 
        'Catch ex As Exception
        '    MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
        'Finally
        '    fechar()
        'End Try

    End Sub

    Public Shared Function SalvarParcelas(dgv As DataGridView) As Boolean
        Dim sql = ""
        Try
            abrir()

            For Each r As DataGridViewRow In dgv.Rows
                If Convert.ToInt32("0" + r.Cells("id_parcela").Value) = 0 Then
                    sql = "INSERT INTO tbParcelasPagar(parcela,data_parcela,valor_parcela,numDocto,descricao,valorTotal,situacao)values(@parcela,@data_parcela,@valor_parcela,@numDocto,@descricao,@valorTotal,@situacao)"
                Else
                    sql = "UPDATE tbParcelasPagar SET parcela=@parcela,data_parcela=@data_parcela,valor_parcela=@valor_parcela,numDocto=@numDocto,descricao=@descricao,valorTotal=@valorTotal,situacao=@situacao WHERE id_parcela=@id_parcela"
                End If

                Using cmd = New SqlCommand(sql, con) ',,,,,
                    cmd.Parameters.AddWithValue("@parcela", r.Cells("parcela").Value)
                    cmd.Parameters.AddWithValue("@data_parcela", r.Cells("data_parcela").Value)
                    cmd.Parameters.AddWithValue("@valor_parcela", r.Cells("valor_parcela").Value)
                    cmd.Parameters.AddWithValue("@numDocto", r.Cells("numDocto").Value)
                    cmd.Parameters.AddWithValue("@descricao", r.Cells("descricao").Value)
                    cmd.Parameters.AddWithValue("@valorTotal", r.Cells("valorTotal").Value)
                    cmd.Parameters.AddWithValue("@situacao", r.Cells("situacao").Value)

                    If Convert.ToInt32("0" + r.Cells("id_parcela").Value) > 0 Then
                        cmd.Parameters.AddWithValue("@id_parcela", Convert.ToInt32("0" + r.Cells("id_parcela").Value))
                    End If

                    cmd.ExecuteNonQuery()
                End Using
            Next
            Return True
        Catch ex As Exception
            MsgBox("Erro ao gravar as Parcelas no banco!" + ex.Message.ToString, MsgBoxStyle.Critical, "Erro")
            Return False
        Finally
            fechar()
        End Try

    End Function


    Public Sub CadastrarParcelaReceber()

        sql = "Insert Into tbParcelasReceber(parcela,data_parcela,valor_parcela,numDocto,descricao,valorTotal,situacao)values(" & parcela & ",'" & data_parcela & "','" & valor_parcela & "','" & numDocto & "','" & descricao & "','" & valorTotal & "','" & situacao & "' )"
        conex.Operar(sql)

    End Sub

    Public Shared Function SalvarParcelasReceber(dgv As DataGridView) As Boolean
        Dim sql = ""
        Try
            abrir()

            For Each r As DataGridViewRow In dgv.Rows
                If Convert.ToInt32("0" + r.Cells("id_parcela").Value) = 0 Then
                    sql = "INSERT INTO tbParcelasReceber(parcela,data_parcela,valor_parcela,numDocto,descricao,valorTotal,situacao)values(@parcela,@data_parcela,@valor_parcela,@numDocto,@descricao,@valorTotal,@situacao)"
                Else
                    sql = "UPDATE tbParcelasReceber SET parcela=@parcela,data_parcela=@data_parcela,valor_parcela=@valor_parcela,numDocto=@numDocto,descricao=@descricao,valorTotal=@valorTotal,situacao=@situacao WHERE id_parcela=@id_parcela"
                End If

                Using cmd = New SqlCommand(sql, con) ',,,,,
                    cmd.Parameters.AddWithValue("@parcela", r.Cells("parcela").Value)
                    cmd.Parameters.AddWithValue("@data_parcela", r.Cells("data_parcela").Value)
                    cmd.Parameters.AddWithValue("@valor_parcela", r.Cells("valor_parcela").Value)
                    cmd.Parameters.AddWithValue("@numDocto", r.Cells("numDocto").Value)
                    cmd.Parameters.AddWithValue("@descricao", r.Cells("descricao").Value)
                    cmd.Parameters.AddWithValue("@valorTotal", r.Cells("valorTotal").Value)
                    cmd.Parameters.AddWithValue("@situacao", r.Cells("situacao").Value)

                    If Convert.ToInt32("0" + r.Cells("id_parcela").Value) > 0 Then
                        cmd.Parameters.AddWithValue("@id_parcela", Convert.ToInt32("0" + r.Cells("id_parcela").Value))
                    End If

                    cmd.ExecuteNonQuery()
                End Using
            Next
            Return True
        Catch ex As Exception
            MsgBox("Erro ao gravar as Parcelas no banco!" + ex.Message.ToString, MsgBoxStyle.Critical, "Erro")
            Return False
        Finally
            fechar()
        End Try

    End Function


    Public Class Paramete
        Shared Function id_parcela() As SqlParameter
            Return New SqlParameter("@id_parcela", SqlDbType.Int)  'parcela
        End Function

        Shared Function parcela() As SqlParameter
            Return New SqlParameter("@parcela", SqlDbType.Int)  'parcela
        End Function

        Shared Function data_parcela() As SqlParameter
            Return New SqlParameter("@data_parcela", SqlDbType.Date)
        End Function

        Shared Function valor_parcela() As SqlParameter
            Return New SqlParameter("@valor_parcela", SqlDbType.VarChar)
        End Function

        Shared Function numDocto() As SqlParameter
            Return New SqlParameter("@numDocto", SqlDbType.VarChar)
        End Function
        Shared Function descricao() As SqlParameter
            Return New SqlParameter("@descricao", SqlDbType.VarChar)
        End Function

        Shared Function valorTotal() As SqlParameter
            Return New SqlParameter("@valorTotal", SqlDbType.VarChar)
        End Function

        Shared Function situacao() As SqlParameter
            Return New SqlParameter("@situacao", SqlDbType.VarChar)
        End Function

    End Class
End Class
