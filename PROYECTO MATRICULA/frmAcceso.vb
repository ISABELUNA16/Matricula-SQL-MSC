Public Class frmAcceso
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Try
            Dim dts As New datos
            Dim func As New funciones
            dts.gseudonimo = txtUsuario.Text
            dts.gClave = txtContraseña.Text
            If func.validar(dts) = True Then
                frmMenu.Show()
                Me.Hide()

            Else
                'informacion para visualizar si existe algun error 
                MsgBox("Contraseña Fallida")
                txtContraseña.Clear()
                txtContraseña.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Close()

    End Sub

    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAceptar.Focus()

        End If
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtContraseña.Focus()
        End If
    End Sub

    Private Sub frmAcceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
