<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUndDidac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUndDidac))
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGVPROFESIONAL = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.btnsalirP = New System.Windows.Forms.Button()
        Me.btnEliminarP = New System.Windows.Forms.Button()
        Me.btncancelarP = New System.Windows.Forms.Button()
        Me.btnModificarP = New System.Windows.Forms.Button()
        Me.BTNNUEVOP = New System.Windows.Forms.Button()
        Me.txtNomUndDidacP = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboEspecialidadP = New System.Windows.Forms.ComboBox()
        Me.txtBuscarP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnBuscarP = New System.Windows.Forms.Button()
        Me.lblIdUndDidacP = New System.Windows.Forms.Label()
        Me.txtAñoModuloP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHorasP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCreditoP = New System.Windows.Forms.TextBox()
        Me.txtIdCicloP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdModuloP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarT = New System.Windows.Forms.Button()
        Me.btnVerT = New System.Windows.Forms.Button()
        Me.btnSalirT = New System.Windows.Forms.Button()
        Me.btnEliminarT = New System.Windows.Forms.Button()
        Me.btnCancelarT = New System.Windows.Forms.Button()
        Me.btnModificarT = New System.Windows.Forms.Button()
        Me.btnNuevoT = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboEspecialidadT = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBuscarT = New System.Windows.Forms.TextBox()
        Me.btnBuscarT = New System.Windows.Forms.Button()
        Me.lblIdUndDidacT = New System.Windows.Forms.Label()
        Me.txtAñoModuloT = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtHorasT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCreditoT = New System.Windows.Forms.TextBox()
        Me.txtIdCicloT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNomUndDidacT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdModuloT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVPROFESIONAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToDeleteRows = False
        Me.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Location = New System.Drawing.Point(16, 304)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(868, 224)
        Me.DataGrid1.TabIndex = 59
        '
        'lblusuario
        '
        Me.lblusuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblusuario.Location = New System.Drawing.Point(786, 584)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(80, 16)
        Me.lblusuario.TabIndex = 63
        Me.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(898, 578)
        Me.TabControl1.TabIndex = 64
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.DGVPROFESIONAL)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.txtNomUndDidacP)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.lblIdUndDidacP)
        Me.TabPage1.Controls.Add(Me.txtAñoModuloP)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtHorasP)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtCreditoP)
        Me.TabPage1.Controls.Add(Me.txtIdCicloP)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtIdModuloP)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(890, 505)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Unidad Didáctica Profesional"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGVPROFESIONAL
        '
        Me.DGVPROFESIONAL.AllowUserToAddRows = False
        Me.DGVPROFESIONAL.AllowUserToDeleteRows = False
        Me.DGVPROFESIONAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPROFESIONAL.Location = New System.Drawing.Point(7, 286)
        Me.DGVPROFESIONAL.Name = "DGVPROFESIONAL"
        Me.DGVPROFESIONAL.ReadOnly = True
        Me.DGVPROFESIONAL.Size = New System.Drawing.Size(874, 201)
        Me.DGVPROFESIONAL.TabIndex = 116
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnGuardarP)
        Me.GroupBox3.Controls.Add(Me.btnsalirP)
        Me.GroupBox3.Controls.Add(Me.btnEliminarP)
        Me.GroupBox3.Controls.Add(Me.btncancelarP)
        Me.GroupBox3.Controls.Add(Me.btnModificarP)
        Me.GroupBox3.Controls.Add(Me.BTNNUEVOP)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(27, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(413, 76)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OPCIONES:"
        '
        'btnGuardarP
        '
        Me.btnGuardarP.BackgroundImage = CType(resources.GetObject("btnGuardarP.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarP.Location = New System.Drawing.Point(266, 18)
        Me.btnGuardarP.Name = "btnGuardarP"
        Me.btnGuardarP.Size = New System.Drawing.Size(62, 52)
        Me.btnGuardarP.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.btnGuardarP, "Guardar")
        Me.btnGuardarP.UseVisualStyleBackColor = True
        '
        'btnsalirP
        '
        Me.btnsalirP.BackgroundImage = CType(resources.GetObject("btnsalirP.BackgroundImage"), System.Drawing.Image)
        Me.btnsalirP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalirP.Location = New System.Drawing.Point(334, 18)
        Me.btnsalirP.Name = "btnsalirP"
        Me.btnsalirP.Size = New System.Drawing.Size(62, 52)
        Me.btnsalirP.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.btnsalirP, "Salir")
        Me.btnsalirP.UseVisualStyleBackColor = True
        '
        'btnEliminarP
        '
        Me.btnEliminarP.BackgroundImage = CType(resources.GetObject("btnEliminarP.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarP.Location = New System.Drawing.Point(204, 19)
        Me.btnEliminarP.Name = "btnEliminarP"
        Me.btnEliminarP.Size = New System.Drawing.Size(62, 52)
        Me.btnEliminarP.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnEliminarP, "Eliminar")
        Me.btnEliminarP.UseVisualStyleBackColor = True
        '
        'btncancelarP
        '
        Me.btncancelarP.BackgroundImage = CType(resources.GetObject("btncancelarP.BackgroundImage"), System.Drawing.Image)
        Me.btncancelarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelarP.Location = New System.Drawing.Point(80, 17)
        Me.btncancelarP.Name = "btncancelarP"
        Me.btncancelarP.Size = New System.Drawing.Size(62, 52)
        Me.btncancelarP.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.btncancelarP, "Cancelar")
        Me.btncancelarP.UseVisualStyleBackColor = True
        '
        'btnModificarP
        '
        Me.btnModificarP.BackgroundImage = CType(resources.GetObject("btnModificarP.BackgroundImage"), System.Drawing.Image)
        Me.btnModificarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarP.Location = New System.Drawing.Point(143, 18)
        Me.btnModificarP.Name = "btnModificarP"
        Me.btnModificarP.Size = New System.Drawing.Size(62, 52)
        Me.btnModificarP.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnModificarP, "Modificar")
        Me.btnModificarP.UseVisualStyleBackColor = True
        '
        'BTNNUEVOP
        '
        Me.BTNNUEVOP.BackgroundImage = CType(resources.GetObject("BTNNUEVOP.BackgroundImage"), System.Drawing.Image)
        Me.BTNNUEVOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNNUEVOP.Location = New System.Drawing.Point(17, 17)
        Me.BTNNUEVOP.Name = "BTNNUEVOP"
        Me.BTNNUEVOP.Size = New System.Drawing.Size(62, 52)
        Me.BTNNUEVOP.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BTNNUEVOP, "Nuevo")
        Me.BTNNUEVOP.UseVisualStyleBackColor = True
        '
        'txtNomUndDidacP
        '
        Me.txtNomUndDidacP.Location = New System.Drawing.Point(253, 141)
        Me.txtNomUndDidacP.Name = "txtNomUndDidacP"
        Me.txtNomUndDidacP.Size = New System.Drawing.Size(622, 20)
        Me.txtNomUndDidacP.TabIndex = 89
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboEspecialidadP)
        Me.GroupBox2.Controls.Add(Me.txtBuscarP)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btnBuscarP)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(456, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 105)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar U.D. Profesional"
        '
        'cboEspecialidadP
        '
        Me.cboEspecialidadP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecialidadP.FormattingEnabled = True
        Me.cboEspecialidadP.Location = New System.Drawing.Point(158, 71)
        Me.cboEspecialidadP.Name = "cboEspecialidadP"
        Me.cboEspecialidadP.Size = New System.Drawing.Size(261, 24)
        Me.cboEspecialidadP.TabIndex = 116
        '
        'txtBuscarP
        '
        Me.txtBuscarP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBuscarP.Location = New System.Drawing.Point(152, 33)
        Me.txtBuscarP.Name = "txtBuscarP"
        Me.txtBuscarP.Size = New System.Drawing.Size(65, 22)
        Me.txtBuscarP.TabIndex = 90
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(19, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 16)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "ESPECIALIDAD:"
        '
        'btnBuscarP
        '
        Me.btnBuscarP.BackgroundImage = CType(resources.GetObject("btnBuscarP.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarP.Location = New System.Drawing.Point(59, 20)
        Me.btnBuscarP.Name = "btnBuscarP"
        Me.btnBuscarP.Size = New System.Drawing.Size(62, 52)
        Me.btnBuscarP.TabIndex = 89
        Me.ToolTip1.SetToolTip(Me.btnBuscarP, "Buscar")
        Me.btnBuscarP.UseVisualStyleBackColor = True
        '
        'lblIdUndDidacP
        '
        Me.lblIdUndDidacP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdUndDidacP.Location = New System.Drawing.Point(253, 110)
        Me.lblIdUndDidacP.Name = "lblIdUndDidacP"
        Me.lblIdUndDidacP.Size = New System.Drawing.Size(59, 20)
        Me.lblIdUndDidacP.TabIndex = 86
        '
        'txtAñoModuloP
        '
        Me.txtAñoModuloP.Location = New System.Drawing.Point(431, 248)
        Me.txtAñoModuloP.Name = "txtAñoModuloP"
        Me.txtAñoModuloP.Size = New System.Drawing.Size(59, 20)
        Me.txtAñoModuloP.TabIndex = 83
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(313, 252)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 16)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "AÑO MÓDULO:"
        '
        'txtHorasP
        '
        Me.txtHorasP.Location = New System.Drawing.Point(166, 225)
        Me.txtHorasP.Name = "txtHorasP"
        Me.txtHorasP.Size = New System.Drawing.Size(41, 20)
        Me.txtHorasP.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "HORAS:"
        '
        'txtCreditoP
        '
        Me.txtCreditoP.Location = New System.Drawing.Point(166, 177)
        Me.txtCreditoP.Name = "txtCreditoP"
        Me.txtCreditoP.Size = New System.Drawing.Size(41, 20)
        Me.txtCreditoP.TabIndex = 76
        '
        'txtIdCicloP
        '
        Me.txtIdCicloP.Location = New System.Drawing.Point(431, 173)
        Me.txtIdCicloP.Name = "txtIdCicloP"
        Me.txtIdCicloP.Size = New System.Drawing.Size(59, 20)
        Me.txtIdCicloP.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "CRÉDITO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(311, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "ID CICLO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 16)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "NOMBRE DE  UND. DICATICA :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 16)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "ID UNIDAD DIDÁCTICA :"
        '
        'txtIdModuloP
        '
        Me.txtIdModuloP.Location = New System.Drawing.Point(431, 211)
        Me.txtIdModuloP.Name = "txtIdModuloP"
        Me.txtIdModuloP.Size = New System.Drawing.Size(59, 20)
        Me.txtIdModuloP.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(311, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "ID MÓDULO:"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.DataGrid1)
        Me.TabPage2.Controls.Add(Me.lblIdUndDidacT)
        Me.TabPage2.Controls.Add(Me.txtAñoModuloT)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtHorasT)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtCreditoT)
        Me.TabPage2.Controls.Add(Me.txtIdCicloT)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtNomUndDidacT)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtIdModuloT)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(890, 552)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Unidad Didáctica Transversal"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnGuardarT)
        Me.GroupBox4.Controls.Add(Me.btnVerT)
        Me.GroupBox4.Controls.Add(Me.btnSalirT)
        Me.GroupBox4.Controls.Add(Me.btnEliminarT)
        Me.GroupBox4.Controls.Add(Me.btnCancelarT)
        Me.GroupBox4.Controls.Add(Me.btnModificarT)
        Me.GroupBox4.Controls.Add(Me.btnNuevoT)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(213, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 76)
        Me.GroupBox4.TabIndex = 116
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "OPCIONES:"
        '
        'btnGuardarT
        '
        Me.btnGuardarT.BackgroundImage = CType(resources.GetObject("btnGuardarT.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarT.Location = New System.Drawing.Point(266, 17)
        Me.btnGuardarT.Name = "btnGuardarT"
        Me.btnGuardarT.Size = New System.Drawing.Size(62, 52)
        Me.btnGuardarT.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.btnGuardarT, "Guardar")
        Me.btnGuardarT.UseVisualStyleBackColor = True
        '
        'btnVerT
        '
        Me.btnVerT.BackgroundImage = CType(resources.GetObject("btnVerT.BackgroundImage"), System.Drawing.Image)
        Me.btnVerT.Location = New System.Drawing.Point(328, 17)
        Me.btnVerT.Name = "btnVerT"
        Me.btnVerT.Size = New System.Drawing.Size(62, 52)
        Me.btnVerT.TabIndex = 120
        Me.ToolTip1.SetToolTip(Me.btnVerT, "Ver")
        '
        'btnSalirT
        '
        Me.btnSalirT.BackgroundImage = CType(resources.GetObject("btnSalirT.BackgroundImage"), System.Drawing.Image)
        Me.btnSalirT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalirT.Location = New System.Drawing.Point(390, 17)
        Me.btnSalirT.Name = "btnSalirT"
        Me.btnSalirT.Size = New System.Drawing.Size(62, 52)
        Me.btnSalirT.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.btnSalirT, "Salir")
        Me.btnSalirT.UseVisualStyleBackColor = True
        '
        'btnEliminarT
        '
        Me.btnEliminarT.BackgroundImage = CType(resources.GetObject("btnEliminarT.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarT.Location = New System.Drawing.Point(205, 18)
        Me.btnEliminarT.Name = "btnEliminarT"
        Me.btnEliminarT.Size = New System.Drawing.Size(62, 52)
        Me.btnEliminarT.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnEliminarT, "Eliminar")
        Me.btnEliminarT.UseVisualStyleBackColor = True
        '
        'btnCancelarT
        '
        Me.btnCancelarT.BackgroundImage = CType(resources.GetObject("btnCancelarT.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarT.Location = New System.Drawing.Point(80, 17)
        Me.btnCancelarT.Name = "btnCancelarT"
        Me.btnCancelarT.Size = New System.Drawing.Size(62, 52)
        Me.btnCancelarT.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.btnCancelarT, "Cancelar")
        Me.btnCancelarT.UseVisualStyleBackColor = True
        '
        'btnModificarT
        '
        Me.btnModificarT.BackgroundImage = CType(resources.GetObject("btnModificarT.BackgroundImage"), System.Drawing.Image)
        Me.btnModificarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarT.Location = New System.Drawing.Point(143, 16)
        Me.btnModificarT.Name = "btnModificarT"
        Me.btnModificarT.Size = New System.Drawing.Size(62, 52)
        Me.btnModificarT.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnModificarT, "Modificar")
        Me.btnModificarT.UseVisualStyleBackColor = True
        '
        'btnNuevoT
        '
        Me.btnNuevoT.BackgroundImage = CType(resources.GetObject("btnNuevoT.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevoT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoT.Location = New System.Drawing.Point(17, 17)
        Me.btnNuevoT.Name = "btnNuevoT"
        Me.btnNuevoT.Size = New System.Drawing.Size(62, 52)
        Me.btnNuevoT.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.btnNuevoT, "Nuevo")
        Me.btnNuevoT.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboEspecialidadT)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtBuscarT)
        Me.GroupBox1.Controls.Add(Me.btnBuscarT)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(544, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 127)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar U.D. Transversal"
        '
        'cboEspecialidadT
        '
        Me.cboEspecialidadT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecialidadT.FormattingEnabled = True
        Me.cboEspecialidadT.Location = New System.Drawing.Point(119, 80)
        Me.cboEspecialidadT.Name = "cboEspecialidadT"
        Me.cboEspecialidadT.Size = New System.Drawing.Size(198, 26)
        Me.cboEspecialidadT.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(3, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 16)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "ESPECILIDAD:"
        '
        'txtBuscarT
        '
        Me.txtBuscarT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBuscarT.Location = New System.Drawing.Point(118, 41)
        Me.txtBuscarT.Name = "txtBuscarT"
        Me.txtBuscarT.Size = New System.Drawing.Size(65, 24)
        Me.txtBuscarT.TabIndex = 108
        '
        'btnBuscarT
        '
        Me.btnBuscarT.BackgroundImage = CType(resources.GetObject("btnBuscarT.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarT.Location = New System.Drawing.Point(39, 23)
        Me.btnBuscarT.Name = "btnBuscarT"
        Me.btnBuscarT.Size = New System.Drawing.Size(62, 52)
        Me.btnBuscarT.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.btnBuscarT, "Buscar")
        Me.btnBuscarT.UseVisualStyleBackColor = True
        '
        'lblIdUndDidacT
        '
        Me.lblIdUndDidacT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdUndDidacT.Location = New System.Drawing.Point(259, 100)
        Me.lblIdUndDidacT.Name = "lblIdUndDidacT"
        Me.lblIdUndDidacT.Size = New System.Drawing.Size(59, 20)
        Me.lblIdUndDidacT.TabIndex = 105
        '
        'txtAñoModuloT
        '
        Me.txtAñoModuloT.Location = New System.Drawing.Point(444, 249)
        Me.txtAñoModuloT.Name = "txtAñoModuloT"
        Me.txtAñoModuloT.Size = New System.Drawing.Size(59, 20)
        Me.txtAñoModuloT.TabIndex = 102
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(320, 253)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 16)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "AÑO MÓDULO:"
        '
        'txtHorasT
        '
        Me.txtHorasT.Location = New System.Drawing.Point(169, 219)
        Me.txtHorasT.Name = "txtHorasT"
        Me.txtHorasT.Size = New System.Drawing.Size(41, 20)
        Me.txtHorasT.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "HORAS:"
        '
        'txtCreditoT
        '
        Me.txtCreditoT.Location = New System.Drawing.Point(169, 182)
        Me.txtCreditoT.Name = "txtCreditoT"
        Me.txtCreditoT.Size = New System.Drawing.Size(41, 20)
        Me.txtCreditoT.TabIndex = 95
        '
        'txtIdCicloT
        '
        Me.txtIdCicloT.Location = New System.Drawing.Point(444, 182)
        Me.txtIdCicloT.Name = "txtIdCicloT"
        Me.txtIdCicloT.Size = New System.Drawing.Size(59, 20)
        Me.txtIdCicloT.TabIndex = 94
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "CRÉDITO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(320, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "ID CICLO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNomUndDidacT
        '
        Me.txtNomUndDidacT.Location = New System.Drawing.Point(259, 136)
        Me.txtNomUndDidacT.Name = "txtNomUndDidacT"
        Me.txtNomUndDidacT.Size = New System.Drawing.Size(267, 20)
        Me.txtNomUndDidacT.TabIndex = 91
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(30, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 16)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "NOMBRE DE  UND. DICATICA :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(33, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 16)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "ID UNIDAD DIDÁCTICA :"
        '
        'txtIdModuloT
        '
        Me.txtIdModuloT.Location = New System.Drawing.Point(444, 219)
        Me.txtIdModuloT.Name = "txtIdModuloT"
        Me.txtIdModuloT.Size = New System.Drawing.Size(59, 20)
        Me.txtIdModuloT.TabIndex = 87
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(320, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 16)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "ID MÓDULO:"
        '
        'frmUndDidac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(898, 629)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblusuario)
        Me.DoubleBuffered = True
        Me.Name = "frmUndDidac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UNIDAD DIDÁCTICA "
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVPROFESIONAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtHorasP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCreditoP As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCicloP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIdModuloP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtHorasT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCreditoT As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCicloT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNomUndDidacT As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIdModuloT As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAñoModuloP As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAñoModuloT As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblIdUndDidacP As System.Windows.Forms.Label
    Friend WithEvents lblIdUndDidacT As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEspecialidadT As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarT As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarT As System.Windows.Forms.Button
    Friend WithEvents txtNomUndDidacP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarP As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarP As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardarP As System.Windows.Forms.Button
    Friend WithEvents btnsalirP As System.Windows.Forms.Button
    Friend WithEvents btnEliminarP As System.Windows.Forms.Button
    Friend WithEvents btncancelarP As System.Windows.Forms.Button
    Friend WithEvents btnModificarP As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVOP As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardarT As System.Windows.Forms.Button
    Friend WithEvents btnVerT As System.Windows.Forms.Button
    Friend WithEvents btnSalirT As System.Windows.Forms.Button
    Friend WithEvents btnEliminarT As System.Windows.Forms.Button
    Friend WithEvents btnCancelarT As System.Windows.Forms.Button
    Friend WithEvents btnModificarT As System.Windows.Forms.Button
    Friend WithEvents btnNuevoT As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cboEspecialidadP As System.Windows.Forms.ComboBox
    Friend WithEvents DGVPROFESIONAL As System.Windows.Forms.DataGridView
End Class
