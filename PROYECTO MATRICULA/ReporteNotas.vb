Imports System.Data.SqlClient
Public Class ReporteNotas
    Dim dialog As New OpenFileDialog
    Dim dts As New datos
    Dim func As New funciones
    Dim ruta As String
    Private Sub BtnBuscarAlumno(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerNotaAlumno.Click
       
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.VerNotaAlumno

            DataGridView1.DataSource = dt
            lblEspecialidad.Text = dt.Rows(0).Item(0)
            lblTurno.Text = dt.Rows(0).Item(1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class