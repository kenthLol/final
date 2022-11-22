drop database if exists biblioteca;
create database biblioteca;
use biblioteca;

create table pais(
	cod_pais 	bigint(20) not null auto_increment,
	nombre_pais varchar(100),
	constraint paispk primary key(cod_pais)
);

insert into pais values(null,'NICARAGUA');
insert into pais values(null,'EL SALVADOR');
insert into pais values(null,'COSTA RICA');

create table autor(
	cod_autor 	 bigint(20) not null auto_increment,
	nombre_autor varchar(50),
	cod_pais 	 bigint(20),
	constraint autorpk primary key(cod_autor),
	constraint autorfk foreign key(cod_pais) references pais(cod_pais) on 
	update cascade on delete cascade
);

create table editorial(
	cod_editorial 	 bigint(20) not null auto_increment,
	nombre_editorial varchar(50),
	cod_pais 		 bigint(20),
	constraint editorialpk primary key(cod_editorial),
	constraint editorialfk foreign key(cod_pais) references pais(cod_pais) on 
	update cascade on delete cascade
);

create table usuario(
	cod_ident      bigint(20) not null auto_increment,
	nombres        varchar(50),
	apellidos      varchar(50),
	telefono       varchar(8),
	direccion      varchar(100),
	fecha_nac      date,
	sexo           varchar(1),
	estado_civil   varchar(1),
	centro_estudio varchar(50),
	constraint usuariopk primary key(cod_ident)
);

create table login(
	id int auto_increment not null,
	usuario varchar(20),
	clave varchar(100),
constraint loginpk primary key(id)
);


create table libro(
	cod_libro     bigint(20) not null auto_increment,
	titulo        varchar(50),
	cod_editorial bigint(20),
	fecha_pub     date,
	ejemplares    int,
	n_pag         int,
	idioma        varchar(25),
	edicion       int,
	constraint libropk primary key(cod_libro),
	constraint librofk foreign key(cod_editorial) references 
	editorial(cod_editorial) on update cascade on delete cascade
);

create table relacion_libro_autor(
	cod_libro bigint(20),
	cod_autor bigint(20),
	constraint relacionfk1 foreign key(cod_libro) references libro(cod_libro) 
	on
	update cascade on delete cascade, constraint relacionfk2 foreign 
	key(cod_autor)
	references autor(cod_autor) on update cascade on delete cascade
);

create table bibliotecario(
	cod_bibliotecario bigint(20) not null auto_increment,
	nombres   varchar(50),
	apellidos varchar(50),
	direccion varchar(100),
	cargo     varchar(50),constraint bibliotecariopk primary 
	key(cod_bibliotecario)
);

create table prestamo(
	cod_prestamo      bigint(20) not null auto_increment,
	cod_libro         bigint(20),
	fecha_pres        date,
	fecha_ent 		  date,
	cod_ident 		  bigint(20),
	tipo_prestamo     varchar(10),
	cod_bibliotecario bigint(20),
	entregado 		  varchar(2),
	multa 			  float,
	constraint prestamopk primary key(cod_prestamo),
	constraint prestamofk1 foreign key(cod_libro) references 
	libro(cod_libro) on
	update cascade on delete cascade, constraint prestamofk2 foreign 
	key(cod_ident)
	references usuario(cod_ident) on update cascade on delete 
	cascade,constraint
	prestamofk3 foreign key(cod_bibliotecario) references 
	bibliotecario(cod_bibliotecario) on update cascade on delete cascade
);

/* Procedimientos para Autor */

delimiter //
DROP PROCEDURE if exists insertar_autor //
create procedure insertar_autor(in codigo bigint(20),in nombre varchar(50), in 
	pais bigint(20))
	begin
		if codigo=0 then
			insert into autor values(null, nombre, pais);
		else
			update autor set nombre_autor = nombre, cod_pais = pais where 
			cod_autor = codigo;
		end if;
end //

DROP PROCEDURE if exists seleccionar_autores //
create procedure seleccionar_autores()
begin
	select a.cod_autor as Codigo, a.nombre_autor as Autor, b.nombre_pais as Pais 
    from autor a inner join pais b on a.cod_pais = b.cod_pais order by 
	a.nombre_autor;
