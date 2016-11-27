CREATE VIEW dbo.Report_StudentReport
AS
SELECT        dbo.Individuals.IndividualID, dbo.Individuals.IndividualFirstName, dbo.Individuals.IndividualSecondName, dbo.Individuals.IndividualLastname, dbo.LookupTitles.Title, dbo.Students.StudentCurrentPosition, 
                         dbo.Students.StudentIDNumber, dbo.LookupDisabilities.Disability, dbo.LookupEthnicities.Ethnicity, dbo.LookupMartialStatuses.MaritialStatus, dbo.LookupQualificationLevels.QualificationLevel, 
                         dbo.LookupGenders.Gender, dbo.Addresses.AddressLineOne, dbo.Addresses.AddressLineTwo, dbo.Addresses.AddressTown, dbo.Addresses.AddressSuburb, dbo.Addresses.AddressAreaCode, 
                         dbo.Addresses.AddressIsDefault, dbo.Addresses.AddressModifiedDate, dbo.LookupCountries.CountryName, dbo.LookupProvinces.Province, dbo.LookupAddressTypes.AddressType, 
                         dbo.ContactDetails.ContactDetailValue, dbo.LookupContactTypes.ContactType
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
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'Report_StudentReport';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'ght = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupEthnicities"
            Begin Extent = 
               Top = 102
               Left = 476
               Bottom = 198
               Right = 646
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupMartialStatuses"
            Begin Extent = 
               Top = 102
               Left = 684
               Bottom = 198
               Right = 854
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupGenders"
            Begin Extent = 
               Top = 120
               Left = 246
               Bottom = 216
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Addresses"
            Begin Extent = 
               Top = 138
               Left = 892
               Bottom = 268
               Right = 1095
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "IndividualAddresses"
            Begin Extent = 
               Top = 138
               Left = 1133
               Bottom = 234
               Right = 1303
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupCountries"
            Begin Extent = 
               Top = 198
               Left = 38
               Bottom = 311
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupAddressTypes"
            Begin Extent = 
               Top = 198
               Left = 454
               Bottom = 294
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupProvinces"
            Begin Extent = 
               Top = 198
               Left = 662
               Bottom = 294
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupDisabilities"
            Begin Extent = 
               Top = 216
               Left = 246
               Bottom = 312
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "StudentDisabilities"
            Begin Extent = 
               Top = 234
               Left = 1133
               Bottom = 364
               Right = 1342
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'Report_StudentReport';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IndividualContactDetails"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ContactDetails"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 119
               Right = 438
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupContactTypes"
            Begin Extent = 
               Top = 6
               Left = 476
               Bottom = 102
               Right = 646
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupQualificationLevels"
            Begin Extent = 
               Top = 6
               Left = 684
               Bottom = 102
               Right = 879
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Individuals"
            Begin Extent = 
               Top = 6
               Left = 917
               Bottom = 136
               Right = 1129
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Students"
            Begin Extent = 
               Top = 6
               Left = 1167
               Bottom = 136
               Right = 1380
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LookupTitles"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 198
               Ri', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'Report_StudentReport';

