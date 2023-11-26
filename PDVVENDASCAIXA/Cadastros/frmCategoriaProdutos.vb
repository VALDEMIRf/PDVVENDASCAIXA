Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class frmCategoriaProdutos
    Private Sub frmCategoriaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            da = New SqlDataAdapter("pa_categoriaProdutos_listar", con) '
            ' da = New SqlDataAdapter("select * from tbTipoServico", con)

            da.Fill(dt)
            dgvCategoria.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Tipos de Serviço" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub


    Private Sub Limpar()
        txtCategoria.Focus()
        txtCategoria.Text = ""

    End Sub

    Private Sub FormatarDG()
        dgvCategoria.Columns(0).Visible = False

        dgvCategoria.Columns(1).HeaderText = "Categoria"

        dgvCategoria.Columns(1).Width = 150

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        Limpar()
        btSalvar.Enabled = True

        btAlterar.Enabled = False
        btExcluir.Enabled = False
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtCategoria.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_categoriaProdutos_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text)

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

            If txtCategoria.Text.Equals(String.Empty) Then
                errErro.SetError(txtCategoria, "Digite uma categoria de produtos")
                MsgBox("Selecione uma das categorias listadas")
                Exit Sub
            Else
                errErro.SetError(txtCategoria, "")
            End If

            abrir()
            cmd = New SqlCommand("pa_categoriaProdutos_Editar ", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_categoria", lblCategoria.Text)
            cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text)

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

        If txtCategoria.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir esta categoria?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_categoriaProdutos_Excluir ", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_categoria", lblCategoria.Text)
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

    Private Sub dgvCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategoria.CellClick
        btAlterar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        lblCategoria.Text = dgvCategoria.CurrentRow.Cells(0).Value
        txtCategoria.Text = dgvCategoria.CurrentRow.Cells(1).Value
    End Sub
End Class