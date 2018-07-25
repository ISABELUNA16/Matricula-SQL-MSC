<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRepAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRepAlumno))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboCiclo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboTurno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboSemestre = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGListaAlumnos = New System.Windows.Forms.DataGridView()
        CType(Me.DGListaAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Especialidad:"
        '
        'CboEspecialidad
        '
        Me.CboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEspecialidad.FormattingEnabled = True
        Me.CboEspecialidad.Location = New System.Drawing.Point(154, 61)
        Me.CboEspecialidad.Margin = New System.Windows.Forms.Padding(4)
        Me.CboEspecialidad.Name = "CboEspecialidad"
        Me.CboEspecialidad.Size = New System.Drawing.Size(217, 26)
        Me.CboEspecialidad.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(405, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ciclo:"
        '
        'CboCiclo
        '
        Me.CboCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCiclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCiclo.FormattingEnabled = True
        Me.CboCiclo.Location = New System.Drawing.Point(483, 57)
        Me.CboCiclo.Margin = New System.Windows.Forms.Padding(4)
        Me.CboCiclo.Name = "CboCiclo"
        Me.CboCiclo.Size = New System.Drawing.Size(169, 24)
        Me.CboCiclo.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(405, 119)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Turno:"
        '
        'CboTurno
        '
        Me.CboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTurno.FormattingEnabled = True
        Me.CboTurno.Location = New System.Drawing.Point(483, 113)
        Me.CboTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.CboTurno.Name = "CboTurno"
        Me.CboTurno.Size = New System.Drawing.Size(169, 24)
        Me.CboTurno.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(30, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Semestre:"
        '
        'CboSemestre
        '
        Me.CboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSemestre.FormattingEnabled = True
        Me.CboSemestre.Location = New System.Drawing.Point(154, 117)
        Me.CboSemestre.Margin = New System.Windows.Forms.Padding(4)
        Me.CboSemestre.Name = "CboSemestre"
        Me.CboSemestre.Size = New System.Drawing.Size(217, 26)
        Me.CboSemestre.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(683, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Mostrar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.Resources.buscar
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(717, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 82)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DGListaAlumnos
        '
        Me.DGListaAlumnos.AllowUserToOrderColumns = True
        Me.DGListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListaAlumnos.Location = New System.Drawing.Point(12, 170)
        Me.DGListaAlumnos.Name = "DGListaAlumnos"
        Me.DGListaAlumnos.Size = New System.Drawing.Size(819, 165)
        Me.DGListaAlumnos.TabIndex = 13
        '
        'FormRepAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(843, 419)
        Me.Controls.Add(Me.DGListaAlumnos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CboSemestre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CboTurno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CboCiclo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboEspecialidad)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRepAlumno"
        Me.Text = "FormRepAlumno"
        CType(Me.DGListaAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DGListaAlumnos As System.Windows.Forms.DataGridView
End Class
