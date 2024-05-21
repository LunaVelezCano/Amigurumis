CREATE TABLE [dbo].[FormaDePago] (
    [IdFormadePago] UNIQUEIDENTIFIER NOT NULL,
    [MetodoDePago]  NVARCHAR (MAX)   NOT NULL,
    [Descripcion]   NVARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([IdFormadePago] ASC)
);