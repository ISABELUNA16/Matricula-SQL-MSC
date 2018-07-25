use MATRICULA
GO

create procedure vmoduloP
  @idespecialidad  char(3), @AÑO_MODULO CHAR(4) 
  AS SELECT idmoduloP, nom_modulo
FROM Modulo_Profesional
WHERE IdEspecialidad =@IdEspecialidad AND Año_Modulo=@AÑO_MODULO
GO

create procedure vmoduloT
  @idespecialidad  char(3), @AÑO_MODULO CHAR(4) 
  AS SELECT idmoduloT, nom_modulo
FROM Modulo_Transversal
WHERE IdEspecialidad =@IdEspecialidad AND Año_Modulo=@AÑO_MODULO
GO

CREATE procedure vUNDDIDAC
  @idespecialidad  char(3), @AÑO_MODULO CHAR(4), @IDMODULOP CHAR(3), @IDCICLO CHAR(3)
   AS SELECT IdUndDidac, Nom_UndDidactica
FROM UndDidactica
WHERE IdEspecialidad =@IdEspecialidad AND Año_Modulo=@AÑO_MODULO 
AND IDCICLO=@IDCICLO AND IdModuloP=@IDMODULOP 
GO



CREATE PROCEDURE VALUMNO
@idespecialidad  char(3), @IDSEMESTRE CHAR(6), @IDCICLO CHAR(3), @IDTURNO CHAR(1)
   AS SELECT ALUMNO.APE_PATERNO,ALUMNO.Ape_Materno, ALUMNO.Nom_Alumno, NOTAS.NOTA_FINAL
FROM ALUMNO, MATRICULA,NOTAS
WHERE MATRICULA.IdEspecialidad =@IdEspecialidad  
 AND MATRICULA.IdCiclo=@IDCICLO AND MATRICULA.IdTurno=@IDTURNO AND Matricula.IdSemestre=@IDSEMESTRE
GO

