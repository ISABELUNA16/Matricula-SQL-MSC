use matricula
go

INSERT INTO ESPECIALIDAD (idespecialidad,nom_especialidad)VALUES
('E01','Computación e Informática'),
('E02','Contabilidad'),
('E03','Electronica Industrial'),
('E04','Enfermeria Técnica'),
('E05','Mecanica Automotriz'),
('E06','Mecanica de Producción'),
('E07','Química Industrial')
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
('USU03','esther','coveñas','admin','','esther','123456')
go
select * from usuario

INSERT INTO Modulo_Profesional (idespecialidad,idmoduloP,nom_modulo,Año_Modulo,IdUsuario)
VALUES

('E01','MP01','Gestión de Soporte Técnico Seguridad y Tecnologias de la Información y Comunicación','2010','usu01'),
('E01','MP02','Desarrollo de software y gestión de base de Datos','2010', 'usu01'),
('E01','MP03','Gestión de Aplicaciones para internet y Producción Multimedia','2010','usu01'),

('E02','MP01','Procesos Contables','2010','usu01'),
('E02','MP02','Contabilidad Pública y Privada','2010','usu01'),
('E02','MP03','Analisis Financiero','2010','usu01'),

('E03','MP01','Instalaciones de sistemas Eléctricos','2010','usu01'),
('E03','MP02','Mantenimiento de Máquinas y Equipos Eléctricos','2010','usu01'),
('E03','MP03','Automatización de Sistemas Eléctricos Industriales','2010','usu01'),

('E04','MP01','Atención Primaria en Salud','2010','usu01'),
('E04','MP02','Servicios Técnicos de Enfermeria Asistencial','2010','usu01'),
('E04','MP03','Servicios Técnicos de Enfermeria Especializada','2010','usu01'),

('E05','MP01','Mantenimiento de los Sistemas de Suspención, Direccion y Frenos Automotrices','2010','usu01'),
('E05','MP02','Mantenimiento del Sistemas de Transmisión de Velocidad Y Fuerza Atomotriz','2010','usu01'),
('E05','MP03','Mantenimiento del Sistema Eléctrico Electrónico Automotriz','2010','usu01'),
('E05','MP04','Mantenimiento de motores de Combustión Interna','2010','usu01'),

('E06','MP01','Diseño Mecánico','2010','usu01'),
('E06','MP02','Tecnología de la soldadura','2010','usu01'),
('E06','MP03','Mecanizado con Máquinas Herramientas','2010','usu01'),
('E06','MP04','Matricería y Fundición','2010','usu01'),
('E06','MP05','Mantenimiento Mecánico','2010','usu01'),

('E07','MP01','Ensayos de Laboratorio','2010','usu01'),
('E07','MP02','Procesos Químicos Industriales','2010','usu01'),
('E07','MP03','Aseguramiento de la Calidad','2010','usu01')

go 
SELECT *  FROM Modulo_Profesional
SELECT * FROM Modulo_Tranversal  
INSERT INTO Modulo_Transversal (idespecialidad,idmoduloT,nom_modulo,Año_Modulo,IdUsuario)
VALUES

('E01','MT01','Comunicación','2010','usu01'),
('E01','MT02','Matemática ','2010','usu01'),
('E01','MT03','Sociedad y Economia','2010','usu01'),
('E01','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E01','MT05','Actividades','2010','usu01'),
('E01','MT06','Informática','2010','usu01'),
('E01','MT07','Idioma Extranjero','2010','usu01'),
('E01','MT08','Investigación Tecnológica','2010','usu01'),
('E01','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E01','MT10','Gestión Empresarial','2010','usu01'),
('E01','MT11','Formación y Orientación ','2010','usu01'),

('E02','MT01','Comunicación','2010','usu01'),
('E02','MT02','Matemática ','2010','usu01'),
('E02','MT03','Sociedad y Economia','2010','usu01'),
('E02','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E02','MT05','Actividades','2010','usu01'),
('E02','MT06','Informática','2010','usu01'),
('E02','MT07','Idioma Extranjero','2010','usu01'),
('E02','MT08','Investigación Tecnológica','2010','usu01'),
('E02','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E02','MT10','Gestión Empresarial','2010','usu01'),
('E02','MT11','Formación y Orientación ','2010','usu01'),

('E03','MT01','Comunicación','2010','usu01'),
('E03','MT02','Matemática ','2010','usu01'),
('E03','MT03','Sociedad y Economia','2010','usu01'),
('E03','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E03','MT05','Actividades','2010','usu01'),
('E03','MT06','Informática','2010','usu01'),
('E03','MT07','Idioma Extranjero','2010','usu01'),
('E03','MT08','Investigación Tecnológica','2010','usu01'),
('E03','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E03','MT10','Gestión Empresarial','2010','usu01'),
('E03','MT11','Formación y Orientación ','2010','usu01'),

('E04','MT01','Comunicación','2010','usu01'),
('E04','MT02','Matemática ','2010','usu01'),
('E04','MT03','Sociedad y Economia','2010','usu01'),
('E04','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E04','MT05','Actividades','2010','usu01'),
('E04','MT06','Informática','2010','usu01'),
('E04','MT07','Idioma Extranjero','2010','usu01'),
('E04','MT08','Investigación Tecnológica','2010','usu01'),
('E04','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E04','MT10','Gestión Empresarial','2010','usu01'),
('E04','MT11','Formación y Orientación ','2010','usu01'),

('E05','MT01','Comunicación','2010','usu01'),
('E05','MT02','Matemática ','2010','usu01'),
('E05','MT03','Sociedad y Economia','2010','usu01'),
('E05','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E05','MT05','Actividades','2010','usu01'),
('E05','MT06','Informática','2010','usu01'),
('E05','MT07','Idioma Extranjero','2010','usu01'),
('E05','MT08','Investigación Tecnológica','2010','usu01'),
('E05','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E05','MT10','Gestión Empresarial','2010','usu01'),
('E05','MT11','Formación y Orientación ','2010','usu01'),

