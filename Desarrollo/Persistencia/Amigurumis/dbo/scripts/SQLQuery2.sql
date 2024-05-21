SELECT 
    cat.Nombre AS NombreCategoria,
    prod.Nombre AS NombreProducto,
    val.Puntuacion AS Valoracion,
    val.Comentario AS ComentarioValoracion,
    cli.Nombre AS NombreCliente
FROM [dbo].[ValoracionProducto] val
INNER JOIN [dbo].[Cliente] cli ON val.[IdCliente] = cli.[IdCliente]
INNER JOIN [dbo].[Producto] prod ON val.[IdProducto] = prod.[IdProducto]
INNER JOIN [dbo].[Categoria] cat ON prod.[IdCategoria] = cat.[IdCategoria]
