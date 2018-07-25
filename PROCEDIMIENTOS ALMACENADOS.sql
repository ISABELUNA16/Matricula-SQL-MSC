USE MATRICULA
GO

--PROCEDIMIENTOS PARA  VER NOTAS DE ALUMNO

CREATE PROCEDURE [dbo].[VerNotaAlumno] 
	AS
 select * from notas where idalumno='" & Me.txtCodAlumno.text & " ' 
 order BY IdAlumno
GO

--PROCEDIMIENTOS PARA  LA TABLA ESPECIALIDAD  

CREATE PROCEDURE [dbo].[MostrarEspecialidad] 
	AS
select * from Especialidad ORDER BY IdEspecialidad
GO

CREATE PROCEDURE [dbo].[NuevoEspecialidad]
	
	@IdEspecialidad char(3),
	@Nom_Especialidad varchar(30)
AS
insert into Especialidad(IdEspecialidad,Nom_Especialidad)
values (@IdEspecialidad,@Nom_Especialidad)
GO

CREATE PROCEDURE [dbo].[BuscarEspecialidad]

@IdEspecialidad char(3)
as
select*from Especialidad
where IdEspecialidad=@IdEspecialidad
GO

CREATE PROCEDURE [dbo].[ModificarEspecialidad]
	
	@IdEspecialidad char(3),
	@Nom_Especialidad varchar(30)
AS
update Especialidad
	
	SET 
	
	IdEspecialidad=@IdEspecialidad,
	Nom_Especialidad=@Nom_Especialidad
	
	WHERE
	
	IdEspecialidad=@IdEspecialidad
	GO
	
CREATE PROCEDURE [dbo].[EliminarEspecialidad] 
	
	@IdEspecialidad char(3)
AS

delete from Especialidad
where IdEspecialidad=@IdEspecialidad
GO


--PROCEDIMIENTOS PARA  LA TABLA CICLO

CREATE PROCEDURE dbo.MostrarCiclo 
	AS
select * from Ciclo ORDER BY IdCiclo
go


CREATE PROCEDURE dbo.nuevociclo
	
	@Idciclo char(3),
	@Nom_Ciclo varchar(10),
	@Numero char(2)
	
AS
insert into Ciclo(IdCiclo,Nom_Ciclo,Numero)
values (@IdCiclo,@Nom_Ciclo,@Numero)

GO

create PROCEDURE [dbo].[BuscarCiclo]

@IdCiclo char(3)
as
select*from Ciclo
where IdCiclo=@IdCiclo
GO

CREATE PROCEDURE dbo.ModificarCiclo
	
	@IdCiclo char(3),
	@Nom_Ciclo varchar(10),
	@Numero char(2)
AS
update Ciclo
	
	SET 
	IdCiclo=@IdCiclo,
	Nom_Ciclo=@Nom_Ciclo,
	Numero=@Numero
	WHERE
	IdCiclo=@IdCiclo
GO

create PROCEDURE [dbo].[EliminarCiclo] 
	
	@IdCiclo char(3)
AS
delete from Ciclo
where IdCiclo=@IdCiclo
go

--PROCEDIMIENTOS PARA TABLA MODULO PROFESIONAL

CREATE PROCEDURE dbo.MostrarModuloP 
	AS
select * from Modulo_Profesional ORDER BY IdModuloP, IdEspecialidad
go


CREATE PROCEDURE dbo.GuardarModuloP
	
	@IdModuloP char(4),
	@Nom_Modulo varchar(100),
	@Año_Modulo char(4),
	@Idespecialidad char(3),
	@IdUsuario char(5)
	AS
insert into Modulo_Profesional(IdModuloP,Nom_Modulo,Año_Modulo,IdEspecialidad,IdUsuario)
values (@IdmoduloP,@nom_modulo,@año_Modulo,@idespecialidad,@idusuario)

GO

CREATE PROCEDURE [dbo].[BuscarModuloP]

@IdModuloP char(4),
@IdEspecialidad char(3)
as
select*from Modulo_Profesional
where IdModuloP=@IdModuloP and IdEspecialidad=@IdEspecialidad
GO

CREATE PROCEDURE dbo.ModificarModuloP
	
	@IdModuloP char(4),
	@Nom_Modulo varchar(100),
	@Año_Modulo char(4),
	@IdEspecialidad char(3),
	@IdUsuario char(5)
