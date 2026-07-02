Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmClientesPJ
    Private Sub frmClientesPJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSalvar.Enabled = False
        ListarPJ()
        rbNomePJ.Checked = True
    End Sub



    Private Sub HabilitarCamposPJ()
        txtCNPJ.Enabled = True
        txtIE.Enabled = True
        txtCEP.Enabled = True
        txtComplemento.Enabled = True
        txtObs.Enabled = True
        txtCNPJ.Focus()
    End Sub

    Private Sub Limpar()
        txtCNPJ.Text = ""
        txtNome.Text = ""
        txtFantasia.Text = ""
        txtIE.Text = ""
        txtSituacao.Text = ""
        txtMotivo.Text = ""
        txtTel.Text = ""
        txtEmail.Text = ""
        txtCEP.Text = ""
        txtUF.Text = Nothing
        txtEndereco.Text = ""
        txtNum.Text = ""
        txtCompl.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtObs.Text = ""
    End Sub

    Private Sub ObterCnpj(cnpj As String)

        Dim cliente = Empresa.ObterCnpj(cnpj)
        Try
            txtNome.Text = cliente.nome
            txtFantasia.Text = cliente.fantasia
            txtSituacao.Text = cliente.situacao
            txtMotivo.Text = UTF8_to_ISO(cliente.motivo_situacao)
            txtEndereco.Text = cliente.logradouro
            txtNum.Text = cliente.numero
            txtCompl.Text = cliente.complemento
            txtBairro.Text = cliente.bairro
            txtCEP.Text = cliente.cep
            txtCidade.Text = cliente.municipio
            txtUF.Text = cliente.uf
            txtEmail.Text = cliente.email
            txtTel.Text = cliente.telefone
        Catch ex As Exception

            MessageBox.Show("CNPJ Incorreto, digite um CNPJ válido!!!", "ERRO" + ex.Message.ToString)
        End Try

    End Sub

    Private Sub btBuscarCNPJ_Click(sender As Object, e As EventArgs) Handles btBuscarCNPJ.Click
        ObterCnpj(txtCNPJ.Text)
    End Sub

    Private Sub btNovoPJ_Click(sender As Object, e As EventArgs) Handles btNovoPJ.Click
        HabilitarCamposPJ()
        Limpar()
        btnSalvar.Enabled = True

        btExcluir.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_cliente_SalvarPJ", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@fantasia", txtFantasia.Text)
                cmd.Parameters.AddWithValue("@ie", txtIE.Text)
                cmd.Parameters.AddWithValue("@telRes", "")
                cmd.Parameters.AddWithValue("@telcel", txtTel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNum.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@complemento", "")
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.Date())
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                ListarPJ()
                Limpar()

                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar o Cliente" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub ListarPJ()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_cliente_listarPJ", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.Fill(dt)
            dgPJ.DataSource = dt

            ContarLinhasPJ()

            FormatarDGPJ()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os clientes" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    Private Sub btEditarPJ_Click(sender As Object, e As EventArgs)
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_cliente_EditarPJ", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_cliente", lblCodigo.Text)
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@fantasia", txtFantasia.Text)
                cmd.Parameters.AddWithValue("@telcel", txtTel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNum.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@complemento", "")
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                ListarPJ()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao Editar os dados deste cliente" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btEscluirPJ_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este cliente?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_clienteExcluirPJ", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_cliente", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                ListarPJ()
                Limpar()

                btExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao  excluir os dados deste Cliente" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub ContarLinhasPJ()
        Dim total As Integer = dgPJ.Rows.Count
        lblTotalPJ.Text = CInt(total)

    End Sub

    Private Sub FormatarDGPJ()

        With dgPJ
            .Columns(0).Visible = False
            .Columns(5).Visible = False
            '  .Columns(6).Visible = False

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "CNPJ"
            .Columns(2).HeaderText = "Nome"
            .Columns(3).HeaderText = "Fantasia"
            .Columns(4).HeaderText = "Inscr. Estadual"
            .Columns(5).HeaderText = "cel"
            .Columns(6).HeaderText = "Telefone"
            .Columns(7).HeaderText = "Email"
            .Columns(8).HeaderText = "Situação"
            .Columns(9).HeaderText = "Motivo"
            .Columns(10).HeaderText = "CEP"
            .Columns(11).HeaderText = "UF"
            .Columns(12).HeaderText = "Endereço"
            .Columns(13).HeaderText = "Num"
            .Columns(14).HeaderText = "Compl"
            .Columns(15).HeaderText = "Compl2"
            .Columns(16).HeaderText = "Bairro"
            .Columns(17).HeaderText = "Cidade"
            .Columns(18).HeaderText = "Obs."
            .Columns(19).HeaderText = "Data Cadastro"


            .Columns(1).Width = 130
            .Columns(2).Width = 230
            .Columns(3).Width = 170
            .Columns(4).Width = 150
            .Columns(6).Width = 120
            .Columns(7).Width = 200
            .Columns(8).Width = 120
            .Columns(9).Width = 250
            .Columns(10).Width = 50
            .Columns(11).Width = 80
            .Columns(12).Width = 200
            .Columns(13).Width = 90
            .Columns(14).Width = 150
            .Columns(15).Width = 150
            .Columns(16).Width = 150
            .Columns(17).Width = 150
            .Columns(18).Width = 300
        End With

    End Sub

    Private Sub dgPJ_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPJ.CellClick
        btExcluir.Enabled = True
        btnSalvar.Enabled = False

        HabilitarCamposPJ()
        ' txtCNPJ.Enabled = False

        lblCodigo.Text = dgPJ.CurrentRow.Cells(0).Value
        txtCNPJ.Text = dgPJ.CurrentRow.Cells(1).Value
        txtNome.Text = dgPJ.CurrentRow.Cells(2).Value
        txtFantasia.Text = dgPJ.CurrentRow.Cells(3).Value
        txtIE.Text = dgPJ.CurrentRow.Cells(4).Value
        txtTel.Text = dgPJ.CurrentRow.Cells(6).Value
        txtEmail.Text = dgPJ.CurrentRow.Cells(7).Value
        txtSituacao.Text = dgPJ.CurrentRow.Cells(8).Value
        txtMotivo.Text = dgPJ.CurrentRow.Cells(9).Value
        txtCEP.Text = dgPJ.CurrentRow.Cells(10).Value
        txtUF.Text = dgPJ.CurrentRow.Cells(11).Value
        txtEndereco.Text = dgPJ.CurrentRow.Cells(12).Value
        txtNum.Text = dgPJ.CurrentRow.Cells(13).Value
        txtCompl.Text = dgPJ.CurrentRow.Cells(14).Value
        txtComplemento.Text = dgPJ.CurrentRow.Cells(15).Value
        txtBairro.Text = dgPJ.CurrentRow.Cells(16).Value
        txtCidade.Text = dgPJ.CurrentRow.Cells(17).Value
        txtObs.Text = dgPJ.CurrentRow.Cells(18).Value
    End Sub

    Private Sub rbNomePJ_CheckedChanged(sender As Object, e As EventArgs) Handles rbNomePJ.CheckedChanged
        ListarPJ()
        txtBuscarCNPJ.Text = ""
        txtBuscarNome.Text = ""
        txtBuscarNome.Visible = True
        txtBuscarCNPJ.Visible = False
        txtBuscarNome.Focus()
    End Sub

    Private Sub rbCNPJ_CheckedChanged(sender As Object, e As EventArgs) Handles rbCNPJ.CheckedChanged
        ListarPJ()
        txtBuscarNome.Text = ""
        txtBuscarCNPJ.Text = ""
        txtBuscarNome.Visible = False
        txtBuscarCNPJ.Visible = True
        txtBuscarCNPJ.Focus()
    End Sub

    Private Sub txtBuscarNomePJ_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged
        If txtBuscarNome.Text = "" And dgPJ.Rows.Count > 0 Then
            ListarPJ()


        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_cliente_NomebuscarPJ", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscarNome.Text)

                da.Fill(dt)
                dgPJ.DataSource = dt

                ContarLinhasPJ()

                FormatarDGPJ()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscarCNPJ_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBuscarCNPJ.MaskInputRejected
        If txtBuscarCNPJ.Text = "  .   .   /  -  " And dgPJ.Rows.Count > 0 Then
            ListarPJ()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_clienteCnpjbuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cnpj", txtBuscarCNPJ.Text)

                da.Fill(dt)
                dgPJ.DataSource = dt


                ContarLinhasPJ()

                FormatarDGPJ()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
End Class