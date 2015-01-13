<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bnt_guardar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cb_tipodocu = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_numdocu = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnt_guardar
        '
        Me.bnt_guardar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bnt_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_guardar.ForeColor = System.Drawing.Color.White
        Me.bnt_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnt_guardar.ImageIndex = 0
        Me.bnt_guardar.ImageList = Me.ImageList1
        Me.bnt_guardar.Location = New System.Drawing.Point(183, 197)
        Me.bnt_guardar.Name = "bnt_guardar"
        Me.bnt_guardar.Size = New System.Drawing.Size(40, 40)
        Me.bnt_guardar.TabIndex = 7
        Me.bnt_guardar.Text = "&G"
        Me.bnt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.bnt_guardar.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Save.png")
        Me.ImageList1.Images.SetKeyName(1, "Close_Box_Red.png")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 15)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "* Campos Obligatorios"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(373, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 15)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "*"
        '
        'cb_tipodocu
        '
        Me.cb_tipodocu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_tipodocu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tipodocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipodocu.FormattingEnabled = True
        Me.cb_tipodocu.Items.AddRange(New Object() {"CC", "NIT", "TI", "PSP"})
        Me.cb_tipodocu.Location = New System.Drawing.Point(183, 54)
        Me.cb_tipodocu.Name = "cb_tipodocu"
        Me.cb_tipodocu.Size = New System.Drawing.Size(190, 24)
        Me.cb_tipodocu.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tipo de Documento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Numero de Documento:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(183, 25)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(190, 22)
        Me.txt_nombre.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(103, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(219, 29)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "NUEVO CLIENTE"
        '
        'txt_numdocu
        '
        Me.txt_numdocu.Location = New System.Drawing.Point(183, 84)
        Me.txt_numdocu.Name = "txt_numdocu"
        Me.txt_numdocu.Size = New System.Drawing.Size(190, 22)
        Me.txt_numdocu.TabIndex = 2
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.ImageIndex = 1
        Me.btn_cancelar.ImageList = Me.ImageList1
        Me.btn_cancelar.Location = New System.Drawing.Point(334, 197)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "E-Mail:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(183, 169)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(190, 22)
        Me.txt_email.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Direccion:"
        '
        'txt_dir
        '
        Me.txt_dir.Location = New System.Drawing.Point(183, 140)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(190, 22)
        Me.txt_dir.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Telefono:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(183, 112)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(190, 22)
        Me.txt_telefono.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bnt_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cb_tipodocu)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_dir)
        Me.GroupBox1.Controls.Add(Me.txt_numdocu)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 259)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(373, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 15)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(424, 332)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnt_guardar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cb_tipodocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_numdocu As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
