Imports System.Data.SqlClient

Public Class frmNivelBaixo
    Private Sub frmNivelBaixo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            '  da = New SqlDataAdapter("SELECT * FROM tbProdutos", con)
            da = New SqlDataAdapter("pa_verificar_nivel", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure


            'da.SelectCommand.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            'Dim msg As String = da.SelectCommand.Parameters("@mensagem").Value.ToString
            'MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()
            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub FormatarDG()
        With dg
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(11).Visible = False
            .Columns(14).Visible = False

            .Columns(0).HeaderText = "id_Produto"
            .Columns(1).HeaderText = "id_Fornecedor"
            .Columns(2).HeaderText = "id_Categoria"
            .Columns(3).HeaderText = "id_Unidade"
            .Columns(4).HeaderText = "Produto"
            .Columns(5).HeaderText = "Descrição"
            .Columns(6).HeaderText = "Quantidade"
            .Columns(7).HeaderText = "Vlr de Compra"
            .Columns(8).HeaderText = "Vlr de Venda"
            .Columns(9).HeaderText = "Vlr de Venda"
            .Columns(10).HeaderText = "Dt Cadastro"
            .Columns(11).HeaderText = "imagem"
            .Columns(12).HeaderText = "Nível Mínimo"
            .Columns(13).HeaderText = "quant_vendida"
            .Columns(14).HeaderText = "codigo_barras"

            .Columns(4).Width = 380
            .Columns(5).Width = 300
            '.Columns(3).Width = 260
            '.Columns(4).Width = 120
            '.Columns(5).Width = 80
            '.Columns(6).Width = 45
            '.Columns(7).Width = 100
            '.Columns(8).Width = 100
            '.Columns(9).Width = 80
        End With

    End Sub

    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        Dim id_produto As Integer
        id_produto = dg.CurrentRow.Cells(0).Value
        Dim form = New frmEstoque(id_produto)
        form.ShowDialog()
    End Sub

    Private Sub frmNivelBaixo_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
End Class