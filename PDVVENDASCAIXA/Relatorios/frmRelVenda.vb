Imports System.Data.SqlClient

Public Class frmRelVenda
    Private Sub frmRelVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'VendasDataSet1.ListaVendasGeral'. Você pode movê-la ou removê-la conforme necessário.
        dtData.Value = Now.Date()
        CarregarFuncionarios()
        rel()

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged

        rel()
    End Sub

    Private Sub rel()
        Me.ListaVendasGeralTableAdapter.Fill(Me.VendasDataSet1.ListaVendasGeral, dtData.Text, cbFuncionario.Text)

        Me.ReportViewer1.RefreshReport()
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

    Private Sub cbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuncionario.SelectedIndexChanged

        rel()
    End Sub

    Private Sub rbFuncionario_CheckedChanged(sender As Object, e As EventArgs) 
        '  cbCliente.Text = ""
        cbFuncionario.Text = ""

        ' cbCliente.Visible = False
        cbFuncionario.Visible = True
        dtData.Visible = False
    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) 
        'cbCliente.Text = ""
        cbFuncionario.Text = ""

        ' cbCliente.Visible = False
        cbFuncionario.Visible = False
        dtData.Visible = True
    End Sub
End Class