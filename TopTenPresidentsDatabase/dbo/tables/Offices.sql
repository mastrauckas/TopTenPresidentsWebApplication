CREATE TABLE [dbo].[Offices]
(
	[Id] SMALLINT NOT NULL PRIMARY KEY IDENTITY, 
    [PresidentNameId] SMALLINT NOT NULL,
	[VicePresidentNameId] SMALLINT NOT NULL,
	[TermId] SMALLINT NOT NULL,
	[PolicitalParty] NVARCHAR(200) NOT NULL,
    CONSTRAINT [FK_Offices_Names_PresidentNameId] FOREIGN KEY ([PresidentNameId]) REFERENCES [Names]([Id]),
	CONSTRAINT [FK_Offices_Names_VicePresidentNameId] FOREIGN KEY ([VicePresidentNameId]) REFERENCES [Names]([Id]),
)