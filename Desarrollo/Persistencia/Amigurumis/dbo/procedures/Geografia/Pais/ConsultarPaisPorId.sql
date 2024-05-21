CREATE PROCEDURE [dbo].[ConsultarPaisPorId]
	@IdPais UNIQUEIDENTIFIER = ''
AS
	BEGIN
		SELECT IdPais, Nombre, Activo, Actualiza
		FROM Pais
		WHERE IdPais = @IdPais	
			AND Activo = 1
	END
RETURN 0