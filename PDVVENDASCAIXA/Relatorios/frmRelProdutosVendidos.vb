Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmRelProdutosVendidos
    Private Sub frmRelProdutosVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtDataInicio.Value = Now.ToShortDateString
        dtDatafinal.Value = Now.ToShortDateString

        IniciarRelatorio()
    End Sub

    Sub IniciarRelatorio()
        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.QuantidadeVendidaPorData'. Você pode movê-la ou removê-la conforme necessário.
        Me.QuantidadeVendidaPorDataTableAdapter.Fill(Me.ProdutosDataSet.QuantidadeVendidaPorData, dtDataInicio.Text, dtDatafinal.Text)

        'Parametros vindos do relatório
        Dim parametro(1) As ReportParameter
        parametro(0) = New ReportParameter("data_inicial", dtDataInicio.Value)

        parametro(1) = New ReportParameter("data_final", dtDatafinal.Value)


        Me.ReportViewer1.LocalReport.SetParameters(parametro)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub lblSair_Click(sender As Object, e As EventArgs) Handles lblSair.Click
        Me.Close()
    End Sub

    Private Sub dtDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtDataInicio.ValueChanged
        IniciarRelatorio()
    End Sub

    Private Sub dtDatafinal_ValueChanged(sender As Object, e As EventArgs) Handles dtDatafinal.ValueChanged
        IniciarRelatorio()
    End Sub
End Class