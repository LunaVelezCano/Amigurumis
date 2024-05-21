CREATE TABLE [dbo].[Empleado] (
    [IdEmpleado]        UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdTipoEmpleado]    UNIQUEIDENTIFIER NOT NULL,
    [IdSede]            UNIQUEIDENTIFIER NOT NULL,
    [TipodeDocumento]   NVARCHAR (MAX)   NULL,
    [NumerodeDocumento] NVARCHAR (MAX)   NOT NULL,
    [Nombre]            NVARCHAR (MAX)   NULL,
    [Apellido]          NVARCHAR (MAX)   NULL,
    [Activo]            BIT              DEFAULT ((1)) NULL,
    [Actualiza]         DATETIME         DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED ([IdEmpleado] ASC),
    CONSTRAINT [FK_Empleado_Sede] FOREIGN KEY ([IdSede]) REFERENCES [dbo].[Sede] ([IdSede]),
    CONSTRAINT [FK_Empleado_TipoEmpleado] FOREIGN KEY ([IdTipoEmpleado]) REFERENCES [dbo].[TipoEmpleado] ([IdTipoEmpleado])
);
