'librerias utilizadas para el trabajo con ODBC
Imports System.Data
Imports System.Data.Odbc
Imports System
Imports System.IO
Public Class conexion
    'Variables globales utilizadas en todo el programas
    Public conn As New OdbcConnection("dsn=inventario")
    Public cmd As New OdbcCommand
    Public cmd1 As New OdbcCommand
    Public cmd4 As New OdbcCommand
    Public cmd2, cmd5 As New OdbcCommand
    Public lector As Odbc.OdbcDataReader
    Public lector1 As Odbc.OdbcDataReader
    Public trans As OdbcTransaction
    
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
