Public Class Crear_Compra
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
    Dim objfuncionesvarias As New funciones_varias
    Dim objprovee As New Proveedor
    Dim objproductos As New Productos
    Dim objcon As New conexion
    Dim objcompra As New Compras
    Dim criterio As String
#Region "botones barra"
    Private Sub barra_MouseMove(sender As Object, e As MouseEventArgs) Handles barra.MouseMove
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "valida numeros"
    Private Sub txt_nit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nit.KeyPress
        objfuncionesvarias.comprueba_numeros(e)
    End Sub

    Private Sub txt_numfactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numfactura.KeyPress
        objfuncionesvarias.comprueba_numeros(e)
    End Sub

    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        objfuncionesvarias.comprueba_numeros(e)
    End Sub
#End Region
    Private Sub inhabilitarcampos()
        btn_crear_proveedor.Visible = False
        txt_id.Enabled = False
        txt_nombre.Enabled = False
        txt_telefono.Enabled = False
        txt_direccion.Enabled = False
        txt_tdocu.Enabled = False
    End Sub
    Private Sub habilitarcampos()
        objprovee._idproveedor = Nothing
        txt_id.Text = Nothing
        txt_nombre.Text = Nothing
        txt_telefono.Text = Nothing
        txt_direccion.Text = Nothing
        btn_crear_proveedor.Visible = True
        txt_nombre.Enabled = True
        txt_telefono.Enabled = True
        txt_direccion.Enabled = True
        txt_tdocu.Enabled = True
    End Sub
    Private Sub Crear_Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_tdocu.SelectedIndex = 0
        txt_fecha.Format = DateTimePickerFormat.Custom
        txt_fecha.CustomFormat = "yyyy-MM-dd"
    End Sub
    Private Sub txt_nit_TextChanged(sender As Object, e As EventArgs) Handles txt_nit.TextChanged
        If txt_nit.Text <> Nothing Then
            PanelBuscar_producto.Visible = False
            p_salir.Visible = False
            dg_buscarproducto.Visible = False
            dg_buscarnit.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg_buscarnit.DataSource = objprovee.consultar_con_criterio(txt_nit.Text, "identificacion")
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
            If objprovee.obtener_datos_con_nit(txt_nit.Text, "identificacion") = True Then
                txt_id.Text = objprovee._idproveedor
                txt_nit.Text = objprovee._numdocumento
                txt_nombre.Text = objprovee._nombre
                txt_telefono.Text = objprovee._telefono
                txt_tdocu.Text = objprovee._tipodocumento
                txt_direccion.Text = objprovee._direccion
                txt_nit.Focus()
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

    Private Sub dg_buscarnit_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_buscarnit.CellMouseDoubleClick
        Dim seleccionada As Integer
        Dim nit_provee As String
        seleccionada = CType(sender, DataGridView).CurrentRow.Index
        nit_provee = dg_buscarnit.Rows(seleccionada).Cells(1).Value()
        objprovee.obtener_datos_con_nit(nit_provee, "identificacion")
        txt_nit.Text = objprovee._numdocumento
        txt_nombre.Text = objprovee._nombre
        txt_telefono.Text = objprovee._telefono
        txt_tdocu.Text = objprovee._tipodocumento
        txt_direccion.Text = objprovee._direccion
        txt_nit.Focus()
        dg_buscarnit.Visible = False
        p_salir_buscarcliente.Visible = False

    End Sub

    Private Sub p_salir_buscarcliente_Click(sender As Object, e As EventArgs) Handles p_salir_buscarcliente.Click
        dg_buscarnit.Visible = False
        p_salir_buscarcliente.Visible = False
    End Sub

    Private Sub btn_crear_cliente_Click(sender As Object, e As EventArgs) Handles btn_crear_proveedor.Click
        Dim estado As String = "1"
        If txt_nit.Text = Nothing Then
            MsgBox("El campo Nit esta vacio", MsgBoxStyle.Information, "INVENTARIO")
        ElseIf txt_nombre.Text = Nothing Then
            MsgBox("El campo Nombre esta vacio", MsgBoxStyle.Information, "INVENTARIO")
        ElseIf txt_direccion.Text = Nothing Then
            MsgBox("El campo Direccion esta vacio", MsgBoxStyle.Information, "INVENTARIO")
        ElseIf txt_telefono.Text = Nothing Then
            MsgBox("El campo Telefono esta vacio", MsgBoxStyle.Information, "INVENTARIO")
        Else
            If MsgBox("Confirma la creacion del Proveedor con los siguientes datos:" & vbCrLf & "NIT/CC: " & txt_nit.Text & vbCrLf & "NOMBRE Ó RAZON SOCIAL: " & txt_nombre.Text & vbCrLf & "DIRECCIÓN: " & txt_direccion.Text & vbCrLf & "TELEFONO: " & txt_telefono.Text, MsgBoxStyle.YesNo, "INVENTARIO") = MsgBoxResult.Yes Then
                objprovee.crear_proveedor(txt_nit.Text, txt_nombre.Text, txt_tdocu.Text, txt_telefono.Text, txt_direccion.Text, Nothing, estado)
                If MsgBox("Proveedor Creado. ¿Desea añadir mas informacion del Proveedor?", MsgBoxStyle.YesNo, "INVENTARIO") = MsgBoxResult.Yes Then
                    objprovee._numdocumento = txt_nit.Text
                    objprovee.consultar_id_con_nit(txt_nit.Text)
                    txt_id.Text = objprovee._idproveedor
                    inhabilitarcampos()
                    Dim provee As New Crear_Proveedor
                    provee.Show()
                Else
                    If objprovee.consultar_id_con_nit(txt_nit.Text) = True Then
                        txt_id.Text = objprovee._idproveedor
                        inhabilitarcampos()
                    End If
                End If
            Else
            End If
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        dg_buscarnit.Visible = False
        p_salir_buscarcliente.Visible = False
        PanelBuscar_producto.Visible = True
        p_salir.Visible = True
        r_nombre.Checked = True
        cb_producto.Focus()
        cb_producto.Text = Nothing
        txt_cantidad.Text = Nothing
        txt_existencias.Text = Nothing
        txt_valor.Text = Nothing
    End Sub

    Private Sub p_salir_Click(sender As Object, e As EventArgs) Handles p_salir.Click
        PanelBuscar_producto.Visible = False
        p_salir.Visible = False
        dg_buscarproducto.Visible = False
    End Sub

    Private Sub cb_producto_TextChanged(sender As Object, e As EventArgs) Handles cb_producto.TextChanged
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If cb_producto.Text = Nothing Then
            MsgBox("El campo Producto esta vacio", MsgBoxStyle.Information, "INVENTARIO")
        ElseIf txt_cantidad.Text = Nothing Or txt_cantidad.Text = "0" Then
            MsgBox("El campo Cantidad esta vacio ó es cero", MsgBoxStyle.Information, "INVENTARIO")
        ElseIf txt_valor.Text = Nothing Then
            MsgBox("El campo Precio esta vacio", MsgBoxStyle.Information, "INVENTARIO")

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
                txt_cantidad.Text = Nothing
        End If
    End Sub
    Private Sub dg_buscarproducto_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_buscarproducto.CellMouseDoubleClick
        Dim seleccionada As Integer
        Dim nompro As String
        seleccionada = CType(sender, DataGridView).CurrentRow.Index
        nompro = dg_buscarproducto.Rows(seleccionada).Cells(0).Value()
        cb_producto.Text = nompro
        objproductos.obtener_idproducto_connombre_o_ref(criterio, cb_producto.Text)
        objproductos.obtenercantidad()
        txt_existencias.Text = objproductos._cantidad
        txt_cantidad.Focus()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim si As Integer = 0
        If txt_numfactura.Text = Nothing Then
            MsgBox("El campo Factura esta vacio", MsgBoxStyle.Information, "INVENTARIO")
        ElseIf txt_id.Text = Nothing Then
            MsgBox("No ha seleccionado un Cliente", MsgBoxStyle.Information, "INVENTARIO")
            txt_nit.Focus()
        Else
            If Me.dg_productosventa.RowCount <> 0 Then
                Try
                    Dim cantidadproductos As Integer = Me.dg_productosventa.RowCount
                    Dim vtot As Integer = Val(txt_total.Text)
                    Dim viv As Integer = Val(txt_iva.Text)
                    'objventas.obteneridventa()
                    objcon.conn.Open()
                    objcon.trans = objcon.conn.BeginTransaction()
                    objcon.cmd.CommandType = CommandType.Text
                    objcon.cmd.Connection = objcon.conn
                    Dim estado As Integer = 1
                    'objventas.CrearVenta(Val(txt_numfactura.Text), txt_fecha.Text, vtot, viv, Val(txt_id.Text), objvendedor._idvendedor)
                    objcon.cmd.CommandText = "INSERT INTO factura_compra(numero_factura,fecha_expedicion,valor_total_compra,valor_total_iva,estado,proveedor_idproveedor) VALUES (" & txt_numfactura.Text & " , '" & txt_fecha.Text & "', " & vtot & "," & viv & "," & estado & "," & Val(txt_id.Text) & ")"
                    objcon.cmd.Transaction = objcon.trans
                    objcon.cmd.ExecuteNonQuery()
                    objcon.cmd.CommandText = "SELECT idfactura_compra FROM factura_compra ORDER BY idfactura_compra DESC LIMIT 1 FOR UPDATE"
                    objcon.cmd.Transaction = objcon.trans
                    objcompra._idcompra = objcon.cmd.ExecuteScalar()
                    For i = 0 To cantidadproductos - 1
                        objproductos._idproducto = Me.dg_productosventa.Rows(i).Cells(0).Value()
                        Dim cant_vendida As Integer = Me.dg_productosventa.Rows(i).Cells(4).Value()
                        Dim val_unit As Integer = Me.dg_productosventa.Rows(i).Cells(5).Value()
                        objproductos._cantidad = Me.dg_productosventa.Rows(i).Cells(7).Value()
                        'objproductos.obtenercantidad()
                        objproductos._cantidad += cant_vendida
                        'objcon.increment += 1
                        objcon.cmd.CommandText = "insert into productos_compra(cantidad,valor,estado,factura_compra_idfactura_compra,producto_idproducto) values(" & cant_vendida & "," & val_unit & ",'" & estado & "'," & objcompra._idcompra & ",'" & objproductos._idproducto & "')"
                        objcon.cmd.Transaction = objcon.trans
                        objcon.cmd.ExecuteNonQuery()
                        objcon.cmd.CommandText = "UPDATE producto SET cantidad=" & objproductos._cantidad & " WHERE idproducto='" & objproductos._idproducto & "'"
                        objcon.cmd.Transaction = objcon.trans
                        objcon.cmd.ExecuteNonQuery()
                    Next
                    If MsgBox("Confirma la Compra con los siguientes datos:" & vbCrLf & "PROVEEDOR: " & txt_nombre.Text & vbCrLf & "VALOR TOTAL: " & txt_total.Text, MsgBoxStyle.YesNo, "INVENTARIO") = MsgBoxResult.Yes Then
                        objcon.trans.Commit()
                        MsgBox("COMPRA EXITOSA", MsgBoxStyle.Information, "INVENTARIO")
                        objcon.conn.Close()
                        Me.Close()
                    Else
                        MsgBox("Compra Cancelada", MsgBoxStyle.Information, "INVENTARIO")
                    End If
                Catch ex As System.Data.Odbc.OdbcException
                    objcon.trans.Rollback()
                    objcon.conn.Close()
                    MsgBox("No se pudo ejecutar la transacción!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error en la transacción")
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Detalles del error")

                End Try
            Else
                MsgBox("No Ha Agregado Productos a la Venta", MsgBoxStyle.Critical, "INVENTARIO")
        End If
        End If
    End Sub

    Private Sub dg_productosventa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_productosventa.CellContentClick
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
End Class