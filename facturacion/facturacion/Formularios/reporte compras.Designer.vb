<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_compras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ventas = New System.Windows.Forms.RadioButton()
        Me.detallado = New System.Windows.Forms.RadioButton()
        Me.dg_ventas = New System.Windows.Forms.DataGridView()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.txt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.txt_desde = New System.Windows.Forms.DateTimePicker()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_valor_uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(143, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Desde"
        '
        'ventas
        '
        Me.ventas.AutoSize = True
        Me.ventas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventas.Location = New System.Drawing.Point(127, 12)
        Me.ventas.Name = "ventas"
        Me.ventas.Size = New System.Drawing.Size(106, 25)
        Me.ventas.TabIndex = 21
        Me.ventas.TabStop = True
        Me.ventas.Text = "Por Ventas"
        Me.ventas.UseVisualStyleBackColor = True
        '
        'detallado
        '
        Me.detallado.AutoSize = True
        Me.detallado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detallado.Location = New System.Drawing.Point(12, 12)
        Me.detallado.Name = "detallado"
        Me.detallado.Size = New System.Drawing.Size(98, 25)
        Me.detallado.TabIndex = 20
        Me.detallado.TabStop = True
        Me.detallado.Text = "Detallado"
        Me.detallado.UseVisualStyleBackColor = True
        '
        'dg_ventas
        '
        Me.dg_ventas.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_ventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dg_ventas.Location = New System.Drawing.Point(12, 125)
        Me.dg_ventas.Name = "dg_ventas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_ventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_ventas.RowHeadersVisible = False
        Me.dg_ventas.Size = New System.Drawing.Size(545, 192)
        Me.dg_ventas.TabIndex = 19
        Me.dg_ventas.Visible = False
        '
        'btn_generar
        '
        Me.btn_generar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generar.Location = New System.Drawing.Point(292, 74)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(94, 36)
        Me.btn_generar.TabIndex = 18
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'txt_hasta
        '
        Me.txt_hasta.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_hasta.Location = New System.Drawing.Point(147, 81)
        Me.txt_hasta.Name = "txt_hasta"
        Me.txt_hasta.Size = New System.Drawing.Size(129, 29)
        Me.txt_hasta.TabIndex = 16
        '
        'txt_desde
        '
        Me.txt_desde.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_desde.Location = New System.Drawing.Point(12, 81)
        Me.txt_desde.Name = "txt_desde"
        Me.txt_desde.Size = New System.Drawing.Size(129, 29)
        Me.txt_desde.TabIndex = 15
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fecha, Me.col_producto, Me.col_cantidad, Me.col_valor_uni, Me.col_total})
        Me.dg.Location = New System.Drawing.Point(12, 125)
        Me.dg.Name = "dg"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dg.RowHeadersVisible = False
        Me.dg.Size = New System.Drawing.Size(603, 192)
        Me.dg.TabIndex = 17
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
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.col_valor_uni.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_valor_uni.HeaderText = "Valor Uni."
        Me.col_valor_uni.Name = "col_valor_uni"
        '
        'col_total
        '
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_total.HeaderText = "Valor Total"
        Me.col_total.Name = "col_total"
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
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 140
        '
        'reporte_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(626, 331)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ventas)
        Me.Controls.Add(Me.detallado)
        Me.Controls.Add(Me.dg_ventas)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.txt_hasta)
        Me.Controls.Add(Me.txt_desde)
        Me.Controls.Add(Me.dg)
        Me.Name = "reporte_compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reporte_compras"
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ventas As System.Windows.Forms.RadioButton
    Friend WithEvents detallado As System.Windows.Forms.RadioButton
    Friend WithEvents dg_ventas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents txt_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_valor_uni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
