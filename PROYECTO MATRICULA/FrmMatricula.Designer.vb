<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMatricula))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.txtapemat_alum = New System.Windows.Forms.TextBox()
        Me.txtnom_alum = New System.Windows.Forms.TextBox()
        Me.btnbuscaralumno = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Picfotoalum = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.cboespecialidad = New System.Windows.Forms.ComboBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboapepat_alum = New System.Windows.Forms.ComboBox()
        Me.lblIdMatricula = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTbuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Gbtipoingreso = New System.Windows.Forms.GroupBox()
        Me.rbTrasladoI = New System.Windows.Forms.RadioButton()
        Me.RbTrasladoE = New System.Windows.Forms.RadioButton()
        Me.RbAdmision = New System.Windows.Forms.RadioButton()
        Me.txtaño_modulo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbosemestre = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboturno = New System.Windows.Forms.ComboBox()
        Me.cbociclo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.CachedCryRepEspecialidad1 = New WindowsApplication1.CachedCryRepEspecialidad()
        Me.TVREGISTRO = New System.Windows.Forms.TreeView()
        Me.LVLISTA = New System.Windows.Forms.ListView()
        Me.TXTIDALUM = New System.Windows.Forms.TextBox()
        Me.TXTAP_PAT = New System.Windows.Forms.TextBox()
        Me.TXTAPE_MA = New System.Windows.Forms.TextBox()
        Me.TXTNOM = New System.Windows.Forms.TextBox()
        Me.TXTAÑO = New System.Windows.Forms.TextBox()
        Me.TXTESPECIALIDAD = New System.Windows.Forms.TextBox()
        Me.TXTTURNO = New System.Windows.Forms.TextBox()
        Me.TXTEDAD = New System.Windows.Forms.TextBox()
        Me.TXTSEXO = New System.Windows.Forms.TextBox()
        Me.TXTTELE = New System.Windows.Forms.TextBox()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.Picfotoalum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Gbtipoingreso.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(567, 265)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº de Matricula:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo de Alumno:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(28, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre:"
        '
        'txtidalumno
        '
        Me.txtidalumno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtidalumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidalumno.Location = New System.Drawing.Point(211, 21)
        Me.txtidalumno.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.Size = New System.Drawing.Size(34, 20)
        Me.txtidalumno.TabIndex = 6
        '
        'txtapemat_alum
        '
        Me.txtapemat_alum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtapemat_alum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapemat_alum.Location = New System.Drawing.Point(211, 103)
        Me.txtapemat_alum.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtapemat_alum.Name = "txtapemat_alum"
        Me.txtapemat_alum.Size = New System.Drawing.Size(47, 20)
        Me.txtapemat_alum.TabIndex = 8
        '
        'txtnom_alum
        '
        Me.txtnom_alum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnom_alum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom_alum.Location = New System.Drawing.Point(211, 138)
        Me.txtnom_alum.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtnom_alum.Name = "txtnom_alum"
        Me.txtnom_alum.Size = New System.Drawing.Size(47, 20)
        Me.txtnom_alum.TabIndex = 9
        '
        'btnbuscaralumno
        '
        Me.btnbuscaralumno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnbuscaralumno.BackgroundImage = CType(resources.GetObject("btnbuscaralumno.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscaralumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscaralumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscaralumno.Location = New System.Drawing.Point(369, 21)
        Me.btnbuscaralumno.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnbuscaralumno.Name = "btnbuscaralumno"
        Me.btnbuscaralumno.Size = New System.Drawing.Size(70, 41)
        Me.btnbuscaralumno.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnbuscaralumno, "Buscar Datos Alumno")
        Me.btnbuscaralumno.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 194)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Especialidad:"
        '
        'Picfotoalum
        '
        Me.Picfotoalum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Picfotoalum.Location = New System.Drawing.Point(354, 135)
        Me.Picfotoalum.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Picfotoalum.Name = "Picfotoalum"
        Me.Picfotoalum.Size = New System.Drawing.Size(55, 109)
        Me.Picfotoalum.TabIndex = 27
        Me.Picfotoalum.TabStop = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(35, 160)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 18)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "E-mail:"
        '
        'txtcorreo
        '
        Me.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcorreo.Location = New System.Drawing.Point(211, 171)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(47, 20)
        Me.txtcorreo.TabIndex = 29
        '
        'cboespecialidad
        '
        Me.cboespecialidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboespecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboespecialidad.FormattingEnabled = True
        Me.cboespecialidad.Location = New System.Drawing.Point(211, 205)
        Me.cboespecialidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboespecialidad.Name = "cboespecialidad"
        Me.cboespecialidad.Size = New System.Drawing.Size(47, 21)
        Me.cboespecialidad.TabIndex = 19
        '
        'lblusuario
        '
        Me.lblusuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblusuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblusuario.Location = New System.Drawing.Point(982, 183)
        Me.lblusuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(107, 18)
        Me.lblusuario.TabIndex = 35
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfecha.Location = New System.Drawing.Point(345, 619)
        Me.lblfecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(311, 26)
        Me.lblfecha.TabIndex = 36
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(908, 77)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 88)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "CONSULTA - ESTADO DEL  ALUMNO"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cboapepat_alum)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Picfotoalum)
        Me.GroupBox1.Controls.Add(Me.cboespecialidad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnbuscaralumno)
        Me.GroupBox1.Controls.Add(Me.txtnom_alum)
        Me.GroupBox1.Controls.Add(Me.txtapemat_alum)
        Me.GroupBox1.Controls.Add(Me.txtidalumno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(668, 386)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(447, 250)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Alumno a Matricular"
        '
        'cboapepat_alum
        '
        Me.cboapepat_alum.FormattingEnabled = True
        Me.cboapepat_alum.Location = New System.Drawing.Point(200, 54)
        Me.cboapepat_alum.Name = "cboapepat_alum"
        Me.cboapepat_alum.Size = New System.Drawing.Size(34, 26)
        Me.cboapepat_alum.TabIndex = 30
        '
        'lblIdMatricula
        '
        Me.lblIdMatricula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdMatricula.Location = New System.Drawing.Point(720, 268)
        Me.lblIdMatricula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdMatricula.Name = "lblIdMatricula"
        Me.lblIdMatricula.Size = New System.Drawing.Size(71, 23)
        Me.lblIdMatricula.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Controls.Add(Me.TXTbuscar)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.btncancelar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(94, 77)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(739, 70)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'TXTbuscar
        '
        Me.TXTbuscar.BackColor = System.Drawing.Color.LimeGreen
        Me.TXTbuscar.Location = New System.Drawing.Point(293, 28)
        Me.TXTbuscar.Multiline = True
        Me.TXTbuscar.Name = "TXTbuscar"
        Me.TXTbuscar.Size = New System.Drawing.Size(160, 24)
        Me.TXTbuscar.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Location = New System.Drawing.Point(222, 12)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 52)
        Me.btnBuscar.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnguardar.Location = New System.Drawing.Point(79, 12)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(62, 52)
        Me.btnguardar.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.btnguardar, "Guardar")
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImage = CType(resources.GetObject("btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Location = New System.Drawing.Point(635, 12)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(62, 52)
        Me.btnsalir.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.btnsalir, "Salir")
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(559, 12)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(62, 52)
        Me.btnEliminar.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNNUEVO.BackgroundImage = CType(resources.GetObject("BTNNUEVO.BackgroundImage"), System.Drawing.Image)
        Me.BTNNUEVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNNUEVO.Location = New System.Drawing.Point(7, 13)
        Me.BTNNUEVO.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(62, 52)
        Me.BTNNUEVO.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BTNNUEVO, "Nuevo")
        Me.BTNNUEVO.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.Location = New System.Drawing.Point(151, 12)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(62, 52)
        Me.btncancelar.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.btncancelar, "Cancelar")
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = CType(resources.GetObject("btnModificar.BackgroundImage"), System.Drawing.Image)
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(485, 12)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(62, 52)
        Me.btnModificar.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnModificar, "Modificar")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Gbtipoingreso
        '
        Me.Gbtipoingreso.BackColor = System.Drawing.Color.Transparent
        Me.Gbtipoingreso.Controls.Add(Me.rbTrasladoI)
        Me.Gbtipoingreso.Controls.Add(Me.RbTrasladoE)
        Me.Gbtipoingreso.Controls.Add(Me.RbAdmision)
        Me.Gbtipoingreso.Font = New System.Drawing.Font("Georgia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbtipoingreso.Location = New System.Drawing.Point(522, 167)
        Me.Gbtipoingreso.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Gbtipoingreso.Name = "Gbtipoingreso"
        Me.Gbtipoingreso.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Gbtipoingreso.Size = New System.Drawing.Size(446, 70)
        Me.Gbtipoingreso.TabIndex = 115
        Me.Gbtipoingreso.TabStop = False
        Me.Gbtipoingreso.Text = "Tipo de Ingreso"
        '
        'rbTrasladoI
        '
        Me.rbTrasladoI.AutoSize = True
        Me.rbTrasladoI.Location = New System.Drawing.Point(298, 33)
        Me.rbTrasladoI.Name = "rbTrasladoI"
        Me.rbTrasladoI.Size = New System.Drawing.Size(133, 19)
        Me.rbTrasladoI.TabIndex = 2
        Me.rbTrasladoI.TabStop = True
        Me.rbTrasladoI.Text = "Traslado Interno"
        Me.rbTrasladoI.UseVisualStyleBackColor = True
        '
        'RbTrasladoE
        '
        Me.RbTrasladoE.AutoSize = True
        Me.RbTrasladoE.Location = New System.Drawing.Point(146, 33)
        Me.RbTrasladoE.Name = "RbTrasladoE"
        Me.RbTrasladoE.Size = New System.Drawing.Size(136, 19)
        Me.RbTrasladoE.TabIndex = 1
        Me.RbTrasladoE.TabStop = True
        Me.RbTrasladoE.Text = "Traslado Externo"
        Me.RbTrasladoE.UseVisualStyleBackColor = True
        '
        'RbAdmision
        '
        Me.RbAdmision.AutoSize = True
        Me.RbAdmision.Location = New System.Drawing.Point(39, 33)
        Me.RbAdmision.Name = "RbAdmision"
        Me.RbAdmision.Size = New System.Drawing.Size(86, 19)
        Me.RbAdmision.TabIndex = 0
        Me.RbAdmision.TabStop = True
        Me.RbAdmision.Text = "Admisión"
        Me.RbAdmision.UseVisualStyleBackColor = True
        '
        'txtaño_modulo
        '
        Me.txtaño_modulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtaño_modulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaño_modulo.Location = New System.Drawing.Point(1021, 294)
        Me.txtaño_modulo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtaño_modulo.Name = "txtaño_modulo"
        Me.txtaño_modulo.Size = New System.Drawing.Size(119, 21)
        Me.txtaño_modulo.TabIndex = 123
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(837, 297)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 18)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Año  Curricular:"
        '
        'cbosemestre
        '
        Me.cbosemestre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbosemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosemestre.FormattingEnabled = True
        Me.cbosemestre.Location = New System.Drawing.Point(1022, 235)
        Me.cbosemestre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbosemestre.Name = "cbosemestre"
        Me.cbosemestre.Size = New System.Drawing.Size(117, 23)
        Me.cbosemestre.TabIndex = 121
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(800, 240)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 18)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Semestre Academico:"
        '
        'cboturno
        '
        Me.cboturno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboturno.FormattingEnabled = True
        Me.cboturno.Location = New System.Drawing.Point(982, 324)
        Me.cboturno.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboturno.Name = "cboturno"
        Me.cboturno.Size = New System.Drawing.Size(107, 23)
        Me.cboturno.TabIndex = 119
        '
        'cbociclo
        '
        Me.cbociclo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbociclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbociclo.FormattingEnabled = True
        Me.cbociclo.Location = New System.Drawing.Point(1021, 265)
        Me.cbociclo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbociclo.Name = "cbociclo"
        Me.cbociclo.Size = New System.Drawing.Size(119, 23)
        Me.cbociclo.TabIndex = 118
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(905, 326)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 18)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Turno:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(915, 268)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 18)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Ciclo:"
        '
        'Timer1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevotool, Me.ToolStripSeparator3, Me.CANCELARTOOL, Me.ELIMINARTOOL, Me.MODIFICARTOOL, Me.GuardarTool, Me.ToolStripSeparator2, Me.SALIRTOOL, Me.ToolStripSeparator1, Me.BUSCARTOOL})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1140, 45)
        Me.ToolStrip1.TabIndex = 128
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
        'TVREGISTRO
        '
        Me.TVREGISTRO.Location = New System.Drawing.Point(13, 158)
        Me.TVREGISTRO.Name = "TVREGISTRO"
        Me.TVREGISTRO.Size = New System.Drawing.Size(120, 189)
        Me.TVREGISTRO.TabIndex = 129
        '
        'LVLISTA
        '
        Me.LVLISTA.Location = New System.Drawing.Point(139, 165)
        Me.LVLISTA.Name = "LVLISTA"
        Me.LVLISTA.Size = New System.Drawing.Size(360, 168)
        Me.LVLISTA.TabIndex = 130
        Me.LVLISTA.UseCompatibleStateImageBehavior = False
        '
        'TXTIDALUM
        '
        Me.TXTIDALUM.Location = New System.Drawing.Point(282, 358)
        Me.TXTIDALUM.Name = "TXTIDALUM"
        Me.TXTIDALUM.Size = New System.Drawing.Size(100, 21)
        Me.TXTIDALUM.TabIndex = 131
        '
        'TXTAP_PAT
        '
        Me.TXTAP_PAT.Location = New System.Drawing.Point(282, 386)
        Me.TXTAP_PAT.Name = "TXTAP_PAT"
        Me.TXTAP_PAT.Size = New System.Drawing.Size(100, 21)
        Me.TXTAP_PAT.TabIndex = 132
        '
        'TXTAPE_MA
        '
        Me.TXTAPE_MA.Location = New System.Drawing.Point(282, 413)
        Me.TXTAPE_MA.Name = "TXTAPE_MA"
        Me.TXTAPE_MA.Size = New System.Drawing.Size(100, 21)
        Me.TXTAPE_MA.TabIndex = 133
        '
        'TXTNOM
        '
        Me.TXTNOM.Location = New System.Drawing.Point(282, 440)
        Me.TXTNOM.Name = "TXTNOM"
        Me.TXTNOM.Size = New System.Drawing.Size(100, 21)
        Me.TXTNOM.TabIndex = 134
        '
        'TXTAÑO
        '
        Me.TXTAÑO.Location = New System.Drawing.Point(282, 467)
        Me.TXTAÑO.Name = "TXTAÑO"
        Me.TXTAÑO.Size = New System.Drawing.Size(100, 21)
        Me.TXTAÑO.TabIndex = 135
        '
        'TXTESPECIALIDAD
        '
        Me.TXTESPECIALIDAD.Location = New System.Drawing.Point(280, 492)
        Me.TXTESPECIALIDAD.Name = "TXTESPECIALIDAD"
        Me.TXTESPECIALIDAD.Size = New System.Drawing.Size(100, 21)
        Me.TXTESPECIALIDAD.TabIndex = 136
        '
        'TXTTURNO
        '
        Me.TXTTURNO.Location = New System.Drawing.Point(278, 516)
        Me.TXTTURNO.Name = "TXTTURNO"
        Me.TXTTURNO.Size = New System.Drawing.Size(100, 21)
        Me.TXTTURNO.TabIndex = 137
        '
        'TXTEDAD
        '
        Me.TXTEDAD.Location = New System.Drawing.Point(276, 565)
        Me.TXTEDAD.Name = "TXTEDAD"
        Me.TXTEDAD.Size = New System.Drawing.Size(100, 21)
        Me.TXTEDAD.TabIndex = 138
        '
        'TXTSEXO
        '
        Me.TXTSEXO.Location = New System.Drawing.Point(278, 538)
        Me.TXTSEXO.Name = "TXTSEXO"
        Me.TXTSEXO.Size = New System.Drawing.Size(100, 21)
        Me.TXTSEXO.TabIndex = 139
        '
        'TXTTELE
        '
        Me.TXTTELE.Location = New System.Drawing.Point(281, 595)
        Me.TXTTELE.Name = "TXTTELE"
        Me.TXTTELE.Size = New System.Drawing.Size(100, 21)
        Me.TXTTELE.TabIndex = 140
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Location = New System.Drawing.Point(280, 619)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(100, 21)
        Me.TXTEMAIL.TabIndex = 141
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "IDALUMNO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(156, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 15)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = "APE_PATERNO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(160, 415)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 15)
        Me.Label14.TabIndex = 144
        Me.Label14.Text = "APE_MATERNO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(155, 442)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 15)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "NOM__ALUMNO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(163, 467)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 15)
        Me.Label16.TabIndex = 146
        Me.Label16.Text = "AÑO_INGRESO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(124, 497)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(144, 15)
        Me.Label17.TabIndex = 147
        Me.Label17.Text = "NOM_ESPECIALIDAD"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(160, 516)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 15)
        Me.Label18.TabIndex = 148
        Me.Label18.Text = "NOM_TURNO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(211, 541)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 15)
        Me.Label19.TabIndex = 149
        Me.Label19.Text = "EDAD"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(211, 569)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 15)
        Me.Label20.TabIndex = 150
        Me.Label20.Text = "SEXO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(207, 625)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 15)
        Me.Label21.TabIndex = 151
        Me.Label21.Text = "EMAIL"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(176, 595)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 15)
        Me.Label22.TabIndex = 152
        Me.Label22.Text = "TELEFONO"
        '
        'FrmMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1140, 681)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTEMAIL)
        Me.Controls.Add(Me.TXTTELE)
        Me.Controls.Add(Me.TXTSEXO)
        Me.Controls.Add(Me.TXTTURNO)
        Me.Controls.Add(Me.TXTEDAD)
        Me.Controls.Add(Me.TXTESPECIALIDAD)
        Me.Controls.Add(Me.TXTAÑO)
        Me.Controls.Add(Me.TXTNOM)
        Me.Controls.Add(Me.TXTAPE_MA)
        Me.Controls.Add(Me.TXTAP_PAT)
        Me.Controls.Add(Me.TXTIDALUM)
        Me.Controls.Add(Me.LVLISTA)
        Me.Controls.Add(Me.TVREGISTRO)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtaño_modulo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbosemestre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboturno)
        Me.Controls.Add(Me.cbociclo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Gbtipoingreso)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblIdMatricula)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmMatricula"
        Me.Text = "FrmMatricula"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Picfotoalum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Gbtipoingreso.ResumeLayout(False)
        Me.Gbtipoingreso.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtidalumno As System.Windows.Forms.TextBox
    Friend WithEvents txtapemat_alum As System.Windows.Forms.TextBox
    Friend WithEvents txtnom_alum As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscaralumno As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Picfotoalum As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents cboespecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblIdMatricula As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Gbtipoingreso As System.Windows.Forms.GroupBox
    Friend WithEvents RbTrasladoE As System.Windows.Forms.RadioButton
    Friend WithEvents RbAdmision As System.Windows.Forms.RadioButton
    Friend WithEvents TXTbuscar As System.Windows.Forms.TextBox
    Friend WithEvents rbTrasladoI As System.Windows.Forms.RadioButton
    Friend WithEvents txtaño_modulo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbosemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboturno As System.Windows.Forms.ComboBox
    Friend WithEvents cbociclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboapepat_alum As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
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
    Friend WithEvents CachedCryRepEspecialidad1 As WindowsApplication1.CachedCryRepEspecialidad
    Friend WithEvents TVREGISTRO As System.Windows.Forms.TreeView
    Friend WithEvents LVLISTA As System.Windows.Forms.ListView
    Friend WithEvents TXTIDALUM As System.Windows.Forms.TextBox
    Friend WithEvents TXTAP_PAT As System.Windows.Forms.TextBox
    Friend WithEvents TXTAPE_MA As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOM As System.Windows.Forms.TextBox
    Friend WithEvents TXTAÑO As System.Windows.Forms.TextBox
    Friend WithEvents TXTESPECIALIDAD As System.Windows.Forms.TextBox
    Friend WithEvents TXTTURNO As System.Windows.Forms.TextBox
    Friend WithEvents TXTEDAD As System.Windows.Forms.TextBox
    Friend WithEvents TXTSEXO As System.Windows.Forms.TextBox
    Friend WithEvents TXTTELE As System.Windows.Forms.TextBox
    Friend WithEvents TXTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
