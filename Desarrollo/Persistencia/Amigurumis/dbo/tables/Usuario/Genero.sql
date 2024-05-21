﻿CREATE TABLE [dbo].[Genero]
(
	[IdGenero] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NewId(), 
    [Genero] NVARCHAR(MAX) NOT NULL, 
    [Activa] BIT NULL DEFAULT 1, 
    [Actualiza] DATETIME NULL DEFAULT getdate()
)
