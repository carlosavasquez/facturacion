'librerias utilizadas para el trabajo con ODBC
Imports System.Data
Imports System.Data.Odbc
Imports System
Imports System.IO
Public Class conexion
    'Variables globales utilizadas en todo el programas
    Public conn As New OdbcConnection("dsn=jaferro")
    Public iva, subt, tot, tot_remision As Integer
    Public ivamarica As Integer
    Public cmd As New OdbcCommand
    Public cmd1 As New OdbcCommand
    Public cmd2 As New OdbcCommand
    Public dr As OdbcDataReader
    Public dr1 As OdbcDataReader
    Public dr2 As OdbcDataReader
    Public sql As String = ""
    Public sql1 As String = ""
    Public sql2 As String = ""
    Public nomoperador As String
    Public fechaventa As String
    Public id_operador As Integer
    Public id_metodopago As Integer
    Public id_metodopagoventa As Integer
    Public id_proveedor As Integer
    Public idremision As Integer
    Public idcompra As Integer = 0

    Public modoventa As Integer
    Public modoremision As Integer
    Public idventa As Integer
    Public montocompra As Integer = 0
    Public montoventa As Integer = 0
    Public montoremision As Integer = 0
    Public descuento_venta As Integer = 0
    Public cantidad_producto_compra As Integer
    Public validar_si_guardo_compra_temporal As Integer = 0
    Public validar_si_guardo_venta_temporal As Integer = 0
    Public recibido As String

    'procedimiento que abre un OdbcConnection
    Public Sub conectarse()
        Try
            conn.Open()
            'MsgBox("Conexion Correcta")
        Catch ex As Exception
            MsgBox("NO SE PUDO CONECTAR AL SERVIDOR       " & ex.ToString, MsgBoxStyle.Information)

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