end //

DROP PROCEDURE if exists seleccionar_paises //
create procedure seleccionar_paises()
begin
	select * from pais order by nombre_pais;
end //

DROP PROCEDURE if exists ver_autor //
create procedure ver_autor(in autor bigint(20))
begin
	select * from autor where cod_autor=autor;
end//

DROP PROCEDURE if exists borrar_autor //
create procedure borrar_autor(in autor bigint(20))
begin
	delete from autor where cod_autor=autor ;
end //
Delimiter ;

/* Procedimientos para Editorial */

delimiter //
DROP PROCEDURE if exists insertar_editorial //
create procedure insertar_editorial(in codigo bigint(20),in nombre varchar(50), in 
	pais bigint(20))
	begin
		if codigo=0 then
			insert into editorial values(null, nombre, pais);
		else
			update editorial set nombre_editorial = nombre, cod_pais = pais where 
			cod_editorial = codigo;
		end if;
end //

DROP PROCEDURE if exists seleccionar_editorial //
create procedure seleccionar_editorial()
begin
	select a.cod_editorial as codigo, a.nombre_editorial as Editorial, b.nombre_pais as 
	Pais from editorial a inner join pais b on a.cod_pais = b.cod_pais order by 
	a.nombre_editorial;
end //

DROP PROCEDURE if exists seleccionar_paises_editorial //
create procedure seleccionar_paises_editorial()
begin
	select * from pais order by nombre_pais;
end //

DROP PROCEDURE if exists ver_editorial //
create procedure ver_editorial(in editorial bigint(20))
begin
	select * from editorial where cod_editorial = editorial;
end//

DROP PROCEDURE if exists borrar_editorial //
create procedure borrar_editorial(in editorial bigint(20))
begin
	delete from editorial where cod_editorial = editorial ;
end //
Delimiter ;


/* Procedimientos para Libros */

delimiter //
DROP PROCEDURE if exists insertar_libro //
create procedure insertar_libro(in codigo_libro bigint(20), in titulo varchar(50), 
	in editorial bigint(20), in fecha_public date, in ejemplares int, in n_pag int, 
    in idioma varchar(25), in edicion int, in codigo_autor bigint(20))
	begin
		DECLARE libro_last_id BIGINT(20);
		if codigo_libro = 0 then
			START TRANSACTION;
			insert into libro values(null, titulo, editorial, fecha_public, ejemplares, n_pag, idioma, edicion);
			SELECT @libro_last_id := MAX(cod_libro) FROM libro;
            insert into relacion_libro_autor values(@libro_last_id, codigo_autor);
            commit;
		else
			update libro set 
            titulo = titulo, 
            cod_editorial = editorial, 
            fecha_pub = fecha_public, 
            ejemplares = ejemplares, 
            n_pag = n_pag, 
            idioma = idioma, 
            edicion = edicion
            where cod_libro = codigo_libro;
		end if;
end //

DROP PROCEDURE if exists seleccionar_libros//
create procedure seleccionar_libros()
begin
    select a.cod_libro as codigo, a.titulo as Titulo, b.nombre_editorial as Editorial,
    a.fecha_pub as Publicacion, a.ejemplares as Ejemplares, a.n_pag as Pag,
    a.idioma as Idioma, a.edicion as Edicion
    from libro a 
    inner join editorial b on a.cod_editorial = b.cod_editorial
    order by a.titulo;
end //

DROP PROCEDURE if exists seleccionar_editorial_libro//
create procedure seleccionar_editorial_libro()
begin
	select * from editorial order by nombre_editorial;
end //

DROP PROCEDURE if exists ver_libro//
create procedure ver_libro(in libro bigint(20))
begin
	select * from libro where cod_libro = libro;
end//

DROP procedure if exists borrar_libro//
create procedure borrar_libro(in libro bigint(20))
begin
	delete from libro where cod_libro = libro ;
end //
Delimiter ;

