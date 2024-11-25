Imports System.Data.SqlClient

Public Class frmBaixarContaPagar

    'Dim f1 As frmLancamentoContasPagar

    'Public Sub New(ByVal frm1 As frmLancamentoContasPagar)

    '    ' Esta chamada é requerida pelo designer.
    '    InitializeComponent()

    '    ' Adicione qualquer inicialização após a chamada InitializeComponent().

    '    f1 = frm1

    'End Sub

    Private Sub frmBaixarContaPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        Listar1()

        If intCodigoLancamento <> 0 Then
            lblCodigo.Text = intCodigoLancamento

            CarregarFornecedor()

            '  CarregarDados()


            'txtDataEntrada.Text = f1.txtDataEntrada.Text
        End If
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


    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasReceber_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.Fill(dt)
            dg.DataSource = dt

            '  ContarLinhas()

            '  FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os clientes" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    Private Sub Listar1()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasReceber_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.Fill(dt)
            dg1.DataSource = dt

            '  ContarLinhas()

            '  FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os clientes" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    'Private Sub CarregarDados()
    '    Dim dr As SqlDataReader = Nothing
    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter

    '    Try
    '        abrir()
    '        Dim sql As String = "pa_Parcelas_listarID " & CInt(intCodigoLancamento)
    '        ' Dim sql As String = "SELECT * FROM tbContasPagar WHERE id_conta=" & CInt(txtCodigo.Text)
    '        Dim cmd As SqlCommand = New SqlCommand(sql, con)
    '        ' cmd.CommandText = CommandType.StoredProcedure
    '        ' cmd.Parameters.AddWithValue("@id_conta", txtCodigo.Text)
    '        dr = cmd.ExecuteReader(CommandBehavior.SingleRow)


    '        If dr.HasRows Then
    '            dr.Read()
    '            lbtxtNumParcela.Text = dr.Item("parcela")
    '            txtVencimento.Text = dr.Item("data_parcela")
    '            '  dataEntrada.Text = 
    '            lbtxtValorParcela.Text = dr.Item("valor_parcela")
    '            txtValorParcela.Text = dr.Item("valor_parcela")
    '            txtDocumento.Text = dr.Item("numDocto")
    '            txtDescricao.Text = dr.Item("descricao")
    '            lbtxtValorTotal.Text = dr.Item("valorTotal")
    '            txtSituacao.Text = dr.Item("situacao")

    '        Else

    '            MsgBox("Não foi posssível carregar os Dados.!", MsgBoxStyle.Critical, "Contas a Pagar")

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
    '    Finally
    '        fechar()
    '    End Try

    'End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
    End Sub

    'Private Sub txtSaldoRestante_TextChanged(sender As Object, e As EventArgs) Handles txtSaldoRestante.TextChanged




    'End Sub

    'Private Sub lbtxtSaldoRestante_Click(sender As Object, e As EventArgs) Handles lbtxtSaldoRestante.Click
    '    'Dim valorTotal As Decimal
    '    'Dim valorParcela As Decimal
    '    'Dim valorPago As Decimal
    '    'Dim saldoRestante As Decimal
    '    'Dim res As Decimal

    '    'valorTotal = lbtxtValorTotal.Text
    '    'valorParcela = lbtxtValorParcela.Text
    '    'valorPago = txtValorPago.Text

    '    ''txtJuros.Text
    '    '' txtDesconto.Text

    '    'res = valorParcela - valorPago
    '    'saldoRestante = valorTotal - res

    '    '    lbtxtSaldoRestante.Text = saldoRestante





    'End Sub

    'Private Sub txtValorPago_TextChanged(sender As Object, e As EventArgs) Handles txtValorPago.TextChanged
    '    If lbtxtValorParcela.Text <> "0" And txtValorPago.Text <> "" Then
    '        Dim subTotal As Decimal
    '        Dim pago As Decimal
    '        Dim total As Decimal
    '        'subTotal = lbtxtValorParcela.Text
    '        'pago = txtValorPago.Text
    '        'total = subTotal - pago
    '        'lbtxtSaldoRestante.Text = total
    '    End If


    '    '    Dim resultado As Double
    '    '    resultado = CDbl(txtValorParcela.Text) + CDbl(txtValorPago.Text)
    '    '    MessageBox.Show(CStr(FormatNumber(resultado)))
    '    '    MessageBox.Show(CStr(FormatCurrency(resultado)))
    'End Sub

    'Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
    '    Dim valorTotal As Decimal
    '    Dim valorParcela As Decimal
    '    Dim valorPago As Decimal
    '    Dim saldoRestante As Decimal
    '    Dim res As Decimal

    '    valorTotal = lbtxtValorTotal.Text
    '    valorParcela = lbtxtValorParcela.Text
    '    valorPago = txtValorPago.Text


    '    ''txtJuros.Text
    '    '' txtDesconto.Text

    '    res = valorParcela - valorPago
    '    saldoRestante = valorTotal - res

    '    lbtxtSaldoRestante.Text = saldoRestante
    'End Sub

    'Private Sub txtJuros_TextChanged(sender As Object, e As EventArgs) Handles txtJuros.TextChanged
    '    If lbtxtValorParcela.Text <> "0" And txtJuros.Text <> "" Then
    '        Dim subTotal As Decimal
    '        Dim jur As Decimal
    '        Dim total As Decimal
    '        'subTotal = lbtxtValorParcela.Text
    '        'pago = txtValorPago.Text
    '        'total = subTotal - pago
    '        'lbtxtSaldoRestante.Text = total
    '    End If
    'End Sub

    'Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
    '    If lbtxtValorParcela.Text <> "0" And txtValorPago.Text <> "" Then
    '        Dim subTotal As Decimal
    '        Dim pago As Decimal
    '        Dim total As Decimal
    '        'subTotal = lbtxtValorParcela.Text
    '        'pago = txtValorPago.Text
    '        'total = subTotal - pago
    '        'lbtxtSaldoRestante.Text = total
    '    End If
    'End Sub
End Class