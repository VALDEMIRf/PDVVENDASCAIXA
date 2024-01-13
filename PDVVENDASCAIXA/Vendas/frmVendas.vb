Imports System.Data.SqlClient
Imports System.IO

Public Class frmVendas
    Private Sub frmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        btnSalvar.Enabled = False

        CarregarProdutos()
        CarregarClientes()

        Listar()


        btnExcluir.Enabled = False
        btRel.Enabled = False
        totalizar()
    End Sub
    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            '  da = New SqlDataAdapter("SELECT ven.id_vendas, ven.num_vendas, pro.nome,cli.nome,pro.valor_venda,ven.quantidade,ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM tbVendas as ven INNER JOIN tbProdutos as pro on ven.id_produto=pro.id_produto INNER JOIN tbClientes  as cli on ven.id_cliente = cli.id_cliente", con)
            da = New SqlDataAdapter("pa_Vendas_Listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            ' da.SelectCommand.Parameters.AddWithValue("@num_vendas", txtBuscar.Text)

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
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(10).Visible = False

        dg.Columns(1).HeaderText = "Núm. Venda"
        dg.Columns(2).HeaderText = "Produto"
        dg.Columns(3).HeaderText = "Cliente"
        dg.Columns(4).HeaderText = "Valor Unit."
        dg.Columns(5).HeaderText = "Quantidade"
        dg.Columns(6).HeaderText = "Valor Total"
        dg.Columns(7).HeaderText = "Funcionário"
        dg.Columns(8).HeaderText = "Dt. Venda"

        dg.Columns(1).Width = 70
        dg.Columns(2).Width = 180
        dg.Columns(3).Width = 130
        dg.Columns(4).Width = 90
        dg.Columns(5).Width = 90
        dg.Columns(6).Width = 70
        dg.Columns(7).Width = 150

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
        txtNum.Focus()
        txtNum.Text = ""
        txtQuantidade.Text = "0"
        txtBuscar.Text = ""
        btRel.Enabled = False
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
        gerarnum()
    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        atualizarValor()
    End Sub

    Private Sub atualizarValor()
        Dim cmd As New SqlCommand("pa_Vendas_buscarValorProd", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            cmd.Parameters.Add("@quant", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@valor_venda", SqlDbType.Float).Direction = 2
            cmd.Parameters.Add("@quant_vendida", SqlDbType.Int).Direction = 2
            'cmd.Parameters.Add("@codigo_barras", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim quant As Int32 = cmd.Parameters("@quant").Value
            txtEstoque.Text = CStr(quant)

            Dim valor1 As Double = cmd.Parameters("@valor_venda").Value
            txtValorVenda.Text = CDbl(valor1)

            Dim quant_vendida As Int32 = cmd.Parameters("@quant_vendida").Value
            txtQuantVendida.Text = CStr(quant_vendida)

            '' ----------------------------------------------------------------------------

            'Dim cmd2 As New SqlCommand("pa_produtoBuscaFoto", con)
            Dim cmd2 As New SqlCommand("select imagem from tbProdutos where id_produto = @id_produto", con)

            cmd2.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            cmd2.ExecuteNonQuery()

            Dim tempImagem As Byte() = DirectCast(cmd2.ExecuteScalar, Byte())
            '  Dim tempImagem As Byte() = DirectCast(cmd.Parameters("@imagem").Value, Byte())
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

            'Dim cod_barras As String = cmd.Parameters("@codigo_barras").Value
            'txtCodBarras.Text = cod_barras

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try
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


        quant_vendida = txtQuantVendida.Text
        TotQuantidade = quant_vendida + quantidade

        If txtNum.Text <> "" And Totestoque >= 0 Then
            '    If pbImagem.Image.Equals(Nothing) Then
            '        errErro.SetError(pbImagem, "Escolha uma imagem")
            '        Exit Sub
            '    Else
            '        'MessageBox.Show("certo")
            '    End If

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
                'cmd.Parameters.AddWithValue("@imagem", byteArray)
                'cmd.Parameters.AddWithValue("@nivel_minimo", txtNivel.Text)

                ' cmd.Parameters.AddWithValue("@quant_vendida", 0)
                ' cmd.Parameters.AddWithValue("@codigo_barras", txtCodBarras.Text)+


                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)


                atualizarValor()
                ' PrintPreviewDialog1.Show()
                'Listar()
                BuscarVenda()

                totalizar()

                cbCliente.Enabled = False
                txtNum.Enabled = False
                txtQuantidade.Text = ""

                btRel.Enabled = True

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
                MessageBox.Show("Erro ao excluir o Produto" + ex.Message)
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

        '  HabilitarCampos()

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNum.Text = dg.CurrentRow.Cells(1).Value
        cbProduto.Text = dg.CurrentRow.Cells(2).Value
        cbCliente.Text = dg.CurrentRow.Cells(3).Value
        txtQuantidade.Text = dg.CurrentRow.Cells(5).Value
        ' txtValorVenda.Text = dg.CurrentRow.Cells(5).Value
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
        Dim cmd As New SqlCommand("pa_Vendas_buscarNum", con)  'pa_VendaSbuscarNumero
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.Add("@num_vendas", SqlDbType.Int).Direction = 2

            cmd.ExecuteNonQuery()

            Dim num As Integer = cmd.Parameters("@num_vendas").Value

            ' Dim hora As String = Now.Second
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
        If txtNum.Text = "" Then
            MsgBox("Selecione uma venda na tabela!!!")
            Exit Sub
        End If

        Dim num As String
        num = txtNum.Text
        Dim form = New frmRelComprovante(num)
        form.ShowDialog()
    End Sub

End Class