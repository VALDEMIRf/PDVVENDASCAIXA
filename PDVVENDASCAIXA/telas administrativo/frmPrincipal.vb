Imports System.Data.SqlClient

Public Class frmPrincipal
    Private imagemCarregada As Image
    Dim data As Date

    Dim abertura As Boolean

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' verifivarAbertura()
        Me.Text = "GESTÃO ADMINISTRATIVA   -   PDV   -    EMPRESA:  " & empresaNome
        lblUsuario.Text = usuarioNome

        ' carregarSangria()
        'carregarReforco()

        If (usuarioNome = "admin") Then

            'FuncionáriosToolStripMenuItem.Enabled = True

            '  EmpresaToolStripMenuItem.Enabled = True
        End If
        Listar()
        totalizar()

    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub frmPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        verifivarAbertura()
        Listar()
        totalizar()

        lblVlrAb.Text = 0

        If abertura = True Then
            CarregarDados()
            'CarregarDadosGeral()
        End If

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()

            'METODO 1 - CONSULTA DIRETA NO FORMULÁRIO
            ' cmd = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome,cli.nome,pro.valor_venda,ven.quantidade,ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM tbVendas as ven INNER JOIN tbProdutos as pro on ven.id_produto=pro.id_produto INNER JOIN tbClientes  as cli on ven.id_cliente = cli.id_cliente where ven.data_venda=@data order by num_vendas desc", con)
            ' cmd.Parameters.AddWithValue("@data", Now.Date())
            'cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            ' da = New SqlDataAdapter(cmd)

            '============================================================================================================================================================


            'METODO 2 - CONSULTA COM PROC NO BANCO DE DADOS
            da = New SqlDataAdapter("pa_Vendas_ListaDiaria", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@data", Now.Date())
            da.SelectCommand.Parameters.AddWithValue("@funcionario", usuarioNome)


            '============================================================================================================================================================


            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

            lblVendasDia.Text = dg.Rows.Count()
            'totalizar()
            SomarQuantidadeProdutos()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub


    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Dim formP As Form
        formP = frmFuncionarios

        Dim form = New frmLoginAdm(formP)
        form.ShowDialog()

    End Sub

    Private Sub CargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem.Click
        Dim form = New frmCargos
        form.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Dim form = New frmFornecedores
        form.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim form = New frmCategoriaProdutos
        form.ShowDialog()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        Dim formP As Form
        formP = frmEmpresa

        Dim form = New frmLoginAdm(formP)
        form.ShowDialog()
    End Sub

    Private Sub UnidadeDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadeDeMedidaToolStripMenuItem.Click
        Dim form = New frmUnidadeMedidas
        form.ShowDialog()
    End Sub

    Private Sub TiposDeServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeServiçosToolStripMenuItem.Click
        Dim form = New frmTipoServico
        form.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub
    Private Sub LogoffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoffToolStripMenuItem.Click
        Dim form = New frmLogin
        Me.Hide()
        form.ShowDialog()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New frmClientes
        form.ShowDialog()
    End Sub

    Private Sub OrdemDeServiçoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdemDeServiçoToolStripMenuItem.Click
        Dim form = New frmServicos
        form.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem1.Click
        Dim form = New frmProdutos
        form.ShowDialog()
    End Sub


    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(1).Visible = False
        dg.Columns(4).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(8).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(10).Visible = False

        dg.Columns(1).HeaderText = "Núm. Venda"
        dg.Columns(2).HeaderText = "Produto"
        dg.Columns(3).HeaderText = "Cliente"
        dg.Columns(4).HeaderText = "Valor Unit."
        dg.Columns(5).HeaderText = "Quantidade"
        dg.Columns(6).HeaderText = "Valor Total"
        dg.Columns(7).HeaderText = "Funcionário"
        dg.Columns(8).HeaderText = "Dt. Venda"

        dg.Columns(1).Width = 70
        dg.Columns(2).Width = 130
        dg.Columns(3).Width = 130
        dg.Columns(4).Width = 90
        dg.Columns(5).Width = 70
        dg.Columns(6).Width = 70
        dg.Columns(7).Width = 150

    End Sub

    Sub SomarQuantidadeProdutos()
        Dim quant As Decimal
        For Each linha As DataGridViewRow In dg.Rows
            quant = quant + linha.Cells(5).Value
        Next
        lblProdutosVendidos.Text = quant
    End Sub


    Private Sub totalizar()
        Dim total As Decimal
        For Each lin As DataGridViewRow In dg.Rows
            total = total + lin.Cells(6).Value
        Next

        lblTotalDoDia.Text = total
        txtTotaliza.Text = total

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = Now.ToLongTimeString()
        lblData.Text = Now.ToShortDateString()
    End Sub

    Private Sub PDVRegistrarVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDVRegistrarVendaToolStripMenuItem.Click
        data = Now.ToShortDateString()

        Dim cmd As New SqlCommand("pa_caixa_verificar_abertura", con)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters
                .AddWithValue("@data", data)
                .AddWithValue("@funcionario", usuarioNome)
                .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With

            Dim msg As String = cmd.Parameters("@msg").Value


            If (msg = "Abra primeiro o Caixa" Or lblTextoCaixa.Text = "CAIXA FECHADO") Then
                MessageBox.Show("O Caixa não está aberto! ")

            Else
                Dim form = New frmVendas
                form.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Acessar! " + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub ListarVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarVendasToolStripMenuItem.Click
        Dim form = New frmListaVendas
        form.ShowDialog()
    End Sub

    Private Sub CatálogoDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogoDeProdutosToolStripMenuItem.Click
        Dim form = New frmRelProdutos
        form.ShowDialog()
    End Sub

    Private Sub FiltroDeVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltroDeVendasToolStripMenuItem.Click
        Dim form = New frmRelVenda
        form.ShowDialog()
    End Sub

    Private Sub ServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiçosToolStripMenuItem.Click
        Dim form = New frmRelServicos
        form.ShowDialog()
    End Sub

    Private Sub SangriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SangriaToolStripMenuItem.Click
        Dim formP As Form
        formP = frmSangria

        Dim form = New frmLoginAdm(formP)
        form.ShowDialog()
    End Sub

    Private Sub ReforçosAsCaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReforçosAsCaixaToolStripMenuItem.Click
        Dim formP As Form
        formP = frmReforcoCaixa

        Dim form = New frmLoginAdm(formP)
        form.ShowDialog()
    End Sub

    Sub carregarImagem()

        If abertura = True Then
            imagem.Image = My.Resources.btVerde
            lblTextoCaixa.Text = "CAIXA ABERTO"
            lblAbrirFechar.Text = "FECHAR CAIXA"

        Else
            imagem.Image = My.Resources.btVermelho
            lblTextoCaixa.Text = "CAIXA FECHADO"
            lblAbrirFechar.Text = "ABRIR CAIXA"
        End If

    End Sub

    Sub verifivarAbertura()
        data = Now.ToShortDateString()

        Dim cmd As New SqlCommand("pa_caixa_verificar_abertura", con)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters
                .AddWithValue("@data", data)
                .AddWithValue("@funcionario", usuarioNome)
                .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With

            Dim msg As String = cmd.Parameters("@msg").Value


            '  If (msg = "Abra primeiro o Caixa" Or lblTextoCaixa.Text = "CAIXA FECHADO") Then
            If (msg = "Abra primeiro o Caixa") Then
                    abertura = False
                    carregarImagem()
                Else
                    abertura = True
                carregarImagem()
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Acessar! " + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub imagem_Click(sender As Object, e As EventArgs) Handles imagem.Click

        If abertura = True Then
            Dim valor_abertura As Decimal
            valor_abertura = lblVlrAb.Text

            Dim quant_vendas As Integer
            quant_vendas = lblVendasDia.Text

            Dim prod_vendidos As Integer
            prod_vendidos = lblProdutosVendidos.Text

            Dim total_vendido As Decimal
            total_vendido = lblTotalDoDia.Text

            Dim valor_sangria As Decimal
            valor_sangria = lblTotSangria.Text

            Dim formP = New frmFecharCaixa(valor_abertura, quant_vendas, prod_vendidos, total_vendido, valor_sangria)

            Dim form = New frmLoginAdm(formP)
            form.ShowDialog()

        Else
            Dim valorAb As Decimal
            valorAb = lblVlrAb.Text
            If valorAb > 0 Then
                MsgBox("O caixa não pode ser aberto novamente Hoje!")
            Else
                Dim formP As Form
                formP = frmAbrirCaixa
                Dim form = New frmLoginAdm(formP)
                form.ShowDialog()
            End If

        End If
    End Sub

    'caixa_buscarDadosGeral
    Private Sub CarregarDadosGeral()
        Dim cmd As New SqlCommand("caixa_buscarDadosGeral", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@data_ab", Now.ToShortDateString())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.Add("@hora_ab", SqlDbType.Time).Direction = 2
            cmd.Parameters.Add("@hora_sangria", SqlDbType.Time).Direction = 2
            cmd.Parameters.Add("@valor_ab", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@valor_sangria", SqlDbType.Decimal).Direction = 2
            ' cmd.Parameters.Add("@total_caixa", SqlDbType.Decimal).Direction = 2

            cmd.ExecuteNonQuery()

            Dim hora_ab As TimeSpan = cmd.Parameters("@hora_ab").Value
            lblHoraAb.Text = hora_ab.ToString()

            Dim hora_sangria As TimeSpan = cmd.Parameters("@hora_sangria").Value
            lblHoraSangria.Text = hora_sangria.ToString()

            Dim valor_ab As Decimal = cmd.Parameters("@valor_ab").Value
            lblVlrAb.Text = CStr(valor_ab)

            Dim valor_sangria As Decimal = cmd.Parameters("@valor_sangria").Value
            lblTotSangria.Text = CStr(valor_sangria)

            'Dim total_caixa As Decimal = cmd.Parameters("@total_caixa").Value
            'lblTotalCaixa.Text = CStr(total_caixa)

            'If total_caixa > 0 Then
            '    abertura = False
            '    carregarImagem()
            'End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub CarregarDados()
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
            cmd.Parameters.Add("@total_caixa", SqlDbType.Float).Direction = 2

            cmd.ExecuteNonQuery()

            Dim hora_ab As TimeSpan = cmd.Parameters("@hora_ab").Value
            lblHoraAb.Text = hora_ab.ToString()

            Dim hora_sangria As TimeSpan = cmd.Parameters("@hora_sangria").Value
            lblHoraSangria.Text = hora_sangria.ToString()

            Dim valor_ab As Decimal = cmd.Parameters("@valor_ab").Value
            lblVlrAb.Text = CStr(valor_ab)

            Dim valor_sangria As Decimal = cmd.Parameters("@valor_sangria").Value
            lblTotSangria.Text = CStr(valor_sangria)

            Dim total_caixa As Decimal = cmd.Parameters("@total_caixa").Value
            lblTotalCaixa.Text = CDbl(total_caixa)

            If total_caixa > 0 Then
                abertura = False
                carregarImagem()
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try


    End Sub



    'Private Sub carregarSangria()
    '    Dim cmd As SqlCommand
    '    Dim cmd2 As New SqlCommand("pa_Sangria_listar_VALOR", con)

    '    Try
    '        abrir()

    '        cmd = New SqlCommand("pa_sangria_salvar", con)
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
    '        cmd.Parameters.AddWithValue("@data_sangria", Now.ToShortDateString())
    '        cmd.Parameters.AddWithValue("@valor_sangria", 0)
    '        cmd.Parameters.AddWithValue("@hora_sangria", Now.ToLongTimeString())
    '        cmd.Parameters.AddWithValue("@historico", "INICIO DO DIA")
    '        cmd.Parameters.AddWithValue("@tipoRetirada", "")
    '        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
    '        cmd.ExecuteNonQuery()

    '        Dim msg As String = cmd.Parameters("@mensagem").Value.ToString

    '        '================================================================================================================================
    '        '================================================================================================================================

    '        cmd2.CommandType = 4
    '        cmd2.Parameters.AddWithValue("@data_sangria", Now.ToShortDateString())
    '        cmd2.Parameters.AddWithValue("@funcionario", usuarioNome)
    '        cmd2.Parameters.Add("@valor_sangria", SqlDbType.Decimal).Direction = 2

    '        cmd2.ExecuteNonQuery()

    '        Dim valor_sangria As Decimal = cmd2.Parameters("@valor_sangria").Value
    '        lblSangriaBD.Text = CStr(valor_sangria)


    '    Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
    '    Finally
    '        fechar()
    '    End Try

    'End Sub

    Private Sub carregarReforco()
        Dim cmd As New SqlCommand("pa_Reforco_listar_VALOR", con)

        Try
            abrir()

            Dim vlReforco = Replace(lblReforco.Text, ",", ".")

            abrir()
            cmd = New SqlCommand("pa_Reforco_salvar", con)
            cmd.CommandType = CommandType.StoredProcedure
            ' cmd.Parameters.AddWithValue("@dataF", Now.ToShortDateString())
            cmd.Parameters.AddWithValue("@horaF", Now.ToLongTimeString())
            ' cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.AddWithValue("@valor", vlReforco)
            cmd.Parameters.AddWithValue("@motivo", "")
            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString





            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@dataF", Now.ToShortDateString())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.Add("@valor", SqlDbType.Decimal).Direction = 2


            cmd.ExecuteNonQuery()

            Dim valor_reforco As Decimal = cmd.Parameters("@valor").Value
            lblReforco.Text = CStr(valor_reforco)


        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub verificarFechamento()
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
            'da = New SqlDataAdapter(cmd)
            'da.Fill(dt)
            'dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os dados do caixa" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub RelatórioDoCaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioDoCaixaToolStripMenuItem.Click
        Dim form = New frmRelCaixa
        form.ShowDialog()
    End Sub

    Private Sub EntradaSaídaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaSaídaToolStripMenuItem.Click
        Dim form = New frmTesteValor
        form.ShowDialog()
    End Sub
End Class