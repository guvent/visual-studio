USE [cagbil]
GO

/****** Object:  Table [dbo].[faaliyet]    Script Date: 06/21/2013 01:21:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[faaliyet](
	[İş No] [int] NOT NULL,
	[Müşteri Ad Soyad] [varchar](50) NOT NULL,
	[Telefon No] [varchar](50) NULL,
	[Faaliyet Bilgisi] [varchar](150) NOT NULL,
	[Tarih Saat] [datetime] NOT NULL,
	[Durum] [nchar](10) NOT NULL,
 CONSTRAINT [PK_faaliyet] PRIMARY KEY CLUSTERED 
(
	[İş No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

