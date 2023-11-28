﻿Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text.pdf

Public Class frmProdutos

    Private ImagemCarregada As Image
    Private _create As Net.HttpWebRequest

    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarFornecedor()
        CarregarCategoriaProdutos()
        CarregarUnidadesMedidas()

        DesabilitarCampos()
        btnSalvar.Enabled = False

        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Sub CarregarFornecedor()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_fornecedor_listar", con)
            DA.Fill(DT)
            cbFornecedor.DisplayMember = "razaoSocial"
            cbFornecedor.ValueMember = "id_fornecedor"
            cbFornecedor.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarCategoriaProdutos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_categoriaProdutos_listar", con)
            DA.Fill(DT)
            cbCategoria.DisplayMember = "categoria"
            cbCategoria.ValueMember = "id_categoria"
            cbCategoria.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarUnidadesMedidas()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_unidadeMedida_listar", con)
            DA.Fill(DT)
            cbUnidade.DisplayMember = "unidadeMedida"
            cbUnidade.ValueMember = "id_unidade"
            cbUnidade.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
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
            da = New SqlDataAdapter("pa_produto_Listar", con)
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()
            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtDescricao.Enabled = False
        cbFornecedor.Enabled = False
        cbCategoria.Enabled = False
        cbUnidade.Enabled = False
        txtQuantidade.Enabled = False
        txtValorCompra.Enabled = False
        txtValorVenda.Enabled = False

        txtNivel.Enabled = False


    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtDescricao.Enabled = True
        cbFornecedor.Enabled = True
        cbCategoria.Enabled = True
        cbUnidade.Enabled = True
        txtQuantidade.Enabled = True
        txtValorCompra.Enabled = True
        txtValorVenda.Enabled = True

        txtNivel.Enabled = True

    End Sub

    Private Sub Limpar()
        txtNome.Focus()
        txtNome.Text = ""
        txtDescricao.Text = ""
        txtQuantidade.Text = "0"
        txtValorVenda.Text = ""
        txtValorCompra.Text = ""
        txtBuscar.Text = ""
        txtNivel.Text = "0"
        cbFornecedor.Text = Nothing
        cbUnidade.Text = Nothing
        cbCategoria.Text = Nothing
        'txtCodBarras.Text = ""
        'imgCodBar.Image = Nothing
        '  carregarImagem()

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        'dg.Columns(9).Visible = False
        'dg.Columns(15).Visible = False
        'dg.Columns(16).Visible = False
        'dg.Columns(17).Visible = False
        'dg.Columns(18).Visible = False
        'dg.Columns(19).Visible = False
        'dg.Columns(20).Visible = False

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Descrição"
        dg.Columns(3).HeaderText = "Razão Social"
        dg.Columns(4).HeaderText = "Categoria"
        dg.Columns(5).HeaderText = "Unidade"
        dg.Columns(6).HeaderText = "Quant."
        dg.Columns(7).HeaderText = "Vlr de Compra"
        dg.Columns(8).HeaderText = "Vlr de Venda"
        dg.Columns(9).HeaderText = "Dt Cadastro"
        'dg.Columns(10).HeaderText = "id_fornecedor"
        'dg.Columns(11).HeaderText = "id_categoria"
        'dg.Columns(12).HeaderText = "id_unidade"

        dg.Columns(2).Width = 180
        dg.Columns(1).Width = 120
        dg.Columns(3).Width = 260
        dg.Columns(4).Width = 160
        dg.Columns(5).Width = 90
        dg.Columns(6).Width = 70
        dg.Columns(7).Width = 100
        dg.Columns(8).Width = 100
        dg.Columns(9).Width = 80
        'dg.Columns(11).Width = 70
        'dg.Columns(12).Width = 100
        'dg.Columns(13).Width = 190

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        'If txtNome.Text <> "" Then
        '    If pbImagem.Image.Equals(Nothing) Then
        '        errErro.SetError(pbImagem, "Escolha uma imagem")
        '        Exit Sub
        '    Else
        '        'MessageBox.Show("certo")
        '    End If

        Try

            'CARREGANDO IMAGEM NO BANCO
            'Dim MS As New IO.MemoryStream
            'ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
            'Dim byteArray = MS.ToArray

            Dim vlcompra = Replace(txtValorCompra.Text, ",", ".")
                Dim vlVenda = Replace(txtValorVenda.Text, ",", ".")

                abrir()
                cmd = New SqlCommand("pa_produto_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@id_fornecedor", cbFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@id_categoria", cbCategoria.SelectedValue)
                cmd.Parameters.AddWithValue("@id_unidade", cbUnidade.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor_compra", vlcompra)
                cmd.Parameters.AddWithValue("@valor_venda", vlVenda)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.Date())
                'cmd.Parameters.AddWithValue("@imagem", byteArray)
                'cmd.Parameters.AddWithValue("@nivel_minimo", txtNivel.Text)

                ' cmd.Parameters.AddWithValue("@quant_vendida", 0)
                ' cmd.Parameters.AddWithValue("@codigo_barras", txtCodBarras.Text)


                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                ' PrintPreviewDialog1.Show()
                Listar()
                Limpar()

                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        'End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim cmd As SqlCommand

        Dim vlcompra = Replace(txtValorCompra.Text, ",", ".")
        Dim vlVenda = Replace(txtValorVenda.Text, ",", ".")

        If txtNome.Text <> "" Then

            Try

                'CARREGANDO IMAGEM NO BANCO
                'Dim MS As New IO.MemoryStream
                'ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                'Dim byteArray = MS.ToArray

                abrir()
                cmd = New SqlCommand("pa_produto_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_produto", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@id_fornecedor", cbFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@id_categoria", cbCategoria.SelectedValue)
                cmd.Parameters.AddWithValue("@id_unidade", cbUnidade.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor_compra", vlcompra)
                cmd.Parameters.AddWithValue("@valor_venda", vlVenda)

                'cmd.Parameters.AddWithValue("@imagem", byteArray)
                'cmd.Parameters.AddWithValue("@nivel_minimo", txtNivel.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao Editar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Produto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_produto_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_produto", txtCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False

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
        Cadastro.Show()
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnSalvar.Enabled = False

        txtValorCompra.Visible = True
        txtValorVenda.Visible = True

        HabilitarCampos()

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNome.Text = dg.CurrentRow.Cells(1).Value
        txtDescricao.Text = dg.CurrentRow.Cells(2).Value
        cbFornecedor.Text = dg.CurrentRow.Cells(3).Value
        cbCategoria.Text = dg.CurrentRow.Cells(4).Value
        cbUnidade.Text = dg.CurrentRow.Cells(5).Value
        txtQuantidade.Text = dg.CurrentRow.Cells(6).Value
        txtValorCompra.Text = CInt(dg.CurrentRow.Cells(7).Value) '.ToString("R$ #,###.00")
        txtValorVenda.Text = CInt(dg.CurrentRow.Cells(8).Value) '.ToString("R$ #,###.00")
        ' txtNivel.Text = CInt(dg.CurrentRow.Cells(10).Value)


        '  txtCodBarras.Text = dg.CurrentRow.Cells(12).Value

        'CriarCodigoBarras()

        'Dim tempImagem As Byte() = DirectCast(dg.CurrentRow.Cells(9).Value, Byte())
        'If tempImagem Is Nothing Then
        '    MessageBox.Show("Imagem não localizada", "Erro")
        '    Exit Sub
        'End If
        'Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
        'Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
        'fs.Write(tempImagem, 0, tempImagem.Length)
        'fs.Flush()
        'fs.Close()
        'ImagemCarregada = Image.FromFile(strArquivo)
        'pbImagem.Image = ImagemCarregada
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_produto_BuscarNome", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscar.Text)
                ' da.SelectCommand.Parameters.AddWithValue("@codigo_barras", txtBuscar.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub
End Class