CREATE DATABASE [dbMedico]
GO 
USE [dbMedico] 
GO

CREATE SCHEMA [Acce]
GO

CREATE SCHEMA [Gene]
GO

CREATE SCHEMA [Medi]
GO

CREATE TABLE [Acce].[tbUsuarios] (
  [Usua_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Usua_Usuario] varchar(50) NOT NULL,
  [Usua_Clave] varbinary(max) NOT NULL,
  [Usua_IsAdmin] bit,
  [Rol_Id] int,
  [Usua_Estado] bit DEFAULT (1),
  [Usua_Creacion] int NOT NULL,
  [Usua_FechaCreacion] datetime NOT NULL,
  [Usua_Modificacion] int,
  [Usua_FechaModificacion] datetime
)
GO

CREATE TABLE [Acce].[tbRoles] (
  [Rol_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Rol_Descripcion] varchar(50) NOT NULL,
  [Rol_Estado] bit DEFAULT (1),
  [Rol_Creacion] int NOT NULL,
  [Rol_FechaCreacion] datetime NOT NULL,
  [Rol_Modificacion] int,
  [Rol_FechaModificacion] datetime
)
GO

CREATE TABLE [Acce].[tbPantallas] (
  [Pant_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Pant_Descripcion] varchar(50) NOT NULL,
  [Pant_Estado] bit DEFAULT (1),
  [Pant_Creacion] int NOT NULL,
  [Pant_FechaCreacion] datetime NOT NULL,
  [Pant_Modificacion] int,
  [Pant_FechaModificacion] datetime
)
GO

CREATE TABLE [Acce].[tbPantallasPorRoles] (
  [PaRo_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Pant_Id] int NOT NULL,
  [Rol_Id] int NOT NULL,
  [PaRo_Estado] bit DEFAULT (1),
  [PaRo_Creacion] int NOT NULL,
  [PaRo_FechaCreacion] datetime NOT NULL,
  [PaRo_Modificacion] int,
  [PaRo_FechaModificacion] datetime
)
GO

CREATE TABLE [Gene].[tbEstados] (
  [Esta_Id] VARCHAR(2) primary key,
  [Esta_Descripcion] varchar(50) NOT NULL,
  [Esta_Estado] bit DEFAULT (1),
  [Esta_Creacion] int NOT NULL,
  [Esta_FechaCreacion] datetime NOT NULL,
  [Esta_Modificacion] int,
  [Esta_FechaModificacion] datetime
)
GO

CREATE TABLE [Gene].[tbCiudades] (
  [Ciud_Id] VARCHAR(4) primary key,
  [Ciud_Descripcion] varchar(50) NOT NULL,
  [Esta_Id] varchar(2) NOT NULL,
  [Ciud_Estado] bit DEFAULT (1),
  [Ciud_Creacion] int NOT NULL,
  [Ciud_FechaCreacion] datetime NOT NULL,
  [Ciud_Modificacion] int,
  [Ciud_FechaModificacion] datetime
)
GO

CREATE TABLE [Gene].[tbEstadosCiviles] (
  [EsCi_Id] int PRIMARY KEY IDENTITY(1, 1),
  [EsCi_Descripcion] varchar(50) NOT NULL,
  [EsCi_Estado] bit DEFAULT (1),
  [EsCi_Creacion] int NOT NULL,
  [EsCi_FechaCreacion] datetime NOT NULL,
  [EsCi_Modificacion] int,
  [EsCi_FechaModificacion] datetime
)
GO

CREATE TABLE [Gene].[tbPersonas] (
  [Pers_Identidad] varchar(13) PRIMARY KEY,
  [Pers_PrimerNombre] varchar(50) NOT NULL,
  [Pers_SegundoNombre] varchar(50),
  [Pers_PrimerApellido] varchar(50) NOT NULL,
  [Pers_SegundoApellido] varchar(50),
  [Pers_Sexo] char(1),
  [Pers_Altura] decimal(4,2) NOT NULL,
  [Pers_Nacimiento] datetime,
  [TiSa_Id] int NOT NULL,
  [Usua_Id] int,
  [EsCi_Id] int NOT NULL,
  [Ciud_Id] varchar(4) NOT NULL,
  [Pers_Estado] bit DEFAULT (1),
  [Pers_Creacion] int NOT NULL,
  [Pers_FechaCreacion] datetime NOT NULL,
  [Pers_Modificacion] int,
  [Pers_FechaModificacion] datetime
)
GO

