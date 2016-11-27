CREATE TABLE [dbo].[Venues] (
    [VenueID]          INT          IDENTITY (1, 1) NOT NULL,
    [Venue]            VARCHAR (50) CONSTRAINT [DF_Venues_Venue] DEFAULT ('Unknown') NOT NULL,
    [VenueMaxCapacity] INT          CONSTRAINT [DF_Venues_VenueMaxCapacity] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Venues] PRIMARY KEY CLUSTERED ([VenueID] ASC)
);



