Imports System.Data.SqlClient
Imports System.Text

Public Class frmContasReceber
    Private Sub frmContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregaInformacoesIniciais()

        rbDescricao.Checked = True

        carregarCatContas()

        CarregarClientes()

    End Sub

    Private Sub frmContasReceber_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CarregaInformacoesIniciais()
    End Sub

    Sub carregarCatContas()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()

            DA = New SqlDataAdapter("pa_catContas_listar", con)
            DA.Fill(DT)
            txtBuscarConta.DisplayMember = "descricaocategoriacontas"
            txtBuscarConta.ValueMember = "id_categoriacontas"
            txtBuscarConta.DataSource = DT

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
            'DA = New SqlDataAdapter("SELECT * FROM tbClientes", con) 
            DA = New SqlDataAdapter("pa_cliente_listar", con)
            DA.Fill(DT)
            txtBuscarCliente.DisplayMember = "nome"
            txtBuscarCliente.ValueMember = "id_cliente"
            txtBuscarCliente.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub CarregaInformacoesIniciais()
        Listar()
        CalculaContas()
        ContarLinhas()
        '  FormatarDG()
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasReceber_listar", con)
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()
            '  FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()

        With dg
            .Columns(6).DefaultCellStyle.Format = "c"
            .Columns(9).DefaultCellStyle.Format = "c"
            .Columns(12).DefaultCellStyle.Format = "c"
            .Columns(13).DefaultCellStyle.Format = "c"
            .Columns(14).DefaultCellStyle.Format = "c"

            .Columns(0).Visible = False
            .Columns(5).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(12).Visible = False
            '.Columns(13).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False


            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "numDocto"
            .Columns(2).HeaderText = "Tipo de Conta"
            .Columns(3).HeaderText = "Clientes"
            .Columns(4).HeaderText = "Descrição"
            .Columns(5).HeaderText = "Forma de Pagto"
            .Columns(6).HeaderText = "Valor"
            .Columns(7).HeaderText = "Obsservação"
            .Columns(8).HeaderText = "Vencimento"
            .Columns(9).HeaderText = "Dt. Pagto"
            .Columns(10).HeaderText = "Desconto"
            .Columns(11).HeaderText = "Juros"
            .Columns(12).HeaderText = "Valor Pago"
            .Columns(13).HeaderText = "Situação"
            .Columns(14).HeaderText = "Usuário"
            .Columns(15).HeaderText = "Dt. Cadastro"
            .Columns(16).HeaderText = "ID CatContas"
            .Columns(17).HeaderText = "ID_Fornecedor"
            .Columns(18).HeaderText = "ID_FormaPagto"
            .Columns(19).HeaderText = "ID CatContas"
            .Columns(20).HeaderText = "ID_Fornecedor"
            .Columns(21).HeaderText = "ID_FormaPagto"

            .Columns(1).Width = 150
            .Columns(2).Width = 200
            .Columns(3).Width = 250
            .Columns(4).Width = 200
            .Columns(5).Width = 120
            .Columns(6).Width = 120
            .Columns(7).Width = 300
            .Columns(15).Width = 120

            'For Each row As DataGridViewRow In .Rows
            '    '  row.Cells("situacao").Style.ForeColor = ColorirSituacao(row.Cells("situacao").Value)

            '    If row.Cells("situacao").Value = "Não Paga" Then
            '        row.DefaultCellStyle.BackColor = Color.Red
            '        row.DefaultCellStyle.ForeColor = Color.White
            '    ElseIf row.Cells("situacao").Value = "Paga" Then
            '        row.DefaultCellStyle.BackColor = Color.Green
            '        row.DefaultCellStyle.ForeColor = Color.White
            '    ElseIf row.Cells("situacao").Value = "Vencida" Then
            '        row.DefaultCellStyle.BackColor = Color.DarkRed
            '        row.DefaultCellStyle.ForeColor = Color.White
            '    End If
            'Next
        End With

    End Sub

    'Private Function ColorirSituacao(situacaoCor As String) As Color
    '    Select Case situacaoCor  'Pago, Não Pago, Atrasado
    '        Case "Paga"
    '            Return Color.Blue
    '        Case "Não Paga"
    '            Return Color.Red
    '        Case "Vencida"
    '            Return Color.DarkRed
    '        Case Else
    '            Return Color.Green
    '    End Select
    'End Function

    Private Sub rbTodas_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodas.CheckedChanged
        Listar()
    End Sub

    Private Sub rbContasReceber_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasReceber.CheckedChanged
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("pa_ContasReceber_contas_a_receber", con) '
        '    ' da = New SqlDataAdapter("select * from tbTipoServico", con)

        '    da.Fill(dt)
        '    dg.DataSource = dt

        '    FormatarDG()
        'Catch ex As Exception
        '    MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        'Finally
        '    fechar()
        'End Try
    End Sub

    Private Sub rbContasRecebidas_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasRecebidas.CheckedChanged
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("pa_ContasReceber_contas_recebidas", con) '
        '    ' da = New SqlDataAdapter("select * from tbTipoServico", con)

        '    da.Fill(dt)
        '    dg.DataSource = dt

        '    FormatarDG()
        'Catch ex As Exception
        '    MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        'Finally
        '    fechar()
        'End Try
    End Sub

    Private Sub rbContasVencidas_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasVencidas.CheckedChanged
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        'Try
        '    abrir()
        '    da = New SqlDataAdapter("pa_ContasReceber_contas_atrasadas", con) '
        '    ' da = New SqlDataAdapter("select * from tbTipoServico", con)

        '    da.Fill(dt)
        '    dg.DataSource = dt

        '    FormatarDG()
        'Catch ex As Exception
        '    MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        'Finally
        '    fechar()
        'End Try
    End Sub

    Private Sub rbConta_CheckedChanged(sender As Object, e As EventArgs) Handles rbConta.CheckedChanged
        Listar()
        ' txtBuscarFornecedor.Text = Nothing
        txtBuscarDescricao.Text = ""
        txtBuscarConta.Visible = True
        'txtBuscarConta.Text = Nothing
        txtBuscarCliente.Visible = False
        txtBuscarDescricao.Visible = False
        txtBuscarConta.Focus()
    End Sub

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        Listar()
        ' txtBuscarFornecedor.Text = Nothing
        ' txtBuscarConta.Text = Nothing
        txtBuscarDescricao.Text = ""
        txtBuscarCliente.Visible = True
        txtBuscarConta.Visible = False
        txtBuscarDescricao.Visible = False
        txtBuscarCliente.Focus()
    End Sub

    Private Sub rbDescricao_CheckedChanged(sender As Object, e As EventArgs) Handles rbDescricao.CheckedChanged
        Listar()
        ' txtBuscarFornecedor.Text = Nothing
        '  txtBuscarConta.Text = ""
        txtBuscarDescricao.Text = ""
        txtBuscarConta.Visible = False
        txtBuscarCliente.Visible = False
        txtBuscarDescricao.Visible = True
        txtBuscarDescricao.Focus()
    End Sub

    Private Sub txtBuscarDescricao_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDescricao.TextChanged
        'If txtBuscarDescricao.Text = "" And dg.Rows.Count > 0 Then

        '    Listar()

        'Else
        '    Dim dt As New DataTable
        '    Dim da As SqlDataAdapter

        '    Try
        '        abrir()
        '        da = New SqlDataAdapter("pa_ContasReceber_buscarDescricao", con)
        '        da.SelectCommand.CommandType = CommandType.StoredProcedure
        '        da.SelectCommand.Parameters.AddWithValue("@descricao", txtBuscarDescricao.Text)

        '        da.Fill(dt)
        '        dg.DataSource = dt

        '        FormatarDG()

        '    Catch ex As Exception
        '        MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
        '        fechar()
        '    End Try
        'End If
    End Sub

    Private Sub txtBuscarConta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarConta.SelectedIndexChanged
        'If txtBuscarConta.Text = "" And dg.Rows.Count > 0 Then

        '    Listar()

        'Else

        '    Dim dt As New DataTable
        '    Dim da As SqlDataAdapter

        '    Try
        '        abrir()

        '        da = New SqlDataAdapter("pa_ContasReceber_buscarConta", con)
        '        da.SelectCommand.CommandType = CommandType.StoredProcedure
        '        da.SelectCommand.Parameters.AddWithValue("@id_categoriacontas", txtBuscarConta.SelectedValue)

        '        da.Fill(dt)
        '        dg.DataSource = dt

        '        FormatarDG()

        '    Catch ex As Exception
        '        MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
        '    Finally
        '        fechar()
        '    End Try
        'End If
    End Sub

    Private Sub txtBuscarCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.SelectedIndexChanged
        ''If txtBuscarCliente.Text = "" And dg.Rows.Count > 0 Then

        ''    Listar()

        ''Else
        ''    Dim dt As New DataTable
        ''    Dim da As SqlDataAdapter

        ''    Try
        ''        abrir()

        ''        da = New SqlDataAdapter("pa_ContasReceber_buscarCliente", con)
        ''        da.SelectCommand.CommandType = CommandType.StoredProcedure
        ''        da.SelectCommand.Parameters.AddWithValue("@id_cliente", txtBuscarCliente.SelectedValue)

        ''        da.Fill(dt)
        ''        dg.DataSource = dt

        ''        FormatarDG()

        ''    Catch ex As Exception
        ''        MessageBox.Show("Erro ao Listar os fornecedores" + ex.Message.ToString)
        ''    Finally
        ''        fechar()
        ''    End Try
        ''End If
    End Sub

    Private Sub CalculaContas()
        Dim dblContasPagas, dblContasNaoPagas, dblTotalContas, dblContasAtrasadas As Double

        For Each linha As DataGridViewRow In dg.Rows
            'Total de todas as Contas
            dblTotalContas = dblTotalContas + linha.Cells("Valor").Value

            'Total Contas Pagas
            If linha.Cells("situacao").Value = "Paga" Then
                dblContasPagas = dblContasPagas + linha.Cells("Valor").Value
            End If

            'Total Contas Não Pagas
            If linha.Cells("situacao").Value = "Não Paga" Then
                dblContasNaoPagas = dblContasNaoPagas + linha.Cells("Valor").Value
            End If

            'Total Contas Atrasadas
            If linha.Cells("situacao").Value = "Vencida" Then
                dblContasAtrasadas = dblContasAtrasadas + linha.Cells("Valor").Value
            End If

        Next

        txtTotalContasPagas.Text = FormatCurrency(dblContasPagas)
        txtTotalContasNaoPagas.Text = FormatCurrency(dblContasNaoPagas)
        txtTotalContasPagar.Text = FormatCurrency(dblTotalContas)
        txtTotalContasAtrasadas.Text = FormatCurrency(dblContasAtrasadas)

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblNumTotalContasReceber.Text = CInt(total)
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        intCodigoLancamento = 0
        frmLancamentoContasReceber.ShowDialog()
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        intCodigoLancamento = dg.CurrentRow().Cells("id_contaReceber").Value
        frmLancamentoContasReceber.ShowDialog()

        CarregaInformacoesIniciais()
    End Sub
End Class

