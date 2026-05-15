Imports System.Data.SqlClient

Public Class frmBaixarContaReceber

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

    Private Sub frmBaixarContaReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarContas()
        CarregarClientes()
        caregarFormaPagamento()
        carregarQtdParcela()

        If intCodigoLancamento <> 0 Then
            lblCodigo.Text = intCodigoLancamento

            CarregarDados()
        Else
            lblCodigo.Text = "Novo"
        End If

        Dim parc As Integer = ObterProximaParcela(0)

        MessageBox.Show("A próxima parcela a ser paga é:  " & parc & " .Antes de fazer o cálculo do parcelamento selecione primeiro a parcela:  " & parc)
    End Sub

    Sub carregarQtdParcela()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()

            DA = New SqlDataAdapter("parcelasPagar_listarParcelas", con)
            DA.Fill(DT)
            cboParcela.DisplayMember = "parcela"
            cboParcela.ValueMember = "id_parcela"
            cboParcela.DataSource = DT

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

    Sub CarregarClientes()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbClientes", con) 
            DA = New SqlDataAdapter("pa_cliente_listar", con)
            DA.Fill(DT)
            txtCliente.DisplayMember = "nome"
            txtCliente.ValueMember = "id_cliente"
            txtCliente.DataSource = DT

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

            Dim sql As String = "pa_ParcelasReceber_listarID"
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

            If dr.HasRows Then
                dr.Read()
                lblCodigo.Text = dr.Item("id_parcela")
                lblCodigoConta.Text = dr.Item("idConta")
                lblIdparcela.Text = dr.Item("id_parcela")
                txtNDoc.Text = dr.Item("numDocto")
                txtConta.Text = dr.Item("id_categoriacontas")
                txtCliente.Text = dr.Item("id_cliente")
                txtFormaPagto.Text = dr.Item("id_formaPag")
                txtValor.Text = dr.Item("valorTotal")
                txtValorAtual.Text = dr.Item("saldoRestante")
                'txtSaldoRestante.Text = dr.Item("valorTotal")
                'cboSituacao.Text = dr.Item("situacao")
                txtVencimento.Text = dr.Item("DataVencimento")
                txtDataEntrada.Text = dr.Item("data_cadastro")
                txtValorParcela.Text = dr.Item("valor_parcela")
                ' txtSaldoRestante.Text = dr.Item("saldoRestante")

            End If

            '  ConsularValorParcelaReceber(lblIdparcela.Text)

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Public Function ObterProximaParcela(idConta As Integer) As Integer

        Dim proximaParcela As Integer = 0
        Dim cmd As SqlCommand
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            ' da = New SqlDataAdapter("SELECT TOP 1 (parcela) FROM tbParcelasPagar_Gravar WHERE situacao = 'PENDENTE'", con)
            ' da.SelectCommand.CommandType = CommandType.StoredProcedure
            '   da.SelectCommand.Parameters.AddWithValue("@data", Now.Date())
            Dim sql As String = "SELECT TOP 1 (parcela) FROM tbParcelasReceber_Gravar WHERE situacao = 'PENDENTE' and @IdConta=" & idConta

            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@IdConta", idConta)
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                proximaParcela = Convert.ToInt32(result)
            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Vendas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

        Return proximaParcela

    End Function

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
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


        ElseIf pagamentoDaParcela < vencimentoParcela Then
            Dim taxaDesconto As Double = CDbl(txtDesconto.Text) / 100
            desconto = CDbl(valorDaParcela * taxaDesconto)
            juros = 0
            txtValorPago.Text = CDbl(valorDaParcela - desconto).ToString("c")

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
        Dim valorResto As Double
        valorResto = valorRestante - valorpago
        txtSaldoRestante.Text = CDbl(valorRestante - valorpago).ToString("c")
        txtSaldoRestante.Text = valorResto.ToString("c")
    End Sub

    Private Sub btBaixarConta_Click(sender As Object, e As EventArgs) Handles btBaixarConta.Click
        Dim sql As String
        Dim cmd As SqlCommand


        Try
            abrir()

            cmd = New SqlCommand("pa_ParcelasReceber_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_parcela", lblIdparcela.Text)
            cmd.Parameters.AddWithValue("@parcela", cboParcela.Text)
            cmd.Parameters.AddWithValue("@data_parcela", dtpVencimentoParcela.Value)
            cmd.Parameters.AddWithValue("@valor_parcela", txtValorParcela.Text)
            cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
            cmd.Parameters.AddWithValue("@Pago", True)
            cmd.Parameters.AddWithValue("@valorTotal", txtValor.Text)
            cmd.Parameters.AddWithValue("@situacao", "Pago")
            cmd.Parameters.AddWithValue("@saldoRestante", txtSaldoRestante.Text)
            cmd.Parameters.AddWithValue("@valorPago", txtValorPago.Text)
            cmd.Parameters.AddWithValue("@data_pagamento", Now.ToShortDateString)
            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)



        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub cboParcela_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboParcela.SelectedIndexChanged

        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            Obj_parcela.parcela = cboParcela.Text
            ds = Obj_parcela.ConsularIDParcelaReceber()

            DT = ds.Tables(0)

            If DT.Rows.Count > 0 Then

                lblIdparcela.Text = ds.Tables(0).Rows(0).Item(0)
                ' txtValorAtual.Text = ds.Tables(0).Rows(0).Item(9)

            End If
            'Dim atual As Double
            'Dim vpagar As Double
            'atual = txtValorAtual.Text
            'vpagar = txtValorParcela.Text
            'llteste.Text = atual
            '  ConsularValorParcelaReceber(lblIdparcela.Text)
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub


    Private Function ConsularValorParcelaReceber(parcela As Integer) As Integer
        Dim proximaParcela As Integer = 0
        Dim cmd As SqlCommand
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            ' da = New SqlDataAdapter("SELECT TOP 1 (parcela) FROM tbParcelasPagar_Gravar WHERE situacao = 'PENDENTE'", con)
            ' da.SelectCommand.CommandType = CommandType.StoredProcedure
            '   da.SelectCommand.Parameters.AddWithValue("@data", Now.Date())
            Dim sql As String = "SELECT TOP 1 (parcela) FROM tbParcelasReceber_Gravar WHERE @parcela=" & parcela

            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@parcela", parcela)
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                proximaParcela = Convert.ToInt32(result)
            End If
            'Dim quant As Decimal = cmd.Parameters("@saldoRestante").Value
            'txtValorAtual.Text = CStr(quant)
            llteste.Text = proximaParcela

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Vendas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

        Return proximaParcela





        'Dim atual As String
        'Dim vpagar As String
        'atual = txtValorAtual.Text
        'vpagar = txtValorParcela.Text
        'llteste.Text = atual


        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter

        'Try
        '    abrir()
        '    Dim cmd As New SqlCommand("pa_ParcelasReceber_valorAtual", con)
        '    cmd.CommandType = 4
        '    cmd.Parameters.AddWithValue("@parcela", cboParcela.Text)
        '    cmd.Parameters.Add("@saldoRestante", SqlDbType.Int).Direction = 2
        '    cmd.ExecuteNonQuery()


        '    Dim quant As Decimal = cmd.Parameters("@saldoRestante").Value
        '    txtValorAtual.Text = CStr(quant)

        '    If dt.Rows.Count > 0 Then

        '        llteste.Text = ds.Tables(0).Rows(0).Item(9)
        '        ' txtValorAtual.Text = ds.Tables(0).Rows(0).Item(9)

        '    End If


        '    ' lblIdparcela.Text = ds.Tables(0).Rows(0).Item(0)
        '    ' txtValorAtual.Text = ds.Tables(0).Rows(0).Item(9)



        '    ' atual = txtValorAtual.Text
        '   
        'Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        'Finally
        '    fechar()
        'End Try
    End Function

End Class