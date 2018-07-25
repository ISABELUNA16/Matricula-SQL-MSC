use matricula
go

INSERT INTO ESPECIALIDAD (idespecialidad,nom_especialidad)VALUES
('E01','Computaci�n e Inform�tica'),
('E02','Contabilidad'),
('E03','Electronica Industrial'),
('E04','Enfermeria T�cnica'),
('E05','Mecanica Automotriz'),
('E06','Mecanica de Producci�n'),
('E07','Qu�mica Industrial')
GO
SELECT * FROM Especialidad

INSERT INTO ciclo (Idciclo,nom_ciclo,numero)VALUES
('C01','PRIMERO','I'),
('C02','SEGUNDO','II'),
('C03','TERCERO','I'),
('C04','CUARTO','II'),
('C05','QUINTO','I'),
('C06','SEXTO','II')
GO
SELECT * FROM ciclo

INSERT INTO usuario (Idusuario,nom_usuario,ape_usuario,nivel,mensaje,seudonimo,clave)values
('USU01','rocio','pacco','admin','','rocio','12345'),
('USU02','lory','acosta','admin','','lory','123456'),
('USU03','esther','cove�as','admin','','esther','123456')
go
select * from usuario

INSERT INTO Modulo_Profesional (idespecialidad,idmoduloP,nom_modulo,A�o_Modulo,IdUsuario)
VALUES

('E01','MP01','Gesti�n de Soporte T�cnico Seguridad y Tecnologias de la Informaci�n y Comunicaci�n','2010','usu01'),
('E01','MP02','Desarrollo de software y gesti�n de base de Datos','2010', 'usu01'),
('E01','MP03','Gesti�n de Aplicaciones para internet y Producci�n Multimedia','2010','usu01'),

('E02','MP01','Procesos Contables','2010','usu01'),
('E02','MP02','Contabilidad P�blica y Privada','2010','usu01'),
('E02','MP03','Analisis Financiero','2010','usu01'),

('E03','MP01','Instalaciones de sistemas El�ctricos','2010','usu01'),
('E03','MP02','Mantenimiento de M�quinas y Equipos El�ctricos','2010','usu01'),
('E03','MP03','Automatizaci�n de Sistemas El�ctricos Industriales','2010','usu01'),

('E04','MP01','Atenci�n Primaria en Salud','2010','usu01'),
('E04','MP02','Servicios T�cnicos de Enfermeria Asistencial','2010','usu01'),
('E04','MP03','Servicios T�cnicos de Enfermeria Especializada','2010','usu01'),

('E05','MP01','Mantenimiento de los Sistemas de Suspenci�n, Direccion y Frenos Automotrices','2010','usu01'),
('E05','MP02','Mantenimiento del Sistemas de Transmisi�n de Velocidad Y Fuerza Atomotriz','2010','usu01'),
('E05','MP03','Mantenimiento del Sistema El�ctrico Electr�nico Automotriz','2010','usu01'),
('E05','MP04','Mantenimiento de motores de Combusti�n Interna','2010','usu01'),

('E06','MP01','Dise�o Mec�nico','2010','usu01'),
('E06','MP02','Tecnolog�a de la soldadura','2010','usu01'),
('E06','MP03','Mecanizado con M�quinas Herramientas','2010','usu01'),
('E06','MP04','Matricer�a y Fundici�n','2010','usu01'),
('E06','MP05','Mantenimiento Mec�nico','2010','usu01'),

('E07','MP01','Ensayos de Laboratorio','2010','usu01'),
('E07','MP02','Procesos Qu�micos Industriales','2010','usu01'),
('E07','MP03','Aseguramiento de la Calidad','2010','usu01')

go 
SELECT *  FROM Modulo_Profesional
SELECT * FROM Modulo_Tranversal  
INSERT INTO Modulo_Transversal (idespecialidad,idmoduloT,nom_modulo,A�o_Modulo,IdUsuario)
VALUES

('E01','MT01','Comunicaci�n','2010','usu01'),
('E01','MT02','Matem�tica ','2010','usu01'),
('E01','MT03','Sociedad y Economia','2010','usu01'),
('E01','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E01','MT05','Actividades','2010','usu01'),
('E01','MT06','Inform�tica','2010','usu01'),
('E01','MT07','Idioma Extranjero','2010','usu01'),
('E01','MT08','Investigaci�n Tecnol�gica','2010','usu01'),
('E01','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E01','MT10','Gesti�n Empresarial','2010','usu01'),
('E01','MT11','Formaci�n y Orientaci�n ','2010','usu01'),

('E02','MT01','Comunicaci�n','2010','usu01'),
('E02','MT02','Matem�tica ','2010','usu01'),
('E02','MT03','Sociedad y Economia','2010','usu01'),
('E02','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E02','MT05','Actividades','2010','usu01'),
('E02','MT06','Inform�tica','2010','usu01'),
('E02','MT07','Idioma Extranjero','2010','usu01'),
('E02','MT08','Investigaci�n Tecnol�gica','2010','usu01'),
('E02','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E02','MT10','Gesti�n Empresarial','2010','usu01'),
('E02','MT11','Formaci�n y Orientaci�n ','2010','usu01'),

('E03','MT01','Comunicaci�n','2010','usu01'),
('E03','MT02','Matem�tica ','2010','usu01'),
('E03','MT03','Sociedad y Economia','2010','usu01'),
('E03','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E03','MT05','Actividades','2010','usu01'),
('E03','MT06','Inform�tica','2010','usu01'),
('E03','MT07','Idioma Extranjero','2010','usu01'),
('E03','MT08','Investigaci�n Tecnol�gica','2010','usu01'),
('E03','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E03','MT10','Gesti�n Empresarial','2010','usu01'),
('E03','MT11','Formaci�n y Orientaci�n ','2010','usu01'),

('E04','MT01','Comunicaci�n','2010','usu01'),
('E04','MT02','Matem�tica ','2010','usu01'),
('E04','MT03','Sociedad y Economia','2010','usu01'),
('E04','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E04','MT05','Actividades','2010','usu01'),
('E04','MT06','Inform�tica','2010','usu01'),
('E04','MT07','Idioma Extranjero','2010','usu01'),
('E04','MT08','Investigaci�n Tecnol�gica','2010','usu01'),
('E04','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E04','MT10','Gesti�n Empresarial','2010','usu01'),
('E04','MT11','Formaci�n y Orientaci�n ','2010','usu01'),

