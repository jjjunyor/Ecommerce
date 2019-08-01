CREATE database [dbAVAL]
go
USE [dbAVAL]
GO

CREATE TABLE [dbo].[tblProduto](
	[idProduto] [int] IDENTITY(1,1) NOT NULL,
	[desProduto] [varchar](50) NOT NULL,
	[quantidade] [int] NOT NULL,
	[Valor] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblSeguranca](
	[idToken] [int] IDENTITY(1,1) NOT NULL,
	[Token] [varchar](250) NOT NULL,
	[DataGeracao] [DateTime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idToken] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

insert into tblProduto (desProduto,quantidade,Valor)values('caneta preta',200,2.0)
insert into tblProduto (desProduto,quantidade,Valor)values('lapis de cor',400,1.0)
insert into tblProduto (desProduto,quantidade,Valor)values('caderno 500 folha',30,45.6)
