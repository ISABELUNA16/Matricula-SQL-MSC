use matricula
GO
CREATE procedure insertaralumno
	@IdAlumno           char(8)   ,
	@IdDistrito         char(3)   ,
	@IdTipo             char(3)   ,
	@IdUsuario          char(5)   ,
	@IdEspecialidad     char(3)   ,
	@Ape_paterno        varchar(30)   ,
	@Ape_Materno        varchar(30)   ,
	@Nom_Alumno         varchar(30)   ,
	@Fecha_Nac          date   ,
	@Distrito_Nac		 varchar(30) ,
	@Provincia_Nac		 varchar(30) ,
	@Departamento_Nac	varchar(30) ,
	@Edad				 char(3),
	@Sexo_Alumno        char(1)   ,
	@Estado_Civil		 varchar(15),
	@Dirección          varchar(50)   ,
	@Telef_Alumno       varchar(9)   ,
	@Nombre_IE			 varchar(50) ,
	@AñoEgreso_IE		 char(4) ,
	@Nom_Especialidad   varchar(30)   ,
	@Trabaja			 char(1) ,
	@CentroTrabajo		 varchar(100) ,
	@Func_Trabajo		 varchar(100) ,
	@Nom_Turno			 varchar(10) ,
	@E_Mail             varchar(30)  ,
	@Estudia			 char(1) ,
	@Estudia_Especialidad varchar(100) ,
	@foto			nvarchar(max) ,
	@Año_Ingreso        char(4)  ,	
	@Ape_pat_padre      varchar(30)   ,
	@Ape_mat_padre      varchar(30)   ,
	@Nom_padre     nvarchar(30)   ,
	@dni_padre      char(8)   ,
	@Ocupacion_padre      varchar(30)   ,
	@Domicilio_padre      varchar(30)   ,
	@Telef_padre     char(9)   ,
	@Ape_pat_madre      varchar(30)   ,
	@Ape_mat_madre      varchar(30)   ,
	@Nom_madre      nvarchar(30)   ,
	@dni_madre      char(8)   ,
	@Ocupacion_madre      varchar(30)  ,
	@Domicilio_madre      varchar(30)   ,
	@Telef_madre      char(9)   	
	as
	insert into ALUMNO(
	IdAlumno,
	IdDistrito,
	IdTipo ,
	IdUsuario ,
	IdEspecialidad ,
	Ape_paterno   ,
	Ape_Materno ,
	Nom_Alumno ,
	Fecha_Nac  ,
	Distrito_Nac ,
	Provincia_Nac,
	Departamento_Nac,
	Edad	,
	Sexo_Alumno  ,
	Estado_Civil	,
	Dirección  ,
	Telef_Alumno ,
	Nombre_IE ,
	AñoEgreso_IE	,
	Nom_Especialidad ,
	Trabaja,
	CentroTrabajo,
	Func_Trabajo,
	Nom_Turno,
	E_Mail ,
	Estudia	,
	Estudia_Especialidad ,
	foto	,
	Año_Ingreso ,	
	Ape_pat_padre  ,
	Ape_mat_padre  ,
	Nom_padre ,
	dni_padre ,
	Ocupacion_padre ,
	Domicilio_padre ,
	Telef_padre  ,
	Ape_pat_madre,
	Ape_mat_madre ,
	Nom_madre ,
	dni_madre,
	Ocupacion_madre ,
	Domicilio_madre ,
	Telef_madre )
	VALUES (@IdAlumno,
	@IdDistrito,
	@IdTipo ,
	@IdUsuario ,
	@IdEspecialidad ,
	@Ape_paterno   ,
	@Ape_Materno ,
	@Nom_Alumno ,
	@Fecha_Nac  ,
	@Distrito_Nac ,
	@Provincia_Nac,
	@Departamento_Nac,
	@Edad	,
	@Sexo_Alumno  ,
	@Estado_Civil	,
	@Dirección  ,
	@Telef_Alumno ,
	@Nombre_IE ,
	@AñoEgreso_IE	,
	@Nom_Especialidad ,
	@Trabaja,
	@CentroTrabajo,
	@Func_Trabajo,
	@Nom_Turno,
	@E_Mail ,
	@Estudia	,
	@Estudia_Especialidad ,
	@foto	,
	@Año_Ingreso ,	
	@Ape_pat_padre  ,
	@Ape_mat_padre  ,
	@Nom_padre ,
	@dni_padre ,
	@Ocupacion_padre ,
	@Domicilio_padre ,
	@Telef_padre  ,
	@Ape_pat_madre,
	@Ape_mat_madre ,
	@Nom_madre ,
	@dni_madre,
	@Ocupacion_madre ,
	@Domicilio_madre ,
	@Telef_madre )
