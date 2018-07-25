Public Class datos

    Dim IdEspecialidad As String
    Dim Nom_Especialidad As String

    Dim idciclo As String
    Dim Nom_ciclo As String
    Dim numero As String

    Dim idmoduloP As String
    Dim idmoduloT As String
    Dim Nom_modulo As String
    Dim idespeci As String     ' ver si se puede utilizar la misma variable para todas los forms
    Dim año_MODULO As String
    Dim fecha_hora As String
    'Dim IdUsuarioM As String      ' falta crear su funcion

    Dim idturno As String
    Dim Nom_turno As String

    Dim iddistrito As String
    Dim Nom_distrito As String

    Dim idsemestre As String
    Dim fecha_inicio As Date
    Dim fecha_fin As Date
    'DOCENTE

    Dim idDocente As String
    Dim nom_docente As String
    Dim ape_docente As String
    '*********
    Dim dir_docente As String
    Dim dni_docente As String
    Dim email_docente As String
    Dim fec_nac_docente As String
    Dim tel_docente As String
    Dim sex_docente As String
    '********
    Dim grado As String
    Dim titulo As String
    Dim maestria As String
    Dim doctorado As String
    Dim foto As String
    'Dim IdUsuario As String

    Dim IdUndDidacP As String
    Dim IdUndDidacT As String
    Dim Nom_UndDidac As String
    'Dim IdModuloU As String
    Dim horas As String
    Dim credito As String
    Dim IdCicloU As String

    Dim idUsuario As String
    Dim Nom_Usuario As String
    Dim Ape_Usuario As String
    Dim Nivel As String
    Dim Mensaje As String
    Dim seudonimo As String
    Dim Clave As String

    Dim IdTipo As String
    Dim Descripcion As String

    'frmregistrar Alumno'
    Dim IdAlumno As String
    Dim Nom_Alumno As String
    Dim Ape_paterno As String
    Dim Ape_materno As String
    Dim fec_nac_alum As Date
    Dim dom_alum As String
    Dim tel_alum As String
    Dim dep_alum As String
    Dim dis_alum As String
    Dim sex_alum As String
    Dim mail_alum As String
    Dim añoing_alum As String
    Dim ruta As String
    Dim dis_nac_alum As String

   
    Public Property gdis_nac_alum
        Get
            Return dis_nac_alum
        End Get
        Set(ByVal value)
            dis_nac_alum = value
        End Set
    End Property
    Dim prov_nac_alum As String
    Public Property gprov_nac_alum
        Get
            Return prov_nac_alum
        End Get
        Set(ByVal value)
            prov_nac_alum = value
        End Set
    End Property
    Dim dep_nac_alum As String
    Public Property gdep_nac_alum
        Get
            Return dep_nac_alum
        End Get
        Set(ByVal value)
            dep_nac_alum = value
        End Set
    End Property
    Dim edad_alum As String
    Public Property gedad_alum
        Get
            Return edad_alum
        End Get
        Set(ByVal value)
            edad_alum = value
        End Set
    End Property
    Dim est_civil_alum As String
    Public Property gest_civil_alum
        Get
            Return est_civil_alum
        End Get
        Set(ByVal value)
            est_civil_alum = value
        End Set
    End Property
    Dim nomie_alum As String
    Public Property gnomie_alum
        Get
            Return nomie_alum
        End Get
        Set(ByVal value)
            nomie_alum = value
        End Set
    End Property
    Dim añoeg_ie_alum As String
    Public Property gañoeg_ie_alum
        Get
            Return añoeg_ie_alum
        End Get
        Set(ByVal value)
            añoeg_ie_alum = value
        End Set
    End Property
    Dim trabaja_alum As String
    Public Property gtrabaja_alum
        Get
            Return trabaja_alum
        End Get
        Set(ByVal value)
            trabaja_alum = value
        End Set
    End Property
    Dim cen_trab_alum As String
    Public Property gcen_trab_alum
        Get
            Return cen_trab_alum
        End Get
        Set(ByVal value)
            cen_trab_alum = value
        End Set
    End Property
    Dim func_trab_alum As String
    Public Property gfunc_trab_alum
        Get
            Return func_trab_alum
        End Get
        Set(ByVal value)
            func_trab_alum = value
        End Set
    End Property
    Dim estudia_alum As String
    Public Property gestudia_alum
        Get
            Return estudia_alum
        End Get
        Set(ByVal value)
            estudia_alum = value
        End Set
    End Property
    Dim est_esp_alum As String
    Public Property gest_esp_alum
        Get
            Return est_esp_alum
        End Get
        Set(ByVal value)
            est_esp_alum = value
        End Set
    End Property

    Dim ape_pat_padre As String
    Public Property gape_pat_padre
        Get
            Return ape_pat_padre
        End Get
        Set(ByVal value)
            ape_pat_padre = value
        End Set
    End Property
    Dim ape_mat_padre As String
    Public Property gape_mat_padre
        Get
            Return ape_mat_padre
        End Get
        Set(ByVal value)
            ape_mat_padre = value
        End Set
    End Property
    Dim nom_padre As String
    Public Property gnom_padre
        Get
            Return nom_padre
        End Get
        Set(ByVal value)
            nom_padre = value
        End Set
    End Property
    Dim dni_padre As String
    Public Property gdni_padre
        Get
            Return dni_padre
        End Get
        Set(ByVal value)
            dni_padre = value
        End Set
    End Property
    Dim ocup_padre As String
    Public Property gocup_padre
        Get
            Return ocup_padre
        End Get
        Set(ByVal value)
            ocup_padre = value
        End Set
    End Property
    Dim dom_padre As String
    Public Property gdom_padre
        Get
            Return dom_padre
        End Get
        Set(ByVal value)
            dom_padre = value
        End Set
    End Property
    Dim telef_padre As String
    Public Property gtelef_padre
        Get
            Return telef_padre
        End Get
        Set(ByVal value)
            telef_padre = value
        End Set
    End Property

    Dim ape_pat_madre As String
    Public Property gape_pat_madre
        Get
            Return ape_pat_madre
        End Get
        Set(ByVal value)
            ape_pat_madre = value
        End Set
    End Property
    Dim ape_mat_madre As String
    Public Property gape_mat_madre
        Get
            Return ape_mat_madre
        End Get
        Set(ByVal value)
            ape_mat_madre = value
        End Set
    End Property
    Dim nom_madre As String
    Public Property gnom_madre
        Get
            Return nom_madre
        End Get
        Set(ByVal value)
            nom_madre = value
        End Set
    End Property
    Dim dni_madre As String
    Public Property gdni_madre
        Get
            Return dni_madre
        End Get
        Set(ByVal value)
            dni_madre = value
        End Set
    End Property
    Dim ocup_madre As String
    Public Property gocup_madre
        Get
            Return ocup_madre
        End Get
        Set(ByVal value)
            ocup_madre = value
        End Set
    End Property
    Dim dom_madre As String
    Public Property gdom_madre
        Get
            Return dom_madre
        End Get
        Set(ByVal value)
            dom_madre = value
        End Set
    End Property
    Dim telef_madre As String
    Public Property gtelef_madre
        Get
            Return telef_madre
        End Get
        Set(ByVal value)
            telef_madre = value
        End Set
    End Property

    'MATRICULA
    Dim IDMATRICULA As String

    Dim NOTA_FINAL As String

    Dim fecha_matricula As Date


    Public Property gfecha_matricula
        Get
            Return fecha_matricula
        End Get
        Set(ByVal value)
            fecha_matricula = value
        End Set
    End Property

    'DATOS PARA FORMULARIO ESPECIALIDAD

    Public Property gIdEspecialidad
        Get
            Return IdEspecialidad
        End Get
        Set(ByVal value)
            IdEspecialidad = value
        End Set
    End Property

    Public Property gNom_Especialidad
        Get
            Return Nom_Especialidad
        End Get
        Set(ByVal value)
            Nom_Especialidad = value
        End Set
    End Property

    'Public Sub New(ByVal idespecialidad As String, ByVal especialidad As String)
    '    gidespecialidad = idespecialidad
    '    gNom_Especialidad = Nom_Especialidad
    'End Sub


    'DATOS PARA FORMULARIO CICLO

    Public Property gidciclo
        Get
            Return idciclo
        End Get
        Set(ByVal value)
            idciclo = value
        End Set
    End Property

    Public Property gnom_ciclo
        Get
            Return Nom_ciclo
        End Get
        Set(ByVal value)
            Nom_ciclo = value
        End Set
    End Property


    Public Property gnumero
        Get
            Return numero
        End Get
        Set(ByVal value)
            numero = value
        End Set
    End Property


    'DATOS PARA FORMULARIO MODULO PROFESIONAL

    Public Property gidmoduloP
        Get
            Return idmoduloP
        End Get
        Set(ByVal value)
            idmoduloP = value
        End Set
    End Property

    Public Property gidespeci
        Get
            Return idespeci
        End Get
        Set(ByVal value)
            idespeci = value
        End Set
    End Property


    Public Property gNom_modulo
        Get
            Return Nom_modulo
        End Get
        Set(ByVal value)
            Nom_modulo = value
        End Set
    End Property
    Public Property gaño_MODULO
        Get
            Return año_MODULO
        End Get
        Set(ByVal value)
            año_MODULO = value
        End Set
    End Property
    Public Property gidmoduloT
        Get
            Return idmoduloT
        End Get
        Set(ByVal value)
            idmoduloT = value
        End Set
    End Property
    'Public Property gfecha_hora
    '    Get
    '        Return fecha_hora
    '    End Get
    '    Set(ByVal value)
    '        fecha_hora = value
    '    End Set
    'End Property

    'Public Property gIdUsuarioM
    '    Get
    '        Return idUsuarioM
    '    End Get
    '    Set(ByVal value)
    '        idUsuarioM = value
    '    End Set
    'End Property

    'DATOS PARA TABLA USUARIO

    Public Property gIdUsuario
        Get
            Return idUsuario
        End Get
        Set(ByVal value)
            idUsuario = value
        End Set
    End Property
    Public Property gNom_Usuario
        Get
            Return Nom_Usuario
        End Get
        Set(ByVal value)
            Nom_Usuario = value
        End Set
    End Property

    Public Property gApe_Usuario
        Get
            Return Ape_Usuario
        End Get
        Set(ByVal value)
            Ape_Usuario = value
        End Set
    End Property
    Public Property gNivel
        Get
            Return Nivel
        End Get
        Set(ByVal value)
            Nivel = value
        End Set
    End Property

    Public Property gMensaje
        Get
            Return Mensaje
        End Get
        Set(ByVal value)
            Mensaje = value
        End Set
    End Property
    Public Property gSeudonimo
        Get
            Return seudonimo
        End Get
        Set(ByVal value)
            seudonimo = value
        End Set
    End Property

    Public Property gClave
        Get
            Return Clave
        End Get
        Set(ByVal value)
            Clave = value
        End Set
    End Property


    'DATOS PARA FORMULARIO TURNO

    Public Property gidturno
        Get
            Return idturno
        End Get
        Set(ByVal value)
            idturno = value
        End Set
    End Property
    Public Property gNom_turno
        Get
            Return Nom_turno
        End Get
        Set(ByVal value)
            Nom_turno = value
        End Set
    End Property

    'DATOS PARA FORMULARIO DISTRITO

    Public Property giddistrito
        Get
            Return iddistrito
        End Get
        Set(ByVal value)
            iddistrito = value
        End Set
    End Property
    Public Property gNom_distrito
        Get
            Return Nom_distrito
        End Get
        Set(ByVal value)
            Nom_distrito = value
        End Set
    End Property

    'DATOS PARA EL FORMULARIO SEMESTRE


    Public Property gidsemestre
        Get
            Return idsemestre
        End Get
        Set(ByVal value)
            idsemestre = value
        End Set
    End Property

    Public Property gfecha_inicio
        Get
            Return fecha_inicio
        End Get
        Set(ByVal value)
            fecha_inicio = value
        End Set
    End Property


    Public Property gfecha_fin
        Get
            Return fecha_fin
        End Get
        Set(ByVal value)
            fecha_fin = value
        End Set
    End Property

    'DATOS PARA FORMULARIO DOCENTE

    Public Property gidDocente
        Get
            Return idDocente
        End Get
        Set(ByVal value)
            idDocente = value
        End Set
    End Property

    Public Property gnom_docente
        Get
            Return nom_docente
        End Get
        Set(ByVal value)
            nom_docente = value
        End Set
    End Property


    Public Property gape_docente
        Get
            Return ape_docente
        End Get
        Set(ByVal value)
            ape_docente = value
        End Set
    End Property
    Public Property gDir_docente
        Get
            Return dir_docente

        End Get
        Set(ByVal value)
            dir_docente = value
        End Set
    End Property
    Public Property gDni_docente
        Get
            Return dni_docente

        End Get
        Set(ByVal value)
            dni_docente = value
        End Set
    End Property
    Public Property gEmail_docente
        Get
            Return email_docente

        End Get
        Set(ByVal value)
            email_docente = value
        End Set
    End Property
    Public Property gTel_docente
        Get
            Return tel_docente

        End Get
        Set(ByVal value)
            tel_docente = value
        End Set
    End Property
    Public Property gFec_nac_docente
        Get
            Return fec_nac_docente

        End Get
        Set(ByVal value)
            fec_nac_docente = value
        End Set
    End Property
    Public Property gSex_docente
        Get
            Return sex_docente

        End Get
        Set(ByVal value)
            sex_docente = value
        End Set
    End Property

    Public Property ggrado
        Get
            Return grado
        End Get
        Set(ByVal value)
            grado = value
        End Set
    End Property

    Public Property gtitulo
        Get
            Return titulo
        End Get
        Set(ByVal value)
            titulo = value
        End Set
    End Property


    Public Property gmaestria
        Get
            Return maestria
        End Get
        Set(ByVal value)
            maestria = value
        End Set
    End Property

    Public Property gdoctorado
        Get
            Return doctorado
        End Get
        Set(ByVal value)
            doctorado = value
        End Set
    End Property

    Public Property gfoto
        Get
            Return foto
        End Get
        Set(ByVal value)
            foto = value
        End Set
    End Property


    'Public Property gUsuario
    '    Get
    '        Return Usuario
    '    End Get
    '    Set(ByVal value)
    '        Usuario = value
    '    End Set
    'End Property

    'DATOS PARA FORMULARIOS DE UND.DIACTICA 

    Public Property gIdUndDidacP
        Get
            Return IdUndDidacP
        End Get
        Set(ByVal value)
            IdUndDidacP = value
        End Set
    End Property

    Public Property gIdUndDidacT
        Get
            Return IdUndDidacT
        End Get
        Set(ByVal value)
            IdUndDidacT = value
        End Set
    End Property

    Public Property gNom_UndDidac
        Get
            Return Nom_UndDidac
        End Get
        Set(ByVal value)
            Nom_UndDidac = value
        End Set
    End Property


    Public Property gHoras
        Get
            Return horas
        End Get
        Set(ByVal value)
            horas = value
        End Set
    End Property

    Public Property gCredito
        Get
            Return credito
        End Get
        Set(ByVal value)
            credito = value
        End Set
    End Property

    Public Property gIdCicloU
        Get
            Return IdCicloU
        End Get
        Set(ByVal value)
            IdCicloU = value
        End Set
    End Property

    'Public Property gIdModuloU
    '    Get
    '        Return IdModuloU
    '    End Get
    '    Set(ByVal value)
    '        IdModuloU = value
    '    End Set
    'End Property

    'DATOS PARA FORMULARIO TIPO DE INGRESO
    Public Property gIdTipo
        Get
            Return IdTipo
        End Get
        Set(ByVal value)
            IdTipo = value
        End Set
    End Property

    Public Property gDescripcion
        Get
            Return Descripcion
        End Get
        Set(ByVal value)
            Descripcion = value
        End Set
    End Property

    'datos de frmRegistrarlumno'

    Public Property gIdAlumno
        Get
            Return IdAlumno
        End Get
        Set(ByVal value)
            IdAlumno = value
        End Set
    End Property
    Public Property gNom_Alumno
        Get
            Return Nom_Alumno
        End Get
        Set(ByVal value)
            Nom_Alumno = value
        End Set
    End Property
    Public Property gApe_paterno
        Get
            Return Ape_paterno
        End Get
        Set(ByVal value)
            Ape_paterno = value
        End Set
    End Property
    Public Property gApe_materno
        Get
            Return Ape_materno
        End Get
        Set(ByVal value)
            Ape_materno = value
        End Set
    End Property

    Public Property gfec_nac_alum
        Get
            Return fec_nac_alum
        End Get
        Set(ByVal value)
            fec_nac_alum = value
        End Set
    End Property
    Public Property gdom_alum
        Get
            Return dom_alum
        End Get
        Set(ByVal value)
            dom_alum = value
        End Set
    End Property
    Public Property gtel_alum
        Get
            Return tel_alum
        End Get
        Set(ByVal value)
            tel_alum = value
        End Set
    End Property
    Public Property gdep_alum
        Get
            Return dep_alum
        End Get
        Set(ByVal value)
            dep_alum = value
        End Set
    End Property
    Public Property gdis_alum
        Get
            Return dis_alum
        End Get
        Set(ByVal value)
            dis_alum = value
        End Set
    End Property
    Public Property gsex_alum
        Get
            Return sex_alum
        End Get
        Set(ByVal value)
            sex_alum = value
        End Set
    End Property

    Public Property gmail_alum
        Get
            Return mail_alum
        End Get
        Set(ByVal value)
            mail_alum = value
        End Set
    End Property
    Public Property gañoing_alum
        Get
            Return añoing_alum
        End Get
        Set(ByVal value)
            añoing_alum = value
        End Set
    End Property
    Public Property gruta
        Get
            Return ruta
        End Get
        Set(ByVal value)
            ruta = value
        End Set
    End Property
    'MATRICULA
    Public Property gIdMATRICULA
        Get
            Return IDMATRICULA
        End Get
        Set(ByVal value)
            IDMATRICULA = value
        End Set
    End Property

    Public Property gNOTA_FINAL
        Get
            Return NOTA_FINAL
        End Get
        Set(ByVal value)
            NOTA_FINAL = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
