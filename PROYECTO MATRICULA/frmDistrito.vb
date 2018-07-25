Public Class frmDistrito

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarDistrito(iddistrito:=txtBuscar.Text)

            txtIdDistrito.Text = dt.Rows(0).Item(0)
            txtDistrito.Text = dt.Rows(0).Item(1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtIdDistrito.Enabled = True
        txtDistrito.Enabled = True
        '********
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGuardar.Enabled = False
        btncancelar.Enabled = False
        btnBuscar.Enabled = True
        txtBuscar.Text = ""
        txtDistrito.Focus()
    End Sub
    Sub mostrar()
        Dim funcs As New funciones
        Dim dtse As DataTable = funcs.mostrardistrito
        DataGrid1.DataSource = dtse
    End Sub

    Private Sub txtIdDistrito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdDistrito.KeyPress
        If Asc(e.KeyChar) = 13 Or 9 Then
            txtDistrito.Focus()
        End If
    End Sub

    Private Sub txtIdDistrito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdDistrito.TextChanged
        txtIdDistrito.MaxLength = 3
    End Sub

    Private Sub frmDistrito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnNuevo.Focus()
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            Lblusuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.mostrardistrito
            DataGrid1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim FUNC As New funciones
        Dim DT As DataTable = FUNC.GENERARIDDISTRITO
        If IsDBNull(DT.Rows(0)(0)) Then
            txtIdDistrito.Text = "D01"
        Else
            txtIdDistrito.Text = DT.Rows(0)(0)
        End If

        btnGuardar.Enabled = True
        btncancelar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False
        txtIdDistrito.Enabled = True
        txtDistrito.Enabled = True
        txtDistrito.Text = ""
        txtDistrito.Focus()

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        txtIdDistrito.Clear()
        txtDistrito.Clear()
        txtBuscar.Clear()
        '*******
        txtIdDistrito.Enabled = False
        txtDistrito.Enabled = False
        btnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False

        
  
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.giddistrito = txtIdDistrito.Text

            If func.eliminarDistrito(dts) Then
                MsgBox("El Distrito se a eliminado")
                
            Else
                MsgBox("Error al eliminar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()
        '***********
        txtIdDistrito.Enabled = False
        txtDistrito.Enabled = False
        btnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        txtBuscar.Text = ""
        txtIdDistrito.Text = ""
        txtDistrito.Text = ""
     
        txtBuscar.Enabled = True
        btnNuevo.Focus()
    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.giddistrito = txtIdDistrito.Text
            dts.gNom_distrito = txtDistrito.Text

            If func.modificarDistrito(dts) Then
                MsgBox("El Distrito se a modificado")
                
            Else
                MsgBox("Error al editar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()
        '*************************
        btnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        btnGuardar.Enabled = True
        txtBuscar.Enabled = False
        btnNuevo.Focus()
       
    End Sub

    Private Sub btnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.giddistrito = txtIdDistrito.Text
            dts.gNom_distrito = txtDistrito.Text

            If func.nuevoDistrito(dts) Then
                MsgBox("Nuevo Distrito insertado")
                
            Else
                MsgBox("error al insertar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()

        '******
        btnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        txtIdDistrito.Enabled = False
        txtDistrito.Enabled = False
        txtBuscar.Enabled = True
        txtDistrito.Text = ""
        txtIdDistrito.Text = ""
        btnNuevo.Focus()

    End Sub

    Private Sub btnVer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim func As New funciones
        '    Dim dt As DataTable = func.mostrardistrito
        '    DataGrid1.DataSource = dt
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
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

    Private Sub frmDistrito_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtBuscar.Focus()
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

    Private Sub txtDistrito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDistrito.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificar.Focus()
        ElseIf Asc(e.KeyChar) = 13 Then
            btnEliminar.Focus()
        End If

    End Sub

    Private Sub txtDistrito_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDistrito.LostFocus
        If txtDistrito.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtDistrito.Focus()
        End If
    End Sub

    Private Sub txtDistrito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDistrito.TextChanged
        Me.txtDistrito.Text = UCase(Me.txtDistrito.Text)
        Me.txtDistrito.SelectionStart = Me.txtDistrito.TextLength + 1
    End Sub
End Class
