Public Class Compras
    Inherits conexion
    Private numero_factura As Integer
    Private idcompra As Integer
    Private fecha_expedicion As String
#Region "PROPIEDADES"
    Property _numero_factura
        Get
            Return numero_factura
        End Get
        Set(value)
            Me.numero_factura = value
        End Set
    End Property
    Property _idcompra
        Get
            Return idcompra
        End Get
        Set(value)
            Me.idcompra = value
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
#End Region
End Class
