Public Class Cliente
    Inherits Persona
    Dim id_cliente As Integer
    Dim fecha_alta As String
    Public Property _idcliente() As String
        Get
            Return id_cliente
        End Get
        Set(value As String)
            Me.id_cliente = value
        End Set
    End Property
    Function crear_cliente(ByVal iden As String, ByVal nom As String, ByVal tipodoc As String, ByVal tel As String, ByVal dir As String, ByVal email As String, ByVal estado As String)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "INSERT INTO cliente(identificacion,nombre_razon_social,tipo_documento,telefonos,direccion,e_mail,estado) VALUES ('" & iden & "','" & nom & "','" & tipodoc & "','" & tel & "','" & dir & "','" & email & "','" & estado & "')"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
            If resultado <> 0 Then
                Return True
            Else
                Return _idcliente
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Function consultar_todos_con_nit(ByVal busqueda As String, ByVal criterio As String)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT  idcliente,nombre_razon_social,tipo_documento,telefonos,direccion FROM cliente WHERE " & criterio & " = '" & busqueda & "'"
        lector = cmd.ExecuteReader
        If lector.HasRows = True Then
            While lector.Read()
                _idcliente = lector(0)
                _nombre = lector(1)
                _tipodocumento = lector(2)
                _telefono = lector(3)
                _direccion = lector(4)
                conn.Close()
                Return True
            End While
        Else
            conn.Close()
            Return False
        End If
        lector.Close()
        conn.Close()
        Return False

    End Function
    Function consultar_nombre_nit(ByVal busqueda As String, ByVal dato As String)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT nombre_razon_social,identificacion FROM cliente WHERE " & dato & " LIKE '%" & busqueda & "%'"
        'MsgBox(cmd.CommandText)
        Dim da = New Odbc.OdbcDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Function consultar_id_con_nit(nit)
        Try
            conn.Open()
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "SELECT idcliente FROM cliente WHERE identificacion='" & nit & "'"
            _idcliente = cmd.ExecuteScalar()
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
            Return False
        End Try
    End Function
End Class
