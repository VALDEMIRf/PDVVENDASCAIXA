Imports System.Data.SqlClient
Imports System.IO

Public Class frmEstoque

    Dim id_produto As Integer

    Sub New(id_produto As Integer)

        InitializeComponent()
        Me.id_produto = id_produto



    End Sub

    Private Sub frmEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarProdutosBuscar()
        cbBuscar.Text = ""
        txtBuscarProd.Text = ""

        DesabilitarCampos()
        btnSalvar.Enabled = False

        CarregarProdutos()

        If id_produto > 0 Then
            cbProduto.SelectedValue = id_produto
            txtQuantidade.Enabled = True
            btnSalvar.Enabled = True

        End If

        Listar()

        btnExcluir.Enabled = False

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

            FormatarDG()
            'CarregarProdutosBuscar()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(8).Visible = False

        dg.Columns(1).HeaderText = "Produto"
        dg.Columns(2).HeaderText = "Descrição"
        dg.Columns(3).HeaderText = "Quantidade"
        dg.Columns(4).HeaderText = "Data"
        dg.Columns(5).HeaderText = "Funcionário"
        dg.Columns(6).HeaderText = "Motivo"

        dg.Columns(1).Width = 180
        dg.Columns(2).Width = 180
        'dg.Columns(3).Width = 130
        'dg.Columns(4).Width = 90
        'dg.Columns(5).Width = 90
        dg.Columns(6).Width = 150
        'dg.Columns(7).Width = 150

    End Sub

    Private Sub DesabilitarCampos()
        cbDescricao.Enabled = False
        txtQuantidade.Enabled = False
        cbProduto.Enabled = False


    End Sub

    Private Sub HabilitarCampos()
        cbDescricao.Enabled = True
        txtQuantidade.Enabled = True
        cbProduto.Enabled = True


    End Sub

    Private Sub Limpar()

        txtQuantidade.Text = ""
        cbBuscar.Text = ""
        txtBuscarProd.Text = ""
        cbDescricao.Text = "Entrada"

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

    Sub CarregarProdutosBuscar()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbProdutos", con) '
            DA = New SqlDataAdapter("pa_produto_Lista", con)
            DA.Fill(DT)
            cbBuscar.DisplayMember = "nome"
            cbBuscar.ValueMember = "id_produto"
            cbBuscar.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True
        lblMotivo.Visible = False
        txtMotivo.Visible = False
    End Sub

    Private Sub cbDescricao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDescricao.SelectedIndexChanged
        If cbDescricao.Text = "Saída" Then
            lblMotivo.Visible = True
            txtMotivo.Visible = True

            '    lblMotivo.Visible = False
            '    txtMotivo.Visible = False

        End If
    End Sub


    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtQuantidade.Text <> "" Then
            '    If pbImagem.Image.Equals(Nothing) Then
            '        errErro.SetError(pbImagem, "Escolha uma imagem")
            '        Exit Sub
            '    Else
            '        'MessageBox.Show("certo")
            '    End If

            Try

                'quant_vendida = txtQuantVendida.Text
                'TotQuantidade = quant_vendida + quantidade

                abrir()

                'ABATENDO QUANTIDADE EM ESTOQUE
                Dim quantidade As Decimal
                Dim estoque As Decimal
                '  Dim quant_vendida As Decimal
                '  Dim TotQuantidade As Decimal
                Dim Totestoque As Decimal

                quantidade = txtQuantidade.Text
                estoque = txtEstoque.Text

                If cbDescricao.Text = "Saída" Then
                    Totestoque = estoque - quantidade
                Else
                    Totestoque = estoque + quantidade
                End If

                cmd = New SqlCommand("pa_produto_EditarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                '=======================================================================================================================

                cmd = New SqlCommand("pa_estoque_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", cbDescricao.Text)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)

                If cbDescricao.Text = "Entrada" Then

                    cmd.Parameters.AddWithValue("@motivo", "Compra")

                Else
                    cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text)
                End If
                'cmd.Parameters.AddWithValue("@imagem", byteArray)
                'cmd.Parameters.AddWithValue("@nivel_minimo", txtNivel.Text)

                ' cmd.Parameters.AddWithValue("@quant_vendida", 0)
                ' cmd.Parameters.AddWithValue("@codigo_barras", txtCodBarras.Text)+


                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                ' PrintPreviewDialog1.Show()
                Listar()
                atualizarValor()
                Limpar()
                DesabilitarCampos()

                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        Else
            MsgBox("Preencha a quantidade em estoque!!")
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click


        Dim cmd As SqlCommand

        If lblCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Produto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()

                'DEVOLVENDO QUANTIDADE NO ESTOQUE

                'ABATENDO QUANTIDADE EM ESTOQUE
                Dim quantidade As Decimal
                Dim estoque As Decimal
                '  Dim quant_vendida As Decimal
                '  Dim TotQuantidade As Decimal
                Dim Totestoque As Decimal

                quantidade = txtQuantidade.Text
                estoque = txtEstoque.Text

                If cbDescricao.Text = "Saída" Then
                    Totestoque = estoque + quantidade
                Else
                    Totestoque = estoque - quantidade
                End If

                cmd = New SqlCommand("pa_produto_EditarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)

                cmd.ExecuteNonQuery()

                '=======================================================================================================================

                cmd = New SqlCommand("pa_estoque_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_estoque", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                atualizarValor()

                btnExcluir.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir o Produto" + ex.Message)
            Finally
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
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

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnExcluir.Enabled = True
        HabilitarCampos()
        atualizarValor()
        lblMotivo.Visible = True
        txtMotivo.Visible = True

        lblCodigo.Text = dg.CurrentRow.Cells(0).Value
        cbProduto.Text = dg.CurrentRow.Cells(1).Value
        ' cbProduto.SelectedValue = dg.CurrentRow.Cells(7).Value
        cbDescricao.Text = dg.CurrentRow.Cells(2).Value
        txtQuantidade.Text = dg.CurrentRow.Cells(3).Value
        txtMotivo.Text = dg.CurrentRow.Cells(6).Value

    End Sub

    Private Sub cbBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBuscar.SelectedIndexChanged
        If cbBuscar.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_estoque_Buscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_produto", cbBuscar.SelectedValue)

                da.Fill(dt)
                dg.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscarProd_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProd.TextChanged
        If txtBuscarProd.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_estoque_Nomebuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscarProd.Text)

                da.Fill(dt)
                dg.DataSource = dt



            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub


End Class