Imports System.Data.SqlClient
Imports System.Text

Public Class frmContasPagar
    Private Sub frmContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregaInformacoesIniciais()

        rbDescricao.Checked = True

        CarregarFornecedor()
        carregarCatContas()

    End Sub

    Private Sub frmContasPagar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

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

    Sub CarregarFornecedor()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_fornecedor_listar", con)
            DA.Fill(DT)
            txtBuscarFornecedor.DisplayMember = "razaoSocial"
            txtBuscarFornecedor.ValueMember = "id_fornecedor"
            txtBuscarFornecedor.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub CarregaInformacoesIniciais()
        listar()
        CalculaContas()
        ContarLinhas()
        '  FormatarDG()
    End Sub

    Private Sub listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasPagar_listar", con) '
            ' da = New SqlDataAdapter("select * from tbTipoServico", con)

            da.Fill(dt)
            dgContasPagar.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()

        With dgContasPagar

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
            .Columns(13).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False
            .Columns(22).Visible = False
            .Columns(23).Visible = False

            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "numDocto"
            .Columns(2).HeaderText = "Tipo de Conta"
            .Columns(3).HeaderText = "Fornecedor"
            .Columns(4).HeaderText = "Descrição"
            .Columns(5).HeaderText = "Forma de Pagto"
            .Columns(6).HeaderText = "Valor"
            .Columns(7).HeaderText = "Obsservação"
            .Columns(8).HeaderText = "Parcelas"
            .Columns(9).HeaderText = "Valor da parcela"
            .Columns(10).HeaderText = "Vencimento"
            .Columns(11).HeaderText = "Dt. Pagto"
            .Columns(12).HeaderText = "Desconto"
            .Columns(13).HeaderText = "Juros"
            .Columns(14).HeaderText = "Valor Pago"
            .Columns(15).HeaderText = "Situação"
            .Columns(16).HeaderText = "Usuário"
            .Columns(17).HeaderText = "Dt. Cadastro"
            .Columns(18).HeaderText = "ID CatContas"
            .Columns(19).HeaderText = "ID_Fornecedor"
            .Columns(20).HeaderText = "ID_FormaPagto"
            .Columns(21).HeaderText = "ID CatContas"
            .Columns(22).HeaderText = "ID_Fornecedor"
            .Columns(23).HeaderText = "ID_FormaPagto"


            .Columns(1).Width = 150
            .Columns(2).Width = 200
            .Columns(3).Width = 250
            .Columns(4).Width = 200
            .Columns(5).Width = 120
            .Columns(6).Width = 120
            .Columns(7).Width = 300



            For Each row As DataGridViewRow In .Rows
                '  row.Cells("situacao").Style.ForeColor = ColorirSituacao(row.Cells("situacao").Value)

                If row.Cells("situacao").Value = "Não Paga" Then
                    row.DefaultCellStyle.BackColor = Color.Red
                    row.DefaultCellStyle.ForeColor = Color.White
                ElseIf row.Cells("situacao").Value = "Paga" Then
                    row.DefaultCellStyle.BackColor = Color.Green
                    row.DefaultCellStyle.ForeColor = Color.White
                ElseIf row.Cells("situacao").Value = "Vencida" Then
                    row.DefaultCellStyle.BackColor = Color.DarkRed
                    row.DefaultCellStyle.ForeColor = Color.White
                End If
            Next
        End With

    End Sub

    Private Function ColorirSituacao(situacaoCor As String) As Color
        Select Case situacaoCor  'Pago, Não Pago, Atrasado
            Case "Paga"
                Return Color.Blue
            Case "Não Paga"
                Return Color.Red
            Case "Vencida"
                Return Color.DarkRed
            Case Else
                Return Color.Green
        End Select
    End Function




    Private Sub rbTodas_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodas.CheckedChanged
        listar()
    End Sub

    Private Sub rbContasPagar_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasPagar.CheckedChanged

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasPagar_contas_a_pagar", con) '
            ' da = New SqlDataAdapter("select * from tbTipoServico", con)

            da.Fill(dt)
            dgContasPagar.DataSource = dt

            FormatarDG()
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
            ' da = New SqlDataAdapter("select * from tbTipoServico", con)

            da.Fill(dt)
            dgContasPagar.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub rbContasVencidas_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasVencidas.CheckedChanged

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasPagar_contas_atrasadas", con) '
            ' da = New SqlDataAdapter("select * from tbTipoServico", con)

            da.Fill(dt)
            dgContasPagar.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub rbConta_CheckedChanged(sender As Object, e As EventArgs) Handles rbConta.CheckedChanged

        ' txtBuscarFornecedor.Text = Nothing
        txtBuscarDescricao.Text = ""
        txtBuscarConta.Visible = True
        'txtBuscarConta.Text = Nothing
        txtBuscarFornecedor.Visible = False
        txtBuscarDescricao.Visible = False
        txtBuscarConta.Focus()
    End Sub

    Private Sub rbFornecedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbFornecedor.CheckedChanged

        ' txtBuscarFornecedor.Text = Nothing
        ' txtBuscarConta.Text = Nothing
        txtBuscarDescricao.Text = ""
        txtBuscarFornecedor.Visible = True
        txtBuscarConta.Visible = False
        txtBuscarDescricao.Visible = False
        txtBuscarFornecedor.Focus()
    End Sub

    Private Sub rbDescricao_CheckedChanged(sender As Object, e As EventArgs) Handles rbDescricao.CheckedChanged
        ' txtBuscarFornecedor.Text = Nothing
        '  txtBuscarConta.Text = ""
        txtBuscarDescricao.Text = ""
        txtBuscarConta.Visible = False
        txtBuscarFornecedor.Visible = False
        txtBuscarDescricao.Visible = True
        txtBuscarDescricao.Focus()
    End Sub

    Private Sub txtBuscarDescricao_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDescricao.TextChanged
        If txtBuscarDescricao.Text = "" And dgContasPagar.Rows.Count > 0 Then

            listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_ContasPagar_buscarDescricao", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@descricao", txtBuscarDescricao.Text)

                da.Fill(dt)
                dgContasPagar.DataSource = dt

                FormatarDG()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscarConta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarConta.SelectedIndexChanged
        If txtBuscarConta.Text = "" And dgContasPagar.Rows.Count > 0 Then

            listar()

        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("pa_ContasPagar_buscarConta", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_categoriacontas", txtBuscarConta.SelectedValue)

                da.Fill(dt)
                dgContasPagar.DataSource = dt

                FormatarDG()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscarFornecedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarFornecedor.SelectedIndexChanged
        If txtBuscarFornecedor.Text = "" And dgContasPagar.Rows.Count > 0 Then

            listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("pa_ContasPagar_buscarFonecedor", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_fornecedor", txtBuscarFornecedor.SelectedValue)

                da.Fill(dt)
                dgContasPagar.DataSource = dt

                FormatarDG()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar os fornecedores" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub


    Private Sub CalculaContas()
        Dim dblContasPagas, dblContasNaoPagas, dblTotalContas, dblContasAtrasadas As Double

        For Each linha As DataGridViewRow In dgContasPagar.Rows
            'Total de todas as Contas
            dblTotalContas = dblTotalContas + linha.Cells("Valor").Value

            'Total Contas Pagas
            If linha.Cells("situacao").Value = "Paga" Then
                dblContasPagas = dblContasPagas + linha.Cells("Valor").Value
            End If

            'Total Contas Não Pagas
            If linha.Cells("situacao").Value = "NãoPaga" Then
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
        Dim total As Integer = dgContasPagar.Rows.Count
        lblTotal.Text = CInt(total)
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click

        intCodigoLancamento = 0
        frmLancamentoContasPagar.ShowDialog()

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dgContasPagar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContasPagar.CellDoubleClick
        intCodigoLancamento = dgContasPagar.CurrentRow().Cells("id_conta").Value
        'frmLancamentoContasPagar.txtCodigo.Text = intCodigoLancamento
        frmLancamentoContasPagar.ShowDialog()
        CarregaInformacoesIniciais()
    End Sub

    'Private Sub dgContasPagar_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgContasPagar.CellFormatting
    '    If (dgContasPagar.Columns(e.ColumnIndex).Name = "Situação") Then
    '        Try
    '            If Not e.Value.GetType() Is GetType(System.DBNull) Then
    '                If (Convert.ToInt32(e.Value) = "Paga") Then
    '                    e.CellStyle.ForeColor = Color.Red
    '                    e.CellStyle.BackColor = Color.Orange

    '                    If (Convert.ToInt32(e.Value) = "Não Paga") Then
    '                        e.CellStyle.ForeColor = Color.BlueViolet
    '                        e.CellStyle.BackColor = Color.Gray
    '                    End If

    '                    If (Convert.ToInt32(e.Value) = "Vencida") Then
    '                        e.CellStyle.ForeColor = Color.Green
    '                        e.CellStyle.BackColor = Color.LavenderBlush
    '                    End If
    '                End If
    '            End If


    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub
End Class