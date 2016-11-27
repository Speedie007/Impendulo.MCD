/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT TOP 1 * FROM [Companies])
BEGIN
SET IDENTITY_INSERT [dbo].[Companies] ON 
INSERT [dbo].[Companies] ([CompanyID], [CompanyName], [CompanySETANumber], [CompanySicCode], [CompanySARSLevyRegistrationNumber]) VALUES (2004, N'Inspection & Specification Services(ISS)', N'90068521422', N'ABE7512-325', N'900685214')
INSERT [dbo].[Companies] ([CompanyID], [CompanyName], [CompanySETANumber], [CompanySicCode], [CompanySARSLevyRegistrationNumber]) VALUES (2005, N'Test Company', N'15253-220', N'50632586-1120', N'1111111')
SET IDENTITY_INSERT [dbo].[Companies] OFF
END

IF NOT EXISTS (SELECT TOP 1 * FROM [LookupAddressTypes])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupAddressTypes] ON 
INSERT [dbo].[LookupAddressTypes] ([AddressTypeID], [AddressType]) VALUES (1, N'Postal')
INSERT [dbo].[LookupAddressTypes] ([AddressTypeID], [AddressType]) VALUES (2, N'Residential')
SET IDENTITY_INSERT [dbo].[LookupAddressTypes] OFF
END

