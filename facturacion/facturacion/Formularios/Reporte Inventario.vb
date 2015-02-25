Public Class Reporte_Inventario
    Dim objcon As New conexion
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        dg_productos.Rows.Clear()
        Dim nom, ref, ubi, cant As String
        objcon.conn.Open()
        objcon.cmd.CommandType = CommandType.Text
        objcon.cmd.Connection = objcon.conn
        objcon.cmd.CommandText = "SELECT nombre,referencia,cantidad,ubicacion FROM producto"
        objcon.lector = objcon.cmd.ExecuteReader()
        If objcon.lector.HasRows Then
            While objcon.lector.Read
                nom = objcon.lector(0)
                ref = objcon.lector(1)
                cant = objcon.lector(2)
                ubi = objcon.lector(3)
                dg_productos.Rows.Insert(0, nom.ToString, ref.ToString, cant.ToString, ubi.ToString)
            End While
            objcon.lector.Close()
            objcon.conn.Close()
        Else
            objcon.lector.Close()
            MsgBox("No hay productos en su inventario", MsgBoxStyle.Information, "INVENTARIO")
            objcon.conn.Close()
        End If
        objcon.conn.Close()
    End Sub
End Class