GO

SELECT * FROM ALUMNO
GO

CREATE PROCEDURE mostraralumno 
	AS
select * from Alumno ORDER BY Año_Ingreso
GO


CREATE PROCEDURE modificaralumno
	
	@IdAlumno           char(8)   ,
	@IdDistrito         char(3)   ,
	@IdTipo             char(3)   ,
	@IdUsuario          char(5)   ,
	@IdEspecialidad     char(3)   ,
	@Ape_paterno        varchar(30)   ,
	@Ape_Materno        varchar(30)   ,
	@Nom_Alumno         varchar(30)   ,
	@Fecha_Nac          date   ,
	@Distrito_Nac		 varchar(30) ,
	@Provincia_Nac		 varchar(30) ,
	@Departamento_Nac	varchar(30) ,
	@Edad				 char(3),
	@Sexo_Alumno        char(1)   ,
	@Estado_Civil		 varchar(15),
	@Dirección          varchar(50)   ,
	@Telef_Alumno       varchar(9)   ,
	@Nombre_IE			 varchar(50) ,
	@AñoEgreso_IE		 char(4) ,
	@Nom_Especialidad   varchar(30)   ,
	@Trabaja			 char(1) ,
	@CentroTrabajo		 varchar(100) ,
	@Func_Trabajo		 varchar(100) ,
	@Nom_Turno			 varchar(10) ,
	@E_Mail             varchar(30)  ,
	@Estudia			 char(1) ,
	@Estudia_Especialidad varchar(100) ,
	@foto			nvarchar(max) ,
	@Año_Ingreso        char(4)  ,	
	@Ape_pat_padre      varchar(30)   ,
	@Ape_mat_padre      varchar(30)   ,
	@Nom_padre     nvarchar(30)   ,
	@dni_padre      char(8)   ,
	@Ocupacion_padre      varchar(30)   ,
	@Domicilio_padre      varchar(30)   ,
	@Telef_padre     char(9)   ,
	@Ape_pat_madre      varchar(30)   ,
	@Ape_mat_madre      varchar(30)   ,
	@Nom_madre      nvarchar(30)   ,
	@dni_madre      char(8)   ,
	@Ocupacion_madre      varchar(30)  ,
	@Domicilio_madre      varchar(30)   ,
	@Telef_madre      char(9)  

AS
update Alumno
	
	SET 
	IdDistrito=@IdDistrito,
	IdTipo=@IdTipo ,
	IdUsuario=@IdUsuario ,
	IdEspecialidad=@IdEspecialidad ,
	Ape_paterno=@Ape_Materno  ,
	Ape_Materno =@Ape_Materno,
	Nom_Alumno=@Nom_Alumno ,
	Fecha_Nac=@Fecha_Nac  ,
	Distrito_Nac=@Distrito_Nac ,
	Provincia_Nac=@Provincia_Nac,
	Departamento_Nac=@Departamento_Nac,
	Edad=@Edad	,
	Sexo_Alumno =@Sexo_Alumno ,
	Estado_Civil=@Estado_Civil	,
	Dirección =@Dirección ,
	Telef_Alumno=@Telef_Alumno ,
	Nombre_IE =@Nombre_IE,
	AñoEgreso_IE=@AñoEgreso_IE,
	Nom_Especialidad=@Nom_Especialidad ,
	Trabaja=@Trabaja,
	CentroTrabajo=@CentroTrabajo,
	Func_Trabajo=@Func_Trabajo,
	Nom_Turno=@Nom_Turno,
	E_Mail =@E_Mail,
	Estudia=@Estudia,
	Estudia_Especialidad=@Estudia_Especialidad ,
	foto=@foto,
	Año_Ingreso=@Año_Ingreso ,	
	Ape_pat_padre =@Ape_pat_padre ,
	Ape_mat_padre =@Ape_mat_padre ,
	Nom_padre=@Nom_padre ,
	dni_padre=@dni_padre ,
	Ocupacion_padre =@Ocupacion_padre,
	Domicilio_padre=@Domicilio_padre ,
	Telef_padre =@Telef_padre ,
	Ape_pat_madre=@Ape_pat_madre,
	Ape_mat_madre=@Ape_mat_madre ,
	Nom_madre=@Nom_madre ,
	dni_madre=@dni_madre,
	Ocupacion_madre=@Ocupacion_madre ,
	Domicilio_madre=Domicilio_madre ,
	Telef_madre =@Telef_madre        			
	WHERE
	IdAlumno=@IdAlumno
	GO
	
