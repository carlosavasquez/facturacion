Public Class Productos
    Inherits conexion
    Private idproducto As String
    Private nombreproducto As String
    Private tipo_producto As String
    Private referencia As String
    Private marca As String
    Private descripcion As String
    Private precio1 As Integer
    Private precio2 As Integer
    Private precio3 As Integer
    Private iva As Integer
    Private codigo_barras As String
    Private ubicacion As String
    Private estado_producto As String
    Private cantidad As Integer
   
    Function consultar_con_nombre(ByVal busqueda As String, ByVal criterio As String) As List(Of Productos)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT '" & criterio & "' FROM producto WHERE nombre LIKE '%" & busqueda & "%' ORDER BY '" & criterio & "' DESC"
        lector = cmd.ExecuteReader()
        Dim listanombres As New List(Of Productos)
        Dim producto As Productos
        While lector.Read
            producto = New Productos
            producto.nombreproducto = lector(0)
            listanombres.Add(producto)
        End While
        conn.Close()
        Return listanombres
    End Function







End Class
