<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Proveedor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_tipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label_guar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dg_buscarprovee = New System.Windows.Forms.DataGridView()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.P_BUSCAR = New System.Windows.Forms.Panel()
        Me.txt_busqueda = New System.Windows.Forms.TextBox()
        Me.r_nit = New System.Windows.Forms.RadioButton()
        Me.r_nombre = New System.Windows.Forms.RadioButton()
        Me.txt_razon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tip_Botones = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_cerrarpanel = New System.Windows.Forms.PictureBox()
        Me.btn_buscar = New System.Windows.Forms.PictureBox()
        Me.btn_guardar = New System.Windows.Forms.PictureBox()
        Me.btn_eliminar = New System.Windows.Forms.PictureBox()
        Me.btn_editar = New System.Windows.Forms.PictureBox()
        Me.btn_nuevo = New System.Windows.Forms.PictureBox()
        Me.tip_barra = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.barra = New System.Windows.Forms.PictureBox()
        CType(Me.dg_buscarprovee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_BUSCAR.SuspendLayout()
        CType(Me.btn_cerrarpanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CC/NIT"
        '
        'txt_nit
        '
        Me.txt_nit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nit.Location = New System.Drawing.Point(209, 121)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(272, 29)
        Me.txt_nit.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Telefono"
        '
        'txt_tel
        '
        Me.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.Location = New System.Drawing.Point(207, 188)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(272, 29)
        Me.txt_tel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "E-Mail"
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(207, 258)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(272, 29)
        Me.txt_email.TabIndex = 5
        '
        'txt_tipo
        '
        Me.txt_tipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txt_tipo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipo.FormattingEnabled = True
        Me.txt_tipo.Items.AddRange(New Object() {"CC", "NIT", "TI", "PSP"})
        Me.txt_tipo.Location = New System.Drawing.Point(207, 154)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(80, 29)
        Me.txt_tipo.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(217, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Nuevo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(276, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Editar"
        '
        'label_guar
        '
        Me.label_guar.AutoSize = True
        Me.label_guar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_guar.Location = New System.Drawing.Point(325, 316)
        Me.label_guar.Name = "label_guar"
        Me.label_guar.Size = New System.Drawing.Size(49, 15)
        Me.label_guar.TabIndex = 26
        Me.label_guar.Text = "Guardar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(375, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Desactivar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(236, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 32)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "PROVEEDORES"
        '
        'dg_buscarprovee
        '
        Me.dg_buscarprovee.AllowUserToAddRows = False
        Me.dg_buscarprovee.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_buscarprovee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_buscarprovee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_buscarprovee.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_buscarprovee.Location = New System.Drawing.Point(11, 99)
        Me.dg_buscarprovee.Name = "dg_buscarprovee"
        Me.dg_buscarprovee.ReadOnly = True
        Me.dg_buscarprovee.RowHeadersVisible = False
        Me.dg_buscarprovee.Size = New System.Drawing.Size(340, 192)
        Me.dg_buscarprovee.TabIndex = 3
        '
        'txt_dir
        '
        Me.txt_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dir.Location = New System.Drawing.Point(207, 223)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(272, 29)
        Me.txt_dir.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 21)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Direccion"
        '
        'P_BUSCAR
        '
        Me.P_BUSCAR.BackColor = System.Drawing.Color.Gainsboro
        Me.P_BUSCAR.Controls.Add(Me.txt_busqueda)
        Me.P_BUSCAR.Controls.Add(Me.r_nit)
        Me.P_BUSCAR.Controls.Add(Me.r_nombre)
        Me.P_BUSCAR.Controls.Add(Me.dg_buscarprovee)
        Me.P_BUSCAR.Location = New System.Drawing.Point(158, 86)
        Me.P_BUSCAR.Name = "P_BUSCAR"
        Me.P_BUSCAR.Size = New System.Drawing.Size(363, 302)
        Me.P_BUSCAR.TabIndex = 33
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
        'txt_razon
        '
        Me.txt_razon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_razon.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_razon.Location = New System.Drawing.Point(209, 86)
        Me.txt_razon.Name = "txt_razon"
        Me.txt_razon.Size = New System.Drawing.Size(272, 29)
        Me.txt_razon.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 21)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Nombre ó Razon Social"
        '
        'btn_cerrarpanel
        '
        Me.btn_cerrarpanel.Image = Global.facturacion.My.Resources.Resources.salir
        Me.btn_cerrarpanel.Location = New System.Drawing.Point(520, 67)
        Me.btn_cerrarpanel.Name = "btn_cerrarpanel"
        Me.btn_cerrarpanel.Size = New System.Drawing.Size(20, 20)
        Me.btn_cerrarpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrarpanel.TabIndex = 36
        Me.btn_cerrarpanel.TabStop = False
        Me.Tip_Botones.SetToolTip(Me.btn_cerrarpanel, "Boton Cerrrar Panel")
        Me.btn_cerrarpanel.Visible = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.facturacion.My.Resources.Resources.Search
        Me.btn_buscar.Location = New System.Drawing.Point(485, 86)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(50, 50)
        Me.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_buscar.TabIndex = 32
        Me.btn_buscar.TabStop = False
        Me.Tip_Botones.SetToolTip(Me.btn_buscar, "Buscar")
        Me.btn_buscar.Visible = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = Global.facturacion.My.Resources.Resources.saveBN
        Me.btn_guardar.Location = New System.Drawing.Point(324, 331)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.TabStop = False
        Me.Tip_Botones.SetToolTip(Me.btn_guardar, "Guardar Proveedor")
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Image = Global.facturacion.My.Resources.Resources.eliminarBN
        Me.btn_eliminar.Location = New System.Drawing.Point(380, 331)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.TabStop = False
        Me.Tip_Botones.SetToolTip(Me.btn_eliminar, "Desactivar Proveedor")
        '
        'btn_editar
        '
        Me.btn_editar.Image = Global.facturacion.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(268, 331)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_editar.TabIndex = 1
        Me.btn_editar.TabStop = False
        Me.Tip_Botones.SetToolTip(Me.btn_editar, "Editar Proveedor")
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.facturacion.My.Resources.Resources.Nuevo
        Me.btn_nuevo.Location = New System.Drawing.Point(212, 331)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.btn_nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.TabStop = False
        Me.Tip_Botones.SetToolTip(Me.btn_nuevo, "Nuevo Proveedor")
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Image = Global.facturacion.My.Resources.Resources.salir
        Me.btn_cerrar.Location = New System.Drawing.Point(518, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(30, 30)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 23
        Me.btn_cerrar.TabStop = False
        Me.tip_barra.SetToolTip(Me.btn_cerrar, "Cerrar Formulario")
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_minimizar.Image = Global.facturacion.My.Resources.Resources.mini2
        Me.btn_minimizar.Location = New System.Drawing.Point(488, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 22
        Me.btn_minimizar.TabStop = False
        Me.tip_barra.SetToolTip(Me.btn_minimizar, "Minimizar")
        '
        'barra
        '
        Me.barra.Image = Global.facturacion.My.Resources.Resources.barra
        Me.barra.Location = New System.Drawing.Point(0, 0)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(553, 30)
        Me.barra.TabIndex = 21
        Me.barra.TabStop = False
        '
        'Crear_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(548, 410)
        Me.Controls.Add(Me.P_BUSCAR)
        Me.Controls.Add(Me.btn_cerrarpanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_razon)
        Me.Controls.Add(Me.txt_dir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.label_guar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Crear_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Proveedor"
        CType(Me.dg_buscarprovee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_BUSCAR.ResumeLayout(False)
        Me.P_BUSCAR.PerformLayout()
        CType(Me.btn_cerrarpanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barra As System.Windows.Forms.PictureBox
    Friend WithEvents btn_cerrar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_minimizar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_editar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_guardar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents label_guar As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dg_buscarprovee As System.Windows.Forms.DataGridView
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.PictureBox
    Friend WithEvents P_BUSCAR As System.Windows.Forms.Panel
    Friend WithEvents r_nit As System.Windows.Forms.RadioButton
    Friend WithEvents r_nombre As System.Windows.Forms.RadioButton
    Friend WithEvents txt_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents txt_razon As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cerrarpanel As System.Windows.Forms.PictureBox
    Friend WithEvents Tip_Botones As System.Windows.Forms.ToolTip
    Friend WithEvents tip_barra As System.Windows.Forms.ToolTip
End Class
