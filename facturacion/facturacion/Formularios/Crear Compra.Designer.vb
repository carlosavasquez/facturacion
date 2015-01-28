<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crear_Compra))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_numfactura = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_nit = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_crear_cliente = New System.Windows.Forms.PictureBox()
        Me.btn_add = New System.Windows.Forms.PictureBox()
        Me.dg_productosventa = New System.Windows.Forms.DataGridView()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.barra = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_sub = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
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
        Me.btn_guardar = New System.Windows.Forms.PictureBox()
        Me.p_salir_buscarcliente = New System.Windows.Forms.PictureBox()
        Me.dg_buscarnit = New System.Windows.Forms.DataGridView()
        CType(Me.btn_crear_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_productosventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_salir_buscarcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_buscarnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_numfactura
        '
        Me.txt_numfactura.BackColor = System.Drawing.SystemColors.Window
        Me.txt_numfactura.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numfactura.Location = New System.Drawing.Point(451, 40)
        Me.txt_numfactura.Name = "txt_numfactura"
        Me.txt_numfactura.Size = New System.Drawing.Size(124, 29)
        Me.txt_numfactura.TabIndex = 150
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(356, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 21)
        Me.Label17.TabIndex = 158
        Me.Label17.Text = "N° Factura:"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(617, 40)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(58, 29)
        Me.txt_id.TabIndex = 156
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(581, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 21)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "ID:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(219, 75)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(359, 29)
        Me.txt_nombre.TabIndex = 147
        '
        'txt_direccion
        '
        Me.txt_direccion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.Location = New System.Drawing.Point(143, 110)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(234, 29)
        Me.txt_direccion.TabIndex = 148
        '
        'txt_telefono
        '
        Me.txt_telefono.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(425, 110)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(153, 29)
        Me.txt_telefono.TabIndex = 149
        '
        'txt_nit
        '
        Me.txt_nit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nit.Location = New System.Drawing.Point(101, 40)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(227, 29)
        Me.txt_nit.TabIndex = 146
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(383, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 21)
        Me.Label13.TabIndex = 154
        Me.Label13.Text = "Tel:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "Dirección:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 21)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "NIT/CC:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 21)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Nombre ó Razon Social:"
        '
        'btn_crear_cliente
        '
        Me.btn_crear_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_crear_cliente.Image = Global.facturacion.My.Resources.Resources.Personal1
        Me.btn_crear_cliente.Location = New System.Drawing.Point(625, 89)
        Me.btn_crear_cliente.Name = "btn_crear_cliente"
        Me.btn_crear_cliente.Size = New System.Drawing.Size(50, 50)
        Me.btn_crear_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_crear_cliente.TabIndex = 157
        Me.btn_crear_cliente.TabStop = False
        '
        'btn_add
        '
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(677, 152)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(50, 50)
        Me.btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_add.TabIndex = 160
        Me.btn_add.TabStop = False
        '
        'dg_productosventa
        '
        Me.dg_productosventa.AllowUserToAddRows = False
        Me.dg_productosventa.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_productosventa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_productosventa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg_productosventa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_productosventa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_productosventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productosventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idproducto, Me.col_nombre, Me.col_iva, Me.col_estado, Me.col_cantidad, Me.col_unitario, Me.col_valortotal, Me.col_existencias, Me.col_btn_agregar, Me.col_eliminar})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_productosventa.DefaultCellStyle = DataGridViewCellStyle9
        Me.dg_productosventa.Location = New System.Drawing.Point(34, 153)
        Me.dg_productosventa.Name = "dg_productosventa"
        Me.dg_productosventa.RowHeadersVisible = False
        Me.dg_productosventa.Size = New System.Drawing.Size(641, 234)
        Me.dg_productosventa.TabIndex = 159
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Image = Global.facturacion.My.Resources.Resources.salir
        Me.btn_cerrar.Location = New System.Drawing.Point(724, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(30, 30)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 163
        Me.btn_cerrar.TabStop = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_minimizar.Image = Global.facturacion.My.Resources.Resources.mini2
        Me.btn_minimizar.Location = New System.Drawing.Point(694, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 162
        Me.btn_minimizar.TabStop = False
        '
        'barra
        '
        Me.barra.Image = Global.facturacion.My.Resources.Resources.barra
        Me.barra.Location = New System.Drawing.Point(-5, 0)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(759, 30)
        Me.barra.TabIndex = 161
        Me.barra.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(476, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "TOTAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(476, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 168
        Me.Label4.Text = "IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(476, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "SubTotal"
        '
        'txt_iva
        '
        Me.txt_iva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_iva.Enabled = False
        Me.txt_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_iva.Location = New System.Drawing.Point(568, 415)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(107, 22)
        Me.txt_iva.TabIndex = 166
        '
        'txt_total
        '
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(568, 437)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(107, 22)
        Me.txt_total.TabIndex = 164
        '
        'txt_sub
        '
        Me.txt_sub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sub.Enabled = False
        Me.txt_sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sub.Location = New System.Drawing.Point(568, 393)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.Size = New System.Drawing.Size(107, 22)
        Me.txt_sub.TabIndex = 165
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Fecha Factura:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(156, 393)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(93, 24)
        Me.txt_fecha.TabIndex = 170
        '
        'col_idproducto
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_idproducto.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_idproducto.HeaderText = "Id Producto"
        Me.col_idproducto.Name = "col_idproducto"
        Me.col_idproducto.Visible = False
        '
        'col_nombre
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_nombre.DefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.col_cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_cantidad.HeaderText = "CANTIDAD"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Width = 80
        '
        'col_unitario
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "C0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.col_unitario.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_unitario.HeaderText = "V. UNITARIO"
        Me.col_unitario.Name = "col_unitario"
        Me.col_unitario.ReadOnly = True
        Me.col_unitario.Width = 120
        '
        'col_valortotal
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "C0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.col_valortotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_valortotal.HeaderText = "V. TOTAL"
        Me.col_valortotal.Name = "col_valortotal"
        Me.col_valortotal.ReadOnly = True
        '
        'col_existencias
        '
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.col_existencias.DefaultCellStyle = DataGridViewCellStyle8
        Me.col_existencias.HeaderText = "Existencias"
        Me.col_existencias.Name = "col_existencias"
        Me.col_existencias.Visible = False
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
        Me.col_eliminar.HeaderText = "ELIMINAR"
        Me.col_eliminar.Name = "col_eliminar"
        Me.col_eliminar.Text = "ELIMINAR"
        Me.col_eliminar.ToolTipText = "Boton Eliminar"
        Me.col_eliminar.UseColumnTextForButtonValue = True
        Me.col_eliminar.Width = 70
        '
        'btn_guardar
        '
        Me.btn_guardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_guardar.Image = Global.facturacion.My.Resources.Resources.Save
        Me.btn_guardar.Location = New System.Drawing.Point(352, 397)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 172
        Me.btn_guardar.TabStop = False
        '
        'p_salir_buscarcliente
        '
        Me.p_salir_buscarcliente.Image = Global.facturacion.My.Resources.Resources.salir
        Me.p_salir_buscarcliente.Location = New System.Drawing.Point(718, 36)
        Me.p_salir_buscarcliente.Name = "p_salir_buscarcliente"
        Me.p_salir_buscarcliente.Size = New System.Drawing.Size(25, 25)
        Me.p_salir_buscarcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_salir_buscarcliente.TabIndex = 174
        Me.p_salir_buscarcliente.TabStop = False
        Me.p_salir_buscarcliente.Visible = False
        '
        'dg_buscarnit
        '
        Me.dg_buscarnit.AllowUserToAddRows = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_buscarnit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dg_buscarnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_buscarnit.Location = New System.Drawing.Point(386, 61)
        Me.dg_buscarnit.Name = "dg_buscarnit"
        Me.dg_buscarnit.RowHeadersVisible = False
        Me.dg_buscarnit.Size = New System.Drawing.Size(332, 261)
        Me.dg_buscarnit.TabIndex = 173
        Me.dg_buscarnit.Visible = False
        '
        'Crear_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(755, 483)
        Me.Controls.Add(Me.p_salir_buscarcliente)
        Me.Controls.Add(Me.dg_buscarnit)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_sub)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dg_productosventa)
        Me.Controls.Add(Me.txt_numfactura)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_crear_cliente)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_nit)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Crear_Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear_Compra"
        CType(Me.btn_crear_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_productosventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_salir_buscarcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_buscarnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_numfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_crear_cliente As System.Windows.Forms.PictureBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_nit As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.PictureBox
    Friend WithEvents dg_productosventa As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cerrar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_minimizar As System.Windows.Forms.PictureBox
    Friend WithEvents barra As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_sub As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents btn_guardar As System.Windows.Forms.PictureBox
    Friend WithEvents p_salir_buscarcliente As System.Windows.Forms.PictureBox
    Friend WithEvents dg_buscarnit As System.Windows.Forms.DataGridView
End Class
