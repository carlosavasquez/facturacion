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
End Class
