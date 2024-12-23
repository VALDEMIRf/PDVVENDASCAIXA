﻿Imports System.Data.SqlClient
Imports System.IO

Public Class frmVendas
    Private Sub frmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        btnSalvar.Enabled = False
        CarregarClientes()
        ' Listar()

        txtCodBarras.Focus()
        btnExcluir.Enabled = False
        btRel.Enabled = False
        totalizar()
    End Sub
    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            'da = New SqlDataAdapter("pa_Vendas_Listar", con)
            da = New SqlDataAdapter("pa_Vendas_Lista_Geral", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@data", Now.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@funcionario", usuarioNome)

            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()

        With dg
            .Columns(0).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(3).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False

            .Columns(1).HeaderText = "Núm. Venda"
            .Columns(2).HeaderText = "Produto"
            '  .Columns(3).HeaderText = "Cliente"
            .Columns(4).HeaderText = "Valor Unit."
            .Columns(5).HeaderText = "Quant."
            .Columns(6).HeaderText = "Valor Total"
            ' .Columns(7).HeaderText = "Funcionário"
            ' .Columns(8).HeaderText = "Dt. Venda"

            '.Columns(1).Width = 70
            '.Columns(2).Width = 180
            '.Columns(3).Width = 130
            .Columns(4).Width = 70
            .Columns(5).Width = 50
            .Columns(6).Width = 70
            '.Columns(7).Width = 150
        End With

    End Sub

    Private Sub DesabilitarCampos()
        '    txtNum.Enabled = False
        '    txtQuantidade.Enabled = False
        '    cbCliente.Enabled = False
        '    cbProduto.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtNum.Enabled = True
        txtQuantidade.Enabled = True
        cbCliente.Enabled = True
        cbProduto.Enabled = True

    End Sub

    Private Sub Limpar()
        txtCodBarras.Focus()
        txtNum.Text = ""
        txtQuantidade.Text = "1"
        txtBuscar.Text = ""
        btRel.Enabled = False
        txtCodBarras.Text = ""
        pbImagem.Image = Nothing
        lblTotalUnit.Text = " "
        lblTotal.Text = ""
        txtDesconto.Text = ""
        lblTotalFinal.Text = ""
        txtValorRecebido.Text = ""
        lblTroco.Text = ""

        txtCodBarras.Text = ""

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

    Sub CarregarClientes()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_cliente_listar", con)

            DA.Fill(DT)
            cbCliente.DisplayMember = "nome"
            cbCliente.ValueMember = "id_cliente"
            cbCliente.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True
        cbCliente.Text = "CONSUMIDOR"
        CarregarProdutos()
        gerarnum()
        calcularTotal()
    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        atualizarValor()
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

            Dim quant As Int32 = cmd.Parameters("@quant").Value
            txtEstoque.Text = CStr(quant)

            Dim valor1 As Double = cmd.Parameters("@valor_venda").Value
            txtValorVenda.Text = CDbl(valor1)

            Dim quant_vendida As Int32 = cmd.Parameters("@quant_vendida").Value
            txtQuantVendida.Text = CStr(quant_vendida)

            '======================================================================================================
            '======================================================================================================


            'Dim cmd2 As New SqlCommand("select imagem from tbProdutos where id_produto = @id_produto", con)

            'cmd2.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            'cmd2.ExecuteNonQuery()

            'Dim tempImagem As Byte() = DirectCast(cmd2.ExecuteScalar, Byte())

            da = New SqlDataAdapter("pa_produto_BuscaFoto", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)


            Dim tempImagem As Byte() = DirectCast(da.SelectCommand.ExecuteScalar, Byte())

            If tempImagem Is Nothing Then
                MessageBox.Show("Imagem não localizada", "Erro")
                Exit Sub
            End If
            Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
            Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
            fs.Write(tempImagem, 0, tempImagem.Length)
            fs.Flush()
            fs.Close()

            pbImagem.Image = Image.FromFile(strArquivo)


            Dim cod_barras As String = cmd.Parameters("@codigo_barras").Value
            ' txtCodBarras.Text = cod_barras

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub botaoSalvar()
        Dim cmd As SqlCommand

        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim quant_vendida As Decimal
        Dim TotQuantidade As Decimal
        Dim Totestoque As Decimal

        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        Totestoque = estoque - quantidade

        quant_vendida = txtQuantVendida.Text
        TotQuantidade = quant_vendida + quantidade

        If txtNum.Text <> "" And Totestoque >= 0 Then

            Try

                Dim total As Decimal
                Dim valor As Decimal
                Dim quant As Decimal

                valor = txtValorVenda.Text
                quant = txtQuantidade.Text

                total = valor * quant

                abrir()

                'ABATENDO QUANTIDADE EM ESTOQUE
                cmd = New SqlCommand("pa_produto_EditarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                '=======================================================================================================================
                '=======================================================================================================================

                'ACRESCENTAR QUANTIDADE DE PRODUTOS VENDIDOS
                cmd = New SqlCommand("pa_produto_EditarQuantidadeVendida", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quant_vendida", TotQuantidade)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                '=======================================================================================================================
                '=======================================================================================================================

                'SALVAR SAÍDA NA TABELA ESTOQUE
                cmd = New SqlCommand("pa_estoque_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", "Saída")
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@motivo", "Venda")
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                '=======================================================================================================================
                '=======================================================================================================================

                cmd = New SqlCommand("pa_Vendas_salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@num_vendas", txtNum.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_venda", Now.Date())
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString

                atualizarValor()

                BuscarVenda()
                FormatarDG()
                totalizar()

                cbCliente.Enabled = False
                txtNum.Enabled = False
                txtQuantidade.Text = "0"

                btRel.Enabled = True

                txtCodBarras.Text = ""
                txtCodBarras.Focus()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        Else
            MsgBox("A quantidade em estoque é insulficiente!!")
        End If
    End Sub



    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        'botaoSalvar()
        Dim cmd As SqlCommand

        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim quant_vendida As Decimal
        Dim TotQuantidade As Decimal
        Dim Totestoque As Decimal

        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        Totestoque = estoque - quantidade

        quant_vendida = txtQuantVendida.Text
        TotQuantidade = quant_vendida + quantidade

        If txtNum.Text <> "" And Totestoque >= 0 Then

            Try

                Dim total As Decimal
                Dim valor As Decimal
                Dim quant As Decimal

                valor = txtValorVenda.Text
                quant = txtQuantidade.Text

                total = valor * quant

                abrir()

                'ABATENDO QUANTIDADE EM ESTOQUE
                cmd = New SqlCommand("pa_produto_EditarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                '=======================================================================================================================
                '=======================================================================================================================

                'ACRESCENTAR QUANTIDADE DE PRODUTOS VENDIDOS
                cmd = New SqlCommand("pa_produto_EditarQuantidadeVendida", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quant_vendida", TotQuantidade)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                '=======================================================================================================================
                '=======================================================================================================================

                'SALVAR SAÍDA NA TABELA ESTOQUE
                cmd = New SqlCommand("pa_estoque_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", "Saída")
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@motivo", "Venda")
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                '=======================================================================================================================
                '=======================================================================================================================

                cmd = New SqlCommand("pa_Vendas_salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@num_vendas", txtNum.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_venda", Now.Date())
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString

                atualizarValor()

                BuscarVenda()
                FormatarDG()
                totalizar()

                cbCliente.Enabled = False
                txtNum.Enabled = False
                txtQuantidade.Text = "0"

                btRel.Enabled = True

                txtCodBarras.Text = ""
                txtCodBarras.Focus()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        Else
            MsgBox("A quantidade em estoque é insulficiente!!")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        Dim cmd As SqlCommand


        If txtNum.Text <> "" Then

            Try
                Dim total As Decimal
                Dim valor As Decimal
                Dim quant As Decimal

                valor = txtValorVenda.Text
                quant = txtQuantidade.Text

                total = valor * quant

                'CARREGANDO IMAGEM NO BANCO
                'Dim MS As New IO.MemoryStream
                'ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                'Dim byteArray = MS.ToArray

                abrir()
                cmd = New SqlCommand("pa_Vendas_editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_vendas", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@num_vendas", txtNum.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)


                'cmd.Parameters.AddWithValue("@imagem", byteArray)
                'cmd.Parameters.AddWithValue("@nivel_minimo", txtNivel.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()
                totalizar()
            Catch ex As Exception
                MessageBox.Show("Erro ao Editar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim quant_vendida As Decimal
        Dim TotQuantidade As Decimal
        Dim Totestoque As Decimal

        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        Totestoque = estoque + quantidade


        quant_vendida = txtQuantVendida.Text
        TotQuantidade = quant_vendida - quantidade

        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Produto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()

                'DEVOLVENDO QUANTIDADE NO ESTOQUE

                cmd = New SqlCommand("pa_estoque_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", "Entrada")
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@motivo", "Cancelamento")
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()


                '=======================================================================================================================
                '=======================================================================================================================


                cmd = New SqlCommand("pa_produto_EditarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()


                '=======================================================================================================================
                '=======================================================================================================================

                'ACRESCENTAR QUANTIDADE DE PRODUTOS VENDIDOS
                cmd = New SqlCommand("pa_produto_EditarQuantidadeVendida", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quant_vendida", TotQuantidade)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                '=======================================================================================================================
                '=======================================================================================================================


                cmd = New SqlCommand("pa_Vendas_excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_vendas", txtCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()
                totalizar()
                atualizarValor()

                btnExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao excluir o Produto" + ex.Message.ToString)
                fechar()
            End Try
        End If

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick

        btnExcluir.Enabled = True
        btRel.Enabled = True
        btnSalvar.Enabled = True
        cbProduto.Enabled = True

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNum.Text = dg.CurrentRow.Cells(1).Value
        cbProduto.Text = dg.CurrentRow.Cells(2).Value
        cbCliente.Text = dg.CurrentRow.Cells(3).Value
        txtQuantidade.Text = dg.CurrentRow.Cells(5).Value

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_Vendas_buscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@num_vendas", txtBuscar.Text)
                ' da.SelectCommand.Parameters.AddWithValue("@codigo_barras", txtBuscar.Text)

                da.Fill(dt)
                dg.DataSource = dt

                totalizar()
            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub totalizar()
        Dim total As Decimal
        For Each lin As DataGridViewRow In dg.Rows
            total = total + lin.Cells(6).Value
        Next

        lblTotal.Text = total

    End Sub

    Private Sub BuscarVenda()
        If txtNum.Text = "" Then

            Listar()
            totalizar()
        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_Vendas_buscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@num_vendas", txtNum.Text)
                ' da.SelectCommand.Parameters.AddWithValue("@codigo_barras", txtBuscar.Text)

                da.Fill(dt)
                dg.DataSource = dt

                totalizar()
            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub gerarnum()
        Dim cmd As New SqlCommand("pa_Vendas_buscarNum", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.Add("@num_vendas", SqlDbType.Int).Direction = 2

            cmd.ExecuteNonQuery()

            Dim num As Integer = cmd.Parameters("@num_vendas").Value

            Dim numAleatorio As Random = New Random()
            Dim valorInteiro As Integer = numAleatorio.Next(10000000)
            Dim num_final As Integer
            num_final = num + 1

            Dim num_pers As String
            num_pers = num_final.ToString + valorInteiro

            ' txtNum.Text = valorInteiro.ToString()
            txtNum.Text = CStr(num_pers)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            fechar()
        End Try


    End Sub

    Private Sub btRel_Click(sender As Object, e As EventArgs) Handles btRel.Click

        Dim decisao As Integer = MsgBox("Deseja imprimir o comprovante?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel)

        If decisao = 1 Then

            imprimirComprovante()
        Else
            Limpar()
        End If
    End Sub

    Sub imprimirComprovante()
        If txtNum.Text = "" Then
            MsgBox("Selecione uma venda na tabela!!!")
            Exit Sub
        End If

        Dim num As String
        num = txtNum.Text

        Dim subTotal As String
        Dim desconto As String
        Dim totalCompra As String
        Dim valorRecebido As String
        Dim troco As String


        subTotal = lblTotal.Text
        desconto = txtDesconto.Text
        totalCompra = lblTotalFinal.Text
        valorRecebido = txtValorRecebido.Text
        troco = lblTroco.Text

        Dim form = New frmRelComprovante(num, subTotal, desconto, totalCompra, valorRecebido, troco)
        form.ShowDialog()
    End Sub

    Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
        If e.Control = True And e.KeyCode = Keys.NumPad1 Then

            txtCodBarras.Text = ""
        End If
        If e.Control = True And e.KeyCode = Keys.NumPad2 Then

            atualizarValorCod()
        End If
    End Sub

    Private Sub atualizarValorCod()
        Dim cmd As New SqlCommand("pa_Vendas_buscarCodBarras", con)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo_barras", txtCodBarras.Text)
            cmd.Parameters.Add("@id_produto", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Direction = 2
            cmd.ExecuteNonQuery()

            Dim id_produto As Int32 = cmd.Parameters("@id_produto").Value
            cbProduto.SelectedValue = id_produto

            Dim nomeProd As String = cmd.Parameters("@nome").Value

            My.Computer.Audio.Play(My.Resources.barCode, AudioPlayMode.WaitToComplete)

        Catch ex As Exception
            'MsgBox("Produto não Encontrado")
        End Try
        fechar()
    End Sub

    Private Sub txtCodBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodBarras.TextChanged
        atualizarValorCod()
    End Sub

    Private Sub txtValorRecebido_TextChanged(sender As Object, e As EventArgs) Handles txtValorRecebido.TextChanged
        If txtDesconto.Text = "" Then
            MsgBox("Digite um valor a partir de 0")
            txtDesconto.Focus()
        End If

        If lblTotalFinal.Text <> "0" And txtValorRecebido.Text <> "" Then
            Dim totalFinal As Decimal
            Dim valorPago As Decimal
            Dim total As Decimal
            totalFinal = lblTotalFinal.Text
            valorPago = txtValorRecebido.Text
            total = valorPago - totalFinal
            lblTroco.Text = total

        End If


    End Sub

    Private Sub txtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged
        If txtQuantidade.Text = "" Then
            MsgBox("Digite um valor numérico a partir de 1")
        Else
            calcularTotal()
        End If

    End Sub

    Sub calcularTotal()
        If txtQuantidade.Text <> "0" And txtValorVenda.Text <> "" Then
            Dim valor As Double
            Dim quant As Decimal
            Dim total As Decimal
            valor = txtValorVenda.Text
            quant = txtQuantidade.Text
            total = valor * quant
            lblTotalUnit.Text = total
        Else
            txtQuantidade.Text = "1"
        End If

        ' botaoSalvar()
    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        If lblTotal.Text <> "0" And txtDesconto.Text <> "" Then
            Dim subTotal As Decimal
            Dim desc As Decimal
            Dim total As Decimal
            subTotal = lblTotal.Text
            desc = txtDesconto.Text
            total = subTotal - desc
            lblTotalFinal.Text = total
        End If
    End Sub

    Private Sub frmVendas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btnNovo.PerformClick()
            Case Keys.F2
                btnSalvar.PerformClick()
            'Case Keys.F3
            '    btnEditar.PerformClick()
            'Case Keys.F4
            '    btnExcluir.PerformClick()
            'Case Keys.F5
            '    btBuscarCNPJ.PerformClick()
            'Case Keys.F6
            '    btNovoPJ.PerformClick()
            'Case Keys.F7
            '    btSalvarPJ.PerformClick()
            'Case Keys.F8
            '    btEscluirPJ.PerformClick()

            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    Private Sub txtQuantidade_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuantidade.KeyDown
        'If e.KeyCode = Keys.NumPad1 Then
        ' botaoSalvar()
        '    txtCodBarras.Text = ""
        'End If
    End Sub

    Private Sub txtQuantidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantidade.KeyPress
        permiteSoNumeros(sender, e)
    End Sub
End Class