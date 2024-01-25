Imports Microsoft.Reporting.WinForms

Public Class frmRelComprovante
    Public Sub New(ByVal num As String, subTotal As String, desconto As String, totalCompra As String, valorRecebido As String, troco As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        Me.ComprovanteTableAdapter.Fill(Me.VendasDataSet1.Comprovante, num)

        'Parametros vindos do relatório
        Dim parametro(4) As ReportParameter
        parametro(0) = New ReportParameter("subTotal", subTotal)
        parametro(1) = New ReportParameter("desconto", desconto)
        parametro(2) = New ReportParameter("totalCompra", totalCompra)
        parametro(3) = New ReportParameter("valorRecebido", valorRecebido)
        parametro(4) = New ReportParameter("troco", troco)

        Me.ReportViewer1.LocalReport.SetParameters(parametro)
        Me.ReportViewer1.RefreshReport()

    End Sub
    Private Sub frmRelComprovante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'VendasDataSet1.Comprovante'. Você pode movê-la ou removê-la conforme necessário.
        ' Me.ComprovanteTableAdapter.Fill(Me.VendasDataSet1.Comprovante)

        '  Me.ReportViewer1.RefreshReport()
    End Sub
End Class