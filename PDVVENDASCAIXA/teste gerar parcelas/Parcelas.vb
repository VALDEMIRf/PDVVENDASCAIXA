

Imports System.Data.SqlClient

Public Class Parcelas

    Dim sql As String
    Dim ds As New DataSet
    Dim conex As New ConexaoTeste


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

    Public Sub CadastrarParcela()

        sql = "Insert Into tbParcelasPagar(parcela,data_parcela,valor_parcela,numDocto,descricao,valorTotal,situacao)values(" & parcela & ",'" & data_parcela & "','" & valor_parcela & "','" & numDocto & "','" & descricao & "','" & valorTotal & "','" & situacao & "' )"
        conex.Operar(sql)

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
End Class
