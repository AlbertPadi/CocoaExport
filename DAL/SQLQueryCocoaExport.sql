create database CocoaExport

use CocoaExport

create table Usuarios(
			UsuarioId int primary key identity ,
			Nombres varchar(50),
			Apellidos varchar(50), 
			Direccion varchar(50),
			NombreUsuario varchar(40), 
			Contrasena varchar(100),
			Contrasena1 varchar(100));
			select *from Usuarios

			insert into Usuarios(Nombres, Apellidos, Direccion, NombreUsuario, Contrasena, Contrasena1) values('Juan Alberto', 'Padilla Balbi', 'San Francisco de Macoris', 'Master', 'alberto2015', 'alberto2015');
					drop table Usuarios
create table Certificaciones(
			CertificacionId int primary key identity, 
			Descripcion varchar(50));

			select*from Certificaciones	
						
							
create table Socios(
			SocioId int primary key identity, 
			Nombre varchar(50), 
			Apellido varchar(50),
			Direccion varchar(40),
			Cedula varchar(13), 
			CertificacionId int References Certificaciones(CertificacionId), 
			CantidadTerreno float, 
			Fertilizantes int);
			
		select *from Socios
								
create table Inspecciones(
			InspeccionesId int primary key identity, 
			SocioId int References Socios(SocioId),
			Fecha varchar (20),
			Fertilizantes int,
			MaterialSiembra varchar(35), 
			CrianzaAnimales int,
			ControlPlagas varchar(35), 
			ResumenInspeccion varchar(200));

create table TiposCacao(
			TipoCacaoId int primary key identity, 
			Descripcion varchar(35));					
		
create table Recepciones(
			RecepcionId int primary key identity, 
			SocioId int References Socios(SocioId), 
			LoteId int References Lotes(LoteId),
			CertificacionId int References Certificaciones(CertificacionId), 
			TipoCacaoId int References TiposCacao(TipoCacaoId),
			Observacion varchar(200), 
			RecibidoPor varchar(50));
			drop table Recepciones
						
						 
create table Lotes(
			LoteId int primary key identity,
			CodigoLote varchar(20), 
			Total float, 
			CertificacionId int References Certificaciones(CertificacionId),
			Fecha varchar(20));

	insert into Lotes(CodigoLote, Total) values('025SGS', 500);
	select*from Lotes
	--detalle
create table LotesExportes(
			LoteId int References Lotes(LoteId), 
			ExportacionId int References Exportaciones(ExportacionId));

			select *from LotesExportes
		    drop table LotesExportes
			select e.CodigoLote from Exportaciones l inner join LotesExportes e on l.ExportacionId = e.ExportacionId where e.ExportacionId = 15

create table RecepcionLotes(
			RecepcionId int, 
			CertificacionId int, 
			Fecha varchar(10), 
			CantidadPesada float, 
			Observacion varchar(200));
			drop table RecepcionLotes
select *from RecepcionLotes


create table DestinosExportes(
			 DestinoId int primary key identity, 
			 Pais varchar(50), 
			 CodigoDestino varchar(30), 
			 NombreDestino varchar(50),
			 Direccion varchar(50), 
			 CodigoPostal float);

			select *from DestinosExportes
			drop table DestinosExportes
create table Exportaciones(
			 ExportacionId int primary key identity, 
			 DestinoId int References DestinosExportes(DestinoId), 
			 CantidadToneladas float, 
			 CertificacionId int References Certificaciones(CertificacionId), 
			 Fecha varchar(20), 
			 LoteId int References Lotes(LoteId), 
			 Resumen varchar(300));

			 select *from Exportaciones
			 drop table Exportaciones

create table DestinosExportacion(
			 DestinoExpId int primary key identity,
			 ExportacionId int References Exportaciones(ExportacionId),
			 Pais varchar(50), 
			 NombreDestino varchar(50), 
			 Direccion varchar(50), 
			 Codigopostal int);
			select *from DestinosExportacion
			drop table DestinosExportacion