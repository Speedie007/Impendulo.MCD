CREATE TABLE [dbo].[LookupEnquiryStatuses] (
    [EnquiryStatusID] INT           IDENTITY (1, 1) NOT NULL,
    [EnquiryStatus]   VARCHAR (100) CONSTRAINT [DF_LookupEnquiryStatuses_EnquiryStatus] DEFAULT ('New') NOT NULL,
    CONSTRAINT [PK_LookupEnquiryStatuses] PRIMARY KEY CLUSTERED ([EnquiryStatusID] ASC)
);

