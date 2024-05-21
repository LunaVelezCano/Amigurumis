CREATE TABLE [dbo].[TipoDocumento]
(
	[IdTipoDocumento] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NewId(), 
    [TipoDeDocumento] NVARCHAR(MAX) NOT NULL, 
    [Activa] BIT NOT NULL DEFAULT 1, 
    [Actualiza] DATETIME NOT NULL DEFAULT getdate()
)
