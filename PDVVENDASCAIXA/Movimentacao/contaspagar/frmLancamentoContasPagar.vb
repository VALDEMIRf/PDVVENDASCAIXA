Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmLancamentoContasPagar

    Dim parc As New Parcelas

    Private Sub frmLancamentoContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rbParcelamento.Checked = False

        carregarContas()
        CarregarFornecedor()
        caregarFormaPagamento()

        If intCodigoLancamento <> 0 Then
            txtCodigo.Text = intCodigoLancamento

            CarregarDados()
        Else
            txtCodigo.Text = "Novo"
        End If
    End Sub

    Private Sub frmLancamentoContasPagar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        listarParcelas()
        carregarContas()
        CarregarFornecedor()
        caregarFormaPagamento()
        CarregarDados()
    End Sub

    Dim _Codigo As Integer
    Public Property Codigo() As Integer
        Get
            Return _Codigo

        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

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
                lblPago.Text = dr.Item("Pago")
                txtVencimento.Text = dr.Item("DataVencimento")
                txtDataEntrada.Text = dr.Item("data_cadastro")
                txtSituacao.Text = dr.Item("situacao")

            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados desta conta" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub txtValor_LostFocus(sender As Object, e As System.EventArgs)
        txtValor.Text = FormatCurrency(txtValor.Text)
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
    End Sub

    Private Sub DesabilitarCampos()

        txtCodigo.Enabled = False
        txtNDoc.Enabled = False
        txtConta.Enabled = False
        txtFornecedor.Enabled = False
        ' txtDescricao.Enabled = False
        txtFormaPagto.Enabled = False
        txtValor.Enabled = False

        ' txtParcela.Enabled = False
        txtValorParcelas.Enabled = False
        txtVencimento.Enabled = False
        mskData.Enabled = False
        txtDesconto.Enabled = False
        txtJuros.Enabled = False
        '  txtValoraPagar.Enabled = False
        txtSituacao.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNDoc.Focus()
        txtCodigo.Enabled = True
        txtNDoc.Enabled = True
        txtConta.Enabled = True
        txtFornecedor.Enabled = True
        '  txtDescricao.Enabled = True
        txtFormaPagto.Enabled = True
        txtValor.Enabled = True

        ' txtParcela.Enabled = True
        txtValorParcelas.Enabled = True
        txtVencimento.Enabled = True
        mskData.Enabled = True
        txtDesconto.Enabled = True
        txtJuros.Enabled = True
        ' txtValoraPagar.Enabled = True
        txtSituacao.Enabled = True
    End Sub

    Private Sub Limpar()
        'txtNDoc.Focus()


        'txtCodigo.Text = ""
        'txtNDoc.Text = ""
        'txtConta.Text = Nothing
        'txtFornecedor.Text = Nothing
        'txtDescricao.Text = ""
        'txtFormaPagto.Text = Nothing
        'txtValor.Text = ""
        'txtObs.Text = ""
        ''txtParcela.Text = ""
        'txtDataEntrada.Text = ""
        'txtVencimento.Text = ""
        '' mskData.Text = ""
        'txtDesconto.Text = ""
        'txtJuros.Text = ""
        '' txtValoraPago.Text = ""
        'txtValorPago.Text = ""
        'txtSituacao.Text = Nothing
    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        If txtValor.Text <> "0" And txtDesconto.Text <> "" Then

            Dim desc As Decimal
            ' Dim jur As Decimal
            Dim valor1 As Decimal
            Dim valorTotal As Decimal
            Try
                lblCodigoConta.Text = txtDesconto.Text
                lblPago.Text = txtValor.Text

                desc = lblCodigoConta.Text
                valor1 = lblPago.Text
                valorTotal = valor1 - desc

            Catch ex As Exception
            End Try
        Else
            txtDesconto.Text = 0
        End If

    End Sub

    Private Sub txtJuros_TextChanged_1(sender As Object, e As EventArgs) Handles txtJuros.TextChanged
        If txtValor.Text <> "0" And txtJuros.Text <> "" Then

            Dim jur As Decimal
            Dim valor1 As Decimal
            Dim valorTotal As Decimal
            Try
                ' lblJuros.Text = txtJuros.Text
                lblPago.Text = txtValor.Text

                jur = txtJuros.Text
                valor1 = lblPago.Text
                valorTotal = valor1 + jur

            Catch ex As Exception
            End Try
        Else
            txtJuros.Text = 0
        End If
    End Sub

    Private Sub txtParcela_KeyPress(sender As Object, e As KeyPressEventArgs)
        permiteSoNumeros(sender, e)
    End Sub


    Private Sub btGerarParcelas_Click(sender As Object, e As EventArgs) Handles btGerarParcelas.Click

        dgvParcelas.Rows.Clear()


        Dim venc As DateTime = mskData.Text
        Dim ValorTotal, valorParcela, valorDesconto, valorJuros As Double
        Dim situacao = txtSituacao.Text

        Dim situacaoPagto As String
        If lblPago.Text = False Then
            situacaoPagto = "Não"
        Else
            situacaoPagto = "Sim"
        End If


        'Calcular valor de cada Parcela

        ValorTotal = txtValorParcelas.Text
        valorDesconto = txtDesconto.Text
        valorJuros = txtJuros.Text

        valorParcela = FormatCurrency(ValorTotal / txtNumeroPacelas.Text)

        Try

            For i = 0 To Val(txtNumeroPacelas.Text) - 1

                Dim novaParcela As DateTime

                novaParcela = venc.AddDays(i * 30)

                If novaParcela.DayOfWeek = DayOfWeek.Sunday Then
                    novaParcela = novaParcela.AddDays(1)
                ElseIf novaParcela.DayOfWeek = DayOfWeek.Saturday Then
                    novaParcela = novaParcela.AddDays(2)
                End If

                ' dgvParcelas.Rows.Add(i + 1, Mid(novaParcela.ToString, 1, 10), FormatCurrency(valorParcela), txtNDoc.Text, txtDescricao.Text, txtValor.Text, situacao, txtCodigo.Text)
                dgvParcelas.Rows.Add(txtCodigo.Text, i + 1, Mid(novaParcela.ToString, 1, 10), FormatCurrency(valorParcela), txtNDoc.Text, situacaoPagto, FormatCurrency(ValorTotal), txtSituacao.Text, txtSaldoRestante.Text, txtFornecedor.SelectedValue, lblCodigoConta.Text)

            Next

            btGravarParcelas.Enabled = True

        Catch ex As Exception
            MsgBox("Erro ao calcular pagamento  " + ex.Message.ToString, MsgBoxStyle.Critical, "Atenção")
        End Try


    End Sub

    Private Sub listarParcelas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_Parcelas_listar", con) '
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@numDocto", txtNDoc.Text)

            da.Fill(dt)
            ' dgvBaixarConta.DataSource = dt

            'FormatarParcelasDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Parcelas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub btGravarParcelas_Click(sender As Object, e As EventArgs) Handles btGravarParcelas.Click
        Dim ano, mes, dia, parcela As Integer
        Dim dr As Date
        Dim d, data_parcela As String
        Dim valor_parcela As Decimal
        Dim cmd As SqlCommand
        Dim cmd2 As SqlCommand

        Try
            abrir()

            Dim numlinhas As Integer = dgvParcelas.RowCount - 1
            Dim cont As Integer = 0
            Dim Pvalor As String = txtValor.Text
            'Insere no banco de dados as parcelas geradas no DataGrid
            While (cont <= numlinhas)
                dr = Me.dgvParcelas.Item(2, cont).Value
                dia = dr.Day
                mes = dr.Month
                ano = dr.Year
                d = ano & "-" & mes & "-" & dia

                If txtNDoc.Text <> "" Then

                    cmd = New SqlCommand("pa_Parcelas_Salvar", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@id_categoriacontas", txtConta.SelectedValue)
                    cmd.Parameters.AddWithValue("@parcela", Me.dgvParcelas.Item(1, cont).Value)
                    cmd.Parameters.AddWithValue("@data_parcela", d)
                    cmd.Parameters.AddWithValue("@valor_parcela", Me.dgvParcelas.Item(3, cont).Value)
                    cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                    cmd.Parameters.AddWithValue("@Pago", lblPago.Text)
                    cmd.Parameters.AddWithValue("@valorTotal", txtValor.Text)
                    cmd.Parameters.AddWithValue("@situacao", "Pendente")
                    cmd.Parameters.AddWithValue("@saldoRestante", txtValor.Text)
                    cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue)
                    cmd.Parameters.AddWithValue("@idConta", lblCodigoConta.Text)
                    cmd.Parameters.AddWithValue("@valorPago", "")
                    cmd.Parameters.AddWithValue("@data_pagamento", "")
                    cmd.Parameters.AddWithValue("@juros", "")
                    cmd.Parameters.AddWithValue("@desconto", "")
                    cmd.ExecuteNonQuery()

                End If

                cont = cont + 1

            End While

            MsgBox("Parcelas gravadas com sucesso!", MsgBoxStyle.Information, "Sucesso")

            atualizarSituacao()

        Catch ex As Exception
            MsgBox("Erro ao registrar as Parcelas!" + ex.Message.ToString, MsgBoxStyle.Critical, "Erro")
        Finally
            fechar()
        End Try
    End Sub

    Public Sub atualizarSituacao()
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("pa_ContasPagar_EditarSituacao", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", txtCodigo.Text)
            cmd.Parameters.AddWithValue("@situacao", "Em Parcelamento")
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub txtJuros_Leave(sender As Object, e As EventArgs)
        Dim num As Decimal = Convert.ToDecimal(txtJuros.Text)
        txtJuros.Text = num.ToString("N2")
    End Sub

    Private Sub txtDesconto_Leave(sender As Object, e As EventArgs) Handles txtDesconto.Leave
        Dim num As Decimal = Convert.ToDecimal(txtDesconto.Text)
        txtDesconto.Text = num.ToString("N2")
    End Sub

    Private Sub txtValorParcelas_Leave(sender As Object, e As EventArgs) Handles txtValorParcelas.Leave
        Dim num As Decimal = Convert.ToDecimal(txtValorParcelas.Text)
        txtValorParcelas.Text = num.ToString("N2")
    End Sub

    Private Sub txtSaldoRestante_Leave(sender As Object, e As EventArgs) Handles txtSaldoRestante.Leave
        Dim num As Decimal = Convert.ToDecimal(txtSaldoRestante.Text)
        txtSaldoRestante.Text = num.ToString("N2")
    End Sub


    Private Sub txtNumeroPacelas_TextChanged(sender As Object, e As EventArgs)
        permiteSoNumeros(sender, e)
        'txtValorParcelas.Text = txtValor.Text
    End Sub

    Private Sub rbParcelamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbParcelamento.CheckedChanged
        ' If txtSituacao.Text = "Em Parcelamento" Then
        If rbParcelamento.Checked = True Then

            txtValorParcelas.Text = txtValor.Text

            txtNumeroPacelas.Enabled = True
            mskData.Enabled = True
            btGerarParcelas.Enabled = True
        Else

            txtNumeroPacelas.Enabled = False
            mskData.Enabled = False
            btGerarParcelas.Enabled = False

        End If
    End Sub

End Class

