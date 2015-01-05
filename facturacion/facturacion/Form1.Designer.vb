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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_nota = New System.Windows.Forms.TextBox()
        Me.cb_tipodocu = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_numdocu = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_sexo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_fechanacio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_telefonolegal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_legal = New System.Windows.Forms.TextBox()
        Me.txt_ciudad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
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
        Me.bnt_guardar.Location = New System.Drawing.Point(295, 350)
        Me.bnt_guardar.Name = "bnt_guardar"
        Me.bnt_guardar.Size = New System.Drawing.Size(108, 39)
        Me.bnt_guardar.TabIndex = 38
        Me.bnt_guardar.Text = "Guardar"
        Me.bnt_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label9.Location = New System.Drawing.Point(18, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 15)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "* Campos Obligatorios"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(373, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 15)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 16)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Nota:"
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
        'txt_nota
        '
        Me.txt_nota.Location = New System.Drawing.Point(69, 145)
        Me.txt_nota.Multiline = True
        Me.txt_nota.Name = "txt_nota"
        Me.txt_nota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_nota.Size = New System.Drawing.Size(307, 125)
        Me.txt_nota.TabIndex = 5
        '
        'cb_tipodocu
        '
        Me.cb_tipodocu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_tipodocu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tipodocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipodocu.FormattingEnabled = True
        Me.cb_tipodocu.Items.AddRange(New Object() {"CC", "NIT", "TI", "PSP"})
        Me.cb_tipodocu.Location = New System.Drawing.Point(182, 83)
        Me.cb_tipodocu.Name = "cb_tipodocu"
        Me.cb_tipodocu.Size = New System.Drawing.Size(190, 24)
        Me.cb_tipodocu.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tipo de Documento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Apellido:"
        '
        'txt_ape
        '
        Me.txt_ape.Location = New System.Drawing.Point(182, 53)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(190, 22)
        Me.txt_ape.TabIndex = 2
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
        Me.Label4.Location = New System.Drawing.Point(13, 123)
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
        Me.txt_nombre.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(300, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(219, 29)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "NUEVO CLIENTE"
        '
        'txt_numdocu
        '
        Me.txt_numdocu.Location = New System.Drawing.Point(183, 117)
        Me.txt_numdocu.Name = "txt_numdocu"
        Me.txt_numdocu.Size = New System.Drawing.Size(190, 22)
        Me.txt_numdocu.TabIndex = 4
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.ImageIndex = 1
        Me.btn_cancelar.ImageList = Me.ImageList1
        Me.btn_cancelar.Location = New System.Drawing.Point(409, 350)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(114, 39)
        Me.btn_cancelar.TabIndex = 39
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_sexo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_fechanacio)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_telefonolegal)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_legal)
        Me.GroupBox2.Controls.Add(Me.txt_ciudad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_dir)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_telefono)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(413, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 292)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Contacto"
        '
        'txt_sexo
        '
        Me.txt_sexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_sexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_sexo.FormattingEnabled = True
        Me.txt_sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.txt_sexo.Location = New System.Drawing.Point(179, 147)
        Me.txt_sexo.Name = "txt_sexo"
        Me.txt_sexo.Size = New System.Drawing.Size(190, 24)
        Me.txt_sexo.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Sexo:"
        '
        'txt_fechanacio
        '
        Me.txt_fechanacio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fechanacio.Location = New System.Drawing.Point(179, 119)
        Me.txt_fechanacio.Name = "txt_fechanacio"
        Me.txt_fechanacio.Size = New System.Drawing.Size(190, 22)
        Me.txt_fechanacio.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(22, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Fecha Nacimiento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "E-Mail:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(179, 177)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(190, 22)
        Me.txt_email.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Telefono Rep. Legal:"
        '
        'txt_telefonolegal
        '
        Me.txt_telefonolegal.Location = New System.Drawing.Point(179, 236)
        Me.txt_telefonolegal.Name = "txt_telefonolegal"
        Me.txt_telefonolegal.Size = New System.Drawing.Size(190, 22)
        Me.txt_telefonolegal.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Representante Legal:"
        '
        'txt_legal
        '
        Me.txt_legal.Location = New System.Drawing.Point(179, 206)
        Me.txt_legal.Name = "txt_legal"
        Me.txt_legal.Size = New System.Drawing.Size(190, 22)
        Me.txt_legal.TabIndex = 7
        '
        'txt_ciudad
        '
        Me.txt_ciudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_ciudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_ciudad.FormattingEnabled = True
        Me.txt_ciudad.Items.AddRange(New Object() {"Alcala", "Quimbaya"})
        Me.txt_ciudad.Location = New System.Drawing.Point(179, 89)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Size = New System.Drawing.Size(190, 24)
        Me.txt_ciudad.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Direccion:"
        '
        'txt_dir
        '
        Me.txt_dir.Location = New System.Drawing.Point(179, 61)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(190, 22)
        Me.txt_dir.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Telefono:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(179, 33)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(190, 22)
        Me.txt_telefono.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_nota)
        Me.GroupBox1.Controls.Add(Me.cb_tipodocu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_numdocu)
        Me.GroupBox1.Controls.Add(Me.txt_ape)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 292)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 543)
        Me.Controls.Add(Me.bnt_guardar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnt_guardar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_nota As System.Windows.Forms.TextBox
    Friend WithEvents cb_tipodocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ape As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_numdocu As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_fechanacio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_telefonolegal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_legal As System.Windows.Forms.TextBox
    Friend WithEvents txt_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
