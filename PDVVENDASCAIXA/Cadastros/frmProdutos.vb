Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text.pdf

Public Class frmProdutos

    Private ImagemCarregada As Image
    Private _create As Net.HttpWebRequest

    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        btnSalvar.Enabled = False

        CarregarFornecedor()
        CarregarCategoriaProdutos()
        CarregarUnidadesMedidas()

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
            da = New SqlDataAdapter("pa_produtoListar", con)
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
        txtQuantidade.Enabled = False
        txtValor.Enabled = False
        txtValorCompra.Enabled = False
        txtNivel.Enabled = False
        cbFornecedor.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtDescricao.Enabled = True
        'txtQuantidade.Enabled = True
        txtValor.Enabled = True
        txtValorCompra.Enabled = True
        txtNivel.Enabled = True
        cbFornecedor.Enabled = True
        cbCategoria.Enabled = True
        cbUnidade.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNome.Focus()
        txtNome.Text = ""
        txtDescricao.Text = ""
        txtQuantidade.Text = "0"
        txtValor.Text = ""
        txtValorCompra.Text = ""
        txtBuscar.Text = ""
        txtNivel.Text = "0"
        cbCategoria.Text = " "
        cbFornecedor.Text = Nothing
        cbUnidade.Text = Nothing
        cbCategoria.Text = Nothing
        txtCodBarras.Text = ""
        imgCodBar.Image = Nothing
        '  carregarImagem()

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(15).Visible = False
        dg.Columns(16).Visible = False
        dg.Columns(17).Visible = False
        dg.Columns(18).Visible = False
        dg.Columns(19).Visible = False
        dg.Columns(20).Visible = False

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Descrição"
        dg.Columns(3).HeaderText = "Categoria"
        dg.Columns(4).HeaderText = "Unidade"
        dg.Columns(5).HeaderText = "Quant."
        dg.Columns(6).HeaderText = "Vlr de Compra"
        dg.Columns(7).HeaderText = "Vlr de Venda"
        dg.Columns(8).HeaderText = "Dt Cadastro"
        'dg.Columns(9).HeaderText = "Imagem"
        dg.Columns(10).HeaderText = "Nível Mínimo"
        dg.Columns(11).HeaderText = "Quant. Vendida"
        dg.Columns(12).HeaderText = "Código de Barras"
        dg.Columns(13).HeaderText = "Razão Social"
        dg.Columns(14).HeaderText = "Fantasia"
        'dg.Columns(15).HeaderText = "id_fornecedor"
        'dg.Columns(16).HeaderText = "id_fornecedor"
        'dg.Columns(17).HeaderText = "id_categoria"
        'dg.Columns(18).HeaderText = "id_unidade"
        'dg.Columns(19).HeaderText = "id_categoria"
        'dg.Columns(20).HeaderText = "id_unidade"

        dg.Columns(2).Width = 180
        dg.Columns(1).Width = 120
        dg.Columns(3).Width = 90
        dg.Columns(4).Width = 80
        dg.Columns(5).Width = 50
        dg.Columns(6).Width = 60
        dg.Columns(7).Width = 60
        dg.Columns(8).Width = 80
        dg.Columns(10).Width = 55
        dg.Columns(11).Width = 70
        dg.Columns(12).Width = 100
        dg.Columns(13).Width = 190

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub




End Class