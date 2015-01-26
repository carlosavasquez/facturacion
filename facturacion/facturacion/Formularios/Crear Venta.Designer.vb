<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Venta
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_tdocu = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg_buscarproducto = New System.Windows.Forms.DataGridView()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_nit = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_sub = New System.Windows.Forms.TextBox()
        Me.dg_buscarnit = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_crear_cliente = New System.Windows.Forms.PictureBox()
        Me.txt_numfactura = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_vendedor = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PanelBuscar_producto = New System.Windows.Forms.Panel()
        Me.cb_producto = New System.Windows.Forms.TextBox()
        Me.txt_existencias = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.ComboBox()
        Me.check_nompro = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.check_referencia = New System.Windows.Forms.CheckBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dg_productosventa = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.PictureBox()
        Me.p_salir_buscarcliente = New System.Windows.Forms.PictureBox()
        Me.p_salir = New System.Windows.Forms.PictureBox()
        Me.btn_guardar = New System.Windows.Forms.PictureBox()
        Me.col_idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_valortotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_existencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_btn_agregar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dg_buscarproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_buscarnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_crear_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBuscar_producto.SuspendLayout()
        CType(Me.dg_productosventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_salir_buscarcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_tdocu
        '
        Me.txt_tdocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_tdocu.FormattingEnabled = True
        Me.txt_tdocu.Items.AddRange(New Object() {"CC", "NIT", "TI", "PSP"})
        Me.txt_tdocu.Location = New System.Drawing.Point(402, 12)
        Me.txt_tdocu.Name = "txt_tdocu"
        Me.txt_tdocu.Size = New System.Drawing.Size(65, 21)
        Me.txt_tdocu.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(338, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 18)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "T. Doc:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(479, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "TOTAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(479, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(479, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "SubTotal"
        '
        'dg_buscarproducto
        '
        Me.dg_buscarproducto.AllowUserToAddRows = False
        Me.dg_buscarproducto.AllowUserToDeleteRows = False
        Me.dg_buscarproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_buscarproducto.Location = New System.Drawing.Point(100, 249)
        Me.dg_buscarproducto.Name = "dg_buscarproducto"
        Me.dg_buscarproducto.ReadOnly = True
        Me.dg_buscarproducto.RowHeadersVisible = False
        Me.dg_buscarproducto.Size = New System.Drawing.Size(570, 205)
        Me.dg_buscarproducto.TabIndex = 149
        Me.dg_buscarproducto.Visible = False
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(684, 0)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(58, 20)
        Me.txt_id.TabIndex = 129
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(654, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Fecha Factura:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(156, 363)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(93, 24)
        Me.txt_fecha.TabIndex = 7
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(224, 39)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(309, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(147, 65)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(185, 20)
        Me.txt_direccion.TabIndex = 3
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(380, 67)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(153, 20)
        Me.txt_telefono.TabIndex = 4
        '
        'txt_nit
        '
        Me.txt_nit.Location = New System.Drawing.Point(105, 12)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(227, 20)
        Me.txt_nit.TabIndex = 0
        '
        'txt_iva
        '
        Me.txt_iva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_iva.Enabled = False
        Me.txt_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_iva.Location = New System.Drawing.Point(571, 345)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(107, 22)
        Me.txt_iva.TabIndex = 125
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(338, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 18)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "Tel:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 18)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Dirección:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "NIT/CC:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 18)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Nombre ó Razon Social:"
        '
        'txt_total
        '
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(571, 367)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(107, 22)
        Me.txt_total.TabIndex = 123
        '
        'txt_sub
        '
        Me.txt_sub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sub.Enabled = False
        Me.txt_sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sub.Location = New System.Drawing.Point(571, 323)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.Size = New System.Drawing.Size(107, 22)
        Me.txt_sub.TabIndex = 124
        '
        'dg_buscarnit
        '
        Me.dg_buscarnit.AllowUserToAddRows = False
        Me.dg_buscarnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_buscarnit.Location = New System.Drawing.Point(368, 26)
        Me.dg_buscarnit.Name = "dg_buscarnit"
        Me.dg_buscarnit.RowHeadersVisible = False
        Me.dg_buscarnit.Size = New System.Drawing.Size(332, 428)
        Me.dg_buscarnit.TabIndex = 0
        Me.dg_buscarnit.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.facturacion.My.Resources.Resources.add_product
        Me.PictureBox1.Location = New System.Drawing.Point(497, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 143
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Crear Cliente")
        '
        'btn_crear_cliente
        '
        Me.btn_crear_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_crear_cliente.Image = Global.facturacion.My.Resources.Resources.add_person
        Me.btn_crear_cliente.Location = New System.Drawing.Point(538, 39)
        Me.btn_crear_cliente.Name = "btn_crear_cliente"
        Me.btn_crear_cliente.Size = New System.Drawing.Size(50, 49)
        Me.btn_crear_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_crear_cliente.TabIndex = 142
        Me.btn_crear_cliente.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btn_crear_cliente, "Crear Cliente")
        '
        'txt_numfactura
        '
        Me.txt_numfactura.BackColor = System.Drawing.SystemColors.Window
        Me.txt_numfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numfactura.Location = New System.Drawing.Point(571, -2)
        Me.txt_numfactura.Name = "txt_numfactura"
        Me.txt_numfactura.Size = New System.Drawing.Size(77, 22)
        Me.txt_numfactura.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(485, 1)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 16)
        Me.Label17.TabIndex = 145
        Me.Label17.Text = "N° Factura:"
        '
        'txt_vendedor
        '
        Me.txt_vendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vendedor.FormattingEnabled = True
        Me.txt_vendedor.Items.AddRange(New Object() {"CC", "NIT", "TI", "PSP"})
        Me.txt_vendedor.Location = New System.Drawing.Point(119, 330)
        Me.txt_vendedor.Name = "txt_vendedor"
        Me.txt_vendedor.Size = New System.Drawing.Size(261, 26)
        Me.txt_vendedor.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(34, 338)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 18)
        Me.Label18.TabIndex = 148
        Me.Label18.Text = "Vendedor:"
        '
        'PanelBuscar_producto
        '
        Me.PanelBuscar_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBuscar_producto.Controls.Add(Me.cb_producto)
        Me.PanelBuscar_producto.Controls.Add(Me.txt_existencias)
        Me.PanelBuscar_producto.Controls.Add(Me.Label16)
        Me.PanelBuscar_producto.Controls.Add(Me.PictureBox1)
        Me.PanelBuscar_producto.Controls.Add(Me.txt_valor)
        Me.PanelBuscar_producto.Controls.Add(Me.check_nompro)
        Me.PanelBuscar_producto.Controls.Add(Me.Label12)
        Me.PanelBuscar_producto.Controls.Add(Me.check_referencia)
        Me.PanelBuscar_producto.Controls.Add(Me.txt_cantidad)
        Me.PanelBuscar_producto.Controls.Add(Me.Label14)
        Me.PanelBuscar_producto.Controls.Add(Me.Label15)
        Me.PanelBuscar_producto.Location = New System.Drawing.Point(100, 89)
        Me.PanelBuscar_producto.Name = "PanelBuscar_producto"
        Me.PanelBuscar_producto.Size = New System.Drawing.Size(570, 160)
        Me.PanelBuscar_producto.TabIndex = 136
        Me.PanelBuscar_producto.Visible = False
        '
        'cb_producto
        '
        Me.cb_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_producto.Location = New System.Drawing.Point(110, 71)
        Me.cb_producto.Name = "cb_producto"
        Me.cb_producto.Size = New System.Drawing.Size(437, 24)
        Me.cb_producto.TabIndex = 146
        '
        'txt_existencias
        '
        Me.txt_existencias.Enabled = False
        Me.txt_existencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_existencias.Location = New System.Drawing.Point(110, 131)
        Me.txt_existencias.Name = "txt_existencias"
        Me.txt_existencias.Size = New System.Drawing.Size(56, 24)
        Me.txt_existencias.TabIndex = 145
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 18)
        Me.Label16.TabIndex = 144
        Me.Label16.Text = "Existencias:"
        '
        'txt_valor
        '
        Me.txt_valor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.FormattingEnabled = True
        Me.txt_valor.Location = New System.Drawing.Point(232, 97)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(124, 26)
        Me.txt_valor.TabIndex = 61
        '
        'check_nompro
        '
        Me.check_nompro.AutoSize = True
        Me.check_nompro.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.check_nompro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_nompro.Location = New System.Drawing.Point(201, 27)
        Me.check_nompro.Name = "check_nompro"
        Me.check_nompro.Size = New System.Drawing.Size(72, 36)
        Me.check_nompro.TabIndex = 51
        Me.check_nompro.Text = "Nombre"
        Me.check_nompro.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(183, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 18)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Valor:"
        '
        'check_referencia
        '
        Me.check_referencia.AutoSize = True
        Me.check_referencia.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.check_referencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_referencia.Location = New System.Drawing.Point(274, 27)
        Me.check_referencia.Name = "check_referencia"
        Me.check_referencia.Size = New System.Drawing.Size(93, 36)
        Me.check_referencia.TabIndex = 52
        Me.check_referencia.Text = "Referencia"
        Me.check_referencia.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(110, 99)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(56, 24)
        Me.txt_cantidad.TabIndex = 56
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 18)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Producto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 18)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Cantidad:"
        '
        'dg_productosventa
        '
        Me.dg_productosventa.AllowUserToAddRows = False
        Me.dg_productosventa.AllowUserToDeleteRows = False
        Me.dg_productosventa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg_productosventa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_productosventa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dg_productosventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productosventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idproducto, Me.col_nombre, Me.col_iva, Me.col_estado, Me.col_cantidad, Me.col_unitario, Me.col_valortotal, Me.col_existencias, Me.col_btn_agregar, Me.col_eliminar})
        Me.dg_productosventa.Location = New System.Drawing.Point(37, 94)
        Me.dg_productosventa.Name = "dg_productosventa"
        Me.dg_productosventa.RowHeadersVisible = False
        Me.dg_productosventa.Size = New System.Drawing.Size(641, 229)
        Me.dg_productosventa.TabIndex = 150
        '
        'btn_add
        '
        Me.btn_add.Image = Global.facturacion.My.Resources.Resources._1421382337_add1_
        Me.btn_add.Location = New System.Drawing.Point(680, 93)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(50, 50)
        Me.btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_add.TabIndex = 151
        Me.btn_add.TabStop = False
        '
        'p_salir_buscarcliente
        '
        Me.p_salir_buscarcliente.Image = Global.facturacion.My.Resources.Resources.salir
        Me.p_salir_buscarcliente.Location = New System.Drawing.Point(700, 1)
        Me.p_salir_buscarcliente.Name = "p_salir_buscarcliente"
        Me.p_salir_buscarcliente.Size = New System.Drawing.Size(25, 25)
        Me.p_salir_buscarcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_salir_buscarcliente.TabIndex = 143
        Me.p_salir_buscarcliente.TabStop = False
        Me.p_salir_buscarcliente.Visible = False
        '
        'p_salir
        '
        Me.p_salir.Image = Global.facturacion.My.Resources.Resources.salir
        Me.p_salir.Location = New System.Drawing.Point(670, 66)
        Me.p_salir.Name = "p_salir"
        Me.p_salir.Size = New System.Drawing.Size(25, 25)
        Me.p_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_salir.TabIndex = 137
        Me.p_salir.TabStop = False
        Me.p_salir.Visible = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_guardar.Image = Global.facturacion.My.Resources.Resources.Actions_document_save_icon
        Me.btn_guardar.Location = New System.Drawing.Point(407, 327)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 139
        Me.btn_guardar.TabStop = False
        '
        'col_idproducto
        '
        Me.col_idproducto.HeaderText = "Id Producto"
        Me.col_idproducto.Name = "col_idproducto"
        '
        'col_nombre
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_nombre.DefaultCellStyle = DataGridViewCellStyle20
        Me.col_nombre.HeaderText = "PRODUCTO"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        Me.col_nombre.Width = 270
        '
        'col_iva
        '
        Me.col_iva.HeaderText = "IVA%"
        Me.col_iva.Name = "col_iva"
        Me.col_iva.Visible = False
        Me.col_iva.Width = 50
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "Estado"
        Me.col_estado.Name = "col_estado"
        Me.col_estado.Visible = False
        '
        'col_cantidad
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.Format = "N0"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.col_cantidad.DefaultCellStyle = DataGridViewCellStyle21
        Me.col_cantidad.HeaderText = "CANTIDAD"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Width = 80
        '
        'col_unitario
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.Format = "C0"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.col_unitario.DefaultCellStyle = DataGridViewCellStyle22
        Me.col_unitario.HeaderText = "V. UNITARIO"
        Me.col_unitario.Name = "col_unitario"
        Me.col_unitario.ReadOnly = True
        Me.col_unitario.Width = 120
        '
        'col_valortotal
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.Format = "C0"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.col_valortotal.DefaultCellStyle = DataGridViewCellStyle23
        Me.col_valortotal.HeaderText = "V. TOTAL"
        Me.col_valortotal.Name = "col_valortotal"
        Me.col_valortotal.ReadOnly = True
        '
        'col_existencias
        '
        DataGridViewCellStyle24.Format = "N0"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.col_existencias.DefaultCellStyle = DataGridViewCellStyle24
        Me.col_existencias.HeaderText = "Existencias"
        Me.col_existencias.Name = "col_existencias"
        '
        'col_btn_agregar
        '
        Me.col_btn_agregar.HeaderText = "Agregar"
        Me.col_btn_agregar.Name = "col_btn_agregar"
        Me.col_btn_agregar.Text = "Agregar"
        Me.col_btn_agregar.ToolTipText = "Boton Agregar"
        Me.col_btn_agregar.UseColumnTextForButtonValue = True
        Me.col_btn_agregar.Visible = False
        Me.col_btn_agregar.Width = 70
        '
        'col_eliminar
        '
        Me.col_eliminar.HeaderText = "Eliminar"
        Me.col_eliminar.Name = "col_eliminar"
        Me.col_eliminar.Text = "Eliminar"
        Me.col_eliminar.ToolTipText = "Boton Eliminar"
        Me.col_eliminar.UseColumnTextForButtonValue = True
        Me.col_eliminar.Width = 70
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(700, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 152
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Crear_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(771, 461)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dg_buscarnit)
        Me.Controls.Add(Me.dg_buscarproducto)
        Me.Controls.Add(Me.PanelBuscar_producto)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.p_salir_buscarcliente)
        Me.Controls.Add(Me.p_salir)
        Me.Controls.Add(Me.dg_productosventa)
        Me.Controls.Add(Me.txt_vendedor)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_numfactura)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_crear_cliente)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_tdocu)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_nit)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_sub)
        Me.Name = "Crear_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Venta"
        CType(Me.dg_buscarproducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_buscarnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_crear_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBuscar_producto.ResumeLayout(False)
        Me.PanelBuscar_producto.PerformLayout()
        CType(Me.dg_productosventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_salir_buscarcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_tdocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_nit As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_sub As System.Windows.Forms.TextBox
    Friend WithEvents p_salir As System.Windows.Forms.PictureBox
    Friend WithEvents btn_guardar As System.Windows.Forms.PictureBox
    Friend WithEvents dg_buscarnit As System.Windows.Forms.DataGridView
    Friend WithEvents btn_crear_cliente As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents p_salir_buscarcliente As System.Windows.Forms.PictureBox
    Friend WithEvents txt_numfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_vendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dg_buscarproducto As System.Windows.Forms.DataGridView
    Friend WithEvents PanelBuscar_producto As System.Windows.Forms.Panel
    Friend WithEvents cb_producto As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents check_nompro As System.Windows.Forms.CheckBox
    Friend WithEvents check_referencia As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dg_productosventa As System.Windows.Forms.DataGridView
    Friend WithEvents txt_valor As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_existencias As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.PictureBox
    Friend WithEvents col_idproducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_valortotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_existencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_btn_agregar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents col_eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
