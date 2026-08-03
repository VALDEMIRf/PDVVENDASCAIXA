Imports System.Data.SqlClient
Imports System.Text

Public Class frmContasApagar

    Dim dal As New ContaPagarDAL()

    Private Sub frmContasApagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
        CarregarFornecedor()
        carregarCatContas()
        carregarBuscarCatContas()
        CarregarBuscarFornecedor()
        caregarFormaPagamento()

        txtBuscarFornecedor.Text = Nothing
        txtBuscarTipoConta.Text = Nothing
        txtBuscarFornecedor.Visible = False
        txtBuscarTipoConta.Visible = False

        rbTodas.Checked = True

        CarregaInformacoesIniciais()

    End Sub

    Private Sub frmContasApagar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CarregaInformacoesIniciais()
        txtBuscarFornecedor.Text = Nothing
        txtBuscarTipoConta.Text = Nothing
    End Sub

    Private Sub CarregaInformacoesIniciais()

        Limpar()
        CalculaContas()
        ContarLinhas()

    End Sub

    Sub carregarBuscarCatContas()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()

            DA = New SqlDataAdapter("pa_catContas_listar", con)
            DA.Fill(DT)
            txtBuscarTipoConta.DisplayMember = "descricaocategoriacontas"
            txtBuscarTipoConta.ValueMember = "id_categoriacontas"
            txtBuscarTipoConta.DataSource = DT


        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarFornecedor()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_fornecedor_listar", con)
            DA.Fill(DT)
            txtFornecedor.DisplayMember = "razaoSocial"
            txtFornecedor.ValueMember = "id_fornecedor"
            txtFornecedor.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Fornecedores" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub carregarCatContas()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()

            DA = New SqlDataAdapter("pa_catContas_listar", con)
            DA.Fill(DT)
            txtTipoConta.DisplayMember = "descricaocategoriacontas"
            txtTipoConta.ValueMember = "id_categoriacontas"
            txtTipoConta.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarBuscarFornecedor()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_fornecedor_listar", con)
            DA.Fill(DT)
            txtBuscarFornecedor.DisplayMember = "razaoSocial"
            txtBuscarFornecedor.ValueMember = "id_fornecedor"
            txtBuscarFornecedor.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Fornecedores" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub caregarFormaPagamento()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()

            DA = New SqlDataAdapter("pa_FormaPagamento_listar", con)
            DA.Fill(DT)
            txtFormaPagto.DisplayMember = "nome"
            txtFormaPagto.ValueMember = "id_formaPag"
            txtFormaPagto.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os tipos de pagamentos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgvContas.Rows.Count
        lblTotalLinhas.Text = CInt(total)
    End Sub

    Private Sub CalculaContas()
        Dim dblContasPagas, dblContasNaoPagas, dblTotalContas, dblContasAtrasadas As Double

        For Each linha As DataGridViewRow In dgvContas.Rows
            '    'Total de todas as Contas
            dblTotalContas = dblTotalContas + linha.Cells(5).Value

            '    'Total Contas Pagas
            If linha.Cells("Pago").Value = True Then
                dblContasPagas = dblContasPagas + linha.Cells(5).Value
            End If

            '    'Total Contas Não Pagas
            If linha.Cells("Pago").Value = False Then
                dblContasNaoPagas = dblContasNaoPagas + linha.Cells(5).Value
            End If
        Next
        txtTotalContasPagas.Text = FormatCurrency(dblContasPagas)
        txtTotalContasNaoPagas.Text = FormatCurrency(dblContasNaoPagas)
        txtTotalContasPagar.Text = FormatCurrency(dblTotalContas)
    End Sub

    Private Sub Carregar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_ContasPagar_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dgvContas.DataSource = dt

            ContarLinhas()

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub rbTodas_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodas.CheckedChanged
        Carregar()
        txtBuscarFornecedor.Text = Nothing
        txtBuscarTipoConta.Text = Nothing
        txtBuscarFornecedor.Visible = False
        txtBuscarTipoConta.Visible = False
    End Sub

    Private Sub rbContasPagar_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasPagar.CheckedChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasPagar_contas_a_pagar", con)

            da.Fill(dt)
            dgvContas.DataSource = dt

            FormatarDG()
            txtBuscarFornecedor.Text = Nothing
            txtBuscarTipoConta.Text = Nothing
            txtBuscarFornecedor.Visible = False
            txtBuscarTipoConta.Visible = False

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub rbContasPagas_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasPagas.CheckedChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasPagar_contas_pagas", con) '

            da.Fill(dt)
            dgvContas.DataSource = dt

            FormatarDG()

            txtBuscarFornecedor.Text = Nothing
            txtBuscarTipoConta.Text = Nothing
            txtBuscarFornecedor.Visible = False
            txtBuscarTipoConta.Visible = False
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub rbTipoConta_CheckedChanged(sender As Object, e As EventArgs) Handles rbTipoConta.CheckedChanged
        Carregar()
        txtBuscarTipoConta.Visible = True
        txtBuscarFornecedor.Visible = False
        txtBuscarTipoConta.Focus()
    End Sub

    Private Sub rbFornecedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbFornecedor.CheckedChanged
        Carregar()
        txtBuscarFornecedor.Visible = True
        txtBuscarTipoConta.Visible = False
        txtBuscarFornecedor.Focus()
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
        Limpar()
        btSalvar.Enabled = True
        btPagar.Enabled = False
        btExcluir.Enabled = False
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtTipoConta.Text <> "" And txtNDoc.Text <> "" Then

            Try
                Dim vlcontaPagar = Replace(txtValor.Text, ",", ".")
                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtTipoConta.SelectedValue)
                cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@Valor", vlcontaPagar)
                cmd.Parameters.AddWithValue("@DataVencimento", dtpVencimento.Value)
                cmd.Parameters.AddWithValue("@DataPagamento", DBNull.Value)
                cmd.Parameters.AddWithValue("@Pago", False)
                cmd.Parameters.AddWithValue("@usuario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.ToShortDateString)
                cmd.Parameters.AddWithValue("@situacao", "Pendente")
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Carregar()
                Limpar()

                btSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar esta conta" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If

    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Dim cmd As SqlCommand

        If txtTipoConta.Text <> "" And txtNDoc.Text <> "" Then

            Try
                Dim vlcontaPagar = Replace(txtValor.Text, ",", ".")
                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", lblCodigo.Text)
                cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtTipoConta.SelectedValue)
                cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@Valor", vlcontaPagar)
                cmd.Parameters.AddWithValue("@DataVencimento", dtpVencimento.Value)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Carregar()
                Limpar()

                btSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar esta conta" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub btPagar_Click(sender As Object, e As EventArgs) Handles btPagar.Click
        Dim cmd As SqlCommand

        Try

            abrir()
            cmd = New SqlCommand("pa_ContasPagar_PagarConta", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", lblCodigo.Text)
            cmd.Parameters.AddWithValue("@DataPagamento", Now.ToShortDateString)
            cmd.Parameters.AddWithValue("@Pago", True)
            cmd.Parameters.AddWithValue("@situacao", "Pago")
            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            Carregar()
            Limpar()

            btSalvar.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar esta conta" + ex.Message.ToString)
        Finally

            fechar()
        End Try
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtTipoConta.Text <> "" And txtNDoc.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este conta?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Carregar()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btGrafico_Click(sender As Object, e As EventArgs) Handles btGrafico.Click
        Dim form = New frmDashboard
        form.ShowDialog()
    End Sub

    Private Sub btPendente_Click(sender As Object, e As EventArgs) Handles btPendente.Click

        rbTodas.Checked = False

        dgvContas.DataSource = dal.ListarPendente()
        MessageBox.Show("Total Pendente: R$ " &
                       dal.TotalPendente().ToString("N2"))
    End Sub

    Private Sub btGerarParcelamento_Click(sender As Object, e As EventArgs) Handles btGerarParcelamento.Click
        situacaoPagamento = dgvContas.CurrentRow().Cells("situacao").Value

        If situacaoPagamento = "Pago" Then
            MessageBox.Show("Esta conta já foi paga")
            Exit Sub
        ElseIf situacaoPagamento = "Em Parcelamento" Then
            MessageBox.Show("Esta conta já está em parcelamento")

            Exit Sub

        ElseIf situacaoPagamento = "Pendente" Then

            intCodigoLancamento = dgvContas.CurrentRow().Cells("id").Value
            frmLancamentoContasPagar.ShowDialog()

        End If
    End Sub

    Private Sub btPagarParcela_Click(sender As Object, e As EventArgs) Handles btPagarParcela.Click
        situacaoPagamento = dgvContas.CurrentRow().Cells("situacao").Value

        If situacaoPagamento = "Pago" Then
            MessageBox.Show("Esta conta já foi paga")
            Exit Sub
        ElseIf situacaoPagamento = "Pendente" Or situacaoPagamento = "Em Parcelamento" Then

            intCodigoLancamento = dgvContas.CurrentRow().Cells("id").Value
            frmBaixarContaPagar.ShowDialog()

        End If

    End Sub

    Private Sub DesabilitarCampos()
        txtNDoc.Enabled = False
        txtTipoConta.Enabled = False
        txtFormaPagto.Enabled = False
        txtFornecedor.Enabled = False
        txtValor.Enabled = False
        dtpVencimento.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtNDoc.Focus()
        txtNDoc.Enabled = True
        txtTipoConta.Enabled = True
        txtFormaPagto.Enabled = True
        txtFornecedor.Enabled = True
        txtValor.Enabled = True
        dtpVencimento.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNDoc.Focus()
        txtNDoc.Text = ""
        txtTipoConta.Text = Nothing
        txtFormaPagto.Text = Nothing
        txtFornecedor.Text = Nothing
        txtValor.Text = ""
        dtpVencimento.Text = ""
    End Sub

    Private Sub FormatarDG()

        With dgvContas
            .Columns(5).DefaultCellStyle.Format = "c"
            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False

            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "numDocto"
            .Columns(2).HeaderText = "Cat. Conta"
            .Columns(3).HeaderText = "Fornecedor"
            .Columns(4).HeaderText = "Forma de Pagto"
            .Columns(5).HeaderText = "Valor Total"
            .Columns(6).HeaderText = "Dt. Cadastro"
            .Columns(7).HeaderText = "Dt. Vencimento"
            .Columns(8).HeaderText = "Data Pagamento"
            .Columns(9).HeaderText = "Pago"
            .Columns(10).HeaderText = "Usuário"
            .Columns(11).HeaderText = "Situacao"
            .Columns(12).HeaderText = "id_categoriacontas"
            .Columns(13).HeaderText = "id_categoriacontas"
            .Columns(14).HeaderText = "id_fornecedor"
            .Columns(15).HeaderText = "id_fornecedor"
            .Columns(16).HeaderText = "id_formaPag"
            .Columns(17).HeaderText = "id_formaPag"

            .Columns(1).Width = 150
            .Columns(2).Width = 180
            .Columns(3).Width = 330
            .Columns(4).Width = 130
            .Columns(5).Width = 120
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 100
            .Columns(9).Width = 50
            .Columns(10).Width = 130
            .Columns(11).Width = 130

            For Each row As DataGridViewRow In .Rows
                If row.Cells("situacao").Value = "Pago" Then
                    row.DefaultCellStyle.BackColor = Color.Green
                End If
            Next

        End With
    End Sub

    Private Sub dgvContas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContas.CellClick
        btExcluir.Enabled = True
        btEditar.Enabled = True
        btPagar.Enabled = True
        btSalvar.Enabled = False
        btPendente.Enabled = True
        btGerarParcelamento.Enabled = True
        btPagarParcela.Visible = True
        HabilitarCampos()

        lblCodigo.Text = dgvContas.CurrentRow.Cells(0).Value
        txtNDoc.Text = dgvContas.CurrentRow.Cells(1).Value
        txtTipoConta.Text = dgvContas.CurrentRow.Cells(2).Value
        txtFornecedor.Text = dgvContas.CurrentRow.Cells(3).Value
        txtFormaPagto.Text = dgvContas.CurrentRow.Cells(4).Value
        txtValor.Text = dgvContas.CurrentRow.Cells(5).Value
        dtpVencimento.Text = dgvContas.CurrentRow.Cells(6).Value
    End Sub

    Private Sub txtBuscarFornecedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarFornecedor.SelectedIndexChanged
        If txtBuscarFornecedor.Text = "" And dgvContas.Rows.Count > 0 Then

            ' Carregar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("pa_ContasPagar_buscarFonecedor", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_fornecedor", txtBuscarFornecedor.SelectedValue)

                da.Fill(dt)
                dgvContas.DataSource = dt

                FormatarDG()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar a pesquisa dos fornecedores" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscarTipoConta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarTipoConta.SelectedIndexChanged
        If txtBuscarTipoConta.Text = "" And dgvContas.Rows.Count > 0 Then

            ' Carregar()

        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("pa_ContasPagar_buscarDescricao", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_categoriacontas", txtBuscarTipoConta.SelectedValue)

                da.Fill(dt)
                dgvContas.DataSource = dt

                FormatarDG()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub


End Class



