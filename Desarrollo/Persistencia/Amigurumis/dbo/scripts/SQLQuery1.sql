SELECT 
    c.[IdCiudad] AS IdCiudad,
    c.Nombre AS NombreCiudad, 
    d.[IdDepartamento] AS IdDepartamento,
    d.Nombre AS NombreDepartamento, 
    p.[IdPais] AS IdPais,
    p.Nombre AS NombrePais
FROM [dbo].[Ciudad] AS c
INNER JOIN [dbo].[Departamento] AS d ON c.[IdDepartamento] = d.[IdDepartamento]
INNER JOIN [dbo].[Pais] AS p ON d.[IdPais] = p.[IdPais]