('E05','MT01','Comunicaci�n','2010','usu01'),
('E05','MT02','Matem�tica ','2010','usu01'),
('E05','MT03','Sociedad y Economia','2010','usu01'),
('E05','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E05','MT05','Actividades','2010','usu01'),
('E05','MT06','Inform�tica','2010','usu01'),
('E05','MT07','Idioma Extranjero','2010','usu01'),
('E05','MT08','Investigaci�n Tecnol�gica','2010','usu01'),
('E05','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E05','MT10','Gesti�n Empresarial','2010','usu01'),
('E05','MT11','Formaci�n y Orientaci�n ','2010','usu01'),

('E06','MT01','Comunicaci�n','2010','usu01'),
('E06','MT02','Matem�tica ','2010','usu01'),
('E06','MT03','Sociedad y Economia','2010','usu01'),
('E06','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E06','MT05','Actividades','2010','usu01'),
('E06','MT06','Inform�tica','2010','usu01'),
('E06','MT07','Idioma Extranjero','2010','usu01'),
('E06','MT08','Investigaci�n Tecnol�gica','2010','usu01'),
('E06','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E06','MT10','Gesti�n Empresarial','2010','usu01'),
('E06','MT11','Formaci�n y Orientaci�n ','2010','usu01'),

('E07','MT01','Comunicaci�n','2010','usu01'),
('E07','MT02','Matem�tica ','2010','usu01'),
('E07','MT03','Sociedad y Economia','2010','usu01'),
('E07','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E07','MT05','Actividades','2010','usu01'),
('E07','MT06','Inform�tica','2010','usu01'),
('E07','MT07','Idioma Extranjero','2010','usu01'),
('E07','MT08','Investigaci�n Tecnol�gica','2010','usu01'),
('E07','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E07','MT10','Gesti�n Empresarial','2010','usu01'),
('E07','MT11','Formaci�n y Orientaci�n ','2010','usu01')

go  


SELECT * FROM Modulo_Tranversal 


INSERT INTO TURNO (Idturno,nom_turno)VALUES
('D','Dia'),
('N','Noche')
GO
SELECT * FROM TURNO

INSERT INTO Distrito(IdDistrito,Nom_Distrito)VALUES
 ('D01','San Juan de Lurigancho'),
 ('D02','Santa Anita')
 GO
 SELECT * FROM Distrito
 
 
 INSERT INTO SEMESTRE (Idsemestre,fecha_inicio,fecha_fin)VALUES
 ('2011-1','04/04/2011','23/07/2011'),
 ('2011-2','01/08/2011','16/12/2011')
GO

SELECT * FROM SEMESTRE


INSERT INTO UndDidactica_Profesional (IdUndDidacP,Nom_UndDidactica,Horas,Credito,IdModuloP,IdCiclo,IdEspecialidad,A�O_MODULO)VALUES
--UDs DE COMPUTACI�N E INFORM�TICA
('UP01','Organizacion y Administracion de Soporte t�cnico','3','2','MP01','C01','E01','2010'),
('UP02','Integraci�n de las Tecnologias de Informaci�n y Comunicaci�n','4','3','MP01','C01','E01','2010'),
('UP03','Mantenimiento de Equipos de C�mputo','6','4','MP01','C01','E01','2010'),
('UP04','Reparaci�n de Equipos de C�mputo','6','4','MP01','C02','E01','2010'),
('UP05','Did�ctica en el uso de Recursos Inform�ticos','2','1','MP01','C02','E01','2010'),
('UP06','Dise�o de Redes de Comunicaci�n','6','5','MP01','C01','E01','2010'),
('UP07','Instalaci�n y configuraci�n de redes de comunicaci�n','4','3','MP01','C02','E01','2010'),
('UP08','Herramientas de Gesti�n de redes de Comunicaci�n','4','3','MP01','C02','E01','2010'),
('UP09','Seguridad Inform�tica','3','2','MP01','C01','E01','2010'),
('UP10','Administraci�n de Redes','2','2','MP01','C02','E01','2010'),
('UP11','Software de Servidor de Red','4','3','MP01','C02','E01','2010'),

('UP01','Analisis y dise�o de Sistemas','6','5','MP02','C03','E01','2010'),
('UP02','Herramientas de Desarrollo de Software','6','4','MP02','C03','E01','2010'),
('UP03','Taller de Base de Datos','4','3','MP02','C03','E01','2010'),
('UP04','Metodolog�as de Desarrollo de Software','2','2','MP02','C04','E01','2010'),
('UP05','Taller de Programaci�n Concurrente','8','6','MP02','C04','E01','2010'),
('UP06','Taller de Programaci�n Distribuida','8','6','MP02','C04','E01','2010'),
('UP07','L�gica de Programaci�n','2','1','MP02','C03','E01','2010'),
('UP08','Taller de Modelamiento de Software','4','3','MP02','C03','E01','2010'),
('UP09','Administraci�n de Base de Datos','6','4','MP02','C04','E01','2010'),

('UP01','Dise�o Gr�fico','5','4','MP03','C05','E01','2010'),
('UP02','Animaci�n de Gr�ficos','5','4','MP03','C05','E01','2010'),
('UP03','Herramientas Multimedia','4','3','MP03','C05','E01','2010'),
('UP04','Producci�n Audiovisual','6','4','MP03','C06','E01','2010'),
('UP05','Dise�o Web','4','3','MP03','C05','E01','2010'),
('UP06','Taller de Programaci�n Web','10','7','MP03','C06','E01','2010'),
('UP07','Comercio Electr�nico','3','2','MP03','C06','E01','2010'),
('UP08','Aplicaciones M�viles','4','3','MP03','C06','E01','2010'),
('UP09','Gesti�n y Administraci�n Web','6','4','MP03','C05','E01','2010'),

