Public Class Crear_Venta
#Region "Moverventana"
    Inherits System.Windows.Forms.Form

    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")> _
    Private Shared Sub ReleaseCapture()
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")> _
    Private Shared Sub SendMessage( _
            ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, _
            ByVal wParam As Integer, ByVal lParam As Integer _
            )
    End Sub
    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&
    Public Sub moverForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub
#End Region
    Dim objcon As New conexion
    Dim objcliente As New Cliente
    Dim objfuncionesvarias As New funciones_varias
    Dim objproductos As New Productos
    Dim objventas As New Ventas
    Dim objvendedor As New Vendedor
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
                dg_buscarnit.Visible = False
                p_salir_buscarcliente.Visible = False
                habilitarcampos()
            Else
                dg_buscarnit.Visible = True
                p_salir_buscarcliente.Visible = True
            End If
            If objcliente.consultar_todos_con_nit(txt_nit.Text, "identificacion") = True Then
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
            p_salir_buscarcliente.Visible = False
            habilitarcampos()
        End If
    End Sub
    Private Sub Crear_Venta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Menu_Principal.btn_ventas.Enabled = True
        Menu_Principal.btn_ventas.Image = My.Resources.ventas
    End Sub
    Private Sub Crear_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_tdocu.SelectedIndex = 0
        txt_vendedor.DataSource = objvendedor.obtenervendedor
        txt_vendedor.SelectedIndex = 0
        txt_fecha.Format = DateTimePickerFormat.Custom
        txt_fecha.CustomFormat = "yyyy-MM-dd"
    End Sub
    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        objfuncionesvarias.comprueba_numeros(e)
    End Sub
    Private Sub p_salir_Click(sender As Object, e As EventArgs) Handles p_salir.Click
        PanelBuscar_producto.Visible = False
        p_salir.Visible = False
        dg_buscarproducto.Visible = False

    End Sub
    Private Sub txt_cantidad_GotFocus(sender As Object, e As EventArgs) Handles txt_cantidad.GotFocus
        objproductos.obtener_idproducto_connombre_o_ref(criterio, cb_producto.Text)
        txt_valor.DataSource = Nothing

        Try
            txt_valor.DataSource = objproductos.precios_producto()
        Catch ex As Exception
            MsgBox(ex.ToString)
            'If ex .ToString .Contains ("")
            cb_producto.Focus()
            cb_producto.Text = Nothing
            'MsgBox("EL PRODUCTO SELECCIONADO NO ES VALIDO", MsgBoxStyle.Critical, "JAFERRO")
        End Try

        objproductos.obtenercantidad()
        txt_existencias.Text = objproductos._cantidad

    End Sub
    Private Sub dg_buscarnit_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_buscarnit.CellMouseDoubleClick
        Dim seleccionada As Integer
        Dim nomdg As String
        seleccionada = CType(sender, DataGridView).CurrentRow.Index
        nomdg = dg_buscarnit.Rows(seleccionada).Cells(1).Value()
        txt_nit.Text = nomdg
        txt_nit.Focus()
        dg_buscarnit.Visible = False
        p_salir_buscarcliente.Visible = False
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
            If MsgBox("Confirma la creacion del cliente con los siguientes datos:" & vbCrLf & "NIT/CC: " & txt_nit.Text & vbCrLf & "NOMBRE Ó RAZON SOCIAL: " & txt_nombre.Text & vbCrLf & "DIRECCIÓN: " & txt_direccion.Text & vbCrLf & "TELEFONO: " & txt_telefono.Text, MsgBoxStyle.YesNo, "INVENTARIO") = MsgBoxResult.Yes Then
                objcliente.crear_cliente(txt_nit.Text, txt_nombre.Text, txt_tdocu.Text, txt_telefono.Text, txt_direccion.Text, Nothing, estado)
                If MsgBox("Cliente Creado. ¿Desea añadir mas informacion del cliente?", MsgBoxStyle.YesNo, "Cliente Creado") = MsgBoxResult.Yes Then
                    objcliente._numdocumento = txt_nit.Text
                    objcliente.consultar_id_con_nit(txt_nit.Text)
                    txt_id.Text = objcliente._idcliente
                    inhabilitarcampos()
                    Dim adi_clien As New Editar_Cliente
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
        ElseIf txt_cantidad.Text = Nothing Or txt_cantidad.Text = "0" Then
            MsgBox("El campo Cantidad esta vacio ó es cero", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_valor.Text = Nothing Then
            MsgBox("El campo Precio esta vacio", MsgBoxStyle.Information, "JAFERRO")

        Else
            If Val(txt_cantidad.Text) > Val(txt_existencias.Text) Then
                MsgBox("La cantidad maxima que puede vender de este producto es:" & txt_existencias.Text, MsgBoxStyle.Critical, "JAFERRO")
            Else
                objproductos.calcular_iva(Val(txt_valor.Text), Val(txt_cantidad.Text))
                Dim i, s, t As Integer
                i = objproductos._totaliva
                s = objproductos._subtotal
                t = objproductos._totalventa
                txt_iva.Text = i
                txt_sub.Text = s
                txt_total.Text = t
                Dim v_total As Integer = Val(txt_valor.Text) * Val(txt_cantidad.Text)
                objproductos.Obtenerdatos()
                dg_productosventa.Rows.Insert(0, objproductos._idproducto, objproductos._nombreproducto, objproductos._iva, objproductos._estadoproducto, Val(txt_cantidad.Text), Val(txt_valor.Text), Val(v_total.ToString), Val(txt_existencias.Text))
                PanelBuscar_producto.Visible = False
                p_salir.Visible = False
                dg_buscarproducto.Visible = False
                txt_valor.DataSource = Nothing
                txt_cantidad.Text = Nothing
            End If
        End If
    End Sub
    Private Sub p_salir_buscarcliente_Click(sender As Object, e As EventArgs) Handles p_salir_buscarcliente.Click
        dg_buscarnit.Visible = False
        p_salir_buscarcliente.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim cantidadproductos As Integer = Me.dg_productosventa.RowCount - 1
        MsgBox(cantidadproductos.ToString)
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim si As Integer = 0
        If txt_numfactura.Text = Nothing Then
            MsgBox("El campo Factura esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_id.Text = Nothing Then
            MsgBox("No ha seleccionado un Cliente", MsgBoxStyle.Information, "JAFERRO")
            txt_nit.Focus()
        Else
            If Me.dg_productosventa.RowCount <> 0 Then

                If objventas.validar_factura(Val(txt_numfactura.Text)) = False Then
                    Try
                        Dim cantidadproductos As Integer = Me.dg_productosventa.RowCount
                        objvendedor.obtenerid(txt_vendedor.Text)
                        Dim vtot As Integer = Val(txt_total.Text)
                        Dim viv As Integer = Val(txt_iva.Text)
                        'objventas.obteneridventa()
                        objcon.conn.Open()
                        objcon.trans = objcon.conn.BeginTransaction()
                        objcon.cmd.CommandType = CommandType.Text
                        objcon.cmd.Connection = objcon.conn
                        Dim estado As Integer = 1
                        'objventas.CrearVenta(Val(txt_numfactura.Text), txt_fecha.Text, vtot, viv, Val(txt_id.Text), objvendedor._idvendedor)
                        objcon.cmd.CommandText = "INSERT INTO factura_venta(numero_factura,fecha_expedicion,valor_total_venta,valor_total_iva,estado,cliente_idcliente,vendedor_idvendedor) VALUES (" & txt_numfactura.Text & " , '" & txt_fecha.Text & "', " & vtot & "," & viv & "," & estado & "," & Val(txt_id.Text) & "," & objvendedor._idvendedor & ")"
                        objcon.cmd.Transaction = objcon.trans
                        objcon.cmd.ExecuteNonQuery()
                        objcon.cmd.CommandText = "SELECT idfactura_venta FROM factura_venta ORDER BY idfactura_venta DESC LIMIT 1 FOR UPDATE"
                        objcon.cmd.Transaction = objcon.trans
                        objventas._idventa = objcon.cmd.ExecuteScalar()
                        For i = 0 To cantidadproductos - 1
                            objproductos._idproducto = Me.dg_productosventa.Rows(i).Cells(0).Value()
                            Dim cant_vendida As Integer = Me.dg_productosventa.Rows(i).Cells(4).Value()
                            Dim val_unit As Integer = Me.dg_productosventa.Rows(i).Cells(5).Value()
                            objproductos._cantidad = Me.dg_productosventa.Rows(i).Cells(7).Value()
                            'objproductos.obtenercantidad()
                            objproductos._cantidad -= cant_vendida
                            'objcon.increment += 1
                            objcon.cmd.CommandText = "insert into productos_venta(cantidad,valor,estado,factura_venta_idfactura_venta,producto_idproducto) values(" & cant_vendida & "," & val_unit & ",'" & estado & "'," & objventas._idventa & ",'" & objproductos._idproducto & "')"
                            objcon.cmd.Transaction = objcon.trans
                            objcon.cmd.ExecuteNonQuery()
                            'objproductos.agregar_productos_a_venta(cant_vendida, val_unit, objventas._idventa)
                            'objcon.increment += 1
                            'objproductos.actualizarcantidad()
                            objcon.cmd.CommandText = "Update producto Set cantidad=" & objproductos._cantidad & " WHERE idproducto='" & objproductos._idproducto & "'"
                            objcon.cmd.Transaction = objcon.trans
                            objcon.cmd.ExecuteNonQuery()
                        Next
                        objcon.trans.Commit()
                        MsgBox("VENTA EXITOSA", MsgBoxStyle.Information, "JAFERRO")
                        objcon.conn.Close()
                        Me.Close()
                    Catch ex As System.Data.Odbc.OdbcException
                        objcon.trans.Rollback()
                        objcon.conn.Close()
                        MsgBox("No se pudo ejecutar la transacción!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error en la transacción")
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Detalles del error")

                    End Try
                Else
                    MsgBox("El numero de factura ya esta", MsgBoxStyle.Information, "JAFERRO")
                End If
            Else
                MsgBox("No Ha Agregado Productos a la Venta", MsgBoxStyle.Critical, "JAFERRO")
            End If
        End If
    End Sub
    Private Sub cb_producto_TextChanged(sender As Object, e As EventArgs) Handles cb_producto.TextChanged
        'verifica
        If cb_producto.Text <> Nothing Then
            If r_nombre.Checked Then
                criterio = "nombre"
            ElseIf r_ref.Checked Then
                criterio = "referencia"
            End If
            dg_buscarproducto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_buscarproducto.DataSource = objproductos.consultar_productos(cb_producto.Text, criterio)
            dg_buscarproducto.Columns(0).HeaderText = "NOMBRE"
            dg_buscarproducto.Columns(0).Width = 200
            dg_buscarproducto.Columns(1).HeaderText = "REF."
            dg_buscarproducto.Columns(1).Width = 80
            dg_buscarproducto.Columns(2).HeaderText = "CANT."
            dg_buscarproducto.Columns(2).Width = 50
            dg_buscarproducto.Columns(3).HeaderText = "PRECIO 1"
            dg_buscarproducto.Columns(3).Width = 80
            dg_buscarproducto.Columns(4).HeaderText = "PRECIO 2"
            dg_buscarproducto.Columns(4).Width = 80
            dg_buscarproducto.Columns(5).HeaderText = "PRECIO 3"
            dg_buscarproducto.Columns(5).Width = 80
            If dg_buscarproducto.RowCount = 0 Then
                dg_buscarproducto.Visible = False
                'p_salir_buscarcliente.Visible = False
            Else
                dg_buscarproducto.Visible = True
                'p_salir_buscarcliente.Visible = True
            End If
        Else
            dg_buscarproducto.Visible = False
        End If
    End Sub
    Private Sub dg_productosventa_CellContentClick1(sender As Object, e As DataGridViewCellEventArgs) Handles dg_productosventa.CellContentClick
        If e.ColumnIndex = 8 Then
            PanelBuscar_producto.Visible = True
            p_salir.Visible = True
            r_nombre.Checked = True
            cb_producto.Focus()
            cb_producto.Text = Nothing
            txt_cantidad.Text = Nothing
            txt_existencias.Text = Nothing
            txt_valor.Text = Nothing

        ElseIf e.ColumnIndex = 9 Then
            If dg_productosventa.RowCount = 0 Then
                MsgBox("No hay productos para eliminar", MsgBoxStyle.Information, "JAFERRO")
            Else
                Dim seleccionada As Integer
                seleccionada = CType(sender, DataGridView).CurrentRow.Index
                Dim vuni As Integer = Me.dg_productosventa.CurrentRow.Cells.Item(5).Value()
                Dim piva As Integer = Me.dg_productosventa.CurrentRow.Cells.Item(2).Value()
                Dim can As Integer = Me.dg_productosventa.CurrentRow.Cells.Item(4).Value()
                Dim nom As String = Me.dg_productosventa.CurrentRow.Cells.Item(1).Value()
                If MsgBox("Confirma la Eliminacion de este Producto:" & vbCrLf & "Producto:" & nom & vbCrLf & "Cantidad:" & can.ToString, MsgBoxStyle.YesNo, "JAFERRO") = MsgBoxResult.Yes Then

                    objproductos.restartotales(vuni, can, piva)
                    Dim i, s, t As Integer
                    i = objproductos._totaliva
                    s = objproductos._subtotal
                    t = objproductos._totalventa
                    txt_iva.Text = i
                    txt_sub.Text = s
                    txt_total.Text = t
                    dg_productosventa.Rows.RemoveAt(seleccionada)

                Else
                    MsgBox("La eliminación a sido cancelada", MsgBoxStyle.Information, "JAFERRO")
                End If
            End If
        Else
        End If
    End Sub
    Private Sub dg_buscarproducto_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_buscarproducto.CellMouseDoubleClick
        Dim seleccionada As Integer
        Dim nompro As String
        seleccionada = CType(sender, DataGridView).CurrentRow.Index
        nompro = dg_buscarproducto.Rows(seleccionada).Cells(0).Value()
        cb_producto.Text = nompro
        txt_cantidad.Focus()
    End Sub
    Private Sub dg_productosventa_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dg_productosventa.CellEndEdit
        If e.ColumnIndex = 4 Then
            Dim seleccionada As Integer
            seleccionada = CType(sender, DataGridView).CurrentRow.Index
            If dg_productosventa.Rows(seleccionada).Cells(4).Value() = Nothing Then
                dg_productosventa.Rows(seleccionada).Cells(4).Value() = 1
                Dim va, car, tot As Integer
                car = dg_productosventa.Rows(seleccionada).Cells(4).Value()
                va = dg_productosventa.Rows(seleccionada).Cells(5).Value()
                tot = va * car
                dg_productosventa.Rows(seleccionada).Cells(6).Value() = tot
                objproductos._idproducto = dg_productosventa.Rows(seleccionada).Cells(0).Value()
                'MsgBox(car.ToString)
                objproductos.calcular_iva(va, car)
                Dim i, s, t As Integer
                i = objproductos._totaliva
                s = objproductos._subtotal
                t = objproductos._totalventa
                txt_iva.Text = i
                txt_sub.Text = s
                txt_total.Text = t
                MsgBox("El campo cantidad no puede quedar vacio", MsgBoxStyle.Critical, "JAFERRO")
            Else
                If dg_productosventa.Rows(seleccionada).Cells(4).Value() > dg_productosventa.Rows(seleccionada).Cells(7).Value() Then
                    MsgBox("Ha digitado una cantidad mayor a las existencias del producto", MsgBoxStyle.Critical, "JAFERRO")
                    dg_productosventa.Rows(seleccionada).Cells(4).Value() = 1
                    Dim va, car, tot As Integer
                    car = dg_productosventa.Rows(seleccionada).Cells(4).Value()
                    va = dg_productosventa.Rows(seleccionada).Cells(5).Value()
                    tot = va * car
                    dg_productosventa.Rows(seleccionada).Cells(6).Value() = tot
                    objproductos._idproducto = dg_productosventa.Rows(seleccionada).Cells(0).Value()
                    'MsgBox(car.ToString)
                    objproductos.calcular_iva(va, car)
                    Dim i, s, t As Integer
                    i = objproductos._totaliva
                    s = objproductos._subtotal
                    t = objproductos._totalventa
                    txt_iva.Text = i
                    txt_sub.Text = s
                    txt_total.Text = t
                Else
                    Dim va, car, tot As Integer

                    car = dg_productosventa.Rows(seleccionada).Cells(4).Value()

                    va = dg_productosventa.Rows(seleccionada).Cells(5).Value()
                    tot = va * car
                    dg_productosventa.Rows(seleccionada).Cells(6).Value() = tot
                    objproductos._idproducto = dg_productosventa.Rows(seleccionada).Cells(0).Value()
                    objproductos.calcular_iva(va, car)
                    Dim i, s, t As Integer
                    i = objproductos._totaliva
                    s = objproductos._subtotal
                    t = objproductos._totalventa
                    txt_iva.Text = i
                    txt_sub.Text = s
                    txt_total.Text = t
                End If

            End If
        Else

        End If
    End Sub
    Private Sub dg_productosventa_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dg_productosventa.CellBeginEdit
        If e.ColumnIndex = 4 Then
            Dim seleccionada As Integer
            Dim va, car, iv As Integer
            seleccionada = CType(sender, DataGridView).CurrentRow.Index
            car = dg_productosventa.Rows(seleccionada).Cells(4).Value()
            va = dg_productosventa.Rows(seleccionada).Cells(5).Value()
            iv = dg_productosventa.Rows(seleccionada).Cells(2).Value()
            'MsgBox(car.ToString)
            objproductos.restartotales(va, car, iv)
            Dim i, s, t As Integer
            i = objproductos._totaliva
            s = objproductos._subtotal
            t = objproductos._totalventa
            txt_iva.Text = i
            txt_sub.Text = s
            txt_total.Text = t
        Else

        End If
    End Sub
    Private Sub dg_productosventa_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_productosventa.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros
    End Sub
    Private Sub Validar_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim Celda As DataGridViewCell = Me.dg_productosventa.CurrentCell()

        If Celda.ColumnIndex = 4 Then

            If e.KeyChar = "."c Then

                If InStr(Celda.EditedFormattedValue.ToString, ".", CompareMethod.Text) > 0 Then

                    e.Handled = True
                Else

                    e.Handled = False
                End If
            Else

                If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then

                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                        e.Handled = False
                    Else

                        e.Handled = True
                    End If
                Else

                    If e.KeyChar = "0"c Then

                        e.Handled = True
                    Else

                        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                            e.Handled = False
                        Else

                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        PanelBuscar_producto.Visible = True
        p_salir.Visible = True
        r_nombre.Checked = True
        cb_producto.Focus()
        cb_producto.Text = Nothing
        txt_cantidad.Text = Nothing
        txt_existencias.Text = Nothing
        txt_valor.Text = Nothing
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        MsgBox(Me.dg_productosventa.RowCount.ToString - 1)
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub barra_MouseMove(sender As Object, e As MouseEventArgs) Handles barra.MouseMove
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub

    Private Sub txt_numfactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numfactura.KeyPress
        objfuncionesvarias.comprueba_numeros(e)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles r_ref.CheckedChanged

    End Sub
End Class