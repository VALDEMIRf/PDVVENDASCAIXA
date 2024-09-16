Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class frmTipoDocumento
    Private Sub frmTipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btSalvar.Enabled = False

        carregaGrid()

        btAlterar.Enabled = False
        btExcluir.Enabled = False
    End Sub

    Private Sub carregaGrid()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("pa_catContas_listar ", con) '

            da.Fill(dt)
            dgvTipo.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os tipos de Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Limpar()
        txtTipoDocumento.Focus()
        txtTipoDocumento.Text = ""

    End Sub

    Private Sub FormatarDG()

        With dgvTipo
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Contas"
            .Columns(1).Width = 150
        End With

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        Limpar()
        btSalvar.Enabled = True

        btAlterar.Enabled = False
        btExcluir.Enabled = False
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtTipoDocumento.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_catContas_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricaocategoriacontas", txtTipoDocumento.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                carregaGrid()
                Limpar()


            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btAlterar_Click(sender As Object, e As EventArgs) Handles btAlterar.Click
        Dim cmd As SqlCommand
        Try

            If txtTipoDocumento.Text.Equals(String.Empty) Then
                errErro.SetError(txtTipoDocumento, "Digite um tipo de Conta de cobrança")
                MsgBox("Selecione um tipo de Conta de cobrança listadas")
                Exit Sub
            Else
                errErro.SetError(txtTipoDocumento, "")
            End If

            abrir()
            cmd = New SqlCommand("pa_catContas_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_categoriacontas", lblTipo.Text)
            cmd.Parameters.AddWithValue("@descricaocategoriacontas", txtTipoDocumento.Text)

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            carregaGrid()
            Limpar()

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            fechar()
        End Try
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtTipoDocumento.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este tipo de conta?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_catContas_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_categoriacontas", lblTipo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                carregaGrid()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub brSair_Click(sender As Object, e As EventArgs) Handles brSair.Click
        Me.Close()
    End Sub

    Private Sub dgvTipo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipo.CellClick
        btAlterar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        lblTipo.Text = dgvTipo.CurrentRow.Cells(0).Value
        txtTipoDocumento.Text = dgvTipo.CurrentRow.Cells(1).Value
    End Sub

    Private Sub txtTipoDocumento_TextChanged(sender As Object, e As EventArgs) Handles txtTipoDocumento.TextChanged

        If txtTipoDocumento.Text = "" And dgvTipo.Rows.Count > 0 Then

            carregaGrid()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_catContas_listarNome", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@descricaocategoriacontas", txtTipoDocumento.Text)

                da.Fill(dt)
                dgvTipo.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If

    End Sub
End Class