Imports System
Imports System.Windows.Forms
Public Class funciones_varias
    Inherits System.Windows.Forms.Form
    Sub comprueba_numeros(e)
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")> _
    Private Shared Sub ReleaseCapture()
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")> _
    Private Shared Sub SendMessage( _
            ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, _
            ByVal wParam As Integer, ByVal lParam As Integer _
            )
    End Sub
    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&
    Public Sub moverForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub
End Class
