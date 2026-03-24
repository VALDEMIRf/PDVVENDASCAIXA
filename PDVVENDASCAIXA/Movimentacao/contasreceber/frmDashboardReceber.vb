Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmDashboardReceber

    Dim connectionString As String = My.Settings.PDVConnectionString.ToString

    Private Sub frmDashboardReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDashboard()
    End Sub

    Private Sub CarregarDashboard()

        Using con As New SqlConnection(connectionString)

            Dim sql As String =
                "SELECT 
                    SUM(CASE WHEN Pago = 0 THEN Valor ELSE 0 END) AS TotalPendente,
                    SUM(CASE WHEN Pago = 1 THEN Valor ELSE 0 END) AS TotalPago
                 FROM tbContasReceber"

            Using cmd As New SqlCommand(sql, con)
                con.Open()
                Dim dr = cmd.ExecuteReader()

                If dr.Read() Then
                    Dim pendente As Decimal = If(IsDBNull(dr("TotalPendente")), 0, dr("TotalPendente"))
                    Dim pago As Decimal = If(IsDBNull(dr("TotalPago")), 0, dr("TotalPago"))

                    lblTotalPendente.Text = "Total Pendente: R$ " & pendente.ToString("N2")
                    lblTotalPago.Text = "Total Pago: R$ " & pago.ToString("N2")

                    chartFinanceiro.Series(0).Points.Clear()
                    chartFinanceiro.Series(0).Points.AddXY("Pendente", pendente)
                    chartFinanceiro.Series(0).Points.AddXY("Pago", pago)
                End If
            End Using
        End Using

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
End Class