AS
update Modulo_Profesional
	
	SET 
	IdModuloP=@IdModuloP,
	Nom_Modulo=@Nom_Modulo,
	Año_Modulo=@Año_Modulo,
	IdEspecialidad=@IdEspecialidad,
	IdUsuario=@IdUsuario
	WHERE
	IdModuloP=@IdModuloP
GO

create PROCEDURE [dbo].[EliminarModuloP] 
	
	@IdModuloP char(4)
AS
delete from Modulo_Profesional
where IdModuloP=@IdModuloP
go

--PROCEDIMIENTOS PARA TABLA MODULO TRANSVERSAL

CREATE PROCEDURE dbo.MostrarModuloT 
	AS
select * from Modulo_Transversal ORDER BY IdModuloT, IdEspecialidad
go


CREATE PROCEDURE dbo.GuardarModuloT	
	@IdModuloT char(4),
	@Nom_Modulo varchar(100),
	@Año_Modulo char(4),
	@Idespecialidad char(3),
	@IdUsuario char(5)
	AS
insert into Modulo_Transversal(IdModuloT,Nom_Modulo,Año_Modulo,IdEspecialidad,IdUsuario)
values (@IdmoduloT,@nom_modulo,@año_Modulo,@idespecialidad,@idusuario)
GO

CREATE PROCEDURE [dbo].[BuscarModuloT]

@IdModuloT char(4),
@IdEspecialidad char(3)
as
select*from Modulo_Transversal
where IdModuloT=@IdModuloT and IdEspecialidad=@IdEspecialidad
GO


CREATE PROCEDURE dbo.ModificarModuloT
	
	@IdModuloT char(4),
	@Nom_Modulo varchar(100),
	@Año_Modulo char(4),
	@IdEspecialidad char(3),
	@IdUsuario char(5)
AS
update Modulo_Transversal
	
	SET 
	IdModuloT=@IdModuloT,
	Nom_Modulo=@Nom_Modulo,
	Año_Modulo=@Año_Modulo,
	IdEspecialidad=@IdEspecialidad,
	IdUsuario=@IdUsuario
	WHERE
	IdModuloT=@IdModuloT
GO

create PROCEDURE [dbo].[EliminarModuloT] 
	
	@IdModuloT char(4)
AS
delete from Modulo_Transversal
where IdModuloT=@IdModuloT
go


--PROCEDIMIENTO PARA CONTRASEÑA

create procedure dbo.Validar
@Seudonimo varchar (20),
@Clave varchar(20)
as
select * from Usuario
where Seudonimo=@Seudonimo and Clave=@Clave
go

--PROCEDIMIENTOS PARA TABLA TURNO


CREATE PROCEDURE [dbo].[MostrarTurno] 
	AS
select * from Turno ORDER BY IdTurno
GO

CREATE PROCEDURE [dbo].[NuevoTurno]
	
	@IdTurno char(1),
	@Nom_Turno varchar(10)
AS
insert into Turno(IdTurno,Nom_Turno)
values (@IdTurno,@Nom_Turno)
GO
select * from Turno
CREATE PROCEDURE [dbo].[BuscarTurno]

@Idturno char(1)
as
select*from Turno
where IdTurno=@IdTurno
GO
select * from Turno 

CREATE PROCEDURE [dbo].[ModificarTurno]
	
	@IdTurno char(1),
	@Nom_Turno varchar(10)
AS
update turno
	
	SET 
	IdTurno=@IdTurno,
	Nom_Turno=@Nom_Turno
	WHERE
	IdTurno=@IdTurno
	GO
	
CREATE PROCEDURE [dbo].[EliminarTurno] 
	
	@IdTurno char(1)
AS
delete from Turno
where IdTurno=@IdTurno
GO

--PROCEDIMIENTOS PARA TABLA DISTRITO

CREATE PROCEDURE [dbo].[MostrarDistrito] 
	AS
select * from Distrito ORDER BY IdDistrito
GO

CREATE PROCEDURE [dbo].[NuevoDistrito]
	
	@IdDistrito char(3),
	@Nom_Distrito varchar(30)
AS
insert into Distrito(IdDistrito,Nom_Distrito )
values (@IdDistrito,@Nom_Distrito)
GO