('E06','MT01','Comunicación','2010','usu01'),
('E06','MT02','Matemática ','2010','usu01'),
('E06','MT03','Sociedad y Economia','2010','usu01'),
('E06','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E06','MT05','Actividades','2010','usu01'),
('E06','MT06','Informática','2010','usu01'),
('E06','MT07','Idioma Extranjero','2010','usu01'),
('E06','MT08','Investigación Tecnológica','2010','usu01'),
('E06','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E06','MT10','Gestión Empresarial','2010','usu01'),
('E06','MT11','Formación y Orientación ','2010','usu01'),

('E07','MT01','Comunicación','2010','usu01'),
('E07','MT02','Matemática ','2010','usu01'),
('E07','MT03','Sociedad y Economia','2010','usu01'),
('E07','MT04','Medio Ambiente y Desarrollo Sostenible','2010','usu01'),
('E07','MT05','Actividades','2010','usu01'),
('E07','MT06','Informática','2010','usu01'),
('E07','MT07','Idioma Extranjero','2010','usu01'),
('E07','MT08','Investigación Tecnológica','2010','usu01'),
('E07','MT09','Relaciones en el Entorno del Trabajo','2010','usu01'),
('E07','MT10','Gestión Empresarial','2010','usu01'),
('E07','MT11','Formación y Orientación ','2010','usu01')

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


INSERT INTO UndDidactica_Profesional (IdUndDidacP,Nom_UndDidactica,Horas,Credito,IdModuloP,IdCiclo,IdEspecialidad,AÑO_MODULO)VALUES
--UDs DE COMPUTACIÓN E INFORMÁTICA
('UP01','Organizacion y Administracion de Soporte técnico','3','2','MP01','C01','E01','2010'),
('UP02','Integración de las Tecnologias de Información y Comunicación','4','3','MP01','C01','E01','2010'),
('UP03','Mantenimiento de Equipos de Cómputo','6','4','MP01','C01','E01','2010'),
('UP04','Reparación de Equipos de Cómputo','6','4','MP01','C02','E01','2010'),
('UP05','Didáctica en el uso de Recursos Informáticos','2','1','MP01','C02','E01','2010'),
('UP06','Diseño de Redes de Comunicación','6','5','MP01','C01','E01','2010'),
('UP07','Instalación y configuración de redes de comunicación','4','3','MP01','C02','E01','2010'),
('UP08','Herramientas de Gestión de redes de Comunicación','4','3','MP01','C02','E01','2010'),
('UP09','Seguridad Informática','3','2','MP01','C01','E01','2010'),
('UP10','Administración de Redes','2','2','MP01','C02','E01','2010'),
('UP11','Software de Servidor de Red','4','3','MP01','C02','E01','2010'),

('UP01','Analisis y diseño de Sistemas','6','5','MP02','C03','E01','2010'),
('UP02','Herramientas de Desarrollo de Software','6','4','MP02','C03','E01','2010'),
('UP03','Taller de Base de Datos','4','3','MP02','C03','E01','2010'),
('UP04','Metodologías de Desarrollo de Software','2','2','MP02','C04','E01','2010'),
('UP05','Taller de Programación Concurrente','8','6','MP02','C04','E01','2010'),
('UP06','Taller de Programación Distribuida','8','6','MP02','C04','E01','2010'),
('UP07','Lógica de Programación','2','1','MP02','C03','E01','2010'),
('UP08','Taller de Modelamiento de Software','4','3','MP02','C03','E01','2010'),
('UP09','Administración de Base de Datos','6','4','MP02','C04','E01','2010'),

('UP01','Diseño Gráfico','5','4','MP03','C05','E01','2010'),
('UP02','Animación de Gráficos','5','4','MP03','C05','E01','2010'),
('UP03','Herramientas Multimedia','4','3','MP03','C05','E01','2010'),
('UP04','Producción Audiovisual','6','4','MP03','C06','E01','2010'),
('UP05','Diseño Web','4','3','MP03','C05','E01','2010'),
('UP06','Taller de Programación Web','10','7','MP03','C06','E01','2010'),
('UP07','Comercio Electrónico','3','2','MP03','C06','E01','2010'),
('UP08','Aplicaciones Móviles','4','3','MP03','C06','E01','2010'),
('UP09','Gestión y Administración Web','6','4','MP03','C05','E01','2010'),

--UDs de Contabilidad
('UP01','Contabilidad General I','6','4','MP01','C01','E02','2010'),
('UP02','Contabilidad General II','8','6','MP01','C02','E02','2010'),
('UP03','Plan Contable','4','3','MP01','C01','E02','2010'),
('UP04','Documentación Comercial y Contable','6','4','MP01','C01','E02','2010'),
('UP05','Administración Empresarial','3','2','MP01','C01','E02','2010'),
('UP06','Legislación Laboral','4','3','MP01','C02','E02','2010'),
('UP07','Legislación Comercial','4','3','MP01','C01','E02','2010'),
('UP08','Legislación Tributaria','4','3','MP01','C02','E02','2010'),

('UP01','Fundamentos de Costos','6','4','MP02','C02','E02','2010'),
('UP02','Contabilidad de Costos','6','4','MP02','C03','E02','2010'),
('UP03','Contabilidad de Sociedades','7','5','MP02','C04','E02','2010'),
('UP04','Contabilidad Aplicada','8','6','MP02','C04','E02','2010'),
('UP05','Técnica Presupuestal','6','4','MP02','C03','E02','2010'),
('UP06','Contabilidad Gubernamental I','5','4','MP02','C03','E02','2010'),
('UP07','Contabilidad Gubernamental II','7','5','MP02','C04','E02','2010'),
('UP08','Aplicativos Informáticos','5','4','MP02','C03','E02','2010'),

('UP01','Formulación de Estados Financieros','6','4','MP03','C05','E02','2010'),
('UP02','Análisis e Interpretación de Estados Financieros','6','4','MP03','C06','E02','2010'),
('UP03','Fundamentos de Finanzas','4','3','MP03','C05','E02','2010'),
('UP04','Finanzas Públicas','4','3','MP03','C06','E02','2010'),
('UP05','Formulación y Evaluación de Proyectos','5','4','MP03','C05','E02','2010'),
('UP06','Planeamiento de la Auditoria','4','3','MP03','C05','E02','2010'),
('UP07','Técnicas y Procedimientos de Auditoria','4','3','MP03','C06','E02','2010'),
('UP08','Contabilidad de Entidades Financieras I','6','4','MP03','C05','E02','2010'),
('UP09','Contabilidad de Entidades Financieras II','6','4','MP03','C06','E02','2010'),
('UP10','Cálculo Financiero','5','4','MP03','C06','E02','2010'),

