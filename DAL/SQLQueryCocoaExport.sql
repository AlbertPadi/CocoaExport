create database CocoaExport

use CocoaExport

create table Usuarios(UsuarioId int primary key identity ,
			Nombres varchar(50),
			Apellidos varchar(50), Direccion varchar(50),
			NombreUsuario varchar(40), Contrasena varchar(100));

			insert into Usuarios(Nombres, Apellidos, Direccion, NombreUsuario, Contrasena) values ('Jorge', 'Castro', 'Pimentel', 'Jorgeecm', '123456789');
			insert into Usuarios(Nombres, Apellidos, Direccion, NombreUsuario, Contrasena) values ('Camargo', 'Camargo', 'Pimentel', 'Camargo', '123456789');
			select *from Usuarios;
					
create table Certificaciones(CertificacionId int primary key identity, 
			Descripcion varchar(50));

			select*from Certificaciones	
						
							
create table Socios(SocioId int primary key identity, 
			Nombre varchar(50), 
			Apellido varchar(50),
			Direccion varchar(40),
			Cedula varchar(13), 
			CertificacionId int References Certificaciones(CertificacionId), 
			CantidadTerreno float, 
			Fertilizantes int);
			
		select *from Socios
								
create table Inspecciones(InspeccionesId int primary key identity, 
			SocioId int References Socios(SocioId),
			Fecha varchar (20),
			Fertilizantes int,
			MaterialSiembra varchar(35), 
			CrianzaAnimales int,
			ControlPlagas varchar(35), 
			ResumenInspeccion varchar(200));

create table TiposCacao(TipoCacaoId int primary key identity, 
			Descripcion varchar(35));					
								
create table Recepciones(RecepcionId int primary key identity, 
			SocioId int References Socios(SocioId), 
			LoteId int References Lotes(LoteId),
			CertificacionId int References Certificaciones(CertificacionId), 
			TipoCacaoId int References TiposCacao(TipoCacaoId),
			Observacion varchar(200), 
			RecibidoPor varchar(50));

						insert into Recepciones(Fecha, CantidadesPesadas, Observacion, RecibidoPor) values('24/12/2015', 500, 'jhdafjid', 'Pedro Santana');
						select *from Recepciones
						drop table Recepciones
--detalle							 
create table Lotes(LoteId int primary key identity, 
			CodigoLote varchar(20), 
			Total float, 
			CertificacionId int References Certificaciones(CertificacionId),
			Fecha varchar(20));

			drop table Lotes

--detalle recepcion lotes								
create table RecepcionLotes(RecepcionId int, CertificacionId int, Fecha varchar(10), CantidadPesada float, Observacion varchar(200));
select *from RecepcionLotes


create table DestinosExportes(DestinosId int primary key identity, Pais varchar(50), CodigoDestino varchar(30), NombreDestino varchar(50),
								Direccion varchar(50), CodigoPostal int);
			select *from DestinosExportes
	
create table Exportaciones(ExportacionId int primary key identity, DestinoId int, 
								CantidadToneladas float, Certificacion varchar(40), Fecha varchar(20), 
								LotesExportados float, Detalle varchar(300));

					