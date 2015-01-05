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
    Public Property _fechaalta() As String
        Get
            Return fecha_alta
        End Get
        Set(value As String)
            Me.fecha_alta = value
        End Set
    End Property
    Sub crear_cliente(ByVal iden As String, ByVal nom As String, ByVal tipodoc As String, ByVal tel As String, ByVal dir As String, ByVal email As String, ByVal f_alta As String, ByVal estado As String)
        conn.Open()

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            sql = "INSERT INTO cliente(identificacion,nombre_razon_social,tipo_documento,telefonos,direccion,e_mail,fecha_alta,estado) VALUES ('" & iden & "','" & nom & "','" & tipodoc & "','" & tel & "','" & dir & "','" & email & "','" & fecha_alta & "','" & estado & "')"
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MsgBox("Registro Guardado", MsgBoxStyle.Information, "Nuevo Cliente")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