--UDs DE ELECTROTECNIA INDUSTRIAL
('UP01','Fundamentos de Electrotecnia','8','6','MP01','C01','E03','2010'),
('UP02','Mecánica Básica','4','3','MP01','C01','E03','2010'),
('UP03','Instalaciones Eléctricas I','7','5','MP01','C01','E03','2010'),
('UP04','Instalaciones Eléctricas II','6','4','MP01','C02','E03','2010'),
('UP05','Dipositivos Electrónicos','4','3','MP01','C01','E03','2010'),
('UP06','Montaje e Instalación de Sub-estaciones','4','3','MP01','C02','E03','2010'),
('UP07','Distribución de Baja y Media Tensión','4','3','MP01','C02','E03','2010'),
('UP08','Equipos e Instrumentos de Medición','4','3','MP01','C02','E03','2010'),
('UP09','Proyecto de Mantenimiento de Sistemas Eléctricos','4','3','MP01','C02','E03','2010'),

('UP01','Tecnologia de Materiales','2','1','MP02','C03','E03','2010'),
('UP02','Máquinas Eléctricas','8','6','MP02','C03','E03','2010'),
('UP03','Generación y Transmisión de Energia Eléctrica','6','4','MP02','C03','E03','2010'),
('UP04','Instalacion de Máquinas Eléctricas','6','4','MP02','C03','E03','2010'),
('UP05','Rebobinado de Máquinas Eléctricas','8','6','MP02','C04','E03','2010'),
('UP06','Mantenimiento de Sistemas y Equípos Eléctricos ','8','6','MP02','C04','E03','2010'),
('UP07','Electrónica de Potencia','4','3','MP02','C04','E03','2010'),
('UP08','Proyecto de Máquinas y Equipos','4','3','MP02','C04','E03','2010'),

('UP01','Sistema de Control Automático','4','3','MP03','C05','E03','2010'),
('UP02','Electrónica de Potencia Aplicada','6','4','MP03','C05','E03','2010'),
('UP03','Electroneumática y Eletrohidráulica','6','4','MP03','C05','E03','2010'),
('UP04','Tableros de Control y Mando Automático','8','6','MP03','C05','E03','2010'),
('UP05','Controlador Lógico Programable y Periféricos','8','6','MP03','C06','E03','2010'),
('UP06','Mantenimiento de Sistema de Control Automático ','6','4','MP03','C06','E03','2010'),
('UP07','Instrumentación y Control de Procesos Industriales','6','4','MP03','C06','E03','2010'),
('UP08','Proyecto de Sistemas de Automatización Industrial','4','3','MP03','C06','E03','2010'),

--UDs DE ENFERMERIA  TÉCNICA
('UP01','Anatomia Funcional','5','4','MP01','C01','E04','2010'),
('UP02','Primeros Auxilios','6','4','MP01','C01','E04','2010'),
('UP03','Educación para la Salud','6','4','MP01','C02','E04','2010'),
('UP04','Actividades en Salud Pública','10','7','MP01','C02','E04','2010'),
('UP05','Asistencia en Inmunizaciones','6','4','MP01','C01','E04','2010'),
('UP06','Actividades en Salud Comunitaria','6','4','MP01','C02','E04','2010'),
('UP07','Actividades en Epidemiologia','5','4','MP01','C01','E04','2010'),

('UP01','Documentación en Salud','2','1','MP02','C03','E04','2010'),
('UP02','Bioseguridad','5','4','MP02','C03','E04','2010'),
('UP03','Asistencia Básica Hospitalaria','10','7','MP02','C03','E04','2010'),
('UP04','Nutrición y Dietas','5','4','MP02','C03','E04','2010'),
('UP05','Procedimientos Invasivos y no Invasivos','4','3','MP02','C04','E04','2010'),
('UP06','Asistencia en la Administración de Medicamentos','5','4','MP02','C04','E04','2010'),
('UP07','Muestras Biológicas','4','3','MP02','C04','E04','2010'),
('UP08','Asistencia al Usuario con Patologias','4','3','MP02','C04','E04','2010'),
('UP09','Asistencia al Usuario Quirúrgico','7','5','MP02','C04','E04','2010'),

('UP01','Atención en Salud Materna','5','4','MP03','C05','E04','2010'),
('UP02','Salud del Niño y del Adolecente','7','5','MP03','C05','E04','2010'),
('UP03','Asistencia del Adulto Mayor','7','5','MP03','C05','E04','2010'),
('UP04','Asistencia de Enfermeria en Salud Mental','5','4','MP03','C05','E04','2010'),
('UP05','Asistencia en Fisioterapia y Rehabilitación','6','4','MP03','C06','E04','2010'),
('UP06','Asistencia en Salud Bucal','4','3','MP03','C06','E04','2010'),
('UP07','Asistencia en Medicina Alternativa','7','5','MP03','C06','E04','2010'),
('UP08','Asistencia al Usuario oncológico','7','5','MP03','C06','E04','2010'),

--UDs de MECANICA AUTOMOTRIZ
('UP01','Dibujo Mecánico','4','3','MP01','C01','E05','2010'),
('UP02','Mecánica de Taller','8','6','MP01','C01','E05','2010'),
('UP03','Sistema de Suspensíon y Dirección','10','7','MP01','C01','E05','2010'),
('UP04','Hidroneumática','4','3','MP01','C02','E05','2010'),
('UP05','Laboratorio de Sistemas','4','3','MP01','C02','E05','2010'),
('UP06','Prevención de Riesgos','3','2','MP01','C02','E05','2010'),
('UP07','Sistema de Frenos','11','8','MP01','C02','E05','2010'),

