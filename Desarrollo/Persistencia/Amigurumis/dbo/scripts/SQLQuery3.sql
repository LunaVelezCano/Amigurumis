SELECT 
    c.Nombre AS NombreCliente,
    fp.MetodoDePago AS MetodoDePago,
    dv.TotalVenta AS ValorTotalVenta
FROM [dbo].[Venta] v
INNER JOIN [dbo].[Cliente] c ON v.[IdCliente] = c.[IdCliente]
INNER JOIN [dbo].[DetalleDeVenta] dv ON v.[IdVenta] = dv.[IdVenta]
INNER JOIN [dbo].[FormaDePago] fp ON dv.[IdFormadePago] = fp.[IdFormadePago]
