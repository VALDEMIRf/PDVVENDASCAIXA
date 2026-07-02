Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSalvar.Enabled = False
        Listar()

        rbNome.Checked = True

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

        With dg
            .Columns(0).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(20).Visible = False


            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "CPF"
            .Columns(3).HeaderText = "RG"
            .Columns(4).HeaderText = "Est. Civil"
            .Columns(5).HeaderText = "Naturalidade"
            .Columns(6).HeaderText = "Sexo"
            .Columns(7).HeaderText = "Nascimento"
            .Columns(8).HeaderText = "Telefone"
            .Columns(9).HeaderText = "Celular"
            .Columns(10).HeaderText = "Email"
            .Columns(11).HeaderText = "CEP"
            .Columns(12).HeaderText = "UF"
            .Columns(13).HeaderText = "Endereço"
            .Columns(14).HeaderText = "Num"
            .Columns(15).HeaderText = "Compl"
            .Columns(16).HeaderText = "Compl2"
            .Columns(17).HeaderText = "Bairro"
            .Columns(18).HeaderText = "Cidade"
            .Columns(19).HeaderText = "Obs."
            .Columns(20).HeaderText = "Data Cadastro"

            .Columns(1).Width = 150
            .Columns(2).Width = 110
            .Columns(5).Width = 100
            .Columns(6).Width = 80
            .Columns(7).Width = 100
            .Columns(8).Width = 120
            .Columns(9).Width = 120
            .Columns(10).Width = 200
            .Columns(11).Width = 80
            .Columns(12).Width = 30
            .Columns(13).Width = 140
            .Columns(14).Width = 75
            .Columns(15).Width = 150
            .Columns(16).Width = 150
            .Columns(17).Width = 150
            .Columns(19).Width = 180
        End With

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

    Private Sub HabilitarCampos()

        txtCPF.Enabled = True
        txtRG.Enabled = True
        txtNome.Enabled = True
        cbEstCivil.Enabled = True
        txtNatural.Enabled = True
        cbSexo.Enabled = True
        txtdtNasc.Enabled = True
        txtTel.Enabled = True
        txtTelCel.Enabled = True
        txtEmail.Enabled = True
        txtCEP.Enabled = True
        txtNumero.Enabled = True
        txtCompl.Enabled = True
        txtObs.Enabled = True
        txtCPF.Focus()
    End Sub

    Private Sub Limpar()
        txtCPF.Text = ""
        txtRG.Text = ""
        txtNome.Text = ""
        cbEstCivil.Text = Nothing
        txtNatural.Text = ""
        cbSexo.Text = Nothing
        txtdtNasc.Text = ""
        txtTel.Text = ""
        txtTelCel.Text = ""
        txtEmail.Text = ""
        txtCEP.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCompl.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtUF.Text = Nothing
        txtObs.Text = ""

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
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
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
                cmd.Parameters.AddWithValue("@data_cadastro", Now.Date())
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
        btnEditar.Enabled = True

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
                cmd.Parameters.AddWithValue("@id_cliente", lblCodigo.Text)
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
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
                MessageBox.Show("Erro ao Editar os dados deste cliente" + ex.Message.ToString)
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
                cmd.Parameters.AddWithValue("@id_cliente", lblCodigo.Text)
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

    Private Function validaCEP()
        Dim rgxCep = New Regex("^\d{5}-\d{3}$")
        If Not rgxCep.IsMatch(txtCEP.Text) Then
            MessageBox.Show("Digite um cep válido!!!!")
            txtCEP.Focus()
            Return False
        End If
        Return True
    End Function

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

                FormatarDG()
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
                da = New SqlDataAdapter("pa_clienteCpfbuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cpf", txtBuscarCPF.Text)

                da.Fill(dt)
                dg.DataSource = dt

                FormatarDG()
                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub rbNome_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        Listar()
        txtBuscarCPF.Text = ""
        txtBuscarNome.Text = ""
        txtBuscarNome.Visible = True
        txtBuscarCPF.Visible = False
        txtBuscarNome.Focus()
    End Sub

    Private Sub rbCPF_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        Listar()
        txtBuscarNome.Text = ""
        txtBuscarCPF.Text = ""
        txtBuscarNome.Visible = False
        txtBuscarCPF.Visible = True
        txtBuscarCPF.Focus()
    End Sub

    Private Sub ObterCep(cep As String)

        Dim dsCep = clsCep.ObterCep(cep)
        Try
            txtEndereco.Text = UTF8_to_ISO(dsCep.logradouro)
            txtComplemento.Text = UTF8_to_ISO(dsCep.complemento)
            txtBairro.Text = UTF8_to_ISO(dsCep.bairro)
            txtCidade.Text = UTF8_to_ISO(dsCep.localidade)
            txtUF.Text = dsCep.uf
        Catch ex As Exception
            MessageBox.Show("CEP Incorreto, digite um CEP válido!!!", "ERRO")
        End Try

    End Sub


    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btBuscarCEP_Click(sender As Object, e As EventArgs) Handles btBuscarCEP.Click
        If validaCEP() Then

            ObterCep(txtCEP.Text)

        End If
    End Sub
End Class