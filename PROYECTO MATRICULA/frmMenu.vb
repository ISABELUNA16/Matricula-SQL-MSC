Imports System.Data.SqlClient
Public Class frmMenu
    Public cnn As New SqlConnection

    Private Sub CursosYCurriculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CursosYCurriculaToolStripMenuItem.Click
        frmTurno.Show()
    End Sub

    Private Sub MantenimientoDeDistritosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoDeDistritosToolStripMenuItem.Click
        frmDistrito.Show()
    End Sub

    Private Sub EspecialidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecialidadesToolStripMenuItem.Click
        frmCiclo.Show()
    End Sub

    Private Sub MantenimientoDeSemestreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoDeSemestreToolStripMenuItem.Click
        frmSemestre.Show()
    End Sub

    Private Sub MntenimientoDeCicloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MntenimientoDeCicloToolStripMenuItem.Click
        frmTipoIngreso.Show()
    End Sub

    Private Sub ModalidadDeIngresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModalidadDeIngresoToolStripMenuItem.Click
        frmEspecialidad.Show()
    End Sub

    Private Sub TiposDeMatrículaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeMatrículaToolStripMenuItem.Click
        frmModulo.Show()
    End Sub

    Private Sub TurnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnosToolStripMenuItem.Click
        frmUndDidac.Show()
    End Sub

    Private Sub CondiciónDeAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CondiciónDeAlumnoToolStripMenuItem.Click
        frmDocente.Show()
    End Sub

    Private Sub PersonalJerarquicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalJerarquicoToolStripMenuItem.Click
        frmTipoIngreso.Show()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarToolStripMenuItem.Click
        frmregistraralumno.Show()
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim func As New funciones
            Dim dt As DataTable = func.REGISTRARUSUARIO(SEUDONIMO:=frmAcceso.txtUsuario.Text, CLAVE:=frmAcceso.txtContraseña.Text)

            LBLUSUARIO.Text = dt.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FichaDeMatriculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichaDeMatriculaToolStripMenuItem.Click
        FrmMatricula.Show()
    End Sub

    Private Sub SALIRToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem1.Click
        frmAcceso.Close()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLFECHA.Text = Date.Today
        LBLHORA.Text = TimeOfDay
    End Sub

    Private Sub RegistrosDeEvaluaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmNotas.Show()
    End Sub

    Private Sub MatriculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatriculaToolStripMenuItem.Click
        Me.Hide()
        FrmMatricula.Show()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub SqlConnection(ByVal p1 As Object)
        Throw New NotImplementedException
    End Sub

    Private Sub DistritoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistritoToolStripMenuItem.Click

        cnn = New SqlConnection("Data Source=PC-100-PC;Initial Catalog=MATRICULA;Integrated Security=True")

        cnn.Open()
        Dim oDataAdaptDistrito As SqlDataAdapter
        oDataAdaptDistrito = New SqlDataAdapter("select * from distrito", cnn)

        Dim oDataSetDistrito As New MATRICULADataSet
        oDataSetDistrito.Clear()
        cnn.Close()
        Try
            Dim informe2 As New CryRepDistrito
            oDataAdaptDistrito.Fill(oDataSetDistrito, "Distrito")
            informe2.SetDataSource(oDataSetDistrito)

            Dim report2 As New FrmReporte
            report2.CrystalReportViewer1.ReportSource = informe2
            report2.Text = "Distrito"
            report2.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub EspecialidadesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecialidadesToolStripMenuItem1.Click

        cnn = New SqlConnection("Data Source=PC-100-PC;Initial Catalog=MATRICULA;Integrated Security=True")

        cnn.Open()
        Dim oDataAdaptEspecialidad As SqlDataAdapter
        oDataAdaptEspecialidad = New SqlDataAdapter("select * from Especialidad", cnn)

        Dim oDataSetEspecialidad As New MATRICULADataSet
        oDataSetEspecialidad.Clear()
        cnn.Close()
        Try
            Dim informe3 As New CryRepEspecialidad
            oDataAdaptEspecialidad.Fill(oDataSetEspecialidad, "Especialidad")
            informe3.SetDataSource(oDataSetEspecialidad)

            Dim report3 As New FrmReporte
            report3.CrystalReportViewer1.ReportSource = informe3
            report3.Text = "Especialidad"
            report3.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub NominaDeAlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NominaDeAlumnosToolStripMenuItem.Click
        FormRepAlumno.Show()
    End Sub
End Class