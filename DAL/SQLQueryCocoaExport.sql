create database CocoaExport

use CocoaExport

create table Usuarios(UsuarioId int primary key identity , Nombres varchar(50), 
								Apellidos varchar(50), Direccion varchar(50),
								NombreUsuario varchar(40), Contrasena varchar(100));

					
create table Certificaciones(CertificacionId int primary key identity, Descripcion varchar(50));
							
							
create table Socios(SocioId int primary key identity, Nombre varchar(50), Apellido varchar(50),
								Direccion varchar(40),Cedula integer, CertificacionId int References Certificaciones(CertificacionId), Codigo int, CantidadTareas float, 
								Fertilizantes int);

create table Inspecciones(InspeccionesId int primary key identity, SocioId int References Socios(SocioId), 
								Fecha varchar (20), Fertilizantes int,
								MaterialSiembra varchar(35), CrianzaAnimales int,
								ControlPlagas varchar(35), ResumenInspeccion varchar(200));
--detalle
create table TiposCacao(TipoCacaoId int primary key identity, Descripcion varchar(35));					
								
create table Recepciones(RecepcionId int primary key identity, SocioId int References Socios(SocioId), 
								 CertificacionId int References Certificaciones(CertificacionId), TipoCacaoId int References TiposCacao(TipoCacaoId),
								 Fecha varchar(10), CantidadesPesadas float, Observacion varchar(200), RecibidoPor varchar(50));

--detalle							 
create table Lotes(LoteId int primary key identity, Total int, RecepcionId int References Recepciones(RecepcionId), 
								CertificacionId int References Certificaciones(CertificacionId), Fecha varchar(20));
								
create table DestinosExportes(DestinosId int primary key identity, Pais varchar(50), CodigoDestino int, NombreDestino varchar(50),
								Direccion varchar(50), CodigoPostal int);
			
	
create table Exportaciones(ExportacionId int primary key identity, DestinoId int, 
								CantidadToneladas float, Certificacion varchar(40), Fecha varchar(20), 
								LotesExportados float, Detalle varchar(300));

								Insert into Usuarios(NombreUsuario,Contraseña) values('Melvin','1234');

