CREATE TABLE [dbo].[ALUMNO]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [Ciudad] NVARCHAR(50) NOT NULL, 
    [Edad] INT NOT NULL
)
