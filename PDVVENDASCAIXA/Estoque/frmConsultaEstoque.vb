Imports System.Data.SqlClient

Public Class frmConsultaEstoque
    Private Sub frmConsultaEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()

        dtDataInicio.Visible = False
        dtDatafinal.Visible = False
        lblDataFinal.Visible = False
        lblDataInicial.Visible = False

        rbEntrada.Checked = True
    End Sub

    Private Sub rbEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles rbEntrada.CheckedChanged
        cbEntrada.Text = ""
        cbEntrada.Visible = True
        dtDataInicio.Visible = False
        dtDatafinal.Visible = False
        lblDataFinal.Visible = False
        lblDataInicial.Visible = False

    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        cbEntrada.Text = ""
        cbEntrada.Visible = False
        dtDataInicio.Visible = True
        dtDatafinal.Visible = True
        lblDataFinal.Visible = True
        lblDataInicial.Visible = True
    End Sub

    Private Sub cbEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEntrada.SelectedIndexChanged
        If cbEntrada.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_Estoque_Entradabuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@descricao", cbEntrada.Text)

                da.Fill(dt)
                dg.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("pa_estoque_Buscargeral", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os produtos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(8).Visible = False

        dg.Columns(1).HeaderText = "Produto"
        dg.Columns(2).HeaderText = "Descrição"
        dg.Columns(3).HeaderText = "Quantidade"
        dg.Columns(4).HeaderText = "Data"
        dg.Columns(5).HeaderText = "Funcionário"
        dg.Columns(6).HeaderText = "Motivo"

        dg.Columns(1).Width = 100
        'dg.Columns(2).Width = 180
        'dg.Columns(3).Width = 130
        'dg.Columns(4).Width = 90
        'dg.Columns(5).Width = 90
        'dg.Columns(6).Width = 70
        'dg.Columns(7).Width = 150

    End Sub

    Private Sub lblSair_Click(sender As Object, e As EventArgs) Handles lblSair.Click
        Me.Close()

    End Sub

    Private Sub dtDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtDataInicio.ValueChanged
        buscarPorDatas()
    End Sub

    Private Sub dtDatafinal_ValueChanged(sender As Object, e As EventArgs) Handles dtDatafinal.ValueChanged
        buscarPorDatas()
    End Sub
    '

    Sub buscarPorDatas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_estoque_buscarEntreDatas", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@data_inicial", dtDataInicio.Text)
            da.SelectCommand.Parameters.AddWithValue("@data_final", dtDatafinal.Value)

            da.Fill(dt)
            dg.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try
    End Sub
End Class