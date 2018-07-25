use master 
create database MATRICULA
use MATRICULA
GO

CREATE TABLE [Alumno]
( 
	[IdAlumno]           char(8)  NOT NULL ,
	[IdDistrito]         char(3)  NULL ,
	[IdTipo]             char(3)  NULL ,
	[IdUsuario]          char(5)  NULL ,
	[IdEspecialidad]     char(3)  NULL ,
	[Ape_paterno]        varchar(30)  NULL ,
	[Ape_Materno]        varchar(30)  NULL ,
	[Nom_Alumno]         varchar(30)  NULL ,
	[Fecha_Nac]          date  NULL ,
	[Distrito_Nac]		 varchar(30) NULL,
	[Provincia_Nac]		 varchar(30) NULL,
	[Departamento_Nac]	varchar(30) NULL,
	[Edad]				 char(3),
	[Sexo_Alumno]        char(1)  NULL ,
	[Estado_Civil]		 varchar(15),
	[DirecciÛn]          varchar(50)  NULL ,
	[Telef_Alumno]       varchar(9)  NULL ,
	[Nombre_IE]			 varchar(50) NULL,
	[AÒoEgreso_IE]		 char(4) NULL,
	[Nom_Especialidad]   varchar(30)  NULL ,
	[Trabaja]			 char(1) NULL,
	[CentroTrabajo]		 varchar(100) NULL,
	[Func_Trabajo]		 varchar(100) NULL,
	[Nom_Turno]			 varchar(10) NULL,
	[E_Mail]             varchar(30)  NULL,
	[Estudia]			 char(1) NULL,
	[Estudia_Especialidad] varchar(100) NULL,
	--[Observacion]        varchar(50)  NULL,
	[foto]				nvarchar(max) NULL,
	[AÒo_Ingreso]        char(4)null,	
	[Ape_pat_padre]      varchar(30)  NULL ,
	[Ape_mat_padre]      varchar(30)  NULL ,
	[Nom_padre]      nvarchar(30)  NULL ,
	[dni_padre]      char(8)  NULL ,
	[Ocupacion_padre]      varchar(30)  NULL ,
	[Domicilio_padre]      varchar(30)  NULL ,
	[Telef_padre]      char(9)  NULL ,
	[Ape_pat_madre]      varchar(30)  NULL ,
	[Ape_mat_madre]      varchar(30)  NULL ,
	[Nom_madre]      nvarchar(30)  NULL ,
	[dni_madre]      char(8)  NULL ,
	[Ocupacion_madre]      varchar(30)  NULL ,
	[Domicilio_madre]      varchar(30)  NULL ,
	[Telef_madre]      char(9)  NULL ,
)
go

ALTER TABLE [Alumno]
	ADD CONSTRAINT [XPKAlumno] PRIMARY KEY  NONCLUSTERED ([IdAlumno] ASC)
go

CREATE TABLE [Ciclo]
( 
	[IdCiclo]            char(3)  NOT NULL ,
	[Nom_Ciclo]          varchar(10)  NULL ,
	[Numero]             char(3)  NULL 
)
go

ALTER TABLE [Ciclo]
	ADD CONSTRAINT [XPKCiclo] PRIMARY KEY  NONCLUSTERED ([IdCiclo] ASC)
go

CREATE TABLE [Distrito]
( 
	[IdDistrito]         char(3)  NOT NULL ,
	[Nom_Distrito]       varchar(30)  NULL 
)
go

ALTER TABLE [Distrito]
	ADD CONSTRAINT [XPKDistrito] PRIMARY KEY  NONCLUSTERED ([IdDistrito] ASC)
go

CREATE TABLE Docente
( 
	[IdDocente]          char(5)  NOT NULL ,
	[Nom_Docente]        varchar(30)  NULL ,
	[Ape_Docente]        varchar(30)  NULL ,
	[Grado]              varchar(20)  NULL ,
	[Titulo]             varchar(30)  NULL ,
	[Maestria]           varchar(30)  NULL ,
	[Doctorado]          varchar(30)  NULL ,
	[Foto]               nvarchar(max)  NULL ,
	[Dni_Docente]        char(8)   NULL ,
	[Email_Docente]      varchar(30)  NULL ,
	[Tel_Docente]        varchar(9)  NULL ,
	[Dir_Docente]        varchar(50)  NULL ,
	[Fec_Nac_Docente]    date  NULL ,
	[Sex_Docente]        char(1) NULL ,
	[IdUsuario]          varchar(5)  NULL 
)
go


