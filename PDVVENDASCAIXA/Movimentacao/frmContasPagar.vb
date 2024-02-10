Imports System.Data.SqlClient
Imports System.Text

Public Class frmContasPagar
    Private Sub frmContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DesabilitarCampos()
        btSalvar.Enabled = False
        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
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

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub DesabilitarCampos()
        txtNDoc.Enabled = False
        txtDescricao.Enabled = False
        txtDtPagto.Enabled = False
        txtEmpresa.Enabled = False
        txtReferencia.Enabled = False
        txtSituacao.Enabled = False
        txtValor.Enabled = False

        txtVencimento.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNDoc.Enabled = True
        txtDescricao.Enabled = True
        txtDtPagto.Enabled = True
        txtEmpresa.Enabled = True
        txtReferencia.Enabled = True
        txtSituacao.Enabled = True
        txtValor.Enabled = True

        txtVencimento.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNDoc.Focus()
        txtNDoc.Text = ""
        txtDescricao.Text = ""
        txtDtPagto.Text = ""
        txtEmpresa.Text = ""
        txtReferencia.Text = ""
        txtSituacao.Text = Nothing
        txtValor.Text = ""

        txtVencimento.Text = ""

    End Sub

    Private Sub FormatarDG()

        dgContasPagar.Columns(0).Visible = False

        dgContasPagar.Columns(1).HeaderText = "Documento"
        dgContasPagar.Columns(2).HeaderText = "Descrição"
        dgContasPagar.Columns(3).HeaderText = "Valor"
        dgContasPagar.Columns(4).HeaderText = "Dt Referência"
        dgContasPagar.Columns(5).HeaderText = "Empresa"
        dgContasPagar.Columns(6).HeaderText = "Vencimento"
        dgContasPagar.Columns(7).HeaderText = "Dt Pagto"
        dgContasPagar.Columns(8).HeaderText = "Pago"

        dgContasPagar.Columns(1).Width = 120
        dgContasPagar.Columns(2).Width = 170
        dgContasPagar.Columns(3).Width = 70
        dgContasPagar.Columns(5).Width = 150
        dgContasPagar.Columns(8).Width = 50

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgContasPagar.Rows.Count
        lblTotal.Text = CInt(total)
    End Sub

    Public Shared Sub Moeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = ""
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        txtNDoc.Focus()
        HabilitarCampos()
        ' Limpar()
        btSalvar.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
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
                cmd.Parameters.AddWithValue("@valor", valor1)
                cmd.Parameters.AddWithValue("@referencia", txtReferencia.Text)
                cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@dtPagto", txtDtPagto.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.ToShortDateString)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
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

                cmd.Parameters.AddWithValue("@id_conta", lblCodigo.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@valor", valor1)
                cmd.Parameters.AddWithValue("@referencia", txtReferencia.Text)
                cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@dtPagto", txtDtPagto.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
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
                cmd.Parameters.AddWithValue("@id_conta", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados desta conta" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dgContasPagar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContasPagar.CellClick

        btnExcluir.Enabled = True
        btSalvar.Enabled = False
        btnEditar.Enabled = True

        HabilitarCampos()
        txtNDoc.Enabled = False

        lblCodigo.Text = dgContasPagar.CurrentRow.Cells(0).Value
        txtNDoc.Text = dgContasPagar.CurrentRow.Cells(1).Value
        txtDescricao.Text = dgContasPagar.CurrentRow.Cells(2).Value
        txtValor.Text = dgContasPagar.CurrentRow.Cells(3).Value
        txtReferencia.Text = dgContasPagar.CurrentRow.Cells(4).Value
        txtEmpresa.Text = dgContasPagar.CurrentRow.Cells(5).Value
        txtVencimento.Text = dgContasPagar.CurrentRow.Cells(6).Value
        txtDtPagto.Text = dgContasPagar.CurrentRow.Cells(7).Value
        txtSituacao.Text = dgContasPagar.CurrentRow.Cells(8).Value

    End Sub
End Class