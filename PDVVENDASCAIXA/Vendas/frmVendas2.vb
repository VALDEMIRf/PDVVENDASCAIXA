Imports System.Data.SqlClient
Imports System.IO

Public Class frmVendas2
    Private Sub frmVendas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarProdutos()
        Listar()
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

    Private Sub atualizarValor()
        Dim da As SqlDataAdapter

        Dim cmd As New SqlCommand("pa_Vendas_buscarValorProd", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            cmd.Parameters.Add("@quant", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@valor_venda", SqlDbType.Float).Direction = 2
            cmd.Parameters.Add("@quant_vendida", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@codigo_barras", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            'Dim quant As Int32 = cmd.Parameters("@quant").Value
            'txtEstoque.Text = CStr(quant)

            Dim valor1 As Double = cmd.Parameters("@valor_venda").Value
            txtValorUnitario.Text = CDbl(valor1)

            Dim quant As Int32 = cmd.Parameters("@quant").Value
            txtEstoque.Text = CStr(quant)
            'Dim quant_vendida As Int32 = cmd.Parameters("@quant_vendida").Value
            'txtQuantVendida.Text = CStr(quant_vendida)

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

            '  da = New SqlDataAdapter("SELECT * FROM tbProdutos", con)
            da = New SqlDataAdapter("pa_Vendas_Listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dg.DataSource = dt

            ' ContarLinhas()
            ' FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub


    Private Sub ListaGeral()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_Vendas_Listar", con)
            ' da = New SqlDataAdapter("pa_Vendas_Lista_Geral", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            ' da.SelectCommand.Parameters.AddWithValue("@data", Now.ToShortDateString)
            '  da.SelectCommand.Parameters.AddWithValue("@funcionario", usuarioNome)

            da.Fill(dt)
            dg.DataSource = dt



        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub


    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        atualizarValor()
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim quant_vendida As Decimal
        Dim TotQuantidade As Decimal
        Dim Totestoque As Decimal

        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        Totestoque = estoque - quantidade

        'quant_vendida = txtQuantVendida.Text
        'TotQuantidade = quant_vendida + quantidade

        If txtNum.Text <> "" Then
            '   If txtNum.Text <> "" And Totestoque >= 0 Then

            Try
                Dim total As Decimal
                Dim valor As Decimal
                Dim quant As Decimal

                valor = txtValorUnitario.Text
                quant = txtQuantidade.Text

                total = valor * quant

                abrir()

                cmd = New SqlCommand("pa_Vendas_salvarSemCliente", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@num_vendas", txtNum.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_venda", Now.Date())
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                atualizarValor()
                Listar()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        Else
            MsgBox("A quantidade em estoque é insulficiente!!")



        End If
    End Sub


    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnExcluir.Enabled = True
        btRel.Enabled = True
        btnSalvar.Enabled = True
        cbProduto.Enabled = True

        lblCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNum.Text = dg.CurrentRow.Cells(1).Value
        cbProduto.Text = dg.CurrentRow.Cells(2).Value

        txtQuantidade.Text = dg.CurrentRow.Cells(5).Value
    End Sub
End Class