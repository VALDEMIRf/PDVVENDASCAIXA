Imports System.Data.SqlClient
Imports System.Text

Public Class frmContasPagar
    Private Sub frmContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PCarregaInformacoesIniciais()

        rbTodas.Checked = True

    End Sub

    Private Sub rbTodas_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodas.CheckedChanged

    End Sub

    Private Sub rbContasPagar_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasPagar.CheckedChanged

    End Sub

    Private Sub rbContasPagas_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasPagas.CheckedChanged

    End Sub

    Private Sub rbContasVencidas_CheckedChanged(sender As Object, e As EventArgs) Handles rbContasVencidas.CheckedChanged

    End Sub


    Private Sub frmContasPagar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        PCarregaInformacoesIniciais()
    End Sub

    Private Sub PCarregaDados()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            '  da = New SqlDataAdapter("pa_ContasPagar_listar", con)
            Dim sql As String = "SELECT * FROM tbContasPagarTeste ORDER BY codigo"
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dgContasPagar.DataSource = dt

            ContarLinhas()
            '  FormatarDG()

            ' PCalculaTotalContasPagar()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PCarregaInformacoesIniciais()
        PCarregaDados()
        PCalculaTotalContasPagar()
        PFormataGridView()
    End Sub

    Private Sub PFormataGridView()
        With dgContasPagar
            .Columns(4).DefaultCellStyle.Format = "c"
        End With
    End Sub

    Private Sub PCalculaTotalContasPagar()
        Dim dblContasPagas, dblContasNaoPagas, dblTotalContas As Double

        For Each linha As DataGridViewRow In dgContasPagar.Rows
            'Total Contas a Pagar
            dblTotalContas = dblTotalContas + linha.Cells("valor").Value

            'Total Contas Pagas
            If linha.Cells("situacao").Value = "Sim" Then
                dblContasPagas = dblContasPagas + linha.Cells("valor").Value
            End If

            'Total Contas Não Pagas
            If linha.Cells("situacao").Value = "Não" Then
                dblContasNaoPagas = dblContasNaoPagas + linha.Cells("valor").Value
            End If

        Next

        txtTotalContasPagas.Text = FormatCurrency(dblContasPagas)
        txtTotalContasNaoPagas.Text = FormatCurrency(dblContasNaoPagas)
        txtTotalContasPagar.Text = FormatCurrency(dblTotalContas)

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgContasPagar.Rows.Count
        lblTotal.Text = CInt(total)
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click

        intCodigoLancamento = 0
        frmLancamentoContasPagar.ShowDialog()
        'Dim form = New frmLancamentoContasPagar
        'Form.ShowDialog()

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dgContasPagar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContasPagar.CellClick
        enviarDados()
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        enviarDados()
    End Sub

    Private Sub enviarDados()
        intCodigoLancamento = dgContasPagar.CurrentRow().Cells("codigo").Value
        'frmLancamentoContasPagar.txtCodigo.Text = intCodigoLancamento
        frmLancamentoContasPagar.ShowDialog()
        PCarregaInformacoesIniciais()
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


End Class