Public Class Form1
    

#Region "Moverventana"
    Inherits System.Windows.Forms.Form

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
#End Region
    Dim objcliente As New Cliente
    Dim objfuncionesvarias As New funciones_varias
    Dim estado As String = "1"
    Sub habilitarcampos()
        txt_email.Enabled = True
        txt_nit.Enabled = True
        txt_razon.Enabled = True
        txt_tel.Enabled = True
        txt_tipo.Enabled = True
        txt_dir.Enabled = True
    End Sub
    Sub inhabilitarcampos()
        txt_email.Enabled = False
        txt_nit.Enabled = False
        txt_razon.Enabled = False
        txt_tel.Enabled = False
        txt_tipo.Enabled = False
        txt_dir.Enabled = False
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub barra_MouseMove(sender As Object, e As MouseEventArgs) Handles barra.MouseMove
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub



    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        habilitarcampos()
        txt_razon.Focus()
        btn_nuevo.Enabled = False
        btn_nuevo.Image = My.Resources.nuevoBN
        btn_editar.Image = My.Resources.editarBN
        btn_guardar.Image = My.Resources.Save
        btn_guardar.Enabled = True
        btn_eliminar.Visible = False
        Label9.Visible = False
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        'habilitarcampos()
        txt_razon.Focus()
        btn_guardar.Image = My.Resources.Save
        btn_editar.Image = My.Resources.editarBN
        btn_nuevo.Image = My.Resources.nuevoBN
        btn_guardar.Enabled = True
        btn_guardar.Image = My.Resources.actualizar
        label_guar.Text = "Actualizar"
        label_guar.Location = New Point(318, 316)
        btn_buscar.Visible = True

    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_nit.Text = Nothing Then
            MsgBox("El campo Nit esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_razon.Text = Nothing Then
            MsgBox("El campo Nombre esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_dir.Text = Nothing Then
            MsgBox("El campo Direccion esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_tel.Text = Nothing Then
            MsgBox("El campo Telefono esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_email.Text = Nothing Then
            MsgBox("El campo Telefono esta vacio", MsgBoxStyle.Information, "JAFERRO")
        Else
            If objcliente._idcliente = 0 Then
                'si es 0 es por que se esta creando un usuario nuevo
                Dim estado As String = "1"
                If MsgBox("Confirma la creacion del Proveedor con los siguientes datos:" & vbCrLf & "NIT/CC: " & txt_nit.Text & vbCrLf & "NOMBRE Ó RAZON SOCIAL: " & txt_razon.Text & vbCrLf & "DIRECCIÓN: " & txt_dir.Text & vbCrLf & "TELEFONO: " & txt_tel.Text & vbCrLf & "E-MAIL: " & txt_email.Text, MsgBoxStyle.YesNo, "INVENTARIO") = MsgBoxResult.Yes Then
                    objcliente.crear_cliente(txt_nit.Text, txt_razon.Text, txt_tipo.Text, txt_tel.Text, txt_dir.Text, txt_email.Text, estado)
                    MsgBox("Cliente Creado", MsgBoxStyle.Information, "INVENTARIO")
                    Me.Close()
                Else
                    MsgBox("Ha cancelado la Operación", MsgBoxStyle.Information, "INVENTARIO")
                End If
            Else
                'de lo contrario he seleccionado algun proveedor existente por lo cual estaré editando
                objcliente.editarcliente(txt_nit.Text, txt_razon.Text, txt_tipo.Text, txt_tel.Text, txt_dir.Text, txt_email.Text, estado)
                MsgBox("Cliente Editado", MsgBoxStyle.Information, "INVENTARIO")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        P_BUSCAR.Visible = True
        btn_cerrarpanel.Visible = True
        txt_busqueda.Focus()
    End Sub

    Private Sub txt_busqueda_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda.TextChanged
        Dim criterio As String = "identificacion"
        If r_nombre.Checked Then
            criterio = "nombre_razon_social"
        ElseIf r_nit.Checked Then
            criterio = "identificacion"
        End If
        dg_buscarprovee.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_buscarprovee.DataSource = objcliente.consultar_con_criterio(txt_busqueda.Text, criterio)
        dg_buscarprovee.Columns(0).HeaderText = "NOMBRE"
        dg_buscarprovee.Columns(0).Width = 200
        dg_buscarprovee.Columns(1).HeaderText = "NIT/CC"
        dg_buscarprovee.Columns(1).Width = 138

    End Sub
    Private Sub btn_cerrarpanel_Click(sender As Object, e As EventArgs) Handles btn_cerrarpanel.Click
        P_BUSCAR.Visible = False
        btn_cerrarpanel.Visible = False

    End Sub

    Private Sub dg_buscarprovee_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_buscarprovee.CellMouseDoubleClick
        Dim seleccionada As Integer
        Dim nit_provee As String
        seleccionada = CType(sender, DataGridView).CurrentRow.Index
        nit_provee = dg_buscarprovee.Rows(seleccionada).Cells(1).Value()
        objcliente.obtener_datos_con_nit(nit_provee, "identificacion")
        txt_email.Text = objcliente._email
        txt_nit.Text = objcliente._numdocumento
        txt_razon.Text = objcliente._nombre
        txt_tel.Text = objcliente._telefono
        txt_tipo.Text = objcliente._tipodocumento
        txt_dir.Text = objcliente._direccion
        Dim estado As Integer = objcliente._estado
        If estado = 1 Then
            btn_eliminar.Image = My.Resources.Personal_desactivado
            btn_eliminar.Enabled = True
            Label9.Text = "Desactivar"
            Label9.Location = New Point(375, 316)
        ElseIf estado = 0 Then
            btn_eliminar.Image = My.Resources.Personal_activado
            btn_eliminar.Enabled = True
            Label9.Text = "Activar"
            Label9.Location = New Point(383, 316)
        End If
        txt_razon.Focus()
        P_BUSCAR.Visible = False
        btn_cerrarpanel.Visible = False
        habilitarcampos()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        estado = "0"
        If MsgBox("Si desactiva este proveedor, no podra utilizarlos en sus comprar. ¿Desea Desactivarlo?", MsgBoxStyle.YesNo, "INVENTARIO") = MsgBoxResult.Yes Then
            objcliente.editarcliente(txt_nit.Text, txt_razon.Text, txt_tipo.Text, txt_tel.Text, txt_dir.Text, txt_email.Text, estado)
            MsgBox("Cliente Desactivado", MsgBoxStyle.Information, "INVENTARIO")
            Me.Close()
        End If
    End Sub
    Private Sub txt_nit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nit.KeyPress
        objfuncionesvarias.comprueba_numeros(e)
    End Sub
    Private Sub txt_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tel.KeyPress
        objfuncionesvarias.comprueba_numeros(e)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inhabilitarcampos()
        r_nombre.Checked = True
        txt_tipo.SelectedIndex = 0
    End Sub
End Class
