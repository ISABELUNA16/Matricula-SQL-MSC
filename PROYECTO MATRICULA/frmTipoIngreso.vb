Public Class frmTipoIngreso

    Private Sub frmTipoIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDescrip.Focus()
        BtnCancelar.Enabled = True
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        BtnGuardar.Enabled = False
        txtIdTipo.Enabled = False
        txtDescrip.Enabled = False
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            '  lblusuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.mostrarTipo
            DataGrid1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub MOSTRAR()
        Dim funcs As New funciones
        Dim dtse As DataTable = funcs.mostrarTipo
        DataGrid1.DataSource = dtse
    End Sub

    Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim FUNC As New funciones
        Dim DT As DataTable = FUNC.GENERARIDTIPO

        If IsDBNull(DT.Rows(0)(0)) Then
            txtIdTipo.Text = "T01"
            ' txtDescrip.Focus()
        Else
            txtIdTipo.Text = DT.Rows(0)(0)
        End If


        '**********

        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False
        txtIdTipo.Enabled = True
        txtDescrip.Enabled = True
        txtDescrip.Text = ""
        txtDescrip.Focus()
       
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        txtIdTipo.Clear()
        txtDescrip.Clear()
        txtBuscar.Clear()
        txtIdTipo.Enabled = False
        txtDescrip.Enabled = False
        btnNuevo.Enabled = True
        BtnCancelar.Enabled = True
        btnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        btnModificar.Enabled = False
        txtBuscar.Focus()
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdTipo = txtIdTipo.Text

            If func.eliminarTipo(dts) Then
                MsgBox("El tipo de Ingreso se a eliminado")
               
            Else
                MsgBox("Error al eliminar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRAR()
       
        '***********
        txtIdTipo.Enabled = False
        txtDescrip.Enabled = False
        btnNuevo.Enabled = True
        BtnCancelar.Enabled = True
        btnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        btnModificar.Enabled = False
        BtnSalirT.Enabled = True
        txtBuscar.Text = ""
        txtIdTipo.Text = ""
        txtDescrip.Text = ""
        txtBuscar.Enabled = True
        txtBuscar.Focus()
    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdTipo = txtIdTipo.Text
            dts.gDescripcion = txtDescrip.Text
            'txtIdTipo.Enabled = True
            'txtDescrip.Enabled = True
            'txtIdTipo.Focus()

            If func.modificarTipo(dts) Then
                MsgBox("El Tipo de Ingreso se a modificado")
                
            Else
                MsgBox("Error al editar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRAR()
        '*************************
        btnNuevo.Enabled = True
        BtnCancelar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        BtnSalirT.Enabled = True
        BtnGuardar.Enabled = True
        txtIdTipo.Enabled = False
        txtDescrip.Enabled = False
        txtBuscar.Enabled = True
        txtBuscar.Focus()
    End Sub

    Private Sub BtnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdTipo = txtIdTipo.Text
            dts.gDescripcion = txtDescrip.Text
           

            If func.nuevoTipo(dts) Then
                MsgBox("Tipo de Ingreso Insertado")

            Else
                MsgBox("error al insertar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        
        Call MOSTRAR()
     


        '******
        btnNuevo.Enabled = True
        BtnCancelar.Enabled = True
        btnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        btnModificar.Enabled = False
        BtnSalirT.Enabled = True
        txtIdTipo.Enabled = False
        txtDescrip.Enabled = False
        txtBuscar.Enabled = True
        txtDescrip.Text = ""
        txtIdTipo.Text = ""
        btnNuevo.Focus()
        '*******
    End Sub

    Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarTipo(idTipo:=txtBuscar.Text)


            txtIdTipo.Text = dt.Rows(0).Item(0)
            txtDescrip.Text = dt.Rows(0).Item(1)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        txtIdTipo.Enabled = True
        txtDescrip.Enabled = True
        '********
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = True
        btnBuscar.Enabled = True
        txtBuscar.Text = ""
        txtDescrip.Focus()


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
    Private Sub txtIdTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdTipo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDescrip.Focus()
        End If
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

    Private Sub txtIdTipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdTipo.TextChanged
        Dim i As Integer
        txtIdTipo.Text = UCase(txtIdTipo.Text)
        i = Len(txtIdTipo.Text)
        txtIdTipo.SelectionStart = i
    End Sub

    Private Sub txtDescrip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescrip.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnGuardar.Focus()

        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificar.Focus()
        End If
    End Sub

    Private Sub txtDescrip_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescrip.LostFocus
        'If String.IsNullOrEmpty(txtDescrip.Text) Then
        '    MessageBox.Show("INGRESAR EL CONTENIDO")
        '    txtDescrip.Focus()
        'End If
        'If txtDescrip.Text = "" Then
        '    ErrorProvider1.SetError(txtDescrip, "debe ingresar datos")
        '    txtDescrip.Focus()
        'End If
        If txtDescrip.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtDescrip.Focus()
        End If

    End Sub

    Private Sub txtDescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrip.TextChanged
        Me.txtDescrip.Text = UCase(Me.txtDescrip.Text)
        Me.txtDescrip.SelectionStart = Me.txtDescrip.TextLength + 1
    End Sub

    Private Sub frmTipoIngreso_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtBuscar.Focus()
    End Sub

    Private Sub btnNuevo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnNuevo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDescrip.Focus()
        End If
    End Sub
End Class