--UDs de Contabilidad
('UP01','Contabilidad General I','6','4','MP01','C01','E02','2010'),
('UP02','Contabilidad General II','8','6','MP01','C02','E02','2010'),
('UP03','Plan Contable','4','3','MP01','C01','E02','2010'),
('UP04','Documentaci�n Comercial y Contable','6','4','MP01','C01','E02','2010'),
('UP05','Administraci�n Empresarial','3','2','MP01','C01','E02','2010'),
('UP06','Legislaci�n Laboral','4','3','MP01','C02','E02','2010'),
('UP07','Legislaci�n Comercial','4','3','MP01','C01','E02','2010'),
('UP08','Legislaci�n Tributaria','4','3','MP01','C02','E02','2010'),

('UP01','Fundamentos de Costos','6','4','MP02','C02','E02','2010'),
('UP02','Contabilidad de Costos','6','4','MP02','C03','E02','2010'),
('UP03','Contabilidad de Sociedades','7','5','MP02','C04','E02','2010'),
('UP04','Contabilidad Aplicada','8','6','MP02','C04','E02','2010'),
('UP05','T�cnica Presupuestal','6','4','MP02','C03','E02','2010'),
('UP06','Contabilidad Gubernamental I','5','4','MP02','C03','E02','2010'),
('UP07','Contabilidad Gubernamental II','7','5','MP02','C04','E02','2010'),
('UP08','Aplicativos Inform�ticos','5','4','MP02','C03','E02','2010'),

('UP01','Formulaci�n de Estados Financieros','6','4','MP03','C05','E02','2010'),
('UP02','An�lisis e Interpretaci�n de Estados Financieros','6','4','MP03','C06','E02','2010'),
('UP03','Fundamentos de Finanzas','4','3','MP03','C05','E02','2010'),
('UP04','Finanzas P�blicas','4','3','MP03','C06','E02','2010'),
('UP05','Formulaci�n y Evaluaci�n de Proyectos','5','4','MP03','C05','E02','2010'),
('UP06','Planeamiento de la Auditoria','4','3','MP03','C05','E02','2010'),
('UP07','T�cnicas y Procedimientos de Auditoria','4','3','MP03','C06','E02','2010'),
('UP08','Contabilidad de Entidades Financieras I','6','4','MP03','C05','E02','2010'),
('UP09','Contabilidad de Entidades Financieras II','6','4','MP03','C06','E02','2010'),
('UP10','C�lculo Financiero','5','4','MP03','C06','E02','2010'),

--UDs DE ELECTROTECNIA INDUSTRIAL
('UP01','Fundamentos de Electrotecnia','8','6','MP01','C01','E03','2010'),
('UP02','Mec�nica B�sica','4','3','MP01','C01','E03','2010'),
('UP03','Instalaciones El�ctricas I','7','5','MP01','C01','E03','2010'),
('UP04','Instalaciones El�ctricas II','6','4','MP01','C02','E03','2010'),
('UP05','Dipositivos Electr�nicos','4','3','MP01','C01','E03','2010'),
('UP06','Montaje e Instalaci�n de Sub-estaciones','4','3','MP01','C02','E03','2010'),
('UP07','Distribuci�n de Baja y Media Tensi�n','4','3','MP01','C02','E03','2010'),
('UP08','Equipos e Instrumentos de Medici�n','4','3','MP01','C02','E03','2010'),
('UP09','Proyecto de Mantenimiento de Sistemas El�ctricos','4','3','MP01','C02','E03','2010'),

('UP01','Tecnologia de Materiales','2','1','MP02','C03','E03','2010'),
('UP02','M�quinas El�ctricas','8','6','MP02','C03','E03','2010'),
('UP03','Generaci�n y Transmisi�n de Energia El�ctrica','6','4','MP02','C03','E03','2010'),
('UP04','Instalacion de M�quinas El�ctricas','6','4','MP02','C03','E03','2010'),
('UP05','Rebobinado de M�quinas El�ctricas','8','6','MP02','C04','E03','2010'),
('UP06','Mantenimiento de Sistemas y Equ�pos El�ctricos ','8','6','MP02','C04','E03','2010'),
('UP07','Electr�nica de Potencia','4','3','MP02','C04','E03','2010'),
('UP08','Proyecto de M�quinas y Equipos','4','3','MP02','C04','E03','2010'),

('UP01','Sistema de Control Autom�tico','4','3','MP03','C05','E03','2010'),
('UP02','Electr�nica de Potencia Aplicada','6','4','MP03','C05','E03','2010'),
('UP03','Electroneum�tica y Eletrohidr�ulica','6','4','MP03','C05','E03','2010'),
('UP04','Tableros de Control y Mando Autom�tico','8','6','MP03','C05','E03','2010'),
('UP05','Controlador L�gico Programable y Perif�ricos','8','6','MP03','C06','E03','2010'),
('UP06','Mantenimiento de Sistema de Control Autom�tico ','6','4','MP03','C06','E03','2010'),
('UP07','Instrumentaci�n y Control de Procesos Industriales','6','4','MP03','C06','E03','2010'),
('UP08','Proyecto de Sistemas de Automatizaci�n Industrial','4','3','MP03','C06','E03','2010'),

--UDs DE ENFERMERIA  T�CNICA
('UP01','Anatomia Funcional','5','4','MP01','C01','E04','2010'),
('UP02','Primeros Auxilios','6','4','MP01','C01','E04','2010'),
('UP03','Educaci�n para la Salud','6','4','MP01','C02','E04','2010'),
('UP04','Actividades en Salud P�blica','10','7','MP01','C02','E04','2010'),
('UP05','Asistencia en Inmunizaciones','6','4','MP01','C01','E04','2010'),
('UP06','Actividades en Salud Comunitaria','6','4','MP01','C02','E04','2010'),
('UP07','Actividades en Epidemiologia','5','4','MP01','C01','E04','2010'),

('UP01','Documentaci�n en Salud','2','1','MP02','C03','E04','2010'),
('UP02','Bioseguridad','5','4','MP02','C03','E04','2010'),
('UP03','Asistencia B�sica Hospitalaria','10','7','MP02','C03','E04','2010'),
('UP04','Nutrici�n y Dietas','5','4','MP02','C03','E04','2010'),
('UP05','Procedimientos Invasivos y no Invasivos','4','3','MP02','C04','E04','2010'),
('UP06','Asistencia en la Administraci�n de Medicamentos','5','4','MP02','C04','E04','2010'),
('UP07','Muestras Biol�gicas','4','3','MP02','C04','E04','2010'),
('UP08','Asistencia al Usuario con Patologias','4','3','MP02','C04','E04','2010'),
('UP09','Asistencia al Usuario Quir�rgico','7','5','MP02','C04','E04','2010'),

