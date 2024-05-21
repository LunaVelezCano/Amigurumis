CREATE TABLE [dbo].[Cliente] (
    [IdCliente]         UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdTipoDocumento]   UNIQUEIDENTIFIER NOT NULL,
    [IdGenero]          UNIQUEIDENTIFIER NOT NULL,
    [Nombre]            NVARCHAR (MAX)   NULL,
    [Apellido]          NVARCHAR (MAX)   NULL,
    [NumerodeDocumento] NVARCHAR (MAX)   NOT NULL,
    [Correo]            NVARCHAR (MAX)   NOT NULL,
    [Dirección]         NVARCHAR (MAX)   NOT NULL,
    [Activo]            BIT              DEFAULT ((1)) NULL,
    [Actualiza]         DATETIME         DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([IdCliente] ASC),
    CONSTRAINT [FK_Cliente_TipoDocumento] FOREIGN KEY ([IdTipoDocumento]) REFERENCES [dbo].[TipoDocumento] ([IdTipoDocumento]),
    CONSTRAINT [FK_Cliente_Genero] FOREIGN KEY ([IdGenero]) REFERENCES [dbo].[Genero] ([IdGenero])
);

