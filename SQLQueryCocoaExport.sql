--Creamos la basse de datos llamada "CocoaExport"
create database CocoaExport

--Le damos uso a la Base de Datos CocoaExport
use CocoaExport

--Creamos la tabla Registro Usuarios
create table Usuarios(UsuarioId int primary key identity , Nombre varchar(50), 
								Apellido varchar(50), Direccion varchar(50),
								NombreUsuario varchar(40), Contraseña varchar(100));
								
--Creamos la tabla Registro de Socios
create table Socios(SocioId int primary key identity, Nombre varchar(50), Apellido varchar(50),
								Direccion varchar(40),Cedula integer, Codigo int, Hectareas float, 
								Fertilizantes int);
						select *from Socios;
--Creamos la tabla Inspecciones para la inspeccion a las fincas de los socios
create table Inspecciones(InspeccionesId int primary key identity, SocioId int References Socios(SocioId), 
								Fecha varchar (20), CantidadTerreno float,Fertilizantes int, 
								MaterialSiembra varchar(35), CrianzaAnimales int,
								ControlPlagas varchar(35), ResumenInspeccion varchar(200));

							
--Creamos la tabla Centros de Acopio. Este es el almacen que recibe el cacao de los socios
create table CentrosAcopio(CentrosAcpId int primary key identity, Nombre varchar(50), Direccion varchar(40), 
								 Fecha varchar(10),Sacos int, Kilos float, Cajas float, 
								 Observacion varchar(200), EntregadoPor varchar(50), RecibidoPor varchar(50));
							 
--Creamos la tabla Control de lotes para llevar controlada la cantidad de cacao que se va a exportar
create table ControlLotes(ControlLotesId int primary key identity, CentrosAcpId int References CentrosAcopio(CentrosAcpId), 
								Almacen int, Fecha varchar(20), Quintales float, Kilos float, NombreSocio varchar(50),
								ApellidoSocio varchar(50), Codigo int, QuintalesSocio float, KilosSocio float, Certificacion varchar(40));
								
--Creamos la tabla del destinatario donde se registra el cliente internacional a quien se le exporta
create table DestinosExportes(DestinosId int primary key identity, Pais varchar(50), CodigoDestino int, NombreDestino varchar(50),
								Direccion varchar(50), CodigoPostal int);
			
		

--Y por ultimo creamos la tabla Exportacion para enviar el cacao al extranjero, sea cual sea el destino
create table Exportaciones(ExportacionId int primary key identity, DestinosId int References DestinosExportes(DestinosId), 
								CodigoExporte int, Certificacion varchar(40), Fecha varchar(20), 
								Toneladas float, Detalle varchar(300));

Select *From Usuarios