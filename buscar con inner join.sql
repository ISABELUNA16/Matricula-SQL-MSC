
SELECT *FROM Matricula
GO


USE MATRICULA
GO

alter PROCEDURE [dbo].[VERLISTALUMNOS]
@Nom_Especialidad  varchar(30),
@IdTurno varchar(10),
@IdSemestre  char(6),
@Numero   char(3)
as
SELECT
Matricula.IdAlumno,Matricula.idMatricula,Matricula.IdTurno,
alumno.Ape_Paterno,alumno.Ape_Materno,alumno.Nom_Alumno,alumno.nom_especialidad,
ciclo.numero
FROM
Alumno INNER JOIN Matricula 
on Alumno.IdAlumno=Matricula.IdAlumno
INNER JOIN Ciclo
on Matricula.IdCiclo=Ciclo.IdCiclo  
WHERE
Alumno.Nom_Especialidad=@Nom_Especialidad AND
Matricula.IdTurno=@IdTurno AND
Matricula.IdSemestre=@IdSemestre AND
Ciclo.Numero=@Numero
GO




SELECT
Matricula.IdAlumno,Matricula.idMatricula,
alumno.Ape_Paterno,alumno.Ape_Materno,alumno.Nom_Alumno,alumno.nom_especialidad,alumno.nom_turno,
ciclo.numero
FROM
Alumno INNER JOIN Matricula 
on Alumno.IdAlumno=Matricula.IdAlumno
INNER JOIN Ciclo
on Matricula.IdCiclo=Ciclo.IdCiclo  
WHERE
Alumno.Nom_Especialidad='Computación e Informática'AND
Alumno.Nom_Turno='Dia'AND
Matricula.IdSemestre='2011-1'AND
Ciclo.Numero='I'
GO



create PROCEDURE [dbo].[VALUMNO]
@Nom_Especialidad  varchar(30),
@IdTurno varchar(10),
@IdSemestre  char(6),
@Numero   char(3)
as
SELECT
Matricula.IdAlumno,Matricula.idMatricula,
alumno.Ape_Paterno,alumno.Ape_Materno,alumno.Nom_Alumno,
Notas.Nota_Final,Notas.Observación
FROM
Alumno INNER JOIN Matricula 
on Alumno.IdAlumno=Matricula.IdAlumno
INNER JOIN Notas
on Matricula.IdMatricula=Notas.IdMatricula
INNER JOIN Ciclo
on Notas.IDCICLO,Ciclo.Idciclo 
WHERE
Alumno.Nom_Especialidad=@Nom_Especialidad AND
Matricula.IdTurno=@IdTurno AND
Matricula.IdSemestre=@IdSemestre AND
Ciclo.Numero=@Numero
GO

USE MATRICULA
SELECT * FROM MATRICULA
SELECT * FROM Alumno