﻿CREATE TABLE [dbo].[Names]
(
	[Id] SMALLINT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [MiddleName] NVARCHAR(50) NOT NULL,
    [LastName] NVARCHAR(50) NOT NULL,
    [DateOfBirth] DATE NOT NULL,
    [DateOfDeath] DATE NULL,
)
