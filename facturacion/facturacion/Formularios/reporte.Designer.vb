<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_desde = New System.Windows.Forms.DateTimePicker()
        Me.txt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_valor_uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.dg_ventas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detallado = New System.Windows.Forms.RadioButton()
        Me.ventas = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_ven = New System.Windows.Forms.Label()
        Me.l_cos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.l_ganancia = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_desde
        '
        Me.txt_desde.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_desde.Location = New System.Drawing.Point(30, 81)
        Me.txt_desde.Name = "txt_desde"
        Me.txt_desde.Size = New System.Drawing.Size(129, 29)
        Me.txt_desde.TabIndex = 0
        '
        'txt_hasta
        '
        Me.txt_hasta.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_hasta.Location = New System.Drawing.Point(165, 81)
        Me.txt_hasta.Name = "txt_hasta"
        Me.txt_hasta.Size = New System.Drawing.Size(129, 29)
        Me.txt_hasta.TabIndex = 1
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fecha, Me.col_producto, Me.col_cantidad, Me.col_valor_uni, Me.col_total})
        Me.dg.Location = New System.Drawing.Point(30, 125)
        Me.dg.Name = "dg"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dg.RowHeadersVisible = False
        Me.dg.Size = New System.Drawing.Size(603, 192)
        Me.dg.TabIndex = 2
        Me.dg.Visible = False
        '
        'col_fecha
        '
        Me.col_fecha.HeaderText = "Fecha"
        Me.col_fecha.Name = "col_fecha"
        '
        'col_producto
        '
        Me.col_producto.HeaderText = "Nombre Producto"
        Me.col_producto.Name = "col_producto"
        Me.col_producto.Width = 200
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "Cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        '
        'col_valor_uni
        '
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.col_valor_uni.DefaultCellStyle = DataGridViewCellStyle9
        Me.col_valor_uni.HeaderText = "Valor Uni."
        Me.col_valor_uni.Name = "col_valor_uni"
        '
        'col_total
        '
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle10
        Me.col_total.HeaderText = "Valor Total"
        Me.col_total.Name = "col_total"
        '
        'btn_generar
        '
        Me.btn_generar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generar.Location = New System.Drawing.Point(310, 74)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(94, 36)
        Me.btn_generar.TabIndex = 3
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'dg_ventas
        '
        Me.dg_ventas.AllowUserToAddRows = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_ventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dg_ventas.Location = New System.Drawing.Point(30, 125)
        Me.dg_ventas.Name = "dg_ventas"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_ventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dg_ventas.RowHeadersVisible = False
        Me.dg_ventas.Size = New System.Drawing.Size(545, 192)
        Me.dg_ventas.TabIndex = 4
        Me.dg_ventas.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Numero Factura"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 140
        '
        'detallado
        '
        Me.detallado.AutoSize = True
        Me.detallado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detallado.Location = New System.Drawing.Point(30, 12)
        Me.detallado.Name = "detallado"
        Me.detallado.Size = New System.Drawing.Size(98, 25)
        Me.detallado.TabIndex = 5
        Me.detallado.TabStop = True
        Me.detallado.Text = "Detallado"
        Me.detallado.UseVisualStyleBackColor = True
        '
        'ventas
        '
        Me.ventas.AutoSize = True
        Me.ventas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventas.Location = New System.Drawing.Point(145, 12)
        Me.ventas.Name = "ventas"
        Me.ventas.Size = New System.Drawing.Size(106, 25)
        Me.ventas.TabIndex = 6
        Me.ventas.TabStop = True
        Me.ventas.Text = "Por Ventas"
        Me.ventas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ventas"
        '
        'l_ven
        '
        Me.l_ven.AutoSize = True
        Me.l_ven.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_ven.Location = New System.Drawing.Point(97, 329)
        Me.l_ven.Name = "l_ven"
        Me.l_ven.Size = New System.Drawing.Size(28, 21)
        Me.l_ven.TabIndex = 8
        Me.l_ven.Text = "$0"
        '
        'l_cos
        '
        Me.l_cos.AutoSize = True
        Me.l_cos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_cos.Location = New System.Drawing.Point(97, 353)
        Me.l_cos.Name = "l_cos"
        Me.l_cos.Size = New System.Drawing.Size(28, 21)
        Me.l_cos.TabIndex = 10
        Me.l_cos.Text = "$0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Costos"
        '
        'l_ganancia
        '
        Me.l_ganancia.AutoSize = True
        Me.l_ganancia.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_ganancia.Location = New System.Drawing.Point(97, 378)
        Me.l_ganancia.Name = "l_ganancia"
        Me.l_ganancia.Size = New System.Drawing.Size(28, 21)
        Me.l_ganancia.TabIndex = 12
        Me.l_ganancia.Text = "$0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ganancia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Desde"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(161, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Hasta"
        '
        'reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(662, 412)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.l_ganancia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.l_cos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.l_ven)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ventas)
        Me.Controls.Add(Me.detallado)
        Me.Controls.Add(Me.dg_ventas)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.txt_hasta)
        Me.Controls.Add(Me.txt_desde)
        Me.Controls.Add(Me.dg)
        Me.Name = "reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reporte"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents dg_ventas As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detallado As System.Windows.Forms.RadioButton
    Friend WithEvents ventas As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l_ven As System.Windows.Forms.Label
    Friend WithEvents l_cos As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents l_ganancia As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_valor_uni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
