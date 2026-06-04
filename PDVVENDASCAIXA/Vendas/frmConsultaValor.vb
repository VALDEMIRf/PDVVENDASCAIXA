Imports System.Data.SqlClient
Imports System.IO

Public Class frmConsultaValor
    Private Sub frmConsultaValor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarProdutos()
    End Sub

    Sub CarregarProdutos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbProdutos", con) '
            DA = New SqlDataAdapter("pa_produto_Lista", con)
            DA.Fill(DT)
            cbProduto.DisplayMember = "nome"
            cbProduto.ValueMember = "id_produto"
            cbProduto.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        carregaDados()
    End Sub

    Private Sub carregaDados()
        Dim da As SqlDataAdapter

        Dim total As Decimal
        Dim valor As Decimal
        Dim quantidade As Decimal

        'valor = txtValorUnitario.Text
        'quantidade = txtQuantidade.Text

        'total = valor * quantidade

        Dim cmd As New SqlCommand("pa_Vendas_ConsultaValorProd", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Direction = 2
            cmd.Parameters.Add("@valor_venda", SqlDbType.Float).Direction = 2
            cmd.Parameters.Add("@codigo_barras", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim valor1 As Double = cmd.Parameters("@valor_venda").Value
            txtValorUnitario.Text = CDbl(valor1)

            Dim Nomeproduto As String = cmd.Parameters("@nome").Value
            txtProduto.Text = Nomeproduto

            '=============================================================================================================================================================
            '=============================================================================================================================================================

            da = New SqlDataAdapter("pa_produto_BuscaFoto", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)

            Dim tempImagem As Byte() = DirectCast(da.SelectCommand.ExecuteScalar, Byte())

            If tempImagem Is Nothing Then
                MessageBox.Show("Imagem não localizada", "Erro")
                Exit Sub
            End If
            Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
            Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
            fs.Write(tempImagem, 0, tempImagem.Length)
            fs.Flush()
            fs.Close()

            pbImagem.Image = Image.FromFile(strArquivo)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub txtValorUnitario_TextChanged(sender As Object, e As EventArgs) Handles txtValorUnitario.TextChanged
        txtValorUnitario.Text = FormatCurrency(txtValorUnitario.Text)
    End Sub
End Class