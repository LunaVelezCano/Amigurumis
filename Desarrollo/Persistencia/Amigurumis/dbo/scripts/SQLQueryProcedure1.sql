CREATE PROCEDURE [dbo].[IngresarPais]
	@Nombre NVARCHAR(MAX) = ' '
AS
	BEGIN
	INSERT INTO Pais(Nombre)
	VALUES(@Nombre)
	END
RETURN 0