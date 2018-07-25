ALTER proc [dbo].[buscar_empleados_nombre]
@Ape varchar(60)
as
select CodEmpleado as Código,Apellidos,Nombres,NombreCargo 
as cargo,Tratamiento,FechaNacimiento,FechaContratacion,Direccion,NombreDistrito 
as Distrito,NombrePais as Pais,Telefono from Empleados
inner join dbo.cargos on dbo.Empleados.CodCargo=dbo.cargos.CodCargo inner join dbo.Distritos 
on Empleados.CodDistrito=Distritos.CodDistrito inner join Paises on Empleados.CodPais=Paises.Codpais
where Apellidos like @Ape +'%'





--select a.codalu,a.nombre,a.ape,M.fecMat,C.DesCiclo from alumnos inner join matricula on alumnos.codMat=Matricla.codMat
--inner join Ciclos on Alumnos.CodCiclo=Ciclos.codCiclo
--tiene q ser algo asi...
--a representa a la tabla alumno....