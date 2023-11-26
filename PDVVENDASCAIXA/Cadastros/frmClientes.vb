Imports System.Data.SqlClient

Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        'dtData.Value = Now
        btnSalvar.Enabled = False
        ' txtBuscarCPF.Visible = False

        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        rbNome.Checked = True
        rbPF.Checked = True

    End Sub

    Private Sub rbPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbPF.CheckedChanged
        txtCPF.Visible = True
        txtRG.Visible = True
        txtCNPJ.Visible = False
        txtIE.Visible = False
        txtNatural.Visible = True
        txtdtNasc.Visible = True
        cbEstCivil.Visible = True
        cbSexo.Visible = True
        lblEstadoCivil.Visible = True
        lblNatural.Visible = True
        lblSexo.Visible = True
        lblNasc.Visible = True

    End Sub

    Private Sub rbPJ_CheckedChanged(sender As Object, e As EventArgs) Handles rbPJ.CheckedChanged
        txtCPF.Visible = False
        txtRG.Visible = False
        txtCNPJ.Visible = True
        txtIE.Visible = True
        txtNatural.Visible = False
        txtdtNasc.Visible = False
        cbEstCivil.Visible = False
        cbSexo.Visible = False
        lblEstadoCivil.Visible = False
        lblNatural.Visible = False
        lblSexo.Visible = False
        lblNasc.Visible = False
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
        txtIE.Text = ""
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
    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        'dg.Columns(3).Visible = False


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
        dg.Columns(16).HeaderText = "Bairro"
        dg.Columns(17).HeaderText = "Cidade"
        dg.Columns(18).HeaderText = "Data Cadastro"

        dg.Columns(1).Width = 150
        dg.Columns(2).Width = 110
        dg.Columns(5).Width = 100
        dg.Columns(6).Width = 80
        dg.Columns(7).Width = 110
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

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_cliente_listar", con)

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
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
                cmd.Parameters.AddWithValue("@ie", txtIE.Text)
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
                fechar()
            End Try
        End If
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
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
                cmd.Parameters.AddWithValue("@ie", txtIE.Text)
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

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btBuscarCEP_Click(sender As Object, e As EventArgs) Handles btBuscarCEP.Click
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

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Cadastro.Show()
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnSalvar.Enabled = False

        HabilitarCampos()
        txtCPF.Enabled = False

        txtNome.Text = dg.CurrentRow.Cells(1).Value
        txtCPF.Text = dg.CurrentRow.Cells(2).Value
        txtCNPJ.Text = dg.CurrentRow.Cells(3).Value
        txtRG.Text = dg.CurrentRow.Cells(4).Value
        txtIE.Text = dg.CurrentRow.Cells(5).Value
        cbEstCivil.Text = dg.CurrentRow.Cells(6).Value
        txtNatural.Text = dg.CurrentRow.Cells(7).Value
        cbSexo.Text = dg.CurrentRow.Cells(8).Value
        txtdtNasc.Text = dg.CurrentRow.Cells(9).Value
        txtTel.Text = dg.CurrentRow.Cells(10).Value
        txtTelCel.Text = dg.CurrentRow.Cells(11).Value
        txtEmail.Text = dg.CurrentRow.Cells(12).Value
        txtCEP.Text = dg.CurrentRow.Cells(13).Value
        txtUF.Text = dg.CurrentRow.Cells(14).Value
        txtEndereco.Text = dg.CurrentRow.Cells(15).Value
        txtNumero.Text = dg.CurrentRow.Cells(16).Value
        txtCompl.Text = dg.CurrentRow.Cells(17).Value
        txtComplemento.Text = dg.CurrentRow.Cells(18).Value
        txtBairro.Text = dg.CurrentRow.Cells(19).Value
        txtCidade.Text = dg.CurrentRow.Cells(20).Value
        txtObs.Text = dg.CurrentRow.Cells(21).Value
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarCPF.Text = ""
        txtBuscarNome.Text = ""
        txtBuscarNome.Visible = True
        txtBuscarCPF.Visible = False
        txtBuscarNome.Focus()
        Listar()
    End Sub

    Private Sub rbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscarNome.Text = ""
        txtBuscarCPF.Text = ""
        txtBuscarNome.Visible = False
        txtBuscarCPF.Visible = True
        txtBuscarCPF.Focus()
        Listar()
    End Sub

    Private Sub txtBuscarNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged
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

    Private Sub txtBuscarCPF_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBuscarCPF.MaskInputRejected
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
End Class