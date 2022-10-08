USE [Tarefas]
GO

/****** Object:  Table [dbo].[Tarefas]    Script Date: 08/10/2022 16:24:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tarefas](
	[IdTarefa] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NULL,
	[Status] [nchar](1) NULL
) ON [PRIMARY]
GO


