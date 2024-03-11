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

        With dg
            .Columns(0).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False

            .Columns(1).HeaderText = "Produto"
            .Columns(2).HeaderText = "Descrição"
            .Columns(3).HeaderText = "Quantidade"
            .Columns(4).HeaderText = "Data"
            .Columns(5).HeaderText = "Funcionário"
            .Columns(6).HeaderText = "Motivo"

            .Columns(1).Width = 100
            '.Columns(2).Width = 180
            '.Columns(3).Width = 130
            '.Columns(4).Width = 90
            '.Columns(5).Width = 90
            '.Columns(6).Width = 70
            '.Columns(7).Width = 150
        End With

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