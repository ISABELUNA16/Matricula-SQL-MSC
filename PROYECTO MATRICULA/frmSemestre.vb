Public Class frmSemestre


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'txtBuscar.Focus()
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarSemestre(idSemestre:=txtBuscar.Text)

            txtIdSemestre.Text = dt.Rows(0).Item(0)
            txtFecIni.Text = dt.Rows(0).Item(1)
            txtFecFin.Text = dt.Rows(0).Item(2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtIdSemestre.Enabled = True
        txtFecFin.Enabled = True
        txtFecIni.Enabled = True
        '********
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        btnBuscar.Enabled = True
        txtBuscar.Text = ""
        txtIdSemestre.Focus()
    End Sub
    Sub mostrar()
        Dim func As New funciones
        Dim dt As DataTable = func.mostrarSemestre
        DataGrid1.DataSource = dt
    End Sub


    Private Sub frmSemestre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBuscar.Focus()

        Try
            Dim func As New funciones
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            Lblusuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.mostrarSemestre
            DataGrid1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.txtFecIni.ValidatingType = GetType(System.DateTime)
        Me.txtFecFin.ValidatingType = GetType(System.DateTime)
        '  Me.ToolTip2.IsBalloon = True

    End Sub

    Private Sub txtIdSemestre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdSemestre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtFecIni.Focus()
        End If
    End Sub

    Private Sub txtFecIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtFecFin.Focus()
        End If
    End Sub

    Private Sub txtIdSemestre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdSemestre.LostFocus
        If txtIdSemestre.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtIdSemestre.Focus()
        End If
    End Sub

    Private Sub txtIdSemestre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdSemestre.TextChanged
        txtIdSemestre.MaxLength = 6
        Me.txtIdSemestre.Text = UCase(Me.txtIdSemestre.Text)
        Me.txtIdSemestre.SelectionStart = Me.txtIdSemestre.TextLength + 1
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidsemestre = txtIdSemestre.Text

            If func.eliminarSemestre(dts) Then
                MsgBox("El Semestre se a eliminado")
               
            Else
                MsgBox("Error al eliminar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()
        '**
        txtIdSemestre.Enabled = False
        txtFecIni.Enabled = False
        txtFecFin.Enabled = False
        btnNuevo.Enabled = True
        BtnCancelar.Enabled = False
        btnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        btnModificar.Enabled = False
        BtnSalirT.Enabled = True
        txtBuscar.Text = ""
        txtIdSemestre.Text = ""
        txtFecIni.Text = ""
        txtFecFin.Text = ""
        txtBuscar.Enabled = True
        txtBuscar.Focus()



    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidsemestre = txtIdSemestre.Text
            dts.gfecha_inicio = txtFecIni.Text
            dts.gfecha_fin = txtFecFin.Text

            If func.modificarSemestre(dts) Then
                MsgBox("El Semestre se a modificado")
                
            Else
                MsgBox("Error al editar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()

        '****
        btnNuevo.Enabled = True
        BtnCancelar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        BtnSalirT.Enabled = True
        BtnGuardar.Enabled = True
        txtIdSemestre.Enabled = False
        txtFecIni.Enabled = False
        txtFecFin.Enabled = False
        txtBuscar.Enabled = False
        txtIdSemestre.Text = ""
        txtFecIni.Text = ""
        txtFecFin.Text = ""
        txtBuscar.Focus()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidsemestre = txtIdSemestre.Text
            dts.gfecha_inicio = txtFecIni.Text
            dts.gfecha_fin = txtFecFin.Text

            If func.nuevoSemestre(dts) Then
                MsgBox("Nuevo Semestre insertado")
                
            Else
                MsgBox("error al insertar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()
        btnNuevo.Enabled = True
        BtnCancelar.Enabled = False
        btnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        btnModificar.Enabled = False
        BtnSalirT.Enabled = True
        txtIdSemestre.Enabled = False
        txtFecIni.Enabled = False
        txtFecFin.Enabled = False
        txtBuscar.Enabled = True
        txtFecIni.Text = ""
        txtIdSemestre.Text = ""
        txtFecFin.Text = ""
        btnNuevo.Focus()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False
        txtIdSemestre.Enabled = True
        txtFecIni.Enabled = True
        txtFecFin.Enabled = True
        txtIdSemestre.Text = ""
        txtFecIni.Text = ""
        txtFecFin.Text = ""
        txtIdSemestre.Focus()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        txtIdSemestre.Clear()
        txtFecIni.Clear()
        txtFecFin.Clear()
        '***
        txtIdSemestre.Enabled = False
        txtFecIni.Enabled = False
        txtFecFin.Enabled = False
        btnNuevo.Enabled = True
        BtnCancelar.Enabled = False
        btnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        btnModificar.Enabled = False
        txtBuscar.Focus()

    End Sub

    Private Sub frmSemestre_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtBuscar.Focus()
    End Sub

    Private Sub BtnSalirT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalirT.Click
        Try
            If MsgBox("ESTAS SEGURO DE SALIR", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMenu.Show()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnBuscar.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Me.txtBuscar.Text = UCase(Me.txtBuscar.Text)
        Me.txtBuscar.SelectionStart = Me.txtBuscar.TextLength + 1
    End Sub
    Private Sub txtFecIni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFecIni.KeyDown
        Me.ToolTip2.Hide(Me.txtFecIni)
    End Sub

    Private Sub txtFecIni_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecIni.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtFecFin.Focus()
        End If
    End Sub
    Private Sub txtFecIni_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs) Handles txtFecIni.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.ToolTip2.ToolTipTitle = "DATO INVALIDO"
            Me.ToolTip2.Show("LA FECHA INGRESADA NO COINCIDE CON EL TIPO DE FORMATO (dia/mes/año)", Me.txtFecIni, 0, -20, 5000)
            txtFecIni.Text = ""
            txtFecIni.Focus()
        End If
    End Sub

    Private Sub txtFecFin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFecFin.KeyDown
        Me.ToolTip2.Hide(Me.txtFecFin)
    End Sub

    Private Sub txtFecFin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecFin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnGuardar.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificar.Focus()
        End If
    End Sub
    Private Sub txtFecFin_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs) Handles txtFecFin.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.ToolTip2.ToolTipTitle = "DATO INVALIDO"
            Me.ToolTip2.Show("LA FECHA INGRESADA NO COINCIDE CON EL TIPO DE FORMATO (dia/mes/año)", Me.txtFecIni, 0, -20, 5000)
            txtFecFin.Text = ""
            txtFecFin.Focus()
        End If
    End Sub
End Class