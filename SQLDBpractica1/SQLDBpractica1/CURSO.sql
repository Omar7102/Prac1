CREATE TABLE [dbo].[CURSO]
(
	[Cod] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [Fecha_inicio] NVARCHAR(50) NOT NULL, 
    [Duracion] INT NOT NULL, 
    [Valor] INT NOT NULL
)
