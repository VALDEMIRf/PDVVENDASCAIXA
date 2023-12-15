Public Class frmRelComprovante
    Public Sub New(ByVal num As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        Me.ComprovanteTableAdapter.Fill(Me.VendasDataSet1.Comprovante, num)

        Me.ReportViewer1.RefreshReport()

    End Sub
    Private Sub frmRelComprovante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'VendasDataSet1.Comprovante'. Você pode movê-la ou removê-la conforme necessário.
        ' Me.ComprovanteTableAdapter.Fill(Me.VendasDataSet1.Comprovante)

        '  Me.ReportViewer1.RefreshReport()
    End Sub
End Class