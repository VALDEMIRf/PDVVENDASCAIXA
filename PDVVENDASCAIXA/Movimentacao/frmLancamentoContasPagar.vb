Imports System.Data.SqlClient

Public Class frmLancamentoContasPagar
    Private Sub frmLancamentoContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If intCodigoLancamento <> 0 Then
            txtCodigo.Text = intCodigoLancamento

            PLeDados()
        Else
            txtCodigo.Text = "Novo"
        End If
    End Sub

    Private Sub PLeDados()
        Dim dr As SqlDataReader = Nothing
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            '  da = New SqlDataAdapter("pa_ContasPagar_listar", con)
            Dim sql As String = "SELECT * FROM tbContasPagarTeste  WHERE codigo=" & CInt(txtCodigo.Text)
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader(Data.CommandBehavior.SingleRow)


            If dr.HasRows Then
                dr.Read()
                txtData.Text = dr.Item("data")
                txtNDoc.Text = dr.Item("numero")
                txtDescricao.Text = dr.Item("descricao")
                txtValor.Text = dr.Item("valor")
                txtEmpresa.Text = dr.Item("empresa")
                txtSituacao.Text = dr.Item("situacao")
            Else

                MsgBox("Não foi posssível carregar os Dados.!", MsgBoxStyle.Critical, "Contas a Pagar")


            End If



        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub


    Private Sub PLimpaCampos()
        txtCodigo.Text = "Novo"
        txtData.Text = Date.Today
        txtNDoc.Text = ""
        txtDescricao.Text = ""
        txtValor.Text = ""
        txtEmpresa.Text = ""
        txtSituacao.SelectedIndex = 0
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



    Private Sub PGravaDados()

        Try
            abrir()
            Dim sql As String = "INSERT INTO tbContasPagarTeste(data,numero,descricao,valor,empresa,situacao) VALUES(?,?,?,?,?,?)"
                Dim cmd As SqlCommand = New SqlCommand(sql, con)

                cmd.Parameters.Add(New SqlParameter("@data", txtData.Text))
                cmd.Parameters.Add(New SqlParameter("@numero", txtNDoc.Text))
                cmd.Parameters.Add(New SqlParameter("@descricao", txtDescricao.Text))
                cmd.Parameters.Add(New SqlParameter("@valor", txtValor.Text))
                cmd.Parameters.Add(New SqlParameter("@empresa", txtEmpresa.Text))
                cmd.Parameters.Add(New SqlParameter("@situacao", txtSituacao.Text))

            cmd.ExecuteNonQuery()
            MsgBox("Lançamento realizado com sucesso.!", MsgBoxStyle.Information, "Contas a Pagar")

            Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PAlteraDados()

        Try
            abrir()
            Dim sql As String = "UPDATE tbContasPagarTeste SET data=?,numero=?,descricao=?,valor=?,empresa=?,situacao=? WHERE codigo=" & CInt(txtCodigo.Text)
                Dim cmd As SqlCommand = New SqlCommand(sql, con)

                cmd.Parameters.Add(New SqlParameter("@data", txtData.Text))
            cmd.Parameters.Add(New SqlParameter("@numero", txtNDoc.Text))
            cmd.Parameters.Add(New SqlParameter("@descricao", txtDescricao.Text))
                cmd.Parameters.Add(New SqlParameter("@valor", txtValor.Text))
                cmd.Parameters.Add(New SqlParameter("@empresa", txtEmpresa.Text))
            cmd.Parameters.Add(New SqlParameter("@situacao", txtSituacao.Text))


            cmd.ExecuteNonQuery()
                MsgBox("Lançamento alterado com sucesso.!", MsgBoxStyle.Information, "Contas a Pagar")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
            fechar()
        End Try

    End Sub


    Private Sub txtValor_LostFocus(sender As Object, e As System.EventArgs) Handles txtValor.LostFocus
        txtValor.Text = FormatCurrency(txtValor.Text)
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If FValidaCampos() = False Then Exit Sub

        If txtCodigo.Text = "Novo" Then
            PGravaDados()
        Else
            PAlteraDados()
        End If


        intPergunta = MsgBox("Gostaria de inserir outro lançamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Contas a Pagar")
        If intPergunta <> vbYes Then
            ' Exit Sub
            Me.Dispose()
        Else
            PLimpaCampos()
        End If

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
    End Sub
End Class