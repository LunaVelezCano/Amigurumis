CREATE TABLE [dbo].[Venta] (
    [IdVenta]    UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdEmpleado] UNIQUEIDENTIFIER NOT NULL,
    [IdCliente]  UNIQUEIDENTIFIER NOT NULL,
    [FechaVenta] DATE             NOT NULL,
    [TotalVenta] INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([IdVenta] ASC)
);
