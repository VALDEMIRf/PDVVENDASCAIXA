Imports System.Data.SqlClient

Public Class clsConexao

    Public Shared Function ObterConexao() As SqlConnection
        Return New SqlConnection("Data Source=DESKTOP-R5VHKNO\SQLEXPRESS;Initial Catalog=PDV;Integrated Security=True")
    End Function
    End Class

