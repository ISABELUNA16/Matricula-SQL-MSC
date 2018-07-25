<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteNotas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodAlumno = New System.Windows.Forms.TextBox()
        Me.BtnVerNotaAlumno = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblCiclo = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Alumno:"
        '
        'TxtCodAlumno
        '
        Me.TxtCodAlumno.Location = New System.Drawing.Point(140, 32)
        Me.TxtCodAlumno.Name = "TxtCodAlumno"
        Me.TxtCodAlumno.Size = New System.Drawing.Size(111, 20)
        Me.TxtCodAlumno.TabIndex = 1
        '
        'BtnVerNotaAlumno
        '
        Me.BtnVerNotaAlumno.Location = New System.Drawing.Point(283, 25)
        Me.BtnVerNotaAlumno.Name = "BtnVerNotaAlumno"
        Me.BtnVerNotaAlumno.Size = New System.Drawing.Size(44, 44)
        Me.BtnVerNotaAlumno.TabIndex = 2
        Me.BtnVerNotaAlumno.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ESPECIALIDAD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TURNO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CICLO:"
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEspecialidad.Location = New System.Drawing.Point(186, 132)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(141, 15)
        Me.lblEspecialidad.TabIndex = 6
        '
        'lblTurno
        '
        Me.lblTurno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTurno.Location = New System.Drawing.Point(404, 132)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(90, 13)
        Me.lblTurno.TabIndex = 7
        '
        'lblCiclo
        '
        Me.lblCiclo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCiclo.Location = New System.Drawing.Point(589, 131)
        Me.lblCiclo.Name = "lblCiclo"
        Me.lblCiclo.Size = New System.Drawing.Size(96, 13)
        Me.lblCiclo.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(726, 181)
        Me.DataGridView1.TabIndex = 9
        '
        'ReporteNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 416)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblCiclo)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.lblEspecialidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnVerNotaAlumno)
        Me.Controls.Add(Me.TxtCodAlumno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReporteNotas"
        Me.Text = "ReporteNotas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodAlumno As System.Windows.Forms.TextBox
    Friend WithEvents BtnVerNotaAlumno As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEspecialidad As System.Windows.Forms.Label
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblCiclo As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
