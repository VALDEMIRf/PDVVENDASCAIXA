Imports System.Data.SqlClient

Public Class clsContaPagar
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ContaPagarDAL

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



    Private cod_produto_ As Integer
    Public Property cod_produto() As Integer
        Get
            Return cod_produto_
        End Get
        Set(ByVal value As Integer)
            cod_produto_ = value
        End Set
    End Property

    Public Property Id As Integer
    Public Property Descricao As String
    Public Property numDocto As String
    Public Property Valor As Decimal
    Public Property ValorTotal As Decimal
    Public Property DataVencimento As Date
    Public Property dataEmissao As Date
    Public Property DataVencimento1 As Date
    Public Property DataPagamento As Date
    Public Property Pago As Boolean
    Public Property id_fornecedor As Integer
    Public Property Status As String
    Public Property Parcelado As Boolean
    Public Property id_categoriacontas As Integer
    Public Property id_formaPag As Integer


    Public Function ConsularIDParcela()
        sql = "Select * from tbParcelasPagar_Gravar Where parcela='" & parcela & "'"
        ds = con.listar(sql)

        'Using conn = clsConexao.ObterConexao()
        '    conn.Open()

        '    Dim cmd As New SqlCommand("Select * from tbParcelasPagar_Gravar Where parcela='" & parcela & "'", conn)

        '    Dim qtd As Integer = CInt(cmd.ExecuteScalar())

        '    If qtd > 0 Then
        '        MessageBox.Show("Atenção! Existem " & qtd & " parcelas próximas do vencimento.")
        '    End If
        'End Using
        Return ds
    End Function

    Public Function ConsularIDParcelaReceber()
        sql = "Select * from tbParcelasReceber_Gravar Where parcela='" & parcela & "'"
        ds = con.listar(sql)

        'Using conn = clsConexao.ObterConexao()
        '    conn.Open()

        '    Dim cmd As New SqlCommand("Select * from tbParcelasPagar_Gravar Where parcela='" & parcela & "'", conn)

        '    Dim qtd As Integer = CInt(cmd.ExecuteScalar())

        '    If qtd > 0 Then
        '        MessageBox.Show("Atenção! Existem " & qtd & " parcelas próximas do vencimento.")
        '    End If
        'End Using
        Return ds
    End Function

    Public Function ConsularValorParcelaReceber()
        sql = "Select * from tbParcelasReceber_Gravar Where id_parcela='" & id_parcela & "'"
        ds = con.listar(sql)

        'Using conn = clsConexao.ObterConexao()
        '    conn.Open()

        '    Dim cmd As New SqlCommand("Select * from tbParcelasPagar_Gravar Where parcela='" & parcela & "'", conn)

        '    Dim qtd As Integer = CInt(cmd.ExecuteScalar())

        '    If qtd > 0 Then
        '        MessageBox.Show("Atenção! Existem " & qtd & " parcelas próximas do vencimento.")
        '    End If
        'End Using
        Return ds
    End Function

End Class
