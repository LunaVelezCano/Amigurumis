CREATE PROCEDURE [dbo].[ModificarPais]
	@IdPais UNIQUEIDENTIFIER = ' ',
	@Nombre NVARCHAR(MAX) = ' '
AS
	BEGIN
		UPDATE Pais
		SET Nombre = @Nombre,
		Actualiza = GetDate()
		WHERE IdPais = @IdPais
		AND Activo = 1
	END
RETURN 0
