Public Class Persona
    Inherits conexion
    Dim nombre As String
    Dim apellido As String
    Dim tipo_documento As String
    Dim num_documento As String
    Dim direccion As String
    Dim telefono As String
    Dim email As String
    Dim estado As String

    Public Property _nombre() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            Me.nombre = value
        End Set
    End Property
    Public Property _apellido() As String
        Get
            Return apellido
        End Get
        Set(value As String)
            Me.apellido = value
        End Set
    End Property
    Public Property _tipodocumento() As String
        Get
            Return tipo_documento
        End Get
        Set(value As String)
            Me.tipo_documento = value
        End Set
    End Property
    Public Property _numdocumento() As String
        Get
            Return num_documento
        End Get
        Set(value As String)
            Me.num_documento = value
        End Set
    End Property
    Public Property _direccion() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            Me.direccion = value
        End Set
    End Property
    Public Property _telefono() As String
        Get
            Return telefono
        End Get
        Set(value As String)
            Me.telefono = value
        End Set
    End Property
    Public Property _email() As String
        Get
            Return email
        End Get
        Set(value As String)
            Me.email = value
        End Set
    End Property
    Public Property _estado() As String
        Get
            Return estado
        End Get
        Set(value As String)
            Me.estado = value
        End Set
    End Property
End Class
