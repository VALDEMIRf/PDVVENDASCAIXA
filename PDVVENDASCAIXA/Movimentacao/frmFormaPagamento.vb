Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class frmFormaPagamento
    Private Sub frmFormaPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            da = New SqlDataAdapter("pa_FormaPagamento_listar", con) '

            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Formas de Pagamento" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Limpar()
        txtNome.Focus()
        txtNome.Text = ""

    End Sub

    Private Sub FormatarDG()

        With dg
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Nome"
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

        If txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_FormaPagamento_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)

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

            If txtNome.Text.Equals(String.Empty) Then
                errErro.SetError(txtNome, "Digite uma Forma de Pagamento")
                MsgBox("Selecione uma Forma de Pagamento listadas")
                Exit Sub
            Else
                errErro.SetError(txtNome, "")
            End If

            abrir()
            cmd = New SqlCommand("pa_FormaPagamento_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_formaPag", lblCodigo.Text)
            cmd.Parameters.AddWithValue("@nome", txtNome.Text)

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

        If txtNome.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir esta Forma de Pagamento?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_FormaPagamento_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_formaPag", lblCodigo.Text)
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

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btAlterar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        lblCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNome.Text = dg.CurrentRow.Cells(1).Value
    End Sub
End Class