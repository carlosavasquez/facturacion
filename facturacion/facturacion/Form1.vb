Public Class Form1

    Private Sub bnt_guardar_Click(sender As Object, e As EventArgs) Handles bnt_guardar.Click
        Dim estado As String = "1"
        Dim objcliente As New Cliente
        objcliente.crear_cliente(txt_numdocu.Text, txt_nombre.Text, cb_tipodocu.Text, txt_telefono.Text, txt_dir.Text, txt_email.Text, txt_fechanacio.Text, estado)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_tipodocu.SelectedIndex = 0

    End Sub
End Class
