USE [Articulos]
GO
/****** Object:  Table [dbo].[Informacion]    Script Date: 05/07/2021 21:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Informacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Detalles] [varchar](200) NOT NULL,
	[Cantidad] [bigint] NOT NULL,
	[Precio] [money] NOT NULL,
	[Stock] [varchar](50) NOT NULL,
	[Existencia] [bit] NOT NULL,
 CONSTRAINT [PK_Informacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Informacion] ON 
GO
INSERT [dbo].[Informacion] ([Id], [Nombre], [Detalles], [Cantidad], [Precio], [Stock], [Existencia]) VALUES (1, N'Laptop', N'I9 G9na 16GB Ram 1TB SSD Ryden Graphics 8GB', 11, 1750.0000, N'A Tope', 1)
GO
SET IDENTITY_INSERT [dbo].[Informacion] OFF
GO
