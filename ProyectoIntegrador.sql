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
condicion boolean default true,
constraint pk_persona primary key (idRegistro)

); 

CREATE TABLE vencimientos(
    idPago INT AUTO_INCREMENT,
    idRegistro INT,
    fechaPago DATE,
    fechaVencimiento DATE,
    medioPago VARCHAR(20),
    cuotas INT,
    CONSTRAINT pk_vencimientos PRIMARY KEY (idPago),
    FOREIGN KEY (idRegistro) REFERENCES persona(idRegistro)
);

create table actividad(
NActividad int,
Nombre varchar(40),
precio float,
constraint pk_actividad primary key(NActividad)
);

insert into actividad values
(1000,"Fútbol",5200),
(1001,"Spinning",5000),
(1002,"Crossfit",5000),
(1003,"Natación",5500),
(1004,"Pilates",5000),
(1005,"Musculación",4000),
(1006,"Tenis",5000),
(1007,"Boxeo",4000),
(1008,"Taekwondo",4000),
(1009,"Hockey",5000),
(1010,"Gimnasia Rítmica",4000),
(1011,"Gimnasia Artistica",4000),
(1012,"Futsal",5000),
(1013,"Basquet",5000),
(1014,"Volley",5000),
(1015,"Handball",5000),
(1016,"Atletismo",5500);

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