ALTER TABLE [Docente]
	ADD CONSTRAINT [XPKDocente] PRIMARY KEY  NONCLUSTERED ([IdDocente] ASC)
go

CREATE TABLE [Especialidad]
( 
	[IdEspecialidad]     char(3)  NOT NULL ,
	[Nom_Especialidad]   varchar(30)  NULL 
)
go

ALTER TABLE [Especialidad]
	ADD CONSTRAINT [XPKEspecialidad] PRIMARY KEY  NONCLUSTERED ([IdEspecialidad] ASC)
go



create TABLE [Matricula]
( 
	[IdMatricula]        char(7)  NOT NULL ,
	[IdAlumno]           char(8)  NULL ,
	[IdEspecialidad]     char(3)  not NULL ,
	[IdSemestre]         char(6)  not NULL ,
	[IdTurno]            char(1)  NULL ,
	[AÒo_Modulo]		 char(4) null,
	[IdUsuario]          char(5)  NULL ,
	[IdCiclo]			 char(3)  not null,
	[Fecha_matricula]	 date null,
	[Descripcion]        varchar(30)  NULL 
)
go

ALTER TABLE [Matricula]
	ADD CONSTRAINT [XPKMatricula] PRIMARY KEY  NONCLUSTERED ([IdMatricula] ASC, [Idciclo] asc,[Idespecialidad] asc)
go


CREATE TABLE [Modulo_Profesional]
( 	
	[IdModuloP]          char(4)  NOT NULL ,
	[IdEspecialidad]     char(3)  NOT NULL ,
	[AÒo_Modulo]         char(4)  NOT NULL ,
	[Nom_Modulo]         varchar(100)  NULL ,
	[IdUsuario]          char(5)  NULL 
)
go
SELECT * FROM Modulo_Profesional 


ALTER TABLE [Modulo_Profesional]
	ADD CONSTRAINT [XPKModulo_Profesional] PRIMARY KEY  NONCLUSTERED ([IdModuloP] ASC,[IdEspecialidad]ASC,[AÒo_Modulo]ASC)
go

CREATE TABLE [Modulo_Transversal]
( 
	[IdModuloT]          char(4)  NOT NULL ,
	[IdEspecialidad]     char(3)  NOT NULL ,
	[AÒo_Modulo]         char(4)  NOT NULL ,
	[Nom_Modulo]         varchar(100)  NULL ,
	[IdUsuario]          char(5)  NULL 
)
go

ALTER TABLE [Modulo_Transversal]
	ADD CONSTRAINT [XPKModulo_Transversal] PRIMARY KEY  NONCLUSTERED ([IdModuloT] ASC,[IdEspecialidad]ASC,[AÒo_Modulo]ASC)
go

CREATE TABLE [Notas]
( 
	[IdAlumno]			 char(8) NOT NULL,
	[IdEspecialidad]	 char(3) not null,	
	[IdSemestre]         char(6)  NOT NULL ,
	[IdUndDidacP]         char(4) NULL ,
	[IdUndDidacT]         char(4) NULL ,
	[AÒo_Modulo]		 char(4) not null,
	[IdModuloP]          char(4)  NOT NULL ,
	[IdModuloT]          char(4)  NOT NULL ,
	[IDCICLO]            CHAR(3) NOT NULL,
	[IDTURNO]			 CHAR(1) NOT NULL,
	[Nota_Final]         char(2)  NULL ,
	[Nota_Recupera]      char(2)  NULL ,
	[Nota_Repitencia]	 char(2)  null,
	[IdUsuario]          char(5)  NULL ,
	[IdDocente]          char(5)  NULL ,
	[Cod_Documento]      varchar(30)  NULL,
	[ObservaciÛn]		 varchar(100) NULL
	
)
go