CREATE TABLE [Medi].[tbTiposSangre] (
  [TiSa_Id] int PRIMARY KEY IDENTITY(1, 1),
  [TiSa_Descripcion] varchar(50) NOT NULL,
  [TiSa_Estado] bit DEFAULT (1),
  [TiSa_Creacion] int NOT NULL,
  [TiSa_FechaCreacion] datetime NOT NULL,
  [TiSa_Modificacion] int,
  [TiSa_FechaModificacion] datetime
)
GO

CREATE TABLE [Medi].[tbEnfermedades] (
  [Enfe_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Enfe_Descripcion] varchar(50) NOT NULL,
  [Enfe_Estado] bit DEFAULT (1),
  [Enfe_Creacion] int NOT NULL,
  [Enfe_FechaCreacion] datetime NOT NULL,
  [Enfe_Modificacion] int,
  [Enfe_FechaModificacion] datetime
)
GO

CREATE TABLE [Medi].[tbEstadosSalud] (
  [EsSa_Id] int PRIMARY KEY IDENTITY(1, 1),
  [EsSa_Descripcion] varchar(50) NOT NULL,
  [EsSa_Estado] bit DEFAULT (1),
  [EsSa_Creacion] int NOT NULL,
  [EsSa_FechaCreacion] datetime NOT NULL,
  [EsSa_Modificacion] int,
  [EsSa_FechaModificacion] datetime
)
GO

CREATE TABLE [Medi].[tbEjercios] (
  [Ejer_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Ejer_Descripcion] varchar(50) NOT NULL,
  [Ejer_TipoEjercicio] varchar(50) NOT NULL,
  [Ejer_Estado] bit DEFAULT (1),
  [Ejer_Creacion] int NOT NULL,
  [Ejer_FechaCreacion] datetime NOT NULL,
  [Ejer_Modificacion] int,
  [Ejer_FechaModificacion] datetime
)
GO

CREATE TABLE [Medi].[tbAlimentos] (
  [Alim_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Alim_Descripcion] varchar(50),
  [Alim_TipoComida] varchar(50),
  [Alim_Calorias] decimal(6,2),
  [Alim_Proteinas] decimal(6,2),
  [Alim_Carbohidratos] decimal(6,2),
  [Alim_Estado] bit DEFAULT (1),
  [Alim_Creacion] int NOT NULL,
  [Alim_FechaCreacion] datetime NOT NULL,
  [Alim_Modificacion] int,
  [Alim_FechaModificacion] datetime
)
GO

CREATE TABLE [Medi].[tbEnfermedadesPorPersona] (
  [EnPe_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Enfe_Id] int NOT NULL,
  [Pers_Identidad] varchar(13) NOT NULL,
  [EnPe_Estado] bit DEFAULT (1),
  [EnPe_Creacion] int NOT NULL,
  [EnPe_FechaCreacion] datetime NOT NULL,
  [EnPe_Modificacion] int,
  [EnPe_FechaModificacion] datetime
)
GO

CREATE TABLE [Medi].[tbDiagnosticos] (
  [Diag_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Pers_Identidad] varchar(13) NOT NULL,
  [EsSa_Id] int NOT NULL,
  [Diag_Peso] decimal(6,2) NOT NULL,
  [Diag_Estado] bit DEFAULT (1),
  [Diag_Creacion] int NOT NULL,
  [Diag_FechaCreacion] datetime NOT NULL,
  [Diag_Modificacion] int,
  [Diag_FechaModificacion] datetime
)
GO

CREATE TABLE [Medi].[tbDietas] (
  [Diet_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Diag_Id] int NOT NULL,
  [Alim_Id] int NOT NULL,
  [Diet_Detalle] varchar(100),
  [Diet_Estado] bit DEFAULT (1),
  [Diet_Creacion] int NOT NULL,
  [Diet_FechaCreacion] datetime NOT NULL,
  [Diet_Modificacion] int,
  [Diet_FechaModificacion] datetime
)
GO

CREATE TABLE [Medi].[tbEntrenamientos] (
  [Entr_Id] int PRIMARY KEY IDENTITY(1, 1),
  [Diag_Id] int NOT NULL,
  [Ejer_Id] int NOT NULL,
  [Entr_Peso] decimal(6,2),
  [Entr_Duracion] decimal(6,2),
  [Entr_Repeticiones] int,
  [Entr_Sets] int,
  [Entr_Detalle] varchar(100),
  [Entr_Estado] bit DEFAULT (1),
  [Entr_Creacion] int NOT NULL,
  [Entr_FechaCreacion] datetime NOT NULL,
  [Entr_Modificacion] int,
  [Entr_FechaModificacion] datetime
)
GO

