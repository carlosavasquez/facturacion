<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Producto
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_iva = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_precio2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_precio1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_precio3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Check_servicio = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cod_barras = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ref = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ubicacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label_guar = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.P_BUSCAR = New System.Windows.Forms.Panel()
        Me.txt_busqueda = New System.Windows.Forms.TextBox()
        Me.r_REF = New System.Windows.Forms.RadioButton()
        Me.r_nombre = New System.Windows.Forms.RadioButton()
        Me.dg_buscarprovee = New System.Windows.Forms.DataGridView()
        Me.btn_cerrarpanel = New System.Windows.Forms.PictureBox()
        Me.btn_eliminar = New System.Windows.Forms.PictureBox()
        Me.btn_editar = New System.Windows.Forms.PictureBox()
        Me.btn_nuevo = New System.Windows.Forms.PictureBox()
        Me.btn_guardar = New System.Windows.Forms.PictureBox()
        Me.btn_buscar = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.barra = New System.Windows.Forms.PictureBox()
        Me.P_BUSCAR.SuspendLayout()
        CType(Me.dg_buscarprovee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrarpanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_iva
        '
        Me.txt_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_iva.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_iva.FormattingEnabled = True
        Me.txt_iva.Items.AddRange(New Object() {"0", "16"})
        Me.txt_iva.Location = New System.Drawing.Point(118, 308)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(72, 29)
        Me.txt_iva.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(185, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(229, 32)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "NUEVO PRODUCTO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(329, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 21)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Precio 2:"
        '
        'txt_precio2
        '
        Me.txt_precio2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio2.Location = New System.Drawing.Point(408, 129)
        Me.txt_precio2.Name = "txt_precio2"
        Me.txt_precio2.Size = New System.Drawing.Size(115, 29)
        Me.txt_precio2.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(329, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 21)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Precio 1:"
        '
        'txt_precio1
        '
        Me.txt_precio1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio1.Location = New System.Drawing.Point(408, 85)
        Me.txt_precio1.Name = "txt_precio1"
        Me.txt_precio1.Size = New System.Drawing.Size(115, 29)
        Me.txt_precio1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(329, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 21)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Precio 3:"
        '
        'txt_precio3
        '
        Me.txt_precio3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio3.Location = New System.Drawing.Point(408, 173)
        Me.txt_precio3.Name = "txt_precio3"
        Me.txt_precio3.Size = New System.Drawing.Size(115, 29)
        Me.txt_precio3.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 21)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Iva:"
        '
        'Check_servicio
        '
        Me.Check_servicio.AutoSize = True
        Me.Check_servicio.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_servicio.Location = New System.Drawing.Point(237, 312)
        Me.Check_servicio.Name = "Check_servicio"
        Me.Check_servicio.Size = New System.Drawing.Size(87, 25)
        Me.Check_servicio.TabIndex = 6
        Me.Check_servicio.Text = "Servicio"
        Me.Check_servicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check_servicio.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 21)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Cod. Barras:"
        '
        'txt_cod_barras
        '
        Me.txt_cod_barras.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_barras.Location = New System.Drawing.Point(118, 220)
        Me.txt_cod_barras.Name = "txt_cod_barras"
        Me.txt_cod_barras.Size = New System.Drawing.Size(199, 29)
        Me.txt_cod_barras.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Descripcion:"
        '
        'txt_descrip
        '
        Me.txt_descrip.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descrip.Location = New System.Drawing.Point(333, 244)
        Me.txt_descrip.Multiline = True
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_descrip.Size = New System.Drawing.Size(199, 90)
        Me.txt_descrip.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Marca:"
        '
        'txt_marca
        '
        Me.txt_marca.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_marca.Location = New System.Drawing.Point(118, 176)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(199, 29)
        Me.txt_marca.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Referencia:"
        '
        'txt_ref
        '
        Me.txt_ref.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ref.Location = New System.Drawing.Point(118, 132)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Size = New System.Drawing.Size(199, 29)
        Me.txt_ref.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(118, 88)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(199, 29)
        Me.txt_nombre.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Ubicacion:"
        '
        'txt_ubicacion
        '
        Me.txt_ubicacion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ubicacion.Location = New System.Drawing.Point(118, 264)
        Me.txt_ubicacion.Name = "txt_ubicacion"
        Me.txt_ubicacion.Size = New System.Drawing.Size(199, 29)
        Me.txt_ubicacion.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(350, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Desactivar"
        '
        'label_guar
        '
        Me.label_guar.AutoSize = True
        Me.label_guar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_guar.Location = New System.Drawing.Point(300, 354)
        Me.label_guar.Name = "label_guar"
        Me.label_guar.Size = New System.Drawing.Size(49, 15)
        Me.label_guar.TabIndex = 60
        Me.label_guar.Text = "Guardar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(251, 354)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 15)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Editar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(192, 354)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 15)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Nuevo"
        '
        'P_BUSCAR
        '
        Me.P_BUSCAR.BackColor = System.Drawing.Color.Gainsboro
        Me.P_BUSCAR.Controls.Add(Me.txt_busqueda)
        Me.P_BUSCAR.Controls.Add(Me.r_REF)
        Me.P_BUSCAR.Controls.Add(Me.r_nombre)
        Me.P_BUSCAR.Controls.Add(Me.dg_buscarprovee)
        Me.P_BUSCAR.Location = New System.Drawing.Point(216, 49)
        Me.P_BUSCAR.Name = "P_BUSCAR"
        Me.P_BUSCAR.Size = New System.Drawing.Size(363, 302)
        Me.P_BUSCAR.TabIndex = 63
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
        'r_REF
        '
        Me.r_REF.AutoSize = True
        Me.r_REF.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.r_REF.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_REF.Location = New System.Drawing.Point(172, 11)
        Me.r_REF.Name = "r_REF"
        Me.r_REF.Size = New System.Drawing.Size(104, 38)
        Me.r_REF.TabIndex = 31
        Me.r_REF.TabStop = True
        Me.r_REF.Text = "REFERENCIA"
        Me.r_REF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.r_REF.UseVisualStyleBackColor = True
        '
        'r_nombre
        '
        Me.r_nombre.AutoSize = True
        Me.r_nombre.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.r_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_nombre.Location = New System.Drawing.Point(87, 11)
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_buscarprovee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dg_buscarprovee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_buscarprovee.DefaultCellStyle = DataGridViewCellStyle8
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
        Me.btn_cerrarpanel.Location = New System.Drawing.Point(578, 30)
        Me.btn_cerrarpanel.Name = "btn_cerrarpanel"
        Me.btn_cerrarpanel.Size = New System.Drawing.Size(20, 20)
        Me.btn_cerrarpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrarpanel.TabIndex = 64
        Me.btn_cerrarpanel.TabStop = False
        Me.btn_cerrarpanel.Visible = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Image = Global.facturacion.My.Resources.Resources.desactivar_producto_BN
        Me.btn_eliminar.Location = New System.Drawing.Point(355, 369)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_eliminar.TabIndex = 57
        Me.btn_eliminar.TabStop = False
        '
        'btn_editar
        '
        Me.btn_editar.Image = Global.facturacion.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(243, 369)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_editar.TabIndex = 56
        Me.btn_editar.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.facturacion.My.Resources.Resources.Nuevo
        Me.btn_nuevo.Location = New System.Drawing.Point(187, 369)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.btn_nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_nuevo.TabIndex = 55
        Me.btn_nuevo.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = Global.facturacion.My.Resources.Resources.saveBN
        Me.btn_guardar.Location = New System.Drawing.Point(299, 369)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 52
        Me.btn_guardar.TabStop = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.facturacion.My.Resources.Resources.Search
        Me.btn_buscar.Location = New System.Drawing.Point(529, 85)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(50, 50)
        Me.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_buscar.TabIndex = 62
        Me.btn_buscar.TabStop = False
        Me.btn_buscar.Visible = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Image = Global.facturacion.My.Resources.Resources.salir
        Me.btn_cerrar.Location = New System.Drawing.Point(568, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(30, 30)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 67
        Me.btn_cerrar.TabStop = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_minimizar.Image = Global.facturacion.My.Resources.Resources.mini2
        Me.btn_minimizar.Location = New System.Drawing.Point(538, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 66
        Me.btn_minimizar.TabStop = False
        '
        'barra
        '
        Me.barra.Image = Global.facturacion.My.Resources.Resources.barra
        Me.barra.Location = New System.Drawing.Point(-8, 0)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(620, 30)
        Me.barra.TabIndex = 65
        Me.barra.TabStop = False
        '
        'Crear_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(599, 427)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.P_BUSCAR)
        Me.Controls.Add(Me.btn_cerrarpanel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.label_guar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ubicacion)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_precio2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_precio1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_precio3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Check_servicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cod_barras)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_descrip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ref)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_buscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Crear_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Producto"
        Me.P_BUSCAR.ResumeLayout(False)
        Me.P_BUSCAR.PerformLayout()
        CType(Me.dg_buscarprovee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrarpanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_iva As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_precio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_precio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_precio3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Check_servicio As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_barras As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_marca As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ubicacion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents label_guar As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_editar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_buscar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_cerrarpanel As System.Windows.Forms.PictureBox
    Friend WithEvents P_BUSCAR As System.Windows.Forms.Panel
    Friend WithEvents txt_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents r_REF As System.Windows.Forms.RadioButton
    Friend WithEvents r_nombre As System.Windows.Forms.RadioButton
    Friend WithEvents dg_buscarprovee As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cerrar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_minimizar As System.Windows.Forms.PictureBox
    Friend WithEvents barra As System.Windows.Forms.PictureBox
End Class
