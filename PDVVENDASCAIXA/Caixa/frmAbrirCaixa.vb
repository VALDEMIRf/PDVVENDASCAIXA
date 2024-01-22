Imports System.Data.SqlClient

Public Class frmAbrirCaixa
    Private Sub frmAbrirCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAbertura.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtAbertura.Text = "" Then
            MsgBox("Digite um valor")
        Else
            Dim cmd As SqlCommand
            Dim cmd2 As SqlCommand
            Try

                Dim descricao_Sangria As String = "inicio do dia"
                Dim descricao_reforco As String = "inicio do dia"

                abrir()
                cmd = New SqlCommand("pa_caixa_abertura_caixa", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@data_ab", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@hora_ab", Now.ToLongTimeString())
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@valor_ab", txtAbertura.Text)
                cmd.Parameters.AddWithValue("@valor_sangria", 0)
                cmd.Parameters.AddWithValue("@hora_sangria", Now.ToLongTimeString())
                ' cmd.Parameters.AddWithValue("@historico", descricao_Sangria)
                cmd.Parameters.AddWithValue("@quant_vendas", 0)
                cmd.Parameters.AddWithValue("@prod_vendidos", 0)
                cmd.Parameters.AddWithValue("@total_vendido", 0)
                cmd.Parameters.AddWithValue("@total_caixa", 0)
                cmd.Parameters.AddWithValue("@saldo_total", 0)
                cmd.Parameters.AddWithValue("@valor_quebra", 0)
                cmd.Parameters.AddWithValue("@hora_fecha", Now.ToLongTimeString())
                ' cmd.Parameters.AddWithValue("@valor_reforco", 0)
                ' cmd.Parameters.AddWithValue("@motivo_reforco", descricao_reforco)


                ''@data_ab,@hora_ab,@funcionario,@valor_ab,@valor_sangria,@hora_sangria,@quant_vendas,@prod_vendidos,
                ''@total_vendido,@total_caixa,@saldo_total,@valor_quebra,@hora_fecha
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub frmAbrirCaixa_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtAbertura.Focus()
    End Sub
End Class