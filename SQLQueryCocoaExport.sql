create database CocoaExport

use CocoaExport

create table Usuarios(UsuarioId int primary key identity , Nombres varchar(50), 
								Apellidos varchar(50), Direccion varchar(50),
								NombreUsuario varchar(40), Contrasena varchar(100));

create table Socios(SocioId int primary key identity, Nombre varchar(50), Apellido varchar(50),
								Direccion varchar(40),Cedula integer, Certificacion Varchar(40), Codigo int, CantidadTareas float, 
								Fertilizantes int);
					
create table Certificaciones(CertificacionId int primary key identity, SocioId int References Socios(SocioId), Descripcion varchar(50));
							
							
create table Inspecciones(InspeccionesId int primary key identity, SocioId int References Socios(SocioId), 
								Fecha varchar (20), Fertilizantes int,
								MaterialSiembra varchar(35), CrianzaAnimales int,
								ControlPlagas varchar(35), ResumenInspeccion varchar(200));
								
							
create table Recepciones(RecepcionId int primary key identity, SocioId varchar(50), Direccion varchar(40), 
								 Fecha varchar(10),Sacos int, CantidadesPesadas float, TipoCacao varchar(50),
								 Certificacion varchar (40),
								 Observacion varchar(200), EntregadoPor varchar(50), RecibidoPor varchar(50));

								 
							 
create table Lotes(LoteId int primary key identity, Total int, Fecha varchar(20),Certificacion varchar(40));

								
create table DestinosExportes(DestinosId int primary key identity, Pais varchar(50), CodigoDestino int, NombreDestino varchar(50),
								Direccion varchar(50), CodigoPostal int);
			
	
create table Exportaciones(ExportacionId int primary key identity, DestinoId int, 
								CantidadToneladas float, Certificacion varchar(40), Fecha varchar(20), 
								LotesExportados float, Detalle varchar(300));

Select *From Usuarios