IF NOT EXISTS (SELECT TOP 1 * FROM [LookupCountries])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupCountries] ON 
INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (1, N'South Africa', N'ZAR')
INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (2, N'Lesotho', N'LS')
INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (3, N'Mozambique', N'MZ')
INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (4, N'Zimbabwe', N'ZW')
INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (5, N'Namibia', N'NA')
SET IDENTITY_INSERT [dbo].[LookupCountries] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupProvinces])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupProvinces] ON 
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (1, N'Gauteng')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (2, N'Free State')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (3, N'Western Cape')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (4, N'Northern Cape')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (5, N'Eastern Cape')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (6, N'Limpopo')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (7, N'KwaZulu-Natal')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (8, N'Mpumalanga')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (9, N'North West')
SET IDENTITY_INSERT [dbo].[LookupProvinces] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [Addresses])
BEGIN
SET IDENTITY_INSERT [dbo].[Addresses] ON 
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (7040, 2, 1, 2, N'24 Jonkershoek Street', N'', N'Sasolburg', N'Vaalpark', N'1948', 1, CAST(N'2017-03-08T10:55:56.510' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (7041, 2, 1, 3, N'sdgfsadfsadfSDFSADFSADF', N'sadfasd', N'sadfasdfsadf', N'sdfasd', N'123', 1, CAST(N'2017-03-10T15:05:55.747' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8003, 2, 1, 2, N'dfsadsffadsf', N'dfdsaf', N'dsfadsds', N'33333332', N'22222', 0, CAST(N'2017-03-09T20:06:41.237' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8004, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:09:55.307' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8005, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:10:14.497' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8006, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:12:22.023' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8007, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:13:53.570' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8008, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:16:02.877' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8009, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:18:38.313' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8010, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:21:30.803' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8011, 1, 1, 1, N'sdfvsdafasdfasdf', N'asdfasdfa', N'asdfasd', N'asdfasd', N'34324234', 0, CAST(N'2017-03-09T20:28:00.610' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8012, 1, 1, 1, N'', N'', N'', N'', N'34324234', 0, CAST(N'2017-03-09T20:33:32.977' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8013, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:34:37.637' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8014, 1, 1, 1, N'yyyyyy', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:38:09.267' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8015, 2, 1, 3, N'Testing', N'adfdas', N'sdfsda', N'sdfsfad', N'', 1, CAST(N'2017-03-10T10:00:00.637' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8016, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:13:18.247' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8017, 2, 1, 2, N'test', N'test', N'fdasfds', N'afdsf', N'1234', 1, CAST(N'2017-03-10T15:06:36.423' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8018, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:14:06.913' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8019, 1, 1, 1, N'ldkfgsalkjdfhdkajs', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:14:47.927' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8020, 1, 1, 1, N'dkjfhsdakjf', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:15:01.600' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8021, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:16:25.333' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8022, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:20:49.740' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8023, 2, 1, 2, N'24 jonkershoek Street', N'', N'Sasolburg', N'Vaalpark', N'1948', 1, CAST(N'2017-03-10T10:23:35.393' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8024, 1, 1, 1, N'sdfadsfdsf', N'', N'', N'', N'', 0, CAST(N'2017-03-10T14:34:48.433' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8025, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T15:04:56.987' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9003, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-12T18:33:08.770' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9004, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-12T18:38:06.730' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9005, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-12T18:38:14.617' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9006, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-12T18:39:09.900' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9007, 1, 1, 2, N'8 Owen Horwood Street', N'', N'Sasolburb', N'Ext 11', N'1947', 0, CAST(N'2017-03-12T18:44:04.310' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9008, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-14T12:26:43.847' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9009, 2, 1, 1, N'fsdafsdafsadf', N'', N'', N'', N'', 1, CAST(N'2017-03-14T17:26:28.980' AS DateTime))
SET IDENTITY_INSERT [dbo].[Addresses] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [CompanyAddresses])
BEGIN
INSERT [dbo].[CompanyAddresses] ([CompanyID], [AddressID]) VALUES (2004, 7040)
INSERT [dbo].[CompanyAddresses] ([CompanyID], [AddressID]) VALUES (2004, 8007)
INSERT [dbo].[CompanyAddresses] ([CompanyID], [AddressID]) VALUES (2004, 8010)
INSERT [dbo].[CompanyAddresses] ([CompanyID], [AddressID]) VALUES (2005, 8025)
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupEnquiryStartDateTypes])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupEnquiryStartDateTypes] ON 
INSERT [dbo].[LookupEnquiryStartDateTypes] ([EnquiryStartDateTypeID], [EnquiryStartDateType]) VALUES (1, N'Client Requested Date')
INSERT [dbo].[LookupEnquiryStartDateTypes] ([EnquiryStartDateTypeID], [EnquiryStartDateType]) VALUES (2, N'System Determined Date')
SET IDENTITY_INSERT [dbo].[LookupEnquiryStartDateTypes] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [CostingModels])
BEGIN
SET IDENTITY_INSERT [dbo].[CostingModels] ON 
INSERT [dbo].[CostingModels] ([CostingModelID], [CostingModelName]) VALUES (1, N'Per Module')
INSERT [dbo].[CostingModels] ([CostingModelID], [CostingModelName]) VALUES (2, N'Per Day')
INSERT [dbo].[CostingModels] ([CostingModelID], [CostingModelName]) VALUES (3, N'Per Course')
SET IDENTITY_INSERT [dbo].[CostingModels] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupDepartments])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupDepartments] ON 
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (1004, N'Learnership')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (1005, N'Lifting Operator Training (LOPT)')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (1006, N'Surface Mobile Equipment')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (2004, N'Apprenticeship')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (2005, N'Short Courses')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (2009, N'Training Related Services')
SET IDENTITY_INSERT [dbo].[LookupDepartments] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [Curriculums])
BEGIN
SET IDENTITY_INSERT [dbo].[Curriculums] ON 
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (1, 1, 2004, N'Welder', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (2, 1, 2004, N'Fitter and Turner', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (3, 1, 2004, N'Fitter', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (4, 1, 2004, N'Turner', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (5, 1, 2004, N'Boilermaking', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (6, 1, 2004, N'Electrical', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (7, 1, 2004, N'Millwright', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (8, 1, 2004, N'Rigging', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (9, 1, 2004, N'Instrumentation', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (10, 2, 1004, N'National Certificate Electrical Engineering', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (11, 1, 1004, N'Engineering Fabrication', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (12, 1, 1004, N'Mechanical Engineering: Fitting & Machining', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (13, 1, 1004, N'Mechanical Engineering: Machining', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (14, 1, 1004, N'Mechanical Engineering: Fitting', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (15, 1, 1004, N'Metals Production', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (16, 1, 1004, N'Welding Application and Practice', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (17, 1, 2005, N'test', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (21, 1, 1005, N'Mobile Crane', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (1018, 2, 2009, N'Assessments', 0)
SET IDENTITY_INSERT [dbo].[Curriculums] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupContactTypes])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupContactTypes] ON 
INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (1, N'Email Address')
INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (2, N'Cell Number')
INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (3, N'Home Number')
INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (4, N'Office Number')
INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (2007, N'Fax Number')
SET IDENTITY_INSERT [dbo].[LookupContactTypes] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [ContactDetails])
BEGIN
SET IDENTITY_INSERT [dbo].[ContactDetails] ON 
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7002, N'', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7003, N'testdf', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7004, N'you', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7005, N'yesy', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7006, N'ggggggggggggggggg', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7007, N'Brendanw@mweb.co.za', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7008, N'(016) 897-1225', 2)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7009, N'inspec@cyberserv.co.za', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7010, N'(016) 971-2259', 4)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7011, N'(086) 600-2259', 2007)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7012, N'Brendanw@mweb.co.za', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7013, N'(082) 334-9956', 2)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7014, N'TestEmail@company.com', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7015, N'(016) 971-2259', 4)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7016, N'(016) 971-2259', 2007)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (7017, N'(082) 334-9956', 2)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8002, N'test', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8003, N'(016) 971-2259', 2007)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8004, N'hgkhjgjh', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8005, N'', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8006, N'', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8007, N'(016) 971-2259', 4)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8008, N'', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8009, N'', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8010, N'(016) 971-2259', 2007)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8011, N'', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8012, N'test', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (8013, N'brendanw@mweb.co.za', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (9002, N'(012) 546-5465', 4)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (9003, N'(082) 334-9956', 2)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (9004, N'', 1)
SET IDENTITY_INSERT [dbo].[ContactDetails] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [CompanyContactDetails])
BEGIN
INSERT [dbo].[CompanyContactDetails] ([CompanyID], [ContactDetailID]) VALUES (2004, 7009)
INSERT [dbo].[CompanyContactDetails] ([CompanyID], [ContactDetailID]) VALUES (2004, 7010)
INSERT [dbo].[CompanyContactDetails] ([CompanyID], [ContactDetailID]) VALUES (2004, 7011)
INSERT [dbo].[CompanyContactDetails] ([CompanyID], [ContactDetailID]) VALUES (2005, 7014)
INSERT [dbo].[CompanyContactDetails] ([CompanyID], [ContactDetailID]) VALUES (2005, 7015)
INSERT [dbo].[CompanyContactDetails] ([CompanyID], [ContactDetailID]) VALUES (2005, 7016)
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupTitles])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupTitles] ON 
INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (1, N'Mr')
INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (2, N'Mrs')
INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (3, N'Miss')
INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (4, N'Dr')
INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (5, N'Prof')
SET IDENTITY_INSERT [dbo].[LookupTitles] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [Individuals])
BEGIN
SET IDENTITY_INSERT [dbo].[Individuals] ON 
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (8056, 1, N'Brendan', N'Mark', N'Wood')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (8057, 1, N'deagsdfasdfasdfd', N'Mark', N'Wood')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9050, 1, N'Me', N'', N'Threm')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9051, 1, N'Testing', N'', N'wdafsdfsdafasdf')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9052, 1, N'estes', N'lkjk', N'tesdygvkhu')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9053, 1, N'Joe', N'', N'Bradery')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9054, 1, N'Helping me', N'', N'')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9055, 1, N'Brendan', N'Mark', N'Wood')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9056, 1, N'sosoi', N'', N'')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10050, 1, N'agdasfas', N'asdfas', N'sdfasd')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10051, 4, N'bvhgfd', N'rhtdh', N'fgdgfq')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10052, 1, N'Brendan', N'Mark', N'Wood')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10053, 1, N'Test Facilitator', N'', N'dksfljsldk')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10054, 1, N'zdfhcfjgh', N'', N'')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10055, 1, N'Facilitator', N'Facilitator', N'Facilitator')
SET IDENTITY_INSERT [dbo].[Individuals] OFF
END

IF NOT EXISTS (SELECT TOP 1 * FROM [ComapnyContacts])
BEGIN
INSERT [dbo].[ComapnyContacts] ([IndividualID], [CompanyID]) VALUES (8056, 2004)
INSERT [dbo].[ComapnyContacts] ([IndividualID], [CompanyID]) VALUES (9056, 2005)
END

