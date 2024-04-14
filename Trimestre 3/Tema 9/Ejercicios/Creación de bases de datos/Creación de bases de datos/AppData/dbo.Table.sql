CREATE TABLE [dbo].[Medicamentos]
(
	[Id] INT NOT NULL IDENTITY, 
    [Codigo] CHAR(6) NOT NULL, 
    [PrincipioActivo] VARCHAR(50) NOT NULL, 
    [Posologia] VARCHAR(200) NOT NULL, 
    [Familia] VARCHAR(50) NOT NULL, 
    [NombreComercial] VARCHAR(50) NOT NULL, 
    [FormaFarmaceutica] VARCHAR(50) NOT NULL, 
    [Dosis] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id]) 
)