ALTER TABLE [Notas]
	ADD CONSTRAINT [XPKNotas] PRIMARY KEY  NONCLUSTERED ([IdaLUMNO] ASC,[IdSemestre],[IdEspecialidad] asc,[AÒo_Modulo]ASC, [IDTURNO]ASC, [IDCICLO] ASC)
go

CREATE TABLE [Semestre]
( 
	[IdSemestre]         char(6)  NOT NULL ,
	[Fecha_Inicio]       date  NULL ,
	[Fecha_Fin]          date  NULL 
)
go
SELECT *FROM Semestre
ALTER TABLE [Semestre]
	ADD CONSTRAINT [XPKSemestre] PRIMARY KEY  NONCLUSTERED ([IdSemestre] ASC)
go

CREATE TABLE [TipoIngreso]
( 
	[IdTipo]             char(3)  NOT NULL ,
	[Descripcion]        varchar(30)  NULL 
)
go

ALTER TABLE [TipoIngreso]
	ADD CONSTRAINT [XPKTipoIngreso] PRIMARY KEY  NONCLUSTERED ([IdTipo] ASC)
go

CREATE TABLE [Turno]
( 
	[IdTurno]            char(1)  NOT NULL ,
	[Nom_Turno]          varchar(10)  NULL 
)
go
select * from turno

ALTER TABLE [Turno]
	ADD CONSTRAINT [XPKTurno] PRIMARY KEY  NONCLUSTERED ([IdTurno] ASC)
go

CREATE TABLE [UndDidactica_Profesional]
( 
	[IdUndDidacP]         char(4)  NOT NULL ,
	[IdEspecialidad]     char(3)  not NULL,
	[IdModuloP]          char(4)  not NULL ,
	[AÒo_Modulo]         char(4)  NOT NULL ,
	[Nom_UndDidactica]   varchar(100)  NULL ,
	[Horas]              int  NULL ,
	[Credito]            REAL  NULL ,
	[IdCiclo]            char(3)  NULL 
	)
go
select * from UndDidactica_Profesional 
select * from UndDidactica_Transversal  


ALTER TABLE [UndDidactica_Profesional]
	ADD CONSTRAINT [XPKUdDidacticaP] PRIMARY KEY  NONCLUSTERED ([IdUndDidacP] ASC,[IdmoduloP]ASC,[IdEspecialidad] ASC,[a—O_MODULO]ASC )
go
CREATE TABLE [UndDidactica_Transversal]
( 
	[IdUndDidacT]         char(4)  NOT NULL ,
	[IdEspecialidad]     char(3)  not NULL,
	[IdModuloT]          char(4)  not NULL ,
	[AÒo_Modulo]         char(4)  NOT NULL ,
	[Nom_UndDidactica]   varchar(100)  NULL ,
	[Horas]              int  NULL ,
	[Credito]            REAL  NULL ,
	[IdCiclo]            char(3)  NULL 
	)
go


ALTER TABLE [UndDidactica_Transversal]
	ADD CONSTRAINT [XPKUdDidacticaT] PRIMARY KEY  NONCLUSTERED ([IdUndDidacT] ASC,[IdModuloT] asc,[IdEspecialidad] ASC,[a—O_MODULO]ASC )
go

--CREATE TABLE [UndDidactica_Prof]
--( 
	
--	[IdUndDidac]         char(4)  NOT NULL ,
--	[IdEspecialidad]     char(3)  not NULL,
--	[IdModuloP]           char(4)  NOT NULL ,
--	[IdModuloT]           char(4)  NOT NULL ,
--	[AÒo_Modulo]         char(4)  NOT NULL ,
--	[Nom_UndDidacProf]   varchar(100)  NULL ,
--	[Credito]            int  NULL ,
--	[Horas]              int  NULL ,
--	[IdCiclo]            char(3)  NULL ,
	
--)
--go
select * from UndDidactica_Profesional 

--ALTER TABLE [UndDidactica_Prof]
--	ADD CONSTRAINT [XPKUnDidactica_Prof] PRIMARY KEY  NONCLUSTERED ([IdUndDidac] ASC,[IdModulo] ASC,[IdEspecialidad] ASC, [a—O_MODULO]ASC)
--go

