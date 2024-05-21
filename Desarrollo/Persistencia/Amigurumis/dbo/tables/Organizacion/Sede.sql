CREATE TABLE [dbo].[Sede] (
    [IdSede]       UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdAmigurumis] UNIQUEIDENTIFIER NOT NULL,
    [IdCiudad]     UNIQUEIDENTIFIER NOT NULL,
    [Nombre]       NVARCHAR (MAX)   NULL,
    [Direccion]    NVARCHAR (MAX)   NULL,
    [Activo]       BIT              DEFAULT ((1)) NULL,
    [Actualiza]    DATETIME         DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Sede] PRIMARY KEY CLUSTERED ([IdSede] ASC),
    CONSTRAINT [FK_Sede_Amigurumis] FOREIGN KEY ([IdAmigurumis]) REFERENCES [dbo].[Amigurumis] ([IdAmigurumis]),
    CONSTRAINT [FK_Sede_Ciudad] FOREIGN KEY ([IdCiudad]) REFERENCES [dbo].[Ciudad] ([IdCiudad])
);