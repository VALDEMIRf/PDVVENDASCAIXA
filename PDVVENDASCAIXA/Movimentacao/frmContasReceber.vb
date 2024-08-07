﻿Imports System.Data.SqlClient
Imports System.Text

Public Class frmContasReceber
    Private Sub frmContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        btnSalvar.Enabled = False
        Listar()

        CarregarClientes()

        rbCliente.Checked = True

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub DesabilitarCampos()
        txtNVenda.Enabled = False

    End Sub

    Private Sub HabilitarCampos()

    End Sub

    Private Sub Limpar()

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
            txtCliente.DisplayMember = "nome"
            txtCliente.ValueMember = "id_cliente"
            txtCliente.DataSource = DT

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