('UP01','Atenci�n en Salud Materna','5','4','MP03','C05','E04','2010'),
('UP02','Salud del Ni�o y del Adolecente','7','5','MP03','C05','E04','2010'),
('UP03','Asistencia del Adulto Mayor','7','5','MP03','C05','E04','2010'),
('UP04','Asistencia de Enfermeria en Salud Mental','5','4','MP03','C05','E04','2010'),
('UP05','Asistencia en Fisioterapia y Rehabilitaci�n','6','4','MP03','C06','E04','2010'),
('UP06','Asistencia en Salud Bucal','4','3','MP03','C06','E04','2010'),
('UP07','Asistencia en Medicina Alternativa','7','5','MP03','C06','E04','2010'),
('UP08','Asistencia al Usuario oncol�gico','7','5','MP03','C06','E04','2010'),

--UDs de MECANICA AUTOMOTRIZ
('UP01','Dibujo Mec�nico','4','3','MP01','C01','E05','2010'),
('UP02','Mec�nica de Taller','8','6','MP01','C01','E05','2010'),
('UP03','Sistema de Suspens�on y Direcci�n','10','7','MP01','C01','E05','2010'),
('UP04','Hidroneum�tica','4','3','MP01','C02','E05','2010'),
('UP05','Laboratorio de Sistemas','4','3','MP01','C02','E05','2010'),
('UP06','Prevenci�n de Riesgos','3','2','MP01','C02','E05','2010'),
('UP07','Sistema de Frenos','11','8','MP01','C02','E05','2010'),

('UP01','Mecanismo de Embrague Y Caja de Velocidades','8','6','MP02','C03','E05','2010'),
('UP02','Mecanismo Diferencial','4','3','MP02','C03','E05','2010'),
('UP03','Soldadura Aplicada a Mecanismos Automotrices','6','4','MP02','C03','E05','2010'),
('UP04','Laboratorio de Mecanismo de Transmisi�n','4','3','MP02','C03','E05','2010'),

('UP01','Dibujo El�ctrico Automotriz','3','2','MP03','C04','E05','2010'),
('UP02','Fundamentos El�ctricos y Electr�nicos Automotrices','4','3','MP03','C04','E05','2010'),
('UP03','Sistema de Carga y Arranque','6','4','MP03','C04','E05','2010'),
('UP04','Sistema de Encendido Convencional y Electr�nico','6','4','MP03','C04','E05','2010'),
('UP05','Sistemas de Luces y Controles Auxiliares','5','4','MP03','C04','E05','2010'),

('UP01','Motores de Combusti�n Interna Otto','10','7','MP04','C05','E05','2010'),
('UP02','Inyecci�n Electr�nica Otto','6','4','MP04','C05','E05','2010'),
('UP03','Laboratorio de Motores','5','4','MP04','C05','E05','2010'),
('UP04','Conversi�n de Motores a Combustibles Alternos','4','3','MP04','C05','E05','2010'),
('UP05','Motores de Combusti�n Interna Diesel','6','4','MP04','C06','E05','2010'),
('UP06','Laboratorio de Sistema Diesel','6','4','MP04','C06','E05','2010'),
('UP07','Rectificaciones Automotrices','6','4','MP04','C06','E05','2010'),
('UP08','Afinamiento de Motores de Conbusti�n Interna','4','3','MP04','C06','E05','2010'),
('UP09','Inyecci�n Electr�nica Diesel','3','2','MP04','C06','E05','2010'),

--UDs DE MEC�NICA DE PRODUCCI�N
('UP01','Dibujo T�cnico','4','3','MP01','C01','E06','2010'),
('UP02','Materiales Industriales','3','2','MP01','C01','E06','2010'),
('UP03','Mec�nica de Banco','8','6','MP01','C01','E06','2010'),
('UP04','M�quinas B�sicas','4','3','MP01','C02','E06','2010'),
('UP05','Dibujo Asistido por Ordenador','4','3','MP01','C02','E06','2010'),
('UP06','C�lculo de Elementos de M�quinas','3','2','MP01','C02','E06','2010'),

('UP01','Dibujo y C�lculo de Soldadura','3','2','MP02','C01','E06','2010'),
('UP02','Soldadura Oxigas','6','4','MP02','C01','E06','2010'),
('UP03','Soldadura El�ctrica','7','5','MP02','C02','E06','2010'),
('UP04','Soldadura Mixta','4','3','MP02','C02','E06','2010'),

('UP01','M�quinas Convensionales I','12','9','MP03','C03','E06','2010'),
('UP02','M�quinas Convensionales II','12','9','MP03','C04','E06','2010'),
('UP03','M�quinas Especiales','4','3','MP03','C03','E06','2010'),
('UP04','M�quinas de Control Num�rico Computarizado','6','4','MP03','C04','E06','2010'),
('UP05','T�cnicas de Producci�n I','6','4','MP03','C03','E06','2010'),
('UP06','T�cnicas de Producci�n II','6','5','MP03','C04','E06','2010'),

('UP01','Modeler�a y Fundici�n','6','4','MP04','C05','E06','2010'),
('UP02','Moldes Permanentes','6','4','MP04','C05','E06','2010'),
('UP03','Matrices de Chapas','8','6','MP04','C06','E06','2010'),
('UP04','Tratamientos T�rmicos y ensayos','4','3','MP04','C06','E06','2010'),

('UP01','Gesti�n del Mantenimiento','2','1','MP05','C05','E06','2010'),
('UP02','Seguridad e Higiene Industrial','2','1','MP05','C05','E06','2010'),
('UP03','Mantenimiento Mec�nico','8','6','MP05','C05','E06','2010'),
('UP04','Automatizaci�n','8','6','MP05','C06','E06','2010'),
('UP05','Mantenimiento El�ctrico','3','2','MP05','C06','E06','2010'),

