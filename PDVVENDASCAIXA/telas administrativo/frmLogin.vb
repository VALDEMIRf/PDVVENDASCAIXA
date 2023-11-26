Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim form = New frmPrincipal
        form.ShowDialog()
    End Sub
End Class