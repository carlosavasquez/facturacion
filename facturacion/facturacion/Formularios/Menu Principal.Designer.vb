<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_reportes = New System.Windows.Forms.PictureBox()
        Me.btn_vendedores = New System.Windows.Forms.PictureBox()
        Me.btn_ventas = New System.Windows.Forms.PictureBox()
        Me.btn_clientes = New System.Windows.Forms.PictureBox()
        Me.btn_productos = New System.Windows.Forms.PictureBox()
        Me.btn_proveedores = New System.Windows.Forms.PictureBox()
        Me.btn_compras = New System.Windows.Forms.PictureBox()
        CType(Me.btn_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_vendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "COMPRAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PROVEEDORES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(380, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CLIENTES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "VENTAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(562, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PRODUCTOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(557, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "VENDEDORES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(757, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "REPORTES"
        '
        'btn_reportes
        '
        Me.btn_reportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_reportes.Image = Global.facturacion.My.Resources.Resources.sales_report_icon
        Me.btn_reportes.Location = New System.Drawing.Point(736, 246)
        Me.btn_reportes.Name = "btn_reportes"
        Me.btn_reportes.Size = New System.Drawing.Size(150, 150)
        Me.btn_reportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_reportes.TabIndex = 15
        Me.btn_reportes.TabStop = False
        '
        'btn_vendedores
        '
        Me.btn_vendedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_vendedores.Image = Global.facturacion.My.Resources.Resources.Occupations_Technical_Support_Representative_Male_Light_icon
        Me.btn_vendedores.Location = New System.Drawing.Point(549, 337)
        Me.btn_vendedores.Name = "btn_vendedores"
        Me.btn_vendedores.Size = New System.Drawing.Size(150, 150)
        Me.btn_vendedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_vendedores.TabIndex = 12
        Me.btn_vendedores.TabStop = False
        '
        'btn_ventas
        '
        Me.btn_ventas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_ventas.Image = Global.facturacion.My.Resources.Resources.shopping_cart_insert256
        Me.btn_ventas.Location = New System.Drawing.Point(157, 337)
        Me.btn_ventas.Name = "btn_ventas"
        Me.btn_ventas.Size = New System.Drawing.Size(150, 150)
        Me.btn_ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_ventas.TabIndex = 7
        Me.btn_ventas.TabStop = False
        '
        'btn_clientes
        '
        Me.btn_clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_clientes.Image = Global.facturacion.My.Resources.Resources.man1_256
        Me.btn_clientes.Location = New System.Drawing.Point(355, 337)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(150, 150)
        Me.btn_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_clientes.TabIndex = 3
        Me.btn_clientes.TabStop = False
        '
        'btn_productos
        '
        Me.btn_productos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_productos.Image = Global.facturacion.My.Resources.Resources.product256
        Me.btn_productos.Location = New System.Drawing.Point(549, 161)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(150, 150)
        Me.btn_productos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_productos.TabIndex = 9
        Me.btn_productos.TabStop = False
        '
        'btn_proveedores
        '
        Me.btn_proveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_proveedores.Image = Global.facturacion.My.Resources.Resources.couple256
        Me.btn_proveedores.Location = New System.Drawing.Point(355, 160)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(150, 150)
        Me.btn_proveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_proveedores.TabIndex = 2
        Me.btn_proveedores.TabStop = False
        '
        'btn_compras
        '
        Me.btn_compras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_compras.Image = Global.facturacion.My.Resources.Resources.shopping_cart_add256
        Me.btn_compras.Location = New System.Drawing.Point(157, 160)
        Me.btn_compras.Name = "btn_compras"
        Me.btn_compras.Size = New System.Drawing.Size(150, 150)
        Me.btn_compras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_compras.TabIndex = 1
        Me.btn_compras.TabStop = False
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 646)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_reportes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_vendedores)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_ventas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_productos)
        Me.Controls.Add(Me.btn_proveedores)
        Me.Controls.Add(Me.btn_compras)
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        CType(Me.btn_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_vendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_compras As System.Windows.Forms.PictureBox
    Friend WithEvents btn_proveedores As System.Windows.Forms.PictureBox
    Friend WithEvents btn_clientes As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_ventas As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_productos As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_vendedores As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_reportes As System.Windows.Forms.PictureBox
End Class