INSERT INTO [Gene].[tbEstados] ([Esta_Id], [Esta_Descripcion], [Esta_Creacion], [Esta_FechaCreacion])
VALUES 
('04', 'Copan', 1, GETDATE()),
('02', 'Colon', 1,  GETDATE()),
('06', 'Choluteca', 1, GETDATE()),
('09', 'Gracias a Dios', 1, GETDATE()),
('10', 'Intibuca', 1, GETDATE()),
('08', 'Francisco Morazan', 1, GETDATE()),
('05', 'Cortes', 1, GETDATE());
GO

INSERT INTO [Gene].[tbCiudades] ([Ciud_Id], [Ciud_Descripcion], [Esta_Id], [Ciud_Creacion], [Ciud_FechaCreacion])
VALUES
('0401', 'Santa Rosa de Copan', '04', 1, GETDATE()),
('0201', 'trujillo', '02', 1, GETDATE()),
('0601', 'Choluteca', '06', 1, GETDATE()),
('0901', 'Puerto Lempira', '09', 1, GETDATE()),
('1001', 'La Esperanza', '10', 1, GETDATE()),
('0501', 'San Pedro Sula', '05', 1, GETDATE()),
('0801', 'Tegucigalpa', '08', 1, GETDATE());
GO

INSERT INTO Gene.tbEstadosCiviles (EsCi_Descripcion, EsCi_Creacion, EsCi_FechaCreacion)
VALUES  ('Soltero(a)', 1, getdate()),
		('Casado(a)', 1, getdate()),
		('Divorciado(a)', 1, getdate()),
		('Viudo(a)', 1, getdate()),
		('Union libre', 1, getdate());
GO

INSERT INTO Medi.tbTiposSangre (TiSa_Descripcion, TiSa_Creacion, TiSa_FechaCreacion)
VALUES ('O positivo', 1, GETDATE()),
       ('A positivo', 1, GETDATE()),
       ('B positivo', 1, GETDATE()),
       ('AB positivo', 1, GETDATE()),
       ('O negativo', 1, GETDATE()),
       ('A negativo', 1, GETDATE()),
       ('B negativo', 1, GETDATE()),
       ('AB negativo', 1, GETDATE());
GO

INSERT INTO Acce.tbUsuarios (Usua_Usuario, Usua_Clave, Usua_IsAdmin, Usua_Creacion, Usua_FechaCreacion)
VALUES  ('kevin', HASHBYTES('SHA2_512', 'kevin'), 1, 1, getdate()),
		('manuel', HASHBYTES('SHA2_512', '123'), 1, 1, getdate());
GO

INSERT INTO Gene.tbPersonas (Pers_Identidad, Pers_PrimerNombre, Pers_PrimerApellido, Pers_Sexo, EsCi_Id, Pers_Altura, Pers_Nacimiento, TiSa_Id, Usua_Id, Ciud_Id, Pers_Creacion, Pers_FechaCreacion)
VALUES  ('0801200120525', 'Kevin', 'Membreño', 'M', 1, '1.66', '2001-06-25', 1, 1, '0501', 1, getdate()),
		('0501200511749', 'Mauel', 'Lara', 'M', 1, '1.78', '2005-08-15', 1, 2, '0501', 1, getdate());
GO

ALTER TABLE [Gene].[tbCiudades] ADD FOREIGN KEY ([Esta_Id]) REFERENCES [Gene].[tbEstados] ([Esta_Id])
GO

ALTER TABLE [Gene].[tbPersonas] ADD FOREIGN KEY ([EsCi_Id]) REFERENCES [Gene].[tbEstadosCiviles] ([EsCi_Id])
GO

ALTER TABLE [Gene].[tbPersonas] ADD FOREIGN KEY ([Ciud_Id]) REFERENCES [Gene].[tbCiudades] ([Ciud_Id])
GO

ALTER TABLE [Gene].[tbPersonas] ADD FOREIGN KEY ([TiSa_Id]) REFERENCES [Medi].[tbTiposSangre] ([TiSa_Id])
GO

ALTER TABLE [Medi].[tbDiagnosticos] ADD FOREIGN KEY ([EsSa_Id]) REFERENCES [Medi].[tbEstadosSalud] ([EsSa_Id])
GO

ALTER TABLE [Medi].[tbEnfermedadesPorPersona] ADD FOREIGN KEY ([Enfe_Id]) REFERENCES [Medi].[tbEnfermedades] ([Enfe_Id])
GO

