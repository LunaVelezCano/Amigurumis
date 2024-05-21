CREATE TABLE [dbo].[DetalleDeVenta] (
    [IdDetalleDeVenta] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdVenta]          UNIQUEIDENTIFIER NOT NULL,
    [IdFormadePago]    UNIQUEIDENTIFIER NOT NULL,
    [IdCliente]        UNIQUEIDENTIFIER NOT NULL,
    [IdProducto]       UNIQUEIDENTIFIER NOT NULL,
    [Concepto]         NVARCHAR (MAX)   NOT NULL,
    [ValorUnidad]      INT              NOT NULL,
    [TotalVenta]       INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([IdDetalleDeVenta] ASC),
    CONSTRAINT [FK_DetalleDeVenta_Venta] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[Venta] ([IdVenta]),
    CONSTRAINT [FK_DetalleDeVenta_FormadePago] FOREIGN KEY ([IdFormadePago]) REFERENCES [dbo].[FormaDePago] ([IdFormadePago]),
    CONSTRAINT [FK_DetalleDeVenta_Producto] FOREIGN KEY ([IdProducto]) REFERENCES [dbo].[Producto] ([IdProducto]),
    CONSTRAINT [FK_DetalleDeVenta_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([IdCliente])
);
