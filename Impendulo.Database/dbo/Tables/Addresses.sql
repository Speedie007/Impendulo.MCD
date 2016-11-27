CREATE TABLE [dbo].[Addresses] (
    [AddressID]           INT           IDENTITY (1, 1) NOT NULL,
    [AddressTypeID]       INT           NOT NULL,
    [CountryID]           INT           NOT NULL,
    [ProvinceID]          INT           NOT NULL,
    [AddressLineOne]      VARCHAR (100) CONSTRAINT [DF_Addresses_AddressLineOne] DEFAULT ('') NOT NULL,
    [AddressLineTwo]      VARCHAR (100) CONSTRAINT [DF_Addresses_AddressLineTwo] DEFAULT ('') NOT NULL,
    [AddressTown]         VARCHAR (50)  CONSTRAINT [DF_Addresses_AddressTown] DEFAULT ('') NOT NULL,
    [AddressSuburb]       VARCHAR (50)  CONSTRAINT [DF_Addresses_Suburb] DEFAULT ('') NOT NULL,
    [AddressAreaCode]     VARCHAR (10)  CONSTRAINT [DF_Addresses_AddressAreaCode] DEFAULT ('') NOT NULL,
    [AddressIsDefault]    BIT           CONSTRAINT [DF_Addresses_CompanyAddressIsDefault] DEFAULT ((1)) NOT NULL,
    [AddressModifiedDate] DATETIME      CONSTRAINT [DF_Addresses_AddressModifiedDate] DEFAULT (getdate()) NOT NULL,
    [RowVersion]          ROWVERSION    NOT NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED ([AddressID] ASC),
    CONSTRAINT [FK_Addresses_LookupAddressTypes] FOREIGN KEY ([AddressTypeID]) REFERENCES [dbo].[LookupAddressTypes] ([AddressTypeID]),
    CONSTRAINT [FK_Addresses_LookupCountries] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[LookupCountries] ([CountryID]),
    CONSTRAINT [FK_Addresses_LookupProvinces] FOREIGN KEY ([ProvinceID]) REFERENCES [dbo].[LookupProvinces] ([ProvinceID])
);



