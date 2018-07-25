Public Class FrmNotas
    Dim func As New funciones
    Dim dts As New datos

    Private Sub FrmNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            lblUsuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        With cboEspecialidad

            .DataSource = func.mostrarEspecialidad

            .DisplayMember = "Nom_Especialidad"

            .ValueMember = "IdEspecialidad"

        End With
        With CBOCICLO
            .DataSource = func.mostrarCiclo

            .DisplayMember = "Nom_CICLO"

            .ValueMember = "IdCICLO"

        End With

        With cboSemestre
            .DataSource = func.mostrarSemestre

            .DisplayMember = "Nom_Semestre"

            .ValueMember = "IdSemestre"

        End With

        With cboTurno
            .DataSource = func.mostrarTurno

            .DisplayMember = "Nom_Turno"

            .ValueMember = "IdTurno"

        End With
        With cboDocente
            .DataSource = func.mostrarDocente

            .DisplayMember = "Nom_docente"

            .ValueMember = "Iddocente"

        End With
        cboEspecialidad.DroppedDown = False
        CBOCICLO.DroppedDown = False
        cboDocente.DroppedDown = False
        cboEspecialidad.DroppedDown = False
        cboModulo.DroppedDown = False
        cboTurno.DroppedDown = False
        cboUdDidactica.DroppedDown = False
        cboSemestre.DroppedDown = False


        cboEspecialidad.Text = ""
        cboSemestre.Text = ""
        cboTurno.Text = ""
        cboModulo.Text = ""
        cboUdDidactica.Text = ""
        CBOCICLO.Text = ""
        cboDocente.Text = ""


    End Sub

    

    Private Sub TXTAÑO_MODULO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAÑO_MODULO.TextChanged
        TXTAÑO_MODULO.MaxLength = 4
    End Sub

    'Private Sub CBOCICLO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCICLO.SelectedIndexChanged

    '    Dim dT As New DataTable
    '            Dim drv As DataRowView = CBOCICLO.SelectedItem
    '    DT = func.vUNDDIDAC(idespecialidad:=Convert.ToString(cboEspecialidad.SelectedValue), AÑO_MODULO:=TXTAÑO_MODULO.Text, IDCICLO:=Convert.ToString(CBOCICLO.SelectedValue), IDMODULO:=Convert.ToString(cboModulo.SelectedValue))
    '            With cboUdDidactica
    '        .DataSource = dT
    '                .DisplayMember = "NOM_UNDDIDACTICA"
    '        .ValueMember = "IDUNDDIDAC"
    '            End With

    'End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dt As New DataTable
            dt = func.VALUMNO(IDESPECIALIDAD:=Convert.ToString(cboEspecialidad.SelectedValue), IDSEMESTRE:=Convert.ToString(cboSemestre.SelectedValue),
                                           IDCICLO:=Convert.ToString(CBOCICLO.SelectedValue), IDTURNO:=Convert.ToString(cboTurno.SelectedValue))
            DTGNOTAS.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

 
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdEspecialidad = Convert.ToString(cboEspecialidad.SelectedValue)
            dts.gidmoduloP = Convert.ToString(cboModulo.SelectedValue)
            dts.gidciclo = Convert.ToString(CBOCICLO.SelectedValue)
            dts.gIdUndDidacP = Convert.ToString(cboUdDidactica.SelectedValue)
            'dts.gidsemestre = Convert.ToString(cboSemestre.SelectedValue)
            dts.gidturno = Convert.ToString(cboTurno.SelectedValue)
            dts.gidDocente = Convert.ToString(cboDocente.SelectedValue)
            dts.gaño_MODULO = TXTAÑO_MODULO.Text

            If func.nuevoCiclo(dts) Then
                MsgBox("nueva ciclo insertado")
                cboEspecialidad.Text = ""
                cboModulo.Text = ""
                CBOCICLO.Text = ""
                cboUdDidactica.Text = ""
                cboSemestre.Text = ""
                cboTurno.Text = ""
                cboDocente.Text = ""
                TXTAÑO_MODULO.Text = ""

            Else
                MsgBox("error al insertar")
                cboEspecialidad.Text = ""
                cboModulo.Text = ""
                CBOCICLO.Text = ""
                cboUdDidactica.Text = ""
                cboSemestre.Text = ""
                cboTurno.Text = ""
                cboDocente.Text = ""
                TXTAÑO_MODULO.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

  
    Private Sub RBMPROFESIONAL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMPROFESIONAL.CheckedChanged
        Dim T As New DataTable
        T = func.vModuloP(idespecialidad:=Convert.ToString(cboEspecialidad.SelectedValue), AÑO_MODULO:=TXTAÑO_MODULO.Text)
        With cboModulo
            .DataSource = T
            .DisplayMember = "nom_modulo"
            .ValueMember = "idmoduloP"
        End With
    End Sub

    Private Sub RBMTRANSVERSAL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMTRANSVERSAL.CheckedChanged
        Dim T As New DataTable
        T = func.vModuloT(idespecialidad:=Convert.ToString(cboEspecialidad.SelectedValue), AÑO_MODULO:=TXTAÑO_MODULO.Text)
        With cboModulo
            .DataSource = T
            .DisplayMember = "nom_modulo"
            .ValueMember = "idmoduloT"
        End With
    End Sub

    Private Sub cboEspecialidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboEspecialidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CBOCICLO.Focus()
        End If
    End Sub

    Private Sub cboEspecialidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEspecialidad.SelectedIndexChanged
        cboEspecialidad.DroppedDown = True
    End Sub

    Private Sub CBOCICLO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBOCICLO.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboUdDidactica.Focus()
        End If
    End Sub

    Private Sub cboUdDidactica_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboUdDidactica.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboSemestre.Focus()
        End If
    End Sub

    Private Sub cboSemestre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSemestre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboTurno.Focus()

        End If
    End Sub

    Private Sub cboSemestre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSemestre.SelectedIndexChanged
        cboSemestre.DroppedDown = True
    End Sub

    Private Sub cboTurno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTurno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboDocente.Focus()
        End If
    End Sub

    Private Sub cboTurno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTurno.SelectedIndexChanged
        cboTurno.DroppedDown = True
    End Sub

    Private Sub CBOCICLO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCICLO.SelectedIndexChanged
        CBOCICLO.DroppedDown = True
    End Sub

    Private Sub cboUdDidactica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUdDidactica.SelectedIndexChanged
        cboUdDidactica.DroppedDown = True
    End Sub

    Private Sub cboDocente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocente.SelectedIndexChanged
        cboDocente.DroppedDown = True
    End Sub
End Class