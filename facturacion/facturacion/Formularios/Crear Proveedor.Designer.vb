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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_razon = New System.Windows.Forms.TextBox()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.barra = New System.Windows.Forms.PictureBox()
        Me.btn_guardar = New System.Windows.Forms.PictureBox()
        Me.btn_eliminar = New System.Windows.Forms.PictureBox()
        Me.btn_editar = New System.Windows.Forms.PictureBox()
        Me.btn_nuevo = New System.Windows.Forms.PictureBox()
        Me.dg_buscarprovee = New System.Windows.Forms.DataGridView()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_buscarprovee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(19, 93)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(180, 21)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Nombre ó Razon Social"
        '
        'txt_razon
        '
        Me.txt_razon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_razon.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_razon.Location = New System.Drawing.Point(209, 85)
        Me.txt_razon.Name = "txt_razon"
        Me.txt_razon.Size = New System.Drawing.Size(272, 29)
        Me.txt_razon.TabIndex = 5
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
        Me.txt_nit.TabIndex = 7
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
        Me.txt_tel.TabIndex = 11
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
        Me.txt_email.TabIndex = 13
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
        Me.txt_tipo.TabIndex = 14
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(325, 316)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Guardar"
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
        'btn_cerrar
        '
        Me.btn_cerrar.Image = Global.facturacion.My.Resources.Resources.salir
        Me.btn_cerrar.Location = New System.Drawing.Point(618, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(30, 30)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 23
        Me.btn_cerrar.TabStop = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_minimizar.Image = Global.facturacion.My.Resources.Resources.mini2
        Me.btn_minimizar.Location = New System.Drawing.Point(588, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 22
        Me.btn_minimizar.TabStop = False
        '
        'barra
        '
        Me.barra.Image = Global.facturacion.My.Resources.Resources.barra
        Me.barra.Location = New System.Drawing.Point(0, 0)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(652, 30)
        Me.barra.TabIndex = 21
        Me.barra.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = Global.facturacion.My.Resources.Resources.saveB_N
        Me.btn_guardar.Location = New System.Drawing.Point(324, 331)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.TabStop = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Image = Global.facturacion.My.Resources.Resources.eliminar_B_N
        Me.btn_eliminar.Location = New System.Drawing.Point(380, 331)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.TabStop = False
        '
        'btn_editar
        '
        Me.btn_editar.Image = Global.facturacion.My.Resources.Resources.Notepad
        Me.btn_editar.Location = New System.Drawing.Point(268, 331)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_editar.TabIndex = 1
        Me.btn_editar.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.facturacion.My.Resources.Resources.Documents
        Me.btn_nuevo.Location = New System.Drawing.Point(212, 331)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(50, 50)
        Me.btn_nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.TabStop = False
        '
        'dg_buscarprovee
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_buscarprovee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_buscarprovee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_buscarprovee.Location = New System.Drawing.Point(370, 49)
        Me.dg_buscarprovee.Name = "dg_buscarprovee"
        Me.dg_buscarprovee.Size = New System.Drawing.Size(278, 295)
        Me.dg_buscarprovee.TabIndex = 29
        '
        'txt_dir
        '
        Me.txt_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dir.Location = New System.Drawing.Point(207, 223)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(272, 29)
        Me.txt_dir.TabIndex = 31
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
        'Crear_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(648, 410)
        Me.Controls.Add(Me.txt_dir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
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
        Me.Controls.Add(Me.txt_razon)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.dg_buscarprovee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Crear_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Proveedor"
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_buscarprovee, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txt_razon As System.Windows.Forms.TextBox
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dg_buscarprovee As System.Windows.Forms.DataGridView
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
