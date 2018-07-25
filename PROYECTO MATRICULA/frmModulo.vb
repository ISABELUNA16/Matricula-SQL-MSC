Imports System.Data.SqlClient

Public Class frmModulo
    Dim func As New funciones

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblFecHora.Text = DateTime.Now

    End Sub

    Private Sub frmModulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim func As New funciones

        CboespecialidadP.Text = ""

        With CboespecialidadP

            .DataSource = func.mostrarEspecialidad

            .DisplayMember = "Nom_Especialidad"

            .ValueMember = "IdEspecialidad"
        End With

        Try

            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            lblUsuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'profesional
        Try
            Dim dt As DataTable = func.mostrarModuloP
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        ''CODIGO DE PESTAÑA DE MODULO TRANSVERSAL

        CboEspecialidadT.Text = ""

        With CboEspecialidadT

            .DataSource = func.mostrarEspecialidad

            .DisplayMember = "Nom_Especialidad"

            .ValueMember = "IdEspecialidad"
        End With

        Try

            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            lblUsuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim dt As DataTable = func.mostrarModuloP
            DataGrid.DataSource = dt
            Dim dts As DataTable = func.mostrarModuloT
            dgvt.DataSource = dts
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CboespecialidadP.DroppedDown = False
        CboEspecialidadT.DroppedDown = False
    
       
    End Sub
    Sub MOSTRAR()
        Dim dt As DataTable = func.mostrarModuloP
        DataGrid.DataSource = dt
    End Sub
    Sub MOSTRARR()
        Dim dts As DataTable = func.mostrarModuloT
        dgvt.DataSource = dts
    End Sub

    Private Sub btnEliminarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarP.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidmoduloP = lblIdModuloP.Text
            dts.gNom_modulo = txtNomModuloP.Text
            dts.gaño_MODULO = txtAñoP.Text
            dts.gidespeci = CboespecialidadP.SelectedValue
            dts.gIdUsuario = lblUsuario.Text


            If func.eliminarmoduloP(dts) Then
                MsgBox(" modulo ELIMINADO")

            Else
                MsgBox("error al insertar")
                lblIdModuloP.Text = ""
                txtNomModuloP.Clear()
                txtAñoP.Clear()
                CboespecialidadP.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRAR()

        txtNomModuloP.Enabled = False
        txtAñoP.Enabled = False
        BTNNUEVO.Enabled = True
        btncancelar.Enabled = True
        btnEliminarP.Enabled = False
        btnGuardarP.Enabled = False
        btnModificarP.Enabled = False
        btnSalirT.Enabled = True
        txtBuscarP.Text = ""
        txtNomModuloP.Text = ""
        txtAñoP.Text = ""
        txtBuscarP.Enabled = True
        BTNNUEVO.Focus()
    End Sub

    Private Sub btnModificarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarP.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidmoduloP = lblIdModuloP.Text
            dts.gNom_modulo = txtNomModuloP.Text
            dts.gaño_MODULO = txtAñoP.Text
            dts.gidespeci = CboespecialidadP.Text
            dts.gIdUsuario = lblUsuario.Text

            If func.modificarModuloP(dts) Then
                MsgBox("El módulo se a modificado")
                lblIdModuloP.Text = ""
                txtNomModuloP.Clear()
                txtAñoP.Clear()
                CboespecialidadP.Text = ""
                txtBuscarP.Clear()
            Else
                MsgBox("Error al editar")
                lblIdModuloP.Text = ""
                txtNomModuloP.Clear()
                txtAñoP.Clear()
                CboespecialidadP.Text = ""
                txtBuscarP.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRAR()

        '****
        BTNNUEVO.Enabled = True
        btncancelar.Enabled = True
        btnEliminarP.Enabled = False
        btnModificarP.Enabled = False
        btnSalirT.Enabled = True
        btnGuardarP.Enabled = True
        txtNomModuloP.Enabled = False
        txtAñoP.Enabled = False
        txtBuscarP.Enabled = False
        txtNomModuloP.Text = ""
        txtAñoP.Text = ""
        BTNNUEVO.Focus()

    End Sub
    Private Sub btnEliminarP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidmoduloP = lblIdModuloP.Text

            If func.eliminarmoduloP(dts) Then
                MsgBox("El módulo se a eliminado")
                lblIdModuloP.Text = ""
                txtNomModuloP.Clear()
                txtAñoP.Clear()
                CboespecialidadP.Text = ""
                txtBuscarP.Clear()
            Else
                MsgBox("Error al eliminar")
                lblIdModuloP.Text = ""
                txtNomModuloP.Clear()
                txtAñoP.Clear()
                CboespecialidadP.Text = ""
                txtBuscarP.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnBuscarP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarP.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarModuloP(idmoduloP:=txtBuscarP.Text, idespecialidad:=CboespecialidadP.SelectedValue)

            lblIdModuloP.Text = dt.Rows(0).Item(0)
            txtAñoP.Text = dt.Rows(0).Item(2)
            txtNomModuloP.Text = dt.Rows(0).Item(3)

            'If CboespecialidadP.Text = " & Me.cboEspecialidad.text & " Then
            '    With CboespecialidadP
            '        .DataSource = func.mostrarEspecialidad

            '        .DisplayMember = "Nom_Especialidad"

            '        .ValueMember = "IdEspecialidad"
            '    End With
            'End If

            'ToolStripStatusLabel3.Text = dt.Rows(0).Item(4)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtNomModuloP.Enabled = True
        txtAñoP.Enabled = True
        '********
        btnModificarP.Enabled = True
        btnEliminarP.Enabled = True
        btnGuardarP.Enabled = False
        btncancelar.Enabled = False
        btnBuscarP.Enabled = True
        '  txtBuscarP.Text = ""
        txtNomModuloP.Focus()
    End Sub

    Private Sub btnVerP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.mostrarModuloP
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarP.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidmoduloP = lblIdModuloP.Text
            dts.gNom_modulo = txtNomModuloP.Text
            dts.gaño_MODULO = txtAñoP.Text
            dts.gidespeci = CboespecialidadP.SelectedValue
            dts.gIdUsuario = lblUsuario.Text

            If func.GuardarModuloP(dts) Then
                MsgBox("nuevo modulo insertado")
                lblIdModuloP.Text = ""
                txtNomModuloP.Clear()
                TxtAñoT.Clear()
                CboespecialidadP.Text = ""

            Else
                MsgBox("error al insertar")
                lblIdModuloP.Text = ""
                txtNomModuloP.Clear()
                txtAñoP.Clear()
                CboespecialidadP.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRAR()

        BTNNUEVO.Enabled = True
        btncancelar.Enabled = True
        btnEliminarP.Enabled = False
        btnGuardarP.Enabled = False
        btnModificarP.Enabled = False
        btnSalirT.Enabled = True
        txtNomModuloP.Enabled = False
        txtAñoP.Enabled = False
        txtBuscarP.Enabled = True
        txtNomModuloP.Text = ""
        txtAñoP.Text = ""
        BTNNUEVO.Focus()
    End Sub

    ''CODIGO DE PESTAÑA DE MODULO TRANSVERSAL

    Private Sub BtnBuscarT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarT.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarModuloT(idmoduloT:=TxtBuscarT.Text, idEspecialidad:=CboEspecialidadT.SelectedValue)

            lblIdModuloT.Text = dt.Rows(0).Item(0)
            TxtAñoT.Text = dt.Rows(0).Item(2)
            TxtNomModuloT.Text = dt.Rows(0).Item(3)

            'ToolStripStatusLabel3.Text = dt.Rows(0).Item(4)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TxtNomModuloT.Enabled = True
        TxtAñoT.Enabled = True
        '********
        btnModificarT.Enabled = True
        btnEliminarT.Enabled = True
        btnGuardarT.Enabled = False
        btncancelar.Enabled = False
        BtnBuscarT.Enabled = True
        '  txtBuscarP.Text = ""
        TxtNomModuloT.Focus()
    End Sub

    Private Sub BtnNuevoT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

       

    End Sub



    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim FUNC As New funciones
        Dim DT As DataTable = FUNC.GenerarIDModuloP

        If IsDBNull(DT.Rows(0)(0)) Then
            lblIdModuloP.Text = "MP01"
        Else
            lblIdModuloP.Text = DT.Rows(0)(0)
        End If

        txtNomModuloP.Clear()
        txtAñoP.Clear()
        btnGuardarP.Enabled = True
        btncancelar.Enabled = True
        btnModificarP.Enabled = False
        btnEliminarP.Enabled = False
        BTNNUEVO.Enabled = False
        txtNomModuloP.Enabled = True
        txtAñoP.Enabled = True
        txtNomModuloP.Focus()

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        lblIdModuloP.Text = ""
        txtNomModuloP.Clear()
        txtAñoP.Clear()
        CboespecialidadP.Text = ""
        txtNomModuloP.Enabled = False
        txtAñoP.Enabled = False
        BTNNUEVO.Enabled = True
        btncancelar.Enabled = True
        btnEliminarP.Enabled = False
        btnGuardarP.Enabled = False
        btnModificarP.Enabled = False

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        '  Me.Close()
        Try
            If MsgBox("ESTAS SEGURO DE SALIR", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMenu.Show()
    End Sub

    ''CODIGOS DE MODULOS TRANSVERSALES

    Private Sub btnNuevoT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoT.Click
        Dim FUNC As New funciones
        Dim DT As DataTable = FUNC.GenerarIDModuloT

        If IsDBNull(DT.Rows(0)(0)) Then
            lblIdModuloT.Text = "MT01"
        Else
            lblIdModuloT.Text = DT.Rows(0)(0)
        End If

        TxtNomModuloT.Clear()
        TxtAñoT.Clear()
        btnGuardarT.Enabled = True
        btnCancelarT.Enabled = True
        btnModificarT.Enabled = False
        btnEliminarT.Enabled = False
        btnNuevoT.Enabled = False
        TxtNomModuloT.Enabled = True
        TxtAñoT.Enabled = True
        TxtNomModuloT.Focus()

    End Sub

    Private Sub btnCancelarT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarT.Click
        lblIdModuloT.Text = ""
        TxtNomModuloT.Clear()
        TxtAñoT.Clear()
        CboEspecialidadT.Text = ""
        TxtBuscarT.Clear()
        TxtNomModuloT.Enabled = False
        TxtAñoT.Enabled = False
        btnNuevoT.Enabled = True
        btnCancelarT.Enabled = False
        btnEliminarT.Enabled = False
        btnGuardarT.Enabled = False
        btnModificarT.Enabled = False
    End Sub

    Private Sub btnEliminarT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarT.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidmoduloT = lblIdModuloT.Text

            If func.eliminarmoduloT(dts) Then
                MsgBox("El módulo se a eliminado")
                
            Else
                MsgBox("Error al eliminar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRARR()

        TxtNomModuloT.Enabled = False
        TxtAñoT.Enabled = False
        btnNuevoT.Enabled = True
        btnCancelarT.Enabled = False
        btnEliminarT.Enabled = False
        btnGuardarT.Enabled = False
        btnModificarT.Enabled = False
        btnSalirT.Enabled = True
        TxtBuscarT.Text = ""
        TxtNomModuloT.Text = ""
        TxtAñoT.Text = ""
        TxtBuscarT.Enabled = True
        btnNuevoT.Focus()
    End Sub

    Private Sub btnModificarT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarT.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidmoduloT = lblIdModuloT.Text
            dts.gNom_modulo = TxtNomModuloT.Text
            dts.gaño_MODULO = TxtAñoT.Text
            dts.gidespeci = CboEspecialidadT.Text
            dts.gIdUsuario = lblUsuario.Text

            If func.modificarModuloT(dts) Then
                MsgBox("El módulo se a modificado")
               
            Else
                MsgBox("Error al editar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRARR()

        btnNuevoT.Enabled = True
        btnCancelarT.Enabled = False
        btnEliminarT.Enabled = False
        btnModificarT.Enabled = False
        btnSalirT.Enabled = True
        btnGuardarT.Enabled = True
        TxtNomModuloT.Enabled = False
        TxtAñoT.Enabled = False
        TxtBuscarT.Enabled = False
        TxtNomModuloT.Text = ""
        TxtAñoT.Text = ""
        btnNuevoT.Focus()
    End Sub

    Private Sub btnGuardarT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarT.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidmoduloT = lblIdModuloT.Text
            dts.gNom_modulo = TxtNomModuloT.Text
            dts.gaño_MODULO = TxtAñoT.Text
            dts.gidespeci = CboEspecialidadT.SelectedValue
            dts.gIdUsuario = lblUsuario.Text


            If func.GuardarModuloT(dts) Then
                MsgBox("nuevo modulo insertado")
                

            Else
                MsgBox("error al insertar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Call MOSTRARR()

        btnNuevoT.Enabled = True
        btnCancelarT.Enabled = False
        btnEliminarT.Enabled = False
        btnGuardarT.Enabled = False
        btnModificarT.Enabled = False
        btnSalirT.Enabled = True
        TxtNomModuloT.Enabled = False
        TxtAñoT.Enabled = False
        TxtBuscarT.Enabled = True
        TxtNomModuloT.Text = ""
        TxtAñoT.Text = ""
        btnNuevoT.Focus()
    End Sub

    Private Sub btnSalirT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirT.Click
        Me.Close()
        Try
            If MsgBox("ESTAS SEGURO DE SALIR", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMenu.Show()
    End Sub

    Private Sub txtBuscarP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnBuscarP.Focus()
        End If
    End Sub
    Private Sub txtBuscarP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarP.TextChanged
        Me.txtBuscarP.Text = UCase(Me.txtBuscarP.Text)
        Me.txtBuscarP.SelectionStart = Me.txtBuscarP.TextLength + 1
    End Sub

    Private Sub txtNomModuloP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomModuloP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CboespecialidadP.Focus()
        End If
    End Sub

    Private Sub txtNomModuloP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomModuloP.LostFocus
        If txtNomModuloP.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtNomModuloP.Focus()
        End If
    End Sub

    Private Sub txtNomModuloP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomModuloP.TextChanged
        Me.txtNomModuloP.Text = UCase(Me.txtNomModuloP.Text)
        Me.txtNomModuloP.SelectionStart = Me.txtNomModuloP.TextLength + 1
    End Sub

    Private Sub txtAñoP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAñoP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardarP .Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificarP.Focus()
        End If

    End Sub

    Private Sub txtAñoP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAñoP.LostFocus
        If txtAñoP.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtAñoP.Focus()
        End If
    End Sub

    Private Sub txtAñoP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAñoP.TextChanged
        Dim i As Integer
        txtAñoP.Text = UCase(txtAñoP.Text)
        i = Len(txtAñoP.Text)
        txtAñoP.SelectionStart = i
    End Sub

    Private Sub CboespecialidadP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboespecialidadP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtAñoP.Focus()
        End If
    End Sub

    Private Sub CboespecialidadP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboespecialidadP.SelectedIndexChanged
        CboespecialidadP.DroppedDown = True
    End Sub

    Private Sub frmModulo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtBuscarP.Focus()
    End Sub

    Private Sub btnVerT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerT.Click
        Try
            Dim dt As DataTable = func.mostrarModuloT
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtNomModuloT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNomModuloT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CboEspecialidadT.Focus()
        End If
    End Sub

    Private Sub TxtNomModuloT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNomModuloT.LostFocus
        If TxtNomModuloT.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            TxtNomModuloT.Focus()
        End If
    End Sub

    Private Sub TxtAñoT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAñoT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardarT.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificarT.Focus()
        End If
    End Sub

    Private Sub TxtAñoT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAñoT.LostFocus
        If TxtAñoT.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            TxtAñoT.Focus()
        End If
    End Sub

    Private Sub CboEspecialidadT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboEspecialidadT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtAñoT.Focus()
        End If
    End Sub
    Private Sub CboEspecialidadT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboEspecialidadT.SelectedIndexChanged
        CboEspecialidadT.DroppedDown = True
    End Sub

    Private Sub TxtBuscarT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscarT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnBuscarT.Focus()
        End If
    End Sub

    Private Sub TxtBuscarT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarT.TextChanged
        Me.TxtBuscarT.Text = UCase(Me.TxtBuscarT.Text)
        Me.TxtBuscarT.SelectionStart = Me.TxtBuscarT.TextLength + 1
    End Sub

    Private Sub TxtNomModuloT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNomModuloT.TextChanged
        Me.TxtNomModuloT.Text = UCase(Me.TxtNomModuloT.Text)
        Me.TxtNomModuloT.SelectionStart = Me.TxtNomModuloT.TextLength + 1
    End Sub

    Private Sub TxtAñoT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAñoT.TextChanged

    End Sub
End Class