Public Class Form1
    
    Private Sub bnt_guardar_Click(sender As Object, e As EventArgs) Handles bnt_guardar.Click

        Dim objcliente As New Cliente
        Dim estado As String = "1"
        If txt_nombre.Text = Nothing Then
            MsgBox("El campo Nombre esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_numdocu.Text = Nothing Then
            MsgBox("El campo Numero de Documento esta vacio", MsgBoxStyle.Information, "JAFERRO")
        Else

            If objcliente.crear_cliente(txt_numdocu.Text, txt_nombre.Text, cb_tipodocu.Text, txt_telefono.Text, txt_dir.Text, txt_email.Text, estado) = True Then
                MsgBox("Cliente Creado Exitosamente", MsgBoxStyle.Information, "JAFERRO")
            Else
                MsgBox("Error al Crear Cliente", MsgBoxStyle.Information, "JAFERRO")
            End If

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_tipodocu.SelectedIndex = 0
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class