--CREATE TABLE [UndDidactica_Trans]
--( 
--[IdUndDidac]         char(4)  NOT NULL ,
--	[IdModuloP]           char(4)  NOT NULL ,
--	[IdModuloT]           char(4)  NOT NULL ,
--	[AÒo_Modulo]         char(4)  NOT NULL ,
--	[Nom_UndDidacTrans]  varchar(100)  NULL ,
--	[Horas]              int  NULL ,
--	[Credito]            int  NULL ,
--	[IdCiclo]            char(3)  NULL ,
	
--)
--go

--ALTER TABLE [UndDidactica_Trans]
--	ADD CONSTRAINT [XPKUndDidacticaTrans] PRIMARY KEY  NONCLUSTERED ([IdUndDidac] ASC,[IdModulo] ASC,[a—O_MODULO]ASC)
--go

CREATE TABLE [Usuario]
( 
	[IdUsuario]          char(5)  NOT NULL ,
	[Nom_Usuario]        varchar(30)  NULL ,
	[Ape_Usuario]        varchar(30)  NULL ,
	[Nivel]              varchar(10)  NULL ,
	[Mensaje]            varchar(50)  NULL ,
	[Seudonimo]          varchar(20)  NULL ,
	[Clave]              varchar(20)  NULL 
)
go

ALTER TABLE [Usuario]
	ADD CONSTRAINT [XPKUsuario] PRIMARY KEY  NONCLUSTERED ([IdUsuario] ASC)
go


ALTER TABLE [Alumno]
	ADD CONSTRAINT [R_1] FOREIGN KEY ([IdDistrito]) REFERENCES [Distrito]([IdDistrito])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Alumno]
	ADD CONSTRAINT [R_2] FOREIGN KEY ([IdUsuario]) REFERENCES [Usuario]([IdUsuario])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Alumno]
	ADD CONSTRAINT [R_3] FOREIGN KEY ([IdTipo]) REFERENCES [TipoIngreso]([IdTipo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [Matricula]
	ADD CONSTRAINT [R_4] FOREIGN KEY ([IdSemestre]) REFERENCES [Semestre]([IdSemestre])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Matricula]
	ADD CONSTRAINT [R_5] FOREIGN KEY ([IdTurno]) REFERENCES [Turno]([IdTurno])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Matricula]
	ADD CONSTRAINT [R_6] FOREIGN KEY ([IdEspecialidad]) REFERENCES [Especialidad]([IdEspecialidad])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Matricula]
	ADD CONSTRAINT [R_7] FOREIGN KEY ([IdAlumno]) REFERENCES [Alumno]([IdAlumno])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Matricula]
	ADD CONSTRAINT [R_8] FOREIGN KEY ([IdUsuario]) REFERENCES [Usuario]([IdUsuario])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

--ALTER TABLE [Matricula]
--	ADD CONSTRAINT [R_35] FOREIGN KEY ([IdModulo],[IdEspecialidad], [AÒo_Modulo]) REFERENCES [Modulo]([IdModulo],[IdEspecialidad],[AÒo_Modulo])
--		ON DELETE NO ACTION
--		ON UPDATE NO ACTION
--go



--ALTER TABLE [Modulo]
--	ADD CONSTRAINT [R_14] FOREIGN KEY ([IdEspecialidad]) REFERENCES [Especialidad]([IdEspecialidad])
--		ON DELETE NO ACTION
--		ON UPDATE NO ACTION
--go

--ALTER TABLE [Modulo]
--	ADD CONSTRAINT [R_16] FOREIGN KEY ([IdUsuario]) REFERENCES [Usuario]([IdUsuario])
--		ON DELETE NO ACTION
--		ON UPDATE NO ACTION
--go


--ALTER TABLE [Modulo_Profesional]
--	ADD CONSTRAINT [R_131] FOREIGN KEY ([IdModulo],[IdEspecialidad],[AÒo_Modulo]) REFERENCES [Modulo]([IdModulo],[IdEspecialidad],[AÒo_Modulo])
--		ON DELETE NO ACTION
--		ON UPDATE NO ACTION
--go


