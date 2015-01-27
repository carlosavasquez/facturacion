Public Class Editar_Cliente
    Dim objcliente As New Cliente
    Private Sub Editar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If objcliente._idcliente = Nothing Or objcliente._idcliente = 0 Then
            MsgBox("la propiedad llega vacia")
        Else
            MsgBox(objcliente._idcliente)
            MsgBox(objcliente._numdocumento)
            MsgBox(objcliente._nombre)
            MsgBox(objcliente._telefono)
            objcliente.consultar_todos_con_nit(objcliente._idcliente, "idcliente")
            txt_numdocu.Text = objcliente._numdocumento
            txt_nombre.Text = objcliente._nombre.ToString
            txt_telefono.Text = objcliente._telefono
            txt_dir.Text = objcliente._direccion
            cb_tipodocu.Text = objcliente._tipodocumento
        End If
    End Sub
End Class