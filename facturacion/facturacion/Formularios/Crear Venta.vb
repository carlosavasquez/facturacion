Public Class Crear_Venta
    Dim objcliente As New Cliente
    Dim objfuncionesvarias As New funciones_varias
    Dim objproductos As New Productos
    Dim objventas As New Ventas
    Dim criterio As String
    Private Sub inhabilitarcampos()
        btn_crear_cliente.Visible = False
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
        btn_crear_cliente.Visible = True
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
            dg_buscarnit.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_buscarnit.DataSource = objcliente.consultar_nombre_nit(txt_nit.Text, "identificacion")
            dg_buscarnit.Columns(0).HeaderText = "NOMBRE"
            dg_buscarnit.Columns(0).Width = 200
            dg_buscarnit.Columns(1).HeaderText = "NIT/CC"
            dg_buscarnit.Columns(1).Width = 130
            If dg_buscarnit.RowCount = 0 Then
            Else
                dg_buscarnit.Visible = True
            End If
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
            dg_buscarnit.Visible = False

            habilitarcampos()
        End If
    End Sub
    Private Sub Crear_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_tdocu.SelectedIndex = 0
    End Sub
    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        objfuncionesvarias.comprueba_numeros(e)
    End Sub
    Private Sub dg_productosventa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_productosventa.CellContentClick
        If e.ColumnIndex = 7 Then
            PanelBuscar_producto.Visible = True
            p_salir.Visible = True
            check_nompro.CheckState = CheckState.Checked
            cb_producto.Focus()
        Else

        End If
    End Sub

    Private Sub p_salir_Click(sender As Object, e As EventArgs) Handles p_salir.Click
        PanelBuscar_producto.Visible = False
        p_salir.Visible = False

    End Sub

    Private Sub txt_cantidad_GotFocus(sender As Object, e As EventArgs) Handles txt_cantidad.GotFocus
        objproductos.obtener_idproducto_connombre_o_ref(criterio, cb_producto.Text)
        txt_valor.DataSource = Nothing
        txt_valor.DataSource = objproductos.precios_producto()

    End Sub

    Private Sub check_nompro_CheckedChanged1(sender As Object, e As EventArgs) Handles check_nompro.CheckedChanged
        If check_referencia.CheckState = CheckState.Checked Then
            check_referencia.CheckState = CheckState.Unchecked
        Else
            check_nompro.CheckState = CheckState.Checked
            criterio = "nombre"
            cb_producto.DataSource = Nothing
            cb_producto.DataSource = objproductos.consultar_con_nombre(criterio)
        End If
    End Sub

    Private Sub check_referencia_CheckedChanged1(sender As Object, e As EventArgs) Handles check_referencia.CheckedChanged
        If check_nompro.CheckState = CheckState.Checked Then
            check_nompro.CheckState = CheckState.Unchecked
        Else
            check_referencia.CheckState = CheckState.Checked
            criterio = "referencia"
            cb_producto.DataSource = Nothing
            cb_producto.DataSource = objproductos.consultar_con_nombre(criterio)
        End If
    End Sub

    Private Sub dg_buscarnit_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_buscarnit.CellMouseDoubleClick
        Dim seleccionada As Integer
        Dim nomdg As String
        seleccionada = CType(sender, DataGridView).CurrentRow.Index
        nomdg = dg_buscarnit.Rows(seleccionada).Cells(1).Value()
        txt_nit.Text = nomdg
        txt_nit.Focus()
        dg_buscarnit.Visible = False
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        If txt_nombre.Text <> Nothing Then
            dg_buscarnit.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_buscarnit.DataSource = objcliente.consultar_nombre_nit(txt_nombre.Text, "nombre_razon_social")
            dg_buscarnit.Columns(0).HeaderText = "NOMBRE"
            dg_buscarnit.Columns(0).Width = 200
            dg_buscarnit.Columns(1).HeaderText = "NIT/CC"
            dg_buscarnit.Columns(1).Width = 130
            If dg_buscarnit.RowCount = 0 Then
                dg_buscarnit.Visible = False
                p_salir_buscarcliente.Visible = False
            Else
                dg_buscarnit.Visible = True
                p_salir_buscarcliente.Visible = True
            End If
        Else
            dg_buscarnit.Visible = False
            p_salir_buscarcliente.Visible = False
            habilitarcampos()
        End If

    End Sub

    Private Sub btn_crear_cliente_Click(sender As Object, e As EventArgs) Handles btn_crear_cliente.Click
        Dim estado As String = "1"
        If txt_nit.Text = Nothing Then
            MsgBox("El campo Nit esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_nombre.Text = Nothing Then
            MsgBox("El campo Nombre esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_direccion.Text = Nothing Then
            MsgBox("El campo Direccion esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_telefono.Text = Nothing Then
            MsgBox("El campo Telefono esta vacio", MsgBoxStyle.Information, "JAFERRO")
        Else
            If objcliente.crear_cliente(txt_nit.Text, txt_nombre.Text, txt_tdocu.Text, txt_telefono.Text, Nothing, Nothing, estado) = True Then
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
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If cb_producto.Text = Nothing Then
            MsgBox("El campo Producto esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_cantidad.Text = Nothing Then
            MsgBox("El campo Cantidad esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_valor.Text = Nothing Then
            MsgBox("El campo Precio esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_desc.Text = Nothing Then
            txt_desc.Text = "0"
        Else
            If objproductos.comprobar_existencia(Val(txt_cantidad.Text)) = True Then
                objproductos.calcular_iva(Val(txt_valor.Text), Val(txt_cantidad.Text))
                txt_iva.Text = objproductos._totaliva
                txt_sub.Text = objproductos._subtotal
                txt_total.Text = objproductos._totalventa
            Else
                MsgBox("La cantidad maxima que puede vender de este producto es:" & objproductos._cantidad.ToString, MsgBoxStyle.Critical, "JAFERRO")
            End If

        End If
       
    End Sub

    Private Sub p_salir_buscarcliente_Click(sender As Object, e As EventArgs) Handles p_salir_buscarcliente.Click
        dg_buscarnit.Visible = False
        p_salir_buscarcliente.Visible = False
    End Sub
End Class