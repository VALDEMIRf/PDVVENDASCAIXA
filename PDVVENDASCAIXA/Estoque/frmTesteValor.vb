Imports System.Data.SqlClient

Public Class frmTesteValor
    Private Sub frmTesteValor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub
    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_estoque_Buscargeral", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.Fill(dt)
            dg.DataSource = dt

            '  FormatarDG()
            ' CarregarProdutosBuscar()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

End Class