-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Reports_StudentReports]
--Drop Procedure Reports_StudentReports
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        
		ISNULL(dbo.Individuals.IndividualID,'0') as StudentID,
		ISNULL(dbo.Individuals.IndividualFirstName,'Unknown') as IndividualFirstName, 
		ISNULL(dbo.Individuals.IndividualSecondName,'Unknown') as IndividualSecondName, 
		ISNULL(dbo.Individuals.IndividualLastname,'Unknown') as IndividualLastname, 
		ISNULL(dbo.LookupTitles.Title,'Mr') as Title, 
		ISNULL(dbo.Students.StudentCurrentPosition,'Unknown') as StudentCurrentPosition, 
		ISNULL(dbo.Students.StudentIDNumber,'0000000000000') as StudentIDNumber, 
		ISNULL(dbo.LookupDisabilities.Disability,'Unknown') AS Disability, 
		ISNULL(dbo.LookupEthnicities.Ethnicity,'Unknown') as Ethnicity, 
		ISNULL(dbo.LookupMartialStatuses.MaritialStatus,'Unknown') aS MaritialStatus , 
		ISNULL(dbo.LookupQualificationLevels.QualificationLevel,'Unknown') as QualificationLevel, 
		ISNULL(dbo.LookupGenders.Gender,'Unknown') as Gender, 
		ISNULL(dbo.Addresses.AddressLineOne,'Unknown')as AddressLineOne, 
		ISNULL(dbo.Addresses.AddressLineTwo,'Unknown') AS AddressLineTwo, 
		ISNULL(dbo.Addresses.AddressTown,'Unknown')as AddressTown, 
		ISNULL(dbo.Addresses.AddressSuburb,'Unknown') as AddressSuburb, 
		ISNULL(dbo.Addresses.AddressAreaCode,'0000') as AddressAreaCode, 
		ISNULL(dbo.Addresses.AddressIsDefault,0) as AddressIsDefault, 
		ISNULL(dbo.Addresses.AddressModifiedDate,'01/01/01') as AddressModifiedDate, 
		ISNULL(dbo.LookupCountries.CountryName,'Unknown') as CountryName, 
		ISNULL(dbo.LookupProvinces.Province,'Unknown') as Province, 
		ISNULL(dbo.LookupAddressTypes.AddressType,'Unknown') as AddressType, 
		ISNULL(dbo.ContactDetails.ContactDetailValue,'Unknown') as ContactDetailValue, 
		ISNULL(dbo.LookupContactTypes.ContactType,'Unknown') AS ContactType
FROM            dbo.IndividualContactDetails INNER JOIN
                         dbo.ContactDetails ON dbo.IndividualContactDetails.ContactDetailID = dbo.ContactDetails.ContactDetailID INNER JOIN
                         dbo.LookupContactTypes ON dbo.ContactDetails.ContactTypeID = dbo.LookupContactTypes.ContactTypeID RIGHT OUTER JOIN
                         dbo.LookupQualificationLevels INNER JOIN
                         dbo.Individuals INNER JOIN
                         dbo.Students ON dbo.Individuals.IndividualID = dbo.Students.IndividualID INNER JOIN
                         dbo.LookupTitles ON dbo.Individuals.TitleID = dbo.LookupTitles.TitleID INNER JOIN
                         dbo.LookupEthnicities ON dbo.Students.EthnicityID = dbo.LookupEthnicities.EthnicityID INNER JOIN
                         dbo.LookupMartialStatuses ON dbo.Students.MartialStatusID = dbo.LookupMartialStatuses.MartialStatusID ON dbo.LookupQualificationLevels.QualificationLevelID = dbo.Students.QualificationLevelID INNER JOIN
                         dbo.LookupGenders ON dbo.Students.GenderID = dbo.LookupGenders.GenderID ON dbo.IndividualContactDetails.IndividualID = dbo.Individuals.IndividualID LEFT OUTER JOIN
                         dbo.Addresses INNER JOIN
                         dbo.IndividualAddresses ON dbo.Addresses.AddressID = dbo.IndividualAddresses.AddressID INNER JOIN
                         dbo.LookupCountries ON dbo.Addresses.CountryID = dbo.LookupCountries.CountryID INNER JOIN
                         dbo.LookupAddressTypes ON dbo.Addresses.AddressTypeID = dbo.LookupAddressTypes.AddressTypeID INNER JOIN
                         dbo.LookupProvinces ON dbo.Addresses.ProvinceID = dbo.LookupProvinces.ProvinceID ON dbo.Individuals.IndividualID = dbo.IndividualAddresses.IndividualID LEFT OUTER JOIN
                         dbo.LookupDisabilities INNER JOIN
                         dbo.StudentDisabilities ON dbo.LookupDisabilities.DisabilityID = dbo.StudentDisabilities.DisabilityID ON dbo.Students.IndividualID = dbo.StudentDisabilities.IndividualID


END