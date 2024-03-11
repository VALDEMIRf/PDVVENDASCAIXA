Imports System.Data.SqlClient

Public Class frmGravaContasPagar

    Private Sub frmGravaContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    btSalvar.Enabled = False

        'btnExcluir.Enabled = False

        If intCodigoLancamento <> 0 Then
            txtCodigo.Text = intCodigoLancamento
            ' PLendoDados(intCodigoLancamento)
            PLeDados()
        Else
            txtCodigo.Text = "Novo"
        End If
    End Sub

    Private Sub DesabilitarCampos()
        txtNDoc.Enabled = False
        txtDescricao.Enabled = False
        txtEmpresa.Enabled = False
        txtSituacao.Enabled = False
        txtValor.Enabled = False
        txtVencimento.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNDoc.Focus()
        txtNDoc.Enabled = True
        txtDescricao.Enabled = True
        txtEmpresa.Enabled = True
        txtSituacao.Enabled = True
        txtValor.Enabled = True
        txtVencimento.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNDoc.Focus()
        txtCodigo.Text = "Novo"
        txtNDoc.Text = ""
        txtDescricao.Text = ""
        txtEmpresa.Text = ""
        txtSituacao.Text = Nothing
        txtValor.Text = ""
        txtVencimento.Text = ""

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        txtNDoc.Focus()
        HabilitarCampos()
        ' Limpar()
        btSalvar.Enabled = True

        btnExcluir.Enabled = False

    End Sub

    Private Function FValidaCampos() As Boolean
        If txtNDoc.Text = "" Then
            MsgBox("Preencha o campo número de documento", MsgBoxStyle.Information, "Contas a Pagar")
            Return False
        End If
        If txtDescricao.Text = "" Then
            MsgBox("Preencha o campo descricao", MsgBoxStyle.Information, "Contas a Pagar")
            Return False
        End If
        If txtValor.Text = "" Then
            MsgBox("Preencha o campo valor", MsgBoxStyle.Information, "Contas a Pagar")
            Return False
        End If
        If txtEmpresa.Text = "" Then
            MsgBox("Preencha o campo empresa", MsgBoxStyle.Information, "Contas a Pagar")
            Return False
        End If

        Return True
    End Function

    Private Sub Gravar()
        Dim cmd As SqlCommand

        If txtNDoc.Text <> "" Then

            Dim valor1 = Replace(txtValor.Text, ",", ".")

            Try
                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@numDocto", txtNDoc.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@valor", valor1)
                cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.ToShortDateString)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Limpar()

                btSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados desta conta" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If FValidaCampos() = False Then Exit Sub

        If txtCodigo.Text = "Novo" Then
            Gravar()
        Else
            Alterar()
        End If

        intPergunta = MsgBox("Gostaria de inserir outro lançamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Contas a Pagar")
        If intPergunta <> vbYes Then
            ' Exit Sub
            Me.Dispose()
        Else
            Limpar()
        End If

    End Sub

    Private Sub Alterar()
        Dim cmd As SqlCommand

        If txtNDoc.Text <> "" Then

            Dim valor1 = Replace(txtValor.Text, ",", ".")

            Try
                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_conta", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@valor", valor1)
                cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados desta conta" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PLendoDados(ByVal intCodigo As Integer)
        Dim dr As SqlDataReader = Nothing
        '  Dim drDados As SqlDataReader
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_ContasPagar_listarCodigo {0}" & intCodigo, con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            '  da.SelectCommand.Parameters.AddWithValue("@id_conta", txtCodigo.Text)

            da.Fill(dt)
            ' dgPJ.DataSource = dt


            If dr.HasRows Then
                dr.Read()
                ' txtCodigo.Text = dr.Item("id_conta")
                txtData.Text = dr.Item("data_cadastro")
                txtNDoc.Text = dr.Item("numDocto")
                txtDescricao.Text = dr.Item("descricao")
                txtValor.Text = dr.Item("valor")
                txtEmpresa.Text = dr.Item("empresa")
                txtVencimento.Text = dr.Item("vencimento")
                txtSituacao.Text = dr.Item("situacao")
            Else

                MsgBox("Não foi posssível carregar os Dados.!", MsgBoxStyle.Critical, "Contas a Pagar")

            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)

        Finally
            dr.Close()
            fechar()
        End Try



    End Sub

    Private Sub PLeDados()
        Dim dr As SqlDataReader = Nothing

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            Dim sql As String = "SELECT * FROM tbContasPagar  WHERE id_conta=" & CInt(txtCodigo.Text)
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader(Data.CommandBehavior.SingleRow)

            If dr.HasRows Then
                dr.Read()
                ' txtCodigo.Text = dr.Item("id_conta")
                txtData.Text = dr.Item("data_cadastro")
                txtNDoc.Text = dr.Item("numDocto")
                txtDescricao.Text = dr.Item("descricao")
                txtValor.Text = dr.Item("valor")
                txtEmpresa.Text = dr.Item("empresa")
                txtVencimento.Text = dr.Item("vencimento")
                txtSituacao.Text = dr.Item("situacao")
            Else

                MsgBox("Não foi posssível carregar os Dados.!", MsgBoxStyle.Critical, "Contas a Pagar")

            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)

        Finally
            dr.Close()
            fechar()
        End Try

    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
End Class