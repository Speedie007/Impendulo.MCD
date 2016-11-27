

CREATE PROCEDURE GetLookupTablesForEnumAutoGenteration
--DROP PROCEDURE GetLookupTablesForEnumAutoGenteration
	
AS
	SELECT DISTINCT t.NAME 
		FROM SYS.tables as t
		INNER JOIN SYS.columns AS c ON t.object_id = c.object_id
		and t.name like '%Lookup%';