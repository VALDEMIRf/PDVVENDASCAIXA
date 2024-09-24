Imports System.Data.SqlClient
Imports System.Text

Public Class frmContasReceber
    Private Sub frmContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Listar()

        CarregarClientes()

        rbCliente.Checked = True


    End Sub



    Private Sub FormatarDG()

        With dgContasReceber
            .Columns(22).Visible = False
            .Columns(21).Visible = False

            .Columns(0).HeaderText = "Núm. OS"
            .Columns(1).HeaderText = "Cliente"
            .Columns(2).HeaderText = "Entrada"
            .Columns(3).HeaderText = "CEP"
            .Columns(4).HeaderText = "UF"
            .Columns(5).HeaderText = "Endereço"
            .Columns(6).HeaderText = "Num."
            .Columns(7).HeaderText = "Complemento2."
            .Columns(8).HeaderText = "Compl"
            .Columns(9).HeaderText = "Bairro"
            .Columns(10).HeaderText = "Cidade"
            .Columns(11).HeaderText = "Tel. Residencial"
            .Columns(12).HeaderText = "Tel. Celular"
            .Columns(13).HeaderText = "Email"
            .Columns(14).HeaderText = "Serviço"
            .Columns(15).HeaderText = "Responsável"
            .Columns(16).HeaderText = "Garantia"
            .Columns(17).HeaderText = "Data de Entrega"
            .Columns(18).HeaderText = "Valor"
            .Columns(19).HeaderText = "Status do Pag."
            .Columns(20).HeaderText = "Observações"
            .Columns(21).HeaderText = "idClienteidTipo"
            .Columns(22).HeaderText = "idTipo"

            .Columns(0).Width = 50
            .Columns(1).Width = 180
            .Columns(2).Width = 100
            .Columns(3).Width = 90
            .Columns(4).Width = 45
            .Columns(5).Width = 200
            .Columns(6).Width = 50
            .Columns(7).Width = 150
            .Columns(8).Width = 150
            .Columns(9).Width = 150
            .Columns(10).Width = 120
            .Columns(11).Width = 120
            .Columns(12).Width = 200
            .Columns(13).Width = 200
            .Columns(14).Width = 200
            .Columns(15).Width = 120
            .Columns(16).Width = 100
            .Columns(17).Width = 100
            .Columns(18).Width = 180
            .Columns(19).Width = 250







            '.Columns("Sexo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns("Sexo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            '.Columns.Add("Meta", "Meta")
            '.Columns("Meta").Width = 100
            '.Columns("Meta").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns("Meta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '.Columns.Add("Realizado", "Realizado")
            '.Columns("Realizado").Width = 100
            '.Columns("Realizado").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns("Realizado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '.Columns.Add("Resultado", "Resultado %")
            '.Columns("Resultado").Width = 100
            '.Columns("Resultado").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns("Resultado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            '.Columns.Add("Participacao", "Participação %")
            '.Columns("Participacao").Width = 100
            '.Columns("Participacao").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns("Participacao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            '.Columns.Add("MetaAtingida", "Atingiu meta")
            '.Columns("MetaAtingida").Width = 100
            '.Columns("MetaAtingida").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns("MetaAtingida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            '.Columns.Add("Nota", "Nota")
            '.Columns("Nota").Width = 100
            '.Columns("Nota").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns("Nota").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter





        End With

    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_ContasReceber_listar", con)
            da.Fill(dt)
            dgContasReceber.DataSource = dt

            ContarLinhas()
            ' FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Contas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub


    Sub CarregarClientes()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            'DA = New SqlDataAdapter("SELECT * FROM tbClientes", con) 
            DA = New SqlDataAdapter("pa_cliente_listar", con)
            DA.Fill(DT)
            txtBuscarCliente.DisplayMember = "nome"
            txtBuscarCliente.ValueMember = "id_cliente"
            txtBuscarCliente.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgContasReceber.Rows.Count
        lblNumTotalContasReceber.Text = CInt(total)
    End Sub




End Class