CREATE TABLE [dbo].[ValoracionProducto] (
    [IdValoracionProducto] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdCliente]            UNIQUEIDENTIFIER NOT NULL,
    [IdProducto]           UNIQUEIDENTIFIER NOT NULL,
    [Puntuacion]           NVARCHAR (MAX)   NOT NULL,
    [Comentario]           NVARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([IdValoracionProducto] ASC)
);

