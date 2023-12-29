Imports System.Data.SqlClient

Public Class frmLoginAdm

    Dim form As Form

    Sub New(formP As Form)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        form = formP

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim senha As String = txtSenha.Text
        Dim usuario As String = "admin"

        If senha = "" Then
            MsgBox("Preencha a Senha!!")
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

                Dim msg As String = cmd.Parameters("@msg").Value

                If (msg = "Dados Incorretos") Then
                    txtSenha.Clear()

                Else
                    ' Dim f = New frmSangria
                    Me.Hide()
                    form.ShowDialog()
                End If

            Catch ex As Exception
                MessageBox.Show("Erro ao Acessar! " + ex.Message.ToString)
                fechar()
            End Try

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class