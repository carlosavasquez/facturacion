Public Class Vendedor
    Inherits Persona
    Private idvendedor As Integer
    Property _idvendedor
        Get
            Return idvendedor
        End Get
        Set(value)
            Me.idvendedor = value
        End Set
    End Property
    Sub editarvendedor(ByVal iden As String, ByVal nom As String, ByVal tel As String, ByVal dir As String, ByVal email As String, ByVal estado As String)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "UPDATE vendedor SET identificacion='" & iden & "',nombre='" & nom & "',telefonos='" & tel & "',direccion='" & dir & "',e_mail='" & email & "',estado='" & estado & "' WHERE idvendedor='" & _idvendedor & "'"
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub obtenerid(ByVal nom As String )
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.Transaction = trans
        cmd.CommandText = "SELECT idvendedor FROM vendedor WHERE nombre='" & nom & "'"
        'Dim SLQ_obtenerid = "SELECT idvendedor FROM vendedor WHERE nombre='" & nom & "'"
        _idvendedor = cmd.ExecuteScalar()
        'listquerys(0) = SLQ_obtenerid
        conn.Close()
    End Sub
    Function obtenervendedor()
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT nombre FROM vendedor"
        lector = cmd.ExecuteReader()
        Dim lista As New ArrayList
        While lector.Read
            lista.Add(lector(0))
        End While
        conn.Close()
        Return lista
    End Function
    Function CrearVendedor(ByVal identi As String, ByVal nom As String, ByVal tel As String, ByVal dir As String, ByVal email As String)
        conn.Open()
        Dim estado As Integer = 1
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "INSERT INTO vendedor(identificacion,nombre,telefonos,direccion,e_mail,estado) VALUES ('" & identi & "','" & nom & "','" & tel & "','" & dir & "','" & email & "'," & estado & ")"
        Dim resultado As String = cmd.ExecuteNonQuery()
        conn.Close()
        If resultado <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function obtener_datos_con_nit(ByVal dato As String, ByVal criterio As String)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT idvendedor,identificacion,nombre,telefonos,direccion,e_mail,estado FROM vendedor WHERE " & criterio & " = '" & dato & "'"
        lector = cmd.ExecuteReader()
        If lector.HasRows Then
            While lector.Read
                _idvendedor = lector(0)
                _numdocumento = lector(1)
                _nombre = lector(2)
                _telefono = lector(3)
                _direccion = lector(4)
                _email = lector(5)
                _estado = lector(6)
                conn.Close()
                Return True
            End While
            conn.Close()
        Else
            'MsgBox("ha Ocurrido un error al elegir el proveedor. Profavor Vueva a Seleccionarlo", MsgBoxStyle.Information, "Inventario")
            lector.Close()
            conn.Close()
            Return False
        End If
        lector.Close()
        conn.Close()
        Return False
    End Function
    Function consultar_con_criterio(ByVal busqueda As String, ByVal dato As String)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT nombre,identificacion FROM vendedor WHERE " & dato & " LIKE '%" & busqueda & "%'"
        'MsgBox(cmd.CommandText)
        Dim da = New Odbc.OdbcDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
End Class
