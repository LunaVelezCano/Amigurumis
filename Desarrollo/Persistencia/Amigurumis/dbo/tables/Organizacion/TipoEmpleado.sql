CREATE TABLE [dbo].[TipoEmpleado] (
    [IdTipoEmpleado] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Nombre]         NVARCHAR (MAX)   NULL,
    [Activo]         BIT              DEFAULT ((1)) NULL,
    [Actualiza]      DATETIME         DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_TipoEmpleado] PRIMARY KEY CLUSTERED ([IdTipoEmpleado] ASC)
);