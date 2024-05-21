CREATE TABLE [dbo].[Ciudad] (
    [IdCiudad]       UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdDepartamento] UNIQUEIDENTIFIER NULL,
    [Nombre]         NVARCHAR (MAX)   NULL,
    [Activo]         BIT              DEFAULT ((1)) NULL,
    [Actualiza]      DATETIME         DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED ([IdCiudad] ASC),
    CONSTRAINT [FK_Ciudad_Departamento] FOREIGN KEY ([IdDepartamento]) REFERENCES [dbo].[Departamento] ([IdDepartamento])
);