CREATE TABLE [dbo].[Producto] (
    [IdProducto]           UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdCategoria]          UNIQUEIDENTIFIER NOT NULL,
    [Nombre]               NVARCHAR (MAX)   NOT NULL,
    [Activo]               BIT              DEFAULT ((1)) NULL,
    [UnidadesenExistencia] NCHAR (10)       NULL,
    CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED ([IdProducto] ASC),
    CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY ([IdCategoria]) REFERENCES [dbo].[Categoria] ([IdCategoria])
);

