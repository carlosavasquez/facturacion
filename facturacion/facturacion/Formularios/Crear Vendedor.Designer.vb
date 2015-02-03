<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Vendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crear_Vendedor))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.txt_numdocu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label_guar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_nuevo = New System.Windows.Forms.PictureBox()
        Me.btn_guardar = New System.Windows.Forms.PictureBox()
        Me.btn_eliminar = New System.Windows.Forms.PictureBox()
        Me.btn_editar = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.barra = New System.Windows.Forms.PictureBox()
        Me.P_BUSCAR = New System.Windows.Forms.Panel()
        Me.txt_busqueda = New System.Windows.Forms.TextBox()
        Me.r_nit = New System.Windows.Forms.RadioButton()
        Me.r_nombre = New System.Windows.Forms.RadioButton()
        Me.dg_buscarprovee = New System.Windows.Forms.DataGridView()
        Me.btn_cerrarpanel = New System.Windows.Forms.PictureBox()
        Me.btn_buscar = New System.Windows.Forms.PictureBox()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_BUSCAR.SuspendLayout()
        CType(Me.dg_buscarprovee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrarpanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Save.png")
        Me.ImageList1.Images.SetKeyName(1, "Close_Box_Red.png")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(161, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(226, 32)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "NUEVO VENDEDOR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 238)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 21)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "E-Mail:"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(203, 236)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(273, 29)
        Me.txt_email.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 21)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Direccion:"
        '
        'txt_dir
        '
        Me.txt_dir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dir.Location = New System.Drawing.Point(203, 201)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(273, 29)
        Me.txt_dir.TabIndex = 43
        '
        'txt_numdocu
        '
        Me.txt_numdocu.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numdocu.Location = New System.Drawing.Point(203, 131)
        Me.txt_numdocu.Name = "txt_numdocu"
        Me.txt_numdocu.Size = New System.Drawing.Size(273, 29)
        Me.txt_numdocu.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 21)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Telefono:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(203, 166)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(273, 29)
        Me.txt_telefono.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 21)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Numero de Documento:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(204, 96)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(272, 29)
        Me.txt_nombre.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(325, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Desactivar"
        '
        'label_guar
        '
        Me.label_guar.AutoSize = True
        Me.label_guar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_guar.Location = New System.Drawing.Point(275, 289)
        Me.label_guar.Name = "label_guar"
        Me.label_guar.Size = New System.Drawing.Size(49, 15)
        Me.label_guar.TabIndex = 74
        Me.label_guar.Text = "Guardar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(226, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Editar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Nuevo"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.facturacion.My.Resources.Resources.Nuevo
        Me.btn_nuevo.Location = New System.Drawing.Point(162, 304)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.btn_nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_nuevo.TabIndex = 68
        Me.btn_nuevo.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = Global.facturacion.My.Resources.Resources.saveBN
        Me.btn_guardar.Location = New System.Drawing.Point(274, 304)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 71
        Me.btn_guardar.TabStop = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Image = Global.facturacion.My.Resources.Resources.Personal_desactivado_BN
        Me.btn_eliminar.Location = New System.Drawing.Point(330, 304)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_eliminar.TabIndex = 70
        Me.btn_eliminar.TabStop = False
        '
        'btn_editar
        '
        Me.btn_editar.Image = Global.facturacion.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(218, 304)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_editar.TabIndex = 69
        Me.btn_editar.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Image = Global.facturacion.My.Resources.Resources.salir
        Me.btn_cerrar.Location = New System.Drawing.Point(518, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(30, 30)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 78
        Me.btn_cerrar.TabStop = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_minimizar.Image = Global.facturacion.My.Resources.Resources.mini2
        Me.btn_minimizar.Location = New System.Drawing.Point(488, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 77
        Me.btn_minimizar.TabStop = False
        '
        'barra
        '
        Me.barra.Image = Global.facturacion.My.Resources.Resources.barra
        Me.barra.Location = New System.Drawing.Point(-7, 0)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(561, 30)
        Me.barra.TabIndex = 76
        Me.barra.TabStop = False
        '
        'P_BUSCAR
        '
        Me.P_BUSCAR.BackColor = System.Drawing.Color.Gainsboro
        Me.P_BUSCAR.Controls.Add(Me.txt_busqueda)
        Me.P_BUSCAR.Controls.Add(Me.r_nit)
        Me.P_BUSCAR.Controls.Add(Me.r_nombre)
        Me.P_BUSCAR.Controls.Add(Me.dg_buscarprovee)
        Me.P_BUSCAR.Location = New System.Drawing.Point(161, 81)
        Me.P_BUSCAR.Name = "P_BUSCAR"
        Me.P_BUSCAR.Size = New System.Drawing.Size(363, 302)
        Me.P_BUSCAR.TabIndex = 79
        Me.P_BUSCAR.Visible = False
        '
        'txt_busqueda
        '
        Me.txt_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_busqueda.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda.Location = New System.Drawing.Point(11, 63)
        Me.txt_busqueda.Name = "txt_busqueda"
        Me.txt_busqueda.Size = New System.Drawing.Size(340, 29)
        Me.txt_busqueda.TabIndex = 36
        '
        'r_nit
        '
        Me.r_nit.AutoSize = True
        Me.r_nit.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.r_nit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_nit.Location = New System.Drawing.Point(190, 11)
        Me.r_nit.Name = "r_nit"
        Me.r_nit.Size = New System.Drawing.Size(67, 38)
        Me.r_nit.TabIndex = 31
        Me.r_nit.TabStop = True
        Me.r_nit.Text = "CC/NIT"
        Me.r_nit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.r_nit.UseVisualStyleBackColor = True
        '
        'r_nombre
        '
        Me.r_nombre.AutoSize = True
        Me.r_nombre.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.r_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_nombre.Location = New System.Drawing.Point(105, 11)
        Me.r_nombre.Name = "r_nombre"
        Me.r_nombre.Size = New System.Drawing.Size(81, 38)
        Me.r_nombre.TabIndex = 30
        Me.r_nombre.TabStop = True
        Me.r_nombre.Text = "NOMBRE"
        Me.r_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.r_nombre.UseVisualStyleBackColor = True
        '
        'dg_buscarprovee
        '
        Me.dg_buscarprovee.AllowUserToAddRows = False
        Me.dg_buscarprovee.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_buscarprovee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_buscarprovee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_buscarprovee.DefaultCellStyle = DataGridViewCellStyle4
        Me.dg_buscarprovee.Location = New System.Drawing.Point(11, 99)
        Me.dg_buscarprovee.Name = "dg_buscarprovee"
        Me.dg_buscarprovee.ReadOnly = True
        Me.dg_buscarprovee.RowHeadersVisible = False
        Me.dg_buscarprovee.Size = New System.Drawing.Size(340, 192)
        Me.dg_buscarprovee.TabIndex = 3
        '
        'btn_cerrarpanel
        '
        Me.btn_cerrarpanel.Image = Global.facturacion.My.Resources.Resources.salir
        Me.btn_cerrarpanel.Location = New System.Drawing.Point(523, 62)
        Me.btn_cerrarpanel.Name = "btn_cerrarpanel"
        Me.btn_cerrarpanel.Size = New System.Drawing.Size(20, 20)
        Me.btn_cerrarpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrarpanel.TabIndex = 80
        Me.btn_cerrarpanel.TabStop = False
        Me.btn_cerrarpanel.Visible = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.facturacion.My.Resources.Resources.Search
        Me.btn_buscar.Location = New System.Drawing.Point(482, 96)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(50, 50)
        Me.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_buscar.TabIndex = 81
        Me.btn_buscar.TabStop = False
        Me.btn_buscar.Visible = False
        '
        'Crear_Vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(548, 396)
        Me.Controls.Add(Me.P_BUSCAR)
        Me.Controls.Add(Me.btn_cerrarpanel)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.label_guar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_dir)
        Me.Controls.Add(Me.txt_numdocu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_buscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Crear_Vendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Vendedor"
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_BUSCAR.ResumeLayout(False)
        Me.P_BUSCAR.PerformLayout()
        CType(Me.dg_buscarprovee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrarpanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents txt_numdocu As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents label_guar As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_guardar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_editar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_cerrar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_minimizar As System.Windows.Forms.PictureBox
    Friend WithEvents barra As System.Windows.Forms.PictureBox
    Friend WithEvents P_BUSCAR As System.Windows.Forms.Panel
    Friend WithEvents txt_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents r_nit As System.Windows.Forms.RadioButton
    Friend WithEvents r_nombre As System.Windows.Forms.RadioButton
    Friend WithEvents dg_buscarprovee As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cerrarpanel As System.Windows.Forms.PictureBox
    Friend WithEvents btn_buscar As System.Windows.Forms.PictureBox
End Class
