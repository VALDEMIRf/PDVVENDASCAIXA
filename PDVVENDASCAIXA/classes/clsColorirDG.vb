Public Class clsColorirDG
    Public Id As Integer
    Public Representante As String
    Public Sexo As String
    Public Meta As Decimal
    Public Realizado As Decimal
    Public Resultado As Double
    Public Participacao As Double
    Public MetaAtingida As String
    Public Nota As String

    Public Sub New()
    End Sub

    Public Sub New(_id As Integer, _representante As String, _sexo As String, _meta As Decimal, _realizado As Decimal, _resultado As Double, _participacao As Double, _metaAtingida As String, _nota As String)

        Id = _id
        Representante = _representante
        Sexo = _sexo
        Meta = _meta
        Realizado = _realizado
        Resultado = _resultado
        Participacao = _participacao
        MetaAtingida = _metaAtingida
        Nota = _nota
    End Sub

    Public Function GetclsColorirDG() As List(Of clsColorirDG)
        Dim listaclsColorirDG = New List(Of clsColorirDG)

        listaclsColorirDG.Add(New clsColorirDG(1, "Ana Lúcia dos Santos", "F", 20000, 19500, 98, 5, "Não", "Bom"))
        listaclsColorirDG.Add(New clsColorirDG(2, "Eduardo Martins da Costa", "M", 65000, 60000, 92, 17, "Não", "Bom"))
        listaclsColorirDG.Add(New clsColorirDG(3, "Lerandro de Barros", "M", 27000, 19500, 72, 5, "Não", "Regular"))
        listaclsColorirDG.Add(New clsColorirDG(4, "Lígia Lima de Carvalho", "F", 23000, 25000, 109, 7, "Sim", "Ótimo"))
        listaclsColorirDG.Add(New clsColorirDG(5, "Nelson Viera Ferraz", "M", 16000, 17500, 109, 5, "Sim", "Ótimo"))
        listaclsColorirDG.Add(New clsColorirDG(6, "Tiago Batista ", "M", 39000, 25000, 64, 7, "Não", "Ruím"))
        listaclsColorirDG.Add(New clsColorirDG(7, "Vera do Nascimento Lima", "F", 110000, 96000, 86, 26, "Não", "Bom"))
        listaclsColorirDG.Add(New clsColorirDG(8, "Walter Teizeia de Souza", "M", 95000, 100000, 105, 28, "Não", "Bom"))

        Return listaclsColorirDG
    End Function
End Class
