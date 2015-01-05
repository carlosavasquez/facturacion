﻿Public Class Crear_Venta
    Dim objcliente As New Cliente
    Dim objfuncionesvarias As New funciones_varias
    Private Sub inhabilitarcampos()
        btn_crear.Visible = False
        txt_id.Enabled = False
        txt_nombre.Enabled = False
        txt_telefono.Enabled = False
        txt_direccion.Enabled = False
        txt_tdocu.Enabled = False
    End Sub
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
    Private Sub txt_nit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nit.KeyPress
        objfuncionesvarias.comprueba_numeros(e)
    End Sub

    Private Sub txt_nit_TextChanged(sender As Object, e As EventArgs) Handles txt_nit.TextChanged
        If txt_nit.Text <> Nothing Then
            If objcliente.consultar_todos_con_nit(txt_nit.Text) = True Then
                txt_id.Text = objcliente._idcliente
                txt_nombre.Text = objcliente._nombre
                txt_telefono.Text = objcliente._telefono
                txt_direccion.Text = objcliente._direccion
                txt_tdocu.Text = objcliente._tipodocumento
                inhabilitarcampos()
            Else
                habilitarcampos()
            End If
        Else
            habilitarcampos()
        End If
    End Sub

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click
        Dim estado As String = "1"
        If objcliente.crear_cliente(txt_nit.Text, txt_nombre.Text, txt_tdocu.Text, txt_telefono.Text, Nothing, Nothing, Nothing, estado) = True Then
            If MsgBox("Cliente Creado. ¿Desea añadir informacion del cliente?", MsgBoxStyle.YesNo, "Cliente Creado") = MsgBoxResult.Yes Then
                Dim adi_clien As New Editar_Cliente
                objcliente._numdocumento = txt_nit.Text
                objcliente.consultar_id_con_nit(txt_nit.Text)
                txt_id.Text = objcliente._idcliente
                inhabilitarcampos()
                adi_clien.Show()
            Else
                If objcliente.consultar_id_con_nit(txt_nit.Text) = True Then
                    txt_id.Text = objcliente._idcliente
                    txt_nombre.Enabled = False
                    txt_telefono.Enabled = False
                    txt_direccion.Enabled = False
                End If

            End If
        Else

        End If

    End Sub

    Private Sub Crear_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_tdocu.SelectedIndex = 0
    End Sub
End Class