CREATE PROCEDURE [dbo].[buscarDistrito]

@IdDistrito char(3)
as
select*from Distrito
where IdDistrito=@IdDistrito
GO

CREATE PROCEDURE [dbo].[ModificarDistrito]
	
	@IdDistrito char(3),
	@Nom_Distrito varchar(30)
AS
update Distrito
	
	SET 
	IdDistrito=@IdDistrito,
	Nom_Distrito=@Nom_Distrito
	WHERE
	IdDistrito=@IdDistrito
	GO
	
CREATE PROCEDURE [dbo].[EliminarDistrito] 
	
	@IdDistrito char(3)
AS
delete from Distrito
where IdDistrito=@IdDistrito
GO

--PROCEDIMIENTOS PARA TABLA SEMESTRE

CREATE PROCEDURE [dbo].[MostrarSemestre] 
	AS
select * from Semestre ORDER BY IdSemestre
GO

CREATE PROCEDURE [dbo].[NuevoSemestre]
	
	@IdSemestre char(6),
	@Fecha_Inicio date,
	@Fecha_Fin date
AS
insert into Semestre(IdSemestre,Fecha_Inicio,Fecha_Fin)
values (@IdSemestre,@Fecha_Inicio,@Fecha_Fin)
GO

CREATE PROCEDURE [dbo].[BuscarSemestre]

@IdSemestre char(6)
as
select*from Semestre
where IdSemestre=@IdSemestre
GO

CREATE PROCEDURE [dbo].[ModificarSemestre]
	
	@IdSemestre char(6),
	@Fecha_Inicio date,
	@Fecha_Fin date
AS
update Semestre
	
	SET 
	IdSemestre=@IdSemestre,
	Fecha_Inicio=@Fecha_Inicio,
	Fecha_Fin= @Fecha_Fin
	WHERE
	IdSemestre=@IdSemestre
	GO
	
	CREATE PROCEDURE [dbo].[EliminarSemestre] 
	
	@Idsemestre char(6)
AS
delete from Semestre
where IdSemestre=@IdSemestre
go


--PROCEDIMIENTOS PARA TABLA DOCENTE

CREATE PROCEDURE dbo.MostrarDocente 
	AS
select * from Docente ORDER BY IdDocente
go


CREATE PROCEDURE dbo.NuevoDocente

    @IdDocente          char(5),
	@Nom_Docente       varchar(30),
	@Ape_Docente        varchar(30),
	@Grado              varchar(20)   ,
	@Titulo             varchar(30)   ,
	@Maestria           varchar(30)   ,
	@Doctorado          varchar(30)  ,
	@Foto               nvarchar(max)   ,
	@Dni_Docente        char(8)    ,
	@Email_Docente      varchar(30)   ,
	@Tel_Docente        varchar(9)   ,
	@Dir_Docente        varchar(50)   ,
	@Fec_Nac_Docente    date   ,
	@Sex_Docente        char(1)  ,
	@IdUsuario         varchar(5)  
	
		
AS
insert into Docente(IdDocente,Nom_Docente,Ape_Docente,Grado,Titulo,Maestria,Doctorado,Foto,Dni_Docente,Email_Docente,Tel_Docente,Dir_Docente,Fec_Nac_Docente,Sex_Docente,IdUsuario )
values (@IdDocente,@Nom_Docente,@Ape_Docente,@Grado,@Titulo,@Maestria,@Doctorado,@Foto,@Dni_Docente,@Email_Docente,@Tel_Docente,@Dir_Docente,@Fec_Nac_Docente, @Sex_Docente,@IdUsuario )
GO

create PROCEDURE [dbo].[BuscarDocente]

@IdDocente char(5)
as
select*from Docente
where IdDocente=@IdDocente
GO

CREATE PROCEDURE dbo.modificarDocente
	
	@IdDocente          char(5),
	@Nom_Docente       varchar(30),
	@Ape_Docente        varchar(30),
	@Grado              varchar(20)   ,
	@Titulo             varchar(30)   ,
	@Maestria           varchar(30)   ,
	@Doctorado          varchar(30)  ,
	@Foto               nvarchar(max)   ,
	@Dni_Docente        char(8)    ,
	@Email_Docente      varchar(30)   ,
	@Tel_Docente        varchar(9)   ,
	@Dir_Docente        varchar(50)   ,
	@Fec_Nac_Docente    date   ,
	@Sex_Docente        char(1)  ,
	@IdUsuario         varchar(5) 
	 
	
