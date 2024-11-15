drop database if exists proyecto;

create database proyecto;
use proyecto;

create table usuario(
idUsuario int auto_increment,
nombreUsuario varchar (20),
claveUsuario varchar (15),
Activo boolean default true,
constraint pk_usuario primary key (idUsuario)
);



drop table if exists persona;
create table if not exists persona(
idRegistro int,
nombre varchar(50),
apellido varchar(50),
tipodoc varchar(25),
nrodoc varchar(10),
aptofisico boolean default false,
condicion boolean,
constraint pk_persona primary key (idRegistro)

); 
INSERT INTO persona (idRegistro, nombre, apellido, tipodoc, nrodoc, aptofisico, condicion) VALUES
(100, 'Juan', 'Pérez', 'DNI', '12345678', true, true),
(101, 'María', 'Gómez', 'DNI', '23456789', true, true),
(102, 'Carlos', 'López', 'DNI', '34567890', true, false),
(103, 'Ana', 'Martínez', 'DNI', '45678901', true, true),
(104, 'Luis', 'Fernández', 'Pasaporte', '56789012', false, true),
(105, 'Sofía', 'García', 'DNI', '67890123', true, true),
(106, 'Jorge', 'Rodríguez', 'Pasaporte', '78901234', false, false),
(107, 'Laura', 'Hernández', 'DNI', '89012345', true, true),
(108, 'Marta', 'Ruiz', 'DNI', '90123456', true, false),
(109, 'Pablo', 'Sánchez', 'Pasaporte', '01234567', false, true);

CREATE TABLE vencimientos(
    idPago INT AUTO_INCREMENT,
    idRegistro INT,
    fechaPago DATE,
    fechaVencimiento date,
    medioPago VARCHAR(20),
    cuotas INT,
    CONSTRAINT pk_vencimientos PRIMARY KEY (idPago),
    FOREIGN KEY (idRegistro) REFERENCES persona(idRegistro)
);
INSERT INTO vencimientos (idRegistro, fechaPago, fechaVencimiento, medioPago, cuotas) VALUES
(100, '2024-11-01', '2024-12-01', 'Tarjeta', 1),
(101, '2024-11-02', '2024-12-02', 'Efectivo', 1),
(103, '2024-11-03', '2024-12-03', 'Tarjeta', 6),
(104, '2024-11-04', '2024-12-04', 'Tarjeta', 3),
(105, '2024-11-05', '2024-12-05', 'Tarjeta', 3),
(107, '2024-11-06', '2024-12-06', 'Efectivo', 1),
(109, '2024-11-07', '2024-12-07', 'Tarjeta', 6);


/*create table nosocio-actividad*/
CREATE TABLE no_socio (
    idNoSocio INT AUTO_INCREMENT PRIMARY KEY,
    idPersona INT,
    actividadElegida VARCHAR(50),
    precio FLOAT,
    fechaPago DATE,
    FOREIGN KEY (idPersona) REFERENCES persona(idRegistro)
);

CREATE TABLE actividad (
    NActividad INT PRIMARY KEY,
    Nombre VARCHAR(40),
    precio FLOAT
);

CREATE TABLE actividad_horarios (
    idHorario INT AUTO_INCREMENT PRIMARY KEY,
    NActividad INT,
    dia VARCHAR(20),
    horario VARCHAR(20),
    FOREIGN KEY (NActividad) REFERENCES actividad(NActividad)
);

INSERT INTO actividad (NActividad, Nombre, precio) VALUES
(1000, "Fútbol", 5200),
(1001, "Spinning", 5000),
(1002, "Crossfit", 5000),
(1003, "Natación", 5500),
(1004, "Pilates", 5000),
(1005, "Musculación", 4000),
(1006, "Tenis", 5000),
(1007, "Boxeo", 4000),
(1008, "Taekwondo", 4000),
(1009, "Hockey", 5000),
(1010, "Gimnasia Rítmica", 4000),
(1011, "Gimnasia Artística", 4000),
(1012, "Futsal", 5000),
(1013, "Basquet", 5000),
(1014, "Volley", 5000),
(1015, "Handball", 5000),
(1016, "Atletismo", 5500);

