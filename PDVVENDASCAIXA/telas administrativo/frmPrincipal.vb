Imports System.Data.SqlClient

Public Class frmPrincipal
    Private imagemCarregada As Image
    Dim data As Date

    Dim abertura As Boolean

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Dim form = New frmFuncionarios
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
        Dim form = New frmEmpresa
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

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' verifivarAbertura()
        Me.Text = "GESTÃO ADMINISTRATIVA   -   PDV   -    EMPRESA:  " & empresaNome
        lblUsuario.Text = usuarioNome

        If (usuarioNome = "admin") Then

            FuncionáriosToolStripMenuItem.Enabled = True
            SangriaToolStripMenuItem.Enabled = True
            EmpresaToolStripMenuItem.Enabled = True
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

        If abertura = True Then
            CarregarDados()
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

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
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
        Dim form = New frmSangria
        form.ShowDialog()
    End Sub

    Sub carregarImagem()

        If abertura = True Then
            imagem.Image = My.Resources.verde
        Else
            imagem.Image = My.Resources.vermelho
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
        Dim img As String
        If abertura = True Then
            Dim form = New frmFecharCaixa
            form.ShowDialog()
            '  img = "https://static.vecteezy.com/system/resources/previews/017/177/933/non_2x/round-check-mark-symbol-with-transparent-background-free-png.png"
        Else
            Dim form = New frmAbrirCaixa
            form.ShowDialog()
            ' img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWtkh6KUxTBgwtqvJHp-5t8XUHG3hr9MQL0dd1AsmKuVS5fcdRxKbPb5cccxwKzSNCm9U&usqp=CAU"
        End If
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


End Class