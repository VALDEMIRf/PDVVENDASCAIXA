Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class ConexaoTeste
    Public con As New SqlConnection
    Public cmd As SqlCommand = con.CreateCommand
    Public ds As New DataSet
    Public da As SqlDataAdapter = New SqlDataAdapter(cmd)

    Dim daImagem As SqlDataAdapter
    Dim dsImagem As DataSet


    Public Sub Conectar()


        Try

            con.ConnectionString = "Data Source=DESKTOP-R5VHKNO\SQLEXPRESS;Initial Catalog=PDV;Integrated Security=True"
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message & "Erro ao conectar")


        End Try
    End Sub

    Public Sub Operar(ByVal sql)
        Conectar()
        Try
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & ex.ToString, MsgBoxStyle.Critical, "Erro no método operar")
        Finally
            con.Close()
        End Try
    End Sub

    Public Function listar(ByVal sql As String)
        Conectar()
        Try
            ds.Clear()
            cmd.CommandText = sql
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message & " erro no método listar")
        Finally
            con.Close()
        End Try
        Return ds
    End Function




End Class
