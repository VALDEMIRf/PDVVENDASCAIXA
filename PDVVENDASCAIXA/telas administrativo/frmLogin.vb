Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = txtUsuario.Text
        Dim senha As String = txtSenha.Text

        If usuario = "" Or senha = "" Then
            MsgBox("Preencha os Campos!!")
        Else

            Dim cmd As New SqlCommand("pa_Login", con)

            Try
                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@nome", usuario)
                    .AddWithValue("@cpf", senha)
                    .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With

                usuarioNome = txtUsuario.Text
                CarregarEmpresa()

                Dim msg As String = cmd.Parameters("@msg").Value
                MsgBox(msg, vbInformation)

                If (msg = "Dados Incorretos") Then
                    txtSenha.Clear()
                    txtUsuario.Clear()
                    txtUsuario.Focus()
                Else
                    Dim f = New frmPrincipal
                    Me.Hide()
                    f.ShowDialog()
                End If

            Catch ex As Exception
                MessageBox.Show("Erro ao Acessar! " + ex.Message.ToString)
                fechar()
            End Try

        End If
    End Sub

    Public Sub CarregarEmpresa()

        '    Dim cmd As New SqlCommand("pa_empresa_listar", con)
        '    Try
        '        abrir()
        '        cmd.CommandType = 4
        '        'cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
        '        'cmd.Parameters.Add("@valor_venda", SqlDbType.Decimal).Direction = 2
        '        'cmd.Parameters.Add("@quant", SqlDbType.Int).Direction = 2
        '        'cmd.Parameters.Add("@quant_vendida", SqlDbType.Int).Direction = 2
        '        '  cmd.Parameters.Add("@razaoSocial", SqlDbType.VarChar, 100).Direction = 2
        '        idempresa = cmd.Parameters.Add("@razaoSocial", SqlDbType.VarChar, 100).Direction = 2
        '        cmd.ExecuteNonQuery()


        '        ' lblEmpresa.Text = empresa

        '    Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        '    Finally
        '        fechar()
        '    End Try
        'End Sub



        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim bolResult As Boolean
        Try
            abrir()


            cmd = New SqlCommand("pa_empresa_ListaNome", con)
            cmd.CommandType = CommandType.StoredProcedure

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                idempresa = dr.Item("razaoSocial")
                bolResult = True
            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao Listar o nome da Empresa" + ex.Message.ToString)
        Finally

            fechar()
        End Try
    End Sub
End Class