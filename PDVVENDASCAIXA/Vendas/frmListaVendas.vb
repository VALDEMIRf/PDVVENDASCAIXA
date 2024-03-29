﻿Imports System.Data.SqlClient

Public Class frmListaVendas
    Private Sub frmListaVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarFuncionarios()

        CarregarClientes()

         Listar()
    End Sub

    Sub CarregarClientes()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_cliente_listar", con)
            DA.Fill(DT)
            cbCliente.DisplayMember = "nome"
            cbCliente.ValueMember = "id_cliente"
            cbCliente.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)

        Finally
            fechar()
        End Try

    End Sub

    Sub CarregarFuncionarios()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_funcionario_listaNome", con)
            DA.Fill(DT)
            cbFuncionario.DisplayMember = "nome"
            cbFuncionario.ValueMember = "id_func"
            cbFuncionario.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)

        Finally
            fechar()
        End Try

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_Vendas_ListaGeral", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@data", Now.Date())

            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Vendas" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()

        With dg
            .Columns(0).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False

            .Columns(1).HeaderText = "Núm. Venda"
            .Columns(2).HeaderText = "Produto"
            .Columns(3).HeaderText = "Cliente"
            .Columns(4).HeaderText = "Valor Unit."
            .Columns(5).HeaderText = "Quantidade"
            .Columns(6).HeaderText = "Valor Total"
            .Columns(7).HeaderText = "Funcionário"
            .Columns(8).HeaderText = "Dt. Venda"

            .Columns(1).Width = 70
            .Columns(2).Width = 180
            .Columns(3).Width = 130
            .Columns(4).Width = 90
            .Columns(5).Width = 90
            .Columns(6).Width = 70
            .Columns(7).Width = 150
        End With

    End Sub

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        cbCliente.Text = ""
        cbFuncionario.Text = ""

        cbCliente.Visible = True
        cbFuncionario.Visible = False
        dtData.Visible = False
    End Sub

    Private Sub rbFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles rbFuncionario.CheckedChanged
        cbCliente.Text = ""
        cbFuncionario.Text = ""

        cbCliente.Visible = False
        cbFuncionario.Visible = True
        dtData.Visible = False
    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        cbCliente.Text = ""

        cbCliente.Visible = False
        cbFuncionario.Visible = True
        dtData.Visible = True
    End Sub

    Private Sub cbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuncionario.SelectedIndexChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_Vendas_ListaFuncionario", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@funcionario", cbFuncionario.Text)

            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Vendas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_Vendas_ListaCliente", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@cliente", cbCliente.SelectedValue)

            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Vendas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_Vendas_ListaGeral", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@data", dtData.Text)

            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Vendas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
End Class