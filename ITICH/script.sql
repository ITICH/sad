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
SET IDENTITY_INSERT [dbo].[Carateristicas_instalacoes] ON 
SET IDENTITY_INSERT [dbo].[Carateristicas_juridicas] ON 
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (1, N'Entidade Publica')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (2, N'Associação')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (3, N'Cooperativa')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (4, N'Sociedade Anónima')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (5, N'Sociedade por Quotas')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (6, N'Sociedade Coletiva')
INSERT [dbo].[Carateristicas_juridicas] ([id_carateristica_juridica], [tipo_carteristica]) VALUES (7, N'Empresa Publica Municipal')
SET IDENTITY_INSERT [dbo].[Carateristicas_juridicas] OFF
SET IDENTITY_INSERT [dbo].[Dominios_cientificos_tecnologicos] ON 
SET IDENTITY_INSERT [dbo].[Empresa] ON 
SET IDENTITY_INSERT [dbo].[Espacos_incubadora] ON 
SET IDENTITY_INSERT [dbo].[Fases_desenvolvimento] ON 
INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (1, N'Fase I')
INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (2, N'Fase II')
INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (3, N'Fase III')
INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (4, N'Fase IV')
INSERT [dbo].[Fases_desenvolvimento] ([id_fase_desenvolvimento], [nome_fase]) VALUES (5, N'Fase V')
SET IDENTITY_INSERT [dbo].[Fases_desenvolvimento] OFF
SET IDENTITY_INSERT [dbo].[Incubadoras] ON 
SET IDENTITY_INSERT [dbo].[Instalacoes] ON 
SET IDENTITY_INSERT [dbo].[Localizacao] ON 
SET IDENTITY_INSERT [dbo].[Nome_area] ON 
SET IDENTITY_INSERT [dbo].[Nome_dominio] ON 
SET IDENTITY_INSERT [dbo].[Parques_cientificos] ON 
SET IDENTITY_INSERT [dbo].[Perfil] ON 
INSERT [dbo].[Perfil] ([id], [perfil]) VALUES (1, N'ADM')
INSERT [dbo].[Perfil] ([id], [perfil]) VALUES (2, N'EMP')
SET IDENTITY_INSERT [dbo].[Perfil] OFF
SET IDENTITY_INSERT [dbo].[Resultados_simulacao] ON 
SET IDENTITY_INSERT [dbo].[Servicos_incubadora] ON 
SET IDENTITY_INSERT [dbo].[Servicos_incubadora] OFF
