Imports System.Data.SqlClient
Imports System.Text

Public Class frmReceberContas
    Dim dal As New ContaPagarDAL()
    Private Sub frmReceberContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar()

        CarregarClientes()
        carregarCatContas()
        caregarFormaPagamento()

        carregarBuscarCatContas()

        CarregarBuscarCliente()


        ' txtBuscarCliente.Text = Nothing
        '  txtBuscarTipoConta.Text = Nothing

        rbTodas.Checked = True

        CarregaInformacoesIniciais()

    End Sub

    Private Sub frmReceberContas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CarregaInformacoesIniciais()
        'txtBuscarFornecedor.Text = Nothing
        'txtBuscarTipoConta.Text = Nothing
    End Sub

    Private Sub CarregaInformacoesIniciais()
        Carregar()

        CalculaContas()
        ContarLinhas()

    End Sub

    Private Sub Carregar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasReceber_listar", con) '
            ' da = New SqlDataAdapter("select * from tbTipoServico", con)

            da.Fill(dt)
            dgvContasReceber.DataSource = dt

            ' FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
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
            txtDescricao.DisplayMember = "descricaocategoriacontas"
            txtDescricao.ValueMember = "id_categoriacontas"
            txtDescricao.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
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

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarBuscarCliente()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_cliente_listar", con)
            DA.Fill(DT)
            txtBuscarCliente.DisplayMember = "nome"
            txtBuscarCliente.ValueMember = "id_cliente"
            txtBuscarCliente.DataSource = DT

        Catch ex As Exception
            ' MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarClientes()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_cliente_listarGeral", con)
            DA.Fill(DT)
            txtCliente.DisplayMember = "nome"
            txtCliente.ValueMember = "id_cliente"
            txtCliente.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub rbTodas_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodas.CheckedChanged
        Carregar()
        txtBuscarCliente.Text = Nothing
        txtBuscarTipoConta.Text = Nothing
    End Sub

    Private Sub rbContasReceber_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasReceber.CheckedChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasReceber_contas_a_receber", con)

            da.Fill(dt)
            dgvContasReceber.DataSource = dt

            FormatarDG()
            txtBuscarCliente.Text = Nothing
            txtBuscarTipoConta.Text = Nothing

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub rbContasRecebidas_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasRecebidas.CheckedChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasReceber_contas_recebidas", con) '
            ' da = New SqlDataAdapter("select * from tbTipoServico", con)

            da.Fill(dt)
            dgvContasReceber.DataSource = dt

            FormatarDG()

            txtBuscarCliente.Text = Nothing
            txtBuscarTipoConta.Text = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub


    Private Sub rbTipoConta_CheckedChanged(sender As Object, e As EventArgs) Handles rbTipoConta.CheckedChanged
        Carregar()
        txtBuscarTipoConta.Visible = True
        txtBuscarCliente.Visible = False
        txtBuscarTipoConta.Focus()
    End Sub

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        Carregar()
        txtBuscarCliente.Visible = True
        txtBuscarTipoConta.Visible = False
        txtBuscarCliente.Focus()
    End Sub

    Private Sub txtBuscarTipoConta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarTipoConta.SelectedIndexChanged
        If txtBuscarTipoConta.Text = "" And dgvContasReceber.Rows.Count > 0 Then

            Carregar()

        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("pa_ContasReceber_buscarDescricao", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@descricaocategoriacontas", txtBuscarTipoConta.Text)

                da.Fill(dt)
                dgvContasReceber.DataSource = dt

                FormatarDG()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscarCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.SelectedIndexChanged
        If txtBuscarCliente.Text = "" And dgvContasReceber.Rows.Count > 0 Then

            Carregar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("pa_ContasReceber_buscarCliente", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                ' da.SelectCommand.Parameters.AddWithValue("@id_cliente", txtBuscarCliente.SelectedValue)
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscarCliente.Text)

                da.Fill(dt)
                dgvContasReceber.DataSource = dt

                FormatarDG()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar os fornecedores" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
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

    Private Sub ContarLinhas()
        Dim total As Integer = dgvContasReceber.Rows.Count
        lblTotalLinhas.Text = CInt(total)
    End Sub

    Private Sub CalculaContas()
        Dim dblContasPagas, dblContasNaoPagas, dblTotalContas, dblContasAtrasadas As Double

        For Each linha As DataGridViewRow In dgvContasReceber.Rows
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

            '    'Total Contas Atrasadas
            '    If linha.Cells("situacao").Value = "Vencida" Then
            '        dblContasAtrasadas = dblContasAtrasadas + linha.Cells(6).Value
            '    End If

        Next

        txtTotalContasRecebidas.Text = FormatCurrency(dblContasPagas)
        txtTotalContasNaoRecebidas.Text = FormatCurrency(dblContasNaoPagas)
        txtTotalContasReceber.Text = FormatCurrency(dblTotalContas)


    End Sub

    Private Sub DesabilitarCampos()
        txtNDoc.Enabled = False
        txtDescricao.Enabled = False

        txtFormaPagto.Enabled = False
        txtDescricao.Enabled = False
        txtValor.Enabled = False
        dtpVencimento.Enabled = False


    End Sub

    Private Sub HabilitarCampos()
        txtNDoc.Focus()
        txtNDoc.Enabled = True
        txtDescricao.Enabled = True

        txtFormaPagto.Enabled = True
        txtCliente.Enabled = True
        txtValor.Enabled = True
        dtpVencimento.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNDoc.Focus()
        txtNDoc.Text = ""
        txtDescricao.Text = Nothing

        txtFormaPagto.Text = Nothing
        txtCliente.Text = Nothing
        txtValor.Text = ""
        dtpVencimento.Text = ""

    End Sub


    Private Sub FormatarDG()

        With dgvContasReceber

            .Columns(5).DefaultCellStyle.Format = "c"

            .Columns(0).Visible = False
            ' .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False


            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "numDocto"
            .Columns(2).HeaderText = "Cat. Conta"
            .Columns(3).HeaderText = "Cliente"
            .Columns(4).HeaderText = "Forma de Pagto"
            .Columns(5).HeaderText = "Valor"
            .Columns(6).HeaderText = "Dt. Vencimento"
            .Columns(7).HeaderText = "Dt. Pagto"
            .Columns(8).HeaderText = "Pago"
            .Columns(9).HeaderText = "Usuario"
            .Columns(10).HeaderText = "Dt. Cadastro"
            .Columns(11).HeaderText = "situacao"
            .Columns(12).HeaderText = "id_categoriacontas"
            .Columns(13).HeaderText = "id_categoriacontas"
            .Columns(14).HeaderText = "id_fornecedor"
            .Columns(15).HeaderText = "id_fornecedor"
            .Columns(16).HeaderText = "id_formaPag"
            .Columns(17).HeaderText = "id_formaPag"


            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 300
            .Columns(4).Width = 130
            .Columns(5).Width = 120
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 70
            .Columns(9).Width = 80
            .Columns(10).Width = 100
        End With


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

        If txtDescricao.Text <> "" And txtNDoc.Text <> "" Then

            Try
                Dim vlcontaReceber = Replace(txtValor.Text, ",", ".")
                abrir()
                cmd = New SqlCommand("pa_ContasReceber_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtDescricao.SelectedValue)
                cmd.Parameters.AddWithValue("@id_cliente", txtCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@Valor", vlcontaReceber)
                cmd.Parameters.AddWithValue("@DataVencimento", dtpVencimento.Value)
                cmd.Parameters.AddWithValue("@DataPagamento", DBNull.Value)
                cmd.Parameters.AddWithValue("@Pago", False)
                cmd.Parameters.AddWithValue("@situacao", "Pendente")
                cmd.Parameters.AddWithValue("@usuario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.ToShortDateString)
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

        If txtDescricao.Text <> "" And txtNDoc.Text <> "" Then

            Try
                Dim vlcontaReceber = Replace(txtValor.Text, ",", ".")
                abrir()
                cmd = New SqlCommand("pa_ContasReceber_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", lblCodigo.Text)
                cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtDescricao.SelectedValue)
                cmd.Parameters.AddWithValue("@id_cliente", txtCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@Valor", vlcontaReceber)
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

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtDescricao.Text <> "" And txtNDoc.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este conta?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_ContasReceber_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Carregar()
                Limpar()

                ' btnExcluir.Enabled = False
                '   btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btPagar_Click(sender As Object, e As EventArgs) Handles btPagar.Click
        Dim cmd As SqlCommand

        Try

            abrir()
            cmd = New SqlCommand("pa_ContasReceber_PagarConta", con)
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

    Private Sub btPendente_Click(sender As Object, e As EventArgs) Handles btPendente.Click
        rbTodas.Checked = False

        dgvContasReceber.DataSource = dal.ListarPendenteRec()
        MessageBox.Show("Total Pendente: R$ " &
                       dal.TotalPendenteRec().ToString("N2"))
    End Sub

    Private Sub btGrafico_Click(sender As Object, e As EventArgs) Handles btGrafico.Click
        Dim form = New frmDashboardReceber
        form.ShowDialog()
    End Sub

    Private Sub btGerarParcelamento_Click(sender As Object, e As EventArgs) Handles btGerarParcelamento.Click
        situacaoPagamentoReceber = dgvContasReceber.CurrentRow().Cells("situacao").Value

        If situacaoPagamentoReceber = "Pago" Then
            MessageBox.Show("Esta conta já foi paga")
            Exit Sub
        ElseIf situacaoPagamentoReceber = "Em Parcelamento" Then
            MessageBox.Show("Esta conta já está em parcelamento")

            Exit Sub

        ElseIf situacaoPagamentoReceber = "Pendente" Then

            intCodigoLancamento = dgvContasReceber.CurrentRow().Cells("id").Value
            frmLancamentoContasReceber.ShowDialog()

        End If
    End Sub

    Private Sub btPagarParcela_Click(sender As Object, e As EventArgs) Handles btPagarParcela.Click
        intCodigoLancamento = dgvContasReceber.CurrentRow().Cells("id").Value
        frmBaixarContaReceber.ShowDialog()
    End Sub

    Private Sub dgvContasReceber_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContasReceber.CellClick
        btExcluir.Enabled = True
        btEditar.Enabled = True
        btPagar.Enabled = True
        btSalvar.Enabled = False
        btPendente.Enabled = True
        btGerarParcelamento.Enabled = True
        btPagarParcela.Visible = True
        '  HabilitarCampos()

        lblCodigo.Text = dgvContasReceber.CurrentRow.Cells(0).Value
        txtNDoc.Text = dgvContasReceber.CurrentRow.Cells(1).Value
        txtDescricao.Text = dgvContasReceber.CurrentRow.Cells(2).Value
        txtCliente.Text = dgvContasReceber.CurrentRow.Cells(3).Value
        txtFormaPagto.Text = dgvContasReceber.CurrentRow.Cells(4).Value
        txtValor.Text = dgvContasReceber.CurrentRow.Cells(5).Value
        dtpVencimento.Text = dgvContasReceber.CurrentRow.Cells(6).Value

    End Sub
End Class