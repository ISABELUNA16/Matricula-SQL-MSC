Public Class frmTurno
    Public func As New funciones
    Public dts As New datos

    Private Sub frmTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'BtnCancelar.Enabled = False
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        txtIdTurno.Enabled = False
        txtTurno.Enabled = False

        CANCELARTOOL.Enabled = False
        MODIFICARTOOL.Enabled = False
        ELIMINARTOOL.Enabled = False
        GuardarTool.Enabled = False

        'PARA MOSTRAR EL TEXTO EN FORMA DE GLOBO 
        Me.ToolTip2.IsBalloon = True
        Try
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)
            'lblusuario.Text = dt.Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim dt As DataTable = func.mostrarTurno
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub MOSTRANDOTURNOS()
        Dim funcs As New funciones
        Dim dt As DataTable = funcs.mostrarTurno
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'btnModificar.BackgroundImage = My.Resources.modificar
        'BtnCancelar.BackgroundImage = My.Resources.cancel
        'btnEliminar.BackgroundImage = My.Resources.eliminar
        'BtnGuardar.BackgroundImage = My.Resources.guardd

        'BtnCancelar.Enabled = True
        'BtnGuardar.Enabled = True
        'btnModificar.Enabled = True
        'btnEliminar.Enabled = True

        'btnNuevo.Enabled = False
        'btnNuevo.BackgroundImage = My.Resources.nuebvo55
        'btnsalir.Enabled = False
        'btnsalir.BackgroundImage = My.Resources.salir555
        'btnBuscar.Enabled = False
        'btnBuscar.BackgroundImage = My.Resources.buscar555


        'txtTurno.Text = ""
        'txtIdTurno.Text = ""
        'BtnGuardar.Enabled = True
        'BtnCancelar.Enabled = True
        'btnModificar.Enabled = False
        'btnEliminar.Enabled = False
        'btnNuevo.Enabled = False
        'txtIdTurno.Enabled = True
        'txtTurno.Enabled = True
        'txtIdTurno.Focus()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'btnNuevo.Enabled = True
        'btnNuevo.BackgroundImage = My.Resources.fontext_dll_09_10
        'btnsalir.Enabled = True
        'btnsalir.BackgroundImage = My.Resources.n5
        'btnBuscar.Enabled = True
        'btnBuscar.BackgroundImage = My.Resources.buscar

        'btnModificar.BackgroundImage = My.Resources.modificar555
        'BtnCancelar.BackgroundImage = My.Resources.cancel55
        'btnEliminar.BackgroundImage = My.Resources.eliminar55
        'BtnGuardar.BackgroundImage = My.Resources.guard555

        'BtnCancelar.Enabled = False
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        'btnEliminar.Enabled = False


        'txtIdTurno.Clear()
        'txtTurno.Clear()
        'txtBuscar.Clear()
        'txtBuscar.Focus()
        'btnNuevo.Enabled = True
        'btnEliminar.Enabled = False
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        'BtnSalirT.Enabled = True
        'txtIdTurno.Enabled = False
        'txtTurno.Enabled = False

    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'btnNuevo.Enabled = True
        'btnNuevo.BackgroundImage = My.Resources.fontext_dll_09_10
        'btnsalir.Enabled = True
        'btnsalir.BackgroundImage = My.Resources.n5
        'btnBuscar.Enabled = True
        'btnBuscar.BackgroundImage = My.Resources.buscar

        'btnModificar.BackgroundImage = My.Resources.modificar555
        'BtnCancelar.BackgroundImage = My.Resources.cancel55
        'btnEliminar.BackgroundImage = My.Resources.eliminar55
        'BtnGuardar.BackgroundImage = My.Resources.guard555

        'BtnCancelar.Enabled = False
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        'btnEliminar.Enabled = False

        '****
        'txtIdTurno.Enabled = False
        'txtTurno.Enabled = False
        'btnNuevo.Enabled = True
        'btnBuscar.Enabled = True
        'BtnCancelar.Enabled = False
        'btnEliminar.Enabled = True
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        'BtnSalirT.Enabled = True
        'txtBuscar.Text = ""
        'txtBuscar.Focus()
        'Try
        '    dts.gidturno = txtIdTurno.Text

        '    If func.eliminarTurno(dts) Then
        '        MsgBox("El Turno se a eliminado")

        '    Else
        '        MsgBox("Error al eliminar")

        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)

        'End Try
        'Call MOSTRANDOTURNOS()
    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'btnNuevo.Enabled = True
        'btnNuevo.BackgroundImage = My.Resources.fontext_dll_09_10
        'BtnSalirT.Enabled = True
        'BtnSalirT.BackgroundImage = My.Resources.n5
        'btnBuscar.Enabled = True
        'btnBuscar.BackgroundImage = My.Resources.buscar

        'btnModificar.BackgroundImage = My.Resources.modificar555
        'BtnCancelar.BackgroundImage = My.Resources.cancel55
        'btnEliminar.BackgroundImage = My.Resources.eliminar55
        'BtnGuardar.BackgroundImage = My.Resources.guard555

        'BtnCancelar.Enabled = False
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        'btnEliminar.Enabled = False


        'Try
        '    dts.gidturno = txtIdTurno.Text
        '    dts.gNom_turno = txtTurno.Text

        '    If func.modificarTurno(dts) Then
        '        MsgBox("El Turno se a modificado")

        '    Else
        '        MsgBox("Error al editar")

        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)

        'End Try
        'Call MOSTRANDOTURNOS()
        ''***
        'btnNuevo.Enabled = True
        'BtnCancelar.Enabled = False
        'btnEliminar.Enabled = False
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        'BtnSalirT.Enabled = True
        'btnBuscar.Enabled = True
        'txtIdTurno.Enabled = True
        'txtTurno.Enabled = True

    End Sub

    Private Sub BtnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'btnNuevo.Enabled = True
        'btnNuevo.BackgroundImage = My.Resources.fontext_dll_09_10
        'btnsalir.Enabled = True
        'btnsalir.BackgroundImage = My.Resources.n5
        'btnBuscar.Enabled = True
        'btnBuscar.BackgroundImage = My.Resources.buscar

        'btnModificar.BackgroundImage = My.Resources.modificar555
        'BtnCancelar.BackgroundImage = My.Resources.cancel55
        'btnEliminar.BackgroundImage = My.Resources.eliminar55
        'BtnGuardar.BackgroundImage = My.Resources.guard555

        'BtnCancelar.Enabled = False
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        'btnEliminar.Enabled = False


        '****
        'btnNuevo.Enabled = True
        'btnBuscar.Enabled = True
        'BtnCancelar.Enabled = True
        'btnEliminar.Enabled = False
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        'BtnSalirT.Enabled = True
        'txtIdTurno.Enabled = False
        'txtTurno.Enabled = False
        'txtBuscar.Enabled = True
        ''txtIdTurno.Text = ""
        ''txtTurno.Text = ""
        'btnNuevo.Focus()
        'Try

        '    dts.gNom_turno = txtTurno.Text
        '    dts.gidturno = txtIdTurno.Text
        '    If func.nuevoTurno(dts) Then
        '        MsgBox("Nueva especialidad insertada")
        '    Else
        '        MsgBox("error al insertar")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'Call MOSTRANDOTURNOS()
    End Sub

    Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'btnModificar.BackgroundImage = My.Resources.modificar
        'BtnCancelar.BackgroundImage = My.Resources.cancel
        'btnEliminar.BackgroundImage = My.Resources.eliminar
        'BtnGuardar.BackgroundImage = My.Resources.guard555

        'BtnCancelar.Enabled = True
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = True
        'btnEliminar.Enabled = True

        'btnNuevo.Enabled = False
        'btnNuevo.BackgroundImage = My.Resources.nuebvo55
        'BtnSalirT.Enabled = False
        'BtnSalirT.BackgroundImage = My.Resources.salir555
        'btnBuscar.Enabled = False
        'btnBuscar.BackgroundImage = My.Resources.buscar555

        'txtTurno.Enabled = True
        'txtIdTurno.Enabled = True
        'btnNuevo.Enabled = False
        'btnBuscar.Enabled = False
        'BtnCancelar.Enabled = True
        'btnEliminar.Enabled = True
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = True
        'BtnSalirT.Enabled = False

        'Try
        '    '  Dim func As New funciones
        '    Dim dt As DataTable = func.buscarTurno(idturno:=txtBuscar.Text)
        '    Dim dts As DataTable = func.mostrarTurno
        '    txtIdTurno.Text = dt.Rows(0).Item(0)
        '    txtTurno.Text = dt.Rows(0).Item(1)
        '    DataGridView1.DataSource = dts
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'txtTurno.Focus()
        '' btnEliminar.Focus(
    End Sub

    Private Sub btnver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim func As New funciones
        '    Dim dt As DataTable = func.mostrarTurno
        '    DataGrid1.DataSource = dt
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub BtnSalirT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'btnNuevo.Enabled = True
        'btnBuscar.Enabled = True
        'BtnCancelar.Enabled = False
        'btnEliminar.Enabled = False
        'BtnGuardar.Enabled = False
        'btnModificar.Enabled = False
        'BtnSalirT.Enabled = True

        'Try
        '    If MsgBox("ESTAS SEGURO DE SALIR", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        Me.Close()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'frmMenu.Show()
    End Sub

    Private Sub txtIdTurno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtTurno.Focus()
        End If
    End Sub

    Private Sub txtIdTurno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If String.IsNullOrEmpty(txtIdTurno.Text) Then
            MessageBox.Show("Debe completar la informacion requerida")
            txtIdTurno.Focus()
            Return
        End If
    End Sub
    Private Sub btnBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) = 13 Then
        '    btnEliminar.Focus()
        'End If

    End Sub

    Private Sub txtTurno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) = 13 Then
        '    BtnGuardar.Focus()
        'End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.txtBuscar.Text = UCase(Me.txtBuscar.Text)
        Me.txtBuscar.SelectionStart = Me.txtBuscar.TextLength + 1
    End Sub
    'Private Sub Combo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo1.SelectedIndexChanged
    '    Combo1.DroppedDown = True
    'End Sub

    Private Sub txtTurno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtTurno.Text = UCase(Me.txtTurno.Text)
        Me.txtTurno.SelectionStart = Me.txtTurno.TextLength + 1
    End Sub
    Private Sub txtIdTurno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtIdTurno.Text = UCase(Me.txtIdTurno.Text)
        Me.txtIdTurno.SelectionStart = Me.txtIdTurno.TextLength + 1
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'txtIdTurno.Text = DataGridView1.CurrentRow.Cells(0).Value
        'txtTurno.Text = DataGridView1.CurrentRow.Cells(1).Value
    End Sub

    Private Sub DataGridView1_ReadOnlyChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.ReadOnlyChanged
        'DataGridView1.Columns("IdTurno").ReadOnly = True
    End Sub

    Private Sub txtBuscar_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    btnBuscar.Focus()
        'End If
    End Sub

    Private Sub frmTurno_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtBuscar.Focus()
        txtIdTurno.Text = ""
        txtTurno.Text = ""
    End Sub

    Private Sub btnNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        ' btnNuevo.BackgroundImage =
    End Sub

    Private Sub btnNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        ' btnNuevo .BackgroundImage = My.resources.
    End Sub

    Private Sub BtnSalirT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        ' BtnSalirT.BackgroundImage = My.resources.salir
    End Sub

    Private Sub txtIdTurno_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdTurno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTurno.Focus()
        End If
        'If Asc(e.KeyChar) = 13 Then
        '    BtnCancelar.Focus()
        'End If
    End Sub
    Private Sub txtTurno_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTurno.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    GuardarTool.Focus()
        'End If
    End Sub

    Private Sub txtTurno_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTurno.KeyUp
        'If Asc(e.KeyChar) = 13 Then
        '    GuardarTool.Focus()
        'End If
        'If e.KeyValue = Keys.Enter Then
        '    GuardarTool.Focus()
        'End If
    End Sub

    Private Sub txtTurno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTurno.LostFocus
        If txtTurno.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtTurno.Focus()
        End If
    End Sub

    Private Sub txtTurno_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTurno.Move

    End Sub

    Private Sub txtTurno_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTurno.TextChanged
        Me.txtTurno.Text = UCase(Me.txtTurno.Text)
        Me.txtTurno.SelectionStart = Me.txtTurno.TextLength + 1
    End Sub

    Private Sub txtIdTurno_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdTurno.KeyUp

    End Sub

    Private Sub txtIdTurno_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdTurno.LostFocus
        If txtIdTurno.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtIdTurno.Focus()
        End If
    End Sub

    Private Sub txtIdTurno_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdTurno.TextChanged
        Me.txtIdTurno.Text = UCase(Me.txtIdTurno.Text)
        Me.txtIdTurno.SelectionStart = Me.txtIdTurno.TextLength + 1
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Me.txtBuscar.Text = UCase(Me.txtBuscar.Text)
        Me.txtBuscar.SelectionStart = Me.txtBuscar.TextLength + 1
    End Sub

    Private Sub nuevotool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevotool.Click
        txtTurno.Text = ""
        txtIdTurno.Text = ""

        CANCELARTOOL.Enabled = True
        ELIMINARTOOL.Enabled = True
        MODIFICARTOOL.Enabled = True
        GuardarTool.Enabled = True
        nuevotool.Enabled = False
        SALIRTOOL.Enabled = False
        BUSCARTOOL.Enabled = False
        txtIdTurno.Enabled = True
        txtTurno.Enabled = True
        txtIdTurno.Focus()
    End Sub

    Private Sub CANCELARTOOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELARTOOL.Click
        txtIdTurno.Clear()
        txtTurno.Clear()
        txtBuscar.Clear()
        txtBuscar.Focus()


        CANCELARTOOL.Enabled = False
        ELIMINARTOOL.Enabled = False
        MODIFICARTOOL.Enabled = False
        GuardarTool.Enabled = False
        nuevotool.Enabled = True
        SALIRTOOL.Enabled = True
        BUSCARTOOL.Enabled = True
    End Sub

    Private Sub ELIMINARTOOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELIMINARTOOL.Click
        txtIdTurno.Enabled = False
        txtTurno.Enabled = False

        CANCELARTOOL.Enabled = False
        ELIMINARTOOL.Enabled = False
        MODIFICARTOOL.Enabled = False
        GuardarTool.Enabled = False
        nuevotool.Enabled = True
        SALIRTOOL.Enabled = True
        BUSCARTOOL.Enabled = True
        txtBuscar.Text = ""
        txtBuscar.Focus()

        Try
            dts.gidturno = txtIdTurno.Text

            If func.eliminarTurno(dts) Then
                MsgBox("El Turno se a eliminado")

            Else
                MsgBox("Error al eliminar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRANDOTURNOS()

    End Sub

    Private Sub MODIFICARTOOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODIFICARTOOL.Click

        Try
            dts.gidturno = txtIdTurno.Text
            dts.gNom_turno = txtTurno.Text

            If func.modificarTurno(dts) Then
                MsgBox("El Turno se a modificado")

            Else
                MsgBox("Error al editar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRANDOTURNOS()
        '***
       
        CANCELARTOOL.Enabled = False
        ELIMINARTOOL.Enabled = False
        MODIFICARTOOL.Enabled = False
        GuardarTool.Enabled = False
        nuevotool.Enabled = True
        SALIRTOOL.Enabled = True
        BUSCARTOOL.Enabled = True
        txtIdTurno.Enabled = True
        txtTurno.Enabled = True


    End Sub

    Private Sub GuardarTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarTool.Click
     


        CANCELARTOOL.Enabled = False
        ELIMINARTOOL.Enabled = False
        MODIFICARTOOL.Enabled = False
        GuardarTool.Enabled = False
        nuevotool.Enabled = True
        SALIRTOOL.Enabled = True
        BUSCARTOOL.Enabled = True

        txtIdTurno.Enabled = False
        txtTurno.Enabled = False
        txtBuscar.Enabled = True
        'txtIdTurno.Text = ""
        'txtTurno.Text = ""

        Try

            dts.gNom_turno = txtTurno.Text
            dts.gidturno = txtIdTurno.Text
            If func.nuevoTurno(dts) Then
                MsgBox("Nueva especialidad insertada")
            Else
                MsgBox("error al insertar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call MOSTRANDOTURNOS()

    End Sub

    Private Sub BUSCARTOOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUSCARTOOL.Click

        txtTurno.Enabled = True
        txtIdTurno.Enabled = True
        CANCELARTOOL.Enabled = True
        ELIMINARTOOL.Enabled = True
        MODIFICARTOOL.Enabled = True
        GuardarTool.Enabled = False
        nuevotool.Enabled = False
        SALIRTOOL.Enabled = False
        BUSCARTOOL.Enabled = False
        Try
            '  Dim func As New funciones
            Dim dt As DataTable = func.buscarTurno(idturno:=txtBuscar.Text)
            Dim dts As DataTable = func.mostrarTurno
            txtIdTurno.Text = dt.Rows(0).Item(0)
            txtTurno.Text = dt.Rows(0).Item(1)
            DataGridView1.DataSource = dts
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtTurno.Focus()
    End Sub

    Private Sub SALIRTOOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRTOOL.Click

        Try
            If MsgBox("ESTAS SEGURO DE SALIR", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMenu.Show()
    End Sub
End Class