/* Procedimientos para Usuarios */
DROP PROCEDURE if exists insertar_usuario;
delimiter //
create procedure insertar_usuario(in codigo bigint(20), in Nombres varchar(50), 
	in Apellidos varchar(50), in tel varchar(8), in dir varchar(100), in Fecha_nac date,
    in sex varchar(1), in Estado_civil varchar(1), in Centro_estudio varchar(50))
	begin
		if codigo=0 then
			insert into usuario values(null, Nombres, Apellidos, tel, dir, Fecha_nac, sex, Estado_civil, Centro_estudio);
		else
			update usuario 
            set nombres = Nombres, 
				apellidos = Apellidos,
                telefono = tel,
                direccion = dir,
                fecha_nac = Fecha_nac,
                sexo = sex,
                estado_civil = Estado_civil,
                centro_estudio = Centro_estudio
			where 
			cod_ident = codigo;
		end if;
end //

DROP PROCEDURE if exists seleccionar_usuarios//
create procedure seleccionar_usuarios()
begin
	select cod_ident as Codigo, nombres as Nombres, apellidos as Apellidos, telefono as Teléfono, direccion as Dirección, 
		   fecha_nac as 'Fecha Nac', sexo as Sexo, estado_civil as 'Estado civ', centro_estudio as 'Centro Estudio' 
	from usuario 
	order by 
	nombres;
end //

DROP PROCEDURE if exists ver_usuario//
create procedure ver_usuario(in codigo_usuario bigint(20))
begin
	select * from usuario where cod_ident = codigo_usuario;
end//

DROP PROCEDURE if exists borrar_usuario//
create procedure borrar_usuario(in codigo_usuario bigint(20))
begin
	delete from usuario where cod_ident = codigo_usuario;
end //
Delimiter ;

call insertar_usuario(1, 'Kenneth Samuel', 'Lola Pichardo', '76342467', 'No se', '2001-01-08', 'M', 'S', 'Guillermo');
call seleccionar_usuarios();

-- --------------- LOGIN ---------------------------------------
delimiter //
drop procedure if exists consultar_login//
create procedure consultar_login(in pusuario varchar(20),in pclave varchar(100))
begin
	select * from login where usuario=pusuario and clave=md5(pclave);
end//
DELIMITER ;

-- ------------------- REPORTES -----------------------------------
/*  Libros por pais */

Delimiter //
DROP PROCEDURE if exists libros_por_pais//
CREATE PROCEDURE libros_por_pais(in country varchar(100))
begin
	SELECT l.titulo, e.nombre_editorial, p.nombre_pais from libro l 
    INNER JOIN editorial e on l.cod_editorial = e.cod_editorial
    INNER JOIN pais p on e.cod_pais = p.cod_pais
    WHERE p.nombre_pais like concat("%", country, "%");
end //
DELIMITER ;

/* Préstamos realizados en un rango de fecha  */
Delimiter //
DROP PROCEDURE if exists cantidad_prestamos//
CREATE PROCEDURE cantidad_prestamos(in primera_fecha date, in segunda_fecha date)
begin	
	SELECT COUNT(*) as 'Prestamos' FROM prestamo
	where fecha_ent between primera_fecha and segunda_fecha 
    and entregado = 'no';
end //
DELIMITER ;

/* Préstamos vencidos  */
Delimiter //
DROP PROCEDURE if exists prestamos_vencidos//
CREATE PROCEDURE prestamos_vencidos()
begin	
	SELECT l.cod_libro as Codigo, l.titulo as Titulo, p.fecha_ent as 'Fecha Entrega', 
    concat('VENCIDO') as Estado
	FROM prestamo p 
	INNER JOIN libro l on p.cod_libro = l.cod_libro
	WHERE p.fecha_ent < curdate() AND entregado = 'no';
end //
DELIMITER ;

/* Usuarios con multa  */
Delimiter //
DROP PROCEDURE if exists usuarios_con_multa//
CREATE PROCEDURE usuarios_con_multa()
begin	
	SELECT u.nombres as Nombres, u.apellidos as Apellidos, u.centro_estudio as 'Centro estudio',
	p.multa as Multa
	from usuario u 
	INNER JOIN  prestamo p on u.cod_ident = p.cod_ident
	WHERE p.multa > 0;
end //
DELIMITER ;

call seleccionar_editorial();
insert into login values(null, 'kenth', md5('1234'));

Create user biblioteca@localhost identified by '123456789';
Grant execute on biblioteca.* to biblioteca@localhost;