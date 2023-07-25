
CREATE TABLE estados (
	id tinyint not null primary key auto_increment,
	orden tinyint not null unique,
	estado varchar(50) not null
);


CREATE TABLE roles (
	id tinyint not null primary key auto_increment,
	codigo varchar(10) not null unique,
	rol varchar(50) not null,
	horariosSi bit not null default 0,
	permisosConfiguracion bit not null default 0,
	permisosFichas bit not null default 0,
	permisosModificarTurno bit not null default 0,
	permisosSoloTurnosPropios bit not null default 1
);


CREATE TABLE especialidades (
	id smallint not null primary key auto_increment,
	codigo varchar(10) not null unique,
	especialidad varchar(50) not null
);



CREATE TABLE usuarios(
	id int not null primary key auto_increment,
	cod_usu varchar(10) not null unique,
	password varchar(140) not null,
	nombre_apellido varchar(200) not null,
	email varchar(200) not null unique,
	tipo_documento varchar(20) not null,
	numero_doc varchar(30) not null unique,
	fecha_nacimiento date not null,
	direccion varchar(50) not null,
	localidad smallint not null,
	especialidad smallint not null,
	rol tinyint not null,
	altaUsu varchar(10) not null,
	modiUsu varchar(10),
	bajaUsu varchar(10),
	altaFecha datetime not null default NOW(),
	modiFecha datetime,
	bajaFecha datetime,
	foreign key (rol) references roles (id),
	foreign key (especialidad) references especialidades (id)
);


CREATE TABLE turnos
(
	id int not null primary key auto_increment,
	id_paciente int not null,
	id_medico int not null,
	fecha_hora datetime not null,
	observaciones text not null,
	estado tinyint not null,
	altaUsu varchar(10) not null,
	modiUsu varchar(10),
	bajaUsu varchar(10),
	altaFecha datetime not null default NOW(),
	modiFecha datetime,
	bajaFecha datetime,
	foreign key (estado) references estados (id),
	foreign key (id_paciente) references usuarios (id),
	foreign key (id_medico) references usuarios (id)
);


CREATE TABLE dSemana(
	id tinyint primary key auto_increment,
	cod_dia tinyint not null unique, /* TRIGGER (cod_dia between 1 and 7)*/
	diaSemana varchar(10) not null unique
);


CREATE TABLE horarios (
	id int primary key auto_increment,
	id_medico int not null,
	id_dia tinyint not null,
	hora_ini time not null,
	hora_fin time not null,
	foreign key (id_medico) references usuarios (id),
	foreign key (id_dia) references dSemana (id),
	constraint UQ_horarios_id_dia_id_medico unique (id_dia, id_medico)
);


CREATE TABLE provincias (
	id tinyint not null primary key auto_increment,
	provincia varchar(50) not null
);


CREATE TABLE localidades(
	id smallint not null primary key auto_increment,
	localidad varchar(50) NOT NULL,
	id_prov tinyint NOT NULL,
	foreign key (id_prov) references provincias(id)
);