--UDs DE QU�MICA INDUSTRIAL
('UP01','Ensayos F�sicos y Organol�pticos','4','3','MP01','C01','E07','2010'),
('UP02','Ensayos Qu�micos','10','8','MP01','C01','E07','2010'),
('UP03','C�lculos Fundamentales en Qu�mica','5','4','MP01','C01','E07','2010'),
('UP04','Ensayos de Impacto Ambiental','3','2','MP01','C01','E07','2010'),
('UP05','Ensayos por Instrumentaci�n','4','3','MP01','C02','E07','2010'),
('UP06','Ensayos Bromatol�gicos','6','4','MP01','C02','E07','2010'),
('UP07','Ensayos Qu�micos Industriales','10','8','MP01','C02','E07','2010'),

('UP01','Planeamiento y Control de la Producci�n','3','2','MP02','C02','E07','2010'),
('UP02','Estadistica Aplicada','3','2','MP02','C03','E07','2010'),
('UP03','Servicios Auxiliares de Proceso','3','2','MP02','C03','E07','2010'),
('UP04','Balance de Materia Y Energia','6','4','MP02','C03','E07','2010'),
('UP05','Operaciones con Transporte de Fluidos','6','4','MP02','C03','E07','2010'),
('UP06','Tratamiento de S�lidos','4','3','MP02','C03','E07','2010'),
('UP07','Seguridad e Higiene Industrial','3','2','MP02','C04','E07','2010'),
('UP08','Producci�n Industrial','12','9','MP02','C04','E07','2010'),
('UP09','Sistema de Control de Procesos','4','3','MP02','C04','E07','2010'),
('UP10','Procesos Qu�micos','5','4','MP02','C04','E07','2010'),
('UP11','Tratamiento de Efluentes','4','3','MP02','C05','E07','2010'),

('UP01','Sistemas de Calidad','6','4','MP03','C05','E07','2010'),
('UP02','Medidas de Variables Fisicoqu�micas','6','4','MP03','C06','E07','2010'),
('UP03','Control de Calidad en Procesos Qu�micos Inorg�nicos','6','4','MP03','C05','E07','2010'),
('UP04','Control de Calidad en la Agroindustria I','4','3','MP03','C05','E07','2010'),
('UP05','Metrologia','4','3','MP03','C05','E07','2010'),
('UP06','Calidad y Productividad','4','3','MP03','C06','E07','2010'),
('UP07','Auditorias de Calidad','3','2','MP03','C06','E07','2010'),
('UP08','Control de Calidad en la Agroindustria II','4','3','MP03','C06','E07','2010'),
('UP09','Control de Calidad en Procesos Qu�micos Org�nicos','6','4','MP03','C06','E07','2010')
go 
SELECT * FROM UndDidactica_Prof 
INSERT INTO UndDidactica_Transversal (IdUndDidacT,Nom_UndDidactica,Horas,Credito,IdModuloT,IdCiclo,IdEspecialidad,A�O_MODULO)VALUES
--UNIDADES DIDACTICAS TRANSVERSALES C.I.
('UT01','T�cnicas de Comunicaci�n','2','1.5','MT01','C01','E01','2010'),
('UT02','Interpretaci�n y Producci�n de Textos','2','1.5','MT01','C02','E01','2010'),
('UT01','L�gica y Funciones','2','1.5','MT02','C01','E01','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E01','2010'),
('UT01','Sociedad y Economia en la Globaizaci�n','3','2','MT03','C03','E01','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E01','2010'),
('UT01','Cultura F�sica y Deporte','2','1','MT05','C01','E01','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E01','2010'),
('UT01','Inform�tica e Internet','2','1.5','MT06','C01','E01','2010'),
('UT02','Ofim�tica','2','1.5','MT06','C02','E01','2010'),
('UT01','Comunicaci�n Interpersonal','2','1.5','MT07','C04','E01','2010'),
('UT02','Comunicaci�n Empresarial','2','1.5','MT07','C05','E01','2010'),
('UT01','Fundamentos de Investigaci�n','2','1.5','MT08','C02','E01','2010'),
('UT02','Investigaci�n e Innovaci�n Tecnol�gica','2','1.5','MT08','C03','E01','2010'),
('UT03','Proyectos de Investigaci�n e Innovaci�n Tecnol�gica','4','3','MT08','C04','E01','2010'),
('UT01','�tica Profesional','2','1.5','MT09','C05','E01','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E01','2010'),
('UT01','Organizaci�n y Constituci�n de Empresas','2','1.5','MT10','C05','E01','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E01','2010'),
('UT01','Legislaci�n e Inserci�n Laboral','3','2','MT11','C06','E01','2010'),
--UNIDADES DIDACTICAS TRANSVERSALES C.T.
('UT01','T�cnicas de Comunicaci�n','2','1.5','MT01','C01','E02','2010'),
('UT02','Interpretaci�n y Producci�n de Textos','2','1.5','MT01','C02','E02','2010'),
('UT01','L�gica y Funciones','2','1.5','MT02','C01','E02','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E02','2010'),
('UT01','Sociedad y Economia en la Globaizaci�n','3','2','MT03','C03','E02','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E02','2010'),
('UT01','Cultura F�sica y Deporte','2','1','MT05','C01','E02','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E02','2010'),
('UT01','Inform�tica e Internet','2','1.5','MT06','C01','E02','2010'),
('UT02','Ofim�tica','2','1.5','MT06','C02','E02','2010'),
('UT01','Comunicaci�n Interpersonal','2','1.5','MT07','C04','E02','2010'),
('UT02','Comunicaci�n Empresarial','2','1.5','MT07','C05','E02','2010'),
('UT01','Fundamentos de Investigaci�n','2','1.5','MT08','C02','E02','2010'),
('UT02','Investigaci�n e Innovaci�n Tecnol�gica','2','1.5','MT08','C03','E02','2010'),
('UT03','Proyectos de Investigaci�n e Innovaci�n Tecnol�gica','4','3','MT08','C04','E02','2010'),
('UT01','�tica Profesional','2','1.5','MT09','C05','E02','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E02','2010'),
('UT01','Organizaci�n y Constituci�n de Empresas','2','1.5','MT10','C05','E02','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E02','2010'),
('UT01','Legislaci�n e Inserci�n Laboral','3','2','MT11','C06','E02','2010'),

