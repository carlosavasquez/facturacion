Public Class funciones_varias
    Sub comprueba_numeros(e)
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
End Class
