CREATE TABLE [dbo].[SMTPSettings] (
    [SmtpSettingID]         INT           IDENTITY (1, 1) NOT NULL,
    [PortNumber]            INT           CONSTRAINT [DF_SMTPSettings_PortNumber] DEFAULT ((25)) NOT NULL,
    [SMTPHost]              VARCHAR (100) CONSTRAINT [DF_SMTPSettings_SMTPHost] DEFAULT ('smtp.mweb.co..za') NOT NULL,
    [RequireAuthentication] BIT           CONSTRAINT [DF_SMTPSettings_RequireAuthentication] DEFAULT ((0)) NOT NULL,
    [RequiresSSL]           BIT           CONSTRAINT [DF_SMTPSettings_RequiresSSL] DEFAULT ((0)) NOT NULL,
    [FromAddress]           VARCHAR (100) CONSTRAINT [DF_SMTPSettings_FromAddress] DEFAULT ('info@mcdtraining.co.za') NOT NULL,
    [UserName]              VARCHAR (100) NOT NULL,
    [Password]              VARCHAR (100) NOT NULL,
    [DisplayName]           VARCHAR (100) CONSTRAINT [DF_SMTPSettings_DisplayName] DEFAULT ('MCD Communication') NOT NULL,
    CONSTRAINT [PK_SMTPSettings] PRIMARY KEY CLUSTERED ([SmtpSettingID] ASC)
);

