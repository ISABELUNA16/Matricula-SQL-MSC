Public Class frmUsuarios
    Public dts As New datos
    Public func As New funciones

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '  Dim func As New funciones
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            lblusuario.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            'Dim func As New funciones
            Dim dt As DataTable = func.MostrarUsuario
            DataGrid1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub MOSTRARUSUARIO()
        Try
            ' Dim func As New funciones
            Dim dt As DataTable = func.MostrarUsuario
            DataGrid1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        '  Dim FUNC As New funciones
        Dim DT As DataTable = FUNC.GENERARIDUSUARIO
        If IsDBNull(DT.Rows(0)(0)) Then
            txtIdUsu.Text = "USU01"
        Else
            txtIdUsu.Text = DT.Rows(0)(0)
        End If
        txtNom.Text = ""
        txtApe.Text = ""
        txtSeudonimo.Text = ""
        txtClave.Text = ""
        txtNivel.Text = ""
        txtComentario.Text = ""

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        txtIdUsu.Clear()
        txtNom.Clear()
        txtApe.Clear()
        txtNivel.Clear()
        txtComentario.Clear()
        txtSeudonimo.Clear()
        txtClave.Clear()
        txtBuscar.Clear()
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            'Dim dts As New datos
            'Dim func As New funciones
            dts.gIdUsuario = txtIdUsu.Text

            If func.eliminarUsuario(dts) Then
                MsgBox("El Usuario se ah Eliminado")

            Else
                MsgBox("Error al eliminar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRARUSUARIO()

    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            'Dim dts As New datos
            'Dim func As New funciones
            dts.gIdUsuario = txtIdUsu.Text
            dts.gNom_Usuario = txtNom.Text
            dts.gApe_Usuario = txtApe.Text
            dts.gNivel = txtNivel.Text
            dts.gMensaje = txtComentario.Text
            dts.gSeudonimo = txtSeudonimo.Text
            dts.gClave = txtClave.Text

            If func.modificarEspecialidad(dts) Then
                MsgBox("El Usuario se ah Modificado")

            Else
                MsgBox("Error al editar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRARUSUARIO()
    End Sub

    Private Sub BtnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            dts.gIdUsuario = txtIdUsu.Text
            dts.gNom_Usuario = txtNom.Text
            dts.gApe_Usuario = txtApe.Text
            dts.gNivel = txtNivel.Text
            dts.gMensaje = txtComentario.Text
            dts.gSeudonimo = txtSeudonimo.Text
            dts.gClave = txtClave.Text

            If func.nuevoUsuario(dts) Then
                MsgBox("Nuevo Usuario Insertado")

            Else
                MsgBox("error al insertar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call MOSTRARUSUARIO()
    End Sub

    Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            'Dim func As New funciones
            Dim dt As DataTable = func.buscarUsuario(idUsuario:=txtBuscar.Text)

            txtIdUsu.Text = dt.Rows(0).Item(0)
            txtNom.Text = dt.Rows(0).Item(1)
            txtApe.Text = dt.Rows(0).Item(2)
            txtNivel.Text = dt.Rows(0).Item(3)
            txtComentario.Text = dt.Rows(0).Item(4)
            txtSeudonimo.Text = dt.Rows(0).Item(5)
            txtClave.Text = dt.Rows(0).Item(6)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalirT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalirT.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub txtIdUsu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdUsu.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNom.Focus()
        End If
    End Sub

    Private Sub txtIdUsu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdUsu.TextChanged
        Me.txtIdUsu.Text = UCase(Me.txtIdUsu.Text)
        Me.txtIdUsu.SelectionStart = Me.txtIdUsu.TextLength + 1
    End Sub

    Private Sub txtNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtApe.Focus()

        End If
    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        Me.txtNom.Text = UCase(Me.txtNom.Text)
        Me.txtNom.SelectionStart = Me.txtNom.TextLength + 1
    End Sub

    Private Sub txtApe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNivel.Focus()
        End If
    End Sub

    Private Sub txtApe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApe.TextChanged
        Me.txtApe.Text = UCase(Me.txtApe.Text)
        Me.txtApe.SelectionStart = Me.txtApe.TextLength + 1
    End Sub

    Private Sub txtNivel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNivel.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSeudonimo.Focus()

        End If
    End Sub

    Private Sub txtNivel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNivel.TextChanged
        Me.txtNivel.Text = UCase(Me.txtNivel.Text)
        Me.txtNivel.SelectionStart = Me.txtNivel.TextLength + 1
    End Sub

    Private Sub txtComentario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComentario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnGuardar.Focus()

        End If
        If Asc(e.KeyChar) = 13 Then
            btnModificar.Focus()
        End If
    End Sub

    Private Sub txtComentario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComentario.TextChanged
        Me.txtComentario.Text = UCase(Me.txtComentario.Text)
        Me.txtComentario.SelectionStart = Me.txtComentario.TextLength + 1
    End Sub

    Private Sub txtSeudonimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeudonimo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtClave.Focus()
        End If
    End Sub

    Private Sub txtSeudonimo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeudonimo.TextChanged
        Me.txtSeudonimo.Text = UCase(Me.txtSeudonimo.Text)
        Me.txtSeudonimo.SelectionStart = Me.txtSeudonimo.TextLength + 1
    End Sub

    Private Sub txtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtComentario.Focus()

        End If
    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged
        Me.txtClave.Text = UCase(Me.txtClave.Text)
        Me.txtClave.SelectionStart = Me.txtClave.TextLength + 1
    End Sub

    Private Sub frmUsuarios_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Me.txtBuscar.Focus()
    End Sub
End Class