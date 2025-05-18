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

    Private Sub frmBaixarContaPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarContas()
        CarregarFornecedor()
        caregarFormaPagamento()

        If intCodigoBaixa <> 0 Then
            txtCodigoParcela.Text = intCodigoBaixa

            CarregarDados()
        Else
            txtCodigoParcela.Text = "Novo"
        End If
        txtDescricao.Text = My.Forms.frmLancamentoContasPagar.txtDescricao.Text
        txtVencimento.Text = My.Forms.frmLancamentoContasPagar.txtVencimento.Text
        txtSituacao.Text = My.Forms.frmLancamentoContasPagar.txtSituacao.Text
        txtFormaPagto.Text = My.Forms.frmLancamentoContasPagar.txtFormaPagto.Text
        txtFornecedor.Text = My.Forms.frmLancamentoContasPagar.txtFornecedor.Text
        txtConta.Text = My.Forms.frmLancamentoContasPagar.txtConta.Text
        lblCodigo.Text = My.Forms.frmLancamentoContasPagar.txtCodigo.Text
        dtpVencimentoParcela.Value = My.Forms.frmLancamentoContasPagar.txtVencimento.Text
        lblRecebeValorTotal.Text = My.Forms.frmLancamentoContasPagar.txtValor.Text

        'lblCodigo.Text = intCodigoBaixa
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

            Dim sql As String = "pa_Parcelas_listarID " & CInt(intCodigoBaixa)
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)


            If dr.HasRows Then
                dr.Read()
                txtNDoc.Text = dr.Item("numDocto")
                txtSituacao.Text = dr.Item("situacao")
                txtDescricao.Text = dr.Item("descricao")
                txtValorParcela.Text = dr.Item("valor_parcela")
                lblNrParcela.Text = dr.Item("parcela")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
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

    Private Sub txtPagamento_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPagamento.MaskInputRejected
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

    Private Sub txtPagamento_TextChanged(sender As Object, e As EventArgs) Handles txtPagamento.TextChanged

    End Sub

    Private Sub btBaixarConta_Click(sender As Object, e As EventArgs) Handles btBaixarConta.Click
        Dim sql As String
        Dim cmd As SqlCommand
        Dim observacaoParcela As String = txtObs.Text

        If txtValorPago.Text = String.Empty Then
            MsgBox("Por favor informe o valor do pagamento.", MsgBoxStyle.Information, "VALDEMIR")
            txtValorPago.Focus()
            Exit Sub
        End If


        Try
            abrir()

            cmd = New SqlCommand("pa_Parcelas_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_parcela", txtCodigoParcela.Text)
            cmd.Parameters.AddWithValue("@parcela", lblNrParcela.Text)
            cmd.Parameters.AddWithValue("@data_parcela", dtpVencimentoParcela.Value)
            cmd.Parameters.AddWithValue("@valor_parcela", txtValorParcela.Text)
            cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
            cmd.Parameters.AddWithValue("@valorTotal", lblRecebeValorTotal.Text)
            cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
            cmd.Parameters.AddWithValue("@saldoRestante", txtSaldoRestante.Text)
            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            inseriParcelaPaga()

        Catch ex As Exception
            Throw ex
        Finally
            fechar()
        End Try

    End Sub

    Private Sub inseriParcelaPaga()
        Dim cmd As SqlCommand

        If txtCodigoParcela.Text <> "" Then

            Try

                abrir()
                cmd = New SqlCommand("pa_ParcelasPagas_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_conta", lblCodigo.Text)
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtConta.SelectedValue)
                cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@codparcela", txtCodigoParcela.Text)
                cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@valorParcela", txtValorParcela.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.AddWithValue("@vencimento", dtpVencimentoParcela.Value)
                cmd.Parameters.AddWithValue("@datapagamento", dtpPagamentoParcela.Value)
                cmd.Parameters.AddWithValue("@desconto", txtDesconto.Text)
                cmd.Parameters.AddWithValue("@juros", txtJuros.Text)
                cmd.Parameters.AddWithValue("@valorpago", txtValorPago.Text)
                cmd.Parameters.AddWithValue("@saldoRestante", txtSaldoRestante.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        End If
    End Sub

    'Calcula a taxas de descontos, juros
    Private Sub calcular()

        valorDaParcela = CDbl(txtValorParcela.Text)

        vencimentoParcela = dtpVencimentoParcela.Value.Date
        pagamentoDaParcela = dtpPagamentoParcela.Value.Date

        If pagamentoDaParcela > vencimentoParcela Then
            numerodias = pagamentoDaParcela.Subtract(vencimentoParcela)
        End If

        If calcularJuros Then
            Dim taxaJuros As Double = CDbl(txtJuros.Text) / 100
            juros = CDbl(valorDaParcela * numerodias.Days * taxaJuros)
            desconto = 0
            txtValorPago.Text = CDbl(valorDaParcela + juros).ToString("c")
        Else
            If calcularDesconto Then
                Dim taxaDesconto As Double = CDbl(txtDesconto.Text) / 100
                desconto = CDbl(valorDaParcela * taxaDesconto)
                juros = 0
                txtValorPago.Text = CDbl(valorDaParcela - desconto).ToString("c")
            Else
                juros = 0
                desconto = 0
                txtValorPago.Text = valorDaParcela.ToString("c")
            End If
        End If



        calculoValorResto()


    End Sub

    Private Sub calculoValorResto()
        valorRestante = CDbl(lblRecebeValorTotal.Text)
        Dim saldoRestante As Double = CDbl(txtValorPago.Text)
        'Dim v As String
        'Dim p As String
        'v = lblRecebeValorTotal.Text
        'p = txtValorPago.Text
        'recebeValor = v - p
        txtSaldoRestante.Text = CDbl(valorRestante - saldoRestante).ToString("c")
    End Sub

    Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        If txtValorParcela.Text = "" Then
            MsgBox("Informe o valor para aplicar o Desconto/Juros referente a esta mensalidade.",
                   MsgBoxStyle.Information, "CS .Net Tecnologia")
            txtValorParcela.Focus()
            Exit Sub
        End If

        If dtpPagamentoParcela.Value > dtpVencimentoParcela.Value Then
            txtDesconto.Enabled = False
            txtJuros.Enabled = True
            calcularJuros = True
            calcularDesconto = False
        Else
            If dtpPagamentoParcela.Value < dtpVencimentoParcela.Value Then
                txtDesconto.Enabled = True
                txtJuros.Enabled = False
                calcularDesconto = True
                calcularJuros = False
            Else
                If dtpPagamentoParcela.Value = dtpVencimentoParcela.Value Then
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

    Private Sub btEmDia_Click(sender As Object, e As EventArgs) Handles btEmDia.Click
        dtpPagamentoParcela.Value = dtpVencimentoParcela.Value
    End Sub
End Class

