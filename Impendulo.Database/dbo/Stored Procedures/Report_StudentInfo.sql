

CREATE PROCEDURE Report_StudentInfo
--DROP PROCEDURE Report_StudentInfo
	
AS
	SELECT        TOP (200) Students.IndividualID, Students.StudentIDNumber, Students.StudentCurrentPosition, Students.StudentlInitialDate, LookupMartialStatuses.MaritialStatus, LookupGenders.Gender, 
                         LookupQualificationLevels.QualificationLevel, LookupEthnicities.Ethnicity, Individuals.IndividualFirstName, Individuals.IndividualSecondName, Individuals.IndividualLastname, Individuals.TitleID, 
                         LookupTitles.Title, Companies.CompanyName, Companies.CompanySETANumber, Companies.CompanySicCode, Companies.CompanySARSLevyRegistrationNumber
FROM            IndividualAddresses INNER JOIN
                         Addresses ON IndividualAddresses.AddressID = Addresses.AddressID INNER JOIN
                         LookupAddressTypes ON Addresses.AddressTypeID = LookupAddressTypes.AddressTypeID INNER JOIN
                         LookupCountries ON Addresses.CountryID = LookupCountries.CountryID INNER JOIN
                         LookupProvinces ON Addresses.ProvinceID = LookupProvinces.ProvinceID RIGHT OUTER JOIN
                         Students INNER JOIN
                         LookupMartialStatuses ON Students.MartialStatusID = LookupMartialStatuses.MartialStatusID INNER JOIN
                         LookupGenders ON Students.GenderID = LookupGenders.GenderID INNER JOIN
                         LookupEthnicities ON Students.EthnicityID = LookupEthnicities.EthnicityID INNER JOIN
                         LookupQualificationLevels ON Students.QualificationLevelID = LookupQualificationLevels.QualificationLevelID INNER JOIN
                         Individuals ON Students.IndividualID = Individuals.IndividualID INNER JOIN
                         LookupTitles ON Individuals.TitleID = LookupTitles.TitleID ON IndividualAddresses.IndividualID = Individuals.IndividualID LEFT OUTER JOIN
                         Companies INNER JOIN
                         StudentAssociatedCompany ON Companies.CompanyID = StudentAssociatedCompany.CompanyID ON Students.IndividualID = StudentAssociatedCompany.IndividualID