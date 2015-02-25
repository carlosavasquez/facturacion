<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Inventario
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
        Me.dg_productos = New System.Windows.Forms.DataGridView()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ubi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_generar = New System.Windows.Forms.Button()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_productos
        '
        Me.dg_productos.AllowUserToAddRows = False
        Me.dg_productos.AllowUserToDeleteRows = False
        Me.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.col_ref, Me.col_cant, Me.col_ubi})
        Me.dg_productos.Location = New System.Drawing.Point(12, 99)
        Me.dg_productos.Name = "dg_productos"
        Me.dg_productos.ReadOnly = True
        Me.dg_productos.RowHeadersVisible = False
        Me.dg_productos.Size = New System.Drawing.Size(465, 290)
        Me.dg_productos.TabIndex = 0
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        Me.col_nombre.Width = 160
        '
        'col_ref
        '
        Me.col_ref.HeaderText = "Referencia"
        Me.col_ref.Name = "col_ref"
        Me.col_ref.ReadOnly = True
        '
        'col_cant
        '
        Me.col_cant.HeaderText = "Cantidad"
        Me.col_cant.Name = "col_cant"
        Me.col_cant.ReadOnly = True
        '
        'col_ubi
        '
        Me.col_ubi.HeaderText = "Ubicación"
        Me.col_ubi.Name = "col_ubi"
        Me.col_ubi.ReadOnly = True
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(12, 43)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 1
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'Reporte_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 415)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.dg_productos)
        Me.Name = "Reporte_Inventario"
        Me.Text = "Reporte_Inventario"
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_productos As System.Windows.Forms.DataGridView
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ubi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_generar As System.Windows.Forms.Button
End Class
