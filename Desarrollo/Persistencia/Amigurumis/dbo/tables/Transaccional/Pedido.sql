CREATE TABLE [dbo].[Pedido] (
    [IdPedido]         UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdVenta]          UNIQUEIDENTIFIER NOT NULL,
    [FechaPedido]      DATE             NOT NULL,
    [FechaEntrega]     DATE             NOT NULL,
    [DirecciónEntrega] NVARCHAR (MAX)   NOT NULL,
    [Estado] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY CLUSTERED ([IdPedido] ASC)
);

