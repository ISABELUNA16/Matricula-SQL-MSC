
Public Class frmUndDidac
    'CODIGO DE PESTAÑA DE UD PROFESIONAL
    Dim func As New funciones
    Private Sub frmUndDidac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            lblusuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cboEspecialidadP.Text = ""

        With cboEspecialidadP

            .DataSource = func.mostrarEspecialidad

            .DisplayMember = "Nom_Especialidad"

            .ValueMember = "IdEspecialidad"
        End With

        cboEspecialidadT.Text = ""

        With cboEspecialidadT

            .DataSource = func.mostrarEspecialidad

            .DisplayMember = "Nom_Especialidad"

            .ValueMember = "IdEspecialidad"
        End With
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.MostrarUDP
            DGVPROFESIONAL.DataSource = dt
            Dim dts As DataTable = func.MostrarUDT
            DataGrid1.DataSource = dts
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cboEspecialidadP.DroppedDown = False
        cboEspecialidadT.DroppedDown = False
    End Sub
    Sub mostrar()
        Dim func As New funciones
        Dim dt As DataTable = func.MostrarUDP
        DGVPROFESIONAL.DataSource = dt
    End Sub
    Sub mostrarr()
        Dim dts As DataTable = func.MostrarUDT
        DataGrid1.DataSource = dts
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        'Me.DataGrid1.DataSource = ""
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        'Me.DataGrid1.DataSource = ""
    End Sub

    Private Sub BTNNUEVOP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVOP.Click
        Dim FUNC As New funciones
        Dim DT As DataTable = FUNC.GENERARIDUNDDIDACP

        If IsDBNull(DT.Rows(0)(0)) Then
            lblIdUndDidacP.Text = "UP01"
        Else
            lblIdUndDidacP.Text = DT.Rows(0)(0)
        End If

        txtNomUndDidacP.Clear()
        txtIdCicloP.Clear()
        txtIdModuloP.Clear()
        txtCreditoP.Clear()
        txtHorasP.Clear()
        txtAñoModuloP.Clear()
        cboEspecialidadP.Text = ""


        '**********

        btnGuardarP.Enabled = True
        btncancelarP.Enabled = True
        btnModificarP.Enabled = False
        btnEliminarP.Enabled = False
        BTNNUEVOP.Enabled = False
        lblIdUndDidacP.Enabled = False
        txtNomUndDidacP.Enabled = True
        txtCreditoP.Enabled = True
        txtHorasP.Enabled = True
        txtIdCicloP.Enabled = True
        txtIdModuloP.Enabled = True
        txtAñoModuloP.Enabled = True
        txtNomUndDidacP.Focus()

    End Sub

    Private Sub btncancelarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarP.Click
        lblIdUndDidacP.Text = ""
        txtNomUndDidacP.Clear()
        txtIdCicloP.Clear()
        txtIdModuloP.Clear()
        txtCreditoP.Clear()
        txtHorasP.Clear()

        lblIdUndDidacP.Enabled = False
        txtNomUndDidacP.Enabled = False
        txtCreditoP.Enabled = False
        txtHorasP.Enabled = False
        txtIdCicloP.Enabled = False
        txtIdModuloP.Enabled = False
        txtAñoModuloP.Enabled = False
        BTNNUEVOP.Enabled = True
        BtnCancelarp.Enabled = False
        btnEliminarP.Enabled = False
        btnGuardarP.Enabled = False
        btnModificarP.Enabled = False
    End Sub

    Private Sub btnEliminarP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarP.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdUndDidacP = lblIdUndDidacP.Text

            If func.eliminarUDP(dts) Then
                MsgBox("La Und. Didactica  se a eliminado")

            Else
                MsgBox("Error al eliminar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Call mostrar()

        '***********
        lblIdUndDidacP.Enabled = False
        txtNomUndDidacP.Enabled = False
        txtCreditoP.Enabled = False
        txtHorasP.Enabled = False
        txtIdCicloP.Enabled = False
        txtIdModuloP.Enabled = False
        BTNNUEVOP.Enabled = True
        btncancelarP.Enabled = False
        btnEliminarP.Enabled = False
        btnGuardarP.Enabled = False
        btnModificarP.Enabled = False
        btnsalirP.Enabled = True
        txtBuscarP.Text = ""
        lblIdUndDidacP.Text = ""
        txtNomUndDidacP.Text = ""
        txtCreditoP.Text = ""
        txtHorasP.Text = ""
        txtIdCicloP.Text = ""
        txtIdModuloP.Text = ""
        txtAñoModuloP.Text = ""
        txtBuscarP.Enabled = True
        BTNNUEVOP.Focus()
    End Sub

    Private Sub btnModificarP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarP.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdUndDidacP = lblIdUndDidacP.Text
            dts.gNom_UndDidac = txtNomUndDidacP.Text
            dts.gidmoduloP = txtIdModuloP.Text
            dts.gIdCicloU = txtIdCicloP.Text
            dts.gHoras = txtHorasP.Text
            dts.gCredito = txtCreditoP.Text

            If func.modificarUDP(dts) Then
                MsgBox("La Und. Didactica a sido Modificada")

            Else
                MsgBox("Error al editar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Call mostrar()

        '*************************
        BTNNUEVOP.Enabled = True
        btncancelarP.Enabled = False
        btnEliminarP.Enabled = False
        btnModificarP.Enabled = False
        btnsalirP.Enabled = True
        btnGuardarP.Enabled = True
        lblIdUndDidacP.Enabled = False
        txtNomUndDidacP.Enabled = False
        txtCreditoP.Enabled = False
        txtHorasP.Enabled = False
        txtIdCicloP.Enabled = False
        txtIdModuloP.Enabled = False
        txtAñoModuloP.Enabled = False
        txtBuscarP.Enabled = False
        BTNNUEVOP.Focus()
    End Sub

    Private Sub btnGuardarP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarP.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdUndDidacP = lblIdUndDidacP.Text
            dts.gNom_UndDidac = txtNomUndDidacP.Text
            dts.gidmoduloP = txtIdModuloP.Text
            dts.gIdCicloU = txtIdCicloP.Text
            dts.gHoras = txtHorasP.Text
            dts.gCredito = txtCreditoP.Text
            dts.gIdEspecialidad = cboEspecialidadP.SelectedValue

            If func.GuardarUDP(dts) Then
                MsgBox("Nueva Und. Didactica insertada")

            Else
                MsgBox("error al insertar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()


        '******
        BTNNUEVOP.Enabled = True
        btncancelarP.Enabled = False
        btnEliminarP.Enabled = False
        btnGuardarP.Enabled = False
        btnModificarP.Enabled = False
        btnsalirP.Enabled = True
        lblIdUndDidacP.Enabled = False
        txtNomUndDidacP.Enabled = False
        txtCreditoP.Enabled = False
        txtHorasP.Enabled = False
        txtIdCicloP.Enabled = False
        txtIdModuloP.Enabled = False
        txtAñoModuloP.Enabled = False
        txtBuscarP.Enabled = True
        lblIdUndDidacP.Text = ""
        txtNomUndDidacP.Text = ""
        txtCreditoP.Text = ""
        txtHorasP.Text = ""
        txtIdCicloP.Text = ""
        txtIdModuloP.Text = ""
        txtAñoModuloP.Text = ""
        BTNNUEVOP.Focus()
        '*******
    End Sub
    Private Sub btnsalirP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalirP.Click
        Try
            If MsgBox("ESTAS SEGURO DE SALIR", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMenu.Show()
    End Sub

    Private Sub btnBuscarP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarP.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarUDP(idUndDidacP:=txtBuscarP.Text, idespecialidad:=cboEspecialidadP.SelectedValue)

            lblIdUndDidacP.Text = dt.Rows(0).Item(0)
            txtCreditoP.Text = dt.Rows(0).Item(6)
            txtIdModuloP.Text = dt.Rows(0).Item(2)
            txtIdCicloP.Text = dt.Rows(0).Item(7)
            txtNomUndDidacP.Text = dt.Rows(0).Item(4)
            txtHorasP.Text = dt.Rows(0).Item(5)
            txtAñoModuloP.Text = dt.Rows(0).Item(3)

            'If cboEspecialidadP.Text = " & Me.cboEspecialidad.text & " Then
            '    With cboEspecialidadP
            '        .DataSource = func.mostrarEspecialidad

            '        .DisplayMember = "Nom_Especialidad"

            '        .ValueMember = "IdEspecialidad"
            '    End With
            'End If
            'cboEspecialidadP.Text = dt.Rows(0).Item(1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'CODIGO DE PESTAÑA DE UD TRANSVERSAL

    Private Sub btnNuevoT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoT.Click
        Dim FUNC As New funciones
        Dim DT As DataTable = FUNC.GENERARIDUNDDIDACT

        If IsDBNull(DT.Rows(0)(0)) Then
            lblIdUndDidacT.Text = "UT01"
        Else
            lblIdUndDidacT.Text = DT.Rows(0)(0)
        End If

        txtNomUndDidacT.Clear()
        txtIdCicloT.Clear()
        txtIdModuloT.Clear()
        txtCreditoT.Clear()
        txtHorasT.Clear()

        '**********

        btnGuardarT.Enabled = True
        btnCancelarT.Enabled = True
        btnModificarT.Enabled = False
        btnEliminarT.Enabled = False
        btnNuevoT.Enabled = False
        lblIdUndDidacT.Enabled = False
        txtNomUndDidacT.Enabled = True
        txtCreditoT.Enabled = True
        txtHorasT.Enabled = True
        txtIdCicloT.Enabled = True
        txtIdModuloT.Enabled = True
        txtAñoModuloT.Enabled = True
        txtNomUndDidacT.Text = ""
        txtNomUndDidacT.Focus()
    End Sub

    Private Sub btnCancelarT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarT.Click
        lblIdUndDidacT.Text = ""
        txtNomUndDidacT.Clear()
        txtIdCicloT.Clear()
        txtIdModuloT.Clear()
        txtCreditoT.Clear()
        txtHorasT.Clear()

        lblIdUndDidacT.Enabled = False
        txtNomUndDidacT.Enabled = False
        txtCreditoT.Enabled = False
        txtHorasT.Enabled = False
        txtIdCicloT.Enabled = False
        txtIdModuloT.Enabled = False
        txtAñoModuloT.Enabled = False
        btnNuevoT.Enabled = True
        btnCancelarT.Enabled = False
        btnEliminarT.Enabled = False
        btnGuardarT.Enabled = False
        btnModificarT.Enabled = False
    End Sub

    Private Sub btnEliminarT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarT.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdUndDidacT = lblIdUndDidacT.Text

            If func.eliminarUDT(dts) Then
                MsgBox("La Und. Didactica  se a eliminado")

            Else
                MsgBox("Error al eliminar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrarr()

        '***********

        lblIdUndDidacT.Enabled = False
        txtNomUndDidacT.Enabled = False
        txtCreditoT.Enabled = False
        txtHorasT.Enabled = False
        txtIdCicloT.Enabled = False
        txtIdModuloT.Enabled = False
        btnNuevoT.Enabled = True
        btnCancelarT.Enabled = False
        btnEliminarT.Enabled = False
        btnGuardarT.Enabled = False
        btnModificarT.Enabled = False
        btnSalirT.Enabled = True
        txtBuscarT.Text = ""
        lblIdUndDidacT.Text = ""
        txtNomUndDidacT.Text = ""
        txtCreditoT.Text = ""
        txtHorasT.Text = ""
        txtIdCicloT.Text = ""
        txtIdModuloT.Text = ""
        txtAñoModuloT.Text = ""
        txtBuscarT.Enabled = True
        btnNuevoT.Focus()
    End Sub

    Private Sub btnModificarT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarT.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdUndDidacT = lblIdUndDidacT.Text
            dts.gNom_UndDidac = txtNomUndDidacT.Text
            dts.gidmoduloT = txtIdModuloT.Text
            dts.gIdCicloU = txtIdCicloT.Text
            dts.gHoras = txtHorasT.Text
            dts.gCredito = txtCreditoT.Text

            If func.modificarUDT(dts) Then
                MsgBox("La Und. Didactica a sido Modificada")

            Else
                MsgBox("Error al editar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrarr()


        '*************************
        btnNuevoT.Enabled = True
        btnCancelarT.Enabled = False
        btnEliminarT.Enabled = False
        btnModificarT.Enabled = False
        btnSalirT.Enabled = True
        btnGuardarT.Enabled = True
        lblIdUndDidacT.Enabled = False
        txtNomUndDidacT.Enabled = False
        txtCreditoT.Enabled = False
        txtHorasT.Enabled = False
        txtIdCicloT.Enabled = False
        txtIdModuloT.Enabled = False
        txtAñoModuloT.Enabled = False
        txtBuscarT.Enabled = False
        btnNuevoT.Focus()
    End Sub

    Private Sub btnGuardarT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarT.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdUndDidacT = lblIdUndDidacT.Text
            dts.gNom_UndDidac = txtNomUndDidacT.Text
            dts.gidmoduloT = txtIdModuloT.Text
            dts.gIdCicloU = txtIdCicloT.Text
            dts.gHoras = txtHorasT.Text
            dts.gCredito = txtCreditoT.Text

            If func.GuardarUDT(dts) Then
                MsgBox("Nueva Und. Didactica insertada")

            Else
                MsgBox("error al insertar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrarr()

        '******
        btnNuevoT.Enabled = True
        btnCancelarT.Enabled = False
        btnEliminarT.Enabled = False
        btnGuardarT.Enabled = False
        btnModificarT.Enabled = False
        btnSalirT.Enabled = True
        lblIdUndDidacT.Enabled = False
        txtNomUndDidacT.Enabled = False
        txtCreditoT.Enabled = False
        txtHorasT.Enabled = False
        txtIdCicloT.Enabled = False
        txtIdModuloT.Enabled = False
        txtAñoModuloT.Enabled = False
        txtBuscarT.Enabled = True
        lblIdUndDidacT.Text = ""
        txtNomUndDidacT.Text = ""
        txtCreditoT.Text = ""
        txtHorasT.Text = ""
        txtIdCicloT.Text = ""
        txtIdModuloT.Text = ""
        txtAñoModuloT.Text = ""
        btnNuevoT.Focus()
        '*******
    End Sub
    Private Sub btnSalirT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirT.Click
        Try
            If MsgBox("ESTAS SEGURO DE SALIR", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMenu.Show()
    End Sub

    Private Sub btnBuscarT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarT.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarUDT(idUndDidacT:=txtBuscarT.Text, idespecialidad:=cboEspecialidadT.SelectedValue)
            lblIdUndDidacT.Text = dt.Rows(0).Item(0)
            txtCreditoT.Text = dt.Rows(0).Item(6)
            txtIdModuloT.Text = dt.Rows(0).Item(2)
            txtIdCicloT.Text = dt.Rows(0).Item(7)
            txtNomUndDidacT.Text = dt.Rows(0).Item(4)
            txtHorasT.Text = dt.Rows(0).Item(5)
            txtAñoModuloT.Text = dt.Rows(0).Item(3)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtNomUndDidacP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomUndDidacP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCreditoP.Focus()
        End If
    End Sub

    Private Sub txtCreditoP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCreditoP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtHorasP.Focus()
        End If
    End Sub

    Private Sub txtHorasP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHorasP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtIdCicloP.Focus()
        End If
    End Sub

    Private Sub txtIdCicloP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCicloP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtIdModuloP.Focus()
        End If
    End Sub
    Private Sub txtIdModuloP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdModuloP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboEspecialidadP.Focus()
        End If
    End Sub
    Private Sub cboEspecialidadP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cboEspecialidadP.DroppedDown = True
    End Sub

    Private Sub txtAñoModuloP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAñoModuloP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardarP.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificarP.Focus()
        End If

    End Sub

    Private Sub cboEspecialidadP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboEspecialidadP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtAñoModuloP.Focus()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEspecialidadP.SelectedIndexChanged
        cboEspecialidadP.DroppedDown = True

    End Sub

    Private Sub frmUndDidac_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtBuscarP.Focus()
    End Sub

    Private Sub txtNomUndDidacP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomUndDidacP.LostFocus
        If txtNomUndDidacP.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtNomUndDidacP.Focus()
        End If
    End Sub

    Private Sub txtNomUndDidacP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomUndDidacP.TextChanged
        Me.txtNomUndDidacP.Text = UCase(Me.txtNomUndDidacP.Text)
        Me.txtNomUndDidacP.SelectionStart = Me.txtNomUndDidacP.TextLength + 1

    End Sub

    Private Sub txtIdCicloP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCicloP.LostFocus
        If txtIdCicloP.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtIdCicloP.Focus()
        End If
    End Sub

    Private Sub txtIdCicloP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdCicloP.TextChanged
        Me.txtIdCicloP.Text = UCase(Me.txtIdCicloP.Text)
        Me.txtIdCicloP.SelectionStart = Me.txtIdCicloP.TextLength + 1


    End Sub

    Private Sub txtIdModuloP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdModuloP.LostFocus
        If txtIdModuloP.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtIdModuloP.Focus()
        End If
    End Sub

    Private Sub txtIdModuloP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdModuloP.TextChanged
        Me.txtIdModuloP.Text = UCase(Me.txtIdModuloP.Text)
        Me.txtIdModuloP.Text = Me.txtIdModuloP.TextLength + 1


    End Sub

    Private Sub txtBuscarP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnBuscarP.Focus()
        End If
    End Sub

    Private Sub txtBuscarP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarP.TextChanged
        Dim i As Integer
        txtBuscarP.Text = UCase(txtBuscarP.Text)
        i = Len(txtBuscarP.Text)
        txtBuscarP.SelectionStart = i
        txtBuscarP.Focus()

    End Sub
    Private Sub txtCreditoP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCreditoP.LostFocus
        If txtCreditoP.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtCreditoP.Focus()
        End If
    End Sub
    Private Sub txtHorasP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHorasP.LostFocus
        If txtHorasP.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtHorasP.Focus()
        End If
    End Sub

    Private Sub txtIdModuloT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdModuloT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboEspecialidadT.Focus()
        End If
    End Sub


    Private Sub cboEspecialidadT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboEspecialidadT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtAñoModuloT.Focus()
        End If
    End Sub

    Private Sub cboEspecialidadT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEspecialidadT.SelectedIndexChanged
        cboEspecialidadT.DroppedDown = True
    End Sub

    Private Sub txtAñoModuloT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAñoModuloT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardarT.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificarT.Focus()
        End If
    End Sub

    Private Sub txtNomUndDidacT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomUndDidacT.LostFocus
        If txtNomUndDidacT.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtNomUndDidacT.Focus()
        End If
    End Sub

    Private Sub txtNomUndDidacT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomUndDidacT.TextChanged
        Me.txtNomUndDidacT.Text = UCase(Me.txtNomUndDidacT.Text)
        Me.txtNomUndDidacT.SelectionStart = Me.txtNomUndDidacT.TextLength + 1

    End Sub

    Private Sub txtIdCicloT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCicloT.LostFocus
        If txtIdCicloT.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtIdCicloT.Focus()
        End If
    End Sub

    Private Sub txtIdCicloT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdCicloT.TextChanged
        Me.txtIdCicloT.Text = UCase(Me.txtIdCicloT.Text)
        Me.txtIdCicloT.SelectionStart = Me.txtIdCicloT.TextLength + 1

    End Sub

    Private Sub txtIdModuloT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdModuloT.LostFocus
        If txtIdModuloT.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtIdModuloT.Focus()
        End If
    End Sub

    Private Sub txtIdModuloT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdModuloT.TextChanged
        Me.txtIdModuloT.Text = UCase(Me.txtIdModuloT.Text)
        Me.txtIdModuloT.SelectionStart = Me.txtIdModuloT.TextLength + 1

    End Sub

    Private Sub txtAñoModuloT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAñoModuloT.TextChanged

    End Sub

    Private Sub txtBuscarT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarT.TextChanged
        Me.txtBuscarT.Text = UCase(Me.txtBuscarT.Text)
        Me.txtBuscarT.SelectionStart = Me.txtBuscarT.TextLength + 1

    End Sub
End Class