('UP01','Mecanismo de Embrague Y Caja de Velocidades','8','6','MP02','C03','E05','2010'),
('UP02','Mecanismo Diferencial','4','3','MP02','C03','E05','2010'),
('UP03','Soldadura Aplicada a Mecanismos Automotrices','6','4','MP02','C03','E05','2010'),
('UP04','Laboratorio de Mecanismo de Transmisión','4','3','MP02','C03','E05','2010'),

('UP01','Dibujo Eléctrico Automotriz','3','2','MP03','C04','E05','2010'),
('UP02','Fundamentos Eléctricos y Electrónicos Automotrices','4','3','MP03','C04','E05','2010'),
('UP03','Sistema de Carga y Arranque','6','4','MP03','C04','E05','2010'),
('UP04','Sistema de Encendido Convencional y Electrónico','6','4','MP03','C04','E05','2010'),
('UP05','Sistemas de Luces y Controles Auxiliares','5','4','MP03','C04','E05','2010'),

('UP01','Motores de Combustión Interna Otto','10','7','MP04','C05','E05','2010'),
('UP02','Inyección Electrónica Otto','6','4','MP04','C05','E05','2010'),
('UP03','Laboratorio de Motores','5','4','MP04','C05','E05','2010'),
('UP04','Conversión de Motores a Combustibles Alternos','4','3','MP04','C05','E05','2010'),
('UP05','Motores de Combustión Interna Diesel','6','4','MP04','C06','E05','2010'),
('UP06','Laboratorio de Sistema Diesel','6','4','MP04','C06','E05','2010'),
('UP07','Rectificaciones Automotrices','6','4','MP04','C06','E05','2010'),
('UP08','Afinamiento de Motores de Conbustión Interna','4','3','MP04','C06','E05','2010'),
('UP09','Inyección Electrónica Diesel','3','2','MP04','C06','E05','2010'),

--UDs DE MECÁNICA DE PRODUCCIÓN
('UP01','Dibujo Técnico','4','3','MP01','C01','E06','2010'),
('UP02','Materiales Industriales','3','2','MP01','C01','E06','2010'),
('UP03','Mecánica de Banco','8','6','MP01','C01','E06','2010'),
('UP04','Máquinas Básicas','4','3','MP01','C02','E06','2010'),
('UP05','Dibujo Asistido por Ordenador','4','3','MP01','C02','E06','2010'),
('UP06','Cálculo de Elementos de Máquinas','3','2','MP01','C02','E06','2010'),

('UP01','Dibujo y Cálculo de Soldadura','3','2','MP02','C01','E06','2010'),
('UP02','Soldadura Oxigas','6','4','MP02','C01','E06','2010'),
('UP03','Soldadura Eléctrica','7','5','MP02','C02','E06','2010'),
('UP04','Soldadura Mixta','4','3','MP02','C02','E06','2010'),

('UP01','Máquinas Convensionales I','12','9','MP03','C03','E06','2010'),
('UP02','Máquinas Convensionales II','12','9','MP03','C04','E06','2010'),
('UP03','Máquinas Especiales','4','3','MP03','C03','E06','2010'),
('UP04','Máquinas de Control Numérico Computarizado','6','4','MP03','C04','E06','2010'),
('UP05','Técnicas de Producción I','6','4','MP03','C03','E06','2010'),
('UP06','Técnicas de Producción II','6','5','MP03','C04','E06','2010'),

('UP01','Modelería y Fundición','6','4','MP04','C05','E06','2010'),
('UP02','Moldes Permanentes','6','4','MP04','C05','E06','2010'),
('UP03','Matrices de Chapas','8','6','MP04','C06','E06','2010'),
('UP04','Tratamientos Térmicos y ensayos','4','3','MP04','C06','E06','2010'),

('UP01','Gestión del Mantenimiento','2','1','MP05','C05','E06','2010'),
('UP02','Seguridad e Higiene Industrial','2','1','MP05','C05','E06','2010'),
('UP03','Mantenimiento Mecánico','8','6','MP05','C05','E06','2010'),
('UP04','Automatización','8','6','MP05','C06','E06','2010'),
('UP05','Mantenimiento Eléctrico','3','2','MP05','C06','E06','2010'),

--UDs DE QUÍMICA INDUSTRIAL
('UP01','Ensayos Físicos y Organolépticos','4','3','MP01','C01','E07','2010'),
('UP02','Ensayos Químicos','10','8','MP01','C01','E07','2010'),
('UP03','Cálculos Fundamentales en Química','5','4','MP01','C01','E07','2010'),
('UP04','Ensayos de Impacto Ambiental','3','2','MP01','C01','E07','2010'),
('UP05','Ensayos por Instrumentación','4','3','MP01','C02','E07','2010'),
('UP06','Ensayos Bromatológicos','6','4','MP01','C02','E07','2010'),
('UP07','Ensayos Químicos Industriales','10','8','MP01','C02','E07','2010'),

('UP01','Planeamiento y Control de la Producción','3','2','MP02','C02','E07','2010'),
('UP02','Estadistica Aplicada','3','2','MP02','C03','E07','2010'),
('UP03','Servicios Auxiliares de Proceso','3','2','MP02','C03','E07','2010'),
('UP04','Balance de Materia Y Energia','6','4','MP02','C03','E07','2010'),
('UP05','Operaciones con Transporte de Fluidos','6','4','MP02','C03','E07','2010'),
('UP06','Tratamiento de Sólidos','4','3','MP02','C03','E07','2010'),
('UP07','Seguridad e Higiene Industrial','3','2','MP02','C04','E07','2010'),
('UP08','Producción Industrial','12','9','MP02','C04','E07','2010'),
('UP09','Sistema de Control de Procesos','4','3','MP02','C04','E07','2010'),
('UP10','Procesos Químicos','5','4','MP02','C04','E07','2010'),
('UP11','Tratamiento de Efluentes','4','3','MP02','C05','E07','2010'),

