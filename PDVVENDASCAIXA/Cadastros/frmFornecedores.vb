Imports System.Data.SqlClient
Imports System.Data.IO

Public Class frmFornecedores
    Private Sub frmFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSalvar.Enabled = False
        txtBuscarCNPJ.Visible = False

        Listar()

        btnExcluir.Enabled = False
        rbEmpresa.Checked = True
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_fornecedor_listar", con)

            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()

            '  FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Fornecedores" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()

        With dg
            .Columns(0).Visible = False
            .Columns(2).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False

            .Columns(1).HeaderText = "CNPJ"
            .Columns(2).HeaderText = "ABERTURA"
            .Columns(3).HeaderText = "Nome da Empresa"
            .Columns(4).HeaderText = "Fantasia"
            .Columns(5).HeaderText = "Endereço N°"
            .Columns(6).HeaderText = "Nº "
            .Columns(7).HeaderText = "Compl."
            .Columns(8).HeaderText = "Bairro"
            .Columns(9).HeaderText = "Cidade"
            .Columns(10).HeaderText = "UF"
            .Columns(11).HeaderText = "Cep"
            .Columns(12).HeaderText = "Telefone"
            .Columns(13).HeaderText = "Email"
            .Columns(14).HeaderText = "Situação"
            .Columns(15).HeaderText = "Motivo"
            .Columns(16).HeaderText = "Contato"
            .Columns(17).HeaderText = "Tel. Contato"
            .Columns(18).HeaderText = "Dt. Cadastro"

            .Columns(1).Width = 150
            .Columns(2).Width = 300
        End With

    End Sub


    Private Sub Limpar()
        txtCNPJ.Focus()
        txtCNPJ.Text = ""
        txtRazaoSocial.Text = ""
        txtFantasia.Text = ""
        txtTel.Text = ""
        txtEmail.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCompl.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtUF.Text = Nothing
        txtCEP.Text = ""
        txtMotivo.Text = ""
        txtSituacao.Text = ""
        txtAbertura.Text = ""
        txtContato.Text = ""
        txtTelContato.Text = ""

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub rbEmpresa_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpresa.CheckedChanged
        txtBuscarCNPJ.Text = ""
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtBuscarCNPJ.Visible = False
        txtBuscar.Focus()
        Listar()
    End Sub

    Private Sub rbCNPJ_CheckedChanged(sender As Object, e As EventArgs) Handles rbCNPJ.CheckedChanged
        txtBuscar.Text = ""
        txtBuscarCNPJ.Text = ""
        txtBuscar.Visible = False
        txtBuscarCNPJ.Visible = True
        txtBuscarCNPJ.Focus()
        Listar()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_fornecedor_Nomebuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@razaoSocial", txtBuscar.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscarCNPJ_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBuscarCNPJ.MaskInputRejected
        If txtBuscarCNPJ.Text = "   .   .   -" And dg.Rows.Count > 0 Then
            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_fornecedor_CNPJbuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cnpj", txtBuscarCNPJ.Text)

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

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Cadastro.Show()

        btnExcluir.Enabled = True
        btnSalvar.Enabled = False

        txtCNPJ.Text = dg.CurrentRow.Cells(1).Value
        txtAbertura.Text = dg.CurrentRow.Cells(2).Value
        txtRazaoSocial.Text = dg.CurrentRow.Cells(3).Value
        txtFantasia.Text = dg.CurrentRow.Cells(4).Value
        txtEndereco.Text = dg.CurrentRow.Cells(5).Value
        txtNumero.Text = dg.CurrentRow.Cells(6).Value
        txtCompl.Text = dg.CurrentRow.Cells(7).Value
        txtBairro.Text = dg.CurrentRow.Cells(8).Value
        txtCidade.Text = dg.CurrentRow.Cells(9).Value
        txtUF.Text = dg.CurrentRow.Cells(10).Value
        txtCEP.Text = dg.CurrentRow.Cells(11).Value
        txtTel.Text = dg.CurrentRow.Cells(12).Value
        txtEmail.Text = dg.CurrentRow.Cells(13).Value
        txtSituacao.Text = dg.CurrentRow.Cells(14).Value
        txtMotivo.Text = dg.CurrentRow.Cells(15).Value
        txtContato.Text = dg.CurrentRow.Cells(16).Value
        txtTelContato.Text = dg.CurrentRow.Cells(17).Value
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" And txtRazaoSocial.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_fornecedor_Salvar", con)
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
                cmd.Parameters.AddWithValue("@telefone", txtTel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text)
                cmd.Parameters.AddWithValue("@abertura", txtAbertura.Text)
                cmd.Parameters.AddWithValue("@contato", txtContato.Text)
                cmd.Parameters.AddWithValue("@telcontato", txtTelContato.Text)

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

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Fornecedor?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_fornecedor_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao  excluir os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        Limpar()
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles btBuscarEmpresa.Click
        btnSalvar.Enabled = True

        ObterCnpj(txtCNPJ.Text)
    End Sub

    Private Sub ObterCnpj(cnpj As String)

        Dim cliente = Empresa.ObterCnpj(cnpj)
        Try
            txtRazaoSocial.Text = cliente.nome
            txtSituacao.Text = cliente.situacao
            txtAbertura.Text = cliente.abertura
            txtMotivo.Text = UTF8_to_ISO(cliente.motivo_situacao)
            txtEndereco.Text = cliente.logradouro
            txtNumero.Text = cliente.numero
            txtCompl.Text = cliente.complemento
            txtBairro.Text = cliente.bairro
            txtCEP.Text = cliente.cep
            txtCidade.Text = cliente.municipio
            txtUF.Text = cliente.uf
            txtFantasia.Text = cliente.fantasia
            txtTel.Text = cliente.telefone
            txtEmail.Text = cliente.email
        Catch ex As Exception

            '  MessageBox.Show("CNPJ Incorreto, digite um CNPJ válido!!!" + ex.Message.ToString)
            MessageBox.Show("CNPJ Incorreto, digite um CNPJ válido!!!", "ERRO")
        End Try

    End Sub
End Class