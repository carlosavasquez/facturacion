Public Class Ventas
    Inherits conexion
    Private numero_factura As Integer
    Private idventa As Integer
    Private fecha_expedicion As String
    Property _numero_factura
        Get
            Return numero_factura
        End Get
        Set(value)
            Me.numero_factura = value
        End Set
    End Property
    Property _idventa
        Get
            Return idventa
        End Get
        Set(value)
            Me.idventa = value
        End Set
    End Property
    Property _fecha_expedicion
        Get
            Return fecha_expedicion
        End Get
        Set(value)
            Me.fecha_expedicion = value
        End Set
    End Property
    Sub obteneridventa()
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT idfactura_venta FROM factura_venta ORDER BY idfactura_venta DESC LIMIT 1 "
        _idventa = cmd.ExecuteScalar
    End Sub
    Function validar_factura(ByVal numero As Integer)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT numero_factura FROM factura_venta"
        lector = cmd.ExecuteReader
        Dim si As Integer
        If lector.HasRows Then
            While lector.Read()
                If numero = lector(0) Then
                    si = 1
                Else
                    si = 0
                End If
            End While
            lector.Close()
            If si = 1 Then
                lector.Close()
                conn.Close()
                Return True
            Else
                lector.Close()
                conn.Close()
                Return False
            End If
            lector.Close()
        Else
            'MsgBox("No hay numeros de facturas")
            conn.Close()
            lector.Close()
            Return True
        End If
    End Function
    Function CrearVenta(ByVal num_factura As Integer, ByVal fecha As String, ByVal valorventa As Integer, ByVal valoriva As Integer, ByVal idcli As Integer, ByVal idvendedor As Integer)
        conn.Open()
        Dim estado As Integer = 1
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "INSERT INTO factura_venta(numero_factura,fecha_expedicion,valor_total_venta,valor_total_iva,estado,cliente_idcliente,vendedor_idvendedor) VALUES "
        cmd.CommandText += "(" & num_factura & " , '" & fecha & "', " & valorventa & "," & valoriva & "," & estado & "," & idcli & "," & idvendedor & ")"
        Dim resultado As Integer = cmd.ExecuteNonQuery()
        If resultado <> 0 Then
            conn.Close()
            Return True
        Else
            conn.Close()
            Return False
        End If
    End Function
End Class
