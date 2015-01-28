Public Class Crear_Compra

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class