--ALTER TABLE [Modulo_Tranversal]
--	ADD CONSTRAINT [R_128] FOREIGN KEY ([IdModulo],[IdEspecialidad],[AÒo_Modulo]) REFERENCES [Modulo]([IdModulo],[IdEspecialidad],[AÒo_Modulo])
--		ON DELETE NO ACTION
--		ON UPDATE NO ACTION
--go


--ALTER TABLE [Notas]
--	ADD CONSTRAINT [R_66] FOREIGN KEY ([IdUNDDIDAC]) REFERENCES [UNDDIDACTICA]([IdUNDDIDAC])
--		ON DELETE NO ACTION
--		ON UPDATE NO ACTION
--go
ALTER TABLE [Notas]
	ADD CONSTRAINT  [R_9]FOREIGN KEY ([IdTURNO]) REFERENCES [TURNO]([IdTURNO])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Notas]
	ADD CONSTRAINT [R_10a] FOREIGN KEY ([IdUndDidacP], [IDMODULOP],[IdEspecialidad],[AÒo_Modulo])
	 REFERENCES [UndDidacTICA_Profesional]([IdUndDidacP],[IDMODULOP],[IdEspecialidad],[AÒo_Modulo]) 
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Notas]
	ADD CONSTRAINT [R_10b] FOREIGN KEY ([IdUndDidacT], [IDMODULOT],[IdEspecialidad],[AÒo_Modulo])
	 REFERENCES [UndDidacTICA_Transversal]([IdUndDidacT],[IDMODULOT],[IdEspecialidad],[AÒo_Modulo]) 
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Notas]
	ADD CONSTRAINT [R_11] FOREIGN KEY ([IdUsuario]) REFERENCES [Usuario]([IdUsuario])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Notas]
	ADD CONSTRAINT [R_12] FOREIGN KEY ([IdDocente]) REFERENCES [Docente]([IdDocente])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [UndDidactica_Profesional]
	ADD CONSTRAINT [R_13] FOREIGN KEY ([IdModuloP],[IdEspecialidad],[AÒo_Modulo]) 
	REFERENCES [Modulo_Profesional]([IdModuloP],[IdEspecialidad],[AÒo_Modulo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [UndDidactica_transversal]
	ADD CONSTRAINT [R_14] FOREIGN KEY ([IdModuloT],[IdEspecialidad],[AÒo_Modulo]) 
	REFERENCES [Modulo_Transversal]([IdModuloT],[IdEspecialidad],[AÒo_Modulo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [UndDidactica_Profesional]
	ADD CONSTRAINT [R_15a] FOREIGN KEY ([IdCiclo]) REFERENCES [Ciclo]([IdCiclo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
ALTER TABLE [UndDidactica_transversal]
	ADD CONSTRAINT [R_15b] FOREIGN KEY ([IdCiclo]) REFERENCES [Ciclo]([IdCiclo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
ALTER TABLE [Matricula]
	ADD CONSTRAINT [R_16] FOREIGN KEY ([Idciclo]) REFERENCES [Ciclo]([Idciclo])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

--ALTER TABLE [UndDidactica_Prof]
--	ADD CONSTRAINT [R_61] FOREIGN KEY ([IdUndDidac],[IdModulo], [IdEspecialidad],[AÒo_Modulo]) REFERENCES [UndDidactica]([IdUndDidac],[IdModulo],[IdEspecialidad],[AÒo_Modulo])
--		ON DELETE NO ACTION
--		ON UPDATE NO ACTION
--go


--ALTER TABLE [UndDidactica_Trans]
--	ADD CONSTRAINT [R_58] FOREIGN KEY ([IdUndDidac],[IdModulo],[IdEspecialidad],[AÒo_Modulo]) REFERENCES [UndDidactica]([IdUndDidac],[IdModulo],[IdEspecialidad],[AÒo_Modulo])
--		ON DELETE NO ACTION
--		ON UPDATE NO ACTION
--go
select * from Modulo_Transversal