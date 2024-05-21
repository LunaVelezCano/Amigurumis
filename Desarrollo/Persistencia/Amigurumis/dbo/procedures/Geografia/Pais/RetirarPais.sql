CREATE PROCEDURE [dbo].[RetirarPais]
	@IdPais UNIQUEIDENTIFIER = ''
AS
	BEGIN
		UPDATE Pais
		SET Activo = 0,
			Actualiza = GetDate()
		WHERE IdPais = @IdPais	
			AND Activo = 1
	END
RETURN 0