ALTER TABLE [Medi].[tbEnfermedadesPorPersona] ADD FOREIGN KEY ([Pers_Identidad]) REFERENCES [Gene].[tbPersonas] ([Pers_Identidad])
GO

ALTER TABLE [Medi].[tbDietas] ADD FOREIGN KEY ([Alim_Id]) REFERENCES [Medi].[tbAlimentos] ([Alim_Id])
GO

ALTER TABLE [Medi].[tbDietas] ADD FOREIGN KEY ([Diag_Id]) REFERENCES [Medi].[tbDiagnosticos] ([Diag_Id])
GO

ALTER TABLE [Medi].[tbEntrenamientos] ADD FOREIGN KEY ([Ejer_Id]) REFERENCES [Medi].[tbEjercios] ([Ejer_Id])
GO

ALTER TABLE [Medi].[tbEntrenamientos] ADD FOREIGN KEY ([Diag_Id]) REFERENCES [Medi].[tbDiagnosticos] ([Diag_Id])
GO

ALTER TABLE [Gene].[tbPersonas] ADD FOREIGN KEY ([Usua_Id]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Acce].[tbUsuarios] ADD FOREIGN KEY ([Rol_Id]) REFERENCES [Acce].[tbRoles] ([Rol_Id])
GO

ALTER TABLE [Acce].[tbPantallasPorRoles] ADD FOREIGN KEY ([Pant_Id]) REFERENCES [Acce].[tbPantallas] ([Pant_Id])
GO

ALTER TABLE [Acce].[tbPantallasPorRoles] ADD FOREIGN KEY ([Rol_Id]) REFERENCES [Acce].[tbRoles] ([Rol_Id])
GO

ALTER TABLE [Acce].[tbUsuarios] ADD FOREIGN KEY ([Usua_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Acce].[tbUsuarios] ADD FOREIGN KEY ([Usua_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Acce].[tbRoles] ADD FOREIGN KEY ([Rol_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Acce].[tbRoles] ADD FOREIGN KEY ([Rol_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Acce].[tbPantallas] ADD FOREIGN KEY ([Pant_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Acce].[tbPantallas] ADD FOREIGN KEY ([Pant_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Acce].[tbPantallasPorRoles] ADD FOREIGN KEY ([PaRo_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Acce].[tbPantallasPorRoles] ADD FOREIGN KEY ([PaRo_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Gene].[tbEstados] ADD FOREIGN KEY ([Esta_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Gene].[tbEstados] ADD FOREIGN KEY ([Esta_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Gene].[tbCiudades] ADD FOREIGN KEY ([Ciud_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Gene].[tbCiudades] ADD FOREIGN KEY ([Ciud_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Gene].[tbEstadosCiviles] ADD FOREIGN KEY ([EsCi_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Gene].[tbEstadosCiviles] ADD FOREIGN KEY ([EsCi_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Gene].[tbPersonas] ADD FOREIGN KEY ([Pers_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Gene].[tbPersonas] ADD FOREIGN KEY ([Pers_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbTiposSangre] ADD FOREIGN KEY ([TiSa_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbTiposSangre] ADD FOREIGN KEY ([TiSa_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEnfermedades] ADD FOREIGN KEY ([Enfe_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEnfermedades] ADD FOREIGN KEY ([Enfe_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEstadosSalud] ADD FOREIGN KEY ([EsSa_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEstadosSalud] ADD FOREIGN KEY ([EsSa_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbAlimentos] ADD FOREIGN KEY ([Alim_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbAlimentos] ADD FOREIGN KEY ([Alim_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEnfermedadesPorPersona] ADD FOREIGN KEY ([EnPe_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEnfermedadesPorPersona] ADD FOREIGN KEY ([EnPe_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbDiagnosticos] ADD FOREIGN KEY ([Diag_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbDiagnosticos] ADD FOREIGN KEY ([Diag_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEjercios] ADD FOREIGN KEY ([Ejer_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEjercios] ADD FOREIGN KEY ([Ejer_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbDietas] ADD FOREIGN KEY ([Diet_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbDietas] ADD FOREIGN KEY ([Diet_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEntrenamientos] ADD FOREIGN KEY ([Entr_Creacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO

ALTER TABLE [Medi].[tbEntrenamientos] ADD FOREIGN KEY ([Entr_Modificacion]) REFERENCES [Acce].[tbUsuarios] ([Usua_Id])
GO