AS
update Docente
	
	SET 
	 IdDocente=@IdDocente,
	Nom_Docente=Nom_Docente,
	Ape_Docente=@Ape_Docente,
	Grado=@Grado,
	Titulo=@Titulo,
	Maestria =Maestria,
	Doctorado=@Doctorado,
	Foto=@Foto,
	Dni_Docente=@Dni_Docente,
	Email_Docente=@Email_Docente,
	Tel_Docente =@Tel_Docente,
	Dir_Docente=@Dir_Docente,
	Fec_Nac_Docente=@Fec_Nac_Docente,
	Sex_Docente =@Sex_Docente,
	IdUsuario=@IdUsuario
	
	WHERE
	IdDocente=@IdDocente
GO

create PROCEDURE [dbo].[EliminarDocente] 
	
	@IdDocente char(5)
AS
delete from Docente
where IdDocente=@IdDocente
go

--PROCEDIMIENTOS PARA  LA TABLA USUARIO
CREATE PROCEDURE [dbo].[MostrarUsuario] 
	AS
select * from Usuario ORDER BY IdUsuario
GO

CREATE PROCEDURE [dbo].[NuevoUsuario]
	
	@IdUsuario char(5),
	@Nom_Usuario varchar(30),
	@Ape_Usuario varchar(30),
	@Nivel varchar(10),
	@Mensaje varchar (50),
	@Seudonimo varchar (20),
	@Clave varchar (20)
AS
insert into Usuario(IdUsuario,Nom_Usuario,Ape_Usuario,Nivel,Mensaje,Seudonimo,Clave)
values (@IdUsuario,@Nom_Usuario,@Ape_Usuario,@Nivel,@Mensaje,@Seudonimo,@Clave)
GO

CREATE PROCEDURE [dbo].[BuscarUsuario]

@IdUsuario char(5)
as
select*from Usuario
where IdUsuario=@IdUsuario
GO

CREATE PROCEDURE [dbo].[ModificarUsuario]
	
	@IdUsuario char(5),
	@Nom_Usuario varchar(30),
	@Ape_Usuario varchar(30),
	@Nivel varchar(10),
	@Mensaje varchar (50),
	@Seudonimo varchar (20),
	@Clave varchar (20)
AS
update Usuario
SET 
	IdUsuario=@IdUsuario,
	Nom_Usuario=@Nom_Usuario,
	Ape_Usuario=@Ape_Usuario,
	Nivel=@Nivel,
	Mensaje=@Mensaje,
	Seudonimo=@Seudonimo,
	Clave=@Clave
WHERE
	IdUsuario=@IdUsuario
GO
	
CREATE PROCEDURE [dbo].[EliminarUsuario] 
	
	@IdUsuario char(3)
AS
delete from Usuario
where IdUsuario=@IdUsuario
GO

--PROCEDIMIENTOS PARA  LA TABLA TIPO DE INGRESO
CREATE PROCEDURE [dbo].[MostrarTipo] 
	AS
select * from TipoIngreso ORDER BY IdTipo
GO

CREATE PROCEDURE [dbo].[NuevoTipo]
	
	@IdTipo char(3),
	@Descripcion varchar(30)
AS
insert into TipoIngreso(IdTipo,descripcion)
values (@IdTipo,@descripcion)
GO

CREATE PROCEDURE [dbo].[BuscarTipo]

@IdTipo char(3)
as
select*from TipoIngreso
where IdTipo=@IdTipo
GO

CREATE PROCEDURE [dbo].[ModificarTipo]
	
	@IdTipo char(3),
	@Descripcion varchar(30)
	AS
	update TipoIngreso
	
	SET 
	IdTipo=@IdTipo,
	Descripcion=@Descripcion
	WHERE
	IdTipo=@IdTipo
	GO
	
