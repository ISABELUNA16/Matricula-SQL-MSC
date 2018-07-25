Public Class frmCiclo
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.buscarCiclo(idciclo:=txtBuscar.Text)

            txtIdCiclo.Text = dt.Rows(0).Item(0)
            txtCiclo.Text = dt.Rows(0).Item(1)
            txtNumCiclo.Text = dt.Rows(0).Item(2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtIdCiclo.Enabled = True
        txtCiclo.Enabled = True
        txtNumCiclo.Enabled = True

        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btnBuscar.Enabled = True
        txtBuscar.Text = ""
        txtCiclo.Focus()
    End Sub
    Sub mostrar()
        Dim func As New funciones
        Dim dt As DataTable = func.mostrarCiclo
        DataGrid.DataSource = dt
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidciclo = txtIdCiclo.Text
            dts.gnom_ciclo = txtCiclo.Text
            dts.gnumero = txtNumCiclo.Text

            If func.modificarCiclo(dts) Then
                MsgBox("La especialidad se a modificado")
               
            Else
                MsgBox("Error al modificar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()

        '****
        btnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        btnguardar.Enabled = True
        txtIdCiclo.Enabled = False
        txtCiclo.Enabled = False
        txtNumCiclo.Enabled = False
        txtBuscar.Enabled = False
        txtIdCiclo.Text = ""
        txtCiclo.Text = ""
        txtNumCiclo.Text = ""
        btnNuevo.Focus()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidciclo = txtIdCiclo.Text

            If func.eliminarCiclo(dts) Then
                MsgBox("El ciclo se a eliminado")
                
            Else
                MsgBox("Error al eliminar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()

        '**
        txtIdCiclo.Enabled = False
        txtCiclo.Enabled = False
        txtNumCiclo.Enabled = False
        btnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnguardar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        txtBuscar.Text = ""
        txtIdCiclo.Text = ""
        txtCiclo.Text = ""
        txtNumCiclo.Text = ""
        txtBuscar.Enabled = True
        btnNuevo.Focus()

    End Sub

    Private Sub txtIdCiclo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtCiclo.Focus()
        End If
    End Sub

    Private Sub txtCiclo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtNumCiclo.Focus()
        End If
    End Sub

    Private Sub txtNumCiclo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            btnNuevo.Focus()
        End If
    End Sub

    Private Sub frmCiclo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Dim dt As DataTable = func.mostrarCiclo
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        txtIdCiclo.Clear()
        txtCiclo.Clear()
        txtNumCiclo.Clear()
        txtBuscar.Clear()
        txtIdCiclo.Enabled = False
        txtCiclo.Enabled = False
        txtNumCiclo.Enabled = False
        btnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnguardar.Enabled = False
        btnModificar.Enabled = False

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gidciclo = txtIdCiclo.Text
            dts.gnom_ciclo = txtCiclo.Text
            dts.gnumero = txtNumCiclo.Text

            If func.nuevoCiclo(dts) Then
                MsgBox("nueva ciclo insertado")
                
            Else
                MsgBox("error al insertar")
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call mostrar()
        btnNuevo.Enabled = True
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btnguardar.Enabled = False
        btnModificar.Enabled = False
        btnsalir.Enabled = True
        txtIdCiclo.Enabled = False
        txtCiclo.Enabled = False
        txtNumCiclo.Enabled = False
        txtBuscar.Enabled = True
        txtCiclo.Text = ""
        txtIdCiclo.Text = ""
        txtNumCiclo.Text = ""
        btnNuevo.Focus()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        'Me.Close()
        Try
            If MsgBox("ESTAS SEGURO DE SALIR", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMenu.Show()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        btnguardar.Enabled = True
        btncancelar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False
        txtIdCiclo.Enabled = True
        txtCiclo.Enabled = True
        txtNumCiclo.Enabled = True
        txtIdCiclo.Text = ""
        txtCiclo.Text = ""
        txtNumCiclo.Text = ""
        txtIdCiclo.Focus()
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

    Private Sub frmCiclo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtBuscar.Focus()
    End Sub

    Private Sub txtCiclo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCiclo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNumCiclo.Focus()
        End If
    End Sub

    Private Sub txtCiclo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCiclo.LostFocus
        If txtCiclo.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtCiclo.Focus()
        End If
    End Sub

    Private Sub txtCiclo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCiclo.TextChanged
        Me.txtCiclo.Text = UCase(Me.txtCiclo.Text)
        Me.txtCiclo.SelectionStart = Me.txtCiclo.TextLength + 1
    End Sub

    Private Sub txtNumCiclo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumCiclo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnguardar.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificar.Focus()
        End If
    End Sub

    Private Sub txtNumCiclo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumCiclo.LostFocus
        If txtNumCiclo.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtNumCiclo.Focus()
        End If
    End Sub
    Private Sub txtNumCiclo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumCiclo.TextChanged
        Me.txtNumCiclo.Text = UCase(Me.txtNumCiclo.Text)
        Me.txtNumCiclo.SelectionStart = Me.txtNumCiclo.TextLength + 1
    End Sub

    Private Sub txtIdCiclo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCiclo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCiclo.Focus()
        End If
    End Sub

    Private Sub txtIdCiclo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCiclo.LostFocus
        If txtIdCiclo.Text = "" Then
            MsgBox("INGRESAR CONTENIDO")
            txtIdCiclo.Focus()
        End If
    End Sub

    Private Sub txtIdCiclo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdCiclo.TextChanged
        Me.txtIdCiclo.Text = UCase(Me.txtIdCiclo.Text)
        Me.txtIdCiclo.SelectionStart = Me.txtIdCiclo.TextLength + 1
       
    End Sub
End Class