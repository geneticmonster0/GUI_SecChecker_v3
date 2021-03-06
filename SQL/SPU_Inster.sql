USE [testDB_2]
GO
/****** Object:  StoredProcedure [dbo].[SPU_Insert_AD]    Script Date: 3/14/2017 4:21:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SPU_Insert_SEP]
	-- Add the parameters for the stored procedure here
@TableName varchar(MAX),
@FilePath varchar(MAX)
AS
BEGIN
DECLARE @sql NVARCHAR(MAX)
SET @sql  = N'BULK INSERT '+@TableName+'
    FROM '''+@FilePath+'''
    WITH
    (
    FIRSTROW = 2,
	
    FIELDTERMINATOR = '','',  --CSV field delimiter
    ROWTERMINATOR = ''\n'',   --Use to shift the control to next row    
    TABLOCK
    )'

	EXEC sys.sp_executesql @sql;


END