--UNIDADES DIDACTICAS TRANSVERSALES E.I
('UT01','T�cnicas de Comunicaci�n','2','1.5','MT01','C01','E03','2010'),
('UT02','Interpretaci�n y Producci�n de Textos','2','1.5','MT01','C02','E03','2010'),
('UT01','L�gica y Funciones','2','1.5','MT02','C01','E03','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E03','2010'),
('UT01','Sociedad y Economia en la Globaizaci�n','3','2','MT03','C03','E03','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E03','2010'),
('UT01','Cultura F�sica y Deporte','2','1','MT05','C01','E03','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E03','2010'),
('UT01','Inform�tica e Internet','2','1.5','MT06','C01','E03','2010'),
('UT02','Ofim�tica','2','1.5','MT06','C02','E03','2010'),
('UT01','Comunicaci�n Interpersonal','2','1.5','MT07','C04','E03','2010'),
('UT02','Comunicaci�n Empresarial','2','1.5','MT07','C05','E03','2010'),
('UT01','Fundamentos de Investigaci�n','2','1.5','MT08','C02','E03','2010'),
('UT02','Investigaci�n e Innovaci�n Tecnol�gica','2','1.5','MT08','C03','E03','2010'),
('UT03','Proyectos de Investigaci�n e Innovaci�n Tecnol�gica','4','3','MT08','C04','E03','2010'),
('UT01','�tica Profesional','2','1.5','MT09','C05','E03','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E03','2010'),
('UT01','Organizaci�n y Constituci�n de Empresas','2','1.5','MT10','C05','E03','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E03','2010'),
('UT01','Legislaci�n e Inserci�n Laboral','3','2','MT11','C06','E03','2010'),
--UNIDADES DIDACTICAS TRANSVERSALES E.T.
('UT01','T�cnicas de Comunicaci�n','2','1.5','MT01','C01','E04','2010'),
('UT02','Interpretaci�n y Producci�n de Textos','2','1.5','MT01','C02','E04','2010'),
('UT01','L�gica y Funciones','2','1.5','MT02','C01','E04','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E04','2010'),
('UT01','Sociedad y Economia en la Globaizaci�n','3','2','MT03','C03','E04','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E04','2010'),
('UT01','Cultura F�sica y Deporte','2','1','MT05','C01','E04','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E04','2010'),
('UT01','Inform�tica e Internet','2','1.5','MT06','C01','E04','2010'),
('UT02','Ofim�tica','2','1.5','MT06','C02','E04','2010'),
('UT01','Comunicaci�n Interpersonal','2','1.5','MT07','C04','E04','2010'),
('UT02','Comunicaci�n Empresarial','2','1.5','MT07','C05','E04','2010'),
('UT01','Fundamentos de Investigaci�n','2','1.5','MT08','C02','E04','2010'),
('UT02','Investigaci�n e Innovaci�n Tecnol�gica','2','1.5','MT08','C03','E04','2010'),
('UT03','Proyectos de Investigaci�n e Innovaci�n Tecnol�gica','4','3','MT08','C04','E04','2010'),
('UT01','�tica Profesional','2','1.5','MT09','C05','E04','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E04','2010'),
('UT01','Organizaci�n y Constituci�n de Empresas','2','1.5','MT10','C05','E04','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E04','2010'),
('UT01','Legislaci�n e Inserci�n Laboral','3','2','MT11','C06','E04','2010'),

--UNIDADES DIDACTICAS TRANSVERSALES M.A.
('UT01','T�cnicas de Comunicaci�n','2','1.5','MT01','C01','E05','2010'),
('UT02','Interpretaci�n y Producci�n de Textos','2','1.5','MT01','C02','E05','2010'),
('UT01','L�gica y Funciones','2','1.5','MT02','C01','E05','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E05','2010'),
('UT01','Sociedad y Economia en la Globaizaci�n','3','2','MT03','C03','E05','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E05','2010'),
('UT01','Cultura F�sica y Deporte','2','1','MT05','C01','E05','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E05','2010'),
('UT01','Inform�tica e Internet','2','1.5','MT06','C05','E05','2010'),
('UT02','Ofim�tica','2','1.5','MT06','C02','E05','2010'),
('UT01','Comunicaci�n Interpersonal','2','1.5','MT07','C04','E05','2010'),
('UT02','Comunicaci�n Empresarial','2','1.5','MT07','C05','E05','2010'),
('UT01','Fundamentos de Investigaci�n','2','1.5','MT08','C02','E05','2010'),
('UT02','Investigaci�n e Innovaci�n Tecnol�gica','2','1.5','MT08','C03','E05','2010'),
('UT03','Proyectos de Investigaci�n e Innovaci�n Tecnol�gica','4','3','MT08','C04','E05','2010'),
('UT01','�tica Profesional','2','1.5','MT09','C05','E05','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E05','2010'),
('UT01','Organizaci�n y Constituci�n de Empresas','2','1.5','MT10','C05','E05','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E05','2010'),
('UT01','Legislaci�n e Inserci�n Laboral','3','2','MT11','C06','E05','2010'),


--UNIDADES DIDACTICAS TRANSVERSALES M.A.
('UT01','T�cnicas de Comunicaci�n','2','1.5','MT01','C01','E06','2010'),
('UT02','Interpretaci�n y Producci�n de Textos','2','1.5','MT01','C02','E06','2010'),
('UT01','L�gica y Funciones','2','1.5','MT02','C01','E06','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E06','2010'),
('UT01','Sociedad y Economia en la Globaizaci�n','3','2','MT03','C03','E06','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E06','2010'),
('UT01','Cultura F�sica y Deporte','2','1','MT05','C01','E06','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E06','2010'),
('UT01','Inform�tica e Internet','2','1.5','MT06','C01','E06','2010'),
('UT02','Ofim�tica','2','1.5','MT06','C02','E06','2010'),
('UT01','Comunicaci�n Interpersonal','2','1.5','MT07','C04','E06','2010'),
('UT02','Comunicaci�n Empresarial','2','1.5','MT07','C05','E06','2010'),
('UT01','Fundamentos de Investigaci�n','2','1.5','MT08','C02','E06','2010'),
('UT02','Investigaci�n e Innovaci�n Tecnol�gica','2','1.5','MT08','C03','E06','2010'),
('UT03','Proyectos de Investigaci�n e Innovaci�n Tecnol�gica','4','3','MT08','C04','E06','2010'),
('UT01','�tica Profesional','2','1.5','MT09','C05','E06','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E06','2010'),
('UT01','Organizaci�n y Constituci�n de Empresas','2','1.5','MT10','C05','E06','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E06','2010'),
('UT01','Legislaci�n e Inserci�n Laboral','3','2','MT11','C06','E06','2010'),

