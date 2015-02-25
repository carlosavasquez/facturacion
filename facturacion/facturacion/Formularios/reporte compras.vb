Public Class reporte_compras
    Dim objcon As New conexion
    Private Sub reporte_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_desde.Format = DateTimePickerFormat.Custom
        txt_desde.CustomFormat = "yyyy-MM-dd"
        txt_hasta.Format = DateTimePickerFormat.Custom
        txt_hasta.CustomFormat = "yyyy-MM-dd"
        detallado.Checked = True
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim costos As Integer = 0
        Dim val_venta As Integer = 0
        Dim ganancia As Integer = 0
        If detallado.Checked = True Then
            dg.Rows.Clear()
            dg_ventas.Visible = False
            dg.Visible = True
            Dim id_co, cant, val, idpro, valtot As Integer
            Dim nom, fecha As String
            objcon.conn.Open()
            objcon.cmd.CommandType = CommandType.Text
            objcon.cmd.Connection = objcon.conn
            objcon.cmd.CommandText = "SELECT idfactura_compra,fecha_expedicion FROM factura_compra WHERE fecha_expedicion BETWEEN '" & txt_desde.Text & "' AND '" & txt_hasta.Text & "'"
            objcon.lector = objcon.cmd.ExecuteReader()
            If objcon.lector.HasRows Then
                While objcon.lector.Read
                    id_co = objcon.lector(0)
                    fecha = objcon.lector(1)
                    objcon.cmd2.CommandType = CommandType.Text
                    objcon.cmd2.Connection = objcon.conn
                    objcon.cmd2.CommandText = "SELECT cantidad,valor,producto_idproducto FROM productos_compra WHERE factura_compra_idfactura_compra='" & id_co & "'"
                    objcon.lector1 = objcon.cmd2.ExecuteReader()
                    If objcon.lector1.HasRows Then
                        While objcon.lector1.Read
                            cant = objcon.lector1(0)
                            val = objcon.lector1(1)
                            idpro = objcon.lector1(2)
                            objcon.cmd4.CommandType = CommandType.Text
                            objcon.cmd4.Connection = objcon.conn
                            objcon.cmd4.CommandText = "SELECT nombre FROM producto WHERE idproducto='" & idpro & "'"
                            nom = objcon.cmd4.ExecuteScalar()
                            dg.Rows.Insert(0, fecha.ToString, nom.ToString, cant.ToString, val.ToString, valtot.ToString)
                        End While
                        objcon.lector1.Close()
                    Else
                        MsgBox("no hay productos en esta compra" & fecha.ToString, MsgBoxStyle.Information, "INVENTARIO")
                        objcon.lector1.Close()
                    End If
                End While
                objcon.lector.Close()
            Else
                objcon.lector.Close()
                MsgBox("no hay compras en estas fechas", MsgBoxStyle.Information, "INVENTARIO")
            End If
            objcon.conn.Close()
        ElseIf ventas.Checked = True Then
            dg.Visible = False
            dg_ventas.Visible = True
            Dim fechav, nombre As String
            Dim numfact, valortot, idcli As Integer
            objcon.conn.Open()
            objcon.cmd.CommandType = CommandType.Text
            objcon.cmd.Connection = objcon.conn
            objcon.cmd.CommandText = "SELECT fecha_expedicion,numero_factura,valor_total_compra,proveedor_idproveedor FROM factura_compra WHERE fecha_expedicion BETWEEN '" & txt_desde.Text & "' AND '" & txt_hasta.Text & "'"
            objcon.lector = objcon.cmd.ExecuteReader()
            If objcon.lector.HasRows Then
                While objcon.lector.Read
                    fechav = objcon.lector(0)
                    numfact = objcon.lector(1)
                    valortot = objcon.lector(2)
                    idcli = objcon.lector(3)
                    objcon.cmd2.CommandType = CommandType.Text
                    objcon.cmd2.Connection = objcon.conn
                    objcon.cmd2.CommandText = "SELECT nombre_razon_social FROM proveedor WHERE idproveedor='" & idcli & "'"
                    nombre = objcon.cmd2.ExecuteScalar()
                    dg_ventas.Rows.Insert(0, fechav.ToString, numfact.ToString, valortot.ToString, nombre.ToString)
                End While
            Else
                objcon.lector.Close()
                MsgBox("no hay ventas en estas fechas", MsgBoxStyle.Information, "INVENTARIO")
            End If
            objcon.conn.Close()
        End If
    End Sub
    Private Sub detallado_CheckedChanged(sender As Object, e As EventArgs) Handles detallado.CheckedChanged
        If detallado.Checked = True Then
            dg.Visible = True
            dg_ventas.Visible = False
        Else
            dg.Visible = False
            dg_ventas.Visible = True
        End If
    End Sub
    Private Sub ventas_CheckedChanged(sender As Object, e As EventArgs) Handles ventas.CheckedChanged
        If ventas.Checked = True Then
            dg_ventas.Visible = True
            dg.Visible = False
        Else
            dg_ventas.Visible = False
            dg.Visible = True
        End If
    End Sub
End Class