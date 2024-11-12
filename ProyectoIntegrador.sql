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
drop table if exists vencimientos;
create table if not exists vencimientos(
idPago int auto_increment,
idRegistro int,
fecha DATE,
constraint pk_vencimientos primary key (idPago),
foreign key (idRegistro) references persona(idRegistro)
);

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
		 insert into persona values(filas,nom,ape,tipo,doc,1,1);
		 set res  = filas;
	  else
		 set res = existe;
      end if;		 
	end //

select * from persona
