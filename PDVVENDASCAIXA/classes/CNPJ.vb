

Imports System.Net
Imports Newtonsoft.Json

Public Class AtividadePrincipal
    Property code As String
    Property text As String
End Class

Public Class AtividadeSecundaria
    Property code As String
    Property text As String
End Class

Public Class Billing
    Property free As Boolean
    Property database As Boolean
End Class

Public Class Extra

End Class

Public Class Qsa
    Property nome As String
    Property qual As String

    'Public Shared Function ObterCnpj1(cnpj As String) As Qsa

    '    Dim url = "https://www.receitaws.com.br/v1/cnpj/" + cnpj
    '    Dim json = New WebClient().DownloadString(url)

    '    Dim qsa = JsonConvert.DeserializeObject(Of Qsa)(json)

    '    Return qsa

    'End Function

End Class

Public Class Empresa
    Property abertura As String
    Property situacao As String
    Property fantasia As String
    Property tipo As String
    Property nome As String
    Property porte As String
    Property natureza_juridica As String
    Property qsa As List(Of Qsa)
    Property logradouro As String
    Property numero As String
    Property complemento As String
    Property bairro As String
    Property municipio As String
    Property uf As String
    Property cep As String
    Property telefone As String
    Property email As String
    Property efr As String
    Property motivo_situacao As String
    Property situacao_especial As String
    Property data_situacao_especial As String
    Property atividade_principal As List(Of AtividadePrincipal)
    Property atividade_secundaria As List(Of AtividadeSecundaria)
    Property capital_social As String
    Property extra As Extra
    Property billing As Billing


    'Public Sub New()

    'End Sub

    'Public Sub New(nome As String, qual As String)
    '    Me.nome = nome
    '    ' Me.qual = qual
    'End Sub

    'Public Sub ListaQsa(lista As List(Of Qsa))
    '    lista.Add(New Qsa(""))
    'End Sub

    'Public Shared Function ObterCnpj1(cnpj As String) As Qsa

    '    Dim url = "https://www.receitaws.com.br/v1/cnpj/" + cnpj
    '    Dim json = New WebClient().DownloadString(url)

    '    Dim qsa = JsonConvert.DeserializeObject(Of Qsa)(json)

    '    Return qsa

    'End Function


    Public Shared Function ObterCnpj(cnpj As String) As Empresa

        Dim url = "https://www.receitaws.com.br/v1/cnpj/" + cnpj
        Dim json = New WebClient().DownloadString(url)

        Dim empresa = JsonConvert.DeserializeObject(Of Empresa)(json)

        Return empresa

    End Function








End Class




'https://www.receitaws.com.br/v1/cnpj/05305236000150
