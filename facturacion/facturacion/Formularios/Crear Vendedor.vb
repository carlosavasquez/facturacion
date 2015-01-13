Public Class Crear_Vendedor
    Dim objvendedor As New Vendedor
    Private Sub bnt_guardar_Click(sender As Object, e As EventArgs) Handles bnt_guardar.Click
        If txt_nombre.Text = Nothing Then
            MsgBox("El campo Nombre esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_numdocu.Text = Nothing Then
            MsgBox("El campo Numero Identificacion esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_telefono.Text = Nothing Then
            MsgBox("El campo Telefono esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_dir.Text = Nothing Then
            MsgBox("El campo Direccion esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_email.Text = Nothing Then
            MsgBox("El campo E-Mail esta vacio", MsgBoxStyle.Information, "JAFERRO")
        Else
            If objvendedor.CrearVendedor(txt_numdocu.Text, txt_nombre.Text, txt_telefono.Text, txt_dir.Text, txt_email.Text) = True Then
                MsgBox("Vendedor Creado Exitosamente", MsgBoxStyle.Information, "JAFERRO")
            Else
                MsgBox("Error Creando Vendedor", MsgBoxStyle.Critical, "JAFERRO")
            End If
        End If
    End Sub
End Class