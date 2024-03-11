Imports System.Data.SqlClient

Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        'dtData.Value = Now
        btnSalvar.Enabled = False
        ' txtBuscarCPF.Visible = False

        Listar()
        ListarPJ()

        rbNome.Checked = True
        rbNomePJ.Checked = True

    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        cbSexo.Enabled = False
        txtRG.Enabled = False
        txtCPF.Enabled = False
        txtCNPJ.Enabled = False
        txtIE.Enabled = False
        txtTel.Enabled = False
        txtEmail.Enabled = False
        txtdtNasc.Enabled = False
        txtCompl.Enabled = False
        cbEstCivil.Enabled = False
        txtTelCel.Enabled = False
        txtNatural.Enabled = False
        txtObs.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNome.Focus()
        txtNome.Enabled = True
        cbSexo.Enabled = True
        txtRG.Enabled = True
        txtCPF.Enabled = True
        txtCNPJ.Enabled = True
        txtIE.Enabled = True
        txtTel.Enabled = True
        txtEmail.Enabled = True
        txtdtNasc.Enabled = True
        txtCompl.Enabled = True
        cbEstCivil.Enabled = True
        txtTelCel.Enabled = True
        txtNatural.Enabled = True
        txtObs.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNome.Focus()
        txtNome.Text = ""
        cbSexo.Text = Nothing
        cbEstCivil.Text = Nothing
        txtRG.Text = ""
        txtCNPJ.Text = ""
        txtCPF.Text = ""
        txtTel.Text = ""
        txtTelCel.Text = ""
        txtNatural.Text = ""
        txtEmail.Text = ""
        txtdtNasc.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCompl.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtUF.Text = Nothing
        txtCEP.Text = ""
        txtObs.Text = ""
        txtRazaoSocial.Text = ""
        txtFantasia.Text = ""
        txtIE.Text = ""
        txtTelPJ.Text = ""
        txtEmailPJ.Text = ""
        txtCEPPJ.Text = ""
        txtUFPJ.Text = Nothing
        txtEnd.Text = ""
        txtNum.Text = ""
        txtComplPJ.Text = ""
        txtBairroPJ.Text = ""
        txtCidadePJ.Text = ""
        txtObsPj.Text = ""
        txtSituacao.Text = ""
        txtMotivo.Text = ""
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_cliente_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os clientes" + ex.Message.ToString)
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
        dg.Columns(20).Visible = False
        dg.Columns(21).Visible = False

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "CPF"
        dg.Columns(3).HeaderText = "RG"
        dg.Columns(4).HeaderText = "Est. Civil"
        dg.Columns(5).HeaderText = "Naturalidade"
        dg.Columns(6).HeaderText = "Sexo"
        dg.Columns(7).HeaderText = "Nascimento"
        dg.Columns(8).HeaderText = "Telefone"
        dg.Columns(9).HeaderText = "Celular"
        dg.Columns(10).HeaderText = "Email"
        dg.Columns(11).HeaderText = "CEP"
        dg.Columns(12).HeaderText = "UF"
        dg.Columns(13).HeaderText = "Endereço"
        dg.Columns(14).HeaderText = "Num"
        dg.Columns(15).HeaderText = "Compl"
        dg.Columns(16).HeaderText = "Compl2"
        dg.Columns(17).HeaderText = "Bairro"
        dg.Columns(18).HeaderText = "Cidade"
        dg.Columns(19).HeaderText = "Obs."
        dg.Columns(20).HeaderText = "Data Cadastro"

        dg.Columns(1).Width = 150
        dg.Columns(2).Width = 110
        dg.Columns(5).Width = 100
        dg.Columns(6).Width = 80
        dg.Columns(7).Width = 100
        dg.Columns(8).Width = 120
        dg.Columns(9).Width = 120
        dg.Columns(10).Width = 200
        dg.Columns(11).Width = 80
        dg.Columns(12).Width = 30
        dg.Columns(13).Width = 140
        dg.Columns(14).Width = 75
        dg.Columns(15).Width = 150
        dg.Columns(16).Width = 150
        dg.Columns(17).Width = 150
        dg.Columns(19).Width = 180

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

    End Sub


    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtCPF.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_cliente_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.AddWithValue("@cnpj", "")
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
                cmd.Parameters.AddWithValue("@ie", "")
                cmd.Parameters.AddWithValue("@estadoCivil", cbEstCivil.Text)
                cmd.Parameters.AddWithValue("@naturalidade", txtNatural.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@dtNasc", txtdtNasc.Text)
                cmd.Parameters.AddWithValue("@telRes", txtTel.Text)
                cmd.Parameters.AddWithValue("@telcel", txtTelCel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.ToShortDateString)
                cmd.Parameters.AddWithValue("@situacao", "")
                cmd.Parameters.AddWithValue("@motivo", "")
                cmd.Parameters.AddWithValue("@tipocli", 0)
                cmd.Parameters.AddWithValue("@fantasia", "")
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
                Limpar()

                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar o Cliente" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub dg_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick

        'btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnSalvar.Enabled = False

        HabilitarCampos()
        txtCPF.Enabled = False

        lblCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNome.Text = dg.CurrentRow.Cells(1).Value
        txtCPF.Text = dg.CurrentRow.Cells(2).Value
        txtRG.Text = dg.CurrentRow.Cells(3).Value
        cbEstCivil.Text = dg.CurrentRow.Cells(4).Value
        txtNatural.Text = dg.CurrentRow.Cells(5).Value
        cbSexo.Text = dg.CurrentRow.Cells(6).Value
        txtdtNasc.Text = dg.CurrentRow.Cells(7).Value
        txtTel.Text = dg.CurrentRow.Cells(8).Value
        txtTelCel.Text = dg.CurrentRow.Cells(9).Value
        txtEmail.Text = dg.CurrentRow.Cells(10).Value
        txtCEP.Text = dg.CurrentRow.Cells(11).Value
        txtUF.Text = dg.CurrentRow.Cells(12).Value
        txtEndereco.Text = dg.CurrentRow.Cells(13).Value
        txtNumero.Text = dg.CurrentRow.Cells(14).Value
        txtCompl.Text = dg.CurrentRow.Cells(15).Value
        txtComplemento.Text = dg.CurrentRow.Cells(16).Value
        txtBairro.Text = dg.CurrentRow.Cells(17).Value
        txtCidade.Text = dg.CurrentRow.Cells(18).Value
        txtObs.Text = dg.CurrentRow.Cells(19).Value
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtCPF.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_cliente_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.AddWithValue("@cnpj", "")
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
                cmd.Parameters.AddWithValue("@ie", "")
                cmd.Parameters.AddWithValue("@estadoCivil", cbEstCivil.Text)
                cmd.Parameters.AddWithValue("@naturalidade", txtNatural.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@dtNasc", txtdtNasc.Text)
                cmd.Parameters.AddWithValue("@telRes", txtTel.Text)
                cmd.Parameters.AddWithValue("@telcel", txtTelCel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
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

        If txtCPF.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este cliente?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_cliente_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao  excluir os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub ObterCnpj(cnpj As String)

        Dim cliente = Empresa.ObterCnpj(cnpj)
        Try
            txtRazaoSocial.Text = cliente.nome
            txtFantasia.Text = cliente.fantasia
            txtSituacao.Text = cliente.situacao
            txtMotivo.Text = UTF8_to_ISO(cliente.motivo_situacao)
            txtEnd.Text = cliente.logradouro
            txtNum.Text = cliente.numero
            txtComplPJ.Text = cliente.complemento
            txtBairroPJ.Text = cliente.bairro
            txtCEPPJ.Text = cliente.cep
            txtCidadePJ.Text = cliente.municipio
            txtUFPJ.Text = cliente.uf
            txtEmailPJ.Text = cliente.email
            txtTelPJ.Text = cliente.telefone
        Catch ex As Exception

            '  MessageBox.Show("CNPJ Incorreto, digite um CNPJ válido!!!" + ex.Message.ToString)
            MessageBox.Show("CNPJ Incorreto, digite um CNPJ válido!!!", "ERRO" + ex.Message.ToString)
        End Try

    End Sub

    Private Sub btBuscarCEP_Click_1(sender As Object, e As EventArgs) Handles btBuscarCEP.Click
        Try
            Dim ws = New WSCEP.AtendeClienteClient()
            Dim resposta = ws.consultaCEP(txtCEP.Text)
            txtEndereco.Text = resposta.end
            txtComplemento.Text = resposta.complemento2  'complemento
            txtBairro.Text = resposta.bairro
            txtCidade.Text = resposta.cidade
            txtUF.Text = resposta.uf

        Catch ex As Exception
            MsgBox("Erro ao buscar CEP.!" & ex.Message.ToString, vbCritical)
        End Try
    End Sub

    Private Sub txtBuscarNome_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged
        If txtBuscarNome.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_cliente_Nomebuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscarNome.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscarCPF_MaskInputRejected_1(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBuscarCPF.MaskInputRejected
        If txtBuscarCPF.Text = "   .   .   -" And dg.Rows.Count > 0 Then
            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_cliente_Cpfbuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cpf", txtBuscarCPF.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub rbNome_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarCPF.Text = ""
        txtBuscarNome.Text = ""
        txtBuscarNome.Visible = True
        txtBuscarCPF.Visible = False
        txtBuscarNome.Focus()
    End Sub

    Private Sub rbCPF_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscarNome.Text = ""
        txtBuscarCPF.Text = ""
        txtBuscarNome.Visible = False
        txtBuscarCPF.Visible = True
        txtBuscarCPF.Focus()
    End Sub

    Private Sub lblSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btBuscarCNPJ_Click_1(sender As Object, e As EventArgs) Handles btBuscarCNPJ.Click
        ObterCnpj(txtCNPJ.Text)
    End Sub

    Private Sub btNovoPJ_Click(sender As Object, e As EventArgs) Handles btNovoPJ.Click
        HabilitarCampos()
        Limpar()
        btSalvarPJ.Enabled = True
        'btEditarPJ.Enabled = False
        btEscluirPJ.Enabled = False
    End Sub

    Private Sub btSalvarPJ_Click(sender As Object, e As EventArgs) Handles btSalvarPJ.Click
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" And txtRazaoSocial.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_cliente_SalvarPJ", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtRazaoSocial.Text)
                cmd.Parameters.AddWithValue("@cpf", "")
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.AddWithValue("@rg", "")
                cmd.Parameters.AddWithValue("@ie", txtIE.Text)
                cmd.Parameters.AddWithValue("@estadoCivil", "")
                cmd.Parameters.AddWithValue("@naturalidade", "")
                cmd.Parameters.AddWithValue("@sexo", "")
                cmd.Parameters.AddWithValue("@dtNasc", "")
                cmd.Parameters.AddWithValue("@telRes", txtTelPJ.Text)
                cmd.Parameters.AddWithValue("@telcel", "")
                cmd.Parameters.AddWithValue("@email", txtEmailPJ.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEPPJ.Text)
                cmd.Parameters.AddWithValue("@UF", txtUFPJ.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEnd.Text)
                cmd.Parameters.AddWithValue("@num", txtNum.Text)
                cmd.Parameters.AddWithValue("@compl", txtComplPJ.Text)
                cmd.Parameters.AddWithValue("@complemento", "")
                cmd.Parameters.AddWithValue("@bairro", txtBairroPJ.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidadePJ.Text)
                cmd.Parameters.AddWithValue("@obs", txtObsPj.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.ToShortDateString)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text)
                cmd.Parameters.AddWithValue("@tipocli", 1)
                cmd.Parameters.AddWithValue("@fantasia", txtFantasia.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                ListarPJ()
                Limpar()

                btSalvarPJ.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar o Cliente" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub btEscluirPJ_Click(sender As Object, e As EventArgs) Handles btEscluirPJ.Click
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este cliente?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_cliente_ExcluirPJ", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                ListarPJ()
                Limpar()

                btnExcluir.Enabled = False
                'btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao  excluir os dados deste Cliente" + ex.Message.ToString)
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
    Private Sub ContarLinhasPJ()
        Dim total As Integer = dgPJ.Rows.Count
        lblTotalPJ.Text = CInt(total)

    End Sub

    Private Sub FormatarDGPJ()
        dgPJ.Columns(0).Visible = False
        dgPJ.Columns(15).Visible = False
        '  dgPJ.Columns(6).Visible = False



        dgPJ.Columns(1).HeaderText = "Nome"
        dgPJ.Columns(2).HeaderText = "Fantasia"
        dgPJ.Columns(3).HeaderText = "CNPJ"
        dgPJ.Columns(4).HeaderText = "Inscr. Estadual"
        dgPJ.Columns(5).HeaderText = "Telefone"
        dgPJ.Columns(6).HeaderText = "Email"
        dgPJ.Columns(7).HeaderText = "CEP"
        dgPJ.Columns(8).HeaderText = "UF"
        dgPJ.Columns(9).HeaderText = "Endereço"
        dgPJ.Columns(10).HeaderText = "Num"
        dgPJ.Columns(11).HeaderText = "Compl"
        dgPJ.Columns(12).HeaderText = "Bairro"
        dgPJ.Columns(13).HeaderText = "Cidade"
        dgPJ.Columns(14).HeaderText = "Obs."
        dgPJ.Columns(15).HeaderText = "Situação"
        dgPJ.Columns(16).HeaderText = "Motivo"
        dgPJ.Columns(17).HeaderText = "Data Cadastro"
        dgPJ.Columns(18).HeaderText = "Tipo"

        dgPJ.Columns(1).Width = 150
        dgPJ.Columns(2).Width = 100
        dgPJ.Columns(3).Width = 100
        dgPJ.Columns(6).Width = 80
        dgPJ.Columns(7).Width = 100
        dgPJ.Columns(8).Width = 120
        dgPJ.Columns(9).Width = 120
        dgPJ.Columns(10).Width = 50
        dgPJ.Columns(11).Width = 80
        dgPJ.Columns(12).Width = 100
        dgPJ.Columns(13).Width = 100

    End Sub

    Private Sub dgPJ_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPJ.CellClick
        btEscluirPJ.Enabled = True
        btSalvarPJ.Enabled = False

        HabilitarCampos()
        ' txtCNPJ.Enabled = False

        lblCodigo.Text = dgPJ.CurrentRow.Cells(0).Value
        txtRazaoSocial.Text = dgPJ.CurrentRow.Cells(1).Value
        txtFantasia.Text = dgPJ.CurrentRow.Cells(2).Value
        txtCNPJ.Text = dgPJ.CurrentRow.Cells(3).Value
        txtIE.Text = dgPJ.CurrentRow.Cells(4).Value
        txtTelPJ.Text = dgPJ.CurrentRow.Cells(5).Value
        txtEmailPJ.Text = dgPJ.CurrentRow.Cells(6).Value
        txtCEPPJ.Text = dgPJ.CurrentRow.Cells(7).Value
        txtUFPJ.Text = dgPJ.CurrentRow.Cells(8).Value
        txtEnd.Text = dgPJ.CurrentRow.Cells(9).Value
        txtNum.Text = dgPJ.CurrentRow.Cells(10).Value
        txtComplPJ.Text = dgPJ.CurrentRow.Cells(11).Value
        txtBairroPJ.Text = dgPJ.CurrentRow.Cells(12).Value
        txtCidadePJ.Text = dgPJ.CurrentRow.Cells(13).Value
        txtObsPj.Text = dgPJ.CurrentRow.Cells(14).Value
        txtSituacao.Text = dgPJ.CurrentRow.Cells(15).Value
        txtMotivo.Text = dgPJ.CurrentRow.Cells(16).Value

    End Sub

    Private Sub rbNomePJ_CheckedChanged(sender As Object, e As EventArgs) Handles rbNomePJ.CheckedChanged
        txtBuscarCNPJ.Text = ""
        txtBuscarNomePJ.Text = ""
        txtBuscarNomePJ.Visible = True
        txtBuscarCNPJ.Visible = False
        txtBuscarNomePJ.Focus()
    End Sub

    Private Sub rbCNPJ_CheckedChanged(sender As Object, e As EventArgs) Handles rbCNPJ.CheckedChanged
        txtBuscarNomePJ.Text = ""
        txtBuscarCNPJ.Text = ""
        txtBuscarNomePJ.Visible = False
        txtBuscarCNPJ.Visible = True
        txtBuscarCNPJ.Focus()
    End Sub

    Private Sub txtNomePJ_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNomePJ.TextChanged
        If txtBuscarNomePJ.Text = "" And dgPJ.Rows.Count > 0 Then

            ListarPJ()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_cliente_NomebuscarPJ", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscarNomePJ.Text)

                da.Fill(dt)
                dgPJ.DataSource = dt

                ContarLinhasPJ()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBuscarCNPJ.MaskInputRejected
        If txtBuscarCNPJ.Text = "   .   .   -" And dgPJ.Rows.Count > 0 Then


        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_cliente_CpfbuscarPJ", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cnpj", txtBuscarCNPJ.Text)

                da.Fill(dt)
                dgPJ.DataSource = dt

                ListarPJ()
                ContarLinhasPJ()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub frmClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyCode = Keys.F1 Then
        '    botaoNovo()
        'End If
        'If e.KeyCode = Keys.F2 Then
        '    botaoBuscarCep()
        'End If

        Select Case e.KeyCode
            Case Keys.F1
                btnNovo.PerformClick()
            Case Keys.F2
                btBuscarCEP.PerformClick()
            Case Keys.F3
                btnEditar.PerformClick()
            Case Keys.F4
                btnExcluir.PerformClick()
            Case Keys.F5
                btBuscarCNPJ.PerformClick()
            Case Keys.F6
                btNovoPJ.PerformClick()
            Case Keys.F7
                btSalvarPJ.PerformClick()
            Case Keys.F8
                btEscluirPJ.PerformClick()

            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btSair_Click_1(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
End Class