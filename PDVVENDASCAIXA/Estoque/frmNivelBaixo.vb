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
        dg.Columns(0).Visible = False
        dg.Columns(3).Visible = False
        dg.Columns(4).Visible = False
        dg.Columns(5).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(8).Visible = False
        dg.Columns(10).Visible = False


        dg.Columns(1).HeaderText = "Produto"
        dg.Columns(2).HeaderText = "Descrição"
        ' dg.Columns(3).HeaderText = "Fornecedor"
        'dg.Columns(4).HeaderText = "Categoria"
        ' dg.Columns(5).HeaderText = "Unidade"
        dg.Columns(6).HeaderText = "Quantidade" '
        ' dg.Columns(7).HeaderText = "Vlr de Compra"
        ' dg.Columns(8).HeaderText = "Vlr de Venda"
        dg.Columns(9).HeaderText = "Dt Cadastro"
        dg.Columns(11).HeaderText = "Nível Mínimo"


        dg.Columns(1).Width = 180
        dg.Columns(2).Width = 200
        'dg.Columns(3).Width = 260
        'dg.Columns(4).Width = 120
        'dg.Columns(5).Width = 80
        'dg.Columns(6).Width = 45
        'dg.Columns(7).Width = 100
        'dg.Columns(8).Width = 100
        'dg.Columns(9).Width = 80
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

    Private Sub lblSair_Click(sender As Object, e As EventArgs) Handles lblSair.Click
        Me.Close()
    End Sub
End Class