('UP01','Sistemas de Calidad','6','4','MP03','C05','E07','2010'),
('UP02','Medidas de Variables Fisicoquímicas','6','4','MP03','C06','E07','2010'),
('UP03','Control de Calidad en Procesos Químicos Inorgánicos','6','4','MP03','C05','E07','2010'),
('UP04','Control de Calidad en la Agroindustria I','4','3','MP03','C05','E07','2010'),
('UP05','Metrologia','4','3','MP03','C05','E07','2010'),
('UP06','Calidad y Productividad','4','3','MP03','C06','E07','2010'),
('UP07','Auditorias de Calidad','3','2','MP03','C06','E07','2010'),
('UP08','Control de Calidad en la Agroindustria II','4','3','MP03','C06','E07','2010'),
('UP09','Control de Calidad en Procesos Químicos Orgánicos','6','4','MP03','C06','E07','2010')
go 
SELECT * FROM UndDidactica_Prof 
INSERT INTO UndDidactica_Transversal (IdUndDidacT,Nom_UndDidactica,Horas,Credito,IdModuloT,IdCiclo,IdEspecialidad,AÑO_MODULO)VALUES
--UNIDADES DIDACTICAS TRANSVERSALES C.I.
('UT01','Técnicas de Comunicación','2','1.5','MT01','C01','E01','2010'),
('UT02','Interpretación y Producción de Textos','2','1.5','MT01','C02','E01','2010'),
('UT01','Lógica y Funciones','2','1.5','MT02','C01','E01','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E01','2010'),
('UT01','Sociedad y Economia en la Globaización','3','2','MT03','C03','E01','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E01','2010'),
('UT01','Cultura Física y Deporte','2','1','MT05','C01','E01','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E01','2010'),
('UT01','Informática e Internet','2','1.5','MT06','C01','E01','2010'),
('UT02','Ofimática','2','1.5','MT06','C02','E01','2010'),
('UT01','Comunicación Interpersonal','2','1.5','MT07','C04','E01','2010'),
('UT02','Comunicación Empresarial','2','1.5','MT07','C05','E01','2010'),
('UT01','Fundamentos de Investigación','2','1.5','MT08','C02','E01','2010'),
('UT02','Investigación e Innovación Tecnológica','2','1.5','MT08','C03','E01','2010'),
('UT03','Proyectos de Investigación e Innovación Tecnológica','4','3','MT08','C04','E01','2010'),
('UT01','Ética Profesional','2','1.5','MT09','C05','E01','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E01','2010'),
('UT01','Organización y Constitución de Empresas','2','1.5','MT10','C05','E01','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E01','2010'),
('UT01','Legislación e Inserción Laboral','3','2','MT11','C06','E01','2010'),
--UNIDADES DIDACTICAS TRANSVERSALES C.T.
('UT01','Técnicas de Comunicación','2','1.5','MT01','C01','E02','2010'),
('UT02','Interpretación y Producción de Textos','2','1.5','MT01','C02','E02','2010'),
('UT01','Lógica y Funciones','2','1.5','MT02','C01','E02','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E02','2010'),
('UT01','Sociedad y Economia en la Globaización','3','2','MT03','C03','E02','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E02','2010'),
('UT01','Cultura Física y Deporte','2','1','MT05','C01','E02','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E02','2010'),
('UT01','Informática e Internet','2','1.5','MT06','C01','E02','2010'),
('UT02','Ofimática','2','1.5','MT06','C02','E02','2010'),
('UT01','Comunicación Interpersonal','2','1.5','MT07','C04','E02','2010'),
('UT02','Comunicación Empresarial','2','1.5','MT07','C05','E02','2010'),
('UT01','Fundamentos de Investigación','2','1.5','MT08','C02','E02','2010'),
('UT02','Investigación e Innovación Tecnológica','2','1.5','MT08','C03','E02','2010'),
('UT03','Proyectos de Investigación e Innovación Tecnológica','4','3','MT08','C04','E02','2010'),
('UT01','Ética Profesional','2','1.5','MT09','C05','E02','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E02','2010'),
('UT01','Organización y Constitución de Empresas','2','1.5','MT10','C05','E02','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E02','2010'),
('UT01','Legislación e Inserción Laboral','3','2','MT11','C06','E02','2010'),

--UNIDADES DIDACTICAS TRANSVERSALES E.I
('UT01','Técnicas de Comunicación','2','1.5','MT01','C01','E03','2010'),
('UT02','Interpretación y Producción de Textos','2','1.5','MT01','C02','E03','2010'),
('UT01','Lógica y Funciones','2','1.5','MT02','C01','E03','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E03','2010'),
('UT01','Sociedad y Economia en la Globaización','3','2','MT03','C03','E03','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E03','2010'),
('UT01','Cultura Física y Deporte','2','1','MT05','C01','E03','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E03','2010'),
('UT01','Informática e Internet','2','1.5','MT06','C01','E03','2010'),
('UT02','Ofimática','2','1.5','MT06','C02','E03','2010'),
('UT01','Comunicación Interpersonal','2','1.5','MT07','C04','E03','2010'),
('UT02','Comunicación Empresarial','2','1.5','MT07','C05','E03','2010'),
('UT01','Fundamentos de Investigación','2','1.5','MT08','C02','E03','2010'),
('UT02','Investigación e Innovación Tecnológica','2','1.5','MT08','C03','E03','2010'),
('UT03','Proyectos de Investigación e Innovación Tecnológica','4','3','MT08','C04','E03','2010'),
('UT01','Ética Profesional','2','1.5','MT09','C05','E03','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E03','2010'),
('UT01','Organización y Constitución de Empresas','2','1.5','MT10','C05','E03','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E03','2010'),
('UT01','Legislación e Inserción Laboral','3','2','MT11','C06','E03','2010'),
--UNIDADES DIDACTICAS TRANSVERSALES E.T.
('UT01','Técnicas de Comunicación','2','1.5','MT01','C01','E04','2010'),
('UT02','Interpretación y Producción de Textos','2','1.5','MT01','C02','E04','2010'),
('UT01','Lógica y Funciones','2','1.5','MT02','C01','E04','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E04','2010'),
('UT01','Sociedad y Economia en la Globaización','3','2','MT03','C03','E04','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E04','2010'),
('UT01','Cultura Física y Deporte','2','1','MT05','C01','E04','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E04','2010'),
('UT01','Informática e Internet','2','1.5','MT06','C01','E04','2010'),
('UT02','Ofimática','2','1.5','MT06','C02','E04','2010'),
('UT01','Comunicación Interpersonal','2','1.5','MT07','C04','E04','2010'),
('UT02','Comunicación Empresarial','2','1.5','MT07','C05','E04','2010'),
('UT01','Fundamentos de Investigación','2','1.5','MT08','C02','E04','2010'),
('UT02','Investigación e Innovación Tecnológica','2','1.5','MT08','C03','E04','2010'),
('UT03','Proyectos de Investigación e Innovación Tecnológica','4','3','MT08','C04','E04','2010'),
('UT01','Ética Profesional','2','1.5','MT09','C05','E04','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E04','2010'),
('UT01','Organización y Constitución de Empresas','2','1.5','MT10','C05','E04','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E04','2010'),
('UT01','Legislación e Inserción Laboral','3','2','MT11','C06','E04','2010'),

