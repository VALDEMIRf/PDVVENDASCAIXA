Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmLancamentoContasPagar

    Dim parc As New Parcelas

    Private Sub frmLancamentoContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If intCodigoLancamento <> 0 Then
            txtCodigo.Text = intCodigoLancamento

            CarregarDados()
        Else
            txtCodigo.Text = "Novo"
        End If

        carregarContas()
        CarregarFornecedor()
        caregarFormaPagamento()

        listarParcelas()

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
            ' Dim sql As String = "SELECT * FROM tbContasPagar WHERE id_conta=" & CInt(txtCodigo.Text)
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            ' cmd.CommandText = CommandType.StoredProcedure
            ' cmd.Parameters.AddWithValue("@id_conta", txtCodigo.Text)
            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)


            If dr.HasRows Then
                dr.Read()
                txtNDoc.Text = dr.Item("numDocto")
                txtConta.Text = dr.Item("id_categoriacontas")
                txtFornecedor.Text = dr.Item("id_fornecedor")
                txtDescricao.Text = dr.Item("descricao")
                txtFormaPagto.Text = dr.Item("id_formaPag")
                txtValor.Text = dr.Item("valor")
                txtObs.Text = dr.Item("obs")
                txtParcela.Text = dr.Item("parcelas")
                txtValorParcelas.Text = dr.Item("valorParcelas")
                txtVencimento.Text = dr.Item("vencimento")
                mskData.Text = dr.Item("datapagamento")
                txtDesconto.Text = dr.Item("desconto")
                txtJuros.Text = dr.Item("juros")
                txtValorPago.Text = dr.Item("valorpago")
                txtSituacao.Text = dr.Item("situacao")

            Else

                MsgBox("Não foi posssível carregar os Dados.!", MsgBoxStyle.Critical, "Contas a Pagar")

            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Function FValidaCampos() As Boolean
        If txtNDoc.Text = "" Then
            MsgBox("Preencha o campo número de documento", MsgBoxStyle.Information, "Contas a Pagar")
            Return False
        End If
        If txtDescricao.Text = "" Then
            MsgBox("Preencha o campo descricao", MsgBoxStyle.Information, "Contas a Pagar")
            Return False
        End If
        If txtValor.Text = "" Then
            MsgBox("Preencha o campo valor", MsgBoxStyle.Information, "Contas a Pagar")
            Return False
        End If
        If txtFornecedor.Text = "" Then
            MsgBox("Preencha o campo empresa", MsgBoxStyle.Information, "Contas a Pagar")
            Return False
        End If

        Return True
    End Function

    Private Sub gravar()

        Dim cmd As SqlCommand

        If txtNDoc.Text <> "" Then

            Try

                Dim valorConta = Replace(txtValor.Text, ",", ".")
                Dim valorParela = Replace(txtValorParcelas.Text, ",", ".")
                Dim valorDesconto = Replace(txtDesconto.Text, ",", ".")
                Dim valorJuros = Replace(txtJuros.Text, ",", ".")
                Dim valorPago = Replace(txtValorPago.Text, ",", ".")

                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtConta.SelectedValue)
                cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@valor", valorConta)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.AddWithValue("@parcelas", txtNumeroPacelas.Value)
                cmd.Parameters.AddWithValue("@valorParcelas", valorParela)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@datapagamento", mskData.Text)
                cmd.Parameters.AddWithValue("@desconto", valorDesconto)
                cmd.Parameters.AddWithValue("@juros", valorJuros)
                cmd.Parameters.AddWithValue("@valorpago", valorPago)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@usuario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.ToShortDateString)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                ' btSalvar.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        End If

    End Sub

    Private Sub alterar()
        Dim cmd As SqlCommand

        If txtNDoc.Text <> "" Then

            Try

                Dim valorConta = Replace(txtValor.Text, ",", ".")
                Dim valorParela = Replace(txtValorParcelas.Text, ",", ".")
                Dim valorDesconto = Replace(txtDesconto.Text, ",", ".")
                Dim valorJuros = Replace(txtJuros.Text, ",", ".")
                Dim valorPago = Replace(txtValorPago.Text, ",", ".")

                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_conta", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@numDocto", "")
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtConta.SelectedValue)
                cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@valor", valorConta)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.AddWithValue("@parcelas", txtNumeroPacelas.Value)
                cmd.Parameters.AddWithValue("@valorParcelas", valorParela)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@datapagamento", mskData.Text)
                cmd.Parameters.AddWithValue("@desconto", valorDesconto)
                cmd.Parameters.AddWithValue("@juros", valorJuros)
                cmd.Parameters.AddWithValue("@valorpago", valorPago)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)

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

    Private Sub txtValor_LostFocus(sender As Object, e As System.EventArgs)
        txtValor.Text = FormatCurrency(txtValor.Text)
    End Sub

    Private Sub btConta_Click(sender As Object, e As EventArgs) Handles btConta.Click
        Dim form = New frmTipoDocumento
        form.ShowDialog()
    End Sub

    Private Sub btFornecedor_Click(sender As Object, e As EventArgs) Handles btFornecedor.Click
        Dim form = New frmFornecedores
        form.ShowDialog()
    End Sub

    Private Sub btFormaPagto_Click(sender As Object, e As EventArgs) Handles btFormaPagto.Click
        Dim form = New frmFormaPagamento
        form.ShowDialog()
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If txtSituacao.Text = "Paga" Then
            MsgBox("Insira a data de pagamento e o valor pago")
            'Exit Sub
        End If

        If FValidaCampos() = False Then Exit Sub

        If txtCodigo.Text = "Novo" Then
            gravar()
        Else
            alterar()
        End If

        intPergunta = MsgBox("Gostaria de inserir outro lançamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Contas a Pagar")
        If intPergunta <> vbYes Then
            ' Exit Sub
            Me.Dispose()
        Else
            Limpar()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtNDoc.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir esta conta?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_conta", intCodigoLancamento)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Limpar()

                'btnExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao  excluir os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub DesabilitarCampos()

        txtCodigo.Enabled = False
        txtNDoc.Enabled = False
        txtConta.Enabled = False
        txtFornecedor.Enabled = False
        txtDescricao.Enabled = False
        txtFormaPagto.Enabled = False
        txtValor.Enabled = False
        txtObs.Enabled = False
        txtParcela.Enabled = False
        txtValorParcelas.Enabled = False
        txtVencimento.Enabled = False
        mskData.Enabled = False
        txtDesconto.Enabled = False
        txtJuros.Enabled = False
        txtValorPago.Enabled = False
        txtSituacao.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNDoc.Focus()
        txtCodigo.Enabled = True
        txtNDoc.Enabled = True
        txtConta.Enabled = True
        txtFornecedor.Enabled = True
        txtDescricao.Enabled = True
        txtFormaPagto.Enabled = True
        txtValor.Enabled = True
        txtObs.Enabled = True
        txtParcela.Enabled = True
        txtValorParcelas.Enabled = True
        txtVencimento.Enabled = True
        mskData.Enabled = True
        txtDesconto.Enabled = True
        txtJuros.Enabled = True
        txtValorPago.Enabled = True
        txtSituacao.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNDoc.Focus()
        txtCodigo.Enabled = ""
        txtNDoc.Enabled = ""
        txtConta.Enabled = Nothing
        txtFornecedor.Enabled = Nothing
        txtDescricao.Enabled = ""
        txtFormaPagto.Enabled = Nothing
        txtValor.Enabled = ""
        txtObs.Enabled = ""
        txtParcela.Enabled = ""
        txtValorParcelas.Enabled = ""
        txtVencimento.Enabled = ""
        mskData.Enabled = ""
        txtDesconto.Enabled = ""
        txtJuros.Enabled = ""
        txtValorPago.Enabled = ""
        txtSituacao.Enabled = Nothing
    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        If txtValor.Text <> "0" And txtDesconto.Text <> "" Then

            Dim desc As Decimal
            ' Dim jur As Decimal
            Dim valor1 As Decimal
            Dim valorTotal As Decimal
            Try
                lblDesconto.Text = txtDesconto.Text
                lblValor.Text = txtValor.Text

                desc = lblDesconto.Text
                valor1 = lblValor.Text
                valorTotal = valor1 - desc

                ' txtValorPago.Text = valorTotal

            Catch ex As Exception
            End Try
        Else
            txtDesconto.Text = 0
        End If

    End Sub

    Private Sub txtJuros_TextChanged(sender As Object, e As EventArgs) Handles txtJuros.TextChanged
        If txtValor.Text <> "0" And txtJuros.Text <> "" Then

            Dim jur As Decimal
            Dim valor1 As Decimal
            Dim valorTotal As Decimal
            Try
                lblJuros.Text = txtJuros.Text
                lblValor.Text = txtValor.Text

                jur = lblJuros.Text
                valor1 = lblValor.Text
                valorTotal = valor1 + jur

                'txtValorPago.Text = valorTotal

            Catch ex As Exception
            End Try
        Else
            txtJuros.Text = 0
        End If
    End Sub

    Private Sub txtParcela_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParcela.KeyPress
        permiteSoNumeros(sender, e)
    End Sub

    Private Sub FormatarDGParcelas()
        With dgvParcelas
            .Columns(0).Visible = "par"
            .Columns(1).HeaderText = "Parcela"
            .Columns(2).HeaderText = "Data"
            ' .Columns(3).HeaderText = "Valor"
            ' .Columns(1).Width = 150
        End With
    End Sub

    Private Sub btGerarParcelas_Click(sender As Object, e As EventArgs) Handles btGerarParcelas.Click



        dgvParcelas.Rows.Clear()

        Dim venc As DateTime = mskData.Text

        Dim ValorTotal, valorParcela, valorDesconto, valorJuros As Double

        Dim situacao = txtSituacao.Text


        'Calcular valor de cada Parcela

        ValorTotal = txtValorParcelas.Text
        valorDesconto = txtDesconto.Text
        valorJuros = txtJuros.Text


        valorParcela = FormatCurrency(ValorTotal / txtNumeroPacelas.Text)

        'valorParcelaUnica = FormatCurrency(ValorTotal / txtNumeroPacelas.Text)
        'txtValorParcelas.Text = valorParcela

        Try

            ' FormatarDGParcelas()
            For i = 0 To Val(txtNumeroPacelas.Text) - 1

                Dim novaParcela As DateTime

                novaParcela = venc.AddDays(i * 30)

                If novaParcela.DayOfWeek = DayOfWeek.Sunday Then
                    novaParcela = novaParcela.AddDays(1)
                ElseIf novaParcela.DayOfWeek = DayOfWeek.Saturday Then
                    novaParcela = novaParcela.AddDays(2)
                End If

                ' NrParcelas = i + 1
                'listar()

                dgvParcelas.Rows.Add(i + 1, Mid(novaParcela.ToString, 1, 10), FormatCurrency(valorParcela), txtNDoc.Text, txtDescricao.Text, txtValor.Text, situacao)

                ' dgvParcelas.Rows.Add(txtCodigo.Text, txtNDoc.Text, txtDescricao.Text, i + 1, Mid(novaParcela.ToString, 1, 10), txtValor.Text,
                'txtValorParcelas.Text, txtDesconto.Text, txtJuros.Text, txtSituacao.Text)
            Next

            btGravarParcelas.Enabled = True

        Catch ex As Exception
            MsgBox("Erro ao calcular pagamento" + ex.Message.ToString, MsgBoxStyle.Critical, "Atenção")
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
            dgvParcelas.DataSource = dt

            'FormatarDG()
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

        Try

            abrir()

            Dim numlinhas As Integer = dgvParcelas.RowCount - 1
            Dim cont As Integer = 0

            'Insere no banco de dados as parcelas geradas no DataGrid
            While (cont <= numlinhas)
                dr = Me.dgvParcelas.Item(1, cont).Value
                dia = dr.Day
                mes = dr.Month
                ano = dr.Year
                d = ano & "-" & mes & "-" & dia
                'Dim sit As String = dgvParcelas.Rows(6).ToString



                parc.parcela = Me.dgvParcelas.Item(0, cont).Value
                parc.data_parcela = d
                parc.valor_parcela = (Me.dgvParcelas.Item(2, cont).Value).Replace("R$", "")
                parc.numDocto = txtNDoc.Text
                parc.descricao = txtDescricao.Text
                parc.valorTotal = txtValor.Text
                parc.situacao = txtSituacao.Text

                parc.CadastrarParcela()


                'Dim valorDesconto = Replace(txtDesconto.Text, ",", ".")
                'Dim valorJuros = Replace(txtJuros.Text, ",", ".")
                'Dim valorPago = Replace(txtValorPago.Text, ",", ".")
                'Dim valorparcela = Replace(txtValorParcelas.Text, ",", ".")


                'cmd = New SqlCommand("pa_Parcelas_Salvar", con)
                'cmd.CommandType = CommandType.StoredProcedure

                'cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                'cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                'cmd.Parameters.AddWithValue("@Nrparcelas", txtParcela.Text) '3
                'cmd.Parameters.AddWithValue("@dtParcela", mskData.Text) '4
                'cmd.Parameters.AddWithValue("@valor", txtValor.Text)
                'cmd.Parameters.AddWithValue("@valorParcela", valorparcela) '6
                'cmd.Parameters.AddWithValue("@desconto", valorDesconto)
                'cmd.Parameters.AddWithValue("@juros", valorJuros)
                'cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                'cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                'cmd.ExecuteNonQuery()

                'Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                'MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)



                cont = cont + 1

            End While
            MsgBox("Parcelas gravadas com sucesso!", MsgBoxStyle.Information, "Sucesso")

        Catch ex As Exception
            MsgBox("Erro ao gravar as Parcelas no banco!" + ex.Message.ToString, MsgBoxStyle.Critical, "Erro")
        Finally
            fechar()
        End Try
    End Sub



    Private Sub txtJuros_Leave(sender As Object, e As EventArgs) Handles txtJuros.Leave
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

    Private Sub chContaPaga_CheckedChanged(sender As Object, e As EventArgs) Handles chContaPaga.CheckedChanged

        If chContaPaga.Checked Then
            mstbDataPagto.Enabled = True
            txtJuros.Enabled = True
            txtDesconto.Enabled = True
        Else
            mstbDataPagto.Enabled = False
            txtJuros.Enabled = False
            txtDesconto.Enabled = False
        End If


    End Sub

    Private Sub txtNumeroPacelas_TextChanged(sender As Object, e As EventArgs)
        permiteSoNumeros(sender, e)
        'txtValorParcelas.Text = txtValor.Text
    End Sub



    Private Sub txtSituacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSituacao.SelectedIndexChanged
        If txtSituacao.Text = "Em Parcelamento" Then

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

    Private Sub dgvParcelas_DoubleClick(sender As Object, e As EventArgs) Handles dgvParcelas.DoubleClick
        intCodigoLancamento = dgvParcelas.CurrentRow().Cells("id_parcela").Value
        frmBaixarContaPagar.ShowDialog()
    End Sub
End Class

'Private Sub FormatarDG()
'    With dgvParcelas

'        .Columns(6).DefaultCellStyle.Format = "c"
'        .Columns(7).DefaultCellStyle.Format = "c"
'        .Columns(8).DefaultCellStyle.Format = "c"
'        .Columns(9).DefaultCellStyle.Format = "c"
'        .Columns(10).DefaultCellStyle.Format = "c"

'        .Columns(0).Visible = False
'        .Columns(1).Visible = False
'        .Columns(12).Visible = False

'        .Columns(0).HeaderText = "id"
'        .Columns(1).HeaderText = "conta"
'        .Columns(2).HeaderText = "numDocto"
'        .Columns(3).HeaderText = "Descrição"
'        .Columns(4).HeaderText = "Nrparcelas"
'        .Columns(5).HeaderText = "dtParcela"
'        .Columns(6).HeaderText = "Valor"
'        .Columns(7).HeaderText = "ValorParcelas"
'        .Columns(8).HeaderText = "Desconto"
'        .Columns(9).HeaderText = "juros"
'        .Columns(10).HeaderText = "valorpago"
'        .Columns(11).HeaderText = "situacao"
'        .Columns(12).HeaderText = "data_cadastro"
'    End With
'End Sub