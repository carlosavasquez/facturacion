Public Class Login
    Dim objlogin As New Clase_Login

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If objlogin.Valores(txt_usuario.Text, txt_pass.Text) = True Then
            MsgBox("Bienvenido", MsgBoxStyle.Information, "INVENTARIO")
            Dim menu As New Menu_Principal
            menu.Show()
            Me.Close()
        Else
            MsgBox("El usuario o Contrasena no son correctos", MsgBoxStyle.Critical, "INVENTARIO")
        End If
    End Sub
End Class