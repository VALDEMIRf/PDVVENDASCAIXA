Imports System.Data.SqlClient

Public Class frmGravarContaPagar
    Private Sub frmGravarContaPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarContas()
        CarregarFornecedor()
        caregarFormaPagamento()

        If intCodigoLancamento <> 0 Then
            txtCodigo.Text = intCodigoLancamento

            CarregarDados()
        Else
            txtCodigo.Text = "Novo"
        End If
        ' Limpar()
    End Sub

    Private Sub frmGravarContaPagar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        carregarContas()
        CarregarFornecedor()
        caregarFormaPagamento()
        CarregarDados()
        '   Limpar()
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

    Private Sub Limpar()
        txtNDoc.Focus()
        'txtCodigo.Text = ""
        txtNDoc.Text = ""
        txtConta.Text = Nothing
        txtFornecedor.Text = Nothing
        txtDescricao.Text = ""
        txtFormaPagto.Text = Nothing
        txtValor.Text = ""
        txtObs.Text = ""
        txtDataEntrada.Text = ""
        txtVencimento.Text = ""
        txtDtPagamento.Text = ""
        txtDesconto.Text = ""
        txtJuros.Text = ""
        txtValorPago.Text = ""
        txtSituacao.Text = Nothing
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
                txtVencimento.Text = dr.Item("vencimento")
                txtDataEntrada.Text = dr.Item("data_cadastro")
                txtDtPagamento.Text = dr.Item("datapagamento")
                txtDesconto.Text = dr.Item("desconto")
                txtJuros.Text = dr.Item("juros")
                txtValorPago.Text = dr.Item("valorpago")
                txtSituacao.Text = dr.Item("situacao")


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

                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtConta.SelectedValue)
                cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@valor", txtValor.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@datapagamento", txtDtPagamento.Text)
                cmd.Parameters.AddWithValue("@desconto", txtDesconto.Text)
                cmd.Parameters.AddWithValue("@juros", txtJuros.Text)
                cmd.Parameters.AddWithValue("@valorpago", txtValorPago.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@usuario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_cadastro", txtDataEntrada.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)


                Limpar()

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

                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_conta", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@numDocto", "")
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtConta.SelectedValue)
                cmd.Parameters.AddWithValue("@id_fornecedor", txtFornecedor.SelectedValue)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@valor", txtValor.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@datapagamento", txtDtPagamento.Text)
                cmd.Parameters.AddWithValue("@desconto", txtDesconto.Text)
                cmd.Parameters.AddWithValue("@juros", txtJuros.Text)
                cmd.Parameters.AddWithValue("@valorpago", txtValorPago.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        End If

    End Sub

    Private Sub txtDesconto_LostFocus(sender As Object, e As EventArgs) Handles txtDesconto.LostFocus
        txtDesconto.Text = FormatCurrency(txtDesconto.Text)
    End Sub

    Private Sub txtJuros_LostFocus(sender As Object, e As EventArgs) Handles txtJuros.LostFocus
        txtJuros.Text = FormatCurrency(txtJuros.Text)
    End Sub

    Private Sub txtValorPago_LostFocus(sender As Object, e As EventArgs) Handles txtValorPago.LostFocus
        txtValorPago.Text = FormatCurrency(txtValorPago.Text)
    End Sub

    Private Sub txtValor_LostFocus(sender As Object, e As EventArgs) Handles txtValor.LostFocus
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
            Exit Sub
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
                cmd.Parameters.AddWithValue("@id_conta", txtCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Limpar()

                'btnExcluir.Enabled = False
                Me.Dispose()

            Catch ex As Exception
                MessageBox.Show("Erro ao  excluir os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub
End Class