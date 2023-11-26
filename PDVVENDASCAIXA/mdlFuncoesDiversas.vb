Imports System.Text

Module mdlFuncoesDiversas
    Public Function UTF8_to_ISO(texto As String) As String
        'Dim isoEncoding = Encoding.GetEncoding("ISO-8859-8")
        Dim isoEncoding = Encoding.GetEncoding("Windows-1252")
        Dim utfEncoding = Encoding.UTF8

        Dim bytesIso As Byte() = utfEncoding.GetBytes(texto)
        Dim bytesUtf As Byte() = Encoding.Convert(utfEncoding, isoEncoding, bytesIso)

        Dim textoISO = utfEncoding.GetString(bytesUtf)

        UTF8_to_ISO = textoISO
    End Function

    Public Sub permiteSoNumeros(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Module
