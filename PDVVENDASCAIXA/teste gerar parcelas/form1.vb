Public Class form1


    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoTeste
    Dim produto As New Produto
    Dim parc As New Parcelas

    Public Sub Carrega_Valor()
        Try
            ds = produto.ConsularValor()
            dgvValor.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Erro ao consultar", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Carrega_Valor()


    End Sub

    Private Sub btnGravar_Click(sender As System.Object, e As System.EventArgs) Handles btnGravar.Click
        Try
            produto.produto = txtProduto.Text
            produto.valor = txtValor.Text.Replace(",", ".")
            produto.CadastrarValor()
            MsgBox("Produto gravado com sucesso!", MsgBoxStyle.Information, "Sucesso")

            Carrega_Valor()


        Catch ex As Exception
            MsgBox("Não foi possível Gravar as informações no banco de dados", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub txtValor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtValor.TextChanged

        Utils.TextBoxMoeda(txtValor)



    End Sub

    Private Sub txtParcela_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtParcela.TextChanged
        Utils.TextBoxMoeda(txtParcela)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim venc As DateTime = mskData.Text

        Dim ValorTotal, valorParcela As Double

        'Calcular valor de cada Parcela

        ValorTotal = txtParcela.Text

        valorParcela = FormatCurrency(ValorTotal / txtNumeroPacelas.Text)




        Try
            For i = 0 To Val(txtNumeroPacelas.Text) - 1


                Dim novaParcela As DateTime

                novaParcela = venc.AddDays(i * 30)


                If novaParcela.DayOfWeek = DayOfWeek.Sunday Then
                    novaParcela = novaParcela.AddDays(1)
                ElseIf novaParcela.DayOfWeek = DayOfWeek.Saturday Then
                    novaParcela = novaParcela.AddDays(2)
                End If



                dgvParcelas.Rows.Add(i + 1, Mid(novaParcela.ToString, 1, 10), FormatCurrency(valorParcela))
            Next




        Catch ex As Exception
            MsgBox("Erro ao calcular pagamento", MsgBoxStyle.Critical, "Atenção")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ano, mes, dia As Integer
        Dim dr As Date
        Dim d As String
        'Dim Parcela As String


        Try

            Dim numlinhas As Integer = dgvParcelas.RowCount - 1
            Dim cont As Integer = 0

            'Insere no banco de dados as parcelas geradas no DataGrid
            While (cont <= numlinhas)
                dr = Me.dgvParcelas.Item(1, cont).Value
                dia = dr.Day
                mes = dr.Month
                ano = dr.Year
                d = ano & "-" & mes & "-" & dia





                parc.parcela = (Me.dgvParcelas.Item(0, cont).Value)
                parc.data_parcela = d
                parc.valor_parcela = (Me.dgvParcelas.Item(2, cont).Value).Replace("R$", "").Replace(".", "").Replace(",", ".")
                parc.CadastrarParcela()



                cont = cont + 1

            End While
            MsgBox("Parcelas gravadas com sucesso!", MsgBoxStyle.Information, "Sucesso")

        Catch ex As Exception
            MsgBox("Erro ao gravar as Parcelas no banco!", MsgBoxStyle.Information, "Sucesso")
        End Try


    End Sub

    Private Sub dgvParcelas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvParcelas.CellContentClick

    End Sub
End Class