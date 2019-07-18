CREATE DATABASE dbAval
go
use dbAval
GO
CREATE TABLE [dbo].[tblConta] (
    [idConta]     INT         IDENTITY (1, 1)   NOT NULL PRIMARY KEY,
    [NumeroConta] VARCHAR (50) NOT NULL,
    [Saldo]       MONEY        NOT NULL
);

go


CREATE TABLE [dbo].[tblTransferencia] (
    [IdTransferencia]   INT         IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [ContaOrigem]       INT          NOT NULL,
    [ContaDestino]      INT          NOT NULL,
    [Valor]             VARCHAR (10) NOT NULL,
    [TipoTransferencia] VARCHAR (10) NOT NULL,
    [DataOcorrencia]    DATETIME     NOT NULL,
    [User]              VARCHAR (50) NOT NULL
);
go


ALTER TABLE [dbo].[tblTransferencia]
ADD CONSTRAINT FK_ContaOrigem FOREIGN KEY (ContaOrigem)
REFERENCES [dbo].[tblConta](idConta)
go
ALTER TABLE [dbo].[tblTransferencia]
ADD CONSTRAINT FK_ContaDestino FOREIGN KEY (ContaDestino)
REFERENCES [dbo].[tblConta](idConta)