IF NOT EXISTS (SELECT TOP 1 * FROM [LookupEthnicities])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupEthnicities] ON 
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (1, N'Black African')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (2, N'White')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (3, N'Coloured')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (4, N'Indian')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (5, N'Asian')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (6, N'Other/Unspecified')
SET IDENTITY_INSERT [dbo].[LookupEthnicities] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupGenders])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupGenders] ON 
INSERT [dbo].[LookupGenders] ([GenderID], [Gender]) VALUES (1, N'Male')
INSERT [dbo].[LookupGenders] ([GenderID], [Gender]) VALUES (2, N'Female')
SET IDENTITY_INSERT [dbo].[LookupGenders] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupMartialStatuses])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupMartialStatuses] ON 
INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (1, N'Married')
INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (2, N'Widowed')
INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (3, N'Separated')
INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (4, N'Divorced')
INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (5, N'Single')
SET IDENTITY_INSERT [dbo].[LookupMartialStatuses] OFF
END

IF NOT EXISTS (SELECT TOP 1 * FROM [LookupQualificationLevels])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupQualificationLevels] ON 
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (1, N'NQF 1 (Grade 9/National Certificate)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (2, N'NQF 2 (National Certificate)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (3, N'NQF 3 (National Certificate)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (4, N'NQF 4 (Grade 12/Matric)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (5, N'NQF 5 (National Diplomas)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (6, N'NQF 6 (National Diplomas)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (7, N'NQF 7 (Bachelors Degree, B Techs, Advanced Diploma)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (8, N'NQF 8 (Honours Degree/Post-graduate Diploma)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (9, N'NQF 9 (Masters Degree)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (10, N'NQF 10 (Doctrate)')
SET IDENTITY_INSERT [dbo].[LookupQualificationLevels] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [Students])
BEGIN
INSERT [dbo].[Students] 
([IndividualID], [QualificationLevelID], [MartialStatusID], [GenderID], [EthnicityID], [StudentIDNumber], [StudentCurrentPosition], [StudentlInitialDate]) 
VALUES 
(8057, 8, 5, 1, 2, N'800695014089', N'', CAST(N'2017-03-08T00:00:00.000' AS DateTime))
END


IF NOT EXISTS (SELECT TOP 1 * FROM [StudentAssociatedCompany])
BEGIN
SET IDENTITY_INSERT [dbo].[StudentAssociatedCompany] ON 
INSERT [dbo].[StudentAssociatedCompany] ([StudentAssosiatedCompanyID], [IndividualID], [CompanyID], [IsCurrentCompany]) VALUES (1, 8057, 2004, 1)
INSERT [dbo].[StudentAssociatedCompany] ([StudentAssosiatedCompanyID], [IndividualID], [CompanyID], [IsCurrentCompany]) VALUES (2, 8057, 2005, 0)
SET IDENTITY_INSERT [dbo].[StudentAssociatedCompany] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [Employees])
BEGIN
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (8057, N'hgkghjkhk')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9050, N'7541256-01')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9051, N'1259652')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9052, N'8787')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9053, N'H12434')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9054, N'87465146')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9055, N'ISS012356')
END


IF NOT EXISTS (SELECT TOP 1 * FROM [IndividualAddresses])
BEGIN
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8015, 9053)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8017, 8057)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8018, 9050)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8019, 9051)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8020, 9051)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8021, 9052)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8022, 9054)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8023, 9055)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8024, 9054)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9003, 10050)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9004, 10050)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9005, 10050)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9006, 10051)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9007, 10052)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9008, 10055)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9009, 10053)
END



IF NOT EXISTS (SELECT TOP 1 * FROM [LookupTypeOfRelations])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupTypeOfRelations] ON 
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (1, N'Father')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (2, N'Mother')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (3, N'Brother')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (4, N'Sister')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (5, N'Uncle')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (6, N'Aunt')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (7, N'Friend')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (8, N'Husband')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (9, N'Wife')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (10, N'Girl Friend')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (11, N'Boy Friend')
SET IDENTITY_INSERT [dbo].[LookupTypeOfRelations] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [Facilitators])
BEGIN
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10050)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10051)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10052)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10053)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10054)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10055)
END



IF NOT EXISTS (SELECT TOP 1 * FROM [IndividualContactDetails])
BEGIN
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (8056, 7012)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (8056, 7013)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (8057, 8013)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (8057, 9003)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (9050, 8007)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (9050, 8008)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (9051, 8009)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (9051, 8011)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (9055, 8010)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (9056, 8012)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (10052, 9002)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (10055, 9004)
END