CREATE PROCEDURE [dbo].[EliminarTipo] 
	
	@IdTipo char(3)
	AS
	delete from TipoIngreso
	where
	 IdTipo=@IdTipo
	GO
	
	--PROCEDIMIENTOS PARA TABLA UND. DIDACTICA PROFESIONAL
	
	CREATE PROCEDURE [dbo].[MostrarUDP] 
	AS
	select * from UndDidactica_Profesional ORDER BY IdUndDidacp	
	GO

	create PROCEDURE [dbo].[GuardarUDP]
	@IdUndDidacP         char(4)   ,
	@Nom_UndDidactica   varchar(100)  ,
	@Credito            int   ,
	@Horas              int   ,
	@IdModuloP           char(3)   ,
	@IdCiclo            char(3) 
	
	AS
	insert into UndDidactica_Profesional(Nom_UndDidactica,IdUndDidacP,Credito,Horas,IdModuloP,IdCiclo)
	values (@Nom_UndDidactica,@IdUndDidacP,@Credito,@Horas,@IdModuloP,@IdCiclo)
	GO
	

	CREATE PROCEDURE [dbo].[BuscarUDP]

	@IdUndDidacP char(4),
	@IdEspecialidad char(3)
	as
	select*from UndDidactica_Profesional
	where IdUndDidacP=@IdUndDidacP and IdEspecialidad=@IdEspecialidad
	GO

	CREATE PROCEDURE [dbo].[ModificarUDP]
		
	@Nom_UndDidactica   varchar(100)  ,
	@Credito            int   ,
	@Horas              int   ,
	@IdUndDidacP         char(4)   ,
	@IdModuloP           char(3)   ,
	@IdCiclo            char(3) 
	AS
	update UndDidactica_Profesional
	
	SET 
	Nom_UndDidactica=@Nom_UndDidactica,
	Credito=@Credito,
	Horas=@Horas,
	IdUndDidacP=@IdUndDidacP,
	IdModuloP=@IdModuloP,
	IdCiclo=@IdCiclo
	WHERE
	IdUndDidacP=@IdUndDidacP
	GO
	
	CREATE PROCEDURE [dbo].[EliminarUDP] 
	
	@IdUndDidacP char(4)
	AS
	delete from UndDidactica_Profesional
	where IdUndDidacP =@IdUndDidacP 
	GO
	
	--PROCEDIMIENTOS PARA TABLA UND. DIDACTICA TRANSVERSAL
	
	CREATE PROCEDURE [dbo].[MostrarUDT] 
	AS
	select * from UndDidactica_Transversal ORDER BY IdUndDidacT	
	GO

	create PROCEDURE [dbo].[GuardarUDT]
	@IdUndDidacT         char(4)   ,
	@Nom_UndDidactica   varchar(100)  ,
	@Credito            int   ,
	@Horas              int   ,
	@IdModuloT           char(3)   ,
	@IdCiclo            char(3) 
	
	
	AS
	insert into UndDidactica_Transversal(Nom_UndDidactica,IdUndDidacT,Credito,Horas,IdModuloT,IdCiclo)
	values (@Nom_UndDidactica,@IdUndDidacT,@Credito,@Horas,@IdModuloT,@IdCiclo)
	GO

	CREATE PROCEDURE [dbo].[BuscarUDT]

	@IdUndDidacT char(4),
	@IdEspecialidad char(3)
	as
	select*from UndDidactica_Transversal
	where IdUndDidacT=@IdUndDidacT and IdEspecialidad=@IdEspecialidad
	GO

	CREATE PROCEDURE [dbo].[ModificarUDT]
		
	@Nom_UndDidactica   varchar(100)  ,
	@Credito            int   ,
	@Horas              int   ,
	@IdUndDidacT         char(4)   ,
	@IdModuloT           char(3)   ,
	@IdCiclo            char(3) 
	AS
	update UndDidactica_Transversal
	
	SET 
	Nom_UndDidactica=@Nom_UndDidactica,
	Credito=@Credito,
	Horas=@Horas,
	IdUndDidacT=@IdUndDidacT,
	IdModuloT=@IdModuloT,
	IdCiclo=@IdCiclo
	WHERE
	IdUndDidacT=@IdUndDidacT
	GO
	
	CREATE PROCEDURE [dbo].[EliminarUDT] 
	
	@IdUndDidacT char(4)
	AS
	delete from UndDidactica_Transversal
	where IdUndDidacT =@IdUndDidacT 
	GO
	
	
	

	