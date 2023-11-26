Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class frmUnidadeMedidas
    Private Sub frmUnidadeMedidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            da = New SqlDataAdapter("pa_unidadeMedida_listar", con) '
            ' da = New SqlDataAdapter("select * from tbTipoServico", con)

            da.Fill(dt)
            dgvUnidade.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Tipos de Serviço" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Limpar()
        txtUnidade.Focus()
        txtUnidade.Text = ""

    End Sub

    Private Sub FormatarDG()
        dgvUnidade.Columns(0).Visible = False

        dgvUnidade.Columns(1).HeaderText = "Unidade"

        dgvUnidade.Columns(1).Width = 100

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        Limpar()
        btSalvar.Enabled = True

        btAlterar.Enabled = False
        btExcluir.Enabled = False
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtUnidade.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_unidadeMedida_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@unidadeMedida", txtUnidade.Text)

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

            If txtUnidade.Text.Equals(String.Empty) Then
                errErro.SetError(txtUnidade, "Digite uma unidade de medida")
                MsgBox("Selecione uma unidade de medida listada")
                Exit Sub
            Else
                errErro.SetError(txtUnidade, "")
            End If

            abrir()
            cmd = New SqlCommand("pa_unidadeMedida_Editar ", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_unidade", lblUnidade.Text)
            cmd.Parameters.AddWithValue("@unidadeMedida", txtUnidade.Text)

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            carregaGrid()
            Limpar()


        Catch ex As Exception
            MessageBox.Show("Erro ao Editar os dados" + ex.Message.ToString)
            fechar()
        End Try
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtUnidade.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir esta cunidade?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_unidadeMedida_Excluir ", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_unidade", lblUnidade.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                carregaGrid()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao Excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub brSair_Click(sender As Object, e As EventArgs) Handles brSair.Click
        Me.Close()
    End Sub

    Private Sub dgvUnidade_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnidade.CellClick

        btAlterar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        lblUnidade.Text = dgvUnidade.CurrentRow.Cells(0).Value
        txtUnidade.Text = dgvUnidade.CurrentRow.Cells(1).Value

    End Sub
End Class