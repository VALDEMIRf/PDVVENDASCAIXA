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
        cbCliente.Enabled = False
        cbTipoServico.Enabled = False
        mktDtEntrada.Enabled = False
        txtEndereco.Enabled = False
        txtNumero.Enabled = False
        txtBairro.Enabled = False
        txtCidade.Enabled = False
        txtUF.Enabled = False
        txtCEP.Enabled = False
        txtTelRes.Enabled = False
        txtTelCel.Enabled = False
        txtEmail.Enabled = False
        txtResponsavel.Enabled = False
        cbGarantia.Enabled = False
        mktDtEntrega.Enabled = False
        txtValor.Enabled = False
        cbStatusPgto.Enabled = False
        txtObs.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNumServico.Enabled = True
        cbCliente.Enabled = True
        cbTipoServico.Enabled = True
        mktDtEntrada.Enabled = True
        txtEndereco.Enabled = True
        txtNumero.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
        txtUF.Enabled = True
        txtCEP.Enabled = True
        txtTelRes.Enabled = True
        txtTelCel.Enabled = True
        txtEmail.Enabled = True
        txtResponsavel.Enabled = True
        cbGarantia.Enabled = True
        mktDtEntrega.Enabled = True
        txtValor.Enabled = True
        cbStatusPgto.Enabled = True
        txtObs.Enabled = True
    End Sub

    Private Sub Limpar()
        cbCliente.Focus()
        txtCodigo.Text = ""
        cbCliente.Text = Nothing
        cbTipoServico.Text = Nothing
        mktDtEntrada.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtUF.Text = Nothing
        txtCEP.Text = ""
        txtTelRes.Text = ""
        txtTelCel.Text = ""
        txtEmail.Text = ""
        txtResponsavel.Text = ""
        cbGarantia.Text = Nothing
        mktDtEntrega.Text = ""
        txtValor.Text = ""
        cbStatusPgto.Text = Nothing
        txtObs.Text = ""

    End Sub

    Private Sub FormatarDG()

        dgvServico.Columns(20).Visible = False
        dgvServico.Columns(21).Visible = False

        dgvServico.Columns(0).HeaderText = "Núm. OS"
        dgvServico.Columns(1).HeaderText = "Cliente"
        dgvServico.Columns(2).HeaderText = "Entrada"
        dgvServico.Columns(3).HeaderText = "CEP"
        dgvServico.Columns(4).HeaderText = "UF"
        dgvServico.Columns(5).HeaderText = "Endereço"
        dgvServico.Columns(6).HeaderText = "Num."
        dgvServico.Columns(7).HeaderText = "Compl."
        dgvServico.Columns(8).HeaderText = "Bairro"
        dgvServico.Columns(9).HeaderText = "Cidade"
        dgvServico.Columns(10).HeaderText = "Residencial"
        dgvServico.Columns(11).HeaderText = "Celular"
        dgvServico.Columns(12).HeaderText = "Email"
        dgvServico.Columns(13).HeaderText = "Serviço"
        dgvServico.Columns(14).HeaderText = "Responsável"
        dgvServico.Columns(15).HeaderText = "Garantia"
        dgvServico.Columns(16).HeaderText = "Entrega"
        dgvServico.Columns(17).HeaderText = "Valor"
        dgvServico.Columns(18).HeaderText = "Status do Pag."
        dgvServico.Columns(19).HeaderText = "Observações"
        dgvServico.Columns(20).HeaderText = "idCliente"
        dgvServico.Columns(21).HeaderText = "idTipo"

        dgvServico.Columns(0).Width = 50
        dgvServico.Columns(1).Width = 180
        dgvServico.Columns(2).Width = 100
        dgvServico.Columns(3).Width = 90
        dgvServico.Columns(4).Width = 45
        dgvServico.Columns(5).Width = 200
        dgvServico.Columns(6).Width = 50
        dgvServico.Columns(7).Width = 150
        dgvServico.Columns(8).Width = 150
        dgvServico.Columns(9).Width = 150
        dgvServico.Columns(10).Width = 120
        dgvServico.Columns(11).Width = 120
        dgvServico.Columns(12).Width = 200
        dgvServico.Columns(13).Width = 200
        dgvServico.Columns(14).Width = 200
        dgvServico.Columns(15).Width = 120
        dgvServico.Columns(16).Width = 100
        dgvServico.Columns(17).Width = 100
        dgvServico.Columns(18).Width = 180
        dgvServico.Columns(19).Width = 250

    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_ServicoLista", con)
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
            txtComplemento2.Text = resposta.complemento2  'complemento
            txtBairro.Text = resposta.bairro
            txtCidade.Text = resposta.cidade
            txtUF.Text = resposta.uf

        Catch ex As Exception
            MsgBox("Erro ao buscar CEP.!" & ex.Message.ToString, vbCritical)
        End Try
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click

    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged

    End Sub

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged

    End Sub

    Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged

    End Sub

    Private Sub dgvServico_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServico.CellClick

    End Sub
End Class