IF NOT EXISTS (SELECT TOP 1 * FROM [Courses])
BEGIN
SET IDENTITY_INSERT [dbo].[Courses] ON 
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1, 1004, N'NQF Level 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (2, 1004, N'NQF Level 3', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3, 1004, N'NQF Level 4', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (4, 2004, N'Orientation', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (5, 1005, N'Forklift', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (6, 2004, N'Measuring', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (7, 2004, N'Workshop Practice 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (8, 2005, N'short course 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (9, 1005, N'Mobile Crane C33', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (10, 1005, N'Mobile Crane C34', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1002, 2009, N'Recognition of Prior Learning (RPL)', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1003, 2004, N'Basic Lifting Techniques', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1004, 2004, N'Workshop Practice 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1005, 2004, N'Fitting', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1006, 2004, N'Bearings and Seals', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1007, 2004, N'Alignment', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1008, 2004, N'Pumps', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1009, 2004, N'Hydraulics and Pneumatics', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1010, 2004, N'Turning 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1011, 2004, N'Turning 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1012, 2004, N'Milling', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1013, 2004, N'Welding for Other Trades', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1014, 2004, N'Electrical 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1015, 2004, N'Electrical 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1018, 2004, N'AC & DC Machines', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1019, 2004, N'Wiring and Installations', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1020, 2004, N'Fault Finding', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1021, 2004, N'Electronics', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1022, 2004, N'PLC', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1023, 2009, N'Trade Test Readiness assessment (TTR)', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1024, 2009, N'Trade Test Gap training ( when not course aligned)', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1025, 2009, N'Trade Test Preparation - Fitter', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1026, 2009, N'Trade Test Preparation - Fitter and Turner', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1027, 2009, N'Trade Test Preparation -Turner', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1028, 2009, N'Trade Test Preparation - Electrician', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1029, 2009, N'Trade Test Preparation - Boilermaker', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1030, 2009, N'Trade Test Preparation - Welder', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1031, 2009, N'Trade Test Preparation - Rigging', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1032, 2009, N'Trade Test Preparation - Instumentation', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (2014, 2009, N'Trade Orientation - Fitter', N'')
SET IDENTITY_INSERT [dbo].[Courses] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [FacilitatorAssociatedCourses])
BEGIN
SET IDENTITY_INSERT [dbo].[FacilitatorAssociatedCourses] ON 
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (83, 10051, 1)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (85, 10051, 3)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (88, 10050, 1)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (89, 10050, 2)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (90, 10050, 3)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1002, 10052, 7)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1003, 10052, 1005)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1004, 10052, 1008)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1005, 10052, 1010)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1006, 10052, 1011)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1007, 10052, 1004)
SET IDENTITY_INSERT [dbo].[FacilitatorAssociatedCourses] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupEnrollmentTypes])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupEnrollmentTypes] ON 
INSERT [dbo].[LookupEnrollmentTypes] ([EnrollmentTypeID], [EnrollmentType]) VALUES (1, N'Novice')
INSERT [dbo].[LookupEnrollmentTypes] ([EnrollmentTypeID], [EnrollmentType]) VALUES (2, N'Re-Certification')
SET IDENTITY_INSERT [dbo].[LookupEnrollmentTypes] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [CurriculumCourses])
BEGIN
SET IDENTITY_INSERT [dbo].[CurriculumCourses] ON 
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (20, 0, 21, 9, 1, 1, CAST(15425.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1022, 0, 6, 4, 2, 1, CAST(2314134.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1023, 0, 3, 4, 1, 1, CAST(23434.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1024, 0, 9, 4, 1, 1, CAST(876578.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1025, 0, 9, 4, 2, 1, CAST(24324234.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1027, 0, 4, 4, 2, 1, CAST(95465.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1028, 0, 1018, 1002, 1, 2, CAST(1234.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1029, 0, 5, 4, 1, 4, CAST(3254.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1030, 0, 2, 4, 1, 2, CAST(770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1031, 1030, 2, 6, 1, 9, CAST(3640.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1032, 1031, 2, 7, 1, 11, CAST(4450.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1033, 1032, 2, 1003, 1, 3, CAST(1210.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1034, 1033, 2, 1004, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1035, 1034, 2, 1005, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1036, 1035, 2, 1006, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1037, 0, 2, 1007, 1, 15, CAST(6060.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1038, 0, 2, 1008, 1, 5, CAST(2020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1039, 0, 2, 1009, 1, 5, CAST(2020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1040, 0, 2, 1010, 1, 15, CAST(7510.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1041, 0, 2, 1011, 1, 15, CAST(7510.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1042, 0, 2, 1012, 1, 15, CAST(7510.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1043, 0, 2, 1013, 1, 10, CAST(5010.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1044, 0, 7, 4, 1, 2, CAST(734.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1045, 1044, 7, 6, 1, 9, CAST(3464.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1046, 1045, 7, 7, 1, 11, CAST(4235.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1047, 1046, 7, 1003, 1, 3, CAST(1152.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1048, 1052, 7, 1009, 1, 5, CAST(1925.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1049, 1047, 7, 1004, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1050, 1056, 7, 1014, 1, 15, CAST(5775.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1051, 1050, 7, 1015, 1, 10, CAST(5775.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1052, 1053, 7, 1008, 1, 5, CAST(1925.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1053, 1054, 7, 1007, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1054, 1055, 7, 1006, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1055, 1062, 7, 1005, 1, 15, CAST(5775.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1056, 1049, 7, 1013, 1, 10, CAST(4770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1057, 1051, 7, 1018, 1, 20, CAST(7700.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1058, 1057, 7, 1019, 1, 20, CAST(8040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1059, 1058, 7, 1020, 1, 5, CAST(1925.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1060, 1059, 7, 1021, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1062, 1060, 7, 1022, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1063, 0, 8, 4, 1, 2, CAST(770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1064, 0, 8, 6, 1, 9, CAST(3640.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1065, 0, 1018, 1023, 1, 2, CAST(440.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1066, 0, 1018, 1024, 1, 1, CAST(440.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1067, 0, 1018, 1025, 1, 20, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1068, 0, 1018, 1026, 1, 20, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1069, 0, 1018, 1027, 1, 20, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1070, 0, 1018, 1028, 1, 20, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1071, 0, 1018, 1029, 1, 20, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1072, 0, 1018, 1030, 1, 20, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1073, 0, 1018, 1031, 1, 20, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1074, 0, 1018, 1032, 1, 20, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1075, 0, 11, 1, 1, 365, CAST(36500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1076, 1075, 11, 2, 1, 365, CAST(45600.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[CurriculumCourses] OFF
END



IF NOT EXISTS (SELECT TOP 1 * FROM [Modules])
BEGIN
SET IDENTITY_INSERT [dbo].[Modules] ON 
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (1, 2004, N'Induction')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (2, 2004, N'Safety')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (3, 2004, N'Materials')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (4, 2004, N'Drawings and Sketches')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (5, 2004, N'Measuring Equipment')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (6, 2004, N'Hand tools')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (7, 2004, N'Workshop Tools')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (8, 2004, N'Marking Off')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (10, 2004, N'Basic Lifting Techniques')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (11, 2004, N'Hand Skills')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (12, 2004, N'Keys and Locking Devices')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (14, 2004, N'Lubrication')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (15, 2004, N'Bearings')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (16, 2004, N'Assemblies')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (17, 2004, N'Installation of Machinery')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (18, 2004, N'Couplings')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (19, 2004, N'Drives')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (20, 2004, N'Brakes and Clutches')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (21, 2004, N'Pumps')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (22, 2004, N'Hydraulics')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (23, 2004, N'Pneumatics')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (24, 2004, N'Centre Lathe Work')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (25, 2004, N'Milling Machine Work')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (26, 2004, N'Gas Cutting and Heating')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (27, 2004, N'Gas Welding and Brazing')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (28, 2004, N'Arc welding')
SET IDENTITY_INSERT [dbo].[Modules] OFF
END

IF NOT EXISTS (SELECT TOP 1 * FROM [CurriculumCourseModules])
BEGIN
SET IDENTITY_INSERT [dbo].[CurriculumCourseModules] ON 
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1069, 1030, 1)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1070, 1030, 2)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1071, 1031, 3)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1072, 1031, 4)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1073, 1031, 5)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1074, 1032, 6)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1075, 1032, 7)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1076, 1032, 8)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1077, 1032, 5)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1078, 1033, 10)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1080, 1034, 11)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1081, 1035, 12)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1082, 1035, 8)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1083, 1035, 5)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1084, 1036, 15)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1085, 1036, 14)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1086, 1036, 16)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1087, 1036, 12)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1088, 1036, 4)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1089, 1036, 7)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1091, 1044, 1)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1092, 1044, 2)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (2091, 1024, 28)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (2092, 1024, 16)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (2093, 1024, 10)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (2094, 1024, 15)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (2095, 1024, 20)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (2096, 1024, 24)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (2097, 1024, 18)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (2098, 1024, 4)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3091, 1029, 28)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3092, 1029, 16)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3093, 1029, 10)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3094, 1029, 15)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3095, 1029, 20)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3096, 1029, 24)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3097, 1029, 18)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3098, 1029, 4)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3099, 1029, 19)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3100, 1029, 26)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3101, 1029, 27)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3102, 1029, 11)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3103, 1029, 6)
SET IDENTITY_INSERT [dbo].[CurriculumCourseModules] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [Activities])
BEGIN
SET IDENTITY_INSERT [dbo].[Activities] ON 
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1, 1, N'ID1', N'Recall applicable sections of the Manpower Training (Act No 56, 1981), with special reference to discipline and legal  responsibilities. ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (2, 1, N'ID2', N'Recall terms and conditions of apprenticeship as Gazetted 26 July 1991.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (3, 2, N'SF1', N'Recall relevant regulations of the following Acts: Occupational Health and Safety Act (Act No 85, 1993) and Minerals Act and Regulations (Act No 50, 1991) ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (4, 2, N'SF2', N'Attend a standard industrial safety course accredited by the industry. ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (5, 2, N'SF5', N'Identify relevant colour markings and symbolic safety signs.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (6, 2, N'SF6', N'Identify relevant colour codes for compressed gas cylinders.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (8, 3, N'MA1', N'Recall the terms, definitions and use of materials   pertaining to the trade with special reference to plates, tubes,   pipes and hollow sections')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (9, 3, N'MA2', N'Recall the physical properties and characteristics of metal. ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (10, 3, N'MA3', N'Identify ferrous and non-ferrous metals.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (11, 3, N'MA7', N'Recall differences between ferrous, non-ferrous metals and non-metallic materials.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (12, 3, N'MA8', N'Identify steel profiles with respect to plates, chequer plate, angles, channels, RSJ; UB; UC; rounds, squares, hollow  sections, fasteners and flat bar.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (13, 5, N'MF2', N'Use and set a vernier - depth, inside and outside.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (14, 5, N'MF3', N'Use a tape measure and steel rule.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (15, 5, N'MF5', N'Use a machine level.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (16, 5, N'MF6', N'Use and set a vernier height gauge.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (17, 4, N'DS1', N'Recall terms and definitions pertaining to engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (18, 4, N'DS2', N'Interpret relevant symbols, abbreviations and tolerances.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (19, 4, N'DS7', N'Make free hand sketches including plan, front and side elevations.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (20, 4, N'DS8', N'Compile a material list from engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (21, 4, N'DS10', N'Identify surface textures.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (22, 6, N'HT1', N'Identify measuring, checking, forming, cutting, marking and fastening tools and tooling aids.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (23, 6, N'HT2', N'Use measuring, checking, forming, cutting, marking and fastening tools and tooling aids.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (24, 6, N'HT3', N'Maintain measuring, checking, forming, cutting, marking and fastening tools and tooling  aids.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (25, 6, N'HT4', N'Use hand tools applicable to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (26, 7, N'WT1', N'Use fixed and portable drilling machines.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (27, 7, N'WT2', N'Use a fixed and portable grinding machines including replacing, setting, truing and ringing  of wheels.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (28, 7, N'WT3', N'Use a portable jig-saw.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (29, 7, N'WT17', N'Operate pneumatic and or electrical power tools.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (30, 7, N'WT21', N'Mount grinding stone to pedestal grinder. Maximum size:  250mm diameter wheel. RPM = 2 000')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (31, 7, N'WT22', N'Dress a grinding wheel.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (32, 8, N'MT9', N'Mark off a project applicable to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (33, 8, N'MO1', N'Mark off projects for manufacturing using all standard marking-off techniques and tools.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (34, 5, N'MF1', N'Use and set a micrometer - outside, depth, inside.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (35, 5, N'MF4', N'Use a calliper - inside and outside.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (38, 3, N'MA6', N'Handle materials and work pieces using chain blocks and overhead cranes by means of the correct lifting, stacking  and slinging methods and using tirfors for positioning work pieces.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (39, 10, N'BG2', N'Recall overhead crane hand signals.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (40, 10, N'BG3', N'Demonstrate overhead crane hand signals.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (41, 10, N'BG4', N'Use the following equipment: 
? chain block  :  2 ton max 
? coffin block  :  2 ton max 
? shackles  :  2 ton max 
? chain slings  :  2 ton max 
? wire rope slings  :  20mm diameter ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (42, 11, N'HS1', N'Fabricate a project applicable to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (43, 11, N'HS2', N'Sharpen chisels.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (44, 11, N'HS3', N'Sharpen drills')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (45, 11, N'HS4', N'Dress screwdrivers.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (46, 11, N'HS5', N'Sharpen punches.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (47, 11, N'HS6', N' Sharpen spikes.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (48, 11, N'HS7', N'Sharpen marking-off tools.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (49, 11, N'HS8', N'Manufacture a project using the following techniques and material: filing, sawing, drilling, tapping, reaming. Material:  mild steel')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (50, 11, N'HS9', N'Harden and temper a centre punch.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (51, 12, N'KL1', N'Identify the following types of keys - gib-head, parallel, taper, feather, woodruff, and tangenial.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (52, 12, N'KL2', N'Manufacture a gib-head, parallel, taper and feather key.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (53, 12, N'KL3', N'Fit a gib-head, parallel, taper, feather key.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (54, 12, N'KL5', N'Remove a gib-head, parallel, taper and feather key.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (55, 12, N'KL6', N'Identify nuts and bolts')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (56, 12, N'KL7', N'Tighten nuts and bolts.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (57, 8, N'MT6', N'Mark off a seven-holed flange/coupling.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (58, 8, N'MT7', N'Mark off a five-holed flange/coupling.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (59, 8, N'MT8', N'Mark off a flange consisting of a centre hole.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (60, 5, N'MF7(14)', N'Use the following gauges: 
? telescopic 
? thread 
? feeler 
? double dial set indicator 
? belt tensioner   ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (61, 15, N'BE1', N'Identify plain metal bearing materials such as bronze, white metal, synthetic.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (62, 15, N'BE2', N'Identify solid, split and guide bearings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (63, 15, N'BE5', N'Make oil grooves and wedges.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (64, 15, N'BE6', N'Identify classes of bearings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (65, 15, N'BE7', N'Identify the following ball bearings - deep groove, angular contact, self-alignment and thrust.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (66, 15, N'BE8', N'Identify the following types of roller bearings - spherical, thrust, taper, and cylindrical.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (67, 15, N'BE9', N'Fit a bearing to a shaft using a hand operated press, sleeve, oil bath and or induction heater.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (68, 15, N'BE10', N'Remove a bearing from a shaft using a bearing puller or hand operated press.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (69, 15, N'BE11', N'Fit a spherical roller bearing and adaptor sleeve to a shaft.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (70, 15, N'BE12', N'Remove a spherical roller bearing from an adaptor sleeve and shaft.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (71, 15, N'BE13', N'Fit and remove a thrust bearing on a shaft (single direction).')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (72, 15, N'BE14', N'Fit a roller bearing on a shaft.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (73, 15, N'BE15', N'Recall types of bearing failures and their causes.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (74, 14, N'LU1', N'Identify the following types of lubrication systems; force-feed, splash-feed and gravity feed.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (75, 14, N'LU2', N'Identify the following types of lubricants; oil, grease, copper compound, thread cutting compounds.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (76, 14, N'LU3', N'Diagnose faults in a force feed system.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (77, 14, N'LU4', N'Pack bearings with grease.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (78, 16, N'AS3', N'Identify the following types of fits on shafts and hole basis - clearance, transition, interference.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (80, 16, N'AS4', N'Fit a boss to a shaft with reference to clearance fit.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (81, 16, N'AS5', N'Fit a boss to a shaft with reference to transition fit.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (82, 16, N'AS6', N'Fit a boss to a shaft with reference to interference fit.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (83, 12, N'KL4', N'Install the following locking devices - lock-nuts, dowels, lock-plates, split pins, taper pins and wire method.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (84, 4, N'DS9', N'Identify type of fits from engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (85, 7, N'WT20', N'Use hand operated presses.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (86, 16, N'AS1', N'Dismantle a worm-wheel type reduction gearbox.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (87, 16, N'AS2', N'Assemble a worm-wheel type gearbox.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (88, 16, N'AS8', N'Fit seal and packing to mechanical components. e.g.: pumps, gearboxes, etc.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (89, 17, N'IM3', N'Install and level gearboxes, motors, machines and pumps.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (90, 18, N'CP1', N'Identify the following types of couplings - flexible, rigid, slip couplings and universal couplings (carden shaft).')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (91, 18, N'CP2', N'Mount and align the following couplings: 
1. Flexible tyre coupling 
2. Rigid flange coupling 
3. Bibby tyre coupling 
4. Internal gear coupling.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (92, 18, N'CP7', N'Diagnose faults on the following couplings: fenner flex, rigid, bibby, and internal gear couplings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (93, 19, N'DR1', N'Identify the following types of drives - belt, gear, fluid and chain.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (94, 19, N'DR2', N'Identify A, B and C class V-belts.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (95, 19, N'DR3', N'Install and align a single belt-drive.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (96, 19, N'DR4', N'Install and align match-set belt drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (97, 19, N'DR5', N'Install and align chain drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (98, 19, N'DR7', N'Maintain belt drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (99, 19, N'DR8', N'Maintain gear drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (100, 19, N'DR9', N'Maintain chain drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (101, 19, N'DR10', N'Maintain a fluid drive.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (102, 19, N'DR11', N'Install jockey on V-belt and chain drive units.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (103, 20, N'BC1', N'Identify the following brake systems: 
? disc 
? thruster 
? electro-magnetic.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (104, 20, N'BC2', N'Maintain disc brakes.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (105, 20, N'BC3', N'Maintain thruster brakes - calliper type.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (106, 20, N'BC4', N'Maintain electro-magnetic brakes.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (107, 20, N'BC5', N'Identify centrifugal and multi-disc clutch systems.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (108, 20, N'BC7', N'Maintain a multi-disc clutch.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (109, 21, N'PU1', N'Identify the following types of pumps: 
? centrifugal 
? reciprocating 
? gear ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (110, 21, N'PU2', N'Define the terms positive and non positive displacement.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (111, 21, N'PU3', N'Install gland bush packing.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (112, 21, N'PU4', N'Install a mechanical seal.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (113, 21, N'PU5', N' Prime centrifugal, reciprocating and gear pumps.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (114, 21, N'PU6', N'Diagnose faults on centrifugal, reciprocating and gear pumps.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (115, 21, N'PU7', N'Interpret given flow diagrams and systems.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (116, 22, N'HY1', N'Interpret symbols and abbreviations.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (117, 22, N'HY2', N'Interpret elementary hydraulic circuit diagrams.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (118, 22, N'HY3', N'Identify the following hydraulic fluids: 
? petroleum based 
? emulsion based')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (119, 22, N'HY4', N'Install and maintain the following filters: 
? suction 
? pressure 
? return')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (120, 22, N'HY5', N'Install and maintain hydraulic tubing and fittings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (121, 22, N'HY6', N'Install and maintain flexible hydraulic hoses and fittings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (122, 22, N'HY7', N'Identify the following hydraulic pumps - vane, gear, and piston.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (123, 22, N'HY8', N'Install and maintain hydraulic pumps.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (124, 22, N'HY9', N'Service procedures of reservoir.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (125, 22, N'HY10', N'Install and maintain directional control, pressure and flow control valves.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (126, 22, N'HY11', N'Install and maintain hydraulic cylinders.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (127, 22, N'HY12', N'Identify and install accumulators.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (128, 22, N'HY13', N'Diagnose faults in basic hydraulic systems.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (129, 4, N'DS18', N'Compile material lists from hydraulic and pneumatic drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (130, 23, N'PN1', N'Interpret symbols and abbreviations.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (131, 23, N'PN2', N'Interpret pneumatic circuit diagrams.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (132, 23, N'PN3', N'Identify compressed air pipelines.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (133, 23, N'PN4', N'Install and maintain compressed air pipelines.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (134, 23, N'PN5', N'Install and maintain air service units.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (135, 23, N'PN6', N'Install and maintain cylinders.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (136, 23, N'PN7', N'Install and maintain directional control, flow control and pressure valves.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (137, 23, N'PN9', N'Testing of set safety valves.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (138, 23, N'PN10', N'Recall the service procedure for air receivers.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (139, 23, N'PN12', N'Diagnose faults in pneumatic systems.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (140, 11, N'HS10', N'Sharpen single point machine cutting tools.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (141, 24, N'CL1', N'Carry out routine inspection on centre lathe.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (142, 24, N'CL2', N'Compile a machining procedure.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (143, 24, N'CL3', N'Recall the parts of a centre lathe.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (144, 24, N'CL4', N'Set calibrated dials.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (145, 24, N'CL5', N'Set up a workpiece in a four-jaw chuck.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (146, 24, N'CL6', N'Identify types of cutting tools with reference to: 
(i) High speed toolbits 
(ii) Throw away bits (inserts tungsten carbide) ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (147, 24, N'CL7', N'Turn an external parallel workpiece.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (148, 24, N'CL8', N'Turn an internal parallel work piece.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (149, 24, N'CL9', N'Turn the following internal and external threads: 
(i)    "V" and acme / trapezoidal 
(ii)   Left hand and right hand 
(iii)  Single and two-start ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (150, 24, N'CL10', N'Turn an external and internal taper using a compound slide.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (151, 24, N'Cl11', N'Turn an external and internal radius.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (152, 24, N'CL12', N'Turn a work piece between centres.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (153, 24, N'CL13', N'Turn workpieces using fixed and travelling steadies.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (154, 5, N'MF8', N'Use a gear tooth vernier.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (155, 25, N'MM1', N'Carry out routine inspection on milling machine.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (156, 25, N'MM2', N'Compile a machining procedure.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (157, 25, N'MM3', N'Recall the parts of a universal milling machine.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (158, 25, N'MM4', N'Set calibrated dials.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (159, 25, N'MM5', N'Set up workpiece in a dividing head using a three-jaw chuck, and between centres.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (160, 25, N'MM6', N'Set up a work piece on a turntable.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (161, 25, N'MM7', N'Set up a workpiece in a machine vice.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (162, 25, N'MM8', N'Use a dividing head for simple and differential indexing.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (163, 25, N'MM10', N'Mount a universal head.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (164, 25, N'MM11', N'Identify high speed and tungsten cutting tools with reference to:
? Slot drills, Side and face cutters, End-mills, Slit-saws 
? Gear cutters, Ripping cutters, Face mills, Fly cutters ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (165, 25, N'MM12', N'Machine a spur gear.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (166, 25, N'MM13', N'Cut an external keyway.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (167, 25, N'MM14', N' Machine a hexan.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (168, 25, N'MM15', N'Machine a cube using a machine vice.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (169, 25, N'MM16', N'Drill equal spaced holes on PCD''s.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (170, 25, N'MM17', N'Bore a hole.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (171, 25, N'MM18', N'Split a bush using a slit-saw.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (172, 25, N'MM19', N'Cut an internal keyway.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (173, 26, N'GC1', N'Identify and assemble gas cutting and heating equipment, including light up and shut-down procedures.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (174, 26, N'GC2', N'Select nozzles and gas pressures for cutting and heating different materials of various thicknesses.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (175, 26, N'GC3', N'Hand cut and heat materials incidental to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (176, 2, N'SF3', N'Recall safety in welding and gas cutting.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (177, 27, N'GW10', N'Identify and set up oxygen-fuel gas welding equipment including light up, adjustment of gas pressures and shut  down procedures.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (178, 27, N'GW11', N'Differentiate between brazing and gas welding consumables.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (179, 27, N'GW12', N'Prepare material for brazing and gas welding.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (180, 27, N'GW13', N'Braze and gas weld workpieces incidental to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (181, 28, N'AO1', N'Identify and set up AC and/or DC welding machines, equipment including starting up and shutting down  Procedures.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (182, 28, N'AO2', N'Differentiate between arc welding consumables.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (183, 28, N'AO3', N'Prepare material for arc welding.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (184, 28, N'AO4', N'Tack and arc weld workpieces incidental to the trade using manual metal arc welding techniques.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1036, 3, N'MA13', N'Recall characteristics of ferrous metals – mild steel and cast iron. ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1037, 3, N'MA14', N'Recall characteristics of non-ferrous metals – copper, brass, aluminium, white metal and stainless steel.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1038, 4, N'DSE2', N'Recall symbols and abbreviations as used o engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1039, 4, N'DSE5', N'Interpret engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1040, 8, N'MO2', N'Mark off a bus-bar.')
SET IDENTITY_INSERT [dbo].[Activities] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [CurriculumCourseModuleActivities])
BEGIN
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1069, 1)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1069, 2)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1070, 3)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1070, 4)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1070, 5)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1070, 6)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 17)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 18)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 19)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 20)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 21)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1074, 22)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1074, 23)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1074, 24)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1074, 25)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 26)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 27)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 28)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 29)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 30)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1076, 32)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1076, 33)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1077, 34)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1077, 35)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1078, 38)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1078, 39)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1078, 40)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1078, 41)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 42)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 43)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 44)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 45)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 46)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 47)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 48)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 49)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 50)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 51)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 52)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 53)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 54)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 55)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 56)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 83)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1082, 57)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1082, 58)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1082, 59)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1083, 60)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 61)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 62)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 63)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 64)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 65)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 66)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 67)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 68)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 69)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 70)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 71)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 72)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 73)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1086, 78)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1086, 80)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1086, 81)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1086, 82)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1091, 1)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1091, 2)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1092, 3)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1092, 4)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1092, 5)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1092, 6)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (3091, 181)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (3091, 182)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (3091, 183)
END

IF NOT EXISTS (SELECT TOP 1 * FROM [LookupSectionalEnrollmentTypes])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupSectionalEnrollmentTypes] ON 
INSERT [dbo].[LookupSectionalEnrollmentTypes] ([LookupSectionalEnrollmentTypeID], [LookupSectionalEnrollmentType]) VALUES (1, N'Section 13')
INSERT [dbo].[LookupSectionalEnrollmentTypes] ([LookupSectionalEnrollmentTypeID], [LookupSectionalEnrollmentType]) VALUES (2, N'Section 28')
SET IDENTITY_INSERT [dbo].[LookupSectionalEnrollmentTypes] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupEnrollmentProgressStates])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupEnrollmentProgressStates] ON 
INSERT [dbo].[LookupEnrollmentProgressStates] ([LookupEnrollmentProgressStateID], [EnrollmentProgressCurrentState]) VALUES (1, N'In Progress')
INSERT [dbo].[LookupEnrollmentProgressStates] ([LookupEnrollmentProgressStateID], [EnrollmentProgressCurrentState]) VALUES (2, N'Complete')
SET IDENTITY_INSERT [dbo].[LookupEnrollmentProgressStates] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupDisabilities])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupDisabilities] ON 
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (1, N'Mobility Impairments')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (2, N'Physical Impairments')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (3, N'Vision')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (4, N'Hearing')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (5, N'Cognitive or Learning')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (7, N'Other')
SET IDENTITY_INSERT [dbo].[LookupDisabilities] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [StudentDisabilities])
BEGIN
SET IDENTITY_INSERT [dbo].[StudentDisabilities] ON 
INSERT [dbo].[StudentDisabilities] ([StudentDisabilityID], [IndividualID], [DisabilityID], [StudentDisabilityNotes]) VALUES (2002, 8057, 1, N'none')
INSERT [dbo].[StudentDisabilities] ([StudentDisabilityID], [IndividualID], [DisabilityID], [StudentDisabilityNotes]) VALUES (2003, 8057, 3, N'testing eyes')
INSERT [dbo].[StudentDisabilities] ([StudentDisabilityID], [IndividualID], [DisabilityID], [StudentDisabilityNotes]) VALUES (2004, 8057, 7, N'test')
SET IDENTITY_INSERT [dbo].[StudentDisabilities] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupSetas])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupSetas] ON 
INSERT [dbo].[LookupSetas] ([SetaID], [SetsName], [SetaAbbriviation]) VALUES (2, N'Construction Education and Training Authority', N'CETA')
INSERT [dbo].[LookupSetas] ([SetaID], [SetsName], [SetaAbbriviation]) VALUES (3, N'Transport Education Training Authority', N'TETA')
INSERT [dbo].[LookupSetas] ([SetaID], [SetsName], [SetaAbbriviation]) VALUES (4, N'Mining Qualifications Authority', N'MQA')
SET IDENTITY_INSERT [dbo].[LookupSetas] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [CurriculumCourseAssociatedSetas])
BEGIN
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (2, 1029)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (2, 1032)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (2, 1075)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (3, 1032)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (3, 1075)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (4, 1075)
END


IF NOT EXISTS (SELECT TOP 1 * FROM [Venues])
BEGIN
SET IDENTITY_INSERT [dbo].[Venues] ON 
INSERT [dbo].[Venues] ([VenueID], [Venue], [VenueMaxCapacity]) VALUES (1, N'Venue 1', 12)
SET IDENTITY_INSERT [dbo].[Venues] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [CurricullumCourseCodes])
BEGIN
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (20, N'116254')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1022, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1023, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1024, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1025, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1027, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1028, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1029, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1030, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1031, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1032, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1033, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1034, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1035, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1036, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1037, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1038, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1039, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1040, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1041, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1042, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1043, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1044, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1045, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1046, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1047, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1048, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1049, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1050, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1051, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1052, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1053, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1054, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1055, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1056, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1057, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1058, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1059, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1060, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1062, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1063, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1064, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1065, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1066, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1067, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1068, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1069, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1070, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1071, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1072, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1073, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1074, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1075, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1076, N'')
END


IF NOT EXISTS (SELECT TOP 1 * FROM [CurriculumCourseMinimumMaximums])
BEGIN
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (20, 2, 3)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1022, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1023, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1024, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1025, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1027, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1028, 1, 2)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1029, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1030, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1031, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1032, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1033, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1034, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1035, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1036, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1037, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1038, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1039, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1040, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1041, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1042, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1043, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1044, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1045, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1046, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1047, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1048, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1049, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1050, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1051, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1052, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1053, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1054, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1055, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1056, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1057, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1058, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1059, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1060, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1062, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1063, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1064, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1065, 1, 2)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1066, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1067, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1068, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1069, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1070, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1071, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1072, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1073, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1074, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1075, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1076, 0, 0)
END


IF NOT EXISTS (SELECT TOP 1 * FROM [LookupEnquiryTypes])
BEGIN
SET IDENTITY_INSERT [dbo].[LookupEnquiryTypes] ON 
INSERT [dbo].[LookupEnquiryTypes] ([EnquiryTypeID], [EnquiryType]) VALUES (1, N'Engineering')
INSERT [dbo].[LookupEnquiryTypes] ([EnquiryTypeID], [EnquiryType]) VALUES (2, N'LOPT')
SET IDENTITY_INSERT [dbo].[LookupEnquiryTypes] OFF
END


IF NOT EXISTS (SELECT TOP 1 * FROM [SMTPSettings])
BEGIN
SET IDENTITY_INSERT [dbo].[SMTPSettings] ON 
INSERT [dbo].[SMTPSettings] ([SmtpSettingID], [PortNumber], [SMTPHost], [RequireAuthentication], [RequiresSSL], [FromAddress], [UserName], [Password], [DisplayName]) VALUES (1, 25, N'smtp.mweb.co.za', 0, 0, N'brendanw@mweb.co.za', N'Brendanw@mweb.co.za', N'speedie3', N'MCD Communication')
SET IDENTITY_INSERT [dbo].[SMTPSettings] OFF
END