--UNIDADES DIDACTICAS TRANSVERSALES QI
('UT01','T�cnicas de Comunicaci�n','2','1.5','MT01','C01','E07','2010'),
('UT02','Interpretaci�n y Producci�n de Textos','2','1.5','MT01','C02','E07','2010'),
('UT01','L�gica y Funciones','2','1.5','MT02','C01','E07','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E07','2010'),
('UT01','Sociedad y Economia en la Globaizaci�n','3','2','MT03','C03','E07','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E07','2010'),
('UT01','Cultura F�sica y Deporte','2','1','MT05','C01','E07','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E07','2010'),
('UT01','Inform�tica e Internet','2','1.5','MT06','C01','E07','2010'),
('UT02','Ofim�tica','2','1.5','MT06','C02','E07','2010'),
('UT01','Comunicaci�n Interpersonal','2','1.5','MT07','C04','E07','2010'),
('UT02','Comunicaci�n Empresarial','2','1.5','MT07','C05','E07','2010'),
('UT01','Fundamentos de Investigaci�n','2','1.5','MT08','C02','E07','2010'),
('UT02','Investigaci�n e Innovaci�n Tecnol�gica','2','1.5','MT08','C03','E07','2010'),
('UT03','Proyectos de Investigaci�n e Innovaci�n Tecnol�gica','4','3','MT08','C04','E07','2010'),
('UT01','�tica Profesional','2','1.5','MT09','C05','E07','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E07','2010'),
('UT01','Organizaci�n y Constituci�n de Empresas','2','1.5','MT10','C05','E07','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E07','2010'),
('UT01','Legislaci�n e Inserci�n Laboral','3','2','MT11','C06','E07','2010')
GO

SELECT * FROM UndDidactica_Profesional
SELECT * FROM UndDidactica_Transversal

INSERT INTO TIPOINGRESO(IDTIPO,DESCRIPCION)VALUES
('T01', 'ADMISI�N'),
('T02', 'TRASLADO')

select * from TipoIngreso

INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'00000000', N'D01', N'T01', N'USU03', N'E02', N'APONTE', N'APONTE', N'PEDRO DAMIAN', CAST(0x4A1B0B00 AS Date), N'S. J. LURIGANCHO', N'LIMA', N'LIMA', N'17 ', N'M', N'Soltero', N' ASENT. H  JOSE MARIATEGUI MZ K1 LT 18', N'3624399', N'I.E. JOSE CARLOS MARIATEGUI  0152 .S.J.L ', N'2010', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'XDDEMIXD@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'APONTE', N'LAURA', N'PEDRO DAMIAN', N'        ', N'OBRERO', N'ASENT. H  JOSE MARIATEGUI MZ K', N'         ', N'APONTE', N'SALAZAR', N'LUCIA DIONICIA', N'        ', N'COSMETOLOGA', N'ASENT. H  JOSE MARIATEGUI MZ K', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'46880758', N'D01', N'T01', N'USU03', N'E01', N'NARRO ', N'MARZANO', N'HAIDER YOLVI', CAST(0xF5180B00 AS Date), N'CENTRO DE LIMA', N'LIMA', N'LIMA', N'18 ', N'M', N'Soltero', N' M,Z D1. LT 7 AA.HH.CUIDAD DE LOS CONSTRUCTORES II', N'2537481', N'SAN JOSE OBRERO     ', N'2007', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'HAIDER_SJO_90@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'NARRO', N'LEIVA', N'LORGIO  FELICIANO', N'        ', N' OMERCIANTE', N'SAN JUAN DE LURIGANCHO', N'         ', N'MARZANO ', N'GUTIERREZ', N'VICTORIA GREGORIA', N'        ', N'ENFERMERA TECNICA', N' M,Z D1. LT 7 AA.HH.CUIDAD DE ', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'70068285', N'D01', N'T01', N'USU03', N'E01', N'CODORI ', N'CHACON ', N'ERIKA ROXANA', CAST(0xD71B0B00 AS Date), N'S.J.LURIGANCHO', N'LIMA', N'LIMA', N'16 ', N'F', N'Soltero', N'MZ A5 LT 16 SUB LT8 SECTOR LOMAS BAJAS JICAMARCA', N'990891120', N'EL B OSQUE N� 1182', N'2010', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'ROXANA_CONDORI@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'CONDORI', N'TICA ', N'TEOFILO', N'24664203', N'COSTURERO', N'MZ A5 LT 16 SUB LT8 SECTOR LOM', N'990891120', N'CHACON ', N'HUAYHUA', N'PRAXIDA', N'24704348', N'', N'MZ A5 LT 16 SUB LT8 SECTOR LOM', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'47259765', N'D01', N'T01', N'USU03', N'E01', N'OYOLO', N'MARTINEZ', N'JESUS ALBERTO', CAST(0xCB180B00 AS Date), N'S.J.LURIGANCHO', N'LIMA', N'LIMA', N'19 ', N'M', N'Soltero', N'MZ P1 LT 16 J.C.A', N'958078618', N'I.E NICOLAS COPERNICO', N'2008', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'OYOLO', N'ATOCCSA', N'PELAYO', N'08310217', N'ELECTRICISTA', N'MZ A5 LT 16 SUB LT8 SECTOR LOM', N'989812256', N'MARTINEZ', N'EULOGIO', N'CRISANTA', N'        ', N'', N'MZ A5 LT 16 SUB LT8 SECTOR LOM', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'44704976', N'D01', N'T01', N'USU03', N'E01', N'VILLAVICENCIO', N'SANTE', N'CLEMENTINA', CAST(0xC1120B00 AS Date), N'ICA', N'ICA', N'ICA', N'23 ', N'M', N'Soltero', N'MZ R1 LT 19 AA.HH. JUAN PABLO II 3� ZONA', N'4594306', N'MIGUEL GRAU', N'2004', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'SHARUMI_SHERLYN@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'VILLAVICENCIO ', N'GALVEZ', N'VICTOR', N'        ', N'EMPLEADO', N'', N'         ', N'SANTE', N'CANCHARI', N'CLEMENTINA', N'        ', N'AMA DE CASA ', N'SAN JUAQUIN 3� ETAPA', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'43562626', N'D01', N'T01', N'USU03', N'E01', N'MULLIZACA', N'MULLISACA', N'IZOLINA', CAST(0x9A100B00 AS Date), N'AZANGORA', N'PUTINA', N'PUNO', N'24 ', N'F', N'Soltero', N'MZ C 2 LT 12  MATRISCAL CACERES ', N'995834801', N'DANIEL ALCIDES GARRION ', N'2002', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'SOLEM86@GMAIL', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'MULLIZACA ', N'MULLISACA', N'ADRIAN', N'        ', N'CHOFER', N'', N'         ', N'MULLISACA', N'CACERES', N'VICTORIA', N'        ', N'SU CASA', N'', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'47517721', N'D01', N'T01', N'USU03', N'E01', N'PAREDES', N'VIDAL', N'JOSE VIRIGILIO ', CAST(0x181A0B00 AS Date), N' LIMA', N'LIMA', N'LIMA', N'18 ', N'M', N'Soltero', N'AV. PAMPA ALTA AA.HH JOSE CARLOS MARIATEGUI', N'995337156', N'13 DE AGOSTO', N'2010', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'BADBOY14_93@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0x5B950A00 AS Date), N'PAREDES', N'RODRIGUEZ', N'HENRY ANTONIO', N'        ', N'COMERCIANTE', N'AV. PAMPA ALTA AA.HH JOSE CARL', N'999904518', N'VIDAL ', N'CANPHUALLPA', N'ROSAURA', N'        ', N'COMERCIANTE', N'AV. PAMPA ALTA AA.HH JOSE CARL', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'47092655', N'D01', N'T01', N'USU03', N'E01', N'QUISPE', N'CHUCYA', N'STEFANY', CAST(0x5B180B00 AS Date), N'S.J. LURIGANCHO', N'LIMA', N'LIMA', N'19 ', N'F', N'Soltero', N'CALLE MARGARITA MZ P LT 3 SANTA MARTHA', N'7608946', N'EL AMAUTA N 164', N'2007', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'@', N'S', N'CONTABILIDAD', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'QUISPE ', N'CUSIPAUCAR', N'SAMUEL', N'        ', N'AUTOSERVICIO', N'CALLE MARGARITA MZ P LT 3 SANT', N'992259059', N'CHUCYA', N'BALLADARES', N'GUILLERMINA', N'        ', N'AMA D CASA', N'CALLE MARGARITA MZ P LT 3 SANT', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'70813193', N'D01', N'T01', N'USU03', N'E01', N'QUISPE', N'ALATA', N'BERENISSE SAVIANA', CAST(0xA2190B00 AS Date), N'TACNA', N'TACNA', N'TACNA', N'18 ', N'F', N'Soltero', N'JR. PEREZ DE ARMENDARIZ MZ H 14 LT 20', N'', N'SIMON BOLIVAR', N'2007', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'QUISPE', N'RUIZ', N'ABELINO', N'        ', N'ESTUDIANTE', N'JR. PEREZ DE ARMENDARIZ MZ H 1', N'         ', N'ALATA', N'MERINO ', N'MARIA CARMEN', N'        ', N'ESTUDIANTE', N'JR. PEREZ DE ARMENDARIZ MZ H 1', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'47798791', N'D01', N'T01', N'USU03', N'E01', N'NINA', N'PALMA', N'LICELY', CAST(0xB5190B00 AS Date), N'YANATILE', N'CALCA', N'CUZCO', N'19 ', N'F', N'Soltero', N'AV CANTO GRANDE PDRO "2"', N'3892624', N'SAN LUIS GONZAGA', N'2009', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'NINA', N'HUAMAN', N'JUAN BAUTISTA', N'        ', N'PROFESOR', N'AV CANTO GRANDE PDRO "2"', N'         ', N'PALMA', N'ROZAS', N'EUFRACIA', N'        ', N'AMA DE CASA', N'AV CANTO GRANDE PDRO "2" MZ R ', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'72208950', N'D01', N'T01', N'USU03', N'E01', N'MONTOYA', N'JIMENEZ', N'KRISTELL MEREDY ', CAST(0xB51B0B00 AS Date), N'S.J LURIGANCHO. ', N'LIMA', N'LIMA', N'17 ', N'F', N'Soltero', N'JR.AEROLITOS 338 STA ELIZABETH. - LAS FLORES 21', N'3882836', N'I.E.N� 100 2SANTA ELIZABETH"', N'2009', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'KRISAMOR_CELOS94@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.png', CAST(0xB9330B00 AS Date), N'MONTOYA', N'ATOCCSA', N'JUAN FLORENCIO', N'28480038', N'TRABAJADOR INDEPENDIENTE', N'JR.AEROLITOS 338 STA ELIZABETH', N'3882836  ', N'JIMENEZ ', N'CANALES', N'LOURDES ASUNTA', N'07866728', N'PROFESORA', N'JR.AEROLITOS 338 STA ELIZABETH', N'3882836  ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Direcci�n], [Telef_Alumno], [Nombre_IE], [A�oEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [A�o_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'76239230', N'D01', N'T01', N'USU03', N'E01', N'OSORIO', N'VALDEZ', N'YESSICA CORINA', CAST(0x881C0B00 AS Date), N'S.J.LURIGANCHO', N'LIMA', N'LIMA ', N'16 ', N'F', N'Soltero', N'psje.4 A sector Huanta  II ampliacion', N'999338251', N'I.E. Jose Carlos Mariategui', N'2010', N'Computaci�n e Inform�tica', N'N', N'', N'', N'Dia', N'@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'Osorio ', N'Perez', N'Juan', N'09261265', N'Alba�il', N'psje.4 A sector Huanta II ampl', N'999338251', N'Valdez', N'Ore', N'Julia Ricardina', N'        ', N'ama de casa', N'psje.4 A sector Huanta II ampl', N'         ')


select * from Matricula
select * from Alumno
select * from Modulo_Profesional