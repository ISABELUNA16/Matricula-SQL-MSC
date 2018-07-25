Imports System.Data.SqlClient
Public Class FormRepAlumno
    Public cnn As New SqlConnection
    Dim func As New funciones
    Dim dts As datos
    Public oDataSetAlumno As DataSet
    Public oDataAdaptAlumno As SqlDataAdapter
    Private Sub FormRepAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CboSemestre.Focus()

        With CboCiclo

            .DataSource = func.mostrarCiclo

            .DisplayMember = "Numero"

            .ValueMember = "Idciclo"

        End With

        With CboTurno

            .DataSource = func.mostrarTurno

            .DisplayMember = "Nom_turno"

            .ValueMember = "Idturno"

        End With

        With CboEspecialidad

            .DataSource = func.mostrarEspecialidad

            .DisplayMember = "nom_especialidad"

            .ValueMember = "Idespecialidad"

        End With

        With CboSemestre

            .DataSource = func.mostrarSemestre

            .DisplayMember = "Idsemestre"

            .ValueMember = "Idsemestre"

        End With
        CboSemestre.Text = ""
        CboCiclo.Text = ""
        CboEspecialidad.Text = ""
        CboTurno.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cnn = New SqlConnection("Data Source=HENRY-PC;Initial Catalog=Matricula;User ID=henry;Password=12345")
        'cnn = New SqlConnection("Data Source=PC-100-PC\SQLEXPRESS;Initial Catalog=Matricula;Integrated Security=True")
        cnn = New SqlConnection("Data Source=PC-100-PC;Initial Catalog=MATRICULA;Integrated Security=True")
        cnn.Open()
        oDataAdaptAlumno = New SqlDataAdapter("verListAlumnos", cnn)
        Dim oDataSetAlumno As New MATRICULADataSet
        cnn.Close()

        Try

            Dim informe As New CryRepAlumnos
            oDataAdaptAlumno.Fill(oDataSetAlumno, "verListAlumnos")
            informe.SetDataSource(oDataSetAlumno)

            Dim rept As New FrmReporte
            rept.CrystalReportViewer1.ReportSource = informe

            Dim frmReporte As New Form()
            With frmReporte
                .Controls.Add(rept.CrystalReportViewer1)
                .Text = "ALUMNO"
                .WindowState = FormWindowState.Maximized
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try

        'cnn = New SqlConnection("Data Source=ROCIO-PC;Initial Catalog=MATRICULA;Integrated Security=True")
        ''cnn = New SqlConnection("Data Source=PC-100-PC\SQLEXPRESS;Initial Catalog=Matriculita;Integrated Security=True")
        ''cnn = New SqlConnection("Data Source=KELLY-PC\SQLEXPRESS;Initial Catalog=Matricula;Integrated Security=True")
        'cnn.Open()
        'Dim oDataAdaptAlumno As SqlDataAdapter
        'oDataAdaptAlumno = New SqlDataAdapter("verListAlumnos", cnn)

        'Dim sSQL As String
        'sSQL = "verListAlumnos"

        'Dim oDataSetAlumno As New MATRICULADataSet
        'Dim oComando As New SqlCommand(sSQL, cnn)
        'oComando.Parameters("@nom_especialidad").Value.ToString()
        ''oDataAdaptAlumno.SelectCommand.Parameters("@nom_turno").Value = Me.CboTurno.SelectedValue.ToString
        ''oDataAdaptAlumno.SelectCommand.Parameters("@IdSemestre").Value = Me.CboSemestre.SelectedValue.ToString
        ''oDataAdaptAlumno.SelectCommand.Parameters("@numero").Value = Me.CboCiclo.SelectedValue.ToString
        'oDataAdaptAlumno.SelectCommand = oComando

        'oDataAdaptAlumno.Fill(oDataSetAlumno)

        ''Dim iResultado As Integer
        'cnn.Open() ' abrir conexión
        ''iResultado =
        'oComando.ExecuteNonQuery() ' ejecutar comando

        'oDataSetAlumno.Clear()
        'cnn.Close()
        'Try
        '    Dim informe As New CryRepAlumnos
        '    oDataAdaptAlumno.Fill(oDataSetAlumno, "Alumno")
        '    informe.SetDataSource(oDataSetAlumno)

        '    Dim report As New FrmReporte
        '    report.CrystalReportViewer1.ReportSource = informe
        '    report.Text = "Reporte de Alumno"
        '    report.ShowDialog()

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    cnn.Close()
        'End Try


        'Try
        '    cnn = New SqlConnection("Data Source=PC-100-PC\SQLEXPRESS;Initial Catalog=Matriculita;Integrated Security=True")
        '    cnn.Open()
        '    'cnn.Open()
        '    Dim dataAdaptEspecialidad As New SqlDataAdapter
        '    Dim datasetalumno As New MATRICULADataSet
        '    Dim sSQL As String
        '    sSQL = "verListAlumnos"

        '    dataAdaptEspecialidad.SelectCommand.Parameters("@nom_especialidad").Value = Me.CboEspecialidad.SelectedValue
        '    dataAdaptEspecialidad.SelectCommand.Parameters("@nom_turno").Value = Me.CboTurno.SelectedValue
        '    dataAdaptEspecialidad.SelectCommand.Parameters("@IdSemestre").Value = Me.CboSemestre.SelectedValue
        '    dataAdaptEspecialidad.SelectCommand.Parameters("@numero").Value = Me.CboCiclo.SelectedValue
        '    'dataAdaptEspecialidad.Fill(datasetalumno, "vespecialidadxalumno")

        '    Dim oComando As New SqlCommand(sSQL, cnn)
        '    'Dim iResultado As Integer
        '    cnn.Open() ' abrir conexión
        '    'iResultado =
        '    oComando.ExecuteNonQuery() ' ejecutar comando
        '    cnn.Close() ' cerrar conexión

        '    Dim report As New CryRepAlumnos
        '    report.SetDataSource(datasetalumno)

        '    Dim frmrep As New FrmReporte
        '    frmrep.CrystalReportViewer1.ReportSource = report
        '    frmrep.Text = "verListAlumnos"
        '    frmrep.ShowDialog()

        '    ' frmrep.CrystalReportViewer1.Dock = DockStyle.Fill
        '    ' frmrep.WindowState = FormWindowState.Maximized
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    cnn.Close()
        'End Try
        'cnn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
         Try
            Dim func As New funciones
            'Dim dt As DataTable = func.VERLISTALUMNOS(NOM_ESPECIALIDAD:=Convert.ToString(CboEspecialidad.SelectedItem),
            '    NOM_TURNO:=Convert.ToString(CboTurno.SelectedItem), IDSEMESTRE:=Convert.ToString(CboSemestre.SelectedItem),
            '    NUMERO:=Convert.ToString(CboCiclo.SelectedItem))
            Dim dt As DataTable = func.VERLISTALUMNOS(NOM_ESPECIALIDAD:=CboEspecialidad.Text,
                NOM_TURNO:=CboTurno.Text, IDSEMESTRE:=CboSemestre.Text,
                NUMERO:=CboCiclo.Text)

            DGListaAlumnos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub CboEspecialidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboEspecialidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CboSemestre.Focus()
        End If
    End Sub

    Private Sub CboEspecialidad_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboEspecialidad.MouseEnter
        CboEspecialidad.DroppedDown = True
    End Sub

    Private Sub CboSemestre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboSemestre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CboCiclo.Focus()
        End If
    End Sub

    Private Sub CboCiclo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboCiclo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CboTurno.Focus()
        End If
    End Sub

    Private Sub CboSemestre_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboSemestre.MouseEnter
        CboSemestre.DroppedDown = True
    End Sub

    Private Sub CboCiclo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCiclo.MouseEnter
        CboCiclo.DroppedDown = True
    End Sub

    Private Sub CboTurno_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboTurno.MouseEnter
        CboTurno.DroppedDown = True
    End Sub

End Class