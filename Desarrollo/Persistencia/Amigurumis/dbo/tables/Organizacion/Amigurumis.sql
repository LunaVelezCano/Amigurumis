CREATE TABLE [dbo].[Amigurumis] (
    [IdAmigurumis] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [NIT]          NVARCHAR (MAX)   NULL,
    [Nombre]       NVARCHAR (MAX)   NULL,
    [Activo]       BIT              DEFAULT ((1)) NULL,
    [Actualiza]    DATETIME         DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Amigurumis] PRIMARY KEY CLUSTERED ([IdAmigurumis] ASC)
);

