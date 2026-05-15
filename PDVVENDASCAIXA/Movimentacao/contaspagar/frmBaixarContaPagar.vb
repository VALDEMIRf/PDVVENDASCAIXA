Imports System.Data.SqlClient

Public Class frmBaixarContaPagar

    Dim codParcela As Integer
    Dim calcularJuros As Boolean = False
    Dim calcularDesconto As Boolean = False
    Dim numerodias As TimeSpan
    Dim juros As Double = 0
    Dim desconto As Double = 0
    Dim valorDaParcela As Double
    Dim valorRestante As Double
    Dim vencimentoParcela As Date
    Dim pagamentoDaParcela As Date
    Dim Obj_parcela As New clsContaPagar
    Dim ds As New DataSet

    Dim connn As New ContaPagarDAL

    Private Sub frmBaixarContaPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        carregarContas()
        CarregarFornecedor()
        caregarFormaPagamento()
        carregarQtdParcela()


        If intCodigoLancamento <> 0 Then
            lblCodigo.Text = intCodigoLancamento

            CarregarDados()
        Else
            lblCodigo.Text = "Novo"
        End If

        CarregarDGrid()

        '   Dim parc As Integer = ObterProximaParcela(1)

        ' MessageBox.Show("A próxima parcela a ser paga é:  " & parc & " .Antes de fazer o cálculo do parcelamento selecione primeiro a parcela:  " & parc)

    End Sub

    Private Sub frmBaixarContaPagar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CarregarDGrid()
    End Sub

    Sub carregarQtdParcela()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()

            DA = New SqlDataAdapter("parcelasPagar_listarParcelas", con)
            DA.Fill(DT)
            'cboParcela.DisplayMember = "parcela"
            'cboParcela.ValueMember = "id_parcela"
            'cboParcela.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub
    Sub carregarContas()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()

            DA = New SqlDataAdapter("pa_catContas_listar", con)
            DA.Fill(DT)
            txtConta.DisplayMember = "descricaocategoriacontas"
            txtConta.ValueMember = "id_categoriacontas"
            txtConta.DataSource = DT

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

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
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
    Private Sub CarregarDados()
        Dim dr As SqlDataReader = Nothing
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            Dim sql As String = "pa_ContasPagar_listarID " & CInt(intCodigoLancamento)
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

            If dr.HasRows Then
                dr.Read()
                lblCodigoConta.Text = dr.Item("id")
                txtNDoc.Text = dr.Item("numDocto")
                txtConta.Text = dr.Item("descricaocategoriacontas")
                txtFornecedor.Text = dr.Item("razaoSocial")
                txtFormaPagto.Text = dr.Item("nome")
                txtValor.Text = FormatCurrency(dr.Item("valor"))
                ' lblPago.Text = dr.Item("Pago")
                txtVencimento.Text = dr.Item("DataVencimento")
                txtDataEntrada.Text = dr.Item("data_cadastro")
                txtSituacao.Text = dr.Item("situacao")

            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas  " + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub
    Private Sub CarregarDGrid()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_ParcelasGravar_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@numDocto", txtNDoc.Text)

            da.Fill(dt)
            dgvParcelas.DataSource = dt

            FormatarDG()



        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Parcelas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub dgvParcelas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParcelas.CellClick

        If dgvParcelas.CurrentRow.Cells(7).Value = 1 Then
            MsgBox("Esta Parcela já foi paga")
            Exit Sub
        Else
            lblNrParcela.Text = dgvParcelas.CurrentRow.Cells(0).Value
            txtNumParcela.Text = dgvParcelas.CurrentRow.Cells(3).Value
            lblVlrParcelas.Text = dgvParcelas.CurrentRow.Cells(4).Value
            txtValorParcela.Text = dgvParcelas.CurrentRow.Cells(4).Value
            dtpVencimentoParcela.Text = dgvParcelas.CurrentRow.Cells(5).Value
            lblSaldoAtualizado.Text = dgvParcelas.CurrentRow.Cells(10).Value

            Dim vParcela As Double
            Dim saldoAtual As Double
            Dim Resultado As Double
            'Dim As Double
            'vParcela = lblVlrParcelas.Text

            'saldoAtual = lblSaldoAtualizado.Text
            'Resultado = CDbl(saldoAtual - vParcela)
            'txtSaldoAtual.Text = CDbl(Resultado).ToString("C2")
        End If


    End Sub

    Private Sub FormatarDG()

        With dgvParcelas
            .Columns(0).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Documento"
            .Columns(2).HeaderText = "Vlr. Total"
            .Columns(3).HeaderText = "Parcelas"
            .Columns(4).HeaderText = "Valor Parcela"
            .Columns(5).HeaderText = "Data Parcela"
            .Columns(6).HeaderText = "Situação"
            .Columns(7).HeaderText = "Pago"
            .Columns(8).HeaderText = "Valor Pago"
            .Columns(9).HeaderText = "Data Pgto"
            .Columns(10).HeaderText = "Saldo Restante"
            .Columns(11).HeaderText = "id_categoria"
            .Columns(12).HeaderText = "id_fornecedor"
            .Columns(13).HeaderText = "idConta"

            .Columns(0).Width = 50
            .Columns(1).Width = 100
            .Columns(2).Width = 120
            .Columns(3).Width = 70
            .Columns(4).Width = 130
            .Columns(5).Width = 90
            .Columns(6).Width = 100
            .Columns(7).Width = 50
            .Columns(8).Width = 130
            .Columns(9).Width = 90
            .Columns(10).Width = 130
        End With

    End Sub

    Private Sub txtValorParcela_TextChanged(sender As Object, e As EventArgs) Handles txtValorParcela.TextChanged
        txtValorParcela.Text = FormatCurrency(txtValorParcela.Text)
    End Sub

    Private Sub txtValoraPagar_TextChanged(sender As Object, e As EventArgs) Handles txtValorPago.TextChanged
        txtValorPago.Text = FormatCurrency(txtValorPago.Text)
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub txtPagamento_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        If txtPagamento.Text > txtVencimento.Text Then
            txtDesconto.Enabled = False
            txtJuros.Enabled = True
            txtValorPago.Text = ""
        ElseIf txtPagamento.Text < txtVencimento.Text Then
            txtDesconto.Enabled = True
            txtJuros.Enabled = False
            txtValorPago.Text = ""
        ElseIf txtPagamento.Text = txtVencimento.Text Then
            txtDesconto.Enabled = False
            txtJuros.Enabled = False
            txtValorPago.Text = ""
        End If
    End Sub


    Private Sub btBaixarConta_Click(sender As Object, e As EventArgs) Handles btBaixarConta.Click
        Dim sql As String
        Dim cmd As SqlCommand
        Dim cmd2 As SqlCommand

        Dim vTotal As Double
        vTotal = CDbl(txtValor.Text)
        valorDaParcela = CDbl(txtValorParcela.Text)
        valorRestante = vTotal - valorDaParcela
        txtSaldoRestante.Text = CDbl(valorRestante).ToString("c")
        Try
            abrir()

            cmd = New SqlCommand("pa_Parcelas_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_parcela", lblNrParcela.Text)
            cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
            cmd.Parameters.AddWithValue("@parcela", txtNumParcela.Text)
            cmd.Parameters.AddWithValue("@situacao", "Pago")
            cmd.Parameters.AddWithValue("@Pago", True)
            cmd.Parameters.AddWithValue("@valorPago", txtValorPago.Text)
            cmd.Parameters.AddWithValue("@data_pagamento", Now.ToShortDateString)
            cmd.Parameters.AddWithValue("@saldoRestante", txtSaldoRestante.Text)
            cmd.Parameters.AddWithValue("@juros", lblJuros.Text)
            cmd.Parameters.AddWithValue("@desconto", lblDesconto.Text)
            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            '==================================================================================================================================================================
            '========================================================================================================================================================


            cmd2 = New SqlCommand("pa_ParcelasPagas_Salvar", con)
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.Parameters.AddWithValue("@id_parcela", lblNrParcela.Text)
            cmd2.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
            cmd2.Parameters.AddWithValue("@valorTotal", txtValor.Text)
            cmd2.Parameters.AddWithValue("@parcela", txtNumParcela.Text)
            cmd2.Parameters.AddWithValue("@valor_parcela", txtValorParcela.Text)
            cmd2.Parameters.AddWithValue("@data_parcela", dtpVencimentoParcela.Text)
            cmd2.Parameters.AddWithValue("@situacao", "Pago")
            cmd2.Parameters.AddWithValue("@Pago", True)
            cmd2.Parameters.AddWithValue("@valorPago", txtValorPago.Text)
            cmd2.Parameters.AddWithValue("@data_pagamento", Now.ToShortDateString)
            cmd2.Parameters.AddWithValue("@saldoRestante", txtSaldoRestante.Text)
            cmd2.Parameters.AddWithValue("@juros", lblJuros.Text)
            cmd2.Parameters.AddWithValue("@desconto", lblDesconto.Text)
            cmd2.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd2.ExecuteNonQuery()

            Dim msg2 As String = cmd2.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg2, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
        Finally
            fechar()
        End Try
        Me.Close()
    End Sub

    'Calcula a taxas de descontos, juros
    Private Sub calcular()

        valorDaParcela = txtValorParcela.Text
        'valorDaParcela = txtValorParcela.Text

        vencimentoParcela = dtpVencimentoParcela.Value.Date
        pagamentoDaParcela = txtPagamento.Value.Date

        If pagamentoDaParcela > vencimentoParcela Then
            numerodias = pagamentoDaParcela.Subtract(vencimentoParcela)
            Dim taxaJuros As Double = CDbl(txtJuros.Text) / 100
            juros = CDbl(valorDaParcela * numerodias.Days * taxaJuros)
            desconto = 0
            txtValorPago.Text = CDbl(valorDaParcela + juros).ToString("c")
            lblJuros.Text = CDbl(juros).ToString("c")

        ElseIf pagamentoDaParcela < vencimentoParcela Then
            Dim taxaDesconto As Double = CDbl(txtDesconto.Text) / 100
            desconto = CDbl(valorDaParcela * taxaDesconto)
            juros = 0
            txtValorPago.Text = CDbl(valorDaParcela - desconto).ToString("c")
            lblDesconto.Text = CDbl(desconto).ToString("c")
        Else
            juros = 0
            desconto = 0
            txtValorPago.Text = valorDaParcela.ToString("c")
        End If

        calculoValorResto()

    End Sub

    Private Sub calculoValorResto()
        valorRestante = txtValor.Text
        Dim valorpago As Integer = txtValorParcela.Text

        txtSaldoRestante.Text = CDbl(valorRestante - valorpago).ToString("c")
    End Sub

    Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        If txtValorParcela.Text = "" Then
            MsgBox("Informe o valor para aplicar o Desconto/Juros referente a esta mensalidade.",
                   MsgBoxStyle.Information, "CS .Net Tecnologia")
            ' txtValorParcela.Focus()
            Exit Sub
        End If

        If txtPagamento.Value > dtpVencimentoParcela.Value Then
            txtDesconto.Enabled = False
            txtJuros.Enabled = True
            calcularJuros = True
            calcularDesconto = False
        Else
            If txtPagamento.Value < dtpVencimentoParcela.Value Then
                txtDesconto.Enabled = True
                txtJuros.Enabled = False
                calcularDesconto = True
                calcularJuros = False
            Else
                If txtPagamento.Value = dtpVencimentoParcela.Value Then
                    txtDesconto.Enabled = False
                    txtJuros.Enabled = False
                    calcularJuros = False
                    calcularDesconto = False
                End If
            End If
        End If

        'Calcula a taxas de descontos, juros
        calcular()
    End Sub

    Private Sub btEmDia_Click(sender As Object, e As EventArgs)
        txtPagamento.Value = dtpVencimentoParcela.Value
    End Sub



    '   Private Sub cboParcela_SelectedIndexChanged(sender As Object, e As EventArgs)

    'Dim DT As New DataTable
    'Dim DA As SqlDataAdapter
    'Try
    '    abrir()
    '    Obj_parcela.parcela = cboParcela.Text
    '    ds = Obj_parcela.ConsularIDParcela()

    '    DT = ds.Tables(0)

    '    If DT.Rows.Count > 0 Then

    '        lblIdparcela.Text = ds.Tables(0).Rows(0).Item(0)

    '    End If

    'Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
    'Finally
    '    fechar()
    'End Try
    '  End Sub

    ' Public Function ObterProximaParcela(idConta As Integer) As Integer

    '    Dim proximaParcela As Integer = 0
    '    Dim cmd As SqlCommand
    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter

    '    Try
    '        abrir()

    '        ' da = New SqlDataAdapter("SELECT TOP 1 (parcela) FROM tbParcelasPagar_Gravar WHERE situacao = 'PENDENTE'", con)
    '        ' da.SelectCommand.CommandType = CommandType.StoredProcedure
    '        '   da.SelectCommand.Parameters.AddWithValue("@data", Now.Date())
    '        Dim sql As String = "SELECT TOP 1 (parcela) FROM tbParcelasPagar_Gravar WHERE situacao = 'PENDENTE' and @IdConta=" & idConta

    '        cmd = New SqlCommand(sql, con)

    '        cmd.Parameters.AddWithValue("@IdConta", idConta)
    '        Dim result = cmd.ExecuteScalar()

    '        If result IsNot Nothing Then
    '            proximaParcela = Convert.ToInt32(result)
    '        End If


    '    Catch ex As Exception
    '        MessageBox.Show("Erro ao Listar as Vendas" + ex.Message.ToString)
    '    Finally
    '        fechar()
    '    End Try

    '    Return proximaParcela

    'End Function


End Class

