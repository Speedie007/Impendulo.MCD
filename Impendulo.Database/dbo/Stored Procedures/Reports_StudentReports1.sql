-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Reports_StudentReports1
--Drop Procedure Reports_StudentReports
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        dbo.Individuals.IndividualID, dbo.Individuals.IndividualFirstName, dbo.Individuals.IndividualSecondName, dbo.Individuals.IndividualLastname, dbo.LookupTitles.Title, 
                         dbo.Students.StudentCurrentPosition, dbo.Students.StudentIDNumber, dbo.LookupDisabilities.Disability, dbo.LookupEthnicities.Ethnicity, dbo.LookupMartialStatuses.MaritialStatus, 
                         dbo.LookupQualificationLevels.QualificationLevel, dbo.LookupGenders.Gender, dbo.Addresses.AddressLineOne, dbo.Addresses.AddressLineTwo, dbo.Addresses.AddressTown, dbo.Addresses.AddressSuburb, 
                         dbo.Addresses.AddressAreaCode, dbo.Addresses.AddressIsDefault, dbo.Addresses.AddressModifiedDate, dbo.LookupCountries.CountryName, dbo.LookupProvinces.Province, 
                         dbo.LookupAddressTypes.AddressType, dbo.ContactDetails.ContactDetailValue, dbo.LookupContactTypes.ContactType
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