--UNIDADES DIDACTICAS TRANSVERSALES M.A.
('UT01','Técnicas de Comunicación','2','1.5','MT01','C01','E05','2010'),
('UT02','Interpretación y Producción de Textos','2','1.5','MT01','C02','E05','2010'),
('UT01','Lógica y Funciones','2','1.5','MT02','C01','E05','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E05','2010'),
('UT01','Sociedad y Economia en la Globaización','3','2','MT03','C03','E05','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E05','2010'),
('UT01','Cultura Física y Deporte','2','1','MT05','C01','E05','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E05','2010'),
('UT01','Informática e Internet','2','1.5','MT06','C05','E05','2010'),
('UT02','Ofimática','2','1.5','MT06','C02','E05','2010'),
('UT01','Comunicación Interpersonal','2','1.5','MT07','C04','E05','2010'),
('UT02','Comunicación Empresarial','2','1.5','MT07','C05','E05','2010'),
('UT01','Fundamentos de Investigación','2','1.5','MT08','C02','E05','2010'),
('UT02','Investigación e Innovación Tecnológica','2','1.5','MT08','C03','E05','2010'),
('UT03','Proyectos de Investigación e Innovación Tecnológica','4','3','MT08','C04','E05','2010'),
('UT01','Ética Profesional','2','1.5','MT09','C05','E05','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E05','2010'),
('UT01','Organización y Constitución de Empresas','2','1.5','MT10','C05','E05','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E05','2010'),
('UT01','Legislación e Inserción Laboral','3','2','MT11','C06','E05','2010'),


--UNIDADES DIDACTICAS TRANSVERSALES M.A.
('UT01','Técnicas de Comunicación','2','1.5','MT01','C01','E06','2010'),
('UT02','Interpretación y Producción de Textos','2','1.5','MT01','C02','E06','2010'),
('UT01','Lógica y Funciones','2','1.5','MT02','C01','E06','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E06','2010'),
('UT01','Sociedad y Economia en la Globaización','3','2','MT03','C03','E06','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E06','2010'),
('UT01','Cultura Física y Deporte','2','1','MT05','C01','E06','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E06','2010'),
('UT01','Informática e Internet','2','1.5','MT06','C01','E06','2010'),
('UT02','Ofimática','2','1.5','MT06','C02','E06','2010'),
('UT01','Comunicación Interpersonal','2','1.5','MT07','C04','E06','2010'),
('UT02','Comunicación Empresarial','2','1.5','MT07','C05','E06','2010'),
('UT01','Fundamentos de Investigación','2','1.5','MT08','C02','E06','2010'),
('UT02','Investigación e Innovación Tecnológica','2','1.5','MT08','C03','E06','2010'),
('UT03','Proyectos de Investigación e Innovación Tecnológica','4','3','MT08','C04','E06','2010'),
('UT01','Ética Profesional','2','1.5','MT09','C05','E06','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E06','2010'),
('UT01','Organización y Constitución de Empresas','2','1.5','MT10','C05','E06','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E06','2010'),
('UT01','Legislación e Inserción Laboral','3','2','MT11','C06','E06','2010'),

--UNIDADES DIDACTICAS TRANSVERSALES QI
('UT01','Técnicas de Comunicación','2','1.5','MT01','C01','E07','2010'),
('UT02','Interpretación y Producción de Textos','2','1.5','MT01','C02','E07','2010'),
('UT01','Lógica y Funciones','2','1.5','MT02','C01','E07','2010'),
('UT02','Estadistica General','2','1.5','MT02','C02','E07','2010'),
('UT01','Sociedad y Economia en la Globaización','3','2','MT03','C03','E07','2010'),
('UT01','Medio Ambiente y Desarrollo Sostenible','3','2','MT04','C03','E07','2010'),
('UT01','Cultura Física y Deporte','2','1','MT05','C01','E07','2010'),
('UT02','Cultura Artistica','2','1','MT05','C02','E07','2010'),
('UT01','Informática e Internet','2','1.5','MT06','C01','E07','2010'),
('UT02','Ofimática','2','1.5','MT06','C02','E07','2010'),
('UT01','Comunicación Interpersonal','2','1.5','MT07','C04','E07','2010'),
('UT02','Comunicación Empresarial','2','1.5','MT07','C05','E07','2010'),
('UT01','Fundamentos de Investigación','2','1.5','MT08','C02','E07','2010'),
('UT02','Investigación e Innovación Tecnológica','2','1.5','MT08','C03','E07','2010'),
('UT03','Proyectos de Investigación e Innovación Tecnológica','4','3','MT08','C04','E07','2010'),
('UT01','Ética Profesional','2','1.5','MT09','C05','E07','2010'),
('UT02','Liderazgo y Trabajo en Equipo','2','1.5','MT09','C06','E07','2010'),
('UT01','Organización y Constitución de Empresas','2','1.5','MT10','C05','E07','2010'),
('UT02','Proyecto Empresarial','2','1.5','MT10','C06','E07','2010'),
('UT01','Legislación e Inserción Laboral','3','2','MT11','C06','E07','2010')
GO

SELECT * FROM UndDidactica_Profesional
SELECT * FROM UndDidactica_Transversal

