USE master;
GO
IF DB_ID (N'ITICH') IS NOT NULL
DROP DATABASE ITICH;
GO
CREATE DATABASE ITICH;
GO
-- Verify the database files and sizes
SELECT name, size, size*1.0/128 AS [Size in MBs]
FROM sys.master_files
WHERE name = N'ITICH';
GO

USE [ITICH]
GO
/****** Object:  Table [dbo].[Areas_negocios]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Areas_negocios](
	[id_area] [int] IDENTITY(1,1) NOT NULL,
	[id_parque] [int] NULL,
	[id_nome_area] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carateristicas_instalacoes]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carateristicas_instalacoes](
	[id_carateristicas] [int] IDENTITY(1,1) NOT NULL,
	[num_lotes] [int] NULL,
	[num_lotes_ocupados] [int] NULL,
	[estacionamento] [bit] NULL,
	[videovigilancia] [bit] NULL,
	[seguranca] [bit] NULL,
	[tipo_de_rede] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carateristicas_juridicas]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carateristicas_juridicas](
	[id_carateristica_juridica] [int] IDENTITY(1,1) NOT NULL,
	[tipo_carteristica] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dominios_cientificos_tecnologicos]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dominios_cientificos_tecnologicos](
	[id_dominio] [int] IDENTITY(1,1) NOT NULL,
	[id_parque] [int] NULL,
	[id_nome_dominio] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[nome_empresa] [nvarchar](50) NULL,
	[contacto_tel] [int] NULL,
	[password] [nvarchar](20) NOT NULL,
	[perfil] [int] NULL,
	[e_mail] [nvarchar](50) NULL,
	[validada] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Espacos_incubadora]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Espacos_incubadora](
	[id_espaco] [int] IDENTITY(1,1) NOT NULL,
	[tipo_espaco] [nvarchar](50) NULL,
	[id_incubadora] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fases_desenvolvimento]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fases_desenvolvimento](
	[id_fase_desenvolvimento] [int] IDENTITY(1,1) NOT NULL,
	[nome_fase] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incubadoras]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incubadoras](
	[id_incubadora] [int] IDENTITY(1,1) NOT NULL,
	[volume_negocios] [int] NULL,
	[numero_de_pessoas] [int] NULL,
	[nom_inc] [nvarchar](50) NULL,
	[id_parque] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instalacoes]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instalacoes](
	[id_instalacoes] [int] IDENTITY(1,1) NOT NULL,
	[id_carateristicas] [int] NULL,
	[id_parque] [int] NULL,
	[designaca] [nvarchar](50) NULL,
	[localidad] [nvarchar](50) NULL,
	[concelh] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localizacao]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localizacao](
	[id_localizacao] [int] IDENTITY(1,1) NOT NULL,
	[morada] [nvarchar](50) NULL,
	[distrit] [nvarchar](50) NULL,
	[concelh] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nome_area]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nome_area](
	[id_nome_area] [int] IDENTITY(1,1) NOT NULL,
	[nome_area] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nome_dominio]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nome_dominio](
	[id_nome_dominio] [int] IDENTITY(1,1) NOT NULL,
	[nome_dominio] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parques_cientificos]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parques_cientificos](
	[id_parque] [int] IDENTITY(1,1) NOT NULL,
	[entidade_gestora] [nvarchar](50) NOT NULL,
	[fins_lucrativos] [bit] NULL,
	[interesse_publico] [bit] NULL,
	[contacto_tel] [int] NULL,
	[ano_de_inicio] [date] NULL,
	[patrimonio_acossiativo_e_capital_social] [money] NULL,
	[id_fase_de_desenvolvimento] [int] NULL,
	[id_carateristica_juridica] [int] NULL,
	[id_localizacao] [int] NULL,
	[nome_parque] [nchar](50) NULL,
	[e_mail] [nvarchar](50) NULL,
	[temIncubadora] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[perfil] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resultados_simulacao]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resultados_simulacao](
	[id_resultado] [int] IDENTITY(1,1) NOT NULL,
	[id_empresa] [int] NOT NULL,
	[resultado] [xml] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicos_incubadora]    Script Date: 17/02/2021 15:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicos_incubadora](
	[id_servico] [int] IDENTITY(1,1) NOT NULL,
	[tipo_servico] [nvarchar](50) NULL,
	[id_incubadora] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Areas_negocios] ON 

INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (1, 1, 1)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (2, 1, 2)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (3, 1, 3)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (4, 1, 4)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (5, 1, 5)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (6, 2, 6)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (7, 2, 7)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (8, 2, 8)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (9, 2, 9)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (10, 2, 10)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (11, 2, 3)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (12, 2, 12)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (13, 4, 9)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (14, 4, 7)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (15, 5, 2)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (16, 5, 14)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (17, 6, 17)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (18, 8, 17)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (19, 9, 1)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (20, 9, 18)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (21, 9, 19)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (22, 9, 20)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (23, 10, 17)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (24, 11, 21)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (25, 11, 6)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (26, 11, 22)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (27, 12, 4)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (28, 12, 5)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (29, 13, 7)
INSERT [dbo].[Areas_negocios] ([id_area], [id_parque], [id_nome_area]) VALUES (30, 14, 22)
SET IDENTITY_INSERT [dbo].[Areas_negocios] OFF
SET IDENTITY_INSERT [dbo].[Carateristicas_instalacoes] ON 

INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (1, NULL, 34, 1, 1, 1, N'fibra otipca')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (2, NULL, 7, 1, 1, 1, N'fibra otipca')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (3, 16, 13, 1, 1, 1, N'fibra otipca')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (4, 10, 10, 1, 1, 1, N'test')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (5, 4, 3, 0, 1, 1, N'test')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (6, 0, 0, 1, 1, 1, N'fibra otipca')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (7, 24, 0, 1, 1, 1, N'fibra otica')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (8, 37, 0, 1, 1, 1, N'fibra otica')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (9, 26, 0, 1, 1, 1, N'fibra otica')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (10, 0, 0, 1, 1, 1, N'')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (11, 0, 0, 1, 1, 1, N'')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (12, 0, 0, 1, 1, 1, N'')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (13, 0, 0, 1, 1, 1, N'')
INSERT [dbo].[Carateristicas_instalacoes] ([id_carateristicas], [num_lotes], [num_lotes_ocupados], [estacionamento], [videovigilancia], [seguranca], [tipo_de_rede]) VALUES (14, 0, 0, 1, 1, 1, N'')
SET IDENTITY_INSERT [dbo].[Carateristicas_instalacoes] OFF
SET IDENTITY_INSERT [dbo].[Carateristicas_juridicas] ON 

INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (1, N'Entidade Publica')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (2, N'Associação')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (3, N'Cooperativa')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (4, N'Sociedade Anónima')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (5, N'Sociedade por Quotas')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (14, N'Sociedade Coletiva')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (15, N'Empresa Publica Municipal')
SET IDENTITY_INSERT [dbo].[Carateristicas_juridicas] OFF
SET IDENTITY_INSERT [dbo].[Dominios_cientificos_tecnologicos] ON 

INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (1, 1, 1)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (2, 1, 2)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (3, 1, 3)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (4, 4, 2)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (5, 5, 3)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (6, 8, 4)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (7, 9, 3)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (8, 10, 5)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (9, 11, 5)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (10, 12, 5)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (11, 13, 1)
INSERT [dbo].[Dominios_cientificos_tecnologicos] ([id_dominio], [id_parque], [id_nome_dominio]) VALUES (12, 14, 5)
SET IDENTITY_INSERT [dbo].[Dominios_cientificos_tecnologicos] OFF
SET IDENTITY_INSERT [dbo].[Empresa] ON 

INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (1, N'itich', 987654321, N'sad123', 1, N'itich@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (2, N'itich2', 123456789, N'qw', 2, N'itich2', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (3, N'empresa1', 123456789, N'qwe', 2, N'emp1', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (4, N'empresa2', 987654321, N'qwe', 2, N'email@ads.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (5, N'empresa3', 123456789, N'cXdlcXdl', 2, N'emp3@mail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (6, N'empresa5', 123456789, N'YXNk', 2, N'sad@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (7, N'emp6', 132456, N'YXNk', 2, N'emp7@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (8, N'empresa11', 123456789, N'cXdlcXdl', 2, N'emp11@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (9, N'emp12', 12345678, N'cXdl', 2, N'emp12@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (10, N'qweqwe', 987654321, N'YXNkYXNk', 2, N'm@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (11, N'zzz', 123456789, N'cQ==', 2, N'z@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (12, N'adddaadd', 123456789, N'cXdlcXdl', 2, N'aaaa@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (13, N'ddd', 123123123, N'YXNkYXNk', 2, N'dddd@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (14, N'testeteste', 123456789, N'cXdlcXdl', 2, N'asdasd@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (15, N'testetestetestes', 987654321, N'cXdlcXdl', 2, N'asdasdasd@gmail.com', NULL)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (16, N'itich3teste', 987654321, N'c2FkMTIz', 1, N'itich3@gmail.com', 1)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (17, N'testeVal', 987654321, N'cXdlcXdl', 2, N'testeVal@gmail.com', 1)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (18, N'teste123', 987654321, N'cXdlcXdl', 2, N'teste123@gmail.com', 1)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (19, N'empresaTeste', 987654321, N'cXdlcXdl', 2, N'testeEmp@gmail.com', 0)
INSERT [dbo].[Empresa] ([id_empresa], [nome_empresa], [contacto_tel], [password], [perfil], [e_mail], [validada]) VALUES (20, N'eeee', 123456789, N'cXdlcXdl', 2, N'eee@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[Empresa] OFF
SET IDENTITY_INSERT [dbo].[Espacos_incubadora] ON 

INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (1, N'Gabinete individual / co-working', 2)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (2, N'Gabinete virtual', 2)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (3, N'Sala de reuniões e de formação', 2)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (4, N'test', 2)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (5, N'test', 4)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (6, N'salas', 5)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (7, N'auditorio', 6)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (8, N'Salas', 7)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (9, N'Salas', 8)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (10, N'Lotes de terreno', 8)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (11, N'Salas de reuniões e auditório', 8)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (12, N'Apoio ao Empreendedorismo', 9)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (13, N'Incubação e Mentoring', 9)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (14, N'Assessoria em processos de Spin-Off', 9)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (15, N'Coaching em Internacionalização', 9)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (16, N'Orientação técnica na fase de constituição', 11)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (17, N'Serviços de contabilidade e planeamento fiscal', 11)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (18, N'Apoio da angariação de investimento', 11)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (19, N'Propriedade Intelectual e aconselhamento jurídico ', 11)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (20, N'Incubação e Cowork', 13)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (21, N'Gabinete de Inserção Profissional', 13)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (22, N'Acolhimento Empresarial', 13)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (23, N' Consultoria de Gestão', 13)
INSERT [dbo].[Espacos_incubadora] ([id_espaco], [tipo_espaco], [id_incubadora]) VALUES (24, N'Acesso a financiamento', 13)
SET IDENTITY_INSERT [dbo].[Espacos_incubadora] OFF
SET IDENTITY_INSERT [dbo].[Fases_desenvolvimento] ON 

INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (1, N'Fase I')
INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (2, N'Fase II')
INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (3, N'Fase III')
INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (4, N'Fase IV')
INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (5, N'Fase V')
SET IDENTITY_INSERT [dbo].[Fases_desenvolvimento] OFF
SET IDENTITY_INSERT [dbo].[Incubadoras] ON 

INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (2, NULL, NULL, N'Universidade de Aveiro Incubator', 1)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (4, 1314124, 9, N'test', 5)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (5, 52000000, 0, N'sanjotec', 6)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (6, 0, 0, N'sanjotec', 6)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (7, 0, 0, N'parkurbis', 6)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (8, 2500000, 0, N'parkurbis', 8)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (9, 58600000, 477, N'Regia Douro', 9)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (10, 0, 0, N' PCT Brigantia-Ecopark', 10)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (11, 190000000, 330, N'IPN', 11)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (12, 0, 400, N'Sines Tecnopolo', 12)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (13, 0, 50, N'INOV POINT', 13)
INSERT [dbo].[Incubadoras] ([id_incubadora], [volume_negocios], [numero_de_pessoas], [nom_inc], [id_parque]) VALUES (14, 1000000, 0, N'nonagon', 14)
SET IDENTITY_INSERT [dbo].[Incubadoras] OFF
SET IDENTITY_INSERT [dbo].[Instalacoes] ON 

INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (8, 1, 1, N'Universidade de Aveiro Incubator', NULL, N'Ilhavo')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (9, 2, 1, N'Design Factory Aveiro', NULL, N'Ilhavo')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (10, 3, 2, N'iParque', N'Coimbra', N'Antanhol')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (11, 4, 4, N'qwe', N'test', N'test')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (12, 5, 5, N'teste', N'etst', N'tes')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (13, 6, 6, N'salas', N'São joão da madeira', N'São joão da madeira')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (16, 9, 9, N'Regia Douro Park', N'Vila Real', N'Vila Real')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (17, 10, 10, N'Brigantia EcoPark', N'Bragança', N'Bragança')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (18, 11, 11, N'IPN', N'Coimbra', N'Coimbra')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (19, 12, 12, N'Sine TecnoPolo', N'Sines', N'Sines')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (20, 13, 13, N'Tagusvalley', N'Abrantes', N'Santarem')
INSERT [dbo].[Instalacoes] ([id_instalacoes], [id_carateristicas], [id_parque], [designaca], [localidad], [concelh]) VALUES (21, 14, 14, N'nonagon', N'Lagoa', N'Açores')
SET IDENTITY_INSERT [dbo].[Instalacoes] OFF
SET IDENTITY_INSERT [dbo].[Localizacao] ON 

INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (1, N'Avenida 25 de Abril 3830-044 Ílhavo', N'Aveiro', N'Ilhavo')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (2, N'Coimbra', N'Coimbra', N'Antanhol')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (4, N'teste', N'teste', N'teste')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (5, N'asd', N'porto', N'gaia')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (6, N'R. de Fundões 151, 3700-121 São ', N'Aveiro', N'São joão da madeira')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (7, N'Parque de Ciência e Tecnologia da Covilhã, SA', N'Castelo Branco', N'Covilhã')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (9, N'Regia Douro Park, 5000-033, Vila Real', N'Vila Real', N'Vila Real')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (10, N'Av. Cidade de Léon, 506, 5300-358', N'Bragança', N'Bragança')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (11, N'Rua Pedro Nunes,3030 - 199 Coimbra', N'Coimbra', N'Coimbra')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (12, N'Z.I.L. II, Lote 122-A, 7520-309 Sines', N'Lisboa', N'Sines')
INSERT [dbo].[Localizacao] ([id_localizacao], [morada], [distrit], [concelh]) VALUES (13, N'Rua José Dias Simão, 2200-062 ABRANTES', N'Santarém', N'ABRANTES')
SET IDENTITY_INSERT [dbo].[Localizacao] OFF
SET IDENTITY_INSERT [dbo].[Nome_area] ON 

INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (1, N'Agroindustrial                                    ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (2, N'Energia                                           ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (3, N'Materiais                                         ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (4, N'TICE                                              ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (5, N'Mar                                               ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (6, N'Saúde                                             ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (7, N'Tecnologias Biologicas                            ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (8, N'Tecnologias da Informação                         ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (9, N'Comunicação                                       ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (10, N'Eletrónica                                        ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (14, N'teste                                             ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (12, N'Nanotecnologia                                    ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (13, N'Biotecnologia                                     ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (15, N'testesteste                                       ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (16, N'eee                                               ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (17, N'De base tecnologica                               ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (18, N'agro-alimentar                                    ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (19, N'enologia                                          ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (20, N'viticultura                                       ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (21, N'informatica                                       ')
INSERT [dbo].[Nome_area] ([id_nome_area], [nome_area]) VALUES (22, N'engenharia                                        ')
SET IDENTITY_INSERT [dbo].[Nome_area] OFF
SET IDENTITY_INSERT [dbo].[Nome_dominio] ON 

INSERT [dbo].[Nome_dominio] ([id_nome_dominio], [nome_dominio]) VALUES (1, N'Biotecnologia Industrial')
INSERT [dbo].[Nome_dominio] ([id_nome_dominio], [nome_dominio]) VALUES (2, N'Bioeconomia e Economia circular')
INSERT [dbo].[Nome_dominio] ([id_nome_dominio], [nome_dominio]) VALUES (3, N'Agroflorestal')
INSERT [dbo].[Nome_dominio] ([id_nome_dominio], [nome_dominio]) VALUES (4, N'De base tecnologica')
INSERT [dbo].[Nome_dominio] ([id_nome_dominio], [nome_dominio]) VALUES (5, N'Diversos')
SET IDENTITY_INSERT [dbo].[Nome_dominio] OFF
SET IDENTITY_INSERT [dbo].[Parques_cientificos] ON 

INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (1, N'Universidade de Aveiro ', 1, 1, 234243750, CAST(N'2010-03-01' AS Date), 7500000.0000, 4, 4, 1, N'PCI - Creative Science Park Aveiro Region         ', N'pci@pci.pt', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (2, N'Coimbra iParque', 1, 1, 239244500, CAST(N'2010-01-01' AS Date), 1000000.0000, 2, 15, 2, N'iparque                                           ', N'geral@coimbraiparque.pt', 0)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (3, N'Biocant Park', 0, 1, 231410890, CAST(N'1970-01-01' AS Date), NULL, 3, 3, 2, N'Biocant Park                                      ', N'info@biocant.pt', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (4, N'teste', 0, 1, 987654321, CAST(N'1970-01-01' AS Date), NULL, 2, 3, 4, N'teste                                             ', N'qwe@gmail.com', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (5, N'teste', 0, 1, 123456789, CAST(N'1970-01-01' AS Date), NULL, NULL, 2, 5, N'asd                                               ', N'teste@gmail.com', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (6, N'sanjotec', 0, 1, 256001900, CAST(N'1970-01-01' AS Date), 52000000.0000, 2, 3, 6, N'sanjotec                                          ', N'geral@sanjotec.com', NULL)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (8, N'parkurbis', 1, 1, 275957000, CAST(N'2001-01-01' AS Date), 2500000.0000, 1, 3, 7, N'parkurbis                                         ', N'info@parkurbis.pt', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (9, N'Universidade de Trás-os-Montes e Alto Douro (UTAD)', 1, 1, 259308200, CAST(N'2021-01-04' AS Date), 58600000.0000, 3, 0, 9, N'Regia Douro                                       ', N'info@regiadouro.com', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (10, N'Brigantia EcoPark', 0, 0, 273310300, CAST(N'2001-01-04' AS Date), 0.0000, 0, 3, 10, N'Brigantia EcoPark                                 ', N'info@brigantia-ecopark.pt', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (11, N'instituto pedro nunes', 0, 1, 239700900, CAST(N'1991-01-04' AS Date), 190000000.0000, 2, 2, 11, N'instituto pedro nunes                             ', N'info@ipn.pt', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (12, N'SinesTecnoPolo', 0, 1, 269000300, CAST(N'2021-01-04' AS Date), 0.0000, 2, 2, 12, N'SinesTecnoPolo                                    ', N'info@sinestecnopolo.org', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (13, N'Tagusvalley', 0, 1, 241330330, CAST(N'2021-01-04' AS Date), 50000000.0000, 2, 1, 13, N'Tagusvalley                                       ', N'geral@tagusvalley.pt', 1)
INSERT [dbo].[Parques_cientificos] ([id_parque], [entidade_gestora], [fins_lucrativos], [interesse_publico], [contacto_tel], [ano_de_inicio], [patrimonio_acossiativo_e_capital_social], [id_fase_de_desenvolvimento], [id_carateristica_juridica], [id_localizacao], [nome_parque], [e_mail], [temIncubadora]) VALUES (14, N'nonagon', 0, 1, 965985090, CAST(N'2021-01-04' AS Date), 1000000.0000, 3, 2, 13, N'nonagon                                           ', N'geral@nonagon.pt', 1)
SET IDENTITY_INSERT [dbo].[Parques_cientificos] OFF
SET IDENTITY_INSERT [dbo].[Perfil] ON 

INSERT [dbo].[Perfil] ([id], [perfil]) VALUES (1, N'ADM')
INSERT [dbo].[Perfil] ([id], [perfil]) VALUES (2, N'EMP')
SET IDENTITY_INSERT [dbo].[Perfil] OFF
SET IDENTITY_INSERT [dbo].[Resultados_simulacao] ON 

INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (1, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (2, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (3, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (4, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (5, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (6, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (7, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (8, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (9, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (11, 16, N'sanjotec__________________________________________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (12, 16, N'sanjotecXMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (13, 16, N'sanjotec_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (14, 16, N'PCI-CreativeScienceParkAveiroRegion_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (15, 16, N'PCI-CreativeScienceParkAveiroRegion_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (16, 16, N'PCI-CreativeScienceParkAveiroRegion_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (17, 16, N'PCI-CreativeScienceParkAveiroRegion_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (18, 16, N'sanjotec_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (19, 16, N'sanjotec_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (20, 16, N'institutopedronunes_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (21, 16, N'institutopedronunes_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (22, 16, N'iparque_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (23, 16, N'institutopedronunes_XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (10, 16, N'PCI_-_Creative_Science_Park_Aveiro_Region_________XMLparque.xml')
INSERT [dbo].[Resultados_simulacao] ([id_resultado], [id_empresa], [resultado]) VALUES (24, 16, N'teste_XMLparque.xml')
SET IDENTITY_INSERT [dbo].[Resultados_simulacao] OFF
SET IDENTITY_INSERT [dbo].[Servicos_incubadora] ON 

INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (1, N'Acompanhamento na gestão operacional do negócio', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (2, N'Assessoria e apoio jurídico', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (6, N'Apoio consolidação do modelo e plano de negócios', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (8, N'Apoio proteção direitos de propriedade intelectual', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (13, N'Acesso portefólio de competências e serviços da UA', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (17, N'Apoio constituição da empresa, início de atividade', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (18, N'Apoio na estruturação da estratégia de comunicação', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (20, N'Apoio divulgação da atividade, produtos e serviços', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (21, N'Contacto com investidores e entidades financeiras', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (22, N'test', 2)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (23, N'test', 4)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (24, N'Divulgação informação interesse empresarial', 5)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (25, N'Sessões capacitação gestão de startups', 6)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (26, N'Serviços de telecomunicações', 7)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (27, N'Salas', 8)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (28, N'Lotes de terreno', 8)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (29, N'Salas de reuniões e auditório', 8)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (30, N'Salas para Start-ups', 9)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (31, N'Salas para Coworking', 9)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (32, N'salas para empresas consolidadas', 10)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (33, N'sala de incubação', 10)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (34, N'Salas de reuniões', 10)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (35, N'Laboratórios', 10)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (36, N'Sala de Reuniões', 11)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (37, N'Sala de Incubação', 11)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (38, N'Sala de Pré-incubação', 12)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (39, N'Laboratório de Pré-incubação', 12)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (40, N'espaços reservados', 12)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (41, N'Incubação Fisica', 13)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (42, N'Cowork & Virtual', 13)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (43, N' Espaço COWORK', 14)
INSERT [dbo].[Servicos_incubadora] ([id_servico], [tipo_servico], [id_incubadora]) VALUES (44, N'incubação', 14)
SET IDENTITY_INSERT [dbo].[Servicos_incubadora] OFF