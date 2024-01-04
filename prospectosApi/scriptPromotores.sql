--CREATE DATABASE Promotores;
--go;

create table prospectos(
id int PRIMARY KEY IDENTITY(0,1),
nombre varchar(50),
apellidoPaterno varchar(50),
apellidoMaterno varchar(50),
calle varchar(100),
numero varchar(20),
colonia varchar(100),
codigoPostal varchar(5),
telefono varchar(15),
rfc varchar(13), 
estatus int, --enviado, autorizado, rechazado
)

create table documentos(
id int PRIMARY KEY IDENTITY(0,1),
nombre varchar(100),
prospectoId int,
urlDocumento varchar(200)
FOREIGN KEY (prospectoId) REFERENCES prospecto (id)
)