Imports System.Data.SqlClient
Imports System.Text

Public Class frmServicos

    Dim CodigoServico As Integer

    Private Sub frmServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        btSalvar.Enabled = False
        Listar()

        CarregarTipoServico()
        CarregarClientes()

        rbCliente.Checked = True

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub DesabilitarCampos()
        txtNumServico.Enabled = False
        txtCodigo.Enabled = False
        cbCliente.Enabled = False
        mktDtEntrada.Enabled = False
        txtCEP.Enabled = False
        'txtUF.Enabled = False
        'txtEndereco.Enabled = False
        txtNumero.Enabled = False
        'txtComplemento.Enabled = False
        txtCompl.Enabled = False
        'txtBairro.Enabled = False
        'txtCidade.Enabled = False
        txtTelRes.Enabled = False
        txtTelCel.Enabled = False
        txtEmail.Enabled = False
        cbTipoServico.Enabled = False
        txtResponsavel.Enabled = False
        cbGarantia.Enabled = False
        mktDtEntrega.Enabled = False
        txtValor.Enabled = False
        cbStatusPgto.Enabled = False
        txtObs.Enabled = False

    End Sub

    Private Sub HabilitarCampos()

        txtNumServico.Enabled = True
        txtCodigo.Enabled = True
        cbCliente.Enabled = True
        mktDtEntrada.Enabled = True
        txtCEP.Enabled = True
        'txtUF.Enabled = True
        'txtEndereco.Enabled = True
        txtNumero.Enabled = True
        'txtComplemento.Enabled = True
        txtCompl.Enabled = True
        'txtBairro.Enabled = True
        'txtCidade.Enabled = True
        txtTelRes.Enabled = True
        txtTelCel.Enabled = True
        txtEmail.Enabled = True
        cbTipoServico.Enabled = True
        txtResponsavel.Enabled = True
        cbGarantia.Enabled = True
        mktDtEntrega.Enabled = True
        txtValor.Enabled = True
        cbStatusPgto.Enabled = True
        txtObs.Enabled = True
    End Sub

    Private Sub Limpar()
        cbCliente.Focus()
        txtNumServico.Text = ""
        txtCodigo.Text = ""
        cbCliente.Text = Nothing
        mktDtEntrada.Text = ""
        txtCEP.Text = ""
        txtUF.Text = Nothing
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtComplemento.Text = ""
        txtCompl.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtTelRes.Text = ""
        txtTelCel.Text = ""
        txtEmail.Text = ""
        cbTipoServico.Text = Nothing
        txtResponsavel.Text = ""
        cbGarantia.Text = Nothing
        mktDtEntrega.Text = ""
        txtValor.Text = ""
        cbStatusPgto.Text = Nothing
        txtObs.Text = ""

    End Sub

    Private Sub FormatarDG()

        With dgvServico
            .Columns(22).Visible = False
            .Columns(21).Visible = False

            .Columns(0).HeaderText = "Núm. OS"
            .Columns(1).HeaderText = "Cliente"
            .Columns(2).HeaderText = "Entrada"
            .Columns(3).HeaderText = "CEP"
            .Columns(4).HeaderText = "UF"
            .Columns(5).HeaderText = "Endereço"
            .Columns(6).HeaderText = "Num."
            .Columns(7).HeaderText = "Complemento2."
            .Columns(8).HeaderText = "Compl"
            .Columns(9).HeaderText = "Bairro"
            .Columns(10).HeaderText = "Cidade"
            .Columns(11).HeaderText = "Tel. Residencial"
            .Columns(12).HeaderText = "Tel. Celular"
            .Columns(13).HeaderText = "Email"
            .Columns(14).HeaderText = "Serviço"
            .Columns(15).HeaderText = "Responsável"
            .Columns(16).HeaderText = "Garantia"
            .Columns(17).HeaderText = "Data de Entrega"
            .Columns(18).HeaderText = "Valor"
            .Columns(19).HeaderText = "Status do Pag."
            .Columns(20).HeaderText = "Observações"
            .Columns(21).HeaderText = "idClienteidTipo"
            .Columns(22).HeaderText = "idTipo"

            .Columns(0).Width = 50
            .Columns(1).Width = 180
            .Columns(2).Width = 100
            .Columns(3).Width = 90
            .Columns(4).Width = 45
            .Columns(5).Width = 200
            .Columns(6).Width = 50
            .Columns(7).Width = 150
            .Columns(8).Width = 150
            .Columns(9).Width = 150
            .Columns(10).Width = 120
            .Columns(11).Width = 120
            .Columns(12).Width = 200
            .Columns(13).Width = 200
            .Columns(14).Width = 200
            .Columns(15).Width = 120
            .Columns(16).Width = 100
            .Columns(17).Width = 100
            .Columns(18).Width = 180
            .Columns(19).Width = 250
        End With

    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_Servico_Lista", con)
            da.Fill(dt)
            dgvServico.DataSource = dt

            ContarLinhas()
            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Serviços" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub


    Sub CarregarClientes()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbClientes", con) 
            DA = New SqlDataAdapter("pa_cliente_listar", con)
            DA.Fill(DT)
            cbCliente.DisplayMember = "nome"
            cbCliente.ValueMember = "id_cliente"
            cbCliente.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarTipoServico()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbTipoServico", con)
            DA = New SqlDataAdapter("pa_tipoServico_listar", con)

            DA.Fill(DT)
            cbTipoServico.DisplayMember = "tipoServico"
            cbTipoServico.ValueMember = "id_tipo"
            cbTipoServico.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub
    Private Sub ContarLinhas()
        Dim total As Integer = dgvServico.Rows.Count
        lblTotal.Text = CInt(total)
    End Sub

    Public Shared Sub Moeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = ""
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
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

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
        Limpar()
        btSalvar.Enabled = True

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If cbCliente.Text <> "" Then

            Dim valor1 = Replace(txtValor.Text, ",", ".")

            Try
                abrir()
                cmd = New SqlCommand("pa_servico_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@dtEntrada", mktDtEntrada.Text)
                cmd.Parameters.AddWithValue("@CEP", txtCEP.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@telres", txtTelRes.Text)
                cmd.Parameters.AddWithValue("@telcel", txtTelCel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@id_tipo", cbTipoServico.SelectedValue)
                cmd.Parameters.AddWithValue("@responsavel", txtResponsavel.Text)
                cmd.Parameters.AddWithValue("@garantia", cbGarantia.Text)
                cmd.Parameters.AddWithValue("@dtEntrega", mktDtEntrega.Text)
                cmd.Parameters.AddWithValue("@valor", valor1)
                cmd.Parameters.AddWithValue("@statusPag", cbStatusPgto.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
                Limpar()

                btSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Dim valor1 = Replace(txtValor.Text, ",", ".")


            Try
                abrir()
                cmd = New SqlCommand("pa_Servico_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_servico", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@dtEntrada", mktDtEntrada.Text)
                cmd.Parameters.AddWithValue("@CEP", txtCEP.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@telres", txtTelRes.Text)
                cmd.Parameters.AddWithValue("@telcel", txtTelCel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@id_tipo", cbTipoServico.SelectedValue)
                cmd.Parameters.AddWithValue("@responsavel", txtResponsavel.Text)
                cmd.Parameters.AddWithValue("@garantia", cbGarantia.Text)
                cmd.Parameters.AddWithValue("@dtEntrega", mktDtEntrega.Text)
                cmd.Parameters.AddWithValue("@valor", valor1)
                cmd.Parameters.AddWithValue("@statusPag", cbStatusPgto.Text)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este serviço?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_Servico_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_servico", txtCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dgvServico_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServico.CellClick
        Cadastro.Show()

        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btSalvar.Enabled = False

        HabilitarCampos()

        txtCodigo.Text = dgvServico.CurrentRow.Cells(0).Value
        cbCliente.Text = dgvServico.CurrentRow.Cells(1).Value
        mktDtEntrada.Text = dgvServico.CurrentRow.Cells(2).Value
        txtCEP.Text = dgvServico.CurrentRow.Cells(3).Value
        txtUF.Text = dgvServico.CurrentRow.Cells(4).Value
        txtEndereco.Text = dgvServico.CurrentRow.Cells(5).Value
        txtNumero.Text = dgvServico.CurrentRow.Cells(6).Value
        txtComplemento.Text = dgvServico.CurrentRow.Cells(7).Value
        txtCompl.Text = dgvServico.CurrentRow.Cells(8).Value
        txtBairro.Text = dgvServico.CurrentRow.Cells(9).Value
        txtCidade.Text = dgvServico.CurrentRow.Cells(10).Value
        txtTelRes.Text = dgvServico.CurrentRow.Cells(11).Value
        txtTelCel.Text = dgvServico.CurrentRow.Cells(12).Value
        txtEmail.Text = dgvServico.CurrentRow.Cells(13).Value
        cbTipoServico.Text = dgvServico.CurrentRow.Cells(14).Value
        txtResponsavel.Text = dgvServico.CurrentRow.Cells(15).Value
        cbGarantia.Text = dgvServico.CurrentRow.Cells(16).Value
        mktDtEntrega.Text = dgvServico.CurrentRow.Cells(17).Value
        txtValor.Text = dgvServico.CurrentRow.Cells(18).Value
        cbStatusPgto.Text = dgvServico.CurrentRow.Cells(19).Value
        txtObs.Text = dgvServico.CurrentRow.Cells(20).Value
    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        txtBuscar.Text = ""
        txtBuscar.Visible = False
        txtNumeroOrdem.Visible = False
        dtData.Visible = True
        '  Listar()
    End Sub

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        dtData.Visible = False
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtNumeroOrdem.Visible = False
        txtBuscar.Focus()
        ' Listar()
    End Sub

    Private Sub rbNumeroServico_CheckedChanged(sender As Object, e As EventArgs) Handles rbNumeroServico.CheckedChanged
        dtData.Visible = False
        txtBuscar.Visible = False
        txtNumeroOrdem.Visible = True
        txtNumeroOrdem.Focus()
    End Sub

    Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged
        'If dtData.Text = "" And dgvServico.Rows.Count > 0 Then

        Listar()

        '  Else
        Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
            da = New SqlDataAdapter("pa_Servico_ConsultaData", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@data", dtData.Text)

                da.Fill(dt)
                dgvServico.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        '  End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dgvServico.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_Servico_ConsultaNome", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscar.Text)

                da.Fill(dt)
                dgvServico.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtNumeroOrdem_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroOrdem.TextChanged
        If txtNumeroOrdem.Text = "" And dgvServico.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_Servico_ConsultaNumeroOrdem", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_servico", txtNumeroOrdem.Text)

                da.Fill(dt)
                dgvServico.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub
End Class