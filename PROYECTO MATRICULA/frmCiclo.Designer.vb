<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCiclo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCiclo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Lblusuario = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtNumCiclo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdCiclo = New System.Windows.Forms.TextBox()
        Me.txtCiclo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Location = New System.Drawing.Point(9, 188)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(62, 52)
        Me.btnEliminar.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = CType(resources.GetObject("btnModificar.BackgroundImage"), System.Drawing.Image)
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Location = New System.Drawing.Point(9, 130)
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
        Me.btnNuevo.Location = New System.Drawing.Point(7, 18)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 52)
        Me.btnNuevo.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.Location = New System.Drawing.Point(12, 204)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.Size = New System.Drawing.Size(443, 179)
        Me.DataGrid.TabIndex = 36
        Me.DataGrid.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Location = New System.Drawing.Point(352, 83)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 52)
        Me.btnBuscar.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Lblusuario
        '
        Me.Lblusuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblusuario.Location = New System.Drawing.Point(372, 402)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(89, 22)
        Me.Lblusuario.TabIndex = 40
        Me.Lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(467, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(82, 359)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OPCIONES:"
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnguardar.Location = New System.Drawing.Point(7, 250)
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
        Me.btnsalir.Location = New System.Drawing.Point(7, 308)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(62, 52)
        Me.btnsalir.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.btnsalir, "Salir")
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.Location = New System.Drawing.Point(7, 76)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(62, 52)
        Me.btncancelar.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.btncancelar, "Cancelar")
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(352, 158)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(56, 20)
        Me.txtBuscar.TabIndex = 50
        '
        'txtNumCiclo
        '
        Me.txtNumCiclo.Location = New System.Drawing.Point(169, 164)
        Me.txtNumCiclo.Name = "txtNumCiclo"
        Me.txtNumCiclo.Size = New System.Drawing.Size(65, 20)
        Me.txtNumCiclo.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(64, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "ID CICLO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(65, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "CICLO:"
        '
        'txtIdCiclo
        '
        Me.txtIdCiclo.Location = New System.Drawing.Point(169, 89)
        Me.txtIdCiclo.Name = "txtIdCiclo"
        Me.txtIdCiclo.Size = New System.Drawing.Size(75, 20)
        Me.txtIdCiclo.TabIndex = 46
        '
        'txtCiclo
        '
        Me.txtCiclo.Location = New System.Drawing.Point(169, 127)
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.Size = New System.Drawing.Size(91, 20)
        Me.txtCiclo.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(65, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "NÚMERO:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevotool, Me.ToolStripSeparator3, Me.CANCELARTOOL, Me.ELIMINARTOOL, Me.MODIFICARTOOL, Me.GuardarTool, Me.ToolStripSeparator2, Me.SALIRTOOL, Me.ToolStripSeparator1, Me.BUSCARTOOL})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(558, 45)
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
        'frmCiclo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(558, 487)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtNumCiclo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdCiclo)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtCiclo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lblusuario)
        Me.Controls.Add(Me.DataGrid)
        Me.DoubleBuffered = True
        Me.Name = "frmCiclo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CICLO"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Lblusuario As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents txtNumCiclo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdCiclo As System.Windows.Forms.TextBox
    Friend WithEvents txtCiclo As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnguardar As System.Windows.Forms.Button
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
