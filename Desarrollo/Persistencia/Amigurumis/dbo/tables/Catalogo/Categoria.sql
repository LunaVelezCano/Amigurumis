CREATE TABLE [dbo].[Categoria] (
    [IdCategoria] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Nombre]      NVARCHAR (MAX)   NOT NULL,
    [Descripcion] NVARCHAR (MAX)   NULL,
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC)
);


