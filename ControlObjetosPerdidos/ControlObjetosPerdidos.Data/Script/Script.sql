CREATE TABLE TRolUsuario
(
	IdRolUsuario int primary key identity(1, 1),
	Nombre nvarchar(60) not null,
	Descripcion nvarchar(60) null,
);

CREATE TABLE TUsuario
(
	IdUsuario nvarchar(100)  primary key,
	IdRolUsuario int not null,
	Contrasena nvarchar(100) null,
	Nombre nvarchar(100) not null,
	Apellidos nvarchar(100) not null,
	Telefono nvarchar(10) not null,
	Estado int not null,
	Constraint FK_USUARIO_ROL Foreign Key (IdRolUsuario) references TRolUsuario (IdRolUsuario)
);

CREATE TABLE TCategoria
(
	IdCategoria int primary key identity(1, 1),
	Nombre nvarchar(60) not null,
	Descripcion nvarchar(60) null,
);
	
CREATE TABLE TSubCategoria
(
	IdSubCategoria int primary key identity(1, 1),
	IdCategoria int not null,
	Nombre nvarchar(60) not null,
	Descripcion nvarchar(60) null,
	Constraint FK_CAT_SUBCAT Foreign Key (IdCategoria) references TCategoria (IdCategoria)
);

CREATE TABLE TArticulo
(
	IdArticulo int primary key identity(1,1),
	IdSubCategoria int not null,
	Descripcion nvarchar(100) not null,
	Estado nvarchar(60) not null,
	Constraint FK_ART_SUBCAT Foreign Key (IdSubCategoria) references TSubCategoria (IdSubCategoria)
);	

Create Table TReporteArticuloPerdido
(
	IdReporte int primary key identity(1,1),
	Caracteristicas nvarchar(250) not null,
	Nombre nvarchar(100) not null,
	Apellidos nvarchar(100) not null,
	Telefono nvarchar(10) not null,
	Correo nvarchar(100) null,
);