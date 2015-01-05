Public Class Crear_Venta
    Dim objcliente As New Cliente
    Private Sub habilitarcampos()
        objcliente._idcliente = Nothing
        txt_id.Text = Nothing
        txt_nombre.Text = Nothing
        txt_telefono.Text = Nothing
        txt_direccion.Text = Nothing
        btn_crear.Visible = True
        txt_nombre.Enabled = True
        txt_telefono.Enabled = True
        txt_direccion.Enabled = True
        txt_tdocu.Enabled = True
    End Sub
    Private Sub Crear_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_nit_TextChanged(sender As Object, e As EventArgs) Handles txt_nit.TextChanged

        If txt_nit.Text <> Nothing Then
            If objcliente.consultar_con_nit(txt_nit.Text) = True Then
                txt_id.Text = objcliente._idcliente
                txt_nombre.Text = objcliente._nombre
                txt_telefono.Text = objcliente._telefono
                txt_direccion.Text = objcliente._direccion
                txt_tdocu.Text = objcliente._tipodocumento
                btn_crear.Visible = False
                txt_id.Enabled = False
                txt_nombre.Enabled = False
                txt_telefono.Enabled = False
                txt_direccion.Enabled = False
                txt_tdocu.Enabled = False
            Else
                habilitarcampos()
            End If
        Else
            habilitarcampos()
        End If
    End Sub
End Class