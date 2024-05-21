CREATE TABLE [dbo].[HistorialPedido] (
    [IdHistorialPedido] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdCliente]         UNIQUEIDENTIFIER NOT NULL,
    [IdPedido]          UNIQUEIDENTIFIER NOT NULL,
    [FechaPedido]       DATE             NOT NULL,
    [ValorTotalPedido]  INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([IdHistorialPedido] ASC),
    CONSTRAINT [FK_HistorialPedido_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([IdCliente])
);

