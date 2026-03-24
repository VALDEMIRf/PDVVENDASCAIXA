Imports System.Data.SqlClient
Imports System.Configuration

Public Class ContaReceberDAL
    Public ds As New DataSet
    Private adpt As SqlDataAdapter
    'Private PDVConnectionString As String = ConfigurationManager.ConnectionStrings("PDVConnectionString").ConnectionString
    Dim connectionString As String = My.Settings.PDVConnectionString.ToString

End Class
