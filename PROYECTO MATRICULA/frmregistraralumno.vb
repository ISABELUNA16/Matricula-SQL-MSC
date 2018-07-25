Imports System.Data.SqlClient
Public Class frmregistraralumno

    Dim dialog As New OpenFileDialog
    Dim dts As New datos
    Dim func As New funciones
    Dim ruta As String


    Private Sub frmregistraralumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtAñoIng.Focus()

        'dialog.FileName = "C:\fotos\ALUMNOS.PNG"
        'PicFotoAlum.Image = System.Drawing.Image.FromFile(dialog.FileName)
        CboDistrito.Text = ""
        Cboespecialidad.Text = ""
        cbotipoing.Text = ""


        Try
            '  Dim func As New funciones
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            Lblusuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

     

            With cboDistrito

                .DataSource = func.mostrardistrito

                .DisplayMember = "Nom_Distrito"

                .ValueMember = "IdDistrito"

            End With

            With cboespecialidad

                .DataSource = func.mostrarEspecialidad

                .DisplayMember = "nom_especialidad"

                .ValueMember = "Idespecialidad"

            End With


            With cboTipoIng

                .DataSource = func.mostrarTipo

                .DisplayMember = "Descripcion"

                .ValueMember = "IdTipo"

        End With

            With cboTurno

                .DataSource = func.mostrarTurno

                .DisplayMember = "Nom_turno"

                .ValueMember = "Idturno"

        End With

        cboDistrito.Text = ""
        cboespecialidad.Text = ""
        cboTipoIng.Text = ""
        cboTurno.Text = ""
        Try
            Dim dt As DataTable = func.mostraralumno
            DgAlumno.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub MOSTRARALUMNOS()
        Try
            Dim dt As DataTable = func.mostraralumno
            DgAlumno.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub BtnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExaminar.Click
        'dialog.Filter = "Todos los archivos(*.*)|*.*|Imagen(*.jpg)|*.jpg|Imagen(*.bmp)|*.bmp|Imagen(*.gif)|*.gif|Imagen(*.png)|*.png"
        'PicFotoAlum.SizeMode = PictureBoxSizeMode.StretchImage
        'If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    PicFotoAlum.Image = System.Drawing.Image.FromFile(dialog.FileName)

        'End If
    End Sub

    Private Sub TxtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDni.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txtdireccion.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
        
    End Sub
    Private Sub TxtAñoIng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAñoIng.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txtap_paterno.Focus()
        End If
    End Sub

    Private Sub Txtañoing_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAñoIng.TextChanged
        Me.TxtAñoIng.Text = UCase(Me.TxtAñoIng.Text)
        Me.TxtAñoIng.SelectionStart = Me.TxtAñoIng.TextLength + 1
    End Sub
    Private Sub Txtap_paterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtap_paterno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txtap_materno.Focus()
        End If
    End Sub

    Private Sub Txtap_materno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtap_materno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txtnombre.Focus()
        End If
    End Sub
    Private Sub Txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtnombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txtfec_nac_alum.Focus()
        End If
    End Sub

    Private Sub Txtfec_nac_alum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtdis_nac.Focus()
        End If
    End Sub

    Private Sub Gbsexo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gbsexo.Enter
        TxtTelef.Focus()
    End Sub

    Private Sub TxtTelef_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelef.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtDni.Focus()
        End If
    End Sub

    Private Sub Txtdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtdireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CboDistrito.Focus()
        End If
    End Sub

    Private Sub Cboespecialidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            BtnExaminar.Focus()
        End If
    End Sub

    Private Sub BtnExaminar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BtnExaminar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnGuardar.Focus()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Me.txtBuscar.Text = UCase(Me.txtBuscar.Text)
        Me.txtBuscar.SelectionStart = Me.txtBuscar.TextLength + 1
    End Sub

    Private Sub Txtap_paterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtap_paterno.TextChanged
        Me.Txtap_paterno.Text = UCase(Me.Txtap_paterno.Text)
        Me.Txtap_paterno.SelectionStart = Me.Txtap_paterno.TextLength + 1

        'Txtap_paterno.Text = UCase(Txtap_paterno.Text)
    End Sub

    Private Sub Txtap_materno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtap_materno.TextChanged
        Me.Txtap_materno.Text = UCase(Me.Txtap_materno.Text)
        Me.Txtap_materno.SelectionStart = Me.Txtap_materno.TextLength + 1

        'Txtap_materno.Text = UCase(Txtap_materno.Text)
    End Sub

    Private Sub Txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtnombre.TextChanged
        Me.Txtnombre.Text = UCase(Me.Txtnombre.Text)
        Me.Txtnombre.SelectionStart = Me.Txtnombre.TextLength + 1

        ' Txtnombre.Text = UCase(Txtnombre.Text)
    End Sub

    Private Sub Txtcorreo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.TXTCORREO.Text = UCase(Me.TXTCORREO.Text)
        'Me.TXTCORREO.SelectionStart = Me.TXTCORREO.TextLength + 1

        ' TXTCORREO.Text = LCase(TXTCORREO.Text)
    End Sub

    Private Sub txtdis_nac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdis_nac.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdep_nac.Focus()
        End If
    End Sub

    Private Sub txtdep_nac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdep_nac.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtprov_nac.Focus()
        End If
    End Sub

    Private Sub txtprov_nac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprov_nac.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtedad_alum.Focus()
        End If
    End Sub

    Private Sub txtedad_alum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtedad_alum.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtTelef.Focus()
        End If
    End Sub

    Private Sub TXTCORREO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            cboespecialidad.Focus()
        End If
    End Sub

    Private Sub cboespecialidad_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboespecialidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboTipoIng.Focus()
        End If
    End Sub

    Private Sub cboTipoIng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipoIng.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboTurno.Focus()
        End If
    End Sub

    Private Sub cboDistrito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDistrito.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TXTCORREO.Focus()
        End If
    End Sub

    Private Sub cboTurno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTurno.KeyPress
        Dim tp As TabPage = TabControl1.TabPages(1)
        If Asc(e.KeyChar) = 13 Then
            TabControl1.SelectedTab = tp

        End If
        If Asc(e.KeyChar) = 13 Then
            txtnom_ie.Focus()
        End If
    End Sub

    Private Sub txtnom_ie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnom_ie.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtañoeg_ie.Focus()
        End If
    End Sub

    Private Sub txtañoeg_ie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtañoeg_ie.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtfunc_trab.Focus()
        End If
    End Sub

    Private Sub txtfunc_trab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfunc_trab.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtcentrab_alum.Focus()
        End If
    End Sub

    Private Sub txtcentrab_alum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcentrab_alum.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtespecialidad_externa.Focus()
        End If
    End Sub

    Private Sub BtnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscaralumno(idalumno:=txtBuscar.Text)
            LblIdAlumno.Text = dt.Rows(0).Item(0)
            TxtDni.Text = dt.Rows(0).Item(0)
            Select Case cboDistrito.ValueMember = dt.Rows(0).Item(1)
                Case cboDistrito.ValueMember = "D01"
                    cboDistrito.Text = "San juan de Lurigancho"

            End Select

            Select Case cboTipoIng.ValueMember = dt.Rows(0).Item(2)
                Case cboTipoIng.ValueMember = "T01"
                    cboTipoIng.Text = "Admisión"

            End Select

            Txtap_paterno.Text = dt.Rows(0).Item(5)
            Txtap_materno.Text = dt.Rows(0).Item(6)
            Txtnombre.Text = dt.Rows(0).Item(7)
            Txtfec_nac_alum.Text = dt.Rows(0).Item(8)
            txtdis_nac.Text = dt.Rows(0).Item(9)
            txtprov_nac.Text = dt.Rows(0).Item(10)
            txtdep_nac.Text = dt.Rows(0).Item(11)
            txtedad_alum.Text = dt.Rows(0).Item(12)
            If dt.Rows(0).Item(13) = "F" Then
                rbfemenino.Checked = True
            Else
                rbmasculino.Checked = True
            End If
            If dt.Rows(0).Item(14) = "Soltero" Then
                rbsoltero.Checked = True
            Else
                If dt.Rows(0).Item(14) = "Casado" Then
                    rbcasado.Checked = True
                Else
                    rbconviviente.Checked = True
                End If
            End If
            Txtdireccion.Text = dt.Rows(0).Item(15)
            TxtTelef.Text = dt.Rows(0).Item(16)
            txtnom_ie.Text = dt.Rows(0).Item(17)
            txtañoeg_ie.Text = dt.Rows(0).Item(18)
            cboespecialidad.SelectedText = dt.Rows(0).Item(19)
            If dt.Rows(0).Item(20) = "N" Then
                rbno_trab.Checked = "True"
            Else
                rbsi_trab.Checked = "false"
            End If
            txtcentrab_alum.Text = dt.Rows(0).Item(21)
            txtfunc_trab.Text = dt.Rows(0).Item(22)
            cboTurno.SelectedText = dt.Rows(0).Item(23)
            TXTCORREO.Text = dt.Rows(0).Item(24)
            If dt.Rows(0).Item(25) = "S" Then
                rbsiactv.Checked = True
            Else
                rbnoactv.Checked = True
            End If
            txtespecialidad_externa.Text = dt.Rows(0).Item(26)


            TxtAñoIng.Text = dt.Rows(0).Item(28)
            txtappat_padre.Text = dt.Rows(0).Item(29)
            txtapmat_padre.Text = dt.Rows(0).Item(30)
            txtnom_padre.Text = dt.Rows(0).Item(31)
            TxtDni_padre.Text = dt.Rows(0).Item(32)
            txtocupacion_padre.Text = dt.Rows(0).Item(33)
            txtdom_padre.Text = dt.Rows(0).Item(34)
            txttel_padre.Text = dt.Rows(0).Item(35)
            txtappat_madre.Text = dt.Rows(0).Item(36)
            txtapmat_madre.Text = dt.Rows(0).Item(37)
            txtnom_madre.Text = dt.Rows(0).Item(38)
            txtdni_madre.Text = dt.Rows(0).Item(39)
            txtocupacion_madre.Text = dt.Rows(0).Item(40)
            txtdom_madre.Text = dt.Rows(0).Item(41)
            txttel_madre.Text = dt.Rows(0).Item(42)
            PicFotoAlum.Image = System.Drawing.Image.FromFile(dt.Rows(0).Item(27))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        LblIdAlumno.Text = ""
        Txtap_paterno.Text = ""
        Txtap_materno.Text = ""
        Txtnombre.Clear()
        txtdis_nac.Clear()
        txtprov_nac.Clear()
        txtdep_nac.Text = ""
        txtedad_alum.Clear()
        txtnom_ie.Clear()
        txtañoeg_ie.Clear()
        txtcentrab_alum.Clear()
        txtfunc_trab.Clear()
        txtespecialidad_externa.Clear()
        txtappat_padre.Clear()
        txtappat_madre.Clear()
        txtapmat_madre.Clear()
        txtapmat_padre.Clear()
        txtnom_padre.Clear()
        txtnom_madre.Clear()
        txttel_madre.Clear()
        txttel_padre.Clear()
        txtocupacion_madre.Clear()
        txtocupacion_padre.Clear()
        txtdom_madre.Clear()
        txtdom_padre.Clear()
        TXTCORREO.Text = "@"
        TxtTelef.Text = ""
        Txtdireccion.Text = ""
        cboespecialidad.Text = ""
        cboDistrito.Text = ""
        cboespecialidad.Text = ""
        cboTipoIng.Text = ""
        TxtDni.Text = ""
        Txtnombre.Text = ""
        Txtfec_nac_alum.Text = ""
        TxtAñoIng.Text = ""
        rbcasado.Checked = False
        rbconviviente.Checked = False
        rbfemenino.Checked = False
        rbmasculino.Checked = False
        rbno_trab.Checked = False
        ' dialog.FileName = "C:\fotos\ALUMNOS.PNG"
        'PicFotoAlum.Image = System.Drawing.Image.FromFile(dialog.FileName)

        Txtap_paterno.Focus()

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        LblIdAlumno.Text = ""
        Txtap_paterno.Text = ""
        Txtap_materno.Text = ""
        Txtnombre.Clear()
        txtdis_nac.Clear()
        txtprov_nac.Clear()
        txtdep_nac.Text = ""
        txtedad_alum.Clear()
        txtnom_ie.Clear()
        txtañoeg_ie.Clear()
        txtcentrab_alum.Clear()
        txtfunc_trab.Clear()
        txtespecialidad_externa.Clear()
        txtappat_padre.Clear()
        txtappat_madre.Clear()
        txtapmat_madre.Clear()
        txtapmat_padre.Clear()
        txtnom_padre.Clear()
        txtnom_madre.Clear()
        txttel_madre.Clear()
        txttel_padre.Clear()
        txtocupacion_madre.Clear()
        txtocupacion_padre.Clear()
        txtdom_madre.Clear()
        txtdom_padre.Clear()
        TXTCORREO.Text = "@"
        TxtTelef.Text = ""
        Txtdireccion.Text = ""
        cboespecialidad.Text = ""
        cboDistrito.Text = ""
        cboespecialidad.Text = ""
        cboTipoIng.Text = ""
        TxtDni.Text = ""
        Txtnombre.Text = ""
        Txtfec_nac_alum.Text = ""
        TxtAñoIng.Text = ""
        dialog.FileName = "C:\fotos\ALUMNOS.PNG"
        PicFotoAlum.Image = System.Drawing.Image.FromFile(dialog.FileName)
    End Sub

    Private Sub BtnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Try
            'Dim dts As New datos
            'Dim func As New funciones
            dts.gIdAlumno = LblIdAlumno.Text

            If func.eliminaralumno(dts) Then
                MsgBox("El alumno se a eliminado")
                
            Else
                MsgBox("Error al eliminar")
               
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRARALUMNOS()
    End Sub

    Private Sub BtnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Try
            'Dim dts As New datos
            'Dim func As New funciones
            dts.gIdAlumno = LblIdAlumno.Text
            dts.giddistrito = cboDistrito.SelectedValue
            dts.gIdTipo = cboTipoIng.SelectedValue
            dts.gIdEspecialidad = cboespecialidad.Text
            dts.gApe_paterno = Txtap_paterno.Text
            dts.gApe_materno = Txtap_materno.Text
            dts.gNom_Alumno = Txtnombre.Text
            dts.gfec_nac_alum = Txtfec_nac_alum.Text
            dts.gdis_nac_alum = txtdis_nac.Text
            dts.gprov_nac_alum = txtprov_nac.Text
            dts.gdep_nac_alum = txtdep_nac.Text
            dts.gedad_alum = txtedad_alum.Text
            dts.gIdUsuario = Lblusuario.Text

            If rbfemenino.Checked = True Then
                dts.gsex_alum = "F"
            Else
                dts.gsex_alum = "M"
            End If
            If rbsoltero.Checked = True Then
                dts.gest_civil_alum = "Soltero"
            ElseIf rbcasado.Checked = True Then
                dts.gest_civil_alum = "Casado"
            Else
                dts.gest_civil_alum = "Conviviente"
            End If
            dts.gdom_alum = Txtdireccion.Text
            dts.gtel_alum = TxtTelef.Text
            dts.gnomie_alum = txtnom_ie.Text
            dts.gañoeg_ie_alum = txtañoeg_ie.Text
            dts.gNom_Especialidad = cboespecialidad.Text
            If rbsi_trab.Checked = True Then
                dts.gtrabaja_alum = "Si"
            Else
                dts.gtrabaja_alum = "No"
            End If
            dts.gcen_trab_alum = txtcentrab_alum.Text
            dts.gfunc_trab_alum = txtfunc_trab.Text
            dts.gNom_turno = cboTurno.Text
            dts.gmail_alum = TXTCORREO.Text

            If rbsiactv.Checked = True Then
                dts.gestudia_alum = "Si"
            Else
                dts.gestudia_alum = "No"
            End If
            dts.gest_esp_alum = txtespecialidad_externa.Text
            dts.gañoing_alum = TxtAñoIng.Text
            dts.gape_pat_padre = txtappat_padre.Text
            dts.gape_mat_padre = txtapmat_padre.Text
            dts.gnom_padre = txtnom_padre.Text
            dts.gdni_padre = TxtDni_padre.Text
            dts.gocup_padre = txtocupacion_padre.Text
            dts.gdom_padre = txtdom_padre.Text
            dts.gtelef_padre = txttel_padre.Text
            dts.gape_pat_madre = txtapmat_madre.Text
            dts.gape_mat_madre = txtapmat_madre.Text
            dts.gnom_madre = txtnom_madre.Text
            dts.gdni_madre = txtdni_madre.Text
            dts.gocup_madre = txtocupacion_madre.Text
            dts.gdom_madre = txtdom_madre.Text
            dts.gtelef_madre = TxtTelef.Text
            dts.gruta = dialog.FileName
            dts.gIdUsuario = Lblusuario.Text

            If func.modificaralumno(dts) Then
                MsgBox("Los Datos del Alumno Han Sido Modificados")

            Else
                MsgBox("ERROR AL MODIFICAR")
               
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRARALUMNOS()
    End Sub

    Private Sub BtnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            dts.gIdAlumno = LblIdAlumno.Text
            dts.giddistrito = cboDistrito.SelectedValue
            dts.gIdTipo = cboTipoIng.SelectedValue
            dts.gIdEspecialidad = cboespecialidad.SelectedValue
            dts.gApe_paterno = Txtap_paterno.Text
            dts.gApe_materno = Txtap_materno.Text
            dts.gNom_Alumno = Txtnombre.Text
            dts.gfec_nac_alum = Txtfec_nac_alum.Text
            dts.gdis_nac_alum = txtdis_nac.Text
            dts.gprov_nac_alum = txtprov_nac.Text
            dts.gdep_nac_alum = txtdep_nac.Text
            dts.gedad_alum = txtedad_alum.Text
            If rbfemenino.Checked = True Then
                dts.gsex_alum = "F"
            Else
                dts.gsex_alum = "M"
            End If
            If rbsoltero.Checked = True Then
                dts.gest_civil_alum = "Soltero"
            ElseIf rbcasado.Checked = True Then
                dts.gest_civil_alum = "Casado"
            Else
                dts.gest_civil_alum = "Conviviente"
            End If
            dts.gdom_alum = Txtdireccion.Text
            dts.gtel_alum = TxtTelef.Text
            dts.gnomie_alum = txtnom_ie.Text
            dts.gañoeg_ie_alum = txtañoeg_ie.Text
            dts.gNom_Especialidad = cboespecialidad.Text
            If rbsi_trab.Checked = True Then
                dts.gtrabaja_alum = "Si"
            Else
                dts.gtrabaja_alum = "No"
            End If
            dts.gcen_trab_alum = txtcentrab_alum.Text
            dts.gfunc_trab_alum = txtfunc_trab.Text
            dts.gNom_turno = cboTurno.Text
            dts.gmail_alum = TXTCORREO.Text

            If rbsiactv.Checked = True Then
                dts.gestudia_alum = "Si"
            Else
                dts.gestudia_alum = "No"
            End If
            dts.gest_esp_alum = txtespecialidad_externa.Text
            dts.gañoing_alum = TxtAñoIng.Text
            dts.gape_pat_padre = txtappat_padre.Text
            dts.gape_mat_padre = txtapmat_padre.Text
            dts.gnom_padre = txtnom_padre.Text
            dts.gdni_padre = TxtDni_padre.Text
            dts.gocup_padre = txtocupacion_padre.Text
            dts.gdom_padre = txtdom_padre.Text
            dts.gtelef_padre = txttel_padre.Text
            dts.gape_pat_madre = txtappat_madre.Text
            dts.gape_mat_madre = txtapmat_madre.Text
            dts.gnom_madre = txtnom_madre.Text
            dts.gdni_madre = txtdni_madre.Text
            dts.gocup_madre = txtocupacion_madre.Text
            dts.gdom_madre = txtdom_madre.Text
            dts.gtelef_madre = txttel_madre.Text
            dts.gruta = dialog.FileName
            dts.gIdUsuario = Lblusuario.Text




            If func.insertaralumno(dts) Then
                MsgBox("nuevo alumno insertado")

            Else
                MsgBox("error al insertar alumno")
                
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRARALUMNOS()
    End Sub

    Private Sub BtnSalirT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalirT.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub txtdis_nac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdis_nac.TextChanged
        Me.txtdis_nac.Text = UCase(Me.txtdis_nac.Text)
        Me.txtdis_nac.SelectionStart = Me.txtdis_nac.TextLength + 1
    End Sub

    Private Sub txtdep_nac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdep_nac.TextChanged
        Me.txtdep_nac.Text = UCase(Me.txtdep_nac.Text)
        Me.txtdep_nac.SelectionStart = Me.txtdep_nac.TextLength + 1
    End Sub

    Private Sub txtfec_nac_alum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfec_nac_alum.KeyDown
        Me.ToolTip1.Hide(Me.txtfec_nac_alum)
    End Sub

    Private Sub txtfec_nac_alum_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs) Handles txtfec_nac_alum.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.ToolTip1.ToolTipTitle = "DATO INVALIDO"
            Me.ToolTip1.Show("LA FECHA INGRESADA NO COINCIDE CON EL TIPO DE FORMATO (dia/mes/año)", Me.txtfec_nac_alum, 0, -20, 5000)
            txtfec_nac_alum.Text = ""
            txtfec_nac_alum.Focus()
        End If
    End Sub


    Private Sub txtfec_nac_alum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfec_nac_alum.LostFocus
        Dim A As Date
        Dim R As Integer
        A = CDate(txtfec_nac_alum.Text)
        R = DateDiff(DateInterval.Year, A, Today())
        txtedad_alum.Text = R
    End Sub
    Private Sub txtfec_nac_alum_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfec_nac_alum.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdis_nac.Focus()
        End If
    End Sub

    Private Sub txtespecialidad_externa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtespecialidad_externa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtappat_padre.Focus()
        End If
    End Sub

    Private Sub txtappat_padre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtappat_padre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtapmat_padre.Focus()
        End If
    End Sub



    Private Sub txtapmat_padre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapmat_padre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnom_padre.Focus()
        End If
    End Sub

    Private Sub txtnom_padre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnom_padre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtocupacion_padre.Focus()
        End If
    End Sub

    Private Sub txtnom_padre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnom_padre.TextChanged

    End Sub

    Private Sub txtocupacion_padre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtocupacion_padre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtDni_padre.Focus()
        End If
    End Sub

    Private Sub txtocupacion_padre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtocupacion_padre.TextChanged

    End Sub

    Private Sub txttel_padre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_padre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdom_padre.Focus()
        End If
    End Sub

    Private Sub txttel_padre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttel_padre.TextChanged

    End Sub

    Private Sub TxtDni_padre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDni_padre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txttel_padre.Focus()
        End If
    End Sub

    Private Sub TxtDni_padre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDni_padre.TextChanged

    End Sub

    Private Sub txtdom_padre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdom_padre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtappat_madre.Focus()
        End If
    End Sub

    Private Sub txtdom_padre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdom_padre.TextChanged

    End Sub

    Private Sub txtappat_madre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtappat_madre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtapmat_madre.Focus()
        End If
    End Sub

    Private Sub txtapmat_madre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapmat_madre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnom_madre.Focus()
        End If
    End Sub

    Private Sub txtapmat_madre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapmat_madre.TextChanged

    End Sub

    Private Sub txtnom_madre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnom_madre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtocupacion_madre.Focus()
        End If
    End Sub

    Private Sub txtnom_madre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnom_madre.TextChanged

    End Sub

    Private Sub txtocupacion_madre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtocupacion_madre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdni_madre.Focus()
        End If
    End Sub

    Private Sub txtocupacion_madre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtocupacion_madre.TextChanged

    End Sub

    Private Sub txtdni_madre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdni_madre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txttel_madre.Focus()
        End If
    End Sub

    Private Sub txtdni_madre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdni_madre.TextChanged

    End Sub

    Private Sub txttel_madre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel_madre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdom_madre.Focus()
        End If
    End Sub

    Private Sub txtdom_madre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdom_madre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnGuardar.Focus()
        End If
    End Sub

    Private Sub txtprov_nac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprov_nac.TextChanged
        Me.txtprov_nac.Text = UCase(Me.txtprov_nac.Text)
        Me.txtprov_nac.SelectionStart = Me.txtprov_nac.TextLength + 1
    End Sub

    Private Sub Txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtdireccion.TextChanged
        Me.Txtdireccion.Text = UCase(Me.Txtdireccion.Text)
        Me.Txtdireccion.SelectionStart = Me.Txtdireccion.TextLength + 1
    End Sub

    Private Sub txtcorreo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorreo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboespecialidad.Focus()
        End If
    End Sub

    Private Sub cboDistrito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDistrito.SelectedIndexChanged

    End Sub
End Class