Public Class frmInicial

    Private ImagemCarregada As Image
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New frmPrincipal
        form.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbImagem.Click
        Dim form = New frmPrincipal
        form.ShowDialog()
    End Sub

    Private Sub btAcesso_Click(sender As Object, e As EventArgs) Handles btAcesso.Click
        pbImagem.Visible = True
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"}

            If OFD.ShowDialog = DialogResult.OK Then
                ImagemCarregada = Image.FromFile(OFD.FileName)
                pbImagem.Image = ImagemCarregada
            End If
        End Using
    End Sub
End Class