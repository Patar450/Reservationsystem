CREATE TABLE [dbo].[Boat_tbl]
(
	[BoatId] INT NOT NULL PRIMARY KEY, 
    [BoatName] NCHAR(30) NULL, 
    [BoatModel] NCHAR(15) NULL, 
    [BoatEngine] NCHAR(10) NULL, 
    [BoatYear] DATE NULL, 
    [BoatFT] INT NULL, 
    [WC] NCHAR(10) NULL, 
    [PAX] NCHAR(10) NULL, 
    [BoatRate] MONEY NULL
)
