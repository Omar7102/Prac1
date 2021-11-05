CREATE TABLE [dbo].[Producto]
(
	[Id_producto] INT NOT NULL PRIMARY KEY, 
    [nombre_producto] NVARCHAR(MAX) NOT NULL, 
    [fecha_vencimiento] DATE NOT NULL, 
    [barcode] DATE NOT NULL, 
    [precio] DECIMAL(18, 2) NOT NULL, 
    [nit] INT NOT NULL, 
    [id_tipo] INT NOT NULL
)
