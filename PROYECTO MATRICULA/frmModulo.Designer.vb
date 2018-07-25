<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModulo))
        Me.lblFecHora = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.lblIdModuloP = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboespecialidadP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscarP = New System.Windows.Forms.TextBox()
        Me.btnBuscarP = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnEliminarP = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnModificarP = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.txtAñoP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNomModuloP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvt = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarT = New System.Windows.Forms.Button()
        Me.btnVerT = New System.Windows.Forms.Button()
        Me.btnSalirT = New System.Windows.Forms.Button()
        Me.btnEliminarT = New System.Windows.Forms.Button()
        Me.btnCancelarT = New System.Windows.Forms.Button()
        Me.btnModificarT = New System.Windows.Forms.Button()
        Me.btnNuevoT = New System.Windows.Forms.Button()
        Me.lblIdModuloT = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CboEspecialidadT = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBuscarT = New System.Windows.Forms.TextBox()
        Me.BtnBuscarT = New System.Windows.Forms.Button()
        Me.TxtAñoT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNomModuloT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.nuevotool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CANCELARTOOL = New System.Windows.Forms.ToolStripButton()
        Me.ELIMINARTOOL = New System.Windows.Forms.ToolStripButton()
        Me.MODIFICARTOOL = New System.Windows.Forms.ToolStripButton()
        Me.GuardarTool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SALIRTOOL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BUSCARTOOL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecHora
        '
        Me.lblFecHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecHora.Location = New System.Drawing.Point(318, 591)
        Me.lblFecHora.Name = "lblFecHora"
        Me.lblFecHora.Size = New System.Drawing.Size(149, 21)
        Me.lblFecHora.TabIndex = 42
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsuario.Location = New System.Drawing.Point(690, 591)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(80, 21)
        Me.lblUsuario.TabIndex = 43
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(882, 519)
        Me.TabControl1.TabIndex = 44
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.DataGrid)
        Me.TabPage1.Controls.Add(Me.lblIdModuloP)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.txtAñoP)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtNomModuloP)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(874, 493)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Módulo Profesional"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGrid
        '
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(12, 270)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(840, 203)
        Me.DataGrid.TabIndex = 58
        Me.DataGrid.TabStop = False
        '
        'lblIdModuloP
        '
        Me.lblIdModuloP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdModuloP.Location = New System.Drawing.Point(203, 168)
        Me.lblIdModuloP.Name = "lblIdModuloP"
        Me.lblIdModuloP.Size = New System.Drawing.Size(71, 21)
        Me.lblIdModuloP.TabIndex = 119
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboespecialidadP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBuscarP)
        Me.GroupBox1.Controls.Add(Me.btnBuscarP)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(436, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 120)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Módulo Profesional"
        '
        'CboespecialidadP
        '
        Me.CboespecialidadP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CboespecialidadP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboespecialidadP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboespecialidadP.FormattingEnabled = True
        Me.CboespecialidadP.Location = New System.Drawing.Point(116, 77)
        Me.CboespecialidadP.Name = "CboespecialidadP"
        Me.CboespecialidadP.Size = New System.Drawing.Size(241, 21)
        Me.CboespecialidadP.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Especialidad:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtBuscarP
        '
        Me.txtBuscarP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBuscarP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBuscarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarP.Location = New System.Drawing.Point(116, 39)
        Me.txtBuscarP.Name = "txtBuscarP"
        Me.txtBuscarP.Size = New System.Drawing.Size(66, 20)
        Me.txtBuscarP.TabIndex = 60
        '
        'btnBuscarP
        '
        Me.btnBuscarP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscarP.BackgroundImage = CType(resources.GetObject("btnBuscarP.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarP.Location = New System.Drawing.Point(46, 23)
        Me.btnBuscarP.Name = "btnBuscarP"
        Me.btnBuscarP.Size = New System.Drawing.Size(62, 52)
        Me.btnBuscarP.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.btnBuscarP, "Buscar")
        Me.btnBuscarP.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnGuardarP)
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.btnEliminarP)
        Me.GroupBox2.Controls.Add(Me.btncancelar)
        Me.GroupBox2.Controls.Add(Me.btnModificarP)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(407, 76)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPCIONES:"
        '
        'btnGuardarP
        '
        Me.btnGuardarP.BackgroundImage = CType(resources.GetObject("btnGuardarP.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarP.Location = New System.Drawing.Point(271, 19)
        Me.btnGuardarP.Name = "btnGuardarP"
        Me.btnGuardarP.Size = New System.Drawing.Size(62, 52)
        Me.btnGuardarP.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.btnGuardarP, "Guardar")
        Me.btnGuardarP.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImage = CType(resources.GetObject("btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Location = New System.Drawing.Point(336, 17)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(62, 52)
        Me.btnsalir.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.btnsalir, "Salir")
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnEliminarP
        '
        Me.btnEliminarP.BackgroundImage = CType(resources.GetObject("btnEliminarP.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarP.Location = New System.Drawing.Point(206, 18)
        Me.btnEliminarP.Name = "btnEliminarP"
        Me.btnEliminarP.Size = New System.Drawing.Size(62, 52)
        Me.btnEliminarP.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnEliminarP, "Eliminar")
        Me.btnEliminarP.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.Location = New System.Drawing.Point(80, 17)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(62, 52)
        Me.btncancelar.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.btncancelar, "Cancelar")
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnModificarP
        '
        Me.btnModificarP.BackgroundImage = CType(resources.GetObject("btnModificarP.BackgroundImage"), System.Drawing.Image)
        Me.btnModificarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarP.Location = New System.Drawing.Point(145, 18)
        Me.btnModificarP.Name = "btnModificarP"
        Me.btnModificarP.Size = New System.Drawing.Size(62, 52)
        Me.btnModificarP.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnModificarP, "Modificar")
        Me.btnModificarP.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.BackgroundImage = CType(resources.GetObject("BTNNUEVO.BackgroundImage"), System.Drawing.Image)
        Me.BTNNUEVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNNUEVO.Location = New System.Drawing.Point(17, 17)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(62, 52)
        Me.BTNNUEVO.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BTNNUEVO, "Nuevo")
        Me.BTNNUEVO.UseVisualStyleBackColor = True
        '
        'txtAñoP
        '
        Me.txtAñoP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAñoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAñoP.Location = New System.Drawing.Point(203, 234)
        Me.txtAñoP.Name = "txtAñoP"
        Me.txtAñoP.Size = New System.Drawing.Size(277, 20)
        Me.txtAñoP.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(40, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Año:"
        '
        'txtNomModuloP
        '
        Me.txtNomModuloP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomModuloP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomModuloP.Location = New System.Drawing.Point(203, 203)
        Me.txtNomModuloP.Name = "txtNomModuloP"
        Me.txtNomModuloP.Size = New System.Drawing.Size(491, 20)
        Me.txtNomModuloP.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Módulo:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Id Módulo:"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Controls.Add(Me.dgvt)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.lblIdModuloT)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.TxtAñoT)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtNomModuloT)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(874, 493)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Módulo Transversal"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvt
        '
        Me.dgvt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt.Location = New System.Drawing.Point(26, 278)
        Me.dgvt.Name = "dgvt"
        Me.dgvt.Size = New System.Drawing.Size(819, 199)
        Me.dgvt.TabIndex = 121
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnGuardarT)
        Me.GroupBox3.Controls.Add(Me.btnVerT)
        Me.GroupBox3.Controls.Add(Me.btnSalirT)
        Me.GroupBox3.Controls.Add(Me.btnEliminarT)
        Me.GroupBox3.Controls.Add(Me.btnCancelarT)
        Me.GroupBox3.Controls.Add(Me.btnModificarT)
        Me.GroupBox3.Controls.Add(Me.btnNuevoT)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 76)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OPCIONES:"
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
        Me.btnEliminarT.Location = New System.Drawing.Point(204, 18)
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
        Me.btnModificarT.Location = New System.Drawing.Point(142, 18)
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
        'lblIdModuloT
        '
        Me.lblIdModuloT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdModuloT.Location = New System.Drawing.Point(199, 152)
        Me.lblIdModuloT.Name = "lblIdModuloT"
        Me.lblIdModuloT.Size = New System.Drawing.Size(100, 23)
        Me.lblIdModuloT.TabIndex = 59
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CboEspecialidadT)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TxtBuscarT)
        Me.GroupBox4.Controls.Add(Me.BtnBuscarT)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(482, 69)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(386, 120)
        Me.GroupBox4.TabIndex = 117
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar Módulo Transversal"
        '
        'CboEspecialidadT
        '
        Me.CboEspecialidadT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboEspecialidadT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEspecialidadT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEspecialidadT.FormattingEnabled = True
        Me.CboEspecialidadT.Location = New System.Drawing.Point(147, 72)
        Me.CboEspecialidadT.Name = "CboEspecialidadT"
        Me.CboEspecialidadT.Size = New System.Drawing.Size(233, 21)
        Me.CboEspecialidadT.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 18)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "ESPECIALIDAD:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtBuscarT
        '
        Me.TxtBuscarT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBuscarT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtBuscarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarT.Location = New System.Drawing.Point(159, 34)
        Me.TxtBuscarT.Name = "TxtBuscarT"
        Me.TxtBuscarT.Size = New System.Drawing.Size(64, 20)
        Me.TxtBuscarT.TabIndex = 74
        '
        'BtnBuscarT
        '
        Me.BtnBuscarT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBuscarT.BackgroundImage = CType(resources.GetObject("BtnBuscarT.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarT.Location = New System.Drawing.Point(62, 21)
        Me.BtnBuscarT.Name = "BtnBuscarT"
        Me.BtnBuscarT.Size = New System.Drawing.Size(62, 52)
        Me.BtnBuscarT.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.BtnBuscarT, "Buscar")
        Me.BtnBuscarT.UseVisualStyleBackColor = True
        '
        'TxtAñoT
        '
        Me.TxtAñoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAñoT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAñoT.Location = New System.Drawing.Point(199, 240)
        Me.TxtAñoT.Name = "TxtAñoT"
        Me.TxtAñoT.Size = New System.Drawing.Size(315, 20)
        Me.TxtAñoT.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "AÑO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtNomModuloT
        '
        Me.TxtNomModuloT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNomModuloT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomModuloT.Location = New System.Drawing.Point(199, 199)
        Me.TxtNomModuloT.Name = "TxtNomModuloT"
        Me.TxtNomModuloT.Size = New System.Drawing.Size(538, 20)
        Me.TxtNomModuloT.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "MÓDULO:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(36, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 18)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "ID MÓDULO:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevotool, Me.ToolStripSeparator3, Me.CANCELARTOOL, Me.ELIMINARTOOL, Me.MODIFICARTOOL, Me.GuardarTool, Me.ToolStripSeparator2, Me.SALIRTOOL, Me.ToolStripSeparator1, Me.BUSCARTOOL})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(868, 45)
        Me.ToolStrip1.TabIndex = 129
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'nuevotool
        '
        Me.nuevotool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.nuevotool.Image = CType(resources.GetObject("nuevotool.Image"), System.Drawing.Image)
        Me.nuevotool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.nuevotool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nuevotool.Name = "nuevotool"
        Me.nuevotool.Size = New System.Drawing.Size(42, 42)
        Me.nuevotool.Text = "&Nuevo"
        Me.nuevotool.ToolTipText = "NUEVO"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 45)
        '
        'CANCELARTOOL
        '
        Me.CANCELARTOOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CANCELARTOOL.Image = CType(resources.GetObject("CANCELARTOOL.Image"), System.Drawing.Image)
        Me.CANCELARTOOL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CANCELARTOOL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CANCELARTOOL.Name = "CANCELARTOOL"
        Me.CANCELARTOOL.Size = New System.Drawing.Size(42, 42)
        Me.CANCELARTOOL.Text = "ToolStripButton1"
        Me.CANCELARTOOL.ToolTipText = "CANCELAR"
        '
        'ELIMINARTOOL
        '
        Me.ELIMINARTOOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ELIMINARTOOL.Image = CType(resources.GetObject("ELIMINARTOOL.Image"), System.Drawing.Image)
        Me.ELIMINARTOOL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ELIMINARTOOL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ELIMINARTOOL.Name = "ELIMINARTOOL"
        Me.ELIMINARTOOL.Size = New System.Drawing.Size(43, 42)
        Me.ELIMINARTOOL.Text = "ToolStripButton2"
        Me.ELIMINARTOOL.ToolTipText = "ELIMINAR"
        '
        'MODIFICARTOOL
        '
        Me.MODIFICARTOOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MODIFICARTOOL.Image = CType(resources.GetObject("MODIFICARTOOL.Image"), System.Drawing.Image)
        Me.MODIFICARTOOL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MODIFICARTOOL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MODIFICARTOOL.Name = "MODIFICARTOOL"
        Me.MODIFICARTOOL.Size = New System.Drawing.Size(45, 42)
        Me.MODIFICARTOOL.Text = "ToolStripButton3"
        Me.MODIFICARTOOL.ToolTipText = "MODIFICAR"
        '
        'GuardarTool
        '
        Me.GuardarTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarTool.Image = CType(resources.GetObject("GuardarTool.Image"), System.Drawing.Image)
        Me.GuardarTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GuardarTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarTool.Name = "GuardarTool"
        Me.GuardarTool.Size = New System.Drawing.Size(43, 42)
        Me.GuardarTool.Text = "&Guardar"
        Me.GuardarTool.ToolTipText = "GUARDAR"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 45)
        '
        'SALIRTOOL
        '
        Me.SALIRTOOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SALIRTOOL.Image = CType(resources.GetObject("SALIRTOOL.Image"), System.Drawing.Image)
        Me.SALIRTOOL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SALIRTOOL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SALIRTOOL.Name = "SALIRTOOL"
        Me.SALIRTOOL.Size = New System.Drawing.Size(43, 42)
        Me.SALIRTOOL.Text = "ToolStripButton4"
        Me.SALIRTOOL.ToolTipText = "SALIR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 45)
        '
        'BUSCARTOOL
        '
        Me.BUSCARTOOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BUSCARTOOL.Image = CType(resources.GetObject("BUSCARTOOL.Image"), System.Drawing.Image)
        Me.BUSCARTOOL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BUSCARTOOL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BUSCARTOOL.Name = "BUSCARTOOL"
        Me.BUSCARTOOL.Size = New System.Drawing.Size(45, 42)
        Me.BUSCARTOOL.Text = "ToolStripButton5"
        Me.BUSCARTOOL.ToolTipText = "BUSCAR"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator5, Me.ToolStripButton6, Me.ToolStripSeparator6, Me.ToolStripButton7})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(868, 45)
        Me.ToolStrip2.TabIndex = 129
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(42, 42)
        Me.ToolStripButton1.Text = "&Nuevo"
        Me.ToolStripButton1.ToolTipText = "NUEVO"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 45)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(42, 42)
        Me.ToolStripButton2.Text = "ToolStripButton1"
        Me.ToolStripButton2.ToolTipText = "CANCELAR"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(43, 42)
        Me.ToolStripButton3.Text = "ToolStripButton2"
        Me.ToolStripButton3.ToolTipText = "ELIMINAR"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(45, 42)
        Me.ToolStripButton4.Text = "ToolStripButton3"
        Me.ToolStripButton4.ToolTipText = "MODIFICAR"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(43, 42)
        Me.ToolStripButton5.Text = "&Guardar"
        Me.ToolStripButton5.ToolTipText = "GUARDAR"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 45)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(43, 42)
        Me.ToolStripButton6.Text = "ToolStripButton4"
        Me.ToolStripButton6.ToolTipText = "SALIR"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 45)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(45, 42)
        Me.ToolStripButton7.Text = "ToolStripButton5"
        Me.ToolStripButton7.ToolTipText = "BUSCAR"
        '
        'frmModulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(881, 648)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblFecHora)
        Me.DoubleBuffered = True
        Me.Name = "frmModulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MÓDULO"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblFecHora As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnBuscarP As System.Windows.Forms.Button
    Friend WithEvents txtAñoP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNomModuloP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TxtAñoT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNomModuloT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardarP As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminarP As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnModificarP As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscarT As System.Windows.Forms.Button
    Friend WithEvents txtBuscarP As System.Windows.Forms.TextBox
    Friend WithEvents lblIdModuloP As System.Windows.Forms.Label
    Friend WithEvents CboespecialidadP As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboEspecialidadT As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarT As System.Windows.Forms.TextBox
    Friend WithEvents lblIdModuloT As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardarT As System.Windows.Forms.Button
    Friend WithEvents btnVerT As System.Windows.Forms.Button
    Friend WithEvents btnSalirT As System.Windows.Forms.Button
    Friend WithEvents btnEliminarT As System.Windows.Forms.Button
    Friend WithEvents btnCancelarT As System.Windows.Forms.Button
    Friend WithEvents btnModificarT As System.Windows.Forms.Button
    Friend WithEvents btnNuevoT As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dgvt As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents nuevotool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CANCELARTOOL As System.Windows.Forms.ToolStripButton
    Friend WithEvents ELIMINARTOOL As System.Windows.Forms.ToolStripButton
    Friend WithEvents MODIFICARTOOL As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarTool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SALIRTOOL As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BUSCARTOOL As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
End Class
