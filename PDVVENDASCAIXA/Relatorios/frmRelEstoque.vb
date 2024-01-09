Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmRelEstoque
    Private Sub frmRelEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ESTOQUEDataSet1.BuscarEntradasSaidas'. Você pode movê-la ou removê-la conforme necessário.
        ' Me.BuscarEntradasSaidasTableAdapter.Fill(Me.ESTOQUEDataSet1.BuscarEntradasSaidas)


        ' BuscarPorData()

        'dtDataInicio.Visible = False
        'dtDatafinal.Visible = False
        'lblDataFinal.Visible = False
        'lblDataInicial.Visible = False

        dtDataInicio.Value = Now.ToShortDateString
        dtDatafinal.Value = Now.ToShortDateString

        rbEntrada.Checked = True
        cbEntrada.Visible = True
        cbEntrada.Text = "Entrada"

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub rbEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles rbEntrada.CheckedChanged
        cbEntrada.Text = ""
        cbEntrada.Visible = True

        ReportViewer1.Visible = False
        ReportViewer2.Visible = True

    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged

        ReportViewer1.Visible = True
        ReportViewer2.Visible = False

        cbEntrada.Text = ""
        cbEntrada.Visible = False

        dtDataInicio.Visible = True
        dtDatafinal.Visible = True
        lblDataFinal.Visible = True
        lblDataInicial.Visible = True
    End Sub

    Private Sub cbEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEntrada.SelectedIndexChanged
        ChamarRelEntradaSaida()
    End Sub

    Private Sub dtDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtDataInicio.ValueChanged
        BuscarPorData()
        If rbEntrada.Checked = True Then
            ChamarRelEntradaSaida()
        End If
    End Sub

    Private Sub dtDatafinal_ValueChanged(sender As Object, e As EventArgs) Handles dtDatafinal.ValueChanged
        BuscarPorData()
        If rbEntrada.Checked = True Then
            ChamarRelEntradaSaida()
        End If
    End Sub

    Sub BuscarPorData()
        Me.EstoquePorDataTableAdapter.Fill(Me.ESTOQUEDataSet1.EstoquePorData, dtDataInicio.Text, dtDatafinal.Text)
        Me.BuscarEntradasTableAdapter.Fill(Me.ESTOQUEDataSet1.BuscarEntradas, dtDataInicio.Text, dtDatafinal.Text)
        Me.BuscarSaidasTableAdapter.Fill(Me.ESTOQUEDataSet1.BuscarSaidas, dtDataInicio.Text, dtDatafinal.Text)

        ''Parametros vindos do relatório
        Dim parametro(1) As ReportParameter
        parametro(0) = New ReportParameter("data_inicial", dtDataInicio.Value)

        parametro(1) = New ReportParameter("data_final", dtDatafinal.Value)


        'Dim data_inicial As ReportParameter
        'Dim data_final As ReportParameter
        'data_inicial = New ReportParameter("data_inicial", dtDataInicio.Value)
        'data_final = New ReportParameter("data_final", dtDatafinal.Value)

        Me.ReportViewer1.LocalReport.SetParameters(parametro)
        'Me.ReportViewer1.LocalReport.SetParameters(data_final)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub ChamarRelEntradaSaida()
        Dim descricao As String
        If cbEntrada.Text = "Entrada" Then
            descricao = "Entradas"
        Else
            descricao = "Saídas"
        End If

        Me.BuscarEntradasSaidasTableAdapter.Fill(Me.ESTOQUEDataSet1.BuscarEntradasSaidas, cbEntrada.Text, dtDataInicio.Text, dtDatafinal.Text)

        'Parametros vindos do relatório
        Dim parametro(2) As ReportParameter
        parametro(0) = New ReportParameter("data_inicial", dtDataInicio.Value)

        parametro(1) = New ReportParameter("data_final", dtDatafinal.Value)

        parametro(2) = New ReportParameter("descricao", descricao)

        Me.ReportViewer2.LocalReport.SetParameters(parametro)

        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub lblSair_Click(sender As Object, e As EventArgs) Handles lblSair.Click
        Me.Close()
    End Sub
End Class