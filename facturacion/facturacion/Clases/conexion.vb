'librerias utilizadas para el trabajo con ODBC
Imports System.Data
Imports System.Data.Odbc
Imports System
Imports System.IO
Public Class conexion
    Sub VariasTrans()
        Try
            conn.Open()
            'Crear un arreglo de memoria y cargar en cada vector las consultas separadas por punto y coma
          
            trans = conn.BeginTransaction
            MsgBox(listquerys.Length.ToString)
            For i = 0 To listquerys.Length
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                cmd.Transaction = trans
                cmd.CommandText = listquerys(i)
                MsgBox("en ciclo" & listquerys(i).ToString)
                cmd.ExecuteNonQuery()
            Next
            trans.Commit()
            conn.Close()
            MsgBox("Transacción Finalizada con Exito!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Transacción Procesada")
        Catch ex As Exception
            trans.Rollback()
            conn.Close()
            MsgBox("No se pudo ejecutar la transacción!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error en la transacción")
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Detalles del error")

        End Try
    End Sub
    'Variables globales utilizadas en todo el programas
    Public conn As New OdbcConnection("dsn=jaferro")
    Public cmd As New OdbcCommand
    Public lector As Odbc.OdbcDataReader
    Public trans As OdbcTransaction
    Public listquerys As String
    Public increment As Integer = 0
    'procedimiento que abre un OdbcConnection
    Public Sub conectarse()
        Try
            conn.Open()
            'MsgBox("Conexion Correcta")
        Catch ex As Exception
            MsgBox("NO SE PUDO CONECTAR AL SERVIDOR" & ex.ToString, MsgBoxStyle.Information)
        End Try
    End Sub
    'procedimiento que Cierra un OdbcConnection
    Public Sub desconectarse()
        Try
            conn.Close()
            'MsgBox("DesConexion Correcta")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try
    End Sub
End Class
