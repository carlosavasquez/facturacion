Public Class Clase_Login
    Inherits conexion
    Public Function Valores(ByVal usuario As String, ByVal pass As String)
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New Odbc.OdbcDataAdapter("select usuario,contrasena from operador", conn)
        da.Fill(dt)
        For Each datarow In dt.Rows
            If usuario = datarow.item(0) And pass = datarow(1) Then
                'If txt_tipo.Text = datarow(2) Then
                conn.Close()
                Return True
            End If
            'End If
        Next
        conn.Close()
        Return False
    End Function
End Class
