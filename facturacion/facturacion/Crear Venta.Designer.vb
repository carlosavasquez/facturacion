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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dg_productosventa = New System.Windows.Forms.DataGridView()
        Me.col_idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_valortotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idbodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_btn_agregar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txt_tdocu = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_nit = New System.Windows.Forms.TextBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_sub = New System.Windows.Forms.TextBox()
        Me.PanelBuscar_producto = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_valor = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cb_producto = New System.Windows.Forms.ComboBox()
        Me.btn_agregarpro = New System.Windows.Forms.Button()
        Me.check_nompro = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.check_referencia = New System.Windows.Forms.CheckBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dg_productosventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.PanelBuscar_producto.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_productosventa
        '
        Me.dg_productosventa.AllowUserToDeleteRows = False
        Me.dg_productosventa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg_productosventa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_productosventa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dg_productosventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productosventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idproducto, Me.col_nombre, Me.col_referencia, Me.col_marca, Me.col_descripcion, Me.col_iva, Me.col_estado, Me.col_cantidad, Me.col_unitario, Me.col_descuento, Me.col_valortotal, Me.col_idventa, Me.col_idbodega, Me.col_btn_agregar})
        Me.dg_productosventa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_productosventa.Location = New System.Drawing.Point(3, 17)
        Me.dg_productosventa.Name = "dg_productosventa"
        Me.dg_productosventa.ReadOnly = True
        Me.dg_productosventa.RowHeadersVisible = False
        Me.dg_productosventa.Size = New System.Drawing.Size(631, 229)
        Me.dg_productosventa.TabIndex = 0
        '
        'col_idproducto
        '
        Me.col_idproducto.HeaderText = "Id Producto"
        Me.col_idproducto.Name = "col_idproducto"
        Me.col_idproducto.ReadOnly = True
        Me.col_idproducto.Visible = False
        '
        'col_nombre
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_nombre.DefaultCellStyle = DataGridViewCellStyle21
        Me.col_nombre.HeaderText = "PRODUCTO"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        Me.col_nombre.Width = 270
        '
        'col_referencia
        '
        Me.col_referencia.HeaderText = "Referencia"
        Me.col_referencia.Name = "col_referencia"
        Me.col_referencia.ReadOnly = True
        Me.col_referencia.Visible = False
        '
        'col_marca
        '
        Me.col_marca.HeaderText = "Marca"
        Me.col_marca.Name = "col_marca"
        Me.col_marca.ReadOnly = True
        Me.col_marca.Visible = False
        '
        'col_descripcion
        '
        Me.col_descripcion.HeaderText = "Descripcion"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.ReadOnly = True
        Me.col_descripcion.Visible = False
        '
        'col_iva
        '
        Me.col_iva.HeaderText = "IVA%"
        Me.col_iva.Name = "col_iva"
        Me.col_iva.ReadOnly = True
        Me.col_iva.Visible = False
        Me.col_iva.Width = 50
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "Estado"
        Me.col_estado.Name = "col_estado"
        Me.col_estado.ReadOnly = True
        Me.col_estado.Visible = False
        '
        'col_cantidad
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.Format = "N0"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.col_cantidad.DefaultCellStyle = DataGridViewCellStyle22
        Me.col_cantidad.HeaderText = "CANTIDAD"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.ReadOnly = True
        Me.col_cantidad.Width = 80
        '
        'col_unitario
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.Format = "C0"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.col_unitario.DefaultCellStyle = DataGridViewCellStyle23
        Me.col_unitario.HeaderText = "V. UNITARIO"
        Me.col_unitario.Name = "col_unitario"
        Me.col_unitario.ReadOnly = True
        Me.col_unitario.Width = 120
        '
        'col_descuento
        '
        DataGridViewCellStyle24.Format = "N0"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.col_descuento.DefaultCellStyle = DataGridViewCellStyle24
        Me.col_descuento.HeaderText = "Descuento"
        Me.col_descuento.Name = "col_descuento"
        Me.col_descuento.ReadOnly = True
        Me.col_descuento.Visible = False
        '
        'col_valortotal
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.Format = "C0"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.col_valortotal.DefaultCellStyle = DataGridViewCellStyle25
        Me.col_valortotal.HeaderText = "V. TOTAL"
        Me.col_valortotal.Name = "col_valortotal"
        Me.col_valortotal.ReadOnly = True
        '
        'col_idventa
        '
        Me.col_idventa.HeaderText = "Id Venta"
        Me.col_idventa.Name = "col_idventa"
        Me.col_idventa.ReadOnly = True
        Me.col_idventa.Visible = False
        '
        'col_idbodega
        '
        Me.col_idbodega.HeaderText = "Id Bodega"
        Me.col_idbodega.Name = "col_idbodega"
        Me.col_idbodega.ReadOnly = True
        Me.col_idbodega.Visible = False
        '
        'col_btn_agregar
        '
        Me.col_btn_agregar.HeaderText = ""
        Me.col_btn_agregar.Name = "col_btn_agregar"
        Me.col_btn_agregar.ReadOnly = True
        Me.col_btn_agregar.Width = 50
        '
        'txt_tdocu
        '
        Me.txt_tdocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_tdocu.FormattingEnabled = True
        Me.txt_tdocu.Items.AddRange(New Object() {"CC", "NIT", "TI", "PSP"})
        Me.txt_tdocu.Location = New System.Drawing.Point(406, 68)
        Me.txt_tdocu.Name = "txt_tdocu"
        Me.txt_tdocu.Size = New System.Drawing.Size(65, 21)
        Me.txt_tdocu.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(342, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 18)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "T. Doc:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 450)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Descuento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(417, 428)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "SubTotal"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dg_productosventa)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(637, 249)
        Me.GroupBox4.TabIndex = 130
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PRODUCTOS VENTA"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(569, 1)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(72, 20)
        Me.txt_id.TabIndex = 129
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(539, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "ID:"
        '
        'btn_crear
        '
        Me.btn_crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_crear.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btn_crear.FlatAppearance.BorderSize = 20
        Me.btn_crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btn_crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_crear.Location = New System.Drawing.Point(564, 92)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(52, 52)
        Me.btn_crear.TabIndex = 5
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Fecha Factura:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(168, 400)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(78, 20)
        Me.txt_fecha.TabIndex = 118
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(151, 95)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(386, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(151, 121)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(185, 20)
        Me.txt_direccion.TabIndex = 3
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(384, 123)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(153, 20)
        Me.txt_telefono.TabIndex = 4
        '
        'txt_nit
        '
        Me.txt_nit.Location = New System.Drawing.Point(151, 68)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(185, 20)
        Me.txt_nit.TabIndex = 0
        '
        'txt_descuento
        '
        Me.txt_descuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descuento.Location = New System.Drawing.Point(509, 446)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(107, 22)
        Me.txt_descuento.TabIndex = 126
        '
        'txt_iva
        '
        Me.txt_iva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_iva.Location = New System.Drawing.Point(509, 424)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(107, 22)
        Me.txt_iva.TabIndex = 125
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(342, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 18)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "Tel:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 18)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Dirección:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "NIT/CC:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 18)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Razon Social:"
        '
        'txt_total
        '
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(509, 468)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(107, 22)
        Me.txt_total.TabIndex = 123
        '
        'txt_sub
        '
        Me.txt_sub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sub.Location = New System.Drawing.Point(509, 402)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.Size = New System.Drawing.Size(107, 22)
        Me.txt_sub.TabIndex = 124
        '
        'PanelBuscar_producto
        '
        Me.PanelBuscar_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBuscar_producto.Controls.Add(Me.GroupBox2)
        Me.PanelBuscar_producto.Location = New System.Drawing.Point(200, 57)
        Me.PanelBuscar_producto.Name = "PanelBuscar_producto"
        Me.PanelBuscar_producto.Size = New System.Drawing.Size(388, 203)
        Me.PanelBuscar_producto.TabIndex = 136
        Me.PanelBuscar_producto.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_valor)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.cb_producto)
        Me.GroupBox2.Controls.Add(Me.btn_agregarpro)
        Me.GroupBox2.Controls.Add(Me.check_nompro)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.check_referencia)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 188)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'txt_valor
        '
        Me.txt_valor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_valor.FormattingEnabled = True
        Me.txt_valor.Location = New System.Drawing.Point(96, 118)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(124, 24)
        Me.txt_valor.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(6, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Descuento:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(43, 22)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "0"
        '
        'cb_producto
        '
        Me.cb_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_producto.FormattingEnabled = True
        Me.cb_producto.Location = New System.Drawing.Point(96, 63)
        Me.cb_producto.Name = "cb_producto"
        Me.cb_producto.Size = New System.Drawing.Size(274, 24)
        Me.cb_producto.TabIndex = 3
        '
        'btn_agregarpro
        '
        Me.btn_agregarpro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_agregarpro.Location = New System.Drawing.Point(338, 137)
        Me.btn_agregarpro.Name = "btn_agregarpro"
        Me.btn_agregarpro.Size = New System.Drawing.Size(32, 32)
        Me.btn_agregarpro.TabIndex = 10
        Me.btn_agregarpro.UseVisualStyleBackColor = True
        '
        'check_nompro
        '
        Me.check_nompro.AutoSize = True
        Me.check_nompro.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.check_nompro.Location = New System.Drawing.Point(9, 19)
        Me.check_nompro.Name = "check_nompro"
        Me.check_nompro.Size = New System.Drawing.Size(67, 34)
        Me.check_nompro.TabIndex = 0
        Me.check_nompro.Text = "Nombre"
        Me.check_nompro.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(6, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Valor:"
        '
        'check_referencia
        '
        Me.check_referencia.AutoSize = True
        Me.check_referencia.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.check_referencia.Location = New System.Drawing.Point(82, 19)
        Me.check_referencia.Name = "check_referencia"
        Me.check_referencia.Size = New System.Drawing.Size(88, 34)
        Me.check_referencia.TabIndex = 1
        Me.check_referencia.Text = "Referencia"
        Me.check_referencia.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(96, 90)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(56, 22)
        Me.txt_cantidad.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(6, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Producto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(6, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 16)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Cantidad:"
        '
        'Crear_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 532)
        Me.Controls.Add(Me.PanelBuscar_producto)
        Me.Controls.Add(Me.txt_tdocu)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_nit)
        Me.Controls.Add(Me.txt_descuento)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_sub)
        Me.Name = "Crear_Venta"
        Me.Text = "Crear Venta"
        CType(Me.dg_productosventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.PanelBuscar_producto.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg_productosventa As System.Windows.Forms.DataGridView
    Friend WithEvents txt_tdocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_crear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_nit As System.Windows.Forms.TextBox
    Friend WithEvents txt_descuento As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_sub As System.Windows.Forms.TextBox
    Friend WithEvents col_idproducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_referencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_valortotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idventa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idbodega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_btn_agregar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PanelBuscar_producto As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_valor As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cb_producto As System.Windows.Forms.ComboBox
    Friend WithEvents btn_agregarpro As System.Windows.Forms.Button
    Friend WithEvents check_nompro As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents check_referencia As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
