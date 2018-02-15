CREATE TABLE [dbo].[Funcionario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] VARCHAR(50) NOT NULL, 
    [Cargo] VARCHAR(50) NOT NULL, 
    [Departamento] VARCHAR(50) NOT NULL
)
