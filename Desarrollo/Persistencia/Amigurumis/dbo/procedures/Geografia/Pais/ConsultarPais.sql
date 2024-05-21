CREATE PROCEDURE [dbo].[ConsultarPais]
	
AS
	Begin
		SELECT IdPais, Nombre, Activo, Actualiza
		FROM Pais
		WHERE Activo = 1
	END
RETURN 0
