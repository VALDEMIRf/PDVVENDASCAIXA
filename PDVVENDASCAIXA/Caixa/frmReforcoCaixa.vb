Imports System.Data.SqlClient

Public Class frmReforcoCaixa
    Private Sub frmReforcoCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtValor.Focus()
        DesabilitarCampos()
        Listar()

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_Reforco_listar", con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar " + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False

        dg.Columns(1).HeaderText = "Hora"
        dg.Columns(2).HeaderText = "Valor"
        dg.Columns(3).HeaderText = "Motivo"

        dg.Columns(3).Width = 180

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnSalvar.Enabled = False

        HabilitarCampos()

        lblCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtValor.Text = dg.CurrentRow.Cells(1).Value
        txtMotivo.Text = dg.CurrentRow.Cells(2).Value

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand
        If txtValor.Text <> "" Then
            Try
                Dim vlReforco = Replace(txtValor.Text, ",", ".")

                abrir()
                cmd = New SqlCommand("pa_Reforco_salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@horaF", Now.ToLongTimeString())
                cmd.Parameters.AddWithValue("@valor", vlReforco)
                cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
                Limpar()
                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand
        If txtValor.Text <> "" Then

            Dim vlReforco = Replace(txtValor.Text, ",", ".")

            Try

                abrir()
                cmd = New SqlCommand("pa_Reforco_editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_reforco", lblCodigo.Text)
                cmd.Parameters.AddWithValue("@horaF", Now.ToLongTimeString())
                cmd.Parameters.AddWithValue("@valor", vlReforco)
                cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao Editar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtValor.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Produto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_Reforco_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_reforco", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir o Produto" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub Limpar()
        txtValor.Focus()
        txtValor.Text = ""
        txtMotivo.Text = ""
    End Sub

    Private Sub DesabilitarCampos()
        txtValor.Enabled = False
        txtMotivo.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtValor.Enabled = True
        txtMotivo.Enabled = True
    End Sub
End Class