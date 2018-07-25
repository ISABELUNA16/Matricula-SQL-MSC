Imports System.Data.SqlClient
Imports System.IO
Public Class funciones
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrarEspecialidad() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarEspecialidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function nuevoEspecialidad(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("NuevoEspecialidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdEspecialidad", dts.gIdEspecialidad)
            cmd.Parameters.AddWithValue("@Nom_Especialidad", dts.gNom_Especialidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarEspecialidad(ByVal idespecialidad As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("BuscarEspecialidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdEspecialidad", idespecialidad)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarEspecialidad(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ModificarEspecilidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdEspecialidad", dts.gIdEspecialidad)
            cmd.Parameters.AddWithValue("@Nom_Especialidad", dts.gNom_Especialidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarEspecialidad(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EliminarEspecialidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdEspecialidad", SqlDbType.Char).Value = dts.gIdEspecialidad

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    'FUNCIONES PARA FORMULARIO CICLO

    Public Function mostrarCiclo() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarCiclo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function nuevoCiclo(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("nuevoCiclo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idCiclo", dts.gidciclo)
            cmd.Parameters.AddWithValue("@nom_ciclo", dts.gnom_ciclo)
            cmd.Parameters.AddWithValue("@numero", dts.gnumero)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarCiclo(ByVal idciclo As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarCiclo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idciclo", idciclo)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarCiclo(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarCiclo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idciclo", dts.gidciclo)
            cmd.Parameters.AddWithValue("@nom_ciclo", dts.gnom_ciclo)
            cmd.Parameters.AddWithValue("@numero", dts.gnumero)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarCiclo(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarCiclo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idciclo", SqlDbType.Char).Value = dts.gidciclo

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    'FUNCIONES PARA FORMULARIO MODULO PROFESIONAL

    Public Function mostrarModuloP() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarModuloP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GuardarModuloP(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("GuardarModuloP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idespecialidad", dts.gidespeci)
            cmd.Parameters.AddWithValue("@idmoduloP", dts.gidmoduloP)
            cmd.Parameters.AddWithValue("@nom_modulo", dts.gNom_modulo)
            cmd.Parameters.AddWithValue("@año_modulo", dts.gaño_MODULO)
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gIdUsuario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarModuloP(ByVal idmoduloP As String, ByVal idEspecialidad As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarModuloP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idModuloP", idmoduloP)
            cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarModuloP(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ModificarModuloP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdEspecialidad", dts.gidespeci)
            cmd.Parameters.AddWithValue("@idmoduloP", dts.gidmoduloP)
            cmd.Parameters.AddWithValue("@nom_modulo", dts.gNom_modulo)
            cmd.Parameters.AddWithValue("@año_modulo", dts.gaño_MODULO)
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gIdUsuario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarmoduloP(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarmoduloP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idmoduloP", SqlDbType.Char).Value = dts.gidmoduloP

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    'FUNCIONES PARA FORMULARIO MODULO TRANSVERSAL
    Public Function mostrarModuloT() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarModuloT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GuardarModuloT(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("GuardarModuloT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idespecialidad", dts.gidespeci)
            cmd.Parameters.AddWithValue("@idmoduloT", dts.gidmoduloT)
            cmd.Parameters.AddWithValue("@nom_modulo", dts.gNom_modulo)
            cmd.Parameters.AddWithValue("@año_modulo", dts.gaño_MODULO)
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gIdUsuario)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarModuloT(ByVal idmoduloT As String, ByVal idEspecialidad As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarModuloT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idModuloT", idmoduloT)
            cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarModuloT(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarModuloT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idespecialidad", dts.gidespeci)
            cmd.Parameters.AddWithValue("@idmoduloT", dts.gidmoduloT)
            cmd.Parameters.AddWithValue("@nom_modulo", dts.gNom_modulo)
            cmd.Parameters.AddWithValue("@año_modulo", dts.gaño_MODULO)
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gIdUsuario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarmoduloT(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarmoduloT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idmoduloT", SqlDbType.Char).Value = dts.gidmoduloT

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    'FUNCION PARA VALIDAR CONTRASEÑA
    Public Function validar(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("validar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@seudonimo", dts.gseudonimo)
            cmd.Parameters.AddWithValue("@clave", dts.gClave)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    

    'FUNCIONES PARA FORMULARIO TURNO

    Public Function mostrarTurno() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarTurno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function nuevoTurno(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("NuevoTurno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idturno", dts.gidturno)
            cmd.Parameters.AddWithValue("@nom_turno", dts.gNom_turno)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarTurno(ByVal idturno As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("BuscarTurno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idturno", idturno)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarTurno(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarturno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idturno", dts.gidturno)
            cmd.Parameters.AddWithValue("@nom_turno", dts.gNom_turno)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarTurno(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarturno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idturno", SqlDbType.Char).Value = dts.gidturno

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    'FUNCIONES PARA FORMULARIO DISTRITO

    Public Function mostrardistrito() As DataTable
        Try
            Dim dt As New DataTable
            conectado()
            Dim cmd As New SqlCommand


            cmd = New SqlCommand("mostrardistrito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then

                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function nuevoDistrito(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("nuevodistrito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@iddistrito", dts.giddistrito)
            cmd.Parameters.AddWithValue("@nom_distrito", dts.gNom_distrito)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarDistrito(ByVal iddistrito As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscardistrito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@iddistrito", iddistrito)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarDistrito(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificardistrito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@iddistrito", dts.giddistrito)
            cmd.Parameters.AddWithValue("@nom_distrito", dts.gNom_distrito)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarDistrito(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminardistrito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@iddistrito", SqlDbType.Char).Value = dts.giddistrito

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function


    'FUNCIONES PARA FORMULARIO SEMESTRE

    Public Function mostrarSemestre() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarSemestre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function nuevoSemestre(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("nuevoSemestre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idSemestre", dts.gidsemestre)
            cmd.Parameters.AddWithValue("@fecha_inicio", dts.gfecha_inicio)
            cmd.Parameters.AddWithValue("@fecha_fin", dts.gfecha_fin)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarSemestre(ByVal idSemestre As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarSemestre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idSemestre", idSemestre)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarSemestre(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarSemestre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idSemestre", dts.gidsemestre)
            cmd.Parameters.AddWithValue("@fecha_inicio", dts.gfecha_inicio)
            cmd.Parameters.AddWithValue("@fecha_fin", dts.gfecha_fin)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarSemestre(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarSemestre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idSemestre", SqlDbType.Char).Value = dts.gidsemestre

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    'FUNCIONES PARA FORMULARIO DOCENTE

    Public Function MostrarDocente() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarDocente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function NuevoDocente(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("NuevoDocente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idDocente", dts.gidDocente)
            cmd.Parameters.AddWithValue("@nom_docente", dts.gnom_docente)
            cmd.Parameters.AddWithValue("@Ape_Docente", dts.gape_docente)
            cmd.Parameters.AddWithValue("@Dir_Docente", dts.gDir_docente)
            cmd.Parameters.AddWithValue("@Dni_Docente", dts.gDni_docente)
            cmd.Parameters.AddWithValue("@Email_Docente", dts.gEmail_docente)
            cmd.Parameters.AddWithValue("@Tel_Docente", dts.gTel_docente)
            cmd.Parameters.AddWithValue("@Fec_nac_Docente", dts.gFec_nac_docente)
            cmd.Parameters.AddWithValue("@Sex_Docente", dts.gSex_docente)

            cmd.Parameters.AddWithValue("@grado", dts.ggrado)
            cmd.Parameters.AddWithValue("@titulo", dts.gtitulo)
            cmd.Parameters.AddWithValue("@maestria", dts.gmaestria)
            cmd.Parameters.AddWithValue("@doctorado", dts.gdoctorado)
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gIdUsuario)
            cmd.Parameters.AddWithValue("@foto", dts.gruta)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarDocente(ByVal idDocente As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("BuscarDocente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdDocente", idDocente)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarDocente(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarDocente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdDocente", SqlDbType.Char).Value = dts.gidDocente

            '  cmd.Parameters.AddWithValue("@IdDocente", dts.gidDocente)
            cmd.Parameters.AddWithValue("@Nom_Docente", SqlDbType.VarChar).Value = dts.gnom_docente
            cmd.Parameters.AddWithValue("@Ape_Docente", dts.gape_docente)
            cmd.Parameters.AddWithValue("@Dir_Docente", dts.gDir_docente)
            cmd.Parameters.AddWithValue("@Dni_Docente", dts.gDni_docente)
            cmd.Parameters.AddWithValue("@Email_Docente", dts.gEmail_docente)
            cmd.Parameters.AddWithValue("@Tel_Docente", dts.gTel_docente)
            cmd.Parameters.AddWithValue("@Fec_nac_Docente", dts.gFec_nac_docente)
            cmd.Parameters.AddWithValue("@Sex_Docente", dts.gSex_docente)

            cmd.Parameters.AddWithValue("@Grado", dts.ggrado)
            cmd.Parameters.AddWithValue("@Titulo", dts.gtitulo)
            cmd.Parameters.AddWithValue("@Maestria", dts.gmaestria)
            cmd.Parameters.AddWithValue("@Doctorado", dts.gdoctorado)
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gIdUsuario)
            cmd.Parameters.AddWithValue("@foto", dts.gruta)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
    Public Function eliminarDocente(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EliminarDocente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdDocente", SqlDbType.Char).Value = dts.gidDocente

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    'FUNCIONES PARA EL FORM USUARIOS

    Public Function MostrarUsuario() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function nuevoUsuario(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("nuevoUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idUsuario", dts.gIdUsuario)
            cmd.Parameters.AddWithValue("@nom_Usuario", dts.gNom_Usuario)
            cmd.Parameters.AddWithValue("@Ape_Usuario", dts.gApe_Usuario)
            cmd.Parameters.AddWithValue("@Nivel", dts.gNivel)
            cmd.Parameters.AddWithValue("@Mensaje", dts.gMensaje)
            cmd.Parameters.AddWithValue("@Seudonimo", dts.gSeudonimo)
            cmd.Parameters.AddWithValue("@Clave", dts.gClave)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarUsuario(ByVal idUsuario As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarUsuario(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idUsuario", dts.gIdUsuario)
            cmd.Parameters.AddWithValue("@nom_Usuario", dts.gNom_Usuario)
            cmd.Parameters.AddWithValue("@Ape_Usuario", dts.gApe_Usuario)
            cmd.Parameters.AddWithValue("@Nivel", dts.gNivel)
            cmd.Parameters.AddWithValue("@Mensaje", dts.gMensaje)
            cmd.Parameters.AddWithValue("@Seudonimo", dts.gSeudonimo)
            cmd.Parameters.AddWithValue("@Clave", dts.gClave)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarUsuario(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idUsuario", SqlDbType.Char).Value = dts.gIdUsuario

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
    'FUNCIONES PARA EL FORMULARIO TIPO DE INGRESO

    Public Function mostrarTipo() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarTipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function nuevoTipo(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("nuevoTipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idTipo", dts.gIdTipo)
            cmd.Parameters.AddWithValue("@Descripcion", dts.gDescripcion)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarTipo(ByVal idTipo As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarTipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idTipo", idTipo)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarTipo(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarTipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idTipo", dts.gIdTipo)
            cmd.Parameters.AddWithValue("@Descripcion", dts.gDescripcion)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarTipo(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarTipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idTipo", SqlDbType.Char).Value = dts.gIdTipo

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function


    'FUNCIONES PARA EL FORM UND. DIDACTICA PROFESIONAL

    Public Function MostrarUDP() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarUDP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GuardarUDP(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("GuardarUDP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUndDidacP", dts.gIdUndDidacP)
            cmd.Parameters.AddWithValue("@Nom_UndDidactica", dts.gNom_UndDidac)
            cmd.Parameters.AddWithValue("@horas", dts.gHoras)
            cmd.Parameters.AddWithValue("@credito", dts.gCredito)
            cmd.Parameters.AddWithValue("@IdModuloP", dts.gidmoduloP)
            cmd.Parameters.AddWithValue("@IdCiclo", dts.gIdCicloU)
            'cmd.Parameters.AddWithValue("@Idespecialidad", dts.gIdEspecialidad)
            'cmd.Parameters.AddWithValue("@Idaño", dts.gaño_MODULO)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarUDP(ByVal idUndDidacP As String, ByVal idespecialidad As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarUDP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUndDidacP", idUndDidacP)
            cmd.Parameters.AddWithValue("@IdEspecialidad", idespecialidad)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarUDP(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarUDP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUndDidacP", dts.gIdUndDidacP)
            cmd.Parameters.AddWithValue("@Nom_UndDidactica", dts.gNom_UndDidac)
            cmd.Parameters.AddWithValue("@horas", dts.gHoras)
            cmd.Parameters.AddWithValue("@credito", dts.gCredito)
            cmd.Parameters.AddWithValue("@IdModuloP", dts.gidmoduloP)
            cmd.Parameters.AddWithValue("@IdCiclo", dts.gIdCicloU)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarUDP(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarUDP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUndDidacP", SqlDbType.Char).Value = dts.gIdUndDidacP

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
    'FUNCIONES PARA U.D. TRANSVERSAL
    Public Function MostrarUDT() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarUDT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GuardarUDT(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("GuardarUDT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUndDidacT", dts.gIdUndDidacT)
            cmd.Parameters.AddWithValue("@Nom_UndDidactica", dts.gNom_UndDidac)
            cmd.Parameters.AddWithValue("@horas", dts.gHoras)
            cmd.Parameters.AddWithValue("@credito", dts.gCredito)
            cmd.Parameters.AddWithValue("@IdModuloT", dts.gidmoduloT)
            cmd.Parameters.AddWithValue("@IdCiclo", dts.gIdCicloU)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarUDT(ByVal idUndDidacT As String, ByVal idespecialidad As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarUDT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUndDidacT", idUndDidacT)
            cmd.Parameters.AddWithValue("@IdEspecialidad", idespecialidad)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarUDT(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarUDT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUndDidacT", dts.gIdUndDidacT)
            cmd.Parameters.AddWithValue("@Nom_UndDidactica", dts.gNom_UndDidac)
            cmd.Parameters.AddWithValue("@horas", dts.gHoras)
            cmd.Parameters.AddWithValue("@credito", dts.gCredito)
            cmd.Parameters.AddWithValue("@IdModuloT", dts.gidmoduloT)
            cmd.Parameters.AddWithValue("@IdCiclo", dts.gIdCicloU)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminarUDT(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarUDT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUndDidacT", SqlDbType.Char).Value = dts.gIdUndDidacT

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
    'ALUMNO
    Public Function insertaralumno(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertaralumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idalumno", dts.gIdAlumno)
            cmd.Parameters.AddWithValue("@IdDistrito", dts.giddistrito)
            cmd.Parameters.AddWithValue("@IDTIPO", dts.gIdTipo)
            cmd.Parameters.AddWithValue("@IDESPECIALIDAD", dts.gIdEspecialidad)
            cmd.Parameters.AddWithValue("@Ape_paterno", dts.gApe_paterno)
            cmd.Parameters.AddWithValue("@Ape_materno", dts.gApe_materno)
            cmd.Parameters.AddWithValue("@Nom_alumno", dts.gNom_Alumno)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfec_nac_alum)
            cmd.Parameters.AddWithValue("@Distrito_nac", dts.gdis_nac_alum)
            cmd.Parameters.AddWithValue("@Provincia_nac", dts.gprov_nac_alum)
            cmd.Parameters.AddWithValue("@Departamento_nac", dts.gdep_nac_alum)
            cmd.Parameters.AddWithValue("@edad", dts.gedad_alum)
            cmd.Parameters.AddWithValue("@sexo_alumno", dts.gsex_alum)
            cmd.Parameters.AddWithValue("@estado_civil", dts.gest_civil_alum)
            cmd.Parameters.AddWithValue("@dirección", dts.gdom_alum)
            cmd.Parameters.AddWithValue("@telef_alumno", dts.gtel_alum)
            cmd.Parameters.AddWithValue("@Nombre_ie", dts.gnomie_alum)
            cmd.Parameters.AddWithValue("@añoegreso_ie", dts.gañoeg_ie_alum)
            cmd.Parameters.AddWithValue("@NOM_ESPECIALIDAD", dts.gNom_Especialidad)
            cmd.Parameters.AddWithValue("@trabaja", dts.gtrabaja_alum)
            cmd.Parameters.AddWithValue("@centrotrabajo", dts.gcen_trab_alum)
            cmd.Parameters.AddWithValue("@func_trabajo", dts.gfunc_trab_alum)
            cmd.Parameters.AddWithValue("@NOM_turno", dts.gNom_turno)
            cmd.Parameters.AddWithValue("@e_mail", dts.gmail_alum)
            cmd.Parameters.AddWithValue("@estudia", dts.gestudia_alum)
            cmd.Parameters.AddWithValue("@estudia_especialidad", dts.gest_esp_alum)
            cmd.Parameters.AddWithValue("@año_ingreso", dts.gañoing_alum)
            cmd.Parameters.AddWithValue("@ape_pat_padre", dts.gape_pat_padre)
            cmd.Parameters.AddWithValue("@ape_mat_padre", dts.gape_mat_padre)
            cmd.Parameters.AddWithValue("@nom_padre", dts.gnom_padre)
            cmd.Parameters.AddWithValue("@dni_padre", dts.gdni_padre)
            cmd.Parameters.AddWithValue("@ocupacion_padre", dts.gocup_padre)
            cmd.Parameters.AddWithValue("@domicilio_padre", dts.gdom_padre)
            cmd.Parameters.AddWithValue("@telef_padre", dts.gtelef_padre)
            cmd.Parameters.AddWithValue("@ape_pat_Madre", dts.gape_pat_madre)
            cmd.Parameters.AddWithValue("@ape_mat_Madre", dts.gape_mat_madre)
            cmd.Parameters.AddWithValue("@nom_Madre", dts.gnom_madre)
            cmd.Parameters.AddWithValue("@DNI_MADRE", dts.gdni_madre)
            cmd.Parameters.AddWithValue("@ocupacion_Madre", dts.gocup_madre)
            cmd.Parameters.AddWithValue("@domicilio_Madre", dts.gdom_madre)
            cmd.Parameters.AddWithValue("@telef_Madre", dts.gtelef_madre)
            cmd.Parameters.AddWithValue("@foto", dts.gruta)
            cmd.Parameters.AddWithValue("@idusuario", dts.gIdUsuario)



            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscaralumno(ByVal idalumno As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscaralumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idalumno", idalumno)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificaralumno(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificaralumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idalumno", dts.gIdAlumno)
            cmd.Parameters.AddWithValue("@IdDistrito", dts.giddistrito)
            cmd.Parameters.AddWithValue("@IDTIPO", dts.gIdTipo)
            cmd.Parameters.AddWithValue("@IdEspecialidad", dts.gIdEspecialidad)
            cmd.Parameters.AddWithValue("@Ape_paterno", dts.gApe_paterno)
            cmd.Parameters.AddWithValue("@Ape_materno", dts.gApe_materno)
            cmd.Parameters.AddWithValue("@Nom_alumno", dts.gNom_Alumno)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfec_nac_alum)
            cmd.Parameters.AddWithValue("@Distrito_nac", dts.gdis_nac_alum)
            cmd.Parameters.AddWithValue("@Provincia_nac", dts.gprov_nac_alum)
            cmd.Parameters.AddWithValue("@Departamento_nac", dts.gdep_nac_alum)
            cmd.Parameters.AddWithValue("@edad", dts.gedad_alum)
            cmd.Parameters.AddWithValue("@sexo_alumno", dts.gsex_alum)
            cmd.Parameters.AddWithValue("@estado_civil", dts.gest_civil_alum)
            cmd.Parameters.AddWithValue("@dirección", dts.gdom_alum)
            cmd.Parameters.AddWithValue("@telef_alumno", dts.gtel_alum)
            cmd.Parameters.AddWithValue("@Nombre_ie", dts.gnomie_alum)
            cmd.Parameters.AddWithValue("@añoegreso_ie", dts.gañoeg_ie_alum)
            cmd.Parameters.AddWithValue("@NOM_ESPECIALIDAD", dts.gNom_Especialidad)
            cmd.Parameters.AddWithValue("@trabaja", dts.gtrabaja_alum)
            cmd.Parameters.AddWithValue("@centrotrabajo", dts.gcen_trab_alum)
            cmd.Parameters.AddWithValue("@func_trabajo", dts.gfunc_trab_alum)
            cmd.Parameters.AddWithValue("@NOM_turno", dts.gNom_turno)
            cmd.Parameters.AddWithValue("@e_mail", dts.gmail_alum)
            cmd.Parameters.AddWithValue("@estudia", dts.gestudia_alum)
            cmd.Parameters.AddWithValue("@estudia_especialidad", dts.gest_esp_alum)
            cmd.Parameters.AddWithValue("@año_ingreso", dts.gañoing_alum)
            cmd.Parameters.AddWithValue("@ape_pat_padre", dts.gape_pat_padre)
            cmd.Parameters.AddWithValue("@ape_mat_padre", dts.gape_mat_padre)
            cmd.Parameters.AddWithValue("@nom_padre", dts.gnom_padre)
            cmd.Parameters.AddWithValue("@dni_padre", dts.gdni_padre)
            cmd.Parameters.AddWithValue("@ocupacion_padre", dts.gocup_padre)
            cmd.Parameters.AddWithValue("@domicilio_padre", dts.gdom_padre)
            cmd.Parameters.AddWithValue("@telef_padre", dts.gtelef_padre)
            cmd.Parameters.AddWithValue("@ape_pat_madre", dts.gape_pat_madre)
            cmd.Parameters.AddWithValue("@ape_mat_madre", dts.gape_mat_madre)
            cmd.Parameters.AddWithValue("@nom_madre", dts.gnom_madre)
            cmd.Parameters.AddWithValue("@dni_madre", dts.gdni_madre)
            cmd.Parameters.AddWithValue("@ocupacion_madre", dts.gocup_madre)
            cmd.Parameters.AddWithValue("@domicilio_madre", dts.gdom_madre)
            cmd.Parameters.AddWithValue("@telef_madre", dts.gtelef_madre)
            cmd.Parameters.AddWithValue("@foto", dts.gruta)
            cmd.Parameters.AddWithValue("@idusuario", dts.gIdUsuario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function mostraralumno() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostraralumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'agrega a la bd los datos
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function


    Public Function eliminaralumno(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminaralumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idAlumno", SqlDbType.Char).Value = dts.gIdAlumno

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    'VER NOMINAS DE ALUMNOS EN REPORTE

    Public Function VERLISTALUMNOS(ByVal NOM_ESPECIALIDAD As String, ByVal NOM_TURNO As String, ByVal IDSEMESTRE As String, ByVal NUMERO As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("VERLISTALUMNOS")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nom_Especialidad", NOM_ESPECIALIDAD)
            cmd.Parameters.AddWithValue("@Nom_Turno", NOM_TURNO)
            cmd.Parameters.AddWithValue("@IdSemestre", IDSEMESTRE)
            cmd.Parameters.AddWithValue("@Numero", NUMERO)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try

        'Public Function vModuloP(ByVal idespecialidad As String, ByVal AÑO_MODULO As String) As DataTable
        'Try
        '    conectado()
        '    cmd = New SqlCommand("vmoduloP")
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Connection = cnn
        '    cmd.Parameters.AddWithValue("@idespecialidad", idespecialidad)
        '    cmd.Parameters.AddWithValue("@AÑO_MODULO", AÑO_MODULO)
        '    If cmd.ExecuteNonQuery Then
        '        Dim t As New DataTable
        '        Dim da As New SqlDataAdapter(cmd)
        '        da.Fill(t)
        '        Return t
        '    Else
        '        Return Nothing
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Return Nothing
        'Finally
        '    desconectado()
        'End Try
    End Function


   
    'GENERAR ID DE TABLAS

    Public Function GENERARIDDISTRITO() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("GENERARIDDISTRITO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'agrega a la bd los datos
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function GENERARIDUSUARIO() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("GENERARIDUSUARIO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'agrega a la bd los datos
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GENERARIDDOCENTE() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("GENERARIDDOCENTE")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'agrega a la bd los datos
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GENERARIDESPECIALIDAD() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("GENERARIDESPECIALIDAD")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'agrega a la bd los datos
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
  
    Public Function GENERARIDTIPO() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("GENERARIDTIPO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'agrega a la bd los datos
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function GenerarIDModuloP() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("GenerarIDModuloP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'agrega a la bd los datos
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GenerarIDModuloT() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("GenerarIDModuloT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'agrega a la bd los datos
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GENERARIDUNDDIDACP() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("GENERARIDUNDDIDACP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim DT As New DataTable
                Dim DA As New SqlDataAdapter(cmd)
                DA.Fill(DT)
                Return DT
            Else
                Return Nothing

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GENERARIDUNDDIDACT() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("GENERARIDUNDDIDACT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim DT As New DataTable
                Dim DA As New SqlDataAdapter(cmd)
                DA.Fill(DT)
                Return DT
            Else
                Return Nothing

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GENERARIDMATRICULA() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("GENERARIDMATRICULA")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim DT As New DataTable
                Dim DA As New SqlDataAdapter(cmd)
                DA.Fill(DT)
                Return DT
            Else
                Return Nothing

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function GENERARIDMATRICULAE() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("GENERARIDMATRICULAE")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim DT As New DataTable
                Dim DA As New SqlDataAdapter(cmd)
                DA.Fill(DT)
                Return DT
            Else
                Return Nothing

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

   
    'FUNC REGISTRAR USUARIO
    Public Function REGISTRARUSUARIO(ByVal SEUDONIMO As String, ByVal CLAVE As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("REGISTRARUSUARIO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@SEUDONIMO", SEUDONIMO)
            cmd.Parameters.AddWithValue("@CLAVE", CLAVE)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    'MATRICULA

    Public Function insertarMATRICULA(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertarMATRICULA")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IDMATRICULA", dts.gIdMATRICULA)
            cmd.Parameters.AddWithValue("@IDALUMNO", dts.gIdAlumno)
            cmd.Parameters.AddWithValue("@IDESPECIALIDAD", dts.gIdEspecialidad)
            cmd.Parameters.AddWithValue("@IDSEMESTRE", dts.gidsemestre)
            cmd.Parameters.AddWithValue("@IDTURNO", dts.gidturno)
            cmd.Parameters.AddWithValue("@IDUSUARIO", dts.gIdUsuario)
            cmd.Parameters.AddWithValue("@IDCICLO", dts.gidciclo)
            cmd.Parameters.AddWithValue("@año_modulo", dts.gaño_MODULO)
            cmd.Parameters.AddWithValue("@fecha_matricula", dts.gfecha_matricula)
            cmd.Parameters.AddWithValue("@descripcion", dts.gDescripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscarmatricula(ByVal idalumno As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarmatricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idalumno", idalumno)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function modificarmatricula(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificarmatricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            
            cmd.Parameters.AddWithValue("@IdEspecialidad", dts.gIdEspecialidad)
            cmd.Parameters.AddWithValue("@idturno", dts.gidturno)
            cmd.Parameters.AddWithValue("@idsemestre", dts.gidsemestre)
            cmd.Parameters.AddWithValue("@idciclo", dts.gidciclo)
            cmd.Parameters.AddWithValue("@año_modulo", dts.gaño_MODULO)
            cmd.Parameters.AddWithValue("@fecha_matricula", dts.gfecha_matricula)
            cmd.Parameters.AddWithValue("@descripcion", dts.gDescripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function


    Public Function eliminarmatricula(ByVal dts As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarmatricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idmatricula", SqlDbType.Char).Value = dts.gIdMATRICULA

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    'Public Function mostrarnomalumno() As DataTable
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("mostrarnomalumno")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn
    '        If cmd.ExecuteNonQuery Then
    '            Dim dt As New DataTable
    '            Dim da As New SqlDataAdapter(cmd)
    '            da.Fill(dt)
    '            Return dt
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return Nothing
    '    Finally
    '        desconectado()
    '    End Try
    'End Function

    'notas'

    Public Function vModuloP(ByVal idespecialidad As String, ByVal AÑO_MODULO As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("vmoduloP")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idespecialidad", idespecialidad)
            cmd.Parameters.AddWithValue("@AÑO_MODULO", AÑO_MODULO)
            If cmd.ExecuteNonQuery Then
                Dim t As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(t)
                Return t
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function vModuloT(ByVal idespecialidad As String, ByVal AÑO_MODULO As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("vmoduloT")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idespecialidad", idespecialidad)
            cmd.Parameters.AddWithValue("@AÑO_MODULO", AÑO_MODULO)
            If cmd.ExecuteNonQuery Then
                Dim t As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(t)
                Return t
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function vUNDDIDAC(ByVal idespecialidad As String, ByVal AÑO_MODULO As String, ByVal IDMODULO As String, ByVal IDCICLO As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("vUNDDIDAC")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idespecialidad", idespecialidad)
            cmd.Parameters.AddWithValue("@AÑO_MODULO", AÑO_MODULO)
            cmd.Parameters.AddWithValue("@IDMODULO", IDMODULO)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function VALUMNO(ByVal IDESPECIALIDAD As String, ByVal IDSEMESTRE As String, ByVal IDCICLO As String, ByVal IDTURNO As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("VALUMNO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idespecialidad", IDESPECIALIDAD)
            cmd.Parameters.AddWithValue("@IDSEMESTRE", IDSEMESTRE)
            cmd.Parameters.AddWithValue("@IDCICLO", IDCICLO)
            cmd.Parameters.AddWithValue("@IDTURNO", IDTURNO)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertarNOTA(ByVal DTS As datos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("INSERTARNOTA")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@AÑO_MODULO", DTS.gaño_MODULO)
            cmd.Parameters.AddWithValue("@IDESPECIALIDAD", DTS.gIdEspecialidad)
            cmd.Parameters.AddWithValue("@IDMODULO", DTS.gidmoduloP)
            cmd.Parameters.AddWithValue("@IDCICLO", DTS.gidciclo)
            cmd.Parameters.AddWithValue("@IDUNDDIDACP", DTS.gIdUndDidacP)
            'cmd.Parameters.AddWithValue("@IDSEMESTRE", DTS.gidsemestre)
            cmd.Parameters.AddWithValue("@IDTURNO", DTS.gidturno)
            cmd.Parameters.AddWithValue("@IDALUMNO", DTS.gIdAlumno)
            cmd.Parameters.AddWithValue("@IDUSUARIO", DTS.gIdUsuario)
            cmd.Parameters.AddWithValue("@IDDOCENTE", DTS.gidDocente)
            cmd.Parameters.AddWithValue("@NOTA_FINAL", DTS.gNOTA_FINAL)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    'FUNCIONES PARA REPORTE NOTAS

    Public Function VerNotaAlumno() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("VerNotaAlumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
End Class
