CREATE TABLE [dbo].[LookupAddressTypes] (
    [AddressTypeID] INT          IDENTITY (1, 1) NOT NULL,
    [AddressType]   VARCHAR (25) CONSTRAINT [DF_LookupAddressTypes_AddressType] DEFAULT ('Unknown') NOT NULL,
    CONSTRAINT [PK_LookupAddressTypes] PRIMARY KEY CLUSTERED ([AddressTypeID] ASC)
);

