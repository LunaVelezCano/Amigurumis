SELECT
    E.Nombre AS NombreEmpleado,
    TE.Nombre AS TipoEmpleado,
    S.Nombre AS NombreSede
FROM
    Empleado E
INNER JOIN
    TipoEmpleado TE ON E.IdTipoEmpleado = TE.IdTipoEmpleado
INNER JOIN
    Sede S ON E.IdSede = S.IdSede;
