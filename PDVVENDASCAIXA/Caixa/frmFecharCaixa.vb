Imports System.Data.SqlClient

Public Class frmFecharCaixa
    Private valor_abertura As Decimal
    Private quant_vendas As Integer
    Private prod_vendidos As Integer
    Private total_vendido As Decimal
    Private valor_sangria As Decimal

    Private total_caixa As Decimal

    Public Sub New(valor_abertura As Decimal, quant_vendas As Integer, prod_vendidos As Integer, total_vendido As Decimal, valor_sangria As Decimal)
        InitializeComponent()

        Me.valor_abertura = valor_abertura
        Me.quant_vendas = quant_vendas
        Me.prod_vendidos = prod_vendidos
        Me.total_vendido = total_vendido
        Me.valor_sangria = valor_sangria

    End Sub

    Private Sub frmFecharCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAbertura.Text = valor_abertura
        Listar()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtTotalCaixa.Text = "" Then
            MsgBox("Digite um valor")

        Else
            total_caixa = txtTotalCaixa.Text
            Dim subtotal As Decimal
            subtotal = total_caixa - valor_abertura + valor_sangria

            Dim quebra As Decimal
            quebra = total_caixa - total_vendido - valor_abertura + valor_sangria

            Dim ab = Replace(txtAbertura.Text, ",", ".")
            Dim tc = Replace(txtTotalCaixa.Text, ",", ".")

            Dim cmd As SqlCommand
            Try

                abrir()
                cmd = New SqlCommand("pa_caixa_fechar_caixa", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@data_ab", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@hora_ab", Now.ToLongTimeString())
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@valor_ab", ab)
                'cmd.Parameters.AddWithValue("@valor_sangria", 0)
                'cmd.Parameters.AddWithValue("@hora_sangria", Now.ToLongTimeString())
                cmd.Parameters.AddWithValue("@quant_vendas", quant_vendas)
                cmd.Parameters.AddWithValue("@prod_vendidos", prod_vendidos)
                cmd.Parameters.AddWithValue("@total_vendido", total_vendido)
                cmd.Parameters.AddWithValue("@total_caixa", tc)
                cmd.Parameters.AddWithValue("@saldo_total", subtotal)
                cmd.Parameters.AddWithValue("@valor_quebra", quebra)
                cmd.Parameters.AddWithValue("@hora_fecha", Now.ToShortTimeString())

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()

            cmd = New SqlCommand("SELECT * FROM tbCaixa WHERE funcionario=@func AND data_ab=@data", con)

            cmd.Parameters.AddWithValue("@func", usuarioNome)
            cmd.Parameters.AddWithValue("@data", Now.ToShortDateString)





            'da = New SqlDataAdapter("pa_Vendas_ListaGeral", con)
            'da.SelectCommand.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.AddWithValue("@func", usuarioNome)
            'cmd.Parameters.AddWithValue("@data", Now.ToShortDateString)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os dados do caixa" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(1).Visible = False
        dg.Columns(3).Visible = False
        dg.Columns(6).Visible = False
        dg.Columns(8).Visible = False
        dg.Columns(10).Visible = False
        dg.Columns(11).Visible = False
        dg.Columns(12).Visible = False
        dg.Columns(13).Visible = False


        dg.Columns(2).HeaderText = "Hora Abertura"
        dg.Columns(4).HeaderText = "Valor da Abertura"
        dg.Columns(5).HeaderText = "Total Sangria"
        dg.Columns(7).HeaderText = "Quantidade Vendas"
        dg.Columns(9).HeaderText = "Total Vendido"

        'dg.Columns(2).Width = 210
        'dg.Columns(1).Width = 150
        'dg.Columns(3).Width = 50
        'dg.Columns(4).Width = 90
        'dg.Columns(5).Width = 80
        'dg.Columns(6).Width = 80

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub


End Class