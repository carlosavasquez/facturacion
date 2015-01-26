Public Class Editar_Cliente
    Dim objcliente As New Cliente
    Private Sub Editar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If objcliente._idcliente = Nothing Then

        Else
            Dim id As String = objcliente._idcliente
            objcliente.consultar_todos_con_nit(id, "idproducto")
            txt_numdocu.Text = objcliente._numdocumento
            txt_nombre.Text = objcliente._nombre
            txt_telefono.Text = objcliente._telefono
            txt_dir.Text = objcliente._direccion
            cb_tipodocu.Text = objcliente._tipodocumento
        End If
    End Sub
End Class