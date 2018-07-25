Public Class frmDocente
    Dim dialog As New OpenFileDialog
    Public func As New funciones
    Public dts As New datos

    Private Sub txtExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        With dialog
            .InitialDirectory = ""
            .FileName = "Todos los Archivos"
            .Filter = "Todos los Archivos|*.*|JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 2
        End With
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With PicFOTODOC
                .Image = Image.FromFile(dialog.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
            End With
        End If
    End Sub
    Sub mostrar()
        Dim funcs As New funciones
        Dim dts As DataTable = funcs.MostrarDocente
        DataGrid1.DataSource = dts
    End Sub

    Private Sub frmDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BtnNuevo.Focus()
        Try
            ' Dim func As New funciones
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            LBLUSUARIO.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Call mostrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    
    Private Sub txtIdDocente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdDocente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNom.Focus()
        End If
    End Sub
    Private Sub txtNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtApe.Focus()
        End If
    End Sub

    Private Sub txtApe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDireccion.Focus()
        End If
    End Sub
    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtEmail.Focus()
        End If
    End Sub


    Private Sub txtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDni.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSexo.Focus()
        End If
        If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub txtSexo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSexo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGrado.Focus()
        End If
    End Sub

    Private Sub txtGrado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTitulo.Focus()
        End If
    End Sub

    Private Sub txtTitulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitulo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtMaestria.Focus()
        End If
    End Sub

  
    Private Sub txtDoctorado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDoctorado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtFecNacimi.Focus()
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        '   Dim FUNC As New funciones
        Dim DT As DataTable = func.GENERARIDDOCENTE
        If IsDBNull(DT.Rows(0)(0)) Then
            txtIdDocente.Text = "DOC01"
        Else
            txtIdDocente.Text = DT.Rows(0)(0)
        End If
        'If IsDBNull(DT.Rows(0)(0)) >= 10 Then
        '    txtIdDocente.Text = "DOC10"
        'End If

        Call mostrar()

        btnGuardar.Enabled = True
        btncancelar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        BtnNuevo.Enabled = False
        txtNom.Enabled = True
        txtApe.Enabled = True
        txtDireccion.Enabled = True
        txtEmail.Enabled = True
        txtTlf.Enabled = True
        txtDni.Enabled = True
        txtSexo.Enabled = True
        txtGrado.Enabled = True
        txtTitulo.Enabled = True
        txtMaestria.Enabled = True
        txtDoctorado.Enabled = True
        txtFecNacimi.Enabled = True
        txtNom.Text = ""
        txtApe.Text = ""
        txtDireccion.Text = ""
        txtEmail.Clear()
        txtTlf.Clear()
        txtDni.Text = ""
        txtSexo.Text = ""
        txtGrado.Text = ""
        txtTitulo.Text = ""
        txtMaestria.Text = ""
        txtDoctorado.Text = ""
        txtFecNacimi.Text = ""
        txtNom.Focus()
    End Sub
    Private Sub txtFecNacimi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFecNacimi.KeyDown
        Me.ToolTip2.Hide(Me.txtFecNacimi)
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        txtIdDocente.Clear()
        txtNom.Clear()
        txtApe.Clear()
        txtGrado.Clear()
        txtTitulo.Clear()
        txtMaestria.Clear()
        txtDoctorado.Clear()
        PicFOTODOC.Image = Nothing
        txtBuscar.Clear()

        txtNom.Enabled = False
        txtApe.Enabled = False
        txtDireccion.Enabled = False
        txtEmail.Enabled = False
        txtTlf.Enabled = False
        txtDni.Enabled = False
        txtSexo.Enabled = False
        txtGrado.Enabled = False
        txtTitulo.Enabled = False
        txtMaestria.Enabled = False
        txtDoctorado.Enabled = False
        txtFecNacimi.Enabled = False
        BtnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            'Dim dts As New datos
            'Dim func As New funciones
            dts.gidDocente = txtIdDocente.Text

            If func.eliminarDocente(dts) Then
                MsgBox("El Docente a sido eliminado")
               
            Else
                MsgBox("Error al eliminar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()

        txtNom.Enabled = False
        txtApe.Enabled = False
        txtDireccion.Enabled = False
        txtEmail.Enabled = False
        txtTlf.Enabled = False
        txtDni.Enabled = False
        txtSexo.Enabled = False
        txtGrado.Enabled = False
        txtTitulo.Enabled = False
        txtMaestria.Enabled = False
        txtDoctorado.Enabled = False
        txtFecNacimi.Enabled = False
        BtnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        txtBuscar.Text = ""
        txtNom.Text = ""
        txtApe.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        txtTlf.Text = ""
        txtDni.Text = ""
        txtSexo.Text = ""
        txtGrado.Text = ""
        txtTitulo.Text = ""
        txtMaestria.Text = ""
        txtDoctorado.Text = ""
        txtFecNacimi.Text = ""
        txtBuscar.Enabled = True
        BtnNuevo.Focus()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            'Dim dts As New datos
            'Dim func As New funciones
            dts.gidDocente = txtIdDocente.Text

            dts.gnom_docente = txtNom.Text
            dts.gape_docente = txtApe.Text
            dts.ggrado = txtGrado.Text
            dts.gtitulo = txtTitulo.Text
            dts.gmaestria = txtMaestria.Text
            dts.gDir_docente = txtDireccion.Text
            dts.gDni_docente = txtDni.Text
            dts.gEmail_docente = txtEmail.Text
            dts.gTel_docente = txtTlf.Text
            dts.gFec_nac_docente = txtFecNacimi.Text
            dts.gSex_docente = txtSexo.Text
            dts.gdoctorado = txtDoctorado.Text
            dts.gruta = dialog.FileName
            dts.gIdUsuario = LBLUSUARIO.Text

            If func.modificarDocente(dts) Then
                MsgBox("El Docente se a modificado")

            Else
                MsgBox("Error al editar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()

        BtnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        btnGuardar.Enabled = True
        txtNom.Enabled = False
        txtApe.Enabled = False
        txtDireccion.Enabled = False
        txtEmail.Enabled = False
        txtDni.Enabled = False
        txtSexo.Enabled = False
        txtGrado.Enabled = False
        txtTitulo.Enabled = False
        txtMaestria.Enabled = False
        txtDoctorado.Enabled = False
        txtFecNacimi.Enabled = False
        'txtNom.Clear()
        'txtApe.Clear()
        'txtDireccion.Clear()
        'txtEmail.Clear()
        'txtDni.Clear()
        'txtSexo.Clear()
        'txtGrado.Clear()
        'txtTitulo.Clear()
        'txtMaestria.Clear()
        'txtDoctorado.Clear()
        'txtFecNacimi.Clear()
        'txtTlf.Clear()
        'BtnNuevo.Focus()
    End Sub

    Private Sub btnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidDocente = txtIdDocente.Text
            dts.gnom_docente = txtNom.Text
            dts.gape_docente = txtApe.Text
            dts.ggrado = txtGrado.Text
            dts.gtitulo = txtTitulo.Text
            dts.gmaestria = txtMaestria.Text
            dts.gDir_docente = txtDireccion.Text
            dts.gDni_docente = txtDni.Text
            dts.gEmail_docente = txtEmail.Text
            dts.gTel_docente = txtTlf.Text
            dts.gFec_nac_docente = txtFecNacimi.Text
            dts.gSex_docente = txtSexo.Text
            dts.gdoctorado = txtDoctorado.Text
            dts.gruta = dialog.FileName
            dts.gIdUsuario = LBLUSUARIO.Text

            If func.nuevoDocente(dts) Then
                MsgBox("nuevo Docente insertado")

            Else
                MsgBox("error al insertar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()
        BtnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        txtNom.Enabled = False
        txtApe.Enabled = False
        txtDireccion.Enabled = False
        txtEmail.Enabled = False
        txtTlf.Enabled = False
        txtDni.Enabled = False
        txtSexo.Enabled = False
        txtGrado.Enabled = False
        txtTitulo.Enabled = False
        txtMaestria.Enabled = False
        txtDoctorado.Enabled = False
        txtFecNacimi.Enabled = False
        txtBuscar.Enabled = True
        txtNom.Text = ""
        txtApe.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        txtTlf.Text = ""
        txtDni.Text = ""
        txtSexo.Text = ""
        txtGrado.Text = ""
        txtTitulo.Text = ""
        txtMaestria.Text = ""
        txtDoctorado.Text = ""
        txtFecNacimi.Text = ""
        BtnNuevo.Focus()
    End Sub

    Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarDocente(idDocente:=txtBuscar.Text)

            txtIdDocente.Text = dt.Rows(0).Item(0)
            txtNom.Text = dt.Rows(0).Item(1)
            txtApe.Text = dt.Rows(0).Item(2)
            txtGrado.Text = dt.Rows(0).Item(3)
            txtTitulo.Text = dt.Rows(0).Item(4)
            txtMaestria.Text = dt.Rows(0).Item(5)
            txtDoctorado.Text = dt.Rows(0).Item(6)
            ' PicFOTODOC.Image = dt.Rows(0).Item(7)
            txtDni.Text = dt.Rows(0).Item(8)
            txtEmail.Text = dt.Rows(0).Item(9)
            txtTlf.Text = dt.Rows(0).Item(10)
            txtDireccion.Text = dt.Rows(0).Item(11)
            txtFecNacimi.Text = dt.Rows(0).Item(12)
            txtSexo.Text = dt.Rows(0).Item(13)
           
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtNom.Enabled = True
        txtApe.Enabled = True
        txtDireccion.Enabled = True
        txtEmail.Enabled = True
        txtTlf.Enabled = True
        txtDni.Enabled = True
        txtSexo.Enabled = True
        txtGrado.Enabled = True
        txtTitulo.Enabled = True
        txtMaestria.Enabled = True
        txtDoctorado.Enabled = True
        txtFecNacimi.Enabled = True
        '********
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGuardar.Enabled = False
        btncancelar.Enabled = False
        btnBuscar.Enabled = True
        txtBuscar.Text = ""
        txtNom.Focus()
    End Sub
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click

        Try
            If MsgBox("ESTAS SEGURO DE SALIR", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMenu.Show()
    End Sub

    Private Sub frmDocente_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtBuscar.Focus()
    End Sub

    Private Sub txtTlf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTlf.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDni.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTlf.Focus()
        End If
    End Sub
    Private Sub txtFecNacimi_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs) Handles txtFecNacimi.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.ToolTip2.ToolTipTitle = "DATO INVALIDO"
            Me.ToolTip2.Show("LA FECHA INGRESADA NO COINCIDE CON EL TIPO DE FORMATO (dia/mes/año)", Me.txtFecNacimi, 0, -20, 5000)
            txtFecNacimi.Text = ""
            txtFecNacimi.Focus()
        End If
    End Sub
    Private Sub txtFecNacimi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecNacimi.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificar.Focus()
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnBuscar.Focus()
        End If
    End Sub

    Private Sub txtIdDocente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdDocente.TextChanged
        Me.txtIdDocente.Text = UCase(Me.txtIdDocente.Text)
        Me.txtIdDocente.SelectionStart = Me.txtIdDocente.TextLength + 1


        'Left((txtIdDocente.Text) - 3)
    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        Me.txtNom.Text = UCase(Me.txtNom.Text)
        Me.txtNom.SelectionStart = Me.txtNom.TextLength + 1
    End Sub

    Private Sub txtApe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApe.TextChanged
        Me.txtApe.Text = UCase(Me.txtApe.Text)
        Me.txtApe.SelectionStart = Me.txtApe.TextLength + 1
    End Sub

    Private Sub txtDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.TextChanged
        Me.txtDireccion.Text = UCase(Me.txtDireccion.Text)
        Me.txtDireccion.SelectionStart = Me.txtDireccion.TextLength + 1
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged
        Me.txtEmail.Text = UCase(Me.txtEmail.Text)
        Me.txtEmail.SelectionStart = Me.txtEmail.TextLength + 1
    End Sub

    Private Sub txtDni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDni.TextChanged
        Me.txtDni.Text = UCase(Me.txtDni.Text)
        Me.txtDni.SelectionStart = Me.txtDni.TextLength + 1
    End Sub

    Private Sub txtSexo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSexo.TextChanged
        Me.txtSexo.Text = UCase(Me.txtSexo.Text)
        Me.txtSexo.SelectionStart = Me.txtSexo.TextLength + 1
    End Sub

    Private Sub txtGrado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrado.TextChanged
        Me.txtGrado.Text = UCase(Me.txtGrado.Text)
        Me.txtGrado.SelectionStart = Me.txtGrado.TextLength + 1
    End Sub

    Private Sub txtTitulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitulo.TextChanged
        Me.txtTitulo.Text = UCase(Me.txtTitulo.Text)
        Me.txtTitulo.SelectionStart = Me.txtTitulo.TextLength + 1
    End Sub


    Private Sub txtDoctorado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDoctorado.TextChanged
        Me.txtDoctorado.Text = UCase(Me.txtDoctorado.Text)
        Me.txtDoctorado.SelectionStart = Me.txtDoctorado.TextLength + 1
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

        Me.txtBuscar.Text = UCase(Me.txtBuscar.Text)
        Me.txtBuscar.SelectionStart = Me.txtBuscar.TextLength + 1
    End Sub

    Private Sub txtMaestria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaestria.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDoctorado.Focus()
        End If
    End Sub

    Private Sub txtMaestria_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaestria.TextChanged
        Me.txtMaestria.Text = UCase(Me.txtMaestria.Text)
        Me.txtMaestria.SelectionStart = Me.txtMaestria.TextLength + 1
    End Sub

    Private Sub txtFecNacimi_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtFecNacimi.MaskInputRejected

    End Sub
End Class