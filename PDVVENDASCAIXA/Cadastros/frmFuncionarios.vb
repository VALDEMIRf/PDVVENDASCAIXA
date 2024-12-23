﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports iTextSharp.text.pdf
Public Class frmFuncionarios
    Private ImagemCarregada As Image
    Private _create As Net.HttpWebRequest

    Private Sub frmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarImagem()
        DesabilitarCampos()

        btSalvar.Enabled = False
        txtBuscarCPF.Visible = False

        Listar()
        CarregarCargos()

        btEditar.Enabled = False
        btExcluir.Enabled = False
        rbNome.Checked = True

    End Sub

    Sub CarregarCargos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_Cargo_listar", con)
            DA.Fill(DT)
            cbCargo.DisplayMember = "cargo"
            cbCargo.ValueMember = "idCargo"
            cbCargo.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_funcionario_listar", con)
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os funcionários" + ex.Message.ToString)
        Finally

            fechar()
        End Try


    End Sub

    Private Sub FormatarDG()
        With dg
            .Columns(0).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(28).Visible = False
            .Columns(29).Visible = False
            .Columns(30).Visible = False

            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "CPF"
            .Columns(3).HeaderText = "RG"
            .Columns(4).HeaderText = "PIS"
            .Columns(5).HeaderText = "Tel Res"
            .Columns(6).HeaderText = "Tel Cel"
            '.Columns(7).HeaderText = "CTPS"
            ' .Columns(8).HeaderText = "SERIE"
            .Columns(9).HeaderText = "Salário"
            .Columns(10).HeaderText = "Email"
            .Columns(11).HeaderText = "Sexo"
            .Columns(12).HeaderText = "dtNasc."
            .Columns(13).HeaderText = "Cargo"
            '.Columns(14).HeaderText = "Dt Contratação"
            '.Columns(15).HeaderText = "Dt Demissão"
            '.Columns(16).HeaderText = "Hora Inicial"
            '.Columns(17).HeaderText = "Intervalo"
            '.Columns(18).HeaderText = "Retorno"
            '.Columns(19).HeaderText = "Fim do exp."
            .Columns(20).HeaderText = "CEP"
            .Columns(21).HeaderText = "UF"
            .Columns(22).HeaderText = "Endereço"
            .Columns(23).HeaderText = "Num."
            .Columns(24).HeaderText = "Compl1"
            .Columns(25).HeaderText = "Compl2"
            .Columns(26).HeaderText = "Bairro"
            .Columns(27).HeaderText = "Cidade"
            '   .Columns(28).HeaderText = "Foto"


            '.Columns(5).Width = 130
            '.Columns(6).Width = 150
            '.Columns(8).Width = 65
            '.Columns(9).Width = 30
            '.Columns(10).Width = 170
            '.Columns(11).Width = 45
            '.Columns(12).Width = 110
            '.Columns(13).Width = 110
            '.Columns(14).Width = 150
            '.Columns(15).Width = 150
            '.Columns(16).Width = 65
        End With

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        cbSexo.Enabled = False
        txtRG.Enabled = False
        txtCPF.Enabled = False
        txtTel.Enabled = False
        txtEmail.Enabled = False
        txtdtNasc.Enabled = False
        txtCompl.Enabled = False
        txtCEP.Enabled = False
        cbCargo.Enabled = False
        dtData.Enabled = False
        txtdtDemissao.Enabled = False
        txtPIS.Enabled = False
        txtTel.Enabled = False
        txtCel.Enabled = False
        txtCTPS.Enabled = False
        txtSerie.Enabled = False
        txtSalario.Enabled = False
        txtEntrada.Enabled = False
        txtSaida.Enabled = False
        txtEntrada2.Enabled = False
        txtSaida2.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        cbSexo.Enabled = True
        txtRG.Enabled = True
        txtCPF.Enabled = True
        txtTel.Enabled = True
        txtEmail.Enabled = True
        txtdtNasc.Enabled = True
        txtNumero.Enabled = True
        txtCompl.Enabled = True
        txtCEP.Enabled = True
        cbCargo.Enabled = True
        dtData.Enabled = True
        txtdtDemissao.Enabled = True
        txtPIS.Enabled = True
        txtTel.Enabled = True
        txtCel.Enabled = True
        txtCTPS.Enabled = True
        txtSerie.Enabled = True
        txtSalario.Enabled = True
        txtEntrada.Enabled = True
        txtSaida.Enabled = True
        txtEntrada2.Enabled = True
        txtSaida2.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNome.Focus()
        txtNome.Text = ""
        cbSexo.Text = Nothing
        txtRG.Text = ""
        txtCPF.Text = ""
        txtTel.Text = ""
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
        cbCargo.Text = Nothing
        dtData.Text = ""
        txtdtDemissao.Text = ""
        txtBuscar.Text = ""
        txtPIS.Text = ""
        txtTel.Text = ""
        txtCel.Text = ""
        txtCTPS.Text = ""
        txtSerie.Text = ""
        txtSalario.Text = ""
        txtEntrada.Text = ""
        txtSaida.Text = ""
        txtEntrada2.Text = ""
        txtSaida2.Text = ""


        carregarImagem()
    End Sub

    Private Sub btBuscarCEP_Click(sender As Object, e As EventArgs) Handles btBuscarCEP.Click
        If validaCEP() Then
            ObterCep(txtCEP.Text)
            ' MessageBox.Show("Digite um cep válido!!!!")
        End If

        'Try
        '    Dim ws = New WSCEP.AtendeClienteClient()
        '    Dim resposta = ws.consultaCEP(txtCEP.Text)
        '    txtEndereco.Text = resposta.end
        '    txtComplemento.Text = resposta.complemento2
        '    txtBairro.Text = resposta.bairro
        '    txtCidade.Text = resposta.cidade
        '    txtUF.Text = resposta.uf

        'Catch ex As Exception
        '    MsgBox("Erro ao buscar o CEP.!" & ex.Message.ToString, vbCritical)
        'End Try
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

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
        Limpar()
        btSalvar.Enabled = True

        btEditar.Enabled = False
        btExcluir.Enabled = False
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtCPF.Text <> "" And txtNome.Text <> "" Then

            Try

                'CARREGANDO IMAGEM NO BANCO
                Dim MS As New IO.MemoryStream
                ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = MS.ToArray

                Dim vlSalario = Replace(txtSalario.Text, ",", ".")

                abrir()
                cmd = New SqlCommand("pa_funcionario_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
                cmd.Parameters.AddWithValue("@pis", txtPIS.Text)
                cmd.Parameters.AddWithValue("@telRes", txtTel.Text)
                cmd.Parameters.AddWithValue("@telcel", txtCel.Text)
                cmd.Parameters.AddWithValue("@ctps", txtCTPS.Text)
                cmd.Parameters.AddWithValue("@serie", txtSerie.Text)
                cmd.Parameters.AddWithValue("@salario", vlSalario)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@dtNasc", txtdtNasc.Text)
                cmd.Parameters.AddWithValue("@idCargo", cbCargo.SelectedValue)
                cmd.Parameters.AddWithValue("@data_contratado", dtData.Text)
                cmd.Parameters.AddWithValue("@data_demissao", txtdtDemissao.Text)
                cmd.Parameters.AddWithValue("@horaentrada", txtEntrada.Text)
                cmd.Parameters.AddWithValue("@horasaida", txtSaida.Text)
                cmd.Parameters.AddWithValue("@horaentrada2", txtEntrada2.Text)
                cmd.Parameters.AddWithValue("@horasaida2", txtSaida2.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@complemento2", txtComplemento.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@imagem", byteArray)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
                Limpar()

                btSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Dim cmd As SqlCommand

        If txtCPF.Text <> "" And txtNome.Text <> "" Then

            Try

                'CARREGANDO IMAGEM NO BANCO
                Dim MS As New IO.MemoryStream
                ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = MS.ToArray

                Dim vlSalario = Replace(txtSalario.Text, ",", ".")
                abrir()
                cmd = New SqlCommand("pa_funcionario_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.AddWithValue("@rg", txtRG.Text)
                cmd.Parameters.AddWithValue("@pis", txtPIS.Text)
                cmd.Parameters.AddWithValue("@telRes", txtTel.Text)
                cmd.Parameters.AddWithValue("@telcel", txtCel.Text)
                cmd.Parameters.AddWithValue("@ctps", txtCTPS.Text)
                cmd.Parameters.AddWithValue("@serie", txtSerie.Text)
                cmd.Parameters.AddWithValue("@salario", vlSalario)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@dtNasc", txtdtNasc.Text)
                cmd.Parameters.AddWithValue("@idCargo", cbCargo.SelectedValue)
                cmd.Parameters.AddWithValue("@data_contratado", dtData.Text)
                cmd.Parameters.AddWithValue("@data_demissao", txtdtDemissao.Text)
                cmd.Parameters.AddWithValue("@horaentrada", txtEntrada.Text)
                cmd.Parameters.AddWithValue("@horasaida", txtSaida.Text)
                cmd.Parameters.AddWithValue("@horaentrada2", txtEntrada2.Text)
                cmd.Parameters.AddWithValue("@horasaida2", txtSaida2.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@complemento2", txtComplemento.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@imagem", byteArray)
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

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtCPF.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este funcionário?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_funcionario_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btExcluir.Enabled = False
                btEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarCPF.Text = ""
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtBuscarCPF.Visible = False
        txtBuscar.Focus()
        Listar()
    End Sub

    Private Sub rbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscar.Text = ""
        txtBuscarCPF.Text = ""
        txtBuscar.Visible = False
        txtBuscarCPF.Visible = True
        txtBuscarCPF.Focus()
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
                da = New SqlDataAdapter("pa_funcionario_Nomebuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscar.Text)

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
                da = New SqlDataAdapter("pa_funcionario_Cpfbuscar", con)
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

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Cadastro.Show()

        btEditar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        HabilitarCampos()
        txtCPF.Enabled = False

        txtNome.Text = dg.CurrentRow.Cells(1).Value
        txtCPF.Text = dg.CurrentRow.Cells(2).Value
        txtRG.Text = dg.CurrentRow.Cells(3).Value
        txtPIS.Text = dg.CurrentRow.Cells(4).Value
        txtTel.Text = dg.CurrentRow.Cells(5).Value
        txtCel.Text = dg.CurrentRow.Cells(6).Value
        txtCTPS.Text = dg.CurrentRow.Cells(7).Value
        txtSerie.Text = dg.CurrentRow.Cells(8).Value
        txtSalario.Text = dg.CurrentRow.Cells(9).Value
        txtEmail.Text = dg.CurrentRow.Cells(10).Value
        cbSexo.Text = dg.CurrentRow.Cells(11).Value
        txtdtNasc.Text = dg.CurrentRow.Cells(12).Value
        cbCargo.Text = dg.CurrentRow.Cells(13).Value
        dtData.Text = dg.CurrentRow.Cells(14).Value
        txtdtDemissao.Text = dg.CurrentRow.Cells(15).Value
        txtEntrada.Text = dg.CurrentRow.Cells(16).Value
        txtSaida.Text = dg.CurrentRow.Cells(17).Value
        txtEntrada2.Text = dg.CurrentRow.Cells(18).Value
        txtSaida2.Text = dg.CurrentRow.Cells(19).Value
        txtCEP.Text = dg.CurrentRow.Cells(20).Value
        txtUF.Text = dg.CurrentRow.Cells(21).Value
        txtEndereco.Text = dg.CurrentRow.Cells(22).Value
        txtNumero.Text = dg.CurrentRow.Cells(23).Value
        txtCompl.Text = dg.CurrentRow.Cells(24).Value
        txtComplemento.Text = dg.CurrentRow.Cells(25).Value
        txtBairro.Text = dg.CurrentRow.Cells(26).Value
        txtCidade.Text = dg.CurrentRow.Cells(27).Value

        Dim tempImagem As Byte() = DirectCast(dg.CurrentRow.Cells(28).Value, Byte())
        If tempImagem Is Nothing Then
            MessageBox.Show("Imagem não localizada", "Erro")
            Exit Sub
        End If
        Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
        Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
        fs.Write(tempImagem, 0, tempImagem.Length)
        fs.Flush()
        fs.Close()
        ImagemCarregada = Image.FromFile(strArquivo)
        pbImagem.Image = ImagemCarregada
    End Sub

    Private Sub btImagem_Click(sender As Object, e As EventArgs) Handles btImagem.Click
        pbImagem.Visible = True
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"}

            If OFD.ShowDialog = DialogResult.OK Then
                ImagemCarregada = Image.FromFile(OFD.FileName)
                pbImagem.Image = ImagemCarregada
            End If
        End Using
    End Sub

    Sub carregarImagem()

        ' Try
        ' 
        Dim img As String = "https://www.buritama.sp.leg.br/imagens/parlamentares-2013-2016/sem-foto.jpg/image"
        ' Dim img As String = My.Resources.imagesemfoto
        Dim req As System.Net.HttpWebRequest
        Dim resp As System.Net.HttpWebResponse
        req = Net.WebRequest.Create(img)
        req = req.Create(img)

        resp = req.GetResponse

        ImagemCarregada = New Bitmap(resp.GetResponseStream)
        pbImagem.Image = ImagemCarregada
        req.Abort()

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
End Class