INSERT INTO TIPOINGRESO(IDTIPO,DESCRIPCION)VALUES
('T01', 'ADMISIÓN'),
('T02', 'TRASLADO')

select * from TipoIngreso

INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'00000000', N'D01', N'T01', N'USU03', N'E02', N'APONTE', N'APONTE', N'PEDRO DAMIAN', CAST(0x4A1B0B00 AS Date), N'S. J. LURIGANCHO', N'LIMA', N'LIMA', N'17 ', N'M', N'Soltero', N' ASENT. H  JOSE MARIATEGUI MZ K1 LT 18', N'3624399', N'I.E. JOSE CARLOS MARIATEGUI  0152 .S.J.L ', N'2010', N'Computación e Informática', N'N', N'', N'', N'Dia', N'XDDEMIXD@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'APONTE', N'LAURA', N'PEDRO DAMIAN', N'        ', N'OBRERO', N'ASENT. H  JOSE MARIATEGUI MZ K', N'         ', N'APONTE', N'SALAZAR', N'LUCIA DIONICIA', N'        ', N'COSMETOLOGA', N'ASENT. H  JOSE MARIATEGUI MZ K', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'46880758', N'D01', N'T01', N'USU03', N'E01', N'NARRO ', N'MARZANO', N'HAIDER YOLVI', CAST(0xF5180B00 AS Date), N'CENTRO DE LIMA', N'LIMA', N'LIMA', N'18 ', N'M', N'Soltero', N' M,Z D1. LT 7 AA.HH.CUIDAD DE LOS CONSTRUCTORES II', N'2537481', N'SAN JOSE OBRERO     ', N'2007', N'Computación e Informática', N'N', N'', N'', N'Dia', N'HAIDER_SJO_90@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'NARRO', N'LEIVA', N'LORGIO  FELICIANO', N'        ', N' OMERCIANTE', N'SAN JUAN DE LURIGANCHO', N'         ', N'MARZANO ', N'GUTIERREZ', N'VICTORIA GREGORIA', N'        ', N'ENFERMERA TECNICA', N' M,Z D1. LT 7 AA.HH.CUIDAD DE ', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'70068285', N'D01', N'T01', N'USU03', N'E01', N'CODORI ', N'CHACON ', N'ERIKA ROXANA', CAST(0xD71B0B00 AS Date), N'S.J.LURIGANCHO', N'LIMA', N'LIMA', N'16 ', N'F', N'Soltero', N'MZ A5 LT 16 SUB LT8 SECTOR LOMAS BAJAS JICAMARCA', N'990891120', N'EL B OSQUE N° 1182', N'2010', N'Computación e Informática', N'N', N'', N'', N'Dia', N'ROXANA_CONDORI@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'CONDORI', N'TICA ', N'TEOFILO', N'24664203', N'COSTURERO', N'MZ A5 LT 16 SUB LT8 SECTOR LOM', N'990891120', N'CHACON ', N'HUAYHUA', N'PRAXIDA', N'24704348', N'', N'MZ A5 LT 16 SUB LT8 SECTOR LOM', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'47259765', N'D01', N'T01', N'USU03', N'E01', N'OYOLO', N'MARTINEZ', N'JESUS ALBERTO', CAST(0xCB180B00 AS Date), N'S.J.LURIGANCHO', N'LIMA', N'LIMA', N'19 ', N'M', N'Soltero', N'MZ P1 LT 16 J.C.A', N'958078618', N'I.E NICOLAS COPERNICO', N'2008', N'Computación e Informática', N'N', N'', N'', N'Dia', N'@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'OYOLO', N'ATOCCSA', N'PELAYO', N'08310217', N'ELECTRICISTA', N'MZ A5 LT 16 SUB LT8 SECTOR LOM', N'989812256', N'MARTINEZ', N'EULOGIO', N'CRISANTA', N'        ', N'', N'MZ A5 LT 16 SUB LT8 SECTOR LOM', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'44704976', N'D01', N'T01', N'USU03', N'E01', N'VILLAVICENCIO', N'SANTE', N'CLEMENTINA', CAST(0xC1120B00 AS Date), N'ICA', N'ICA', N'ICA', N'23 ', N'M', N'Soltero', N'MZ R1 LT 19 AA.HH. JUAN PABLO II 3° ZONA', N'4594306', N'MIGUEL GRAU', N'2004', N'Computación e Informática', N'N', N'', N'', N'Dia', N'SHARUMI_SHERLYN@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'VILLAVICENCIO ', N'GALVEZ', N'VICTOR', N'        ', N'EMPLEADO', N'', N'         ', N'SANTE', N'CANCHARI', N'CLEMENTINA', N'        ', N'AMA DE CASA ', N'SAN JUAQUIN 3° ETAPA', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'43562626', N'D01', N'T01', N'USU03', N'E01', N'MULLIZACA', N'MULLISACA', N'IZOLINA', CAST(0x9A100B00 AS Date), N'AZANGORA', N'PUTINA', N'PUNO', N'24 ', N'F', N'Soltero', N'MZ C 2 LT 12  MATRISCAL CACERES ', N'995834801', N'DANIEL ALCIDES GARRION ', N'2002', N'Computación e Informática', N'N', N'', N'', N'Dia', N'SOLEM86@GMAIL', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'MULLIZACA ', N'MULLISACA', N'ADRIAN', N'        ', N'CHOFER', N'', N'         ', N'MULLISACA', N'CACERES', N'VICTORIA', N'        ', N'SU CASA', N'', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'47517721', N'D01', N'T01', N'USU03', N'E01', N'PAREDES', N'VIDAL', N'JOSE VIRIGILIO ', CAST(0x181A0B00 AS Date), N' LIMA', N'LIMA', N'LIMA', N'18 ', N'M', N'Soltero', N'AV. PAMPA ALTA AA.HH JOSE CARLOS MARIATEGUI', N'995337156', N'13 DE AGOSTO', N'2010', N'Computación e Informática', N'N', N'', N'', N'Dia', N'BADBOY14_93@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0x5B950A00 AS Date), N'PAREDES', N'RODRIGUEZ', N'HENRY ANTONIO', N'        ', N'COMERCIANTE', N'AV. PAMPA ALTA AA.HH JOSE CARL', N'999904518', N'VIDAL ', N'CANPHUALLPA', N'ROSAURA', N'        ', N'COMERCIANTE', N'AV. PAMPA ALTA AA.HH JOSE CARL', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'47092655', N'D01', N'T01', N'USU03', N'E01', N'QUISPE', N'CHUCYA', N'STEFANY', CAST(0x5B180B00 AS Date), N'S.J. LURIGANCHO', N'LIMA', N'LIMA', N'19 ', N'F', N'Soltero', N'CALLE MARGARITA MZ P LT 3 SANTA MARTHA', N'7608946', N'EL AMAUTA N 164', N'2007', N'Computación e Informática', N'N', N'', N'', N'Dia', N'@', N'S', N'CONTABILIDAD', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'QUISPE ', N'CUSIPAUCAR', N'SAMUEL', N'        ', N'AUTOSERVICIO', N'CALLE MARGARITA MZ P LT 3 SANT', N'992259059', N'CHUCYA', N'BALLADARES', N'GUILLERMINA', N'        ', N'AMA D CASA', N'CALLE MARGARITA MZ P LT 3 SANT', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'70813193', N'D01', N'T01', N'USU03', N'E01', N'QUISPE', N'ALATA', N'BERENISSE SAVIANA', CAST(0xA2190B00 AS Date), N'TACNA', N'TACNA', N'TACNA', N'18 ', N'F', N'Soltero', N'JR. PEREZ DE ARMENDARIZ MZ H 14 LT 20', N'', N'SIMON BOLIVAR', N'2007', N'Computación e Informática', N'N', N'', N'', N'Dia', N'@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'QUISPE', N'RUIZ', N'ABELINO', N'        ', N'ESTUDIANTE', N'JR. PEREZ DE ARMENDARIZ MZ H 1', N'         ', N'ALATA', N'MERINO ', N'MARIA CARMEN', N'        ', N'ESTUDIANTE', N'JR. PEREZ DE ARMENDARIZ MZ H 1', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'47798791', N'D01', N'T01', N'USU03', N'E01', N'NINA', N'PALMA', N'LICELY', CAST(0xB5190B00 AS Date), N'YANATILE', N'CALCA', N'CUZCO', N'19 ', N'F', N'Soltero', N'AV CANTO GRANDE PDRO "2"', N'3892624', N'SAN LUIS GONZAGA', N'2009', N'Computación e Informática', N'N', N'', N'', N'Dia', N'@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'NINA', N'HUAMAN', N'JUAN BAUTISTA', N'        ', N'PROFESOR', N'AV CANTO GRANDE PDRO "2"', N'         ', N'PALMA', N'ROZAS', N'EUFRACIA', N'        ', N'AMA DE CASA', N'AV CANTO GRANDE PDRO "2" MZ R ', N'         ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'72208950', N'D01', N'T01', N'USU03', N'E01', N'MONTOYA', N'JIMENEZ', N'KRISTELL MEREDY ', CAST(0xB51B0B00 AS Date), N'S.J LURIGANCHO. ', N'LIMA', N'LIMA', N'17 ', N'F', N'Soltero', N'JR.AEROLITOS 338 STA ELIZABETH. - LAS FLORES 21', N'3882836', N'I.E.N° 100 2SANTA ELIZABETH"', N'2009', N'Computación e Informática', N'N', N'', N'', N'Dia', N'KRISAMOR_CELOS94@HOTMAIL.COM', N'N', N'', N'C:\fotos\ALUMNOS.png', CAST(0xB9330B00 AS Date), N'MONTOYA', N'ATOCCSA', N'JUAN FLORENCIO', N'28480038', N'TRABAJADOR INDEPENDIENTE', N'JR.AEROLITOS 338 STA ELIZABETH', N'3882836  ', N'JIMENEZ ', N'CANALES', N'LOURDES ASUNTA', N'07866728', N'PROFESORA', N'JR.AEROLITOS 338 STA ELIZABETH', N'3882836  ')
INSERT [dbo].[Alumno] ([IdAlumno], [IdDistrito], [IdTipo], [IdUsuario], [IdEspecialidad], [Ape_paterno], [Ape_Materno], [Nom_Alumno], [Fecha_Nac], [Distrito_Nac], [Provincia_Nac], [Departamento_Nac], [Edad], [Sexo_Alumno], [Estado_Civil], [Dirección], [Telef_Alumno], [Nombre_IE], [AñoEgreso_IE], [Nom_Especialidad], [Trabaja], [CentroTrabajo], [Func_Trabajo], [Nom_Turno], [E_Mail], [Estudia], [Estudia_Especialidad], [foto], [Año_Ingreso], [Ape_pat_padre], [Ape_mat_padre], [Nom_padre], [dni_padre], [Ocupacion_padre], [Domicilio_padre], [Telef_padre], [Ape_pat_madre], [Ape_mat_madre], [Nom_madre], [dni_madre], [Ocupacion_madre], [Domicilio_madre], [Telef_madre]) VALUES (N'76239230', N'D01', N'T01', N'USU03', N'E01', N'OSORIO', N'VALDEZ', N'YESSICA CORINA', CAST(0x881C0B00 AS Date), N'S.J.LURIGANCHO', N'LIMA', N'LIMA ', N'16 ', N'F', N'Soltero', N'psje.4 A sector Huanta  II ampliacion', N'999338251', N'I.E. Jose Carlos Mariategui', N'2010', N'Computación e Informática', N'N', N'', N'', N'Dia', N'@', N'N', N'', N'C:\fotos\ALUMNOS.PNG', CAST(0xB9330B00 AS Date), N'Osorio ', N'Perez', N'Juan', N'09261265', N'Albañil', N'psje.4 A sector Huanta II ampl', N'999338251', N'Valdez', N'Ore', N'Julia Ricardina', N'        ', N'ama de casa', N'psje.4 A sector Huanta II ampl', N'         ')


select * from Matricula
select * from Alumno
select * from Modulo_Profesional