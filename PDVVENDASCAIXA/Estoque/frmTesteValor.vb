Imports System.Data.SqlClient

Public Class frmTesteValor
    Private Sub frmTesteValor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarProdutos()
        '  carregaDados()
        Listar()
    End Sub

    Private Sub btGravar_Click(sender As Object, e As EventArgs) Handles btGravar.Click

    End Sub

    Sub carregaDados()
        Dim cmd As New SqlCommand("pa_buscarValorProd", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            cmd.Parameters.Add("@quant", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@valor_venda", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@valor_venda1", SqlDbType.Money).Direction = 2
            cmd.Parameters.Add("@valor_venda2", SqlDbType.VarChar).Direction = 2

            'cmd.Parameters.Add("@quant_vendida", SqlDbType.Int).Direction = 2
            'cmd.Parameters.Add("@codigo_barras", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            'Dim valorVenda As Double


            Dim valor As Decimal = cmd.Parameters("@valor_venda").Value
            Dim valor1 As Double = cmd.Parameters("@valor_venda1").Value
            Dim valor2 As String = cmd.Parameters("@valor_venda2").Value
            txtValorDecimal.Text = CDbl(valor)
            txtValorMoney.Text = CDbl(valor2)
            txtValorVarchar.Text = CDbl(valor2)


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_prod_Teste_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.Fill(dt)
            dg.DataSource = dt

            'FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub CarregarProdutos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbProdutos", con) '
            DA = New SqlDataAdapter("pa_produto_Lista", con)
            DA.Fill(DT)
            cbProduto.DisplayMember = "nome"
            cbProduto.ValueMember = "id_produto"
            cbProduto.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        Dim valor As Decimal
        Dim valor1 As Double
        Dim valor2 As String

        Dim resultado As Decimal
        Dim resultado1 As Double
        Dim resultado2 As String

        valor = txtValorDecimal.Text
        valor1 = txtValorMoney.Text
        valor2 = txtValorVarchar.Text

        Dim quant As Integer
        quant = txtquant.Text

        resultado = valor * quant
        resultado1 = valor1 * quant
        resultado2 = valor2 * quant

        txtResultadoDecimal.Text = resultado
        txtResultadoMoney.Text = resultado1
        txtResultadoVarchar.Text = resultado2
    End Sub
End Class