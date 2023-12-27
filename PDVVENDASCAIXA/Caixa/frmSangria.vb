Imports System.Data.SqlClient

Public Class frmSangria
    Private Sub frmSangria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSangria.Focus()

        Dim cmd As New SqlCommand("pa_caixa_buscarDadosCaixa", con)

        Try
            abrir()

            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@data_ab", Now.ToShortDateString())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.Add("@hora_ab", SqlDbType.Time).Direction = 2
            cmd.Parameters.Add("@hora_sangria", SqlDbType.Time).Direction = 2
            cmd.Parameters.Add("@valor_ab", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@valor_sangria", SqlDbType.Decimal).Direction = 2
            '  cmd.Parameters.Add("@total_caixa", SqlDbType.Decimal).Direction = 2

            cmd.ExecuteNonQuery()

            Dim valor_sangria As Decimal = cmd.Parameters("@valor_sangria").Value
            lblTotSangria.Text = CStr(valor_sangria)

            Listar()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            '  da = New SqlDataAdapter("SELECT * FROM tbProdutos", con)
            da = New SqlDataAdapter("pa_Sangria_listar", con)
            da.Fill(dt)
            dg.DataSource = dt


            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(1).Visible = False

        dg.Columns(1).HeaderText = "Funcionario"
        dg.Columns(2).HeaderText = "Dt. Sangria"
        dg.Columns(3).HeaderText = "Valor Sangria"
        dg.Columns(4).HeaderText = "Hora Sangria"
        dg.Columns(5).HeaderText = "Histórico"
        dg.Columns(6).HeaderText = "tipo"


        dg.Columns(5).Width = 180


    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtSangria.Text <> "" Then

            Try
                abrir()

                Dim total_sangria As Decimal
                Dim sangria As Decimal
                Dim sangriaBD As Decimal
                sangria = txtSangria.Text
                sangriaBD = lblTotSangria.Text
                total_sangria = sangria + sangriaBD

                cmd = New SqlCommand("pa_sangria_salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_sangria", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@valor_sangria", txtSangria.Text)
                cmd.Parameters.AddWithValue("@hora_sangria", Now.ToLongTimeString())
                cmd.Parameters.AddWithValue("@historico", txtHistorico.Text)
                cmd.Parameters.AddWithValue("@tipoRetirada", cbTipo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Erro, corriga os dados de alteração" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
End Class