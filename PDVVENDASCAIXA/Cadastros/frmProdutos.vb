Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text.pdf

Public Class frmProdutos

    Private ImagemCarregada As Image
    Private _create As Net.HttpWebRequest

    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarImagem()
        CarregarFornecedor()
        CarregarCategoriaProdutos()
        CarregarUnidadesMedidas()

        DesabilitarCampos()
        btnSalvar.Enabled = False

        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub frmProdutos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CarregarCategoriaProdutos()
        CarregarUnidadesMedidas()
        CarregarFornecedor()
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
            da.SelectCommand.CommandType = CommandType.StoredProcedure
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
        ' txtQuantidade.Enabled = True
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
        ' txtCodBarras.Text = ""
        imgCodBar.Image = Nothing
        carregarImagem()

    End Sub

    Private Sub FormatarDG()
        With dg
            .Columns(0).Visible = False
            .Columns(9).Visible = False
            .Columns(16).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False

            .Columns(1).HeaderText = "Produto"
            .Columns(2).HeaderText = "Descrição"
            .Columns(3).HeaderText = "Fornecedor"
            .Columns(4).HeaderText = "Categoria"
            .Columns(5).HeaderText = "Unidade"
            .Columns(6).HeaderText = "Quant."
            .Columns(7).HeaderText = "Vlr de Compra"
            .Columns(8).HeaderText = "Vlr de Venda"
            .Columns(10).HeaderText = "Nível Mínimo"
            .Columns(11).HeaderText = "quant_vendida"
            .Columns(12).HeaderText = "Cód. Barras"
            .Columns(13).HeaderText = "data_cadastro"

            .Columns(1).Width = 200
            .Columns(2).Width = 180
            '.Columns(2).Width = 200
            '.Columns(3).Width = 260
            '.Columns(4).Width = 120
            '.Columns(5).Width = 80
            '.Columns(6).Width = 45
            '.Columns(7).Width = 100
            '.Columns(8).Width = 100
            '.Columns(9).Width = 80
        End With

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        If txtCodBarras.Text <> "" Then
            HabilitarCampos()
            ' Limpar()
            btnSalvar.Enabled = True
            '  btnEditar.Enabled = False
            '  btnExcluir.Enabled = False
            ' CriarCodigoBarras()
            txtCodBarras.Focus()
        End If

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim cmd As SqlCommand

        If txtNome.Text <> "" Then

            Try

                'CARREGANDO IMAGEM NO BANCO
                Dim MS As New IO.MemoryStream
                ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = MS.ToArray

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
                cmd.Parameters.AddWithValue("@imagem", byteArray)
                cmd.Parameters.AddWithValue("@nivel_minimo", txtNivel.Text)
                cmd.Parameters.AddWithValue("@quant_vendida", 0)
                cmd.Parameters.AddWithValue("@codigo_barras", txtCodBarras.Text)

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
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim cmd As SqlCommand

        Dim vlcompra = Replace(txtValorCompra.Text, ",", ".")
        Dim vlVenda = Replace(txtValorVenda.Text, ",", ".")

        If txtNome.Text <> "" Then

            Try

                'CARREGANDO IMAGEM NO BANCO
                Dim MS As New IO.MemoryStream
                ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = MS.ToArray

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
                cmd.Parameters.AddWithValue("@imagem", byteArray)
                cmd.Parameters.AddWithValue("@nivel_minimo", txtNivel.Text)

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
        ' Cadastro.Show()
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
        txtValorCompra.Text = dg.CurrentRow.Cells(7).Value '.ToString("R$ #,###.00")
        txtValorVenda.Text = dg.CurrentRow.Cells(8).Value '.ToString("R$ #,###.00")

        txtNivel.Text = CInt(dg.CurrentRow.Cells(10).Value)
        txtCodBarras.Text = dg.CurrentRow.Cells(12).Value

        Dim tempImagem As Byte() = DirectCast(dg.CurrentRow.Cells(9).Value, Byte())
        If tempImagem Is Nothing Then
            MessageBox.Show("Imagem não localizada", "Erro")
            Exit Sub
        End If
        Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
        Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
        fs.Write(tempImagem, 0, tempImagem.Length)
        fs.Flush()
        fs.Close()
        ImagemCarregada = Image.FromFile(strArquivo)
        pbImagem.Image = ImagemCarregada

        ' txtNivel.Text = CInt(dg.CurrentRow.Cells(14).Value)

        CriarCodigoBarras()
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
                da.SelectCommand.Parameters.AddWithValue("@codigo_barras", txtBuscar.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btImagem_Click(sender As Object, e As EventArgs)
        pbImagem.Visible = True
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"}

            If OFD.ShowDialog = DialogResult.OK Then
                ImagemCarregada = Image.FromFile(OFD.FileName)
                pbImagem.Image = ImagemCarregada
            End If
        End Using
    End Sub

    Private Sub btImagem_Click_1(sender As Object, e As EventArgs) Handles btImagem.Click
        pbImagem.Visible = True
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"}

            If OFD.ShowDialog = DialogResult.OK Then
                ImagemCarregada = Image.FromFile(OFD.FileName)
                pbImagem.Image = ImagemCarregada
            End If
        End Using
    End Sub

    Sub CriarCodigoBarras()

        Dim codBarras As New Barcode128

        With codBarras
            .BarHeight = 50
            .Code = txtCodBarras.Text
            .GenerateChecksum = True
            .CodeType = Barcode.CODE128

            Try
                Dim bmp As New Bitmap(.CreateDrawingImage(Color.Black, Color.White))
                Dim img As Image
                img = New Bitmap(bmp.Width, bmp.Height)

                Dim g As Graphics = Graphics.FromImage(img)
                g.FillRectangle(New SolidBrush(Color.White), 0, 0, bmp.Width, bmp.Height)
                g.DrawImage(bmp, 0, 0)
                imgCodBar.Image = img

            Catch ex As Exception
                MsgBox("Erro" + ex.Message.ToString)
            End Try

        End With

    End Sub

    Sub carregarImagem()

        Dim img As String = "https://www.buritama.sp.leg.br/imagens/parlamentares-2013-2016/sem-foto.jpg/image"

        Dim req As System.Net.HttpWebRequest
        Dim resp As System.Net.HttpWebResponse
        req = Net.WebRequest.Create(img)
        req = req.Create(img)

        resp = req.GetResponse

        ImagemCarregada = New Bitmap(resp.GetResponseStream)
        pbImagem.Image = ImagemCarregada
        req.Abort()

    End Sub

    Private Sub txtCodBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodBarras.TextChanged
        CriarCodigoBarras()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bmp As New Bitmap(imgCodBar.Width, imgCodBar.Height)
        imgCodBar.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub btCategorias_Click(sender As Object, e As EventArgs) Handles btCategorias.Click
        Dim form = New frmCategoriaProdutos
        form.ShowDialog()
    End Sub

    Private Sub btUnidadesMedidas_Click(sender As Object, e As EventArgs) Handles btUnidadesMedidas.Click
        Dim form = New frmUnidadeMedidas
        form.ShowDialog()
    End Sub

    Private Sub btFornecedores_Click(sender As Object, e As EventArgs) Handles btFornecedores.Click
        Dim form = New frmFornecedores
        form.ShowDialog()
    End Sub
End Class