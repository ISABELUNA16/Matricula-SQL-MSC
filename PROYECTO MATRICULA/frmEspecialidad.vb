Public Class frmEspecialidad

    Private Sub frmEspecialidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BTNNUEVO.Focus()
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            Lblusuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Try
        '    Dim func As New funciones
        '    Dim dt As DataTable = func.mostrarEspecialidad
        '    DataGrid1.DataSource = dt
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Call mostrar()
    End Sub
    Sub mostrar()
        Dim func As New funciones
        Dim dt As DataTable = func.mostrarEspecialidad
        DataGrid1.DataSource = dt
    End Sub
    Private Sub txtIdEspeci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        txtEspecialidad.Focus()

    End Sub

    Private Sub txtIdEspeci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtIdEspeci.MaxLength = 3
    End Sub

  

    Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarEspecialidad(idespecialidad:=txtBuscar.Text)

            txtIdEspeci.Text = dt.Rows(0).Item(0)
            txtEspecialidad.Text = dt.Rows(0).Item(1)
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtIdEspeci.Enabled = True
        txtEspecialidad.Enabled = True
        '********
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGUARDAR.Enabled = False
        btncancelar.Enabled = True
        btnBuscar.Enabled = True
        txtBuscar.Text = ""
        txtEspecialidad.Focus()
    End Sub

    Private Sub BTNNUEVO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim FUNC As New funciones
        Dim DT As DataTable = FUNC.GENERARIDESPECIALIDAD
        If IsDBNull(DT.Rows(0)(0)) Then
            txtIdEspeci.Text = "E01"
        Else
            txtIdEspeci.Text = DT.Rows(0)(0)
        End If

        '**********

        btnGUARDAR.Enabled = True
        btncancelar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        BTNNUEVO.Enabled = False
        txtIdEspeci.Enabled = True
        txtEspecialidad.Enabled = True
        txtEspecialidad.Text = ""
        txtEspecialidad.Focus()

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        txtIdEspeci.Enabled = False
        txtEspecialidad.Enabled = False
        txtIdEspeci.Clear()
        txtEspecialidad.Clear()
        txtBuscar.Clear()
        BTNNUEVO.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnGUARDAR.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdEspecialidad = txtIdEspeci.Text

            If func.eliminarEspecialidad(dts) Then
                MsgBox("La especialidad se a eliminado")
                
            Else
                MsgBox("Error al eliminar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()

        '***********
        txtIdEspeci.Enabled = False
        txtEspecialidad.Enabled = False
        BTNNUEVO.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnGUARDAR.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        txtBuscar.Text = ""
        txtIdEspeci.Text = ""
        txtEspecialidad.Text = ""
        txtBuscar.Enabled = True
        BTNNUEVO.Focus()
    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones

            dts.gIdEspecialidad = txtIdEspeci.Text
            dts.gNom_Especialidad = txtEspecialidad.Text

            If func.modificarEspecialidad(dts) Then
                MsgBox("La Especialidad se a Modificado correctamente")

            Else
                MsgBox("Error al editar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()
        '*************************
        BTNNUEVO.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        btnGUARDAR.Enabled = True
        txtIdEspeci.Enabled = False
        txtEspecialidad.Enabled = False
        txtBuscar.Enabled = False
        BTNNUEVO.Focus()
    End Sub

    Private Sub btnGUARDAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGUARDAR.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gIdEspecialidad = txtIdEspeci.Text
            dts.gNom_Especialidad = txtEspecialidad.Text

            If func.nuevoEspecialidad(dts) Then
                MsgBox("nueva especialidad insertada")
                
            Else
                MsgBox("error al insertar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()

        '******
        BTNNUEVO.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnGUARDAR.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        txtIdEspeci.Enabled = False
        txtEspecialidad.Enabled = False
        txtBuscar.Enabled = True
        txtEspecialidad.Text = ""
        txtIdEspeci.Text = ""
        BTNNUEVO.Focus()
        '*******
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

    Private Sub frmEspecialidad_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtBuscar.Focus()
    End Sub

    Private Sub txtIdEspeci_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdEspeci.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtEspecialidad.Focus()
        End If
    End Sub
    Private Sub txtEspecialidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEspecialidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGUARDAR.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificar.Focus()
        End If
    End Sub

    Private Sub txtEspecialidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEspecialidad.LostFocus
        If txtEspecialidad.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtEspecialidad.Focus()
        End If
    End Sub

    Private Sub txtEspecialidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEspecialidad.TextChanged
        Dim i As Integer
        txtEspecialidad.Text = UCase(txtEspecialidad.Text)
        i = Len(txtEspecialidad.Text)
        txtEspecialidad.SelectionStart = i
        txtEspecialidad.Focus()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnBuscar.Focus()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim i As Integer
        txtBuscar.Text = UCase(txtBuscar.Text)
        i = Len(txtBuscar.Text)
        txtBuscar.SelectionStart = i
        txtBuscar.Focus()
    End Sub

    Private Sub txtIdEspeci_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdEspeci.LostFocus
        If txtIdEspeci.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtIdEspeci.Focus()
        End If
    End Sub

    Private Sub txtIdEspeci_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdEspeci.TextChanged

    End Sub
End Class