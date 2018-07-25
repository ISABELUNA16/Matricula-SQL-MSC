<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEspecialidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEspecialidad))
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.Lblusuario = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGUARDAR = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.txtIdEspeci = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Location = New System.Drawing.Point(36, 248)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(484, 159)
        Me.DataGrid1.TabIndex = 24
        Me.DataGrid1.TabStop = False
        '
        'Lblusuario
        '
        Me.Lblusuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblusuario.Location = New System.Drawing.Point(399, 448)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(97, 20)
        Me.Lblusuario.TabIndex = 29
        Me.Lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Location = New System.Drawing.Point(450, 84)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 52)
        Me.btnBuscar.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnGUARDAR)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 78)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OPCIONES:"
        '
        'btnGUARDAR
        '
        Me.btnGUARDAR.BackgroundImage = CType(resources.GetObject("btnGUARDAR.BackgroundImage"), System.Drawing.Image)
        Me.btnGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGUARDAR.Location = New System.Drawing.Point(260, 14)
        Me.btnGUARDAR.Name = "btnGUARDAR"
        Me.btnGUARDAR.Size = New System.Drawing.Size(62, 52)
        Me.btnGUARDAR.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.btnGUARDAR, "Guardar")
        Me.btnGUARDAR.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImage = CType(resources.GetObject("btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Location = New System.Drawing.Point(328, 14)
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
        Me.btnEliminar.Location = New System.Drawing.Point(197, 16)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(62, 52)
        Me.btnEliminar.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.Location = New System.Drawing.Point(71, 15)
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
        Me.btnModificar.Location = New System.Drawing.Point(133, 16)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(62, 52)
        Me.btnModificar.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnModificar, "Modificar")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.BackgroundImage = CType(resources.GetObject("BTNNUEVO.BackgroundImage"), System.Drawing.Image)
        Me.BTNNUEVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNNUEVO.Location = New System.Drawing.Point(8, 14)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(62, 52)
        Me.BTNNUEVO.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BTNNUEVO, "Nuevo")
        Me.BTNNUEVO.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(439, 142)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(94, 20)
        Me.txtBuscar.TabIndex = 125
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Location = New System.Drawing.Point(209, 204)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(347, 20)
        Me.txtEspecialidad.TabIndex = 124
        '
        'txtIdEspeci
        '
        Me.txtIdEspeci.Location = New System.Drawing.Point(209, 163)
        Me.txtIdEspeci.Name = "txtIdEspeci"
        Me.txtIdEspeci.Size = New System.Drawing.Size(125, 20)
        Me.txtIdEspeci.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "ESPECIALIDAD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 18)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "ID ESPECIALIDAD:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevotool, Me.ToolStripSeparator3, Me.CANCELARTOOL, Me.ELIMINARTOOL, Me.MODIFICARTOOL, Me.GuardarTool, Me.ToolStripSeparator2, Me.SALIRTOOL, Me.ToolStripSeparator1, Me.BUSCARTOOL})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(568, 45)
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
        'frmEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(568, 505)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtEspecialidad)
        Me.Controls.Add(Me.txtIdEspeci)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lblusuario)
        Me.Controls.Add(Me.DataGrid1)
        Me.DoubleBuffered = True
        Me.Name = "frmEspecialidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents Lblusuario As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGUARDAR As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecialidad As System.Windows.Forms.TextBox
    Friend WithEvents txtIdEspeci As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
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
