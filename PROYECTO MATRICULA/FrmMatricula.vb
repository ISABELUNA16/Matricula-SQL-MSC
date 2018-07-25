
Imports System.Data
Imports System.Data.SqlClient
Public Class FrmMatricula
    Dim func As New funciones
    Dim dts As datos
    Dim dialog As New OpenFileDialog
    Dim carrera As String

    '**********
    Const strcn As String = "data source =(local);DATABASE = MATRICULA ; INTEGRATED SECURITY = SSPI"
    Dim cn As New SqlConnection(strcn)
    Private Const IdAlumno As Integer = 0
    Private Const Ape_Paterno As Integer = 1
    Private Const Ape_Materno As Integer = 2
    Private Const Nom_Alumno As Integer = 3
    Private Const Año_Ingreso As Integer = 4
    Private Const Nom_Especialidad As Integer = 5
    Private Const Nom_Turno As Integer = 6
    Private Const Edad As Integer = 7
    Private Const Sexo_Alumno As Integer = 8
    Private Const Telef_Alumno As Integer = 9
    Private Const E_Mail As Integer = 10



    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click

        btnguardar.Enabled = True

        If RbAdmision.Checked = True Then
            Dim FUNC As New funciones
            Dim DT As DataTable = FUNC.GENERARIDMATRICULA

            btnguardar.Enabled = True

            If IsDBNull(DT.Rows(0)(0)) Then
                lblIdMatricula.Text = Convert.ToString("0001" + "-" + Mid(Trim(cbosemestre.Text), 3, 2))
            Else
                Dim value As Integer
                value = Convert.ToInt32(Mid(DT.Rows(0)(0), 1, 4))
                lblIdMatricula.Text = (value.ToString("D4") + "-" + Mid(Trim(cbosemestre.Text), 3, 2))
            End If

        ElseIf RbTrasladoE.Checked = True Then
            Dim FUNC As New funciones
            Dim DT As DataTable = FUNC.GENERARIDMATRICULAE
            Dim value As Integer
            value = Mid(DT.Rows(0)(0), 1, 4)
            btnguardar.Enabled = True

            If IsError(value.ToString) <= "1000" Then

                lblIdMatricula.Text = Convert.ToString("1001" + "-" + Mid(Trim(cbosemestre.Text), 3, 2))
            Else
                'Dim value As Integer
                'value = Convert.ToInt32(Mid(DT.Rows(0)(0), 1, 4))
                lblIdMatricula.Text = (value.ToString("D4") + "-" + Mid(Trim(cbosemestre.Text), 3, 2))
            End If

        ElseIf rbTrasladoI.Checked = True Then

            MsgBox("Ingrese DNI de alumno y modifique carrera de matricula")
        Else
            MsgBox("SELECCIONE TIPO DE INGRESO")
        End If
    End Sub


    Private Sub FrmMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Picfotoalum.SizeMode = PictureBoxSizeMode.StretchImage

        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        cbosemestre.Focus()

        With cbosemestre

            .DataSource = func.mostrarSemestre

            .DisplayMember = "Idsemestre"

            .ValueMember = "Idsemestre"

        End With


        With cbociclo

            .DataSource = func.mostrarCiclo

            .DisplayMember = "Nom_ciclo"

            .ValueMember = "Idciclo"

        End With

        With cboturno

            .DataSource = func.mostrarTurno

            .DisplayMember = "Nom_turno"

            .ValueMember = "Idturno"

        End With



        With cboespecialidad

            .DataSource = func.mostrarEspecialidad

            .DisplayMember = "nom_especialidad"

            .ValueMember = "Idespecialidad"

        End With

        'With cboapepat_alum

        '    .DataSource = func.mostrarnomalumno

        '    .DisplayMember = "ape_paterno, ape_materno"

        '    .ValueMember = "ape_paterno"

        'End With

        cbociclo.Text = ""
        cboespecialidad.Text = ""
        cbosemestre.Text = ""
        cboturno.Text = ""
        cboapepat_alum.Text = ""


        Try
            Dim func As New funciones
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            lblusuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '******************************

    
        Dim cn As New SqlConnection(strcn)
        Dim cmdcarrera As New SqlCommand(" select distinct Nom_Especialidad from Alumno ", cn)
        Dim DR As SqlDataReader
        Dim PADRE As TreeNode

        titulo()

        TVREGISTRO.Nodes.Clear()

        With cmdcarrera
            .Connection.Open()
            DR = .ExecuteReader
            PADRE = New TreeNode("Nom_Especialidad")
            TVREGISTRO.Nodes.Add(PADRE)
            While DR.Read
                PADRE.Nodes.Add(DR("Nom_Especialidad"))

            End While
            .Connection.Close()
        End With
      



    End Sub


    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Try
            Dim func As New funciones
            Dim dts As New datos
            dts.gIdAlumno = txtidalumno.Text
            dts.gIdMATRICULA = lblIdMatricula.Text()
            dts.gIdEspecialidad = cboespecialidad.SelectedValue
            dts.gidsemestre = cbosemestre.SelectedValue
            dts.gidciclo = cbociclo.SelectedValue
            dts.gidturno = cboturno.SelectedValue
            dts.gaño_MODULO = txtaño_modulo.Text
            dts.gfecha_matricula = lblfecha.Text
            If RbAdmision.Checked = True Then
                dts.gDescripcion = "Admisión"
            ElseIf RbTrasladoE.Checked = True Then

                dts.gDescripcion = "Traslado Externo"
            Else
                dts.gDescripcion = "Traslado Interno"
            End If
            dts.gfecha_matricula = lblfecha.Text
            dts.gIdUsuario = lblusuario.Text


            If func.insertarMATRICULA(dts) Then
                MsgBox("MATRICULA EXITOSA")

            Else
                MsgBox("ERROR AL INSERTAR MATRICULA")

            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        btnguardar.Enabled = True

    End Sub

    Private Sub btnbuscaralumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscaralumno.Click
        Try

            Dim dt As New DataTable
            dt = func.buscaralumno(idalumno:=txtidalumno.Text)

            If IsDBNull(dt.Rows(0).Item(5)) Then
                cboapepat_alum.Text = ""
            Else
                cboapepat_alum.Text = dt.Rows(0).Item(5)
            End If

            If IsDBNull(dt.Rows(0).Item(6)) Then
                txtapemat_alum.Text = ""
            Else
                txtapemat_alum.Text = dt.Rows(0).Item(6)
            End If

            If IsDBNull(dt.Rows(0).Item(7)) Then
                txtnom_alum.Text = ""
            Else
                txtnom_alum.Text = dt.Rows(0).Item(7)
            End If



            If IsDBNull(dt.Rows(0).Item(4)) Then
                cboespecialidad.Text = ""
            Else

                cboespecialidad.Text = dt.Rows(0).Item(4)

            End If



            If IsDBNull(dt.Rows(0).Item(24)) Then
                txtcorreo.Text = ""
            Else
                txtcorreo.Text = dt.Rows(0).Item(24)
            End If

            If IsDBNull(dt.Rows(0).Item(28)) Then
                dialog.FileName = dt.Rows(0).Item(28)
                Picfotoalum.Image = System.Drawing.Image.FromFile(dialog.FileName)
                MsgBox("no hay foto")
            Else
                Picfotoalum.Image = System.Drawing.Image.FromFile(dt.Rows(0).Item(27))
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnguardar.Visible = True
    End Sub

    Private Sub txtidalumno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidalumno.TextChanged
        txtidalumno.MaxLength = 8
    End Sub

    Private Sub txtapepat_alum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cboapepat_alum.Text = UCase(cboapepat_alum.Text)
    End Sub

    ''Private Sub lblfecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblfecha.Click
    ''    lblfecha.Text = Date.Now.ToString("YYYY/MM/dd")
    ''    'lblfecha.Text = Date.Now
    ''End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    'Private Sub RbAdmision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbAdmision.CheckedChanged

    '    'Dim FUNC As New funciones
    '    'Dim DT As DataTable = FUNC.GENERARIDMATRICULA

    '    'btncancelar.Visible = True


    '    'If IsDBNull(DT.Rows(0)(0)) Then
    '    '    lblIdMatricula.Text = Convert.ToString("0001" + "-" + Mid(Trim(cbosemestre.Text), 3, 2))
    '    'Else
    '    '    Dim value As Integer
    '    '    value = Convert.ToInt32(Mid(DT.Rows(0)(0), 1, 4))
    '    '    lblIdMatricula.Text = (value.ToString("D4") + "-" + Mid(Trim(cbosemestre.Text), 3, 2))
    '    'End If
    'End Sub

    'Private Sub RbTraslado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbTrasladoE.CheckedChanged

    '    For i = 1001 To 2000 + 1

    '    Next
    '    'Dim FUNC As New funciones
    '    'Dim DT As DataTable = FUNC.GENERARIDMATRICULAE
    '    'btncancelar.Visible = True


    '    'If IsDBNull(Convert.ToInt32(Mid(DT.Rows(0)(0), 1, 4))) Then

    '    '    lblIdMatricula.Text = Convert.ToString("1001" + "-" + Mid(Trim(cbosemestre.Text), 3, 2))
    '    'Else
    '    '    Dim value As Integer
    '    '    value = Convert.ToInt32(Mid(DT.Rows(0)(0), 1, 4))
    '    '    lblIdMatricula.Text = (value.ToString("D4") + "-" + Mid(Trim(cbosemestre.Text), 3, 2))

    '    'End If

    'End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim func As New funciones

            Dim dt As DataTable = func.buscarmatricula(idalumno:=TXTbuscar.Text)

            txtidalumno.Text = dt.Rows(0).Item(1)
            lblIdMatricula.Text = dt.Rows(0).Item(0)
            cbosemestre.Text = dt.Rows(0).Item(3)
            cbociclo.Text = dt.Rows(0).Item(7)
            txtaño_modulo.Text = dt.Rows(0).Item(5)
            cboturno.Text = dt.Rows(0).Item(4)

            If dt.Rows(0).Item(9) = "Admisión" Then
                RbAdmision.Checked = True
            ElseIf dt.Rows(0).Item(9) = "Traslado Externo" Then
                RbTrasladoE.Checked = True
            Else

                rbTrasladoI.Checked = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub


    Private Sub cbosemestre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BTNNUEVO.Enabled = True
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        txtidalumno.Text = ""
        cboapepat_alum.Text = ""
        txtapemat_alum.Text = ""
        txtnom_alum.Text = ""
        txtcorreo.Text = ""
        cbosemestre.Text = ""
        cbociclo.Text = ""
        cboespecialidad.Text = ""
        cboturno.Text = ""
        txtaño_modulo.Text = ""

        RbAdmision.Checked = False
        RbTrasladoE.Checked = False
        rbTrasladoI.Checked = False
        lblIdMatricula.Text = ""
        TXTbuscar.Text = ""


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones


            dts.gIdEspecialidad = cboespecialidad.Text
            dts.gidsemestre = cbosemestre.Text
            dts.gidciclo = cbociclo.Text
            dts.gidturno = cboturno.Text
            dts.gaño_MODULO = txtaño_modulo.Text
            dts.gfecha_matricula = lblfecha.Text

            If RbAdmision.Checked = True Then
                dts.gDescripcion = "Admisión"
            ElseIf RbTrasladoE.Checked = True Then
                dts.gDescripcion = "Traslado Externo"
            Else
                dts.gDescripcion = "Traslado Interno"
            End If

            If func.modificaralumno(dts) Then
                MsgBox("Los Datos Han Sido Modificados")


            Else
                MsgBox("ERROR AL MODIFICAR")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdMATRICULA = lblIdMatricula.Text

            If func.eliminarmatricula(dts) Then
                MsgBox("La matricula se a eliminado")

            Else
                MsgBox("Error al eliminar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Sub titulo()
        LVLISTA.Clear()
        LVLISTA.View = View.Details
        LVLISTA.GridLines = True
        LVLISTA.FullRowSelect = True
        LVLISTA.Columns.Add("IdAlumno", 25, HorizontalAlignment.Center)
        LVLISTA.Columns.Add("Ape_Paterno", 120, HorizontalAlignment.Left)
        LVLISTA.Columns.Add("Ape_Materno", 120, HorizontalAlignment.Center)
        LVLISTA.Columns.Add("Nom_Alumno", 120, HorizontalAlignment.Left)
        LVLISTA.Columns.Add("Año_Ingreso", 20, HorizontalAlignment.Center)
        LVLISTA.Columns.Add("Nom_Especialidad", 120, HorizontalAlignment.Left)
        LVLISTA.Columns.Add("Nom_Turno", 25, HorizontalAlignment.Center)
        LVLISTA.Columns.Add("Edad", 10, HorizontalAlignment.Left)
        LVLISTA.Columns.Add("Sexo_Alumno", 10, HorizontalAlignment.Center)
        LVLISTA.Columns.Add("Telef_Alumno", 10, HorizontalAlignment.Left)
        LVLISTA.Columns.Add("E_mail", 25, HorizontalAlignment.Right)


    End Sub
    Sub llenar()
        Dim cmd As New SqlCommand("select IdAlumno , Ape_Paterno , Ape_Materno , Nom_Alumno, Año_Ingreso, Nom_Especialidad , Nom_Turno , Edad , Sexo_Alumno , Telef_Alumno , E_Mail from Alumno where " & carrera & " order by Nom_Especialidad ", cn)
        Dim dr As SqlDataReader
        Dim Alumno As ListViewItem
        titulo()
        With cmd
            .Connection.Open()
            dr = .ExecuteReader
            While dr.Read
                Alumno = New ListViewItem(dr("IdAlumno").ToString, 0)
                Alumno.SubItems.Add(dr("Ape_Paterno"))
                Alumno.SubItems.Add(dr("Ape_Materno"))
                Alumno.SubItems.Add(dr("Nom_Alumno"))
                Alumno.SubItems.Add(dr("AÑo_Ingreso"))
                Alumno.SubItems.Add(dr("Nom_Especialidad"))
                Alumno.SubItems.Add(dr("Nom_Turno"))
                Alumno.SubItems.Add(dr("Edad"))
                Alumno.SubItems.Add(dr("Sexo_Alumno"))
                Alumno.SubItems.Add(dr("Telef_Alumno"))
                Alumno.SubItems.Add(dr("E_Mail"))
                LVLISTA.Items.Add(Alumno)

            End While
            .Connection.Close()

        End With
    End Sub

    Private Sub TXTbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTbuscar.TextChanged
        TXTbuscar.MaxLength = 8
    End Sub

    'Private Sub rbTrasladoI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTrasladoI.CheckedChanged

    '    'Dim FUNC As New funciones
    '    'Dim DT As DataTable = FUNC.GENERARIDMATRICULA

    '    'btncancelar.Visible = True


    '    'If IsDBNull(DT.Rows(0)(0)) Then
    '    '    lblIdMatricula.Text = Convert.ToString("0001" + "-" + Mid(Trim(cbosemestre.Text), 3, 2))
    '    'Else
    '    '    Dim value As Integer
    '    '    value = Convert.ToInt32(Mid(DT.Rows(0)(0), 1, 4))
    '    '    lblIdMatricula.Text = (value.ToString("D4") + "-" + Mid(Trim(cbosemestre.Text), 3, 2))
    '    'End If
    'End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblfecha.Text = Date.Now
    End Sub

    Private Sub TVREGISTRO_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVREGISTRO.AfterSelect
        If TVREGISTRO.SelectedNode.Level = 1 Then
            Select Case TVREGISTRO.SelectedNode.Parent.Text
                Case "Nom_Especialidad"
                    carrera = "Nom_Especialidad='" & TVREGISTRO.SelectedNode.Text & "'"
                    llenar()
            End Select
        End If
    End Sub

    Private Sub LVLISTA_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LVLISTA.MouseClick



    End Sub

    Private Sub LVLISTA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVLISTA.SelectedIndexChanged

    End Sub
End Class

