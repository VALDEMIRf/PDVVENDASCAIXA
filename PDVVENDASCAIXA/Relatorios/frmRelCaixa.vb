Imports System.Data.SqlClient

Public Class frmRelCaixa
    Private Sub frmRelCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtData.Value = Now.ToShortDateString
        cbFuncionario.Text = usuarioNome

        CarregarFuncionarios()

        'TODO: esta linha de código carrega dados na tabela 'caixa1DataSet1.tbCaixa'. Você pode movê-la ou removê-la conforme necessário.
        IniciarRel()

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
        IniciarRel()
    End Sub
    Sub IniciarRel()
        Me.tbCaixaTableAdapter.Fill(Me.caixa1DataSet1.tbCaixa, cbFuncionario.Text, dtData.Value)
        Me.ListaVendasGeralTableAdapter.Fill(Me.VendasDataSet1.ListaVendasGeral, dtData.Value, cbFuncionario.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged
        IniciarRel()
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
End Class