Imports System.Data.SqlClient

Public Class frmProdutoConsultaSimples
    Private Sub frmProdutoConsultaSimples_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodBarras.Focus()
    End Sub

    Sub consultaValorProd()

        Dim cmd As New SqlCommand("pa_produto_consultaSimples", con)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo_barras", txtCodBarras.Text)
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 100).Direction = 2
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 100).Direction = 2
            cmd.Parameters.Add("@valor_venda", SqlDbType.Float).Direction = 2
            cmd.ExecuteNonQuery()

            Dim nome As String = cmd.Parameters("@nome").Value
            txtProduto.Text = CStr(nome)

            Dim descricao As String = cmd.Parameters("@descricao").Value
            txtDescricao.Text = CStr(descricao)

            Dim valor As Double = cmd.Parameters("@valor_venda").Value
            txtValor.Text = CDbl(valor)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub btConsulta_Click(sender As Object, e As EventArgs) Handles btConsulta.Click
        consultaValorProd()
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub
End Class