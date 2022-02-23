CREATE TABLE [dbo].[Terms]
(
	[Id] SMALLINT NOT NULL PRIMARY KEY,
    [OfficeId] SMALLINT NOT NULL,
    [ElectedDate] DATE NOT NULL, 
    [InaugurationDate] DATE NOT NULL, 
    [LastDate] DATE NULL, 
    CONSTRAINT [FK_Terms_Offices] FOREIGN KEY ([OfficeId]) REFERENCES [Offices]([Id])
)
