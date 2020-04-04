CREATE TABLE [dbo].[Plant]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] VARCHAR(50),
	[Description] VARCHAR(50),
	[PlantTypeID] INT,
	[SeasonID] VARCHAR(25)
)
