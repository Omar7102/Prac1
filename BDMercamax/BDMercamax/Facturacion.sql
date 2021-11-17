﻿CREATE TABLE [dbo].[Facturacion]
(
	[id_factura] INT NOT NULL PRIMARY KEY, 
    [monto_total] DECIMAL(18, 2) NOT NULL, 
    [fecha] DATE NOT NULL, 
    [monto_iva] DECIMAL(18, 2) NOT NULL, 
    [cc_cliente] INT NOT NULL, 
    [cc_personal] INT NOT NULL, 
    [id_venta] INT NOT NULL, 
    
)
