Public Class Produto
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoTeste


    Private cod_produto_ As Integer
    Public Property cod_produto() As Integer
        Get
            Return cod_produto_
        End Get
        Set(ByVal value As Integer)
            cod_produto_ = value
        End Set
    End Property

    Private produto_ As String
    Public Property produto() As String
        Get
            Return produto_
        End Get
        Set(ByVal value As String)
            produto_ = value
        End Set
    End Property

    Private valor_ As String
    Public Property valor() As String
        Get
            Return valor_
        End Get
        Set(ByVal value As String)
            valor_ = value
        End Set
    End Property

    Public Sub CadastrarValor()

        sql = "Insert Into produtoTesteAPAGAR (produto,valor)values('" & produto & "','" & valor & "' )"
        con.Operar(sql)

    End Sub

    Public Function ConsularValor()
        sql = "Select * from tbProduto"
        ds = con.listar(sql)
        Return ds
    End Function
End Class
