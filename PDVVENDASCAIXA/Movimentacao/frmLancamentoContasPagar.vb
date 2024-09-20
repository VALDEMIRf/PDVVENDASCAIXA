Imports System.Data.SqlClient

Public Class frmLancamentoContasPagar
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
                txtParcelas.Text = dr.Item("parcelas")
                txtValorParcelas.Text = dr.Item("valorParcelas")
                txtVencimento.Text = dr.Item("vencimento")
                txtDataPagto.Text = dr.Item("datapagamento")
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
                cmd.Parameters.AddWithValue("@parcelas", txtParcelas.Text)
                cmd.Parameters.AddWithValue("@valorParcelas", valorParela)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@datapagamento", txtDataPagto.Text)
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
                cmd.Parameters.AddWithValue("@parcelas", txtParcelas.Text)
                cmd.Parameters.AddWithValue("@valorParcelas", valorParela)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@datapagamento", txtDataPagto.Text)
                cmd.Parameters.AddWithValue("@desconto", valorDesconto)
                cmd.Parameters.AddWithValue("@juros", valorJuros)
                cmd.Parameters.AddWithValue("@valorpago", valorPago)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)


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
        txtParcelas.Enabled = False
        txtValorParcelas.Enabled = False
        txtVencimento.Enabled = False
        txtDataPagto.Enabled = False
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
        txtParcelas.Enabled = True
        txtValorParcelas.Enabled = True
        txtVencimento.Enabled = True
        txtDataPagto.Enabled = True
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
        txtParcelas.Enabled = ""
        txtValorParcelas.Enabled = ""
        txtVencimento.Enabled = ""
        txtDataPagto.Enabled = ""
        txtDesconto.Enabled = ""
        txtJuros.Enabled = ""
        txtValorPago.Enabled = ""
        txtSituacao.Enabled = Nothing
    End Sub


End Class