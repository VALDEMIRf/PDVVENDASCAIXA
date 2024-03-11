Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class frmCargos
    Private Sub frmCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            ' da = New SqlDataAdapter("pa_Cargo_listar", con) '
            da = New SqlDataAdapter("select * from tbCargos", con)

            da.Fill(dt)
            dgCargos.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Cargos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Limpar()
        txtCargo.Focus()
        txtCargo.Text = ""
    End Sub

    Private Sub FormatarDG()
        With dgCargos
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Cargos"
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

        If txtCargo.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_Cargo_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cargo", txtCargo.Text)

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

            If txtCargo.Text.Equals(String.Empty) Then
                errErro.SetError(txtCargo, "Digite o nome de um Cargo")
                MsgBox("Selecione um dos Cargos listados")
                Exit Sub
            Else
                errErro.SetError(txtCargo, "")
            End If


            abrir()
            cmd = New SqlCommand("pa_Cargo_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCargo", lblCargo.Text)
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text)

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            carregaGrid()
            Limpar()


        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o Cargo" + ex.Message.ToString)
            fechar()
        End Try
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtCargo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Cargo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_Cargo_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@idCargo", lblCargo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                carregaGrid()
                Limpar()

                ' btnExcluir.Enabled = False
                '   btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub brSair_Click(sender As Object, e As EventArgs) Handles brSair.Click
        Me.Close()
    End Sub

    Private Sub dgCargos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCargos.CellClick
        btAlterar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        lblCargo.Text = dgCargos.CurrentRow.Cells(0).Value
        txtCargo.Text = dgCargos.CurrentRow.Cells(1).Value
    End Sub
End Class