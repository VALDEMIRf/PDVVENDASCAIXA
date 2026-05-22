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

        If intCodigoLancamento <> 0 Then
            lblCodigo.Text = intCodigoLancamento

            CarregarDados()

        Else
            lblCodigo.Text = "Novo"
        End If

        CarregarDGrid()
    End Sub

    Private Sub frmBaixarContaPagar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CarregarDGrid()
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

    Sub ultimoValor()
        Dim dr As SqlDataReader = Nothing
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim numIDParcela2 As Integer
        Dim numIDParcela As Integer

        If txtNumParcela.Text = 1 Then
            txtAtualizarSaldo.Text = txtValor.Text
        Else
            numIDParcela = lblNrParcela.Text
            numIDParcela2 = numIDParcela - 1

            Try
                abrir()

                Dim sql As String = "pa_ParcelasPagasValorRestante " & CInt(numIDParcela2)
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    txtAtualizarSaldo.Text = dr.Item("saldoRestante")

                End If

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar o saldo Restante  " + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub

    Private Sub dgvParcelas_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        If dgvParcelas.CurrentRow.Cells(7).Value = True Then
            MsgBox("Esta Parcela já foi paga")
            Exit Sub
        Else
            lblNrParcela.Text = dgvParcelas.CurrentRow.Cells(0).Value
            txtAtualizarSaldo.Text = dgvParcelas.CurrentRow.Cells(2).Value
            txtNumParcela.Text = dgvParcelas.CurrentRow.Cells(3).Value
            lblVlrParcelas.Text = dgvParcelas.CurrentRow.Cells(4).Value
            txtValorParcela.Text = dgvParcelas.CurrentRow.Cells(4).Value
            dtpVencimentoParcela.Text = dgvParcelas.CurrentRow.Cells(5).Value
            lblSaldoAtualizado.Text = dgvParcelas.CurrentRow.Cells(10).Value

            ultimoValor()
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

            For Each row As DataGridViewRow In .Rows
                If row.Cells("situacao").Value = "Pago" Then
                    row.DefaultCellStyle.BackColor = Color.Green

                End If
            Next


        End With

    End Sub

    Private Sub txtValorParcela_TextChanged(sender As Object, e As EventArgs)
        txtValorParcela.Text = FormatCurrency(txtValorParcela.Text)
    End Sub

    Private Sub txtValoraPagar_TextChanged(sender As Object, e As EventArgs)
        txtValorPago.Text = FormatCurrency(txtValorPago.Text)
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs)
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

    Private Sub btBaixarConta_Click(sender As Object, e As EventArgs)
        Dim sql As String
        Dim cmd As SqlCommand
        Dim cmd2 As SqlCommand

        Dim vTotal As Double

        vTotal = CDbl(txtAtualizarSaldo.Text)
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
            cmd.ExecuteNonQuery()

            MsgBox("PARCELA SALVA!")

            ' salvarParcelaPaga()
            baixarContaFinal()

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub baixarContaFinal()
        Dim cmd As SqlCommand

        If txtSaldoRestante.Text > 0 Then
            Exit Sub

        ElseIf txtSaldoRestante.Text = 0 Then

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

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar esta conta" + ex.Message.ToString)
            Finally

                fechar()
            End Try

        End If

        Me.Close()
    End Sub

    'Calcula a taxas de descontos, juros
    Private Sub calcular()

        valorDaParcela = txtValorParcela.Text

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
        valorRestante = txtAtualizarSaldo.Text
        Dim valorpago As Integer = txtValorParcela.Text

        txtSaldoRestante.Text = CDbl(valorRestante - valorpago).ToString("c")

    End Sub

    Private Sub btCalcular_Click(sender As Object, e As EventArgs)
        If txtValorParcela.Text = "" Then
            MsgBox("Informe o valor para aplicar o Desconto/Juros referente a esta mensalidade.",
                   MsgBoxStyle.Information, "VAL.Net Tecnologia")

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

    Private Sub btSair_Click_1(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub


End Class

