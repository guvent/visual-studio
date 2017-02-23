USE [cagbil]
GO

/****** Object:  Table [dbo].[ihtiyac]    Script Date: 06/21/2013 22:34:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ihtiyac](
	[No] [int] NOT NULL,
	[Barkod No] [varchar](50) NULL,
	[Ürün Adı] [varchar](50) NOT NULL,
	[İşlevi] [varchar](50) NOT NULL,
	[Grubu] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

