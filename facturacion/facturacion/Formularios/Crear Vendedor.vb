Public Class Crear_Vendedor
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
    Dim objvendedor As New Vendedor
    Dim objfuncionesvarias As New funciones_varias
    Dim estado As String = "1"
    Sub habilitarcampos()
        txt_nombre.Enabled = True
        txt_dir.Enabled = True
        txt_email.Enabled = True
        txt_numdocu.Enabled = True
        txt_telefono.Enabled = True
    End Sub
    Sub inhabilitarcampos()
        txt_nombre.Enabled = False
        txt_dir.Enabled = False
        txt_email.Enabled = False
        txt_numdocu.Enabled = False
        txt_telefono.Enabled = False
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

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_nombre.Text = Nothing Then
            MsgBox("El campo Nombre esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_numdocu.Text = Nothing Then
            MsgBox("El campo Numero Identificacion esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_telefono.Text = Nothing Then
            MsgBox("El campo Telefono esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_dir.Text = Nothing Then
            MsgBox("El campo Direccion esta vacio", MsgBoxStyle.Information, "JAFERRO")
        ElseIf txt_email.Text = Nothing Then
            MsgBox("El campo E-Mail esta vacio", MsgBoxStyle.Information, "JAFERRO")
        Else
            If objvendedor._idvendedor = 0 Then
                'si es 0 es por que se esta creando un usuario nuevo
                Dim estado As String = "1"
                If MsgBox("Confirma la creacion del Vendedor con los siguientes datos:" & vbCrLf & "NOMBRE: " & txt_nombre.Text & vbCrLf & "NUMERO DE DOCUMENTO: " & txt_numdocu.Text & vbCrLf & "TELEFONO: " & txt_telefono.Text & vbCrLf & "DIRECCION: " & txt_dir.Text & vbCrLf & "E-MAIL: " & txt_email.Text, MsgBoxStyle.YesNo, "INVENTARIO") = MsgBoxResult.Yes Then
                    objvendedor.CrearVendedor(txt_numdocu.Text, txt_nombre.Text, txt_telefono.Text, txt_dir.Text, txt_email.Text)
                    MsgBox("Vendedor Creado Exitosamente", MsgBoxStyle.Information, "INVENTARIO")
                    Me.Close()
                Else
                    MsgBox("Ha cancelado la Operación", MsgBoxStyle.Information, "INVENTARIO")
                End If
            Else
                'de lo contrario he seleccionado algun proveedor existente por lo cual estaré editando
                objvendedor.editarvendedor(txt_numdocu.Text, txt_nombre.Text, txt_telefono.Text, txt_dir.Text, txt_email.Text, estado)
                MsgBox("Vendedor Editado", MsgBoxStyle.Information, "INVENTARIO")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        habilitarcampos()
        txt_nombre.Focus()
        btn_nuevo.Enabled = False
        btn_nuevo.Image = My.Resources.nuevoBN
        btn_editar.Image = My.Resources.editarBN
        btn_guardar.Image = My.Resources.Save
        btn_guardar.Enabled = True
        btn_eliminar.Visible = False
        Label9.Visible = False
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        txt_nombre.Focus()
        btn_guardar.Image = My.Resources.Save
        btn_editar.Image = My.Resources.editarBN
        btn_nuevo.Image = My.Resources.nuevoBN
        btn_guardar.Enabled = True
        btn_guardar.Image = My.Resources.actualizar
        label_guar.Text = "Actualizar"
        label_guar.Location = New Point(243, 289)
        btn_buscar.Visible = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        estado = "0"
        If MsgBox("Si desactiva este Vendedor, no podra utilizarlos en sus Ventas. ¿Desea Desactivarlo?", MsgBoxStyle.YesNo, "INVENTARIO") = MsgBoxResult.Yes Then
            objvendedor.editarvendedor(txt_numdocu.Text, txt_nombre.Text, txt_telefono.Text, txt_dir.Text, txt_email.Text, estado)
            MsgBox("Vendedor Desactivado", MsgBoxStyle.Information, "INVENTARIO")
            Me.Close()
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        P_BUSCAR.Visible = True
        btn_cerrarpanel.Visible = True
        txt_busqueda.Focus()
    End Sub

    Private Sub dg_buscarprovee_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_buscarprovee.CellMouseDoubleClick
        Dim seleccionada As Integer
        Dim idenvendedor As String
        seleccionada = CType(sender, DataGridView).CurrentRow.Index
        idenvendedor = dg_buscarprovee.Rows(seleccionada).Cells(1).Value()
        objvendedor.obtener_datos_con_nit(idenvendedor, "identificacion")
        txt_email.Text = objvendedor._email
        txt_numdocu.Text = objvendedor._numdocumento
        txt_nombre.Text = objvendedor._nombre
        txt_telefono.Text = objvendedor._telefono
        txt_dir.Text = objvendedor._direccion
        Dim estado As Integer = objvendedor._estado
        If estado = 1 Then
            btn_eliminar.Image = My.Resources.Personal_desactivado
            btn_eliminar.Enabled = True
            Label9.Text = "Desactivar"
            Label9.Location = New Point(298, 289)
        ElseIf estado = 0 Then
            btn_eliminar.Image = My.Resources.Personal_activado
            btn_eliminar.Enabled = True
            Label9.Text = "Activar"
            Label9.Location = New Point(305, 289)
        End If
        txt_nombre.Focus()
        P_BUSCAR.Visible = False
        btn_cerrarpanel.Visible = False
        habilitarcampos()
    End Sub

    Private Sub txt_busqueda_TextChanged(sender As Object, e As EventArgs) Handles txt_busqueda.TextChanged
        Dim criterio As String = "identificacion"
        If r_nombre.Checked Then
            criterio = "nombre"
        ElseIf r_nit.Checked Then
            criterio = "identificacion"
        End If
        dg_buscarprovee.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_buscarprovee.DataSource = objvendedor.consultar_con_criterio(txt_busqueda.Text, criterio)
        dg_buscarprovee.Columns(0).HeaderText = "NOMBRE"
        dg_buscarprovee.Columns(0).Width = 200
        dg_buscarprovee.Columns(1).HeaderText = "NIT/CC"
        dg_buscarprovee.Columns(1).Width = 138
    End Sub
    Private Sub btn_cerrarpanel_Click(sender As Object, e As EventArgs) Handles btn_cerrarpanel.Click
        P_BUSCAR.Visible = False
        btn_cerrarpanel.Visible = False
    End Sub
End Class