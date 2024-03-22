Imports System.Data.SqlClient
Imports System.Text

Public Class frmContasPagar
    Private Sub frmContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()

        btSalvar.Enabled = False
        Listar()
        CarregarTipoDocumento()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub frmContasPagar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
        CarregarTipoDocumento()
    End Sub

    Sub CarregarTipoDocumento()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbTipoServico", con)
            DA = New SqlDataAdapter("pa_tipoDocto_listar", con)

            DA.Fill(DT)
            txtTipoDocto.DisplayMember = "tipoDocto"
            txtTipoDocto.ValueMember = "id_tipo"
            txtTipoDocto.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub DesabilitarCampos()
        txtNDoc.Enabled = False
        txtDescricao.Enabled = False
        txtVencimento.Enabled = False
        txtValor.Enabled = False
        txtEmpresa.Enabled = False
        txtSituacao.Enabled = False
        txtData.Enabled = False
        txtTipoDocto.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtNDoc.Focus()
        txtNDoc.Enabled = True
        txtDescricao.Enabled = True
        txtEmpresa.Enabled = True
        txtSituacao.Enabled = True
        txtValor.Enabled = True
        txtVencimento.Enabled = True
        txtTipoDocto.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNDoc.Focus()
        txtCodigo.Text = "Novo"
        txtNDoc.Text = ""
        txtDescricao.Text = ""
        txtEmpresa.Text = ""
        txtSituacao.Text = Nothing
        txtTipoDocto.Text = Nothing
        txtValor.Text = ""
        txtVencimento.Text = ""
        txtData.Text = ""
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_ContasPagar_listar", con)
            da.Fill(dt)
            dgContasPagar.DataSource = dt

            ContarLinhas()
            FormatarDG()

            PCalculaTotalContasPagar()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()

        With dgContasPagar
            .Columns(0).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False

            .Columns(1).HeaderText = "Descrição"
            .Columns(2).HeaderText = "Empresa"
            .Columns(3).HeaderText = "Tipo Docto"
            .Columns(4).HeaderText = "Nr. Docto"
            .Columns(5).HeaderText = "valor"
            .Columns(6).HeaderText = "Vencimento"
            .Columns(7).HeaderText = "Situação"
            .Columns(8).HeaderText = "Dt Cadastro"

            .Columns(5).DefaultCellStyle.Format = "c"

            .Columns(1).Width = 200
            .Columns(2).Width = 200
            .Columns(3).Width = 85
            .Columns(4).Width = 90
            .Columns(5).Width = 90
            .Columns(6).Width = 88
            .Columns(7).Width = 80

        End With

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgContasPagar.Rows.Count
        lblTotal.Text = CInt(total)
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
        Limpar()
        btSalvar.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        ' intCodigoLancamento = 0
        ' frmGravaContasPagar.ShowDialog()
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtNDoc.Text <> "" Then

            Dim valor1 = Replace(txtValor.Text, ",", ".")

            Try
                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text)
                cmd.Parameters.AddWithValue("@id_tipo", txtTipoDocto.SelectedValue)
                cmd.Parameters.AddWithValue("@valor", valor1)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.ToShortDateString)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Limpar()

                btSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados desta conta" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtNDoc.Text <> "" Then

            Dim valor1 = Replace(txtValor.Text, ",", ".")

            Try
                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_conta", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@valor", valor1)
                cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados desta conta" + ex.Message.ToString)
                fechar()
            End Try
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

                btnExcluir.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados desta conta" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
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
        If txtEmpresa.Text = "" Then
            MsgBox("Preencha o campo empresa", MsgBoxStyle.Information, "Contas a Pagar")
            Return False
        End If

        Return True
    End Function

    Private Sub dgContasPagar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContasPagar.CellClick

        btnExcluir.Enabled = True
        btSalvar.Enabled = False

        HabilitarCampos()
        btnEditar.Enabled = True

        txtCodigo.Text = dgContasPagar.CurrentRow.Cells(0).Value
        txtNDoc.Text = dgContasPagar.CurrentRow.Cells(1).Value
        txtDescricao.Text = dgContasPagar.CurrentRow.Cells(2).Value
        txtValor.Text = dgContasPagar.CurrentRow.Cells(3).Value
        txtEmpresa.Text = dgContasPagar.CurrentRow.Cells(4).Value
        txtVencimento.Text = dgContasPagar.CurrentRow.Cells(5).Value
        txtSituacao.Text = dgContasPagar.CurrentRow.Cells(6).Value
        txtData.Text = dgContasPagar.CurrentRow.Cells(7).Value

    End Sub

    Sub PCalculaTotalContasPagar()
        Dim dblContasPagas, dblContasNaoPagas, dblTotalContas As Double

        For Each linha As DataGridViewRow In dgContasPagar.Rows
            'Total Contas a Pagar
            dblTotalContas = dblTotalContas + linha.Cells("valor").Value

            'Total Contas Pagas
            If linha.Cells("situacao").Value = "pago" Then
                dblContasPagas = dblContasPagas + linha.Cells("valor").Value
            End If

            'Total Contas Não Pagas
            If linha.Cells("situacao").Value = "aberto" Then
                dblContasNaoPagas = dblContasNaoPagas + linha.Cells("valor").Value
            End If

        Next

        txtTotalContasPagas.Text = FormatCurrency(dblContasPagas)
        txtTotalContasNaoPagas.Text = FormatCurrency(dblContasNaoPagas)
        txtTotalContasPagar.Text = FormatCurrency(dblTotalContas)
    End Sub



    Private Sub btTipoDocumento_Click(sender As Object, e As EventArgs) Handles btTipoDocumento.Click
        Dim form = New frmTipoDocumento
        form.ShowDialog()
    End Sub


End Class