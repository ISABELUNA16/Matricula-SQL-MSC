<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemestre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSemestre))
        Me.txtIdSemestre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Lblusuario = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnSalirT = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtFecIni = New System.Windows.Forms.MaskedTextBox()
        Me.txtFecFin = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
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
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIdSemestre
        '
        Me.txtIdSemestre.Location = New System.Drawing.Point(278, 140)
        Me.txtIdSemestre.Name = "txtIdSemestre"
        Me.txtIdSemestre.Size = New System.Drawing.Size(75, 20)
        Me.txtIdSemestre.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(150, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "FECHA_INICIO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(150, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID SEMESTRE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(150, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "FECHA_FIN:"
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToAddRows = False
        Me.DataGrid1.AllowUserToDeleteRows = False
        Me.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Location = New System.Drawing.Point(95, 254)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(412, 131)
        Me.DataGrid1.TabIndex = 29
        Me.DataGrid1.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(506, 62)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(65, 20)
        Me.txtBuscar.TabIndex = 32
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Location = New System.Drawing.Point(431, 62)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 52)
        Me.btnBuscar.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Lblusuario
        '
        Me.Lblusuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblusuario.Location = New System.Drawing.Point(506, 416)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(80, 16)
        Me.Lblusuario.TabIndex = 33
        Me.Lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.BtnGuardar)
        Me.GroupBox9.Controls.Add(Me.BtnSalirT)
        Me.GroupBox9.Controls.Add(Me.btnEliminar)
        Me.GroupBox9.Controls.Add(Me.BtnCancelar)
        Me.GroupBox9.Controls.Add(Me.btnModificar)
        Me.GroupBox9.Controls.Add(Me.btnNuevo)
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(22, 48)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(387, 79)
        Me.GroupBox9.TabIndex = 117
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "OPCIONES:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardar.Location = New System.Drawing.Point(256, 19)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(62, 52)
        Me.BtnGuardar.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Guardar")
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnSalirT
        '
        Me.BtnSalirT.BackgroundImage = CType(resources.GetObject("BtnSalirT.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalirT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalirT.Location = New System.Drawing.Point(319, 18)
        Me.BtnSalirT.Name = "BtnSalirT"
        Me.BtnSalirT.Size = New System.Drawing.Size(62, 52)
        Me.BtnSalirT.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.BtnSalirT, "Salir")
        Me.BtnSalirT.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Location = New System.Drawing.Point(193, 20)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(62, 52)
        Me.btnEliminar.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Location = New System.Drawing.Point(69, 20)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(62, 52)
        Me.BtnCancelar.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, "Cancelar")
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = CType(resources.GetObject("btnModificar.BackgroundImage"), System.Drawing.Image)
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Location = New System.Drawing.Point(132, 21)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(62, 52)
        Me.btnModificar.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnModificar, "Modificar")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Location = New System.Drawing.Point(7, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 52)
        Me.btnNuevo.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtFecIni
        '
        Me.txtFecIni.Location = New System.Drawing.Point(278, 173)
        Me.txtFecIni.Mask = "00/00/0000"
        Me.txtFecIni.Name = "txtFecIni"
        Me.txtFecIni.Size = New System.Drawing.Size(100, 20)
        Me.txtFecIni.TabIndex = 118
        Me.txtFecIni.ValidatingType = GetType(Date)
        '
        'txtFecFin
        '
        Me.txtFecFin.Location = New System.Drawing.Point(278, 209)
        Me.txtFecFin.Mask = "00/00/0000"
        Me.txtFecFin.Name = "txtFecFin"
        Me.txtFecFin.Size = New System.Drawing.Size(100, 20)
        Me.txtFecFin.TabIndex = 119
        Me.txtFecFin.ValidatingType = GetType(Date)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevotool, Me.ToolStripSeparator3, Me.CANCELARTOOL, Me.ELIMINARTOOL, Me.MODIFICARTOOL, Me.GuardarTool, Me.ToolStripSeparator2, Me.SALIRTOOL, Me.ToolStripSeparator1, Me.BUSCARTOOL})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(600, 45)
        Me.ToolStrip1.TabIndex = 130
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
        'frmSemestre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 445)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtFecFin)
        Me.Controls.Add(Me.txtFecIni)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Lblusuario)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdSemestre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frmSemestre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEMESTRE"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdSemestre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Lblusuario As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnSalirT As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtFecIni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFecFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
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
End Class