-- Insertar horarios
INSERT INTO actividad_horarios (NActividad, dia, horario) VALUES
-- Fútbol
(1000, "Lunes", "08:00 AM - 09:00 AM"),
(1000, "Miércoles", "05:00 PM - 06:00 PM"),
(1000, "Viernes", "07:00 AM - 08:00 AM"),
-- Spinning
(1001, "Lunes", "06:00 AM - 07:00 AM"),
(1001, "Miércoles", "08:00 AM - 09:00 AM"),
(1001, "Viernes", "06:00 PM - 07:00 PM"),
-- Crossfit
(1002, "Martes", "09:00 AM - 10:00 AM"),
(1002, "Jueves", "07:00 PM - 08:00 PM"),
(1002, "Viernes", "10:00 AM - 11:00 AM"),
-- Natación
(1003, "Lunes", "07:00 PM - 08:00 PM"),
(1003, "Miércoles", "06:00 AM - 07:00 AM"),
(1003, "Viernes", "05:00 PM - 06:00 PM"),
-- Pilates
(1004, "Martes", "06:00 PM - 07:00 PM"),
(1004, "Jueves", "09:00 AM - 10:00 AM"),
(1004, "Viernes", "07:00 AM - 08:00 AM"),
-- Musculación
(1005, "Lunes", "10:00 AM - 11:00 AM"),
(1005, "Miércoles", "06:00 PM - 07:00 PM"),
(1005, "Viernes", "07:00 PM - 08:00 PM"),
-- Tenis
(1006, "Lunes", "05:00 PM - 06:00 PM"),
(1006, "Martes", "07:00 AM - 08:00 AM"),
(1006, "Jueves", "08:00 AM - 09:00 AM"),
-- Boxeo
(1007, "Martes", "09:00 AM - 10:00 AM"),
(1007, "Miércoles", "05:00 PM - 06:00 PM"),
(1007, "Viernes", "06:00 PM - 07:00 PM"),
-- Taekwondo
(1008, "Lunes", "06:00 PM - 07:00 PM"),
(1008, "Miércoles", "09:00 AM - 10:00 AM"),
(1008, "Viernes", "08:00 AM - 09:00 AM"),
-- Hockey
(1009, "Lunes", "07:00 AM - 08:00 AM"),
(1009, "Martes", "05:00 PM - 06:00 PM"),
(1009, "Jueves", "10:00 AM - 11:00 AM"),
-- Gimnasia Rítmica
(1010, "Martes", "08:00 AM - 09:00 AM"),
(1010, "Jueves", "06:00 PM - 07:00 PM"),
(1010, "Viernes", "09:00 AM - 10:00 AM"),
-- Gimnasia Artística
(1011, "Lunes", "09:00 AM - 10:00 AM"),
(1011, "Miércoles", "06:00 AM - 07:00 AM"),
(1011, "Viernes", "07:00 AM - 08:00 AM"),
-- Futsal
(1012, "Lunes", "06:00 AM - 07:00 AM"),
(1012, "Martes", "07:00 PM - 08:00 PM"),
(1012, "Jueves", "08:00 AM - 09:00 AM"),
-- Basquet
(1013, "Martes", "06:00 PM - 07:00 PM"),
(1013, "Miércoles", "07:00 AM - 08:00 AM"),
(1013, "Viernes", "10:00 AM - 11:00 AM"),
-- Volley
(1014, "Lunes", "08:00 AM - 09:00 AM"),
(1014, "Miércoles", "05:00 PM - 06:00 PM"),
(1014, "Jueves", "07:00 PM - 08:00 PM"),
-- Handball
(1015, "Lunes", "06:00 PM - 07:00 PM"),
(1015, "Miércoles", "08:00 AM - 09:00 AM"),
(1015, "Viernes", "07:00 AM - 08:00 AM"),
-- Atletismo
(1016, "Martes", "09:00 AM - 10:00 AM"),
(1016, "Jueves", "06:00 AM - 07:00 AM"),
(1016, "Viernes", "05:00 PM - 06:00 PM");



insert into usuario(idUsuario,nombreUsuario,claveUsuario) values
(1,'Vanesa','1234'),
(2,'Estefania','5678'),
(3,'Lola','1111');

DELIMITER //  

create procedure IngresoLogin(in usu varchar(20),in pass varchar(15))

begin
  
	select * from usuario 
	where nombreUsuario = usu and claveUsuario = pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */
end 
//

/* Para probar el procedure se usa call:

call IngresoLogin('dato1', 'dato2');
*/

/* ===============================
si los datos de los parametros existen la consulta arroja 1 FILA
si los datos de los parametros NO EXISTEN la consulta arroja 0 FILAS
============================================================================= */
 
 create procedure Nuevo_Registro(in nom varchar(50),in ape varchar(50),in tipo varchar(25), 
								in doc int, in apto bool, in cond bool,
								out res int)
 begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from persona);
     if filas = 0 then
		set filas = 600; /* consideramos a este numero como el primer numero de inscripto */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de postulante almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(idRegistro) + 1 from persona);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el postulante
		------------------------------------------------------- */	
		set existe = (select count(*) from persona where tipodoc = tipo and nrodoc = doc);
     end if;
	 
	  if existe = 0 then	 
		 insert into persona values(filas,nom,ape,tipo,doc,apto,cond);
		 set res  = filas;
	  else
		 set res = existe;
      end if;	
      
	end //
    
    DELIMITER //
CREATE PROCEDURE EliminarPersona(IN id INT)
BEGIN
    DELETE FROM persona WHERE idRegistro = id;
END //
     DELIMITER ;

select * from persona;
select * from vencimientos;
