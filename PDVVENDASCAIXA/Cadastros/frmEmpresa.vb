Imports System.Data.SqlClient

Public Class frmEmpresa
    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCNPJ.Focus()
        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_empresa_listar", con)

            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar a Empresa" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(3).Visible = False
        dg.Columns(4).Visible = False
        dg.Columns(5).Visible = False
        dg.Columns(6).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(8).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(10).Visible = False
        dg.Columns(11).Visible = False
        dg.Columns(12).Visible = False
        dg.Columns(13).Visible = False
        dg.Columns(14).Visible = False

        dg.Columns(1).HeaderText = "CNPJ"
        dg.Columns(2).HeaderText = "Nome da Empresa"
        dg.Columns(3).HeaderText = "Fantasia"
        dg.Columns(4).HeaderText = "Endereço"
        dg.Columns(5).HeaderText = "N°"
        dg.Columns(6).HeaderText = "Compl."
        dg.Columns(7).HeaderText = "Bairro"
        dg.Columns(8).HeaderText = "Cidade"
        dg.Columns(9).HeaderText = "UF"
        dg.Columns(10).HeaderText = "Cep"
        dg.Columns(11).HeaderText = "Telefone"
        dg.Columns(12).HeaderText = "Celular"
        dg.Columns(13).HeaderText = "Email"
        dg.Columns(14).HeaderText = "Dt. Cadastro"

        dg.Columns(1).Width = 140
        dg.Columns(2).Width = 350


    End Sub


    Private Sub Limpar()
        txtCNPJ.Focus()
        txtCNPJ.Text = Nothing
        txtRazaoSocial.Text = ""
        txtFantasia.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCompl.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtUF.Text = Nothing
        txtCEP.Text = Nothing
        txtTelResidencial.Text = Nothing
        txtCelular.Text = Nothing
        txtEmail.Text = ""

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" And txtRazaoSocial.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_empresa_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.AddWithValue("@razaoSocial", txtRazaoSocial.Text)
                cmd.Parameters.AddWithValue("@nomeFantasia", txtFantasia.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@telefone", txtTelResidencial.Text)
                cmd.Parameters.AddWithValue("@celular", txtCelular.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.Date())
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
                Limpar()

                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar o Fornecedor" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" And txtRazaoSocial.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_empresa_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.AddWithValue("@razaoSocial", txtRazaoSocial.Text)
                cmd.Parameters.AddWithValue("@nomeFantasia", txtFantasia.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@telefone", txtTelResidencial.Text)
                cmd.Parameters.AddWithValue("@celular", txtCelular.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)

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

        If txtCNPJ.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir esta Empresa?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_empresa_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False
                btnSalvar.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Erro ao  excluir os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnSalvar.Enabled = False

        txtCNPJ.Text = dg.CurrentRow.Cells(1).Value
        txtRazaoSocial.Text = dg.CurrentRow.Cells(2).Value
        txtFantasia.Text = dg.CurrentRow.Cells(3).Value
        txtEndereco.Text = dg.CurrentRow.Cells(4).Value
        txtNumero.Text = dg.CurrentRow.Cells(5).Value
        txtCompl.Text = dg.CurrentRow.Cells(6).Value
        txtBairro.Text = dg.CurrentRow.Cells(7).Value
        txtCidade.Text = dg.CurrentRow.Cells(8).Value
        txtUF.Text = dg.CurrentRow.Cells(9).Value
        txtCEP.Text = dg.CurrentRow.Cells(10).Value
        txtTelResidencial.Text = dg.CurrentRow.Cells(11).Value
        txtCelular.Text = dg.CurrentRow.Cells(12).Value
        txtEmail.Text = dg.CurrentRow.Cells(13).Value
    End Sub
End Class