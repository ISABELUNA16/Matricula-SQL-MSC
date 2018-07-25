<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotas))
        Me.cboModulo = New System.Windows.Forms.ComboBox()
        Me.DTGNOTAS = New System.Windows.Forms.DataGridView()
        Me.cboDocente = New System.Windows.Forms.ComboBox()
        Me.cboUdDidactica = New System.Windows.Forms.ComboBox()
        Me.cboTurno = New System.Windows.Forms.ComboBox()
        Me.cboSemestre = New System.Windows.Forms.ComboBox()
        Me.cboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBOCICLO = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTAÑO_MODULO = New System.Windows.Forms.TextBox()
        Me.LBLUSUARIO = New System.Windows.Forms.Label()
        Me.Gbmodulo = New System.Windows.Forms.GroupBox()
        Me.RBMPROFESIONAL = New System.Windows.Forms.RadioButton()
        Me.RBMTRANSVERSAL = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        CType(Me.DTGNOTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbmodulo.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboModulo
        '
        Me.cboModulo.FormattingEnabled = True
        Me.cboModulo.Location = New System.Drawing.Point(167, 188)
        Me.cboModulo.Name = "cboModulo"
        Me.cboModulo.Size = New System.Drawing.Size(199, 21)
        Me.cboModulo.TabIndex = 29
        '
        'DTGNOTAS
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGNOTAS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DTGNOTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTGNOTAS.DefaultCellStyle = DataGridViewCellStyle6
        Me.DTGNOTAS.Location = New System.Drawing.Point(402, 31)
        Me.DTGNOTAS.Name = "DTGNOTAS"
        Me.DTGNOTAS.Size = New System.Drawing.Size(418, 421)
        Me.DTGNOTAS.TabIndex = 25
        '
        'cboDocente
        '
        Me.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocente.FormattingEnabled = True
        Me.cboDocente.Location = New System.Drawing.Point(181, 393)
        Me.cboDocente.Name = "cboDocente"
        Me.cboDocente.Size = New System.Drawing.Size(199, 21)
        Me.cboDocente.TabIndex = 24
        '
        'cboUdDidactica
        '
        Me.cboUdDidactica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUdDidactica.FormattingEnabled = True
        Me.cboUdDidactica.Location = New System.Drawing.Point(167, 263)
        Me.cboUdDidactica.Name = "cboUdDidactica"
        Me.cboUdDidactica.Size = New System.Drawing.Size(199, 21)
        Me.cboUdDidactica.TabIndex = 23
        '
        'cboTurno
        '
        Me.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTurno.FormattingEnabled = True
        Me.cboTurno.Location = New System.Drawing.Point(169, 351)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.Size = New System.Drawing.Size(199, 21)
        Me.cboTurno.TabIndex = 22
        '
        'cboSemestre
        '
        Me.cboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemestre.FormattingEnabled = True
        Me.cboSemestre.Location = New System.Drawing.Point(169, 308)
        Me.cboSemestre.Name = "cboSemestre"
        Me.cboSemestre.Size = New System.Drawing.Size(120, 21)
        Me.cboSemestre.TabIndex = 21
        '
        'cboEspecialidad
        '
        Me.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecialidad.FormattingEnabled = True
        Me.cboEspecialidad.Location = New System.Drawing.Point(167, 86)
        Me.cboEspecialidad.Name = "cboEspecialidad"
        Me.cboEspecialidad.Size = New System.Drawing.Size(199, 21)
        Me.cboEspecialidad.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "DOCENTE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "UND. DIDACTICA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "TURNO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "SEMESTRE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(12, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ESPECIALIDAD:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "CICLO:"
        '
        'CBOCICLO
        '
        Me.CBOCICLO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCICLO.FormattingEnabled = True
        Me.CBOCICLO.Location = New System.Drawing.Point(169, 226)
        Me.CBOCICLO.Name = "CBOCICLO"
        Me.CBOCICLO.Size = New System.Drawing.Size(120, 21)
        Me.CBOCICLO.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(17, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "AÑO CURRICULAR:"
        '
        'TXTAÑO_MODULO
        '
        Me.TXTAÑO_MODULO.Location = New System.Drawing.Point(169, 39)
        Me.TXTAÑO_MODULO.Name = "TXTAÑO_MODULO"
        Me.TXTAÑO_MODULO.Size = New System.Drawing.Size(100, 20)
        Me.TXTAÑO_MODULO.TabIndex = 33
        Me.TXTAÑO_MODULO.Text = " "
        '
        'LBLUSUARIO
        '
        Me.LBLUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLUSUARIO.Location = New System.Drawing.Point(762, 471)
        Me.LBLUSUARIO.Name = "LBLUSUARIO"
        Me.LBLUSUARIO.Size = New System.Drawing.Size(58, 15)
        Me.LBLUSUARIO.TabIndex = 34
        '
        'Gbmodulo
        '
        Me.Gbmodulo.BackColor = System.Drawing.Color.Transparent
        Me.Gbmodulo.Controls.Add(Me.RBMPROFESIONAL)
        Me.Gbmodulo.Controls.Add(Me.RBMTRANSVERSAL)
        Me.Gbmodulo.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbmodulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Gbmodulo.Location = New System.Drawing.Point(15, 131)
        Me.Gbmodulo.Name = "Gbmodulo"
        Me.Gbmodulo.Size = New System.Drawing.Size(365, 39)
        Me.Gbmodulo.TabIndex = 53
        Me.Gbmodulo.TabStop = False
        Me.Gbmodulo.Text = "MODULOS:"
        '
        'RBMPROFESIONAL
        '
        Me.RBMPROFESIONAL.AutoSize = True
        Me.RBMPROFESIONAL.BackColor = System.Drawing.Color.Transparent
        Me.RBMPROFESIONAL.Location = New System.Drawing.Point(89, 12)
        Me.RBMPROFESIONAL.Name = "RBMPROFESIONAL"
        Me.RBMPROFESIONAL.Size = New System.Drawing.Size(130, 20)
        Me.RBMPROFESIONAL.TabIndex = 52
        Me.RBMPROFESIONAL.TabStop = True
        Me.RBMPROFESIONAL.Text = "M. Profesional"
        Me.RBMPROFESIONAL.UseVisualStyleBackColor = False
        '
        'RBMTRANSVERSAL
        '
        Me.RBMTRANSVERSAL.AutoSize = True
        Me.RBMTRANSVERSAL.BackColor = System.Drawing.Color.Transparent
        Me.RBMTRANSVERSAL.Location = New System.Drawing.Point(225, 12)
        Me.RBMTRANSVERSAL.Name = "RBMTRANSVERSAL"
        Me.RBMTRANSVERSAL.Size = New System.Drawing.Size(134, 20)
        Me.RBMTRANSVERSAL.TabIndex = 53
        Me.RBMTRANSVERSAL.TabStop = True
        Me.RBMTRANSVERSAL.Text = "M. Transversal"
        Me.RBMTRANSVERSAL.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.BtnGuardar)
        Me.GroupBox4.Controls.Add(Me.btnimprimir)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(212, 438)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(184, 64)
        Me.GroupBox4.TabIndex = 118
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "OPCIONES:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardar.Location = New System.Drawing.Point(28, 14)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(44, 44)
        Me.BtnGuardar.TabIndex = 119
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.BackgroundImage = CType(resources.GetObject("btnimprimir.BackgroundImage"), System.Drawing.Image)
        Me.btnimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnimprimir.Location = New System.Drawing.Point(112, 14)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(44, 44)
        Me.btnimprimir.TabIndex = 115
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(482, 467)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 120
        '
        'FrmNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 514)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Gbmodulo)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.LBLUSUARIO)
        Me.Controls.Add(Me.TXTAÑO_MODULO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBOCICLO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboModulo)
        Me.Controls.Add(Me.DTGNOTAS)
        Me.Controls.Add(Me.cboDocente)
        Me.Controls.Add(Me.cboUdDidactica)
        Me.Controls.Add(Me.cboTurno)
        Me.Controls.Add(Me.cboSemestre)
        Me.Controls.Add(Me.cboEspecialidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "FrmNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmNotas"
        CType(Me.DTGNOTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbmodulo.ResumeLayout(False)
        Me.Gbmodulo.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboModulo As System.Windows.Forms.ComboBox
    Friend WithEvents DTGNOTAS As System.Windows.Forms.DataGridView
    Friend WithEvents cboDocente As System.Windows.Forms.ComboBox
    Friend WithEvents cboUdDidactica As System.Windows.Forms.ComboBox
    Friend WithEvents cboTurno As System.Windows.Forms.ComboBox
    Friend WithEvents cboSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents cboEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBOCICLO As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTAÑO_MODULO As System.Windows.Forms.TextBox
    Friend WithEvents LBLUSUARIO As System.Windows.Forms.Label
    Friend WithEvents Gbmodulo As System.Windows.Forms.GroupBox
    Friend WithEvents RBMPROFESIONAL As System.Windows.Forms.RadioButton
    Friend WithEvents RBMTRANSVERSAL As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
End Class
