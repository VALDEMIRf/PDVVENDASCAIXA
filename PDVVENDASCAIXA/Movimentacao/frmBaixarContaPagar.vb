Imports System.Data.SqlClient

Public Class frmBaixarContaPagar
    Private Sub frmBaixarContaPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If intCodigoLancamento <> 0 Then
            lblCodigo.Text = intCodigoLancamento

            CarregarDados()

        End If
    End Sub

    Private Sub CarregarDados()
        Dim dr As SqlDataReader = Nothing
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            Dim sql As String = "pa_Parcelas_listarID " & CInt(intCodigoLancamento)
            ' Dim sql As String = "SELECT * FROM tbContasPagar WHERE id_conta=" & CInt(txtCodigo.Text)
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            ' cmd.CommandText = CommandType.StoredProcedure
            ' cmd.Parameters.AddWithValue("@id_conta", txtCodigo.Text)
            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)


            If dr.HasRows Then
                dr.Read()
                txtNumParcela.Text = dr.Item("parcela")
                txtVencimento.Text = dr.Item("data_parcela")
                txtValorParcela.Text = dr.Item("valor_parcela")
                txtDocumento.Text = dr.Item("numDocto")
                txtDescricao.Text = dr.Item("descricao")
                txtValorTotal.Text = dr.Item("valorTotal")
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

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
    End Sub

    Private Sub btBaixarConta_Click(sender As Object, e As EventArgs) Handles btBaixarConta.Click

    End Sub
End Class