create PROCEDURE buscaralumno

@IdAlumno char(8)
as
select*from Alumno
where IdAlumno=@IdAlumno
GO


create PROCEDURE eliminaralumno
	
	@Idalumno char(8)
AS
delete from alumno
where Idalumno=@Idalumno
go



create procedure registrarusuario

@Seudonimo varchar (20),
@Clave varchar(20)
as
select*  from Usuario
where Seudonimo=@Seudonimo and Clave=@Clave
go

----PROCEDIMIENTOS PARA TABLA MATRICULA

CREATE procedure insertarMATRICULA
@IDMATRICULA CHAR(7),
@IdAlumno char(8),
@IDESPECIALIDAD char(3),
@IDSEMESTRE char(6),
@IDTURNO CHAR(1),
@año_modulo char(4),
@IDUSUARIO CHAR(5),
@IDCICLO CHAR(3),
@Fecha_matricula date,
@Descripcion varchar(30) 


as 
insert into Matricula(IdMatricula,IdAlumno, IdEspecialidad,IdSemestre,IdTurno,
 año_modulo, IdUsuario,IDCICLO,Fecha_matricula,Descripcion )
values (@IdMatricula, @IdAlumno, @IdEspecialidad, @IdSemestre,@IdTurno,
@año_modulo, @IdUsuario,@IDCICLO, @Fecha_matricula,@Descripcion)
go

create PROCEDURE buscarMATRICULA
@IdAlumno char(8)
as
select*from matricula
where IdAlumno=@IdAlumno
GO



CREATE PROCEDURE [dbo].[Modificarmatricula]
	
@IdAlumno char(8),	
@IDESPECIALIDAD char(3),
@IDSEMESTRE char(6),
@IDTURNO CHAR(1),
@año_modulo char(4),
@IDCICLO CHAR(3),
@Fecha_matricula date,
@Descripcion varchar(30) 
AS
update matricula
	SET 
idalumno=@IDalumno,
Idespecialidad=@IDESPECIALIDAD,
Idsemestre=@IDSEMESTRE,
Idturno=@IDTURNO,
Año_modulo=@año_modulo,
IdCiclo=@IDCICLO,
Fecha_matricula=@Fecha_matricula,
Descripcion=@Descripcion

	WHERE
Idalumno=@Idalumno
GO

create PROCEDURE [dbo].[EliminarMatricula] 
	@IDMATRICULA CHAR(7)
AS
delete from matricula
where Idmatricula=@IDMATRICULA
go

--alter PROCEDURE dbo.Mostrarnomalumno
--	AS 
--select alumno.Ape_paterno, alumno.Ape_Materno, alumno.Nom_Alumno  from alumno  
----WHERE ape_paterno LIKE '[a-z]%'
--go


--create procedure insertarNOTAS
--@IdAlumno char(8),
--@IDESPECIALIDAD CHAR(3),
--@IDMODULO CHAR(3),
--@IDCICLO CHAR(3),
--@IDUNDDIDAC CHAR(3),
----@idsemestre char(6),
--@AÑO_MODULO CHAR(3),
--@IDTURNO CHAR(1),
--@NOTA_FINAL CHAR(2),
--@IDUSUARIO CHAR(5),
--@IDDOCENTE CHAR(5)

--as 
--insert into Notas(IdAlumno,IdEspecialidad,IdModulo,IDCICLO, IdUndDidac ,Año_Modulo,IDTURNO,Nota_Final,IdUsuario,IdDocente)
--VALUES (@IdAlumno,@IDESPECIALIDAD,@IDMODULO,@IDCICLO,@IDUNDDIDAC, @AÑO_MODULO,@IDTURNO,@NOTA_FINAL,@IDUSUARIO,@IDDOCENTE)
--go

--USE MATRICULA
--SELECT*FROM Alumno
--select *from Matricula
--delete Matricula where IdMatricula='0008-11'